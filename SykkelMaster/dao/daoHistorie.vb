Public Class daoHistorie
    Public Shared sql As String
 
    Public Shared Function hentAvtaleHistorie(Optional ByVal id As Integer = Nothing, Optional ByVal sok As String = Nothing) As DataTable
        sql = "SELECT salg_leie.ordre_nr, salg_leie.frist, " &
              "sykkel.rammenr, sykkel.hjulstr, sykkel.rammestr, " &
              "sykkeltype.sykkeltype , person.id, salg_leie.s_l_status " &
              "FROM salg_leie " &
              "JOIN sykkel_leid_ut ON salg_leie.ordre_nr = sykkel_leid_ut.ordre_nr " &
              "JOIN sykkel ON sykkel.rammenr = sykkel_leid_ut.rammenr " &
              "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
              "JOIN person ON salg_leie.person_id_kunde = person.id " &
              "WHERE person.id = " & id

        Return database.dt_query(sql)
    End Function
End Class
