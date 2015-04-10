Public Class sykkelDAO
    Public Shared payload As DataTable
    Public Shared sql As String

    Public Shared Function leggTilSykkel(ByVal sykkel As sykkel) As Boolean
        sql = "INSERT INTO sykkel VALUES('" & sykkel.pRammenr & "', " & sykkel.pSykkeltype & ", " &
              sykkel.pHjulstr & ", " & sykkel.pRammestr & ", '" & sykkel.pStatus & "', '" &
              sykkel.pAvviksmld & "', " & sykkel.pPosisjon & ", " & sykkel.pVirksomhet & ");"

        Return db.query(sql)
    End Function

    Public Shared Function oppdaterSykkel(ByVal sykkel As sykkel) As Boolean
        sql = "UPDATE sykkel SET rammenr = '" & sykkel.pRammenr & "', sykkeltype = " & sykkel.pSykkeltype &
              ", hjulstr = " & sykkel.pHjulstr & ", rammestr = " & sykkel.pRammestr & ", s_status = '" & sykkel.pStatus &
              "', avviksmelding = '" & sykkel.pAvviksmld & "', posisjon = " & sykkel.pPosisjon &
              ", virksomhet_id = " & sykkel.pVirksomhet & " WHERE rammenr = '" & sykkel.pRammenr & "';"

        Return db.query(sql)
    End Function

    Public Shared Function fjernSykkel(ByVal sykkel As sykkel) As Boolean
        sql = "DELETE FROM sykkel WHERE rammenr = '" & sykkel.pID & "';"

        Return db.query(sql)
    End Function

    Public Shared Function hentSykkler(Optional ByVal sok As String = Nothing, Optional ByVal posisjon As String = Nothing, Optional ByVal status As String = Nothing) As DataTable
        sql = "SELECT sykkel.rammenr, sykkeltype.sykkeltype, s_status, sykkel.hjulstr, sykkel.rammestr, " &
              "sykkel.avviksmelding, v1.navn posisjon, v2.navn " &
              "FROM sykkel " &
              "JOIN sykkeltype ON sykkel.sykkeltype = sykkeltype.id " &
              "JOIN virksomhet v1 ON sykkel.posisjon = v1.id " &
              "JOIN virksomhet v2 ON sykkel.virksomhet_id = v2.id " &
              "AND rammenr LIKE '%" & sok & "%' AND v1.navn LIKE '%" & posisjon & "%' AND s_status LIKE '%" & status & "%';"

        Return db.data_table_query(sql)
    End Function
End Class
