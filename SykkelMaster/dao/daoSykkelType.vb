Public Class daoSykkelType
    Public Shared sql As String

    Public Shared Function leggTilSykkelType(ByVal st As clsSykkelUtstyrType) As Boolean
        Return database.query("INSERT INTO sykkeltype (sykkeltype) VALUES('" & st.pNavn & "');")
    End Function

    Public Shared Function oppdaterSykkelType(ByVal st As clsSykkelUtstyrType) As Boolean
        Return database.query("UPDATE sykkeltype SET sykkeltype = '" & st.pNavn & "' WHERE id = " & st.pID & ";")
    End Function

    Public Shared Function fjernSykkelType(ByVal st As clsSykkelUtstyrType) As Boolean
        Return database.query("DELETE FROM sykkeltype WHERE id = " & st.pID & ";")
    End Function
End Class
