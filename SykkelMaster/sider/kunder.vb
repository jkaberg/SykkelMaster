Public Class kunder

    Private Sub kunder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM person WHERE person.person_id NOT IN (SELECT person_id FROM ansatt)")

        DataGridView1.DataSource = payload
    End Sub
End Class