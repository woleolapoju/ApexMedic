<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMultiSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMultiSelection))
        Me.lbRight = New System.Windows.Forms.ListBox
        Me.lbLeft = New System.Windows.Forms.ListBox
        Me.cmdAllToRight = New System.Windows.Forms.Button
        Me.cmdToRight = New System.Windows.Forms.Button
        Me.cmdlToLeft = New System.Windows.Forms.Button
        Me.cmdAllToLeft = New System.Windows.Forms.Button
        Me.PanMainCommand = New System.Windows.Forms.Panel
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.PanMainCommand.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbRight
        '
        Me.lbRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRight.FormattingEnabled = True
        Me.lbRight.Location = New System.Drawing.Point(2, 2)
        Me.lbRight.Name = "lbRight"
        Me.lbRight.Size = New System.Drawing.Size(174, 264)
        Me.lbRight.TabIndex = 0
        '
        'lbLeft
        '
        Me.lbLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLeft.FormattingEnabled = True
        Me.lbLeft.Location = New System.Drawing.Point(210, 2)
        Me.lbLeft.Name = "lbLeft"
        Me.lbLeft.Size = New System.Drawing.Size(170, 264)
        Me.lbLeft.TabIndex = 1
        '
        'cmdAllToRight
        '
        Me.cmdAllToRight.Location = New System.Drawing.Point(178, 56)
        Me.cmdAllToRight.Name = "cmdAllToRight"
        Me.cmdAllToRight.Size = New System.Drawing.Size(30, 30)
        Me.cmdAllToRight.TabIndex = 55
        Me.cmdAllToRight.Text = ">>"
        Me.cmdAllToRight.UseVisualStyleBackColor = True
        '
        'cmdToRight
        '
        Me.cmdToRight.Location = New System.Drawing.Point(178, 86)
        Me.cmdToRight.Name = "cmdToRight"
        Me.cmdToRight.Size = New System.Drawing.Size(30, 30)
        Me.cmdToRight.TabIndex = 56
        Me.cmdToRight.Text = ">"
        Me.cmdToRight.UseVisualStyleBackColor = True
        '
        'cmdlToLeft
        '
        Me.cmdlToLeft.Location = New System.Drawing.Point(178, 138)
        Me.cmdlToLeft.Name = "cmdlToLeft"
        Me.cmdlToLeft.Size = New System.Drawing.Size(30, 30)
        Me.cmdlToLeft.TabIndex = 57
        Me.cmdlToLeft.Text = "<"
        Me.cmdlToLeft.UseVisualStyleBackColor = True
        '
        'cmdAllToLeft
        '
        Me.cmdAllToLeft.Location = New System.Drawing.Point(178, 168)
        Me.cmdAllToLeft.Name = "cmdAllToLeft"
        Me.cmdAllToLeft.Size = New System.Drawing.Size(30, 30)
        Me.cmdAllToLeft.TabIndex = 58
        Me.cmdAllToLeft.Text = "<<"
        Me.cmdAllToLeft.UseVisualStyleBackColor = True
        '
        'PanMainCommand
        '
        Me.PanMainCommand.BackColor = System.Drawing.Color.LightYellow
        Me.PanMainCommand.Controls.Add(Me.cmdClose)
        Me.PanMainCommand.Controls.Add(Me.cmdOk)
        Me.PanMainCommand.Location = New System.Drawing.Point(2, 270)
        Me.PanMainCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.PanMainCommand.Name = "PanMainCommand"
        Me.PanMainCommand.Size = New System.Drawing.Size(443, 42)
        Me.PanMainCommand.TabIndex = 59
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(317, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(60, 39)
        Me.cmdClose.TabIndex = 251
        Me.cmdClose.Text = "&Cancel"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(256, 0)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(60, 39)
        Me.cmdOk.TabIndex = 250
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'FrmMultiSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 314)
        Me.Controls.Add(Me.PanMainCommand)
        Me.Controls.Add(Me.cmdAllToLeft)
        Me.Controls.Add(Me.cmdlToLeft)
        Me.Controls.Add(Me.cmdToRight)
        Me.Controls.Add(Me.cmdAllToRight)
        Me.Controls.Add(Me.lbLeft)
        Me.Controls.Add(Me.lbRight)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMultiSelection"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Selection"
        Me.PanMainCommand.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbRight As System.Windows.Forms.ListBox
    Friend WithEvents lbLeft As System.Windows.Forms.ListBox
    Friend WithEvents cmdAllToRight As System.Windows.Forms.Button
    Friend WithEvents cmdToRight As System.Windows.Forms.Button
    Friend WithEvents cmdlToLeft As System.Windows.Forms.Button
    Friend WithEvents cmdAllToLeft As System.Windows.Forms.Button
    Friend WithEvents PanMainCommand As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
End Class
