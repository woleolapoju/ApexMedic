<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdhocFinancialState
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdhocFinancialState))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.lvList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.PanPatient = New System.Windows.Forms.Panel
        Me.tAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.NumPeriod = New System.Windows.Forms.NumericUpDown
        Me.Label11 = New System.Windows.Forms.Label
        Me.cPayType = New System.Windows.Forms.ComboBox
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanAccount = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tAccountName = New System.Windows.Forms.TextBox
        Me.cmdAccount = New System.Windows.Forms.Button
        Me.tAccountCode = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.PanDetails = New System.Windows.Forms.Panel
        Me.mnuPrint = New System.Windows.Forms.MenuStrip
        Me.mnuPrintResult = New System.Windows.Forms.ToolStripMenuItem
        Me.lblInDebt = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.tBalance = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdUnRegistered = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanMainCommand.SuspendLayout()
        Me.PanPatient.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.NumPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAccount.SuspendLayout()
        Me.PanDetails.SuspendLayout()
        Me.mnuPrint.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(453, 524)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'PanMainCommand
        '
        Me.PanMainCommand.Controls.Add(Me.lvList)
        Me.PanMainCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMainCommand.Location = New System.Drawing.Point(0, 195)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(453, 329)
        Me.PanMainCommand.TabIndex = 243
        '
        'lvList
        '
        Me.lvList.BackColor = System.Drawing.Color.GhostWhite
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvList.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        Me.lvList.HideSelection = False
        Me.lvList.Location = New System.Drawing.Point(0, 0)
        Me.lvList.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.lvList.MultiSelect = False
        Me.lvList.Name = "lvList"
        Me.lvList.ShowItemToolTips = True
        Me.lvList.Size = New System.Drawing.Size(453, 329)
        Me.lvList.TabIndex = 237
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sn"
        Me.ColumnHeader1.Width = 23
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Ref No."
        Me.ColumnHeader7.Width = 53
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 67
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ServiceID"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Service Description"
        Me.ColumnHeader4.Width = 146
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Bills"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 75
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Payment"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 79
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
        Me.PanPatient.Size = New System.Drawing.Size(453, 50)
        Me.PanPatient.TabIndex = 57
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(85, 23)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(365, 20)
        Me.tAccount.TabIndex = 51
        Me.tAccount.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(2, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Account:"
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(225, 0)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(225, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(169, 0)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 7
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(85, 1)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(84, 20)
        Me.tPatientNo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Patient No:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.NumPeriod)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.cPayType)
        Me.Panel3.Controls.Add(Me.dtpDate)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 58)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(453, 27)
        Me.Panel3.TabIndex = 239
        '
        'NumPeriod
        '
        Me.NumPeriod.Location = New System.Drawing.Point(414, 4)
        Me.NumPeriod.Name = "NumPeriod"
        Me.NumPeriod.Size = New System.Drawing.Size(37, 20)
        Me.NumPeriod.TabIndex = 256
        Me.NumPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumPeriod.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 255
        Me.Label11.Text = "Account Type:"
        '
        'cPayType
        '
        Me.cPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPayType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cPayType.FormattingEnabled = True
        Me.cPayType.Items.AddRange(New Object() {"Individual", "Corporate"})
        Me.cPayType.Location = New System.Drawing.Point(85, 6)
        Me.cPayType.Name = "cPayType"
        Me.cPayType.Size = New System.Drawing.Size(85, 21)
        Me.cPayType.TabIndex = 4
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(328, 3)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(84, 20)
        Me.dtpDate.TabIndex = 2
        Me.dtpDate.Tag = "RegDate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Date/Period:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tblHeader)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 49)
        Me.Panel2.TabIndex = 240
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.Controls.Add(Me.Label7, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label8, 1, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.Size = New System.Drawing.Size(447, 49)
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
        Me.Label7.Size = New System.Drawing.Size(336, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "FINANCIAL STATE"
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
        Me.Label8.Size = New System.Drawing.Size(336, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Computes Individual/Corporate Financial State"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAccount
        '
        Me.PanAccount.Controls.Add(Me.GroupBox1)
        Me.PanAccount.Controls.Add(Me.tAccountName)
        Me.PanAccount.Controls.Add(Me.cmdAccount)
        Me.PanAccount.Controls.Add(Me.tAccountCode)
        Me.PanAccount.Controls.Add(Me.Label12)
        Me.PanAccount.Location = New System.Drawing.Point(0, 135)
        Me.PanAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAccount.Name = "PanAccount"
        Me.PanAccount.Size = New System.Drawing.Size(450, 24)
        Me.PanAccount.TabIndex = 241
        Me.PanAccount.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(1, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 3)
        Me.GroupBox1.TabIndex = 253
        Me.GroupBox1.TabStop = False
        '
        'tAccountName
        '
        Me.tAccountName.Location = New System.Drawing.Point(196, 2)
        Me.tAccountName.Name = "tAccountName"
        Me.tAccountName.ReadOnly = True
        Me.tAccountName.Size = New System.Drawing.Size(254, 20)
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
        Me.PanDetails.BackColor = System.Drawing.Color.LightYellow
        Me.PanDetails.Controls.Add(Me.mnuPrint)
        Me.PanDetails.Controls.Add(Me.lblInDebt)
        Me.PanDetails.Controls.Add(Me.cmdClose)
        Me.PanDetails.Controls.Add(Me.cmdOk)
        Me.PanDetails.Controls.Add(Me.tBalance)
        Me.PanDetails.Controls.Add(Me.Label5)
        Me.PanDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanDetails.Location = New System.Drawing.Point(0, 159)
        Me.PanDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.PanDetails.Name = "PanDetails"
        Me.PanDetails.Size = New System.Drawing.Size(453, 36)
        Me.PanDetails.TabIndex = 242
        '
        'mnuPrint
        '
        Me.mnuPrint.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.mnuPrint.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuPrint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintResult})
        Me.mnuPrint.Location = New System.Drawing.Point(218, 6)
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(54, 24)
        Me.mnuPrint.TabIndex = 257
        Me.mnuPrint.Text = "MenuStrip1"
        '
        'mnuPrintResult
        '
        Me.mnuPrintResult.BackColor = System.Drawing.Color.Transparent
        Me.mnuPrintResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPrintResult.ForeColor = System.Drawing.Color.Brown
        Me.mnuPrintResult.Name = "mnuPrintResult"
        Me.mnuPrintResult.Size = New System.Drawing.Size(46, 20)
        Me.mnuPrintResult.Text = "Print"
        '
        'lblInDebt
        '
        Me.lblInDebt.AutoSize = True
        Me.lblInDebt.ForeColor = System.Drawing.Color.Red
        Me.lblInDebt.Location = New System.Drawing.Point(171, 11)
        Me.lblInDebt.Name = "lblInDebt"
        Me.lblInDebt.Size = New System.Drawing.Size(42, 13)
        Me.lblInDebt.TabIndex = 252
        Me.lblInDebt.Text = "In Debt"
        Me.lblInDebt.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(389, 2)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(60, 31)
        Me.cmdClose.TabIndex = 251
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(328, 2)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(60, 32)
        Me.cmdOk.TabIndex = 250
        Me.cmdOk.Text = "&Generate"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'tBalance
        '
        Me.tBalance.Location = New System.Drawing.Point(85, 7)
        Me.tBalance.Name = "tBalance"
        Me.tBalance.ReadOnly = True
        Me.tBalance.Size = New System.Drawing.Size(85, 20)
        Me.tBalance.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Balance:"
        '
        'cmdUnRegistered
        '
        Me.cmdUnRegistered.Location = New System.Drawing.Point(194, 0)
        Me.cmdUnRegistered.Name = "cmdUnRegistered"
        Me.cmdUnRegistered.Size = New System.Drawing.Size(31, 21)
        Me.cmdUnRegistered.TabIndex = 64
        Me.cmdUnRegistered.Text = "OP"
        Me.cmdUnRegistered.UseVisualStyleBackColor = True
        '
        'FrmAdhocFinancialState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(453, 524)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdhocFinancialState"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adhoc Financial State"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanMainCommand.ResumeLayout(False)
        Me.PanPatient.ResumeLayout(False)
        Me.PanPatient.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NumPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanAccount.ResumeLayout(False)
        Me.PanAccount.PerformLayout()
        Me.PanDetails.ResumeLayout(False)
        Me.PanDetails.PerformLayout()
        Me.mnuPrint.ResumeLayout(False)
        Me.mnuPrint.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PanAccount As System.Windows.Forms.Panel
    Friend WithEvents tAccountName As System.Windows.Forms.TextBox
    Friend WithEvents cmdAccount As System.Windows.Forms.Button
    Friend WithEvents tAccountCode As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanDetails As System.Windows.Forms.Panel
    Friend WithEvents lblInDebt As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents tBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NumPeriod As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuPrintResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdUnRegistered As System.Windows.Forms.Button
End Class
