<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBatches
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBatches))
        Me.lblAction = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tBatchNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tDesc = New System.Windows.Forms.TextBox
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpMadeDate = New System.Windows.Forms.DateTimePicker
        Me.lblDate = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.cmdProduct = New System.Windows.Forms.Button
        Me.chkDiscontinue = New System.Windows.Forms.CheckBox
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAction
        '
        Me.lblAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAction.BackColor = System.Drawing.Color.Transparent
        Me.lblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.ForeColor = System.Drawing.Color.Red
        Me.lblAction.Location = New System.Drawing.Point(7, 217)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(119, 15)
        Me.lblAction.TabIndex = 9
        Me.lblAction.Text = "?"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 217
        Me.Label2.Text = "Product Code:"
        '
        'tCode
        '
        Me.tCode.BackColor = System.Drawing.Color.Lavender
        Me.tCode.Location = New System.Drawing.Point(105, 83)
        Me.tCode.Name = "tCode"
        Me.tCode.ReadOnly = True
        Me.tCode.Size = New System.Drawing.Size(115, 20)
        Me.tCode.TabIndex = 216
        Me.tCode.Tag = "ProductCode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "Batch No:"
        '
        'tBatchNo
        '
        Me.tBatchNo.Location = New System.Drawing.Point(105, 61)
        Me.tBatchNo.Name = "tBatchNo"
        Me.tBatchNo.Size = New System.Drawing.Size(115, 20)
        Me.tBatchNo.TabIndex = 214
        Me.tBatchNo.Tag = "BatchNo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 219
        Me.Label3.Text = "Product Name:"
        '
        'tDesc
        '
        Me.tDesc.BackColor = System.Drawing.Color.Lavender
        Me.tDesc.Location = New System.Drawing.Point(105, 105)
        Me.tDesc.Name = "tDesc"
        Me.tDesc.ReadOnly = True
        Me.tDesc.Size = New System.Drawing.Size(182, 20)
        Me.tDesc.TabIndex = 218
        Me.tDesc.Tag = "ProductName"
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpiryDate.Location = New System.Drawing.Point(106, 148)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.Size = New System.Drawing.Size(115, 20)
        Me.dtpExpiryDate.TabIndex = 226
        Me.dtpExpiryDate.Tag = "ExpiryDate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(3, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 227
        Me.Label7.Text = "Expiry Date:"
        '
        'dtpMadeDate
        '
        Me.dtpMadeDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpMadeDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMadeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMadeDate.Location = New System.Drawing.Point(106, 126)
        Me.dtpMadeDate.Name = "dtpMadeDate"
        Me.dtpMadeDate.Size = New System.Drawing.Size(115, 20)
        Me.dtpMadeDate.TabIndex = 224
        Me.dtpMadeDate.Tag = "DateMade"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(3, 130)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(102, 13)
        Me.lblDate.TabIndex = 225
        Me.lblDate.Text = "Date Manufactured:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(30, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 5)
        Me.GroupBox1.TabIndex = 230
        Me.GroupBox1.TabStop = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.Lavender
        Me.cmdOk.Location = New System.Drawing.Point(143, 201)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(72, 44)
        Me.cmdOk.TabIndex = 228
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancel.Location = New System.Drawing.Point(214, 201)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(68, 44)
        Me.CmdCancel.TabIndex = 229
        Me.CmdCancel.Text = "&Close"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'cmdProduct
        '
        Me.cmdProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdProduct.Location = New System.Drawing.Point(220, 82)
        Me.cmdProduct.Name = "cmdProduct"
        Me.cmdProduct.Size = New System.Drawing.Size(27, 21)
        Me.cmdProduct.TabIndex = 231
        Me.cmdProduct.Text = "..."
        Me.cmdProduct.UseVisualStyleBackColor = True
        '
        'chkDiscontinue
        '
        Me.chkDiscontinue.AutoSize = True
        Me.chkDiscontinue.Location = New System.Drawing.Point(107, 171)
        Me.chkDiscontinue.Name = "chkDiscontinue"
        Me.chkDiscontinue.Size = New System.Drawing.Size(82, 17)
        Me.chkDiscontinue.TabIndex = 238
        Me.chkDiscontinue.Text = "Discontinue"
        Me.chkDiscontinue.UseVisualStyleBackColor = True
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.Controls.Add(Me.Label9, 1, 0)
        Me.tblHeader.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label10, 1, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.Size = New System.Drawing.Size(289, 52)
        Me.tblHeader.TabIndex = 262
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.GhostWhite
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(80, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 28)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "DRUG BATCHES"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(80, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(209, 24)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Maintains Drug Batches"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmBatches
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.CancelButton = Me.CmdCancel
        Me.ClientSize = New System.Drawing.Size(289, 249)
        Me.Controls.Add(Me.tblHeader)
        Me.Controls.Add(Me.chkDiscontinue)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.cmdProduct)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.dtpExpiryDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpMadeDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tBatchNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBatches"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Drug Batches"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tBatchNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tDesc As System.Windows.Forms.TextBox
    Friend WithEvents dtpExpiryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpMadeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdProduct As System.Windows.Forms.Button
    Friend WithEvents chkDiscontinue As System.Windows.Forms.CheckBox
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
