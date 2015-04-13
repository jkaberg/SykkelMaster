Public Class person
    Private person As clsPerson

    Private Sub kunder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Laster inn data fra databasen til gridView
        oppdaterGridView()
    End Sub

    Private Sub kundeGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles kundeGridView.CellClick
        oppdaterTxtbox()
    End Sub

    Private Sub txtPostnr_TextChanged(sender As Object, e As EventArgs) Handles txtPostnr.TextChanged
        'Henter opp poststed i textboxen
        If txtPostnr.Text <> "" Then
            txtPoststed.Text = daoDelt.finnPostSted(txtPostnr.Text)
        Else
            txtPoststed.Text = ""
        End If
    End Sub

    Public Sub oppdaterGridView(Optional ByVal sok As String = Nothing, Optional ByVal id As Integer = Nothing)
        'Søke på kundens fornavn, etternavn og telefonnr i databasen
        Dim payload As DataTable

        If Not id = Nothing Then
            payload = daoPerson.hentPersoner(id:=id)
        ElseIf sok = Nothing Then
            payload = daoPerson.hentPersoner()
        Else
            payload = daoPerson.hentPersoner(sok:=sok)
        End If

        With Me.kundeGridView
            .DataSource = payload
            'Kolonne vises ikke 
            .Columns("id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("fornavn").HeaderText = "Fornavn"
            .Columns("etternavn").HeaderText = "Etternavn"
            .Columns("telefon").HeaderText = "Telefon"
            .Columns("mail").HeaderText = "E-post"
            .Columns("adresse").HeaderText = "Adresse"
            .Columns("post_nr").HeaderText = "Postnr"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With

        If Not id = Nothing Then
            oppdaterTxtbox()
        End If
    End Sub

    Private Sub oppdaterTxtbox()
        'Setter inn datane fra Grid Viewn i Textboksene
        With Me.kundeGridView
            txtNavn.Text = .Rows(Me.kundeGridView.CurrentRow.Index).Cells("fornavn").Value
            txtEtternavn.Text = .Rows(Me.kundeGridView.CurrentRow.Index).Cells("etternavn").Value
            txtTelefon.Text = .Rows(Me.kundeGridView.CurrentRow.Index).Cells("telefon").Value
            txtAdresse.Text = .Rows(Me.kundeGridView.CurrentRow.Index).Cells("adresse").Value
            txtMail.Text = .Rows(Me.kundeGridView.CurrentRow.Index).Cells("mail").Value
            txtPostnr.Text = .Rows(Me.kundeGridView.CurrentRow.Index).Cells("post_nr").Value
        End With
    End Sub

    Private Sub sokKunde_TextChanged(sender As Object, e As EventArgs) Handles sokKunde.TextChanged
        oppdaterGridView(sok:=sokKunde.Text)
    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        'Legg til en ny person
        Try
            Dim person As New clsPerson(txtNavn.Text, txtEtternavn.Text, txtPostnr.Text, txtTelefon.Text, txtAdresse.Text, txtMail.Text)

            daoPerson.leggTilPerson(person)
            MsgBox(navn() & " lagt til.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            oppdaterGridView()
        End Try
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Oppdater bruker
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & navn() & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim person As New clsPerson(Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("id").Value,
                                                txtNavn.Text,
                                                txtEtternavn.Text,
                                                txtPostnr.Text,
                                                txtTelefon.Text,
                                                txtAdresse.Text,
                                                txtMail.Text)

                    daoPerson.oppdaterPerson(person)
                    MsgBox(navn() & " er oppdatert.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                    oppdaterTxtbox()
                End Try
        End Select
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Slett bruker
        Select Case MsgBox("Er du sikker på at du vil fjern " & navn() & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim person As New clsPerson(Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("id").Value,
                                                txtNavn.Text,
                                                txtEtternavn.Text)

                    daoPerson.fjernPerson(person)
                    MsgBox(navn() & " fjernet.", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                End Try
        End Select
    End Sub

    Private Sub btnTom_Click(sender As Object, e As EventArgs) Handles btnTom.Click
        'Tøm tekstbokser
        txtNavn.Text = ""
        txtEtternavn.Text = ""
        txtAdresse.Text = ""
        txtMail.Text = ""
        txtPostnr.Text = ""
        txtTelefon.Text = ""
    End Sub

    Private Function navn() As String
        Return txtNavn.Text & " " & txtEtternavn.Text
    End Function
End Class