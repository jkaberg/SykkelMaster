Public Class daoUtleie
    Private Shared sql As String

    Public Shared Function hentRabattAvtaler() As DataTable
        Return database.dt_query("SELECT type_rabatt, prosent FROM rabatt")
    End Function
    Public Shared Function fjernFraKundevogn(ByVal id As Integer, ByVal dt As DataTable) As DataTable
        dt.Rows(id).Delete()

        Return dt
    End Function
    Public Shared Function hentPerson(ByVal id As Integer) As clsPerson
        sql = "SELECT " &
              "person.id, person.fornavn, person.etternavn, person.telefon, person.mail, person.adresse, person.post_nr, " &
              "sted.post_sted " &
              "FROM person " &
              "JOIN sted ON person.post_nr = sted.post_nr " &
              "WHERE person.id = '" & id & "';"

        Dim payload As DataTable = database.dt_query(sql)

        If payload.Rows.Count = 1 Then
            Dim d As DataRow = payload.Rows(0)

            Return New clsPerson(d("id"),
                                 d("fornavn"),
                                 d("etternavn"),
                                 d("post_nr"),
                                 d("telefon"),
                                 d("adresse"),
                                 d("mail"),
                                 d("post_sted"))
        Else
            Throw New Exception("Denne personen eksisterer ikke i databasen.")
        End If
    End Function

#Region "sykkel"
    Public Shared Function hentSykkler() As DataTable
        sql = "SELECT sykkel.rammenr, sykkel.hjulstr, sykkel.sykkeltype, sykkel.rammestr, sykkel.innkjopspris, " &
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
                                                  ByVal rammeStr As Integer,
                                                  ByVal innkjopspris As Integer) As DataTable
        Dim sykkel As DataRow = dt.NewRow()

        sykkel.Item("rammenr") = rammenr
        sykkel.Item("sykkelnavn") = sykkelNavn
        sykkel.Item("sykkeltype") = sykkelType
        sykkel.Item("hjulstr") = hjulStr
        sykkel.Item("rammestr") = rammeStr
        sykkel.Item("innkjopspris") = innkjopspris
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
        Dim innkjopspris As New DataColumn("innkjopspris")

        rammenr.DataType = System.Type.GetType("System.String")
        sykkelNavn.DataType = System.Type.GetType("System.String")
        sykkelType.DataType = System.Type.GetType("System.Int32")
        rammeStr.DataType = System.Type.GetType("System.Int32")
        hjulStr.DataType = System.Type.GetType("System.Int32")
        innkjopspris.DataType = System.Type.GetType("System.Int32")

        dt.Columns.Add(rammenr)
        dt.Columns.Add(sykkelNavn)
        dt.Columns.Add(sykkelType)
        dt.Columns.Add(hjulStr)
        dt.Columns.Add(rammeStr)
        dt.Columns.Add(innkjopspris)

        Return dt
    End Function

#End Region
#Region "utstyr"
    Public Shared Function hentUtstyr() As DataTable
        sql = "SELECT sykkelutstyr.id, sykkelutstyr.innkjopspris, sykkelutstyr.storrelse, utstyrstype.utstyrstype navn " &
              "FROM sykkelutstyr " &
              "JOIN utstyrstype ON utstyrstype.id = sykkelutstyr.utstyrstype " &
              "WHERE sykkelutstyr.s_u_status = 'Tilgjengelig';"

        Return database.dt_query(sql)
    End Function
    Public Shared Function settUtstyrStatus(ByVal status As String,
                                            ByVal id As Integer) As DataTable

        database.query("UPDATE sykkelutstyr SET s_u_status = '" & status & "' WHERE id = '" & id & "';")
        Return hentUtstyr()
    End Function
    Public Shared Function leggTilUtstyrKundevogn(ByVal dt As DataTable,
                                                  ByVal id As Integer,
                                                  ByVal navn As String,
                                                  ByVal innkjopspris As Integer,
                                                  ByVal storrelse As String)

        Dim utstyr As DataRow = dt.NewRow()

        utstyr.Item("id") = id
        utstyr.Item("navn") = navn
        utstyr.Item("innkjopspris") = innkjopspris
        utstyr.Item("storrelse") = storrelse
        dt.Rows.Add(utstyr)

        Return dt
    End Function
    Public Shared Function lagUtstyrDataTable() As DataTable
        Dim dt As New DataTable("utstyr")

        Dim id As New DataColumn("id")
        Dim navn As New DataColumn("navn")
        Dim innkjopspris As New DataColumn("innkjopspris")
        Dim storrelse As New DataColumn("storrelse")

        id.DataType = System.Type.GetType("System.Int32")
        navn.DataType = System.Type.GetType("System.String")
        innkjopspris.DataType = System.Type.GetType("System.Int32")
        storrelse.DataType = System.Type.GetType("System.String")

        dt.Columns.Add(id)
        dt.Columns.Add(navn)
        dt.Columns.Add(innkjopspris)
        dt.Columns.Add(storrelse)

        Return dt
    End Function

#End Region
End Class
