Public Class StringExampleForm

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        'Concatinate first and last name and then display
        Label3.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class
