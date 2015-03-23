<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndrePassord
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nåværendePassordtxt = New System.Windows.Forms.TextBox()
        Me.nyttPassordtxt = New System.Windows.Forms.TextBox()
        Me.btnBytt_Passord = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nåværende Passord"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nytt Passord"
        '
        'nåværendePassordtxt
        '
        Me.nåværendePassordtxt.Location = New System.Drawing.Point(122, 17)
        Me.nåværendePassordtxt.Name = "nåværendePassordtxt"
        Me.nåværendePassordtxt.Size = New System.Drawing.Size(151, 20)
        Me.nåværendePassordtxt.TabIndex = 4
        '
        'nyttPassordtxt
        '
        Me.nyttPassordtxt.Location = New System.Drawing.Point(122, 41)
        Me.nyttPassordtxt.Name = "nyttPassordtxt"
        Me.nyttPassordtxt.Size = New System.Drawing.Size(151, 20)
        Me.nyttPassordtxt.TabIndex = 5
        '
        'btnBytt_Passord
        '
        Me.btnBytt_Passord.Location = New System.Drawing.Point(6, 65)
        Me.btnBytt_Passord.Name = "btnBytt_Passord"
        Me.btnBytt_Passord.Size = New System.Drawing.Size(266, 19)
        Me.btnBytt_Passord.TabIndex = 6
        Me.btnBytt_Passord.Text = "Bytt Passord"
        Me.btnBytt_Passord.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnBytt_Passord)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.nyttPassordtxt)
        Me.GroupBox1.Controls.Add(Me.nåværendePassordtxt)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(277, 89)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Endre passord"
        '
        'EndrePassord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 110)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EndrePassord"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Endre Passord"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nåværendePassordtxt As System.Windows.Forms.TextBox
    Friend WithEvents nyttPassordtxt As System.Windows.Forms.TextBox
    Friend WithEvents btnBytt_Passord As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
