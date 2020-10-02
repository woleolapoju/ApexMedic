<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRefunds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRefunds))
        Me.PanAccount = New System.Windows.Forms.Panel
        Me.tAccountName = New System.Windows.Forms.TextBox
        Me.cmdAccount = New System.Windows.Forms.Button
        Me.tAccountCode = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.PanPatient = New System.Windows.Forms.Panel
        Me.tAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.cPayType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tRecNo = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanAction = New System.Windows.Forms.FlowLayoutPanel
        Me.mnuAction = New System.Windows.Forms.MenuStrip
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.lblAction = New System.Windows.Forms.Label
        Me.PanDetails = New System.Windows.Forms.Panel
        Me.tChqDetails = New System.Windows.Forms.TextBox
        Me.cPayMode = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.tAmtInWords = New System.Windows.Forms.TextBox
        Me.tReason = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tAmount = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdUnRegistered = New System.Windows.Forms.Button
        Me.PanAccount.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanMainCommand.SuspendLayout()
        Me.PanPatient.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.PanDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanAccount
        '
        Me.PanAccount.Controls.Add(Me.tAccountName)
        Me.PanAccount.Controls.Add(Me.cmdAccount)
        Me.PanAccount.Controls.Add(Me.tAccountCode)
        Me.PanAccount.Controls.Add(Me.Label12)
        Me.PanAccount.Location = New System.Drawing.Point(0, 135)
        Me.PanAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAccount.Name = "PanAccount"
        Me.PanAccount.Size = New System.Drawing.Size(445, 24)
        Me.PanAccount.TabIndex = 241
        Me.PanAccount.Visible = False
        '
        'tAccountName
        '
        Me.tAccountName.Location = New System.Drawing.Point(208, 2)
        Me.tAccountName.Name = "tAccountName"
        Me.tAccountName.ReadOnly = True
        Me.tAccountName.Size = New System.Drawing.Size(254, 20)
        Me.tAccountName.TabIndex = 46
        Me.tAccountName.TabStop = False
        '
        'cmdAccount
        '
        Me.cmdAccount.Location = New System.Drawing.Point(182, 1)
        Me.cmdAccount.Name = "cmdAccount"
        Me.cmdAccount.Size = New System.Drawing.Size(26, 21)
        Me.cmdAccount.TabIndex = 10
        Me.cmdAccount.Text = "..."
        Me.cmdAccount.UseVisualStyleBackColor = True
        '
        'tAccountCode
        '
        Me.tAccountCode.Location = New System.Drawing.Point(96, 2)
        Me.tAccountCode.Name = "tAccountCode"
        Me.tAccountCode.Size = New System.Drawing.Size(84, 20)
        Me.tAccountCode.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Account:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanMainCommand, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.PanPatient, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanAccount, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PanDetails, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(481, 308)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'PanMainCommand
        '
        Me.PanMainCommand.BackColor = System.Drawing.Color.Lavender
        Me.PanMainCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanMainCommand.Controls.Add(Me.cmdClose)
        Me.PanMainCommand.Controls.Add(Me.cmdOk)
        Me.PanMainCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMainCommand.Location = New System.Drawing.Point(0, 272)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(481, 36)
        Me.PanMainCommand.TabIndex = 243
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(384, 1)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(87, 46)
        Me.cmdClose.TabIndex = 251
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(293, 1)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(87, 46)
        Me.cmdOk.TabIndex = 250
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'PanPatient
        '
        Me.PanPatient.Controls.Add(Me.cmdUnRegistered)
        Me.PanPatient.Controls.Add(Me.tAccount)
        Me.PanPatient.Controls.Add(Me.Label16)
        Me.PanPatient.Controls.Add(Me.tPatientName)
        Me.PanPatient.Controls.Add(Me.cmdPatient)
        Me.PanPatient.Controls.Add(Me.tPatientNo)
        Me.PanPatient.Controls.Add(Me.Label4)
        Me.PanPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanPatient.Location = New System.Drawing.Point(0, 85)
        Me.PanPatient.Margin = New System.Windows.Forms.Padding(0)
        Me.PanPatient.Name = "PanPatient"
        Me.PanPatient.Size = New System.Drawing.Size(481, 50)
        Me.PanPatient.TabIndex = 57
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(96, 25)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(382, 20)
        Me.tAccount.TabIndex = 51
        Me.tAccount.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Account:"
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(239, 2)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(239, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(181, 2)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 7
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(96, 3)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(84, 20)
        Me.tPatientNo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Patient No:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.cPayType)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.tRecNo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 58)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(481, 27)
        Me.Panel3.TabIndex = 239
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 255
        Me.Label11.Text = "Discount Type:"
        '
        'cPayType
        '
        Me.cPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPayType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cPayType.FormattingEnabled = True
        Me.cPayType.Items.AddRange(New Object() {"Individual Refund", "Corporate Refund"})
        Me.cPayType.Location = New System.Drawing.Point(96, 3)
        Me.cPayType.Name = "cPayType"
        Me.cPayType.Size = New System.Drawing.Size(123, 21)
        Me.cPayType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(305, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ref: No:"
        '
        'tRecNo
        '
        Me.tRecNo.Location = New System.Drawing.Point(380, 3)
        Me.tRecNo.Name = "tRecNo"
        Me.tRecNo.ReadOnly = True
        Me.tRecNo.Size = New System.Drawing.Size(97, 20)
        Me.tRecNo.TabIndex = 1
        Me.tRecNo.TabStop = False
        Me.tRecNo.Text = "(AUTO)"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tblHeader)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(475, 49)
        Me.Panel2.TabIndex = 240
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.tblHeader.Controls.Add(Me.Label7, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label8, 1, 1)
        Me.tblHeader.Controls.Add(Me.PanAction, 2, 0)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblHeader.Size = New System.Drawing.Size(475, 49)
        Me.tblHeader.TabIndex = 56
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
        Me.Label7.Size = New System.Drawing.Size(237, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "REFUNDS"
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
        Me.PictureBox1.Size = New System.Drawing.Size(111, 49)
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
        Me.Label8.Location = New System.Drawing.Point(111, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(237, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Manages Refunds Given"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Location = New System.Drawing.Point(348, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(127, 49)
        Me.PanAction.TabIndex = 55
        '
        'mnuAction
        '
        Me.mnuAction.AllowMerge = False
        Me.mnuAction.BackColor = System.Drawing.Color.Transparent
        Me.mnuAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuDelete})
        Me.mnuAction.Location = New System.Drawing.Point(0, 0)
        Me.mnuAction.Name = "mnuAction"
        Me.mnuAction.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuAction.Size = New System.Drawing.Size(98, 24)
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
        Me.lblAction.Size = New System.Drawing.Size(119, 19)
        Me.lblAction.TabIndex = 11
        Me.lblAction.Text = "?"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanDetails
        '
        Me.PanDetails.Controls.Add(Me.tChqDetails)
        Me.PanDetails.Controls.Add(Me.cPayMode)
        Me.PanDetails.Controls.Add(Me.Label3)
        Me.PanDetails.Controls.Add(Me.Label6)
        Me.PanDetails.Controls.Add(Me.tAmtInWords)
        Me.PanDetails.Controls.Add(Me.tReason)
        Me.PanDetails.Controls.Add(Me.Label9)
        Me.PanDetails.Controls.Add(Me.tAmount)
        Me.PanDetails.Controls.Add(Me.Label5)
        Me.PanDetails.Controls.Add(Me.dtpDate)
        Me.PanDetails.Controls.Add(Me.Label2)
        Me.PanDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanDetails.Location = New System.Drawing.Point(0, 159)
        Me.PanDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.PanDetails.Name = "PanDetails"
        Me.PanDetails.Size = New System.Drawing.Size(481, 113)
        Me.PanDetails.TabIndex = 242
        '
        'tChqDetails
        '
        Me.tChqDetails.Location = New System.Drawing.Point(250, 48)
        Me.tChqDetails.Name = "tChqDetails"
        Me.tChqDetails.Size = New System.Drawing.Size(226, 20)
        Me.tChqDetails.TabIndex = 270
        '
        'cPayMode
        '
        Me.cPayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPayMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cPayMode.FormattingEnabled = True
        Me.cPayMode.Items.AddRange(New Object() {"Cash", "Cheque", "Others"})
        Me.cPayMode.Location = New System.Drawing.Point(98, 48)
        Me.cPayMode.Name = "cPayMode"
        Me.cPayMode.Size = New System.Drawing.Size(85, 21)
        Me.cPayMode.TabIndex = 268
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 271
        Me.Label3.Text = "Pay Details:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 269
        Me.Label6.Text = "Payment Mode:"
        '
        'tAmtInWords
        '
        Me.tAmtInWords.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tAmtInWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAmtInWords.Location = New System.Drawing.Point(2, 74)
        Me.tAmtInWords.Margin = New System.Windows.Forms.Padding(0)
        Me.tAmtInWords.Multiline = True
        Me.tAmtInWords.Name = "tAmtInWords"
        Me.tAmtInWords.ReadOnly = True
        Me.tAmtInWords.Size = New System.Drawing.Size(477, 35)
        Me.tAmtInWords.TabIndex = 260
        Me.tAmtInWords.TabStop = False
        '
        'tReason
        '
        Me.tReason.Location = New System.Drawing.Point(96, 25)
        Me.tReason.Name = "tReason"
        Me.tReason.Size = New System.Drawing.Size(378, 20)
        Me.tReason.TabIndex = 258
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 259
        Me.Label9.Text = "Refund Reason:"
        '
        'tAmount
        '
        Me.tAmount.Location = New System.Drawing.Point(96, 2)
        Me.tAmount.Name = "tAmount"
        Me.tAmount.Size = New System.Drawing.Size(85, 20)
        Me.tAmount.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Refund Amount:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(376, 3)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(99, 20)
        Me.dtpDate.TabIndex = 2
        Me.dtpDate.Tag = "RegDate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Date:"
        '
        'cmdUnRegistered
        '
        Me.cmdUnRegistered.Location = New System.Drawing.Point(207, 2)
        Me.cmdUnRegistered.Name = "cmdUnRegistered"
        Me.cmdUnRegistered.Size = New System.Drawing.Size(31, 21)
        Me.cmdUnRegistered.TabIndex = 64
        Me.cmdUnRegistered.Text = "OP"
        Me.cmdUnRegistered.UseVisualStyleBackColor = True
        '
        'FrmRefunds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 308)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRefunds"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Refunds"
        Me.PanAccount.ResumeLayout(False)
        Me.PanAccount.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanMainCommand.ResumeLayout(False)
        Me.PanPatient.ResumeLayout(False)
        Me.PanPatient.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.PanDetails.ResumeLayout(False)
        Me.PanDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanAccount As System.Windows.Forms.Panel
    Friend WithEvents tAccountName As System.Windows.Forms.TextBox
    Friend WithEvents cmdAccount As System.Windows.Forms.Button
    Friend WithEvents tAccountCode As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents PanPatient As System.Windows.Forms.Panel
    Friend WithEvents tAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cPayType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tRecNo As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents PanDetails As System.Windows.Forms.Panel
    Friend WithEvents tAmtInWords As System.Windows.Forms.TextBox
    Friend WithEvents tReason As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tChqDetails As System.Windows.Forms.TextBox
    Friend WithEvents cPayMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdUnRegistered As System.Windows.Forms.Button
End Class
