Public Class innlevering

    Private Sub innlevering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM salg_leie")

        DataGridView1.DataSource = payload
    End Sub
End Class