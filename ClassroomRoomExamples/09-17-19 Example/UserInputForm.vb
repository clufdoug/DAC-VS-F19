Option Explicit On
Option Strict On

Public Class UserInputForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim resultNumber As Integer

        secondNumber = 7

        'firstNumber = Convert.ToInt32(NumberTextBox.Text)


        Try
            firstNumber = Integer.Parse(NumberTextBox.Text)
            Console.WriteLine("In the Try Code")
        Catch ex As Exception
            Console.WriteLine("In the Catch Code")
            Console.WriteLine(ex.Message)
            NumberTextBox.Text = ""
            MsgBox("Please enter a valid number")
            NumberTextBox.Select()

        Finally
            Console.WriteLine("In the Finally Code")
        End Try



        resultNumber = firstNumber + secondNumber

        Console.WriteLine(resultNumber)

    End Sub

    Private Sub NumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles NumberTextBox.TextChanged

    End Sub
End Class
