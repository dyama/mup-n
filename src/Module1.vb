Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO

Module Module1

  Public c As config
  Public conffile As String

  Sub Main()

    conffile = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\mupn.config"
    If System.IO.File.Exists(conffile) Then
      c = CType(fs2obj(conffile), config)
      If My.Application.CommandLineArgs.Count = 1 Then
        Dim file As String = My.Application.CommandLineArgs(0)
        If System.IO.File.Exists(file) Then
          Dim upfilename As String = runFtp(file)
          ' 完了後
          If upfilename.IndexOf("エラー") < 0 Then
            If upfilename.Length > 0 Then
              ' アップロード完了
              Dim url As String = c.pattern.Replace("%1", upfilename)
              ' 短縮 URL にする
              If c.shorten Then url = getHtml("http://is.gd/create.php?format=simple&url=" & url)
              ' ブラウザで開く
              If c.openBrowser Then System.Diagnostics.Process.Start(url)
              ' お知らせ
              Select Case c.notifMode
                Case 0
                  If DialogQuestion(IO.Path.GetFileName(file) & " をアップロードしときました。URL をコピーしますか？", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Clipboard.SetText(url)
                  End If
                Case 1
                  Clipboard.SetText(url)
                  DialogInformation(IO.Path.GetFileName(file) & " をアップロードして URL をコピーしときました。")
              End Select
            Else
              ' 削除完了
              DialogInformation("サーバの " & IO.Path.GetFileName(file) & " を削除しときました。")
            End If
          Else
            If DialogError(upfilename & Environment.NewLine & "設定画面を開きますか？", MessageBoxButtons.YesNo) = DialogResult.Yes Then
              runConfEditor()
            End If
          End If
        Else
          DialogError("アップロードするファイル名が変です。: " & My.Application.CommandLineArgs(0))
        End If
      Else
        runConfEditor()
      End If
    Else
      c = New config
      runConfEditor()
    End If

  End Sub

  ' 設定画面
  Sub runConfEditor()
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(False)
    Application.Run(New Form1())
  End Sub

  ' FTP
  Function runFtp(ByVal file As String) As String

    Dim basename As String = Path.GetFileName(file)
    Dim upfilename As String = md5sum(basename).Substring(0, 32) & Path.GetExtension(file)

    Dim u As Uri
    Dim ftp As FtpWebRequest
    Dim ftpRes As FtpWebResponse
    Dim FileExist As Boolean = False

    ' 指定されたサーバ/ディレクトリの一覧を取得してくる
    u = New Uri("ftp://" & c.server & ":" & c.port.ToString & "/" & c.directory & "/")
    ftp = CType(WebRequest.Create(u), FtpWebRequest)
    ftp.Credentials = New NetworkCredential(c.user, c.password)
    ftp.KeepAlive = False
    ftp.UsePassive = c.usePasv

    ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails
    Try
      ftpRes = CType(ftp.GetResponse(), FtpWebResponse)
      Try
        Dim sr As New StreamReader(ftpRes.GetResponseStream())
        Dim res As String = sr.ReadToEnd()
        FileExist = res.IndexOf(upfilename) > 0
        sr.Close()
        ' Console.WriteLine("{0}: {1}", ftpRes.StatusCode, ftpRes.StatusDescription)
        ftpRes.Close()
      Catch
        upfilename = "エラー：ディレクトリ " & c.directory & " は存在しないか、アクセスできません。"
      End Try
    Catch
      upfilename = "エラー：サーバ " & c.server & ":" & c.port.ToString & " に接続できませんでした。"
    End Try

    u = New Uri("ftp://" & c.server & ":" & c.port.ToString & "/" & c.directory & "/" & upfilename)
    ftp = CType(WebRequest.Create(u), FtpWebRequest)
    ftp.Credentials = New NetworkCredential(c.user, c.password)
    ftp.UseBinary = True
    ftp.KeepAlive = False      '要求の完了後に接続を閉じる
    ftp.UsePassive = c.usePasv 'PASVモード

    If FileExist Then
      ' 削除モード
      ftp.Method = WebRequestMethods.Ftp.DeleteFile
      Try
        ftpRes = CType(ftp.GetResponse(), FtpWebResponse)
        Console.WriteLine("{0}: {1}", ftpRes.StatusCode, ftpRes.StatusDescription)
        ftpRes.Close()
        upfilename = ""
      Catch
        upfilename = "エラー：サーバのファイル " & c.directory & "/" & upfilename & " を削除できませんでした。"
      End Try
    Else
      ' アップロードモード
      ftp.Method = WebRequestMethods.Ftp.UploadFile
      Try
        Dim reqStrm As System.IO.Stream = ftp.GetRequestStream()
        Dim fs As New System.IO.FileStream(file, System.IO.FileMode.Open, System.IO.FileAccess.Read)
        Dim buffer(1023) As Byte
        While True
          Dim readSize As Integer = fs.Read(buffer, 0, buffer.Length)
          If readSize = 0 Then
            Exit While
          End If
          reqStrm.Write(buffer, 0, readSize)
        End While
        fs.Close()
        reqStrm.Close()
        ftpRes = CType(ftp.GetResponse(), FtpWebResponse)
        Console.WriteLine("{0}: {1}", ftpRes.StatusCode, ftpRes.StatusDescription)
        ftpRes.Close()
      Catch
        upfilename = "エラー：ファイル " & upfilename & " を " & c.directory & " にアップロードできませんでした。"
      End Try
    End If
    Return upfilename
  End Function

  Private Function md5sum(ByVal text As String) As String
    Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(text)
    Dim md5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
    Dim bs As Byte() = md5.ComputeHash(data)
    Return BitConverter.ToString(bs).ToLower().Replace("-", "")
  End Function

  Function getHtml(ByVal url) As String
    Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("UTF-8")
    Dim req As WebRequest = WebRequest.Create(url)
    Dim res As WebResponse = req.GetResponse()
    Dim st As Stream = res.GetResponseStream()
    Dim sr As StreamReader = New StreamReader(st, enc)
    Dim html As String = sr.ReadToEnd()
    sr.Close()
    st.Close()
    Return Regex.Replace(html, "[^a-zA-Z0-9:/\.]", "")
  End Function

  <Serializable()> _
    Class config
    Public server As String = ""
    Public port As UInteger = 21
    Public user As String = ""
    Public password As String = ""
    Public directory As String = "/"
    Public usePasv As Boolean = False
    ' ---
    Public notifMode As Integer = 0
    Public pattern As String = "http://example.com/%1"
    Public shorten As Boolean = True
    Public openBrowser As Boolean = False
    ' ---
    Public regist As Boolean = False
    ' ---
    Public Function check() As Boolean
      If Not Regex.Match(server, "^[a-z][a-z0-9_\-]*(\.[a-z][a-z0-9_\-]*){1,}$|^\d{1,3}(\.\d{1,3}){3}$").Success Then
        MessageBox.Show("サーバ名がなんだか変です。: " & server)
        Return False
      End If
      If Not Regex.Match(user, "^[a-zA-Z][a-zA-Z0-9_\-]*$").Success Then
        MessageBox.Show("ユーザ名がなんだか変です。: " & user)
        Return False
      End If
      Return True
    End Function
  End Class

#Region "オブジェクトデータとバイナリファイルの相互変換"

  ' オブジェクトをファイルシステムデータに変換する
  '------------------------------------------------------------
  Public Function obj2fs(ByVal Obj As Object, ByVal Path As String) As Boolean
    Dim Result As Boolean = False
    Dim fs As New System.IO.FileStream(Path, System.IO.FileMode.Create, System.IO.FileAccess.Write)
    Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
    Try
      bf.Serialize(fs, Obj)
      Result = True
    Finally
      fs.Close()
    End Try
    Return Result
  End Function

  ' ファイルシステムデータをオブジェクトに変換する。失敗時=NULL。
  '------------------------------------------------------------
  Public Function fs2obj(ByVal Path As String) As Object
    Dim fs As New System.IO.FileStream(Path, System.IO.FileMode.Open, System.IO.FileAccess.Read)
    Dim f As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
    Dim obj As Object
    Try
      obj = f.Deserialize(fs)
    Catch
      obj = Nothing
    Finally
      fs.Close()
    End Try
    Return obj
  End Function

#End Region

  ' メッセージボックス
  '------------------------------------------------------------
  ' 情報表示       = Information
  ' 確認           = Question
  ' 操作エラー     = Warning
  ' システムエラー = Error
  ' ただし例外メッセージなどは極力 debug.print を使うこと。
  '------------------------------------------------------------
  Public Function DialogInformation(ByVal Text As String, ByVal Button As MessageBoxButtons) As DialogResult
    Return MessageBox.Show(Text, "mup'n", Button, MessageBoxIcon.Information)
  End Function
  Public Function DialogQuestion(ByVal Text As String, ByVal Button As MessageBoxButtons) As DialogResult
    Return MessageBox.Show(Text, "mup'n", Button, MessageBoxIcon.Question)
  End Function
  Public Function DialogWarning(ByVal Text As String, ByVal Button As MessageBoxButtons) As DialogResult
    Return MessageBox.Show(Text, "mup'n", Button, MessageBoxIcon.Warning)
  End Function
  Public Function DialogError(ByVal Text As String, ByVal Button As MessageBoxButtons) As DialogResult
    Return MessageBox.Show(Text, "mup'n", Button, MessageBoxIcon.Error)
  End Function
  Public Function DialogInformation(ByVal Text As String) As DialogResult
    MessageBox.Show(Text, "mup'n", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Function
  Public Function DialogWarning(ByVal Text As String) As DialogResult
    MessageBox.Show(Text, "mup'n", MessageBoxButtons.OK, MessageBoxIcon.Warning)
  End Function
  Public Function DialogError(ByVal Text As String) As DialogResult
    MessageBox.Show(Text, "mup'n", MessageBoxButtons.OK, MessageBoxIcon.Error)
  End Function

End Module

