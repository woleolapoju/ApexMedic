<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRequisition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRequisition))
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel
        Me.PanCommands = New System.Windows.Forms.Panel
        Me.tDuration = New System.Windows.Forms.TextBox
        Me.tMedication = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.mnuCut = New System.Windows.Forms.Button
        Me.mnuOpen = New System.Windows.Forms.Button
        Me.mnuInsert = New System.Windows.Forms.Button
        Me.lvMedication = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.RadStaffTreatment = New System.Windows.Forms.RadioButton
        Me.RadHospitalUse = New System.Windows.Forms.RadioButton
        Me.PanMail = New System.Windows.Forms.Panel
        Me.mnuMail = New System.Windows.Forms.CheckBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cDept = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboStaff = New System.Windows.Forms.ComboBox
        Me.lblStaff = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.tRefNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.PanCommands.SuspendLayout()
        Me.PanHeading.SuspendLayout()
        Me.PanMail.SuspendLayout()
        Me.SuspendLayout()
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
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.Size = New System.Drawing.Size(520, 59)
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
        Me.Label7.Location = New System.Drawing.Point(111, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "DRUGS REQUISITION"
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
        Me.PictureBox1.Size = New System.Drawing.Size(111, 59)
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
        Me.Label8.Location = New System.Drawing.Point(111, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Maintains Drug Request"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAction.Location = New System.Drawing.Point(315, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(205, 59)
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
        Me.lblAction.Size = New System.Drawing.Size(191, 19)
        Me.lblAction.TabIndex = 11
        Me.lblAction.Text = "?"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanHeading, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 59)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(520, 378)
        Me.TableLayoutPanel1.TabIndex = 236
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.PanCommands, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lvMedication, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 147)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(514, 228)
        Me.TableLayoutPanel7.TabIndex = 59
        '
        'PanCommands
        '
        Me.PanCommands.BackColor = System.Drawing.Color.LightYellow
        Me.PanCommands.Controls.Add(Me.tDuration)
        Me.PanCommands.Controls.Add(Me.tMedication)
        Me.PanCommands.Controls.Add(Me.Label14)
        Me.PanCommands.Controls.Add(Me.mnuCut)
        Me.PanCommands.Controls.Add(Me.mnuOpen)
        Me.PanCommands.Controls.Add(Me.mnuInsert)
        Me.PanCommands.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCommands.Location = New System.Drawing.Point(0, 0)
        Me.PanCommands.Margin = New System.Windows.Forms.Padding(0)
        Me.PanCommands.Name = "PanCommands"
        Me.PanCommands.Size = New System.Drawing.Size(514, 26)
        Me.PanCommands.TabIndex = 253
        '
        'tDuration
        '
        Me.tDuration.Location = New System.Drawing.Point(338, 3)
        Me.tDuration.Name = "tDuration"
        Me.tDuration.Size = New System.Drawing.Size(95, 20)
        Me.tDuration.TabIndex = 13
        '
        'tMedication
        '
        Me.tMedication.Location = New System.Drawing.Point(108, 3)
        Me.tMedication.Name = "tMedication"
        Me.tMedication.Size = New System.Drawing.Size(229, 20)
        Me.tMedication.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(2, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Medication/Dosage:"
        '
        'mnuCut
        '
        Me.mnuCut.Image = Global.ApexMedic.My.Resources.Resources.CUT
        Me.mnuCut.Location = New System.Drawing.Point(486, 1)
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(26, 25)
        Me.mnuCut.TabIndex = 10
        Me.mnuCut.Text = "..."
        Me.mnuCut.UseVisualStyleBackColor = True
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = Global.ApexMedic.My.Resources.Resources.OPEN
        Me.mnuOpen.Location = New System.Drawing.Point(461, 1)
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(26, 25)
        Me.mnuOpen.TabIndex = 9
        Me.mnuOpen.Text = "..."
        Me.mnuOpen.UseVisualStyleBackColor = True
        '
        'mnuInsert
        '
        Me.mnuInsert.Image = Global.ApexMedic.My.Resources.Resources.NEW1
        Me.mnuInsert.Location = New System.Drawing.Point(436, 1)
        Me.mnuInsert.Name = "mnuInsert"
        Me.mnuInsert.Size = New System.Drawing.Size(26, 25)
        Me.mnuInsert.TabIndex = 8
        Me.mnuInsert.UseVisualStyleBackColor = True
        '
        'lvMedication
        '
        Me.lvMedication.BackColor = System.Drawing.Color.GhostWhite
        Me.lvMedication.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader19, Me.ColumnHeader20})
        Me.lvMedication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMedication.FullRowSelect = True
        Me.lvMedication.GridLines = True
        Me.lvMedication.HideSelection = False
        Me.lvMedication.Location = New System.Drawing.Point(3, 29)
        Me.lvMedication.MultiSelect = False
        Me.lvMedication.Name = "lvMedication"
        Me.lvMedication.Size = New System.Drawing.Size(508, 196)
        Me.lvMedication.TabIndex = 5
        Me.lvMedication.UseCompatibleStateImageBehavior = False
        Me.lvMedication.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Sn"
        Me.ColumnHeader13.Width = 29
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Medication"
        Me.ColumnHeader19.Width = 296
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Dosage"
        Me.ColumnHeader20.Width = 161
        '
        'PanHeading
        '
        Me.PanHeading.Controls.Add(Me.RadStaffTreatment)
        Me.PanHeading.Controls.Add(Me.RadHospitalUse)
        Me.PanHeading.Controls.Add(Me.PanMail)
        Me.PanHeading.Controls.Add(Me.cmdClose)
        Me.PanHeading.Controls.Add(Me.cmdOk)
        Me.PanHeading.Controls.Add(Me.cDept)
        Me.PanHeading.Controls.Add(Me.Label11)
        Me.PanHeading.Controls.Add(Me.cboStaff)
        Me.PanHeading.Controls.Add(Me.lblStaff)
        Me.PanHeading.Controls.Add(Me.dtpDate)
        Me.PanHeading.Controls.Add(Me.tRefNo)
        Me.PanHeading.Controls.Add(Me.Label6)
        Me.PanHeading.Controls.Add(Me.Label2)
        Me.PanHeading.Location = New System.Drawing.Point(3, 3)
        Me.PanHeading.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(514, 141)
        Me.PanHeading.TabIndex = 58
        '
        'RadStaffTreatment
        '
        Me.RadStaffTreatment.AutoSize = True
        Me.RadStaffTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadStaffTreatment.ForeColor = System.Drawing.Color.DarkRed
        Me.RadStaffTreatment.Location = New System.Drawing.Point(396, 4)
        Me.RadStaffTreatment.Name = "RadStaffTreatment"
        Me.RadStaffTreatment.Size = New System.Drawing.Size(113, 17)
        Me.RadStaffTreatment.TabIndex = 256
        Me.RadStaffTreatment.Text = "Staff Treatment"
        Me.RadStaffTreatment.UseVisualStyleBackColor = True
        '
        'RadHospitalUse
        '
        Me.RadHospitalUse.AutoSize = True
        Me.RadHospitalUse.Checked = True
        Me.RadHospitalUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadHospitalUse.ForeColor = System.Drawing.Color.DarkRed
        Me.RadHospitalUse.Location = New System.Drawing.Point(290, 4)
        Me.RadHospitalUse.Name = "RadHospitalUse"
        Me.RadHospitalUse.Size = New System.Drawing.Size(97, 17)
        Me.RadHospitalUse.TabIndex = 255
        Me.RadHospitalUse.TabStop = True
        Me.RadHospitalUse.Text = "Hospital Use"
        Me.RadHospitalUse.UseVisualStyleBackColor = True
        '
        'PanMail
        '
        Me.PanMail.Controls.Add(Me.mnuMail)
        Me.PanMail.Location = New System.Drawing.Point(3, 81)
        Me.PanMail.Name = "PanMail"
        Me.PanMail.Size = New System.Drawing.Size(182, 20)
        Me.PanMail.TabIndex = 254
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
        Me.cmdClose.Location = New System.Drawing.Point(441, 78)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(70, 58)
        Me.cmdClose.TabIndex = 253
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(370, 79)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(70, 57)
        Me.cmdOk.TabIndex = 252
        Me.cmdOk.Text = "O&k"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cDept
        '
        Me.cDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cDept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cDept.FormattingEnabled = True
        Me.cDept.Location = New System.Drawing.Point(290, 22)
        Me.cDept.Name = "cDept"
        Me.cDept.Size = New System.Drawing.Size(221, 21)
        Me.cDept.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(213, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Department:"
        '
        'cboStaff
        '
        Me.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboStaff.FormattingEnabled = True
        Me.cboStaff.Location = New System.Drawing.Point(290, 46)
        Me.cboStaff.Name = "cboStaff"
        Me.cboStaff.Size = New System.Drawing.Size(221, 21)
        Me.cboStaff.TabIndex = 62
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.Location = New System.Drawing.Point(213, 50)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(77, 13)
        Me.lblStaff.TabIndex = 56
        Me.lblStaff.Text = "Requested By:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(79, 32)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(111, 20)
        Me.dtpDate.TabIndex = 2
        Me.dtpDate.Tag = "RegDate"
        '
        'tRefNo
        '
        Me.tRefNo.Location = New System.Drawing.Point(80, 10)
        Me.tRefNo.Name = "tRefNo"
        Me.tRefNo.ReadOnly = True
        Me.tRefNo.Size = New System.Drawing.Size(109, 20)
        Me.tRefNo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Requisition No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Date:"
        '
        'FrmRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 437)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRequisition"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Drug Requisition"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.PanCommands.ResumeLayout(False)
        Me.PanCommands.PerformLayout()
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.PanMail.ResumeLayout(False)
        Me.PanMail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents cDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboStaff As System.Windows.Forms.ComboBox
    Friend WithEvents lblStaff As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanCommands As System.Windows.Forms.Panel
    Friend WithEvents tDuration As System.Windows.Forms.TextBox
    Friend WithEvents tMedication As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents mnuCut As System.Windows.Forms.Button
    Friend WithEvents mnuOpen As System.Windows.Forms.Button
    Friend WithEvents mnuInsert As System.Windows.Forms.Button
    Friend WithEvents lvMedication As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents PanMail As System.Windows.Forms.Panel
    Friend WithEvents mnuMail As System.Windows.Forms.CheckBox
    Friend WithEvents RadStaffTreatment As System.Windows.Forms.RadioButton
    Friend WithEvents RadHospitalUse As System.Windows.Forms.RadioButton
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
End Class
