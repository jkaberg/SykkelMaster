Public Class bruker

    Private Sub bruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM person JOIN ansatt ON person.person_id = ansatt.person_id")

        DataGridView1.DataSource = payload
    End Sub
End Class