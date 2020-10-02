<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPayment))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
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
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.tSourceDocNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdUnRegistered = New System.Windows.Forms.Button
        Me.tChqDetails = New System.Windows.Forms.TextBox
        Me.cPayMode = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.tAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.tRecNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.PanCopies = New System.Windows.Forms.Panel
        Me.tCopies = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.chkPrintReceipt = New System.Windows.Forms.CheckBox
        Me.mnuBillLoad = New System.Windows.Forms.MenuStrip
        Me.mnuLoadBill = New System.Windows.Forms.ToolStripMenuItem
        Me.lnkFinancialState = New System.Windows.Forms.LinkLabel
        Me.PanMail = New System.Windows.Forms.Panel
        Me.mnuMail = New System.Windows.Forms.CheckBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.PanDetails = New System.Windows.Forms.Panel
        Me.cServiceID = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PanCommands = New System.Windows.Forms.Panel
        Me.mnuCut = New System.Windows.Forms.Button
        Me.mnuOpen = New System.Windows.Forms.Button
        Me.mnuInsert = New System.Windows.Forms.Button
        Me.tAmount = New System.Windows.Forms.TextBox
        Me.tServiceName = New System.Windows.Forms.TextBox
        Me.lvList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.PanTotal = New System.Windows.Forms.Panel
        Me.tAmtInWords = New System.Windows.Forms.TextBox
        Me.tTotal = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.lvAppointment = New System.Windows.Forms.ListView
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.TimBill = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuReconcile = New System.Windows.Forms.ToolStripMenuItem
        Me.tStartDate = New System.Windows.Forms.ToolStripTextBox
        Me.tEndDate = New System.Windows.Forms.ToolStripTextBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.PanHeading.SuspendLayout()
        Me.PanMainCommand.SuspendLayout()
        Me.PanCopies.SuspendLayout()
        Me.mnuBillLoad.SuspendLayout()
        Me.PanMail.SuspendLayout()
        Me.PanDetails.SuspendLayout()
        Me.PanCommands.SuspendLayout()
        Me.PanTotal.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanHeading, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanMainCommand, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanDetails, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lvList, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PanTotal, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1028, 568)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.tblHeader)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1022, 49)
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
        Me.tblHeader.Size = New System.Drawing.Size(1022, 49)
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
        Me.Label7.Size = New System.Drawing.Size(706, 24)
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
        Me.Label8.Size = New System.Drawing.Size(706, 25)
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
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAction.Location = New System.Drawing.Point(817, 0)
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
        'PanHeading
        '
        Me.PanHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanHeading.Controls.Add(Me.tSourceDocNo)
        Me.PanHeading.Controls.Add(Me.Label4)
        Me.PanHeading.Controls.Add(Me.cmdUnRegistered)
        Me.PanHeading.Controls.Add(Me.tChqDetails)
        Me.PanHeading.Controls.Add(Me.cPayMode)
        Me.PanHeading.Controls.Add(Me.Label11)
        Me.PanHeading.Controls.Add(Me.Label12)
        Me.PanHeading.Controls.Add(Me.tAccount)
        Me.PanHeading.Controls.Add(Me.Label16)
        Me.PanHeading.Controls.Add(Me.tPatientName)
        Me.PanHeading.Controls.Add(Me.Label3)
        Me.PanHeading.Controls.Add(Me.Label2)
        Me.PanHeading.Controls.Add(Me.dtpDate)
        Me.PanHeading.Controls.Add(Me.tRecNo)
        Me.PanHeading.Controls.Add(Me.Label1)
        Me.PanHeading.Controls.Add(Me.cmdPatient)
        Me.PanHeading.Controls.Add(Me.tPatientNo)
        Me.PanHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanHeading.Location = New System.Drawing.Point(452, 58)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(573, 146)
        Me.PanHeading.TabIndex = 57
        '
        'tSourceDocNo
        '
        Me.tSourceDocNo.Location = New System.Drawing.Point(80, 27)
        Me.tSourceDocNo.Name = "tSourceDocNo"
        Me.tSourceDocNo.Size = New System.Drawing.Size(103, 20)
        Me.tSourceDocNo.TabIndex = 265
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 266
        Me.Label4.Text = "Source Doc No:"
        '
        'cmdUnRegistered
        '
        Me.cmdUnRegistered.Location = New System.Drawing.Point(189, 49)
        Me.cmdUnRegistered.Name = "cmdUnRegistered"
        Me.cmdUnRegistered.Size = New System.Drawing.Size(31, 21)
        Me.cmdUnRegistered.TabIndex = 264
        Me.cmdUnRegistered.Text = "OP"
        Me.cmdUnRegistered.UseVisualStyleBackColor = True
        '
        'tChqDetails
        '
        Me.tChqDetails.Location = New System.Drawing.Point(80, 117)
        Me.tChqDetails.Name = "tChqDetails"
        Me.tChqDetails.Size = New System.Drawing.Size(380, 20)
        Me.tChqDetails.TabIndex = 262
        '
        'cPayMode
        '
        Me.cPayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPayMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cPayMode.FormattingEnabled = True
        Me.cPayMode.Items.AddRange(New Object() {"Cash", "Cheque", "Others"})
        Me.cPayMode.Location = New System.Drawing.Point(81, 93)
        Me.cPayMode.Name = "cPayMode"
        Me.cPayMode.Size = New System.Drawing.Size(103, 21)
        Me.cPayMode.TabIndex = 260
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 263
        Me.Label11.Text = "Pay Details:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 261
        Me.Label12.Text = "Payment Mode:"
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(80, 71)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(380, 20)
        Me.tAccount.TabIndex = 51
        Me.tAccount.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(2, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Account:"
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(221, 49)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(238, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Patient:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 8)
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
        Me.dtpDate.Location = New System.Drawing.Point(80, 4)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpDate.TabIndex = 2
        Me.dtpDate.Tag = "RegDate"
        '
        'tRecNo
        '
        Me.tRecNo.Location = New System.Drawing.Point(351, 26)
        Me.tRecNo.Name = "tRecNo"
        Me.tRecNo.ReadOnly = True
        Me.tRecNo.Size = New System.Drawing.Size(107, 20)
        Me.tRecNo.TabIndex = 1
        Me.tRecNo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(285, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Receipt No:"
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(164, 49)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 7
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(80, 49)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(86, 20)
        Me.tPatientNo.TabIndex = 0
        '
        'PanMainCommand
        '
        Me.PanMainCommand.BackColor = System.Drawing.Color.LightYellow
        Me.PanMainCommand.Controls.Add(Me.PanCopies)
        Me.PanMainCommand.Controls.Add(Me.chkPrintReceipt)
        Me.PanMainCommand.Controls.Add(Me.mnuBillLoad)
        Me.PanMainCommand.Controls.Add(Me.lnkFinancialState)
        Me.PanMainCommand.Controls.Add(Me.PanMail)
        Me.PanMainCommand.Controls.Add(Me.cmdClose)
        Me.PanMainCommand.Controls.Add(Me.cmdOk)
        Me.PanMainCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMainCommand.Location = New System.Drawing.Point(449, 207)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(579, 42)
        Me.PanMainCommand.TabIndex = 58
        '
        'PanCopies
        '
        Me.PanCopies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanCopies.Controls.Add(Me.tCopies)
        Me.PanCopies.Controls.Add(Me.Label27)
        Me.PanCopies.Location = New System.Drawing.Point(237, 19)
        Me.PanCopies.Name = "PanCopies"
        Me.PanCopies.Size = New System.Drawing.Size(51, 22)
        Me.PanCopies.TabIndex = 557
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
        Me.chkPrintReceipt.Location = New System.Drawing.Point(152, 23)
        Me.chkPrintReceipt.Name = "chkPrintReceipt"
        Me.chkPrintReceipt.Size = New System.Drawing.Size(87, 17)
        Me.chkPrintReceipt.TabIndex = 259
        Me.chkPrintReceipt.Text = "Print Receipt"
        Me.chkPrintReceipt.UseVisualStyleBackColor = True
        '
        'mnuBillLoad
        '
        Me.mnuBillLoad.BackColor = System.Drawing.Color.LightBlue
        Me.mnuBillLoad.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuBillLoad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLoadBill})
        Me.mnuBillLoad.Location = New System.Drawing.Point(368, 12)
        Me.mnuBillLoad.Name = "mnuBillLoad"
        Me.mnuBillLoad.Size = New System.Drawing.Size(72, 24)
        Me.mnuBillLoad.TabIndex = 258
        Me.mnuBillLoad.Text = "MenuStrip1"
        '
        'mnuLoadBill
        '
        Me.mnuLoadBill.Name = "mnuLoadBill"
        Me.mnuLoadBill.Size = New System.Drawing.Size(64, 20)
        Me.mnuLoadBill.Text = "&Load Bill"
        '
        'lnkFinancialState
        '
        Me.lnkFinancialState.AutoSize = True
        Me.lnkFinancialState.Location = New System.Drawing.Point(1, 24)
        Me.lnkFinancialState.Name = "lnkFinancialState"
        Me.lnkFinancialState.Size = New System.Drawing.Size(147, 13)
        Me.lnkFinancialState.TabIndex = 256
        Me.lnkFinancialState.TabStop = True
        Me.lnkFinancialState.Text = "Check Patient Financial State"
        '
        'PanMail
        '
        Me.PanMail.Controls.Add(Me.mnuMail)
        Me.PanMail.Location = New System.Drawing.Point(2, 0)
        Me.PanMail.Name = "PanMail"
        Me.PanMail.Size = New System.Drawing.Size(157, 20)
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
        Me.cmdClose.Location = New System.Drawing.Point(516, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(60, 39)
        Me.cmdClose.TabIndex = 251
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(455, 0)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(60, 39)
        Me.cmdOk.TabIndex = 250
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'PanDetails
        '
        Me.PanDetails.Controls.Add(Me.cServiceID)
        Me.PanDetails.Controls.Add(Me.Label9)
        Me.PanDetails.Controls.Add(Me.Label6)
        Me.PanDetails.Controls.Add(Me.Label5)
        Me.PanDetails.Controls.Add(Me.PanCommands)
        Me.PanDetails.Controls.Add(Me.tAmount)
        Me.PanDetails.Controls.Add(Me.tServiceName)
        Me.PanDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanDetails.Location = New System.Drawing.Point(449, 249)
        Me.PanDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.PanDetails.Name = "PanDetails"
        Me.PanDetails.Size = New System.Drawing.Size(579, 56)
        Me.PanDetails.TabIndex = 59
        '
        'cServiceID
        '
        Me.cServiceID.FormattingEnabled = True
        Me.cServiceID.Location = New System.Drawing.Point(2, 20)
        Me.cServiceID.Name = "cServiceID"
        Me.cServiceID.Size = New System.Drawing.Size(95, 21)
        Me.cServiceID.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(299, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 256
        Me.Label9.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 255
        Me.Label6.Text = "Service Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 254
        Me.Label5.Text = "Service ID"
        '
        'PanCommands
        '
        Me.PanCommands.Controls.Add(Me.mnuCut)
        Me.PanCommands.Controls.Add(Me.mnuOpen)
        Me.PanCommands.Controls.Add(Me.mnuInsert)
        Me.PanCommands.Location = New System.Drawing.Point(376, 14)
        Me.PanCommands.Name = "PanCommands"
        Me.PanCommands.Size = New System.Drawing.Size(84, 26)
        Me.PanCommands.TabIndex = 253
        '
        'mnuCut
        '
        Me.mnuCut.Image = Global.ApexMedic.My.Resources.Resources.CUT
        Me.mnuCut.Location = New System.Drawing.Point(57, 0)
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(26, 25)
        Me.mnuCut.TabIndex = 7
        Me.mnuCut.Text = "..."
        Me.mnuCut.UseVisualStyleBackColor = True
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = Global.ApexMedic.My.Resources.Resources.OPEN
        Me.mnuOpen.Location = New System.Drawing.Point(32, 0)
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(26, 25)
        Me.mnuOpen.TabIndex = 6
        Me.mnuOpen.Text = "..."
        Me.mnuOpen.UseVisualStyleBackColor = True
        '
        'mnuInsert
        '
        Me.mnuInsert.Image = Global.ApexMedic.My.Resources.Resources.NEW1
        Me.mnuInsert.Location = New System.Drawing.Point(7, 0)
        Me.mnuInsert.Name = "mnuInsert"
        Me.mnuInsert.Size = New System.Drawing.Size(26, 25)
        Me.mnuInsert.TabIndex = 5
        Me.mnuInsert.UseVisualStyleBackColor = True
        '
        'tAmount
        '
        Me.tAmount.Location = New System.Drawing.Point(301, 20)
        Me.tAmount.Name = "tAmount"
        Me.tAmount.Size = New System.Drawing.Size(73, 20)
        Me.tAmount.TabIndex = 4
        '
        'tServiceName
        '
        Me.tServiceName.Location = New System.Drawing.Point(101, 20)
        Me.tServiceName.Name = "tServiceName"
        Me.tServiceName.ReadOnly = True
        Me.tServiceName.Size = New System.Drawing.Size(197, 20)
        Me.tServiceName.TabIndex = 46
        Me.tServiceName.TabStop = False
        '
        'lvList
        '
        Me.lvList.BackColor = System.Drawing.Color.GhostWhite
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        Me.lvList.Location = New System.Drawing.Point(452, 305)
        Me.lvList.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.lvList.MultiSelect = False
        Me.lvList.Name = "lvList"
        Me.lvList.ShowItemToolTips = True
        Me.lvList.Size = New System.Drawing.Size(573, 238)
        Me.lvList.TabIndex = 237
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sn"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ServiceID"
        Me.ColumnHeader2.Width = 69
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Service Description"
        Me.ColumnHeader3.Width = 350
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 110
        '
        'PanTotal
        '
        Me.PanTotal.Controls.Add(Me.tAmtInWords)
        Me.PanTotal.Controls.Add(Me.tTotal)
        Me.PanTotal.Controls.Add(Me.Label10)
        Me.PanTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanTotal.Location = New System.Drawing.Point(452, 546)
        Me.PanTotal.Name = "PanTotal"
        Me.PanTotal.Size = New System.Drawing.Size(573, 19)
        Me.PanTotal.TabIndex = 238
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
        Me.tAmtInWords.Size = New System.Drawing.Size(392, 19)
        Me.tAmtInWords.TabIndex = 48
        Me.tAmtInWords.TabStop = False
        '
        'tTotal
        '
        Me.tTotal.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.tTotal.ForeColor = System.Drawing.Color.Black
        Me.tTotal.Location = New System.Drawing.Point(474, 0)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.ReadOnly = True
        Me.tTotal.Size = New System.Drawing.Size(99, 20)
        Me.tTotal.TabIndex = 47
        Me.tTotal.TabStop = False
        Me.tTotal.Text = "0"
        Me.tTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(412, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "TOTAL:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lvAppointment, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 58)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel2, 5)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(443, 507)
        Me.TableLayoutPanel2.TabIndex = 241
        '
        'lvAppointment
        '
        Me.lvAppointment.BackColor = System.Drawing.Color.LemonChiffon
        Me.lvAppointment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader16})
        Me.lvAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAppointment.FullRowSelect = True
        Me.lvAppointment.GridLines = True
        Me.lvAppointment.HideSelection = False
        Me.lvAppointment.Location = New System.Drawing.Point(0, 38)
        Me.lvAppointment.Margin = New System.Windows.Forms.Padding(0)
        Me.lvAppointment.MultiSelect = False
        Me.lvAppointment.Name = "lvAppointment"
        Me.lvAppointment.Size = New System.Drawing.Size(443, 469)
        Me.lvAppointment.TabIndex = 14
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
        Me.ColumnHeader12.Width = 99
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Othernames"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Account"
        Me.ColumnHeader14.Width = 127
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Sex"
        Me.ColumnHeader16.Width = 47
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdRefresh)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 38)
        Me.Panel1.TabIndex = 13
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.Color.Black
        Me.cmdRefresh.Location = New System.Drawing.Point(383, 0)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(60, 38)
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
        Me.Label20.Size = New System.Drawing.Size(443, 38)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Patients with Bills"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimBill
        '
        Me.TimBill.Enabled = True
        Me.TimBill.Interval = 100000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReconcile, Me.tStartDate, Me.tEndDate})
        Me.MenuStrip1.Location = New System.Drawing.Point(119, 27)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(245, 26)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuReconcile
        '
        Me.mnuReconcile.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuReconcile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuReconcile.Name = "mnuReconcile"
        Me.mnuReconcile.Size = New System.Drawing.Size(73, 22)
        Me.mnuReconcile.Text = "Reconcile"
        '
        'tStartDate
        '
        Me.tStartDate.BackColor = System.Drawing.Color.SteelBlue
        Me.tStartDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStartDate.ForeColor = System.Drawing.Color.Red
        Me.tStartDate.Name = "tStartDate"
        Me.tStartDate.Size = New System.Drawing.Size(80, 22)
        '
        'tEndDate
        '
        Me.tEndDate.BackColor = System.Drawing.Color.SteelBlue
        Me.tEndDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tEndDate.ForeColor = System.Drawing.Color.Red
        Me.tEndDate.Name = "tEndDate"
        Me.tEndDate.Size = New System.Drawing.Size(80, 22)
        '
        'FrmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1028, 568)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPayment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.PanMainCommand.ResumeLayout(False)
        Me.PanMainCommand.PerformLayout()
        Me.PanCopies.ResumeLayout(False)
        Me.PanCopies.PerformLayout()
        Me.mnuBillLoad.ResumeLayout(False)
        Me.mnuBillLoad.PerformLayout()
        Me.PanMail.ResumeLayout(False)
        Me.PanMail.PerformLayout()
        Me.PanDetails.ResumeLayout(False)
        Me.PanDetails.PerformLayout()
        Me.PanCommands.ResumeLayout(False)
        Me.PanTotal.ResumeLayout(False)
        Me.PanTotal.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
    Friend WithEvents PanMail As System.Windows.Forms.Panel
    Friend WithEvents mnuMail As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents tAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tRecNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents PanDetails As System.Windows.Forms.Panel
    Friend WithEvents cServiceID As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PanCommands As System.Windows.Forms.Panel
    Friend WithEvents mnuCut As System.Windows.Forms.Button
    Friend WithEvents mnuOpen As System.Windows.Forms.Button
    Friend WithEvents mnuInsert As System.Windows.Forms.Button
    Friend WithEvents tAmount As System.Windows.Forms.TextBox
    Friend WithEvents tServiceName As System.Windows.Forms.TextBox
    Friend WithEvents PanTotal As System.Windows.Forms.Panel
    Friend WithEvents tAmtInWords As System.Windows.Forms.TextBox
    Friend WithEvents tTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tChqDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cPayMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lnkFinancialState As System.Windows.Forms.LinkLabel
    Friend WithEvents mnuBillLoad As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuLoadBill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lvAppointment As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimBill As System.Windows.Forms.Timer
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents chkPrintReceipt As System.Windows.Forms.CheckBox
    Friend WithEvents PanCopies As System.Windows.Forms.Panel
    Friend WithEvents tCopies As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmdUnRegistered As System.Windows.Forms.Button
    Friend WithEvents tSourceDocNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuReconcile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tStartDate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tEndDate As System.Windows.Forms.ToolStripTextBox
End Class
