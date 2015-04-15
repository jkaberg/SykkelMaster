Public Class daoUtleie
    Private Shared sql As String

    Public Shared Function hentRabattAvtaler() As DataTable
        Return database.dt_query("SELECT id, type_rabatt FROM rabatt")
    End Function

    Public Shared Function hentSykkler() As DataTable
        Return database.dt_query("SELECT rammenr, sykkeltype, hjulstr, rammestr FROM sykkel WHERE s_status = 'Tilgjengelig';")
    End Function

    Public Shared Function lagSykklerDataTable() As DataTable
        Dim dt As New DataTable("sykkler")

        Dim fraTid As DataColumn = New DataColumn("fratid")
        Dim tilTid As DataColumn = New DataColumn("tiltid")
        Dim sykkelType As DataColumn = New DataColumn("sykkeltype")
        Dim hjulStr As DataColumn = New DataColumn("hjulstr")
        Dim rammeStr As DataColumn = New DataColumn("rammestr")

        tilTid.DataType = System.Type.GetType("System.String")
        fraTid.DataType = System.Type.GetType("System.String")
        sykkelType.DataType = System.Type.GetType("System.Int32")
        rammeStr.DataType = System.Type.GetType("System.Int32")
        hjulStr.DataType = System.Type.GetType("System.Int32")

        dt.Columns.Add(fraTid)
        dt.Columns.Add(tilTid)
        dt.Columns.Add(sykkelType)
        dt.Columns.Add(hjulStr)
        dt.Columns.Add(rammeStr)

        Return dt
    End Function

    Public Shared Function leggTilSykkelKundevogn(ByVal dt As DataTable,
                                                  ByVal fraTid As String,
                                                  ByVal tilTid As String,
                                                  ByVal sykkelType As Integer,
                                                  ByVal hjulStr As Integer,
                                                  ByVal rammeStr As Integer)
        Dim sykkel As DataRow

        sykkel = dt.NewRow()
        sykkel.Item("fratid") = fraTid
        sykkel.Item("tiltid") = tilTid
        sykkel.Item("sykkeltype") = sykkelType
        sykkel.Item("hjulstr") = hjulStr
        sykkel.Item("rammestr") = rammeStr
        dt.Rows.Add(sykkel)

        Return dt
    End Function
End Class
