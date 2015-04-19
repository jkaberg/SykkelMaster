<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class innleveringSendMail
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
        Me.rtbBrodtekst = New System.Windows.Forms.RichTextBox()
        Me.txtEmne = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSendMail = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMottaker = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'rtbBrodtekst
        '
        Me.rtbBrodtekst.Location = New System.Drawing.Point(15, 113)
        Me.rtbBrodtekst.Name = "rtbBrodtekst"
        Me.rtbBrodtekst.Size = New System.Drawing.Size(410, 141)
        Me.rtbBrodtekst.TabIndex = 0
        Me.rtbBrodtekst.Text = ""
        '
        'txtEmne
        '
        Me.txtEmne.Location = New System.Drawing.Point(15, 71)
        Me.txtEmne.Name = "txtEmne"
        Me.txtEmne.Size = New System.Drawing.Size(410, 20)
        Me.txtEmne.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Emne"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Brødtekst"
        '
        'btnSendMail
        '
        Me.btnSendMail.Location = New System.Drawing.Point(15, 260)
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(410, 62)
        Me.btnSendMail.TabIndex = 4
        Me.btnSendMail.Text = "Send Mail"
        Me.btnSendMail.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mottaker"
        '
        'TextBox1
        '
        Me.txtMottaker.Enabled = False
        Me.txtMottaker.Location = New System.Drawing.Point(12, 25)
        Me.txtMottaker.Name = "TextBox1"
        Me.txtMottaker.Size = New System.Drawing.Size(410, 20)
        Me.txtMottaker.TabIndex = 6
        '
        'innleveringSendMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 335)
        Me.Controls.Add(Me.txtMottaker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSendMail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmne)
        Me.Controls.Add(Me.rtbBrodtekst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "innleveringSendMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send E-post"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbBrodtekst As System.Windows.Forms.RichTextBox
    Friend WithEvents txtEmne As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSendMail As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMottaker As System.Windows.Forms.TextBox
End Class
