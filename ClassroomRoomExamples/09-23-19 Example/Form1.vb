

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x As Long

        Dim y As Long
        'x = 20
        'y = 7

        ''returns the decimal value of the division
        'Console.WriteLine("x/y =" & Str(x / y))
        ''returns the integer (whole number) value
        'Console.WriteLine("x/y =" & Str(x \ y))
        ''returns the remainder value after division
        'Console.WriteLine("x/y =" & Str(x Mod y))


        x = 8
        x <<= 1

        Console.WriteLine(Str(x))
        x >>= 1
        Console.WriteLine(Str(x))
        'x = x + 1
        '
    End Sub

End Class
