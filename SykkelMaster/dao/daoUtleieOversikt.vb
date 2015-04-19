Public Class daoUtleieOversikt
    Public Shared sql As String
    Public Shared Function hentPerson(ByVal id As Integer) As clsPerson
        sql = "SELECT " &
              "person.id, person.fornavn, person.etternavn, person.telefon, person.mail, person.adresse, person.post_nr, " &
              "sted.post_sted " &
              "FROM person " &
              "JOIN sted ON person.post_nr = sted.post_nr " &
              "WHERE person.id = '" & id & "';"

        Dim payload As DataTable = database.dt_query(sql)

        If payload.Rows.Count = 1 Then
            Dim d As DataRow = payload.Rows(0)

            Return New clsPerson(d("id"),
                                 d("fornavn"),
                                 d("etternavn"),
                                 d("post_nr"),
                                 d("telefon"),
                                 d("adresse"),
                                 d("mail"),
                                 d("post_sted"))
        Else
            Throw New Exception("Denne personen eksisterer ikke i databasen.")
        End If
    End Function
End Class
