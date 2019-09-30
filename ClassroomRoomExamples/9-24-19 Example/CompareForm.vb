Option Compare Binary




Public Class CompareForm
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        CompareStrings()

    End Sub

    Sub Compare()




        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim thirdNumber As Integer

        firstNumber = 1
        secondNumber = 4
        thirdNumber = 3



        'is thirdNumber beetween first and second number

        If thirdNumber > firstNumber And thirdNumber < secondNumber Then
            MessageBox.Show("True")

        Else
            MessageBox.Show("false")

        End If
    End Sub
    Sub CompareStrings()
        Dim firstString As String
        Dim secondString As String
        Dim x As Integer
        Dim amount As Integer
        amount = 1


        firstString = "abcd"
        secondString = "abde"
        'x = Hex(90)
        'x = Chr(90)

        x = Len(firstString)
        Console.WriteLine("before the loop" & Str(x))

        For i = 1 To 10
            firstString &= "!"
            Console.WriteLine(firstString)
        Next
        x = Len(firstString)
        'Console.WriteLine(firstString < secondString)
        Console.WriteLine("after the loop" & Str(x))
        'Console.WriteLine(x)


    End Sub
    Sub MessageWithButtons()
        Dim returnValue As DialogResult
        returnValue = MessageBox.Show("This is the message", "Heading", MessageBoxButtons.AbortRetryIgnore)
    End Sub

End Class
