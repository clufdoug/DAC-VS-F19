'Doug Cluff
'RCET0265
'Asg4-1
'Math Contest Form
'https://github.com/clufdoug/DAC­VS­F19/tree/master/Assignments/Asg4-6

Option Strict On
Option Explicit On

Public Class rentalForm

    Dim beginOdometer As Double
    Dim endOdometer As Double
    Dim custName As String
    Dim custAddress As String
    Dim custCity As String
    Dim custState As String
    Dim custZip As Integer
    Dim days As Integer
    Dim totalcustomers As Integer
    Dim totalmiles As Double
    Dim totalsales As Double
    Private Sub rentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        summaryButton.Enabled = False

    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        validateInput()

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        nameTextBox.Clear()
        addressTextBox.Clear()
        cityTextBox.Clear()
        stateTextBox.Clear()
        zipCodeTextBox.Clear()
        beginOdometerTextBox.Clear()
        endOdometerTextBox.Clear()
        daysTextBox.Clear()
        milesDrivenLabel.Text = ""
        mileChargeLabel.Text = ""
        dayChargeLabel.Text = ""
        discountLabel.Text = ""
        youOweLabel.Text = ""
        milesRadioButton.Enabled = True
        kilometersRadioButton.Enabled = False
        aaaCheckBox.Enabled = False
        seniorCheckBox.Enabled = False
    End Sub

    Private Sub validateInput()
        If nameTextBox.Text = "" Then
            MessageBox.Show("Customer name may not be blank", "Input Error")
            nameTextBox.Focus()
        End If
        If addressTextBox.Text = "" Then
            MessageBox.Show("Address may not be blank", "Input Error")
            addressTextBox.Focus()
        End If
        If cityTextBox.Text = "" Then
            MessageBox.Show("City may not be blank", "Input Error")
            cityTextBox.Focus()
        End If
        If stateTextBox.Text = "" Then
            MessageBox.Show("State may not be blank", "Input Error")
        End If
        Try
            Integer.Parse(zipCodeTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Zip code must be a number", "Input Error")
            zipCodeTextBox.Clear()
            zipCodeTextBox.Focus()
        End Try
        Try
            Integer.Parse(beginOdometerTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Beginning Odometer Reading must be a number", "Input Error")
            beginOdometerTextBox.Clear()
            beginOdometerTextBox.Focus()
        End Try
        Try
            Integer.Parse(endOdometerTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Ending Odometer Reading must be a number", "Input Error")
            endOdometerTextBox.Clear()
            endOdometerTextBox.Focus()
        End Try
        Try
            Integer.Parse(daysTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Number of Days must be a number", "Input Error")
            daysTextBox.Clear()
            daysTextBox.Focus()
        End Try

        milesDriven()
        mileCharge()
        dayCharge()
        discount()
        youOwe()
        total()
        summaryButton.Enabled = True

    End Sub
    Private Sub summaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        MessageBox.Show("Daily Totals" & vbNewLine & "Customers = " & totalcustomers & vbNewLine _
                         & "Miles = " & totalmiles & vbNewLine _
                         & "Sales = " & totalsales.ToString("C"))
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Function milesDriven() As Double
        Try
            beginOdometer = Double.Parse(beginOdometerTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Zip code must be a number", "Input Error")
            beginOdometerTextBox.Clear()
            beginOdometerTextBox.Focus()
        End Try
        Try
            endOdometer = Double.Parse(endOdometerTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Zip code must be a number", "Input Error")
            endOdometerTextBox.Clear()
            endOdometerTextBox.Focus()
        End Try
        If kilometersRadioButton.Checked = True Then
            milesDriven = ((endOdometer - beginOdometer) * 0.62)
        ElseIf milesRadioButton.Checked = True Then
            milesDriven = endOdometer - beginOdometer
        End If
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
        mileChargeLabel.Text = mileCharge.ToString("C")
        'Console.WriteLine(mileCharge)

    End Function

    Private Function dayCharge() As Double
        If Integer.Parse(daysTextBox.Text) = 0 Or Integer.Parse(daysTextBox.Text) > 45 Then
            MessageBox.Show("Days must be greater than 0 and less than 45", "Input Error")
            daysTextBox.Clear()
            daysTextBox.Focus()
        Else
            dayCharge = Integer.Parse(daysTextBox.Text) * 15.0
        End If
        dayChargeLabel.Text = dayCharge.ToString("C")
        Console.WriteLine(dayCharge)
    End Function

    Private Function discount() As Double
        discount = 0

        If aaaCheckBox.Checked = True Then
            discount = (0.05 * (mileCharge() + dayCharge()))
        End If
        If seniorCheckBox.Checked = True Then
            discount += (0.03 * (mileCharge() + dayCharge()))
        End If

        discountLabel.Text = discount.ToString("C")
        Console.WriteLine(discount)
    End Function

    Private Function youOwe() As Double
        youOwe = mileCharge() + dayCharge() - discount()
        youOweLabel.Text = youOwe.ToString("C")
        Console.WriteLine(youOwe)
    End Function

    Private Sub total()
        totalcustomers += 1
        totalmiles += milesDriven()
        totalsales += youOwe()

    End Sub


End Class
