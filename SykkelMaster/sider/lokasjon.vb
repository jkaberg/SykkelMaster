Public Class lokasjoner
    Private payload As New DataTable

    Private Sub lokasjon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With lokasjonGrid
            .DataSource = daoLokasjon.hentLokasjoner()
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
    Private Sub oppdaterGridView(Optional ByVal sok As String = Nothing)
        lokasjonGrid.DataSource = daoLokasjon.hentLokasjoner(sok)
    End Sub
    Private Sub oversiktGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles lokasjonGrid.CellClick
        'legger inn info i tekstboksene
        With lokasjonGrid
            txtNavn.Text = daoDelt.finnDGWVerdi(lokasjonGrid, "navn")
            txtTelefon.Text = daoDelt.finnDGWVerdi(lokasjonGrid, "telefon")
            txtMail.Text = daoDelt.finnDGWVerdi(lokasjonGrid, "mail")
            txtAdresse.Text = daoDelt.finnDGWVerdi(lokasjonGrid, "adresse")
            txtPostnr.Text = daoDelt.finnDGWVerdi(lokasjonGrid, "post_nr")
        End With
    End Sub


    Private Sub btnAddlocation_Click(sender As Object, e As EventArgs) Handles btnAddLocation.Click
        'legger til lokasjon
        Try
            Dim lokasjon As New clsLokasjon(txtNavn.Text,
                                            txtMail.Text,
                                            txtAdresse.Text,
                                            txtTelefon.Text,
                                            txtPostnr.Text)

            daoLokasjon.leggTilLokasjon(lokasjon)
            MsgBox(lokasjon.pNavn & " lagt til.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            lokasjonGrid.DataSource = daoLokasjon.hentLokasjoner
        End Try
    End Sub


    Private Sub txtpostnr_TextChanged(sender As Object, e As EventArgs) Handles txtPostnr.TextChanged
        'henter frem poststed ut ifra postnummer
        If IsNumeric(txtPostnr.Text) Then
            txtPoststed.Text = daoDelt.finnPostSted(txtPostnr.Text)
        End If
    End Sub

    Private Sub btnUpdateLocation_Click(sender As Object, e As EventArgs) Handles btnUpdateLocation.Click
        'oppdaterer lokasjon
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & txtNavn.Text & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim lokasjon As New clsLokasjon(daoDelt.finnDGWVerdi(lokasjonGrid, "id"),
                                                    txtNavn.Text,
                                                    txtMail.Text,
                                                    txtAdresse.Text,
                                                    txtTelefon.Text,
                                                    txtPostnr.Text)

                    daoLokasjon.oppdaterLokasjon(lokasjon)
                    MsgBox(txtNavn.Text & " oppdatert.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    lokasjonGrid.DataSource = daoLokasjon.hentLokasjoner
                End Try
        End Select
    End Sub

    Private Sub BtnDeleteLocation_Click(sender As Object, e As EventArgs) Handles BtnDeleteLocation.Click
        'Slette en lokasjon i databasen
        Select Case MsgBox("Er du sikker på at du vil fjern " & txtNavn.Text & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim lokasjon As New clsLokasjon(daoDelt.finnDGWVerdi(lokasjonGrid, "id"),
                                                    txtNavn.Text)

                    daoLokasjon.fjernLokasjon(lokasjon)
                    MsgBox(txtNavn.Text & " fjernet.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    lokasjonGrid.DataSource = daoLokasjon.hentLokasjoner
                End Try
        End Select
    End Sub

    Private Sub btnTom_Click(sender As Object, e As EventArgs) Handles btnTom.Click
        txtNavn.Text = ""
        txtTelefon.Text = ""
        txtAdresse.Text = ""
        txtMail.Text = ""
        txtPostnr.Text = ""
        txtPoststed.Text = ""

        lokasjonGrid.DataSource = daoLokasjon.hentLokasjoner
    End Sub
End Class