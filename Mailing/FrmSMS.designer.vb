<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSMS))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnConnect = New System.Windows.Forms.Button
        Me.btnDisconnect = New System.Windows.Forms.Button
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSendMessage4Appointments = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.tFlowControl = New System.Windows.Forms.TextBox
        Me.tStopBit = New System.Windows.Forms.TextBox
        Me.tDataBit = New System.Windows.Forms.TextBox
        Me.tBaudRate = New System.Windows.Forms.TextBox
        Me.tComPort = New System.Windows.Forms.TextBox
        Me.btnSendClass2Msg = New System.Windows.Forms.Button
        Me.btnCheckPhone = New System.Windows.Forms.Button
        Me.txtStorage = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnSendMsg = New System.Windows.Forms.Button
        Me.tSMSMessage = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.tblOnappointment = New System.Windows.Forms.TableLayoutPanel
        Me.lvAppointment = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tblOnappointment.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COM Port: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Baud Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data Bit:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Stop Bit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Flow Control:"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(124, 245)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(179, 23)
        Me.btnConnect.TabIndex = 10
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(65, 110)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(74, 23)
        Me.btnDisconnect.TabIndex = 12
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 26)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(81, 13)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "Phone Number:"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(103, 24)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(182, 20)
        Me.txtPhoneNumber.TabIndex = 13
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(17, 57)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 13)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Message:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSendMessage4Appointments)
        Me.GroupBox2.Controls.Add(Me.cmdClose)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.btnSendClass2Msg)
        Me.GroupBox2.Controls.Add(Me.btnConnect)
        Me.GroupBox2.Controls.Add(Me.btnCheckPhone)
        Me.GroupBox2.Controls.Add(Me.txtStorage)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btnSendMsg)
        Me.GroupBox2.Controls.Add(Me.tSMSMessage)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(281, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 429)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'btnSendMessage4Appointments
        '
        Me.btnSendMessage4Appointments.Enabled = False
        Me.btnSendMessage4Appointments.Location = New System.Drawing.Point(123, 341)
        Me.btnSendMessage4Appointments.Name = "btnSendMessage4Appointments"
        Me.btnSendMessage4Appointments.Size = New System.Drawing.Size(182, 23)
        Me.btnSendMessage4Appointments.TabIndex = 34
        Me.btnSendMessage4Appointments.Text = "Send Message"
        Me.btnSendMessage4Appointments.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(311, 253)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(48, 100)
        Me.cmdClose.TabIndex = 33
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tFlowControl)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnDisconnect)
        Me.Panel1.Controls.Add(Me.tStopBit)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tDataBit)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tBaudRate)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tComPort)
        Me.Panel1.Location = New System.Drawing.Point(5, 250)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 142)
        Me.Panel1.TabIndex = 16
        Me.Panel1.Visible = False
        '
        'tFlowControl
        '
        Me.tFlowControl.Location = New System.Drawing.Point(71, 86)
        Me.tFlowControl.Name = "tFlowControl"
        Me.tFlowControl.ReadOnly = True
        Me.tFlowControl.Size = New System.Drawing.Size(58, 20)
        Me.tFlowControl.TabIndex = 19
        '
        'tStopBit
        '
        Me.tStopBit.Location = New System.Drawing.Point(71, 65)
        Me.tStopBit.Name = "tStopBit"
        Me.tStopBit.ReadOnly = True
        Me.tStopBit.Size = New System.Drawing.Size(58, 20)
        Me.tStopBit.TabIndex = 18
        '
        'tDataBit
        '
        Me.tDataBit.Location = New System.Drawing.Point(71, 44)
        Me.tDataBit.Name = "tDataBit"
        Me.tDataBit.ReadOnly = True
        Me.tDataBit.Size = New System.Drawing.Size(58, 20)
        Me.tDataBit.TabIndex = 17
        '
        'tBaudRate
        '
        Me.tBaudRate.Location = New System.Drawing.Point(71, 23)
        Me.tBaudRate.Name = "tBaudRate"
        Me.tBaudRate.ReadOnly = True
        Me.tBaudRate.Size = New System.Drawing.Size(58, 20)
        Me.tBaudRate.TabIndex = 16
        '
        'tComPort
        '
        Me.tComPort.Location = New System.Drawing.Point(71, 2)
        Me.tComPort.Name = "tComPort"
        Me.tComPort.ReadOnly = True
        Me.tComPort.Size = New System.Drawing.Size(58, 20)
        Me.tComPort.TabIndex = 14
        '
        'btnSendClass2Msg
        '
        Me.btnSendClass2Msg.Enabled = False
        Me.btnSendClass2Msg.Location = New System.Drawing.Point(123, 330)
        Me.btnSendClass2Msg.Name = "btnSendClass2Msg"
        Me.btnSendClass2Msg.Size = New System.Drawing.Size(182, 23)
        Me.btnSendClass2Msg.TabIndex = 32
        Me.btnSendClass2Msg.Text = "Send Message"
        Me.btnSendClass2Msg.UseVisualStyleBackColor = True
        '
        'btnCheckPhone
        '
        Me.btnCheckPhone.Enabled = False
        Me.btnCheckPhone.Location = New System.Drawing.Point(123, 268)
        Me.btnCheckPhone.Name = "btnCheckPhone"
        Me.btnCheckPhone.Size = New System.Drawing.Size(182, 23)
        Me.btnCheckPhone.TabIndex = 31
        Me.btnCheckPhone.Text = "Check Phone"
        Me.btnCheckPhone.UseVisualStyleBackColor = True
        '
        'txtStorage
        '
        Me.txtStorage.Location = New System.Drawing.Point(104, 218)
        Me.txtStorage.Name = "txtStorage"
        Me.txtStorage.ReadOnly = True
        Me.txtStorage.Size = New System.Drawing.Size(193, 20)
        Me.txtStorage.TabIndex = 30
        Me.txtStorage.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Storage:"
        Me.Label13.Visible = False
        '
        'btnSendMsg
        '
        Me.btnSendMsg.Location = New System.Drawing.Point(123, 292)
        Me.btnSendMsg.Name = "btnSendMsg"
        Me.btnSendMsg.Size = New System.Drawing.Size(182, 23)
        Me.btnSendMsg.TabIndex = 13
        Me.btnSendMsg.Text = "Send Message"
        Me.btnSendMsg.UseVisualStyleBackColor = True
        '
        'tSMSMessage
        '
        Me.tSMSMessage.BackColor = System.Drawing.Color.White
        Me.tSMSMessage.Location = New System.Drawing.Point(103, 57)
        Me.tSMSMessage.Multiline = True
        Me.tSMSMessage.Name = "tSMSMessage"
        Me.tSMSMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tSMSMessage.Size = New System.Drawing.Size(248, 154)
        Me.tSMSMessage.TabIndex = 15
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tblHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(652, 501)
        Me.TableLayoutPanel1.TabIndex = 15
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
        Me.tblHeader.Size = New System.Drawing.Size(652, 60)
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
        Me.Label7.Size = New System.Drawing.Size(572, 33)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "SMS"
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
        Me.PictureBox1.Size = New System.Drawing.Size(80, 60)
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
        Me.Label8.Location = New System.Drawing.Point(80, 33)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(572, 27)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Manages SMS Sending and Receiving"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tblOnappointment, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 63)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(646, 435)
        Me.TableLayoutPanel2.TabIndex = 52
        '
        'tblOnappointment
        '
        Me.tblOnappointment.ColumnCount = 1
        Me.tblOnappointment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblOnappointment.Controls.Add(Me.lvAppointment, 0, 1)
        Me.tblOnappointment.Controls.Add(Me.Panel2, 0, 0)
        Me.tblOnappointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblOnappointment.Location = New System.Drawing.Point(3, 3)
        Me.tblOnappointment.Name = "tblOnappointment"
        Me.tblOnappointment.RowCount = 2
        Me.tblOnappointment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.594406!))
        Me.tblOnappointment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.40559!))
        Me.tblOnappointment.Size = New System.Drawing.Size(272, 429)
        Me.tblOnappointment.TabIndex = 12
        '
        'lvAppointment
        '
        Me.lvAppointment.BackColor = System.Drawing.Color.GhostWhite
        Me.lvAppointment.CheckBoxes = True
        Me.lvAppointment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAppointment.FullRowSelect = True
        Me.lvAppointment.GridLines = True
        Me.lvAppointment.HideSelection = False
        Me.lvAppointment.Location = New System.Drawing.Point(3, 27)
        Me.lvAppointment.MultiSelect = False
        Me.lvAppointment.Name = "lvAppointment"
        Me.lvAppointment.Size = New System.Drawing.Size(266, 399)
        Me.lvAppointment.TabIndex = 4
        Me.lvAppointment.UseCompatibleStateImageBehavior = False
        Me.lvAppointment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Reg. No"
        Me.ColumnHeader7.Width = 57
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Full Name"
        Me.ColumnHeader8.Width = 116
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Phone"
        Me.ColumnHeader9.Width = 97
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkAll)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dtpDate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(266, 18)
        Me.Panel2.TabIndex = 5
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAll.ForeColor = System.Drawing.Color.Red
        Me.chkAll.Location = New System.Drawing.Point(1, 1)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(73, 16)
        Me.chkAll.TabIndex = 33
        Me.chkAll.Text = "Check All"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Appointment date:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(171, -1)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(93, 20)
        Me.dtpDate.TabIndex = 1
        '
        'FrmSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(652, 501)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSMS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.tblOnappointment.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tSMSMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnSendMsg As System.Windows.Forms.Button
    Friend WithEvents txtStorage As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnCheckPhone As System.Windows.Forms.Button
    Friend WithEvents btnSendClass2Msg As System.Windows.Forms.Button
    Friend WithEvents tComPort As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tFlowControl As System.Windows.Forms.TextBox
    Friend WithEvents tStopBit As System.Windows.Forms.TextBox
    Friend WithEvents tDataBit As System.Windows.Forms.TextBox
    Friend WithEvents tBaudRate As System.Windows.Forms.TextBox
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblOnappointment As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvAppointment As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents btnSendMessage4Appointments As System.Windows.Forms.Button

End Class
