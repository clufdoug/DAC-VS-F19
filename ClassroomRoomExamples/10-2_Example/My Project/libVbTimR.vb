'Tim Rossiter - rosstimo@isu.edu
'This class contains reusable subs and functions
'Originnally created by me on 3-24-2018
'this could eventually be a reusable .dll - work in prgress
'enjoy

Option Strict Off 'doesn't like some of my functions - leave off unless troubleshooting

Public Class libVbTimR

    Public Shared Sub clearAllTextBoxesOn(ByVal parent As Object)
        allTextBoxesIn(parent).ForEach(Sub(item) item.Clear())
    End Sub

    Public Shared Sub clearAllCheckBoxesOn(ByVal parent As Object)
        allCheckBoxesIn(parent).ForEach(Sub(item) item.Checked = False)
    End Sub

    Public Shared Function allCheckBoxesIn(parent As Object) As List(Of CheckBox)
        Dim checkBoxList As New List(Of CheckBox)
        getObjectsIn(parent, "CheckBox").ForEach(Sub(item) checkBoxList.Add(TryCast(item, CheckBox)))
        Return checkBoxList
    End Function

    Public Shared Function allTextBoxesIn(parent As Object) As List(Of TextBox)
        Dim textBoxList As New List(Of TextBox)
        getObjectsIn(parent, "TextBox").ForEach(Sub(item) textBoxList.Add(TryCast(item, TextBox)))
        Return textBoxList
    End Function

    Public Shared Function allEmptyTextBoxesIn(parent As Object) As List(Of TextBox)
        Dim textBoxList As New List(Of TextBox)
        For Each txtbox As TextBox In allTextBoxesIn(parent)
            If txtbox.Text = "" Then textBoxList.Add(txtbox)
        Next
        Return textBoxList

    End Function

    Public Shared Function allTextBoxesWithIntegersIn(parent As Object) As List(Of TextBox)
        Dim textBoxList As New List(Of TextBox)
        For Each txtbox As TextBox In allTextBoxesIn(parent)
            Try
                Integer.Parse(txtbox.Text)
                textBoxList.Add(txtbox)
            Catch
                'do nothing and try next
            End Try
        Next
        Return textBoxList
    End Function

    Public Shared Function getIntegerFrom(txtBox As TextBox) As Integer
        If hasValidInteger(txtBox) Then Return Integer.Parse(txtBox.Text)
    End Function

    Public Shared Function hasValidInteger(txtBox As TextBox) As Boolean 'TODO make this and overloaded funcion that could be any number type return the type or something or return true if matched type argument
        Try
            Integer.Parse(txtBox.Text)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Shared Function getDoubleFrom(txtBox As TextBox) As Double
        If hasValidDouble(txtBox) Then Return Double.Parse(txtBox.Text)
    End Function

    Public Shared Function hasValidDouble(txtBox As TextBox) As Boolean 'TODO make this and overloaded funcion that could be any number type return the type or something or return true if matched type argument
        Try
            Double.Parse(txtBox.Text)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Shared Function getObjectsIn(parent As Object, matchTypeName As String) As List(Of Object)
        Dim objList As New List(Of Object)
        Dim ctrl As Control = parent.GetNextControl(parent, False)
        Do Until ctrl Is Nothing
            If TypeName(ctrl) = matchTypeName Then
                objList.Add(ctrl)
            End If
            ctrl = parent.GetNextControl(ctrl, False)
        Loop
        Return objList
    End Function

End Class
