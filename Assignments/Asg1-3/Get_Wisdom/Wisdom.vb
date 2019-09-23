' Assignment: Asg1-1
' RCET0265
' Doug Cluff
' Wisdom Program

Option Explicit On
Option Strict On

Public Class Wisdom

    'display the first bit of wisdom in the label box
    Private Sub Wisdom_1_Click(sender As Object, e As EventArgs) Handles Wisdom_1.Click
        Wisdom_Response.Text = "Silence is often misinterpreted but never misquoted..."
    End Sub

    'display the second bit of wisdom in the label box
    Private Sub Wisdom_2_Click(sender As Object, e As EventArgs) Handles Wisdom_2.Click
        Wisdom_Response.Text = "Plan your life like you will live forever, and live your life like you will die the next day..."
    End Sub

    'display the third bit of wisdom in the label box
    Private Sub Wisdom_3_Click(sender As Object, e As EventArgs) Handles Wisdom_3.Click
        Wisdom_Response.Text = "Just because something is common sense doesn't mean it's common practice..."
    End Sub

    'display the fourth bit of wisdom in the label box
    Private Sub Wisdom_4_Click(sender As Object, e As EventArgs) Handles Wisdom_4.Click
        Wisdom_Response.Text = "Wisdom is to live in the present, plan for the future and profit from the past..."
    End Sub

    'Controls the Exit_Button to Exit the program
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
End Class
