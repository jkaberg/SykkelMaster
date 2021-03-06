﻿Public Class daoAnsatt
    Public Shared sql As String
    ''' <summary>
    ''' SQL setning som legger til ny ansatt i databasen
    ''' </summary>
    ''' <param name="ansatt">objektet clsAnsatt</param>
    ''' <returns>retunerer boolean verdi</returns>
    Public Shared Function leggTilAnsatt(ByVal ansatt As clsAnsatt) As Boolean
        sql = "START TRANSACTION;" &
              "INSERT INTO person (fornavn, etternavn, telefon, mail, adresse, post_nr) " &
              "VALUES ('" & ansatt.pFnavn & "', '" & ansatt.pEnavn & "', " & ansatt.pTlfnr & ", '" & ansatt.pEpost & "', '" & ansatt.pAdresse & "', " & ansatt.pPostnr & ");" &
              "INSERT INTO ansatt (person_id, stilling, provisjon, passord, virksomhet_id) " &
              "VALUES (LAST_INSERT_ID(), " & ansatt.pStilling & ", " & ansatt.pProvisjon & ", '" & ansatt.pPassord & "', " & ansatt.pArbeidssted & ");" &
              "COMMIT;"

        Return database.query(sql)
    End Function
    ''' <summary>
    ''' SQL setning som legger oppdatere ansatt i databasen
    ''' </summary>
    ''' <param name="ansatt">objektet clsAnsatt</param>
    ''' <returns>retunerer boolean verdi</returns>
    Public Shared Function oppdaterAnsatt(ByVal ansatt As clsAnsatt) As Boolean
        sql = "START TRANSACTION;" &
              "UPDATE person SET fornavn = '" & ansatt.pFnavn & "', etternavn = '" & ansatt.pEnavn & "', telefon = " & ansatt.pTlfnr & ", mail = '" & ansatt.pEpost & "', adresse = '" & ansatt.pAdresse & "', post_nr = " & ansatt.pPostnr & " " &
              "WHERE id = " & ansatt.pID & ";" &
              "UPDATE ansatt SET stilling = " & ansatt.pStilling & ", provisjon = " & ansatt.pProvisjon & ", virksomhet_id = " & ansatt.pArbeidssted & " " &
              "WHERE person_id = " & ansatt.pID & ";" &
              "COMMIT;"

        Return database.query(sql)
    End Function
    ''' <summary>
    ''' SQL setning som fjerner ansatt i databasen
    ''' </summary>
    ''' <param name="ansatt">objektet clsAnsatt</param>
    ''' <returns>retunerer boolean verdi</returns>
    Public Shared Function fjernAnsatt(ByVal ansatt As clsAnsatt) As Boolean
        Return database.query("DELETE FROM ansatt WHERE ansatt.person_id = " & ansatt.pID & ";")
    End Function
    ''' <summary>
    ''' SQL setning som henter ut samtlige ansatte i databaen
    ''' </summary>
    ''' <returns>retunerer datatable med data</returns>
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

        Return database.dt_query(sql)
    End Function

End Class
