' Assignment: Asg1-1
' RCET0265
' Doug Cluff
' Hello World Program

Public Class Form1
    Dim response As String
    Dim language As String



    Private Sub Language_English_Click(sender As Object, e As EventArgs) Handles Language_English.Click
        response = "Hello World"
        language = "English"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)

    End Sub

    Private Sub Language_French_Click(sender As Object, e As EventArgs) Handles Language_French.Click
        response = "Bonjour le monde"
        language = "French"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)
    End Sub

    Private Sub Language_Spanish_Click(sender As Object, e As EventArgs) Handles Language_Spanish.Click
        response = "Hola Mundo"
        language = "Spanish"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)
    End Sub

    Private Sub Language_German_Click(sender As Object, e As EventArgs) Handles Language_German.Click
        response = "Hallo Welt"
        language = "German"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)
    End Sub

    Private Sub Language_Italian_Click(sender As Object, e As EventArgs) Handles Language_Italian.Click
        response = "Ciao mondo"
        language = "Italian"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)
    End Sub

    Private Sub Language_Norwegian_Click(sender As Object, e As EventArgs) Handles Language_Norwegian.Click
        response = "Hei Verden"
        language = "Norwegian"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()


    End Sub
End Class
