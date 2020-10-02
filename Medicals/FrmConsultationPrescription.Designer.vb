<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultationPrescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultationPrescription))
        Me.tblMedication = New System.Windows.Forms.TableLayoutPanel
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.lblSource = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lvMedication = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.PanCommands = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.tDosage = New System.Windows.Forms.TextBox
        Me.tMedication = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.mnuCut = New System.Windows.Forms.Button
        Me.mnuOpen = New System.Windows.Forms.Button
        Me.mnuInsert = New System.Windows.Forms.Button
        Me.cboDosage = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdOk = New System.Windows.Forms.Button
        Me.tblMedication.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanCommands.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblMedication
        '
        Me.tblMedication.ColumnCount = 2
        Me.tblMedication.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMedication.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblMedication.Controls.Add(Me.tblHeader, 0, 0)
        Me.tblMedication.Controls.Add(Me.lvMedication, 0, 2)
        Me.tblMedication.Controls.Add(Me.PanCommands, 0, 1)
        Me.tblMedication.Controls.Add(Me.Panel2, 1, 2)
        Me.tblMedication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMedication.Location = New System.Drawing.Point(0, 0)
        Me.tblMedication.Name = "tblMedication"
        Me.tblMedication.RowCount = 3
        Me.tblMedication.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblMedication.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblMedication.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMedication.Size = New System.Drawing.Size(575, 344)
        Me.tblMedication.TabIndex = 1
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.tblMedication.SetColumnSpan(Me.tblHeader, 2)
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.Controls.Add(Me.lblSource, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label8, 1, 1)
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.Size = New System.Drawing.Size(575, 55)
        Me.tblHeader.TabIndex = 254
        '
        'lblSource
        '
        Me.lblSource.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSource.AutoSize = True
        Me.lblSource.BackColor = System.Drawing.Color.GhostWhite
        Me.lblSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSource.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblSource.Location = New System.Drawing.Point(80, 0)
        Me.lblSource.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(495, 30)
        Me.lblSource.TabIndex = 0
        Me.lblSource.Text = "CONSULTATION PRESCRIPTION"
        Me.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label8.Size = New System.Drawing.Size(495, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvMedication
        '
        Me.lvMedication.BackColor = System.Drawing.Color.GhostWhite
        Me.lvMedication.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader19, Me.ColumnHeader20})
        Me.lvMedication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMedication.FullRowSelect = True
        Me.lvMedication.GridLines = True
        Me.lvMedication.HideSelection = False
        Me.lvMedication.Location = New System.Drawing.Point(3, 108)
        Me.lvMedication.MultiSelect = False
        Me.lvMedication.Name = "lvMedication"
        Me.lvMedication.Size = New System.Drawing.Size(485, 233)
        Me.lvMedication.TabIndex = 5
        Me.lvMedication.UseCompatibleStateImageBehavior = False
        Me.lvMedication.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Sn"
        Me.ColumnHeader13.Width = 31
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Medication"
        Me.ColumnHeader19.Width = 217
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Dosage"
        Me.ColumnHeader20.Width = 201
        '
        'PanCommands
        '
        Me.PanCommands.BackColor = System.Drawing.Color.LightYellow
        Me.PanCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tblMedication.SetColumnSpan(Me.PanCommands, 2)
        Me.PanCommands.Controls.Add(Me.Label15)
        Me.PanCommands.Controls.Add(Me.tDosage)
        Me.PanCommands.Controls.Add(Me.tMedication)
        Me.PanCommands.Controls.Add(Me.Label14)
        Me.PanCommands.Controls.Add(Me.mnuCut)
        Me.PanCommands.Controls.Add(Me.mnuOpen)
        Me.PanCommands.Controls.Add(Me.mnuInsert)
        Me.PanCommands.Controls.Add(Me.cboDosage)
        Me.PanCommands.Location = New System.Drawing.Point(0, 55)
        Me.PanCommands.Margin = New System.Windows.Forms.Padding(0)
        Me.PanCommands.Name = "PanCommands"
        Me.PanCommands.Size = New System.Drawing.Size(575, 50)
        Me.PanCommands.TabIndex = 253
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.DarkRed
        Me.Label15.Location = New System.Drawing.Point(245, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Dosage/Duration"
        '
        'tDosage
        '
        Me.tDosage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDosage.Location = New System.Drawing.Point(248, 20)
        Me.tDosage.Name = "tDosage"
        Me.tDosage.Size = New System.Drawing.Size(226, 21)
        Me.tDosage.TabIndex = 1
        '
        'tMedication
        '
        Me.tMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMedication.Location = New System.Drawing.Point(4, 20)
        Me.tMedication.Name = "tMedication"
        Me.tMedication.Size = New System.Drawing.Size(240, 21)
        Me.tMedication.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.DarkRed
        Me.Label14.Location = New System.Drawing.Point(0, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Medication"
        '
        'mnuCut
        '
        Me.mnuCut.Image = Global.ApexMedic.My.Resources.Resources.CUT
        Me.mnuCut.Location = New System.Drawing.Point(545, 18)
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(26, 25)
        Me.mnuCut.TabIndex = 10
        Me.mnuCut.Text = "..."
        Me.mnuCut.UseVisualStyleBackColor = True
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = Global.ApexMedic.My.Resources.Resources.OPEN
        Me.mnuOpen.Location = New System.Drawing.Point(520, 18)
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(26, 25)
        Me.mnuOpen.TabIndex = 9
        Me.mnuOpen.Text = "..."
        Me.mnuOpen.UseVisualStyleBackColor = True
        '
        'mnuInsert
        '
        Me.mnuInsert.Image = Global.ApexMedic.My.Resources.Resources.NEW1
        Me.mnuInsert.Location = New System.Drawing.Point(495, 18)
        Me.mnuInsert.Name = "mnuInsert"
        Me.mnuInsert.Size = New System.Drawing.Size(26, 25)
        Me.mnuInsert.TabIndex = 3
        Me.mnuInsert.UseVisualStyleBackColor = True
        '
        'cboDosage
        '
        Me.cboDosage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDosage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDosage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDosage.FormattingEnabled = True
        Me.cboDosage.Location = New System.Drawing.Point(250, 20)
        Me.cboDosage.Name = "cboDosage"
        Me.cboDosage.Size = New System.Drawing.Size(243, 23)
        Me.cboDosage.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmdOk)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(491, 105)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(84, 239)
        Me.Panel2.TabIndex = 255
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(4, 152)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 82)
        Me.cmdOk.TabIndex = 50
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'FrmConsultationPrescription
        '
        Me.AcceptButton = Me.mnuInsert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 344)
        Me.Controls.Add(Me.tblMedication)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultationPrescription"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultation Prescription"
        Me.tblMedication.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanCommands.ResumeLayout(False)
        Me.PanCommands.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblMedication As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanCommands As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tDosage As System.Windows.Forms.TextBox
    Friend WithEvents tMedication As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents mnuCut As System.Windows.Forms.Button
    Friend WithEvents mnuOpen As System.Windows.Forms.Button
    Friend WithEvents mnuInsert As System.Windows.Forms.Button
    Friend WithEvents lvMedication As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cboDosage As System.Windows.Forms.ComboBox
End Class
