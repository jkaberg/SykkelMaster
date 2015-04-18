Public Class ansatte
    Private payload As New DataTable
    ''' <summary>
    ''' Laster inn data fra databasen til Gridview.
    ''' Legger stillinger og arbeidssteder i combobox
    ''' Endrer navn på kolonnene for brukervennlighet
    ''' </summary>
    Private Sub bruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With cbxStilling
            .DisplayMember = "stilling"
            .ValueMember = "id"
            .DataSource = daoDelt.hentStillinger
        End With

        With cbxArbedidssted
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = daoDelt.hentVirksomhet
        End With

        With brukerGridView
            .DataSource = daoAnsatt.hentAnsatte
            'Vis ikke enkelte kolonner 
            .Columns("id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("fornavn").HeaderText = "Fornavn"
            .Columns("etternavn").HeaderText = "Etternavn"
            .Columns("telefon").HeaderText = "Telefon"
            .Columns("mail").HeaderText = "E-post"
            .Columns("adresse").HeaderText = "Adresse"
            .Columns("post_nr").HeaderText = "Postnr"
            .Columns("stilling").HeaderText = "Stilling"
            .Columns("post_sted").HeaderText = "Post sted"
            .Columns("provisjon").HeaderText = "Provisjon"
            .Columns("provisjon").DefaultCellStyle.Format = "p1" ' legger til prosenttegn etter provisjon, tallet er antall desimaler
            .Columns("navn").HeaderText = "Arbeidsplass"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Refresh()
        End With
    End Sub

    Private Sub Vis_bruker(sender As Object, e As DataGridViewCellEventArgs) Handles brukerGridView.CellClick
        'Setter inn dataen fra Grid Viewn i Textboksene
        With Me.brukerGridView
            txtNavn.Text = daoDelt.finnDGWVerdi(brukerGridView, "fornavn")
            txtEtternavn.Text = daoDelt.finnDGWVerdi(brukerGridView, "etternavn")
            txtTelefon.Text = daoDelt.finnDGWVerdi(brukerGridView, "telefon")
            txtAdresse.Text = daoDelt.finnDGWVerdi(brukerGridView, "adresse")
            txtMail.Text = daoDelt.finnDGWVerdi(brukerGridView, "mail")
            txtPostnr.Text = daoDelt.finnDGWVerdi(brukerGridView, "post_nr")
            cbxStilling.Text = daoDelt.finnDGWVerdi(brukerGridView, "stilling")
            cbxArbedidssted.Text = daoDelt.finnDGWVerdi(brukerGridView, "navn")

            'Sett provisjonen
            provisjonLabel(daoDelt.finnDGWVerdi(brukerGridView, "provisjon"))
        End With
    End Sub

    Private Sub txtPostnr_TextChanged(sender As Object, e As EventArgs) Handles txtPostnr.TextChanged
        If txtPostnr.Text <> "" Then
            txtPostSted.Text = daoDelt.finnPostSted(txtPostnr.Text)
        Else
            txtPostSted.Text = ""
        End If
    End Sub

    Private Sub ProvisjoBar_Scroll(sender As Object, e As ScrollEventArgs) Handles ProvisjonBar.Scroll
        'Oppdater provisjonslabel med scrollbar veriden
        provisjonLabel(ProvisjonBar.Value)
    End Sub

    Private Sub provisjonLabel(ByVal p As Integer)
        'Oppdater provisjonslabel med scrollbar veriden
        lblProvisjon.Text = p & "%"
    End Sub

    Private Sub btnLeggTilBruker(sender As Object, e As EventArgs) Handles btnLegg_til_Bruker.Click
        'legg til ansatt
        Dim passord As String = verktoy.tilfeldigStreng()

        Dim body As String = "Hei " & navn() & ", og velkommen til Sykkelmaster." & vbNewLine &
                             "Det er opprettet en ny bruker til deg med følgende opplysninger" & vbNewLine & vbNewLine &
                             "Brukernavn: " & txtMail.Text & vbNewLine &
                             "Passord: " & passord & vbNewLine & vbNewLine &
                             "Hilsen, SykkelMaster"

        If daoDelt.sjekkMailEksisterer(txtMail.Text) Then
            MsgBox("Det eksisterer allerede en bruker med mail adresse " & txtMail.Text & ", vennligt velg noe annet.", MsgBoxStyle.Critical)
        Else
            Select Case MsgBox("Er du sikker på at du vil legg til " & navn() & "?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    Try
                        Dim ansatt As New clsAnsatt(fnavn:=txtNavn.Text,
                                                    enavn:=txtEtternavn.Text,
                                                    pnr:=txtPostnr.Text,
                                                    tnr:=txtTelefon.Text,
                                                    adresse:=txtAdresse.Text,
                                                    epost:=txtMail.Text,
                                                    stilling:=cbxStilling.SelectedValue,
                                                    provisjon:=ProvisjonBar.Value,
                                                    arbeidssted:=cbxArbedidssted.SelectedValue,
                                                    passord:=passord)

                        daoAnsatt.leggTilAnsatt(ansatt)
                        verktoy.sendMail(txtMail.Text, "Ny bruker i Sykkelmaster", body)
                        MsgBox(navn() & " lagt til.", MsgBoxStyle.Exclamation)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    Finally
                        brukerGridView.DataSource = daoAnsatt.hentAnsatte
                    End Try
            End Select
        End If
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Slett bruker
        Select Case MsgBox("Er du sikker på at du vil fjerne " & navn() & "?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    Dim ansatt As New clsAnsatt(id:=daoDelt.finnDGWVerdi(brukerGridView, "id"),
                                                fnavn:=txtNavn.Text,
                                                enavn:=txtEtternavn.Text)

                    daoAnsatt.fjernAnsatt(ansatt)
                    MsgBox(navn() & " er fjernet.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    brukerGridView.DataSource = daoAnsatt.hentAnsatte
                End Try
        End Select
    End Sub

    Private Sub Oppdater_Bruker(sender As Object, e As EventArgs) Handles btnOppdater_Bruker.Click
        'Oppdater bruker
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & navn() & "?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    Dim ansatt As New clsAnsatt(id:=daoDelt.finnDGWVerdi(brukerGridView, "id"),
                                                fnavn:=txtNavn.Text,
                                                enavn:=txtEtternavn.Text,
                                                pnr:=txtPostnr.Text,
                                                tnr:=txtTelefon.Text,
                                                adresse:=txtAdresse.Text,
                                                epost:=txtMail.Text,
                                                stilling:=cbxStilling.SelectedValue,
                                                provisjon:=ProvisjonBar.Value,
                                                arbeidssted:=cbxArbedidssted.SelectedValue)

                    daoAnsatt.oppdaterAnsatt(ansatt)
                    MsgBox(navn() & " er oppdatert.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    brukerGridView.DataSource = daoAnsatt.hentAnsatte
                End Try
        End Select
    End Sub

    Private Function navn() As String
        Return txtNavn.Text & " " & txtEtternavn.Text
    End Function

    Private Sub btnTom_Click(sender As Object, e As EventArgs) Handles btnTom.Click
        txtNavn.Text = ""
        txtEtternavn.Text = ""
        txtTelefon.Text = ""
        txtMail.Text = ""
        txtAdresse.Text = ""
        txtPostnr.Text = ""
        cbxStilling.SelectedIndex = -1
        cbxArbedidssted.SelectedIndex = -1
        ProvisjonBar.Value = 0

        brukerGridView.DataSource = daoAnsatt.hentAnsatte
    End Sub
End Class