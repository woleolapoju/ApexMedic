<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnModem = New System.Windows.Forms.Button
        Me.chkIntegrated = New System.Windows.Forms.CheckBox
        Me.chkIgnoreBatchNo = New System.Windows.Forms.CheckBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkStoreAssignment = New System.Windows.Forms.CheckBox
        Me.chkBillPharmacy = New System.Windows.Forms.CheckBox
        Me.chkBillLab = New System.Windows.Forms.CheckBox
        Me.chkBillXray = New System.Windows.Forms.CheckBox
        Me.chkBillScan = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tUP = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.ChkConsultation = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tCancelBill = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkNursingStation = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tExpiryPeriod = New System.Windows.Forms.TextBox
        Me.txtBillNotice = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDebitNotice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tFollowUp = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chkRequestForm = New System.Windows.Forms.CheckBox
        Me.chkFromFrontDesk = New System.Windows.Forms.CheckBox
        Me.chkDistribute = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdBackupPath = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.tBackupPath = New System.Windows.Forms.TextBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.tMarkUp = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cInterface = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.tblHeader.Size = New System.Drawing.Size(426, 44)
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
        Me.Label7.Size = New System.Drawing.Size(346, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "SETTINGS"
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
        Me.PictureBox1.Size = New System.Drawing.Size(80, 44)
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
        Me.Label8.Location = New System.Drawing.Point(80, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(346, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Setup System Parameters"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnModem
        '
        Me.btnModem.Location = New System.Drawing.Point(9, 53)
        Me.btnModem.Name = "btnModem"
        Me.btnModem.Size = New System.Drawing.Size(121, 23)
        Me.btnModem.TabIndex = 52
        Me.btnModem.Text = "Modem/SMS Setting"
        Me.btnModem.UseVisualStyleBackColor = True
        '
        'chkIntegrated
        '
        Me.chkIntegrated.AutoSize = True
        Me.chkIntegrated.Location = New System.Drawing.Point(10, 114)
        Me.chkIntegrated.Name = "chkIntegrated"
        Me.chkIntegrated.Size = New System.Drawing.Size(266, 17)
        Me.chkIntegrated.TabIndex = 65
        Me.chkIntegrated.Text = "Integrated with NAAPS Office automation Software"
        Me.chkIntegrated.UseVisualStyleBackColor = True
        '
        'chkIgnoreBatchNo
        '
        Me.chkIgnoreBatchNo.AutoSize = True
        Me.chkIgnoreBatchNo.Location = New System.Drawing.Point(10, 81)
        Me.chkIgnoreBatchNo.Name = "chkIgnoreBatchNo"
        Me.chkIgnoreBatchNo.Size = New System.Drawing.Size(194, 17)
        Me.chkIgnoreBatchNo.TabIndex = 64
        Me.chkIgnoreBatchNo.Text = "Ignore BatchNo for Pharmacy Items"
        Me.chkIgnoreBatchNo.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(308, 507)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(114, 34)
        Me.cmdClose.TabIndex = 66
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.Lavender
        Me.cmdOk.Location = New System.Drawing.Point(193, 507)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(113, 34)
        Me.cmdOk.TabIndex = 67
        Me.cmdOk.Text = "&Save"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(5, 494)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 10)
        Me.GroupBox1.TabIndex = 226
        Me.GroupBox1.TabStop = False
        '
        'chkStoreAssignment
        '
        Me.chkStoreAssignment.AutoSize = True
        Me.chkStoreAssignment.Location = New System.Drawing.Point(10, 97)
        Me.chkStoreAssignment.Name = "chkStoreAssignment"
        Me.chkStoreAssignment.Size = New System.Drawing.Size(191, 17)
        Me.chkStoreAssignment.TabIndex = 227
        Me.chkStoreAssignment.Text = "Ignore Pharmacy Store Assignment"
        Me.chkStoreAssignment.UseVisualStyleBackColor = True
        '
        'chkBillPharmacy
        '
        Me.chkBillPharmacy.AutoSize = True
        Me.chkBillPharmacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBillPharmacy.ForeColor = System.Drawing.Color.Black
        Me.chkBillPharmacy.Location = New System.Drawing.Point(6, 18)
        Me.chkBillPharmacy.Name = "chkBillPharmacy"
        Me.chkBillPharmacy.Size = New System.Drawing.Size(73, 17)
        Me.chkBillPharmacy.TabIndex = 228
        Me.chkBillPharmacy.Text = "Pharmacy"
        Me.chkBillPharmacy.UseVisualStyleBackColor = True
        '
        'chkBillLab
        '
        Me.chkBillLab.AutoSize = True
        Me.chkBillLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBillLab.ForeColor = System.Drawing.Color.Black
        Me.chkBillLab.Location = New System.Drawing.Point(248, 17)
        Me.chkBillLab.Name = "chkBillLab"
        Me.chkBillLab.Size = New System.Drawing.Size(76, 17)
        Me.chkBillLab.TabIndex = 229
        Me.chkBillLab.Text = "Laboratory"
        Me.chkBillLab.UseVisualStyleBackColor = True
        '
        'chkBillXray
        '
        Me.chkBillXray.AutoSize = True
        Me.chkBillXray.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBillXray.ForeColor = System.Drawing.Color.Black
        Me.chkBillXray.Location = New System.Drawing.Point(83, 19)
        Me.chkBillXray.Name = "chkBillXray"
        Me.chkBillXray.Size = New System.Drawing.Size(47, 17)
        Me.chkBillXray.TabIndex = 230
        Me.chkBillXray.Text = "Xray"
        Me.chkBillXray.UseVisualStyleBackColor = True
        '
        'chkBillScan
        '
        Me.chkBillScan.AutoSize = True
        Me.chkBillScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBillScan.ForeColor = System.Drawing.Color.Black
        Me.chkBillScan.Location = New System.Drawing.Point(332, 18)
        Me.chkBillScan.Name = "chkBillScan"
        Me.chkBillScan.Size = New System.Drawing.Size(51, 17)
        Me.chkBillScan.TabIndex = 231
        Me.chkBillScan.Text = "Scan"
        Me.chkBillScan.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tUP)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ChkConsultation)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tCancelBill)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.chkNursingStation)
        Me.GroupBox2.Controls.Add(Me.chkBillPharmacy)
        Me.GroupBox2.Controls.Add(Me.chkBillScan)
        Me.GroupBox2.Controls.Add(Me.chkBillLab)
        Me.GroupBox2.Controls.Add(Me.chkBillXray)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox2.Location = New System.Drawing.Point(4, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 102)
        Me.GroupBox2.TabIndex = 232
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generate Bill from"
        '
        'tUP
        '
        Me.tUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUP.Location = New System.Drawing.Point(189, 75)
        Me.tUP.Name = "tUP"
        Me.tUP.Size = New System.Drawing.Size(114, 20)
        Me.tUP.TabIndex = 246
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 13)
        Me.Label11.TabIndex = 245
        Me.Label11.Text = "Code for unregistered/Out patients:"
        '
        'ChkConsultation
        '
        Me.ChkConsultation.AutoSize = True
        Me.ChkConsultation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkConsultation.ForeColor = System.Drawing.Color.Black
        Me.ChkConsultation.Location = New System.Drawing.Point(6, 37)
        Me.ChkConsultation.Name = "ChkConsultation"
        Me.ChkConsultation.Size = New System.Drawing.Size(84, 17)
        Me.ChkConsultation.TabIndex = 244
        Me.ChkConsultation.Text = "Consultation"
        Me.ChkConsultation.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(313, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 243
        Me.Label10.Text = "-1 for unlimited"
        '
        'tCancelBill
        '
        Me.tCancelBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCancelBill.Location = New System.Drawing.Point(271, 53)
        Me.tCancelBill.Name = "tCancelBill"
        Me.tCancelBill.Size = New System.Drawing.Size(32, 20)
        Me.tCancelBill.TabIndex = 242
        Me.tCancelBill.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(261, 13)
        Me.Label9.TabIndex = 241
        Me.Label9.Text = "Grace period to allow to modify Bill/Payment/Discount"
        '
        'chkNursingStation
        '
        Me.chkNursingStation.AutoSize = True
        Me.chkNursingStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNursingStation.ForeColor = System.Drawing.Color.Black
        Me.chkNursingStation.Location = New System.Drawing.Point(142, 18)
        Me.chkNursingStation.Name = "chkNursingStation"
        Me.chkNursingStation.Size = New System.Drawing.Size(98, 17)
        Me.chkNursingStation.TabIndex = 232
        Me.chkNursingStation.Text = "Nursing Station"
        Me.chkNursingStation.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 13)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "Days to check for expired Pharmacy products"
        '
        'tExpiryPeriod
        '
        Me.tExpiryPeriod.Location = New System.Drawing.Point(231, 130)
        Me.tExpiryPeriod.Name = "tExpiryPeriod"
        Me.tExpiryPeriod.Size = New System.Drawing.Size(39, 20)
        Me.tExpiryPeriod.TabIndex = 234
        Me.tExpiryPeriod.Text = "0"
        '
        'txtBillNotice
        '
        Me.txtBillNotice.BackColor = System.Drawing.Color.White
        Me.txtBillNotice.Location = New System.Drawing.Point(87, 15)
        Me.txtBillNotice.Multiline = True
        Me.txtBillNotice.Name = "txtBillNotice"
        Me.txtBillNotice.ReadOnly = True
        Me.txtBillNotice.Size = New System.Drawing.Size(325, 20)
        Me.txtBillNotice.TabIndex = 236
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 235
        Me.Label2.Text = "Bill Notice Text:"
        '
        'txtDebitNotice
        '
        Me.txtDebitNotice.BackColor = System.Drawing.Color.White
        Me.txtDebitNotice.Location = New System.Drawing.Point(87, 37)
        Me.txtDebitNotice.Multiline = True
        Me.txtDebitNotice.Name = "txtDebitNotice"
        Me.txtDebitNotice.ReadOnly = True
        Me.txtDebitNotice.Size = New System.Drawing.Size(325, 20)
        Me.txtDebitNotice.TabIndex = 238
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 237
        Me.Label3.Text = "Debit Note Text:"
        '
        'tFollowUp
        '
        Me.tFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFollowUp.Location = New System.Drawing.Point(200, 69)
        Me.tFollowUp.Name = "tFollowUp"
        Me.tFollowUp.Size = New System.Drawing.Size(32, 20)
        Me.tFollowUp.TabIndex = 240
        Me.tFollowUp.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 13)
        Me.Label4.TabIndex = 239
        Me.Label4.Text = "Consultation Follow-up expiration (days):"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.cInterface)
        Me.GroupBox4.Controls.Add(Me.chkRequestForm)
        Me.GroupBox4.Controls.Add(Me.chkFromFrontDesk)
        Me.GroupBox4.Controls.Add(Me.chkDistribute)
        Me.GroupBox4.Controls.Add(Me.tFollowUp)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox4.Location = New System.Drawing.Point(5, 276)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(417, 114)
        Me.GroupBox4.TabIndex = 241
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Consultation"
        '
        'chkRequestForm
        '
        Me.chkRequestForm.AutoSize = True
        Me.chkRequestForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRequestForm.ForeColor = System.Drawing.Color.Black
        Me.chkRequestForm.Location = New System.Drawing.Point(6, 91)
        Me.chkRequestForm.Name = "chkRequestForm"
        Me.chkRequestForm.Size = New System.Drawing.Size(254, 17)
        Me.chkRequestForm.TabIndex = 245
        Me.chkRequestForm.Text = "Select Test (Lab,Xray,Scan)  from Request Form"
        Me.chkRequestForm.UseVisualStyleBackColor = True
        '
        'chkFromFrontDesk
        '
        Me.chkFromFrontDesk.AutoSize = True
        Me.chkFromFrontDesk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFromFrontDesk.ForeColor = System.Drawing.Color.Black
        Me.chkFromFrontDesk.Location = New System.Drawing.Point(6, 34)
        Me.chkFromFrontDesk.Name = "chkFromFrontDesk"
        Me.chkFromFrontDesk.Size = New System.Drawing.Size(279, 17)
        Me.chkFromFrontDesk.TabIndex = 242
        Me.chkFromFrontDesk.Text = "Distribute Patient to Consulting Room from Front Desk"
        Me.chkFromFrontDesk.UseVisualStyleBackColor = True
        '
        'chkDistribute
        '
        Me.chkDistribute.AutoSize = True
        Me.chkDistribute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDistribute.ForeColor = System.Drawing.Color.Black
        Me.chkDistribute.Location = New System.Drawing.Point(6, 16)
        Me.chkDistribute.Name = "chkDistribute"
        Me.chkDistribute.Size = New System.Drawing.Size(353, 17)
        Me.chkDistribute.TabIndex = 241
        Me.chkDistribute.Text = "Distribute Patient to Consulting Room rather than to logged-in Doctors"
        Me.chkDistribute.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtDebitNotice)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txtBillNotice)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox5.Location = New System.Drawing.Point(6, 392)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(416, 64)
        Me.GroupBox5.TabIndex = 242
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Document Body"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdBackupPath)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.tBackupPath)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox3.Location = New System.Drawing.Point(7, 456)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(415, 41)
        Me.GroupBox3.TabIndex = 563
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Backup"
        '
        'cmdBackupPath
        '
        Me.cmdBackupPath.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBackupPath.Location = New System.Drawing.Point(385, 12)
        Me.cmdBackupPath.Name = "cmdBackupPath"
        Me.cmdBackupPath.Size = New System.Drawing.Size(27, 21)
        Me.cmdBackupPath.TabIndex = 247
        Me.cmdBackupPath.Text = "..."
        Me.cmdBackupPath.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 246
        Me.Label6.Text = "Backup Path:"
        '
        'tBackupPath
        '
        Me.tBackupPath.Location = New System.Drawing.Point(86, 12)
        Me.tBackupPath.Name = "tBackupPath"
        Me.tBackupPath.Size = New System.Drawing.Size(298, 21)
        Me.tBackupPath.TabIndex = 245
        Me.tBackupPath.Tag = ""
        '
        'tMarkUp
        '
        Me.tMarkUp.Location = New System.Drawing.Point(194, 152)
        Me.tMarkUp.Name = "tMarkUp"
        Me.tMarkUp.Size = New System.Drawing.Size(76, 20)
        Me.tMarkUp.TabIndex = 565
        Me.tMarkUp.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 13)
        Me.Label5.TabIndex = 564
        Me.Label5.Text = "Markup Rate for Pharmacy products:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(273, 156)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 12)
        Me.Label17.TabIndex = 566
        Me.Label17.Text = "Evaluated Percent"
        '
        'cInterface
        '
        Me.cInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cInterface.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cInterface.FormattingEnabled = True
        Me.cInterface.Items.AddRange(New Object() {"Comprehensive", "Summary", "Mini"})
        Me.cInterface.Location = New System.Drawing.Point(234, 47)
        Me.cInterface.Name = "cInterface"
        Me.cInterface.Size = New System.Drawing.Size(112, 21)
        Me.cInterface.TabIndex = 246
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(5, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(217, 13)
        Me.Label12.TabIndex = 247
        Me.Label12.Text = "Consultation Data collection Interface Mode:"
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 544)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.tMarkUp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.tExpiryPeriod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkStoreAssignment)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.chkIntegrated)
        Me.Controls.Add(Me.chkIgnoreBatchNo)
        Me.Controls.Add(Me.btnModem)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnModem As System.Windows.Forms.Button
    Friend WithEvents chkIntegrated As System.Windows.Forms.CheckBox
    Friend WithEvents chkIgnoreBatchNo As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkStoreAssignment As System.Windows.Forms.CheckBox
    Friend WithEvents chkBillPharmacy As System.Windows.Forms.CheckBox
    Friend WithEvents chkBillLab As System.Windows.Forms.CheckBox
    Friend WithEvents chkBillXray As System.Windows.Forms.CheckBox
    Friend WithEvents chkBillScan As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tExpiryPeriod As System.Windows.Forms.TextBox
    Friend WithEvents txtBillNotice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDebitNotice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tFollowUp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDistribute As System.Windows.Forms.CheckBox
    Friend WithEvents chkFromFrontDesk As System.Windows.Forms.CheckBox
    Friend WithEvents chkNursingStation As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdBackupPath As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tBackupPath As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkRequestForm As System.Windows.Forms.CheckBox
    Friend WithEvents tCancelBill As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ChkConsultation As System.Windows.Forms.CheckBox
    Friend WithEvents tUP As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tMarkUp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cInterface As System.Windows.Forms.ComboBox
End Class
