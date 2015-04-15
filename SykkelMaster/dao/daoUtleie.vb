Public Class daoUtleie
    Private Shared sql As String

    Public Shared Function hentRabattAvtaler() As DataTable
        Return database.dt_query("SELECT id, type_rabatt FROM rabatt")
    End Function

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

    Public Shared Function lagSykklerDataTable() As DataTable
        Dim dt As New DataTable("sykkler")

        Dim rammenr As New DataColumn("rammenr")
        Dim fraTid As New DataColumn("fratid")
        Dim tilTid As New DataColumn("tiltid")
        Dim sykkelNavn As New DataColumn("sykkelnavn")
        Dim sykkelType As New DataColumn("sykkeltype")
        Dim hjulStr As New DataColumn("hjulstr")
        Dim rammeStr As New DataColumn("rammestr")

        rammenr.DataType = System.Type.GetType("System.String")
        tilTid.DataType = System.Type.GetType("System.String")
        fraTid.DataType = System.Type.GetType("System.String")
        sykkelNavn.DataType = System.Type.GetType("System.String")
        sykkelType.DataType = System.Type.GetType("System.Int32")
        rammeStr.DataType = System.Type.GetType("System.Int32")
        hjulStr.DataType = System.Type.GetType("System.Int32")

        dt.Columns.Add(rammenr)
        dt.Columns.Add(fraTid)
        dt.Columns.Add(tilTid)
        dt.Columns.Add(sykkelNavn)
        dt.Columns.Add(sykkelType)
        dt.Columns.Add(hjulStr)
        dt.Columns.Add(rammeStr)

        Return dt
    End Function

    Public Shared Function leggTilSykkelKundevogn(ByVal dt As DataTable,
                                                  ByVal rammenr As String,
                                                  ByVal fraTid As String,
                                                  ByVal tilTid As String,
                                                  ByVal sykkelNavn As String,
                                                  ByVal sykkelType As Integer,
                                                  ByVal hjulStr As Integer,
                                                  ByVal rammeStr As Integer) As DataTable
        Dim sykkel As DataRow = dt.NewRow()

        sykkel.Item("rammenr") = rammenr
        sykkel.Item("fratid") = fraTid
        sykkel.Item("tiltid") = tilTid
        sykkel.Item("sykkelnavn") = sykkelNavn
        sykkel.Item("sykkeltype") = sykkelType
        sykkel.Item("hjulstr") = hjulStr
        sykkel.Item("rammestr") = rammeStr
        dt.Rows.Add(sykkel)

        Return dt
    End Function

    Public Shared Function fjernSykkelKundevogn(ByVal rammenr As String,
                                                ByVal dt As DataTable) As DataTable

        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item(0).ToString() = rammenr Then
                dt.Rows(i).Delete()
            End If
        Next

        Return dt
    End Function
End Class
