Public Class bruker
    Private gridIndex As Integer

    Private Sub bruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Last inn daten fra databasen til GridView
        oppdaterGridView()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles brukerGridView.CellClick
        'Sett nuvarende DataGrid index sånn at vi finner rett rad i DataTablen
        gridIndex = brukerGridView.CurrentRow.Index

        'Sett in dataen fra Grid Viewn i Textboksene
        txtNavn.Text = brukerGridView.Item((1), gridIndex).Value 'Førnavn
        txtEtternavn.Text = brukerGridView.Item((2), gridIndex).Value 'Etternavn
        txtTelefon.Text = brukerGridView.Item((3), gridIndex).Value 'Telefon
        txtAdresse.Text = brukerGridView.Item((5), gridIndex).Value 'Adresse
        txtMail.Text = brukerGridView.Item((4), gridIndex).Value 'Mail
        txtPostnr.Text = brukerGridView.Item((6), gridIndex).Value 'Postnr

        'Sett provisjonen via sub
        provisjonLabel(brukerGridView.Item((9), gridIndex).Value)
    End Sub

    Private Sub txtPostnr_TextChanged(sender As Object, e As EventArgs) Handles txtPostnr.TextChanged
        Dim payload As New DataTable
        payload = db.query("SELECT post_sted FROM sted WHERE sted.post_nr = '" & brukerGridView.Item((6), gridIndex).Value & "'")

        TextBox8.Text = payload.Rows(0).Item(0)
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        provisjonLabel(HScrollBar1.Value)
    End Sub

    Private Sub provisjonLabel(ByVal p As Integer)
        If Not HScrollBar1.Value = p Then
            HScrollBar1.Value = p
        End If
        Label10.Text = p & "%"
    End Sub

    Private Sub oppdaterGridView()
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM person JOIN ansatt ON person.person_id = ansatt.person_id")
        brukerGridView.DataSource = payload

        ' Sett gridIndex sånn at vi finner frem i djungelen av data fra databasen
        gridIndex = brukerGridView.CurrentRow.Index

        With Me.brukerGridView
            'Vis ikke enkelte kolonner 
            .Columns("person_id").Visible = False
            .Columns("person_id1").Visible = False
            .Columns("passord").Visible = False
            .Columns("virksomhet_id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("fornavn").HeaderText = "Førnavn"
            .Columns("etternavn").HeaderText = "Etternavn"
            .Columns("telefon").HeaderText = "Telefon"
            .Columns("mail").HeaderText = "E-post"
            .Columns("adresse").HeaderText = "Adresse"
            .Columns("post_nr").HeaderText = "Postnr"
            .Columns("stilling").HeaderText = "Stilling"
            .Columns("provisjon").HeaderText = "Provisjon"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            '
            For i As Integer = 0 To brukerGridView.RowCount - 1
                Dim j As String = brukerGridView.Item((9), i).Value

                Select Case j
                    Case Is = 3
                        .Rows(i).Cells("stilling").Value = "Lagerarbeider"
                    Case Is = 5
                        .Rows(i).Cells("stilling").Value = "Selger"
                    Case Is = 10
                        .Rows(i).Cells("stilling").Value = "Daglig Leder"
                End Select
            Next
        End With
    End Sub

End Class