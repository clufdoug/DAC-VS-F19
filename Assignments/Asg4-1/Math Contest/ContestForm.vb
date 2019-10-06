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
    Dim firstNumber As Integer = randomNumber.Next(1, 10)
    Dim secondNumber As Integer = randomNumber.Next(1, 10)

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

    Private Sub Setnumbers()
        FirstNumberTextBox.Text = CStr(firstNumber)
        SecondNumberTextBox.Text = CStr(secondNumber)
    End Sub






    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged, NameTextBox.TextChanged, GradeTextBox.TextChanged

        ContestForm_Validate()
    End Sub


End Class
