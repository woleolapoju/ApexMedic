<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPatientHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPatientHistory))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.PanHeading = New System.Windows.Forms.Panel
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.tAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tPatientName = New System.Windows.Forms.TextBox
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.tPatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabHistory = New System.Windows.Forms.TabControl
        Me.TabFamily = New System.Windows.Forms.TabPage
        Me.tFamily = New System.Windows.Forms.TextBox
        Me.TabMedical = New System.Windows.Forms.TabPage
        Me.tMedical = New System.Windows.Forms.TextBox
        Me.TabAllergy = New System.Windows.Forms.TabPage
        Me.tAllergy = New System.Windows.Forms.TextBox
        Me.TabSocial = New System.Windows.Forms.TabPage
        Me.tSocial = New System.Windows.Forms.TextBox
        Me.TabObsGyn = New System.Windows.Forms.TabPage
        Me.lblNotApplicable = New System.Windows.Forms.Label
        Me.tObsGyn = New System.Windows.Forms.TextBox
        Me.PanPatient = New System.Windows.Forms.Panel
        Me.cmdClose2 = New System.Windows.Forms.Button
        Me.tPatientName1 = New System.Windows.Forms.TextBox
        Me.tPatientNo1 = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanHeading.SuspendLayout()
        Me.TabHistory.SuspendLayout()
        Me.TabFamily.SuspendLayout()
        Me.TabMedical.SuspendLayout()
        Me.TabAllergy.SuspendLayout()
        Me.TabSocial.SuspendLayout()
        Me.TabObsGyn.SuspendLayout()
        Me.PanPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tblHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanHeading, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabHistory, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PanPatient, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(341, 384)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.tblHeader.Size = New System.Drawing.Size(341, 52)
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
        Me.Label9.Size = New System.Drawing.Size(261, 28)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "PATIENT HISTORY"
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
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(80, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(261, 24)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Maintains History of Patients"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanHeading
        '
        Me.PanHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanHeading.Controls.Add(Me.cmdOk)
        Me.PanHeading.Controls.Add(Me.cmdClose)
        Me.PanHeading.Controls.Add(Me.tAccount)
        Me.PanHeading.Controls.Add(Me.Label16)
        Me.PanHeading.Controls.Add(Me.tPatientName)
        Me.PanHeading.Controls.Add(Me.cmdPatient)
        Me.PanHeading.Controls.Add(Me.tPatientNo)
        Me.PanHeading.Controls.Add(Me.Label4)
        Me.PanHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanHeading.Location = New System.Drawing.Point(3, 55)
        Me.PanHeading.Name = "PanHeading"
        Me.PanHeading.Size = New System.Drawing.Size(335, 83)
        Me.PanHeading.TabIndex = 263
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(224, 48)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(53, 31)
        Me.cmdOk.TabIndex = 256
        Me.cmdOk.Text = "&Save"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(278, 48)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(53, 31)
        Me.cmdClose.TabIndex = 255
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'tAccount
        '
        Me.tAccount.Location = New System.Drawing.Point(80, 24)
        Me.tAccount.Name = "tAccount"
        Me.tAccount.ReadOnly = True
        Me.tAccount.Size = New System.Drawing.Size(250, 20)
        Me.tAccount.TabIndex = 51
        Me.tAccount.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Account:"
        '
        'tPatientName
        '
        Me.tPatientName.Location = New System.Drawing.Point(174, 3)
        Me.tPatientName.Name = "tPatientName"
        Me.tPatientName.ReadOnly = True
        Me.tPatientName.Size = New System.Drawing.Size(156, 20)
        Me.tPatientName.TabIndex = 45
        Me.tPatientName.TabStop = False
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(148, 2)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(26, 21)
        Me.cmdPatient.TabIndex = 7
        Me.cmdPatient.Text = "..."
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'tPatientNo
        '
        Me.tPatientNo.Location = New System.Drawing.Point(80, 3)
        Me.tPatientNo.Name = "tPatientNo"
        Me.tPatientNo.Size = New System.Drawing.Size(68, 20)
        Me.tPatientNo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Patient No:"
        '
        'TabHistory
        '
        Me.TabHistory.Controls.Add(Me.TabFamily)
        Me.TabHistory.Controls.Add(Me.TabMedical)
        Me.TabHistory.Controls.Add(Me.TabAllergy)
        Me.TabHistory.Controls.Add(Me.TabSocial)
        Me.TabHistory.Controls.Add(Me.TabObsGyn)
        Me.TabHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabHistory.Location = New System.Drawing.Point(3, 181)
        Me.TabHistory.Name = "TabHistory"
        Me.TabHistory.SelectedIndex = 0
        Me.TabHistory.Size = New System.Drawing.Size(335, 200)
        Me.TabHistory.TabIndex = 264
        '
        'TabFamily
        '
        Me.TabFamily.Controls.Add(Me.tFamily)
        Me.TabFamily.Location = New System.Drawing.Point(4, 22)
        Me.TabFamily.Name = "TabFamily"
        Me.TabFamily.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFamily.Size = New System.Drawing.Size(327, 174)
        Me.TabFamily.TabIndex = 0
        Me.TabFamily.Text = "Family"
        Me.TabFamily.UseVisualStyleBackColor = True
        '
        'tFamily
        '
        Me.tFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tFamily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tFamily.Location = New System.Drawing.Point(3, 3)
        Me.tFamily.Multiline = True
        Me.tFamily.Name = "tFamily"
        Me.tFamily.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tFamily.Size = New System.Drawing.Size(321, 168)
        Me.tFamily.TabIndex = 1
        '
        'TabMedical
        '
        Me.TabMedical.Controls.Add(Me.tMedical)
        Me.TabMedical.Location = New System.Drawing.Point(4, 22)
        Me.TabMedical.Name = "TabMedical"
        Me.TabMedical.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMedical.Size = New System.Drawing.Size(327, 174)
        Me.TabMedical.TabIndex = 1
        Me.TabMedical.Text = "Medical"
        Me.TabMedical.UseVisualStyleBackColor = True
        '
        'tMedical
        '
        Me.tMedical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tMedical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tMedical.Location = New System.Drawing.Point(3, 3)
        Me.tMedical.Multiline = True
        Me.tMedical.Name = "tMedical"
        Me.tMedical.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tMedical.Size = New System.Drawing.Size(321, 168)
        Me.tMedical.TabIndex = 2
        '
        'TabAllergy
        '
        Me.TabAllergy.Controls.Add(Me.tAllergy)
        Me.TabAllergy.Location = New System.Drawing.Point(4, 22)
        Me.TabAllergy.Name = "TabAllergy"
        Me.TabAllergy.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAllergy.Size = New System.Drawing.Size(327, 174)
        Me.TabAllergy.TabIndex = 2
        Me.TabAllergy.Text = "Allergy"
        Me.TabAllergy.UseVisualStyleBackColor = True
        '
        'tAllergy
        '
        Me.tAllergy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tAllergy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tAllergy.Location = New System.Drawing.Point(3, 3)
        Me.tAllergy.Multiline = True
        Me.tAllergy.Name = "tAllergy"
        Me.tAllergy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tAllergy.Size = New System.Drawing.Size(321, 168)
        Me.tAllergy.TabIndex = 2
        '
        'TabSocial
        '
        Me.TabSocial.Controls.Add(Me.tSocial)
        Me.TabSocial.Location = New System.Drawing.Point(4, 22)
        Me.TabSocial.Name = "TabSocial"
        Me.TabSocial.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSocial.Size = New System.Drawing.Size(327, 174)
        Me.TabSocial.TabIndex = 3
        Me.TabSocial.Text = "Social"
        Me.TabSocial.UseVisualStyleBackColor = True
        '
        'tSocial
        '
        Me.tSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tSocial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tSocial.Location = New System.Drawing.Point(3, 3)
        Me.tSocial.Multiline = True
        Me.tSocial.Name = "tSocial"
        Me.tSocial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tSocial.Size = New System.Drawing.Size(321, 168)
        Me.tSocial.TabIndex = 3
        '
        'TabObsGyn
        '
        Me.TabObsGyn.Controls.Add(Me.lblNotApplicable)
        Me.TabObsGyn.Controls.Add(Me.tObsGyn)
        Me.TabObsGyn.Location = New System.Drawing.Point(4, 22)
        Me.TabObsGyn.Name = "TabObsGyn"
        Me.TabObsGyn.Padding = New System.Windows.Forms.Padding(3)
        Me.TabObsGyn.Size = New System.Drawing.Size(327, 174)
        Me.TabObsGyn.TabIndex = 4
        Me.TabObsGyn.Text = "OBS/GYN"
        Me.TabObsGyn.ToolTipText = "Obstratics & Gynaecology"
        Me.TabObsGyn.UseVisualStyleBackColor = True
        '
        'lblNotApplicable
        '
        Me.lblNotApplicable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNotApplicable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotApplicable.ForeColor = System.Drawing.Color.Red
        Me.lblNotApplicable.Location = New System.Drawing.Point(3, 3)
        Me.lblNotApplicable.Name = "lblNotApplicable"
        Me.lblNotApplicable.Size = New System.Drawing.Size(321, 168)
        Me.lblNotApplicable.TabIndex = 2
        Me.lblNotApplicable.Text = "Not Applicable"
        Me.lblNotApplicable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tObsGyn
        '
        Me.tObsGyn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tObsGyn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tObsGyn.Location = New System.Drawing.Point(3, 3)
        Me.tObsGyn.Multiline = True
        Me.tObsGyn.Name = "tObsGyn"
        Me.tObsGyn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tObsGyn.Size = New System.Drawing.Size(321, 168)
        Me.tObsGyn.TabIndex = 3
        '
        'PanPatient
        '
        Me.PanPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanPatient.Controls.Add(Me.cmdClose2)
        Me.PanPatient.Controls.Add(Me.tPatientName1)
        Me.PanPatient.Controls.Add(Me.tPatientNo1)
        Me.PanPatient.Location = New System.Drawing.Point(3, 144)
        Me.PanPatient.Name = "PanPatient"
        Me.PanPatient.Size = New System.Drawing.Size(335, 31)
        Me.PanPatient.TabIndex = 265
        '
        'cmdClose2
        '
        Me.cmdClose2.Location = New System.Drawing.Point(277, 1)
        Me.cmdClose2.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose2.Name = "cmdClose2"
        Me.cmdClose2.Size = New System.Drawing.Size(53, 26)
        Me.cmdClose2.TabIndex = 256
        Me.cmdClose2.Text = "&Close"
        Me.cmdClose2.UseVisualStyleBackColor = True
        '
        'tPatientName1
        '
        Me.tPatientName1.BackColor = System.Drawing.Color.LightYellow
        Me.tPatientName1.Location = New System.Drawing.Point(77, 5)
        Me.tPatientName1.Name = "tPatientName1"
        Me.tPatientName1.ReadOnly = True
        Me.tPatientName1.Size = New System.Drawing.Size(197, 20)
        Me.tPatientName1.TabIndex = 47
        Me.tPatientName1.TabStop = False
        '
        'tPatientNo1
        '
        Me.tPatientNo1.BackColor = System.Drawing.Color.LightYellow
        Me.tPatientNo1.Location = New System.Drawing.Point(2, 5)
        Me.tPatientNo1.Name = "tPatientNo1"
        Me.tPatientNo1.ReadOnly = True
        Me.tPatientNo1.Size = New System.Drawing.Size(70, 20)
        Me.tPatientNo1.TabIndex = 46
        Me.tPatientNo1.TabStop = False
        '
        'FrmPatientHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(341, 384)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPatientHistory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient History"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanHeading.ResumeLayout(False)
        Me.PanHeading.PerformLayout()
        Me.TabHistory.ResumeLayout(False)
        Me.TabFamily.ResumeLayout(False)
        Me.TabFamily.PerformLayout()
        Me.TabMedical.ResumeLayout(False)
        Me.TabMedical.PerformLayout()
        Me.TabAllergy.ResumeLayout(False)
        Me.TabAllergy.PerformLayout()
        Me.TabSocial.ResumeLayout(False)
        Me.TabSocial.PerformLayout()
        Me.TabObsGyn.ResumeLayout(False)
        Me.TabObsGyn.PerformLayout()
        Me.PanPatient.ResumeLayout(False)
        Me.PanPatient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PanHeading As System.Windows.Forms.Panel
    Friend WithEvents tAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tPatientName As System.Windows.Forms.TextBox
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents tPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabHistory As System.Windows.Forms.TabControl
    Friend WithEvents TabFamily As System.Windows.Forms.TabPage
    Friend WithEvents TabMedical As System.Windows.Forms.TabPage
    Friend WithEvents TabAllergy As System.Windows.Forms.TabPage
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents PanPatient As System.Windows.Forms.Panel
    Friend WithEvents tPatientName1 As System.Windows.Forms.TextBox
    Friend WithEvents tPatientNo1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose2 As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents tFamily As System.Windows.Forms.TextBox
    Friend WithEvents tMedical As System.Windows.Forms.TextBox
    Friend WithEvents tAllergy As System.Windows.Forms.TextBox
    Friend WithEvents TabSocial As System.Windows.Forms.TabPage
    Friend WithEvents TabObsGyn As System.Windows.Forms.TabPage
    Friend WithEvents tSocial As System.Windows.Forms.TextBox
    Friend WithEvents tObsGyn As System.Windows.Forms.TextBox
    Friend WithEvents lblNotApplicable As System.Windows.Forms.Label
End Class
