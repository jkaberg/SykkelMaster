Public Class daoDelt
    Public Shared payload As DataTable
    Public Shared sql As String
    ''' <summary>
    ''' SQL som henter ut stillinger fra databasen til comboBox
    ''' </summary>
    ''' <returns>datatable med data</returns>
    Public Shared Function hentStillinger() As DataTable
        Return database.dt_query("SELECT * FROM stilling;")
    End Function
    ''' <summary>
    ''' SQL som henter ut alle virksomheter
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function hentVirksomhet() As DataTable
        Return database.dt_query("SELECT * FROM virksomhet;")
    End Function
    ''' <summary>
    ''' SQL som henter ut alle sykkeltypene i databasen
    ''' </summary>
    ''' <returns>datatable med data</returns>
    Public Shared Function hentSykkelType() As DataTable
        Return database.dt_query("SELECT * FROM sykkeltype;")
    End Function
    ''' <summary>
    ''' SQL som henter ut alle utstyrstypene i databasen 
    ''' </summary>
    ''' <returns>datatable med data</returns>
    Public Shared Function hentUtstyrsType() As DataTable
        Return database.dt_query("SELECT * FROM utstyrstype;")
    End Function
    Public Shared Function finnTlfNummer(ByVal kunde_id As Integer) As String
        payload = database.dt_query("SELECT telefon FROM person WHERE id = " & kunde_id & ";")

        If payload.Rows.Count > 0 Then
            Return payload.Rows(0).Item(0) 'returnerer telefon nummer til Kunde
        Else
            Return vbNullChar
        End If
    End Function

    Public Shared Function finnPostSted(ByVal postnr As String) As String
        payload = database.dt_query("SELECT post_sted FROM sted WHERE sted.post_nr = " & postnr & ";")

        If payload.Rows.Count = 1 Then
            Return payload.Rows(0).Item(0)
        Else
            Return vbNullChar
        End If
    End Function

    Public Shared Function finnKunde(ByVal sok As String) As DataTable
        sql = "SELECT id, fornavn, etternavn, telefon FROM person " &
              "WHERE fornavn LIKE '" & sok & "%' " &
              "OR etternavn LIKE '" & sok & "%' " &
              "OR telefon LIKE '" & sok & "%';"

        Return database.dt_query(sql)
    End Function

    Public Shared Function sjekkMailEksisterer(ByVal epost As String)
        Return database.query("SELECT mail FROM person WHERE mail = '" & epost & "';")
    End Function

    Public Shared Function finnDGWVerdi(ByVal dgw As DataGridView, ByVal kolonne As String) As Object
        If Not IsNothing(dgw.CurrentRow.Index) Then
            Return dgw.Rows(dgw.CurrentRow.Index).Cells(kolonne).Value
        Else
            Return Nothing
        End If

    End Function

    Public Shared Function sjekkRammeNr(ByVal rammenr As String) As Boolean
        Return database.query("SELECT rammenr FROM sykkel WHERE rammenr = '" & rammenr & "';")
    End Function
End Class
