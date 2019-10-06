'Doug Cluff 
'RCET0265
'Asg2-6
'State Flags
'https://github.com/clufdoug/DAC-VS-F19/tree/master/Assignments/Asg2-6/State%20Flags

Public Class StateFlags

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub AlButton_Click(sender As Object, e As EventArgs) Handles AlButton.Click
        FlagPictureBox.Image = My.Resources.Resource.Flag_of_Alabama
        UsaLabel.Text = "Flag of Alabama"
    End Sub

    Private Sub AzButton_Click(sender As Object, e As EventArgs) Handles AzButton.Click
        FlagPictureBox.Image = My.Resources.Resource.Flag_of_Arizona
        UsaLabel.Text = "Flag of Arizona"
    End Sub

    Private Sub CaButton_Click(sender As Object, e As EventArgs) Handles CaButton.Click
        FlagPictureBox.Image = My.Resources.Resource.Flag_of_California
        UsaLabel.Text = "Flag of California"
    End Sub

    Private Sub CoButton_Click(sender As Object, e As EventArgs) Handles CoButton.Click
        FlagPictureBox.Image = My.Resources.Resource.Flag_of_Colorado
        UsaLabel.Text = "Flag of Colorado"
    End Sub

    Private Sub IdButton_Click(sender As Object, e As EventArgs) Handles IdButton.Click
        FlagPictureBox.Image = My.Resources.Resource.Flag_of_Idaho
        UsaLabel.Text = "Flag of Idaho"

    End Sub

    Private Sub NvButton_Click(sender As Object, e As EventArgs) Handles NvButton.Click
        FlagPictureBox.Image = My.Resources.Resource.Flag_of_Nevada
        UsaLabel.Text = "Flag of Nevada"
    End Sub

    Private Sub OrButton_Click(sender As Object, e As EventArgs) Handles OrButton.Click
        FlagPictureBox.Image = My.Resources.Resource.Flag_of_Oregon
        UsaLabel.Text = "Flag of Oregon"
    End Sub

    Private Sub UtButton_Click(sender As Object, e As EventArgs) Handles UtButton.Click
        FlagPictureBox.Image = My.Resources.Resource.Flag_of_Utah
        UsaLabel.Text = "Flag of Utah"
    End Sub

    Private Sub WashButton_Click(sender As Object, e As EventArgs) Handles WaButton.Click
        FlagPictureBox.Image = My.Resources.Resource.Flag_of_Washington
        UsaLabel.Text = "Flag of Washington"
    End Sub

    Private Sub WyButton_Click(sender As Object, e As EventArgs) Handles WyButton.Click
        FlagPictureBox.Image = My.Resources.Resource.Flag_of_Wyoming
        UsaLabel.Text = "Flag of Wyoming"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles FlagPictureBox.Click
        MessageBox.Show("Plese Select a State")

    End Sub


    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        FlagPictureBox.Image = My.Resources.Resource._50_us_state_flags__31031_1411402035
        UsaLabel.Text = "Flags of the USA"

    End Sub


End Class
