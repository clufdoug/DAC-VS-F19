' Assignment: Asg1-5
' RCET0265
' Doug Cluff
' Daily Specials Program

Option Strict On
Option Explicit On

Public Class Specials
    Private Sub Special_Soup_Click(sender As Object, e As EventArgs) Handles Special_Soup.Click
        Special_Response.Text = "Cream Of Chicken & Wild Rice Soup" & vbNewLine & "Long grain And wild rice, celery, onions, carrots And diced chicken simmered In chicken broth embellished With cream And Select herbs. Served Saturday, Sunday, Tuesday And Thursday. Available In cup, bowl Or bread bowl"
    End Sub

    Private Sub Special_Fish_Click(sender As Object, e As EventArgs) Handles Special_Fish.Click
        Special_Response.Text = "All You Can Eat Catfish Strips" & vbNewLine & "With Fries, Coleslaw & Hushpuppies!"
    End Sub

    Private Sub Special_Chef_Click(sender As Object, e As EventArgs) Handles Special_Chef.Click
        Special_Response.Text = "Visual Basic four course feast" & vbNewLine & "All you can eat of your favorite form designs, coding, compilation, and repository updates on a paper platter!!"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
