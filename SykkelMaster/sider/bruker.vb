Public Class bruker
    Private gridIndex As Integer

    Private Sub bruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM person JOIN ansatt ON person.person_id = ansatt.person_id")
        brukerGridView.DataSource = payload

        ' Sett gridIndex sånn at vi finner frem i djungelen av data fra databasen
        gridIndex = brukerGridView.CurrentRow.Index

        With Me.brukerGridView
            .Columns("person_id").Visible = False
            .Columns("person_id1").Visible = False
            .Columns("passord").Visible = False
            .Columns("virksomhet_id").Visible = False
            .DefaultCellStyle.NullValue = "no entry"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
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

        'Select Case DataGridView1.Item((6), index).Value
        '    Case Is = 3
        '        ComboBox1.Items.
        'End Select
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

End Class