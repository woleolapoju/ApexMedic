<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockAdjustment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStockAdjustment))
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.tFindDrugGeneric = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tFindDrug = New System.Windows.Forms.TextBox
        Me.LbCategory = New System.Windows.Forms.ListBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.GrpDetails = New System.Windows.Forms.GroupBox
        Me.lblMarkup = New System.Windows.Forms.Label
        Me.tMarkup = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tFactor = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.tPriceCash = New System.Windows.Forms.TextBox
        Me.tPriceCredit = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tPriceNHIS = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.RadIssueUnit = New System.Windows.Forms.RadioButton
        Me.RadReorderUnit = New System.Windows.Forms.RadioButton
        Me.chkShowAllDrugs = New System.Windows.Forms.CheckBox
        Me.cmdNewBatch = New System.Windows.Forms.Button
        Me.cmdNewDrug = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.tCostPrice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tReason = New System.Windows.Forms.TextBox
        Me.cStore = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.tUnitInStock = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.tQty = New System.Windows.Forms.TextBox
        Me.cBatchNo = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tDrugName = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tDrugCode = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label37 = New System.Windows.Forms.Label
        Me.cboBaseUnit = New System.Windows.Forms.ComboBox
        Me.lvDrugs = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GrpDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.Controls.Add(Me.Label7, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label8, 1, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblHeader.Size = New System.Drawing.Size(868, 54)
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
        Me.Label7.Location = New System.Drawing.Point(80, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(788, 30)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "STOCK ADJUSTMENT"
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
        Me.PictureBox1.Size = New System.Drawing.Size(80, 54)
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
        Me.Label8.Location = New System.Drawing.Point(80, 30)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(788, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Manages Adjustments on Stock "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LbCategory, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 54)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(868, 580)
        Me.TableLayoutPanel1.TabIndex = 52
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightYellow
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.tFindDrugGeneric)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.tFindDrug)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(186, 111)
        Me.Panel3.TabIndex = 58
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(-1, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(171, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Type any part of the Generic name"
        '
        'tFindDrugGeneric
        '
        Me.tFindDrugGeneric.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFindDrugGeneric.ForeColor = System.Drawing.Color.Maroon
        Me.tFindDrugGeneric.Location = New System.Drawing.Point(4, 81)
        Me.tFindDrugGeneric.Name = "tFindDrugGeneric"
        Me.tFindDrugGeneric.Size = New System.Drawing.Size(176, 21)
        Me.tFindDrugGeneric.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Find Drug"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Type any part of the drug name"
        '
        'tFindDrug
        '
        Me.tFindDrug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFindDrug.Location = New System.Drawing.Point(3, 42)
        Me.tFindDrug.Name = "tFindDrug"
        Me.tFindDrug.Size = New System.Drawing.Size(176, 21)
        Me.tFindDrug.TabIndex = 11
        '
        'LbCategory
        '
        Me.LbCategory.BackColor = System.Drawing.Color.Azure
        Me.LbCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategory.FormattingEnabled = True
        Me.LbCategory.Location = New System.Drawing.Point(0, 111)
        Me.LbCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.LbCategory.Name = "LbCategory"
        Me.LbCategory.Size = New System.Drawing.Size(186, 459)
        Me.LbCategory.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GrpDetails, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(453, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(412, 574)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'GrpDetails
        '
        Me.GrpDetails.Controls.Add(Me.lblMarkup)
        Me.GrpDetails.Controls.Add(Me.tMarkup)
        Me.GrpDetails.Controls.Add(Me.Label16)
        Me.GrpDetails.Controls.Add(Me.tFactor)
        Me.GrpDetails.Controls.Add(Me.GroupBox1)
        Me.GrpDetails.Controls.Add(Me.Label12)
        Me.GrpDetails.Controls.Add(Me.RadIssueUnit)
        Me.GrpDetails.Controls.Add(Me.RadReorderUnit)
        Me.GrpDetails.Controls.Add(Me.chkShowAllDrugs)
        Me.GrpDetails.Controls.Add(Me.cmdNewBatch)
        Me.GrpDetails.Controls.Add(Me.cmdNewDrug)
        Me.GrpDetails.Controls.Add(Me.Label9)
        Me.GrpDetails.Controls.Add(Me.tCostPrice)
        Me.GrpDetails.Controls.Add(Me.Label3)
        Me.GrpDetails.Controls.Add(Me.tReason)
        Me.GrpDetails.Controls.Add(Me.cStore)
        Me.GrpDetails.Controls.Add(Me.Label11)
        Me.GrpDetails.Controls.Add(Me.dtpDate)
        Me.GrpDetails.Controls.Add(Me.Label2)
        Me.GrpDetails.Controls.Add(Me.tUnitInStock)
        Me.GrpDetails.Controls.Add(Me.Label20)
        Me.GrpDetails.Controls.Add(Me.cmdClose)
        Me.GrpDetails.Controls.Add(Me.cmdOk)
        Me.GrpDetails.Controls.Add(Me.GroupBox2)
        Me.GrpDetails.Controls.Add(Me.Label18)
        Me.GrpDetails.Controls.Add(Me.tQty)
        Me.GrpDetails.Controls.Add(Me.cBatchNo)
        Me.GrpDetails.Controls.Add(Me.Label14)
        Me.GrpDetails.Controls.Add(Me.tDrugName)
        Me.GrpDetails.Controls.Add(Me.Label13)
        Me.GrpDetails.Controls.Add(Me.tDrugCode)
        Me.GrpDetails.Controls.Add(Me.Label10)
        Me.GrpDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDetails.ForeColor = System.Drawing.Color.DarkBlue
        Me.GrpDetails.Location = New System.Drawing.Point(0, 0)
        Me.GrpDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.GrpDetails.Name = "GrpDetails"
        Me.GrpDetails.Size = New System.Drawing.Size(407, 303)
        Me.GrpDetails.TabIndex = 6
        Me.GrpDetails.TabStop = False
        Me.GrpDetails.Text = "Product Details"
        '
        'lblMarkup
        '
        Me.lblMarkup.AutoSize = True
        Me.lblMarkup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarkup.ForeColor = System.Drawing.Color.Black
        Me.lblMarkup.Location = New System.Drawing.Point(9, 246)
        Me.lblMarkup.Name = "lblMarkup"
        Me.lblMarkup.Size = New System.Drawing.Size(46, 13)
        Me.lblMarkup.TabIndex = 290
        Me.lblMarkup.Text = "Markup:"
        '
        'tMarkup
        '
        Me.tMarkup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMarkup.Location = New System.Drawing.Point(79, 241)
        Me.tMarkup.Name = "tMarkup"
        Me.tMarkup.ReadOnly = True
        Me.tMarkup.Size = New System.Drawing.Size(49, 20)
        Me.tMarkup.TabIndex = 289
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(8, 224)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 288
        Me.Label16.Text = "Factor:"
        '
        'tFactor
        '
        Me.tFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFactor.Location = New System.Drawing.Point(78, 219)
        Me.tFactor.Name = "tFactor"
        Me.tFactor.ReadOnly = True
        Me.tFactor.Size = New System.Drawing.Size(49, 20)
        Me.tFactor.TabIndex = 287
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.tPriceCash)
        Me.GroupBox1.Controls.Add(Me.tPriceCredit)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tPriceNHIS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(193, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 83)
        Me.GroupBox1.TabIndex = 286
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Per Issue Unit"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(7, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 13)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Sell Price (Cash):"
        '
        'tPriceCash
        '
        Me.tPriceCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceCash.Location = New System.Drawing.Point(103, 14)
        Me.tPriceCash.Name = "tPriceCash"
        Me.tPriceCash.Size = New System.Drawing.Size(98, 20)
        Me.tPriceCash.TabIndex = 71
        '
        'tPriceCredit
        '
        Me.tPriceCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceCredit.Location = New System.Drawing.Point(103, 37)
        Me.tPriceCredit.Name = "tPriceCredit"
        Me.tPriceCredit.Size = New System.Drawing.Size(98, 20)
        Me.tPriceCredit.TabIndex = 273
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 274
        Me.Label6.Text = "Sell Price (Credit):"
        '
        'tPriceNHIS
        '
        Me.tPriceNHIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceNHIS.Location = New System.Drawing.Point(104, 59)
        Me.tPriceNHIS.Name = "tPriceNHIS"
        Me.tPriceNHIS.Size = New System.Drawing.Size(98, 20)
        Me.tPriceNHIS.TabIndex = 275
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 276
        Me.Label1.Text = "Sell Price (NHIS):"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 285
        Me.Label12.Text = "Issue Unit:"
        '
        'RadIssueUnit
        '
        Me.RadIssueUnit.AutoSize = True
        Me.RadIssueUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadIssueUnit.ForeColor = System.Drawing.Color.DarkRed
        Me.RadIssueUnit.Location = New System.Drawing.Point(76, 110)
        Me.RadIssueUnit.Name = "RadIssueUnit"
        Me.RadIssueUnit.Size = New System.Drawing.Size(72, 17)
        Me.RadIssueUnit.TabIndex = 283
        Me.RadIssueUnit.Text = "Issue Unit"
        Me.RadIssueUnit.UseVisualStyleBackColor = True
        '
        'RadReorderUnit
        '
        Me.RadReorderUnit.AutoSize = True
        Me.RadReorderUnit.Checked = True
        Me.RadReorderUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadReorderUnit.ForeColor = System.Drawing.Color.DarkRed
        Me.RadReorderUnit.Location = New System.Drawing.Point(76, 91)
        Me.RadReorderUnit.Name = "RadReorderUnit"
        Me.RadReorderUnit.Size = New System.Drawing.Size(73, 17)
        Me.RadReorderUnit.TabIndex = 282
        Me.RadReorderUnit.TabStop = True
        Me.RadReorderUnit.Text = "Order Unit"
        Me.RadReorderUnit.UseVisualStyleBackColor = True
        '
        'chkShowAllDrugs
        '
        Me.chkShowAllDrugs.AutoSize = True
        Me.chkShowAllDrugs.Checked = True
        Me.chkShowAllDrugs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowAllDrugs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowAllDrugs.ForeColor = System.Drawing.Color.DarkRed
        Me.chkShowAllDrugs.Location = New System.Drawing.Point(9, 280)
        Me.chkShowAllDrugs.Name = "chkShowAllDrugs"
        Me.chkShowAllDrugs.Size = New System.Drawing.Size(98, 17)
        Me.chkShowAllDrugs.TabIndex = 281
        Me.chkShowAllDrugs.Text = "Show All Drugs"
        Me.chkShowAllDrugs.UseVisualStyleBackColor = True
        '
        'cmdNewBatch
        '
        Me.cmdNewBatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNewBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewBatch.Location = New System.Drawing.Point(171, 64)
        Me.cmdNewBatch.Name = "cmdNewBatch"
        Me.cmdNewBatch.Size = New System.Drawing.Size(35, 23)
        Me.cmdNewBatch.TabIndex = 280
        Me.cmdNewBatch.Text = "New"
        Me.cmdNewBatch.UseVisualStyleBackColor = True
        '
        'cmdNewDrug
        '
        Me.cmdNewDrug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNewDrug.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewDrug.Location = New System.Drawing.Point(171, 42)
        Me.cmdNewDrug.Name = "cmdNewDrug"
        Me.cmdNewDrug.Size = New System.Drawing.Size(35, 23)
        Me.cmdNewDrug.TabIndex = 279
        Me.cmdNewDrug.Text = "New"
        Me.cmdNewDrug.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 278
        Me.Label9.Text = "Cost Price:"
        '
        'tCostPrice
        '
        Me.tCostPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCostPrice.Location = New System.Drawing.Point(77, 153)
        Me.tCostPrice.Name = "tCostPrice"
        Me.tCostPrice.Size = New System.Drawing.Size(93, 20)
        Me.tCostPrice.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 272
        Me.Label3.Text = "Reason:"
        '
        'tReason
        '
        Me.tReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tReason.Location = New System.Drawing.Point(77, 176)
        Me.tReason.Multiline = True
        Me.tReason.Name = "tReason"
        Me.tReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tReason.Size = New System.Drawing.Size(326, 41)
        Me.tReason.TabIndex = 271
        Me.tReason.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cStore
        '
        Me.cStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cStore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cStore.FormattingEnabled = True
        Me.cStore.Location = New System.Drawing.Point(78, 20)
        Me.cStore.Name = "cStore"
        Me.cStore.Size = New System.Drawing.Size(116, 21)
        Me.cStore.TabIndex = 270
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 269
        Me.Label11.Text = "Store:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(300, 22)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(99, 20)
        Me.dtpDate.TabIndex = 267
        Me.dtpDate.Tag = "RegDate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(206, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 268
        Me.Label2.Text = "Date:"
        '
        'tUnitInStock
        '
        Me.tUnitInStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnitInStock.Location = New System.Drawing.Point(302, 66)
        Me.tUnitInStock.Name = "tUnitInStock"
        Me.tUnitInStock.ReadOnly = True
        Me.tUnitInStock.Size = New System.Drawing.Size(98, 20)
        Me.tUnitInStock.TabIndex = 264
        Me.tUnitInStock.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(206, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 13)
        Me.Label20.TabIndex = 263
        Me.Label20.Text = "Unit In Store:"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Black
        Me.cmdClose.Location = New System.Drawing.Point(333, 228)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(68, 43)
        Me.cmdClose.TabIndex = 262
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.Color.Black
        Me.cmdOk.Location = New System.Drawing.Point(265, 228)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(68, 43)
        Me.cmdOk.TabIndex = 261
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(211, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(191, 3)
        Me.GroupBox2.TabIndex = 260
        Me.GroupBox2.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(7, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 13)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "Qty:"
        '
        'tQty
        '
        Me.tQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tQty.Location = New System.Drawing.Point(77, 131)
        Me.tQty.Name = "tQty"
        Me.tQty.Size = New System.Drawing.Size(49, 20)
        Me.tQty.TabIndex = 69
        '
        'cBatchNo
        '
        Me.cBatchNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBatchNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBatchNo.FormattingEnabled = True
        Me.cBatchNo.Location = New System.Drawing.Point(78, 65)
        Me.cBatchNo.Name = "cBatchNo"
        Me.cBatchNo.Size = New System.Drawing.Size(92, 21)
        Me.cBatchNo.TabIndex = 66
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(7, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Batch No:"
        '
        'tDrugName
        '
        Me.tDrugName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDrugName.Location = New System.Drawing.Point(205, 44)
        Me.tDrugName.Name = "tDrugName"
        Me.tDrugName.ReadOnly = True
        Me.tDrugName.Size = New System.Drawing.Size(196, 20)
        Me.tDrugName.TabIndex = 48
        Me.tDrugName.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Drug:"
        '
        'tDrugCode
        '
        Me.tDrugCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDrugCode.Location = New System.Drawing.Point(77, 43)
        Me.tDrugCode.Name = "tDrugCode"
        Me.tDrugCode.Size = New System.Drawing.Size(94, 20)
        Me.tDrugCode.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 284
        Me.Label10.Text = "Reorder Unit:"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lvDrugs, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(189, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(258, 574)
        Me.TableLayoutPanel3.TabIndex = 59
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightYellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Controls.Add(Me.cboBaseUnit)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 29)
        Me.Panel2.TabIndex = 5
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(4, 7)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 13)
        Me.Label37.TabIndex = 14
        Me.Label37.Text = "Base Unit:"
        '
        'cboBaseUnit
        '
        Me.cboBaseUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaseUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboBaseUnit.FormattingEnabled = True
        Me.cboBaseUnit.Location = New System.Drawing.Point(63, 2)
        Me.cboBaseUnit.Name = "cboBaseUnit"
        Me.cboBaseUnit.Size = New System.Drawing.Size(137, 21)
        Me.cboBaseUnit.TabIndex = 1
        '
        'lvDrugs
        '
        Me.lvDrugs.BackColor = System.Drawing.Color.Azure
        Me.lvDrugs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvDrugs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvDrugs.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDrugs.FullRowSelect = True
        Me.lvDrugs.GridLines = True
        Me.lvDrugs.HideSelection = False
        Me.lvDrugs.Location = New System.Drawing.Point(0, 31)
        Me.lvDrugs.Margin = New System.Windows.Forms.Padding(0)
        Me.lvDrugs.MultiSelect = False
        Me.lvDrugs.Name = "lvDrugs"
        Me.lvDrugs.Size = New System.Drawing.Size(258, 543)
        Me.lvDrugs.TabIndex = 4
        Me.lvDrugs.UseCompatibleStateImageBehavior = False
        Me.lvDrugs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Code"
        Me.ColumnHeader3.Width = 46
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 186
        '
        'FrmStockAdjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(868, 634)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmStockAdjustment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Adjustment"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GrpDetails.ResumeLayout(False)
        Me.GrpDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LbCategory As System.Windows.Forms.ListBox
    Friend WithEvents lvDrugs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GrpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cStore As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tUnitInStock As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tPriceCash As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tQty As System.Windows.Forms.TextBox
    Friend WithEvents cBatchNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tDrugName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tDrugCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tReason As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tPriceCredit As System.Windows.Forms.TextBox
    Friend WithEvents cboBaseUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tFindDrug As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tPriceNHIS As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tCostPrice As System.Windows.Forms.TextBox
    Friend WithEvents cmdNewDrug As System.Windows.Forms.Button
    Friend WithEvents cmdNewBatch As System.Windows.Forms.Button
    Friend WithEvents chkShowAllDrugs As System.Windows.Forms.CheckBox
    Friend WithEvents RadReorderUnit As System.Windows.Forms.RadioButton
    Friend WithEvents RadIssueUnit As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tFindDrugGeneric As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tFactor As System.Windows.Forms.TextBox
    Friend WithEvents lblMarkup As System.Windows.Forms.Label
    Friend WithEvents tMarkup As System.Windows.Forms.TextBox
End Class
