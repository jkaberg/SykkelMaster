<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class utleieOversikt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbOversikt = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbOversikt
        '
        Me.lbOversikt.FormattingEnabled = True
        Me.lbOversikt.ItemHeight = 16
        Me.lbOversikt.Location = New System.Drawing.Point(13, 40)
        Me.lbOversikt.Name = "lbOversikt"
        Me.lbOversikt.Size = New System.Drawing.Size(702, 388)
        Me.lbOversikt.TabIndex = 0
        '
        'utleieOversikt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 456)
        Me.Controls.Add(Me.lbOversikt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "utleieOversikt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "utleieOversikt"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbOversikt As System.Windows.Forms.ListBox
End Class
