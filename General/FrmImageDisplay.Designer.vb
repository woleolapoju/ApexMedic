<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImageDisplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImageDisplay))
        Me.Pict = New System.Windows.Forms.PictureBox
        CType(Me.Pict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pict
        '
        Me.Pict.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pict.Location = New System.Drawing.Point(0, 0)
        Me.Pict.Name = "Pict"
        Me.Pict.Size = New System.Drawing.Size(253, 258)
        Me.Pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pict.TabIndex = 0
        Me.Pict.TabStop = False
        '
        'FrmImageDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(253, 258)
        Me.Controls.Add(Me.Pict)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "FrmImageDisplay"
        Me.ShowInTaskbar = False
        Me.Text = "Image"
        CType(Me.Pict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pict As System.Windows.Forms.PictureBox
End Class
