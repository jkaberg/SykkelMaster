Public Class daoUtleie
    Private Shared sql As String

    Public Shared Function hentRabattAvtaler() As DataTable
        Return database.dt_query("SELECT id, type_rabatt FROM rabatt")
    End Function
#Region "sykkel"
    Public Shared Function hentSykkler() As DataTable
        sql = "SELECT sykkel.rammenr, sykkel.hjulstr, sykkel.sykkeltype, sykkel.rammestr, " &
              "sykkeltype.sykkeltype sykkelnavn " &
              "FROM sykkel " &
              "JOIN sykkeltype ON sykkel.sykkeltype = sykkeltype.id " &
              "WHERE sykkel.s_status = 'Tilgjengelig';"

        Return database.dt_query(sql)
    End Function

    Public Shared Function settSykkelStatus(ByVal status As String,
                                            ByVal rammenr As String) As DataTable

        database.query("UPDATE sykkel SET s_status = '" & status & "' WHERE rammenr = '" & rammenr & "';")
        Return hentSykkler()
    End Function
    Public Shared Function leggTilSykkelKundevogn(ByVal dt As DataTable,
                                                  ByVal rammenr As String,
                                                  ByVal sykkelNavn As String,
                                                  ByVal sykkelType As Integer,
                                                  ByVal hjulStr As Integer,
                                                  ByVal rammeStr As Integer) As DataTable
        Dim sykkel As DataRow = dt.NewRow()

        sykkel.Item("rammenr") = rammenr
        sykkel.Item("sykkelnavn") = sykkelNavn
        sykkel.Item("sykkeltype") = sykkelType
        sykkel.Item("hjulstr") = hjulStr
        sykkel.Item("rammestr") = rammeStr
        dt.Rows.Add(sykkel)

        Return dt
    End Function
    Public Shared Function lagSykklerDataTable() As DataTable
        Dim dt As New DataTable("sykkler")

        Dim rammenr As New DataColumn("rammenr")
        Dim sykkelNavn As New DataColumn("sykkelnavn")
        Dim sykkelType As New DataColumn("sykkeltype")
        Dim hjulStr As New DataColumn("hjulstr")
        Dim rammeStr As New DataColumn("rammestr")

        rammenr.DataType = System.Type.GetType("System.String")
        sykkelNavn.DataType = System.Type.GetType("System.String")
        sykkelType.DataType = System.Type.GetType("System.Int32")
        rammeStr.DataType = System.Type.GetType("System.Int32")
        hjulStr.DataType = System.Type.GetType("System.Int32")

        dt.Columns.Add(rammenr)
        dt.Columns.Add(sykkelNavn)
        dt.Columns.Add(sykkelType)
        dt.Columns.Add(hjulStr)
        dt.Columns.Add(rammeStr)

        Return dt
    End Function
    Public Shared Function fjernSykkelKundevogn(ByVal id As Integer, ByVal dt As DataTable) As DataTable
        dt.Rows(id).Delete()

        Return dt
    End Function
#End Region
#Region "utstyr"
    Public Shared Function hentUtstyr() As DataTable
        Return database.dt_query("SELECT sykkelutstyr.id, sykkelutstyr.navn FROM sykkelutstyr")
    End Function
    Public Shared Function leggTilUtstyrKundevogn(ByVal dt As DataTable,
                                                  ByVal id As Integer,
                                                  ByVal navn As String)

        Dim utstyr As DataRow = dt.NewRow()

        utstyr.Item("id") = id
        utstyr.Item("navn") = navn
        dt.Rows.Add(utstyr)

        Return dt
    End Function
    Public Shared Function lagUtstyrDataTable() As DataTable
        Dim dt As New DataTable("utstyr")

        Dim id As New DataColumn("id")
        Dim navn As New DataColumn("navn")

        id.DataType = System.Type.GetType("System.Int32")
        navn.DataType = System.Type.GetType("System.String")

        dt.Columns.Add(id)
        dt.Columns.Add(navn)

        Return dt
    End Function

#End Region
End Class
