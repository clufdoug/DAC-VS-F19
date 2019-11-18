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
        Else
            Setnumbers()
            SubmitButton.Enabled = True
            studentName = NameTextBox.Text
            studentAge = Integer.Parse(AgeTextBox.Text)
            studentGrade = Integer.Parse(GradeTextBox.Text)
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

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MessageBox.Show(ValidateTextBox.Text, "Your Results")
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Try
            Decimal.Parse(AnswerTextBox.Text)

        Catch ex As Exception
            errorReply = "Answer provided must be a number"
            MessageBox.Show(errorReply)
            AnswerTextBox.Text = ""
            AnswerTextBox.Focus()
        End Try


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

    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged, NameTextBox.TextChanged, GradeTextBox.TextChanged
        ContestForm_Validate()
    End Sub


End Class
