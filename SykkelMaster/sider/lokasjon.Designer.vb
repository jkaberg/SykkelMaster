<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lokasjon
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
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnDeleteLocation = New System.Windows.Forms.Button()
        Me.btnUpdateLocation = New System.Windows.Forms.Button()
        Me.btnAddLocation = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPoststed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpostnr = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.txtLokasjon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTom = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Oppdaterlokasjon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Oppdaterlokasjon)
        Me.GroupBox2.Location = New System.Drawing.Point(309, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 408)
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
        Me.Oppdaterlokasjon.Name = "Oppdaterlokasjon"
        Me.Oppdaterlokasjon.RowTemplate.Height = 24
        Me.Oppdaterlokasjon.Size = New System.Drawing.Size(486, 357)
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
        Me.GroupBox1.Controls.Add(Me.txtpostnr)
        Me.GroupBox1.Controls.Add(Me.txtAdresse)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTelefon)
        Me.GroupBox1.Controls.Add(Me.txtLokasjon)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 408)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ny/rediger lokasjon"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(90, 129)
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
        Me.BtnDeleteLocation.Name = "BtnDeleteLocation"
        Me.BtnDeleteLocation.Size = New System.Drawing.Size(267, 37)
        Me.BtnDeleteLocation.TabIndex = 33
        Me.BtnDeleteLocation.Text = "Slett"
        Me.BtnDeleteLocation.UseVisualStyleBackColor = True
        '
        'btnUpdateLocation
        '
        Me.btnUpdateLocation.Location = New System.Drawing.Point(10, 321)
        Me.btnUpdateLocation.Name = "btnUpdateLocation"
        Me.btnUpdateLocation.Size = New System.Drawing.Size(267, 37)
        Me.btnUpdateLocation.TabIndex = 32
        Me.btnUpdateLocation.Text = "Oppdater"
        Me.btnUpdateLocation.UseVisualStyleBackColor = True
        '
        'btnAddLocation
        '
        Me.btnAddLocation.Location = New System.Drawing.Point(10, 278)
        Me.btnAddLocation.Name = "btnAddLocation"
        Me.btnAddLocation.Size = New System.Drawing.Size(267, 37)
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
        Me.txtPoststed.Location = New System.Drawing.Point(90, 203)
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
        'txtpostnr
        '
        Me.txtpostnr.Location = New System.Drawing.Point(90, 168)
        Me.txtpostnr.Name = "txtpostnr"
        Me.txtpostnr.Size = New System.Drawing.Size(187, 26)
        Me.txtpostnr.TabIndex = 9
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(90, 92)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(187, 26)
        Me.txtAdresse.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 97)
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
        Me.txtTelefon.Location = New System.Drawing.Point(90, 57)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(187, 26)
        Me.txtTelefon.TabIndex = 4
        '
        'txtLokasjon
        '
        Me.txtLokasjon.Location = New System.Drawing.Point(90, 23)
        Me.txtLokasjon.Name = "txtLokasjon"
        Me.txtLokasjon.Size = New System.Drawing.Size(187, 26)
        Me.txtLokasjon.TabIndex = 2
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
        'btnTom
        '
        Me.btnTom.Location = New System.Drawing.Point(10, 235)
        Me.btnTom.Name = "btnTom"
        Me.btnTom.Size = New System.Drawing.Size(267, 37)
        Me.btnTom.TabIndex = 36
        Me.btnTom.Text = "Tøm"
        Me.btnTom.UseVisualStyleBackColor = True
        '
        'lokasjon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 431)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "lokasjon"
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
    Friend WithEvents txtpostnr As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents txtLokasjon As System.Windows.Forms.TextBox
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
