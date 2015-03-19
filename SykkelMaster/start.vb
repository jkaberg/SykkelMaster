Imports SykkelMaster.db
Imports SykkelMaster.ansatt
Imports System.Net.Mail
Imports System.Configuration

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
        If settPassord(TextBox3.Text) Then
            MsgBox("Passord sendt til " & TextBox3.Text)
        Else
            MsgBox("Feil e-post.", MsgBoxStyle.Critical)
        End If
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
                            "ON person.mail = '" & epost & "' AND ansatt.passord = '" & passord & "' " &
                            "JOIN sted ON sted.post_nr = person.post_nr JOIN stilling " &
                            "ON ansatt.stilling = stilling.id"
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
        Dim passord As String = RandomPassordGenerator()

        Dim payload As New DataTable
        Dim sql As String = "UPDATE ansatt " &
                            "JOIN person ON ansatt.person_id = person.id " &
                            "SET ansatt.passord = '" & passord & "' " &
                            "WHERE person.mail = '" & epost & "'"
        payload = db.query(sql)

        If Not payload.Rows.Count = 1 Then
            Return False
            If Not sendMail(epost) Then
                Return False
            End If
        End If

        Return True
    End Function

    Private Function sendMail(ByVal epost As String)
        Return False
    End Function


    Function RandomPassordGenerator() As String 'Funksjon som skal returnere et tilfeldig passord som skal brukes til "glemt passord"
        'Lager variabel random som ny random funksjon 
        Dim random As New Random
        'Lager variabel for alle mulige tegn som kan brukes i tilfeldig passord
        Dim tegnsett As String = "0123456789abcdefghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        'Lager variabel passord som en tom streng, før den blir lagt til i while løkken som genererer tilfeldige tall.
        Dim passord As String = ""
        'Stringposisjon holder styr på hvor random befinner seg
        Dim stringposisjon As Integer = 0

        'Løkken som genererer tall helt til telleren har 8 characters, og deretter legger til characters i Passord variabelen.
        For t As Integer = 0 To 7
            stringposisjon = random.Next(8, tegnsett.Length)
            passord &= tegnsett(stringposisjon)
        Next

        'Returnerer det nye genererte tilfeldige passord
        Return passord
    End Function

End Class
