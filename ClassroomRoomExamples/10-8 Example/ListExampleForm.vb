Public Class ListExampleForm

    Sub CreateList()
        Dim names As New List(Of String)
        Dim numbers As New List(Of Integer)(New Integer() {3, 5, 7, 2, 8})


        names.Add("Bill")
        names.Add("Emily")
        names.Add("Joe")
        names.Add("Nancy")


        Console.WriteLine(names(2))

        For Each items As String In names
            Console.WriteLine(items)
        Next






    End Sub

    Sub formatexample()
        'Format data in nice rows and columns
        Dim output As String
        output = ""

        For column = 1 To 10
            ' trim removes leading and trailing spaces
            output &= Str(column).Trim
            ' same as output = output & Str(column)

        Next

        Console.WriteLine(output)
        Console.WriteLine(output.Length)
    End Sub



    Private Sub ListExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Click
        CreateList()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formatexample()
        invoiceheader()
    End Sub
    Private Function invoiceheader() As String
        Dim headerstring As String
        headerstring = "******************************************************************"



    End Function

    Private Function columnheaders(firstcolumn As String, secondcolumn As String, thirdcolumn As String, fourthcolumn As String)
        'description, unit, rate, subtotal
        Dim columnwidth As Integer
        columnwidth = 20
        Return firstcolumn.PadRight(columnwidth) & secondcolumn.PadRight(columnwidth) &
            thirdcolumn.PadRight(columnwidth) & fourthcolumn.PadRight(columnwidth)

    End Function




End Class
