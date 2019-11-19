'Doug Cluff
'RCET0265
'Asg4-1
'Math Contest Form
'https://github.com/clufdoug/DAC­VS­F19/tree/master/Assignments/Asg4-6

Option Strict On
Option Explicit On

Public Class rentalForm

    Dim beginOdometer As Integer
    Dim endOdometer As Integer
    Dim custName As String
    Dim custAddress As String
    Dim custCity As String
    Dim custState As String
    Dim custZip As Integer
    Dim days As Integer
    Dim discounts As Integer



    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        milesDriven()
        mileCharge()
        dayCharge()
        discount()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

    End Sub

    Private Sub summaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Function milesDriven() As Integer
        beginOdometer = Integer.Parse(beginOdometerTextBox.Text)
        endOdometer = Integer.Parse(endOdometerTextBox.Text)
        milesDriven = endOdometer - beginOdometer
        milesDrivenLabel.Text = milesDriven.ToString
        'Console.WriteLine(milesDriven)
    End Function

    Private Function mileCharge() As Double
        If milesDriven() <= 200 Then
            mileCharge = 0
        ElseIf milesDriven() > 200 And milesDriven() <= 500 Then
            mileCharge = (milesDriven() - 200) * 0.12
        ElseIf milesDriven() > 500 Then
            mileCharge = ((milesDriven() - 500) * 0.1) + (300 * 0.12)
        End If
        mileChargeLabel.Text = mileCharge.ToString
        'Console.WriteLine(mileCharge)

    End Function

    Private Function dayCharge() As Double
        If Integer.Parse(daysTextBox.Text) = 0 Or Integer.Parse(daysTextBox.Text) > 45 Then
            MessageBox.Show("Days must be greater than 0 and less than 45", "Input Error")
            daysTextBox.Clear()
            daysTextBox.Focus()
        Else
            dayCharge = Integer.Parse(daysTextBox.Text) * 15.0
            dayChargeLabel.Text = dayCharge.ToString
            Console.WriteLine(dayCharge)
        End If
    End Function

    Private Function discount() As Double


        If aaaCheckBox.Checked = True Then
            discounts = 5
        End If
        If seniorCheckBox.Checked = True Then
            discounts = discounts + 3
            discount = discounts
            discountLabel.Text = discount.ToString
            Console.WriteLine(discount)
        End If
    End Function

    Private Sub youOwe()

    End Sub

    Private Sub aaaCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles aaaCheckBox.CheckedChanged

    End Sub

    Private Sub seniorCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles seniorCheckBox.CheckedChanged

    End Sub
End Class
