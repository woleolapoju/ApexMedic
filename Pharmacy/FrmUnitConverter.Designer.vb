<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnitConverter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUnitConverter))
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GrpDetails = New System.Windows.Forms.GroupBox
        Me.tConvertQty = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tCostPrice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdCompute = New System.Windows.Forms.Button
        Me.tPriceNHISI = New System.Windows.Forms.TextBox
        Me.tPriceCreditI = New System.Windows.Forms.TextBox
        Me.tPriceCashI = New System.Windows.Forms.TextBox
        Me.tPriceNHIS = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadIssue2Reorder = New System.Windows.Forms.RadioButton
        Me.RadReorder2Issue = New System.Windows.Forms.RadioButton
        Me.tQty = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tFactor = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cBatchNo = New System.Windows.Forms.ComboBox
        Me.cReorderUnit = New System.Windows.Forms.ComboBox
        Me.tPriceCredit = New System.Windows.Forms.TextBox
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.tInStock = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cIssueUnit = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.tPriceCash = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.tDrugName = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tDrugCode = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cStore = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel
        Me.PanBaseUnit = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.lvDrugs = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label36 = New System.Windows.Forms.Label
        Me.tFindDrugGeneric = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboBaseUnit = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.tFindDrug = New System.Windows.Forms.TextBox
        Me.LbCategory = New System.Windows.Forms.ListBox
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.tblProduct = New System.Windows.Forms.TableLayoutPanel
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpDetails.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.PanBaseUnit.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.tblProduct.SuspendLayout()
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
        Me.tblHeader.Size = New System.Drawing.Size(898, 54)
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
        Me.Label7.Location = New System.Drawing.Point(80, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(818, 30)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "BASE UNIT CONVERSION"
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
        Me.Label8.Size = New System.Drawing.Size(818, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Converts Stock Units of Measurement"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpDetails
        '
        Me.GrpDetails.Controls.Add(Me.tConvertQty)
        Me.GrpDetails.Controls.Add(Me.Label9)
        Me.GrpDetails.Controls.Add(Me.tCostPrice)
        Me.GrpDetails.Controls.Add(Me.Label3)
        Me.GrpDetails.Controls.Add(Me.cmdCompute)
        Me.GrpDetails.Controls.Add(Me.tPriceNHISI)
        Me.GrpDetails.Controls.Add(Me.tPriceCreditI)
        Me.GrpDetails.Controls.Add(Me.tPriceCashI)
        Me.GrpDetails.Controls.Add(Me.tPriceNHIS)
        Me.GrpDetails.Controls.Add(Me.Label11)
        Me.GrpDetails.Controls.Add(Me.GroupBox2)
        Me.GrpDetails.Controls.Add(Me.tQty)
        Me.GrpDetails.Controls.Add(Me.Label5)
        Me.GrpDetails.Controls.Add(Me.tFactor)
        Me.GrpDetails.Controls.Add(Me.Label12)
        Me.GrpDetails.Controls.Add(Me.cBatchNo)
        Me.GrpDetails.Controls.Add(Me.cReorderUnit)
        Me.GrpDetails.Controls.Add(Me.tPriceCredit)
        Me.GrpDetails.Controls.Add(Me.dtpDate)
        Me.GrpDetails.Controls.Add(Me.tInStock)
        Me.GrpDetails.Controls.Add(Me.Label2)
        Me.GrpDetails.Controls.Add(Me.cmdClose)
        Me.GrpDetails.Controls.Add(Me.cmdOk)
        Me.GrpDetails.Controls.Add(Me.cIssueUnit)
        Me.GrpDetails.Controls.Add(Me.Label19)
        Me.GrpDetails.Controls.Add(Me.tPriceCash)
        Me.GrpDetails.Controls.Add(Me.Label18)
        Me.GrpDetails.Controls.Add(Me.Label15)
        Me.GrpDetails.Controls.Add(Me.Label14)
        Me.GrpDetails.Controls.Add(Me.tDrugName)
        Me.GrpDetails.Controls.Add(Me.Label13)
        Me.GrpDetails.Controls.Add(Me.tDrugCode)
        Me.GrpDetails.Controls.Add(Me.Label10)
        Me.GrpDetails.Controls.Add(Me.Label6)
        Me.GrpDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDetails.ForeColor = System.Drawing.Color.DarkBlue
        Me.GrpDetails.Location = New System.Drawing.Point(0, 0)
        Me.GrpDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.GrpDetails.Name = "GrpDetails"
        Me.GrpDetails.Size = New System.Drawing.Size(448, 323)
        Me.GrpDetails.TabIndex = 6
        Me.GrpDetails.TabStop = False
        Me.GrpDetails.Text = "Product Details"
        '
        'tConvertQty
        '
        Me.tConvertQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tConvertQty.Location = New System.Drawing.Point(79, 291)
        Me.tConvertQty.Name = "tConvertQty"
        Me.tConvertQty.ReadOnly = True
        Me.tConvertQty.Size = New System.Drawing.Size(75, 20)
        Me.tConvertQty.TabIndex = 301
        Me.tConvertQty.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(5, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 302
        Me.Label9.Text = "Converted Qty:"
        '
        'tCostPrice
        '
        Me.tCostPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCostPrice.Location = New System.Drawing.Point(78, 201)
        Me.tCostPrice.Name = "tCostPrice"
        Me.tCostPrice.ReadOnly = True
        Me.tCostPrice.Size = New System.Drawing.Size(76, 20)
        Me.tCostPrice.TabIndex = 300
        Me.tCostPrice.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 299
        Me.Label3.Text = "Cost Price:"
        '
        'cmdCompute
        '
        Me.cmdCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompute.ForeColor = System.Drawing.Color.Black
        Me.cmdCompute.Location = New System.Drawing.Point(348, 134)
        Me.cmdCompute.Name = "cmdCompute"
        Me.cmdCompute.Size = New System.Drawing.Size(87, 28)
        Me.cmdCompute.TabIndex = 298
        Me.cmdCompute.Text = "Compute Price"
        Me.cmdCompute.UseVisualStyleBackColor = True
        '
        'tPriceNHISI
        '
        Me.tPriceNHISI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceNHISI.Location = New System.Drawing.Point(362, 111)
        Me.tPriceNHISI.Name = "tPriceNHISI"
        Me.tPriceNHISI.Size = New System.Drawing.Size(72, 20)
        Me.tPriceNHISI.TabIndex = 297
        '
        'tPriceCreditI
        '
        Me.tPriceCreditI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceCreditI.Location = New System.Drawing.Point(277, 111)
        Me.tPriceCreditI.Name = "tPriceCreditI"
        Me.tPriceCreditI.Size = New System.Drawing.Size(72, 20)
        Me.tPriceCreditI.TabIndex = 296
        '
        'tPriceCashI
        '
        Me.tPriceCashI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceCashI.Location = New System.Drawing.Point(191, 113)
        Me.tPriceCashI.Name = "tPriceCashI"
        Me.tPriceCashI.Size = New System.Drawing.Size(72, 20)
        Me.tPriceCashI.TabIndex = 295
        '
        'tPriceNHIS
        '
        Me.tPriceNHIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceNHIS.Location = New System.Drawing.Point(361, 88)
        Me.tPriceNHIS.Name = "tPriceNHIS"
        Me.tPriceNHIS.ReadOnly = True
        Me.tPriceNHIS.Size = New System.Drawing.Size(72, 20)
        Me.tPriceNHIS.TabIndex = 293
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(353, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 294
        Me.Label11.Text = "Sell Price (NHIS)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadIssue2Reorder)
        Me.GroupBox2.Controls.Add(Me.RadReorder2Issue)
        Me.GroupBox2.Location = New System.Drawing.Point(78, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(141, 60)
        Me.GroupBox2.TabIndex = 292
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Convert From"
        '
        'RadIssue2Reorder
        '
        Me.RadIssue2Reorder.AutoSize = True
        Me.RadIssue2Reorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadIssue2Reorder.ForeColor = System.Drawing.Color.DarkRed
        Me.RadIssue2Reorder.Location = New System.Drawing.Point(8, 34)
        Me.RadIssue2Reorder.Name = "RadIssue2Reorder"
        Me.RadIssue2Reorder.Size = New System.Drawing.Size(125, 17)
        Me.RadIssue2Reorder.TabIndex = 291
        Me.RadIssue2Reorder.Text = "Issue to Reorder Unit"
        Me.RadIssue2Reorder.UseVisualStyleBackColor = True
        '
        'RadReorder2Issue
        '
        Me.RadReorder2Issue.AutoSize = True
        Me.RadReorder2Issue.Checked = True
        Me.RadReorder2Issue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadReorder2Issue.ForeColor = System.Drawing.Color.DarkRed
        Me.RadReorder2Issue.Location = New System.Drawing.Point(8, 14)
        Me.RadReorder2Issue.Name = "RadReorder2Issue"
        Me.RadReorder2Issue.Size = New System.Drawing.Size(125, 17)
        Me.RadReorder2Issue.TabIndex = 290
        Me.RadReorder2Issue.TabStop = True
        Me.RadReorder2Issue.Text = "Reorder to Issue Unit"
        Me.RadReorder2Issue.UseVisualStyleBackColor = True
        '
        'tQty
        '
        Me.tQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tQty.Location = New System.Drawing.Point(78, 268)
        Me.tQty.Name = "tQty"
        Me.tQty.Size = New System.Drawing.Size(75, 20)
        Me.tQty.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 289
        Me.Label5.Text = "Issue Unit:"
        '
        'tFactor
        '
        Me.tFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFactor.Location = New System.Drawing.Point(78, 245)
        Me.tFactor.Name = "tFactor"
        Me.tFactor.ReadOnly = True
        Me.tFactor.Size = New System.Drawing.Size(76, 20)
        Me.tFactor.TabIndex = 284
        Me.tFactor.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(5, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Factor:"
        '
        'cBatchNo
        '
        Me.cBatchNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBatchNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBatchNo.FormattingEnabled = True
        Me.cBatchNo.Location = New System.Drawing.Point(78, 65)
        Me.cBatchNo.Name = "cBatchNo"
        Me.cBatchNo.Size = New System.Drawing.Size(101, 21)
        Me.cBatchNo.TabIndex = 66
        '
        'cReorderUnit
        '
        Me.cReorderUnit.BackColor = System.Drawing.SystemColors.Control
        Me.cReorderUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cReorderUnit.Enabled = False
        Me.cReorderUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cReorderUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cReorderUnit.FormattingEnabled = True
        Me.cReorderUnit.Location = New System.Drawing.Point(78, 90)
        Me.cReorderUnit.Name = "cReorderUnit"
        Me.cReorderUnit.Size = New System.Drawing.Size(102, 21)
        Me.cReorderUnit.TabIndex = 68
        Me.cReorderUnit.TabStop = False
        '
        'tPriceCredit
        '
        Me.tPriceCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceCredit.Location = New System.Drawing.Point(276, 88)
        Me.tPriceCredit.Name = "tPriceCredit"
        Me.tPriceCredit.ReadOnly = True
        Me.tPriceCredit.Size = New System.Drawing.Size(72, 20)
        Me.tPriceCredit.TabIndex = 273
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(77, 22)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(103, 20)
        Me.dtpDate.TabIndex = 267
        Me.dtpDate.Tag = "RegDate"
        '
        'tInStock
        '
        Me.tInStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tInStock.Location = New System.Drawing.Point(78, 222)
        Me.tInStock.Name = "tInStock"
        Me.tInStock.ReadOnly = True
        Me.tInStock.Size = New System.Drawing.Size(75, 20)
        Me.tInStock.TabIndex = 282
        Me.tInStock.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(2, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 268
        Me.Label2.Text = "Date:"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Black
        Me.cmdClose.Location = New System.Drawing.Point(351, 207)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(84, 68)
        Me.cmdClose.TabIndex = 262
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.Color.Black
        Me.cmdOk.Location = New System.Drawing.Point(259, 207)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(84, 68)
        Me.cmdOk.TabIndex = 261
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cIssueUnit
        '
        Me.cIssueUnit.BackColor = System.Drawing.SystemColors.Control
        Me.cIssueUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cIssueUnit.Enabled = False
        Me.cIssueUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cIssueUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cIssueUnit.FormattingEnabled = True
        Me.cIssueUnit.Location = New System.Drawing.Point(78, 114)
        Me.cIssueUnit.Name = "cIssueUnit"
        Me.cIssueUnit.Size = New System.Drawing.Size(102, 21)
        Me.cIssueUnit.TabIndex = 281
        Me.cIssueUnit.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(184, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 13)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Sell Price (Cash)"
        '
        'tPriceCash
        '
        Me.tPriceCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPriceCash.Location = New System.Drawing.Point(190, 90)
        Me.tPriceCash.Name = "tPriceCash"
        Me.tPriceCash.ReadOnly = True
        Me.tPriceCash.Size = New System.Drawing.Size(72, 20)
        Me.tPriceCash.TabIndex = 71
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(7, 272)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 13)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "Qty:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(3, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Reorder Unit:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(2, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Batch No:"
        '
        'tDrugName
        '
        Me.tDrugName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDrugName.Location = New System.Drawing.Point(181, 44)
        Me.tDrugName.Name = "tDrugName"
        Me.tDrugName.ReadOnly = True
        Me.tDrugName.Size = New System.Drawing.Size(253, 20)
        Me.tDrugName.TabIndex = 48
        Me.tDrugName.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(2, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Drug:"
        '
        'tDrugCode
        '
        Me.tDrugCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDrugCode.Location = New System.Drawing.Point(77, 44)
        Me.tDrugCode.Name = "tDrugCode"
        Me.tDrugCode.Size = New System.Drawing.Size(102, 20)
        Me.tDrugCode.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(4, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 283
        Me.Label10.Text = "Qty In Stock:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(268, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 274
        Me.Label6.Text = "Sell Price (Credit)"
        '
        'cStore
        '
        Me.cStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cStore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cStore.FormattingEnabled = True
        Me.cStore.Location = New System.Drawing.Point(75, 3)
        Me.cStore.Name = "cStore"
        Me.cStore.Size = New System.Drawing.Size(169, 21)
        Me.cStore.TabIndex = 270
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel7, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 54)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(898, 569)
        Me.TableLayoutPanel3.TabIndex = 56
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.PanBaseUnit, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lvDrugs, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(189, 4)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(252, 561)
        Me.TableLayoutPanel7.TabIndex = 4
        '
        'PanBaseUnit
        '
        Me.PanBaseUnit.BackColor = System.Drawing.Color.LightYellow
        Me.PanBaseUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanBaseUnit.Controls.Add(Me.Label1)
        Me.PanBaseUnit.Controls.Add(Me.cStore)
        Me.PanBaseUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanBaseUnit.Location = New System.Drawing.Point(1, 1)
        Me.PanBaseUnit.Margin = New System.Windows.Forms.Padding(1)
        Me.PanBaseUnit.Name = "PanBaseUnit"
        Me.PanBaseUnit.Size = New System.Drawing.Size(250, 29)
        Me.PanBaseUnit.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Store:"
        '
        'lvDrugs
        '
        Me.lvDrugs.BackColor = System.Drawing.Color.Azure
        Me.lvDrugs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvDrugs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvDrugs.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDrugs.FullRowSelect = True
        Me.lvDrugs.GridLines = True
        Me.lvDrugs.HideSelection = False
        Me.lvDrugs.Location = New System.Drawing.Point(0, 31)
        Me.lvDrugs.Margin = New System.Windows.Forms.Padding(0)
        Me.lvDrugs.MultiSelect = False
        Me.lvDrugs.Name = "lvDrugs"
        Me.lvDrugs.Size = New System.Drawing.Size(252, 530)
        Me.lvDrugs.TabIndex = 2
        Me.lvDrugs.UseCompatibleStateImageBehavior = False
        Me.lvDrugs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 49
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 179
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LbCategory, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(178, 561)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightYellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label36)
        Me.Panel2.Controls.Add(Me.tFindDrugGeneric)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cboBaseUnit)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.tFindDrug)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(178, 131)
        Me.Panel2.TabIndex = 58
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.Maroon
        Me.Label36.Location = New System.Drawing.Point(0, 61)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(171, 13)
        Me.Label36.TabIndex = 23
        Me.Label36.Text = "Type any part of the Generic name"
        '
        'tFindDrugGeneric
        '
        Me.tFindDrugGeneric.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFindDrugGeneric.ForeColor = System.Drawing.Color.Maroon
        Me.tFindDrugGeneric.Location = New System.Drawing.Point(5, 76)
        Me.tFindDrugGeneric.Name = "tFindDrugGeneric"
        Me.tFindDrugGeneric.Size = New System.Drawing.Size(167, 21)
        Me.tFindDrugGeneric.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Base Unit:"
        '
        'cboBaseUnit
        '
        Me.cboBaseUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaseUnit.FormattingEnabled = True
        Me.cboBaseUnit.Location = New System.Drawing.Point(63, 105)
        Me.cboBaseUnit.Name = "cboBaseUnit"
        Me.cboBaseUnit.Size = New System.Drawing.Size(109, 21)
        Me.cboBaseUnit.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.SteelBlue
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(0, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(176, 23)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Find Drug"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(1, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(155, 13)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "Type any part of the drug name"
        '
        'tFindDrug
        '
        Me.tFindDrug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFindDrug.Location = New System.Drawing.Point(3, 38)
        Me.tFindDrug.Name = "tFindDrug"
        Me.tFindDrug.Size = New System.Drawing.Size(169, 21)
        Me.tFindDrug.TabIndex = 11
        '
        'LbCategory
        '
        Me.LbCategory.BackColor = System.Drawing.Color.Azure
        Me.LbCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategory.FormattingEnabled = True
        Me.LbCategory.Location = New System.Drawing.Point(0, 131)
        Me.LbCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.LbCategory.Name = "LbCategory"
        Me.LbCategory.Size = New System.Drawing.Size(178, 420)
        Me.LbCategory.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.tblProduct, 0, 5)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(448, 4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 6
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(460, 561)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'tblProduct
        '
        Me.tblProduct.ColumnCount = 1
        Me.tblProduct.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblProduct.Controls.Add(Me.GrpDetails, 0, 1)
        Me.tblProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblProduct.Location = New System.Drawing.Point(0, 0)
        Me.tblProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.tblProduct.Name = "tblProduct"
        Me.tblProduct.RowCount = 3
        Me.tblProduct.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblProduct.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 335.0!))
        Me.tblProduct.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblProduct.Size = New System.Drawing.Size(460, 561)
        Me.tblProduct.TabIndex = 268
        '
        'FrmUnitConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 623)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUnitConverter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Base Unit Converter"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpDetails.ResumeLayout(False)
        Me.GrpDetails.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.PanBaseUnit.ResumeLayout(False)
        Me.PanBaseUnit.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.tblProduct.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GrpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tPriceCredit As System.Windows.Forms.TextBox
    Friend WithEvents cStore As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tPriceCash As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cBatchNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tDrugName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tDrugCode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanBaseUnit As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvDrugs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tFindDrug As System.Windows.Forms.TextBox
    Friend WithEvents LbCategory As System.Windows.Forms.ListBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblProduct As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cReorderUnit As System.Windows.Forms.ComboBox
    Friend WithEvents tQty As System.Windows.Forms.TextBox
    Friend WithEvents tFactor As System.Windows.Forms.TextBox
    Friend WithEvents tInStock As System.Windows.Forms.TextBox
    Friend WithEvents cIssueUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboBaseUnit As System.Windows.Forms.ComboBox
    Friend WithEvents RadReorder2Issue As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tPriceNHIS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadIssue2Reorder As System.Windows.Forms.RadioButton
    Friend WithEvents tPriceNHISI As System.Windows.Forms.TextBox
    Friend WithEvents tPriceCreditI As System.Windows.Forms.TextBox
    Friend WithEvents tPriceCashI As System.Windows.Forms.TextBox
    Friend WithEvents cmdCompute As System.Windows.Forms.Button
    Friend WithEvents tCostPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tConvertQty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents tFindDrugGeneric As System.Windows.Forms.TextBox
End Class
