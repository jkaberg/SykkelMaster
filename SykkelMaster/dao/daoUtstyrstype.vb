Public Class daoUtstyrstype
    Public Shared sql As String

    Public Shared Function leggTilUtstyrstype(ByVal st As clsSykkelUtstyrType) As Boolean
        Return database.query("INSERT INTO utstyrstype (utstyrstype) VALUES('" & st.pNavn & "');")
    End Function

    Public Shared Function oppdaterUtstyrstype(ByVal st As clsSykkelUtstyrType) As Boolean
        Return database.query("UPDATE utstyrstype SET utstyrstype = '" & st.pNavn & "' WHERE id = " & st.pID & ";")
    End Function

    Public Shared Function fjernUtstyrstype(ByVal st As clsSykkelUtstyrType) As Boolean
        Return database.query("DELETE FROM utstyrstype WHERE id = " & st.pID & ";")
    End Function
End Class
