<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransfer_Old
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransfer_Old))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.GrpDetails = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tCostPrice = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tPriceCredit = New System.Windows.Forms.TextBox
        Me.cStoreDestination = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.tUnitInStock = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.tPriceCash = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.tQty = New System.Windows.Forms.TextBox
        Me.cBaseUnit = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cBatchNo = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tDrugName = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tDrugCode = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.tFindDrug = New System.Windows.Forms.TextBox
        Me.LbCategory = New System.Windows.Forms.ListBox
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.lvDrugs = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label37 = New System.Windows.Forms.Label
        Me.cStoreSource = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkIssue = New System.Windows.Forms.CheckBox
        Me.GrpIssue = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tFactor = New System.Windows.Forms.TextBox
        Me.cIssueUnit = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tCQty = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tPriceNHIS = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GrpDetails.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblHeader.SuspendLayout()
        Me.GrpIssue.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 54)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.57747!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.42254!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(941, 648)
        Me.TableLayoutPanel1.TabIndex = 54
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GrpDetails, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(500, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(438, 642)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'GrpDetails
        '
        Me.GrpDetails.Controls.Add(Me.Label12)
        Me.GrpDetails.Controls.Add(Me.tPriceNHIS)
        Me.GrpDetails.Controls.Add(Me.GrpIssue)
        Me.GrpDetails.Controls.Add(Me.chkIssue)
        Me.GrpDetails.Controls.Add(Me.Label3)
        Me.GrpDetails.Controls.Add(Me.tCostPrice)
        Me.GrpDetails.Controls.Add(Me.Label6)
        Me.GrpDetails.Controls.Add(Me.tPriceCredit)
        Me.GrpDetails.Controls.Add(Me.cStoreDestination)
        Me.GrpDetails.Controls.Add(Me.Label11)
        Me.GrpDetails.Controls.Add(Me.dtpDate)
        Me.GrpDetails.Controls.Add(Me.Label2)
        Me.GrpDetails.Controls.Add(Me.tUnitInStock)
        Me.GrpDetails.Controls.Add(Me.Label20)
        Me.GrpDetails.Controls.Add(Me.cmdClose)
        Me.GrpDetails.Controls.Add(Me.cmdOk)
        Me.GrpDetails.Controls.Add(Me.GroupBox2)
        Me.GrpDetails.Controls.Add(Me.Label19)
        Me.GrpDetails.Controls.Add(Me.tPriceCash)
        Me.GrpDetails.Controls.Add(Me.Label18)
        Me.GrpDetails.Controls.Add(Me.tQty)
        Me.GrpDetails.Controls.Add(Me.cBaseUnit)
        Me.GrpDetails.Controls.Add(Me.Label15)
        Me.GrpDetails.Controls.Add(Me.cBatchNo)
        Me.GrpDetails.Controls.Add(Me.Label14)
        Me.GrpDetails.Controls.Add(Me.tDrugName)
        Me.GrpDetails.Controls.Add(Me.Label13)
        Me.GrpDetails.Controls.Add(Me.tDrugCode)
        Me.GrpDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDetails.ForeColor = System.Drawing.Color.DarkBlue
        Me.GrpDetails.Location = New System.Drawing.Point(3, 3)
        Me.GrpDetails.Name = "GrpDetails"
        Me.GrpDetails.Size = New System.Drawing.Size(429, 268)
        Me.GrpDetails.TabIndex = 6
        Me.GrpDetails.TabStop = False
        Me.GrpDetails.Text = "Product Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(224, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 276
        Me.Label3.Text = "Cost Price:"
        '
        'tCostPrice
        '
        Me.tCostPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCostPrice.Location = New System.Drawing.Point(318, 87)
        Me.tCostPrice.Name = "tCostPrice"
        Me.tCostPrice.ReadOnly = True
        Me.tCostPrice.Size = New System.Drawing.Size(101, 20)
        Me.tCostPrice.TabIndex = 275
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(223, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 274
        Me.Label6.Text = "Sell Price (Credit):"
        '
        'tPriceCredit
        '
        Me.tPriceCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceCredit.Location = New System.Drawing.Point(318, 132)
        Me.tPriceCredit.Name = "tPriceCredit"
        Me.tPriceCredit.ReadOnly = True
        Me.tPriceCredit.Size = New System.Drawing.Size(101, 20)
        Me.tPriceCredit.TabIndex = 273
        '
        'cStoreDestination
        '
        Me.cStoreDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cStoreDestination.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cStoreDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cStoreDestination.FormattingEnabled = True
        Me.cStoreDestination.Location = New System.Drawing.Point(96, 20)
        Me.cStoreDestination.Name = "cStoreDestination"
        Me.cStoreDestination.Size = New System.Drawing.Size(116, 21)
        Me.cStoreDestination.TabIndex = 270
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 269
        Me.Label11.Text = "Destination Store:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(316, 22)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(103, 20)
        Me.dtpDate.TabIndex = 267
        Me.dtpDate.Tag = "RegDate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(224, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 268
        Me.Label2.Text = "Date:"
        '
        'tUnitInStock
        '
        Me.tUnitInStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnitInStock.Location = New System.Drawing.Point(317, 66)
        Me.tUnitInStock.Name = "tUnitInStock"
        Me.tUnitInStock.ReadOnly = True
        Me.tUnitInStock.Size = New System.Drawing.Size(103, 20)
        Me.tUnitInStock.TabIndex = 264
        Me.tUnitInStock.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(224, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 13)
        Me.Label20.TabIndex = 263
        Me.Label20.Text = "Unit In Store:"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Black
        Me.cmdClose.Location = New System.Drawing.Point(352, 188)
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
        Me.cmdOk.Location = New System.Drawing.Point(284, 188)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(68, 43)
        Me.cmdOk.TabIndex = 261
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(230, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(191, 3)
        Me.GroupBox2.TabIndex = 260
        Me.GroupBox2.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(224, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 13)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Sell Price (Cash):"
        '
        'tPriceCash
        '
        Me.tPriceCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceCash.Location = New System.Drawing.Point(318, 109)
        Me.tPriceCash.Name = "tPriceCash"
        Me.tPriceCash.ReadOnly = True
        Me.tPriceCash.Size = New System.Drawing.Size(101, 20)
        Me.tPriceCash.TabIndex = 71
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(9, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 13)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "Qty:"
        '
        'tQty
        '
        Me.tQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tQty.Location = New System.Drawing.Point(95, 112)
        Me.tQty.Name = "tQty"
        Me.tQty.Size = New System.Drawing.Size(49, 20)
        Me.tQty.TabIndex = 69
        '
        'cBaseUnit
        '
        Me.cBaseUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBaseUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cBaseUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBaseUnit.FormattingEnabled = True
        Me.cBaseUnit.Location = New System.Drawing.Point(96, 89)
        Me.cBaseUnit.Name = "cBaseUnit"
        Me.cBaseUnit.Size = New System.Drawing.Size(92, 21)
        Me.cBaseUnit.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(7, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Base Unit:"
        '
        'cBatchNo
        '
        Me.cBatchNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBatchNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBatchNo.FormattingEnabled = True
        Me.cBatchNo.Location = New System.Drawing.Point(96, 65)
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
        Me.tDrugName.Location = New System.Drawing.Point(190, 44)
        Me.tDrugName.Name = "tDrugName"
        Me.tDrugName.ReadOnly = True
        Me.tDrugName.Size = New System.Drawing.Size(230, 20)
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
        Me.tDrugCode.Location = New System.Drawing.Point(95, 44)
        Me.tDrugCode.Name = "tDrugCode"
        Me.tDrugCode.Size = New System.Drawing.Size(94, 20)
        Me.tDrugCode.TabIndex = 46
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LbCategory, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel4, 2)
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(198, 642)
        Me.TableLayoutPanel4.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightYellow
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.tFindDrug)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(198, 79)
        Me.Panel3.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 23)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Find Drug"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Type any part of the drug name"
        '
        'tFindDrug
        '
        Me.tFindDrug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFindDrug.Location = New System.Drawing.Point(3, 49)
        Me.tFindDrug.Name = "tFindDrug"
        Me.tFindDrug.Size = New System.Drawing.Size(189, 21)
        Me.tFindDrug.TabIndex = 11
        '
        'LbCategory
        '
        Me.LbCategory.BackColor = System.Drawing.Color.Azure
        Me.LbCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategory.FormattingEnabled = True
        Me.LbCategory.Location = New System.Drawing.Point(0, 79)
        Me.LbCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.LbCategory.Name = "LbCategory"
        Me.LbCategory.Size = New System.Drawing.Size(198, 563)
        Me.LbCategory.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lvDrugs, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(207, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel5, 2)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(287, 642)
        Me.TableLayoutPanel5.TabIndex = 7
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
        Me.lvDrugs.Size = New System.Drawing.Size(287, 611)
        Me.lvDrugs.TabIndex = 4
        Me.lvDrugs.UseCompatibleStateImageBehavior = False
        Me.lvDrugs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Code"
        Me.ColumnHeader3.Width = 55
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 206
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightYellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label37)
        Me.Panel1.Controls.Add(Me.cStoreSource)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 29)
        Me.Panel1.TabIndex = 6
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(4, 7)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 13)
        Me.Label37.TabIndex = 14
        Me.Label37.Text = "Source Store:"
        '
        'cStoreSource
        '
        Me.cStoreSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cStoreSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cStoreSource.FormattingEnabled = True
        Me.cStoreSource.Location = New System.Drawing.Point(80, 4)
        Me.cStoreSource.Name = "cStoreSource"
        Me.cStoreSource.Size = New System.Drawing.Size(180, 21)
        Me.cStoreSource.TabIndex = 1
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
        Me.Label8.Size = New System.Drawing.Size(861, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Manages Transfers between stores"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.tblHeader.Size = New System.Drawing.Size(941, 54)
        Me.tblHeader.TabIndex = 53
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
        Me.Label7.Size = New System.Drawing.Size(861, 30)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "STOCK TRANSFER"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkIssue
        '
        Me.chkIssue.AutoSize = True
        Me.chkIssue.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIssue.ForeColor = System.Drawing.Color.Red
        Me.chkIssue.Location = New System.Drawing.Point(12, 137)
        Me.chkIssue.Name = "chkIssue"
        Me.chkIssue.Size = New System.Drawing.Size(129, 17)
        Me.chkIssue.TabIndex = 277
        Me.chkIssue.Text = "Convert to Issue unit  "
        Me.chkIssue.UseVisualStyleBackColor = True
        '
        'GrpIssue
        '
        Me.GrpIssue.Controls.Add(Me.Label5)
        Me.GrpIssue.Controls.Add(Me.tCQty)
        Me.GrpIssue.Controls.Add(Me.Label1)
        Me.GrpIssue.Controls.Add(Me.tFactor)
        Me.GrpIssue.Controls.Add(Me.cIssueUnit)
        Me.GrpIssue.Controls.Add(Me.Label4)
        Me.GrpIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpIssue.ForeColor = System.Drawing.Color.DarkBlue
        Me.GrpIssue.Location = New System.Drawing.Point(7, 163)
        Me.GrpIssue.Name = "GrpIssue"
        Me.GrpIssue.Size = New System.Drawing.Size(204, 89)
        Me.GrpIssue.TabIndex = 278
        Me.GrpIssue.TabStop = False
        Me.GrpIssue.Text = "Issue Unit Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Factor:"
        '
        'tFactor
        '
        Me.tFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFactor.Location = New System.Drawing.Point(100, 37)
        Me.tFactor.Name = "tFactor"
        Me.tFactor.ReadOnly = True
        Me.tFactor.Size = New System.Drawing.Size(49, 20)
        Me.tFactor.TabIndex = 73
        '
        'cIssueUnit
        '
        Me.cIssueUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cIssueUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cIssueUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cIssueUnit.FormattingEnabled = True
        Me.cIssueUnit.Location = New System.Drawing.Point(101, 13)
        Me.cIssueUnit.Name = "cIssueUnit"
        Me.cIssueUnit.Size = New System.Drawing.Size(92, 21)
        Me.cIssueUnit.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Issue Unit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Converted Qty:"
        '
        'tCQty
        '
        Me.tCQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCQty.Location = New System.Drawing.Point(100, 60)
        Me.tCQty.Name = "tCQty"
        Me.tCQty.Size = New System.Drawing.Size(49, 20)
        Me.tCQty.TabIndex = 75
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(223, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 280
        Me.Label12.Text = "Sell Price (NHIS):"
        '
        'tPriceNHIS
        '
        Me.tPriceNHIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceNHIS.Location = New System.Drawing.Point(318, 155)
        Me.tPriceNHIS.Name = "tPriceNHIS"
        Me.tPriceNHIS.ReadOnly = True
        Me.tPriceNHIS.Size = New System.Drawing.Size(101, 20)
        Me.tPriceNHIS.TabIndex = 279
        '
        'FrmTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 702)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTransfer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GrpDetails.ResumeLayout(False)
        Me.GrpDetails.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        Me.GrpIssue.ResumeLayout(False)
        Me.GrpIssue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvDrugs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cStoreSource As System.Windows.Forms.ComboBox
    Friend WithEvents LbCategory As System.Windows.Forms.ListBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GrpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cStoreDestination As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tUnitInStock As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tQty As System.Windows.Forms.TextBox
    Friend WithEvents cBaseUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cBatchNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tDrugName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tDrugCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tPriceCredit As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tPriceCash As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tCostPrice As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tFindDrug As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents chkIssue As System.Windows.Forms.CheckBox
    Friend WithEvents GrpIssue As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tFactor As System.Windows.Forms.TextBox
    Friend WithEvents cIssueUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tCQty As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tPriceNHIS As System.Windows.Forms.TextBox
End Class
