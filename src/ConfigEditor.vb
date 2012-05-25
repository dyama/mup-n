Imports System.Text.RegularExpressions
Public Class ConfigEditor

  Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
    Me.Close()
  End Sub

  Private Const description As String = "mup'n でアップロード or 削除"

  Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
    ' シェルメニューレジスト
    If Regist.Checked Then
      Dim commandline As String = """" + Application.ExecutablePath + """ ""%1"""
      Dim regkey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey("*\shell\" + description + "\command")
      regkey.SetValue("", commandline)
      regkey.Close()
    Else
      Try
        Microsoft.Win32.Registry.ClassesRoot.DeleteSubKeyTree("*\shell\" & description)
      Catch
        ' キーがなければ無視
      End Try
    End If
    ' ---
    ' 設定の保存
    c.server = Server.Text
    c.port = Port.Value
    c.user = User.Text
    c.password = Password.Text
    c.directory = Regex.Replace(Directory.Text, "/$", "")
    c.usePasv = UsePasv.Checked
    c.pattern = Pattern.Text
    c.shorten = shorten.Checked
    c.openBrowser = openBrowser.Checked
    c.regist = Regist.Checked
    If enableConvert Then
      c.resize = resize.Checked
      If c.resize Then c.geometry = geometry.Text
      c.convFormat = convFormat.Checked
      If c.convFormat Then c.imageFormat = ImageFormat.SelectedIndex
    End If
    If c.check Then
      obj2fs(c, conffile)
      ' ---
      Me.Close()
    End If
  End Sub

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' 設定の復帰
    Server.Text = c.server
    Port.Value = c.port
    User.Text = c.user
    Password.Text = c.password
    Directory.Text = c.directory
    UsePasv.Checked = c.usePasv
    Pattern.Text = c.pattern
    shorten.Checked = c.shorten
    openBrowser.Checked = c.openBrowser
    Regist.Checked = c.regist
    ImageFile.Enabled = enableConvert
    If enableConvert Then
      resize.Checked = c.resize
      geometry.Text = c.geometry
      convFormat.Checked = c.convFormat
      ImageFormat.SelectedIndex = c.imageFormat
    End If
    checkftp_enable(sender, e)
  End Sub

  Private Sub btHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHelp.Click
    System.Diagnostics.Process.Start("http://dyama.chaosnet.org/index.cgi?Dist/Mup%27n")
  End Sub

  Private Sub checkFtp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFtp.Click
    System.Diagnostics.Process.Start("ftp://" & User.Text & ":" & Password.Text & "@" & Server.Text & ":" & Port.Value.ToString & "/" & Directory.Text)
  End Sub

  Private Sub checkftp_enable(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Server.TextChanged, Password.TextChanged, User.TextChanged
    checkFtp.Enabled = Server.TextLength > 0 And User.TextLength > 0 And Password.TextLength > 0
  End Sub

End Class
