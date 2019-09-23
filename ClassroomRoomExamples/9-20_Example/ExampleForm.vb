Option Strict On
Option Explicit On

Public Class ExampleForm




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer 'Loop counter: index,column,row, counter. defines current iteration
        Dim j As Integer 'Nested Loop counter

        Dim outerLoopMax As Integer
        Dim innerLoopMax As Integer
        Dim loopStart As Integer





        'From 1 to 100 in increments of 1
        'i or loopcounter variable gets assigned by and incremented by the loop structure
        For i = 1 To 100 Step 1

            For j = 0 To 10 Step 1
                Console.WriteLine("i = " & Str(i) & " " & "j = " & Str(j))
            Next
        Next

    End Sub

    Private Sub runloop()

    End Sub


End Class
