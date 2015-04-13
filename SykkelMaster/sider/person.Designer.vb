<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class person
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTom = New System.Windows.Forms.Button()
        Me.btnSlett = New System.Windows.Forms.Button()
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPoststed = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.btnLeggTil = New System.Windows.Forms.Button()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.kundeGridView = New System.Windows.Forms.DataGridView()
        Me.sokKunde = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.kundeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTom)
        Me.GroupBox1.Controls.Add(Me.btnSlett)
        Me.GroupBox1.Controls.Add(Me.btnOppdater)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPoststed)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.btnLeggTil)
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(264, 358)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ny/rediger kunde"
        '
        'btnTom
        '
        Me.btnTom.Location = New System.Drawing.Point(9, 213)
        Me.btnTom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTom.Name = "btnTom"
        Me.btnTom.Size = New System.Drawing.Size(240, 30)
        Me.btnTom.TabIndex = 6
        Me.btnTom.Text = "Tøm"
        Me.btnTom.UseVisualStyleBackColor = True
        '
        'btnSlett
        '
        Me.btnSlett.Location = New System.Drawing.Point(9, 324)
        Me.btnSlett.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSlett.Name = "btnSlett"
        Me.btnSlett.Size = New System.Drawing.Size(240, 30)
        Me.btnSlett.TabIndex = 9
        Me.btnSlett.Text = "Slett"
        Me.btnSlett.UseVisualStyleBackColor = True
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(9, 286)
        Me.btnOppdater.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(240, 30)
        Me.btnOppdater.TabIndex = 8
        Me.btnOppdater.Text = "Oppdater"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Poststed"
        '
        'txtPoststed
        '
        Me.txtPoststed.Enabled = False
        Me.txtPoststed.Location = New System.Drawing.Point(80, 186)
        Me.txtPoststed.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPoststed.Name = "txtPoststed"
        Me.txtPoststed.Size = New System.Drawing.Size(166, 22)
        Me.txtPoststed.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "E-post"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(80, 102)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(166, 22)
        Me.txtMail.TabIndex = 3
        '
        'btnLeggTil
        '
        Me.btnLeggTil.Location = New System.Drawing.Point(9, 250)
        Me.btnLeggTil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLeggTil.Name = "btnLeggTil"
        Me.btnLeggTil.Size = New System.Drawing.Size(240, 30)
        Me.btnLeggTil.TabIndex = 7
        Me.btnLeggTil.Text = "Legg til"
        Me.btnLeggTil.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Postnr"
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(80, 158)
        Me.txtPostnr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPostnr.MaxLength = 4
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(166, 22)
        Me.txtPostnr.TabIndex = 5
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(80, 130)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(166, 22)
        Me.txtAdresse.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Adresse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telefonnr"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(80, 74)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefon.MaxLength = 8
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(166, 22)
        Me.txtTelefon.TabIndex = 2
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Location = New System.Drawing.Point(80, 46)
        Me.txtEtternavn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(166, 22)
        Me.txtEtternavn.TabIndex = 1
        '
        'txtNavn
        '
        Me.txtNavn.Location = New System.Drawing.Point(80, 18)
        Me.txtNavn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNavn.Name = "txtNavn"
        Me.txtNavn.Size = New System.Drawing.Size(166, 22)
        Me.txtNavn.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Etternavn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fornavn"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.kundeGridView)
        Me.GroupBox2.Controls.Add(Me.sokKunde)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(284, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(883, 358)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Søk"
        '
        'kundeGridView
        '
        Me.kundeGridView.AllowUserToAddRows = False
        Me.kundeGridView.AllowUserToDeleteRows = False
        Me.kundeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.kundeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.kundeGridView.Location = New System.Drawing.Point(11, 46)
        Me.kundeGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.kundeGridView.Name = "kundeGridView"
        Me.kundeGridView.ReadOnly = True
        Me.kundeGridView.RowHeadersVisible = False
        Me.kundeGridView.RowTemplate.Height = 24
        Me.kundeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.kundeGridView.Size = New System.Drawing.Size(858, 306)
        Me.kundeGridView.TabIndex = 18
        '
        'sokKunde
        '
        Me.sokKunde.Location = New System.Drawing.Point(114, 18)
        Me.sokKunde.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sokKunde.Name = "sokKunde"
        Me.sokKunde.Size = New System.Drawing.Size(328, 22)
        Me.sokKunde.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Navn/telefonnr"
        '
        'person
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 379)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "person"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kunde"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.kundeGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents txtEtternavn As System.Windows.Forms.TextBox
    Friend WithEvents txtNavn As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPostnr As System.Windows.Forms.TextBox
    Friend WithEvents btnLeggTil As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents kundeGridView As System.Windows.Forms.DataGridView
    Friend WithEvents sokKunde As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents btnSlett As System.Windows.Forms.Button
    Friend WithEvents btnOppdater As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPoststed As System.Windows.Forms.TextBox
    Friend WithEvents btnTom As System.Windows.Forms.Button
End Class
