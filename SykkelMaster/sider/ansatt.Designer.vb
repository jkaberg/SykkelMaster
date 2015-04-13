<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ansatte
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
        Me.btnTom = New System.Windows.Forms.Button()
        Me.cbxArbedidssted = New System.Windows.Forms.ComboBox()
        Me.btnOppdater_Bruker = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblProvisjon = New System.Windows.Forms.Label()
        Me.ProvisjonBar = New System.Windows.Forms.HScrollBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxStilling = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPostSted = New System.Windows.Forms.TextBox()
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
        Me.btnSlett = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.brukerGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.brukerGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(283, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(899, 431)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Oversikt"
        '
        'brukerGridView
        '
        Me.brukerGridView.AllowUserToAddRows = False
        Me.brukerGridView.AllowUserToDeleteRows = False
        Me.brukerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.brukerGridView.Location = New System.Drawing.Point(5, 18)
        Me.brukerGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.brukerGridView.Name = "brukerGridView"
        Me.brukerGridView.RowTemplate.Height = 24
        Me.brukerGridView.RowTemplate.ReadOnly = True
        Me.brukerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.brukerGridView.Size = New System.Drawing.Size(887, 405)
        Me.brukerGridView.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSlett)
        Me.GroupBox1.Controls.Add(Me.btnTom)
        Me.GroupBox1.Controls.Add(Me.cbxArbedidssted)
        Me.GroupBox1.Controls.Add(Me.btnOppdater_Bruker)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblProvisjon)
        Me.GroupBox1.Controls.Add(Me.ProvisjonBar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbxStilling)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPostSted)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(264, 431)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ny/rediger ansatt"
        '
        'btnTom
        '
        Me.btnTom.Location = New System.Drawing.Point(9, 292)
        Me.btnTom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTom.Name = "btnTom"
        Me.btnTom.Size = New System.Drawing.Size(237, 30)
        Me.btnTom.TabIndex = 41
        Me.btnTom.Text = "Tøm"
        Me.btnTom.UseVisualStyleBackColor = True
        '
        'cbxArbedidssted
        '
        Me.cbxArbedidssted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxArbedidssted.FormattingEnabled = True
        Me.cbxArbedidssted.Location = New System.Drawing.Point(93, 262)
        Me.cbxArbedidssted.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxArbedidssted.Name = "cbxArbedidssted"
        Me.cbxArbedidssted.Size = New System.Drawing.Size(153, 24)
        Me.cbxArbedidssted.TabIndex = 40
        '
        'btnOppdater_Bruker
        '
        Me.btnOppdater_Bruker.Location = New System.Drawing.Point(9, 359)
        Me.btnOppdater_Bruker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOppdater_Bruker.Name = "btnOppdater_Bruker"
        Me.btnOppdater_Bruker.Size = New System.Drawing.Size(237, 30)
        Me.btnOppdater_Bruker.TabIndex = 34
        Me.btnOppdater_Bruker.Text = "Oppdater"
        Me.btnOppdater_Bruker.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 17)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Arbeidssted"
        '
        'lblProvisjon
        '
        Me.lblProvisjon.AutoSize = True
        Me.lblProvisjon.Location = New System.Drawing.Point(76, 234)
        Me.lblProvisjon.Name = "lblProvisjon"
        Me.lblProvisjon.Size = New System.Drawing.Size(28, 17)
        Me.lblProvisjon.TabIndex = 4
        Me.lblProvisjon.Text = "0%"
        '
        'ProvisjonBar
        '
        Me.ProvisjonBar.LargeChange = 1
        Me.ProvisjonBar.Location = New System.Drawing.Point(124, 234)
        Me.ProvisjonBar.Maximum = 30
        Me.ProvisjonBar.Name = "ProvisjonBar"
        Me.ProvisjonBar.Size = New System.Drawing.Size(123, 21)
        Me.ProvisjonBar.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Provisjon"
        '
        'cbxStilling
        '
        Me.cbxStilling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStilling.FormattingEnabled = True
        Me.cbxStilling.Location = New System.Drawing.Point(80, 202)
        Me.cbxStilling.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxStilling.Name = "cbxStilling"
        Me.cbxStilling.Size = New System.Drawing.Size(167, 24)
        Me.cbxStilling.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Stilling"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Poststed"
        '
        'txtPostSted
        '
        Me.txtPostSted.Enabled = False
        Me.txtPostSted.Location = New System.Drawing.Point(80, 176)
        Me.txtPostSted.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPostSted.MaxLength = 4
        Me.txtPostSted.Name = "txtPostSted"
        Me.txtPostSted.Size = New System.Drawing.Size(167, 22)
        Me.txtPostSted.TabIndex = 32
        '
        'btnLegg_til_Bruker
        '
        Me.btnLegg_til_Bruker.Location = New System.Drawing.Point(9, 326)
        Me.btnLegg_til_Bruker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLegg_til_Bruker.Name = "btnLegg_til_Bruker"
        Me.btnLegg_til_Bruker.Size = New System.Drawing.Size(237, 30)
        Me.btnLegg_til_Bruker.TabIndex = 31
        Me.btnLegg_til_Bruker.Text = "Legg til"
        Me.btnLegg_til_Bruker.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "E-post"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(80, 97)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(167, 22)
        Me.txtMail.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Postnr"
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(80, 150)
        Me.txtPostnr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPostnr.MaxLength = 4
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(167, 22)
        Me.txtPostnr.TabIndex = 9
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(80, 123)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(167, 22)
        Me.txtAdresse.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Adresse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telefonnr"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(80, 70)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefon.MaxLength = 8
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(167, 22)
        Me.txtTelefon.TabIndex = 4
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Location = New System.Drawing.Point(80, 44)
        Me.txtEtternavn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(167, 22)
        Me.txtEtternavn.TabIndex = 3
        '
        'txtNavn
        '
        Me.txtNavn.Location = New System.Drawing.Point(80, 18)
        Me.txtNavn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNavn.Name = "txtNavn"
        Me.txtNavn.Size = New System.Drawing.Size(167, 22)
        Me.txtNavn.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Etternavn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fornavn"
        '
        'btnSlett
        '
        Me.btnSlett.Location = New System.Drawing.Point(9, 393)
        Me.btnSlett.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSlett.Name = "btnSlett"
        Me.btnSlett.Size = New System.Drawing.Size(237, 30)
        Me.btnSlett.TabIndex = 42
        Me.btnSlett.Text = "Slett"
        Me.btnSlett.UseVisualStyleBackColor = True
        '
        'ansatte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ansatte"
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
    Friend WithEvents btnOppdater_Bruker As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPostSted As System.Windows.Forms.TextBox
    Friend WithEvents btnLegg_til_Bruker As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbxStilling As System.Windows.Forms.ComboBox
    Friend WithEvents ProvisjonBar As System.Windows.Forms.HScrollBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblProvisjon As System.Windows.Forms.Label
    Friend WithEvents cbxArbedidssted As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnTom As System.Windows.Forms.Button
    Friend WithEvents btnSlett As System.Windows.Forms.Button
End Class
