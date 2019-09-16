Option Explicit On
Option Strict On
Public Class ExampleForm


    'PascalCase FirstLetterOfEachWordIsCapital no spaces
    'Objects

    'camelCase  firstLetterIsNotCapital
    'variables

    'ALLCAPS
    'CONSTANTS

    'snake_case
    'used in python. not common in .NET




    Sub VariablesAndConstants()
        Dim somenumber As Integer
        Dim result As Integer

        'Constants can not change
        Const SOMECONSTANT = 7D

        somenumber = 5
        Console.WriteLine(somenumber)
        somenumber = 6
        Console.WriteLine(somenumber)

        'result = somenumber + Convert.ToInt32(SOMECONSTANT)
        result = somenumber + CInt(SOMECONSTANT)

        Console.WriteLine()

    End Sub

    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        VariablesAndConstants()
    End Sub
End Class
