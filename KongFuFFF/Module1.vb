Module Module1
    Public Function Rndz(a As Long, b As Long)
        Randomize()
        Rndz = Int((a - b + 1) * Rnd() + b)
    End Function
End Module
