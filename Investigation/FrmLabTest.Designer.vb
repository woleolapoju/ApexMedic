<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLabTest
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7", New System.Windows.Forms.TreeNode() {TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5", New System.Windows.Forms.TreeNode() {TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode8})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLabTest))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TV = New System.Windows.Forms.TreeView
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.PanTotal = New System.Windows.Forms.Panel
        Me.tAmtInWords = New System.Windows.Forms.TextBox
        Me.tTotal = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.GrpDetails = New System.Windows.Forms.GroupBox
        Me.tResult = New System.Windows.Forms.TextBox
        Me.tSpecimen = New System.Windows.Forms.ComboBox
        Me.cResult = New System.Windows.Forms.ComboBox
        Me.tPrice = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpResultDate = New System.Windows.Forms.DateTimePicker
        Me.chkPending = New System.Windows.Forms.CheckBox
        Me.cmdInsertDetails = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tRemark = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.tTestName = New System.Windows.Forms.TextBox
        Me.tTestCode = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lvList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.mnuMail = New System.Windows.Forms.CheckBox
        Me.lnkFinancialState = New System.Windows.Forms.LinkLabel
        Me.mnuInsert = New System.Windows.Forms.Button
        Me.PanCommands = New System.Windows.Forms.Panel
        Me.mnuCut = New System.Windows.Forms.Button
        Me.mnuOpen = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.mnuPrint = New System.Windows.Forms.MenuStrip
        Me.mnuPrintResult = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLastResult = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRefNo = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuPreviewLastResult = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPendingResult = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPrintRequest = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCulture = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSTOOL = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUrinalysis = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.tWard = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.tRequestedBy = New System.Windows.Forms.TextBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdRequestBy = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmdUnRegistered = New System.Windows.Forms.Button
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.tTestNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cSex = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.tRequest = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lblSelectedMenu = New System.Windows.Forms.Label
        Me.dtpPeriod = New System.Windows.Forms.DateTimePicker
        Me.cboPeriod = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.tSummary = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdLoadTest = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.lvAppointment = New System.Windows.Forms.ListView
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.chkDisplay = New System.Windows.Forms.CheckBox
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimLab = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PanTotal.SuspendLayout()
        Me.GrpDetails.SuspendLayout()
        Me.PanMainCommand.SuspendLayout()
        Me.PanCommands.SuspendLayout()
        Me.mnuPrint.SuspendLayout()
        Me.PanHeading.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 543.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tblHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanHeading, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1028, 613)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TV)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 63)
        Me.Panel1.Name = "Panel1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel1, 2)
        Me.Panel1.Size = New System.Drawing.Size(211, 570)
        Me.Panel1.TabIndex = 240
        '
        'TV
        '
        Me.TV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TV.FullRowSelect = True
        Me.TV.HideSelection = False
        Me.TV.Location = New System.Drawing.Point(0, 0)
        Me.TV.Name = "TV"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "Node0"
        TreeNode2.Name = "Node1"
        TreeNode2.Text = "Node1"
        TreeNode3.Name = "Node3"
        TreeNode3.Text = "Node3"
        TreeNode4.Name = "Node8"
        TreeNode4.Text = "Node8"
        TreeNode5.Name = "Node7"
        TreeNode5.Text = "Node7"
        TreeNode6.Name = "Node5"
        TreeNode6.Text = "Node5"
        TreeNode7.Name = "Node6"
        TreeNode7.Text = "Node6"
        TreeNode8.Name = "Node4"
        TreeNode8.Text = "Node4"
        TreeNode9.Name = "Node2"
        TreeNode9.Text = "Node2"
        Me.TV.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode9})
        Me.TV.Size = New System.Drawing.Size(211, 570)
        Me.TV.TabIndex = 0
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.tblHeader, 3)
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
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
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.Size = New System.Drawing.Size(1028, 60)
        Me.tblHeader.TabIndex = 55
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
        Me.Label9.Location = New System.Drawing.Point(111, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(712, 30)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "LABORATORY INVESTIGATION"
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
        Me.PictureBox1.Size = New System.Drawing.Size(111, 60)
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
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(111, 30)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(712, 30)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Maintains Lab test and Results"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAction.Location = New System.Drawing.Point(823, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(205, 60)
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PanTotal, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.GrpDetails, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lvList, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.PanMainCommand, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(220, 190)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(537, 443)
        Me.TableLayoutPanel2.TabIndex = 241
        '
        'PanTotal
        '
        Me.PanTotal.Controls.Add(Me.tAmtInWords)
        Me.PanTotal.Controls.Add(Me.tTotal)
        Me.PanTotal.Controls.Add(Me.Label17)
        Me.PanTotal.Location = New System.Drawing.Point(3, 422)
        Me.PanTotal.Name = "PanTotal"
        Me.PanTotal.Size = New System.Drawing.Size(527, 18)
        Me.PanTotal.TabIndex = 239
        '
        'tAmtInWords
        '
        Me.tAmtInWords.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tAmtInWords.Dock = System.Windows.Forms.DockStyle.Left
        Me.tAmtInWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAmtInWords.Location = New System.Drawing.Point(0, 0)
        Me.tAmtInWords.Margin = New System.Windows.Forms.Padding(0)
        Me.tAmtInWords.Multiline = True
        Me.tAmtInWords.Name = "tAmtInWords"
        Me.tAmtInWords.ReadOnly = True
        Me.tAmtInWords.Size = New System.Drawing.Size(308, 18)
        Me.tAmtInWords.TabIndex = 48
        Me.tAmtInWords.TabStop = False
        '
        'tTotal
        '
        Me.tTotal.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.tTotal.ForeColor = System.Drawing.Color.Black
        Me.tTotal.Location = New System.Drawing.Point(428, 0)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.ReadOnly = True
        Me.tTotal.Size = New System.Drawing.Size(99, 20)
        Me.tTotal.TabIndex = 47
        Me.tTotal.TabStop = False
        Me.tTotal.Text = "0"
        Me.tTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(314, 4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "TOTAL:"
        '
        'GrpDetails
        '
        Me.GrpDetails.Controls.Add(Me.tResult)
        Me.GrpDetails.Controls.Add(Me.tSpecimen)
        Me.GrpDetails.Controls.Add(Me.cResult)
        Me.GrpDetails.Controls.Add(Me.tPrice)
        Me.GrpDetails.Controls.Add(Me.Label15)
        Me.GrpDetails.Controls.Add(Me.Label19)
        Me.GrpDetails.Controls.Add(Me.Label14)
        Me.GrpDetails.Controls.Add(Me.dtpResultDate)
        Me.GrpDetails.Controls.Add(Me.chkPending)
        Me.GrpDetails.Controls.Add(Me.cmdInsertDetails)
        Me.GrpDetails.Controls.Add(Me.GroupBox2)
        Me.GrpDetails.Controls.Add(Me.tRemark)
        Me.GrpDetails.Controls.Add(Me.Label13)
        Me.GrpDetails.Controls.Add(Me.Label12)
        Me.GrpDetails.Controls.Add(Me.tTestName)
        Me.GrpDetails.Controls.Add(Me.tTestCode)
        Me.GrpDetails.Controls.Add(Me.Label11)
        Me.GrpDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDetails.ForeColor = System.Drawing.Color.Black
        Me.GrpDetails.Location = New System.Drawing.Point(3, 0)
        Me.GrpDetails.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.GrpDetails.Name = "GrpDetails"
        Me.GrpDetails.Size = New System.Drawing.Size(531, 174)
        Me.GrpDetails.TabIndex = 58
        Me.GrpDetails.TabStop = False
        '
        'tResult
        '
        Me.tResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tResult.Location = New System.Drawing.Point(77, 34)
        Me.tResult.Multiline = True
        Me.tResult.Name = "tResult"
        Me.tResult.Size = New System.Drawing.Size(304, 41)
        Me.tResult.TabIndex = 268
        '
        'tSpecimen
        '
        Me.tSpecimen.BackColor = System.Drawing.Color.White
        Me.tSpecimen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tSpecimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tSpecimen.FormattingEnabled = True
        Me.tSpecimen.Location = New System.Drawing.Point(77, 123)
        Me.tSpecimen.Name = "tSpecimen"
        Me.tSpecimen.Size = New System.Drawing.Size(147, 21)
        Me.tSpecimen.TabIndex = 267
        Me.tSpecimen.Tag = "Sex"
        '
        'cResult
        '
        Me.cResult.BackColor = System.Drawing.Color.White
        Me.cResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cResult.FormattingEnabled = True
        Me.cResult.Items.AddRange(New Object() {"Male", "Female"})
        Me.cResult.Location = New System.Drawing.Point(77, 35)
        Me.cResult.Name = "cResult"
        Me.cResult.Size = New System.Drawing.Size(323, 21)
        Me.cResult.TabIndex = 266
        Me.cResult.Tag = "Sex"
        '
        'tPrice
        '
        Me.tPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPrice.Location = New System.Drawing.Point(441, 13)
        Me.tPrice.Name = "tPrice"
        Me.tPrice.Size = New System.Drawing.Size(81, 20)
        Me.tPrice.TabIndex = 264
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(406, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 263
        Me.Label15.Text = "Price:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 123)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "Specimen:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 149)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 262
        Me.Label14.Text = "Result Date:"
        '
        'dtpResultDate
        '
        Me.dtpResultDate.CustomFormat = "dd-MMM-yy h.mm  tt"
        Me.dtpResultDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpResultDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpResultDate.Location = New System.Drawing.Point(75, 146)
        Me.dtpResultDate.Name = "dtpResultDate"
        Me.dtpResultDate.Size = New System.Drawing.Size(148, 20)
        Me.dtpResultDate.TabIndex = 261
        Me.dtpResultDate.Tag = "RegDate"
        '
        'chkPending
        '
        Me.chkPending.AutoSize = True
        Me.chkPending.Checked = True
        Me.chkPending.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPending.Location = New System.Drawing.Point(407, 37)
        Me.chkPending.Name = "chkPending"
        Me.chkPending.Size = New System.Drawing.Size(72, 17)
        Me.chkPending.TabIndex = 260
        Me.chkPending.Text = "Pending"
        Me.chkPending.UseVisualStyleBackColor = True
        '
        'cmdInsertDetails
        '
        Me.cmdInsertDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsertDetails.ForeColor = System.Drawing.Color.Black
        Me.cmdInsertDetails.Location = New System.Drawing.Point(448, 134)
        Me.cmdInsertDetails.Name = "cmdInsertDetails"
        Me.cmdInsertDetails.Size = New System.Drawing.Size(76, 31)
        Me.cmdInsertDetails.TabIndex = 258
        Me.cmdInsertDetails.Text = "&Insert"
        Me.cmdInsertDetails.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(274, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 3)
        Me.GroupBox2.TabIndex = 257
        Me.GroupBox2.TabStop = False
        '
        'tRemark
        '
        Me.tRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRemark.Location = New System.Drawing.Point(76, 77)
        Me.tRemark.Multiline = True
        Me.tRemark.Name = "tRemark"
        Me.tRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tRemark.Size = New System.Drawing.Size(447, 44)
        Me.tRemark.TabIndex = 256
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(2, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 255
        Me.Label13.Text = "Remark:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(2, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 253
        Me.Label12.Text = "Result:"
        '
        'tTestName
        '
        Me.tTestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTestName.Location = New System.Drawing.Point(182, 12)
        Me.tTestName.Name = "tTestName"
        Me.tTestName.ReadOnly = True
        Me.tTestName.Size = New System.Drawing.Size(218, 20)
        Me.tTestName.TabIndex = 252
        '
        'tTestCode
        '
        Me.tTestCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTestCode.Location = New System.Drawing.Point(76, 12)
        Me.tTestCode.Name = "tTestCode"
        Me.tTestCode.Size = New System.Drawing.Size(103, 20)
        Me.tTestCode.TabIndex = 250
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(2, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 249
        Me.Label11.Text = "Test:"
        '
        'lvList
        '
        Me.lvList.BackColor = System.Drawing.Color.GhostWhite
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader15, Me.ColumnHeader19})
        Me.lvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvList.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        Me.lvList.HideSelection = False
        Me.lvList.Location = New System.Drawing.Point(3, 228)
        Me.lvList.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.lvList.MultiSelect = False
        Me.lvList.Name = "lvList"
        Me.lvList.ShowItemToolTips = True
        Me.lvList.Size = New System.Drawing.Size(531, 191)
        Me.lvList.TabIndex = 236
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sn"
        Me.ColumnHeader1.Width = 31
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Test MainType"
        Me.ColumnHeader2.Width = 88
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Test SubType"
        Me.ColumnHeader3.Width = 106
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TestCode"
        Me.ColumnHeader4.Width = 1
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Test Name"
        Me.ColumnHeader5.Width = 113
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Result"
        Me.ColumnHeader6.Width = 93
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Remark"
        Me.ColumnHeader7.Width = 85
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Pending"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ResultDate"
        Me.ColumnHeader9.Width = 1
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Price"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "UseGrpPrice"
        Me.ColumnHeader15.Width = 1
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Specimen"
        '
        'PanMainCommand
        '
        Me.PanMainCommand.BackColor = System.Drawing.Color.LightYellow
        Me.PanMainCommand.Controls.Add(Me.mnuMail)
        Me.PanMainCommand.Controls.Add(Me.lnkFinancialState)
        Me.PanMainCommand.Controls.Add(Me.mnuInsert)
        Me.PanMainCommand.Controls.Add(Me.PanCommands)
        Me.PanMainCommand.Controls.Add(Me.cmdClose)
        Me.PanMainCommand.Controls.Add(Me.cmdOk)
        Me.PanMainCommand.Controls.Add(Me.mnuPrint)
        Me.PanMainCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMainCommand.Location = New System.Drawing.Point(0, 177)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(537, 51)
        Me.PanMainCommand.TabIndex = 57
        '
        'mnuMail
        '
        Me.mnuMail.AutoSize = True
        Me.mnuMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMail.Location = New System.Drawing.Point(245, 4)
        Me.mnuMail.Name = "mnuMail"
        Me.mnuMail.Size = New System.Drawing.Size(135, 17)
        Me.mnuMail.TabIndex = 0
        Me.mnuMail.Text = "Mail record after saving"
        Me.mnuMail.UseVisualStyleBackColor = True
        '
        'lnkFinancialState
        '
        Me.lnkFinancialState.AutoSize = True
        Me.lnkFinancialState.Location = New System.Drawing.Point(4, 3)
        Me.lnkFinancialState.Name = "lnkFinancialState"
        Me.lnkFinancialState.Size = New System.Drawing.Size(147, 13)
        Me.lnkFinancialState.TabIndex = 255
        Me.lnkFinancialState.TabStop = True
        Me.lnkFinancialState.Text = "Check Patient Financial State"
        '
        'mnuInsert
        '
        Me.mnuInsert.Image = Global.ApexMedic.My.Resources.Resources.NEW1
        Me.mnuInsert.Location = New System.Drawing.Point(343, 22)
        Me.mnuInsert.Name = "mnuInsert"
        Me.mnuInsert.Size = New System.Drawing.Size(26, 25)
        Me.mnuInsert.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.mnuInsert, "New")
        Me.mnuInsert.UseVisualStyleBackColor = True
        Me.mnuInsert.Visible = False
        '
        'PanCommands
        '
        Me.PanCommands.Controls.Add(Me.mnuCut)
        Me.PanCommands.Controls.Add(Me.mnuOpen)
        Me.PanCommands.Location = New System.Drawing.Point(-2, 22)
        Me.PanCommands.Name = "PanCommands"
        Me.PanCommands.Size = New System.Drawing.Size(56, 26)
        Me.PanCommands.TabIndex = 252
        '
        'mnuCut
        '
        Me.mnuCut.Image = Global.ApexMedic.My.Resources.Resources.CUT
        Me.mnuCut.Location = New System.Drawing.Point(28, 0)
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(26, 25)
        Me.mnuCut.TabIndex = 10
        Me.mnuCut.Text = "..."
        Me.ToolTip1.SetToolTip(Me.mnuCut, "Delete")
        Me.mnuCut.UseVisualStyleBackColor = True
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = Global.ApexMedic.My.Resources.Resources.OPEN
        Me.mnuOpen.Location = New System.Drawing.Point(3, 0)
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(26, 25)
        Me.mnuOpen.TabIndex = 9
        Me.mnuOpen.Text = "..."
        Me.ToolTip1.SetToolTip(Me.mnuOpen, "Edit")
        Me.mnuOpen.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(461, -1)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(77, 51)
        Me.cmdClose.TabIndex = 251
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(382, 0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 51)
        Me.cmdOk.TabIndex = 250
        Me.cmdOk.Text = "&Save Test"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'mnuPrint
        '
        Me.mnuPrint.AllowMerge = False
        Me.mnuPrint.BackColor = System.Drawing.Color.Transparent
        Me.mnuPrint.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuPrint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintResult, Me.mnuPendingResult, Me.mnuPrintRequest, Me.mnuCulture, Me.mnuSTOOL, Me.mnuUrinalysis, Me.ToolStripMenuItem1})
        Me.mnuPrint.Location = New System.Drawing.Point(53, 23)
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(274, 24)
        Me.mnuPrint.TabIndex = 256
        Me.mnuPrint.Text = "MenuStrip1"
        '
        'mnuPrintResult
        '
        Me.mnuPrintResult.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.mnuPrintResult.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLastResult, Me.mnuRefNo, Me.ToolStripMenuItem2, Me.mnuPreviewLastResult})
        Me.mnuPrintResult.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPrintResult.ForeColor = System.Drawing.Color.Brown
        Me.mnuPrintResult.Name = "mnuPrintResult"
        Me.mnuPrintResult.Size = New System.Drawing.Size(79, 20)
        Me.mnuPrintResult.Text = "Print Result"
        '
        'mnuLastResult
        '
        Me.mnuLastResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLastResult.ForeColor = System.Drawing.Color.Brown
        Me.mnuLastResult.Name = "mnuLastResult"
        Me.mnuLastResult.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuLastResult.Size = New System.Drawing.Size(190, 22)
        Me.mnuLastResult.Text = "Last Result"
        '
        'mnuRefNo
        '
        Me.mnuRefNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuRefNo.ForeColor = System.Drawing.Color.Brown
        Me.mnuRefNo.Name = "mnuRefNo"
        Me.mnuRefNo.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuRefNo.Size = New System.Drawing.Size(190, 22)
        Me.mnuRefNo.Text = "Use Test No"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(187, 6)
        '
        'mnuPreviewLastResult
        '
        Me.mnuPreviewLastResult.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPreviewLastResult.Name = "mnuPreviewLastResult"
        Me.mnuPreviewLastResult.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.mnuPreviewLastResult.Size = New System.Drawing.Size(190, 22)
        Me.mnuPreviewLastResult.Text = "Preview Last Result"
        '
        'mnuPendingResult
        '
        Me.mnuPendingResult.BackColor = System.Drawing.Color.LightBlue
        Me.mnuPendingResult.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mnuPendingResult.ForeColor = System.Drawing.Color.Brown
        Me.mnuPendingResult.Name = "mnuPendingResult"
        Me.mnuPendingResult.Size = New System.Drawing.Size(98, 20)
        Me.mnuPendingResult.Text = "Pending Result"
        '
        'mnuPrintRequest
        '
        Me.mnuPrintRequest.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.mnuPrintRequest.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mnuPrintRequest.ForeColor = System.Drawing.Color.Maroon
        Me.mnuPrintRequest.Name = "mnuPrintRequest"
        Me.mnuPrintRequest.Size = New System.Drawing.Size(89, 20)
        Me.mnuPrintRequest.Text = "Print Request"
        Me.mnuPrintRequest.ToolTipText = "Displays todate's laboratory requests "
        '
        'mnuCulture
        '
        Me.mnuCulture.BackColor = System.Drawing.Color.LightBlue
        Me.mnuCulture.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnuCulture.Name = "mnuCulture"
        Me.mnuCulture.Size = New System.Drawing.Size(71, 20)
        Me.mnuCulture.Text = "CULTURE"
        Me.mnuCulture.Visible = False
        '
        'mnuSTOOL
        '
        Me.mnuSTOOL.Name = "mnuSTOOL"
        Me.mnuSTOOL.Size = New System.Drawing.Size(56, 20)
        Me.mnuSTOOL.Text = "STOOL"
        Me.mnuSTOOL.Visible = False
        '
        'mnuUrinalysis
        '
        Me.mnuUrinalysis.Name = "mnuUrinalysis"
        Me.mnuUrinalysis.Size = New System.Drawing.Size(82, 20)
        Me.mnuUrinalysis.Text = "URINALYSIS"
        Me.mnuUrinalysis.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = " "
        Me.ToolStripMenuItem1.Visible = False
        '
        'PanHeading
        '
        Me.PanHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanHeading.Controls.Add(Me.tWard)
        Me.PanHeading.Controls.Add(Me.Label22)
        Me.PanHeading.Controls.Add(Me.tRequestedBy)
        Me.PanHeading.Controls.Add(Me.cmdRequestBy)
        Me.PanHeading.Controls.Add(Me.Label21)
        Me.PanHeading.Controls.Add(Me.cmdUnRegistered)
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
        Me.PanHeading.Controls.Add(Me.Label3)
        Me.PanHeading.Controls.Add(Me.Label2)
        Me.PanHeading.Controls.Add(Me.dtpDate)
        Me.PanHeading.Controls.Add(Me.tTestNo)
        Me.PanHeading.Controls.Add(Me.Label1)
        Me.PanHeading.Controls.Add(Me.cmdPatient)
        Me.PanHeading.Controls.Add(Me.tPatientNo)
        Me.PanHeading.Controls.Add(Me.Label4)
        Me.PanHeading.Controls.Add(Me.cSex)
        Me.PanHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanHeading.Location = New System.Drawing.Point(220, 63)
        Me.PanHeading.Margin = New System.Windows.Forms.Padding(3, 3, 6, 0)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(534, 124)
        Me.PanHeading.TabIndex = 56
        '
        'tWard
        '
        Me.tWard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tWard.ForeColor = System.Drawing.Color.Maroon
        Me.tWard.Location = New System.Drawing.Point(418, 95)
        Me.tWard.Name = "tWard"
        Me.tWard.Size = New System.Drawing.Size(105, 20)
        Me.tWard.TabIndex = 254
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(381, 98)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 13)
        Me.Label22.TabIndex = 253
        Me.Label22.Text = "Ward:"
        '
        'tRequestedBy
        '
        Me.tRequestedBy.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tRequestedBy.Location = New System.Drawing.Point(81, 73)
        Me.tRequestedBy.Name = "tRequestedBy"
        Me.tRequestedBy.Size = New System.Drawing.Size(417, 20)
        Me.tRequestedBy.TabIndex = 67
        Me.tRequestedBy.TabStop = False
        Me.ToolTip1.SetToolTip(Me.tRequestedBy, "Right click to clear")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(102, 26)
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "Clear"
        '
        'cmdRequestBy
        '
        Me.cmdRequestBy.Location = New System.Drawing.Point(498, 73)
        Me.cmdRequestBy.Name = "cmdRequestBy"
        Me.cmdRequestBy.Size = New System.Drawing.Size(26, 21)
        Me.cmdRequestBy.TabIndex = 66
        Me.cmdRequestBy.Text = "..."
        Me.cmdRequestBy.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(4, 76)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 13)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "Requested By:"
        '
        'cmdUnRegistered
        '
        Me.cmdUnRegistered.Location = New System.Drawing.Point(192, 5)
        Me.cmdUnRegistered.Name = "cmdUnRegistered"
        Me.cmdUnRegistered.Size = New System.Drawing.Size(31, 21)
        Me.cmdUnRegistered.TabIndex = 63
        Me.cmdUnRegistered.Text = "OP"
        Me.ToolTip1.SetToolTip(Me.cmdUnRegistered, "Unregistered Patients")
        Me.cmdUnRegistered.UseVisualStyleBackColor = True
        '
        'tPerformedBy
        '
        Me.tPerformedBy.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tPerformedBy.Location = New System.Drawing.Point(80, 95)
        Me.tPerformedBy.Name = "tPerformedBy"
        Me.tPerformedBy.Size = New System.Drawing.Size(274, 20)
        Me.tPerformedBy.TabIndex = 61
        Me.tPerformedBy.TabStop = False
        Me.ToolTip1.SetToolTip(Me.tPerformedBy, "Right click to clear")
        '
        'cmdPerform
        '
        Me.cmdPerform.Location = New System.Drawing.Point(353, 94)
        Me.cmdPerform.Name = "cmdPerform"
        Me.cmdPerform.Size = New System.Drawing.Size(26, 21)
        Me.cmdPerform.TabIndex = 60
        Me.cmdPerform.Text = "..."
        Me.cmdPerform.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Performed By:"
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(80, 50)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(298, 20)
        Me.tAccount.TabIndex = 51
        Me.tAccount.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Account:"
        '
        'tAge
        '
        Me.tAge.Location = New System.Drawing.Point(418, 49)
        Me.tAge.Name = "tAge"
        Me.tAge.Size = New System.Drawing.Size(38, 20)
        Me.tAge.TabIndex = 49
        Me.tAge.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(381, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Age:"
        '
        'tSex
        '
        Me.tSex.BackColor = System.Drawing.Color.White
        Me.tSex.Location = New System.Drawing.Point(418, 27)
        Me.tSex.Name = "tSex"
        Me.tSex.ReadOnly = True
        Me.tSex.Size = New System.Drawing.Size(84, 20)
        Me.tSex.TabIndex = 47
        Me.tSex.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Sex:"
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(80, 28)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(298, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Patient Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Date:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(418, 5)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(103, 20)
        Me.dtpDate.TabIndex = 42
        Me.dtpDate.Tag = "RegDate"
        '
        'tTestNo
        '
        Me.tTestNo.Location = New System.Drawing.Point(289, 6)
        Me.tTestNo.Name = "tTestNo"
        Me.tTestNo.Size = New System.Drawing.Size(88, 20)
        Me.tTestNo.TabIndex = 10
        Me.tTestNo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Lab.  No:"
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(165, 5)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 7
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(80, 6)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(84, 20)
        Me.tPatientNo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Patient No:"
        '
        'cSex
        '
        Me.cSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cSex.FormattingEnabled = True
        Me.cSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cSex.Location = New System.Drawing.Point(418, 27)
        Me.cSex.Name = "cSex"
        Me.cSex.Size = New System.Drawing.Size(104, 21)
        Me.cSex.TabIndex = 64
        Me.cSex.Tag = "Sex"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lvAppointment, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(760, 60)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(268, 576)
        Me.TableLayoutPanel3.TabIndex = 242
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.tRequest, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel5, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 5
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(268, 295)
        Me.TableLayoutPanel6.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1, 4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(266, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Laboratory Investigation Request"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tRequest
        '
        Me.tRequest.AcceptsReturn = True
        Me.tRequest.BackColor = System.Drawing.Color.White
        Me.tRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRequest.Location = New System.Drawing.Point(4, 31)
        Me.tRequest.Multiline = True
        Me.tRequest.Name = "tRequest"
        Me.tRequest.ReadOnly = True
        Me.tRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tRequest.Size = New System.Drawing.Size(260, 128)
        Me.tRequest.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightYellow
        Me.Panel5.Controls.Add(Me.lblSelectedMenu)
        Me.Panel5.Controls.Add(Me.dtpPeriod)
        Me.Panel5.Controls.Add(Me.cboPeriod)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1, 270)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(266, 24)
        Me.Panel5.TabIndex = 8
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
        Me.cboPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPeriod.FormattingEnabled = True
        Me.cboPeriod.Items.AddRange(New Object() {"Today", "Last"})
        Me.cboPeriod.Location = New System.Drawing.Point(87, 2)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(76, 21)
        Me.cboPeriod.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.tSummary, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(1, 164)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(266, 102)
        Me.TableLayoutPanel4.TabIndex = 10
        '
        'tSummary
        '
        Me.tSummary.BackColor = System.Drawing.Color.White
        Me.tSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSummary.Location = New System.Drawing.Point(3, 38)
        Me.tSummary.Multiline = True
        Me.tSummary.Name = "tSummary"
        Me.tSummary.ReadOnly = True
        Me.tSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tSummary.Size = New System.Drawing.Size(260, 61)
        Me.tSummary.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cmdLoadTest)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(260, 29)
        Me.Panel3.TabIndex = 4
        '
        'cmdLoadTest
        '
        Me.cmdLoadTest.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdLoadTest.Location = New System.Drawing.Point(147, 0)
        Me.cmdLoadTest.Name = "cmdLoadTest"
        Me.cmdLoadTest.Size = New System.Drawing.Size(111, 27)
        Me.cmdLoadTest.TabIndex = 2
        Me.cmdLoadTest.Text = "Load Test"
        Me.cmdLoadTest.UseVisualStyleBackColor = True
        Me.cmdLoadTest.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-2, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Case Summary"
        '
        'lvAppointment
        '
        Me.lvAppointment.BackColor = System.Drawing.Color.LemonChiffon
        Me.lvAppointment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader16, Me.ColumnHeader18, Me.ColumnHeader17})
        Me.lvAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAppointment.FullRowSelect = True
        Me.lvAppointment.GridLines = True
        Me.lvAppointment.HideSelection = False
        Me.lvAppointment.Location = New System.Drawing.Point(0, 325)
        Me.lvAppointment.Margin = New System.Windows.Forms.Padding(0)
        Me.lvAppointment.MultiSelect = False
        Me.lvAppointment.Name = "lvAppointment"
        Me.lvAppointment.Size = New System.Drawing.Size(268, 251)
        Me.lvAppointment.TabIndex = 10
        Me.lvAppointment.UseCompatibleStateImageBehavior = False
        Me.lvAppointment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Patient No"
        Me.ColumnHeader11.Width = 65
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Surname"
        Me.ColumnHeader12.Width = 75
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
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "DoctorID"
        Me.ColumnHeader18.Width = 0
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Requesting Doctor"
        Me.ColumnHeader17.Width = 75
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkDisplay)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 298)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 24)
        Me.Panel2.TabIndex = 11
        '
        'chkDisplay
        '
        Me.chkDisplay.AutoSize = True
        Me.chkDisplay.BackColor = System.Drawing.Color.Transparent
        Me.chkDisplay.Checked = True
        Me.chkDisplay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDisplay.ForeColor = System.Drawing.Color.Maroon
        Me.chkDisplay.Location = New System.Drawing.Point(-1, 4)
        Me.chkDisplay.Name = "chkDisplay"
        Me.chkDisplay.Size = New System.Drawing.Size(60, 17)
        Me.chkDisplay.TabIndex = 262
        Me.chkDisplay.Text = "Display"
        Me.chkDisplay.UseVisualStyleBackColor = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.Color.Black
        Me.cmdRefresh.Location = New System.Drawing.Point(202, 0)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(60, 24)
        Me.cmdRefresh.TabIndex = 260
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
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
        Me.Label20.Size = New System.Drawing.Size(262, 24)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Patients with Request"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimLab
        '
        Me.TimLab.Enabled = True
        Me.TimLab.Interval = 10000
        '
        'FrmLabTest
        '
        Me.AcceptButton = Me.cmdInsertDetails
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1028, 613)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLabTest"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laboratory Investigation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.PanTotal.ResumeLayout(False)
        Me.PanTotal.PerformLayout()
        Me.GrpDetails.ResumeLayout(False)
        Me.GrpDetails.PerformLayout()
        Me.PanMainCommand.ResumeLayout(False)
        Me.PanMainCommand.PerformLayout()
        Me.PanCommands.ResumeLayout(False)
        Me.mnuPrint.ResumeLayout(False)
        Me.mnuPrint.PerformLayout()
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tTestNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tAge As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tSex As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents PanCommands As System.Windows.Forms.Panel
    Friend WithEvents mnuCut As System.Windows.Forms.Button
    Friend WithEvents mnuOpen As System.Windows.Forms.Button
    Friend WithEvents mnuInsert As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents mnuMail As System.Windows.Forms.CheckBox
    Friend WithEvents lnkFinancialState As System.Windows.Forms.LinkLabel
    Friend WithEvents tAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tPerformedBy As System.Windows.Forms.TextBox
    Friend WithEvents cmdPerform As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TV As System.Windows.Forms.TreeView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanTotal As System.Windows.Forms.Panel
    Friend WithEvents tAmtInWords As System.Windows.Forms.TextBox
    Friend WithEvents tTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GrpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents tPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpResultDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkPending As System.Windows.Forms.CheckBox
    Friend WithEvents cmdInsertDetails As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tTestName As System.Windows.Forms.TextBox
    Friend WithEvents tTestCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblSelectedMenu As System.Windows.Forms.Label
    Friend WithEvents dtpPeriod As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents tRequest As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tSummary As System.Windows.Forms.TextBox
    Friend WithEvents lvAppointment As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimLab As System.Windows.Forms.Timer
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuPrintResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLastResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRefNo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdLoadTest As System.Windows.Forms.Button
    Friend WithEvents mnuPendingResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents mnuCulture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSTOOL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUrinalysis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrintRequest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdUnRegistered As System.Windows.Forms.Button
    Friend WithEvents cSex As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tRequestedBy As System.Windows.Forms.TextBox
    Friend WithEvents cmdRequestBy As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cResult As System.Windows.Forms.ComboBox
    Friend WithEvents tSpecimen As System.Windows.Forms.ComboBox
    Friend WithEvents chkDisplay As System.Windows.Forms.CheckBox
    Friend WithEvents tWard As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tResult As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuPreviewLastResult As System.Windows.Forms.ToolStripMenuItem
End Class
