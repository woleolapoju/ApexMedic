<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLabStool
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLabStool))
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpResultDate = New System.Windows.Forms.DateTimePicker
        Me.tPerformedBy = New System.Windows.Forms.TextBox
        Me.cmdPerform = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblAction = New System.Windows.Forms.Label
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.tTestNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tSpecimen = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.tAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cRotavirus = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.cMucus = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.cOccultBlood = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cBlood = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cAppearance = New System.Windows.Forms.ComboBox
        Me.tColor = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.tMicroList = New System.Windows.Forms.TextBox
        Me.tFatGlobules = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.cMicroList = New System.Windows.Forms.ComboBox
        Me.tRBC = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.tWBC = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.cOrganism3 = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cOrganism2 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cOrganism1 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DbGrid = New System.Windows.Forms.DataGridView
        Me.Drug = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Organism1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Organism2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Organism3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanHeading.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(402, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 267
        Me.Label14.Text = "Result Date:"
        '
        'dtpResultDate
        '
        Me.dtpResultDate.CustomFormat = "dd-MMM-yy h.mm  tt"
        Me.dtpResultDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpResultDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpResultDate.Location = New System.Drawing.Point(476, 50)
        Me.dtpResultDate.Name = "dtpResultDate"
        Me.dtpResultDate.Size = New System.Drawing.Size(148, 20)
        Me.dtpResultDate.TabIndex = 266
        Me.dtpResultDate.Tag = "RegDate"
        '
        'tPerformedBy
        '
        Me.tPerformedBy.Location = New System.Drawing.Point(69, 50)
        Me.tPerformedBy.Name = "tPerformedBy"
        Me.tPerformedBy.Size = New System.Drawing.Size(287, 20)
        Me.tPerformedBy.TabIndex = 265
        Me.tPerformedBy.TabStop = False
        '
        'cmdPerform
        '
        Me.cmdPerform.Location = New System.Drawing.Point(358, 50)
        Me.cmdPerform.Name = "cmdPerform"
        Me.cmdPerform.Size = New System.Drawing.Size(26, 21)
        Me.cmdPerform.TabIndex = 264
        Me.cmdPerform.Text = "..."
        Me.cmdPerform.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tblHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanHeading, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(866, 598)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.Controls.Add(Me.Label9, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.lblAction, 1, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.Size = New System.Drawing.Size(866, 52)
        Me.tblHeader.TabIndex = 262
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
        Me.Label9.Location = New System.Drawing.Point(80, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(786, 28)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "LABORATORY STOOL TEST"
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
        Me.PictureBox1.Size = New System.Drawing.Size(80, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblAction
        '
        Me.lblAction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAction.AutoSize = True
        Me.lblAction.BackColor = System.Drawing.Color.SteelBlue
        Me.lblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.ForeColor = System.Drawing.Color.White
        Me.lblAction.Location = New System.Drawing.Point(80, 28)
        Me.lblAction.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(786, 24)
        Me.lblAction.TabIndex = 1
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanHeading
        '
        Me.PanHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanHeading.Controls.Add(Me.Label14)
        Me.PanHeading.Controls.Add(Me.dtpResultDate)
        Me.PanHeading.Controls.Add(Me.tPerformedBy)
        Me.PanHeading.Controls.Add(Me.cmdPerform)
        Me.PanHeading.Controls.Add(Me.Label18)
        Me.PanHeading.Controls.Add(Me.Label12)
        Me.PanHeading.Controls.Add(Me.dtpDate)
        Me.PanHeading.Controls.Add(Me.tTestNo)
        Me.PanHeading.Controls.Add(Me.Label11)
        Me.PanHeading.Controls.Add(Me.tSpecimen)
        Me.PanHeading.Controls.Add(Me.Label1)
        Me.PanHeading.Controls.Add(Me.cmdOk)
        Me.PanHeading.Controls.Add(Me.cmdClose)
        Me.PanHeading.Controls.Add(Me.tAccount)
        Me.PanHeading.Controls.Add(Me.Label16)
        Me.PanHeading.Controls.Add(Me.tPatientName)
        Me.PanHeading.Controls.Add(Me.cmdPatient)
        Me.PanHeading.Controls.Add(Me.tPatientNo)
        Me.PanHeading.Controls.Add(Me.Label4)
        Me.PanHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanHeading.Location = New System.Drawing.Point(3, 55)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(860, 77)
        Me.PanHeading.TabIndex = 263
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(0, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 263
        Me.Label18.Text = "Performed By:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(485, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 262
        Me.Label12.Text = "Date:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(522, 5)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(103, 20)
        Me.dtpDate.TabIndex = 261
        Me.dtpDate.Tag = "RegDate"
        '
        'tTestNo
        '
        Me.tTestNo.Location = New System.Drawing.Point(423, 5)
        Me.tTestNo.Name = "tTestNo"
        Me.tTestNo.ReadOnly = True
        Me.tTestNo.Size = New System.Drawing.Size(61, 20)
        Me.tTestNo.TabIndex = 260
        Me.tTestNo.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(360, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 259
        Me.Label11.Text = "Test No:"
        '
        'tSpecimen
        '
        Me.tSpecimen.Location = New System.Drawing.Point(421, 27)
        Me.tSpecimen.Name = "tSpecimen"
        Me.tSpecimen.Size = New System.Drawing.Size(203, 20)
        Me.tSpecimen.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(357, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 258
        Me.Label1.Text = "Specimen:"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(636, 3)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(72, 69)
        Me.cmdOk.TabIndex = 256
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(711, 3)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(72, 69)
        Me.cmdClose.TabIndex = 255
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(68, 26)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(287, 20)
        Me.tAccount.TabIndex = 51
        Me.tAccount.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(0, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Account:"
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(174, 3)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(180, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'cmdPatient
        '
        Me.cmdPatient.Enabled = False
        Me.cmdPatient.Location = New System.Drawing.Point(148, 2)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 7
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(68, 3)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.ReadOnly = True
        Me.tPatientNo.Size = New System.Drawing.Size(80, 20)
        Me.tPatientNo.TabIndex = 257
        Me.tPatientNo.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Patient No:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 138)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.76968!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.23032!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(860, 457)
        Me.TableLayoutPanel2.TabIndex = 264
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cRotavirus)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.cMucus)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.cOccultBlood)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.cBlood)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.cAppearance)
        Me.Panel1.Controls.Add(Me.tColor)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 235)
        Me.Panel1.TabIndex = 0
        '
        'cRotavirus
        '
        Me.cRotavirus.Location = New System.Drawing.Point(103, 147)
        Me.cRotavirus.Name = "cRotavirus"
        Me.cRotavirus.Size = New System.Drawing.Size(137, 20)
        Me.cRotavirus.TabIndex = 269
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 153)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 13)
        Me.Label21.TabIndex = 270
        Me.Label21.Text = "Rotavirus:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(18, 127)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 268
        Me.Label20.Text = "Mucus:"
        '
        'cMucus
        '
        Me.cMucus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cMucus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cMucus.FormattingEnabled = True
        Me.cMucus.Items.AddRange(New Object() {"", "+", "++", "+++", "NILL"})
        Me.cMucus.Location = New System.Drawing.Point(104, 122)
        Me.cMucus.Name = "cMucus"
        Me.cMucus.Size = New System.Drawing.Size(137, 21)
        Me.cMucus.TabIndex = 267
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 102)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 13)
        Me.Label19.TabIndex = 266
        Me.Label19.Text = "Occult Blood:"
        '
        'cOccultBlood
        '
        Me.cOccultBlood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cOccultBlood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cOccultBlood.FormattingEnabled = True
        Me.cOccultBlood.Items.AddRange(New Object() {"", "Negative", "+", "++", "+++", "Not Seen", "NA"})
        Me.cOccultBlood.Location = New System.Drawing.Point(104, 97)
        Me.cOccultBlood.Name = "cOccultBlood"
        Me.cOccultBlood.Size = New System.Drawing.Size(137, 21)
        Me.cOccultBlood.TabIndex = 265
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 264
        Me.Label17.Text = "Blood:"
        '
        'cBlood
        '
        Me.cBlood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBlood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cBlood.FormattingEnabled = True
        Me.cBlood.Items.AddRange(New Object() {"", "+", "++", "+++", "Not Seen", "Seen", "NA"})
        Me.cBlood.Location = New System.Drawing.Point(104, 73)
        Me.cBlood.Name = "cBlood"
        Me.cBlood.Size = New System.Drawing.Size(137, 21)
        Me.cBlood.TabIndex = 263
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 262
        Me.Label15.Text = "Appearance:"
        '
        'cAppearance
        '
        Me.cAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cAppearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cAppearance.FormattingEnabled = True
        Me.cAppearance.Items.AddRange(New Object() {"", "Formed", "Soft", "Loose", "Watery"})
        Me.cAppearance.Location = New System.Drawing.Point(104, 48)
        Me.cAppearance.Name = "cAppearance"
        Me.cAppearance.Size = New System.Drawing.Size(137, 21)
        Me.cAppearance.TabIndex = 261
        '
        'tColor
        '
        Me.tColor.Location = New System.Drawing.Point(104, 25)
        Me.tColor.Name = "tColor"
        Me.tColor.Size = New System.Drawing.Size(137, 20)
        Me.tColor.TabIndex = 259
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 260
        Me.Label13.Text = "Color:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightYellow
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MACROSCOPY"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tMicroList)
        Me.Panel2.Controls.Add(Me.tFatGlobules)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.cMicroList)
        Me.Panel2.Controls.Add(Me.tRBC)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.tWBC)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 244)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(302, 210)
        Me.Panel2.TabIndex = 1
        '
        'tMicroList
        '
        Me.tMicroList.Location = New System.Drawing.Point(104, 69)
        Me.tMicroList.Multiline = True
        Me.tMicroList.Name = "tMicroList"
        Me.tMicroList.Size = New System.Drawing.Size(173, 82)
        Me.tMicroList.TabIndex = 273
        '
        'tFatGlobules
        '
        Me.tFatGlobules.Location = New System.Drawing.Point(104, 152)
        Me.tFatGlobules.Name = "tFatGlobules"
        Me.tFatGlobules.Size = New System.Drawing.Size(137, 20)
        Me.tFatGlobules.TabIndex = 271
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(19, 157)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 13)
        Me.Label25.TabIndex = 272
        Me.Label25.Text = "Fat Globules:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(18, 75)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 13)
        Me.Label24.TabIndex = 270
        Me.Label24.Text = "Microscopy List:"
        '
        'cMicroList
        '
        Me.cMicroList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cMicroList.DropDownWidth = 210
        Me.cMicroList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cMicroList.FormattingEnabled = True
        Me.cMicroList.Location = New System.Drawing.Point(104, 69)
        Me.cMicroList.Name = "cMicroList"
        Me.cMicroList.Size = New System.Drawing.Size(192, 21)
        Me.cMicroList.TabIndex = 269
        '
        'tRBC
        '
        Me.tRBC.Location = New System.Drawing.Point(103, 47)
        Me.tRBC.Name = "tRBC"
        Me.tRBC.Size = New System.Drawing.Size(137, 20)
        Me.tRBC.TabIndex = 263
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(18, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 13)
        Me.Label23.TabIndex = 264
        Me.Label23.Text = "RBC:"
        '
        'tWBC
        '
        Me.tWBC.Location = New System.Drawing.Point(103, 25)
        Me.tWBC.Name = "tWBC"
        Me.tWBC.Size = New System.Drawing.Size(137, 20)
        Me.tWBC.TabIndex = 261
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(18, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 13)
        Me.Label22.TabIndex = 262
        Me.Label22.Text = "WBC:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightYellow
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "MICROSCOPY"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DbGrid, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(311, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel2.SetRowSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(546, 451)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cOrganism3)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cOrganism2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cOrganism1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(540, 104)
        Me.Panel3.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 269
        Me.Label8.Text = "Organism III:"
        '
        'cOrganism3
        '
        Me.cOrganism3.DropDownWidth = 180
        Me.cOrganism3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cOrganism3.FormattingEnabled = True
        Me.cOrganism3.Location = New System.Drawing.Point(77, 78)
        Me.cOrganism3.Name = "cOrganism3"
        Me.cOrganism3.Size = New System.Drawing.Size(457, 21)
        Me.cOrganism3.TabIndex = 268
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 267
        Me.Label7.Text = "Organism II:"
        '
        'cOrganism2
        '
        Me.cOrganism2.DropDownWidth = 180
        Me.cOrganism2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cOrganism2.FormattingEnabled = True
        Me.cOrganism2.Location = New System.Drawing.Point(78, 53)
        Me.cOrganism2.Name = "cOrganism2"
        Me.cOrganism2.Size = New System.Drawing.Size(456, 21)
        Me.cOrganism2.TabIndex = 266
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 265
        Me.Label6.Text = "Organism I:"
        '
        'cOrganism1
        '
        Me.cOrganism1.DropDownWidth = 180
        Me.cOrganism1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cOrganism1.FormattingEnabled = True
        Me.cOrganism1.Location = New System.Drawing.Point(78, 28)
        Me.cOrganism1.Name = "cOrganism1"
        Me.cOrganism1.Size = New System.Drawing.Size(456, 21)
        Me.cOrganism1.TabIndex = 264
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightYellow
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(538, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CULTURE / SENSITIVITY"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DbGrid
        '
        Me.DbGrid.BackgroundColor = System.Drawing.Color.Lavender
        Me.DbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Drug, Me.Organism1, Me.Organism2, Me.Organism3})
        Me.DbGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGrid.Location = New System.Drawing.Point(3, 113)
        Me.DbGrid.Name = "DbGrid"
        Me.DbGrid.Size = New System.Drawing.Size(540, 335)
        Me.DbGrid.TabIndex = 2
        '
        'Drug
        '
        Me.Drug.HeaderText = ""
        Me.Drug.Name = "Drug"
        Me.Drug.Width = 180
        '
        'Organism1
        '
        DataGridViewCellStyle1.NullValue = "N/A"
        Me.Organism1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Organism1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Organism1.HeaderText = "Organism I"
        Me.Organism1.Items.AddRange(New Object() {"N/A", "RESISTANT", "SENSITIVE"})
        Me.Organism1.Name = "Organism1"
        Me.Organism1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Organism2
        '
        DataGridViewCellStyle2.NullValue = "N/A"
        Me.Organism2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Organism2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Organism2.HeaderText = "Organism II"
        Me.Organism2.Items.AddRange(New Object() {"N/A", "RESISTANT", "SENSITIVE"})
        Me.Organism2.Name = "Organism2"
        Me.Organism2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Organism3
        '
        DataGridViewCellStyle3.NullValue = "N/A"
        Me.Organism3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Organism3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Organism3.HeaderText = "Organism III"
        Me.Organism3.Items.AddRange(New Object() {"N/A", "RESISTANT", "SENSITIVE"})
        Me.Organism3.Name = "Organism3"
        Me.Organism3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'FrmLabStool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 598)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLabStool"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laboratory Stool Test"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpResultDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tPerformedBy As System.Windows.Forms.TextBox
    Friend WithEvents cmdPerform As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tTestNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tSpecimen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents tAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cOrganism3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cOrganism2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cOrganism1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DbGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Drug As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Organism1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Organism2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Organism3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents tColor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cAppearance As System.Windows.Forms.ComboBox
    Friend WithEvents cRotavirus As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cMucus As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cOccultBlood As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cBlood As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tRBC As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tWBC As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tFatGlobules As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cMicroList As System.Windows.Forms.ComboBox
    Friend WithEvents tMicroList As System.Windows.Forms.TextBox
End Class
