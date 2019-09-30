Public Class Form1
    Dim everyoneCanSeeThis As Integer

    Sub RunningTotal()
        Static total As Integer
        total += 1

        everyoneCanSeeThis += 1

        Console.WriteLine(total)
    End Sub


End Class
