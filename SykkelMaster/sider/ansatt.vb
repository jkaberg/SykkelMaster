Public Class ansatte
    Private payload As New DataTable

    Private Sub bruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Laster inn daten fra databasen til GridView
        oppdaterGridView()

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
    End Sub

    Private Sub Vis_bruker(sender As Object, e As DataGridViewCellEventArgs) Handles brukerGridView.CellClick
        'Setter inn dataen fra Grid Viewn i Textboksene
        With Me.brukerGridView
            txtNavn.Text = .Rows(Me.brukerGridView.CurrentRow.Index).Cells("fornavn").Value
            txtEtternavn.Text = .Rows(Me.brukerGridView.CurrentRow.Index).Cells("etternavn").Value
            txtTelefon.Text = .Rows(Me.brukerGridView.CurrentRow.Index).Cells("telefon").Value
            txtAdresse.Text = .Rows(Me.brukerGridView.CurrentRow.Index).Cells("adresse").Value
            txtMail.Text = .Rows(Me.brukerGridView.CurrentRow.Index).Cells("mail").Value
            txtPostnr.Text = .Rows(Me.brukerGridView.CurrentRow.Index).Cells("post_nr").Value

            'Sett provisjonen
            provisjonLabel(.Rows(Me.brukerGridView.CurrentRow.Index).Cells("provisjon").Value)
        End With
        stilling()
        arbeidssted()
    End Sub

    Private Sub txtPostnr_TextChanged(sender As Object, e As EventArgs) Handles txtPostnr.TextChanged
        Dim sok As String = daoDelt.finnPostSted(txtPostnr.Text)

        If sok <> "" Then
            txtPostSted.Text = sok
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
        If Not ProvisjonBar.Value = p Then
            ProvisjonBar.Value = p
        End If
        lblProvisjon.Text = p & "%"
    End Sub

    Private Sub stilling()
        payload = daoDelt.hentStillinger()

        With cbxStilling
            .DisplayMember = "stilling"
            .ValueMember = "id"
            .DataSource = payload
        End With

        'oppdaterer stillling fra databasen i combobox
        For i As Integer = 0 To payload.Rows.Count - 1
            If payload.Rows(i)(cbxStilling.DisplayMember).ToString() = Me.brukerGridView.Rows(Me.brukerGridView.CurrentRow.Index).Cells("stilling").Value Then
                Me.cbxStilling.SelectedIndex = i
            End If
        Next
    End Sub

    Private Sub arbeidssted()
        Dim lokasjon As DataTable = daoDelt.hentVirksomhet

        With cbxArbedidssted
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = lokasjon
        End With

        'oppdaterer stillling fra databasen i combobox
        For i As Integer = 0 To lokasjon.Rows.Count - 1
            If lokasjon.Rows(i)(cbxArbedidssted.DisplayMember).ToString() = Me.brukerGridView.Rows(Me.brukerGridView.CurrentRow.Index).Cells("navn").Value Then
                Me.cbxArbedidssted.SelectedIndex = i
            End If
        Next
    End Sub

    Private Sub oppdaterGridView()
        brukerGridView.DataSource = daoAnsatt.hentAnsatte()

        With Me.brukerGridView
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
            .Columns("provisjon").DefaultCellStyle.Format = "p1" ' legger til prosenttegn etter provisjon, tallet er antal desimaler
            .Columns("navn").HeaderText = "Arbeidsplass"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Refresh()
        End With
    End Sub

    Private Sub btnLeggTilBruker(sender As Object, e As EventArgs) Handles btnLegg_til_Bruker.Click
        Dim passord As String = verktoy.tilfeldigStreng()

        Dim body As String = "Hei " & navn() & ", og velkommen til Sykkelmaster." & vbNewLine &
                             "Det er opprettet en ny bruker til deg med følgende opplysninger" & vbNewLine & vbNewLine &
                             "Brukernavn: " & txtMail.Text & vbNewLine &
                             "Passord: " & passord & vbNewLine & vbNewLine &
                             "Hilsen, SykkelMaster"

        If daoDelt.sjekkBrukerEksisterer(txtMail.Text) Then
            MsgBox("Det eksisterer allerede en bruker med mail adresse " & txtMail.Text & ", vennligt velg noe annet.", MsgBoxStyle.Critical)
        Else
            Select Case MsgBox("Er du sikker på at du vil legg til " & navn() & "?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    Try
                        Dim ansatt As New clsAnsatt(txtNavn.Text, txtEtternavn.Text, txtPostnr.Text, txtTelefon.Text, txtAdresse.Text, txtMail.Text, CInt(cbxStilling.SelectedValue), CInt(ProvisjonBar.Value), CInt(cbxArbedidssted.SelectedValue), passord)

                        daoAnsatt.leggTilAnsatt(ansatt)
                        verktoy.sendMail(txtMail.Text, "Ny bruker i Sykkelmaster", body)
                        MsgBox(navn() & " lagt til.", MsgBoxStyle.Exclamation)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    Finally
                        oppdaterGridView()
                    End Try
            End Select
        End If
    End Sub

    Private Sub Slett_Bruker(sender As Object, e As EventArgs) Handles btnSlett_Bruker.Click
        'Slett bruker
        Select Case MsgBox("Er du sikker på at du vil fjern " & navn() & "?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    Dim ansatt As New clsAnsatt(Me.brukerGridView.Rows(Me.brukerGridView.CurrentRow.Index).Cells("id").Value, txtNavn.Text, txtEtternavn.Text)

                    daoAnsatt.fjernAnsatt(ansatt)
                    MsgBox(navn() & " er fjernet.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                End Try
        End Select
    End Sub

    Private Sub Oppdater_Bruker(sender As Object, e As EventArgs) Handles btnOppdater_Bruker.Click
        'Oppdater bruker
        Select Case MsgBox("Er du sikker på at du vil oppdater " & navn() & "?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    Dim ansatt As New clsAnsatt(CInt(Me.brukerGridView.Rows(Me.brukerGridView.CurrentRow.Index).Cells("id").Value), txtNavn.Text, txtEtternavn.Text, txtPostnr.Text, txtTelefon.Text, txtAdresse.Text, txtMail.Text, cbxStilling.SelectedValue, ProvisjonBar.Value, cbxArbedidssted.SelectedValue)

                    daoAnsatt.oppdaterAnsatt(ansatt)
                    MsgBox(navn() & " er oppdatert.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                End Try
        End Select
    End Sub

    Private Function navn() As String
        Return txtNavn.Text & " " & txtEtternavn.Text
    End Function
End Class