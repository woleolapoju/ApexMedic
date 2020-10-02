<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSurgery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSurgery))
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.tRecommendedBy = New System.Windows.Forms.TextBox
        Me.cmdRecommededby = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.tAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.tRefNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanAction = New System.Windows.Forms.FlowLayoutPanel
        Me.mnuAction = New System.Windows.Forms.MenuStrip
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBrowse = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.lblAction = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdNewTheater = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboTheater = New System.Windows.Forms.ComboBox
        Me.cmdPerformedBy = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdMedicalTeam = New System.Windows.Forms.Button
        Me.tMedicalTeam = New System.Windows.Forms.TextBox
        Me.cmdNewSurgeryType = New System.Windows.Forms.Button
        Me.tPerformedBy = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tSurgeryType = New System.Windows.Forms.TextBox
        Me.cmdsurgeryType = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.lnkFinancialState = New System.Windows.Forms.LinkLabel
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.PanHeading.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanMainCommand.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanHeading
        '
        Me.PanHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanHeading.Controls.Add(Me.tRecommendedBy)
        Me.PanHeading.Controls.Add(Me.cmdRecommededby)
        Me.PanHeading.Controls.Add(Me.Label4)
        Me.PanHeading.Controls.Add(Me.tAccount)
        Me.PanHeading.Controls.Add(Me.Label16)
        Me.PanHeading.Controls.Add(Me.tPatientName)
        Me.PanHeading.Controls.Add(Me.Label3)
        Me.PanHeading.Controls.Add(Me.Label2)
        Me.PanHeading.Controls.Add(Me.dtpDate)
        Me.PanHeading.Controls.Add(Me.tRefNo)
        Me.PanHeading.Controls.Add(Me.Label1)
        Me.PanHeading.Controls.Add(Me.cmdPatient)
        Me.PanHeading.Controls.Add(Me.tPatientNo)
        Me.PanHeading.Location = New System.Drawing.Point(0, 60)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(433, 96)
        Me.PanHeading.TabIndex = 238
        '
        'tRecommendedBy
        '
        Me.tRecommendedBy.Location = New System.Drawing.Point(102, 69)
        Me.tRecommendedBy.Name = "tRecommendedBy"
        Me.tRecommendedBy.ReadOnly = True
        Me.tRecommendedBy.Size = New System.Drawing.Size(298, 20)
        Me.tRecommendedBy.TabIndex = 58
        Me.tRecommendedBy.TabStop = False
        '
        'cmdRecommededby
        '
        Me.cmdRecommededby.Location = New System.Drawing.Point(401, 69)
        Me.cmdRecommededby.Name = "cmdRecommededby"
        Me.cmdRecommededby.Size = New System.Drawing.Size(26, 21)
        Me.cmdRecommededby.TabIndex = 57
        Me.cmdRecommededby.Text = "..."
        Me.cmdRecommededby.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Recommended  By:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Surgery Date:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yy h.mm  tt"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(280, 2)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(146, 20)
        Me.dtpDate.TabIndex = 2
        Me.dtpDate.Tag = "RegDate"
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
        Me.tPatientNo.Size = New System.Drawing.Size(76, 20)
        Me.tPatientNo.TabIndex = 0
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
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
        Me.tblHeader.Size = New System.Drawing.Size(435, 59)
        Me.tblHeader.TabIndex = 237
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
        Me.Label7.Location = New System.Drawing.Point(95, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "SURGERY"
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
        Me.PictureBox1.Size = New System.Drawing.Size(95, 59)
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
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(95, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Maintains Surgery Information"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAction.Location = New System.Drawing.Point(245, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(190, 59)
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
        Me.mnuAction.Size = New System.Drawing.Size(188, 24)
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
        Me.lblAction.Size = New System.Drawing.Size(182, 19)
        Me.lblAction.TabIndex = 11
        Me.lblAction.Text = "?"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdNewTheater)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cboTheater)
        Me.GroupBox1.Controls.Add(Me.cmdPerformedBy)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmdMedicalTeam)
        Me.GroupBox1.Controls.Add(Me.tMedicalTeam)
        Me.GroupBox1.Controls.Add(Me.cmdNewSurgeryType)
        Me.GroupBox1.Controls.Add(Me.tPerformedBy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tSurgeryType)
        Me.GroupBox1.Controls.Add(Me.cmdsurgeryType)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 257)
        Me.GroupBox1.TabIndex = 239
        Me.GroupBox1.TabStop = False
        '
        'cmdNewTheater
        '
        Me.cmdNewTheater.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewTheater.Location = New System.Drawing.Point(288, 230)
        Me.cmdNewTheater.Name = "cmdNewTheater"
        Me.cmdNewTheater.Size = New System.Drawing.Size(34, 21)
        Me.cmdNewTheater.TabIndex = 247
        Me.cmdNewTheater.Text = "New"
        Me.cmdNewTheater.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(2, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 246
        Me.Label11.Text = "Theater Used:"
        '
        'cboTheater
        '
        Me.cboTheater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTheater.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboTheater.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTheater.FormattingEnabled = True
        Me.cboTheater.Location = New System.Drawing.Point(104, 230)
        Me.cboTheater.Name = "cboTheater"
        Me.cboTheater.Size = New System.Drawing.Size(182, 21)
        Me.cboTheater.TabIndex = 245
        '
        'cmdPerformedBy
        '
        Me.cmdPerformedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPerformedBy.Location = New System.Drawing.Point(406, 40)
        Me.cmdPerformedBy.Name = "cmdPerformedBy"
        Me.cmdPerformedBy.Size = New System.Drawing.Size(26, 21)
        Me.cmdPerformedBy.TabIndex = 70
        Me.cmdPerformedBy.Text = "..."
        Me.cmdPerformedBy.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Surgery Note:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(102, 148)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(302, 80)
        Me.TextBox1.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Medical Team:"
        '
        'cmdMedicalTeam
        '
        Me.cmdMedicalTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMedicalTeam.Location = New System.Drawing.Point(406, 64)
        Me.cmdMedicalTeam.Name = "cmdMedicalTeam"
        Me.cmdMedicalTeam.Size = New System.Drawing.Size(26, 21)
        Me.cmdMedicalTeam.TabIndex = 66
        Me.cmdMedicalTeam.Text = "..."
        Me.cmdMedicalTeam.UseVisualStyleBackColor = True
        '
        'tMedicalTeam
        '
        Me.tMedicalTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMedicalTeam.Location = New System.Drawing.Point(102, 64)
        Me.tMedicalTeam.Multiline = True
        Me.tMedicalTeam.Name = "tMedicalTeam"
        Me.tMedicalTeam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tMedicalTeam.Size = New System.Drawing.Size(302, 80)
        Me.tMedicalTeam.TabIndex = 65
        '
        'cmdNewSurgeryType
        '
        Me.cmdNewSurgeryType.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewSurgeryType.Location = New System.Drawing.Point(370, 17)
        Me.cmdNewSurgeryType.Name = "cmdNewSurgeryType"
        Me.cmdNewSurgeryType.Size = New System.Drawing.Size(34, 21)
        Me.cmdNewSurgeryType.TabIndex = 64
        Me.cmdNewSurgeryType.Text = "New"
        Me.cmdNewSurgeryType.UseVisualStyleBackColor = True
        '
        'tPerformedBy
        '
        Me.tPerformedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPerformedBy.Location = New System.Drawing.Point(102, 40)
        Me.tPerformedBy.Name = "tPerformedBy"
        Me.tPerformedBy.ReadOnly = True
        Me.tPerformedBy.Size = New System.Drawing.Size(302, 20)
        Me.tPerformedBy.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Performed By:"
        '
        'tSurgeryType
        '
        Me.tSurgeryType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSurgeryType.Location = New System.Drawing.Point(102, 18)
        Me.tSurgeryType.Name = "tSurgeryType"
        Me.tSurgeryType.ReadOnly = True
        Me.tSurgeryType.Size = New System.Drawing.Size(266, 20)
        Me.tSurgeryType.TabIndex = 61
        Me.tSurgeryType.TabStop = False
        '
        'cmdsurgeryType
        '
        Me.cmdsurgeryType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsurgeryType.Location = New System.Drawing.Point(406, 17)
        Me.cmdsurgeryType.Name = "cmdsurgeryType"
        Me.cmdsurgeryType.Size = New System.Drawing.Size(26, 21)
        Me.cmdsurgeryType.TabIndex = 60
        Me.cmdsurgeryType.Text = "..."
        Me.cmdsurgeryType.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Surgery Type:"
        '
        'PanMainCommand
        '
        Me.PanMainCommand.BackColor = System.Drawing.Color.LightYellow
        Me.PanMainCommand.Controls.Add(Me.lnkFinancialState)
        Me.PanMainCommand.Controls.Add(Me.cmdClose)
        Me.PanMainCommand.Controls.Add(Me.cmdOk)
        Me.PanMainCommand.Location = New System.Drawing.Point(0, 412)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(439, 41)
        Me.PanMainCommand.TabIndex = 240
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
        'FrmSurgery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(435, 454)
        Me.Controls.Add(Me.PanMainCommand)
        Me.Controls.Add(Me.PanHeading)
        Me.Controls.Add(Me.tblHeader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSurgery"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surgery"
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanMainCommand.ResumeLayout(False)
        Me.PanMainCommand.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents tRecommendedBy As System.Windows.Forms.TextBox
    Friend WithEvents cmdRecommededby As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNewSurgeryType As System.Windows.Forms.Button
    Friend WithEvents tPerformedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tSurgeryType As System.Windows.Forms.TextBox
    Friend WithEvents cmdsurgeryType As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdMedicalTeam As System.Windows.Forms.Button
    Friend WithEvents tMedicalTeam As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
    Friend WithEvents lnkFinancialState As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdPerformedBy As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboTheater As System.Windows.Forms.ComboBox
    Friend WithEvents cmdNewTheater As System.Windows.Forms.Button
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
End Class
