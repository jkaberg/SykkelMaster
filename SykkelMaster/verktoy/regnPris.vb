Public Class regnPris

    Public Shared Function dag(ByVal innpris As Integer)
        Return innpris * 0.15
    End Function

    Public Shared Function time(ByVal innpris As Integer)
        Return innpris * 0.0015
    End Function
End Class
