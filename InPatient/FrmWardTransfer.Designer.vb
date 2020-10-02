<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWardTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWardTransfer))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.tReason = New System.Windows.Forms.TextBox
        Me.tRefNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tCBed = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tCWard = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tPatient = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cBedNo = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cWard = New System.Windows.Forms.ComboBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.lvlist = New System.Windows.Forms.ListView
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanHeading.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(91, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 3)
        Me.GroupBox1.TabIndex = 260
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 258
        Me.Label5.Text = "Reason:"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(210, 192)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 51)
        Me.cmdClose.TabIndex = 251
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'PanHeading
        '
        Me.PanHeading.Controls.Add(Me.tReason)
        Me.PanHeading.Controls.Add(Me.tRefNo)
        Me.PanHeading.Controls.Add(Me.Label6)
        Me.PanHeading.Controls.Add(Me.tCBed)
        Me.PanHeading.Controls.Add(Me.Label3)
        Me.PanHeading.Controls.Add(Me.tCWard)
        Me.PanHeading.Controls.Add(Me.Label1)
        Me.PanHeading.Controls.Add(Me.tPatient)
        Me.PanHeading.Controls.Add(Me.Label18)
        Me.PanHeading.Controls.Add(Me.Label4)
        Me.PanHeading.Controls.Add(Me.cBedNo)
        Me.PanHeading.Controls.Add(Me.Label11)
        Me.PanHeading.Controls.Add(Me.cWard)
        Me.PanHeading.Controls.Add(Me.GroupBox1)
        Me.PanHeading.Controls.Add(Me.Label5)
        Me.PanHeading.Controls.Add(Me.cmdClose)
        Me.PanHeading.Controls.Add(Me.cmdOk)
        Me.PanHeading.Controls.Add(Me.Label2)
        Me.PanHeading.Controls.Add(Me.dtpDate)
        Me.PanHeading.Location = New System.Drawing.Point(364, 55)
        Me.PanHeading.Margin = New System.Windows.Forms.Padding(0)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(289, 249)
        Me.PanHeading.TabIndex = 57
        '
        'tReason
        '
        Me.tReason.Location = New System.Drawing.Point(83, 161)
        Me.tReason.Name = "tReason"
        Me.tReason.Size = New System.Drawing.Size(202, 20)
        Me.tReason.TabIndex = 274
        '
        'tRefNo
        '
        Me.tRefNo.Location = New System.Drawing.Point(83, 27)
        Me.tRefNo.Name = "tRefNo"
        Me.tRefNo.ReadOnly = True
        Me.tRefNo.Size = New System.Drawing.Size(103, 20)
        Me.tRefNo.TabIndex = 273
        Me.tRefNo.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 272
        Me.Label6.Text = "Ref. No:"
        '
        'tCBed
        '
        Me.tCBed.Location = New System.Drawing.Point(83, 91)
        Me.tCBed.Name = "tCBed"
        Me.tCBed.ReadOnly = True
        Me.tCBed.Size = New System.Drawing.Size(103, 20)
        Me.tCBed.TabIndex = 271
        Me.tCBed.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "Current Bed:"
        '
        'tCWard
        '
        Me.tCWard.Location = New System.Drawing.Point(83, 70)
        Me.tCWard.Name = "tCWard"
        Me.tCWard.ReadOnly = True
        Me.tCWard.Size = New System.Drawing.Size(103, 20)
        Me.tCWard.TabIndex = 269
        Me.tCWard.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 268
        Me.Label1.Text = "Current Ward:"
        '
        'tPatient
        '
        Me.tPatient.Location = New System.Drawing.Point(83, 48)
        Me.tPatient.Name = "tPatient"
        Me.tPatient.ReadOnly = True
        Me.tPatient.Size = New System.Drawing.Size(201, 20)
        Me.tPatient.TabIndex = 267
        Me.tPatient.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 266
        Me.Label18.Text = "Patient"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 264
        Me.Label4.Text = "Bed:"
        '
        'cBedNo
        '
        Me.cBedNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBedNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cBedNo.FormattingEnabled = True
        Me.cBedNo.Location = New System.Drawing.Point(83, 137)
        Me.cBedNo.Name = "cBedNo"
        Me.cBedNo.Size = New System.Drawing.Size(112, 21)
        Me.cBedNo.TabIndex = 265
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 262
        Me.Label11.Text = "Ward:"
        '
        'cWard
        '
        Me.cWard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cWard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cWard.FormattingEnabled = True
        Me.cWard.Location = New System.Drawing.Point(83, 114)
        Me.cWard.Name = "cWard"
        Me.cWard.Size = New System.Drawing.Size(112, 21)
        Me.cWard.TabIndex = 263
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(135, 192)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 51)
        Me.cmdOk.TabIndex = 250
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Date:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(83, 5)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(101, 20)
        Me.dtpDate.TabIndex = 42
        Me.dtpDate.Tag = "RegDate"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "RefNo"
        Me.ColumnHeader1.Width = 49
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Date Admitted"
        Me.ColumnHeader11.Width = 73
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Patient No"
        Me.ColumnHeader7.Width = 57
        '
        'lvlist
        '
        Me.lvlist.BackColor = System.Drawing.Color.GhostWhite
        Me.lvlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader11, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader12, Me.ColumnHeader2})
        Me.lvlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlist.FullRowSelect = True
        Me.lvlist.GridLines = True
        Me.lvlist.HideSelection = False
        Me.lvlist.Location = New System.Drawing.Point(3, 58)
        Me.lvlist.MultiSelect = False
        Me.lvlist.Name = "lvlist"
        Me.lvlist.Size = New System.Drawing.Size(358, 419)
        Me.lvlist.TabIndex = 52
        Me.lvlist.UseCompatibleStateImageBehavior = False
        Me.lvlist.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Surname"
        Me.ColumnHeader8.Width = 72
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Othernames"
        Me.ColumnHeader9.Width = 74
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Ward"
        Me.ColumnHeader12.Width = 45
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "BedNo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.Controls.Add(Me.lvlist, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tblHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanHeading, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(653, 480)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.tblHeader, 2)
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
        Me.tblHeader.Size = New System.Drawing.Size(653, 55)
        Me.tblHeader.TabIndex = 51
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
        Me.Label7.Size = New System.Drawing.Size(573, 30)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "WARD TRANSFER"
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
        Me.Label8.Size = New System.Drawing.Size(573, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Manages the transfer of Patients from one ward to another"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmWardTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 480)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWardTransfer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ward Transfer"
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvlist As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cBedNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cWard As System.Windows.Forms.ComboBox
    Friend WithEvents tCBed As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tCWard As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tPatient As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tReason As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
