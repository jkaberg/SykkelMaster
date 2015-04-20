Public Class daoStatistikk
    Public Shared sql As String

    Public Shared Function hentStats(ByVal index As Integer) As DataTable
        Select Case index
            Case 0 ' Antall sykkler per sykkeltype
                sql = "SELECT sykkeltype.sykkeltype AS navn, count(*) AS num " &
                      "FROM sykkel " &
                      "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                      "GROUP BY sykkeltype.sykkeltype;"
            Case 1 ' Mest populære sykklene
                sql = "SELECT sykkeltype.sykkeltype as navn, count(*) as num " &
                      "FROM sykkel " &
                      "JOIN sykkel_leid_ut ON sykkel_leid_ut.rammenr = sykkel.rammenr " &
                      "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                      "GROUP BY sykkeltype.sykkeltype;"
            Case 2 ' Hvor mange sykkler per "lagerplass"
                sql = "SELECT virksomhet.navn as navn, count(*) as num " &
                      "FROM sykkel " &
                      "JOIN virksomhet ON virksomhet.id = sykkel.posisjon " &
                      "GROUP BY virksomhet.navn;"
            Case 3 ' Hvilke type sykkler er ødelagd
                sql = "SELECT sykkeltype.sykkeltype as navn, count(*) as num " &
                      "FROM sykkel " &
                      "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                      "WHERE sykkel.s_status = 'Reparasjon' " &
                      "GROUP BY sykkeltype.sykkeltype;"
            Case 4 ' Hvor stort er overskuddet
                sql = "SELECT okonomi.tall as num,inntektstype as navn " &
                    "FROM okonomi;"
        End Select

        Return database.dt_query(sql)
    End Function
End Class
