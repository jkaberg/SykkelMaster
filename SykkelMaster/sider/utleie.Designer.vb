<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class utleie
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.cbxHjulstr = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxRammestr = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnLeggTil = New System.Windows.Forms.Button()
        Me.cbxSykkeltype = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxAvtale = New System.Windows.Forms.ComboBox()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbxNavn = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnKunde = New System.Windows.Forms.Button()
        Me.btnRedigerKunde = New System.Windows.Forms.Button()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnOprettAvtale = New System.Windows.Forms.Button()
        Me.btnSlett = New System.Windows.Forms.Button()
        Me.btnRedigere = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.Controls.Add(Me.cbxHjulstr)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbxRammestr)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.btnLeggTil)
        Me.GroupBox1.Controls.Add(Me.cbxSykkeltype)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(328, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 370)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Utleie"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.AllowDrop = True
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Barnehenger", "Barnesete", "Beskytter", "Hjelm", "Lappesaker", "Lastehenger", "Lås", "Sykkelpompe", "Sykkelvekse"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(10, 228)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(404, 55)
        Me.CheckedListBox1.Sorted = True
        Me.CheckedListBox1.TabIndex = 14
        '
        'cbxHjulstr
        '
        Me.cbxHjulstr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxHjulstr.FormattingEnabled = True
        Me.cbxHjulstr.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "24"})
        Me.cbxHjulstr.Location = New System.Drawing.Point(102, 198)
        Me.cbxHjulstr.Name = "cbxHjulstr"
        Me.cbxHjulstr.Size = New System.Drawing.Size(114, 28)
        Me.cbxHjulstr.TabIndex = 12

        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 17)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Hjulstr"
        '
        'cbxRammestr
        '
        Me.cbxRammestr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRammestr.FormattingEnabled = True
        Me.cbxRammestr.Items.AddRange(New Object() {"13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbxRammestr.Location = New System.Drawing.Point(311, 198)
        Me.cbxRammestr.Name = "cbxRammestr"
        Me.cbxRammestr.Size = New System.Drawing.Size(114, 28)
        Me.cbxRammestr.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(233, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 17)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Rammestr"
        '
        'btnLeggTil
        '
        Me.btnLeggTil.Location = New System.Drawing.Point(9, 306)
        Me.btnLeggTil.Name = "btnLeggTil"
        Me.btnLeggTil.Size = New System.Drawing.Size(132, 61)
        Me.btnLeggTil.TabIndex = 15

        Me.btnLeggTil.Text = "Legg til"
        Me.btnLeggTil.UseVisualStyleBackColor = True
        '
        'cbxSykkeltype
        '
        Me.cbxSykkeltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSykkeltype.FormattingEnabled = True
        Me.cbxSykkeltype.Location = New System.Drawing.Point(102, 168)
        Me.cbxSykkeltype.Name = "cbxSykkeltype"
        Me.cbxSykkeltype.Size = New System.Drawing.Size(349, 28)
        Me.cbxSykkeltype.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Sykkeltype"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Sykkel og utstyr"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Tidsramme"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Leie enhet:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(102, 107)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(349, 26)
        Me.DateTimePicker2.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(102, 77)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(349, 26)
        Me.DateTimePicker1.TabIndex = 9
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(157, 51)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 24)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Dag"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Til tidspunkt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fra tidspunkt"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(91, 51)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(68, 24)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Time"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbxAvtale)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 199)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rabatt"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Avtale"
        '
        'cbxAvtale
        '
        Me.cbxAvtale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAvtale.FormattingEnabled = True
        Me.cbxAvtale.Location = New System.Drawing.Point(87, 21)
        Me.cbxAvtale.Name = "cbxAvtale"
        Me.cbxAvtale.Size = New System.Drawing.Size(224, 28)
        Me.cbxAvtale.TabIndex = 6
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(87, 21)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(224, 26)
        Me.txtSok.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Søk"
        '
        'cbxNavn
        '
        Me.cbxNavn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNavn.FormattingEnabled = True
        Me.cbxNavn.Location = New System.Drawing.Point(87, 50)
        Me.cbxNavn.Name = "cbxNavn"
        Me.cbxNavn.Size = New System.Drawing.Size(224, 28)
        Me.cbxNavn.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Navn"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnKunde)
        Me.GroupBox3.Controls.Add(Me.btnRedigerKunde)
        Me.GroupBox3.Controls.Add(Me.txtTelefon)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtSok)
        Me.GroupBox3.Controls.Add(Me.cbxNavn)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 165)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kunde"
        '
        'btnKunde
        '
        Me.btnKunde.Location = New System.Drawing.Point(14, 108)
        Me.btnKunde.Name = "btnKunde"
        Me.btnKunde.Size = New System.Drawing.Size(169, 61)
        Me.btnKunde.TabIndex = 4
        Me.btnKunde.Text = "Legg til ny kunde"
        Me.btnKunde.UseVisualStyleBackColor = True
        '
        'btnRedigerKunde
        '
        Me.btnRedigerKunde.Location = New System.Drawing.Point(170, 108)
        Me.btnRedigerKunde.Name = "btnRedigerKunde"
        Me.btnRedigerKunde.Size = New System.Drawing.Size(132, 61)
        Me.btnRedigerKunde.TabIndex = 5
        Me.btnRedigerKunde.Text = "Rediger kunde"
        Me.btnRedigerKunde.UseVisualStyleBackColor = True
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(87, 80)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(224, 26)
        Me.txtTelefon.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Telefonnr"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnOprettAvtale)
        Me.GroupBox4.Controls.Add(Me.btnSlett)
        Me.GroupBox4.Controls.Add(Me.btnRedigere)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 389)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(735, 313)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Kundevogn"
        '
        'btnOprettAvtale
        '
        Me.btnOprettAvtale.Location = New System.Drawing.Point(611, 253)
        Me.btnOprettAvtale.Name = "btnOprettAvtale"
        Me.btnOprettAvtale.Size = New System.Drawing.Size(117, 49)
        Me.btnOprettAvtale.TabIndex = 40
        Me.btnOprettAvtale.Text = "Opprett avtale"
        Me.btnOprettAvtale.UseVisualStyleBackColor = True
        '
        'btnSlett
        '
        Me.btnSlett.Location = New System.Drawing.Point(611, 77)
        Me.btnSlett.Name = "btnSlett"
        Me.btnSlett.Size = New System.Drawing.Size(132, 61)
        Me.btnSlett.TabIndex = 17
        Me.btnSlett.Text = "Slett"
        Me.btnSlett.UseVisualStyleBackColor = True
        '
        'btnRedigere
        '
        Me.btnRedigere.Location = New System.Drawing.Point(612, 22)
        Me.btnRedigere.Name = "btnRedigere"
        Me.btnRedigere.Size = New System.Drawing.Size(132, 61)
        Me.btnRedigere.TabIndex = 16
        Me.btnRedigere.Text = "Redigere"
        Me.btnRedigere.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(598, 280)
        Me.DataGridView1.TabIndex = 0
        '
        'utleie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 710)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "utleie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utleie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSok As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cbxNavn As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKunde As System.Windows.Forms.Button
    Friend WithEvents btnRedigerKunde As System.Windows.Forms.Button
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLeggTil As System.Windows.Forms.Button
    Friend WithEvents cbxSykkeltype As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbxHjulstr As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbxRammestr As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxAvtale As System.Windows.Forms.ComboBox
    Friend WithEvents btnOprettAvtale As System.Windows.Forms.Button
    Friend WithEvents btnSlett As System.Windows.Forms.Button
    Friend WithEvents btnRedigere As System.Windows.Forms.Button
End Class
