Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click

        If RadioButton1.Checked = True Then
            Console.WriteLine("Radio1")
        ElseIf RadioButton2.Checked = True Then
            Console.WriteLine("Radio2")
        ElseIf RadioButton3.Checked = True Then
            Console.WriteLine("Radio3")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button1.Enabled = True




    End Sub

    Private Sub LoadImage(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = My.Resources.kitty


    End Sub

    Private Sub HideTheButton_Click(sender As Object, e As EventArgs) Handles HideTheButton.Click
        'Hide or show button example
        If Button4.Visible = False Then
            Button4.Show()
        Else Button4.Hide()
        End If

    End Sub
End Class
