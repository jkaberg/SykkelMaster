Public Class personDAO
    Public Shared payload As DataTable
    Public Shared sql As String

    Public Shared Sub leggTilPerson(ByVal person As person)
        sql = "INSERT INTO person (fornavn, etternavn, telefon, mail, adresse, post_nr) VALUES('" &
              person.pFnavn & "', '" & person.pEnavn & "', " & person.pTlfnr & ", '" & person.pEpost & "', '" & person.pGate & "', " & person.pPostnr & ");"

        db.query(sql)
    End Sub

    Public Shared Function fjernPerson(ByVal id As Integer) As Boolean
        sql = "DELETE FROM sykkelmaster2015.person WHERE person.id = " & id & ";"

        db.query(sql)
        Return True
    End Function

    Public Shared Sub oppdaterPerson(ByVal person As person)
        sql = "UPDATE person SET " &
              "fornavn = '" & person.pFnavn & "', " &
              "etternavn = '" & person.pEnavn & "', " &
              "telefon = " & person.pTlfnr & ", " &
              "mail = '" & person.pEpost & "', " &
              "post_nr = " & person.pPostnr & " " &
              "WHERE id = " & person.pID & ";"

        db.query(sql)
    End Sub

    Public Shared Function hentPersoner(Optional ByVal sok As String = Nothing, Optional ByVal id As Integer = Nothing) As DataTable
        If Not id = Nothing Then
            sql = "SELECT * FROM person WHERE id = " & id & ";"
        ElseIf sok = Nothing Then
            sql = "SELECT * FROM person"
        Else
            sql = "SELECT * FROM person WHERE fornavn LIKE '%" & sok & "%' OR telefon LIKE '%" & sok & "%' OR etternavn LIKE '%" & sok & "%';"
        End If

        Return db.query(sql)
    End Function
End Class
