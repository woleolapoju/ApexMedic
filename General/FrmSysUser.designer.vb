<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSysUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSysUser))
        Me.Label3 = New System.Windows.Forms.Label
        Me.tUserID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tUsername = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tPassword = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tConfirm = New System.Windows.Forms.TextBox
        Me.RadReports = New System.Windows.Forms.RadioButton
        Me.RadModules = New System.Windows.Forms.RadioButton
        Me.chkAdmin = New System.Windows.Forms.CheckBox
        Me.ModuleDGV = New System.Windows.Forms.DataGridView
        Me.Modules = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Open = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.mNew = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.mEdit = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Browse = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.mDelete = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SendMail = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ReceiveMail = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ReportDGV = New System.Windows.Forms.DataGridView
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.PanAction = New System.Windows.Forms.FlowLayoutPanel
        Me.mnuAction = New System.Windows.Forms.MenuStrip
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBrowse = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.lblAction = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkGroup = New System.Windows.Forms.CheckBox
        Me.cStaff = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.ModuleDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "User ID:"
        '
        'tUserID
        '
        Me.tUserID.AcceptsReturn = True
        Me.tUserID.Location = New System.Drawing.Point(88, 8)
        Me.tUserID.Name = "tUserID"
        Me.tUserID.ReadOnly = True
        Me.tUserID.Size = New System.Drawing.Size(93, 20)
        Me.tUserID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Username:"
        '
        'tUsername
        '
        Me.tUsername.AcceptsReturn = True
        Me.tUsername.Location = New System.Drawing.Point(88, 31)
        Me.tUsername.Name = "tUsername"
        Me.tUsername.ReadOnly = True
        Me.tUsername.Size = New System.Drawing.Size(192, 20)
        Me.tUsername.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Password:"
        '
        'tPassword
        '
        Me.tPassword.AcceptsReturn = True
        Me.tPassword.Location = New System.Drawing.Point(88, 54)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tPassword.Size = New System.Drawing.Size(94, 20)
        Me.tPassword.TabIndex = 2
        Me.tPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Confirm Pwd:"
        '
        'tConfirm
        '
        Me.tConfirm.AcceptsReturn = True
        Me.tConfirm.Location = New System.Drawing.Point(88, 76)
        Me.tConfirm.Name = "tConfirm"
        Me.tConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tConfirm.Size = New System.Drawing.Size(94, 20)
        Me.tConfirm.TabIndex = 3
        Me.tConfirm.UseSystemPasswordChar = True
        '
        'RadReports
        '
        Me.RadReports.AutoSize = True
        Me.RadReports.BackColor = System.Drawing.Color.Transparent
        Me.RadReports.ForeColor = System.Drawing.Color.DarkRed
        Me.RadReports.Location = New System.Drawing.Point(89, 163)
        Me.RadReports.Name = "RadReports"
        Me.RadReports.Size = New System.Drawing.Size(62, 17)
        Me.RadReports.TabIndex = 33
        Me.RadReports.Text = "&Reports"
        Me.RadReports.UseVisualStyleBackColor = False
        '
        'RadModules
        '
        Me.RadModules.AutoSize = True
        Me.RadModules.BackColor = System.Drawing.Color.Transparent
        Me.RadModules.Checked = True
        Me.RadModules.ForeColor = System.Drawing.Color.DarkRed
        Me.RadModules.Location = New System.Drawing.Point(3, 163)
        Me.RadModules.Name = "RadModules"
        Me.RadModules.Size = New System.Drawing.Size(65, 17)
        Me.RadModules.TabIndex = 32
        Me.RadModules.TabStop = True
        Me.RadModules.Text = "&Modules"
        Me.RadModules.UseVisualStyleBackColor = False
        '
        'chkAdmin
        '
        Me.chkAdmin.AutoSize = True
        Me.chkAdmin.Location = New System.Drawing.Point(2, 182)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(116, 17)
        Me.chkAdmin.TabIndex = 5
        Me.chkAdmin.Text = "Administrative Role"
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'ModuleDGV
        '
        Me.ModuleDGV.AllowUserToAddRows = False
        Me.ModuleDGV.AllowUserToDeleteRows = False
        Me.ModuleDGV.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.ModuleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModuleDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Modules, Me.Open, Me.mNew, Me.mEdit, Me.Browse, Me.mDelete, Me.SendMail, Me.ReceiveMail})
        Me.ModuleDGV.Location = New System.Drawing.Point(1, 200)
        Me.ModuleDGV.MultiSelect = False
        Me.ModuleDGV.Name = "ModuleDGV"
        Me.ModuleDGV.RowHeadersWidth = 21
        Me.ModuleDGV.Size = New System.Drawing.Size(535, 402)
        Me.ModuleDGV.TabIndex = 43
        '
        'Modules
        '
        Me.Modules.Frozen = True
        Me.Modules.HeaderText = "Modules"
        Me.Modules.Name = "Modules"
        Me.Modules.ReadOnly = True
        Me.Modules.ToolTipText = "Application Modules"
        Me.Modules.Width = 165
        '
        'Open
        '
        Me.Open.HeaderText = "Open"
        Me.Open.Name = "Open"
        Me.Open.ToolTipText = "Click to Toggle Open options"
        Me.Open.Width = 45
        '
        'mNew
        '
        Me.mNew.HeaderText = "New"
        Me.mNew.Name = "mNew"
        Me.mNew.ToolTipText = "Click to Toggle New options"
        Me.mNew.Width = 45
        '
        'mEdit
        '
        Me.mEdit.HeaderText = "Edit"
        Me.mEdit.Name = "mEdit"
        Me.mEdit.ToolTipText = "Click to Toggle Edit options"
        Me.mEdit.Width = 45
        '
        'Browse
        '
        Me.Browse.HeaderText = "Browse"
        Me.Browse.Name = "Browse"
        Me.Browse.ToolTipText = "Click to Toggle browse options"
        Me.Browse.Width = 45
        '
        'mDelete
        '
        Me.mDelete.HeaderText = "Delete"
        Me.mDelete.Name = "mDelete"
        Me.mDelete.ToolTipText = "Click to Toggle Delete options"
        Me.mDelete.Width = 50
        '
        'SendMail
        '
        Me.SendMail.HeaderText = "Send Mail"
        Me.SendMail.Name = "SendMail"
        Me.SendMail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SendMail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SendMail.Width = 50
        '
        'ReceiveMail
        '
        Me.ReceiveMail.HeaderText = "Receive Mail"
        Me.ReceiveMail.Name = "ReceiveMail"
        Me.ReceiveMail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReceiveMail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ReceiveMail.Width = 55
        '
        'ReportDGV
        '
        Me.ReportDGV.AllowUserToAddRows = False
        Me.ReportDGV.AllowUserToDeleteRows = False
        Me.ReportDGV.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.ReportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1})
        Me.ReportDGV.Location = New System.Drawing.Point(1, 200)
        Me.ReportDGV.Name = "ReportDGV"
        Me.ReportDGV.Size = New System.Drawing.Size(535, 402)
        Me.ReportDGV.TabIndex = 44
        Me.ReportDGV.Visible = False
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205.0!))
        Me.tblHeader.Controls.Add(Me.Label9, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label10, 1, 1)
        Me.tblHeader.Controls.Add(Me.PanAction, 2, 0)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.Size = New System.Drawing.Size(538, 50)
        Me.tblHeader.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.GhostWhite
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(80, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(253, 27)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "SYSTEM USERS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label10.Size = New System.Drawing.Size(253, 23)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Register System Users"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAction.Location = New System.Drawing.Point(333, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(205, 50)
        Me.PanAction.TabIndex = 54
        '
        'mnuAction
        '
        Me.mnuAction.AllowMerge = False
        Me.mnuAction.BackColor = System.Drawing.Color.Transparent
        Me.mnuAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuEdit, Me.mnuBrowse, Me.mnuDelete})
        Me.mnuAction.Location = New System.Drawing.Point(0, 0)
        Me.mnuAction.Name = "mnuAction"
        Me.mnuAction.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuAction.Size = New System.Drawing.Size(189, 24)
        Me.mnuAction.TabIndex = 52
        Me.mnuAction.Text = "mnuAction"
        '
        'mnuNew
        '
        Me.mnuNew.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(40, 20)
        Me.mnuNew.Text = "New"
        '
        'mnuEdit
        '
        Me.mnuEdit.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(37, 20)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuBrowse
        '
        Me.mnuBrowse.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.mnuBrowse.Name = "mnuBrowse"
        Me.mnuBrowse.Size = New System.Drawing.Size(54, 20)
        Me.mnuBrowse.Text = "Browse"
        '
        'mnuDelete
        '
        Me.mnuDelete.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(50, 20)
        Me.mnuDelete.Text = "Delete"
        '
        'lblAction
        '
        Me.lblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.ForeColor = System.Drawing.Color.Red
        Me.lblAction.Location = New System.Drawing.Point(3, 24)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(199, 19)
        Me.lblAction.TabIndex = 11
        Me.lblAction.Text = "?"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(445, 162)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(91, 36)
        Me.cmdClose.TabIndex = 55
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(351, 162)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(93, 36)
        Me.cmdOk.TabIndex = 54
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkGroup)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tUserID)
        Me.Panel1.Controls.Add(Me.tConfirm)
        Me.Panel1.Controls.Add(Me.tUsername)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tPassword)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cStaff)
        Me.Panel1.Location = New System.Drawing.Point(2, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 104)
        Me.Panel1.TabIndex = 56
        '
        'chkGroup
        '
        Me.chkGroup.AutoSize = True
        Me.chkGroup.Location = New System.Drawing.Point(204, 10)
        Me.chkGroup.Name = "chkGroup"
        Me.chkGroup.Size = New System.Drawing.Size(55, 17)
        Me.chkGroup.TabIndex = 49
        Me.chkGroup.Text = "Group"
        Me.chkGroup.UseVisualStyleBackColor = True
        '
        'cStaff
        '
        Me.cStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cStaff.DropDownWidth = 192
        Me.cStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cStaff.FormattingEnabled = True
        Me.cStaff.Location = New System.Drawing.Point(88, 8)
        Me.cStaff.Name = "cStaff"
        Me.cStaff.Size = New System.Drawing.Size(112, 21)
        Me.cStaff.TabIndex = 48
        Me.cStaff.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(459, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Not applicable"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel2.Location = New System.Drawing.Point(445, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(14, 12)
        Me.Panel2.TabIndex = 59
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Modules"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 390
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Open"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 80
        '
        'FrmSysUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(538, 604)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadReports)
        Me.Controls.Add(Me.RadModules)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.tblHeader)
        Me.Controls.Add(Me.chkAdmin)
        Me.Controls.Add(Me.ModuleDGV)
        Me.Controls.Add(Me.ReportDGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSysUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Users"
        CType(Me.ModuleDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tConfirm As System.Windows.Forms.TextBox
    Friend WithEvents RadReports As System.Windows.Forms.RadioButton
    Friend WithEvents RadModules As System.Windows.Forms.RadioButton
    Friend WithEvents chkAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents ModuleDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ReportDGV As System.Windows.Forms.DataGridView
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cStaff As System.Windows.Forms.ComboBox
    Friend WithEvents chkGroup As System.Windows.Forms.CheckBox
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents Modules As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Open As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents mNew As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents mEdit As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Browse As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents mDelete As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SendMail As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ReceiveMail As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
