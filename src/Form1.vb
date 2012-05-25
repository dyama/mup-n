Imports System.Text.RegularExpressions
Public Class Form1

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
    c.server = Server.Text
    c.port = Port.Value
    c.user = User.Text
    c.password = Password.Text
    c.directory = Regex.Replace(Directory.Text, "/$", "")
    c.usePasv = UsePasv.Checked
    If rb0.Checked Then
      c.notifMode = 0
    ElseIf rb1.Checked Then
      c.notifMode = 1
    Else
      c.notifMode = 0
    End If
    c.pattern = Pattern.Text
    c.shorten = shorten.Checked
    c.openBrowser = openBrowser.Checked
    c.regist = Regist.Checked
    If c.check Then
      obj2fs(c, conffile)
      ' ---
      Me.Close()
    End If
  End Sub

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Server.Text = c.server
    Port.Value = c.port
    User.Text = c.user
    Password.Text = c.password
    Directory.Text = c.directory
    UsePasv.Checked = c.usePasv
    Select Case c.notifMode
      Case 0
        rb0.Checked = True
      Case 1
        rb1.Checked = True
      Case Else
        c.notifMode = 0
        rb0.Checked = True
    End Select
    Pattern.Text = c.pattern
    shorten.Checked = c.shorten
    openBrowser.Checked = c.openBrowser
    Regist.Checked = c.regist
  End Sub

  Private Sub btHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHelp.Click
    System.Diagnostics.Process.Start("http://dyama.chaosnet.org/index.cgi?Dist/Mup%27n")
  End Sub

End Class
