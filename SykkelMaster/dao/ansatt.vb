Public Class ansattDAO
    Public Shared payload As DataTable
    Public Shared sql As String

    Public Shared Sub leggTilAnsatt(ByVal ansatt As ansatt)
        sql = "START TRANSACTION;" &
              "INSERT INTO person (fornavn, etternavn, telefon, mail, adresse, post_nr) " &
              "VALUES ('" & ansatt.pFnavn & "', '" & ansatt.pFnavn & "', " & ansatt.pTlfnr & ", '" & ansatt.pEpost & "', '" & ansatt.pGate & "', " & ansatt.pPostnr & ");" &
              "INSERT INTO ansatt (person_id, stilling, provisjon, passord, virksomhet_id) " &
              "VALUES (LAST_INSERT_ID(), " & ansatt.pStilling & ", " & ansatt.pProvisjon & ", '" & ansatt.pPassord & "', " & ansatt.pArbeidssted & ");" &
              "COMMIT;"

        db.query(sql)
    End Sub

    Public Shared Sub oppdaterAnsatt(ByVal ansatt As ansatt)
        sql = "START TRANSACTION;" &
              "UPDATE person SET fornavn = '" & ansatt.pFnavn & "', etternavn = '" & ansatt.pEnavn & "', telefon = " & ansatt.pTlfnr & ", mail = '" & ansatt.pEpost & "', adresse = '" & ansatt.pGate & "', post_nr = " & ansatt.pGate & " " &
              "WHERE id = " & ansatt.pID & ";" &
              "UPDATE ansatt SET stilling = " & ansatt.pStilling & ", provisjon = " & ansatt.pProvisjon & ", virksomhet_id = " & ansatt.pArbeidssted & " " &
              "WHERE person_id = " & ansatt.pID & ";" &
              "COMMIT;"

        db.query(sql)
    End Sub

    Public Shared Sub fjernAnsatt(ByVal ansatt As ansatt)
        sql = "DELETE FROM ansatt WHERE ansatt.person_id = " & ansatt.pID

        db.query(sql)
    End Sub

    Public Shared Function hentStillinger() As DataTable
        Return db.query("SELECT * FROM stilling")
    End Function

    Public Shared Function hentAnsatte() As DataTable
        sql = "SELECT " &
              "person.id, person.fornavn, person.etternavn, person.telefon, person.mail, person.adresse, person.post_nr, " &
              "ansatt.provisjon, " &
              "sted.post_sted, " &
              "stilling.stilling, " &
              "virksomhet.navn " &
              "FROM person " &
              "JOIN ansatt ON person.id = ansatt.person_id " &
              "JOIN sted ON sted.post_nr = person.post_nr " &
              "JOIN stilling ON ansatt.stilling = stilling.id " &
              "JOIN virksomhet ON virksomhet.id = ansatt.virksomhet_id;"

        Return db.query(sql)
    End Function

End Class
