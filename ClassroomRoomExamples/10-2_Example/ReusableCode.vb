Option Explicit On
Option Strict On
Public Class ReusableCode


    Sub SetToDefaults() 'Reusable reset sub
        FirstTextBox.Clear()
        SecondTextBox.Clear()
        ThirdTextBox.Clear()
        'GoButton.Enabled = False
        FirstTextBox.Select()
    End Sub

    Sub HasValidInteger(txtbox As TextBox)
        Dim number As Integer
        Try
            'number = Integer.Parse(FirstTextbox.text)
            'number = Integer.Parse(stringData)
            number = Integer.Parse(txtbox.Text)
        Catch ex As Exception
            MessageBox.Show("please enter a valid number in " & txtbox.Name)
        End Try

    End Sub

    Private Function GetAllTextBoxes() As List(Of Control)
        'This loops through all the controls in the parent/container.
        'In this case a groupbox called UserInputGroupBox.
        'Each textbox encountered will be added to a list of textboxes and is returned.
        'see libTimR.vb function called getObjectsIn()

        'Word of caution:
        'If you Then can't explain what your code does step by step. 
        'Don't use it in your school assignments.
        'Cut and paste code is not your original work so you can't claim it as your own.
        'calling methods from a library or DLL is the proper way to use code that you have not written yourself.

        'temperary storage for the control object
        Dim ctrl As Control

        'List of all textbox control objects found
        Dim listOfTextBoxes As New List(Of Control)

        'Created this as a loop counter to avoid being stuck
        'in an infinate loop during debugging.
        Dim loopCounter As Integer
        loopCounter = 0

        'This was used to see what TypeName() Returns
        'Console.WriteLine(TypeName(FirstTextBox)) 

        'Get the first control in the group box
        'ctrl must be assigned or the Do loop will see crtl is Nothing and not execute
        ctrl = UserInputGroupBox.GetNextControl(ctrl, False)

        Do Until ctrl Is Nothing Or loopCounter >= 100
            loopCounter += 1

            'Lets see all the controls while debugging
            'Console.WriteLine(ctrl.Name & " is a " & TypeName(ctrl) & " " & "Loop count is: " & Str(loopCounter))

            If TypeName(ctrl) = "TextBox" Then

                'See matching results while debugging
                'Console.WriteLine(ctrl.Name & " is a " & TypeName(ctrl) & " and is a match!!")

                'If the current control is a text box save it to the list
                listOfTextBoxes.Add(ctrl)

            End If

            'Get the first control in the group box
            ctrl = UserInputGroupBox.GetNextControl(ctrl, False)

        Loop

        Return listOfTextBoxes

    End Function

    Function getEmptyTextboxes() As String
        Dim message As String
        message = ""

        For Each txtbox As TextBox In GetAllTextBoxes()
            Console.WriteLine(txtbox.Name)
            message += txtbox.Name
        Next

        Return message
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        SetToDefaults()
        SecondForm.Hide()

    End Sub

    Private Sub ReusableCode_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetToDefaults()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click, GoToolStripMenuItem.Click

        Console.WriteLine(getEmptyTextboxes())
        'GetAllTextBoxes()
        'HasValidInteger(FirstTextBox)
        SecondForm.Show()


    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
