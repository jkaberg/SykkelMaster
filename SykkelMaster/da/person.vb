Public Class personDAO
    Public Shared sql As String

    Public Shared Function leggTilPerson(ByVal person As person) As Boolean
        sql = "INSERT INTO person (fornavn, etternavn, telefon, mail, adresse, post_nr) VALUES('" &
              person.pFnavn & "', '" & person.pEnavn & "', " & person.pTlfnr & ", '" & person.pEpost & "', '" & person.pGate & "', " & person.pPostnr & ");"

        Return database.query(sql)
    End Function

    Public Shared Function fjernPerson(ByVal id As Integer) As Boolean
        Return database.query("DELETE FROM sykkelmaster2015.person WHERE person.id = " & id & ";")
    End Function

    Public Shared Function oppdaterPerson(ByVal person As person) As Boolean
        sql = "UPDATE person SET " &
              "fornavn = '" & person.pFnavn & "', " &
              "etternavn = '" & person.pEnavn & "', " &
              "telefon = " & person.pTlfnr & ", " &
              "mail = '" & person.pEpost & "', " &
              "post_nr = " & person.pPostnr & " " &
              "WHERE id = " & person.pID & ";"

        Return database.query(sql)
    End Function

    Public Shared Function hentPersoner(Optional ByVal sok As String = Nothing, Optional ByVal id As Integer = Nothing) As DataTable
        If Not id = Nothing Then
            sql = "SELECT * FROM person WHERE id = " & id & ";"
        ElseIf sok = Nothing Then
            sql = "SELECT * FROM person"
        Else
            sql = "SELECT * FROM person WHERE fornavn LIKE '%" & sok & "%' OR telefon LIKE '%" & sok & "%' OR etternavn LIKE '%" & sok & "%';"
        End If

        Return database.dt_query(sql)
    End Function
End Class
