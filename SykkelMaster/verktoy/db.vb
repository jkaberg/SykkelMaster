Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class db
    Public Shared conn As New MySqlConnection
    Public Shared config As String = ConfigurationManager.ConnectionStrings("mysql").ConnectionString
    Public Shared Function query(ByVal sql As String) As DataTable
        Dim data As New DataTable
        conn.ConnectionString = config
        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = New MySqlCommand(sql, conn)
            adapter.Fill(data)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Feil ved oppkobling til database: " & ex.Message)
        Finally
            conn.Dispose()
        End Try
        Return data
    End Function
End Class
