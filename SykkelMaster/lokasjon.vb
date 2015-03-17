Public Class lokasjon

    Private Sub lokasjon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM virksomhet")

        DataGridView1.DataSource = payload
    End Sub
End Class