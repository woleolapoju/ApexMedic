<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBulkPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBulkPayment))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.PanCopies = New System.Windows.Forms.Panel
        Me.tCopies = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.chkPrintReceipt = New System.Windows.Forms.CheckBox
        Me.PanMail = New System.Windows.Forms.Panel
        Me.mnuMail = New System.Windows.Forms.CheckBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.PanPatient = New System.Windows.Forms.Panel
        Me.cmdUnRegistered = New System.Windows.Forms.Button
        Me.tAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.tSourceDocNo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
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
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBrowse = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.lblAction = New System.Windows.Forms.Label
        Me.PanAccount = New System.Windows.Forms.Panel
        Me.tAccountName = New System.Windows.Forms.TextBox
        Me.cmdAccount = New System.Windows.Forms.Button
        Me.tAccountCode = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.PanDetails = New System.Windows.Forms.Panel
        Me.tBeing = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tAmtInWords = New System.Windows.Forms.TextBox
        Me.tChqDetails = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cPayMode = New System.Windows.Forms.ComboBox
        Me.tAmount = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuReconcile = New System.Windows.Forms.ToolStripMenuItem
        Me.tStartDate = New System.Windows.Forms.ToolStripTextBox
        Me.tEndDate = New System.Windows.Forms.ToolStripTextBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanMainCommand.SuspendLayout()
        Me.PanCopies.SuspendLayout()
        Me.PanMail.SuspendLayout()
        Me.PanPatient.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.PanAccount.SuspendLayout()
        Me.PanDetails.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(465, 367)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PanMainCommand
        '
        Me.PanMainCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanMainCommand.Controls.Add(Me.PanCopies)
        Me.PanMainCommand.Controls.Add(Me.chkPrintReceipt)
        Me.PanMainCommand.Controls.Add(Me.PanMail)
        Me.PanMainCommand.Controls.Add(Me.cmdClose)
        Me.PanMainCommand.Controls.Add(Me.cmdOk)
        Me.PanMainCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMainCommand.Location = New System.Drawing.Point(0, 315)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(465, 52)
        Me.PanMainCommand.TabIndex = 243
        '
        'PanCopies
        '
        Me.PanCopies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanCopies.Controls.Add(Me.tCopies)
        Me.PanCopies.Controls.Add(Me.Label27)
        Me.PanCopies.Location = New System.Drawing.Point(223, 21)
        Me.PanCopies.Name = "PanCopies"
        Me.PanCopies.Size = New System.Drawing.Size(51, 22)
        Me.PanCopies.TabIndex = 559
        '
        'tCopies
        '
        Me.tCopies.BackColor = System.Drawing.Color.White
        Me.tCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCopies.Location = New System.Drawing.Point(32, 1)
        Me.tCopies.Name = "tCopies"
        Me.tCopies.Size = New System.Drawing.Size(16, 18)
        Me.tCopies.TabIndex = 9
        Me.tCopies.Text = "1"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(0, 4)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(34, 12)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Copies"
        '
        'chkPrintReceipt
        '
        Me.chkPrintReceipt.AutoSize = True
        Me.chkPrintReceipt.Checked = True
        Me.chkPrintReceipt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintReceipt.ForeColor = System.Drawing.Color.DarkRed
        Me.chkPrintReceipt.Location = New System.Drawing.Point(138, 25)
        Me.chkPrintReceipt.Name = "chkPrintReceipt"
        Me.chkPrintReceipt.Size = New System.Drawing.Size(87, 17)
        Me.chkPrintReceipt.TabIndex = 558
        Me.chkPrintReceipt.Text = "Print Receipt"
        Me.chkPrintReceipt.UseVisualStyleBackColor = True
        '
        'PanMail
        '
        Me.PanMail.Controls.Add(Me.mnuMail)
        Me.PanMail.Location = New System.Drawing.Point(2, 1)
        Me.PanMail.Name = "PanMail"
        Me.PanMail.Size = New System.Drawing.Size(140, 20)
        Me.PanMail.TabIndex = 253
        '
        'mnuMail
        '
        Me.mnuMail.AutoSize = True
        Me.mnuMail.Location = New System.Drawing.Point(1, 2)
        Me.mnuMail.Name = "mnuMail"
        Me.mnuMail.Size = New System.Drawing.Size(136, 17)
        Me.mnuMail.TabIndex = 0
        Me.mnuMail.Text = "Mail record after saving"
        Me.mnuMail.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(372, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(84, 48)
        Me.cmdClose.TabIndex = 251
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(279, 0)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(84, 48)
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
        Me.PanPatient.Location = New System.Drawing.Point(0, 109)
        Me.PanPatient.Margin = New System.Windows.Forms.Padding(0)
        Me.PanPatient.Name = "PanPatient"
        Me.PanPatient.Size = New System.Drawing.Size(465, 50)
        Me.PanPatient.TabIndex = 57
        '
        'cmdUnRegistered
        '
        Me.cmdUnRegistered.Location = New System.Drawing.Point(193, 2)
        Me.cmdUnRegistered.Name = "cmdUnRegistered"
        Me.cmdUnRegistered.Size = New System.Drawing.Size(31, 21)
        Me.cmdUnRegistered.TabIndex = 64
        Me.cmdUnRegistered.Text = "OP"
        Me.cmdUnRegistered.UseVisualStyleBackColor = True
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(85, 25)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(376, 20)
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
        Me.tPatientName.Location = New System.Drawing.Point(224, 2)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(236, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(168, 2)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 7
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(85, 3)
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
        Me.Panel3.Controls.Add(Me.tSourceDocNo)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.cPayType)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.tRecNo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 58)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(465, 51)
        Me.Panel3.TabIndex = 239
        '
        'tSourceDocNo
        '
        Me.tSourceDocNo.Location = New System.Drawing.Point(85, 28)
        Me.tSourceDocNo.Name = "tSourceDocNo"
        Me.tSourceDocNo.Size = New System.Drawing.Size(127, 20)
        Me.tSourceDocNo.TabIndex = 267
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 268
        Me.Label10.Text = "Source Doc No:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 255
        Me.Label11.Text = "Payment Type:"
        '
        'cPayType
        '
        Me.cPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPayType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cPayType.FormattingEnabled = True
        Me.cPayType.Items.AddRange(New Object() {"Individual Payment", "Corporate Payment"})
        Me.cPayType.Location = New System.Drawing.Point(85, 6)
        Me.cPayType.Name = "cPayType"
        Me.cPayType.Size = New System.Drawing.Size(126, 21)
        Me.cPayType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(305, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Receipt No:"
        '
        'tRecNo
        '
        Me.tRecNo.Location = New System.Drawing.Point(371, 27)
        Me.tRecNo.Name = "tRecNo"
        Me.tRecNo.ReadOnly = True
        Me.tRecNo.Size = New System.Drawing.Size(90, 20)
        Me.tRecNo.TabIndex = 10
        Me.tRecNo.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tblHeader)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(459, 49)
        Me.Panel2.TabIndex = 240
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205.0!))
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
        Me.tblHeader.Size = New System.Drawing.Size(459, 49)
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
        Me.Label7.Size = New System.Drawing.Size(143, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "PAYMENT"
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
        Me.Label8.Size = New System.Drawing.Size(143, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Manages Payments"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Location = New System.Drawing.Point(254, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(205, 49)
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
        'PanAccount
        '
        Me.PanAccount.Controls.Add(Me.tAccountName)
        Me.PanAccount.Controls.Add(Me.cmdAccount)
        Me.PanAccount.Controls.Add(Me.tAccountCode)
        Me.PanAccount.Controls.Add(Me.Label12)
        Me.PanAccount.Location = New System.Drawing.Point(0, 159)
        Me.PanAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAccount.Name = "PanAccount"
        Me.PanAccount.Size = New System.Drawing.Size(462, 24)
        Me.PanAccount.TabIndex = 241
        Me.PanAccount.Visible = False
        '
        'tAccountName
        '
        Me.tAccountName.Location = New System.Drawing.Point(196, 2)
        Me.tAccountName.Name = "tAccountName"
        Me.tAccountName.ReadOnly = True
        Me.tAccountName.Size = New System.Drawing.Size(266, 20)
        Me.tAccountName.TabIndex = 46
        Me.tAccountName.TabStop = False
        '
        'cmdAccount
        '
        Me.cmdAccount.Location = New System.Drawing.Point(169, 1)
        Me.cmdAccount.Name = "cmdAccount"
        Me.cmdAccount.Size = New System.Drawing.Size(26, 21)
        Me.cmdAccount.TabIndex = 10
        Me.cmdAccount.Text = "..."
        Me.cmdAccount.UseVisualStyleBackColor = True
        '
        'tAccountCode
        '
        Me.tAccountCode.Location = New System.Drawing.Point(85, 2)
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
        'PanDetails
        '
        Me.PanDetails.Controls.Add(Me.tBeing)
        Me.PanDetails.Controls.Add(Me.Label3)
        Me.PanDetails.Controls.Add(Me.tAmtInWords)
        Me.PanDetails.Controls.Add(Me.tChqDetails)
        Me.PanDetails.Controls.Add(Me.Label9)
        Me.PanDetails.Controls.Add(Me.cPayMode)
        Me.PanDetails.Controls.Add(Me.tAmount)
        Me.PanDetails.Controls.Add(Me.Label5)
        Me.PanDetails.Controls.Add(Me.Label6)
        Me.PanDetails.Controls.Add(Me.dtpDate)
        Me.PanDetails.Controls.Add(Me.Label2)
        Me.PanDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanDetails.Location = New System.Drawing.Point(0, 183)
        Me.PanDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.PanDetails.Name = "PanDetails"
        Me.PanDetails.Size = New System.Drawing.Size(465, 132)
        Me.PanDetails.TabIndex = 242
        '
        'tBeing
        '
        Me.tBeing.Location = New System.Drawing.Point(85, 49)
        Me.tBeing.Multiline = True
        Me.tBeing.Name = "tBeing"
        Me.tBeing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tBeing.Size = New System.Drawing.Size(373, 48)
        Me.tBeing.TabIndex = 261
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 262
        Me.Label3.Text = "Being:"
        '
        'tAmtInWords
        '
        Me.tAmtInWords.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tAmtInWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAmtInWords.Location = New System.Drawing.Point(2, 99)
        Me.tAmtInWords.Margin = New System.Windows.Forms.Padding(0)
        Me.tAmtInWords.Multiline = True
        Me.tAmtInWords.Name = "tAmtInWords"
        Me.tAmtInWords.ReadOnly = True
        Me.tAmtInWords.Size = New System.Drawing.Size(461, 29)
        Me.tAmtInWords.TabIndex = 260
        Me.tAmtInWords.TabStop = False
        '
        'tChqDetails
        '
        Me.tChqDetails.Location = New System.Drawing.Point(247, 26)
        Me.tChqDetails.Name = "tChqDetails"
        Me.tChqDetails.Size = New System.Drawing.Size(211, 20)
        Me.tChqDetails.TabIndex = 258
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(177, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 259
        Me.Label9.Text = "Pay Details:"
        '
        'cPayMode
        '
        Me.cPayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPayMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cPayMode.FormattingEnabled = True
        Me.cPayMode.Items.AddRange(New Object() {"Cash", "Cheque", "Others"})
        Me.cPayMode.Location = New System.Drawing.Point(86, 24)
        Me.cPayMode.Name = "cPayMode"
        Me.cPayMode.Size = New System.Drawing.Size(85, 21)
        Me.cPayMode.TabIndex = 256
        '
        'tAmount
        '
        Me.tAmount.Location = New System.Drawing.Point(85, 1)
        Me.tAmount.Name = "tAmount"
        Me.tAmount.Size = New System.Drawing.Size(85, 20)
        Me.tAmount.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Amount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 257
        Me.Label6.Text = "Payment Mode:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(246, 2)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(99, 20)
        Me.dtpDate.TabIndex = 2
        Me.dtpDate.Tag = "RegDate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Date:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Lavender
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReconcile, Me.tStartDate, Me.tEndDate})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(465, 26)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuReconcile
        '
        Me.mnuReconcile.BackColor = System.Drawing.Color.Bisque
        Me.mnuReconcile.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuReconcile.Name = "mnuReconcile"
        Me.mnuReconcile.Size = New System.Drawing.Size(78, 22)
        Me.mnuReconcile.Text = "Reconcile"
        '
        'tStartDate
        '
        Me.tStartDate.BackColor = System.Drawing.Color.Bisque
        Me.tStartDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStartDate.ForeColor = System.Drawing.Color.Red
        Me.tStartDate.Name = "tStartDate"
        Me.tStartDate.Size = New System.Drawing.Size(100, 22)
        '
        'tEndDate
        '
        Me.tEndDate.BackColor = System.Drawing.Color.Bisque
        Me.tEndDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tEndDate.ForeColor = System.Drawing.Color.Red
        Me.tEndDate.Name = "tEndDate"
        Me.tEndDate.Size = New System.Drawing.Size(100, 22)
        '
        'FrmBulkPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(465, 393)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBulkPayment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanMainCommand.ResumeLayout(False)
        Me.PanMainCommand.PerformLayout()
        Me.PanCopies.ResumeLayout(False)
        Me.PanCopies.PerformLayout()
        Me.PanMail.ResumeLayout(False)
        Me.PanMail.PerformLayout()
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
        Me.PanAccount.ResumeLayout(False)
        Me.PanAccount.PerformLayout()
        Me.PanDetails.ResumeLayout(False)
        Me.PanDetails.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanPatient As System.Windows.Forms.Panel
    Friend WithEvents tAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tRecNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cPayType As System.Windows.Forms.ComboBox
    Friend WithEvents PanAccount As System.Windows.Forms.Panel
    Friend WithEvents tAccountName As System.Windows.Forms.TextBox
    Friend WithEvents cmdAccount As System.Windows.Forms.Button
    Friend WithEvents tAccountCode As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PanDetails As System.Windows.Forms.Panel
    Friend WithEvents tChqDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cPayMode As System.Windows.Forms.ComboBox
    Friend WithEvents tAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
    Friend WithEvents PanMail As System.Windows.Forms.Panel
    Friend WithEvents mnuMail As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents tAmtInWords As System.Windows.Forms.TextBox
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents tBeing As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanCopies As System.Windows.Forms.Panel
    Friend WithEvents tCopies As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents chkPrintReceipt As System.Windows.Forms.CheckBox
    Friend WithEvents cmdUnRegistered As System.Windows.Forms.Button
    Friend WithEvents tSourceDocNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuReconcile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tStartDate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tEndDate As System.Windows.Forms.ToolStripTextBox
End Class
