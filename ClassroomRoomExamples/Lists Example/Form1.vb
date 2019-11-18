
Option Explicit On
Option Strict On

Public Class Form1
    'example of lists

    Sub MakeANewList()
        Dim myNewList As New List(Of String)
        myNewList.Add("hello")
        myNewList.Add("bye")

        Console.WriteLine(myNewList(0))
        Console.WriteLine(myNewList(1))

    End Sub

    Sub iterateList()

        Dim otherList As New List(Of String)
        otherList.Add("Bob")
        otherList.Add("Jim")
        otherList.Add("Emily")
        otherList.Add("Beth")
        otherList.Add("Joe")

        For Each item In otherList
            Console.WriteLine(item)
        Next






        'Console.WriteLine(otherList(0))
        'Console.WriteLine(otherList(1))



    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MakeANewList()
        iterateList()


    End Sub
End Class
