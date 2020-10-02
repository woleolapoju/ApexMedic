<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDelivery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDelivery))
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdPerformedBy = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdMedicalTeam = New System.Windows.Forms.Button
        Me.tMedicalTeam = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.lnkFinancialState = New System.Windows.Forms.LinkLabel
        Me.tPerformedBy = New System.Windows.Forms.TextBox
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.tFatherName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tRefNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PanCommands = New System.Windows.Forms.Panel
        Me.mnuCut = New System.Windows.Forms.Button
        Me.mnuOpen = New System.Windows.Forms.Button
        Me.mnuInsert = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lvList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.PanAction = New System.Windows.Forms.FlowLayoutPanel
        Me.mnuAction = New System.Windows.Forms.MenuStrip
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBrowse = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.lblAction = New System.Windows.Forms.Label
        Me.PanMainCommand.SuspendLayout()
        Me.PanHeading.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.PanCommands.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.GhostWhite
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(99, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "DELIVERY"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdPerformedBy
        '
        Me.cmdPerformedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPerformedBy.Location = New System.Drawing.Point(408, 35)
        Me.cmdPerformedBy.Name = "cmdPerformedBy"
        Me.cmdPerformedBy.Size = New System.Drawing.Size(26, 21)
        Me.cmdPerformedBy.TabIndex = 70
        Me.cmdPerformedBy.Text = "..."
        Me.cmdPerformedBy.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Medical Team:"
        '
        'cmdMedicalTeam
        '
        Me.cmdMedicalTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMedicalTeam.Location = New System.Drawing.Point(408, 59)
        Me.cmdMedicalTeam.Name = "cmdMedicalTeam"
        Me.cmdMedicalTeam.Size = New System.Drawing.Size(26, 21)
        Me.cmdMedicalTeam.TabIndex = 66
        Me.cmdMedicalTeam.Text = "..."
        Me.cmdMedicalTeam.UseVisualStyleBackColor = True
        '
        'tMedicalTeam
        '
        Me.tMedicalTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMedicalTeam.Location = New System.Drawing.Point(104, 59)
        Me.tMedicalTeam.Multiline = True
        Me.tMedicalTeam.Name = "tMedicalTeam"
        Me.tMedicalTeam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tMedicalTeam.Size = New System.Drawing.Size(302, 70)
        Me.tMedicalTeam.TabIndex = 65
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(373, 1)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(60, 39)
        Me.cmdClose.TabIndex = 251
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(312, 1)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(60, 39)
        Me.cmdOk.TabIndex = 250
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'PanMainCommand
        '
        Me.PanMainCommand.BackColor = System.Drawing.Color.LightYellow
        Me.PanMainCommand.Controls.Add(Me.lnkFinancialState)
        Me.PanMainCommand.Controls.Add(Me.cmdClose)
        Me.PanMainCommand.Controls.Add(Me.cmdOk)
        Me.PanMainCommand.Location = New System.Drawing.Point(0, 476)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(439, 41)
        Me.PanMainCommand.TabIndex = 244
        '
        'lnkFinancialState
        '
        Me.lnkFinancialState.AutoSize = True
        Me.lnkFinancialState.Location = New System.Drawing.Point(3, 14)
        Me.lnkFinancialState.Name = "lnkFinancialState"
        Me.lnkFinancialState.Size = New System.Drawing.Size(147, 13)
        Me.lnkFinancialState.TabIndex = 256
        Me.lnkFinancialState.TabStop = True
        Me.lnkFinancialState.Text = "Check Patient Financial State"
        '
        'tPerformedBy
        '
        Me.tPerformedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPerformedBy.Location = New System.Drawing.Point(104, 35)
        Me.tPerformedBy.Name = "tPerformedBy"
        Me.tPerformedBy.ReadOnly = True
        Me.tPerformedBy.Size = New System.Drawing.Size(302, 20)
        Me.tPerformedBy.TabIndex = 62
        '
        'PanHeading
        '
        Me.PanHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanHeading.Controls.Add(Me.tFatherName)
        Me.PanHeading.Controls.Add(Me.Label4)
        Me.PanHeading.Controls.Add(Me.tAccount)
        Me.PanHeading.Controls.Add(Me.Label16)
        Me.PanHeading.Controls.Add(Me.tPatientName)
        Me.PanHeading.Controls.Add(Me.Label3)
        Me.PanHeading.Controls.Add(Me.tRefNo)
        Me.PanHeading.Controls.Add(Me.Label1)
        Me.PanHeading.Controls.Add(Me.cmdPatient)
        Me.PanHeading.Controls.Add(Me.tPatientNo)
        Me.PanHeading.Location = New System.Drawing.Point(2, 60)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(433, 98)
        Me.PanHeading.TabIndex = 242
        '
        'tFatherName
        '
        Me.tFatherName.Location = New System.Drawing.Point(102, 70)
        Me.tFatherName.Name = "tFatherName"
        Me.tFatherName.Size = New System.Drawing.Size(322, 20)
        Me.tFatherName.TabIndex = 53
        Me.tFatherName.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Father's Name:"
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(102, 47)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(322, 20)
        Me.tAccount.TabIndex = 51
        Me.tAccount.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Account:"
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(208, 26)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(216, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Patient No:"
        '
        'tRefNo
        '
        Me.tRefNo.Location = New System.Drawing.Point(102, 3)
        Me.tRefNo.Name = "tRefNo"
        Me.tRefNo.ReadOnly = True
        Me.tRefNo.Size = New System.Drawing.Size(79, 20)
        Me.tRefNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ref. No:"
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(181, 25)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 7
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(102, 25)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(80, 20)
        Me.tPatientNo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Performed By:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.cmdPerformedBy)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmdMedicalTeam)
        Me.GroupBox1.Controls.Add(Me.tMedicalTeam)
        Me.GroupBox1.Controls.Add(Me.tPerformedBy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 134)
        Me.GroupBox1.TabIndex = 243
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Normal", "Surgical"})
        Me.ComboBox1.Location = New System.Drawing.Point(104, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox1.TabIndex = 248
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Delivery Type:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(99, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Maintains Delivery Information"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.tblHeader.Controls.Add(Me.Label7, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label8, 1, 1)
        Me.tblHeader.Controls.Add(Me.PanAction, 2, 0)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.Size = New System.Drawing.Size(437, 59)
        Me.tblHeader.TabIndex = 241
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
        Me.PictureBox1.Size = New System.Drawing.Size(99, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PanCommands)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 176)
        Me.GroupBox2.TabIndex = 245
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CHILDREN INFORMATION"
        '
        'PanCommands
        '
        Me.PanCommands.Controls.Add(Me.mnuCut)
        Me.PanCommands.Controls.Add(Me.mnuOpen)
        Me.PanCommands.Controls.Add(Me.mnuInsert)
        Me.PanCommands.Location = New System.Drawing.Point(4, 16)
        Me.PanCommands.Name = "PanCommands"
        Me.PanCommands.Size = New System.Drawing.Size(84, 26)
        Me.PanCommands.TabIndex = 254
        '
        'mnuCut
        '
        Me.mnuCut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuCut.Image = Global.ApexMedic.My.Resources.Resources.CUT
        Me.mnuCut.Location = New System.Drawing.Point(50, 0)
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(26, 25)
        Me.mnuCut.TabIndex = 7
        Me.mnuCut.Text = "..."
        Me.mnuCut.UseVisualStyleBackColor = True
        '
        'mnuOpen
        '
        Me.mnuOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuOpen.Image = Global.ApexMedic.My.Resources.Resources.OPEN
        Me.mnuOpen.Location = New System.Drawing.Point(25, 0)
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(26, 25)
        Me.mnuOpen.TabIndex = 6
        Me.mnuOpen.Text = "..."
        Me.mnuOpen.UseVisualStyleBackColor = True
        '
        'mnuInsert
        '
        Me.mnuInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuInsert.Image = Global.ApexMedic.My.Resources.Resources.NEW1
        Me.mnuInsert.Location = New System.Drawing.Point(0, 0)
        Me.mnuInsert.Name = "mnuInsert"
        Me.mnuInsert.Size = New System.Drawing.Size(26, 25)
        Me.mnuInsert.TabIndex = 5
        Me.mnuInsert.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lvList)
        Me.Panel1.Location = New System.Drawing.Point(4, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 158)
        Me.Panel1.TabIndex = 0
        '
        'lvList
        '
        Me.lvList.BackColor = System.Drawing.Color.GhostWhite
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        Me.lvList.Location = New System.Drawing.Point(2, 30)
        Me.lvList.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.lvList.MultiSelect = False
        Me.lvList.Name = "lvList"
        Me.lvList.ShowItemToolTips = True
        Me.lvList.Size = New System.Drawing.Size(426, 124)
        Me.lvList.TabIndex = 238
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sn"
        Me.ColumnHeader1.Width = 26
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 109
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sex"
        Me.ColumnHeader3.Width = 48
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Weight"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 54
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date"
        Me.ColumnHeader5.Width = 59
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Peculiarities"
        Me.ColumnHeader6.Width = 132
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAction.Location = New System.Drawing.Point(246, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(191, 59)
        Me.PanAction.TabIndex = 54
        '
        'mnuAction
        '
        Me.mnuAction.AllowMerge = False
        Me.mnuAction.BackColor = System.Drawing.Color.Transparent
        Me.mnuAction.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.lblAction.Size = New System.Drawing.Size(181, 19)
        Me.lblAction.TabIndex = 11
        Me.lblAction.Text = "?"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(437, 518)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PanMainCommand)
        Me.Controls.Add(Me.PanHeading)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDelivery"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery"
        Me.PanMainCommand.ResumeLayout(False)
        Me.PanMainCommand.PerformLayout()
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.PanCommands.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdPerformedBy As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdMedicalTeam As System.Windows.Forms.Button
    Friend WithEvents tMedicalTeam As System.Windows.Forms.TextBox
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
    Friend WithEvents lnkFinancialState As System.Windows.Forms.LinkLabel
    Friend WithEvents tPerformedBy As System.Windows.Forms.TextBox
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents tFatherName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanCommands As System.Windows.Forms.Panel
    Friend WithEvents mnuCut As System.Windows.Forms.Button
    Friend WithEvents mnuOpen As System.Windows.Forms.Button
    Friend WithEvents mnuInsert As System.Windows.Forms.Button
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
End Class
