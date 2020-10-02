<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComposeMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComposeMail))
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.PanCompose = New System.Windows.Forms.Panel
        Me.RadGroup = New System.Windows.Forms.RadioButton
        Me.RadPersonal = New System.Windows.Forms.RadioButton
        Me.lnkAttach5 = New System.Windows.Forms.LinkLabel
        Me.ContextMenuAttachment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lnkAttach4 = New System.Windows.Forms.LinkLabel
        Me.lnkAttach3 = New System.Windows.Forms.LinkLabel
        Me.lnkAttach2 = New System.Windows.Forms.LinkLabel
        Me.lnkAttach1 = New System.Windows.Forms.LinkLabel
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdSend = New System.Windows.Forms.Button
        Me.tBody = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdAttachment = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdAddress = New System.Windows.Forms.Button
        Me.tTitle = New System.Windows.Forms.TextBox
        Me.tTo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PanAttachment = New System.Windows.Forms.Panel
        Me.cmdLoadRecord = New System.Windows.Forms.Button
        Me.cmdAttach = New System.Windows.Forms.Button
        Me.cmdCloseAttachment = New System.Windows.Forms.Button
        Me.lvFields = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.lvData = New System.Windows.Forms.ListView
        Me.tCondition = New System.Windows.Forms.TextBox
        Me.lblFilterKey = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboModule = New System.Windows.Forms.ComboBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblWelcome = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanCompose.SuspendLayout()
        Me.ContextMenuAttachment.SuspendLayout()
        Me.PanAttachment.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.tblHeader.Controls.Add(Me.PictureBox2, 2, 0)
        Me.tblHeader.Controls.Add(Me.Label1, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label2, 1, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.Size = New System.Drawing.Size(392, 52)
        Me.tblHeader.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.ApexMedic.My.Resources.Resources.Compose
        Me.PictureBox2.Location = New System.Drawing.Point(338, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.tblHeader.SetRowSpan(Me.PictureBox2, 2)
        Me.PictureBox2.Size = New System.Drawing.Size(51, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.GhostWhite
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(80, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MAIL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(80, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Send and Receive Mail"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ApexMedic.My.Resources.Resources.OutBox
        Me.PictureBox4.Location = New System.Drawing.Point(332, 8)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(41, 41)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Enabled = False
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(300, 1)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(92, 20)
        Me.dtpDate.TabIndex = 41
        Me.dtpDate.Tag = "RegDate"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.Controls.Add(Me.PanCompose, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanAttachment, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 77)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 373.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 373.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(781, 366)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'PanCompose
        '
        Me.PanCompose.Controls.Add(Me.PictureBox4)
        Me.PanCompose.Controls.Add(Me.RadGroup)
        Me.PanCompose.Controls.Add(Me.RadPersonal)
        Me.PanCompose.Controls.Add(Me.lnkAttach5)
        Me.PanCompose.Controls.Add(Me.lnkAttach4)
        Me.PanCompose.Controls.Add(Me.lnkAttach3)
        Me.PanCompose.Controls.Add(Me.lnkAttach2)
        Me.PanCompose.Controls.Add(Me.lnkAttach1)
        Me.PanCompose.Controls.Add(Me.cmdClose)
        Me.PanCompose.Controls.Add(Me.cmdSave)
        Me.PanCompose.Controls.Add(Me.cmdSend)
        Me.PanCompose.Controls.Add(Me.tBody)
        Me.PanCompose.Controls.Add(Me.Label7)
        Me.PanCompose.Controls.Add(Me.cmdAttachment)
        Me.PanCompose.Controls.Add(Me.Label6)
        Me.PanCompose.Controls.Add(Me.cmdAddress)
        Me.PanCompose.Controls.Add(Me.tTitle)
        Me.PanCompose.Controls.Add(Me.tTo)
        Me.PanCompose.Controls.Add(Me.Label5)
        Me.PanCompose.Controls.Add(Me.Label4)
        Me.PanCompose.Location = New System.Drawing.Point(3, 3)
        Me.PanCompose.Name = "PanCompose"
        Me.PanCompose.Size = New System.Drawing.Size(383, 339)
        Me.PanCompose.TabIndex = 2
        '
        'RadGroup
        '
        Me.RadGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroup.AutoSize = True
        Me.RadGroup.Location = New System.Drawing.Point(137, 8)
        Me.RadGroup.Name = "RadGroup"
        Me.RadGroup.Size = New System.Drawing.Size(76, 17)
        Me.RadGroup.TabIndex = 17
        Me.RadGroup.Text = "&Group Mail"
        Me.RadGroup.UseVisualStyleBackColor = True
        '
        'RadPersonal
        '
        Me.RadPersonal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPersonal.AutoSize = True
        Me.RadPersonal.Checked = True
        Me.RadPersonal.Location = New System.Drawing.Point(49, 8)
        Me.RadPersonal.Name = "RadPersonal"
        Me.RadPersonal.Size = New System.Drawing.Size(88, 17)
        Me.RadPersonal.TabIndex = 18
        Me.RadPersonal.TabStop = True
        Me.RadPersonal.Text = "&Personal Mail"
        Me.RadPersonal.UseVisualStyleBackColor = True
        '
        'lnkAttach5
        '
        Me.lnkAttach5.AutoSize = True
        Me.lnkAttach5.ContextMenuStrip = Me.ContextMenuAttachment
        Me.lnkAttach5.Location = New System.Drawing.Point(198, 76)
        Me.lnkAttach5.Name = "lnkAttach5"
        Me.lnkAttach5.Size = New System.Drawing.Size(13, 13)
        Me.lnkAttach5.TabIndex = 16
        Me.lnkAttach5.TabStop = True
        Me.lnkAttach5.Text = "5"
        Me.ToolTip1.SetToolTip(Me.lnkAttach5, "Right click to see options")
        Me.lnkAttach5.Visible = False
        '
        'ContextMenuAttachment
        '
        Me.ContextMenuAttachment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuAttachment.Name = "ContextMenuAttachment"
        Me.ContextMenuAttachment.Size = New System.Drawing.Size(108, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'lnkAttach4
        '
        Me.lnkAttach4.AutoSize = True
        Me.lnkAttach4.ContextMenuStrip = Me.ContextMenuAttachment
        Me.lnkAttach4.Location = New System.Drawing.Point(182, 76)
        Me.lnkAttach4.Name = "lnkAttach4"
        Me.lnkAttach4.Size = New System.Drawing.Size(13, 13)
        Me.lnkAttach4.TabIndex = 15
        Me.lnkAttach4.TabStop = True
        Me.lnkAttach4.Text = "4"
        Me.ToolTip1.SetToolTip(Me.lnkAttach4, "Right click to see options")
        Me.lnkAttach4.Visible = False
        '
        'lnkAttach3
        '
        Me.lnkAttach3.AutoSize = True
        Me.lnkAttach3.ContextMenuStrip = Me.ContextMenuAttachment
        Me.lnkAttach3.Location = New System.Drawing.Point(166, 76)
        Me.lnkAttach3.Name = "lnkAttach3"
        Me.lnkAttach3.Size = New System.Drawing.Size(13, 13)
        Me.lnkAttach3.TabIndex = 14
        Me.lnkAttach3.TabStop = True
        Me.lnkAttach3.Text = "3"
        Me.ToolTip1.SetToolTip(Me.lnkAttach3, "Right click to see options")
        Me.lnkAttach3.Visible = False
        '
        'lnkAttach2
        '
        Me.lnkAttach2.AutoSize = True
        Me.lnkAttach2.ContextMenuStrip = Me.ContextMenuAttachment
        Me.lnkAttach2.Location = New System.Drawing.Point(149, 76)
        Me.lnkAttach2.Name = "lnkAttach2"
        Me.lnkAttach2.Size = New System.Drawing.Size(13, 13)
        Me.lnkAttach2.TabIndex = 13
        Me.lnkAttach2.TabStop = True
        Me.lnkAttach2.Text = "2"
        Me.ToolTip1.SetToolTip(Me.lnkAttach2, "Right click to see options")
        Me.lnkAttach2.Visible = False
        '
        'lnkAttach1
        '
        Me.lnkAttach1.AutoSize = True
        Me.lnkAttach1.ContextMenuStrip = Me.ContextMenuAttachment
        Me.lnkAttach1.Location = New System.Drawing.Point(132, 76)
        Me.lnkAttach1.Name = "lnkAttach1"
        Me.lnkAttach1.Size = New System.Drawing.Size(13, 13)
        Me.lnkAttach1.TabIndex = 12
        Me.lnkAttach1.TabStop = True
        Me.lnkAttach1.Text = "1"
        Me.ToolTip1.SetToolTip(Me.lnkAttach1, "Right click to see options")
        Me.lnkAttach1.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(317, 315)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(61, 23)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(253, 315)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(61, 23)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        Me.cmdSave.Visible = False
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(50, 314)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(61, 23)
        Me.cmdSend.TabIndex = 9
        Me.cmdSend.Text = "Send"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'tBody
        '
        Me.tBody.Location = New System.Drawing.Point(50, 95)
        Me.tBody.Multiline = True
        Me.tBody.Name = "tBody"
        Me.tBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tBody.Size = New System.Drawing.Size(329, 216)
        Me.tBody.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "BODY:"
        '
        'cmdAttachment
        '
        Me.cmdAttachment.Location = New System.Drawing.Point(88, 70)
        Me.cmdAttachment.Name = "cmdAttachment"
        Me.cmdAttachment.Size = New System.Drawing.Size(38, 20)
        Me.cmdAttachment.TabIndex = 6
        Me.cmdAttachment.Text = "New"
        Me.cmdAttachment.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ATTACHMENT"
        '
        'cmdAddress
        '
        Me.cmdAddress.Location = New System.Drawing.Point(246, 25)
        Me.cmdAddress.Name = "cmdAddress"
        Me.cmdAddress.Size = New System.Drawing.Size(26, 21)
        Me.cmdAddress.TabIndex = 4
        Me.cmdAddress.Text = "..."
        Me.cmdAddress.UseVisualStyleBackColor = True
        '
        'tTitle
        '
        Me.tTitle.Location = New System.Drawing.Point(50, 48)
        Me.tTitle.Name = "tTitle"
        Me.tTitle.Size = New System.Drawing.Size(283, 20)
        Me.tTitle.TabIndex = 3
        '
        'tTo
        '
        Me.tTo.Location = New System.Drawing.Point(50, 26)
        Me.tTo.Name = "tTo"
        Me.tTo.ReadOnly = True
        Me.tTo.Size = New System.Drawing.Size(196, 20)
        Me.tTo.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "TITLE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TO:"
        '
        'PanAttachment
        '
        Me.PanAttachment.Controls.Add(Me.cmdLoadRecord)
        Me.PanAttachment.Controls.Add(Me.cmdAttach)
        Me.PanAttachment.Controls.Add(Me.cmdCloseAttachment)
        Me.PanAttachment.Controls.Add(Me.lvFields)
        Me.PanAttachment.Controls.Add(Me.lvData)
        Me.PanAttachment.Controls.Add(Me.tCondition)
        Me.PanAttachment.Controls.Add(Me.lblFilterKey)
        Me.PanAttachment.Controls.Add(Me.Label8)
        Me.PanAttachment.Controls.Add(Me.cboModule)
        Me.PanAttachment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAttachment.Location = New System.Drawing.Point(392, 3)
        Me.PanAttachment.Name = "PanAttachment"
        Me.PanAttachment.Size = New System.Drawing.Size(386, 367)
        Me.PanAttachment.TabIndex = 4
        Me.PanAttachment.Visible = False
        '
        'cmdLoadRecord
        '
        Me.cmdLoadRecord.Location = New System.Drawing.Point(296, 36)
        Me.cmdLoadRecord.Name = "cmdLoadRecord"
        Me.cmdLoadRecord.Size = New System.Drawing.Size(81, 21)
        Me.cmdLoadRecord.TabIndex = 14
        Me.cmdLoadRecord.Text = "Load Record"
        Me.cmdLoadRecord.UseVisualStyleBackColor = True
        '
        'cmdAttach
        '
        Me.cmdAttach.Location = New System.Drawing.Point(253, 313)
        Me.cmdAttach.Name = "cmdAttach"
        Me.cmdAttach.Size = New System.Drawing.Size(61, 23)
        Me.cmdAttach.TabIndex = 13
        Me.cmdAttach.Text = "Attach"
        Me.cmdAttach.UseVisualStyleBackColor = True
        '
        'cmdCloseAttachment
        '
        Me.cmdCloseAttachment.Location = New System.Drawing.Point(316, 313)
        Me.cmdCloseAttachment.Name = "cmdCloseAttachment"
        Me.cmdCloseAttachment.Size = New System.Drawing.Size(61, 23)
        Me.cmdCloseAttachment.TabIndex = 12
        Me.cmdCloseAttachment.Text = "Close"
        Me.cmdCloseAttachment.UseVisualStyleBackColor = True
        '
        'lvFields
        '
        Me.lvFields.BackColor = System.Drawing.Color.GhostWhite
        Me.lvFields.CheckBoxes = True
        Me.lvFields.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFields.FullRowSelect = True
        Me.lvFields.GridLines = True
        Me.lvFields.Location = New System.Drawing.Point(5, 58)
        Me.lvFields.MultiSelect = False
        Me.lvFields.Name = "lvFields"
        Me.lvFields.Size = New System.Drawing.Size(92, 253)
        Me.lvFields.TabIndex = 3
        Me.lvFields.UseCompatibleStateImageBehavior = False
        Me.lvFields.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Fields"
        Me.ColumnHeader1.Width = 65
        '
        'lvData
        '
        Me.lvData.BackColor = System.Drawing.Color.GhostWhite
        Me.lvData.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvData.FullRowSelect = True
        Me.lvData.GridLines = True
        Me.lvData.HideSelection = False
        Me.lvData.Location = New System.Drawing.Point(99, 57)
        Me.lvData.MultiSelect = False
        Me.lvData.Name = "lvData"
        Me.lvData.Size = New System.Drawing.Size(278, 253)
        Me.lvData.TabIndex = 4
        Me.lvData.UseCompatibleStateImageBehavior = False
        Me.lvData.View = System.Windows.Forms.View.Details
        '
        'tCondition
        '
        Me.tCondition.Location = New System.Drawing.Point(62, 24)
        Me.tCondition.Name = "tCondition"
        Me.tCondition.Size = New System.Drawing.Size(131, 20)
        Me.tCondition.TabIndex = 5
        '
        'lblFilterKey
        '
        Me.lblFilterKey.AutoSize = True
        Me.lblFilterKey.Location = New System.Drawing.Point(5, 31)
        Me.lblFilterKey.Name = "lblFilterKey"
        Me.lblFilterKey.Size = New System.Drawing.Size(57, 13)
        Me.lblFilterKey.TabIndex = 2
        Me.lblFilterKey.Text = "PatientNo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Module:"
        '
        'cboModule
        '
        Me.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboModule.FormattingEnabled = True
        Me.cboModule.Location = New System.Drawing.Point(62, 1)
        Me.cboModule.Name = "cboModule"
        Me.cboModule.Size = New System.Drawing.Size(129, 21)
        Me.cboModule.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblWelcome)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.dtpDate)
        Me.Panel3.Location = New System.Drawing.Point(0, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(393, 22)
        Me.Panel3.TabIndex = 4
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Tomato
        Me.lblWelcome.Location = New System.Drawing.Point(57, -4)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(239, 23)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "'Wole Olapoju"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-1, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Welcome"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmComposeMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(392, 420)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmComposeMail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mail"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanCompose.ResumeLayout(False)
        Me.PanCompose.PerformLayout()
        Me.ContextMenuAttachment.ResumeLayout(False)
        Me.PanAttachment.ResumeLayout(False)
        Me.PanAttachment.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanCompose As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tTitle As System.Windows.Forms.TextBox
    Friend WithEvents tTo As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddress As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdSend As System.Windows.Forms.Button
    Friend WithEvents tBody As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdAttachment As System.Windows.Forms.Button
    Friend WithEvents lnkAttach3 As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkAttach2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkAttach1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkAttach5 As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkAttach4 As System.Windows.Forms.LinkLabel
    Friend WithEvents RadGroup As System.Windows.Forms.RadioButton
    Friend WithEvents RadPersonal As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuAttachment As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanAttachment As System.Windows.Forms.Panel
    Friend WithEvents tCondition As System.Windows.Forms.TextBox
    Friend WithEvents lblFilterKey As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboModule As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAttach As System.Windows.Forms.Button
    Friend WithEvents cmdCloseAttachment As System.Windows.Forms.Button
    Friend WithEvents lvFields As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvData As System.Windows.Forms.ListView
    Friend WithEvents cmdLoadRecord As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
