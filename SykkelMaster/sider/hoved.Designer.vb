<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hoved
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
        Me.btnVis_Kunder = New System.Windows.Forms.Button()
        Me.btnVis_Utleie = New System.Windows.Forms.Button()
        Me.btnVis_Lokasjoner = New System.Windows.Forms.Button()
        Me.btnVis_Sykler = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxPlassering = New System.Windows.Forms.ComboBox()
        Me.btnVis_Brukere = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVis_innlevering = New System.Windows.Forms.Button()
        Me.btnBytt_Passord = New System.Windows.Forms.Button()
        Me.btnLogg_ut = New System.Windows.Forms.Button()
        Me.btnStatistikk = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVis_Kunder
        '
        Me.btnVis_Kunder.Enabled = False
        Me.btnVis_Kunder.Location = New System.Drawing.Point(261, 129)
        Me.btnVis_Kunder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVis_Kunder.Name = "btnVis_Kunder"
        Me.btnVis_Kunder.Size = New System.Drawing.Size(143, 49)
        Me.btnVis_Kunder.TabIndex = 4
        Me.btnVis_Kunder.Text = "Kunder"
        Me.btnVis_Kunder.UseVisualStyleBackColor = True
        '
        'btnVis_Utleie
        '
        Me.btnVis_Utleie.Enabled = False
        Me.btnVis_Utleie.Location = New System.Drawing.Point(13, 129)
        Me.btnVis_Utleie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVis_Utleie.Name = "btnVis_Utleie"
        Me.btnVis_Utleie.Size = New System.Drawing.Size(143, 49)
        Me.btnVis_Utleie.TabIndex = 2
        Me.btnVis_Utleie.Text = "Utleie"
        Me.btnVis_Utleie.UseVisualStyleBackColor = True
        '
        'btnVis_Lokasjoner
        '
        Me.btnVis_Lokasjoner.Enabled = False
        Me.btnVis_Lokasjoner.Location = New System.Drawing.Point(13, 185)
        Me.btnVis_Lokasjoner.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVis_Lokasjoner.Name = "btnVis_Lokasjoner"
        Me.btnVis_Lokasjoner.Size = New System.Drawing.Size(143, 49)
        Me.btnVis_Lokasjoner.TabIndex = 5
        Me.btnVis_Lokasjoner.Text = "Lokasjoner"
        Me.btnVis_Lokasjoner.UseVisualStyleBackColor = True
        '
        'btnVis_Sykler
        '
        Me.btnVis_Sykler.Location = New System.Drawing.Point(261, 74)
        Me.btnVis_Sykler.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVis_Sykler.Name = "btnVis_Sykler"
        Me.btnVis_Sykler.Size = New System.Drawing.Size(143, 49)
        Me.btnVis_Sykler.TabIndex = 3
        Me.btnVis_Sykler.Text = "Sykler"
        Me.btnVis_Sykler.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxPlassering)
        Me.GroupBox2.Location = New System.Drawing.Point(261, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(143, 57)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lokasjon"
        '
        'cbxPlassering
        '
        Me.cbxPlassering.FormattingEnabled = True
        Me.cbxPlassering.Location = New System.Drawing.Point(7, 22)
        Me.cbxPlassering.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxPlassering.Name = "cbxPlassering"
        Me.cbxPlassering.Size = New System.Drawing.Size(121, 24)
        Me.cbxPlassering.TabIndex = 0
        '
        'btnVis_Brukere
        '
        Me.btnVis_Brukere.Enabled = False
        Me.btnVis_Brukere.Location = New System.Drawing.Point(261, 185)
        Me.btnVis_Brukere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVis_Brukere.Name = "btnVis_Brukere"
        Me.btnVis_Brukere.Size = New System.Drawing.Size(143, 49)
        Me.btnVis_Brukere.TabIndex = 6
        Me.btnVis_Brukere.Text = "Brukere"
        Me.btnVis_Brukere.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(243, 57)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informasjon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Velkommen, "
        '
        'btnVis_innlevering
        '
        Me.btnVis_innlevering.Location = New System.Drawing.Point(12, 74)
        Me.btnVis_innlevering.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVis_innlevering.Name = "btnVis_innlevering"
        Me.btnVis_innlevering.Size = New System.Drawing.Size(143, 49)
        Me.btnVis_innlevering.TabIndex = 1
        Me.btnVis_innlevering.Text = "Innlevering"
        Me.btnVis_innlevering.UseVisualStyleBackColor = True
        '
        'btnBytt_Passord
        '
        Me.btnBytt_Passord.Location = New System.Drawing.Point(12, 239)
        Me.btnBytt_Passord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBytt_Passord.Name = "btnBytt_Passord"
        Me.btnBytt_Passord.Size = New System.Drawing.Size(143, 49)
        Me.btnBytt_Passord.TabIndex = 7
        Me.btnBytt_Passord.Text = "Endre Passord"
        Me.btnBytt_Passord.UseVisualStyleBackColor = True
        '
        'btnLogg_ut
        '
        Me.btnLogg_ut.Location = New System.Drawing.Point(261, 239)
        Me.btnLogg_ut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogg_ut.Name = "btnLogg_ut"
        Me.btnLogg_ut.Size = New System.Drawing.Size(143, 49)
        Me.btnLogg_ut.TabIndex = 8
        Me.btnLogg_ut.Text = "Logg ut"
        Me.btnLogg_ut.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.btnStatistikk.Location = New System.Drawing.Point(137, 292)
        Me.btnStatistikk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStatistikk.Name = "Button1"
        Me.btnStatistikk.Size = New System.Drawing.Size(143, 49)
        Me.btnStatistikk.TabIndex = 9
        Me.btnStatistikk.Text = "Statistikk"
        Me.btnStatistikk.UseVisualStyleBackColor = True
        '
        'hoved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 342)
        Me.Controls.Add(Me.btnStatistikk)
        Me.Controls.Add(Me.btnLogg_ut)
        Me.Controls.Add(Me.btnBytt_Passord)
        Me.Controls.Add(Me.btnVis_innlevering)
        Me.Controls.Add(Me.btnVis_Sykler)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVis_Brukere)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnVis_Lokasjoner)
        Me.Controls.Add(Me.btnVis_Utleie)
        Me.Controls.Add(Me.btnVis_Kunder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "hoved"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sykkelmaster"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVis_Kunder As System.Windows.Forms.Button
    Friend WithEvents btnVis_Utleie As System.Windows.Forms.Button
    Friend WithEvents btnVis_Lokasjoner As System.Windows.Forms.Button
    Friend WithEvents btnVis_Sykler As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxPlassering As System.Windows.Forms.ComboBox
    Friend WithEvents btnVis_Brukere As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVis_innlevering As System.Windows.Forms.Button
    Friend WithEvents btnBytt_Passord As System.Windows.Forms.Button
    Friend WithEvents btnLogg_ut As System.Windows.Forms.Button
    Friend WithEvents btnStatistikk As System.Windows.Forms.Button
End Class
