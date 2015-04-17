Public Class utstyrstype

    Private payload As New DataTable

    Private Sub utstyrstype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.utstyrstypeGrid
            .DataSource = daoDelt.hentUtstyrsType
            .Columns("id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("utstyrstype").HeaderText = "Utstyrstype"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub utstyrstypeGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles utstyrstypeGrid.CellClick
        txtNavn.Text = daoDelt.finnDGWVerdi(utstyrstypeGrid, "utstyrstype")
    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        'Legge til en ny utstyrstype i systemet
        Try
            Dim ut As New clsSykkelUtstyrType(txtNavn.Text)

            daoUtstyrstype.leggTilUtstyrstype(ut)
            MsgBox(ut.pNavn & " lagt til.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            utstyrstypeGrid.DataSource = daoDelt.hentUtstyrsType
        End Try
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Oppdater utstyrstype
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & txtNavn.Text & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim ut As New clsSykkelUtstyrType(daoDelt.finnDGWVerdi(utstyrstypeGrid, "id"),
                                                txtNavn.Text)

                    daoUtstyrstype.oppdaterUtstyrstype(ut)
                    MsgBox(txtNavn.Text & " oppdatert.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    utstyrstypeGrid.DataSource = daoDelt.hentUtstyrsType
                End Try
        End Select
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Slett utstyrstype
        Select Case MsgBox("Er du sikker på at du vil fjerne " & txtNavn.Text & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim ut As New clsSykkelUtstyrType(daoDelt.finnDGWVerdi(utstyrstypeGrid, "id"),
                                                      txtNavn.Text)

                    daoUtstyrstype.fjernUtstyrstype(ut)
                    MsgBox(txtNavn.Text & " fjernet.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    utstyrstypeGrid.DataSource = daoDelt.hentUtstyrsType
                End Try
        End Select
    End Sub
End Class