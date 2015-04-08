<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bruker
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.brukerGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxArbedidssted = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProvisjonBar = New System.Windows.Forms.HScrollBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxStilling = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSlett_Bruker = New System.Windows.Forms.Button()
        Me.btnOppdater_Bruker = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.btnLegg_til_Bruker = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPostnr = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.txtEtternavn = New System.Windows.Forms.TextBox()
        Me.txtNavn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.brukerGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.brukerGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1011, 512)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Oversikt"
        '
        'brukerGridView
        '
        Me.brukerGridView.AllowUserToAddRows = False
        Me.brukerGridView.AllowUserToDeleteRows = False
        Me.brukerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.brukerGridView.Location = New System.Drawing.Point(6, 22)
        Me.brukerGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.brukerGridView.Name = "brukerGridView"
        Me.brukerGridView.RowTemplate.Height = 24
        Me.brukerGridView.RowTemplate.ReadOnly = True
        Me.brukerGridView.Size = New System.Drawing.Size(998, 479)
        Me.brukerGridView.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxArbedidssted)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ProvisjonBar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbxStilling)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnSlett_Bruker)
        Me.GroupBox1.Controls.Add(Me.btnOppdater_Bruker)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.btnLegg_til_Bruker)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPostnr)
        Me.GroupBox1.Controls.Add(Me.txtAdresse)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTelefon)
        Me.GroupBox1.Controls.Add(Me.txtEtternavn)
        Me.GroupBox1.Controls.Add(Me.txtNavn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(297, 512)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ny/rediger ansatt"
        '
        'cbxArbedidssted
        '
        Me.cbxArbedidssted.FormattingEnabled = True
        Me.cbxArbedidssted.Location = New System.Drawing.Point(106, 344)
        Me.cbxArbedidssted.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxArbedidssted.Name = "cbxArbedidssted"
        Me.cbxArbedidssted.Size = New System.Drawing.Size(172, 28)
        Me.cbxArbedidssted.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 348)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 20)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Arbeidssted"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(87, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "0%"
        '
        'ProvisjonBar
        '
        Me.ProvisjonBar.LargeChange = 1
        Me.ProvisjonBar.Location = New System.Drawing.Point(138, 305)
        Me.ProvisjonBar.Maximum = 30
        Me.ProvisjonBar.Name = "ProvisjonBar"
        Me.ProvisjonBar.Size = New System.Drawing.Size(138, 21)
        Me.ProvisjonBar.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Provisjon"
        '
        'cbxStilling
        '
        Me.cbxStilling.FormattingEnabled = True
        Me.cbxStilling.Location = New System.Drawing.Point(90, 268)
        Me.cbxStilling.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxStilling.Name = "cbxStilling"
        Me.cbxStilling.Size = New System.Drawing.Size(187, 28)
        Me.cbxStilling.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Stilling"
        '
        'btnSlett_Bruker
        '
        Me.btnSlett_Bruker.Location = New System.Drawing.Point(8, 464)
        Me.btnSlett_Bruker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSlett_Bruker.Name = "btnSlett_Bruker"
        Me.btnSlett_Bruker.Size = New System.Drawing.Size(270, 38)
        Me.btnSlett_Bruker.TabIndex = 35
        Me.btnSlett_Bruker.Text = "Slett"
        Me.btnSlett_Bruker.UseVisualStyleBackColor = True
        '
        'btnOppdater_Bruker
        '
        Me.btnOppdater_Bruker.Location = New System.Drawing.Point(7, 421)
        Me.btnOppdater_Bruker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOppdater_Bruker.Name = "btnOppdater_Bruker"
        Me.btnOppdater_Bruker.Size = New System.Drawing.Size(270, 38)
        Me.btnOppdater_Bruker.TabIndex = 34
        Me.btnOppdater_Bruker.Text = "Oppdater"
        Me.btnOppdater_Bruker.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Poststed"
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(90, 232)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox8.MaxLength = 4
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(187, 26)
        Me.TextBox8.TabIndex = 32
        '
        'btnLegg_til_Bruker
        '
        Me.btnLegg_til_Bruker.Location = New System.Drawing.Point(9, 379)
        Me.btnLegg_til_Bruker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLegg_til_Bruker.Name = "btnLegg_til_Bruker"
        Me.btnLegg_til_Bruker.Size = New System.Drawing.Size(270, 38)
        Me.btnLegg_til_Bruker.TabIndex = 31
        Me.btnLegg_til_Bruker.Text = "Legg til"
        Me.btnLegg_til_Bruker.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "E-post"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(90, 128)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(187, 26)
        Me.txtMail.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Postnr"
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(90, 198)
        Me.txtPostnr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPostnr.MaxLength = 4
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(187, 26)
        Me.txtPostnr.TabIndex = 9
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(90, 162)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(187, 26)
        Me.txtAdresse.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Adresse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telefonnr"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(90, 92)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefon.MaxLength = 8
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(187, 26)
        Me.txtTelefon.TabIndex = 4
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Location = New System.Drawing.Point(90, 58)
        Me.txtEtternavn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(187, 26)
        Me.txtEtternavn.TabIndex = 3
        '
        'txtNavn
        '
        Me.txtNavn.Location = New System.Drawing.Point(90, 22)
        Me.txtNavn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNavn.Name = "txtNavn"
        Me.txtNavn.Size = New System.Drawing.Size(187, 26)
        Me.txtNavn.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Etternavn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fornavn"
        '
        'bruker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 540)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "bruker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brukere"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.brukerGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents brukerGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPostnr As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents txtEtternavn As System.Windows.Forms.TextBox
    Friend WithEvents txtNavn As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSlett_Bruker As System.Windows.Forms.Button
    Friend WithEvents btnOppdater_Bruker As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents btnLegg_til_Bruker As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbxStilling As System.Windows.Forms.ComboBox
    Friend WithEvents ProvisjonBar As System.Windows.Forms.HScrollBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxArbedidssted As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
