'Doug Cluff 
'RCET0265
'Asg7-1
'Stock Advisor Program
'https://github.com/

Option Strict On
Option Explicit On

Public Class StockAdvisorForm

    Dim mondayStockName As String
    Dim mondayStockPrice As Double
    Dim tuesdayStockName As String
    Dim tuesdayStockPrice As Double
    Dim wednesdayStockName As String
    Dim wednesdayStockPrice As Double
    Dim errorMessage As String


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to close?", "End Program?", MessageBoxButtons.OKCancel) _
            = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub About(sender As Object, e As EventArgs) Handles AboutButton.Click, AboutToolStripMenuItem.Click
        MessageBox.Show("This is a program to help decide the best stock to choose. It is in no way based on any real facts and is for your entertainment only. Any use beyond this is prohibited and may cost you your first born child.", " Disclaimer")
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateToolStripMenuItem.Click
        Try
            mondayStockName = MondayStockNameTextBox.Text
            mondayStockPrice = Double.Parse(MondayStockPriceTextBox.Text)
            Console.WriteLine("Mondays Stock " & mondayStockName & " Costs " & mondayStockPrice)
        Catch ex As Exception
            errorMessage = "Monday"
            MondayStockPriceTextBox.Select()
            MondayStockPriceTextBox.Clear()
        End Try

        Try
            tuesdayStockName = TuesdayStockNameTextBox.Text
            tuesdayStockPrice = Double.Parse(TuesdayStockPriceTextBox.Text)
            Console.WriteLine("Tuesdays Stock " & tuesdayStockName & " Costs " & tuesdayStockPrice)
        Catch ex As Exception
            errorMessage = "Tuesday"
            TuesdayStockPriceTextBox.Select()
            TuesdayStockPriceTextBox.Clear()
        End Try

        Try
            wednesdayStockName = WednesdayStockNameTextBox.Text
            wednesdayStockPrice = Double.Parse(WednesdayStockPriceTextBox.Text)
            Console.WriteLine("Wednesdays Stock " & wednesdayStockName & " Costs " & wednesdayStockPrice)
        Catch ex As Exception
            errorMessage = "Wednesday"
            WednesdayStockPriceTextBox.Select()
            WednesdayStockPriceTextBox.Clear()
        End Try

        If errorMessage <> "" Then
            MessageBox.Show("Please enter a valid number for " & (errorMessage) & " stock price.", "Input Error")
        Else compileList()
        End If

    End Sub

    Private Sub Clear(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        MondayStockNameTextBox.Clear()
        MondayStockPriceTextBox.Clear()
        TuesdayStockNameTextBox.Clear()
        TuesdayStockPriceTextBox.Clear()
        WednesdayStockNameTextBox.Clear()
        WednesdayStockPriceTextBox.Clear()
    End Sub

    Private Sub Summary(sender As Object, e As EventArgs) Handles SummaryButton.Click, SummaryToolStripMenuItem.Click

    End Sub

    Private Sub compileList()

    End Sub
End Class
