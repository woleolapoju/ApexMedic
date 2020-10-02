<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultationSummary
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultationSummary))
        Me.Label11 = New System.Windows.Forms.Label
        Me.mnuVitalSigns = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuXRay = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuScan = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuProcedureInvest = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuConsultation = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLabInvestigation = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenu = New System.Windows.Forms.MenuStrip
        Me.mnuSurgery = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDrug = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMedicalHistory = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFinancialState = New System.Windows.Forms.ToolStripMenuItem
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.TabMenu = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.dtpPeriod = New System.Windows.Forms.DateTimePicker
        Me.cboPeriod = New System.Windows.Forms.ComboBox
        Me.lblSelectedMenu = New System.Windows.Forms.Label
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.WebBrowser = New System.Windows.Forms.WebBrowser
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.cmdExpand = New System.Windows.Forms.Button
        Me.lblMenu = New System.Windows.Forms.Label
        Me.SelColumn = New System.Windows.Forms.TextBox
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdFilter = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.PanBill = New System.Windows.Forms.Panel
        Me.tConsultationFee = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.chkGenerateBill = New System.Windows.Forms.CheckBox
        Me.mnuPrint = New System.Windows.Forms.MenuStrip
        Me.mnuPrintResult = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLastResult = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRefNo = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.PanMail = New System.Windows.Forms.Panel
        Me.mnuMail = New System.Windows.Forms.CheckBox
        Me.SplitSub = New System.Windows.Forms.SplitContainer
        Me.tblDetails = New System.Windows.Forms.TableLayoutPanel
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.cmdUnRegistered = New System.Windows.Forms.Button
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpNextVisit = New System.Windows.Forms.DateTimePicker
        Me.tConsultant = New System.Windows.Forms.TextBox
        Me.cmdConsultant = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.tAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tAge = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tSex = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.tRefNo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.cSex = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel
        Me.Label14 = New System.Windows.Forms.Label
        Me.tNote = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel
        Me.Label13 = New System.Windows.Forms.Label
        Me.tHPC = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel
        Me.Label9 = New System.Windows.Forms.Label
        Me.tPC = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel
        Me.Label15 = New System.Windows.Forms.Label
        Me.tGeneralExam = New System.Windows.Forms.TextBox
        Me.tblDiagnosis = New System.Windows.Forms.TableLayoutPanel
        Me.tDiagnosis = New System.Windows.Forms.TextBox
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.cmdNewICD = New System.Windows.Forms.Button
        Me.cmdDiagnosis = New System.Windows.Forms.Button
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.cICDCategory = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.TabHistory = New System.Windows.Forms.TabControl
        Me.TabLab = New System.Windows.Forms.TabPage
        Me.tblLab = New System.Windows.Forms.TableLayoutPanel
        Me.cmdLabTest = New System.Windows.Forms.Button
        Me.listLab = New System.Windows.Forms.ListBox
        Me.tLab = New System.Windows.Forms.TextBox
        Me.TabXray = New System.Windows.Forms.TabPage
        Me.tblXray = New System.Windows.Forms.TableLayoutPanel
        Me.cmdXrayTest = New System.Windows.Forms.Button
        Me.listXray = New System.Windows.Forms.ListBox
        Me.tXray = New System.Windows.Forms.TextBox
        Me.TabScan = New System.Windows.Forms.TabPage
        Me.tblScan = New System.Windows.Forms.TableLayoutPanel
        Me.cmdScanTest = New System.Windows.Forms.Button
        Me.listScan = New System.Windows.Forms.ListBox
        Me.tScan = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.lvMedication = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.cmdPrescription = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel
        Me.Label21 = New System.Windows.Forms.Label
        Me.tProcedure = New System.Windows.Forms.TextBox
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.lnkAppointment = New System.Windows.Forms.LinkLabel
        Me.lnkReferrals = New System.Windows.Forms.LinkLabel
        Me.chkAdmission = New System.Windows.Forms.CheckBox
        Me.lnkBed = New System.Windows.Forms.LinkLabel
        Me.SelCol = New System.Windows.Forms.NumericUpDown
        Me.lvAppointment = New System.Windows.Forms.ListView
        Me.RasDescend = New System.Windows.Forms.RadioButton
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.RadAscend = New System.Windows.Forms.RadioButton
        Me.cmdSort = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblCaption = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label22 = New System.Windows.Forms.Label
        Me.SplitMain = New System.Windows.Forms.SplitContainer
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.tFilter = New System.Windows.Forms.TextBox
        Me.lblFilter = New System.Windows.Forms.Label
        Me.PanConsultingRoom = New System.Windows.Forms.Panel
        Me.cConsultingRoom = New System.Windows.Forms.ComboBox
        Me.lblDistributeTo = New System.Windows.Forms.Label
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.PanAction = New System.Windows.Forms.FlowLayoutPanel
        Me.mnuAction = New System.Windows.Forms.MenuStrip
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBrowse = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.lblAction = New System.Windows.Forms.Label
        Me.TimAppointment = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.MainMenu.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanMainCommand.SuspendLayout()
        Me.PanBill.SuspendLayout()
        Me.mnuPrint.SuspendLayout()
        Me.PanMail.SuspendLayout()
        Me.SplitSub.Panel1.SuspendLayout()
        Me.SplitSub.Panel2.SuspendLayout()
        Me.SplitSub.SuspendLayout()
        Me.tblDetails.SuspendLayout()
        Me.PanHeading.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.tblDiagnosis.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabHistory.SuspendLayout()
        Me.TabLab.SuspendLayout()
        Me.tblLab.SuspendLayout()
        Me.TabXray.SuspendLayout()
        Me.tblXray.SuspendLayout()
        Me.TabScan.SuspendLayout()
        Me.tblScan.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.SelCol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SplitMain.Panel1.SuspendLayout()
        Me.SplitMain.Panel2.SuspendLayout()
        Me.SplitMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanConsultingRoom.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Patient No:"
        '
        'mnuVitalSigns
        '
        Me.mnuVitalSigns.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuVitalSigns.Name = "mnuVitalSigns"
        Me.mnuVitalSigns.Size = New System.Drawing.Size(131, 23)
        Me.mnuVitalSigns.Text = "Vital Signs"
        Me.mnuVitalSigns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuXRay
        '
        Me.mnuXRay.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuXRay.Name = "mnuXRay"
        Me.mnuXRay.Size = New System.Drawing.Size(131, 23)
        Me.mnuXRay.Text = "X-Ray"
        Me.mnuXRay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuScan
        '
        Me.mnuScan.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuScan.Name = "mnuScan"
        Me.mnuScan.Size = New System.Drawing.Size(131, 23)
        Me.mnuScan.Text = "Scan"
        Me.mnuScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuProcedureInvest
        '
        Me.mnuProcedureInvest.Font = New System.Drawing.Font("Segoe Print", 8.25!)
        Me.mnuProcedureInvest.Name = "mnuProcedureInvest"
        Me.mnuProcedureInvest.Size = New System.Drawing.Size(131, 23)
        Me.mnuProcedureInvest.Text = "Procedures"
        Me.mnuProcedureInvest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuConsultation
        '
        Me.mnuConsultation.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuConsultation.Name = "mnuConsultation"
        Me.mnuConsultation.Size = New System.Drawing.Size(131, 23)
        Me.mnuConsultation.Text = "Consultation"
        Me.mnuConsultation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuLabInvestigation
        '
        Me.mnuLabInvestigation.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLabInvestigation.Name = "mnuLabInvestigation"
        Me.mnuLabInvestigation.Size = New System.Drawing.Size(131, 23)
        Me.mnuLabInvestigation.Text = "Lab. Investigation"
        Me.mnuLabInvestigation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainMenu
        '
        Me.MainMenu.AllowMerge = False
        Me.MainMenu.AutoSize = False
        Me.MainMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.MainMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLabInvestigation, Me.mnuConsultation, Me.mnuVitalSigns, Me.mnuXRay, Me.mnuScan, Me.mnuProcedureInvest, Me.mnuSurgery, Me.mnuDrug, Me.mnuMedicalHistory, Me.mnuFinancialState})
        Me.MainMenu.Location = New System.Drawing.Point(3, 24)
        Me.MainMenu.Margin = New System.Windows.Forms.Padding(3)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.MainMenu.Size = New System.Drawing.Size(138, 232)
        Me.MainMenu.TabIndex = 1
        Me.MainMenu.Text = "MenuStrip1"
        '
        'mnuSurgery
        '
        Me.mnuSurgery.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSurgery.Name = "mnuSurgery"
        Me.mnuSurgery.Padding = New System.Windows.Forms.Padding(0)
        Me.mnuSurgery.Size = New System.Drawing.Size(131, 23)
        Me.mnuSurgery.Text = "Surgery"
        Me.mnuSurgery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuDrug
        '
        Me.mnuDrug.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDrug.Name = "mnuDrug"
        Me.mnuDrug.Size = New System.Drawing.Size(131, 23)
        Me.mnuDrug.Text = "Drug"
        Me.mnuDrug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuMedicalHistory
        '
        Me.mnuMedicalHistory.Font = New System.Drawing.Font("Segoe Print", 8.25!)
        Me.mnuMedicalHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuMedicalHistory.Name = "mnuMedicalHistory"
        Me.mnuMedicalHistory.Size = New System.Drawing.Size(131, 23)
        Me.mnuMedicalHistory.Text = "Medical History"
        Me.mnuMedicalHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuFinancialState
        '
        Me.mnuFinancialState.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuFinancialState.Name = "mnuFinancialState"
        Me.mnuFinancialState.Size = New System.Drawing.Size(131, 23)
        Me.mnuFinancialState.Text = "Financial State"
        Me.mnuFinancialState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TabMenu, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(166, 643)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TabMenu
        '
        Me.TabMenu.ColumnCount = 1
        Me.TabMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TabMenu.Controls.Add(Me.MainMenu, 0, 1)
        Me.TabMenu.Controls.Add(Me.Label1, 0, 0)
        Me.TabMenu.Controls.Add(Me.Panel4, 0, 2)
        Me.TabMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMenu.Location = New System.Drawing.Point(0, 0)
        Me.TabMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.TabMenu.Name = "TabMenu"
        Me.TabMenu.RowCount = 3
        Me.TabMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TabMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TabMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TabMenu.Size = New System.Drawing.Size(166, 302)
        Me.TabMenu.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightYellow
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Relevant Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightYellow
        Me.Panel4.Controls.Add(Me.dtpPeriod)
        Me.Panel4.Controls.Add(Me.cboPeriod)
        Me.Panel4.Controls.Add(Me.lblSelectedMenu)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 262)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(166, 37)
        Me.Panel4.TabIndex = 2
        '
        'dtpPeriod
        '
        Me.dtpPeriod.CustomFormat = "dd-MMM-yy"
        Me.dtpPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriod.Location = New System.Drawing.Point(69, 14)
        Me.dtpPeriod.Name = "dtpPeriod"
        Me.dtpPeriod.Size = New System.Drawing.Size(72, 18)
        Me.dtpPeriod.TabIndex = 2
        '
        'cboPeriod
        '
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboPeriod.FormattingEnabled = True
        Me.cboPeriod.Items.AddRange(New Object() {"Last", "Today"})
        Me.cboPeriod.Location = New System.Drawing.Point(0, 15)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(64, 21)
        Me.cboPeriod.TabIndex = 1
        '
        'lblSelectedMenu
        '
        Me.lblSelectedMenu.AutoSize = True
        Me.lblSelectedMenu.Location = New System.Drawing.Point(-1, -1)
        Me.lblSelectedMenu.Name = "lblSelectedMenu"
        Me.lblSelectedMenu.Size = New System.Drawing.Size(10, 13)
        Me.lblSelectedMenu.TabIndex = 0
        Me.lblSelectedMenu.Text = "."
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.WebBrowser, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 302)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(166, 341)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'WebBrowser
        '
        Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser.Location = New System.Drawing.Point(3, 32)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(160, 306)
        Me.WebBrowser.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightYellow
        Me.Panel5.Controls.Add(Me.cmdPrint)
        Me.Panel5.Controls.Add(Me.cmdExpand)
        Me.Panel5.Controls.Add(Me.lblMenu)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(160, 23)
        Me.Panel5.TabIndex = 3
        '
        'cmdExpand
        '
        Me.cmdExpand.Location = New System.Drawing.Point(1, 0)
        Me.cmdExpand.Name = "cmdExpand"
        Me.cmdExpand.Size = New System.Drawing.Size(62, 21)
        Me.cmdExpand.TabIndex = 1
        Me.cmdExpand.Text = "&Expand"
        Me.cmdExpand.UseVisualStyleBackColor = True
        '
        'lblMenu
        '
        Me.lblMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMenu.Location = New System.Drawing.Point(0, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(160, 23)
        Me.lblMenu.TabIndex = 2
        Me.lblMenu.Text = "."
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMenu.Visible = False
        '
        'SelColumn
        '
        Me.SelColumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelColumn.Location = New System.Drawing.Point(44, 8)
        Me.SelColumn.Name = "SelColumn"
        Me.SelColumn.Size = New System.Drawing.Size(24, 20)
        Me.SelColumn.TabIndex = 16
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Sex"
        Me.ColumnHeader12.Width = 45
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Age"
        Me.ColumnHeader11.Width = 34
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Patient No"
        Me.ColumnHeader7.Width = 65
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Account"
        Me.ColumnHeader10.Width = 121
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Surname"
        Me.ColumnHeader8.Width = 75
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Othernames"
        Me.ColumnHeader9.Width = 97
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(178, 58)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(28, 19)
        Me.lblCount.TabIndex = 13
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "List Count:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdFilter
        '
        Me.cmdFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilter.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdFilter.Location = New System.Drawing.Point(118, 4)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(36, 27)
        Me.cmdFilter.TabIndex = 11
        Me.cmdFilter.Text = "F&ilter"
        Me.cmdFilter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "S&ort Order:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanMainCommand
        '
        Me.PanMainCommand.BackColor = System.Drawing.Color.LightYellow
        Me.PanMainCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanMainCommand.Controls.Add(Me.PanBill)
        Me.PanMainCommand.Controls.Add(Me.mnuPrint)
        Me.PanMainCommand.Controls.Add(Me.cmdClose)
        Me.PanMainCommand.Controls.Add(Me.cmdOk)
        Me.PanMainCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMainCommand.Location = New System.Drawing.Point(0, 83)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(707, 43)
        Me.PanMainCommand.TabIndex = 59
        '
        'PanBill
        '
        Me.PanBill.BackColor = System.Drawing.Color.Lavender
        Me.PanBill.Controls.Add(Me.tConsultationFee)
        Me.PanBill.Controls.Add(Me.Label23)
        Me.PanBill.Controls.Add(Me.chkGenerateBill)
        Me.PanBill.Location = New System.Drawing.Point(159, 6)
        Me.PanBill.Name = "PanBill"
        Me.PanBill.Size = New System.Drawing.Size(271, 30)
        Me.PanBill.TabIndex = 258
        '
        'tConsultationFee
        '
        Me.tConsultationFee.Location = New System.Drawing.Point(194, 5)
        Me.tConsultationFee.Name = "tConsultationFee"
        Me.tConsultationFee.Size = New System.Drawing.Size(72, 20)
        Me.tConsultationFee.TabIndex = 7
        Me.tConsultationFee.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(104, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(89, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Consultation Fee:"
        '
        'chkGenerateBill
        '
        Me.chkGenerateBill.AutoSize = True
        Me.chkGenerateBill.Checked = True
        Me.chkGenerateBill.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGenerateBill.ForeColor = System.Drawing.Color.Maroon
        Me.chkGenerateBill.Location = New System.Drawing.Point(3, 8)
        Me.chkGenerateBill.Name = "chkGenerateBill"
        Me.chkGenerateBill.Size = New System.Drawing.Size(86, 17)
        Me.chkGenerateBill.TabIndex = 0
        Me.chkGenerateBill.TabStop = False
        Me.chkGenerateBill.Text = "Generate Bill"
        Me.chkGenerateBill.UseVisualStyleBackColor = True
        '
        'mnuPrint
        '
        Me.mnuPrint.AllowMerge = False
        Me.mnuPrint.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.mnuPrint.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuPrint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintResult})
        Me.mnuPrint.Location = New System.Drawing.Point(4, 9)
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(95, 24)
        Me.mnuPrint.TabIndex = 257
        Me.mnuPrint.Text = "MenuStrip1"
        '
        'mnuPrintResult
        '
        Me.mnuPrintResult.BackColor = System.Drawing.Color.Transparent
        Me.mnuPrintResult.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLastResult, Me.mnuRefNo})
        Me.mnuPrintResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPrintResult.ForeColor = System.Drawing.Color.Brown
        Me.mnuPrintResult.Name = "mnuPrintResult"
        Me.mnuPrintResult.Size = New System.Drawing.Size(87, 20)
        Me.mnuPrintResult.Text = "Print Details"
        Me.mnuPrintResult.ToolTipText = "Print Consultation Details"
        '
        'mnuLastResult
        '
        Me.mnuLastResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLastResult.ForeColor = System.Drawing.Color.Brown
        Me.mnuLastResult.Name = "mnuLastResult"
        Me.mnuLastResult.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuLastResult.Size = New System.Drawing.Size(185, 22)
        Me.mnuLastResult.Text = "Last Consultation"
        Me.mnuLastResult.ToolTipText = "Print Last Consultation Details"
        '
        'mnuRefNo
        '
        Me.mnuRefNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuRefNo.ForeColor = System.Drawing.Color.Brown
        Me.mnuRefNo.Name = "mnuRefNo"
        Me.mnuRefNo.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuRefNo.Size = New System.Drawing.Size(185, 22)
        Me.mnuRefNo.Text = "Use Ref. No"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(571, 1)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(71, 38)
        Me.cmdClose.TabIndex = 251
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(498, 1)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(72, 38)
        Me.cmdOk.TabIndex = 250
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'PanMail
        '
        Me.PanMail.Controls.Add(Me.mnuMail)
        Me.PanMail.Location = New System.Drawing.Point(547, 51)
        Me.PanMail.Name = "PanMail"
        Me.PanMail.Size = New System.Drawing.Size(134, 20)
        Me.PanMail.TabIndex = 253
        '
        'mnuMail
        '
        Me.mnuMail.AutoSize = True
        Me.mnuMail.Location = New System.Drawing.Point(1, 2)
        Me.mnuMail.Name = "mnuMail"
        Me.mnuMail.Size = New System.Drawing.Size(136, 17)
        Me.mnuMail.TabIndex = 0
        Me.mnuMail.Text = "Mail record after saving"
        Me.mnuMail.UseVisualStyleBackColor = True
        '
        'SplitSub
        '
        Me.SplitSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitSub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitSub.Location = New System.Drawing.Point(0, 0)
        Me.SplitSub.Name = "SplitSub"
        '
        'SplitSub.Panel1
        '
        Me.SplitSub.Panel1.Controls.Add(Me.tblDetails)
        '
        'SplitSub.Panel2
        '
        Me.SplitSub.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitSub.Size = New System.Drawing.Size(881, 645)
        Me.SplitSub.SplitterDistance = 709
        Me.SplitSub.TabIndex = 0
        '
        'tblDetails
        '
        Me.tblDetails.ColumnCount = 1
        Me.tblDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDetails.Controls.Add(Me.PanMainCommand, 0, 1)
        Me.tblDetails.Controls.Add(Me.PanHeading, 0, 0)
        Me.tblDetails.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.tblDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDetails.Location = New System.Drawing.Point(0, 0)
        Me.tblDetails.Name = "tblDetails"
        Me.tblDetails.RowCount = 3
        Me.tblDetails.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDetails.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDetails.Size = New System.Drawing.Size(707, 643)
        Me.tblDetails.TabIndex = 0
        '
        'PanHeading
        '
        Me.PanHeading.Controls.Add(Me.cmdUnRegistered)
        Me.PanHeading.Controls.Add(Me.cmdPatient)
        Me.PanHeading.Controls.Add(Me.Label12)
        Me.PanHeading.Controls.Add(Me.PanMail)
        Me.PanHeading.Controls.Add(Me.dtpNextVisit)
        Me.PanHeading.Controls.Add(Me.tConsultant)
        Me.PanHeading.Controls.Add(Me.cmdConsultant)
        Me.PanHeading.Controls.Add(Me.Label18)
        Me.PanHeading.Controls.Add(Me.tAccount)
        Me.PanHeading.Controls.Add(Me.Label16)
        Me.PanHeading.Controls.Add(Me.tAge)
        Me.PanHeading.Controls.Add(Me.Label6)
        Me.PanHeading.Controls.Add(Me.tSex)
        Me.PanHeading.Controls.Add(Me.Label5)
        Me.PanHeading.Controls.Add(Me.tPatientName)
        Me.PanHeading.Controls.Add(Me.Label4)
        Me.PanHeading.Controls.Add(Me.Label7)
        Me.PanHeading.Controls.Add(Me.dtpDate)
        Me.PanHeading.Controls.Add(Me.tRefNo)
        Me.PanHeading.Controls.Add(Me.Label8)
        Me.PanHeading.Controls.Add(Me.tPatientNo)
        Me.PanHeading.Controls.Add(Me.Label11)
        Me.PanHeading.Controls.Add(Me.cSex)
        Me.PanHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanHeading.Location = New System.Drawing.Point(3, 3)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(701, 77)
        Me.PanHeading.TabIndex = 57
        '
        'cmdUnRegistered
        '
        Me.cmdUnRegistered.Location = New System.Drawing.Point(174, 6)
        Me.cmdUnRegistered.Name = "cmdUnRegistered"
        Me.cmdUnRegistered.Size = New System.Drawing.Size(31, 21)
        Me.cmdUnRegistered.TabIndex = 255
        Me.cmdUnRegistered.Text = "OP"
        Me.ToolTip1.SetToolTip(Me.cmdUnRegistered, "Unregistered Patients")
        Me.cmdUnRegistered.UseVisualStyleBackColor = True
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(148, 6)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 66
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(341, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Next Visit Date:"
        '
        'dtpNextVisit
        '
        Me.dtpNextVisit.Checked = False
        Me.dtpNextVisit.CustomFormat = "dd-MMM-yyyy"
        Me.dtpNextVisit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNextVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNextVisit.Location = New System.Drawing.Point(420, 50)
        Me.dtpNextVisit.Name = "dtpNextVisit"
        Me.dtpNextVisit.ShowCheckBox = True
        Me.dtpNextVisit.Size = New System.Drawing.Size(121, 20)
        Me.dtpNextVisit.TabIndex = 62
        Me.dtpNextVisit.Tag = "RegDate"
        '
        'tConsultant
        '
        Me.tConsultant.Location = New System.Drawing.Point(76, 51)
        Me.tConsultant.Name = "tConsultant"
        Me.tConsultant.ReadOnly = True
        Me.tConsultant.Size = New System.Drawing.Size(239, 20)
        Me.tConsultant.TabIndex = 61
        Me.tConsultant.TabStop = False
        '
        'cmdConsultant
        '
        Me.cmdConsultant.Location = New System.Drawing.Point(314, 52)
        Me.cmdConsultant.Name = "cmdConsultant"
        Me.cmdConsultant.Size = New System.Drawing.Size(26, 21)
        Me.cmdConsultant.TabIndex = 60
        Me.cmdConsultant.Text = "..."
        Me.cmdConsultant.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(2, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Consultant:"
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(391, 29)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(276, 20)
        Me.tAccount.TabIndex = 51
        Me.tAccount.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(340, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Account:"
        '
        'tAge
        '
        Me.tAge.BackColor = System.Drawing.Color.White
        Me.tAge.Location = New System.Drawing.Point(635, 6)
        Me.tAge.Name = "tAge"
        Me.tAge.Size = New System.Drawing.Size(32, 20)
        Me.tAge.TabIndex = 49
        Me.tAge.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(610, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Age:"
        '
        'tSex
        '
        Me.tSex.BackColor = System.Drawing.Color.White
        Me.tSex.Location = New System.Drawing.Point(548, 6)
        Me.tSex.Name = "tSex"
        Me.tSex.ReadOnly = True
        Me.tSex.Size = New System.Drawing.Size(46, 20)
        Me.tSex.TabIndex = 47
        Me.tSex.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(522, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Sex:"
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(76, 28)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(262, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Patient Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(341, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Date:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yy h.mm  tt"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(377, 5)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(140, 20)
        Me.dtpDate.TabIndex = 42
        Me.dtpDate.Tag = "RegDate"
        '
        'tRefNo
        '
        Me.tRefNo.Location = New System.Drawing.Point(250, 7)
        Me.tRefNo.Name = "tRefNo"
        Me.tRefNo.ReadOnly = True
        Me.tRefNo.Size = New System.Drawing.Size(87, 20)
        Me.tRefNo.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(205, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Ref. No:"
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(76, 6)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(72, 20)
        Me.tPatientNo.TabIndex = 6
        '
        'cSex
        '
        Me.cSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cSex.FormattingEnabled = True
        Me.cSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cSex.Location = New System.Drawing.Point(548, 6)
        Me.cSex.Name = "cSex"
        Me.cSex.Size = New System.Drawing.Size(62, 21)
        Me.cSex.TabIndex = 254
        Me.cSex.Tag = "Sex"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel8, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel7, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel9, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.tblDiagnosis, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel6, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel10, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel11, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel8, 0, 4)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 129)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.97712!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.59238!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.4305!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(701, 511)
        Me.TableLayoutPanel5.TabIndex = 60
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.tNote, 0, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(354, 382)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(343, 100)
        Me.TableLayoutPanel8.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightYellow
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(343, 21)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "NOTES"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tNote
        '
        Me.tNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tNote.Location = New System.Drawing.Point(3, 24)
        Me.tNote.Multiline = True
        Me.tNote.Name = "tNote"
        Me.tNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tNote.Size = New System.Drawing.Size(337, 73)
        Me.tNote.TabIndex = 5
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.tHPC, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(354, 4)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(343, 127)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightYellow
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(343, 21)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "HISTORY PRESENTING COMPLAINT"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tHPC
        '
        Me.tHPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tHPC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tHPC.Location = New System.Drawing.Point(3, 24)
        Me.tHPC.Multiline = True
        Me.tHPC.Name = "tHPC"
        Me.tHPC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tHPC.Size = New System.Drawing.Size(337, 100)
        Me.tHPC.TabIndex = 5
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.tPC, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(343, 127)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightYellow
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(343, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "PRESENTING COMPLAINT"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tPC
        '
        Me.tPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tPC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tPC.Location = New System.Drawing.Point(3, 23)
        Me.tPC.Multiline = True
        Me.tPC.Name = "tPC"
        Me.tPC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tPC.Size = New System.Drawing.Size(337, 101)
        Me.tPC.TabIndex = 5
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.tGeneralExam, 0, 1)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(4, 138)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(343, 115)
        Me.TableLayoutPanel9.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.LightYellow
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(343, 21)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "EXAMINATION"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tGeneralExam
        '
        Me.tGeneralExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tGeneralExam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tGeneralExam.Location = New System.Drawing.Point(3, 24)
        Me.tGeneralExam.Multiline = True
        Me.tGeneralExam.Name = "tGeneralExam"
        Me.tGeneralExam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tGeneralExam.Size = New System.Drawing.Size(337, 88)
        Me.tGeneralExam.TabIndex = 5
        '
        'tblDiagnosis
        '
        Me.tblDiagnosis.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblDiagnosis.ColumnCount = 2
        Me.tblDiagnosis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDiagnosis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblDiagnosis.Controls.Add(Me.tDiagnosis, 0, 1)
        Me.tblDiagnosis.Controls.Add(Me.Panel10, 1, 1)
        Me.tblDiagnosis.Controls.Add(Me.Panel7, 0, 0)
        Me.tblDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDiagnosis.Location = New System.Drawing.Point(351, 135)
        Me.tblDiagnosis.Margin = New System.Windows.Forms.Padding(0)
        Me.tblDiagnosis.Name = "tblDiagnosis"
        Me.tblDiagnosis.RowCount = 2
        Me.tblDiagnosis.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDiagnosis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDiagnosis.Size = New System.Drawing.Size(349, 121)
        Me.tblDiagnosis.TabIndex = 5
        '
        'tDiagnosis
        '
        Me.tDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tDiagnosis.Location = New System.Drawing.Point(4, 27)
        Me.tDiagnosis.Multiline = True
        Me.tDiagnosis.Name = "tDiagnosis"
        Me.tDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tDiagnosis.Size = New System.Drawing.Size(298, 90)
        Me.tDiagnosis.TabIndex = 3
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.cmdNewICD)
        Me.Panel10.Controls.Add(Me.cmdDiagnosis)
        Me.Panel10.Location = New System.Drawing.Point(309, 27)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(36, 90)
        Me.Panel10.TabIndex = 4
        '
        'cmdNewICD
        '
        Me.cmdNewICD.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewICD.Location = New System.Drawing.Point(-1, 30)
        Me.cmdNewICD.Name = "cmdNewICD"
        Me.cmdNewICD.Size = New System.Drawing.Size(37, 26)
        Me.cmdNewICD.TabIndex = 62
        Me.cmdNewICD.Text = "New"
        Me.cmdNewICD.UseVisualStyleBackColor = True
        '
        'cmdDiagnosis
        '
        Me.cmdDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiagnosis.Location = New System.Drawing.Point(0, 0)
        Me.cmdDiagnosis.Name = "cmdDiagnosis"
        Me.cmdDiagnosis.Size = New System.Drawing.Size(36, 24)
        Me.cmdDiagnosis.TabIndex = 61
        Me.cmdDiagnosis.Text = "..."
        Me.cmdDiagnosis.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.tblDiagnosis.SetColumnSpan(Me.Panel7, 2)
        Me.Panel7.Controls.Add(Me.cICDCategory)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(1, 1)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(347, 22)
        Me.Panel7.TabIndex = 5
        '
        'cICDCategory
        '
        Me.cICDCategory.Dock = System.Windows.Forms.DockStyle.Right
        Me.cICDCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cICDCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cICDCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cICDCategory.FormattingEnabled = True
        Me.cICDCategory.Items.AddRange(New Object() {"Last", "Today"})
        Me.cICDCategory.Location = New System.Drawing.Point(177, 0)
        Me.cICDCategory.Name = "cICDCategory"
        Me.cICDCategory.Size = New System.Drawing.Size(170, 20)
        Me.cICDCategory.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.LightYellow
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Margin = New System.Windows.Forms.Padding(0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 22)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "DIAGNOSIS"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.TabHistory)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(4, 260)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(343, 115)
        Me.Panel6.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.Color.LightYellow
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label20.Location = New System.Drawing.Point(152, 2)
        Me.Label20.Margin = New System.Windows.Forms.Padding(0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(198, 18)
        Me.Label20.TabIndex = 268
        Me.Label20.Text = "INVESTIGATIONS"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabHistory
        '
        Me.TabHistory.Controls.Add(Me.TabLab)
        Me.TabHistory.Controls.Add(Me.TabXray)
        Me.TabHistory.Controls.Add(Me.TabScan)
        Me.TabHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabHistory.Location = New System.Drawing.Point(0, 0)
        Me.TabHistory.Name = "TabHistory"
        Me.TabHistory.SelectedIndex = 0
        Me.TabHistory.Size = New System.Drawing.Size(343, 115)
        Me.TabHistory.TabIndex = 267
        '
        'TabLab
        '
        Me.TabLab.Controls.Add(Me.tblLab)
        Me.TabLab.Controls.Add(Me.tLab)
        Me.TabLab.Location = New System.Drawing.Point(4, 22)
        Me.TabLab.Name = "TabLab"
        Me.TabLab.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLab.Size = New System.Drawing.Size(335, 89)
        Me.TabLab.TabIndex = 0
        Me.TabLab.Text = "Laboratory"
        Me.TabLab.UseVisualStyleBackColor = True
        '
        'tblLab
        '
        Me.tblLab.ColumnCount = 2
        Me.tblLab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblLab.Controls.Add(Me.cmdLabTest, 1, 0)
        Me.tblLab.Controls.Add(Me.listLab, 0, 0)
        Me.tblLab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblLab.Location = New System.Drawing.Point(3, 3)
        Me.tblLab.Margin = New System.Windows.Forms.Padding(0)
        Me.tblLab.Name = "tblLab"
        Me.tblLab.RowCount = 1
        Me.tblLab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLab.Size = New System.Drawing.Size(329, 83)
        Me.tblLab.TabIndex = 5
        '
        'cmdLabTest
        '
        Me.cmdLabTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLabTest.Location = New System.Drawing.Point(298, 3)
        Me.cmdLabTest.Name = "cmdLabTest"
        Me.cmdLabTest.Size = New System.Drawing.Size(28, 24)
        Me.cmdLabTest.TabIndex = 62
        Me.cmdLabTest.Text = "..."
        Me.ToolTip1.SetToolTip(Me.cmdLabTest, "Load Request Form")
        Me.cmdLabTest.UseVisualStyleBackColor = True
        '
        'listLab
        '
        Me.listLab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listLab.FormattingEnabled = True
        Me.listLab.Location = New System.Drawing.Point(0, 0)
        Me.listLab.Margin = New System.Windows.Forms.Padding(0)
        Me.listLab.Name = "listLab"
        Me.listLab.Size = New System.Drawing.Size(295, 82)
        Me.listLab.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.listLab, "Double click to remove Test")
        '
        'tLab
        '
        Me.tLab.BackColor = System.Drawing.Color.White
        Me.tLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tLab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLab.Location = New System.Drawing.Point(3, 3)
        Me.tLab.Multiline = True
        Me.tLab.Name = "tLab"
        Me.tLab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tLab.Size = New System.Drawing.Size(329, 83)
        Me.tLab.TabIndex = 1
        '
        'TabXray
        '
        Me.TabXray.Controls.Add(Me.tblXray)
        Me.TabXray.Controls.Add(Me.tXray)
        Me.TabXray.Location = New System.Drawing.Point(4, 22)
        Me.TabXray.Name = "TabXray"
        Me.TabXray.Padding = New System.Windows.Forms.Padding(3)
        Me.TabXray.Size = New System.Drawing.Size(326, 89)
        Me.TabXray.TabIndex = 4
        Me.TabXray.Text = "Xray"
        Me.TabXray.UseVisualStyleBackColor = True
        '
        'tblXray
        '
        Me.tblXray.ColumnCount = 2
        Me.tblXray.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblXray.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblXray.Controls.Add(Me.cmdXrayTest, 1, 0)
        Me.tblXray.Controls.Add(Me.listXray, 0, 0)
        Me.tblXray.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblXray.Location = New System.Drawing.Point(3, 3)
        Me.tblXray.Margin = New System.Windows.Forms.Padding(0)
        Me.tblXray.Name = "tblXray"
        Me.tblXray.RowCount = 1
        Me.tblXray.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblXray.Size = New System.Drawing.Size(320, 83)
        Me.tblXray.TabIndex = 4
        '
        'cmdXrayTest
        '
        Me.cmdXrayTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdXrayTest.Location = New System.Drawing.Point(287, 3)
        Me.cmdXrayTest.Name = "cmdXrayTest"
        Me.cmdXrayTest.Size = New System.Drawing.Size(30, 24)
        Me.cmdXrayTest.TabIndex = 62
        Me.cmdXrayTest.Text = "..."
        Me.ToolTip1.SetToolTip(Me.cmdXrayTest, "Load Request Form")
        Me.cmdXrayTest.UseVisualStyleBackColor = True
        '
        'listXray
        '
        Me.listXray.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listXray.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listXray.FormattingEnabled = True
        Me.listXray.Location = New System.Drawing.Point(0, 0)
        Me.listXray.Margin = New System.Windows.Forms.Padding(0)
        Me.listXray.Name = "listXray"
        Me.listXray.Size = New System.Drawing.Size(284, 82)
        Me.listXray.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.listXray, "Double click to remove Test")
        '
        'tXray
        '
        Me.tXray.BackColor = System.Drawing.Color.White
        Me.tXray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tXray.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tXray.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tXray.Location = New System.Drawing.Point(3, 3)
        Me.tXray.Multiline = True
        Me.tXray.Name = "tXray"
        Me.tXray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tXray.Size = New System.Drawing.Size(320, 83)
        Me.tXray.TabIndex = 2
        '
        'TabScan
        '
        Me.TabScan.Controls.Add(Me.tblScan)
        Me.TabScan.Controls.Add(Me.tScan)
        Me.TabScan.Location = New System.Drawing.Point(4, 22)
        Me.TabScan.Name = "TabScan"
        Me.TabScan.Padding = New System.Windows.Forms.Padding(3)
        Me.TabScan.Size = New System.Drawing.Size(326, 89)
        Me.TabScan.TabIndex = 1
        Me.TabScan.Text = "Scan"
        Me.TabScan.UseVisualStyleBackColor = True
        '
        'tblScan
        '
        Me.tblScan.ColumnCount = 2
        Me.tblScan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblScan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblScan.Controls.Add(Me.cmdScanTest, 1, 0)
        Me.tblScan.Controls.Add(Me.listScan, 0, 0)
        Me.tblScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblScan.Location = New System.Drawing.Point(3, 3)
        Me.tblScan.Margin = New System.Windows.Forms.Padding(0)
        Me.tblScan.Name = "tblScan"
        Me.tblScan.RowCount = 1
        Me.tblScan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblScan.Size = New System.Drawing.Size(320, 83)
        Me.tblScan.TabIndex = 5
        '
        'cmdScanTest
        '
        Me.cmdScanTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdScanTest.Location = New System.Drawing.Point(288, 3)
        Me.cmdScanTest.Name = "cmdScanTest"
        Me.cmdScanTest.Size = New System.Drawing.Size(29, 24)
        Me.cmdScanTest.TabIndex = 62
        Me.cmdScanTest.Text = "..."
        Me.ToolTip1.SetToolTip(Me.cmdScanTest, "Load Request Form")
        Me.cmdScanTest.UseVisualStyleBackColor = True
        '
        'listScan
        '
        Me.listScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listScan.FormattingEnabled = True
        Me.listScan.Location = New System.Drawing.Point(0, 0)
        Me.listScan.Margin = New System.Windows.Forms.Padding(0)
        Me.listScan.Name = "listScan"
        Me.listScan.Size = New System.Drawing.Size(285, 82)
        Me.listScan.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.listScan, "Double click to remove Test")
        '
        'tScan
        '
        Me.tScan.BackColor = System.Drawing.Color.White
        Me.tScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tScan.Location = New System.Drawing.Point(3, 3)
        Me.tScan.Multiline = True
        Me.tScan.Name = "tScan"
        Me.tScan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tScan.Size = New System.Drawing.Size(320, 83)
        Me.tScan.TabIndex = 2
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(354, 260)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(343, 115)
        Me.TableLayoutPanel10.TabIndex = 4
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel3.Controls.Add(Me.lvMedication, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmdPrescription, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 21)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(343, 94)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'lvMedication
        '
        Me.lvMedication.BackColor = System.Drawing.Color.GhostWhite
        Me.lvMedication.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader19, Me.ColumnHeader20})
        Me.lvMedication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMedication.FullRowSelect = True
        Me.lvMedication.GridLines = True
        Me.lvMedication.HideSelection = False
        Me.lvMedication.Location = New System.Drawing.Point(3, 3)
        Me.lvMedication.MultiSelect = False
        Me.lvMedication.Name = "lvMedication"
        Me.lvMedication.Size = New System.Drawing.Size(303, 88)
        Me.lvMedication.TabIndex = 63
        Me.lvMedication.UseCompatibleStateImageBehavior = False
        Me.lvMedication.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Sn"
        Me.ColumnHeader13.Width = 26
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Medication"
        Me.ColumnHeader19.Width = 122
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Dosage"
        Me.ColumnHeader20.Width = 100
        '
        'cmdPrescription
        '
        Me.cmdPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrescription.Location = New System.Drawing.Point(312, 3)
        Me.cmdPrescription.Name = "cmdPrescription"
        Me.cmdPrescription.Size = New System.Drawing.Size(28, 24)
        Me.cmdPrescription.TabIndex = 62
        Me.cmdPrescription.Text = "..."
        Me.ToolTip1.SetToolTip(Me.cmdPrescription, "Load Request Form")
        Me.cmdPrescription.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.LightYellow
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(343, 21)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "PRESCRIPTION"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 1
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.Label21, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.tProcedure, 0, 1)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(4, 382)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(343, 100)
        Me.TableLayoutPanel11.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.LightYellow
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Margin = New System.Windows.Forms.Padding(0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(343, 21)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "MINOR PROCEDURE"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tProcedure
        '
        Me.tProcedure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tProcedure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tProcedure.Location = New System.Drawing.Point(3, 24)
        Me.tProcedure.Multiline = True
        Me.tProcedure.Name = "tProcedure"
        Me.tProcedure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tProcedure.Size = New System.Drawing.Size(337, 73)
        Me.tProcedure.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightYellow
        Me.TableLayoutPanel5.SetColumnSpan(Me.Panel8, 2)
        Me.Panel8.Controls.Add(Me.lnkAppointment)
        Me.Panel8.Controls.Add(Me.lnkReferrals)
        Me.Panel8.Controls.Add(Me.chkAdmission)
        Me.Panel8.Controls.Add(Me.lnkBed)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(4, 486)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(693, 24)
        Me.Panel8.TabIndex = 9
        '
        'lnkAppointment
        '
        Me.lnkAppointment.AutoSize = True
        Me.lnkAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAppointment.Location = New System.Drawing.Point(406, 6)
        Me.lnkAppointment.Name = "lnkAppointment"
        Me.lnkAppointment.Size = New System.Drawing.Size(110, 15)
        Me.lnkAppointment.TabIndex = 3
        Me.lnkAppointment.TabStop = True
        Me.lnkAppointment.Text = "Make Appointment"
        '
        'lnkReferrals
        '
        Me.lnkReferrals.AutoSize = True
        Me.lnkReferrals.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkReferrals.Location = New System.Drawing.Point(525, 5)
        Me.lnkReferrals.Name = "lnkReferrals"
        Me.lnkReferrals.Size = New System.Drawing.Size(91, 15)
        Me.lnkReferrals.TabIndex = 2
        Me.lnkReferrals.TabStop = True
        Me.lnkReferrals.Text = "Make Referrals"
        '
        'chkAdmission
        '
        Me.chkAdmission.AutoSize = True
        Me.chkAdmission.Location = New System.Drawing.Point(4, 6)
        Me.chkAdmission.Name = "chkAdmission"
        Me.chkAdmission.Size = New System.Drawing.Size(136, 17)
        Me.chkAdmission.TabIndex = 1
        Me.chkAdmission.Text = "Recommend Admission"
        Me.chkAdmission.UseVisualStyleBackColor = True
        '
        'lnkBed
        '
        Me.lnkBed.AutoSize = True
        Me.lnkBed.Location = New System.Drawing.Point(140, 6)
        Me.lnkBed.Name = "lnkBed"
        Me.lnkBed.Size = New System.Drawing.Size(104, 13)
        Me.lnkBed.TabIndex = 0
        Me.lnkBed.TabStop = True
        Me.lnkBed.Text = "View Bed Availability"
        Me.lnkBed.Visible = False
        '
        'SelCol
        '
        Me.SelCol.Location = New System.Drawing.Point(66, 8)
        Me.SelCol.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SelCol.Name = "SelCol"
        Me.SelCol.Size = New System.Drawing.Size(17, 20)
        Me.SelCol.TabIndex = 6
        Me.SelCol.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lvAppointment
        '
        Me.lvAppointment.BackColor = System.Drawing.Color.GhostWhite
        Me.lvAppointment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAppointment.FullRowSelect = True
        Me.lvAppointment.GridLines = True
        Me.lvAppointment.HideSelection = False
        Me.lvAppointment.Location = New System.Drawing.Point(0, 0)
        Me.lvAppointment.MultiSelect = False
        Me.lvAppointment.Name = "lvAppointment"
        Me.lvAppointment.Size = New System.Drawing.Size(250, 511)
        Me.lvAppointment.TabIndex = 3
        Me.lvAppointment.UseCompatibleStateImageBehavior = False
        Me.lvAppointment.View = System.Windows.Forms.View.Details
        '
        'RasDescend
        '
        Me.RasDescend.AutoSize = True
        Me.RasDescend.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RasDescend.Location = New System.Drawing.Point(86, 58)
        Me.RasDescend.Name = "RasDescend"
        Me.RasDescend.Size = New System.Drawing.Size(45, 16)
        Me.RasDescend.TabIndex = 8
        Me.RasDescend.Text = "&Desc"
        Me.RasDescend.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(-1, 6)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(41, 23)
        Me.UsernameLabel.TabIndex = 2
        Me.UsernameLabel.Text = "Colu&mn:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadAscend
        '
        Me.RadAscend.AutoSize = True
        Me.RadAscend.Checked = True
        Me.RadAscend.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadAscend.Location = New System.Drawing.Point(48, 58)
        Me.RadAscend.Name = "RadAscend"
        Me.RadAscend.Size = New System.Drawing.Size(40, 16)
        Me.RadAscend.TabIndex = 7
        Me.RadAscend.TabStop = True
        Me.RadAscend.Text = "&Asc"
        Me.RadAscend.UseVisualStyleBackColor = True
        '
        'cmdSort
        '
        Me.cmdSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSort.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdSort.Location = New System.Drawing.Point(86, 4)
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.Size = New System.Drawing.Size(32, 27)
        Me.cmdSort.TabIndex = 10
        Me.cmdSort.Text = "Sor&t"
        Me.cmdSort.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lvAppointment)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 511)
        Me.Panel2.TabIndex = 6
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
        Me.PictureBox1.Size = New System.Drawing.Size(165, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblCaption
        '
        Me.lblCaption.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaption.AutoSize = True
        Me.lblCaption.BackColor = System.Drawing.Color.GhostWhite
        Me.lblCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCaption.Location = New System.Drawing.Point(165, 0)
        Me.lblCaption.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(767, 29)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "CONSULTATION"
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.Font = New System.Drawing.Font("Segoe Print", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(165, 29)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(767, 28)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Manages Consultation"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightYellow
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 24)
        Me.Panel3.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(27, 5)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(144, 15)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "PATIENTS WAITING LIST"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitMain
        '
        Me.SplitMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitMain.Location = New System.Drawing.Point(0, 57)
        Me.SplitMain.Name = "SplitMain"
        '
        'SplitMain.Panel1
        '
        Me.SplitMain.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitMain.Panel2
        '
        Me.SplitMain.Panel2.Controls.Add(Me.SplitSub)
        Me.SplitMain.Size = New System.Drawing.Size(1137, 645)
        Me.SplitMain.SplitterDistance = 252
        Me.SplitMain.TabIndex = 58
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanConsultingRoom, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(250, 643)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 560)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(244, 80)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SelColumn)
        Me.Panel1.Controls.Add(Me.lblCount)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmdFilter)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.SelCol)
        Me.Panel1.Controls.Add(Me.RasDescend)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Controls.Add(Me.RadAscend)
        Me.Panel1.Controls.Add(Me.cmdSort)
        Me.Panel1.Controls.Add(Me.cmdRefresh)
        Me.Panel1.Controls.Add(Me.tFilter)
        Me.Panel1.Controls.Add(Me.lblFilter)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 79)
        Me.Panel1.TabIndex = 4
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdRefresh.Location = New System.Drawing.Point(153, 4)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(46, 27)
        Me.cmdRefresh.TabIndex = 14
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'tFilter
        '
        Me.tFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFilter.Location = New System.Drawing.Point(44, 33)
        Me.tFilter.Name = "tFilter"
        Me.tFilter.Size = New System.Drawing.Size(154, 20)
        Me.tFilter.TabIndex = 5
        '
        'lblFilter
        '
        Me.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilter.Location = New System.Drawing.Point(-1, 30)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(53, 23)
        Me.lblFilter.TabIndex = 4
        Me.lblFilter.Text = "&Filter Text:"
        Me.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanConsultingRoom
        '
        Me.PanConsultingRoom.Controls.Add(Me.cConsultingRoom)
        Me.PanConsultingRoom.Controls.Add(Me.lblDistributeTo)
        Me.PanConsultingRoom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanConsultingRoom.Location = New System.Drawing.Point(0, 24)
        Me.PanConsultingRoom.Margin = New System.Windows.Forms.Padding(0)
        Me.PanConsultingRoom.Name = "PanConsultingRoom"
        Me.PanConsultingRoom.Size = New System.Drawing.Size(250, 22)
        Me.PanConsultingRoom.TabIndex = 7
        '
        'cConsultingRoom
        '
        Me.cConsultingRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cConsultingRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cConsultingRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cConsultingRoom.FormattingEnabled = True
        Me.cConsultingRoom.Location = New System.Drawing.Point(86, 1)
        Me.cConsultingRoom.Name = "cConsultingRoom"
        Me.cConsultingRoom.Size = New System.Drawing.Size(138, 20)
        Me.cConsultingRoom.TabIndex = 54
        Me.cConsultingRoom.Tag = ""
        '
        'lblDistributeTo
        '
        Me.lblDistributeTo.AutoSize = True
        Me.lblDistributeTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistributeTo.ForeColor = System.Drawing.Color.Black
        Me.lblDistributeTo.Location = New System.Drawing.Point(-3, 4)
        Me.lblDistributeTo.Name = "lblDistributeTo"
        Me.lblDistributeTo.Size = New System.Drawing.Size(89, 13)
        Me.lblDistributeTo.TabIndex = 53
        Me.lblDistributeTo.Text = "Consulting Room:"
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205.0!))
        Me.tblHeader.Controls.Add(Me.lblCaption, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label10, 1, 1)
        Me.tblHeader.Controls.Add(Me.PanAction, 2, 0)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.66667!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.33333!))
        Me.tblHeader.Size = New System.Drawing.Size(1137, 57)
        Me.tblHeader.TabIndex = 57
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAction.Location = New System.Drawing.Point(932, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(205, 57)
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
        Me.lblAction.Size = New System.Drawing.Size(191, 19)
        Me.lblAction.TabIndex = 11
        Me.lblAction.Text = "?"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimAppointment
        '
        Me.TimAppointment.Enabled = True
        Me.TimAppointment.Interval = 30000
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(86, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(62, 21)
        Me.cmdPrint.TabIndex = 114
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'FrmConsultationSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1137, 702)
        Me.Controls.Add(Me.SplitMain)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConsultationSummary"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultation"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TabMenu.ResumeLayout(False)
        Me.TabMenu.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.PanMainCommand.ResumeLayout(False)
        Me.PanMainCommand.PerformLayout()
        Me.PanBill.ResumeLayout(False)
        Me.PanBill.PerformLayout()
        Me.mnuPrint.ResumeLayout(False)
        Me.mnuPrint.PerformLayout()
        Me.PanMail.ResumeLayout(False)
        Me.PanMail.PerformLayout()
        Me.SplitSub.Panel1.ResumeLayout(False)
        Me.SplitSub.Panel2.ResumeLayout(False)
        Me.SplitSub.ResumeLayout(False)
        Me.tblDetails.ResumeLayout(False)
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.tblDiagnosis.ResumeLayout(False)
        Me.tblDiagnosis.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TabHistory.ResumeLayout(False)
        Me.TabLab.ResumeLayout(False)
        Me.TabLab.PerformLayout()
        Me.tblLab.ResumeLayout(False)
        Me.TabXray.ResumeLayout(False)
        Me.TabXray.PerformLayout()
        Me.tblXray.ResumeLayout(False)
        Me.TabScan.ResumeLayout(False)
        Me.TabScan.PerformLayout()
        Me.tblScan.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.SelCol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.SplitMain.Panel1.ResumeLayout(False)
        Me.SplitMain.Panel2.ResumeLayout(False)
        Me.SplitMain.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanConsultingRoom.ResumeLayout(False)
        Me.PanConsultingRoom.PerformLayout()
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mnuVitalSigns As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuXRay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProcedureInvest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLabInvestigation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSurgery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDrug As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFinancialState As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabMenu As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dtpPeriod As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectedMenu As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cmdExpand As System.Windows.Forms.Button
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents SelColumn As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdFilter As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuPrintResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLastResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRefNo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanMail As System.Windows.Forms.Panel
    Friend WithEvents mnuMail As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents SplitSub As System.Windows.Forms.SplitContainer
    Friend WithEvents tblDetails As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpNextVisit As System.Windows.Forms.DateTimePicker
    Friend WithEvents tConsultant As System.Windows.Forms.TextBox
    Friend WithEvents cmdConsultant As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tAge As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tSex As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents SelCol As System.Windows.Forms.NumericUpDown
    Friend WithEvents lvAppointment As System.Windows.Forms.ListView
    Friend WithEvents RasDescend As System.Windows.Forms.RadioButton
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents RadAscend As System.Windows.Forms.RadioButton
    Friend WithEvents cmdSort As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SplitMain As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents tFilter As System.Windows.Forms.TextBox
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents TimAppointment As System.Windows.Forms.Timer
    Friend WithEvents mnuMedicalHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tPC As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tGeneralExam As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tHPC As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tblDiagnosis As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents cmdNewICD As System.Windows.Forms.Button
    Friend WithEvents cmdDiagnosis As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TabHistory As System.Windows.Forms.TabControl
    Friend WithEvents TabLab As System.Windows.Forms.TabPage
    Friend WithEvents tLab As System.Windows.Forms.TextBox
    Friend WithEvents TabXray As System.Windows.Forms.TabPage
    Friend WithEvents tXray As System.Windows.Forms.TextBox
    Friend WithEvents TabScan As System.Windows.Forms.TabPage
    Friend WithEvents tScan As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tProcedure As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tNote As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents cICDCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lnkBed As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkAppointment As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkReferrals As System.Windows.Forms.LinkLabel
    Friend WithEvents chkAdmission As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents PanConsultingRoom As System.Windows.Forms.Panel
    Friend WithEvents cConsultingRoom As System.Windows.Forms.ComboBox
    Friend WithEvents lblDistributeTo As System.Windows.Forms.Label
    Friend WithEvents tblLab As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdLabTest As System.Windows.Forms.Button
    Friend WithEvents listLab As System.Windows.Forms.ListBox
    Friend WithEvents tblXray As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdXrayTest As System.Windows.Forms.Button
    Friend WithEvents listXray As System.Windows.Forms.ListBox
    Friend WithEvents tblScan As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdScanTest As System.Windows.Forms.Button
    Friend WithEvents listScan As System.Windows.Forms.ListBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents PanBill As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents chkGenerateBill As System.Windows.Forms.CheckBox
    Friend WithEvents tConsultationFee As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdPrescription As System.Windows.Forms.Button
    Friend WithEvents lvMedication As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cSex As System.Windows.Forms.ComboBox
    Friend WithEvents cmdUnRegistered As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
End Class
