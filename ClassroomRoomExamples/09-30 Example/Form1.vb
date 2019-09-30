Public Class Form1
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Resetall()
    End Sub

    Sub Response()
        '
        'If BadButton.Checked = True Then
        'MessageBox.Show("Thats So Sad...")
        ' End If

        Select Case True
            Case BadButton.Checked
                MessageBox.Show("That is so sad...")
            Case Meh.Checked
                MessageBox.Show("At least you are not dead...")
            Case GoodDayButton.Checked
                MessageBox.Show("That is great!")
            Case Else
                MessageBox.Show("Nothing was picked")
        End Select
    End Sub

    Private Sub ResponseButton_Click(sender As Object, e As EventArgs) Handles ResponseButton.Click
        Response()
    End Sub

    Sub resetall()
        BadButton.Checked = False
        Meh.Checked = False
        GoodDayButton.Checked = False


    End Sub


End Class
