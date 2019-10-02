'Doug Cluff
'10-2-19 Example

Option Strict On
Option Explicit On
Public Class ReuseableCode

    Sub SetToDefaults() 'Reusable Reset
        FirstTextBox.Clear()
        SecondTextBox.Clear()
        ThirdTextBox.Clear()
        'GoButton.Enabled = False
        FirstTextBox.Select()
    End Sub
    Sub HasValidInteger(txtbox As TextBox)
        Dim number As Integer
        Try
            'number = Integer.Parse(FirstTextBox.text)
            'number = Integer.Parse(stringData)

            number = Integer.Parse(txtbox.Text)

        Catch ex As Exception
            MessageBox.Show("Please enter a valid number in " & txtbox.Name)
        End Try




    End Sub

    Sub ValidateAllTextBoxes()




    End Sub





    Function MyFunc() As Integer

        Return 0
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetToDefaults()
    End Sub


    Private Sub ReuseableCode_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetToDefaults()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        HasValidInteger(FirstTextBox)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub
End Class
