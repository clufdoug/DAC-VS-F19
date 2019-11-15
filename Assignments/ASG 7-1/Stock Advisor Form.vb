'Doug Cluff 
'RCET0265
'Asg7-1
'Stock Advisor Program
'https://github.com/

Option Strict On
Option Explicit On

Public Class StockAdvisorForm

    Dim mondayStockName As String = MondayStockNameTextBox.Text
    Dim mondayStockPrice As Double = Double.Parse(MondayStockPriceTextBox.Text)

    Dim tuesdayStockName As String = TuesdayStockNameTextBox.Text
    Dim tuesdayStockPrice As Double = Double.Parse(TuesdayStockPriceTextBox.Text)

    Dim WednesdayStockName As String = WednesdayStockNameTextBox.Text
    Dim WednesdayStockPrice As Double = Double.Parse(WednesdayStockPriceTextBox.Text)

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub About(sender As Object, e As EventArgs) Handles AboutButton.Click, AboutToolStripMenuItem.Click
        MessageBox.Show("This is a program to help decide the best stock to choose. It is in no way based on any real facts and is for your entertainment only. Any use beyond this is prohibited and may cost you your first born child.", " Disclaimer")
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateToolStripMenuItem.Click


        Console.WriteLine("Mondays Stock " & mondayStockName & "Costs" & mondayStockPrice)

        Console.WriteLine("Tuesdays Stock " & tuesdayStockName & "Costs" & tuesdayStockPrice)

        Console.WriteLine("Wednesdays Stock " & WednesdayStockName & "Costs" & WednesdayStockPrice)

    End Sub

    Private Sub Clear(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click


    End Sub

    Private Sub Summary(sender As Object, e As EventArgs) Handles SummaryButton.Click, SummaryToolStripMenuItem.Click

    End Sub
End Class
