Public Class daoUtleie
    Private Shared sql As String

    Public Shared Function hentRabattAvtaler() As DataTable
        Return database.dt_query("SELECT id, type_rabatt FROM rabatt")
    End Function

    Public Shared Function hentSykkler() As DataTable
        sql = "SELECT sykkel.rammenr, sykkel.hjulstr, sykkel.sykkeltype, sykkel.rammestr, " &
              "sykkeltype.sykkeltype AS sykkelnavn " &
              "FROM sykkel " &
              "JOIN sykkeltype ON sykkel.sykkeltype = sykkeltype.sykkeltype " &
              "WHERE s_status = 'Tilgjengelig';"

        Return database.dt_query(sql)
    End Function

    Public Shared Function settSykkelStatus(ByVal status As String, ByVal rammenr As String) As DataTable
        database.query("UPDATE sykkel SET s_status = '" & status & "' WHERE rammenr = '" & rammenr & "';")
        Return hentSykkler()
    End Function

    Public Shared Function lagSykklerDataTable() As DataTable
        Dim dt As New DataTable("sykkler")

        Dim rammenr As DataColumn = New DataColumn("rammenr")
        Dim fraTid As DataColumn = New DataColumn("fratid")
        Dim tilTid As DataColumn = New DataColumn("tiltid")
        Dim sykkelNavn As DataColumn = New DataColumn("sykkelnavn")
        Dim sykkelType As DataColumn = New DataColumn("sykkeltype")
        Dim hjulStr As DataColumn = New DataColumn("hjulstr")
        Dim rammeStr As DataColumn = New DataColumn("rammestr")

        rammenr.DataType = System.Type.GetType("System.String")
        tilTid.DataType = System.Type.GetType("System.String")
        fraTid.DataType = System.Type.GetType("System.String")
        sykkelType.DataType = System.Type.GetType("System.Int32")
        rammeStr.DataType = System.Type.GetType("System.Int32")
        hjulStr.DataType = System.Type.GetType("System.Int32")

        dt.Columns.Add(rammenr)
        dt.Columns.Add(fraTid)
        dt.Columns.Add(tilTid)
        dt.Columns.Add(sykkelType)
        dt.Columns.Add(hjulStr)
        dt.Columns.Add(rammeStr)

        Return dt
    End Function

    Public Shared Function leggTilSykkelKundevogn(ByVal dt As DataTable,
                                                  ByVal rammenr As String,
                                                  ByVal fraTid As String,
                                                  ByVal tilTid As String,
                                                  ByVal sykkelType As Integer,
                                                  ByVal hjulStr As Integer,
                                                  ByVal rammeStr As Integer) As DataTable
        Dim sykkel As DataRow

        sykkel = dt.NewRow()
        sykkel.Item("rammenr") = rammenr
        sykkel.Item("fratid") = fraTid
        sykkel.Item("tiltid") = tilTid
        sykkel.Item("sykkeltype") = sykkelType
        sykkel.Item("hjulstr") = hjulStr
        sykkel.Item("rammestr") = rammeStr
        dt.Rows.Add(sykkel)

        Return dt
    End Function

    Public Shared Function fjernSykkelKundevogn(ByVal rad As Integer, ByVal dt As DataTable) As DataTable
        dt.Rows(rad).Delete()
        Return dt
    End Function
End Class
