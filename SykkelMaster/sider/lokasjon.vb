Public Class lokasjon
    Private gridIndex As Integer
    Private payload As New DataTable

    Private Sub lokasjon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oppdaterGridView()
    End Sub
    Private Sub oppdaterGridView(Optional ByVal sok As String = Nothing)
        Dim sql As String
        If Not sok = Nothing Then
            sql = "SELECT * FROM virksomhet WHERE fornavn LIKE '%" & sok & "%' OR telefon LIKE '%" & sok & "%'"
        Else
            sql = "SELECT * FROM virksomhet"
        End If
        payload = db.query(sql)
        Oppdaterlokasjon.DataSource = payload

        With Me.Oppdaterlokasjon
            ' Kolonne vises ikke 
            .Columns("id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("navn").HeaderText = "Lokasjon"
            .Columns("telefon").HeaderText = "Telefonnummer"
            .Columns("mail").HeaderText = "Epost"
            .Columns("adresse").HeaderText = "Adresse"
            .Columns("post_nr").HeaderText = "Postnr"

            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub
    Private Sub oversiktGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Oppdaterlokasjon.CellClick
        Dim sql As String = "SELECT * FROM virksomhet WHERE navn = '" & Me.Oppdaterlokasjon.Rows(Me.Oppdaterlokasjon.CurrentRow.Index).Cells("navn").Value & "'"
        payload = db.query(sql)
        gridIndex = Oppdaterlokasjon.CurrentRow.Index()

        With Me.Oppdaterlokasjon
            txtLokasjon.Text = .Rows(gridIndex).Cells("navn").Value
            txtTelefon.Text = .Rows(gridIndex).Cells("telefon").Value
            txtMail.Text = .Rows(gridIndex).Cells("mail").Value
            txtAdresse.Text = .Rows(gridIndex).Cells("adresse").Value
            txtpostnr.Text = .Rows(gridIndex).Cells("post_nr").Value
        End With
    End Sub


    Private Sub btnAddlocation_Click(sender As Object, e As EventArgs) Handles btnAddLocation.Click
        Dim sql As String
        sql = "INSERT INTO virksomhet(navn, telefon, mail, adresse, post_nr) VALUES ('" & txtLokasjon.Text & "', '" & txtTelefon.Text & "', '" & txtMail.Text & "', '" & txtAdresse.Text & "', " & txtpostnr.Text & ")"

        payload = db.query(sql)
        Oppdaterlokasjon.DataSource = payload
        oppdaterGridView()
    End Sub


    Private Sub txtpostnr_TextChanged(sender As Object, e As EventArgs) Handles txtpostnr.TextChanged
        payload = db.query("SELECT post_sted FROM sted WHERE sted.post_nr = " & txtpostnr.Text)
        'Oppdaterer poststedet når post nummer blir skrevet inn
        If payload.Rows.Count = 1 Then
            txtPoststed.Text = payload.Rows(0).Item(0)
        Else
            txtPoststed.Text = ""
        End If
    End Sub

    Private Sub btnUpdateLocation_Click(sender As Object, e As EventArgs) Handles btnUpdateLocation.Click
        Dim sql As String
        sql = "UPDATE virksomhet SET navn = '" & txtLokasjon.Text & "', telefon = '" & txtTelefon.Text & "', mail = '" & txtMail.Text & "', adresse = '" & txtAdresse.Text & "', post_nr = '" & txtpostnr.Text & "' WHERE id = '" & Me.Oppdaterlokasjon.Rows(gridIndex).Cells("id").Value & "'"
        Dim lokasjon As String = Me.Oppdaterlokasjon.Rows(gridIndex).Cells("navn").Value

        Select Case MsgBox("Er du sikker på at du vil oppdatere " & lokasjon & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                payload = db.query(sql)
                oppdaterGridView()

        End Select
    End Sub

    Private Sub BtnDeleteLocation_Click(sender As Object, e As EventArgs) Handles BtnDeleteLocation.Click
        'Slette en lokasjon i databasen
        Dim sql As String = "DELETE FROM sykkelmaster2015.virksomhet WHERE virksomhet.id = '" & Me.Oppdaterlokasjon.Rows(gridIndex).Cells("id").Value & "'"

        Dim virksomhet As String = Me.Oppdaterlokasjon.Rows(gridIndex).Cells("navn").Value
        'Slett virksomhet
        Select Case MsgBox("Er du sikker på at du vil fjern " & virksomhet & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    payload = db.query(sql)
                Catch
                    MsgBox("Du kan ikke slette lokasjon")
                End Try
        End Select

        oppdaterGridView()
    End Sub

    Private Sub btnTom_Click(sender As Object, e As EventArgs) Handles btnTom.Click
        txtLokasjon.Text = ""
        txtTelefon.Text = ""
        txtAdresse.Text = ""
        txtMail.Text = ""
        txtpostnr.Text = ""
        oppdaterGridView()
    End Sub

End Class