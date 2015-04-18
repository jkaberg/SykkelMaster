Public Class regnPris
    Private Shared fortjeneste As Integer = 50

    Public Shared Function dag(ByVal innpris As Integer)
        Return innpris * 0.08 + (5 * fortjeneste)
    End Function

    Public Shared Function time(ByVal innpris As Integer)
        Return dag(innpris) * 0.1 + (2 * fortjeneste)
    End Function
End Class
