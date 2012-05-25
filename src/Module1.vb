Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO
Imports System.Web

Module Module1

  Public NL As String = Environment.NewLine
  Public NL2 As String = Environment.NewLine & Environment.NewLine

  Public c As config
  Public conffile As String
  Public dummyform As dummy
  Public confEditor As ConfigEditor
  Public convertfile As String
  Public enableConvert As Boolean = False

  Sub Main()

    ' convert.exe はあるかな？
    convertfile = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\convert.exe"
    enableConvert = IO.File.Exists(convertfile)

    ' 設定ファイルのパス
    conffile = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\mupn.config"

    ' 設定ファイルがなかった場合は、設定画面を開く
    If Not System.IO.File.Exists(conffile) Then
      c = New config
      confEditor = New ConfigEditor
      confEditor.ShowDialog()
      Exit Sub
    End If

    ' 設定ファイルの読み込み
    c = CType(fs2obj(conffile), config)

    ' アップロード対象ファイルパスが指定されていなかった場合、設定画面を開く
    If My.Application.CommandLineArgs.Count <> 1 Then
      confEditor = New ConfigEditor
      confEditor.ShowDialog()
      Exit Sub
    End If

    ' タスクトレイアイコン＋バルーンの準備
    dummyform = New dummy
    dummyform.NotifyIcon1.BalloonTipTitle = "mup'n"
    dummyform.TopMost = True
    dummyform.BringToFront()

    Dim file As String = My.Application.CommandLineArgs(0)

    ' アップロード対象ファイルの検証
    If Not System.IO.File.Exists(file) Then
      showBalloon("指定されたファイルのパスは存在しません。", ToolTipIcon.Error)
      Exit Sub
    End If

    ' 事前処理
    If enableConvert Then
      If c.resize Or c.convFormat Then
        Dim dir As String = IO.Path.GetDirectoryName(file)
        Dim basename As String = IO.Path.GetFileNameWithoutExtension(file)
        Dim ext As String = IO.Path.GetExtension(file)
        Dim args As String = ""
        Dim newfile As String = ""
        If c.resize Then args &= "-geometry " & c.geometry & " "
        If c.convFormat Then
          Dim newext As String = ""
          Select c.imageFormat
            Case 0
              newext = "gif"
            Case 1
              newext = "jpg"
            Case 2
              newext = "pdf"
            Case 3
              newext = "pict"
            Case 4
              newext = "psd"
            Case 5
              newext = "tiff"
            Case 6
              newext = "xcf"
            Case 7
              newext = "xpm"
            Case Else
              newext = ext
          End Select
          newfile = dir & "\" & basename & "_mupn." & newext
        Else
          newfile = dir & "\" & basename & "_mupn." & ext
        End If
        ' convert.exe は日本語を含むファイルパスを正しく処理ができない模様。
        args &= """" & file.Replace("\", "/") & """ """ & newfile.Replace("\", "/") & """"
        ' Exec
        Dim psi As New System.Diagnostics.ProcessStartInfo()
        psi.FileName = convertfile
        psi.RedirectStandardInput = False
        psi.RedirectStandardOutput = False
        psi.UseShellExecute = False
        psi.CreateNoWindow = True
        psi.Arguments = args
        Dim p As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
        p.WaitForExit()
        If IO.File.Exists(newfile) Then
          ' ターゲットファイルの切り替え
          file = newfile
        Else
          Throw New Exception
        End If
      End If
    End If

      ' アップロードの実行
      Dim upfilename As String = runFtp(file)

      ' エラーでした
      If upfilename.IndexOf("エラー") > 0 Then
        showBalloon(upfilename, ToolTipIcon.Error)
        Exit Sub
      End If

      ' 削除しました
      If upfilename.Length = 0 Then
        ' 削除完了
        showBalloon("サーバ " & c.server & " の " & IO.Path.GetFileName(file) & " を削除しました。")
        Exit Sub
      End If

      ' アップロード完了
      Dim url As String = c.pattern.Replace("%1", upfilename)
      ' 短縮 URL にする
      If c.shorten Then url = getHtml("http://is.gd/create.php?format=simple&url=" & url)
      ' ブラウザで開く
      If c.openBrowser Then System.Diagnostics.Process.Start(url)
      ' URL コピー
      Clipboard.SetText(url)
      ' お知らせ
      showBalloon(c.server & " に " & IO.Path.GetFileName(file) & " をアップロードしました。")

  End Sub

  Sub showBalloon(ByVal text As String, Optional ByVal icon As ToolTipIcon = ToolTipIcon.Info)
    dummyform.NotifyIcon1.BalloonTipText = text
    dummyform.NotifyIcon1.BalloonTipIcon = icon
    dummyform.NotifyIcon1.ShowBalloonTip(4000)
    System.Threading.Thread.Sleep(4000)
    dummyform.NotifyIcon1.Dispose()
  End Sub

  ' FTP
  Function runFtp(ByVal file As String) As String

    Dim upfilename As String = Path.GetFileName(file)

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
        Return upfilename
      End Try
    Catch
      upfilename = "エラー：サーバ " & c.server & ":" & c.port.ToString & " に接続できませんでした。"
      Return upfilename
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
        Return upfilename
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
        Return upfilename
      End Try
    End If
    ' URL エンコードして返す
    Return HttpUtility.UrlEncode(upfilename)
  End Function

  ' 指定した URL から HTML を持ってくる
  Function getHtml(ByVal url) As String
    Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("UTF-8")
    Dim req As WebRequest = WebRequest.Create(url)
    Dim res As WebResponse = req.GetResponse()
    Dim st As Stream = res.GetResponseStream()
    Dim sr As StreamReader = New StreamReader(st, enc)
    Dim html As String = sr.ReadToEnd()
    sr.Close()
    st.Close()
    ' 必要じゃない文字を削除して返す
    Return Regex.Replace(html, "[^a-zA-Z0-9:/\.]", "")
  End Function

  ' 設定ファイル用シリアライズ可能オブジェクト
  <Serializable()> _
    Class config
    Public server As String = ""
    Public port As UInteger = 21
    Public user As String = ""
    Public password As String = ""
    Public directory As String = ""
    Public usePasv As Boolean = False
    ' ---
    Public pattern As String = "http://example.com/%1"
    Public shorten As Boolean = False
    Public openBrowser As Boolean = False
    ' ---
    Public regist As Boolean = True
    ' ---
    Public resize As Boolean = False
    Public geometry As String = "600x800"
    Public convFormat As Boolean = False
    Public imageFormat As Integer = 3
    ' ---
    Public Function check() As Boolean
      If Not Regex.Match(server, "^[a-z][a-z0-9_\-]*(\.[a-z][a-z0-9_\-]*){1,}$|^\d{1,3}(\.\d{1,3}){3}$").Success Then
        DialogError("サーバ名が不正です。: " & server)
        Return False
      End If
      If Not Regex.Match(user, "^[a-zA-Z][a-zA-Z0-9_\-]*$").Success Then
        DialogError("ユーザ名が不正です。: " & user)
        Return False
      End If
      If c.resize Then
        If Not Regex.Match(c.geometry, "^\s*\d+x\d+\s*$").Success Then
          DialogError("リサイズは「600x800」のように入力してください。:" & c.geometry)
          Return False
        End If
      End If
      If c.convFormat Then
        If c.imageFormat < 0 Then
          DialogError("変換する画像形式を選択してください。")
          Return False
        End If
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

