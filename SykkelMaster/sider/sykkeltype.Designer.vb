<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sykkeltype
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
        Me.txtNavn = New System.Windows.Forms.TextBox()
        Me.btnSlett = New System.Windows.Forms.Button()
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.btnLeggTil = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sykkeltypeGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sykkeltypeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNavn)
        Me.GroupBox1.Controls.Add(Me.btnSlett)
        Me.GroupBox1.Controls.Add(Me.btnOppdater)
        Me.GroupBox1.Controls.Add(Me.btnLeggTil)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(292, 268)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Legg til/Redigere"
        '
        'txtNavn
        '
        Me.txtNavn.Location = New System.Drawing.Point(58, 48)
        Me.txtNavn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNavn.Name = "txtNavn"
        Me.txtNavn.Size = New System.Drawing.Size(212, 26)
        Me.txtNavn.TabIndex = 13
        '
        'btnSlett
        '
        Me.btnSlett.Location = New System.Drawing.Point(11, 192)
        Me.btnSlett.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSlett.Name = "btnSlett"
        Me.btnSlett.Size = New System.Drawing.Size(259, 38)
        Me.btnSlett.TabIndex = 12
        Me.btnSlett.Text = "Slett"
        Me.btnSlett.UseVisualStyleBackColor = True
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(11, 148)
        Me.btnOppdater.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(259, 38)
        Me.btnOppdater.TabIndex = 11
        Me.btnOppdater.Text = "Oppdater"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnLeggTil
        '
        Me.btnLeggTil.Location = New System.Drawing.Point(11, 101)
        Me.btnLeggTil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLeggTil.Name = "btnLeggTil"
        Me.btnLeggTil.Size = New System.Drawing.Size(259, 38)
        Me.btnLeggTil.TabIndex = 10
        Me.btnLeggTil.Text = "Legg til"
        Me.btnLeggTil.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Navn"
        '
        'sykkeltypeGrid
        '
        Me.sykkeltypeGrid.AllowUserToAddRows = False
        Me.sykkeltypeGrid.AllowUserToDeleteRows = False
        Me.sykkeltypeGrid.AllowUserToResizeRows = False
        Me.sykkeltypeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.sykkeltypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sykkeltypeGrid.Location = New System.Drawing.Point(17, 28)
        Me.sykkeltypeGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sykkeltypeGrid.MultiSelect = False
        Me.sykkeltypeGrid.Name = "sykkeltypeGrid"
        Me.sykkeltypeGrid.ReadOnly = True
        Me.sykkeltypeGrid.RowHeadersVisible = False
        Me.sykkeltypeGrid.RowTemplate.Height = 24
        Me.sykkeltypeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sykkeltypeGrid.Size = New System.Drawing.Size(215, 232)
        Me.sykkeltypeGrid.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sykkeltypeGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(313, 16)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(241, 268)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Søk"
        '
        'sykkeltype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 296)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "sykkeltype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sykkeltype"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.sykkeltypeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOppdater As System.Windows.Forms.Button
    Friend WithEvents btnLeggTil As System.Windows.Forms.Button
    Friend WithEvents sykkeltypeGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNavn As System.Windows.Forms.TextBox
    Friend WithEvents btnSlett As System.Windows.Forms.Button
End Class
