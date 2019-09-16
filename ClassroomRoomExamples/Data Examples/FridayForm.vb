Public Class FridayForm

    Private Sub DoStuffButton_Click(sender As Object, e As EventArgs) Handles DoStuffButton.Click
        fridayExample() 'call the fridayExample sub 
    End Sub


    Sub fridayExample()
        Dim statementOne As String
        Dim statementTwo As String
        Dim statementThree As String
        Dim currentString As String
        Dim rndNumber As Single

        statementOne = "The greatest wisdom ever is... " & vbNewLine & "stuff on next line"
        statementTwo = "The second mouse gets the cheese.."
        statementThree = "Dont spit into the wind.."
        currentString = "Other Info"

        Dim randomNumberExample As New Random 'instantiate new random number object

        'For i = 0 To 1000
        '    rndNumber = randomNumberExample.Next(1, 4)
        '    Console.WriteLine("The current i is " & Str(i) & "The random number is " & Str(rndNumber))
        'Next

        rndNumber = randomNumberExample.Next(1, 4)
        If rndNumber = 1 Then
            Console.WriteLine(currentString)
        ElseIf rndNumber = 2 Then
            Console.WriteLine(statementTwo)
        ElseIf rndNumber = 3 Then
            Console.WriteLine(statementThree)
        Else
            Console.WriteLine("None of the above")
        End If

        Console.ReadLine()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
