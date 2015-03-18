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
        With Me.brukerGridView
            txtNavn.Text = .Rows(gridIndex).Cells("fornavn").Value
            txtEtternavn.Text = .Rows(gridIndex).Cells("etternavn").Value
            txtTelefon.Text = .Rows(gridIndex).Cells("telefon").Value
            txtAdresse.Text = .Rows(gridIndex).Cells("adresse").Value
            txtMail.Text = .Rows(gridIndex).Cells("mail").Value
            txtPostnr.Text = .Rows(gridIndex).Cells("post_nr").Value

            'Sett provisjonen
            provisjonLabel(.Rows(gridIndex).Cells("provisjon").Value)
        End With
    End Sub

    Private Sub txtPostnr_TextChanged(sender As Object, e As EventArgs) Handles txtPostnr.TextChanged
        Dim payload As New DataTable
        payload = db.query("SELECT post_sted FROM sted WHERE sted.post_nr = '" & brukerGridView.Item((6), gridIndex).Value & "'")

        TextBox8.Text = payload.Rows(0).Item(0)
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        'Oppdater provisjons label med scrollbar veriden
        provisjonLabel(HScrollBar1.Value)
    End Sub

    Private Sub provisjonLabel(ByVal p As Integer)
        'Oppdater provisjons label med scrollbar veriden
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
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Legg til bruker
        'db.query("INSERT INTO personer (fornavn, etternavn, telefon, mail, adresse, post_nr, stilling, provisjon) VALUES ('" & txtNavn.Text & "', '" & txtEtternavn.Text & "', '" & txtTelefon.Text & "', '" & txtMail.Text & "', '" & txtAdresse.Text & "', '" & txtPostnr.Text & "', '" & stilling() & "', '" & HScrollBar1.Value & "')")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim bruker As String = Me.brukerGridView.Rows(gridIndex).Cells("fornavn").Value & " " & Me.brukerGridView.Rows(gridIndex).Cells("etternavn").Value
        'Slett bruker
        Select Case MsgBox("Er du sikker på at du vil fjern " & bruker & "?", MsgBoxStyle.YesNoCancel, "caption")
            Case MsgBoxResult.Yes
                db.query("DELETE FROM person WHERE id = '" & Me.brukerGridView.Rows(gridIndex).Cells("id").Value & "'")
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Oppdater bruker
    End Sub
End Class