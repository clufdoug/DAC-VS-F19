Public Class Form1
    Sub AssignString()
        'Initialize the namme variable to "Monday".
        Dim weekday As String
        Dim Somecrazystring As String
        weekday = "Monday"
        Console.WriteLine(weekday.Length())
    End Sub

    Sub Numbers()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer
        Dim userInput As Integer
        firstNumber = Convert.ToDecimal(firstNumberTextBox.Text)
        secondNumber = Convert.ToDecimal(secondNumberTextBox.Text)
        result = firstNumber + secondNumber

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub FirstNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles firstNumberTextBox.TextChanged

    End Sub

    Private Sub SecondNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles secondNumberTextBox.TextChanged

    End Sub

    Private Sub ResultTextBox_TextChanged(sender As Object, e As EventArgs) Handles resultTextBox.TextChanged

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        ()Numbers
    End Sub
End Class
