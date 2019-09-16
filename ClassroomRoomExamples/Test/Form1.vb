Public Class Form1
    Sub AssignString()
        'Initialize the name variable to "Monday"
        Dim weekday As String
        weekday = "Monday"
        Console.WriteLine(weekday)
    End Sub

    Sub Numbers()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim Result As Integer
        firstNumber = 5
        secondNumber = 6

        Result = firstNumber + secondNumber
    End Sub
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        AssignString()
        Numbers()
    End Sub

End Class
