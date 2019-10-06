'Doug Cluff
'RCET0265
'Asg3-6
'Shipping Cost Program
'https://github.com/clufdoug/DAC-VS-F19/tree/master/Assignments/Asg3-6

Option Explicit On
Option Strict On

Public Class ShipCalc
    Dim weightLbs As Integer
    Dim weightOz As Integer
    Dim totalWeight As Integer
    Dim totalCost As Double
    Dim priceOz As Double
    Dim errorMsg As String
    Dim idText As Integer




    'Private Sub ShipCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    If OzTextBox.Text <> "" And LbsTextBox.Text <> "" And IdLabel.Text <> "" Then
    '        CalculateButton.Enabled = True
    '        ClearButton.Enabled = True
    '    Else
    '        CalculateButton.Enabled = False
    '        ClearButton.Enabled = False
    '    End If
    'End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Initialize()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        errorMsg = ""
        Try
            weightOz = Integer.Parse(OzTextBox.Text)
        Catch ex As FormatException
            errorMsg = "Ounces must be a Number"
            OzTextBox.Clear()
            OzTextBox.Focus()
        End Try

        Try
            idText = IdTextBox.TextLength
        Catch ex As FormatException
            errorMsg = "Ounces must be a Number"
            OzTextBox.Clear()
            OzTextBox.Focus()
        End Try

        If IdTextBox.TextLength <> 6 Then
            errorMsg = "ID must be 6 Digits"
            IdTextBox.Clear()
            IdTextBox.Focus()
        End If


        If errorMsg <> "" Then
            MessageBox.Show(errorMsg, "Error")
        Else
            WeightCalc()
        End If





        ShipCostTextBox.Text = (totalCost.ToString("C"))
    End Sub

    Sub WeightCalc()

        weightLbs = Integer.Parse(LbsTextBox.Text)
        weightOz = Integer.Parse(OzTextBox.Text)
        totalWeight = 0
        totalCost = 0
        priceOz = 0.12

        totalWeight = (weightLbs * 16) + weightOz
        Console.WriteLine(totalWeight)
        totalCost = totalWeight * priceOz
        Console.WriteLine(totalCost)
    End Sub

    'Sub ButtonEnable()
    '    If OzTextBox.Text <> "" And LbsTextBox.Text <> "" And IdLabel.Text <> "" Then
    '        CalculateButton.Enabled = True
    '        ClearButton.Enabled = True
    '    Else
    '        CalculateButton.Enabled = False
    '        ClearButton.Enabled = False
    '    End If
    'End Sub

    Sub Initialize()
        IdTextBox.Clear()
        LbsTextBox.Clear()
        OzTextBox.Clear()
        ShipCostTextBox.Clear()
    End Sub
End Class
