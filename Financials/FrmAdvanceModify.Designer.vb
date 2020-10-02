<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdvanceModify
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdvanceModify))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdLoad = New System.Windows.Forms.Button
        Me.tAccountName = New System.Windows.Forms.TextBox
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.cmdAccount = New System.Windows.Forms.Button
        Me.tAccountCode = New System.Windows.Forms.TextBox
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.lblAccount = New System.Windows.Forms.Label
        Me.lblPatientNo = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.lblEnd = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblStart = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cTransType = New System.Windows.Forms.ComboBox
        Me.DbGrid = New System.Windows.Forms.DataGridView
        Me.wole = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.wale = New System.Windows.Forms.DataGridViewButtonColumn
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tblHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DbGrid, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1131, 504)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.tblHeader.Size = New System.Drawing.Size(1131, 64)
        Me.tblHeader.TabIndex = 57
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
        Me.Label7.Size = New System.Drawing.Size(1020, 32)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ADVANCE MODIFICATION OF FINANCIAL ENTRIES"
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
        Me.PictureBox1.Size = New System.Drawing.Size(111, 64)
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
        Me.Label8.Location = New System.Drawing.Point(111, 32)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1020, 32)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "-"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightYellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.cmdLoad)
        Me.Panel1.Controls.Add(Me.tAccountName)
        Me.Panel1.Controls.Add(Me.tPatientName)
        Me.Panel1.Controls.Add(Me.cmdAccount)
        Me.Panel1.Controls.Add(Me.tAccountCode)
        Me.Panel1.Controls.Add(Me.cmdPatient)
        Me.Panel1.Controls.Add(Me.tPatientNo)
        Me.Panel1.Controls.Add(Me.lblAccount)
        Me.Panel1.Controls.Add(Me.lblPatientNo)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cTransType)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1125, 62)
        Me.Panel1.TabIndex = 58
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Location = New System.Drawing.Point(832, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(113, 42)
        Me.Panel6.TabIndex = 280
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(4, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(22, 14)
        Me.Panel4.TabIndex = 276
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 279
        Me.Label2.Text = "Edited entry"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 277
        Me.Label1.Text = "Can't be edited"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(4, 23)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(22, 14)
        Me.Panel5.TabIndex = 278
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdOk)
        Me.Panel3.Controls.Add(Me.cmdClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(962, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(161, 60)
        Me.Panel3.TabIndex = 275
        '
        'cmdOk
        '
        Me.cmdOk.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdOk.Location = New System.Drawing.Point(0, 0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(94, 60)
        Me.cmdOk.TabIndex = 274
        Me.cmdOk.Text = "&Update"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClose.Location = New System.Drawing.Point(93, 0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(68, 60)
        Me.cmdClose.TabIndex = 273
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(99, 29)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(162, 30)
        Me.cmdLoad.TabIndex = 272
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'tAccountName
        '
        Me.tAccountName.Location = New System.Drawing.Point(635, 27)
        Me.tAccountName.Name = "tAccountName"
        Me.tAccountName.ReadOnly = True
        Me.tAccountName.Size = New System.Drawing.Size(191, 20)
        Me.tAccountName.TabIndex = 271
        Me.tAccountName.Tag = ""
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(634, 4)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(192, 20)
        Me.tPatientName.TabIndex = 270
        Me.tPatientName.Tag = ""
        '
        'cmdAccount
        '
        Me.cmdAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAccount.Location = New System.Drawing.Point(608, 27)
        Me.cmdAccount.Name = "cmdAccount"
        Me.cmdAccount.Size = New System.Drawing.Size(26, 21)
        Me.cmdAccount.TabIndex = 269
        Me.cmdAccount.Text = "..."
        Me.cmdAccount.UseVisualStyleBackColor = True
        '
        'tAccountCode
        '
        Me.tAccountCode.Location = New System.Drawing.Point(530, 27)
        Me.tAccountCode.Name = "tAccountCode"
        Me.tAccountCode.Size = New System.Drawing.Size(77, 20)
        Me.tAccountCode.TabIndex = 268
        Me.tAccountCode.Tag = ""
        '
        'cmdPatient
        '
        Me.cmdPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPatient.Location = New System.Drawing.Point(608, 4)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 266
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(530, 4)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(77, 20)
        Me.tPatientNo.TabIndex = 264
        Me.tPatientNo.Tag = ""
        '
        'lblAccount
        '
        Me.lblAccount.Location = New System.Drawing.Point(467, 30)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(55, 14)
        Me.lblAccount.TabIndex = 267
        Me.lblAccount.Text = "Account:"
        '
        'lblPatientNo
        '
        Me.lblPatientNo.AutoSize = True
        Me.lblPatientNo.Location = New System.Drawing.Point(468, 7)
        Me.lblPatientNo.Name = "lblPatientNo"
        Me.lblPatientNo.Size = New System.Drawing.Size(43, 13)
        Me.lblPatientNo.TabIndex = 265
        Me.lblPatientNo.Text = "Patient:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dtpEndDate)
        Me.Panel2.Controls.Add(Me.lblEnd)
        Me.Panel2.Controls.Add(Me.dtpStartDate)
        Me.Panel2.Controls.Add(Me.lblStart)
        Me.Panel2.Location = New System.Drawing.Point(273, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 56)
        Me.Panel2.TabIndex = 258
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(65, 28)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.ShowCheckBox = True
        Me.dtpEndDate.Size = New System.Drawing.Size(116, 20)
        Me.dtpEndDate.TabIndex = 263
        Me.dtpEndDate.Tag = "Date"
        '
        'lblEnd
        '
        Me.lblEnd.Location = New System.Drawing.Point(3, 32)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(55, 15)
        Me.lblEnd.TabIndex = 264
        Me.lblEnd.Text = "End Date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(65, 6)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.ShowCheckBox = True
        Me.dtpStartDate.Size = New System.Drawing.Size(116, 20)
        Me.dtpStartDate.TabIndex = 261
        Me.dtpStartDate.Tag = "Date"
        '
        'lblStart
        '
        Me.lblStart.Location = New System.Drawing.Point(3, 10)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(68, 15)
        Me.lblStart.TabIndex = 262
        Me.lblStart.Text = "Start Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 257
        Me.Label11.Text = "Transaction Type:"
        '
        'cTransType
        '
        Me.cTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTransType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cTransType.FormattingEnabled = True
        Me.cTransType.Items.AddRange(New Object() {"Bills", "Bulk Payments", "Service Based Payments", "Discounts", "Refunds"})
        Me.cTransType.Location = New System.Drawing.Point(101, 5)
        Me.cTransType.Name = "cTransType"
        Me.cTransType.Size = New System.Drawing.Size(162, 21)
        Me.cTransType.TabIndex = 256
        '
        'DbGrid
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DbGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DbGrid.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DbGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.wole, Me.wale})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DbGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.DbGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGrid.Location = New System.Drawing.Point(3, 135)
        Me.DbGrid.MultiSelect = False
        Me.DbGrid.Name = "DbGrid"
        Me.DbGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DbGrid.Size = New System.Drawing.Size(1125, 366)
        Me.DbGrid.TabIndex = 59
        '
        'wole
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.wole.DefaultCellStyle = DataGridViewCellStyle3
        Me.wole.HeaderText = "Column1"
        Me.wole.Name = "wole"
        '
        'wale
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = "Del"
        Me.wale.DefaultCellStyle = DataGridViewCellStyle4
        Me.wale.HeaderText = "Delete"
        Me.wale.Name = "wale"
        Me.wale.Text = "wole"
        '
        'FrmAdvanceModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 504)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdvanceModify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance Modify"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cTransType As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents cmdAccount As System.Windows.Forms.Button
    Friend WithEvents tAccountCode As System.Windows.Forms.TextBox
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents lblPatientNo As System.Windows.Forms.Label
    Friend WithEvents tAccountName As System.Windows.Forms.TextBox
    Friend WithEvents DbGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents wole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wale As System.Windows.Forms.DataGridViewButtonColumn
End Class
