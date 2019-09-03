'Assignment: Asg1-1
'RCET0265
'Doug Cluff
'Hello World Program





Public Class Form1
    Private Sub UpdateTitle(sender As Object, e As EventArgs) Handles UpdateTitleButton.Click
        Me.Text = "My First Windows form."
        Me.DisplayLabel.Text = "Bonjour tout le monde"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class

