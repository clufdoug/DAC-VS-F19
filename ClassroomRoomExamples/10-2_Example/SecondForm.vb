Public Class SecondForm
    Private Sub SecondForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Hello, Im the second Form"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReusableCode.Hide()

    End Sub
End Class