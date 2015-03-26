Public Class bruker
    Private gridIndex As Integer
    Private payload As New DataTable

    Private Sub bruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Laster inn daten fra databasen til GridView
        oppdaterGridView()

        'Laster inn data til comboBoxen cbx stilling
        payload = db.query("SELECT * FROM stilling")
        With cbxStilling
            .DisplayMember = "stilling"
            .ValueMember = "id"
            .DataSource = payload
        End With
    End Sub

    Private Sub Vis_bruker(sender As Object, e As DataGridViewCellEventArgs) Handles brukerGridView.CellClick
        'Sett nåværende DataGrid index sånn at vi finner rett rad i DataTablen
        gridIndex = brukerGridView.CurrentRow.Index

        'Setter inn dataen fra Grid Viewn i Textboksene
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
        stilling()
    End Sub

    Private Sub txtPostnr_TextChanged(sender As Object, e As EventArgs) Handles txtPostnr.TextChanged
        payload = db.query("SELECT post_sted FROM sted WHERE sted.post_nr = '" & txtPostnr.Text & "'")
        'Oppdaterer poststedet når post nummer blir skrevet inn
        If payload.Rows.Count = 1 Then
            TextBox8.Text = payload.Rows(0).Item(0)
        Else
            TextBox8.Text = ""
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
        Label10.Text = p & "%"
    End Sub

    Private Sub stilling()
        Dim sql As String = "SELECT id, stilling FROM stilling"
        payload = db.query(sql)

        With cbxStilling
            .DisplayMember = "stilling"
            .ValueMember = "id"
            .DataSource = payload
        End With

        'oppdaterer stillling fra databasen i combobox
        For i As Integer = 0 To payload.Rows.Count - 1
            If payload.Rows(i)(cbxStilling.DisplayMember).ToString() = Me.brukerGridView.Rows(gridIndex).Cells("stilling").Value Then
                Me.cbxStilling.SelectedIndex = i
            End If
        Next
    End Sub

    Private Sub oppdaterGridView()
        Dim sql As String = "SELECT " &
                            "person.id, person.fornavn, person.etternavn, person.telefon, person.mail, person.adresse, person.post_nr, " &
                            "ansatt.provisjon, " &
                            "sted.post_sted, " &
                            "stilling.stilling " &
                            "FROM person JOIN ansatt " &
                            "ON person.id = ansatt.person_id " &
                            "JOIN sted ON sted.post_nr = person.post_nr JOIN stilling " &
                            "ON ansatt.stilling = stilling.id"
        'payload = db.query("SELECT * FROM person JOIN ansatt ON person.id = ansatt.person_id")
        payload = db.query(sql)
        brukerGridView.DataSource = payload

        ' Sett gridIndex sånn at vi finner frem i djungelen av data fra databasen
        gridIndex = brukerGridView.CurrentRow.Index

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
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With

        txtNavn.Text = ""
        txtEtternavn.Text = ""
        txtTelefon.Text = ""
        txtAdresse.Text = ""
        txtMail.Text = ""
        txtPostnr.Text = ""
    End Sub

    Private Sub leggTilBruker()
        Dim passord As String = util.tilfeldigStreng()
        Dim body As String = "Hei og velkommen til Sykkelmaster," & vbNewLine &
                             "Det er opprettet en ny bruker til deg med følgende opplysninger" & vbNewLine & vbNewLine &
                             "Brukernavn: " & txtMail.Text & vbNewLine &
                             "Passord: " & passord & vbNewLine & vbNewLine &
                             "Hilsen, SykkelMaster"

        Dim sql As String = "START TRANSACTION;" &
                            "INSERT INTO person (fornavn, etternavn, telefon, mail, adresse, post_nr) " &
                            "VALUES ('" & txtNavn.Text & "', '" & txtEtternavn.Text & "', '" & CInt(txtTelefon.Text) & "', '" & txtMail.Text & "', '" & txtAdresse.Text & "', '" & CInt(txtPostnr.Text) & "');" &
                            "INSERT INTO ansatt(person_id, stilling, provisjon, passord, virksomhet_id) " &
                            "VALUES (LAST_INSERT_ID(), '" & CInt(cbxStilling.SelectedValue) & "', '" & CInt(ProvisjonBar.Value) & "', '" & passord & "', 1);" &
                            "COMMIT;"
        payload = db.query(sql)

        ' SPØRR

        If payload.Rows.Count = 1 Then
            MsgBox("Bruker" & txtNavn.Text & " " & txtEtternavn.Text & " lagt til.")
            util.sendMail(txtMail.Text, "Ny bruker i Sykkelmaster", body)
        End If
    End Sub

    Private Sub fjernBruker(ByVal id As Integer)
        Dim sql As String = "DELETE FROM ansatt WHERE ansatt.person_id = " & id
        payload = db.query(sql)

        If payload.Rows.Count > 0 Then
            MsgBox("Bruker er fjernet.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnLeggTilBruker(sender As Object, e As EventArgs) Handles btnLegg_til_Bruker.Click
        Dim bruker As String = txtNavn.Text & " " & txtEtternavn.Text
        If util.sjekkBrukerEksisterer(txtMail.Text) Then
            MsgBox("Det eksisterer allerede en bruker med mail adresse " & txtMail.Text & ", vennligt velg noe annet.", MsgBoxStyle.Critical)
        Else
            Select Case MsgBox("Er du sikker på at du vil legg til " & bruker & "?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    leggTilBruker()
            End Select
        End If

        oppdaterGridView()
    End Sub

    Private Sub Slett_Bruker(sender As Object, e As EventArgs) Handles btnSlett_Bruker.Click
        Dim bruker As String = Me.brukerGridView.Rows(gridIndex).Cells("fornavn").Value & " " & Me.brukerGridView.Rows(gridIndex).Cells("etternavn").Value
        'Slett bruker
        Select Case MsgBox("Er du sikker på at du vil fjern " & bruker & "?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                fjernBruker(Me.brukerGridView.Rows(gridIndex).Cells("id").Value)
        End Select

        'Ettersom vi slettet ansatte så må vi oppdatere gridView
        oppdaterGridView()
    End Sub

    Private Sub Oppdater_Bruker(sender As Object, e As EventArgs) Handles btnOppdater_Bruker.Click
        'Oppdater bruker
        'db.query("UPDATE TABLE personer (fornavn, etternavn, telefon, mail, adresse, post_nr, stilling, provisjon) VALUES ('" & txtNavn.Text & "', '" & txtEtternavn.Text & "', '" & txtTelefon.Text & "', '" & txtMail.Text & "', '" & txtAdresse.Text & "', '" & txtPostnr.Text & "', '" & stilling() & "', '" & HScrollBar1.Value & "')")
        oppdaterGridView()
    End Sub
End Class