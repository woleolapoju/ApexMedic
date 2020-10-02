<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDrugSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDrugSupplier))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.tTelephone = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tContact = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tAddress = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tCode = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanAction = New System.Windows.Forms.FlowLayoutPanel
        Me.mnuAction = New System.Windows.Forms.MenuStrip
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBrowse = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.lblAction = New System.Windows.Forms.Label
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAction.SuspendLayout()
        Me.mnuAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(11, 234)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 8)
        Me.GroupBox1.TabIndex = 244
        Me.GroupBox1.TabStop = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.Lavender
        Me.cmdOk.Location = New System.Drawing.Point(219, 250)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(68, 44)
        Me.cmdOk.TabIndex = 5
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancel.Location = New System.Drawing.Point(286, 250)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(68, 44)
        Me.CmdCancel.TabIndex = 6
        Me.CmdCancel.Text = "&Close"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'tTelephone
        '
        Me.tTelephone.Location = New System.Drawing.Point(106, 179)
        Me.tTelephone.Name = "tTelephone"
        Me.tTelephone.Size = New System.Drawing.Size(139, 20)
        Me.tTelephone.TabIndex = 2
        Me.tTelephone.Tag = "Telephone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "Telephone:"
        '
        'tContact
        '
        Me.tContact.Location = New System.Drawing.Point(106, 201)
        Me.tContact.Name = "tContact"
        Me.tContact.Size = New System.Drawing.Size(256, 20)
        Me.tContact.TabIndex = 3
        Me.tContact.Tag = "AccountNo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 239
        Me.Label4.Text = "Contact Person:"
        '
        'tAddress
        '
        Me.tAddress.Location = New System.Drawing.Point(106, 115)
        Me.tAddress.Multiline = True
        Me.tAddress.Name = "tAddress"
        Me.tAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tAddress.Size = New System.Drawing.Size(256, 62)
        Me.tAddress.TabIndex = 1
        Me.tAddress.Tag = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 238
        Me.Label3.Text = "Address:"
        '
        'tName
        '
        Me.tName.BackColor = System.Drawing.Color.White
        Me.tName.Location = New System.Drawing.Point(106, 93)
        Me.tName.Name = "tName"
        Me.tName.Size = New System.Drawing.Size(256, 20)
        Me.tName.TabIndex = 0
        Me.tName.Tag = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 237
        Me.Label2.Text = "Name:"
        '
        'tCode
        '
        Me.tCode.BackColor = System.Drawing.SystemColors.Control
        Me.tCode.Location = New System.Drawing.Point(106, 71)
        Me.tCode.Name = "tCode"
        Me.tCode.ReadOnly = True
        Me.tCode.Size = New System.Drawing.Size(139, 20)
        Me.tCode.TabIndex = 230
        Me.tCode.Tag = "ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 236
        Me.Label7.Text = "Code:"
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 3
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193.0!))
        Me.tblHeader.Controls.Add(Me.Label5, 1, 0)
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
        Me.tblHeader.Size = New System.Drawing.Size(377, 59)
        Me.tblHeader.TabIndex = 245
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.GhostWhite
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(98, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SUPPLIERS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PictureBox1.Size = New System.Drawing.Size(98, 59)
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
        Me.Label8.Location = New System.Drawing.Point(98, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAction
        '
        Me.PanAction.BackColor = System.Drawing.Color.GhostWhite
        Me.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanAction.Controls.Add(Me.mnuAction)
        Me.PanAction.Controls.Add(Me.lblAction)
        Me.PanAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAction.Location = New System.Drawing.Point(184, 0)
        Me.PanAction.Margin = New System.Windows.Forms.Padding(0)
        Me.PanAction.Name = "PanAction"
        Me.tblHeader.SetRowSpan(Me.PanAction, 2)
        Me.PanAction.Size = New System.Drawing.Size(193, 59)
        Me.PanAction.TabIndex = 54
        '
        'mnuAction
        '
        Me.mnuAction.AllowMerge = False
        Me.mnuAction.BackColor = System.Drawing.Color.Transparent
        Me.mnuAction.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.lblAction.Size = New System.Drawing.Size(180, 19)
        Me.lblAction.TabIndex = 11
        Me.lblAction.Text = "?"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmDrugSupplier
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.CancelButton = Me.CmdCancel
        Me.ClientSize = New System.Drawing.Size(377, 303)
        Me.Controls.Add(Me.tblHeader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.tTelephone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tContact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tCode)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDrugSupplier"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmacy Product Supplier"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanAction.ResumeLayout(False)
        Me.PanAction.PerformLayout()
        Me.mnuAction.ResumeLayout(False)
        Me.mnuAction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents tTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tContact As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tCode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PanAction As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mnuAction As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAction As System.Windows.Forms.Label
End Class
