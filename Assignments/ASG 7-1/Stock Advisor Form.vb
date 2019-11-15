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

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub About(sender As Object, e As EventArgs) Handles AboutButton.Click, AboutToolStripMenuItem.Click
        MessageBox.Show("This is a program to help decide the best stock to choose. It is in no way based on any real facts and is for your entertainment only. Any use beyond this is prohibited and may cost you your first born child.", " Disclaimer")
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateToolStripMenuItem.Click

        mondayStockName = MondayStockNameTextBox.Text
        mondayStockPrice = Integer.Parse(MondayStockPriceTextBox.Text)
        Console.WriteLine("Mondays Stock " & mondayStockName & " Costs " & mondayStockPrice)
        tuesdayStockName = TuesdayStockNameTextBox.Text
        tuesdayStockPrice = Integer.Parse(TuesdayStockPriceTextBox.Text)
        Console.WriteLine("Tuesdays Stock " & tuesdayStockName & " Costs " & tuesdayStockPrice)
        wednesdayStockName = WednesdayStockNameTextBox.Text
        wednesdayStockPrice = Integer.Parse(WednesdayStockPriceTextBox.Text)
        Console.WriteLine("Wednesdays Stock " & wednesdayStockName & " Costs " & wednesdayStockPrice)

    End Sub

    Private Sub Clear(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click


    End Sub

    Private Sub Summary(sender As Object, e As EventArgs) Handles SummaryButton.Click, SummaryToolStripMenuItem.Click

    End Sub
End Class
