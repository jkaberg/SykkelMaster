Public Class kunder
    Private payload As New DataTable
    Private valider_feilmelding As String = ""

    Private Sub kunder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Laster inn data fra databasen til gridView
        oppdaterGridView()
    End Sub

    Private Sub kundeGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles kundeGridView.CellClick
        oppdaterTxtbox()
    End Sub

    Private Sub txtPostnr_TextChanged(sender As Object, e As EventArgs) Handles txtPostnr.TextChanged
        'Henter opp poststed i textboxen
        payload = db.query("SELECT post_sted FROM sted WHERE sted.post_nr = '" & txtPostnr.Text & "'")

        If payload.Rows.Count = 1 Then
            txtPoststed.Text = payload.Rows(0).Item(0)
        Else
            txtPoststed.Text = ""
        End If
    End Sub

    Public Sub oppdaterGridView(Optional ByVal sok As String = Nothing, Optional ByVal id As Integer = Nothing)
        'Søke på kundens fornavn, etternavn og telefonnr i databasen
        Dim sql As String

        If Not id = Nothing Then
            sql = "SELECT * FROM person WHERE id = " & id & ";"
        ElseIf sok = Nothing Then
            sql = "SELECT * FROM person"
        Else
            sql = "SELECT * FROM person WHERE fornavn LIKE '%" & sok & "%' OR telefon LIKE '%" & sok & "%' OR etternavn LIKE '%;"
        End If
        payload = db.query(sql)
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
        'Legge til en ny person i databasen
        Dim sql As String
        sql = "INSERT INTO person (fornavn, etternavn, telefon, mail, adresse, post_nr) VALUES('" & txtNavn.Text & "', '" & txtEtternavn.Text & "', " & txttelefon.Text & ", '" & txtMail.Text & "', '" & txtAdresse.Text & "', " & txtPostnr.Text & ")"


        If ValiderKunde() Then
            db.query(sql)
            oppdaterGridView()
            oppdaterTxtbox()
        Else
            MsgBox(valider_feilmelding, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Oppdatere person i databasen
        Dim sql As String = "UPDATE person SET fornavn = '" & txtNavn.Text & "', etternavn = '" & txtEtternavn.Text & "', telefon = " & txttelefon.Text & ", mail = '" & txtMail.Text & "', post_nr = " & txtPostnr.Text & " WHERE id =" & Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("id").Value

        Dim bruker As String = Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("fornavn").Value & " " & Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("etternavn").Value
        'Oppdater bruker

        If ValiderKunde() Then
            Select Case MsgBox("Er du sikker på at du vil oppdatere " & bruker & "?", MsgBoxStyle.YesNo, "caption")
                Case MsgBoxResult.Yes
                    payload = db.query(sql)
                    oppdaterGridView()
                    oppdaterTxtbox()
            End Select
        Else
            MsgBox(valider_feilmelding, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Slette en person i databasen
        Dim sql As String = "DELETE FROM sykkelmaster2015.person WHERE person.id = " & Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("id").Value

        Dim bruker As String = Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("fornavn").Value & " " & Me.kundeGridView.Rows(Me.kundeGridView.CurrentRow.Index).Cells("etternavn").Value
        'Slett bruker
        Select Case MsgBox("Er du sikker på at du vil fjern " & bruker & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    payload = db.query(sql)
                Catch
                    MsgBox("Du kan ikke slette person")
                End Try
        End Select

        oppdaterGridView()
    End Sub

    Private Sub btnTom_Click(sender As Object, e As EventArgs) Handles btnTom.Click
        txtNavn.Text = ""
        txtEtternavn.Text = ""
        txtAdresse.Text = ""
        txtMail.Text = ""
        txtPostnr.Text = ""
        txttelefon.Text = ""
        oppdaterGridView()
    End Sub

    Function ValiderKunde() As Boolean
        valider_feilmelding = ""

        If Not util.validerStreng(txtNavn.Text) Then
            valider_feilmelding &= "Feil input fornavn" & vbCrLf
            txtNavn.Text = ""

        End If

        If Not util.validerStreng(txtEtternavn.Text) Then
            valider_feilmelding &= "Feil input etternavn" & vbCrLf
            txtEtternavn.Text = ""
        End If

        If Not util.validerNummer(txttelefon.Text, 8) Then
            valider_feilmelding &= "Feil input telefonnummer" & vbCrLf
            txttelefon.Text = ""
        End If

        If Not util.validerEpost(txtMail.Text) Then
            valider_feilmelding &= "Feil input E-post" & vbCrLf
            txtMail.Text = ""
        End If

        If txtAdresse.Text = "" Then
            valider_feilmelding &= "Feil input adresse" & vbCrLf
            txtAdresse.Text = ""

        End If

        If Not util.validerNummer(txtPostnr.Text, 4) Then
            valider_feilmelding &= "Feil input postnummer" & vbCrLf
            txtPostnr.Text = ""
        End If

        If valider_feilmelding = "" Then
            Return True
        End If
    End Function

End Class