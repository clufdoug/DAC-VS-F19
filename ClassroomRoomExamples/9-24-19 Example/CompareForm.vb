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
        Dim x As String

        firstString = "z"
        secondString = "Z"
        'x = Hex(90)
        'x = Chr(90)

        Console.WriteLine(firstString < secondString)
        'Console.WriteLine(x)


    End Sub
End Class
