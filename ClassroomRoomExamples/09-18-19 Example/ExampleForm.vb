Option Strict On
Option Explicit On
Public Class ExampleForm
    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim errorMessage As String
        errorMessage = ""

        LoadTestData() ' Load sample data, Remove for production

        'validate user input in reverse tabstop order
        Try
            firstNumber = Integer.Parse(TextBox1.Text)
        Catch anyException As Exception
            'Exception thrown so do stuff
            errorMessage = errorMessage & "Please enter a number in the 1st Textbox" & vbNewLine
            TextBox1.Select()
            TextBox1.Clear()
        End Try

        Try

            secondNumber = Integer.Parse(TextBox2.Text)
        Catch anyException As Exception
            'Exception thrown so do stuff
            errorMessage = errorMessage & "Please enter a number in the 2nd Textbox" & vbNewLine
            TextBox2.Select()
            TextBox2.Clear()
        End Try

        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "We have a Problem")
        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LoadTestData()
        Dim sample As Integer

        For sample = 1 To 5 Step 1
            Select Case sample
                Case = 1

                    TextBox1.Text = "5"
                    TextBox2.Text = "6"
                    Exit For
                Case = 2
                    TextBox1.Text = "5"
                    TextBox2.Text = "bad"
                    Exit For
                Case = 3
                    TextBox1.Text = "bad"
                    TextBox2.Text = "6"
                    Exit For
                Case = 4
                    TextBox1.Text = "bad"
                    TextBox2.Text = "bad"
                    Exit For
                Case = 5
                    TextBox1.Text = "5"
                    TextBox2.Text = "6"

            End Select
        Next sample



    End Sub






End Class