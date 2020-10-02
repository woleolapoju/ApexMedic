<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSvrInfor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSvrInfor))
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
        Me.GrpAttach = New System.Windows.Forms.GroupBox
        Me.cmdAttach = New System.Windows.Forms.Button
        Me.cmdDBMain = New System.Windows.Forms.Button
        Me.txtDBName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GrpAdvance = New System.Windows.Forms.GroupBox
        Me.txtOwner = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GrpServ.SuspendLayout()
        Me.GrpAuthenticate.SuspendLayout()
        Me.GrpAttach.SuspendLayout()
        Me.GrpAdvance.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GrpServ.Location = New System.Drawing.Point(5, 53)
        Me.GrpServ.Name = "GrpServ"
        Me.GrpServ.Size = New System.Drawing.Size(228, 109)
        Me.GrpServ.TabIndex = 0
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
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Available DB:"
        '
        'txtAttachName
        '
        Me.txtAttachName.Location = New System.Drawing.Point(84, 47)
        Me.txtAttachName.Name = "txtAttachName"
        Me.txtAttachName.Size = New System.Drawing.Size(138, 20)
        Me.txtAttachName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Attached Name:"
        '
        'cboServerName
        '
        Me.cboServerName.FormattingEnabled = True
        Me.cboServerName.Location = New System.Drawing.Point(84, 18)
        Me.cboServerName.Name = "cboServerName"
        Me.cboServerName.Size = New System.Drawing.Size(138, 21)
        Me.cboServerName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
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
        Me.GrpAuthenticate.Location = New System.Drawing.Point(5, 163)
        Me.GrpAuthenticate.Name = "GrpAuthenticate"
        Me.GrpAuthenticate.Size = New System.Drawing.Size(228, 93)
        Me.GrpAuthenticate.TabIndex = 1
        Me.GrpAuthenticate.TabStop = False
        Me.GrpAuthenticate.Text = "Authentication"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(84, 64)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(138, 20)
        Me.txtPassword.TabIndex = 5
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(84, 36)
        Me.txtUserID.Name = "txtUserID"
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
        'GrpAttach
        '
        Me.GrpAttach.Controls.Add(Me.cmdAttach)
        Me.GrpAttach.Controls.Add(Me.cmdDBMain)
        Me.GrpAttach.Controls.Add(Me.txtDBName)
        Me.GrpAttach.Controls.Add(Me.Label6)
        Me.GrpAttach.Location = New System.Drawing.Point(5, 260)
        Me.GrpAttach.Name = "GrpAttach"
        Me.GrpAttach.Size = New System.Drawing.Size(228, 78)
        Me.GrpAttach.TabIndex = 2
        Me.GrpAttach.TabStop = False
        Me.GrpAttach.Text = "DB Attachment"
        '
        'cmdAttach
        '
        Me.cmdAttach.Location = New System.Drawing.Point(137, 43)
        Me.cmdAttach.Name = "cmdAttach"
        Me.cmdAttach.Size = New System.Drawing.Size(84, 26)
        Me.cmdAttach.TabIndex = 15
        Me.cmdAttach.Text = "&Attach"
        Me.cmdAttach.UseVisualStyleBackColor = True
        '
        'cmdDBMain
        '
        Me.cmdDBMain.Location = New System.Drawing.Point(200, 20)
        Me.cmdDBMain.Name = "cmdDBMain"
        Me.cmdDBMain.Size = New System.Drawing.Size(25, 19)
        Me.cmdDBMain.TabIndex = 14
        Me.cmdDBMain.Text = "..."
        Me.cmdDBMain.UseVisualStyleBackColor = True
        '
        'txtDBName
        '
        Me.txtDBName.Location = New System.Drawing.Point(82, 19)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(118, 20)
        Me.txtDBName.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "DB Filename:"
        '
        'GrpAdvance
        '
        Me.GrpAdvance.Controls.Add(Me.txtOwner)
        Me.GrpAdvance.Controls.Add(Me.Label7)
        Me.GrpAdvance.Location = New System.Drawing.Point(239, 53)
        Me.GrpAdvance.Name = "GrpAdvance"
        Me.GrpAdvance.Size = New System.Drawing.Size(212, 142)
        Me.GrpAdvance.TabIndex = 3
        Me.GrpAdvance.TabStop = False
        Me.GrpAdvance.Text = "Advance Setting"
        '
        'txtOwner
        '
        Me.txtOwner.Location = New System.Drawing.Point(50, 19)
        Me.txtOwner.Multiline = True
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOwner.Size = New System.Drawing.Size(154, 110)
        Me.txtOwner.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Owner:"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(42, 344)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(60, 37)
        Me.cmdOk.TabIndex = 4
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(123, 344)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(60, 37)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.Controls.Add(Me.Label9, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label10, 1, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.Size = New System.Drawing.Size(457, 50)
        Me.tblHeader.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.GhostWhite
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(80, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(377, 27)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "SERVER INFORMATION"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(80, 27)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(377, 23)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Change Server Setting"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PictureBox1.Size = New System.Drawing.Size(80, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FrmSvrInfor
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(457, 383)
        Me.Controls.Add(Me.tblHeader)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.GrpAdvance)
        Me.Controls.Add(Me.GrpAttach)
        Me.Controls.Add(Me.GrpAuthenticate)
        Me.Controls.Add(Me.GrpServ)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmSvrInfor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Server Information"
        Me.GrpServ.ResumeLayout(False)
        Me.GrpServ.PerformLayout()
        Me.GrpAuthenticate.ResumeLayout(False)
        Me.GrpAuthenticate.PerformLayout()
        Me.GrpAttach.ResumeLayout(False)
        Me.GrpAttach.PerformLayout()
        Me.GrpAdvance.ResumeLayout(False)
        Me.GrpAdvance.PerformLayout()
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpServ As System.Windows.Forms.GroupBox
    Friend WithEvents txtAttachName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboServerName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpAuthenticate As System.Windows.Forms.GroupBox
    Friend WithEvents chkWinAuthen As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents GrpAttach As System.Windows.Forms.GroupBox
    Friend WithEvents txtDBName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdDBMain As System.Windows.Forms.Button
    Friend WithEvents GrpAdvance As System.Windows.Forms.GroupBox
    Friend WithEvents txtOwner As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdAttach As System.Windows.Forms.Button
    Friend WithEvents cboavaliableDB As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
