<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLabTestResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLabTestResult))
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.tPerformedBy = New System.Windows.Forms.TextBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPerform = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.tDate = New System.Windows.Forms.TextBox
        Me.tAge = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tSex = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tTestNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.mnuGetLabTest = New System.Windows.Forms.MenuStrip
        Me.mnuGetByPatientNo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuGetLabNo = New System.Windows.Forms.ToolStripMenuItem
        Me.PanCommand = New System.Windows.Forms.Panel
        Me.mnuPrint = New System.Windows.Forms.MenuStrip
        Me.mnuPrintResult = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLastResult = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRefNo = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PanMail = New System.Windows.Forms.Panel
        Me.mnuMail = New System.Windows.Forms.CheckBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.PanDetails = New System.Windows.Forms.Panel
        Me.tSn = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpResultDate = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdInsertDetails = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.tRemark = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lvList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.TV = New System.Windows.Forms.TreeView
        Me.Label15 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tResult = New System.Windows.Forms.ComboBox
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanHeading.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.mnuGetLabTest.SuspendLayout()
        Me.PanCommand.SuspendLayout()
        Me.mnuPrint.SuspendLayout()
        Me.PanMail.SuspendLayout()
        Me.PanDetails.SuspendLayout()
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
        Me.tblHeader.Size = New System.Drawing.Size(793, 55)
        Me.tblHeader.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.GhostWhite
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(80, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(713, 30)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "LAB. TEST RESULT"
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
        Me.PictureBox1.Size = New System.Drawing.Size(80, 55)
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
        Me.Label8.Location = New System.Drawing.Point(80, 30)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(713, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Updates Results of Lab. Test "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 293.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanHeading, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanCommand, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PanDetails, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lvList, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TV, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 55)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(793, 527)
        Me.TableLayoutPanel1.TabIndex = 51
        '
        'PanHeading
        '
        Me.PanHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanHeading.Controls.Add(Me.tPerformedBy)
        Me.PanHeading.Controls.Add(Me.cmdPerform)
        Me.PanHeading.Controls.Add(Me.Label18)
        Me.PanHeading.Controls.Add(Me.tDate)
        Me.PanHeading.Controls.Add(Me.tAge)
        Me.PanHeading.Controls.Add(Me.Label6)
        Me.PanHeading.Controls.Add(Me.tSex)
        Me.PanHeading.Controls.Add(Me.Label5)
        Me.PanHeading.Controls.Add(Me.tPatientName)
        Me.PanHeading.Controls.Add(Me.Label3)
        Me.PanHeading.Controls.Add(Me.Label2)
        Me.PanHeading.Controls.Add(Me.tTestNo)
        Me.PanHeading.Controls.Add(Me.Label1)
        Me.PanHeading.Controls.Add(Me.tPatientNo)
        Me.PanHeading.Controls.Add(Me.Label4)
        Me.PanHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanHeading.Location = New System.Drawing.Point(296, 41)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(494, 76)
        Me.PanHeading.TabIndex = 57
        '
        'tPerformedBy
        '
        Me.tPerformedBy.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tPerformedBy.Location = New System.Drawing.Point(80, 50)
        Me.tPerformedBy.Name = "tPerformedBy"
        Me.tPerformedBy.Size = New System.Drawing.Size(377, 20)
        Me.tPerformedBy.TabIndex = 64
        Me.tPerformedBy.TabStop = False
        Me.ToolTip1.SetToolTip(Me.tPerformedBy, "Right click to clear")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(102, 26)
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "Clear"
        '
        'cmdPerform
        '
        Me.cmdPerform.Location = New System.Drawing.Point(457, 50)
        Me.cmdPerform.Name = "cmdPerform"
        Me.cmdPerform.Size = New System.Drawing.Size(26, 21)
        Me.cmdPerform.TabIndex = 63
        Me.cmdPerform.Text = "..."
        Me.cmdPerform.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Performed By:"
        '
        'tDate
        '
        Me.tDate.Location = New System.Drawing.Point(362, 5)
        Me.tDate.Name = "tDate"
        Me.tDate.ReadOnly = True
        Me.tDate.Size = New System.Drawing.Size(118, 20)
        Me.tDate.TabIndex = 50
        Me.tDate.TabStop = False
        '
        'tAge
        '
        Me.tAge.Location = New System.Drawing.Point(444, 27)
        Me.tAge.Name = "tAge"
        Me.tAge.ReadOnly = True
        Me.tAge.Size = New System.Drawing.Size(38, 20)
        Me.tAge.TabIndex = 49
        Me.tAge.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(416, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Age:"
        '
        'tSex
        '
        Me.tSex.Location = New System.Drawing.Point(362, 27)
        Me.tSex.Name = "tSex"
        Me.tSex.ReadOnly = True
        Me.tSex.Size = New System.Drawing.Size(49, 20)
        Me.tSex.TabIndex = 47
        Me.tSex.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Sex:"
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(80, 28)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(242, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Patient Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Date:"
        '
        'tTestNo
        '
        Me.tTestNo.Location = New System.Drawing.Point(242, 6)
        Me.tTestNo.Name = "tTestNo"
        Me.tTestNo.ReadOnly = True
        Me.tTestNo.Size = New System.Drawing.Size(77, 20)
        Me.tTestNo.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Test No:"
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(80, 6)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.ReadOnly = True
        Me.tPatientNo.Size = New System.Drawing.Size(72, 20)
        Me.tPatientNo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Patient No:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightYellow
        Me.Panel3.Controls.Add(Me.mnuGetLabTest)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(296, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(494, 32)
        Me.Panel3.TabIndex = 238
        '
        'mnuGetLabTest
        '
        Me.mnuGetLabTest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mnuGetLabTest.BackColor = System.Drawing.Color.LightYellow
        Me.mnuGetLabTest.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuGetLabTest.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGetByPatientNo, Me.mnuGetLabNo})
        Me.mnuGetLabTest.Location = New System.Drawing.Point(39, 5)
        Me.mnuGetLabTest.Name = "mnuGetLabTest"
        Me.mnuGetLabTest.Size = New System.Drawing.Size(409, 24)
        Me.mnuGetLabTest.TabIndex = 62
        Me.mnuGetLabTest.Text = "MenuStrip1"
        '
        'mnuGetByPatientNo
        '
        Me.mnuGetByPatientNo.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.mnuGetByPatientNo.Name = "mnuGetByPatientNo"
        Me.mnuGetByPatientNo.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuGetByPatientNo.Size = New System.Drawing.Size(208, 20)
        Me.mnuGetByPatientNo.Text = "&Get Lab. Investigation By Patient No"
        Me.mnuGetByPatientNo.ToolTipText = "Press F2 as shortcut"
        '
        'mnuGetLabNo
        '
        Me.mnuGetLabNo.BackColor = System.Drawing.Color.LightBlue
        Me.mnuGetLabNo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuGetLabNo.Name = "mnuGetLabNo"
        Me.mnuGetLabNo.ShortcutKeyDisplayString = ""
        Me.mnuGetLabNo.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuGetLabNo.Size = New System.Drawing.Size(193, 20)
        Me.mnuGetLabNo.Text = "&Get Lab. Investigation By Lab. No"
        Me.mnuGetLabNo.ToolTipText = "Press F3 as shortcut"
        '
        'PanCommand
        '
        Me.PanCommand.BackColor = System.Drawing.Color.LightYellow
        Me.PanCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanCommand.Controls.Add(Me.mnuPrint)
        Me.PanCommand.Controls.Add(Me.PanMail)
        Me.PanCommand.Controls.Add(Me.cmdClose)
        Me.PanCommand.Controls.Add(Me.cmdOk)
        Me.PanCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCommand.Location = New System.Drawing.Point(296, 219)
        Me.PanCommand.Name = "PanCommand"
        Me.PanCommand.Size = New System.Drawing.Size(494, 43)
        Me.PanCommand.TabIndex = 239
        '
        'mnuPrint
        '
        Me.mnuPrint.AllowMerge = False
        Me.mnuPrint.BackColor = System.Drawing.Color.Transparent
        Me.mnuPrint.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuPrint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintResult, Me.ToolStripMenuItem1})
        Me.mnuPrint.Location = New System.Drawing.Point(1, 8)
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(87, 24)
        Me.mnuPrint.TabIndex = 257
        Me.mnuPrint.Text = "MenuStrip1"
        '
        'mnuPrintResult
        '
        Me.mnuPrintResult.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.mnuPrintResult.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLastResult, Me.mnuRefNo})
        Me.mnuPrintResult.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPrintResult.ForeColor = System.Drawing.Color.Brown
        Me.mnuPrintResult.Name = "mnuPrintResult"
        Me.mnuPrintResult.Size = New System.Drawing.Size(79, 20)
        Me.mnuPrintResult.Text = "Print Result"
        '
        'mnuLastResult
        '
        Me.mnuLastResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLastResult.ForeColor = System.Drawing.Color.Brown
        Me.mnuLastResult.Name = "mnuLastResult"
        Me.mnuLastResult.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuLastResult.Size = New System.Drawing.Size(156, 22)
        Me.mnuLastResult.Text = "Last Result"
        '
        'mnuRefNo
        '
        Me.mnuRefNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuRefNo.ForeColor = System.Drawing.Color.Brown
        Me.mnuRefNo.Name = "mnuRefNo"
        Me.mnuRefNo.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuRefNo.Size = New System.Drawing.Size(156, 22)
        Me.mnuRefNo.Text = "Use Test No"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = " "
        Me.ToolStripMenuItem1.Visible = False
        '
        'PanMail
        '
        Me.PanMail.Controls.Add(Me.mnuMail)
        Me.PanMail.Location = New System.Drawing.Point(150, 10)
        Me.PanMail.Name = "PanMail"
        Me.PanMail.Size = New System.Drawing.Size(182, 22)
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
        Me.cmdClose.Location = New System.Drawing.Point(424, 2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(60, 36)
        Me.cmdClose.TabIndex = 253
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(341, 2)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(82, 36)
        Me.cmdOk.TabIndex = 252
        Me.cmdOk.Text = "&Update"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'PanDetails
        '
        Me.PanDetails.Controls.Add(Me.tResult)
        Me.PanDetails.Controls.Add(Me.tSn)
        Me.PanDetails.Controls.Add(Me.Label14)
        Me.PanDetails.Controls.Add(Me.dtpResultDate)
        Me.PanDetails.Controls.Add(Me.Label11)
        Me.PanDetails.Controls.Add(Me.cmdInsertDetails)
        Me.PanDetails.Controls.Add(Me.Label10)
        Me.PanDetails.Controls.Add(Me.Label9)
        Me.PanDetails.Controls.Add(Me.tRemark)
        Me.PanDetails.Controls.Add(Me.Label13)
        Me.PanDetails.Controls.Add(Me.Label12)
        Me.PanDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanDetails.Location = New System.Drawing.Point(296, 123)
        Me.PanDetails.Name = "PanDetails"
        Me.PanDetails.Size = New System.Drawing.Size(494, 90)
        Me.PanDetails.TabIndex = 60
        '
        'tSn
        '
        Me.tSn.Location = New System.Drawing.Point(79, 3)
        Me.tSn.Name = "tSn"
        Me.tSn.ReadOnly = True
        Me.tSn.Size = New System.Drawing.Size(76, 20)
        Me.tSn.TabIndex = 265
        Me.tSn.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 13)
        Me.Label14.TabIndex = 264
        Me.Label14.Text = "Sn."
        '
        'dtpResultDate
        '
        Me.dtpResultDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpResultDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpResultDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpResultDate.Location = New System.Drawing.Point(371, 4)
        Me.dtpResultDate.Name = "dtpResultDate"
        Me.dtpResultDate.Size = New System.Drawing.Size(111, 20)
        Me.dtpResultDate.TabIndex = 60
        Me.dtpResultDate.Tag = "RegDate"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(294, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Date of Result:"
        '
        'cmdInsertDetails
        '
        Me.cmdInsertDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsertDetails.ForeColor = System.Drawing.Color.Black
        Me.cmdInsertDetails.Location = New System.Drawing.Point(408, 30)
        Me.cmdInsertDetails.Name = "cmdInsertDetails"
        Me.cmdInsertDetails.Size = New System.Drawing.Size(75, 55)
        Me.cmdInsertDetails.TabIndex = 263
        Me.cmdInsertDetails.Text = "&Insert"
        Me.cmdInsertDetails.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 262
        Me.Label10.Text = "Result:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 261
        Me.Label9.Text = "Remark:"
        '
        'tRemark
        '
        Me.tRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRemark.Location = New System.Drawing.Point(78, 48)
        Me.tRemark.Multiline = True
        Me.tRemark.Name = "tRemark"
        Me.tRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tRemark.Size = New System.Drawing.Size(302, 35)
        Me.tRemark.TabIndex = 260
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(-50, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 259
        Me.Label13.Text = "Remark:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(-50, -6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 257
        Me.Label12.Text = "Result:"
        '
        'lvList
        '
        Me.lvList.BackColor = System.Drawing.Color.GhostWhite
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        Me.lvList.HideSelection = False
        Me.lvList.Location = New System.Drawing.Point(296, 265)
        Me.lvList.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.lvList.MultiSelect = False
        Me.lvList.Name = "lvList"
        Me.lvList.ShowItemToolTips = True
        Me.lvList.Size = New System.Drawing.Size(494, 262)
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
        Me.ColumnHeader2.Text = "Test MainType"
        Me.ColumnHeader2.Width = 88
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Test SubType"
        Me.ColumnHeader3.Width = 94
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TestCode"
        Me.ColumnHeader4.Width = 1
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Test Name"
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Result"
        Me.ColumnHeader6.Width = 83
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Remark"
        Me.ColumnHeader7.Width = 85
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Pending"
        Me.ColumnHeader8.Width = 1
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Result Date"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Sn"
        Me.ColumnHeader10.Width = 0
        '
        'TV
        '
        Me.TV.BackColor = System.Drawing.Color.White
        Me.TV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TV.FullRowSelect = True
        Me.TV.HideSelection = False
        Me.TV.Location = New System.Drawing.Point(3, 41)
        Me.TV.Name = "TV"
        Me.TableLayoutPanel1.SetRowSpan(Me.TV, 4)
        Me.TV.Size = New System.Drawing.Size(287, 483)
        Me.TV.TabIndex = 240
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.LightYellow
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(287, 38)
        Me.Label15.TabIndex = 241
        Me.Label15.Text = "List of Pending Results"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tResult
        '
        Me.tResult.BackColor = System.Drawing.Color.White
        Me.tResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tResult.FormattingEnabled = True
        Me.tResult.Items.AddRange(New Object() {"Male", "Female"})
        Me.tResult.Location = New System.Drawing.Point(79, 25)
        Me.tResult.Name = "tResult"
        Me.tResult.Size = New System.Drawing.Size(300, 21)
        Me.tResult.TabIndex = 267
        Me.tResult.Tag = "Sex"
        '
        'FrmLabTestResult
        '
        Me.AcceptButton = Me.cmdInsertDetails
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(793, 582)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuGetLabTest
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLabTestResult"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab. Test Result"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.mnuGetLabTest.ResumeLayout(False)
        Me.mnuGetLabTest.PerformLayout()
        Me.PanCommand.ResumeLayout(False)
        Me.PanCommand.PerformLayout()
        Me.mnuPrint.ResumeLayout(False)
        Me.mnuPrint.PerformLayout()
        Me.PanMail.ResumeLayout(False)
        Me.PanMail.PerformLayout()
        Me.PanDetails.ResumeLayout(False)
        Me.PanDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents tAge As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tSex As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tTestNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanDetails As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdInsertDetails As System.Windows.Forms.Button
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpResultDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tDate As System.Windows.Forms.TextBox
    Friend WithEvents mnuGetLabTest As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuGetByPatientNo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanCommand As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PanMail As System.Windows.Forms.Panel
    Friend WithEvents mnuMail As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tPerformedBy As System.Windows.Forms.TextBox
    Friend WithEvents cmdPerform As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents mnuGetLabNo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tSn As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TV As System.Windows.Forms.TreeView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuPrintResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLastResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRefNo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tResult As System.Windows.Forms.ComboBox
End Class
