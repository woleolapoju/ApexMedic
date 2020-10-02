<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoaster
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoaster))
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.lblCaption = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TimAppointment = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lvMedicalStaff = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.PanConsultingRoom = New System.Windows.Forms.Panel
        Me.cFilter = New System.Windows.Forms.ComboBox
        Me.lblDistributeTo = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.chkSun = New System.Windows.Forms.CheckBox
        Me.chkSat = New System.Windows.Forms.CheckBox
        Me.chkFri = New System.Windows.Forms.CheckBox
        Me.chkThu = New System.Windows.Forms.CheckBox
        Me.chkWed = New System.Windows.Forms.CheckBox
        Me.chkTue = New System.Windows.Forms.CheckBox
        Me.chkMon = New System.Windows.Forms.CheckBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.DbGrid = New System.Windows.Forms.DataGridView
        Me.Venue = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeFrom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeTo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TheDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SelCol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanConsultingRoom.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.Controls.Add(Me.lblCaption, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label10, 1, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.66667!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.33333!))
        Me.tblHeader.Size = New System.Drawing.Size(752, 56)
        Me.tblHeader.TabIndex = 59
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
        Me.lblCaption.Size = New System.Drawing.Size(626, 28)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "STAFF DUTY ROASTER"
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
        Me.PictureBox1.Size = New System.Drawing.Size(126, 56)
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
        Me.Label10.Location = New System.Drawing.Point(126, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(626, 28)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Manages Staff Roaster"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimAppointment
        '
        Me.TimAppointment.Enabled = True
        Me.TimAppointment.Interval = 30000
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 377.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanConsultingRoom, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 56)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(752, 597)
        Me.TableLayoutPanel1.TabIndex = 60
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 503)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(375, 94)
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
        Me.Panel1.Size = New System.Drawing.Size(351, 79)
        Me.Panel1.TabIndex = 4
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
        Me.lblCount.Location = New System.Drawing.Point(179, 58)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(28, 19)
        Me.lblCount.TabIndex = 13
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 55)
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
        Me.cmdFilter.Location = New System.Drawing.Point(135, 4)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(60, 27)
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
        Me.cmdSort.Size = New System.Drawing.Size(50, 27)
        Me.cmdSort.TabIndex = 10
        Me.cmdSort.Text = "Sor&t"
        Me.cmdSort.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdRefresh.Location = New System.Drawing.Point(194, 4)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(55, 27)
        Me.cmdRefresh.TabIndex = 14
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'tFilter
        '
        Me.tFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFilter.Location = New System.Drawing.Point(44, 33)
        Me.tFilter.Name = "tFilter"
        Me.tFilter.Size = New System.Drawing.Size(266, 20)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lvMedicalStaff)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(375, 471)
        Me.Panel2.TabIndex = 6
        '
        'lvMedicalStaff
        '
        Me.lvMedicalStaff.BackColor = System.Drawing.Color.GhostWhite
        Me.lvMedicalStaff.CheckBoxes = True
        Me.lvMedicalStaff.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader1})
        Me.lvMedicalStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMedicalStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMedicalStaff.FullRowSelect = True
        Me.lvMedicalStaff.GridLines = True
        Me.lvMedicalStaff.HideSelection = False
        Me.lvMedicalStaff.Location = New System.Drawing.Point(0, 0)
        Me.lvMedicalStaff.MultiSelect = False
        Me.lvMedicalStaff.Name = "lvMedicalStaff"
        Me.lvMedicalStaff.Size = New System.Drawing.Size(375, 471)
        Me.lvMedicalStaff.TabIndex = 3
        Me.lvMedicalStaff.UseCompatibleStateImageBehavior = False
        Me.lvMedicalStaff.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Staff No"
        Me.ColumnHeader7.Width = 65
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Full Name"
        Me.ColumnHeader8.Width = 167
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Doctor"
        Me.ColumnHeader10.Width = 46
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Consultant"
        Me.ColumnHeader11.Width = 61
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Speciality"
        Me.ColumnHeader1.Width = 86
        '
        'PanConsultingRoom
        '
        Me.PanConsultingRoom.BackColor = System.Drawing.Color.LightYellow
        Me.PanConsultingRoom.Controls.Add(Me.cFilter)
        Me.PanConsultingRoom.Controls.Add(Me.lblDistributeTo)
        Me.PanConsultingRoom.Location = New System.Drawing.Point(0, 0)
        Me.PanConsultingRoom.Margin = New System.Windows.Forms.Padding(0)
        Me.PanConsultingRoom.Name = "PanConsultingRoom"
        Me.PanConsultingRoom.Size = New System.Drawing.Size(375, 32)
        Me.PanConsultingRoom.TabIndex = 7
        '
        'cFilter
        '
        Me.cFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cFilter.FormattingEnabled = True
        Me.cFilter.Items.AddRange(New Object() {"ALL", "Doctors", "Non-Doctors"})
        Me.cFilter.Location = New System.Drawing.Point(57, 4)
        Me.cFilter.Name = "cFilter"
        Me.cFilter.Size = New System.Drawing.Size(172, 23)
        Me.cFilter.TabIndex = 54
        Me.cFilter.Tag = ""
        '
        'lblDistributeTo
        '
        Me.lblDistributeTo.AutoSize = True
        Me.lblDistributeTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistributeTo.ForeColor = System.Drawing.Color.Black
        Me.lblDistributeTo.Location = New System.Drawing.Point(3, 8)
        Me.lblDistributeTo.Name = "lblDistributeTo"
        Me.lblDistributeTo.Size = New System.Drawing.Size(47, 13)
        Me.lblDistributeTo.TabIndex = 53
        Me.lblDistributeTo.Text = "Filter By:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightYellow
        Me.Panel3.Controls.Add(Me.dtpDateTo)
        Me.Panel3.Controls.Add(Me.dtpDateFrom)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(375, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(377, 32)
        Me.Panel3.TabIndex = 8
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(199, 6)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(109, 20)
        Me.dtpDateTo.TabIndex = 66
        Me.dtpDateTo.Tag = "RegDate"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(52, 7)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(112, 20)
        Me.dtpDateFrom.TabIndex = 65
        Me.dtpDateFrom.Tag = "RegDate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Days available:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.chkSun)
        Me.Panel4.Controls.Add(Me.chkSat)
        Me.Panel4.Controls.Add(Me.chkFri)
        Me.Panel4.Controls.Add(Me.chkThu)
        Me.Panel4.Controls.Add(Me.chkWed)
        Me.Panel4.Controls.Add(Me.chkTue)
        Me.Panel4.Controls.Add(Me.chkMon)
        Me.Panel4.Location = New System.Drawing.Point(7, 186)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(47, 162)
        Me.Panel4.TabIndex = 64
        '
        'chkSun
        '
        Me.chkSun.AutoSize = True
        Me.chkSun.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSun.Location = New System.Drawing.Point(0, 100)
        Me.chkSun.Name = "chkSun"
        Me.chkSun.Size = New System.Drawing.Size(45, 17)
        Me.chkSun.TabIndex = 538
        Me.chkSun.Tag = ""
        Me.chkSun.Text = "Sun"
        Me.chkSun.UseVisualStyleBackColor = True
        '
        'chkSat
        '
        Me.chkSat.AutoSize = True
        Me.chkSat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSat.Location = New System.Drawing.Point(2, 84)
        Me.chkSat.Name = "chkSat"
        Me.chkSat.Size = New System.Drawing.Size(42, 17)
        Me.chkSat.TabIndex = 537
        Me.chkSat.Tag = ""
        Me.chkSat.Text = "Sat"
        Me.chkSat.UseVisualStyleBackColor = True
        '
        'chkFri
        '
        Me.chkFri.AutoSize = True
        Me.chkFri.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFri.Location = New System.Drawing.Point(2, 70)
        Me.chkFri.Name = "chkFri"
        Me.chkFri.Size = New System.Drawing.Size(37, 17)
        Me.chkFri.TabIndex = 536
        Me.chkFri.Tag = ""
        Me.chkFri.Text = "Fri"
        Me.chkFri.UseVisualStyleBackColor = True
        '
        'chkThu
        '
        Me.chkThu.AutoSize = True
        Me.chkThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkThu.Location = New System.Drawing.Point(2, 54)
        Me.chkThu.Name = "chkThu"
        Me.chkThu.Size = New System.Drawing.Size(43, 17)
        Me.chkThu.TabIndex = 535
        Me.chkThu.Tag = ""
        Me.chkThu.Text = "Thu"
        Me.chkThu.UseVisualStyleBackColor = True
        '
        'chkWed
        '
        Me.chkWed.AutoSize = True
        Me.chkWed.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWed.Location = New System.Drawing.Point(2, 38)
        Me.chkWed.Name = "chkWed"
        Me.chkWed.Size = New System.Drawing.Size(47, 17)
        Me.chkWed.TabIndex = 534
        Me.chkWed.Tag = ""
        Me.chkWed.Text = "Wed"
        Me.chkWed.UseVisualStyleBackColor = True
        '
        'chkTue
        '
        Me.chkTue.AutoSize = True
        Me.chkTue.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTue.Location = New System.Drawing.Point(2, 22)
        Me.chkTue.Name = "chkTue"
        Me.chkTue.Size = New System.Drawing.Size(43, 17)
        Me.chkTue.TabIndex = 533
        Me.chkTue.Tag = ""
        Me.chkTue.Text = "Tue"
        Me.chkTue.UseVisualStyleBackColor = True
        '
        'chkMon
        '
        Me.chkMon.AutoSize = True
        Me.chkMon.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMon.Location = New System.Drawing.Point(2, 6)
        Me.chkMon.Name = "chkMon"
        Me.chkMon.Size = New System.Drawing.Size(47, 17)
        Me.chkMon.TabIndex = 532
        Me.chkMon.Tag = ""
        Me.chkMon.Text = "Mon"
        Me.chkMon.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALL", "Doctors", "Non-Doctors"})
        Me.ComboBox1.Location = New System.Drawing.Point(71, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(189, 21)
        Me.ComboBox1.TabIndex = 62
        Me.ComboBox1.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(21, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Venue:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 46)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIME"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "h.mm  tt"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(152, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(74, 20)
        Me.DateTimePicker1.TabIndex = 57
        Me.DateTimePicker1.Tag = "RegDate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "From:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "h.mm  tt"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(43, 18)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.ShowUpDown = True
        Me.dtpDate.Size = New System.Drawing.Size(74, 20)
        Me.dtpDate.TabIndex = 43
        Me.dtpDate.Tag = "RegDate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(129, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(169, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "From:"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(375, 32)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(377, 471)
        Me.Panel5.TabIndex = 66
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.Controls.Add(Me.DbGrid, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmdClose, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmdOk, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(377, 471)
        Me.TableLayoutPanel2.TabIndex = 66
        '
        'DbGrid
        '
        Me.DbGrid.AllowUserToAddRows = False
        Me.DbGrid.AllowUserToDeleteRows = False
        Me.DbGrid.BackgroundColor = System.Drawing.Color.Lavender
        Me.DbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Venue, Me.Type, Me.TimeFrom, Me.TimeTo, Me.TheDate})
        Me.TableLayoutPanel2.SetColumnSpan(Me.DbGrid, 2)
        Me.DbGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGrid.Location = New System.Drawing.Point(0, 0)
        Me.DbGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.DbGrid.Name = "DbGrid"
        Me.DbGrid.RowHeadersWidth = 48
        Me.DbGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DbGrid.Size = New System.Drawing.Size(377, 431)
        Me.DbGrid.TabIndex = 65
        '
        'Venue
        '
        Me.Venue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Venue.HeaderText = "Venue"
        Me.Venue.Name = "Venue"
        Me.Venue.Width = 150
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Day"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Type.Width = 35
        '
        'TimeFrom
        '
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = "12:00"
        Me.TimeFrom.DefaultCellStyle = DataGridViewCellStyle1
        Me.TimeFrom.HeaderText = "Time From"
        Me.TimeFrom.Name = "TimeFrom"
        Me.TimeFrom.Width = 50
        '
        'TimeTo
        '
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = "23:59"
        Me.TimeTo.DefaultCellStyle = DataGridViewCellStyle2
        Me.TimeTo.HeaderText = "Time To"
        Me.TimeTo.Name = "TimeTo"
        Me.TimeTo.Width = 50
        '
        'TheDate
        '
        Me.TheDate.HeaderText = "TheDate"
        Me.TheDate.Name = "TheDate"
        Me.TheDate.ReadOnly = True
        Me.TheDate.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(0, 431)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(96, 40)
        Me.cmdClose.TabIndex = 54
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(264, 431)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(113, 39)
        Me.cmdOk.TabIndex = 56
        Me.cmdOk.Text = "&Save"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'FrmRoaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 653)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRoaster"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Roaster"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SelCol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PanConsultingRoom.ResumeLayout(False)
        Me.PanConsultingRoom.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TimAppointment As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lvMedicalStaff As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PanConsultingRoom As System.Windows.Forms.Panel
    Friend WithEvents cFilter As System.Windows.Forms.ComboBox
    Friend WithEvents lblDistributeTo As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents chkSun As System.Windows.Forms.CheckBox
    Friend WithEvents chkSat As System.Windows.Forms.CheckBox
    Friend WithEvents chkFri As System.Windows.Forms.CheckBox
    Friend WithEvents chkThu As System.Windows.Forms.CheckBox
    Friend WithEvents chkWed As System.Windows.Forms.CheckBox
    Friend WithEvents chkTue As System.Windows.Forms.CheckBox
    Friend WithEvents chkMon As System.Windows.Forms.CheckBox
    Friend WithEvents DbGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Venue As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TheDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
