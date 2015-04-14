Public Class daoInnlevering
    Public Shared sql As String

    Public Shared Function hentTilbehor(ByVal ordre_nr As Integer) As DataTable
        sql = "SELECT utstyr_leid_ut.ordre_nr, " &
              "sykkelutstyr.navn " &
              "FROM utstyr_leid_ut " &
              "JOIN sykkelutstyr ON utstyr_leid_ut.utstyr_id = sykkelutstyr.id " &
              "WHERE utstyr_leid_ut.ordre_nr = " & ordre_nr & ";"

        Return database.dt_query(sql)
    End Function

    Public Shared Function hentLeieAvtaler(ByVal kunde_id As Integer) As DataTable
        sql = "SELECT ordre_nr " &
              "FROM salg_leie " &
              "WHERE salg_leie.person_id_kunde = " & kunde_id & " AND s_l_status = 'Leid ut';"

        Return database.dt_query(sql)
    End Function

    Public Shared Function hentAvtaleInnehold(Optional ByVal id As Integer = Nothing) As DataTable
        If id Then
            sql = "SELECT salg_leie.ordre_nr, salg_leie.frist, " &
                  "sykkel.rammenr, sykkel.hjulstr, sykkel.rammestr, " &
                  "sykkeltype.sykkeltype , person.id " &
                  "FROM salg_leie " &
                  "JOIN sykkel_leid_ut ON salg_leie.ordre_nr = sykkel_leid_ut.ordre_nr " &
                  "JOIN sykkel ON sykkel.rammenr = sykkel_leid_ut.rammenr " &
                  "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                  "JOIN person ON salg_leie.person_id_kunde = person.id " &
                  "WHERE salg_leie.ordre_nr = " & id
        Else
            sql = "SELECT salg_leie.ordre_nr, salg_leie.frist, " &
                  "sykkel.rammenr, sykkel.hjulstr, sykkel.rammestr, " &
                  "sykkeltype.sykkeltype, person.id " &
                  "FROM salg_leie " &
                  "JOIN sykkel_leid_ut ON salg_leie.ordre_nr = sykkel_leid_ut.ordre_nr " &
                  "JOIN sykkel ON sykkel.rammenr = sykkel_leid_ut.rammenr " &
                  "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                  "JOIN person ON salg_leie.person_id_kunde = person.id " &
                  "WHERE s_l_status <> 'Innlevert';"
        End If

        Return database.dt_query(sql)
    End Function

    Public Shared Function hentLeieFrister(ByVal sok As String) As DataTable
        sql = "SELECT salg_leie.ordre_nr, salg_leie.frist, " &
              "sykkel.rammenr, sykkel.hjulstr, sykkel.rammestr, " &
              "sykkeltype.sykkeltype, person.id " &
              "FROM salg_leie " &
              "JOIN sykkel_leid_ut ON salg_leie.ordre_nr = sykkel_leid_ut.ordre_nr " &
              "JOIN sykkel ON sykkel.rammenr = sykkel_leid_ut.rammenr " &
              "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
              "JOIN person ON salg_leie.person_id_kunde = person.id " &
              "WHERE DATE(frist) " & sok & " DATE(NOW()) AND s_l_status = 'Leid ut';"

        Return database.dt_query(sql)
    End Function

    Public Shared Function avsluttLeieAvtale(ByVal ordre_nr As Integer, ByVal lokasjon As Integer) As Boolean
        sql = "START TRANSACTION;" &
              "UPDATE salg_leie SET s_l_status = 'Innlevert' " &
              "WHERE ordre_nr = " & ordre_nr & ";" &
              "UPDATE sykkel_leid_ut SET s_l_u_status = 'Levert' " &
              "WHERE ordre_nr = " & ordre_nr & ";" &
              "UPDATE utstyr_leid_ut SET u_l_u_status = 'Levert' " &
              "WHERE ordre_nr = " & ordre_nr & ";" &
              "UPDATE sykkel " &
              "JOIN sykkel_leid_ut ON sykkel.rammenr = sykkel_leid_ut.rammenr AND sykkel_leid_ut.ordre_nr = " & ordre_nr & " " &
              "SET sykkel.s_status = 'Innlevert', sykkel.posisjon = " & lokasjon & ";" &
              "COMMIT;"

        Return database.query(sql)
    End Function

    Public Shared Function hentAvtaleHistorie(Optional ByVal id As Integer = Nothing) As DataTable
        If id Then
            sql = "SELECT salg_leie.ordre_nr, salg_leie.frist, " &
                  "sykkel.rammenr, sykkel.hjulstr, sykkel.rammestr, " &
                  "sykkeltype.sykkeltype , person.id " &
                  "FROM salg_leie " &
                  "JOIN sykkel_leid_ut ON salg_leie.ordre_nr = sykkel_leid_ut.ordre_nr " &
                  "JOIN sykkel ON sykkel.rammenr = sykkel_leid_ut.rammenr " &
                  "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                  "JOIN person ON salg_leie.person_id_kunde = person.id " &
                  "WHERE person.id = " & id
        Else
            sql = "SELECT salg_leie.ordre_nr, salg_leie.frist, " &
                  "sykkel.rammenr, sykkel.hjulstr, sykkel.rammestr, " &
                  "sykkeltype.sykkeltype, person.id " &
                  "FROM salg_leie " &
                  "JOIN sykkel_leid_ut ON salg_leie.ordre_nr = sykkel_leid_ut.ordre_nr " &
                  "JOIN sykkel ON sykkel.rammenr = sykkel_leid_ut.rammenr " &
                  "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                  "JOIN person ON salg_leie.person_id_kunde = person.id " &
                  "WHERE s_l_status <> 'Innlevert';"
        End If

        Return database.dt_query(sql)
    End Function
End Class
