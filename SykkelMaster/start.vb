Imports SykkelMaster.db
Imports SykkelMaster.util
Imports SykkelMaster.ansatt
Imports System.Net.Mail
Imports System.Configuration
Imports MySql.Data.MySqlClient


Public Class start
    Public bruker As ansatt

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEpost.Text = "d@"
        txtPassord.Text = "d"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sjekkLogin(txtEpost.Text, txtPassord.Text) Then
            hoved.Show()
            Me.Hide()
        Else
            MsgBox("Feil e-post eller passord.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'settPassord(byttEpost.Text)
        sjekkMail(byttEpost.Text)
        'byttEpost.Text = ""
    End Sub

    Private Function sjekkLogin(ByVal epost As String, ByVal passord As String)
        'Sjekk i databasen om epost å passord eksistere 
        Dim payload As New DataTable
        Dim sql As String = "SELECT " &
                            "person.id, person.fornavn, person.etternavn, person.telefon, person.mail, person.adresse, person.post_nr, " &
                            "ansatt.provisjon, " &
                            "sted.post_sted, " &
                            "stilling.tilgangsniva " &
                            "FROM person JOIN ansatt " &
                            "ON person.mail = '" & epost & "' " &
                            "JOIN sted ON sted.post_nr = person.post_nr JOIN stilling " &
                            "ON ansatt.stilling = stilling.id " &
                            "WHERE ansatt.passord = '" & passord & "'"
        payload = db.query(sql)

        'Hvis payload inneholder en rad så har vi korrekt epost/passord
        If payload.Rows.Count = 1 Then
            Dim d As DataRow = payload.Rows(0)

            'Lag objektet ansatt med dataen fra objektet d
            bruker = New ansatt(d("id"),
                                d("fornavn"),
                                d("etternavn"),
                                d("post_nr"),
                                d("telefon"),
                                d("adresse"),
                                d("post_sted"),
                                d("mail"),
                                d("tilgangsniva"),
                                d("provisjon"))
            Return True
        End If
        Return False
    End Function

    Private Function settPassord(ByVal epost As String)
        'Setter en variabel passord lik funksjonen som lager tilfeldig passord, slik at den ikke blir kjørt flere ganger.
        Dim passord As String = util.tilfeldigStreng()

        Dim payload As New DataTable
        Dim sql As String = "UPDATE ansatt " &
                            "JOIN person ON ansatt.person_id = person.id " &
                            "SET ansatt.passord = '" & passord & "' " &
                            "WHERE person.mail = '" & epost & "'"
        payload = db.query(sql)

            'sendMail(epost, passord)
        If sjekkMail(byttEpost.Text) Then
            util.sendMail(epost, "Bytt Passord", "Her er ditt nye passord: " & passord)
            MsgBox("Ditt nye passord er sendt til deg på mail.")
        Else
            MsgBox("Epost ikke registrert")
            Return False
        End If

        Return True
    End Function

    Private Function sjekkMail(ByVal epost As String)
        Dim payload As New DataTable
        Dim sql As String = "SELECT mail from person WHERE mail='" & epost & "'"

        payload = db.query(sql)
        If payload.Rows.Count = 1 Then
            MsgBox("hei")
            Return True
        Else
            Return False
            MsgBox("Finnes ikke")
        End If
    End Function
End Class
