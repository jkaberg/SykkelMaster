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

    Public Shared Function query2(ByVal sql As String) As Boolean
        conn.ConnectionString = config
        Dim status As Integer
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)

            status = cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Feil ved oppkobling til database: " & ex.Message)
        Finally
            conn.Dispose()
        End Try

        If (status > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Dim Query As String
    'Query = "INSERT INTO  userreg"
    Dim con As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=test;User ID=root;Password=mysql;")
    'Dim sql As MySqlCommand = New MySqlCommand(Query, con)

    Dim cmd As MySqlCommand = New MySqlCommand(query, con)

    Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            lblMsg.Text = "Record is Successfully Inserted"
        Else
            lblMsg.Text = "Record is not Inserted"
        End If
        con.Close()
End Class
