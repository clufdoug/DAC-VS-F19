Public Class Form1

    Sub MySub(ByVal message As String)
        Me.Text = message
        message = "the message changed"
        Console.WriteLine(message)
    End Sub

    Function myfunc() As String

        Return "hello"


    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Me.Text = myfunc()
        Dim usermessage As String
        usermessage = "my message is 42"
        MySub(usermessage)
        Console.WriteLine(usermessage)
    End Sub
End Class
