<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDrugs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDrugs))
        Me.Label1 = New System.Windows.Forms.Label
        Me.tCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tDesc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tReorder = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tMaxQty = New System.Windows.Forms.TextBox
        Me.chkDiscontinue = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.lvList = New System.Windows.Forms.ListView
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.cmdNewCat = New System.Windows.Forms.Button
        Me.GrpBatch = New System.Windows.Forms.GroupBox
        Me.PanCommands = New System.Windows.Forms.Panel
        Me.mnuCut = New System.Windows.Forms.Button
        Me.mnuOpen = New System.Windows.Forms.Button
        Me.mnuInsert = New System.Windows.Forms.Button
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
        Me.cReorderUnit = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.LbCategory = New System.Windows.Forms.ListBox
        Me.lvDrugs = New System.Windows.Forms.ListView
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblDrugCount = New System.Windows.Forms.Label
        Me.cIssueUnit = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.tFactor = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.tApprovedCost = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.tFindDrugGeneric = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.tFindDrug = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tMarkupRate = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmdNewBaseUnit = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.cGenericName = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.GrpBatch.SuspendLayout()
        Me.PanCommands.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(483, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Code:"
        '
        'tCode
        '
        Me.tCode.Location = New System.Drawing.Point(565, 65)
        Me.tCode.Name = "tCode"
        Me.tCode.Size = New System.Drawing.Size(114, 20)
        Me.tCode.TabIndex = 47
        Me.tCode.TabStop = False
        Me.tCode.Tag = "ProductCode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(483, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Description:"
        '
        'tDesc
        '
        Me.tDesc.Location = New System.Drawing.Point(565, 87)
        Me.tDesc.Name = "tDesc"
        Me.tDesc.Size = New System.Drawing.Size(263, 20)
        Me.tDesc.TabIndex = 0
        Me.tDesc.Tag = "ProductName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(483, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Category:"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(566, 109)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(224, 21)
        Me.cboCategory.TabIndex = 2
        Me.cboCategory.Tag = "CategoryCode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(483, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "Reorder Level:"
        '
        'tReorder
        '
        Me.tReorder.Location = New System.Drawing.Point(565, 155)
        Me.tReorder.Name = "tReorder"
        Me.tReorder.Size = New System.Drawing.Size(52, 20)
        Me.tReorder.TabIndex = 3
        Me.tReorder.Tag = "ReorderLevel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(483, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 201
        Me.Label6.Text = "Max. Qty:"
        '
        'tMaxQty
        '
        Me.tMaxQty.Location = New System.Drawing.Point(565, 177)
        Me.tMaxQty.Name = "tMaxQty"
        Me.tMaxQty.Size = New System.Drawing.Size(52, 20)
        Me.tMaxQty.TabIndex = 4
        Me.tMaxQty.Tag = "MaxQty"
        '
        'chkDiscontinue
        '
        Me.chkDiscontinue.AutoSize = True
        Me.chkDiscontinue.Location = New System.Drawing.Point(619, 157)
        Me.chkDiscontinue.Name = "chkDiscontinue"
        Me.chkDiscontinue.Size = New System.Drawing.Size(82, 17)
        Me.chkDiscontinue.TabIndex = 223
        Me.chkDiscontinue.Text = "Discontinue"
        Me.chkDiscontinue.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(815, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(2, 132)
        Me.GroupBox1.TabIndex = 224
        Me.GroupBox1.TabStop = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.Lavender
        Me.cmdOk.Location = New System.Drawing.Point(827, 159)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(72, 44)
        Me.cmdOk.TabIndex = 225
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancel.Location = New System.Drawing.Point(827, 205)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(72, 44)
        Me.CmdCancel.TabIndex = 226
        Me.CmdCancel.Text = "&Close"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'lvList
        '
        Me.lvList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvList.BackColor = System.Drawing.Color.Lavender
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader7})
        Me.lvList.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        Me.lvList.HideSelection = False
        Me.lvList.Location = New System.Drawing.Point(5, 40)
        Me.lvList.MultiSelect = False
        Me.lvList.Name = "lvList"
        Me.lvList.ShowItemToolTips = True
        Me.lvList.Size = New System.Drawing.Size(431, 256)
        Me.lvList.TabIndex = 230
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sn"
        Me.ColumnHeader8.Width = 28
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Code"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Batch No"
        Me.ColumnHeader2.Width = 67
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date Made"
        Me.ColumnHeader5.Width = 62
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Expiry Date"
        Me.ColumnHeader6.Width = 64
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Base Unit"
        Me.ColumnHeader3.Width = 52
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cost Price"
        Me.ColumnHeader4.Width = 57
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Sell Price (Cash)"
        Me.ColumnHeader9.Width = 70
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Sell Price (Credit)"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Discontinued"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 75
        '
        'cmdNewCat
        '
        Me.cmdNewCat.BackColor = System.Drawing.Color.Lavender
        Me.cmdNewCat.Location = New System.Drawing.Point(791, 108)
        Me.cmdNewCat.Name = "cmdNewCat"
        Me.cmdNewCat.Size = New System.Drawing.Size(37, 23)
        Me.cmdNewCat.TabIndex = 232
        Me.cmdNewCat.Text = "New"
        Me.cmdNewCat.UseVisualStyleBackColor = True
        '
        'GrpBatch
        '
        Me.GrpBatch.Controls.Add(Me.PanCommands)
        Me.GrpBatch.Controls.Add(Me.lvList)
        Me.GrpBatch.Location = New System.Drawing.Point(462, 342)
        Me.GrpBatch.Name = "GrpBatch"
        Me.GrpBatch.Size = New System.Drawing.Size(441, 357)
        Me.GrpBatch.TabIndex = 233
        Me.GrpBatch.TabStop = False
        Me.GrpBatch.Text = "Batch Details"
        Me.GrpBatch.Visible = False
        '
        'PanCommands
        '
        Me.PanCommands.Controls.Add(Me.mnuCut)
        Me.PanCommands.Controls.Add(Me.mnuOpen)
        Me.PanCommands.Controls.Add(Me.mnuInsert)
        Me.PanCommands.Location = New System.Drawing.Point(4, 15)
        Me.PanCommands.Name = "PanCommands"
        Me.PanCommands.Size = New System.Drawing.Size(84, 26)
        Me.PanCommands.TabIndex = 259
        '
        'mnuCut
        '
        Me.mnuCut.Image = Global.ApexMedic.My.Resources.Resources.CUT
        Me.mnuCut.Location = New System.Drawing.Point(53, 0)
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(26, 25)
        Me.mnuCut.TabIndex = 10
        Me.mnuCut.Text = "..."
        Me.mnuCut.UseVisualStyleBackColor = True
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = Global.ApexMedic.My.Resources.Resources.OPEN
        Me.mnuOpen.Location = New System.Drawing.Point(28, 0)
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(26, 25)
        Me.mnuOpen.TabIndex = 9
        Me.mnuOpen.Text = "..."
        Me.mnuOpen.UseVisualStyleBackColor = True
        '
        'mnuInsert
        '
        Me.mnuInsert.Image = Global.ApexMedic.My.Resources.Resources.NEW1
        Me.mnuInsert.Location = New System.Drawing.Point(3, 0)
        Me.mnuInsert.Name = "mnuInsert"
        Me.mnuInsert.Size = New System.Drawing.Size(26, 25)
        Me.mnuInsert.TabIndex = 8
        Me.mnuInsert.UseVisualStyleBackColor = True
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209.0!))
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
        Me.tblHeader.Size = New System.Drawing.Size(911, 59)
        Me.tblHeader.TabIndex = 234
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
        Me.Label7.Location = New System.Drawing.Point(111, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(591, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "DRUGS"
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
        Me.PictureBox1.Size = New System.Drawing.Size(111, 59)
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
        Me.Label8.Location = New System.Drawing.Point(111, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(591, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Drug Setup"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAction.Location = New System.Drawing.Point(702, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(209, 59)
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
        'cReorderUnit
        '
        Me.cReorderUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cReorderUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cReorderUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cReorderUnit.FormattingEnabled = True
        Me.cReorderUnit.Location = New System.Drawing.Point(567, 200)
        Me.cReorderUnit.Name = "cReorderUnit"
        Me.cReorderUnit.Size = New System.Drawing.Size(92, 20)
        Me.cReorderUnit.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(483, 206)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 237
        Me.Label15.Text = "Reorder Unit:"
        '
        'LbCategory
        '
        Me.LbCategory.BackColor = System.Drawing.Color.Azure
        Me.LbCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategory.FormattingEnabled = True
        Me.LbCategory.Location = New System.Drawing.Point(0, 106)
        Me.LbCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.LbCategory.Name = "LbCategory"
        Me.LbCategory.Size = New System.Drawing.Size(194, 459)
        Me.LbCategory.TabIndex = 3
        '
        'lvDrugs
        '
        Me.lvDrugs.BackColor = System.Drawing.Color.Azure
        Me.lvDrugs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvDrugs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvDrugs.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDrugs.FullRowSelect = True
        Me.lvDrugs.GridLines = True
        Me.lvDrugs.HideSelection = False
        Me.lvDrugs.Location = New System.Drawing.Point(194, 0)
        Me.lvDrugs.Margin = New System.Windows.Forms.Padding(0)
        Me.lvDrugs.MultiSelect = False
        Me.lvDrugs.Name = "lvDrugs"
        Me.TableLayoutPanel1.SetRowSpan(Me.lvDrugs, 2)
        Me.lvDrugs.Size = New System.Drawing.Size(266, 567)
        Me.lvDrugs.TabIndex = 5
        Me.lvDrugs.UseCompatibleStateImageBehavior = False
        Me.lvDrugs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Code"
        Me.ColumnHeader11.Width = 46
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Description"
        Me.ColumnHeader12.Width = 197
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(746, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 240
        Me.Label9.Text = "Total Drug in Category:"
        '
        'lblDrugCount
        '
        Me.lblDrugCount.AutoSize = True
        Me.lblDrugCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrugCount.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDrugCount.Location = New System.Drawing.Point(864, 327)
        Me.lblDrugCount.Name = "lblDrugCount"
        Me.lblDrugCount.Size = New System.Drawing.Size(14, 13)
        Me.lblDrugCount.TabIndex = 241
        Me.lblDrugCount.Text = "0"
        '
        'cIssueUnit
        '
        Me.cIssueUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cIssueUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cIssueUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cIssueUnit.FormattingEnabled = True
        Me.cIssueUnit.Location = New System.Drawing.Point(567, 224)
        Me.cIssueUnit.Name = "cIssueUnit"
        Me.cIssueUnit.Size = New System.Drawing.Size(92, 20)
        Me.cIssueUnit.TabIndex = 243
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(483, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 242
        Me.Label5.Text = "Issue Unit:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(483, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 245
        Me.Label10.Text = "Factor:"
        '
        'tFactor
        '
        Me.tFactor.Location = New System.Drawing.Point(566, 247)
        Me.tFactor.Name = "tFactor"
        Me.tFactor.Size = New System.Drawing.Size(52, 20)
        Me.tFactor.TabIndex = 244
        Me.tFactor.Tag = "Factor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(623, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 12)
        Me.Label11.TabIndex = 246
        Me.Label11.Text = "Scale of Reorder Unit to Issue Unit"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(483, 276)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 248
        Me.Label12.Text = "Approved Cost:"
        '
        'tApprovedCost
        '
        Me.tApprovedCost.Location = New System.Drawing.Point(567, 270)
        Me.tApprovedCost.Name = "tApprovedCost"
        Me.tApprovedCost.Size = New System.Drawing.Size(89, 20)
        Me.tApprovedCost.TabIndex = 247
        Me.tApprovedCost.Tag = "MaxQty"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lvDrugs, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LbCategory, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 59)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(460, 567)
        Me.TableLayoutPanel1.TabIndex = 249
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightYellow
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.tFindDrugGeneric)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.tFindDrug)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(194, 106)
        Me.Panel3.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Maroon
        Me.Label20.Location = New System.Drawing.Point(-1, 66)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(171, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Type any part of the Generic name"
        '
        'tFindDrugGeneric
        '
        Me.tFindDrugGeneric.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFindDrugGeneric.ForeColor = System.Drawing.Color.Maroon
        Me.tFindDrugGeneric.Location = New System.Drawing.Point(4, 81)
        Me.tFindDrugGeneric.Name = "tFindDrugGeneric"
        Me.tFindDrugGeneric.Size = New System.Drawing.Size(184, 21)
        Me.tFindDrugGeneric.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.SteelBlue
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(192, 23)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Find Drug"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Type any part of the drug name"
        '
        'tFindDrug
        '
        Me.tFindDrug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFindDrug.Location = New System.Drawing.Point(3, 42)
        Me.tFindDrug.Name = "tFindDrug"
        Me.tFindDrug.Size = New System.Drawing.Size(185, 21)
        Me.tFindDrug.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(483, 299)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 251
        Me.Label16.Text = "Markup Rate:"
        '
        'tMarkupRate
        '
        Me.tMarkupRate.Location = New System.Drawing.Point(567, 293)
        Me.tMarkupRate.Name = "tMarkupRate"
        Me.tMarkupRate.Size = New System.Drawing.Size(54, 20)
        Me.tMarkupRate.TabIndex = 250
        Me.tMarkupRate.Tag = "MaxQty"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(627, 298)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 12)
        Me.Label17.TabIndex = 252
        Me.Label17.Text = "Evaluated Percent"
        '
        'cmdNewBaseUnit
        '
        Me.cmdNewBaseUnit.BackColor = System.Drawing.Color.Lavender
        Me.cmdNewBaseUnit.Location = New System.Drawing.Point(665, 200)
        Me.cmdNewBaseUnit.Name = "cmdNewBaseUnit"
        Me.cmdNewBaseUnit.Size = New System.Drawing.Size(37, 43)
        Me.cmdNewBaseUnit.TabIndex = 253
        Me.cmdNewBaseUnit.Text = "New"
        Me.cmdNewBaseUnit.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(662, 275)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 12)
        Me.Label18.TabIndex = 254
        Me.Label18.Text = "Per Reorder Unit"
        '
        'cGenericName
        '
        Me.cGenericName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cGenericName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cGenericName.FormattingEnabled = True
        Me.cGenericName.Location = New System.Drawing.Point(566, 132)
        Me.cGenericName.Name = "cGenericName"
        Me.cGenericName.Size = New System.Drawing.Size(224, 21)
        Me.cGenericName.TabIndex = 255
        Me.cGenericName.Tag = "GenericName"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(483, 136)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 256
        Me.Label19.Text = "Generic Name:"
        '
        'FrmDrugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(911, 626)
        Me.Controls.Add(Me.cGenericName)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmdNewBaseUnit)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tMarkupRate)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tApprovedCost)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tFactor)
        Me.Controls.Add(Me.cIssueUnit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDrugCount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cReorderUnit)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tblHeader)
        Me.Controls.Add(Me.GrpBatch)
        Me.Controls.Add(Me.cmdNewCat)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkDiscontinue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tMaxQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tReorder)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDrugs"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Drug Items"
        Me.GrpBatch.ResumeLayout(False)
        Me.PanCommands.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tReorder As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tMaxQty As System.Windows.Forms.TextBox
    Friend WithEvents chkDiscontinue As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Public WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdNewCat As System.Windows.Forms.Button
    Friend WithEvents GrpBatch As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PanCommands As System.Windows.Forms.Panel
    Friend WithEvents mnuCut As System.Windows.Forms.Button
    Friend WithEvents mnuOpen As System.Windows.Forms.Button
    Friend WithEvents mnuInsert As System.Windows.Forms.Button
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cReorderUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LbCategory As System.Windows.Forms.ListBox
    Friend WithEvents lvDrugs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDrugCount As System.Windows.Forms.Label
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents cIssueUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tFactor As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tApprovedCost As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tFindDrug As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tMarkupRate As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmdNewBaseUnit As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cGenericName As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tFindDrugGeneric As System.Windows.Forms.TextBox
End Class
