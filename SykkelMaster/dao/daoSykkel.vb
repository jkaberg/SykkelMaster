Public Class daoSykkel
    Public Shared sql As String

    Public Shared Function leggTilSykkel(ByVal sykkel As clsSykkel) As Boolean
        sql = "INSERT INTO sykkel VALUES('" & sykkel.pRammenr & "', " & sykkel.pSykkelType & ", " &
              sykkel.pHjulstr & ", " & sykkel.pRammestr & ", '" & sykkel.pStatus & "', '" & sykkel.pPris & "', '" &
              sykkel.pInnkjopspris & "', '" & sykkel.pAvviksmld & "', " & sykkel.pPosisjon & ", " & sykkel.pVirksomhet & ");"

        Return database.query(sql)
    End Function

    Public Shared Function oppdaterSykkel(ByVal sykkel As clsSykkel) As Boolean
        sql = "UPDATE sykkel SET rammenr = '" & sykkel.pRammenr & "', sykkeltype = " & sykkel.pSykkelType &
              ", hjulstr = " & sykkel.pHjulstr & ", rammestr = " & sykkel.pRammestr & ", s_status = '" & sykkel.pStatus &
              "', pris = " & sykkel.pPris & "', innkjopspris = " & sykkel.pInnkjopspris & ", avviksmelding = '" & sykkel.pAvviksmld & "', posisjon = " & sykkel.pPosisjon &
              ", virksomhet_id = " & sykkel.pVirksomhet & " WHERE rammenr = '" & sykkel.pRammenr & "';"
        Console.WriteLine(sql)

        Return database.query(sql)
    End Function

    Public Shared Function fjernSykkel(ByVal sykkel As clsSykkel) As Boolean
        Return database.query("DELETE FROM sykkel WHERE rammenr = '" & sykkel.pRammenr & "';")
    End Function

    Public Shared Function hentSykkler(Optional ByVal sok As String = Nothing,
                                       Optional ByVal posisjon As String = Nothing,
                                       Optional ByVal status As String = Nothing) As DataTable

        sql = "SELECT sykkel.rammenr, sykkeltype.sykkeltype, s_status, sykkel.pris, sykkel.innkjopspris, sykkel.hjulstr, sykkel.rammestr, " &
              "sykkel.avviksmelding, v1.navn posisjon, v2.navn " &
              "FROM sykkel " &
              "JOIN sykkeltype ON sykkel.sykkeltype = sykkeltype.id " &
              "JOIN virksomhet v1 ON sykkel.posisjon = v1.id " &
              "JOIN virksomhet v2 ON sykkel.virksomhet_id = v2.id " &
              "AND rammenr LIKE '%" & sok & "%' AND v1.navn LIKE '%" & posisjon & "%' AND s_status LIKE '%" & status & "%';"

        Return database.dt_query(sql)
    End Function
End Class
