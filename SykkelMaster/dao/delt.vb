Public Class delt
    Public Shared Function hentStillinger() As DataTable
        Return db.data_table_query("SELECT * FROM stilling")
    End Function

    Public Shared Function hentVirksomhet() As DataTable
        Return db.data_table_query("SELECT * FROM virksomhet")
    End Function

    Public Shared Function hentSykkeltype() As DataTable
        Return db.data_table_query("SELECT * FROM sykkeltype")
    End Function
End Class
