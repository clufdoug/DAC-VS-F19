'Doug Cluff 
'RCET0265
'Asg2-6
'State Flags
'https://github.com/clufdoug/DAC-VS-F19/tree/master/Assignments/Asg2-6/State%20Flags

Public Class Form1



    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub AlabButton_Click(sender As Object, e As EventArgs) Handles AlabButton.Click
        PictureBox1.Image = My.Resources.Resource.Flag_of_Alabama
    End Sub

    Private Sub ArizButton_Click(sender As Object, e As EventArgs) Handles ArizButton.Click
        PictureBox1.Image = My.Resources.Resource.Flag_of_Arizona
    End Sub

    Private Sub CaliButton_Click(sender As Object, e As EventArgs) Handles CaliButton.Click
        PictureBox1.Image = My.Resources.Resource.Flag_of_California
    End Sub

    Private Sub ColoButton_Click(sender As Object, e As EventArgs) Handles ColoButton.Click
        PictureBox1.Image = My.Resources.Resource.Flag_of_Colorado
    End Sub

    Private Sub IdahButton_Click(sender As Object, e As EventArgs) Handles IdahButton.Click
        PictureBox1.Image = My.Resources.Resource.Flag_of_Idaho

    End Sub

    Private Sub NevaButton_Click(sender As Object, e As EventArgs) Handles NevaButton.Click
        PictureBox1.Image = My.Resources.Resource.Flag_of_Nevada
    End Sub

    Private Sub OregButton_Click(sender As Object, e As EventArgs) Handles OregButton.Click
        PictureBox1.Image = My.Resources.Resource.Flag_of_Oregon
    End Sub

    Private Sub UtahButton_Click(sender As Object, e As EventArgs) Handles UtahButton.Click
        PictureBox1.Image = My.Resources.Resource.Flag_of_Utah
    End Sub

    Private Sub WashButton_Click(sender As Object, e As EventArgs) Handles WashButton.Click
        PictureBox1.Image = My.Resources.Resource.Flag_of_Washington
    End Sub

    Private Sub WyomButton_Click(sender As Object, e As EventArgs) Handles WyomButton.Click
        PictureBox1.Image = My.Resources.Resource.Flag_of_Wyoming
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Plese Select a State")

    End Sub
End Class
