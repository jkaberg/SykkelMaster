Public Class daoUtleieOversikt
    Public Shared sql As String
    Public Shared Sub leggTilOrdre(ByVal ordre As clsUtleie)
        Dim payload As DataTable
        Dim ordre_nr As Integer
        sql = "START TRANSACTION;" &
              "INSERT INTO salg_leie (dato, frist, sum, s_l_status, person_id_kunde, person_id_selger, rabatt_id) " &
              "VALUES ('" & Format(ordre.pFra, "yyyy-MM-dd HH:mm:ss") & "', '" & Format(ordre.pTil, "yyyy-MM-dd HH:mm:ss") & "', '" & ordre.pTotalPris & "', 'Leid ut', '" & ordre.pKunde.pID & "', " & ordre.pSelger & ", " & ordre.pRabatt & ");" &
              "SELECT LAST_INSERT_ID();" &
              "COMMIT;"

        payload = database.dt_query(sql)

        ordre_nr = payload.Rows(0).Item(0)

        If Not ordre.pSykler.Rows.Count = 0 Then
            For Each rad As DataRow In ordre.pSykler.Rows
                settSykelStatus(rad.Item("rammenr"), ordre_nr)
            Next
        End If
        If Not ordre.pUtstyr.Rows.Count = 0 Then
            For Each rad As DataRow In ordre.pUtstyr.Rows
                settUtstyrStatus(rad.Item("id"), ordre_nr)
            Next
        End If
    End Sub

    Private Shared Sub settSykelStatus(ByVal rammenr As String, ByVal ordre_nr As Integer)
        sql = "START TRANSACTION;" &
              "INSERT INTO sykkel_leid_ut (ordre_nr, rammenr) " &
              "VALUES (" & ordre_nr & ", '" & rammenr & "');" &
              "UPDATE sykkel SET s_status = 'Leid ut' WHERE rammenr = '" & rammenr & "';" &
              "COMMIT;"

        database.query(sql)
    End Sub
    Private Shared Sub settUtstyrStatus(ByVal id As Integer, ByVal ordre_nr As Integer)
        sql = "START TRANSACTION;" &
              "INSERT INTO utstyr_leid_ut (ordre_nr, utstyr_id) " &
              "VALUES (" & ordre_nr & ", " & id & ");" &
              "UPDATE sykkelutstyr SET s_u_status = 'Leid ut' WHERE id = " & id & ";" &
              "COMMIT;"

        database.query(sql)
    End Sub
End Class
