<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeath
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDeath))
        Me.PanHeading = New System.Windows.Forms.Panel
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
        Me.cmdConfirmedBy = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tMedicalTeam = New System.Windows.Forms.TextBox
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tPerformedBy = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpPostDate = New System.Windows.Forms.DateTimePicker
        Me.cmdPerformedBy = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.PanAction = New System.Windows.Forms.FlowLayoutPanel
        Me.mnuAction = New System.Windows.Forms.MenuStrip
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBrowse = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.lblAction = New System.Windows.Forms.Label
        Me.PanHeading.SuspendLayout()
        Me.PanMainCommand.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanHeading
        '
        Me.PanHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.PanHeading.Location = New System.Drawing.Point(2, 61)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(433, 73)
        Me.PanHeading.TabIndex = 242
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(102, 47)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(326, 20)
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
        Me.tPatientName.Size = New System.Drawing.Size(220, 20)
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
        Me.Label2.Location = New System.Drawing.Point(201, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Date of Death:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yy h.mm  tt"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(281, 2)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(146, 20)
        Me.dtpDate.TabIndex = 2
        Me.dtpDate.Tag = "RegDate"
        '
        'tRefNo
        '
        Me.tRefNo.Location = New System.Drawing.Point(102, 3)
        Me.tRefNo.Name = "tRefNo"
        Me.tRefNo.ReadOnly = True
        Me.tRefNo.Size = New System.Drawing.Size(79, 20)
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
        Me.cmdPatient.Location = New System.Drawing.Point(179, 25)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 7
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(102, 25)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(76, 20)
        Me.tPatientNo.TabIndex = 0
        '
        'cmdConfirmedBy
        '
        Me.cmdConfirmedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirmedBy.Location = New System.Drawing.Point(406, 14)
        Me.cmdConfirmedBy.Name = "cmdConfirmedBy"
        Me.cmdConfirmedBy.Size = New System.Drawing.Size(26, 21)
        Me.cmdConfirmedBy.TabIndex = 70
        Me.cmdConfirmedBy.Text = "..."
        Me.cmdConfirmedBy.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 42)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Secondary cause of death:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(102, 96)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(328, 56)
        Me.TextBox1.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 32)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Main cause of death :"
        '
        'tMedicalTeam
        '
        Me.tMedicalTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMedicalTeam.Location = New System.Drawing.Point(102, 38)
        Me.tMedicalTeam.Multiline = True
        Me.tMedicalTeam.Name = "tMedicalTeam"
        Me.tMedicalTeam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tMedicalTeam.Size = New System.Drawing.Size(328, 56)
        Me.tMedicalTeam.TabIndex = 65
        '
        'PanMainCommand
        '
        Me.PanMainCommand.BackColor = System.Drawing.Color.LightYellow
        Me.PanMainCommand.Controls.Add(Me.cmdClose)
        Me.PanMainCommand.Controls.Add(Me.cmdOk)
        Me.PanMainCommand.Location = New System.Drawing.Point(0, 408)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(435, 41)
        Me.PanMainCommand.TabIndex = 244
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Confirmed By:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdConfirmedBy)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tMedicalTeam)
        Me.GroupBox1.Controls.Add(Me.tPerformedBy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 158)
        Me.GroupBox1.TabIndex = 243
        Me.GroupBox1.TabStop = False
        '
        'tPerformedBy
        '
        Me.tPerformedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPerformedBy.Location = New System.Drawing.Point(102, 14)
        Me.tPerformedBy.Name = "tPerformedBy"
        Me.tPerformedBy.Size = New System.Drawing.Size(302, 20)
        Me.tPerformedBy.TabIndex = 62
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
        Me.Label7.Size = New System.Drawing.Size(132, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "DEATH"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(111, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Maintains Death Information"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195.0!))
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
        Me.tblHeader.Size = New System.Drawing.Size(438, 59)
        Me.tblHeader.TabIndex = 241
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.dtpPostDate)
        Me.GroupBox2.Controls.Add(Me.cmdPerformedBy)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 112)
        Me.GroupBox2.TabIndex = 245
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "POST MOTEM INFORMATION"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Notes:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(102, 60)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(326, 50)
        Me.TextBox3.TabIndex = 76
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Date:"
        '
        'dtpPostDate
        '
        Me.dtpPostDate.CustomFormat = "dd-MMM-yy h.mm  tt"
        Me.dtpPostDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPostDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPostDate.Location = New System.Drawing.Point(103, 39)
        Me.dtpPostDate.Name = "dtpPostDate"
        Me.dtpPostDate.Size = New System.Drawing.Size(146, 20)
        Me.dtpPostDate.TabIndex = 74
        Me.dtpPostDate.Tag = "RegDate"
        '
        'cmdPerformedBy
        '
        Me.cmdPerformedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPerformedBy.Location = New System.Drawing.Point(403, 16)
        Me.cmdPerformedBy.Name = "cmdPerformedBy"
        Me.cmdPerformedBy.Size = New System.Drawing.Size(26, 21)
        Me.cmdPerformedBy.TabIndex = 73
        Me.cmdPerformedBy.Text = "..."
        Me.cmdPerformedBy.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(102, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(298, 20)
        Me.TextBox2.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Performed By:"
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAction.Location = New System.Drawing.Point(243, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(195, 59)
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
        Me.lblAction.Size = New System.Drawing.Size(186, 19)
        Me.lblAction.TabIndex = 11
        Me.lblAction.Text = "?"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmDeath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(438, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PanHeading)
        Me.Controls.Add(Me.PanMainCommand)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDeath"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Death"
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.PanMainCommand.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
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
    Friend WithEvents cmdConfirmedBy As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tMedicalTeam As System.Windows.Forms.TextBox
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tPerformedBy As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPerformedBy As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpPostDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
End Class
