<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.txtUserId = New System.Windows.Forms.TextBox
        Me.txtPwd = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.SvrInfo = New System.Windows.Forms.ToolStripMenuItem
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.mnuMenu = New System.Windows.Forms.MenuStrip
        Me.SvrInfor = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblToday = New System.Windows.Forms.Label
        Me.cmdOk = New System.Windows.Forms.Button
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.lblAttemps = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tblHeader.SuspendLayout()
        Me.mnuMenu.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.ForeColor = System.Drawing.Color.SaddleBrown
        Me.UsernameLabel.Location = New System.Drawing.Point(113, 162)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(47, 23)
        Me.UsernameLabel.TabIndex = 10
        Me.UsernameLabel.Text = "&UserID"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.ForeColor = System.Drawing.Color.SaddleBrown
        Me.PasswordLabel.Location = New System.Drawing.Point(113, 188)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(59, 23)
        Me.PasswordLabel.TabIndex = 20
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUserId
        '
        Me.txtUserId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.ForeColor = System.Drawing.Color.Black
        Me.txtUserId.Location = New System.Drawing.Point(166, 164)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(99, 21)
        Me.txtUserId.TabIndex = 0
        '
        'txtPwd
        '
        Me.txtPwd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.ForeColor = System.Drawing.Color.Black
        Me.txtPwd.Location = New System.Drawing.Point(166, 190)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(98, 21)
        Me.txtPwd.TabIndex = 1
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'cmdClose
        '
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(177, 233)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(71, 26)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Close"
        '
        'SvrInfo
        '
        Me.SvrInfo.Name = "SvrInfo"
        Me.SvrInfo.Size = New System.Drawing.Size(117, 20)
        Me.SvrInfo.Text = "Server Information"
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 1
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblHeader.Controls.Add(Me.Label2, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label6, 0, 1)
        Me.tblHeader.Location = New System.Drawing.Point(508, 11)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.Size = New System.Drawing.Size(306, 44)
        Me.tblHeader.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.GhostWhite
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 24)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Pls. enter your login details"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(306, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Authenticates valid Users"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuMenu
        '
        Me.mnuMenu.BackColor = System.Drawing.Color.SandyBrown
        Me.mnuMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SvrInfor})
        Me.mnuMenu.Location = New System.Drawing.Point(5, 300)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(125, 24)
        Me.mnuMenu.TabIndex = 50
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'SvrInfor
        '
        Me.SvrInfor.BackColor = System.Drawing.Color.SandyBrown
        Me.SvrInfor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SvrInfor.Name = "SvrInfor"
        Me.SvrInfor.Size = New System.Drawing.Size(117, 20)
        Me.SvrInfor.Text = "Server Information"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(113, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 19)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Today"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblToday
        '
        Me.lblToday.BackColor = System.Drawing.Color.Transparent
        Me.lblToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToday.ForeColor = System.Drawing.Color.DarkRed
        Me.lblToday.Location = New System.Drawing.Point(115, 128)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(199, 31)
        Me.lblToday.TabIndex = 52
        Me.lblToday.Text = "Today"
        Me.lblToday.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdOk.Image = Global.ApexMedic.My.Resources.Resources.ShowLetter12
        Me.cmdOk.Location = New System.Drawing.Point(166, 215)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(101, 80)
        Me.cmdOk.TabIndex = 6
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.ApexMedic.My.Resources.Resources.AppLogo
        Me.LogoPictureBox.Location = New System.Drawing.Point(70, 4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(124, 51)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 30
        Me.LogoPictureBox.TabStop = False
        '
        'lblAttemps
        '
        Me.lblAttemps.BackColor = System.Drawing.Color.Transparent
        Me.lblAttemps.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblAttemps.Location = New System.Drawing.Point(144, 304)
        Me.lblAttemps.Name = "lblAttemps"
        Me.lblAttemps.Size = New System.Drawing.Size(202, 19)
        Me.lblAttemps.TabIndex = 53
        Me.lblAttemps.Text = "Attempts:"
        Me.lblAttemps.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAttemps.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(55, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 45)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Authenticates valid users"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ApexMedic.My.Resources.Resources.LoginPicture1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(355, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAttemps)
        Me.Controls.Add(Me.lblToday)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuMenu)
        Me.Controls.Add(Me.tblHeader)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Authentication   -   Press Esc to Close"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents SvrInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents SvrInfor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblToday As System.Windows.Forms.Label
    Friend WithEvents lblAttemps As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
