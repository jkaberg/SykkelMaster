Public Class kunder
    Private person As person

    Private Sub kunder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Laster inn data fra databasen til gridView
        oppdaterGridView()
    End Sub

    Private Sub kundeGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles kundeGridView.CellClick
        oppdaterTxtbox()
    End Sub

    Private Sub txtPostnr_TextChanged(sender As Object, e As EventArgs) Handles txtPostnr.TextChanged
        'Henter opp poststed i textboxen
        Dim sok As String = util.finnPostSted(txtPostnr.Text)

        If sok <> "" Then
            txtPoststed.Text = sok
        Else
            txtPoststed.Text = ""
        End If
    End Sub

    Public Sub oppdaterGridView(Optional ByVal sok As String = Nothing, Optional ByVal id As Integer = Nothing)
        'Søke på kundens fornavn, etternavn og telefonnr i databasen
        Dim payload As DataTable

        If Not id = Nothing Then
            payload = personDAO.hentPersoner(id:=id)
        ElseIf sok = Nothing Then
            payload = personDAO.hentPersoner()
        Else
            payload = personDAO.hentPersoner(sok:=sok)
        End If

        kundeGridView.DataSource = payload

        With Me.kundeGridView
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
            txttelefon.Text = .Rows(Me.kundeGridView.CurrentRow.Index).Cells("telefon").Value
            txtAdresse.Text = .Rows(Me.kundeGridView.CurrentRow.Index).Cells("adresse").Value
            txtMail.Text = .Rows(Me.kundeGridView.CurrentRow.Index).Cells("mail").Value
            txtPostnr.Text = .Rows(Me.kundeGridView.CurrentRow.Index).Cells("post_nr").Value
        End With
    End Sub

    Private Sub sokKunde_TextChanged(sender As Object, e As EventArgs) Handles sokKunde.TextChanged
        oppdaterGridView(sok:=sokKunde.Text)
    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        'Legge til en ny person
        Dim person As New person(txtNavn.Text, txtEtternavn.Text, txtPostnr.Text, txttelefon.Text, txtAdresse.Text, txtPoststed.Text, txtMail.Text)

        Try
            personDAO.leggTilPerson(person)
            MsgBox("Kunde lagt til.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            oppdaterGridView()
        End Try
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Oppdater bruker
        Dim person As New person(Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("id").Value, txtNavn.Text, txtEtternavn.Text, txtPostnr.Text, txttelefon.Text, txtAdresse.Text, txtPoststed.Text, txtMail.Text)
        Dim bruker As String = Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("fornavn").Value & " " & Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("etternavn").Value

        Select Case MsgBox("Er du sikker på at du vil oppdatere " & bruker & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    personDAO.oppdaterPerson(person)
                    MsgBox(bruker & " er oppdatert.", MsgBoxStyle.Exclamation)
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
        Dim person_id As Integer = Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("id").Value
        Dim bruker As String = Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("fornavn").Value & " " & Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("etternavn").Value

        Select Case MsgBox("Er du sikker på at du vil fjern " & bruker & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    personDAO.fjernPerson(person_id)
                    MsgBox(bruker & " fjernet.", MsgBoxStyle.Information)
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
        txttelefon.Text = ""
        oppdaterGridView()
    End Sub
End Class