Public Class daoPerson
    Public Shared sql As String
    ''' <summary>
    ''' SQL setning legger til ny person i databasen
    ''' </summary>
    ''' <param name="person">objektet clsPerson</param>
    ''' <returns>retunerer boolean verdi</returns>
    Public Shared Function leggTilPerson(ByVal person As clsPerson) As Boolean
        sql = "INSERT INTO person (fornavn, etternavn, telefon, mail, adresse, post_nr) VALUES('" &
              person.pFnavn & "', '" & person.pEnavn & "', " & person.pTlfnr & ", '" & person.pEpost & "', '" & person.pAdresse & "', " & person.pPostnr & ");"

        Return database.query(sql)
    End Function
    ''' <summary>
    ''' SQL setning fjerner en person i databasen
    ''' </summary>
    ''' <param name="person">objektet clsPerson</param>
    ''' <returns>returnerer boolean verdi</returns>
    Public Shared Function fjernPerson(ByVal person As clsPerson) As Boolean
        Dim navn As String = person.pFnavn & " " & person.pEnavn
        If database.query("SELECT person_id FROM ansatt WHERE person_id = " & person.pID & ";") Then ' kan ikke fjern fra kunde før man fjernet i ansatt/brukere
            Throw New Exception("Du må slett " & navn & " fra ansatt først.")
        Else
            Return database.query("DELETE FROM person WHERE person.id = " & person.pID & ";")
        End If
    End Function
    ''' <summary>
    ''' SQL setning oppdaterer en oerson i databasen
    ''' </summary>
    ''' <param name="person">objektet clsPerson</param>
    ''' <returns>returnerer boolean verdi</returns>
    Public Shared Function oppdaterPerson(ByVal person As clsPerson) As Boolean
        sql = "UPDATE person SET " &
              "fornavn = '" & person.pFnavn & "', " &
              "etternavn = '" & person.pEnavn & "', " &
              "telefon = " & person.pTlfnr & ", " &
              "mail = '" & person.pEpost & "', " &
              "adresse = '" & person.pAdresse & "', " &
              "post_nr = " & person.pPostnr & " " &
              "WHERE id = " & person.pID & ";"

        Return database.query(sql)
    End Function
    ''' <summary>
    ''' SQL setning som henter ut samtlige personer i databasen
    ''' </summary>
    ''' <param name="sok"></param>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function hentPersoner(Optional ByVal sok As String = Nothing, Optional ByVal id As Integer = Nothing) As DataTable
        If Not id = Nothing Then
            sql = "SELECT * FROM person WHERE id = " & id & ";"
        ElseIf sok = Nothing Then
            sql = "SELECT * FROM person"
        Else
            sql = "SELECT * FROM person " &
                  "WHERE fornavn LIKE '%" & sok & "%'" &
                  "OR telefon LIKE '%" & sok & "%'" &
                  "OR etternavn LIKE '%" & sok & "%';"
        End If

        Return database.dt_query(sql)
    End Function
End Class
