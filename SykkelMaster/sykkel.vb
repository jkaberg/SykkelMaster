Public Class sykkel

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Select Case ComboBox1.SelectedValue.ToString
            Case "Mountainbike"
                ComboBox4.Enabled = True
                ComboBox3.Enabled = True
            Case "Bysykkel"
                ComboBox4.Enabled = False
                ComboBox3.Enabled = True
            Case "Barnsykkel"
                ComboBox4.Enabled = True
                ComboBox3.Enabled = False
        End Select
    End Sub
End Class