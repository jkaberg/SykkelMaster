Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class db
    Public Shared conn As New MySqlConnection
    Public Shared config As String = ConfigurationManager.ConnectionStrings("mysql").ConnectionString

    Public Shared Function data_table_query(ByVal sql As String) As DataTable
        Dim data As New DataTable
        conn.ConnectionString = config
        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = New MySqlCommand(sql, conn)
            adapter.Fill(data)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Database feil: " & ex.Message)
        Finally
            conn.Dispose()
        End Try
        Return data
    End Function

    Public Shared Function query(ByVal sql As String) As Boolean
        conn.ConnectionString = config
        Dim status As Integer
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            status = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Database feil: " & ex.Message)
        Finally
            conn.Dispose()
        End Try

        If (status > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
