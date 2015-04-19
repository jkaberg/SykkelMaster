Public Class daoUtleieOversikt
    Public Shared sql As String
    Public Shared Function hentPerson(ByVal id As Integer) As person
        Dim 
        sql = "SELECT " &
        "person.id, person.fornavn, person.etternavn, person.telefon, person.mail, person.adresse, person.post_nr, " &
        "sted.post_sted, " &
        "stilling.tilgangsniva " &
        "FROM person " &
        "JOIN sted ON sted.post_nr = person.post_nr " &
        "JOIN stilling ON ansatt.stilling = stilling.id " &
        "WHERE person.id = '" & id & "';"

        Return
    End Function
End Class
