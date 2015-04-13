Public Class daoUtleie
    Private Shared sql As String

    Public Shared Function hentRabattAvtaler() As DataTable
        Return database.dt_query("SELECT id, type_rabatt FROM rabatt")
    End Function

    Public Shared Function hentSykkler() As DataTable
        Return database.dt_query("SELECT rammenr, sykkeltype, hjulstr, rammestr FROM sykkel WHERE s_status <> 'Leid ut';")
    End Function
End Class
