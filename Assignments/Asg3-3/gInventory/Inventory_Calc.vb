Public Class Form1

    Dim begInventory As Integer
    Dim endInventory As Integer
    Dim avgInventory As Double
    Dim goodSold As Double
    Dim turnover As Double

    Private Sub Calculate_Button_Click(sender As Object, e As EventArgs) Handles Calculate_Button.Click
        TestValues()
        setvar()
        Inventory_Calculation()
        Turnover_Calculation()
    End Sub
    Sub TestValues()
        Try
            begInventory = Integer.Parse(Beg_Inv_TextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Beginning Inventory must be a Number", "Error")
        Finally
            Beg_Inv_TextBox.Clear()
            Beg_Inv_TextBox.Focus()
        End Try

    End Sub
    Sub setvar()
        begInventory = Integer.Parse(Beg_Inv_TextBox.Text)
        endInventory = Integer.Parse(End_Inv_TextBox.Text)
        goodSold = Double.Parse(Good_Sold_TextBox.Text)
    End Sub
    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Beg_Inv_TextBox.Clear()
        End_Inv_TextBox.Clear()
        Good_Sold_TextBox.Clear()
        Turnover_TextBox.Clear()
        Avg_Inv_TextBox.Clear()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()

    End Sub

    Private Sub Inventory_Calculation()
        Console.WriteLine("Inventory Calculations")
        avgInventory = (begInventory + endInventory) / 2
        Console.WriteLine(avgInventory)
        Avg_Inv_TextBox.Text = (avgInventory.ToString("C"))
    End Sub

    Private Sub Turnover_Calculation()
        Console.WriteLine("Turnover Calculations")
        turnover = goodSold / avgInventory
        Console.WriteLine(turnover)
        Turnover_TextBox.Text = (turnover.ToString("G2"))


    End Sub
End Class
