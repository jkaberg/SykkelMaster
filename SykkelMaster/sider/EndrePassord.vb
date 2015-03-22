Imports SykkelMaster.db
Imports SykkelMaster.util
Imports SykkelMaster.ansatt
Imports System.Net.Mail
Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class EndrePassord

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If sjekkPassord(eposttxt.Text, nåværendePassordtxt.Text) = True Then
            If nyttPassordtxt.Text.Length > 30 Or nåværendePassordtxt.Text.Length > 30 Then
                MsgBox("Passord må inneholde mindre enn 30 tegn")
            Else
                endrePassord()
                MsgBox("Passordet er endret til: " & nyttPassordtxt.Text)

                eposttxt.Text = ""
                nåværendePassordtxt.Text = ""
                nyttPassordtxt.Text = ""
            End If
        Else
            MsgBox("E-post eller nåværende passord er feil, eller ikke funnet i databasen.")
        End If


    End Sub


    Private Sub endrePassord()

        Dim payload As New DataTable
        Dim sql As String = "UPDATE ansatt " &
                            "JOIN person ON ansatt.person_id = person.id " &
                            "SET ansatt.passord = '" & nyttPassordtxt.Text & "' " &
                            "WHERE person.mail = '" & eposttxt.Text & "'"
        payload = db.query(sql)
    End Sub

    Private Function sjekkPassord(ByVal mail As String, ByVal current As String)

        Dim payload As New DataTable
        Dim sql As String = "SELECT * FROM ansatt " &
                            "JOIN person ON ansatt.person_id = person.id " &
                            "WHERE passord = '" & current & "' " &
                            "AND Mail = '" & mail & "'"

        'SELECT person.mail, ansatt.passord
        'FROM person
        'INNER JOIN ansatt
        'ON ansatt.person_id=person.id;

        'Prøvde å fikse bedre join så man kun får ut passord og epost, ikke alt annet drit.. men funka dårlig når jeg kjørte koden




        payload = db.query(sql)

        If payload.Rows.Count = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class