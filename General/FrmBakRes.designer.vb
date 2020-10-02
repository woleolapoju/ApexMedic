<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBakRes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBakRes))
        Me.GrpServ = New System.Windows.Forms.GroupBox
        Me.cboavaliableDB = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAttachName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboServerName = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpAuthenticate = New System.Windows.Forms.GroupBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.chkWinAuthen = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GrpAction = New System.Windows.Forms.GroupBox
        Me.mnuClose = New System.Windows.Forms.Button
        Me.cmdDBMain = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.txtDBName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.OFDialog = New System.Windows.Forms.OpenFileDialog
        Me.SFDialog = New System.Windows.Forms.SaveFileDialog
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GrpServ.SuspendLayout()
        Me.GrpAuthenticate.SuspendLayout()
        Me.GrpAction.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpServ
        '
        Me.GrpServ.Controls.Add(Me.cboavaliableDB)
        Me.GrpServ.Controls.Add(Me.Label5)
        Me.GrpServ.Controls.Add(Me.txtAttachName)
        Me.GrpServ.Controls.Add(Me.Label2)
        Me.GrpServ.Controls.Add(Me.cboServerName)
        Me.GrpServ.Controls.Add(Me.Label1)
        Me.GrpServ.Enabled = False
        Me.GrpServ.Location = New System.Drawing.Point(9, 49)
        Me.GrpServ.Name = "GrpServ"
        Me.GrpServ.Size = New System.Drawing.Size(228, 75)
        Me.GrpServ.TabIndex = 1
        Me.GrpServ.TabStop = False
        Me.GrpServ.Text = "Server Infor"
        '
        'cboavaliableDB
        '
        Me.cboavaliableDB.FormattingEnabled = True
        Me.cboavaliableDB.Location = New System.Drawing.Point(84, 75)
        Me.cboavaliableDB.Name = "cboavaliableDB"
        Me.cboavaliableDB.Size = New System.Drawing.Size(138, 21)
        Me.cboavaliableDB.TabIndex = 5
        Me.cboavaliableDB.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Available DB:"
        Me.Label5.Visible = False
        '
        'txtAttachName
        '
        Me.txtAttachName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtAttachName.Location = New System.Drawing.Point(84, 47)
        Me.txtAttachName.Name = "txtAttachName"
        Me.txtAttachName.ReadOnly = True
        Me.txtAttachName.Size = New System.Drawing.Size(138, 20)
        Me.txtAttachName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Attached Name:"
        '
        'cboServerName
        '
        Me.cboServerName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboServerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboServerName.FormattingEnabled = True
        Me.cboServerName.Location = New System.Drawing.Point(84, 18)
        Me.cboServerName.Name = "cboServerName"
        Me.cboServerName.Size = New System.Drawing.Size(138, 21)
        Me.cboServerName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Name:"
        '
        'GrpAuthenticate
        '
        Me.GrpAuthenticate.Controls.Add(Me.txtPassword)
        Me.GrpAuthenticate.Controls.Add(Me.txtUserID)
        Me.GrpAuthenticate.Controls.Add(Me.chkWinAuthen)
        Me.GrpAuthenticate.Controls.Add(Me.Label3)
        Me.GrpAuthenticate.Controls.Add(Me.Label4)
        Me.GrpAuthenticate.Enabled = False
        Me.GrpAuthenticate.Location = New System.Drawing.Point(9, 125)
        Me.GrpAuthenticate.Name = "GrpAuthenticate"
        Me.GrpAuthenticate.Size = New System.Drawing.Size(228, 93)
        Me.GrpAuthenticate.TabIndex = 2
        Me.GrpAuthenticate.TabStop = False
        Me.GrpAuthenticate.Text = "Authentication"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Lavender
        Me.txtPassword.Location = New System.Drawing.Point(84, 64)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(138, 20)
        Me.txtPassword.TabIndex = 5
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.Lavender
        Me.txtUserID.Location = New System.Drawing.Point(84, 36)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(138, 20)
        Me.txtUserID.TabIndex = 4
        '
        'chkWinAuthen
        '
        Me.chkWinAuthen.AutoSize = True
        Me.chkWinAuthen.Location = New System.Drawing.Point(9, 19)
        Me.chkWinAuthen.Name = "chkWinAuthen"
        Me.chkWinAuthen.Size = New System.Drawing.Size(141, 17)
        Me.chkWinAuthen.TabIndex = 3
        Me.chkWinAuthen.Text = "Windows Authentication"
        Me.chkWinAuthen.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkWinAuthen.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User ID:"
        '
        'GrpAction
        '
        Me.GrpAction.Controls.Add(Me.mnuClose)
        Me.GrpAction.Controls.Add(Me.cmdDBMain)
        Me.GrpAction.Controls.Add(Me.cmdOk)
        Me.GrpAction.Controls.Add(Me.txtDBName)
        Me.GrpAction.Controls.Add(Me.Label6)
        Me.GrpAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpAction.Location = New System.Drawing.Point(9, 221)
        Me.GrpAction.Name = "GrpAction"
        Me.GrpAction.Size = New System.Drawing.Size(228, 92)
        Me.GrpAction.TabIndex = 3
        Me.GrpAction.TabStop = False
        Me.GrpAction.Text = "Backup Path:"
        '
        'mnuClose
        '
        Me.mnuClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuClose.Location = New System.Drawing.Point(140, 58)
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(84, 26)
        Me.mnuClose.TabIndex = 16
        Me.mnuClose.Text = "&Close"
        Me.mnuClose.UseVisualStyleBackColor = True
        '
        'cmdDBMain
        '
        Me.cmdDBMain.Location = New System.Drawing.Point(201, 33)
        Me.cmdDBMain.Name = "cmdDBMain"
        Me.cmdDBMain.Size = New System.Drawing.Size(25, 19)
        Me.cmdDBMain.TabIndex = 14
        Me.cmdDBMain.Text = "..."
        Me.cmdDBMain.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(51, 58)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(84, 26)
        Me.cmdOk.TabIndex = 15
        Me.cmdOk.Text = "&Backup"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'txtDBName
        '
        Me.txtDBName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDBName.Location = New System.Drawing.Point(9, 32)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(191, 20)
        Me.txtDBName.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Backup Filename:"
        '
        'OFDialog
        '
        Me.OFDialog.Filter = "All File Formats (*.bak)|*.bak|Backup (*.bak)|*.bak"
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.Controls.Add(Me.Label7, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label8, 1, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.Size = New System.Drawing.Size(244, 44)
        Me.tblHeader.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.GhostWhite
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(80, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "DATABASE BACKUP"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ApexMedic.My.Resources.Resources.Hospital2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.tblHeader.SetRowSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Size = New System.Drawing.Size(80, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(80, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Backup Database"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(9, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 75)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server Infor"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(84, 75)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(138, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Available DB:"
        Me.Label9.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Lavender
        Me.TextBox1.Location = New System.Drawing.Point(84, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(138, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Attached Name:"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.Lavender
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(84, 18)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(138, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Server Name:"
        '
        'FrmBakRes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(244, 318)
        Me.Controls.Add(Me.tblHeader)
        Me.Controls.Add(Me.GrpAction)
        Me.Controls.Add(Me.GrpAuthenticate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpServ)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBakRes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup"
        Me.GrpServ.ResumeLayout(False)
        Me.GrpServ.PerformLayout()
        Me.GrpAuthenticate.ResumeLayout(False)
        Me.GrpAuthenticate.PerformLayout()
        Me.GrpAction.ResumeLayout(False)
        Me.GrpAction.PerformLayout()
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpServ As System.Windows.Forms.GroupBox
    Friend WithEvents txtAttachName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboServerName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboavaliableDB As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrpAuthenticate As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents chkWinAuthen As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GrpAction As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDBMain As System.Windows.Forms.Button
    Friend WithEvents txtDBName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents mnuClose As System.Windows.Forms.Button
    Friend WithEvents OFDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
