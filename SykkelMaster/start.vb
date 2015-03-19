Imports SykkelMaster.db
Imports SykkelMaster.ansatt
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Configuration

Public Class start
    Public bruker As ansatt

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sjekkLogin(TextBox1.Text, TextBox2.Text) Then
            hoved.Show()
            Me.Hide()
        Else
            MsgBox("Feil e-post eller passord.", MsgBoxStyle.Critical)
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
        Console.WriteLine(sql)
        payload = db.query(sql)

        'Hvis payload inneholder en rad så har vi korrekt epost/passord
        If payload.Rows.Count = 1 Then
            Dim d As DataRow = payload.Rows(0)

            'Console.WriteLine(d("id"),
            '                  d("fornavn"),
            '                  d("etternavn"),
            '                  d("post_nr"),
            '                  d("telefon"),
            '                  d("adresse"),
            '                  d("post_sted"),
            '                  d("mail"),
            '                  d("tilgangsniva"),
            '                  d("provisjon"))

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




    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "d@"
        TextBox2.Text = "d"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Setter en variabel passord lik funksjonen som lager tilfeldig passord, slik at den ikke blir kjørt flere ganger.
        Dim passord = RandomPassordGenerator()

        Dim payload As New DataTable
        Dim sql As String = "SELECT " &
                            "person.mail, " &
                            "FROM person JOIN ansatt " &
                            "ON person.mail = '" & TextBox3.Text & "'"
        payload = db.query(sql)

        If payload.Rows.Count = 1 Then
            db.query("UPDATE ansatt JOIN person ON ansatt.person_id = person.id AND person.mail = '" & TextBox3.Text & "' set ansatt.passord ='" & passord & "'")

            ' MYSQL SETNING: UPDATE ansatt JOIN person ON ansatt.person_id = person.id And person.mail ='jens.ronneberg@gmail.com' set ansatt.passord ='jens';
        Else
            MsgBox("E-post eksiterer ikke.")
        End If

    End Sub



    Private Sub Send_Nytt_Passord(ByVal epost As String)

        'Setter en variabel passord lik funksjonen som lager tilfeldig passord, slik at den ikke blir kjørt flere ganger.
        Dim passord = RandomPassordGenerator()

        Dim payload As New DataTable
        Dim sql As String = "SELECT " &
                            "person.mail, " &
                            "FROM person JOIN ansatt " &
                            "ON person.mail = '" & epost & "'"
        payload = db.query(sql)

        If payload.Rows.Count = 1 Then
            db.query("UPDATE ansatt JOIN person ON ansatt.person_id = person.id AND person.mail ='" & epost & "'" & "set ansatt.passord ='" & passord & "'")
                     
            ' MYSQL SETNING: UPDATE ansatt JOIN person ON ansatt.person_id = person.id And person.mail ='jens.ronneberg@gmail.com' set ansatt.passord ='jens';
        Else
            MsgBox("E-post eksiterer ikke.")
        End If


    End Sub


    Function RandomPassordGenerator() As String 'Funksjon som skal returnere et tilfeldig passord som skal brukes til "glemt passord"

        'Lager variabel for alle mulige tegn som kan brukes i tilfeldig passord
        Dim tegnsett As String = "0123456789abcdefghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

        'Teller som brukes til å gå igjennom while løkken for å generere 8 tall.
        Dim passord_teller = 0
        'Lager variabel passord som en tom streng, før den blir lagt til i while løkken som genererer tilfeldige tall.
        Dim passord As String = ""

        'Lager variabel random som ny random funksjon 
        Dim random As New Random

        'Stringposisjon holder styr på hvor random befinner seg
        Dim stringposisjon = ""

        'Løkken som genererer tall helt til telleren har 8 characters, og deretter legger til characters i Passord variabelen.
        While passord_teller <= 8
            stringposisjon = random.Next(8, tegnsett.Length)

            passord &= tegnsett(stringposisjon)
            passord_teller = passord_teller + 1

        End While
        'Returnerer det nye genererte tilfeldige passord
        Return passord

    End Function

End Class
