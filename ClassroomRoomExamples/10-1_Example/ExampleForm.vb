Public Class ExampleForm


    Private Function getRandomOther() As Integer
        'https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netframework-4.8

        Dim randomNumber As New Random

        'found to change about 2 times per millisecond
        'Dim newNum As Integer
        'Static oldNum
        'newNum = randomNumber.Next(1, 10)
        'If oldNum <> newNum Then
        '    Console.WriteLine(System.DateTime.Now.Millisecond)
        '    Console.WriteLine(newNum)
        '    oldNum = newNum
        'End If
        'getRandomOther = newNum

        getRandomOther = randomNumber.Next(1, 10)

    End Function

    'from some old code of mine
    Private Function getRandomInteger() As Integer 'returns a random number from 1 to 10
        Dim maxSingle As Single : maxSingle = 9
        Dim minSingle As Single : minSingle = 1
        Dim tempSingle As Single
        Randomize(System.DateTime.Now.Millisecond) 'set seed to current system millisecond
        tempSingle = ((maxSingle - minSingle + 1) * Rnd() + minSingle) 'actually get the random number in the range
        getRandomInteger = Convert.ToInt32(tempSingle) 'return the number
    End Function

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        For i = 1 To 1000
            'Console.WriteLine("at : " & Str(System.DateTime.Now.Millisecond) & " The home brew random number = " & Str(getRandomInteger())) 'this seems to run ok at full speed
            'Console.WriteLine("at : " & Str(System.DateTime.Now.Millisecond) & " The built in random number = " & Str(getRandomOther())) 'this seems to have longer time between change in number
            getRandomOther()
        Next
    End Sub
End Class
