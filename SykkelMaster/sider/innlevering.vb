Public Class innlevering

    Private Sub innlevering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM salg_leie")

        DataGridView1.DataSource = payload
    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim payload As New DataTable
        Dim sqlNavnCombo As String = "SELECT fornavn, etternavn, telefon FROM person WHERE fornavn LIKE '%" & TextBox3.Text & "%'  "
        payload = db.query(sqlNavnCombo)


    End Sub
End Class