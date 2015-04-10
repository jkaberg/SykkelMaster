Public Class endrePassordDAO
    Public Shared sql As String

    Public Shared Function endrePassord(ByVal passord As String, ByVal epost As String) As Boolean
        sql = "UPDATE ansatt " &
              "JOIN person ON ansatt.person_id = person.id " &
              "SET ansatt.passord = '" & passord & "' " &
              "WHERE person.mail = '" & epost & "'"

        Return database.query(sql)
    End Function
    Public Shared Function sjekkPassord(ByVal passord As String, ByVal epost As String) As Boolean
        sql = "SELECT person.mail, ansatt.passord " &
              "FROM ansatt " &
              "JOIN person ON ansatt.person_id = person.id " &
              "WHERE mail = '" & epost & "' " &
              "AND passord = '" & passord & "'"

        Return database.query(sql)
    End Function
End Class
