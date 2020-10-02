<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHelpDesk
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("LABORATORY", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("SCAN", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("XRAY", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("DRUGS", System.Windows.Forms.HorizontalAlignment.Left)
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHelpDesk))
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.LblDescAction = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuServices = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAppointment = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRoaster = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDoctorsRoaster = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOthersRoaster = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuenquiry = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAdmission = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMortuary = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTheaterSchedules = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPatientList = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFinancialState = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuConsultationRequest = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCLOSE = New System.Windows.Forms.ToolStripMenuItem
        Me.lblCaption = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel
        Me.tblRequest = New System.Windows.Forms.TableLayoutPanel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.tRequest = New System.Windows.Forms.TextBox
        Me.lblSelectedMenu = New System.Windows.Forms.Label
        Me.dtpPeriod = New System.Windows.Forms.DateTimePicker
        Me.cboPeriod = New System.Windows.Forms.ComboBox
        Me.tPatientNameR = New System.Windows.Forms.TextBox
        Me.cmdPatientR = New System.Windows.Forms.Button
        Me.tPatientR = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmdLoadRequest = New System.Windows.Forms.Button
        Me.lvRequest = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.tblAdmission = New System.Windows.Forms.TableLayoutPanel
        Me.DGridAdm = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ward = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Bed = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Discharged = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateDischarged = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.PanCondition = New System.Windows.Forms.Panel
        Me.dtpEndDateAdm = New System.Windows.Forms.DateTimePicker
        Me.tPatientNameAdm = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmdPatientAdm = New System.Windows.Forms.Button
        Me.dtpStartDateAdm = New System.Windows.Forms.DateTimePicker
        Me.tPatientNoAdm = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.chkOnAdmission = New System.Windows.Forms.CheckBox
        Me.cmdPostAdm = New System.Windows.Forms.Button
        Me.tblRoaster = New System.Windows.Forms.TableLayoutPanel
        Me.DBGridRoaster = New System.Windows.Forms.DataGridView
        Me.StaffName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Venue = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeFrom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeTo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.cmdLoadRoaster = New System.Windows.Forms.Button
        Me.lblDoctor = New System.Windows.Forms.Label
        Me.cStaffA = New System.Windows.Forms.ComboBox
        Me.dtpEndDateA = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpStartDateA = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.tblServices = New System.Windows.Forms.TableLayoutPanel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.tblBody = New System.Windows.Forms.TableLayoutPanel
        Me.tblLab = New System.Windows.Forms.TableLayoutPanel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboSubType = New System.Windows.Forms.ComboBox
        Me.cboMainType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.DbGridLab = New System.Windows.Forms.DataGridView
        Me.TestCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TestName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MainType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tblGeneral = New System.Windows.Forms.TableLayoutPanel
        Me.DbGridGeneral = New System.Windows.Forms.DataGridView
        Me.ServiceID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ServiceDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CashAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreditAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShortName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tblScan = New System.Windows.Forms.TableLayoutPanel
        Me.DbGridScan = New System.Windows.Forms.DataGridView
        Me.ScanCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ScanArea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ScanType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tblxray = New System.Windows.Forms.TableLayoutPanel
        Me.DbGridXray = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tblSurgery = New System.Windows.Forms.TableLayoutPanel
        Me.DbGridSurgery = New System.Windows.Forms.DataGridView
        Me.VitalSign = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tblBed = New System.Windows.Forms.TableLayoutPanel
        Me.DbGridBed = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tblAppointment = New System.Windows.Forms.TableLayoutPanel
        Me.DBGridAppointment = New System.Windows.Forms.DataGridView
        Me.PatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateMade = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApptDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToSee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdLoadAppt = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cStaff = New System.Windows.Forms.ComboBox
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.tblHeader.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblMain.SuspendLayout()
        Me.tblRequest.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.tblAdmission.SuspendLayout()
        CType(Me.DGridAdm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.PanCondition.SuspendLayout()
        Me.tblRoaster.SuspendLayout()
        CType(Me.DBGridRoaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.tblServices.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.tblBody.SuspendLayout()
        Me.tblLab.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DbGridLab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblGeneral.SuspendLayout()
        CType(Me.DbGridGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblScan.SuspendLayout()
        CType(Me.DbGridScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblxray.SuspendLayout()
        CType(Me.DbGridXray, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblSurgery.SuspendLayout()
        CType(Me.DbGridSurgery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblBed.SuspendLayout()
        CType(Me.DbGridBed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblAppointment.SuspendLayout()
        CType(Me.DBGridAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.Controls.Add(Me.LblDescAction, 0, 3)
        Me.tblHeader.Controls.Add(Me.MenuStrip1, 0, 2)
        Me.tblHeader.Controls.Add(Me.lblCaption, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label10, 1, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 4
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.66667!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.33333!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblHeader.Size = New System.Drawing.Size(895, 106)
        Me.tblHeader.TabIndex = 60
        '
        'LblDescAction
        '
        Me.LblDescAction.BackColor = System.Drawing.Color.Transparent
        Me.tblHeader.SetColumnSpan(Me.LblDescAction, 2)
        Me.LblDescAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescAction.ForeColor = System.Drawing.Color.DarkRed
        Me.LblDescAction.Location = New System.Drawing.Point(3, 85)
        Me.LblDescAction.Name = "LblDescAction"
        Me.LblDescAction.Size = New System.Drawing.Size(401, 20)
        Me.LblDescAction.TabIndex = 63
        Me.LblDescAction.Text = "."
        Me.LblDescAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.tblHeader.SetColumnSpan(Me.MenuStrip1, 2)
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuServices, Me.mnuAppointment, Me.mnuRoaster, Me.mnuenquiry, Me.mnuTheaterSchedules, Me.mnuPatientList, Me.mnuFinancialState, Me.mnuConsultationRequest, Me.mnuCLOSE})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(895, 25)
        Me.MenuStrip1.TabIndex = 53
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuServices
        '
        Me.mnuServices.BackColor = System.Drawing.Color.CadetBlue
        Me.mnuServices.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mnuServices.ForeColor = System.Drawing.Color.White
        Me.mnuServices.Name = "mnuServices"
        Me.mnuServices.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.mnuServices.Size = New System.Drawing.Size(103, 21)
        Me.mnuServices.Text = "Services && Tariffs"
        '
        'mnuAppointment
        '
        Me.mnuAppointment.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mnuAppointment.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mnuAppointment.ForeColor = System.Drawing.Color.White
        Me.mnuAppointment.Name = "mnuAppointment"
        Me.mnuAppointment.Size = New System.Drawing.Size(94, 21)
        Me.mnuAppointment.Text = "Appointments"
        '
        'mnuRoaster
        '
        Me.mnuRoaster.BackColor = System.Drawing.Color.CadetBlue
        Me.mnuRoaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDoctorsRoaster, Me.mnuOthersRoaster})
        Me.mnuRoaster.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mnuRoaster.ForeColor = System.Drawing.Color.White
        Me.mnuRoaster.Name = "mnuRoaster"
        Me.mnuRoaster.Size = New System.Drawing.Size(86, 21)
        Me.mnuRoaster.Text = "Duty Roaster"
        '
        'mnuDoctorsRoaster
        '
        Me.mnuDoctorsRoaster.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnuDoctorsRoaster.Name = "mnuDoctorsRoaster"
        Me.mnuDoctorsRoaster.Size = New System.Drawing.Size(181, 22)
        Me.mnuDoctorsRoaster.Text = "Doctors"
        '
        'mnuOthersRoaster
        '
        Me.mnuOthersRoaster.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnuOthersRoaster.Name = "mnuOthersRoaster"
        Me.mnuOthersRoaster.Size = New System.Drawing.Size(181, 22)
        Me.mnuOthersRoaster.Text = "Others Medical Staff"
        '
        'mnuenquiry
        '
        Me.mnuenquiry.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mnuenquiry.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdmission, Me.mnuMortuary})
        Me.mnuenquiry.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mnuenquiry.ForeColor = System.Drawing.Color.White
        Me.mnuenquiry.Name = "mnuenquiry"
        Me.mnuenquiry.Size = New System.Drawing.Size(67, 21)
        Me.mnuenquiry.Text = "Enquiries"
        '
        'mnuAdmission
        '
        Me.mnuAdmission.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnuAdmission.Name = "mnuAdmission"
        Me.mnuAdmission.Size = New System.Drawing.Size(135, 22)
        Me.mnuAdmission.Text = "Admissions"
        '
        'mnuMortuary
        '
        Me.mnuMortuary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnuMortuary.Name = "mnuMortuary"
        Me.mnuMortuary.Size = New System.Drawing.Size(135, 22)
        Me.mnuMortuary.Text = "Mortuary"
        '
        'mnuTheaterSchedules
        '
        Me.mnuTheaterSchedules.BackColor = System.Drawing.Color.CadetBlue
        Me.mnuTheaterSchedules.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mnuTheaterSchedules.ForeColor = System.Drawing.Color.White
        Me.mnuTheaterSchedules.Name = "mnuTheaterSchedules"
        Me.mnuTheaterSchedules.Size = New System.Drawing.Size(113, 21)
        Me.mnuTheaterSchedules.Text = "Theater Schedules"
        '
        'mnuPatientList
        '
        Me.mnuPatientList.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mnuPatientList.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mnuPatientList.ForeColor = System.Drawing.Color.White
        Me.mnuPatientList.Name = "mnuPatientList"
        Me.mnuPatientList.Size = New System.Drawing.Size(77, 21)
        Me.mnuPatientList.Text = "Patient List"
        '
        'mnuFinancialState
        '
        Me.mnuFinancialState.BackColor = System.Drawing.Color.CadetBlue
        Me.mnuFinancialState.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mnuFinancialState.ForeColor = System.Drawing.Color.White
        Me.mnuFinancialState.Name = "mnuFinancialState"
        Me.mnuFinancialState.Size = New System.Drawing.Size(93, 21)
        Me.mnuFinancialState.Text = "Financial state"
        '
        'mnuConsultationRequest
        '
        Me.mnuConsultationRequest.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mnuConsultationRequest.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mnuConsultationRequest.ForeColor = System.Drawing.Color.White
        Me.mnuConsultationRequest.Name = "mnuConsultationRequest"
        Me.mnuConsultationRequest.Size = New System.Drawing.Size(131, 21)
        Me.mnuConsultationRequest.Text = "Consultation Request"
        '
        'mnuCLOSE
        '
        Me.mnuCLOSE.BackColor = System.Drawing.Color.DarkRed
        Me.mnuCLOSE.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.mnuCLOSE.ForeColor = System.Drawing.Color.White
        Me.mnuCLOSE.Name = "mnuCLOSE"
        Me.mnuCLOSE.Size = New System.Drawing.Size(63, 21)
        Me.mnuCLOSE.Text = "CLOSE"
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
        Me.lblCaption.Location = New System.Drawing.Point(126, 0)
        Me.lblCaption.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(769, 31)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "HELP DESK"
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PictureBox1.Size = New System.Drawing.Size(126, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Segoe Print", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(126, 31)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(769, 29)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "General enquiry"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblMain
        '
        Me.tblMain.ColumnCount = 5
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.30482!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.69518!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 479.0!))
        Me.tblMain.Controls.Add(Me.tblRequest, 4, 0)
        Me.tblMain.Controls.Add(Me.tblAdmission, 3, 0)
        Me.tblMain.Controls.Add(Me.tblRoaster, 2, 0)
        Me.tblMain.Controls.Add(Me.tblServices, 0, 0)
        Me.tblMain.Controls.Add(Me.tblAppointment, 1, 0)
        Me.tblMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMain.Location = New System.Drawing.Point(0, 106)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 1
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblMain.Size = New System.Drawing.Size(895, 461)
        Me.tblMain.TabIndex = 61
        '
        'tblRequest
        '
        Me.tblRequest.ColumnCount = 1
        Me.tblRequest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblRequest.Controls.Add(Me.Panel7, 0, 0)
        Me.tblRequest.Controls.Add(Me.lvRequest, 0, 1)
        Me.tblRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblRequest.Location = New System.Drawing.Point(418, 3)
        Me.tblRequest.Name = "tblRequest"
        Me.tblRequest.RowCount = 2
        Me.tblRequest.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblRequest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblRequest.Size = New System.Drawing.Size(474, 455)
        Me.tblRequest.TabIndex = 69
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.cmdLoadRequest)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(468, 53)
        Me.Panel7.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.tRequest)
        Me.Panel8.Controls.Add(Me.lblSelectedMenu)
        Me.Panel8.Controls.Add(Me.dtpPeriod)
        Me.Panel8.Controls.Add(Me.cboPeriod)
        Me.Panel8.Controls.Add(Me.tPatientNameR)
        Me.Panel8.Controls.Add(Me.cmdPatientR)
        Me.Panel8.Controls.Add(Me.tPatientR)
        Me.Panel8.Controls.Add(Me.Label15)
        Me.Panel8.Location = New System.Drawing.Point(1, 1)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(392, 51)
        Me.Panel8.TabIndex = 65
        '
        'tRequest
        '
        Me.tRequest.BackColor = System.Drawing.Color.White
        Me.tRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRequest.Location = New System.Drawing.Point(281, 24)
        Me.tRequest.Multiline = True
        Me.tRequest.Name = "tRequest"
        Me.tRequest.ReadOnly = True
        Me.tRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tRequest.Size = New System.Drawing.Size(95, 24)
        Me.tRequest.TabIndex = 67
        Me.tRequest.Visible = False
        '
        'lblSelectedMenu
        '
        Me.lblSelectedMenu.AutoSize = True
        Me.lblSelectedMenu.Location = New System.Drawing.Point(3, 31)
        Me.lblSelectedMenu.Name = "lblSelectedMenu"
        Me.lblSelectedMenu.Size = New System.Drawing.Size(76, 13)
        Me.lblSelectedMenu.TabIndex = 66
        Me.lblSelectedMenu.Text = "Request Date:"
        '
        'dtpPeriod
        '
        Me.dtpPeriod.CustomFormat = "dd-MMM-yyyy"
        Me.dtpPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriod.Location = New System.Drawing.Point(167, 28)
        Me.dtpPeriod.Name = "dtpPeriod"
        Me.dtpPeriod.Size = New System.Drawing.Size(97, 18)
        Me.dtpPeriod.TabIndex = 65
        '
        'cboPeriod
        '
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPeriod.FormattingEnabled = True
        Me.cboPeriod.Items.AddRange(New Object() {"Today", "Last"})
        Me.cboPeriod.Location = New System.Drawing.Point(87, 27)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(76, 21)
        Me.cboPeriod.TabIndex = 62
        '
        'tPatientNameR
        '
        Me.tPatientNameR.Location = New System.Drawing.Point(200, 4)
        Me.tPatientNameR.Name = "tPatientNameR"
        Me.tPatientNameR.ReadOnly = True
        Me.tPatientNameR.Size = New System.Drawing.Size(186, 20)
        Me.tPatientNameR.TabIndex = 63
        Me.tPatientNameR.TabStop = False
        '
        'cmdPatientR
        '
        Me.cmdPatientR.Location = New System.Drawing.Point(173, 3)
        Me.cmdPatientR.Name = "cmdPatientR"
        Me.cmdPatientR.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatientR.TabIndex = 62
        Me.cmdPatientR.Text = "..."
        Me.cmdPatientR.UseVisualStyleBackColor = True
        '
        'tPatientR
        '
        Me.tPatientR.Location = New System.Drawing.Point(86, 4)
        Me.tPatientR.Name = "tPatientR"
        Me.tPatientR.Size = New System.Drawing.Size(85, 20)
        Me.tPatientR.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Patient:"
        '
        'cmdLoadRequest
        '
        Me.cmdLoadRequest.Location = New System.Drawing.Point(393, 3)
        Me.cmdLoadRequest.Name = "cmdLoadRequest"
        Me.cmdLoadRequest.Size = New System.Drawing.Size(74, 46)
        Me.cmdLoadRequest.TabIndex = 59
        Me.cmdLoadRequest.Text = "&Load"
        Me.cmdLoadRequest.UseVisualStyleBackColor = True
        '
        'lvRequest
        '
        Me.lvRequest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRequest.FullRowSelect = True
        Me.lvRequest.GridLines = True
        ListViewGroup1.Header = "LABORATORY"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "SCAN"
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.Header = "XRAY"
        ListViewGroup3.Name = "ListViewGroup3"
        ListViewGroup4.Header = "DRUGS"
        ListViewGroup4.Name = "ListViewGroup4"
        Me.lvRequest.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4})
        Me.lvRequest.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRequest.HideSelection = False
        Me.lvRequest.HoverSelection = True
        Me.lvRequest.Location = New System.Drawing.Point(3, 62)
        Me.lvRequest.Name = "lvRequest"
        Me.lvRequest.Size = New System.Drawing.Size(468, 390)
        Me.lvRequest.TabIndex = 1
        Me.lvRequest.UseCompatibleStateImageBehavior = False
        Me.lvRequest.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sn"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Test Code"
        Me.ColumnHeader4.Width = 124
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Test Name"
        Me.ColumnHeader2.Width = 380
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 111
        '
        'tblAdmission
        '
        Me.tblAdmission.ColumnCount = 1
        Me.tblAdmission.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblAdmission.Controls.Add(Me.DGridAdm, 0, 1)
        Me.tblAdmission.Controls.Add(Me.Panel6, 0, 0)
        Me.tblAdmission.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblAdmission.Location = New System.Drawing.Point(301, 3)
        Me.tblAdmission.Name = "tblAdmission"
        Me.tblAdmission.RowCount = 2
        Me.tblAdmission.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblAdmission.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblAdmission.Size = New System.Drawing.Size(111, 455)
        Me.tblAdmission.TabIndex = 68
        '
        'DGridAdm
        '
        Me.DGridAdm.AllowUserToAddRows = False
        Me.DGridAdm.AllowUserToDeleteRows = False
        Me.DGridAdm.BackgroundColor = System.Drawing.Color.Lavender
        Me.DGridAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridAdm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn21, Me.Ward, Me.Bed, Me.DataGridViewTextBoxColumn22, Me.Discharged, Me.DateDischarged})
        Me.DGridAdm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGridAdm.Location = New System.Drawing.Point(3, 84)
        Me.DGridAdm.Name = "DGridAdm"
        Me.DGridAdm.ReadOnly = True
        Me.DGridAdm.RowHeadersWidth = 25
        Me.DGridAdm.Size = New System.Drawing.Size(105, 368)
        Me.DGridAdm.TabIndex = 52
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PatientNo"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Patient No"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 80
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "PatientName"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Patient Name"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 120
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "DateAdmitted"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Date Admitted"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'Ward
        '
        Me.Ward.DataPropertyName = "Ward"
        Me.Ward.HeaderText = "Ward"
        Me.Ward.Name = "Ward"
        Me.Ward.ReadOnly = True
        '
        'Bed
        '
        Me.Bed.DataPropertyName = "BedNo"
        Me.Bed.HeaderText = "Bed No"
        Me.Bed.Name = "Bed"
        Me.Bed.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "AdmittingStaffname"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Admitted By"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 150
        '
        'Discharged
        '
        Me.Discharged.DataPropertyName = "Discharged"
        Me.Discharged.HeaderText = "Discharged"
        Me.Discharged.Name = "Discharged"
        Me.Discharged.ReadOnly = True
        '
        'DateDischarged
        '
        Me.DateDischarged.DataPropertyName = "DateDischarged"
        Me.DateDischarged.HeaderText = "Date Discharged"
        Me.DateDischarged.Name = "DateDischarged"
        Me.DateDischarged.ReadOnly = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.PanCondition)
        Me.Panel6.Controls.Add(Me.chkOnAdmission)
        Me.Panel6.Controls.Add(Me.cmdPostAdm)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(105, 75)
        Me.Panel6.TabIndex = 0
        '
        'PanCondition
        '
        Me.PanCondition.Controls.Add(Me.dtpEndDateAdm)
        Me.PanCondition.Controls.Add(Me.tPatientNameAdm)
        Me.PanCondition.Controls.Add(Me.Label14)
        Me.PanCondition.Controls.Add(Me.cmdPatientAdm)
        Me.PanCondition.Controls.Add(Me.dtpStartDateAdm)
        Me.PanCondition.Controls.Add(Me.tPatientNoAdm)
        Me.PanCondition.Controls.Add(Me.Label7)
        Me.PanCondition.Controls.Add(Me.Label13)
        Me.PanCondition.Location = New System.Drawing.Point(1, 21)
        Me.PanCondition.Name = "PanCondition"
        Me.PanCondition.Size = New System.Drawing.Size(370, 48)
        Me.PanCondition.TabIndex = 65
        '
        'dtpEndDateAdm
        '
        Me.dtpEndDateAdm.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEndDateAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDateAdm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDateAdm.Location = New System.Drawing.Point(244, 0)
        Me.dtpEndDateAdm.Name = "dtpEndDateAdm"
        Me.dtpEndDateAdm.ShowCheckBox = True
        Me.dtpEndDateAdm.Size = New System.Drawing.Size(120, 20)
        Me.dtpEndDateAdm.TabIndex = 55
        Me.dtpEndDateAdm.Tag = "RegDate"
        '
        'tPatientNameAdm
        '
        Me.tPatientNameAdm.Location = New System.Drawing.Point(175, 22)
        Me.tPatientNameAdm.Name = "tPatientNameAdm"
        Me.tPatientNameAdm.ReadOnly = True
        Me.tPatientNameAdm.Size = New System.Drawing.Size(186, 20)
        Me.tPatientNameAdm.TabIndex = 63
        Me.tPatientNameAdm.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(2, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Start Date:"
        '
        'cmdPatientAdm
        '
        Me.cmdPatientAdm.Location = New System.Drawing.Point(148, 21)
        Me.cmdPatientAdm.Name = "cmdPatientAdm"
        Me.cmdPatientAdm.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatientAdm.TabIndex = 62
        Me.cmdPatientAdm.Text = "..."
        Me.cmdPatientAdm.UseVisualStyleBackColor = True
        '
        'dtpStartDateAdm
        '
        Me.dtpStartDateAdm.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDateAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDateAdm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDateAdm.Location = New System.Drawing.Point(63, 0)
        Me.dtpStartDateAdm.Name = "dtpStartDateAdm"
        Me.dtpStartDateAdm.ShowCheckBox = True
        Me.dtpStartDateAdm.Size = New System.Drawing.Size(120, 20)
        Me.dtpStartDateAdm.TabIndex = 53
        Me.dtpStartDateAdm.Tag = "RegDate"
        '
        'tPatientNoAdm
        '
        Me.tPatientNoAdm.Location = New System.Drawing.Point(62, 22)
        Me.tPatientNoAdm.Name = "tPatientNoAdm"
        Me.tPatientNoAdm.Size = New System.Drawing.Size(84, 20)
        Me.tPatientNoAdm.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Patient:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(189, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "End Date:"
        '
        'chkOnAdmission
        '
        Me.chkOnAdmission.AutoSize = True
        Me.chkOnAdmission.Checked = True
        Me.chkOnAdmission.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOnAdmission.ForeColor = System.Drawing.Color.Maroon
        Me.chkOnAdmission.Location = New System.Drawing.Point(3, 3)
        Me.chkOnAdmission.Name = "chkOnAdmission"
        Me.chkOnAdmission.Size = New System.Drawing.Size(132, 17)
        Me.chkOnAdmission.TabIndex = 64
        Me.chkOnAdmission.Text = "Currently on Admission"
        Me.chkOnAdmission.UseVisualStyleBackColor = True
        '
        'cmdPostAdm
        '
        Me.cmdPostAdm.Location = New System.Drawing.Point(372, 22)
        Me.cmdPostAdm.Name = "cmdPostAdm"
        Me.cmdPostAdm.Size = New System.Drawing.Size(74, 46)
        Me.cmdPostAdm.TabIndex = 59
        Me.cmdPostAdm.Text = "&Load"
        Me.cmdPostAdm.UseVisualStyleBackColor = True
        '
        'tblRoaster
        '
        Me.tblRoaster.ColumnCount = 1
        Me.tblRoaster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblRoaster.Controls.Add(Me.DBGridRoaster, 0, 1)
        Me.tblRoaster.Controls.Add(Me.Panel5, 0, 0)
        Me.tblRoaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblRoaster.Location = New System.Drawing.Point(167, 3)
        Me.tblRoaster.Name = "tblRoaster"
        Me.tblRoaster.RowCount = 2
        Me.tblRoaster.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblRoaster.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblRoaster.Size = New System.Drawing.Size(128, 455)
        Me.tblRoaster.TabIndex = 67
        '
        'DBGridRoaster
        '
        Me.DBGridRoaster.AllowUserToAddRows = False
        Me.DBGridRoaster.AllowUserToDeleteRows = False
        Me.DBGridRoaster.BackgroundColor = System.Drawing.Color.Lavender
        Me.DBGridRoaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBGridRoaster.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffName, Me.tDate, Me.Venue, Me.TimeFrom, Me.TimeTo})
        Me.DBGridRoaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGridRoaster.Location = New System.Drawing.Point(3, 66)
        Me.DBGridRoaster.Name = "DBGridRoaster"
        Me.DBGridRoaster.ReadOnly = True
        Me.DBGridRoaster.RowHeadersWidth = 25
        Me.DBGridRoaster.Size = New System.Drawing.Size(122, 386)
        Me.DBGridRoaster.TabIndex = 52
        '
        'StaffName
        '
        Me.StaffName.DataPropertyName = "StaffName"
        Me.StaffName.HeaderText = "Staff Name"
        Me.StaffName.Name = "StaffName"
        Me.StaffName.ReadOnly = True
        Me.StaffName.Width = 150
        '
        'tDate
        '
        Me.tDate.DataPropertyName = "Date"
        Me.tDate.HeaderText = "Date"
        Me.tDate.Name = "tDate"
        Me.tDate.ReadOnly = True
        Me.tDate.Width = 80
        '
        'Venue
        '
        Me.Venue.DataPropertyName = "Venue"
        Me.Venue.HeaderText = "Venue"
        Me.Venue.Name = "Venue"
        Me.Venue.ReadOnly = True
        Me.Venue.Width = 150
        '
        'TimeFrom
        '
        Me.TimeFrom.DataPropertyName = "TimeFrom"
        Me.TimeFrom.HeaderText = "Time - From"
        Me.TimeFrom.Name = "TimeFrom"
        Me.TimeFrom.ReadOnly = True
        '
        'TimeTo
        '
        Me.TimeTo.DataPropertyName = "TimeTo"
        Me.TimeTo.HeaderText = "Time - To"
        Me.TimeTo.Name = "TimeTo"
        Me.TimeTo.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cmdLoadRoaster)
        Me.Panel5.Controls.Add(Me.lblDoctor)
        Me.Panel5.Controls.Add(Me.cStaffA)
        Me.Panel5.Controls.Add(Me.dtpEndDateA)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.dtpStartDateA)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(122, 57)
        Me.Panel5.TabIndex = 0
        '
        'cmdLoadRoaster
        '
        Me.cmdLoadRoaster.Location = New System.Drawing.Point(366, 6)
        Me.cmdLoadRoaster.Name = "cmdLoadRoaster"
        Me.cmdLoadRoaster.Size = New System.Drawing.Size(74, 46)
        Me.cmdLoadRoaster.TabIndex = 59
        Me.cmdLoadRoaster.Text = "&Load"
        Me.cmdLoadRoaster.UseVisualStyleBackColor = True
        '
        'lblDoctor
        '
        Me.lblDoctor.AutoSize = True
        Me.lblDoctor.Location = New System.Drawing.Point(6, 34)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(32, 13)
        Me.lblDoctor.TabIndex = 58
        Me.lblDoctor.Text = "Staff:"
        Me.lblDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cStaffA
        '
        Me.cStaffA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cStaffA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cStaffA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cStaffA.FormattingEnabled = True
        Me.cStaffA.Location = New System.Drawing.Point(66, 30)
        Me.cStaffA.Name = "cStaffA"
        Me.cStaffA.Size = New System.Drawing.Size(298, 21)
        Me.cStaffA.TabIndex = 57
        '
        'dtpEndDateA
        '
        Me.dtpEndDateA.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEndDateA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDateA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDateA.Location = New System.Drawing.Point(245, 8)
        Me.dtpEndDateA.Name = "dtpEndDateA"
        Me.dtpEndDateA.ShowCheckBox = True
        Me.dtpEndDateA.Size = New System.Drawing.Size(120, 20)
        Me.dtpEndDateA.TabIndex = 55
        Me.dtpEndDateA.Tag = "RegDate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(190, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "End Date:"
        '
        'dtpStartDateA
        '
        Me.dtpStartDateA.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDateA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDateA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDateA.Location = New System.Drawing.Point(64, 8)
        Me.dtpStartDateA.Name = "dtpStartDateA"
        Me.dtpStartDateA.ShowCheckBox = True
        Me.dtpStartDateA.Size = New System.Drawing.Size(120, 20)
        Me.dtpStartDateA.TabIndex = 53
        Me.dtpStartDateA.Tag = "RegDate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Start Date:"
        '
        'tblServices
        '
        Me.tblServices.ColumnCount = 1
        Me.tblServices.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblServices.Controls.Add(Me.Panel4, 0, 0)
        Me.tblServices.Controls.Add(Me.tblBody, 0, 1)
        Me.tblServices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblServices.Location = New System.Drawing.Point(3, 3)
        Me.tblServices.Name = "tblServices"
        Me.tblServices.RowCount = 2
        Me.tblServices.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblServices.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblServices.Size = New System.Drawing.Size(40, 455)
        Me.tblServices.TabIndex = 65
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightYellow
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.cboCategory)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(34, 24)
        Me.Panel4.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 15)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Service Category"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"General", "Laboratory", "Xray", "Scan", "Surgery", "Hospital Ward/Bed"})
        Me.cboCategory.Location = New System.Drawing.Point(108, 0)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(183, 23)
        Me.cboCategory.TabIndex = 52
        '
        'tblBody
        '
        Me.tblBody.ColumnCount = 1
        Me.tblBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBody.Controls.Add(Me.tblLab, 0, 1)
        Me.tblBody.Controls.Add(Me.tblGeneral, 0, 0)
        Me.tblBody.Controls.Add(Me.tblScan, 0, 2)
        Me.tblBody.Controls.Add(Me.tblxray, 0, 3)
        Me.tblBody.Controls.Add(Me.tblSurgery, 0, 4)
        Me.tblBody.Controls.Add(Me.tblBed, 0, 5)
        Me.tblBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblBody.Location = New System.Drawing.Point(3, 33)
        Me.tblBody.Name = "tblBody"
        Me.tblBody.RowCount = 6
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblBody.Size = New System.Drawing.Size(34, 419)
        Me.tblBody.TabIndex = 64
        '
        'tblLab
        '
        Me.tblLab.ColumnCount = 1
        Me.tblLab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLab.Controls.Add(Me.Panel2, 0, 0)
        Me.tblLab.Controls.Add(Me.Panel3, 0, 1)
        Me.tblLab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblLab.Location = New System.Drawing.Point(3, 103)
        Me.tblLab.Name = "tblLab"
        Me.tblLab.RowCount = 2
        Me.tblLab.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblLab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblLab.Size = New System.Drawing.Size(28, 120)
        Me.tblLab.TabIndex = 53
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cboSubType)
        Me.Panel2.Controls.Add(Me.cboMainType)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(22, 54)
        Me.Panel2.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Main Type:"
        '
        'cboSubType
        '
        Me.cboSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboSubType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubType.FormattingEnabled = True
        Me.cboSubType.Location = New System.Drawing.Point(102, 28)
        Me.cboSubType.Name = "cboSubType"
        Me.cboSubType.Size = New System.Drawing.Size(211, 21)
        Me.cboSubType.TabIndex = 9
        '
        'cboMainType
        '
        Me.cboMainType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMainType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboMainType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMainType.FormattingEnabled = True
        Me.cboMainType.Location = New System.Drawing.Point(102, 3)
        Me.cboMainType.Name = "cboMainType"
        Me.cboMainType.Size = New System.Drawing.Size(211, 21)
        Me.cboMainType.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sub Type:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DbGridLab)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(22, 54)
        Me.Panel3.TabIndex = 52
        '
        'DbGridLab
        '
        Me.DbGridLab.AllowUserToAddRows = False
        Me.DbGridLab.AllowUserToDeleteRows = False
        Me.DbGridLab.BackgroundColor = System.Drawing.Color.Lavender
        Me.DbGridLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGridLab.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TestCode, Me.TestName, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.MainType, Me.SubType})
        Me.DbGridLab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGridLab.Location = New System.Drawing.Point(0, 0)
        Me.DbGridLab.Name = "DbGridLab"
        Me.DbGridLab.ReadOnly = True
        Me.DbGridLab.Size = New System.Drawing.Size(22, 54)
        Me.DbGridLab.TabIndex = 52
        '
        'TestCode
        '
        Me.TestCode.DataPropertyName = "TestCode"
        Me.TestCode.HeaderText = "Test Code"
        Me.TestCode.Name = "TestCode"
        Me.TestCode.ReadOnly = True
        Me.TestCode.Width = 62
        '
        'TestName
        '
        Me.TestName.DataPropertyName = "TestName"
        Me.TestName.HeaderText = "Test Name"
        Me.TestName.Name = "TestName"
        Me.TestName.ReadOnly = True
        Me.TestName.Width = 200
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CashPrice"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle1.Format = "N2"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cash Amt."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 65
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CreditPrice"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle2.Format = "N2"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Credit Amt."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'MainType
        '
        Me.MainType.DataPropertyName = "MainType"
        Me.MainType.HeaderText = "MainType"
        Me.MainType.Name = "MainType"
        Me.MainType.ReadOnly = True
        Me.MainType.Visible = False
        '
        'SubType
        '
        Me.SubType.DataPropertyName = "SubType"
        Me.SubType.HeaderText = "SubType"
        Me.SubType.Name = "SubType"
        Me.SubType.ReadOnly = True
        Me.SubType.Visible = False
        '
        'tblGeneral
        '
        Me.tblGeneral.ColumnCount = 1
        Me.tblGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblGeneral.Controls.Add(Me.DbGridGeneral, 0, 0)
        Me.tblGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblGeneral.Location = New System.Drawing.Point(3, 3)
        Me.tblGeneral.Name = "tblGeneral"
        Me.tblGeneral.RowCount = 1
        Me.tblGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.tblGeneral.Size = New System.Drawing.Size(28, 94)
        Me.tblGeneral.TabIndex = 54
        '
        'DbGridGeneral
        '
        Me.DbGridGeneral.AllowUserToAddRows = False
        Me.DbGridGeneral.AllowUserToDeleteRows = False
        Me.DbGridGeneral.BackgroundColor = System.Drawing.Color.Lavender
        Me.DbGridGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGridGeneral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceID, Me.ServiceDesc, Me.CashAmt, Me.CreditAmt, Me.ShortName})
        Me.DbGridGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGridGeneral.Location = New System.Drawing.Point(3, 3)
        Me.DbGridGeneral.Name = "DbGridGeneral"
        Me.DbGridGeneral.ReadOnly = True
        Me.DbGridGeneral.RowHeadersWidth = 25
        Me.DbGridGeneral.Size = New System.Drawing.Size(22, 88)
        Me.DbGridGeneral.TabIndex = 51
        '
        'ServiceID
        '
        Me.ServiceID.DataPropertyName = "ServiceID"
        Me.ServiceID.HeaderText = "Service ID"
        Me.ServiceID.Name = "ServiceID"
        Me.ServiceID.ReadOnly = True
        Me.ServiceID.Width = 62
        '
        'ServiceDesc
        '
        Me.ServiceDesc.DataPropertyName = "ServiceDesc"
        Me.ServiceDesc.HeaderText = "Service Description"
        Me.ServiceDesc.Name = "ServiceDesc"
        Me.ServiceDesc.ReadOnly = True
        Me.ServiceDesc.Width = 220
        '
        'CashAmt
        '
        Me.CashAmt.DataPropertyName = "CashAmt"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.CashAmt.DefaultCellStyle = DataGridViewCellStyle3
        Me.CashAmt.HeaderText = "Cash Amt."
        Me.CashAmt.Name = "CashAmt"
        Me.CashAmt.ReadOnly = True
        Me.CashAmt.Width = 70
        '
        'CreditAmt
        '
        Me.CreditAmt.DataPropertyName = "CreditAmt"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.CreditAmt.DefaultCellStyle = DataGridViewCellStyle4
        Me.CreditAmt.HeaderText = "Credit Amt."
        Me.CreditAmt.Name = "CreditAmt"
        Me.CreditAmt.ReadOnly = True
        Me.CreditAmt.Width = 70
        '
        'ShortName
        '
        Me.ShortName.DataPropertyName = "ShortName"
        Me.ShortName.HeaderText = "Service Short Name"
        Me.ShortName.Name = "ShortName"
        Me.ShortName.ReadOnly = True
        '
        'tblScan
        '
        Me.tblScan.ColumnCount = 1
        Me.tblScan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblScan.Controls.Add(Me.DbGridScan, 0, 0)
        Me.tblScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblScan.Location = New System.Drawing.Point(3, 229)
        Me.tblScan.Name = "tblScan"
        Me.tblScan.RowCount = 1
        Me.tblScan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblScan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tblScan.Size = New System.Drawing.Size(28, 56)
        Me.tblScan.TabIndex = 55
        '
        'DbGridScan
        '
        Me.DbGridScan.AllowUserToAddRows = False
        Me.DbGridScan.AllowUserToDeleteRows = False
        Me.DbGridScan.BackgroundColor = System.Drawing.Color.Lavender
        Me.DbGridScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGridScan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ScanCode, Me.category, Me.ScanArea, Me.ScanType, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DbGridScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGridScan.Location = New System.Drawing.Point(3, 3)
        Me.DbGridScan.Name = "DbGridScan"
        Me.DbGridScan.ReadOnly = True
        Me.DbGridScan.Size = New System.Drawing.Size(22, 50)
        Me.DbGridScan.TabIndex = 51
        '
        'ScanCode
        '
        Me.ScanCode.DataPropertyName = "ScanCode"
        Me.ScanCode.HeaderText = "Scan Code"
        Me.ScanCode.Name = "ScanCode"
        Me.ScanCode.ReadOnly = True
        Me.ScanCode.Width = 62
        '
        'category
        '
        Me.category.DataPropertyName = "Category"
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'ScanArea
        '
        Me.ScanArea.DataPropertyName = "ScanArea"
        Me.ScanArea.HeaderText = "Scan Area"
        Me.ScanArea.Name = "ScanArea"
        Me.ScanArea.ReadOnly = True
        '
        'ScanType
        '
        Me.ScanType.DataPropertyName = "ScanType"
        Me.ScanType.HeaderText = "Scan Type"
        Me.ScanType.Name = "ScanType"
        Me.ScanType.ReadOnly = True
        Me.ScanType.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CashPrice"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle5.Format = "N2"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cash Amt."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 65
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CreditPrice"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle6.Format = "N2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "Credit Amt."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 65
        '
        'tblxray
        '
        Me.tblxray.ColumnCount = 1
        Me.tblxray.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblxray.Controls.Add(Me.DbGridXray, 0, 0)
        Me.tblxray.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblxray.Location = New System.Drawing.Point(3, 291)
        Me.tblxray.Name = "tblxray"
        Me.tblxray.RowCount = 1
        Me.tblxray.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblxray.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tblxray.Size = New System.Drawing.Size(28, 36)
        Me.tblxray.TabIndex = 56
        '
        'DbGridXray
        '
        Me.DbGridXray.AllowUserToAddRows = False
        Me.DbGridXray.AllowUserToDeleteRows = False
        Me.DbGridXray.BackgroundColor = System.Drawing.Color.Lavender
        Me.DbGridXray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGridXray.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DbGridXray.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGridXray.Location = New System.Drawing.Point(3, 3)
        Me.DbGridXray.Name = "DbGridXray"
        Me.DbGridXray.ReadOnly = True
        Me.DbGridXray.RowHeadersWidth = 35
        Me.DbGridXray.Size = New System.Drawing.Size(22, 30)
        Me.DbGridXray.TabIndex = 51
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "XrayCode"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Xray Code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 62
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "XrayType"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Xray Type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 220
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Region"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Region"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CashAmt"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cash Amt."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 65
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CreditAmt"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle8.Format = "N2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn9.HeaderText = "Credit Amt."
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 65
        '
        'tblSurgery
        '
        Me.tblSurgery.ColumnCount = 1
        Me.tblSurgery.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblSurgery.Controls.Add(Me.DbGridSurgery, 0, 0)
        Me.tblSurgery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblSurgery.Location = New System.Drawing.Point(3, 333)
        Me.tblSurgery.Name = "tblSurgery"
        Me.tblSurgery.RowCount = 1
        Me.tblSurgery.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblSurgery.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tblSurgery.Size = New System.Drawing.Size(28, 42)
        Me.tblSurgery.TabIndex = 57
        '
        'DbGridSurgery
        '
        Me.DbGridSurgery.AllowUserToAddRows = False
        Me.DbGridSurgery.AllowUserToDeleteRows = False
        Me.DbGridSurgery.BackgroundColor = System.Drawing.Color.Lavender
        Me.DbGridSurgery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGridSurgery.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VitalSign, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DbGridSurgery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGridSurgery.Location = New System.Drawing.Point(3, 3)
        Me.DbGridSurgery.Name = "DbGridSurgery"
        Me.DbGridSurgery.ReadOnly = True
        Me.DbGridSurgery.Size = New System.Drawing.Size(22, 36)
        Me.DbGridSurgery.TabIndex = 51
        '
        'VitalSign
        '
        Me.VitalSign.DataPropertyName = "SurgeryType"
        Me.VitalSign.HeaderText = "Surgery Type"
        Me.VitalSign.Name = "VitalSign"
        Me.VitalSign.ReadOnly = True
        Me.VitalSign.Width = 300
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CashAmt"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cash Amt."
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CreditAmt"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn11.HeaderText = "Credit Amt."
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 70
        '
        'tblBed
        '
        Me.tblBed.ColumnCount = 1
        Me.tblBed.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBed.Controls.Add(Me.DbGridBed, 0, 0)
        Me.tblBed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblBed.Location = New System.Drawing.Point(3, 381)
        Me.tblBed.Name = "tblBed"
        Me.tblBed.RowCount = 1
        Me.tblBed.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBed.Size = New System.Drawing.Size(28, 35)
        Me.tblBed.TabIndex = 58
        '
        'DbGridBed
        '
        Me.DbGridBed.AllowUserToAddRows = False
        Me.DbGridBed.AllowUserToDeleteRows = False
        Me.DbGridBed.BackgroundColor = System.Drawing.Color.Lavender
        Me.DbGridBed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGridBed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.DbGridBed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGridBed.Location = New System.Drawing.Point(3, 3)
        Me.DbGridBed.Name = "DbGridBed"
        Me.DbGridBed.ReadOnly = True
        Me.DbGridBed.Size = New System.Drawing.Size(22, 29)
        Me.DbGridBed.TabIndex = 58
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Ward"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Ward"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "BedNo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Bed"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 80
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Facility"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Facility"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CashRate"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle11.Format = "N2"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cash Amt."
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 65
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "CreditRate"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle12.Format = "N2"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn16.HeaderText = "Credit Amt."
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 65
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'tblAppointment
        '
        Me.tblAppointment.ColumnCount = 1
        Me.tblAppointment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblAppointment.Controls.Add(Me.DBGridAppointment, 0, 1)
        Me.tblAppointment.Controls.Add(Me.Panel1, 0, 0)
        Me.tblAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblAppointment.Location = New System.Drawing.Point(49, 3)
        Me.tblAppointment.Name = "tblAppointment"
        Me.tblAppointment.RowCount = 2
        Me.tblAppointment.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblAppointment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblAppointment.Size = New System.Drawing.Size(112, 455)
        Me.tblAppointment.TabIndex = 66
        '
        'DBGridAppointment
        '
        Me.DBGridAppointment.AllowUserToAddRows = False
        Me.DBGridAppointment.AllowUserToDeleteRows = False
        Me.DBGridAppointment.BackgroundColor = System.Drawing.Color.Lavender
        Me.DBGridAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBGridAppointment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientNo, Me.PatientName, Me.DateMade, Me.ApptDate, Me.ToSee, Me.Note})
        Me.DBGridAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGridAppointment.Location = New System.Drawing.Point(3, 88)
        Me.DBGridAppointment.Name = "DBGridAppointment"
        Me.DBGridAppointment.ReadOnly = True
        Me.DBGridAppointment.RowHeadersWidth = 25
        Me.DBGridAppointment.Size = New System.Drawing.Size(106, 364)
        Me.DBGridAppointment.TabIndex = 52
        '
        'PatientNo
        '
        Me.PatientNo.DataPropertyName = "PatientNo"
        Me.PatientNo.HeaderText = "Patient No"
        Me.PatientNo.Name = "PatientNo"
        Me.PatientNo.ReadOnly = True
        Me.PatientNo.Width = 80
        '
        'PatientName
        '
        Me.PatientName.DataPropertyName = "PatientName"
        Me.PatientName.HeaderText = "Patient Name"
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        Me.PatientName.Width = 120
        '
        'DateMade
        '
        Me.DateMade.DataPropertyName = "DateMade"
        Me.DateMade.HeaderText = "Date Made"
        Me.DateMade.Name = "DateMade"
        Me.DateMade.ReadOnly = True
        '
        'ApptDate
        '
        Me.ApptDate.DataPropertyName = "AppointmentDate"
        Me.ApptDate.HeaderText = "Appt. Date"
        Me.ApptDate.Name = "ApptDate"
        Me.ApptDate.ReadOnly = True
        '
        'ToSee
        '
        Me.ToSee.DataPropertyName = "Staffname"
        Me.ToSee.HeaderText = "To See"
        Me.ToSee.Name = "ToSee"
        Me.ToSee.ReadOnly = True
        Me.ToSee.Width = 150
        '
        'Note
        '
        Me.Note.DataPropertyName = "Note"
        Me.Note.HeaderText = "Note"
        Me.Note.Name = "Note"
        Me.Note.ReadOnly = True
        Me.Note.Width = 200
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tPatientName)
        Me.Panel1.Controls.Add(Me.cmdPatient)
        Me.Panel1.Controls.Add(Me.tPatientNo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmdLoadAppt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cStaff)
        Me.Panel1.Controls.Add(Me.dtpEndDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpStartDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(106, 79)
        Me.Panel1.TabIndex = 0
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(178, 54)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(186, 20)
        Me.tPatientName.TabIndex = 63
        Me.tPatientName.TabStop = False
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(151, 53)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 62
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(65, 54)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(84, 20)
        Me.tPatientNo.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Patient:"
        '
        'cmdLoadAppt
        '
        Me.cmdLoadAppt.Location = New System.Drawing.Point(366, 6)
        Me.cmdLoadAppt.Name = "cmdLoadAppt"
        Me.cmdLoadAppt.Size = New System.Drawing.Size(74, 68)
        Me.cmdLoadAppt.TabIndex = 59
        Me.cmdLoadAppt.Text = "&Load"
        Me.cmdLoadAppt.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Staff:"
        '
        'cStaff
        '
        Me.cStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cStaff.FormattingEnabled = True
        Me.cStaff.Location = New System.Drawing.Point(66, 30)
        Me.cStaff.Name = "cStaff"
        Me.cStaff.Size = New System.Drawing.Size(298, 21)
        Me.cStaff.TabIndex = 57
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(245, 8)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.ShowCheckBox = True
        Me.dtpEndDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpEndDate.TabIndex = 55
        Me.dtpEndDate.Tag = "RegDate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "End Date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(64, 8)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.ShowCheckBox = True
        Me.dtpStartDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpStartDate.TabIndex = 53
        Me.dtpStartDate.Tag = "RegDate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Start Date:"
        '
        'FrmHelpDesk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 567)
        Me.Controls.Add(Me.tblMain)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHelpDesk"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help Desk"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblMain.ResumeLayout(False)
        Me.tblRequest.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.tblAdmission.ResumeLayout(False)
        CType(Me.DGridAdm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PanCondition.ResumeLayout(False)
        Me.PanCondition.PerformLayout()
        Me.tblRoaster.ResumeLayout(False)
        CType(Me.DBGridRoaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.tblServices.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.tblBody.ResumeLayout(False)
        Me.tblLab.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DbGridLab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblGeneral.ResumeLayout(False)
        CType(Me.DbGridGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblScan.ResumeLayout(False)
        CType(Me.DbGridScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblxray.ResumeLayout(False)
        CType(Me.DbGridXray, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblSurgery.ResumeLayout(False)
        CType(Me.DbGridSurgery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblBed.ResumeLayout(False)
        CType(Me.DbGridBed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblAppointment.ResumeLayout(False)
        CType(Me.DBGridAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuServices As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAppointment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRoaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCLOSE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuenquiry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTheaterSchedules As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPatientList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAdmission As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDoctorsRoaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOthersRoaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFinancialState As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMortuary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tblMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LblDescAction As System.Windows.Forms.Label
    Friend WithEvents tblBody As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblLab As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSubType As System.Windows.Forms.ComboBox
    Friend WithEvents cboMainType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DbGridLab As System.Windows.Forms.DataGridView
    Friend WithEvents tblGeneral As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DbGridGeneral As System.Windows.Forms.DataGridView
    Friend WithEvents tblScan As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DbGridScan As System.Windows.Forms.DataGridView
    Friend WithEvents ScanCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScanArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScanType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tblxray As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DbGridXray As System.Windows.Forms.DataGridView
    Friend WithEvents tblSurgery As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DbGridSurgery As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents tblServices As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents VitalSign As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShortName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DbGridBed As System.Windows.Forms.DataGridView
    Friend WithEvents tblBed As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tblAppointment As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DBGridAppointment As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cStaff As System.Windows.Forms.ComboBox
    Friend WithEvents cmdLoadAppt As System.Windows.Forms.Button
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents PatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateMade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApptDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToSee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TestCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TestName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MainType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tblRoaster As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DBGridRoaster As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cmdLoadRoaster As System.Windows.Forms.Button
    Friend WithEvents lblDoctor As System.Windows.Forms.Label
    Friend WithEvents cStaffA As System.Windows.Forms.ComboBox
    Friend WithEvents dtpEndDateA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDateA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents StaffName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Venue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tblAdmission As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DGridAdm As System.Windows.Forms.DataGridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tPatientNameAdm As System.Windows.Forms.TextBox
    Friend WithEvents cmdPatientAdm As System.Windows.Forms.Button
    Friend WithEvents tPatientNoAdm As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdPostAdm As System.Windows.Forms.Button
    Friend WithEvents dtpEndDateAdm As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDateAdm As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkOnAdmission As System.Windows.Forms.CheckBox
    Friend WithEvents PanCondition As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ward As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Discharged As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDischarged As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnuConsultationRequest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tblRequest As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents tPatientNameR As System.Windows.Forms.TextBox
    Friend WithEvents cmdPatientR As System.Windows.Forms.Button
    Friend WithEvents tPatientR As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmdLoadRequest As System.Windows.Forms.Button
    Friend WithEvents lvRequest As System.Windows.Forms.ListView
    Friend WithEvents lblSelectedMenu As System.Windows.Forms.Label
    Friend WithEvents dtpPeriod As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents tRequest As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
