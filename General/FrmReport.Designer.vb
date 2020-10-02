<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Medical", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Pharmacy", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Financial", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Statistics", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Documents", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Miscellaneous", System.Windows.Forms.HorizontalAlignment.Left)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReport))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lvList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.lvList1 = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.CR = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdPrinter = New System.Windows.Forms.Button
        Me.cOrientation = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cSize = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ChkDisplay = New System.Windows.Forms.CheckBox
        Me.PanRptTitle = New System.Windows.Forms.Panel
        Me.lblWait = New System.Windows.Forms.Label
        Me.lblRetTitle = New System.Windows.Forms.Label
        Me.FrpSelection = New System.Windows.Forms.GroupBox
        Me.chkLetterHead = New System.Windows.Forms.CheckBox
        Me.cboLayOut = New System.Windows.Forms.ComboBox
        Me.lblLayOut = New System.Windows.Forms.Label
        Me.PanDetails = New System.Windows.Forms.Panel
        Me.RadSummary = New System.Windows.Forms.RadioButton
        Me.RadDetails = New System.Windows.Forms.RadioButton
        Me.tRefNo = New System.Windows.Forms.TextBox
        Me.lblRefNo = New System.Windows.Forms.Label
        Me.tAccountName = New System.Windows.Forms.TextBox
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.cmdAccount = New System.Windows.Forms.Button
        Me.tAccountCode = New System.Windows.Forms.TextBox
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.lblEnd = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblStart = New System.Windows.Forms.Label
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.lblAccount = New System.Windows.Forms.Label
        Me.lblPatientNo = New System.Windows.Forms.Label
        Me.PanMainCmd = New System.Windows.Forms.Panel
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdOk = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TimWait = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanRptTitle.SuspendLayout()
        Me.FrpSelection.SuspendLayout()
        Me.PanDetails.SuspendLayout()
        Me.PanMainCmd.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.tblHeader, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1028, 63)
        Me.TableLayoutPanel2.TabIndex = 124
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.Controls.Add(Me.Label7, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label8, 1, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.Size = New System.Drawing.Size(1028, 59)
        Me.tblHeader.TabIndex = 52
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
        Me.Label7.Location = New System.Drawing.Point(117, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(911, 32)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "REPORTS"
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
        Me.PictureBox1.Size = New System.Drawing.Size(117, 59)
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
        Me.Label8.Location = New System.Drawing.Point(117, 32)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(911, 27)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Application Reports"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lvList, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lvList1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 63)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1028, 631)
        Me.TableLayoutPanel1.TabIndex = 125
        '
        'lvList
        '
        Me.lvList.BackColor = System.Drawing.Color.Lavender
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        ListViewGroup1.Header = "Medical"
        ListViewGroup1.Name = "GrpStd"
        ListViewGroup2.Header = "Pharmacy"
        ListViewGroup2.Name = "GrpPharmacy"
        Me.lvList.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lvList.HideSelection = False
        Me.lvList.HoverSelection = True
        Me.lvList.Location = New System.Drawing.Point(3, 0)
        Me.lvList.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.lvList.MultiSelect = False
        Me.lvList.Name = "lvList"
        Me.TableLayoutPanel1.SetRowSpan(Me.lvList, 2)
        Me.lvList.Size = New System.Drawing.Size(265, 631)
        Me.lvList.TabIndex = 2
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Report"
        Me.ColumnHeader1.Width = 243
        '
        'lvList1
        '
        Me.lvList1.BackColor = System.Drawing.Color.Lavender
        Me.lvList1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lvList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvList1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvList1.FullRowSelect = True
        Me.lvList1.GridLines = True
        ListViewGroup3.Header = "Financial"
        ListViewGroup3.Name = "GrpFinancial"
        ListViewGroup4.Header = "Statistics"
        ListViewGroup4.Name = "GrpStat"
        ListViewGroup5.Header = "Documents"
        ListViewGroup5.Name = "GrpDoc"
        ListViewGroup6.Header = "Miscellaneous"
        ListViewGroup6.Name = "GrpMisc"
        Me.lvList1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup3, ListViewGroup4, ListViewGroup5, ListViewGroup6})
        Me.lvList1.HideSelection = False
        Me.lvList1.HoverSelection = True
        Me.lvList1.Location = New System.Drawing.Point(274, 0)
        Me.lvList1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.lvList1.MultiSelect = False
        Me.lvList1.Name = "lvList1"
        Me.TableLayoutPanel1.SetRowSpan(Me.lvList1, 2)
        Me.lvList1.Size = New System.Drawing.Size(265, 631)
        Me.lvList1.TabIndex = 3
        Me.lvList1.UseCompatibleStateImageBehavior = False
        Me.lvList1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Report"
        Me.ColumnHeader2.Width = 244
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.CR, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(542, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(486, 631)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'CR
        '
        Me.CR.ActiveViewIndex = -1
        Me.CR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR.DisplayBackgroundEdge = False
        Me.CR.DisplayGroupTree = False
        Me.CR.DisplayStatusBar = False
        Me.CR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CR.EnableDrillDown = False
        Me.CR.Location = New System.Drawing.Point(0, 0)
        Me.CR.Margin = New System.Windows.Forms.Padding(0)
        Me.CR.Name = "CR"
        Me.CR.SelectionFormula = ""
        Me.CR.ShowCloseButton = False
        Me.CR.ShowGotoPageButton = False
        Me.CR.ShowGroupTreeButton = False
        Me.CR.ShowPageNavigateButtons = False
        Me.CR.ShowTextSearchButton = False
        Me.CR.Size = New System.Drawing.Size(486, 314)
        Me.CR.TabIndex = 4
        Me.CR.ViewTimeSelectionFormula = ""
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.PanMainCmd, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 314)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(486, 317)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.ChkDisplay)
        Me.Panel1.Controls.Add(Me.PanRptTitle)
        Me.Panel1.Controls.Add(Me.FrpSelection)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 311)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 97)
        Me.GroupBox1.TabIndex = 267
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRINT OPTIONS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdPrinter)
        Me.Panel2.Controls.Add(Me.cOrientation)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cSize)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(10, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 84)
        Me.Panel2.TabIndex = 0
        '
        'cmdPrinter
        '
        Me.cmdPrinter.Location = New System.Drawing.Point(64, 3)
        Me.cmdPrinter.Name = "cmdPrinter"
        Me.cmdPrinter.Size = New System.Drawing.Size(86, 27)
        Me.cmdPrinter.TabIndex = 261
        Me.cmdPrinter.Text = "Select Printer"
        Me.cmdPrinter.UseVisualStyleBackColor = True
        '
        'cOrientation
        '
        Me.cOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cOrientation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cOrientation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cOrientation.FormattingEnabled = True
        Me.cOrientation.Items.AddRange(New Object() {"(Default)", "Portrait", "Landscape"})
        Me.cOrientation.Location = New System.Drawing.Point(67, 59)
        Me.cOrientation.Name = "cOrientation"
        Me.cOrientation.Size = New System.Drawing.Size(92, 21)
        Me.cOrientation.TabIndex = 261
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 262
        Me.Label6.Text = "Orientation:"
        '
        'cSize
        '
        Me.cSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cSize.FormattingEnabled = True
        Me.cSize.Items.AddRange(New Object() {"(Default)", "A4", "A3", "A5", "B4", "B5", "Executive", "FanfoldLegal", "FanfoldStandard", "FanfoldUS", "Legal", "Letter"})
        Me.cSize.Location = New System.Drawing.Point(67, 34)
        Me.cSize.Name = "cSize"
        Me.cSize.Size = New System.Drawing.Size(174, 21)
        Me.cSize.TabIndex = 259
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 260
        Me.Label5.Text = "Paper Size:"
        '
        'ChkDisplay
        '
        Me.ChkDisplay.AutoSize = True
        Me.ChkDisplay.Checked = True
        Me.ChkDisplay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDisplay.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkDisplay.Location = New System.Drawing.Point(268, 4)
        Me.ChkDisplay.Name = "ChkDisplay"
        Me.ChkDisplay.Size = New System.Drawing.Size(77, 17)
        Me.ChkDisplay.TabIndex = 266
        Me.ChkDisplay.Text = "On Screen"
        Me.ChkDisplay.UseVisualStyleBackColor = True
        '
        'PanRptTitle
        '
        Me.PanRptTitle.Controls.Add(Me.lblWait)
        Me.PanRptTitle.Controls.Add(Me.lblRetTitle)
        Me.PanRptTitle.Location = New System.Drawing.Point(2, 2)
        Me.PanRptTitle.Name = "PanRptTitle"
        Me.PanRptTitle.Size = New System.Drawing.Size(294, 24)
        Me.PanRptTitle.TabIndex = 265
        '
        'lblWait
        '
        Me.lblWait.AutoSize = True
        Me.lblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.ForeColor = System.Drawing.Color.DarkRed
        Me.lblWait.Location = New System.Drawing.Point(52, 102)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(184, 16)
        Me.lblWait.TabIndex = 260
        Me.lblWait.Text = "Pls. Wait...loading Report"
        '
        'lblRetTitle
        '
        Me.lblRetTitle.AutoSize = True
        Me.lblRetTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetTitle.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRetTitle.Location = New System.Drawing.Point(0, 2)
        Me.lblRetTitle.Name = "lblRetTitle"
        Me.lblRetTitle.Size = New System.Drawing.Size(144, 16)
        Me.lblRetTitle.TabIndex = 259
        Me.lblRetTitle.Text = "Patient Registration"
        '
        'FrpSelection
        '
        Me.FrpSelection.Controls.Add(Me.chkLetterHead)
        Me.FrpSelection.Controls.Add(Me.cboLayOut)
        Me.FrpSelection.Controls.Add(Me.lblLayOut)
        Me.FrpSelection.Controls.Add(Me.PanDetails)
        Me.FrpSelection.Controls.Add(Me.tRefNo)
        Me.FrpSelection.Controls.Add(Me.lblRefNo)
        Me.FrpSelection.Controls.Add(Me.tAccountName)
        Me.FrpSelection.Controls.Add(Me.tPatientName)
        Me.FrpSelection.Controls.Add(Me.cmdAccount)
        Me.FrpSelection.Controls.Add(Me.tAccountCode)
        Me.FrpSelection.Controls.Add(Me.dtpEndDate)
        Me.FrpSelection.Controls.Add(Me.lblEnd)
        Me.FrpSelection.Controls.Add(Me.dtpStartDate)
        Me.FrpSelection.Controls.Add(Me.lblStart)
        Me.FrpSelection.Controls.Add(Me.cboStatus)
        Me.FrpSelection.Controls.Add(Me.lblStatus)
        Me.FrpSelection.Controls.Add(Me.cmdPatient)
        Me.FrpSelection.Controls.Add(Me.tPatientNo)
        Me.FrpSelection.Controls.Add(Me.lblAccount)
        Me.FrpSelection.Controls.Add(Me.lblPatientNo)
        Me.FrpSelection.Location = New System.Drawing.Point(2, 28)
        Me.FrpSelection.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FrpSelection.Name = "FrpSelection"
        Me.FrpSelection.Size = New System.Drawing.Size(366, 182)
        Me.FrpSelection.TabIndex = 260
        Me.FrpSelection.TabStop = False
        Me.FrpSelection.Text = "Report Conditions/Parameters"
        '
        'chkLetterHead
        '
        Me.chkLetterHead.AutoSize = True
        Me.chkLetterHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLetterHead.ForeColor = System.Drawing.Color.Black
        Me.chkLetterHead.Location = New System.Drawing.Point(184, 151)
        Me.chkLetterHead.Name = "chkLetterHead"
        Me.chkLetterHead.Size = New System.Drawing.Size(116, 17)
        Me.chkLetterHead.TabIndex = 270
        Me.chkLetterHead.Text = "Print on Letterhead"
        Me.chkLetterHead.UseVisualStyleBackColor = True
        '
        'cboLayOut
        '
        Me.cboLayOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLayOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLayOut.FormattingEnabled = True
        Me.cboLayOut.Items.AddRange(New Object() {"Layout 1", "Layout 2", "Layout 3", "Layout 4", "Layout 5", "Layout 6"})
        Me.cboLayOut.Location = New System.Drawing.Point(70, 149)
        Me.cboLayOut.Name = "cboLayOut"
        Me.cboLayOut.Size = New System.Drawing.Size(108, 21)
        Me.cboLayOut.TabIndex = 268
        '
        'lblLayOut
        '
        Me.lblLayOut.Location = New System.Drawing.Point(5, 153)
        Me.lblLayOut.Name = "lblLayOut"
        Me.lblLayOut.Size = New System.Drawing.Size(95, 15)
        Me.lblLayOut.TabIndex = 269
        Me.lblLayOut.Text = "Layout:"
        '
        'PanDetails
        '
        Me.PanDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanDetails.Controls.Add(Me.RadSummary)
        Me.PanDetails.Controls.Add(Me.RadDetails)
        Me.PanDetails.ForeColor = System.Drawing.Color.Black
        Me.PanDetails.Location = New System.Drawing.Point(184, 106)
        Me.PanDetails.Name = "PanDetails"
        Me.PanDetails.Size = New System.Drawing.Size(78, 40)
        Me.PanDetails.TabIndex = 267
        '
        'RadSummary
        '
        Me.RadSummary.AutoSize = True
        Me.RadSummary.Location = New System.Drawing.Point(5, 19)
        Me.RadSummary.Name = "RadSummary"
        Me.RadSummary.Size = New System.Drawing.Size(68, 17)
        Me.RadSummary.TabIndex = 1
        Me.RadSummary.Text = "Summary"
        Me.RadSummary.UseVisualStyleBackColor = True
        '
        'RadDetails
        '
        Me.RadDetails.AutoSize = True
        Me.RadDetails.Checked = True
        Me.RadDetails.Location = New System.Drawing.Point(5, 2)
        Me.RadDetails.Name = "RadDetails"
        Me.RadDetails.Size = New System.Drawing.Size(52, 17)
        Me.RadDetails.TabIndex = 0
        Me.RadDetails.TabStop = True
        Me.RadDetails.Text = "Detail"
        Me.RadDetails.UseVisualStyleBackColor = True
        '
        'tRefNo
        '
        Me.tRefNo.Location = New System.Drawing.Point(68, 104)
        Me.tRefNo.Name = "tRefNo"
        Me.tRefNo.Size = New System.Drawing.Size(112, 20)
        Me.tRefNo.TabIndex = 265
        Me.tRefNo.Tag = ""
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Location = New System.Drawing.Point(5, 108)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(47, 13)
        Me.lblRefNo.TabIndex = 266
        Me.lblRefNo.Text = "Ref. No:"
        '
        'tAccountName
        '
        Me.tAccountName.Location = New System.Drawing.Point(172, 84)
        Me.tAccountName.Name = "tAccountName"
        Me.tAccountName.ReadOnly = True
        Me.tAccountName.Size = New System.Drawing.Size(192, 20)
        Me.tAccountName.TabIndex = 264
        Me.tAccountName.Tag = ""
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(172, 60)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(192, 20)
        Me.tPatientName.TabIndex = 263
        Me.tPatientName.Tag = ""
        '
        'cmdAccount
        '
        Me.cmdAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAccount.Location = New System.Drawing.Point(146, 83)
        Me.cmdAccount.Name = "cmdAccount"
        Me.cmdAccount.Size = New System.Drawing.Size(26, 21)
        Me.cmdAccount.TabIndex = 262
        Me.cmdAccount.Text = "..."
        Me.cmdAccount.UseVisualStyleBackColor = True
        '
        'tAccountCode
        '
        Me.tAccountCode.Location = New System.Drawing.Point(68, 83)
        Me.tAccountCode.Name = "tAccountCode"
        Me.tAccountCode.Size = New System.Drawing.Size(77, 20)
        Me.tAccountCode.TabIndex = 261
        Me.tAccountCode.Tag = ""
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(68, 38)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.ShowCheckBox = True
        Me.dtpEndDate.Size = New System.Drawing.Size(116, 20)
        Me.dtpEndDate.TabIndex = 259
        Me.dtpEndDate.Tag = "Date"
        '
        'lblEnd
        '
        Me.lblEnd.Location = New System.Drawing.Point(6, 42)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(55, 15)
        Me.lblEnd.TabIndex = 260
        Me.lblEnd.Text = "End Date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(68, 16)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.ShowCheckBox = True
        Me.dtpStartDate.Size = New System.Drawing.Size(116, 20)
        Me.dtpStartDate.TabIndex = 257
        Me.dtpStartDate.Tag = "Date"
        '
        'lblStart
        '
        Me.lblStart.Location = New System.Drawing.Point(6, 20)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(68, 15)
        Me.lblStart.TabIndex = 258
        Me.lblStart.Text = "Start Date:"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownWidth = 200
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"All", "Outstanding", "Complete"})
        Me.cboStatus.Location = New System.Drawing.Point(70, 126)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(110, 21)
        Me.cboStatus.TabIndex = 7
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(5, 131)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(72, 12)
        Me.lblStatus.TabIndex = 256
        Me.lblStatus.Text = "Status:"
        '
        'cmdPatient
        '
        Me.cmdPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPatient.Location = New System.Drawing.Point(146, 60)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 240
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(68, 60)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(77, 20)
        Me.tPatientNo.TabIndex = 2
        Me.tPatientNo.Tag = ""
        '
        'lblAccount
        '
        Me.lblAccount.Location = New System.Drawing.Point(5, 86)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(55, 14)
        Me.lblAccount.TabIndex = 242
        Me.lblAccount.Text = "Account:"
        '
        'lblPatientNo
        '
        Me.lblPatientNo.AutoSize = True
        Me.lblPatientNo.Location = New System.Drawing.Point(6, 63)
        Me.lblPatientNo.Name = "lblPatientNo"
        Me.lblPatientNo.Size = New System.Drawing.Size(43, 13)
        Me.lblPatientNo.TabIndex = 239
        Me.lblPatientNo.Text = "Patient:"
        '
        'PanMainCmd
        '
        Me.PanMainCmd.Controls.Add(Me.cmdClose)
        Me.PanMainCmd.Controls.Add(Me.Label3)
        Me.PanMainCmd.Controls.Add(Me.cmdOk)
        Me.PanMainCmd.Controls.Add(Me.Label2)
        Me.PanMainCmd.Controls.Add(Me.Label4)
        Me.PanMainCmd.Location = New System.Drawing.Point(377, 3)
        Me.PanMainCmd.Name = "PanMainCmd"
        Me.PanMainCmd.Size = New System.Drawing.Size(106, 261)
        Me.PanMainCmd.TabIndex = 261
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(2, 60)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(100, 58)
        Me.cmdClose.TabIndex = 15
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-4, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 264
        Me.Label3.Text = "NOTE:"
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.Lavender
        Me.cmdOk.Location = New System.Drawing.Point(2, 3)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(100, 55)
        Me.cmdOk.TabIndex = 14
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(0, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 263
        Me.Label2.Text = "RED"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 64)
        Me.Label4.TabIndex = 262
        Me.Label4.Text = "NOTE: Only the report parameters in RED are required for selected report type"
        '
        'TimWait
        '
        Me.TimWait.Enabled = True
        Me.TimWait.Interval = 200
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 694)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanRptTitle.ResumeLayout(False)
        Me.PanRptTitle.PerformLayout()
        Me.FrpSelection.ResumeLayout(False)
        Me.FrpSelection.PerformLayout()
        Me.PanDetails.ResumeLayout(False)
        Me.PanDetails.PerformLayout()
        Me.PanMainCmd.ResumeLayout(False)
        Me.PanMainCmd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvList1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CR As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TimWait As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanRptTitle As System.Windows.Forms.Panel
    Friend WithEvents lblWait As System.Windows.Forms.Label
    Friend WithEvents lblRetTitle As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanMainCmd As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FrpSelection As System.Windows.Forms.GroupBox
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents lblPatientNo As System.Windows.Forms.Label
    Friend WithEvents cmdAccount As System.Windows.Forms.Button
    Friend WithEvents tAccountCode As System.Windows.Forms.TextBox
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents tAccountName As System.Windows.Forms.TextBox
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ChkDisplay As System.Windows.Forms.CheckBox
    Friend WithEvents tRefNo As System.Windows.Forms.TextBox
    Friend WithEvents lblRefNo As System.Windows.Forms.Label
    Friend WithEvents PanDetails As System.Windows.Forms.Panel
    Friend WithEvents RadSummary As System.Windows.Forms.RadioButton
    Friend WithEvents RadDetails As System.Windows.Forms.RadioButton
    Friend WithEvents cboLayOut As System.Windows.Forms.ComboBox
    Friend WithEvents lblLayOut As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdPrinter As System.Windows.Forms.Button
    Friend WithEvents cOrientation As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents chkLetterHead As System.Windows.Forms.CheckBox
End Class
