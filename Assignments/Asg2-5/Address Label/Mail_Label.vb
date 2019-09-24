' Doug Cluff
' RCET 0265
' Asg2-5
' Address Label Display Program
' https://github.com/clufdoug/DAC-VS-F19/tree/master/Assignments

Option Explicit Off

Option Strict Off


Public Class Mail_Label
    Private Sub Display_Button_Click(sender As Object, e As EventArgs) Handles Display_Button.Click
        Output_Label.Text = FirstName_Textbox.Text & LastName_TextBox.Text & vbNewLine &
            Street_TextBox.Text & vbNewLine &
            City_TextBox.Text & " , " & State_ListBox.SelectedItem & " " & Zip_TextBox.Text

    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        FirstName_Textbox.Text = ""
        LastName_TextBox.Text = ""
        Street_TextBox.Text = ""
        City_TextBox.Text = ""
        Zip_TextBox.Text = ""
        Output_Label.Text = ""


    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()

    End Sub
End Class
