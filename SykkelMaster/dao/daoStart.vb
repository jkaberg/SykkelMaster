﻿Public Class daoStart
    Public Shared sql As String
    Public Shared Function sjekkLogin(ByVal epost As String, ByVal passord As String) As clsAnsatt
        sql = "SELECT " &
              "person.id, person.fornavn, person.etternavn, person.telefon, person.mail, person.adresse, person.post_nr, " &
              "ansatt.provisjon, ansatt.stilling, ansatt.passord, ansatt.virksomhet_id, " &
              "sted.post_sted, " &
              "stilling.tilgangsniva " &
              "FROM person " &
              "JOIN ansatt ON person.mail = '" & epost & "' " &
              "JOIN sted ON sted.post_nr = person.post_nr " &
              "JOIN stilling ON ansatt.stilling = stilling.id " &
              "WHERE ansatt.passord = '" & passord & "';"

        Dim payload As DataTable = database.dt_query(sql)

        If payload.Rows.Count = 1 Then
            Dim d As DataRow = payload.Rows(0)

            Return New clsAnsatt(d("id"),
                                 d("fornavn"),
                                 d("etternavn"),
                                 d("mail"),
                                 d("stilling"),
                                 d("virksomhet_id"),
                                 d("passord"))
        Else
            Throw New Exception("Feil E-post/passord.")
        End If
    End Function

    Public Shared Function oppdaterPassord(ByVal passord As String, ByVal epost As String) As Boolean
        sql = "UPDATE ansatt " &
              "JOIN person ON ansatt.person_id = person.id " &
              "SET ansatt.passord = '" & passord & "' " &
              "WHERE person.mail = '" & epost & "';"

        Return database.query(sql)
    End Function
End Class
