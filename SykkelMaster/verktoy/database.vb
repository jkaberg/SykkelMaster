Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class database
    Public Shared conn As New MySqlConnection
    Public Shared config As String = ConfigurationManager.ConnectionStrings("mysql").ConnectionString

    Public Shared Function dt_query(ByVal sql As String) As DataTable
        Dim data As New DataTable
        conn.ConnectionString = config
        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = New MySqlCommand(sql, conn)
            adapter.Fill(data)
            conn.Close()
        Catch ex As Exception
            MsgBox("Database feil: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Dispose()
        End Try
        Return data
    End Function

    Public Shared Function query(ByVal sql As String) As Boolean
        conn.ConnectionString = config
        Dim status As Object = Nothing
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            'status = cmd.ExecuteNonQuery()
            status = cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox("Database feil: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Dispose()
        End Try

        If status IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
