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
        Me.sykkelGrid = New System.Windows.Forms.DataGridView()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.btnLeggTil = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tilTid = New System.Windows.Forms.DateTimePicker()
        Me.fraTid = New System.Windows.Forms.DateTimePicker()
        Me.rbDag = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbTime = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxRabattAvtale = New System.Windows.Forms.ComboBox()
        Me.txtSokKunde = New System.Windows.Forms.TextBox()
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
        Me.vognGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sykkelGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.vognGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sykkelGrid)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.Controls.Add(Me.btnLeggTil)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tilTid)
        Me.GroupBox1.Controls.Add(Me.fraTid)
        Me.GroupBox1.Controls.Add(Me.rbDag)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbTime)
        Me.GroupBox1.Location = New System.Drawing.Point(328, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 370)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Utleie"
        '
        'sykkelGrid
        '
        Me.sykkelGrid.AllowUserToAddRows = False
        Me.sykkelGrid.AllowUserToDeleteRows = False
        Me.sykkelGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.sykkelGrid.Location = New System.Drawing.Point(9, 161)
        Me.sykkelGrid.MultiSelect = False
        Me.sykkelGrid.Name = "sykkelGrid"
        Me.sykkelGrid.RowHeadersVisible = False
        Me.sykkelGrid.RowTemplate.Height = 24
        Me.sykkelGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sykkelGrid.Size = New System.Drawing.Size(446, 78)
        Me.sykkelGrid.TabIndex = 23
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.AllowDrop = True
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Barnehenger", "Barnesete", "Beskytter", "Hjelm", "Lappesaker", "Lastehenger", "Lås", "Sykkelpompe", "Sykkelvekse"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(9, 245)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(446, 55)
        Me.CheckedListBox1.Sorted = True
        Me.CheckedListBox1.TabIndex = 14
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
        'tilTid
        '
        Me.tilTid.Location = New System.Drawing.Point(102, 107)
        Me.tilTid.Name = "tilTid"
        Me.tilTid.Size = New System.Drawing.Size(353, 22)
        Me.tilTid.TabIndex = 10
        '
        'fraTid
        '
        Me.fraTid.Location = New System.Drawing.Point(102, 77)
        Me.fraTid.Name = "fraTid"
        Me.fraTid.Size = New System.Drawing.Size(353, 22)
        Me.fraTid.TabIndex = 9
        '
        'rbDag
        '
        Me.rbDag.AutoSize = True
        Me.rbDag.Location = New System.Drawing.Point(168, 51)
        Me.rbDag.Name = "rbDag"
        Me.rbDag.Size = New System.Drawing.Size(55, 21)
        Me.rbDag.TabIndex = 8
        Me.rbDag.TabStop = True
        Me.rbDag.Text = "Dag"
        Me.rbDag.UseVisualStyleBackColor = True
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
        'rbTime
        '
        Me.rbTime.AutoSize = True
        Me.rbTime.Location = New System.Drawing.Point(102, 53)
        Me.rbTime.Name = "rbTime"
        Me.rbTime.Size = New System.Drawing.Size(60, 21)
        Me.rbTime.TabIndex = 7
        Me.rbTime.TabStop = True
        Me.rbTime.Text = "Time"
        Me.rbTime.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbxRabattAvtale)
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
        'cbxRabattAvtale
        '
        Me.cbxRabattAvtale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRabattAvtale.FormattingEnabled = True
        Me.cbxRabattAvtale.Items.AddRange(New Object() {"10% Enkeltperson", "20% Enkeltperson", "99% Gruppe"})
        Me.cbxRabattAvtale.Location = New System.Drawing.Point(87, 21)
        Me.cbxRabattAvtale.Name = "cbxRabattAvtale"
        Me.cbxRabattAvtale.Size = New System.Drawing.Size(215, 24)
        Me.cbxRabattAvtale.TabIndex = 6
        '
        'txtSokKunde
        '
        Me.txtSokKunde.Location = New System.Drawing.Point(87, 21)
        Me.txtSokKunde.Name = "txtSokKunde"
        Me.txtSokKunde.Size = New System.Drawing.Size(215, 22)
        Me.txtSokKunde.TabIndex = 1
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
        Me.cbxNavn.Size = New System.Drawing.Size(215, 24)
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
        Me.GroupBox3.Controls.Add(Me.txtSokKunde)
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
        Me.btnKunde.Size = New System.Drawing.Size(150, 49)
        Me.btnKunde.TabIndex = 4
        Me.btnKunde.Text = "Legg til ny kunde"
        Me.btnKunde.UseVisualStyleBackColor = True
        '
        'btnRedigerKunde
        '
        Me.btnRedigerKunde.Location = New System.Drawing.Point(170, 108)
        Me.btnRedigerKunde.Name = "btnRedigerKunde"
        Me.btnRedigerKunde.Size = New System.Drawing.Size(132, 51)
        Me.btnRedigerKunde.TabIndex = 5
        Me.btnRedigerKunde.Text = "Rediger kunde"
        Me.btnRedigerKunde.UseVisualStyleBackColor = True
        '
        'txtTelefon
        '
        Me.txtTelefon.Enabled = False
        Me.txtTelefon.Location = New System.Drawing.Point(87, 80)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(215, 22)
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
        Me.GroupBox4.Controls.Add(Me.vognGrid)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 389)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(776, 313)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Kundevogn"
        '
        'btnOprettAvtale
        '
        Me.btnOprettAvtale.Location = New System.Drawing.Point(611, 242)
        Me.btnOprettAvtale.Name = "btnOprettAvtale"
        Me.btnOprettAvtale.Size = New System.Drawing.Size(133, 60)
        Me.btnOprettAvtale.TabIndex = 40
        Me.btnOprettAvtale.Text = "Opprett avtale"
        Me.btnOprettAvtale.UseVisualStyleBackColor = True
        '
        'btnSlett
        '
        Me.btnSlett.Location = New System.Drawing.Point(611, 89)
        Me.btnSlett.Name = "btnSlett"
        Me.btnSlett.Size = New System.Drawing.Size(133, 61)
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
        'vognGrid
        '
        Me.vognGrid.AllowUserToAddRows = False
        Me.vognGrid.AllowUserToDeleteRows = False
        Me.vognGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.vognGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vognGrid.Location = New System.Drawing.Point(7, 22)
        Me.vognGrid.Name = "vognGrid"
        Me.vognGrid.RowTemplate.Height = 24
        Me.vognGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.vognGrid.Size = New System.Drawing.Size(598, 280)
        Me.vognGrid.TabIndex = 0
        '
        'utleie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 710)
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
        CType(Me.sykkelGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.vognGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSokKunde As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cbxNavn As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKunde As System.Windows.Forms.Button
    Friend WithEvents btnRedigerKunde As System.Windows.Forms.Button
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLeggTil As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tilTid As System.Windows.Forms.DateTimePicker
    Friend WithEvents fraTid As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbDag As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbTime As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents vognGrid As System.Windows.Forms.DataGridView
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxRabattAvtale As System.Windows.Forms.ComboBox
    Friend WithEvents btnOprettAvtale As System.Windows.Forms.Button
    Friend WithEvents btnSlett As System.Windows.Forms.Button
    Friend WithEvents btnRedigere As System.Windows.Forms.Button
    Friend WithEvents sykkelGrid As System.Windows.Forms.DataGridView
End Class
