
Public Class innlevering

    Private Sub innlevering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM salg_leie")

        DataGridView1.DataSource = payload
    End Sub

    Public telefon As Integer
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim payload As New DataTable
        Dim rad As DataRow
        Dim sqlNavnCombo As String = "SELECT fornavn, etternavn, telefon FROM person WHERE fornavn LIKE '" & TextBox3.Text & "%' OR etternavn LIKE '" & TextBox3.Text & "%' OR telefon LIKE '" & TextBox3.Text & "%' "
        payload = db.query(sqlNavnCombo)
        Dim fornavn, etternavn As String

        ComboBox1.Items.Clear()
        'Kunder blir lagt ut i ComboBox
        For Each rad In payload.Rows
            fornavn = rad("fornavn")
            etternavn = rad("etternavn")
            telefon = rad("telefon")
            ComboBox1.Items.Add(fornavn & " " & etternavn)

        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Telefon blir vist for vertifisering av kunde
        TextBox2.Text = telefon
    End Sub
End Class