'Doug Cluff
'RCET0265
'Asg4-1
'Math Contest Form
'https://github.com/clufdoug/DAC­VS­F19/tree/master/Assignments/Asg4-1

Option Explicit On
Option Strict On
Public Class ContestForm
    Dim studentName As String
    Dim studentAge As Integer
    Dim studentGrade As Integer
    Dim randomNumber As Random = New Random(DateTime.Now.Millisecond)
    Dim firstNumber As Integer
    Dim secondNumber As Integer
    Dim errorReply As String = ""
    Dim validBoolean As Boolean = True
    Dim compresult As Double

    Private Sub ContestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SubmitButton.Enabled = False
    End Sub



    Private Sub ContestForm_Validate()




        If AgeTextBox.TextLength = 0 Or GradeTextBox.TextLength = 0 Or NameTextBox.TextLength = 0 Then
            SubmitButton.Enabled = False
                'Integer.Parse(AgeTextBox.Text)
            Else
                Setnumbers()
            SubmitButton.Enabled = True
            studentName = NameTextBox.Text

            Try
                studentAge = Integer.Parse(AgeTextBox.Text)
            Catch ex As Exception
                MessageBox.Show("Please number as for Student Age")
                AgeTextBox.Text = ""
                AgeTextBox.Focus()
            End Try

            Try
                studentGrade = Integer.Parse(GradeTextBox.Text)
            Catch ex As Exception
                MessageBox.Show("Please number as for Student Grade")
                GradeTextBox.Text = ""
                GradeTextBox.Focus()
            End Try

            ValidateTextBox.Text = "Hello " & studentName & " Age " & studentAge & " Grade " & studentGrade
        End If

    End Sub



    Private Sub Setnumbers() 'Resets and displays the random number for calculations
        firstNumber = randomNumber.Next(1, 10)
        secondNumber = randomNumber.Next(1, 10)
        FirstNumberTextBox.Text = CStr(firstNumber)
        SecondNumberTextBox.Text = CStr(secondNumber)

    End Sub
    Private Sub MathType() 'Determines the type of math being used for the calculations
        If AddButton.Checked = True Then
            compresult = firstNumber + secondNumber
            AnswerTextBox.Focus()
        ElseIf SubtractButton.Checked = True Then
            compresult = firstNumber - secondNumber
            AnswerTextBox.Focus()
        ElseIf MultiplyButton.Checked = True Then
            compresult = firstNumber * secondNumber
            AnswerTextBox.Focus()
        ElseIf DivideButton.Checked = True Then
            compresult = firstNumber / secondNumber
            AnswerTextBox.Focus()
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click 'Used to exit the program
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        AgeTextBox.Clear()
        ValidateTextBox.Clear()
        NameTextBox.Clear()
        GradeTextBox.Clear()
        AnswerTextBox.Clear()
        FirstNumberTextBox.Clear()
        SecondNumberTextBox.Clear()
        AddButton.Checked = False
        SubtractButton.Checked = False
        MultiplyButton.Checked = False
        DivideButton.Checked = False

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MessageBox.Show(ValidateTextBox.Text, "Your Results")
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        Try
            Decimal.Parse(AnswerTextBox.Text)

            MathType()

            If Decimal.Parse(AnswerTextBox.Text) = compresult Then

                ValidateTextBox.Text = ValidateTextBox.Text & vbNewLine & AnswerTextBox.Text & " is correct"
            Else
                ValidateTextBox.Text = ValidateTextBox.Text & vbNewLine & AnswerTextBox.Text & " is not correct." _
                   & vbNewLine & " The correct answer is " & compresult
            End If
            AnswerTextBox.Text = ""
            AnswerTextBox.Focus()
            Setnumbers()


        Catch ex As Exception
            errorReply = "Answer provided must be a number"
            MessageBox.Show(errorReply)
            AnswerTextBox.Text = ""
            AnswerTextBox.Focus()
        End Try




    End Sub

    Private Sub AgeTextBox_Leave(sender As Object, e As EventArgs) Handles AgeTextBox.Leave

        If Integer.Parse(AgeTextBox.Text) >= 7 And Integer.Parse(AgeTextBox.Text) <= 11 Then
            ContestForm_Validate()
        Else
            MessageBox.Show("Age must be between 7 and 11")
            AgeTextBox.Focus()
            AgeTextBox.Text = ""
        End If
    End Sub


    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub GradeTextBox_leave(sender As Object, e As EventArgs) Handles GradeTextBox.Leave

        If Integer.Parse(GradeTextBox.Text) >= 1 And Integer.Parse(GradeTextBox.Text) <= 4 Then
            ContestForm_Validate()
        Else
            MessageBox.Show("Grade must be between 1 and 4")
            GradeTextBox.Focus()
        End If
    End Sub


End Class
