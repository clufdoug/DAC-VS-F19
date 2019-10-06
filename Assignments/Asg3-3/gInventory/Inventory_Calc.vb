'Doug Cluff
'RCET0265
'Asg3-3
'Inventory Calculator Program
'https://github.com/clufdoug/DAC-VS-F19/tree/master/Assignments/Asg3-3/gInventory

Option Explicit On
Option Strict On
Public Class InventoryCalc

    Dim begInventory As Integer
    Dim endInventory As Integer
    Dim avgInventory As Double
    Dim goodSold As Double
    Dim turnover As Double
    Dim errorMsg As String

    Private Sub Calculate_Button_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        TestValues()
    End Sub

    Sub TestValues()
        errorMsg = ""

        Try
            begInventory = Integer.Parse(GoodSoldTextBox.Text)
        Catch ex As FormatException
            errorMsg = "Goods Sold must be a Number"
            GoodSoldTextBox.Clear()
            GoodSoldTextBox.Focus()
        End Try

        Try
            begInventory = Integer.Parse(EndInvTextBox.Text)
        Catch ex As FormatException
            errorMsg = "Ending Inventory must be a Number"
            EndInvTextBox.Clear()
            EndInvTextBox.Focus()
        End Try

        Try
            begInventory = Integer.Parse(BegInvTextBox.Text)
        Catch ex As FormatException
            errorMsg = "Beginning Inventory must be a Number"
            BegInvTextBox.Clear()
            BegInvTextBox.Focus()
        End Try

        If errorMsg <> "" Then
            MessageBox.Show(errorMsg, "Error")
        Else
            setvar()
            InventoryCalculation()
            TurnoverCalculation()
        End If

    End Sub
    Sub setvar()
        begInventory = Integer.Parse(BegInvTextBox.Text)
        endInventory = Integer.Parse(EndInvTextBox.Text)
        goodSold = Double.Parse(GoodSoldTextBox.Text)
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        BegInvTextBox.Clear()
        EndInvTextBox.Clear()
        GoodSoldTextBox.Clear()
        TurnoverTextBox.Clear()
        AvgInvTextBox.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub InventoryCalculation()
        Console.WriteLine("Inventory Calculations")
        avgInventory = (begInventory + endInventory) / 2
        Console.WriteLine(avgInventory)
        AvgInvTextBox.Text = (avgInventory.ToString("C"))
    End Sub

    Private Sub TurnoverCalculation()
        Console.WriteLine("Turnover Calculations")
        turnover = goodSold / avgInventory
        Console.WriteLine(turnover)
        TurnoverTextBox.Text = (turnover.ToString("G2"))
    End Sub
End Class
