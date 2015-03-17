Imports SykkelMaster.db
Imports SykkelMaster.ansatt
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
        payload = db.query("SELECT * FROM person JOIN ansatt ON person.mail = '" & epost & "' AND ansatt.passord = '" & passord & "' JOIN sted ON sted.post_nr = person.post_nr")

        'Hvis payload inneholder en rad så har vi korrekt epost/passord
        If payload.Rows.Count = 1 Then
            Dim d As DataRow = payload.Rows(0)

            'Lag objektet ansatt med dataen fra objektet d
            bruker = New ansatt(d("person_id"),
                                     d("fornavn"),
                                     d("etternavn"),
                                     d("post_nr"),
                                     d("telefon"),
                                     d("adresse"),
                                     d("post_sted"),
                                     d("mail"),
                                     d("stilling"),
                                     d("provisjon"))
            Return True
        End If
        Return False
    End Function
End Class
