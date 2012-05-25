<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigEditor
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigEditor))
    Me.Server = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Port = New System.Windows.Forms.NumericUpDown
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.checkFtp = New System.Windows.Forms.Button
    Me.Label4 = New System.Windows.Forms.Label
    Me.Directory = New System.Windows.Forms.TextBox
    Me.Password = New System.Windows.Forms.TextBox
    Me.User = New System.Windows.Forms.TextBox
    Me.UsePasv = New System.Windows.Forms.CheckBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.btCancel = New System.Windows.Forms.Button
    Me.btOk = New System.Windows.Forms.Button
    Me.btHelp = New System.Windows.Forms.Button
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.tpGeneral = New System.Windows.Forms.TabPage
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.Label6 = New System.Windows.Forms.Label
    Me.Pattern = New System.Windows.Forms.TextBox
    Me.tpDetail = New System.Windows.Forms.TabPage
    Me.ImageFile = New System.Windows.Forms.GroupBox
    Me.geometry = New System.Windows.Forms.TextBox
    Me.ImageFormat = New System.Windows.Forms.ComboBox
    Me.convFormat = New System.Windows.Forms.CheckBox
    Me.resize = New System.Windows.Forms.CheckBox
    Me.GroupBox3 = New System.Windows.Forms.GroupBox
    Me.Regist = New System.Windows.Forms.CheckBox
    Me.GroupBox4 = New System.Windows.Forms.GroupBox
    Me.shorten = New System.Windows.Forms.CheckBox
    Me.openBrowser = New System.Windows.Forms.CheckBox
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
    CType(Me.Port, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.tpGeneral.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.tpDetail.SuspendLayout()
    Me.ImageFile.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Server
    '
    Me.Server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Server.Location = New System.Drawing.Point(49, 18)
    Me.Server.Name = "Server"
    Me.Server.Size = New System.Drawing.Size(174, 19)
    Me.Server.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(6, 21)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(37, 12)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "サーバ:"
    '
    'Port
    '
    Me.Port.Location = New System.Drawing.Point(229, 18)
    Me.Port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
    Me.Port.Name = "Port"
    Me.Port.Size = New System.Drawing.Size(56, 19)
    Me.Port.TabIndex = 2
    Me.Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.Port.Value = New Decimal(New Integer() {21, 0, 0, 0})
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.checkFtp)
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
    Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(295, 122)
    Me.GroupBox1.TabIndex = 4
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "FTP ログイン情報"
    '
    'checkFtp
    '
    Me.checkFtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.checkFtp.Location = New System.Drawing.Point(199, 93)
    Me.checkFtp.Name = "checkFtp"
    Me.checkFtp.Size = New System.Drawing.Size(86, 23)
    Me.checkFtp.TabIndex = 11
    Me.checkFtp.Text = "確認(&V)..."
    Me.checkFtp.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(6, 71)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(56, 12)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "ディレクトリ:"
    '
    'Directory
    '
    Me.Directory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Directory.Location = New System.Drawing.Point(68, 68)
    Me.Directory.Name = "Directory"
    Me.Directory.Size = New System.Drawing.Size(217, 19)
    Me.Directory.TabIndex = 5
    '
    'Password
    '
    Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Password.Location = New System.Drawing.Point(200, 43)
    Me.Password.Name = "Password"
    Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.Password.Size = New System.Drawing.Size(85, 19)
    Me.Password.TabIndex = 4
    '
    'User
    '
    Me.User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.User.Location = New System.Drawing.Point(49, 43)
    Me.User.Name = "User"
    Me.User.Size = New System.Drawing.Size(85, 19)
    Me.User.TabIndex = 3
    '
    'UsePasv
    '
    Me.UsePasv.AutoSize = True
    Me.UsePasv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.UsePasv.Location = New System.Drawing.Point(8, 93)
    Me.UsePasv.Name = "UsePasv"
    Me.UsePasv.Size = New System.Drawing.Size(83, 16)
    Me.UsePasv.TabIndex = 6
    Me.UsePasv.Text = "&PASV モード"
    Me.UsePasv.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(140, 46)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(54, 12)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "パスワード:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(6, 46)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(37, 12)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "ユーザ:"
    '
    'btCancel
    '
    Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btCancel.Location = New System.Drawing.Point(222, 7)
    Me.btCancel.Name = "btCancel"
    Me.btCancel.Size = New System.Drawing.Size(80, 23)
    Me.btCancel.TabIndex = 0
    Me.btCancel.Text = "キャンセル(&C)"
    Me.btCancel.UseVisualStyleBackColor = True
    '
    'btOk
    '
    Me.btOk.Location = New System.Drawing.Point(136, 7)
    Me.btOk.Name = "btOk"
    Me.btOk.Size = New System.Drawing.Size(80, 23)
    Me.btOk.TabIndex = 16
    Me.btOk.Text = "&OK"
    Me.btOk.UseVisualStyleBackColor = True
    '
    'btHelp
    '
    Me.btHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btHelp.Location = New System.Drawing.Point(7, 7)
    Me.btHelp.Name = "btHelp"
    Me.btHelp.Size = New System.Drawing.Size(80, 23)
    Me.btHelp.TabIndex = 15
    Me.btHelp.Text = "ヘルプ(&H)"
    Me.btHelp.UseVisualStyleBackColor = True
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.tpGeneral)
    Me.TabControl1.Controls.Add(Me.tpDetail)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 0)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(309, 220)
    Me.TabControl1.TabIndex = 17
    '
    'tpGeneral
    '
    Me.tpGeneral.Controls.Add(Me.GroupBox2)
    Me.tpGeneral.Controls.Add(Me.GroupBox1)
    Me.tpGeneral.Location = New System.Drawing.Point(4, 21)
    Me.tpGeneral.Name = "tpGeneral"
    Me.tpGeneral.Padding = New System.Windows.Forms.Padding(3)
    Me.tpGeneral.Size = New System.Drawing.Size(301, 200)
    Me.tpGeneral.TabIndex = 0
    Me.tpGeneral.Text = "基本"
    Me.tpGeneral.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.Label6)
    Me.GroupBox2.Controls.Add(Me.Pattern)
    Me.GroupBox2.Location = New System.Drawing.Point(3, 134)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(295, 62)
    Me.GroupBox2.TabIndex = 9
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "クリップボードにコピーする HTTP URL:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(87, 40)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(198, 12)
    Me.Label6.TabIndex = 9
    Me.Label6.Text = "※ 「%1」がファイル名に置き替えられます。"
    '
    'Pattern
    '
    Me.Pattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Pattern.Location = New System.Drawing.Point(6, 18)
    Me.Pattern.Name = "Pattern"
    Me.Pattern.Size = New System.Drawing.Size(279, 19)
    Me.Pattern.TabIndex = 11
    Me.Pattern.Text = "http://www.example.com/%1"
    '
    'tpDetail
    '
    Me.tpDetail.Controls.Add(Me.ImageFile)
    Me.tpDetail.Controls.Add(Me.GroupBox3)
    Me.tpDetail.Controls.Add(Me.GroupBox4)
    Me.tpDetail.Location = New System.Drawing.Point(4, 21)
    Me.tpDetail.Name = "tpDetail"
    Me.tpDetail.Padding = New System.Windows.Forms.Padding(3)
    Me.tpDetail.Size = New System.Drawing.Size(301, 195)
    Me.tpDetail.TabIndex = 1
    Me.tpDetail.Text = "詳細"
    Me.tpDetail.UseVisualStyleBackColor = True
    '
    'ImageFile
    '
    Me.ImageFile.Controls.Add(Me.geometry)
    Me.ImageFile.Controls.Add(Me.ImageFormat)
    Me.ImageFile.Controls.Add(Me.convFormat)
    Me.ImageFile.Controls.Add(Me.resize)
    Me.ImageFile.Enabled = False
    Me.ImageFile.Location = New System.Drawing.Point(4, 106)
    Me.ImageFile.Name = "ImageFile"
    Me.ImageFile.Size = New System.Drawing.Size(294, 87)
    Me.ImageFile.TabIndex = 12
    Me.ImageFile.TabStop = False
    Me.ImageFile.Text = "画像ファイルの事前処理(ImageMagick)"
    '
    'geometry
    '
    Me.geometry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.geometry.Location = New System.Drawing.Point(187, 23)
    Me.geometry.Name = "geometry"
    Me.geometry.Size = New System.Drawing.Size(101, 19)
    Me.geometry.TabIndex = 5
    Me.geometry.Text = "600x800"
    '
    'ImageFormat
    '
    Me.ImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ImageFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ImageFormat.FormattingEnabled = True
    Me.ImageFormat.Items.AddRange(New Object() {"gif", "jpg", "pdf", "pict", "png", "psd", "tiff", "xcf", "xpm"})
    Me.ImageFormat.Location = New System.Drawing.Point(187, 51)
    Me.ImageFormat.Name = "ImageFormat"
    Me.ImageFormat.Size = New System.Drawing.Size(101, 20)
    Me.ImageFormat.Sorted = True
    Me.ImageFormat.TabIndex = 4
    '
    'convFormat
    '
    Me.convFormat.AutoSize = True
    Me.convFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.convFormat.Location = New System.Drawing.Point(14, 55)
    Me.convFormat.Name = "convFormat"
    Me.convFormat.Size = New System.Drawing.Size(148, 16)
    Me.convFormat.TabIndex = 3
    Me.convFormat.Text = "画像形式を変換(拡張子):"
    Me.convFormat.UseVisualStyleBackColor = True
    '
    'resize
    '
    Me.resize.AutoSize = True
    Me.resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.resize.Location = New System.Drawing.Point(14, 23)
    Me.resize.Name = "resize"
    Me.resize.Size = New System.Drawing.Size(105, 16)
    Me.resize.TabIndex = 0
    Me.resize.Text = "リサイズ(幅x高さ):"
    Me.resize.UseVisualStyleBackColor = True
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.Regist)
    Me.GroupBox3.Location = New System.Drawing.Point(3, 55)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(295, 45)
    Me.GroupBox3.TabIndex = 11
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "右クリックメニュー"
    '
    'Regist
    '
    Me.Regist.AutoSize = True
    Me.Regist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Regist.Location = New System.Drawing.Point(15, 18)
    Me.Regist.Name = "Regist"
    Me.Regist.Size = New System.Drawing.Size(238, 16)
    Me.Regist.TabIndex = 8
    Me.Regist.Text = "エクスプローラの右クリックメニューに登録する(&R)"
    Me.Regist.UseVisualStyleBackColor = True
    '
    'GroupBox4
    '
    Me.GroupBox4.Controls.Add(Me.shorten)
    Me.GroupBox4.Controls.Add(Me.openBrowser)
    Me.GroupBox4.Location = New System.Drawing.Point(3, 6)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Size = New System.Drawing.Size(295, 43)
    Me.GroupBox4.TabIndex = 10
    Me.GroupBox4.TabStop = False
    Me.GroupBox4.Text = "アップロード完了時の動作"
    '
    'shorten
    '
    Me.shorten.AutoSize = True
    Me.shorten.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.shorten.Location = New System.Drawing.Point(12, 18)
    Me.shorten.Name = "shorten"
    Me.shorten.Size = New System.Drawing.Size(110, 16)
    Me.shorten.TabIndex = 12
    Me.shorten.Text = "短縮URLにする(&S)"
    Me.shorten.UseVisualStyleBackColor = True
    '
    'openBrowser
    '
    Me.openBrowser.AutoSize = True
    Me.openBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.openBrowser.Location = New System.Drawing.Point(129, 18)
    Me.openBrowser.Name = "openBrowser"
    Me.openBrowser.Size = New System.Drawing.Size(132, 16)
    Me.openBrowser.TabIndex = 13
    Me.openBrowser.Text = "WWW ブラウザで開く(&B)"
    Me.openBrowser.UseVisualStyleBackColor = True
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
    Me.SplitContainer1.IsSplitterFixed = True
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.btHelp)
    Me.SplitContainer1.Panel2.Controls.Add(Me.btCancel)
    Me.SplitContainer1.Panel2.Controls.Add(Me.btOk)
    Me.SplitContainer1.Size = New System.Drawing.Size(309, 260)
    Me.SplitContainer1.SplitterDistance = 220
    Me.SplitContainer1.SplitterWidth = 1
    Me.SplitContainer1.TabIndex = 18
    '
    'ConfigEditor
    '
    Me.AcceptButton = Me.btOk
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btCancel
    Me.ClientSize = New System.Drawing.Size(309, 260)
    Me.Controls.Add(Me.SplitContainer1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "ConfigEditor"
    Me.Text = "mup'n 設定"
    CType(Me.Port, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.TabControl1.ResumeLayout(False)
    Me.tpGeneral.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.tpDetail.ResumeLayout(False)
    Me.ImageFile.ResumeLayout(False)
    Me.ImageFile.PerformLayout()
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.GroupBox4.ResumeLayout(False)
    Me.GroupBox4.PerformLayout()
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
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
  Friend WithEvents btCancel As System.Windows.Forms.Button
  Friend WithEvents btOk As System.Windows.Forms.Button
  Friend WithEvents btHelp As System.Windows.Forms.Button
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents tpGeneral As System.Windows.Forms.TabPage
  Friend WithEvents tpDetail As System.Windows.Forms.TabPage
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Pattern As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
  Friend WithEvents shorten As System.Windows.Forms.CheckBox
  Friend WithEvents openBrowser As System.Windows.Forms.CheckBox
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents checkFtp As System.Windows.Forms.Button
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents Regist As System.Windows.Forms.CheckBox
  Friend WithEvents ImageFile As System.Windows.Forms.GroupBox
  Friend WithEvents resize As System.Windows.Forms.CheckBox
  Friend WithEvents convFormat As System.Windows.Forms.CheckBox
  Friend WithEvents ImageFormat As System.Windows.Forms.ComboBox
  Friend WithEvents geometry As System.Windows.Forms.TextBox

End Class
