Public Class sykkeltype

    Private payload As New DataTable

    Private Sub sykkeltype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oppdaterGridView()
    End Sub

    Private Sub oppdaterGridView()
        With Me.sykkeltypeGrid
            .DataSource = daoDelt.hentSykkelType
            .Columns("id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("sykkeltype").HeaderText = "Sykkletype"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub SykkelGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles sykkeltypeGrid.CellClick
        txtNavn.Text = daoDelt.finnDGWVerdi(sykkeltypeGrid, "sykkeltype")
    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        'Legge til en ny sykkeltype i systemet
        Try
            Dim st As New clsSykkelType(txtNavn.Text)

            daoSykkelType.leggTilSykkelType(st)
            MsgBox(st.pNavn & " lagt til.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            oppdaterGridView()
        End Try
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Oppdater sykkeltype
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & txtNavn.Text & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim st As New clsSykkelType(daoDelt.finnDGWVerdi(sykkeltypeGrid, "id"),
                                                txtNavn.Text)

                    daoSykkelType.oppdaterSykkelType(st)
                    MsgBox(txtNavn.Text & " oppdatert.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                End Try
        End Select
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Slett sykkeltype
        Select Case MsgBox("Er du sikker på at du vil fjern " & txtNavn.Text & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim st As New clsSykkelType(daoDelt.finnDGWVerdi(sykkeltypeGrid, "id"),
                                                txtNavn.Text)

                    daoSykkelType.fjernSykkelType(st)
                    MsgBox(txtNavn.Text & " fjernet.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                End Try
        End Select
    End Sub
End Class