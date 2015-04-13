<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lokasjoner
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
        Me.Oppdaterlokasjon = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTom = New System.Windows.Forms.Button()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnDeleteLocation = New System.Windows.Forms.Button()
        Me.btnUpdateLocation = New System.Windows.Forms.Button()
        Me.btnAddLocation = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPoststed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPostnr = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.txtNavn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Oppdaterlokasjon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Oppdaterlokasjon)
        Me.GroupBox2.Location = New System.Drawing.Point(309, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(835, 408)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Oversikt"
        '
        'Oppdaterlokasjon
        '
        Me.Oppdaterlokasjon.AllowUserToAddRows = False
        Me.Oppdaterlokasjon.AllowUserToDeleteRows = False
        Me.Oppdaterlokasjon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Oppdaterlokasjon.Location = New System.Drawing.Point(10, 26)
        Me.Oppdaterlokasjon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Oppdaterlokasjon.Name = "Oppdaterlokasjon"
        Me.Oppdaterlokasjon.ReadOnly = True
        Me.Oppdaterlokasjon.RowTemplate.Height = 24
        Me.Oppdaterlokasjon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Oppdaterlokasjon.Size = New System.Drawing.Size(816, 375)
        Me.Oppdaterlokasjon.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTom)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.BtnDeleteLocation)
        Me.GroupBox1.Controls.Add(Me.btnUpdateLocation)
        Me.GroupBox1.Controls.Add(Me.btnAddLocation)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPoststed)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPostnr)
        Me.GroupBox1.Controls.Add(Me.txtAdresse)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTelefon)
        Me.GroupBox1.Controls.Add(Me.txtNavn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(290, 408)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ny/rediger lokasjon"
        '
        'btnTom
        '
        Me.btnTom.Location = New System.Drawing.Point(10, 235)
        Me.btnTom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTom.Name = "btnTom"
        Me.btnTom.Size = New System.Drawing.Size(267, 38)
        Me.btnTom.TabIndex = 36
        Me.btnTom.Text = "Tøm"
        Me.btnTom.UseVisualStyleBackColor = True
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(90, 129)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(187, 26)
        Me.txtMail.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Epost"
        '
        'BtnDeleteLocation
        '
        Me.BtnDeleteLocation.Location = New System.Drawing.Point(10, 364)
        Me.BtnDeleteLocation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDeleteLocation.Name = "BtnDeleteLocation"
        Me.BtnDeleteLocation.Size = New System.Drawing.Size(267, 38)
        Me.BtnDeleteLocation.TabIndex = 33
        Me.BtnDeleteLocation.Text = "Slett"
        Me.BtnDeleteLocation.UseVisualStyleBackColor = True
        '
        'btnUpdateLocation
        '
        Me.btnUpdateLocation.Location = New System.Drawing.Point(10, 321)
        Me.btnUpdateLocation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateLocation.Name = "btnUpdateLocation"
        Me.btnUpdateLocation.Size = New System.Drawing.Size(267, 38)
        Me.btnUpdateLocation.TabIndex = 32
        Me.btnUpdateLocation.Text = "Oppdater"
        Me.btnUpdateLocation.UseVisualStyleBackColor = True
        '
        'btnAddLocation
        '
        Me.btnAddLocation.Location = New System.Drawing.Point(10, 278)
        Me.btnAddLocation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddLocation.Name = "btnAddLocation"
        Me.btnAddLocation.Size = New System.Drawing.Size(267, 38)
        Me.btnAddLocation.TabIndex = 31
        Me.btnAddLocation.Text = "Legg til"
        Me.btnAddLocation.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Poststed"
        '
        'txtPoststed
        '
        Me.txtPoststed.Location = New System.Drawing.Point(90, 202)
        Me.txtPoststed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPoststed.Name = "txtPoststed"
        Me.txtPoststed.ReadOnly = True
        Me.txtPoststed.Size = New System.Drawing.Size(187, 26)
        Me.txtPoststed.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Postnr"
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(90, 168)
        Me.txtPostnr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(187, 26)
        Me.txtPostnr.TabIndex = 9
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(90, 92)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(187, 26)
        Me.txtAdresse.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telefonnr"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(90, 58)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(187, 26)
        Me.txtTelefon.TabIndex = 4
        '
        'txtNavn
        '
        Me.txtNavn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNavn.Location = New System.Drawing.Point(90, 22)
        Me.txtNavn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNavn.Name = "txtNavn"
        Me.txtNavn.Size = New System.Drawing.Size(187, 26)
        Me.txtNavn.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Navn"
        '
        'lokasjoner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 431)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "lokasjoner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lokasjon"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Oppdaterlokasjon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Oppdaterlokasjon As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPostnr As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents txtNavn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPoststed As System.Windows.Forms.TextBox
    Friend WithEvents BtnDeleteLocation As System.Windows.Forms.Button
    Friend WithEvents btnUpdateLocation As System.Windows.Forms.Button
    Friend WithEvents btnAddLocation As System.Windows.Forms.Button
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnTom As System.Windows.Forms.Button
End Class
