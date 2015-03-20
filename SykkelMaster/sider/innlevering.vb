
Public Class innlevering

    Private Sub innlevering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM salg_leie")

        DataGridView1.DataSource = payload
    End Sub

    Public telefon As Integer


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim payload As New DataTable
        Dim sql As String = "SELECT id, fornavn, etternavn, telefon FROM person WHERE fornavn " &
                            "LIKE '" & TextBox3.Text & "%' " &
                            "OR etternavn LIKE '" & TextBox3.Text & "%' " &
                            "OR telefon LIKE '" & TextBox3.Text & "%' "

        payload = db.query(sql)

        With ComboBox1
            .DisplayMember = "fornavn"
            .ValueMember = "id"
            .DataSource = payload
        End With
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.DataSourceChanged
        Dim payload As New DataTable
        Dim sql As String = "SELECT * FROM salg_leie, person WHERE salg_leie.person_id_kunde = person.id AND person.id = '" & ComboBox1.SelectedValue() & "'"
        payload = db.query(sql)
        DataGridView1.DataSource = payload 'Ordrene til kunden som er valgt blir lagt ut i DataGrid

        With ComboBox2
            .DisplayMember = "ordre_nr"
            .ValueMember = "ordre_nr"
            .DataSource = payload
        End With
    End Sub
End Class