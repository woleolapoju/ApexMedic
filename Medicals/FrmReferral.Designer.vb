<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReferral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReferral))
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
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.tReferredBy = New System.Windows.Forms.TextBox
        Me.cmdReferredBy = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.tAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.tRefNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdReferredTo = New System.Windows.Forms.Button
        Me.tReceivingDr = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tReferredTo = New System.Windows.Forms.TextBox
        Me.cmdReferralUnit = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tTreatment = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.tInfor = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tClinicalWarning = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tMedHistory = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tReason = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tDiagnosis = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tHPC = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.mnuPrint = New System.Windows.Forms.MenuStrip
        Me.mnuPrintResult = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLastResult = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRefNo = New System.Windows.Forms.ToolStripMenuItem
        Me.lnkFinancialState = New System.Windows.Forms.LinkLabel
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.PanHeading.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanMainCommand.SuspendLayout()
        Me.mnuPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
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
        Me.tblHeader.Size = New System.Drawing.Size(437, 59)
        Me.tblHeader.TabIndex = 235
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
        Me.Label7.Location = New System.Drawing.Point(101, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "REFERRALS"
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
        Me.PictureBox1.Size = New System.Drawing.Size(101, 59)
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
        Me.Label8.Location = New System.Drawing.Point(101, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Maintains Referrals"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAction.Location = New System.Drawing.Point(246, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(191, 59)
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
        Me.lblAction.Size = New System.Drawing.Size(179, 19)
        Me.lblAction.TabIndex = 11
        Me.lblAction.Text = "?"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanHeading
        '
        Me.PanHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanHeading.Controls.Add(Me.tReferredBy)
        Me.PanHeading.Controls.Add(Me.cmdReferredBy)
        Me.PanHeading.Controls.Add(Me.Label4)
        Me.PanHeading.Controls.Add(Me.tAccount)
        Me.PanHeading.Controls.Add(Me.Label16)
        Me.PanHeading.Controls.Add(Me.tPatientName)
        Me.PanHeading.Controls.Add(Me.Label3)
        Me.PanHeading.Controls.Add(Me.Label2)
        Me.PanHeading.Controls.Add(Me.dtpDate)
        Me.PanHeading.Controls.Add(Me.tRefNo)
        Me.PanHeading.Controls.Add(Me.Label1)
        Me.PanHeading.Controls.Add(Me.cmdPatient)
        Me.PanHeading.Controls.Add(Me.tPatientNo)
        Me.PanHeading.Location = New System.Drawing.Point(2, 62)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(433, 96)
        Me.PanHeading.TabIndex = 236
        '
        'tReferredBy
        '
        Me.tReferredBy.Location = New System.Drawing.Point(93, 69)
        Me.tReferredBy.Name = "tReferredBy"
        Me.tReferredBy.ReadOnly = True
        Me.tReferredBy.Size = New System.Drawing.Size(307, 20)
        Me.tReferredBy.TabIndex = 58
        Me.tReferredBy.TabStop = False
        '
        'cmdReferredBy
        '
        Me.cmdReferredBy.Location = New System.Drawing.Point(401, 69)
        Me.cmdReferredBy.Name = "cmdReferredBy"
        Me.cmdReferredBy.Size = New System.Drawing.Size(26, 21)
        Me.cmdReferredBy.TabIndex = 57
        Me.cmdReferredBy.Text = "..."
        Me.cmdReferredBy.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Referred By:"
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(93, 47)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(331, 20)
        Me.tAccount.TabIndex = 51
        Me.tAccount.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Account:"
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(208, 26)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(216, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Patient No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Date:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yy h.mm  tt"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(280, 2)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(146, 20)
        Me.dtpDate.TabIndex = 2
        Me.dtpDate.Tag = "RegDate"
        '
        'tRefNo
        '
        Me.tRefNo.Location = New System.Drawing.Point(94, 3)
        Me.tRefNo.Name = "tRefNo"
        Me.tRefNo.ReadOnly = True
        Me.tRefNo.Size = New System.Drawing.Size(87, 20)
        Me.tRefNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ref. No:"
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(181, 25)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 7
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(94, 25)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(84, 20)
        Me.tPatientNo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdReferredTo)
        Me.GroupBox1.Controls.Add(Me.tReceivingDr)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tReferredTo)
        Me.GroupBox1.Controls.Add(Me.cmdReferralUnit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 66)
        Me.GroupBox1.TabIndex = 237
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REFERRED TO"
        '
        'cmdReferredTo
        '
        Me.cmdReferredTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReferredTo.Location = New System.Drawing.Point(370, 17)
        Me.cmdReferredTo.Name = "cmdReferredTo"
        Me.cmdReferredTo.Size = New System.Drawing.Size(34, 21)
        Me.cmdReferredTo.TabIndex = 64
        Me.cmdReferredTo.Text = "New"
        Me.cmdReferredTo.UseVisualStyleBackColor = True
        '
        'tReceivingDr
        '
        Me.tReceivingDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tReceivingDr.Location = New System.Drawing.Point(93, 40)
        Me.tReceivingDr.Name = "tReceivingDr"
        Me.tReceivingDr.Size = New System.Drawing.Size(334, 20)
        Me.tReceivingDr.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Receiving Dr."
        '
        'tReferredTo
        '
        Me.tReferredTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tReferredTo.Location = New System.Drawing.Point(92, 18)
        Me.tReferredTo.Name = "tReferredTo"
        Me.tReferredTo.ReadOnly = True
        Me.tReferredTo.Size = New System.Drawing.Size(276, 20)
        Me.tReferredTo.TabIndex = 61
        Me.tReferredTo.TabStop = False
        '
        'cmdReferralUnit
        '
        Me.cmdReferralUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReferralUnit.Location = New System.Drawing.Point(403, 17)
        Me.cmdReferralUnit.Name = "cmdReferralUnit"
        Me.cmdReferralUnit.Size = New System.Drawing.Size(26, 21)
        Me.cmdReferralUnit.TabIndex = 60
        Me.cmdReferralUnit.Text = "..."
        Me.cmdReferralUnit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Referred To:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tTreatment)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.tInfor)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.tClinicalWarning)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tMedHistory)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tReason)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tDiagnosis)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tHPC)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 316)
        Me.GroupBox2.TabIndex = 238
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CLINICAL INFORMATION:"
        '
        'tTreatment
        '
        Me.tTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTreatment.Location = New System.Drawing.Point(88, 182)
        Me.tTreatment.Name = "tTreatment"
        Me.tTreatment.Size = New System.Drawing.Size(340, 20)
        Me.tTreatment.TabIndex = 76
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Treatment:"
        '
        'tInfor
        '
        Me.tInfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tInfor.Location = New System.Drawing.Point(87, 273)
        Me.tInfor.Multiline = True
        Me.tInfor.Name = "tInfor"
        Me.tInfor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tInfor.Size = New System.Drawing.Size(341, 38)
        Me.tInfor.TabIndex = 74
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 275)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Relevant Info.:"
        '
        'tClinicalWarning
        '
        Me.tClinicalWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tClinicalWarning.Location = New System.Drawing.Point(88, 249)
        Me.tClinicalWarning.Name = "tClinicalWarning"
        Me.tClinicalWarning.Size = New System.Drawing.Size(340, 20)
        Me.tClinicalWarning.TabIndex = 72
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Clinical Warning:"
        '
        'tMedHistory
        '
        Me.tMedHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMedHistory.Location = New System.Drawing.Point(88, 227)
        Me.tMedHistory.Name = "tMedHistory"
        Me.tMedHistory.Size = New System.Drawing.Size(340, 20)
        Me.tMedHistory.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 229)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Medical History:"
        '
        'tReason
        '
        Me.tReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tReason.Location = New System.Drawing.Point(88, 205)
        Me.tReason.Name = "tReason"
        Me.tReason.Size = New System.Drawing.Size(340, 20)
        Me.tReason.TabIndex = 68
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Referral Reason:"
        '
        'tDiagnosis
        '
        Me.tDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDiagnosis.Location = New System.Drawing.Point(88, 140)
        Me.tDiagnosis.Multiline = True
        Me.tDiagnosis.Name = "tDiagnosis"
        Me.tDiagnosis.Size = New System.Drawing.Size(340, 39)
        Me.tDiagnosis.TabIndex = 66
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 34)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Provisional Diagnosis:"
        '
        'tHPC
        '
        Me.tHPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tHPC.Location = New System.Drawing.Point(89, 35)
        Me.tHPC.Multiline = True
        Me.tHPC.Name = "tHPC"
        Me.tHPC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tHPC.Size = New System.Drawing.Size(339, 100)
        Me.tHPC.TabIndex = 64
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(361, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "History of Presenting complaint / examination findings / investigation results"
        '
        'PanMainCommand
        '
        Me.PanMainCommand.BackColor = System.Drawing.Color.LightYellow
        Me.PanMainCommand.Controls.Add(Me.mnuPrint)
        Me.PanMainCommand.Controls.Add(Me.lnkFinancialState)
        Me.PanMainCommand.Controls.Add(Me.cmdClose)
        Me.PanMainCommand.Controls.Add(Me.cmdOk)
        Me.PanMainCommand.Location = New System.Drawing.Point(2, 542)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(439, 41)
        Me.PanMainCommand.TabIndex = 239
        '
        'mnuPrint
        '
        Me.mnuPrint.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.mnuPrint.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuPrint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintResult})
        Me.mnuPrint.Location = New System.Drawing.Point(158, 10)
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(195, 24)
        Me.mnuPrint.TabIndex = 259
        Me.mnuPrint.Text = "MenuStrip1"
        '
        'mnuPrintResult
        '
        Me.mnuPrintResult.BackColor = System.Drawing.Color.Transparent
        Me.mnuPrintResult.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLastResult, Me.mnuRefNo})
        Me.mnuPrintResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPrintResult.ForeColor = System.Drawing.Color.Brown
        Me.mnuPrintResult.Name = "mnuPrintResult"
        Me.mnuPrintResult.Size = New System.Drawing.Size(95, 20)
        Me.mnuPrintResult.Text = "Print Referral"
        '
        'mnuLastResult
        '
        Me.mnuLastResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLastResult.ForeColor = System.Drawing.Color.Brown
        Me.mnuLastResult.Name = "mnuLastResult"
        Me.mnuLastResult.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuLastResult.Size = New System.Drawing.Size(157, 22)
        Me.mnuLastResult.Text = "Last Referral"
        '
        'mnuRefNo
        '
        Me.mnuRefNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuRefNo.ForeColor = System.Drawing.Color.Brown
        Me.mnuRefNo.Name = "mnuRefNo"
        Me.mnuRefNo.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuRefNo.Size = New System.Drawing.Size(157, 22)
        Me.mnuRefNo.Text = "Use Ref. No"
        '
        'lnkFinancialState
        '
        Me.lnkFinancialState.AutoSize = True
        Me.lnkFinancialState.Location = New System.Drawing.Point(0, 12)
        Me.lnkFinancialState.Name = "lnkFinancialState"
        Me.lnkFinancialState.Size = New System.Drawing.Size(147, 13)
        Me.lnkFinancialState.TabIndex = 256
        Me.lnkFinancialState.TabStop = True
        Me.lnkFinancialState.Text = "Check Patient Financial State"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(373, 1)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(60, 39)
        Me.cmdClose.TabIndex = 251
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(312, 1)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(60, 39)
        Me.cmdOk.TabIndex = 250
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'FrmReferral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(437, 589)
        Me.Controls.Add(Me.PanMainCommand)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanHeading)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReferral"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Referral"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanMainCommand.ResumeLayout(False)
        Me.PanMainCommand.PerformLayout()
        Me.mnuPrint.ResumeLayout(False)
        Me.mnuPrint.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents tReferredBy As System.Windows.Forms.TextBox
    Friend WithEvents cmdReferredBy As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tReceivingDr As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tReferredTo As System.Windows.Forms.TextBox
    Friend WithEvents cmdReferralUnit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tReason As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tHPC As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tClinicalWarning As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tMedHistory As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tInfor As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
    Friend WithEvents lnkFinancialState As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdReferredTo As System.Windows.Forms.Button
    Friend WithEvents tTreatment As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuPrintResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLastResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRefNo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
End Class
