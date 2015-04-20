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
        Me.btnOprettAvtale = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbOversikt
        '
        Me.lbOversikt.FormattingEnabled = True
        Me.lbOversikt.ItemHeight = 16
        Me.lbOversikt.Location = New System.Drawing.Point(13, 39)
        Me.lbOversikt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbOversikt.Name = "lbOversikt"
        Me.lbOversikt.Size = New System.Drawing.Size(491, 452)
        Me.lbOversikt.TabIndex = 0
        '
        'btnOprettAvtale
        '
        Me.btnOprettAvtale.Location = New System.Drawing.Point(388, 497)
        Me.btnOprettAvtale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOprettAvtale.Name = "btnOprettAvtale"
        Me.btnOprettAvtale.Size = New System.Drawing.Size(117, 49)
        Me.btnOprettAvtale.TabIndex = 41
        Me.btnOprettAvtale.Text = "Opprett avtale"
        Me.btnOprettAvtale.UseVisualStyleBackColor = True
        '
        'utleieOversikt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 551)
        Me.Controls.Add(Me.btnOprettAvtale)
        Me.Controls.Add(Me.lbOversikt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "utleieOversikt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avtale oversikt"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbOversikt As System.Windows.Forms.ListBox
    Friend WithEvents btnOprettAvtale As System.Windows.Forms.Button
End Class
