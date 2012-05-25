<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.Regist = New System.Windows.Forms.CheckBox
    Me.Server = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Port = New System.Windows.Forms.NumericUpDown
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.Directory = New System.Windows.Forms.TextBox
    Me.Password = New System.Windows.Forms.TextBox
    Me.User = New System.Windows.Forms.TextBox
    Me.UsePasv = New System.Windows.Forms.CheckBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.GroupBox3 = New System.Windows.Forms.GroupBox
    Me.btCancel = New System.Windows.Forms.Button
    Me.btOk = New System.Windows.Forms.Button
    Me.btHelp = New System.Windows.Forms.Button
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.TabPage2 = New System.Windows.Forms.TabPage
    Me.TabPage3 = New System.Windows.Forms.TabPage
    Me.ComboBox1 = New System.Windows.Forms.ComboBox
    Me.CheckBox3 = New System.Windows.Forms.CheckBox
    Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
    Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
    Me.CheckBox2 = New System.Windows.Forms.CheckBox
    Me.Label7 = New System.Windows.Forms.Label
    Me.CheckBox1 = New System.Windows.Forms.CheckBox
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.shorten = New System.Windows.Forms.CheckBox
    Me.openBrowser = New System.Windows.Forms.CheckBox
    Me.Label6 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.rb0 = New System.Windows.Forms.RadioButton
    Me.Pattern = New System.Windows.Forms.TextBox
    Me.rb1 = New System.Windows.Forms.RadioButton
    CType(Me.Port, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Regist
    '
    Me.Regist.AutoSize = True
    Me.Regist.Location = New System.Drawing.Point(15, 18)
    Me.Regist.Name = "Regist"
    Me.Regist.Size = New System.Drawing.Size(222, 16)
    Me.Regist.TabIndex = 8
    Me.Regist.Text = "エクスプローラの右クリックメニューに登録(&R)"
    Me.Regist.UseVisualStyleBackColor = True
    '
    'Server
    '
    Me.Server.Location = New System.Drawing.Point(73, 18)
    Me.Server.Name = "Server"
    Me.Server.Size = New System.Drawing.Size(100, 19)
    Me.Server.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(15, 22)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(37, 12)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "サーバ:"
    '
    'Port
    '
    Me.Port.Location = New System.Drawing.Point(180, 18)
    Me.Port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
    Me.Port.Name = "Port"
    Me.Port.Size = New System.Drawing.Size(57, 19)
    Me.Port.TabIndex = 2
    Me.Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.Port.Value = New Decimal(New Integer() {21, 0, 0, 0})
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.Directory)
    Me.GroupBox1.Controls.Add(Me.Password)
    Me.GroupBox1.Controls.Add(Me.User)
    Me.GroupBox1.Controls.Add(Me.UsePasv)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.Port)
    Me.GroupBox1.Controls.Add(Me.Server)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(258, 167)
    Me.GroupBox1.TabIndex = 4
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "FTP 設定"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(14, 119)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(128, 12)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "アップロードするディレクトリ:"
    '
    'Directory
    '
    Me.Directory.Location = New System.Drawing.Point(15, 137)
    Me.Directory.Name = "Directory"
    Me.Directory.Size = New System.Drawing.Size(222, 19)
    Me.Directory.TabIndex = 5
    '
    'Password
    '
    Me.Password.Location = New System.Drawing.Point(73, 90)
    Me.Password.Name = "Password"
    Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.Password.Size = New System.Drawing.Size(131, 19)
    Me.Password.TabIndex = 4
    '
    'User
    '
    Me.User.Location = New System.Drawing.Point(73, 65)
    Me.User.Name = "User"
    Me.User.Size = New System.Drawing.Size(131, 19)
    Me.User.TabIndex = 3
    '
    'UsePasv
    '
    Me.UsePasv.AutoSize = True
    Me.UsePasv.Location = New System.Drawing.Point(73, 43)
    Me.UsePasv.Name = "UsePasv"
    Me.UsePasv.Size = New System.Drawing.Size(86, 16)
    Me.UsePasv.TabIndex = 6
    Me.UsePasv.Text = "&PASV モード"
    Me.UsePasv.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(15, 93)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(54, 12)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "パスワード:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(15, 70)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(37, 12)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "ユーザ:"
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.Regist)
    Me.GroupBox3.Location = New System.Drawing.Point(6, 179)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(258, 45)
    Me.GroupBox3.TabIndex = 8
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "右クリックメニュー"
    '
    'btCancel
    '
    Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btCancel.Location = New System.Drawing.Point(477, 279)
    Me.btCancel.Name = "btCancel"
    Me.btCancel.Size = New System.Drawing.Size(80, 23)
    Me.btCancel.TabIndex = 0
    Me.btCancel.Text = "やめる(&C)"
    Me.btCancel.UseVisualStyleBackColor = True
    '
    'btOk
    '
    Me.btOk.Location = New System.Drawing.Point(391, 279)
    Me.btOk.Name = "btOk"
    Me.btOk.Size = New System.Drawing.Size(80, 23)
    Me.btOk.TabIndex = 16
    Me.btOk.Text = "よし(&O)"
    Me.btOk.UseVisualStyleBackColor = True
    '
    'btHelp
    '
    Me.btHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btHelp.Location = New System.Drawing.Point(12, 277)
    Me.btHelp.Name = "btHelp"
    Me.btHelp.Size = New System.Drawing.Size(80, 23)
    Me.btHelp.TabIndex = 15
    Me.btHelp.Text = "ヘルプ(&H)"
    Me.btHelp.UseVisualStyleBackColor = True
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Location = New System.Drawing.Point(12, 12)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(545, 259)
    Me.TabControl1.TabIndex = 17
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.GroupBox2)
    Me.TabPage1.Controls.Add(Me.GroupBox1)
    Me.TabPage1.Controls.Add(Me.GroupBox3)
    Me.TabPage1.Location = New System.Drawing.Point(4, 21)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(537, 234)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "基本設定"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Location = New System.Drawing.Point(4, 21)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(537, 234)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "詳細設定"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.ComboBox1)
    Me.TabPage3.Controls.Add(Me.CheckBox3)
    Me.TabPage3.Controls.Add(Me.NumericUpDown2)
    Me.TabPage3.Controls.Add(Me.NumericUpDown1)
    Me.TabPage3.Controls.Add(Me.CheckBox2)
    Me.TabPage3.Controls.Add(Me.Label7)
    Me.TabPage3.Controls.Add(Me.CheckBox1)
    Me.TabPage3.Location = New System.Drawing.Point(4, 21)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage3.Size = New System.Drawing.Size(537, 234)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "拡張機能(未実装)"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'ComboBox1
    '
    Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBox1.Enabled = False
    Me.ComboBox1.FormattingEnabled = True
    Me.ComboBox1.Items.AddRange(New Object() {"JPEG - Joint Photographic Experts Group JFIF format (62)", "PNG - Multiple-image Network Graphics (libpng 1.2.44)", "GIF - CompuServe graphics interchange format", "BMP - Microsoft Windows bitmap image v3", "TIFF - Raw CCITT Group4", "HTML - Hypertext Markup Language and a client-side image map", "ICON - Microsoft icon", "TGA - Truevision Targa image", "SVG - Scalable Vector Graphics", "PICT - Apple Macintosh QuickDraw/PICT", "PDF - Portable Document Format", "XPM - Personal Icon", "PS - PostScript", "PSD - Adobe Photoshop bitmap", "XBM - X Windows system bitmap (black and white)", "XCF - GIMP image", "XPS - Microsoft XML Paper Specification"})
    Me.ComboBox1.Location = New System.Drawing.Point(17, 107)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(241, 20)
    Me.ComboBox1.TabIndex = 6
    '
    'CheckBox3
    '
    Me.CheckBox3.AutoSize = True
    Me.CheckBox3.Enabled = False
    Me.CheckBox3.Location = New System.Drawing.Point(7, 85)
    Me.CheckBox3.Name = "CheckBox3"
    Me.CheckBox3.Size = New System.Drawing.Size(189, 16)
    Me.CheckBox3.TabIndex = 5
    Me.CheckBox3.Text = "画像ファイルを次の形式に変換する"
    Me.CheckBox3.UseVisualStyleBackColor = True
    '
    'NumericUpDown2
    '
    Me.NumericUpDown2.Enabled = False
    Me.NumericUpDown2.Location = New System.Drawing.Point(162, 31)
    Me.NumericUpDown2.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
    Me.NumericUpDown2.Name = "NumericUpDown2"
    Me.NumericUpDown2.Size = New System.Drawing.Size(50, 19)
    Me.NumericUpDown2.TabIndex = 4
    Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.NumericUpDown2.Value = New Decimal(New Integer() {640, 0, 0, 0})
    '
    'NumericUpDown1
    '
    Me.NumericUpDown1.Enabled = False
    Me.NumericUpDown1.Location = New System.Drawing.Point(39, 32)
    Me.NumericUpDown1.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
    Me.NumericUpDown1.Name = "NumericUpDown1"
    Me.NumericUpDown1.Size = New System.Drawing.Size(50, 19)
    Me.NumericUpDown1.TabIndex = 3
    Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.NumericUpDown1.Value = New Decimal(New Integer() {640, 0, 0, 0})
    '
    'CheckBox2
    '
    Me.CheckBox2.AutoSize = True
    Me.CheckBox2.Checked = True
    Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBox2.Enabled = False
    Me.CheckBox2.Location = New System.Drawing.Point(16, 59)
    Me.CheckBox2.Name = "CheckBox2"
    Me.CheckBox2.Size = New System.Drawing.Size(112, 16)
    Me.CheckBox2.TabIndex = 2
    Me.CheckBox2.Text = "縦横比を維持する"
    Me.CheckBox2.UseVisualStyleBackColor = True
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Enabled = False
    Me.Label7.Location = New System.Drawing.Point(15, 35)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(243, 12)
    Me.Label7.TabIndex = 1
    Me.Label7.Text = "縦                ピクセル×横                ピクセル"
    '
    'CheckBox1
    '
    Me.CheckBox1.AutoSize = True
    Me.CheckBox1.Enabled = False
    Me.CheckBox1.Location = New System.Drawing.Point(7, 7)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(166, 16)
    Me.CheckBox1.TabIndex = 0
    Me.CheckBox1.Text = "大きい画像ファイルは縮小する"
    Me.CheckBox1.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.shorten)
    Me.GroupBox2.Controls.Add(Me.openBrowser)
    Me.GroupBox2.Controls.Add(Me.Label6)
    Me.GroupBox2.Controls.Add(Me.Label5)
    Me.GroupBox2.Controls.Add(Me.rb0)
    Me.GroupBox2.Controls.Add(Me.Pattern)
    Me.GroupBox2.Controls.Add(Me.rb1)
    Me.GroupBox2.Location = New System.Drawing.Point(270, 10)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(258, 214)
    Me.GroupBox2.TabIndex = 9
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "アップロード完了時の動作"
    '
    'shorten
    '
    Me.shorten.AutoSize = True
    Me.shorten.Location = New System.Drawing.Point(12, 170)
    Me.shorten.Name = "shorten"
    Me.shorten.Size = New System.Drawing.Size(113, 16)
    Me.shorten.TabIndex = 12
    Me.shorten.Text = "短縮URLにする(&S)"
    Me.shorten.UseVisualStyleBackColor = True
    '
    'openBrowser
    '
    Me.openBrowser.AutoSize = True
    Me.openBrowser.Location = New System.Drawing.Point(12, 192)
    Me.openBrowser.Name = "openBrowser"
    Me.openBrowser.Size = New System.Drawing.Size(135, 16)
    Me.openBrowser.TabIndex = 13
    Me.openBrowser.Text = "WWW ブラウザで開く(&B)"
    Me.openBrowser.UseVisualStyleBackColor = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(15, 113)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(198, 36)
    Me.Label6.TabIndex = 9
    Me.Label6.Text = "※ 「%1」がファイル名に置き替えられます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "例) http://****.sakura.ne.jp/temp/%1"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(10, 71)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(188, 12)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "クリップボードにコピーする URL 文字列:"
    '
    'rb0
    '
    Me.rb0.AutoSize = True
    Me.rb0.Checked = True
    Me.rb0.Location = New System.Drawing.Point(17, 23)
    Me.rb0.Name = "rb0"
    Me.rb0.Size = New System.Drawing.Size(177, 16)
    Me.rb0.TabIndex = 9
    Me.rb0.TabStop = True
    Me.rb0.Text = "URL をコピーするか問い合わせる"
    Me.rb0.UseVisualStyleBackColor = True
    '
    'Pattern
    '
    Me.Pattern.Location = New System.Drawing.Point(12, 86)
    Me.Pattern.Name = "Pattern"
    Me.Pattern.Size = New System.Drawing.Size(240, 19)
    Me.Pattern.TabIndex = 11
    '
    'rb1
    '
    Me.rb1.AutoSize = True
    Me.rb1.Location = New System.Drawing.Point(17, 45)
    Me.rb1.Name = "rb1"
    Me.rb1.Size = New System.Drawing.Size(149, 16)
    Me.rb1.TabIndex = 10
    Me.rb1.Text = "URL を自動的にコピーする"
    Me.rb1.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AcceptButton = Me.btOk
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btCancel
    Me.ClientSize = New System.Drawing.Size(573, 314)
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.btHelp)
    Me.Controls.Add(Me.btOk)
    Me.Controls.Add(Me.btCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "Form1"
    Me.Text = "mup'n 設定"
    CType(Me.Port, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage3.ResumeLayout(False)
    Me.TabPage3.PerformLayout()
    CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Regist As System.Windows.Forms.CheckBox
  Friend WithEvents Server As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Port As System.Windows.Forms.NumericUpDown
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Directory As System.Windows.Forms.TextBox
  Friend WithEvents Password As System.Windows.Forms.TextBox
  Friend WithEvents User As System.Windows.Forms.TextBox
  Friend WithEvents UsePasv As System.Windows.Forms.CheckBox
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents btCancel As System.Windows.Forms.Button
  Friend WithEvents btOk As System.Windows.Forms.Button
  Friend WithEvents btHelp As System.Windows.Forms.Button
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
  Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
  Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
  Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
  Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents shorten As System.Windows.Forms.CheckBox
  Friend WithEvents openBrowser As System.Windows.Forms.CheckBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents rb0 As System.Windows.Forms.RadioButton
  Friend WithEvents Pattern As System.Windows.Forms.TextBox
  Friend WithEvents rb1 As System.Windows.Forms.RadioButton

End Class
