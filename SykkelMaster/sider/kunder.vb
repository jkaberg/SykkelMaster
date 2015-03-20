Public Class kunder
    Private gridIndex As Integer

    Private Sub kunder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM person WHERE person.id")

        brukerGridView.DataSource = payload
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles brukerGridView.CellClick
        'Sett nuvarende DataGrid index sånn at vi finner rett rad i DataTablen
        gridIndex = brukerGridView.CurrentRow.Index

        'Sett in dataen fra Grid Viewn i Textboksene
        With Me.brukerGridView
            txtNavn.Text = .Rows(gridIndex).Cells("fornavn").Value
            txtEtternavn.Text = .Rows(gridIndex).Cells("etternavn").Value
            txttelefon.Text = .Rows(gridIndex).Cells("telefon").Value
            txtAdresse.Text = .Rows(gridIndex).Cells("adresse").Value
            txtMail.Text = .Rows(gridIndex).Cells("mail").Value
            txtPostnr.Text = .Rows(gridIndex).Cells("post_nr").Value

        End With
    End Sub

    Private Sub sokKunde_TextChanged(sender As Object, e As EventArgs) Handles sokKunde.TextChanged

    End Sub

    Private Sub oppdaterGridView(Optional ByVal sok As String = Nothing)
        Dim payload As New DataTable
        Dim sql As String
        If sok Then
            sql = "SELECT * FROM person LIKE %_"
        Else

        End If
    End Sub

End Class