<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNursingStation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNursingStation))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SelColumn = New System.Windows.Forms.TextBox
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdFilter = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SelCol = New System.Windows.Forms.NumericUpDown
        Me.RasDescend = New System.Windows.Forms.RadioButton
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.RadAscend = New System.Windows.Forms.RadioButton
        Me.cmdSort = New System.Windows.Forms.Button
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.tFilter = New System.Windows.Forms.TextBox
        Me.lblFilter = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lvAppointment = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuDistribution = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuVitals = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuProcedure = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCLOSE = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cNursingStation = New System.Windows.Forms.ComboBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.cmdUnregisteredPatient1 = New System.Windows.Forms.Button
        Me.tPerformedBy = New System.Windows.Forms.TextBox
        Me.cmdPerform = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.tAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tAge = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tSex = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.tRefNo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.PanProcedure = New System.Windows.Forms.Panel
        Me.RadProcedures = New System.Windows.Forms.RadioButton
        Me.RadInjection = New System.Windows.Forms.RadioButton
        Me.cmdOk = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.lblDistribution = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.lnkRefresh = New System.Windows.Forms.LinkLabel
        Me.PanConsultation = New System.Windows.Forms.Panel
        Me.tConsultationFee = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.cmdUnRegistered = New System.Windows.Forms.Button
        Me.tAccount1 = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.tAge1 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.tSex1 = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.tPatientName1 = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.dtpDate1 = New System.Windows.Forms.DateTimePicker
        Me.cmdPatient1 = New System.Windows.Forms.Button
        Me.tPatientIDNo = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.lnkAppointment = New System.Windows.Forms.LinkLabel
        Me.chkFollowUp = New System.Windows.Forms.CheckBox
        Me.chkUrgent = New System.Windows.Forms.CheckBox
        Me.cmdCancelPost = New System.Windows.Forms.Button
        Me.cmdPOST = New System.Windows.Forms.Button
        Me.cDoctor = New System.Windows.Forms.ComboBox
        Me.lblDistributeTo = New System.Windows.Forms.Label
        Me.tblProcedure = New System.Windows.Forms.TableLayoutPanel
        Me.DbGrid = New System.Windows.Forms.DataGridView
        Me.VitalSign = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Result = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lblSelectedMenu = New System.Windows.Forms.Label
        Me.dtpPeriod = New System.Windows.Forms.DateTimePicker
        Me.cboPeriod = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.tRequest = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel
        Me.lvRequest = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.cmdRefreshRequest = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.tblDetails = New System.Windows.Forms.TableLayoutPanel
        Me.PanOthers = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cProcedureType = New System.Windows.Forms.ComboBox
        Me.tComment = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tIndication = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.PanInjection = New System.Windows.Forms.Panel
        Me.tCommentInj = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cMode = New System.Windows.Forms.ComboBox
        Me.tDosage = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.tInjection = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.PanAction = New System.Windows.Forms.FlowLayoutPanel
        Me.mnuAction = New System.Windows.Forms.MenuStrip
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBrowse = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.lblAction = New System.Windows.Forms.Label
        Me.lnkFinancialState = New System.Windows.Forms.LinkLabel
        Me.LblDescAction = New System.Windows.Forms.Label
        Me.TimAppointment = New System.Windows.Forms.Timer(Me.components)
        Me.TimRequest = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SelCol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tblMain.SuspendLayout()
        Me.PanHeading.SuspendLayout()
        Me.PanMainCommand.SuspendLayout()
        Me.PanProcedure.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.PanConsultation.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.tblProcedure.SuspendLayout()
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.tblDetails.SuspendLayout()
        Me.PanOthers.SuspendLayout()
        Me.PanInjection.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.21951!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.78049!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tblHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MenuStrip1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tblMain, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1284, 648)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 96)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(342, 548)
        Me.TableLayoutPanel2.TabIndex = 54
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 465)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(342, 80)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SelColumn)
        Me.Panel2.Controls.Add(Me.lblCount)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cmdFilter)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.SelCol)
        Me.Panel2.Controls.Add(Me.RasDescend)
        Me.Panel2.Controls.Add(Me.UsernameLabel)
        Me.Panel2.Controls.Add(Me.RadAscend)
        Me.Panel2.Controls.Add(Me.cmdSort)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.tFilter)
        Me.Panel2.Controls.Add(Me.lblFilter)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(281, 79)
        Me.Panel2.TabIndex = 4
        '
        'SelColumn
        '
        Me.SelColumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelColumn.Location = New System.Drawing.Point(44, 8)
        Me.SelColumn.Name = "SelColumn"
        Me.SelColumn.Size = New System.Drawing.Size(24, 20)
        Me.SelColumn.TabIndex = 16
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(189, 58)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(37, 19)
        Me.lblCount.TabIndex = 13
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 56)
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
        Me.cmdFilter.Location = New System.Drawing.Point(132, 4)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(45, 27)
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
        'SelCol
        '
        Me.SelCol.Location = New System.Drawing.Point(66, 8)
        Me.SelCol.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SelCol.Name = "SelCol"
        Me.SelCol.Size = New System.Drawing.Size(17, 20)
        Me.SelCol.TabIndex = 6
        Me.SelCol.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.cmdSort.Size = New System.Drawing.Size(45, 27)
        Me.cmdSort.TabIndex = 10
        Me.cmdSort.Text = "Sor&t"
        Me.cmdSort.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdRefresh.Location = New System.Drawing.Point(178, 4)
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
        Me.tFilter.Size = New System.Drawing.Size(218, 20)
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightYellow
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(342, 30)
        Me.Panel3.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(40, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 15)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "PATIENTS ON VISITATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lvAppointment)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 30)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(342, 432)
        Me.Panel4.TabIndex = 6
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
        Me.lvAppointment.Size = New System.Drawing.Size(342, 432)
        Me.lvAppointment.TabIndex = 3
        Me.lvAppointment.UseCompatibleStateImageBehavior = False
        Me.lvAppointment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Patient No"
        Me.ColumnHeader7.Width = 65
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
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Account"
        Me.ColumnHeader10.Width = 121
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Age"
        Me.ColumnHeader11.Width = 34
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Sex"
        Me.ColumnHeader12.Width = 45
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.tblHeader, 2)
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.Controls.Add(Me.Label7, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label8, 1, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(1, 1)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.31707!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.68293!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblHeader.Size = New System.Drawing.Size(1282, 61)
        Me.tblHeader.TabIndex = 51
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
        Me.Label7.Location = New System.Drawing.Point(124, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1158, 34)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "NURSING STATION"
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
        Me.PictureBox1.Size = New System.Drawing.Size(124, 61)
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
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(124, 34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1158, 27)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Maintains Nursing Station Activities"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDistribution, Me.mnuVitals, Me.mnuProcedure, Me.mnuCLOSE})
        Me.MenuStrip1.Location = New System.Drawing.Point(350, 63)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(933, 29)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuDistribution
        '
        Me.mnuDistribution.BackColor = System.Drawing.Color.CadetBlue
        Me.mnuDistribution.ForeColor = System.Drawing.Color.White
        Me.mnuDistribution.Name = "mnuDistribution"
        Me.mnuDistribution.Size = New System.Drawing.Size(177, 25)
        Me.mnuDistribution.Text = "Distribution for Consultation"
        '
        'mnuVitals
        '
        Me.mnuVitals.BackColor = System.Drawing.Color.PowderBlue
        Me.mnuVitals.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnuVitals.ForeColor = System.Drawing.Color.White
        Me.mnuVitals.Name = "mnuVitals"
        Me.mnuVitals.Size = New System.Drawing.Size(91, 25)
        Me.mnuVitals.Text = "VITAL SIGNS"
        '
        'mnuProcedure
        '
        Me.mnuProcedure.BackColor = System.Drawing.Color.LightSkyBlue
        Me.mnuProcedure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnuProcedure.ForeColor = System.Drawing.Color.White
        Me.mnuProcedure.Name = "mnuProcedure"
        Me.mnuProcedure.Size = New System.Drawing.Size(132, 25)
        Me.mnuProcedure.Text = "MINOR PROCEDURE"
        '
        'mnuCLOSE
        '
        Me.mnuCLOSE.BackColor = System.Drawing.Color.DarkRed
        Me.mnuCLOSE.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.mnuCLOSE.ForeColor = System.Drawing.Color.White
        Me.mnuCLOSE.Name = "mnuCLOSE"
        Me.mnuCLOSE.Size = New System.Drawing.Size(63, 25)
        Me.mnuCLOSE.Text = "CLOSE"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cNursingStation)
        Me.Panel1.Controls.Add(Me.Label32)
        Me.Panel1.Location = New System.Drawing.Point(4, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 23)
        Me.Panel1.TabIndex = 53
        '
        'cNursingStation
        '
        Me.cNursingStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cNursingStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cNursingStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cNursingStation.FormattingEnabled = True
        Me.cNursingStation.Location = New System.Drawing.Point(50, 2)
        Me.cNursingStation.Name = "cNursingStation"
        Me.cNursingStation.Size = New System.Drawing.Size(176, 23)
        Me.cNursingStation.TabIndex = 52
        Me.cNursingStation.Tag = "BloodGroup"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(1, 3)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(48, 15)
        Me.Label32.TabIndex = 51
        Me.Label32.Text = "Station:"
        '
        'tblMain
        '
        Me.tblMain.ColumnCount = 2
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.Controls.Add(Me.PanHeading, 1, 1)
        Me.tblMain.Controls.Add(Me.PanMainCommand, 1, 2)
        Me.tblMain.Controls.Add(Me.Panel5, 0, 1)
        Me.tblMain.Controls.Add(Me.tblProcedure, 1, 3)
        Me.tblMain.Controls.Add(Me.Panel8, 0, 0)
        Me.tblMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMain.Location = New System.Drawing.Point(353, 96)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 4
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblMain.Size = New System.Drawing.Size(927, 548)
        Me.tblMain.TabIndex = 55
        '
        'PanHeading
        '
        Me.PanHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanHeading.Controls.Add(Me.cmdUnregisteredPatient1)
        Me.PanHeading.Controls.Add(Me.tPerformedBy)
        Me.PanHeading.Controls.Add(Me.cmdPerform)
        Me.PanHeading.Controls.Add(Me.Label18)
        Me.PanHeading.Controls.Add(Me.tAccount)
        Me.PanHeading.Controls.Add(Me.Label16)
        Me.PanHeading.Controls.Add(Me.tAge)
        Me.PanHeading.Controls.Add(Me.Label6)
        Me.PanHeading.Controls.Add(Me.tSex)
        Me.PanHeading.Controls.Add(Me.Label5)
        Me.PanHeading.Controls.Add(Me.tPatientName)
        Me.PanHeading.Controls.Add(Me.Label4)
        Me.PanHeading.Controls.Add(Me.Label9)
        Me.PanHeading.Controls.Add(Me.dtpDate)
        Me.PanHeading.Controls.Add(Me.tRefNo)
        Me.PanHeading.Controls.Add(Me.Label10)
        Me.PanHeading.Controls.Add(Me.cmdPatient)
        Me.PanHeading.Controls.Add(Me.tPatientNo)
        Me.PanHeading.Controls.Add(Me.Label11)
        Me.PanHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanHeading.Location = New System.Drawing.Point(182, 61)
        Me.PanHeading.Margin = New System.Windows.Forms.Padding(0)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(745, 78)
        Me.PanHeading.TabIndex = 58
        '
        'cmdUnregisteredPatient1
        '
        Me.cmdUnregisteredPatient1.Location = New System.Drawing.Point(197, 5)
        Me.cmdUnregisteredPatient1.Name = "cmdUnregisteredPatient1"
        Me.cmdUnregisteredPatient1.Size = New System.Drawing.Size(31, 21)
        Me.cmdUnregisteredPatient1.TabIndex = 64
        Me.cmdUnregisteredPatient1.Text = "OP"
        Me.cmdUnregisteredPatient1.UseVisualStyleBackColor = True
        '
        'tPerformedBy
        '
        Me.tPerformedBy.Location = New System.Drawing.Point(90, 52)
        Me.tPerformedBy.Name = "tPerformedBy"
        Me.tPerformedBy.ReadOnly = True
        Me.tPerformedBy.Size = New System.Drawing.Size(244, 20)
        Me.tPerformedBy.TabIndex = 61
        Me.tPerformedBy.TabStop = False
        '
        'cmdPerform
        '
        Me.cmdPerform.Location = New System.Drawing.Point(334, 52)
        Me.cmdPerform.Name = "cmdPerform"
        Me.cmdPerform.Size = New System.Drawing.Size(26, 21)
        Me.cmdPerform.TabIndex = 60
        Me.cmdPerform.Text = "..."
        Me.cmdPerform.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Performed By:"
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(415, 28)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(296, 20)
        Me.tAccount.TabIndex = 51
        Me.tAccount.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(363, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Account:"
        '
        'tAge
        '
        Me.tAge.Location = New System.Drawing.Point(673, 4)
        Me.tAge.Name = "tAge"
        Me.tAge.ReadOnly = True
        Me.tAge.Size = New System.Drawing.Size(38, 20)
        Me.tAge.TabIndex = 49
        Me.tAge.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(647, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Age:"
        '
        'tSex
        '
        Me.tSex.Location = New System.Drawing.Point(591, 4)
        Me.tSex.Name = "tSex"
        Me.tSex.ReadOnly = True
        Me.tSex.Size = New System.Drawing.Size(52, 20)
        Me.tSex.TabIndex = 47
        Me.tSex.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(567, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Sex:"
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(90, 28)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(269, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Patient Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(362, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Date:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yy h.mm  tt"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(417, 5)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(148, 20)
        Me.dtpDate.TabIndex = 42
        Me.dtpDate.Tag = "RegDate"
        '
        'tRefNo
        '
        Me.tRefNo.Location = New System.Drawing.Point(276, 6)
        Me.tRefNo.Name = "tRefNo"
        Me.tRefNo.ReadOnly = True
        Me.tRefNo.Size = New System.Drawing.Size(81, 20)
        Me.tRefNo.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(235, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Ref No:"
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(171, 5)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 7
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(88, 6)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(82, 20)
        Me.tPatientNo.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Patient No:"
        '
        'PanMainCommand
        '
        Me.PanMainCommand.BackColor = System.Drawing.Color.LightYellow
        Me.PanMainCommand.Controls.Add(Me.PanProcedure)
        Me.PanMainCommand.Controls.Add(Me.cmdOk)
        Me.PanMainCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMainCommand.Location = New System.Drawing.Point(182, 139)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(745, 48)
        Me.PanMainCommand.TabIndex = 61
        '
        'PanProcedure
        '
        Me.PanProcedure.Controls.Add(Me.RadProcedures)
        Me.PanProcedure.Controls.Add(Me.RadInjection)
        Me.PanProcedure.Location = New System.Drawing.Point(2, 14)
        Me.PanProcedure.Name = "PanProcedure"
        Me.PanProcedure.Size = New System.Drawing.Size(206, 24)
        Me.PanProcedure.TabIndex = 256
        Me.PanProcedure.Visible = False
        '
        'RadProcedures
        '
        Me.RadProcedures.AutoSize = True
        Me.RadProcedures.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadProcedures.ForeColor = System.Drawing.Color.DarkRed
        Me.RadProcedures.Location = New System.Drawing.Point(84, 4)
        Me.RadProcedures.Name = "RadProcedures"
        Me.RadProcedures.Size = New System.Drawing.Size(118, 17)
        Me.RadProcedures.TabIndex = 3
        Me.RadProcedures.Text = "Minor Procedure"
        Me.RadProcedures.UseVisualStyleBackColor = True
        '
        'RadInjection
        '
        Me.RadInjection.AutoSize = True
        Me.RadInjection.Checked = True
        Me.RadInjection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadInjection.ForeColor = System.Drawing.Color.DarkRed
        Me.RadInjection.Location = New System.Drawing.Point(1, 4)
        Me.RadInjection.Name = "RadInjection"
        Me.RadInjection.Size = New System.Drawing.Size(74, 17)
        Me.RadInjection.TabIndex = 2
        Me.RadInjection.TabStop = True
        Me.RadInjection.Text = "Injection"
        Me.RadInjection.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(288, 2)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(71, 44)
        Me.cmdOk.TabIndex = 250
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 64)
        Me.Panel5.Name = "Panel5"
        Me.tblMain.SetRowSpan(Me.Panel5, 3)
        Me.Panel5.Size = New System.Drawing.Size(176, 481)
        Me.Panel5.TabIndex = 63
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.58253!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel9, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel10, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.43299!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.56701!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(400, 256)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel9.Controls.Add(Me.lblDistribution)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(4, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(392, 30)
        Me.Panel9.TabIndex = 0
        '
        'lblDistribution
        '
        Me.lblDistribution.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDistribution.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistribution.ForeColor = System.Drawing.Color.White
        Me.lblDistribution.Location = New System.Drawing.Point(0, 0)
        Me.lblDistribution.Name = "lblDistribution"
        Me.lblDistribution.Size = New System.Drawing.Size(392, 30)
        Me.lblDistribution.TabIndex = 38
        Me.lblDistribution.Text = "Distribution for Consultation"
        Me.lblDistribution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.lnkRefresh)
        Me.Panel10.Controls.Add(Me.PanConsultation)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.lnkAppointment)
        Me.Panel10.Controls.Add(Me.chkFollowUp)
        Me.Panel10.Controls.Add(Me.chkUrgent)
        Me.Panel10.Controls.Add(Me.cmdCancelPost)
        Me.Panel10.Controls.Add(Me.cmdPOST)
        Me.Panel10.Controls.Add(Me.cDoctor)
        Me.Panel10.Controls.Add(Me.lblDistributeTo)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(4, 41)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(392, 211)
        Me.Panel10.TabIndex = 1
        '
        'lnkRefresh
        '
        Me.lnkRefresh.AutoSize = True
        Me.lnkRefresh.Location = New System.Drawing.Point(7, 96)
        Me.lnkRefresh.Name = "lnkRefresh"
        Me.lnkRefresh.Size = New System.Drawing.Size(44, 13)
        Me.lnkRefresh.TabIndex = 72
        Me.lnkRefresh.TabStop = True
        Me.lnkRefresh.Text = "Refresh"
        '
        'PanConsultation
        '
        Me.PanConsultation.Controls.Add(Me.tConsultationFee)
        Me.PanConsultation.Controls.Add(Me.Label23)
        Me.PanConsultation.Location = New System.Drawing.Point(80, 130)
        Me.PanConsultation.Name = "PanConsultation"
        Me.PanConsultation.Size = New System.Drawing.Size(190, 24)
        Me.PanConsultation.TabIndex = 69
        '
        'tConsultationFee
        '
        Me.tConsultationFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tConsultationFee.Location = New System.Drawing.Point(94, 2)
        Me.tConsultationFee.Name = "tConsultationFee"
        Me.tConsultationFee.Size = New System.Drawing.Size(86, 20)
        Me.tConsultationFee.TabIndex = 67
        Me.tConsultationFee.Tag = ""
        Me.tConsultationFee.Text = "0"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(2, 5)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(89, 13)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "Consultation Fee:"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.cmdUnRegistered)
        Me.Panel11.Controls.Add(Me.tAccount1)
        Me.Panel11.Controls.Add(Me.Label26)
        Me.Panel11.Controls.Add(Me.tAge1)
        Me.Panel11.Controls.Add(Me.Label27)
        Me.Panel11.Controls.Add(Me.tSex1)
        Me.Panel11.Controls.Add(Me.Label28)
        Me.Panel11.Controls.Add(Me.tPatientName1)
        Me.Panel11.Controls.Add(Me.Label29)
        Me.Panel11.Controls.Add(Me.Label30)
        Me.Panel11.Controls.Add(Me.dtpDate1)
        Me.Panel11.Controls.Add(Me.cmdPatient1)
        Me.Panel11.Controls.Add(Me.tPatientIDNo)
        Me.Panel11.Controls.Add(Me.Label35)
        Me.Panel11.Location = New System.Drawing.Point(2, 2)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(440, 78)
        Me.Panel11.TabIndex = 65
        '
        'cmdUnRegistered
        '
        Me.cmdUnRegistered.Location = New System.Drawing.Point(187, 5)
        Me.cmdUnRegistered.Name = "cmdUnRegistered"
        Me.cmdUnRegistered.Size = New System.Drawing.Size(31, 21)
        Me.cmdUnRegistered.TabIndex = 64
        Me.cmdUnRegistered.Text = "OP"
        Me.cmdUnRegistered.UseVisualStyleBackColor = True
        '
        'tAccount1
        '
        Me.tAccount1.Location = New System.Drawing.Point(78, 50)
        Me.tAccount1.Name = "tAccount1"
        Me.tAccount1.ReadOnly = True
        Me.tAccount1.Size = New System.Drawing.Size(225, 20)
        Me.tAccount1.TabIndex = 51
        Me.tAccount1.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(4, 53)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 13)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Account:"
        '
        'tAge1
        '
        Me.tAge1.Location = New System.Drawing.Point(338, 52)
        Me.tAge1.Name = "tAge1"
        Me.tAge1.ReadOnly = True
        Me.tAge1.Size = New System.Drawing.Size(40, 20)
        Me.tAge1.TabIndex = 49
        Me.tAge1.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(303, 54)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 13)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "Age:"
        '
        'tSex1
        '
        Me.tSex1.Location = New System.Drawing.Point(336, 28)
        Me.tSex1.Name = "tSex1"
        Me.tSex1.ReadOnly = True
        Me.tSex1.Size = New System.Drawing.Size(42, 20)
        Me.tSex1.TabIndex = 47
        Me.tSex1.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(303, 31)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(28, 13)
        Me.Label28.TabIndex = 46
        Me.Label28.Text = "Sex:"
        '
        'tPatientName1
        '
        Me.tPatientName1.Location = New System.Drawing.Point(78, 28)
        Me.tPatientName1.Name = "tPatientName1"
        Me.tPatientName1.ReadOnly = True
        Me.tPatientName1.Size = New System.Drawing.Size(225, 20)
        Me.tPatientName1.TabIndex = 45
        Me.tPatientName1.TabStop = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(4, 31)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 13)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "Patient Name:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(243, 10)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 13)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "Date:"
        '
        'dtpDate1
        '
        Me.dtpDate1.CustomFormat = "dd-MMM-yy"
        Me.dtpDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate1.Location = New System.Drawing.Point(280, 6)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(98, 20)
        Me.dtpDate1.TabIndex = 42
        Me.dtpDate1.Tag = "RegDate"
        '
        'cmdPatient1
        '
        Me.cmdPatient1.Location = New System.Drawing.Point(161, 5)
        Me.cmdPatient1.Name = "cmdPatient1"
        Me.cmdPatient1.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient1.TabIndex = 7
        Me.cmdPatient1.Text = "..."
        Me.cmdPatient1.UseVisualStyleBackColor = True
        '
        'tPatientIDNo
        '
        Me.tPatientIDNo.Location = New System.Drawing.Point(78, 6)
        Me.tPatientIDNo.Name = "tPatientIDNo"
        Me.tPatientIDNo.Size = New System.Drawing.Size(82, 20)
        Me.tPatientIDNo.TabIndex = 6
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(4, 9)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(60, 13)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "Patient No:"
        '
        'lnkAppointment
        '
        Me.lnkAppointment.AutoSize = True
        Me.lnkAppointment.Location = New System.Drawing.Point(224, 110)
        Me.lnkAppointment.Name = "lnkAppointment"
        Me.lnkAppointment.Size = New System.Drawing.Size(127, 13)
        Me.lnkAppointment.TabIndex = 64
        Me.lnkAppointment.TabStop = True
        Me.lnkAppointment.Text = "View current appointment"
        '
        'chkFollowUp
        '
        Me.chkFollowUp.AutoSize = True
        Me.chkFollowUp.ForeColor = System.Drawing.Color.Red
        Me.chkFollowUp.Location = New System.Drawing.Point(156, 108)
        Me.chkFollowUp.Name = "chkFollowUp"
        Me.chkFollowUp.Size = New System.Drawing.Size(71, 17)
        Me.chkFollowUp.TabIndex = 63
        Me.chkFollowUp.Text = "Follow-up"
        Me.chkFollowUp.UseVisualStyleBackColor = True
        '
        'chkUrgent
        '
        Me.chkUrgent.AutoSize = True
        Me.chkUrgent.ForeColor = System.Drawing.Color.Red
        Me.chkUrgent.Location = New System.Drawing.Point(80, 108)
        Me.chkUrgent.Name = "chkUrgent"
        Me.chkUrgent.Size = New System.Drawing.Size(79, 17)
        Me.chkUrgent.TabIndex = 62
        Me.chkUrgent.Text = "Emergency"
        Me.chkUrgent.UseVisualStyleBackColor = True
        '
        'cmdCancelPost
        '
        Me.cmdCancelPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelPost.Location = New System.Drawing.Point(8, 161)
        Me.cmdCancelPost.Name = "cmdCancelPost"
        Me.cmdCancelPost.Size = New System.Drawing.Size(70, 40)
        Me.cmdCancelPost.TabIndex = 60
        Me.cmdCancelPost.Text = "Cancel Post"
        Me.cmdCancelPost.UseVisualStyleBackColor = True
        '
        'cmdPOST
        '
        Me.cmdPOST.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPOST.Location = New System.Drawing.Point(90, 161)
        Me.cmdPOST.Name = "cmdPOST"
        Me.cmdPOST.Size = New System.Drawing.Size(140, 40)
        Me.cmdPOST.TabIndex = 59
        Me.cmdPOST.Text = "POST"
        Me.cmdPOST.UseVisualStyleBackColor = True
        '
        'cDoctor
        '
        Me.cDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cDoctor.FormattingEnabled = True
        Me.cDoctor.Location = New System.Drawing.Point(81, 81)
        Me.cDoctor.Name = "cDoctor"
        Me.cDoctor.Size = New System.Drawing.Size(251, 21)
        Me.cDoctor.TabIndex = 50
        Me.cDoctor.Tag = ""
        '
        'lblDistributeTo
        '
        Me.lblDistributeTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistributeTo.ForeColor = System.Drawing.Color.Black
        Me.lblDistributeTo.Location = New System.Drawing.Point(6, 84)
        Me.lblDistributeTo.Name = "lblDistributeTo"
        Me.lblDistributeTo.Size = New System.Drawing.Size(66, 34)
        Me.lblDistributeTo.TabIndex = 49
        Me.lblDistributeTo.Text = "Doctor:"
        '
        'tblProcedure
        '
        Me.tblProcedure.ColumnCount = 1
        Me.tblProcedure.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.61798!))
        Me.tblProcedure.Controls.Add(Me.DbGrid, 0, 0)
        Me.tblProcedure.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.tblProcedure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblProcedure.Location = New System.Drawing.Point(185, 190)
        Me.tblProcedure.Name = "tblProcedure"
        Me.tblProcedure.RowCount = 2
        Me.tblProcedure.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.982036!))
        Me.tblProcedure.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.01797!))
        Me.tblProcedure.Size = New System.Drawing.Size(739, 355)
        Me.tblProcedure.TabIndex = 64
        '
        'DbGrid
        '
        Me.DbGrid.AllowUserToAddRows = False
        Me.DbGrid.AllowUserToDeleteRows = False
        Me.DbGrid.BackgroundColor = System.Drawing.Color.Lavender
        Me.DbGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VitalSign, Me.Result})
        Me.DbGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGrid.Location = New System.Drawing.Point(3, 3)
        Me.DbGrid.MultiSelect = False
        Me.DbGrid.Name = "DbGrid"
        Me.DbGrid.RowHeadersWidth = 20
        Me.DbGrid.Size = New System.Drawing.Size(733, 25)
        Me.DbGrid.TabIndex = 242
        '
        'VitalSign
        '
        Me.VitalSign.DataPropertyName = "VitalSign"
        Me.VitalSign.DividerWidth = 2
        Me.VitalSign.HeaderText = "Vital Sign"
        Me.VitalSign.Name = "VitalSign"
        Me.VitalSign.ReadOnly = True
        Me.VitalSign.Width = 140
        '
        'Result
        '
        Me.Result.DataPropertyName = "Result"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Result.DefaultCellStyle = DataGridViewCellStyle1
        Me.Result.HeaderText = "Result"
        Me.Result.Name = "Result"
        Me.Result.Width = 180
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.tblDetails, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 34)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(733, 318)
        Me.TableLayoutPanel4.TabIndex = 243
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel7, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label22, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.tRequest, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 116)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(360, 199)
        Me.TableLayoutPanel5.TabIndex = 278
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightYellow
        Me.Panel7.Controls.Add(Me.lblSelectedMenu)
        Me.Panel7.Controls.Add(Me.dtpPeriod)
        Me.Panel7.Controls.Add(Me.cboPeriod)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(1, 171)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(358, 24)
        Me.Panel7.TabIndex = 11
        '
        'lblSelectedMenu
        '
        Me.lblSelectedMenu.AutoSize = True
        Me.lblSelectedMenu.Location = New System.Drawing.Point(4, 6)
        Me.lblSelectedMenu.Name = "lblSelectedMenu"
        Me.lblSelectedMenu.Size = New System.Drawing.Size(76, 13)
        Me.lblSelectedMenu.TabIndex = 3
        Me.lblSelectedMenu.Text = "Request Date:"
        '
        'dtpPeriod
        '
        Me.dtpPeriod.CustomFormat = "dd-MMM-yyyy"
        Me.dtpPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriod.Location = New System.Drawing.Point(166, 3)
        Me.dtpPeriod.Name = "dtpPeriod"
        Me.dtpPeriod.Size = New System.Drawing.Size(93, 18)
        Me.dtpPeriod.TabIndex = 2
        '
        'cboPeriod
        '
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboPeriod.FormattingEnabled = True
        Me.cboPeriod.Items.AddRange(New Object() {"Last", "Today"})
        Me.cboPeriod.Location = New System.Drawing.Point(87, 2)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(76, 21)
        Me.cboPeriod.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.SteelBlue
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(1, 4)
        Me.Label22.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(358, 23)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Procedure Request"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tRequest
        '
        Me.tRequest.BackColor = System.Drawing.Color.White
        Me.tRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRequest.Location = New System.Drawing.Point(4, 31)
        Me.tRequest.Multiline = True
        Me.tRequest.Name = "tRequest"
        Me.tRequest.ReadOnly = True
        Me.tRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tRequest.Size = New System.Drawing.Size(352, 133)
        Me.tRequest.TabIndex = 10
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lvRequest, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel6, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(366, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel4.SetRowSpan(Me.TableLayoutPanel6, 2)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(367, 318)
        Me.TableLayoutPanel6.TabIndex = 11
        '
        'lvRequest
        '
        Me.lvRequest.BackColor = System.Drawing.Color.LemonChiffon
        Me.lvRequest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader16})
        Me.lvRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRequest.FullRowSelect = True
        Me.lvRequest.GridLines = True
        Me.lvRequest.HideSelection = False
        Me.lvRequest.Location = New System.Drawing.Point(1, 36)
        Me.lvRequest.Margin = New System.Windows.Forms.Padding(0)
        Me.lvRequest.MultiSelect = False
        Me.lvRequest.Name = "lvRequest"
        Me.lvRequest.Size = New System.Drawing.Size(365, 281)
        Me.lvRequest.TabIndex = 11
        Me.lvRequest.UseCompatibleStateImageBehavior = False
        Me.lvRequest.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Patient No"
        Me.ColumnHeader1.Width = 65
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Surname"
        Me.ColumnHeader2.Width = 75
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Othernames"
        Me.ColumnHeader13.Width = 97
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Account"
        Me.ColumnHeader14.Width = 121
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Sex"
        Me.ColumnHeader16.Width = 45
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cmdRefreshRequest)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(359, 28)
        Me.Panel6.TabIndex = 12
        '
        'cmdRefreshRequest
        '
        Me.cmdRefreshRequest.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdRefreshRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefreshRequest.ForeColor = System.Drawing.Color.Black
        Me.cmdRefreshRequest.Location = New System.Drawing.Point(272, 0)
        Me.cmdRefreshRequest.Name = "cmdRefreshRequest"
        Me.cmdRefreshRequest.Size = New System.Drawing.Size(87, 28)
        Me.cmdRefreshRequest.TabIndex = 260
        Me.cmdRefreshRequest.Text = "&Refresh"
        Me.cmdRefreshRequest.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.SteelBlue
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(0, 0)
        Me.Label20.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(359, 28)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Patients with Request"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblDetails
        '
        Me.tblDetails.ColumnCount = 2
        Me.tblDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDetails.Controls.Add(Me.PanOthers, 1, 0)
        Me.tblDetails.Controls.Add(Me.PanInjection, 0, 0)
        Me.tblDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDetails.Location = New System.Drawing.Point(3, 3)
        Me.tblDetails.Name = "tblDetails"
        Me.tblDetails.RowCount = 1
        Me.tblDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDetails.Size = New System.Drawing.Size(360, 107)
        Me.tblDetails.TabIndex = 277
        '
        'PanOthers
        '
        Me.PanOthers.Controls.Add(Me.Label12)
        Me.PanOthers.Controls.Add(Me.Label15)
        Me.PanOthers.Controls.Add(Me.cProcedureType)
        Me.PanOthers.Controls.Add(Me.tComment)
        Me.PanOthers.Controls.Add(Me.Label14)
        Me.PanOthers.Controls.Add(Me.tIndication)
        Me.PanOthers.Controls.Add(Me.Label13)
        Me.PanOthers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanOthers.Location = New System.Drawing.Point(180, 0)
        Me.PanOthers.Margin = New System.Windows.Forms.Padding(0)
        Me.PanOthers.Name = "PanOthers"
        Me.PanOthers.Size = New System.Drawing.Size(180, 107)
        Me.PanOthers.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Procedure Type:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(2, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Comment:"
        '
        'cProcedureType
        '
        Me.cProcedureType.BackColor = System.Drawing.Color.White
        Me.cProcedureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cProcedureType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cProcedureType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cProcedureType.FormattingEnabled = True
        Me.cProcedureType.Items.AddRange(New Object() {"Incision & Drainage", "Foreign Body Removal", "Ear Syringing", "Suturing of Minor Injuries", "Wound Dressing"})
        Me.cProcedureType.Location = New System.Drawing.Point(88, 4)
        Me.cProcedureType.Name = "cProcedureType"
        Me.cProcedureType.Size = New System.Drawing.Size(173, 21)
        Me.cProcedureType.TabIndex = 63
        '
        'tComment
        '
        Me.tComment.Location = New System.Drawing.Point(88, 52)
        Me.tComment.Multiline = True
        Me.tComment.Name = "tComment"
        Me.tComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tComment.Size = New System.Drawing.Size(248, 52)
        Me.tComment.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Outcome/"
        '
        'tIndication
        '
        Me.tIndication.Location = New System.Drawing.Point(88, 29)
        Me.tIndication.Name = "tIndication"
        Me.tIndication.Size = New System.Drawing.Size(248, 20)
        Me.tIndication.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(2, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Indication:"
        '
        'PanInjection
        '
        Me.PanInjection.Controls.Add(Me.tCommentInj)
        Me.PanInjection.Controls.Add(Me.Label24)
        Me.PanInjection.Controls.Add(Me.Label17)
        Me.PanInjection.Controls.Add(Me.cMode)
        Me.PanInjection.Controls.Add(Me.tDosage)
        Me.PanInjection.Controls.Add(Me.Label19)
        Me.PanInjection.Controls.Add(Me.tInjection)
        Me.PanInjection.Controls.Add(Me.Label21)
        Me.PanInjection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanInjection.Location = New System.Drawing.Point(0, 0)
        Me.PanInjection.Margin = New System.Windows.Forms.Padding(0)
        Me.PanInjection.Name = "PanInjection"
        Me.PanInjection.Size = New System.Drawing.Size(180, 107)
        Me.PanInjection.TabIndex = 58
        '
        'tCommentInj
        '
        Me.tCommentInj.Location = New System.Drawing.Point(80, 70)
        Me.tCommentInj.Multiline = True
        Me.tCommentInj.Name = "tCommentInj"
        Me.tCommentInj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tCommentInj.Size = New System.Drawing.Size(245, 33)
        Me.tCommentInj.TabIndex = 67
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 71)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 13)
        Me.Label24.TabIndex = 66
        Me.Label24.Text = "Comment:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Mode:"
        '
        'cMode
        '
        Me.cMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cMode.FormattingEnabled = True
        Me.cMode.Items.AddRange(New Object() {"Intramuscular", "Intravenous", "Intralesional", "Oral", "Guttate", "Supository", "Pessaries", "Interthecal", "Intra-articular", "Intra-arterial", "Subcutaneous", "Sublingual", "Rectal"})
        Me.cMode.Location = New System.Drawing.Point(81, 45)
        Me.cMode.Name = "cMode"
        Me.cMode.Size = New System.Drawing.Size(115, 21)
        Me.cMode.TabIndex = 64
        '
        'tDosage
        '
        Me.tDosage.Location = New System.Drawing.Point(79, 22)
        Me.tDosage.Name = "tDosage"
        Me.tDosage.Size = New System.Drawing.Size(245, 20)
        Me.tDosage.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Dosage:"
        '
        'tInjection
        '
        Me.tInjection.Location = New System.Drawing.Point(79, 0)
        Me.tInjection.Name = "tInjection"
        Me.tInjection.Size = New System.Drawing.Size(245, 20)
        Me.tInjection.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 3)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Injection:"
        '
        'Panel8
        '
        Me.tblMain.SetColumnSpan(Me.Panel8, 2)
        Me.Panel8.Controls.Add(Me.PanAction)
        Me.Panel8.Controls.Add(Me.lnkFinancialState)
        Me.Panel8.Controls.Add(Me.LblDescAction)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(921, 55)
        Me.Panel8.TabIndex = 65
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanAction.Location = New System.Drawing.Point(716, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.PanAction.Size = New System.Drawing.Size(205, 55)
        Me.PanAction.TabIndex = 256
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
        'lnkFinancialState
        '
        Me.lnkFinancialState.AutoSize = True
        Me.lnkFinancialState.Location = New System.Drawing.Point(2, 20)
        Me.lnkFinancialState.Name = "lnkFinancialState"
        Me.lnkFinancialState.Size = New System.Drawing.Size(147, 13)
        Me.lnkFinancialState.TabIndex = 255
        Me.lnkFinancialState.TabStop = True
        Me.lnkFinancialState.Text = "Check Patient Financial State"
        '
        'LblDescAction
        '
        Me.LblDescAction.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblDescAction.BackColor = System.Drawing.Color.Transparent
        Me.LblDescAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescAction.ForeColor = System.Drawing.Color.DarkRed
        Me.LblDescAction.Location = New System.Drawing.Point(240, 17)
        Me.LblDescAction.Name = "LblDescAction"
        Me.LblDescAction.Size = New System.Drawing.Size(256, 20)
        Me.LblDescAction.TabIndex = 62
        Me.LblDescAction.Text = "..."
        Me.LblDescAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimAppointment
        '
        Me.TimAppointment.Enabled = True
        Me.TimAppointment.Interval = 30000
        '
        'TimRequest
        '
        Me.TimRequest.Enabled = True
        Me.TimRequest.Interval = 30000
        '
        'FrmNursingStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1284, 648)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNursingStation"
        Me.Text = "Nursing Station"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SelCol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tblMain.ResumeLayout(False)
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.PanMainCommand.ResumeLayout(False)
        Me.PanProcedure.ResumeLayout(False)
        Me.PanProcedure.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.PanConsultation.ResumeLayout(False)
        Me.PanConsultation.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.tblProcedure.ResumeLayout(False)
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.tblDetails.ResumeLayout(False)
        Me.PanOthers.ResumeLayout(False)
        Me.PanOthers.PerformLayout()
        Me.PanInjection.ResumeLayout(False)
        Me.PanInjection.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuVitals As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCLOSE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProcedure As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cNursingStation As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SelColumn As System.Windows.Forms.TextBox
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdFilter As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SelCol As System.Windows.Forms.NumericUpDown
    Friend WithEvents RasDescend As System.Windows.Forms.RadioButton
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents RadAscend As System.Windows.Forms.RadioButton
    Friend WithEvents cmdSort As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents tFilter As System.Windows.Forms.TextBox
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lvAppointment As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimAppointment As System.Windows.Forms.Timer
    Friend WithEvents tblMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents tPerformedBy As System.Windows.Forms.TextBox
    Friend WithEvents cmdPerform As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tAge As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tSex As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mnuDistribution As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblDescAction As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
    Friend WithEvents lnkFinancialState As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents tblProcedure As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DbGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvRequest As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdRefreshRequest As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tblDetails As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanOthers As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cProcedureType As System.Windows.Forms.ComboBox
    Friend WithEvents tComment As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tIndication As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PanInjection As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cMode As System.Windows.Forms.ComboBox
    Friend WithEvents tDosage As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tInjection As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lblSelectedMenu As System.Windows.Forms.Label
    Friend WithEvents dtpPeriod As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tRequest As System.Windows.Forms.TextBox
    Friend WithEvents PanProcedure As System.Windows.Forms.Panel
    Friend WithEvents RadProcedures As System.Windows.Forms.RadioButton
    Friend WithEvents RadInjection As System.Windows.Forms.RadioButton
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents TimRequest As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents lblDistribution As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelPost As System.Windows.Forms.Button
    Friend WithEvents cmdPOST As System.Windows.Forms.Button
    Friend WithEvents cDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents lblDistributeTo As System.Windows.Forms.Label
    Friend WithEvents chkFollowUp As System.Windows.Forms.CheckBox
    Friend WithEvents chkUrgent As System.Windows.Forms.CheckBox
    Friend WithEvents lnkAppointment As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents tAccount1 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents tAge1 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents tSex1 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents tPatientName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents dtpDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdPatient1 As System.Windows.Forms.Button
    Friend WithEvents tPatientIDNo As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents PanConsultation As System.Windows.Forms.Panel
    Friend WithEvents tConsultationFee As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents VitalSign As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Result As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tCommentInj As System.Windows.Forms.TextBox
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents lnkRefresh As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdUnRegistered As System.Windows.Forms.Button
    Friend WithEvents cmdUnregisteredPatient1 As System.Windows.Forms.Button
End Class
