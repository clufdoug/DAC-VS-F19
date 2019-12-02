'Doug Cluff
'RCET0265
'Asg4-6
'Rental Car Form
'https://github.com/clufdoug/DAC­VS­F19/tree/master/Assignments/Asg4-6

Option Strict On
Option Explicit On

Public Class RentalForm

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

    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disables the Summary Button until input has been validated
        SummaryButton.Enabled = False
        NameTextBox.Text = "Tim Rossiter"
        AddressTextBox.Text = "2019 Mr.Roboto LN."
        CityTextBox.Text = "Chubbuck"
        StateTextBox.Text = "Idaho"
        ZipCodeTextBox.Text = "83202"
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'Handles button click to begin validation protocols
        ValidateInput()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Handles button click to clear all boxes and calculated values
        NameTextBox.Clear()
        AddressTextBox.Clear()
        CityTextBox.Clear()
        StateTextBox.Clear()
        ZipCodeTextBox.Clear()
        BeginOdometerTextBox.Clear()
        EndOdometerTextBox.Clear()
        DaysTextBox.Clear()
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

    Private Sub ValidateInput()
        'Validates the input of the text boxes
        'All errorMessage values are combined and listed on separate lines
        'boxFocus determined that the first box with the error message will be selected

        Dim errorMessage As String
        Dim boxFocus As Object
        boxFocus = ""
        errorMessage = ""

        If NameTextBox.Text = "" Then
            errorMessage = "Customer name may not be blank" & vbNewLine
            boxFocus = NameTextBox.Focus()
        End If
        If AddressTextBox.Text = "" Then
            errorMessage += "Address may not be blank" & vbNewLine
            If boxFocus Is "" Then
                boxFocus = AddressTextBox.Focus()
            End If
        End If
        If CityTextBox.Text = "" Then
            errorMessage += "City may not be blank" & vbNewLine
            If boxFocus Is "" Then
                boxFocus = CityTextBox.Focus()
            End If

        End If
        If StateTextBox.Text = "" Then
            errorMessage += "State may not be blank" & vbNewLine
            If boxFocus Is "" Then
                boxFocus = StateTextBox.Focus()
            End If

        End If
        Try
            Integer.Parse(ZipCodeTextBox.Text)
        Catch ex As Exception
            errorMessage += "Zip code must be a number" & vbNewLine
            ZipCodeTextBox.Clear()
            If boxFocus Is "" Then
                boxFocus = ZipCodeTextBox.Focus()
            End If
        End Try
        Try
            Integer.Parse(BeginOdometerTextBox.Text)
        Catch ex As Exception
            errorMessage += "Beginning Odometer Reading must be a number" & vbNewLine
            BeginOdometerTextBox.Clear()
            If boxFocus Is "" Then
                boxFocus = BeginOdometerTextBox.Focus()
            End If
        End Try
        Try
            Integer.Parse(EndOdometerTextBox.Text)
        Catch ex As Exception
            errorMessage += "Ending Odometer Reading must be a number" & vbNewLine
            EndOdometerTextBox.Clear()
            If boxFocus Is "" Then
                boxFocus = EndOdometerTextBox.Focus()
            End If
        End Try
        Try
            Integer.Parse(DaysTextBox.Text)
        Catch ex As Exception
            errorMessage += "Number of Days must be a number" & vbNewLine
            DaysTextBox.Clear()
            If boxFocus Is "" Then
                boxFocus = DaysTextBox.Focus()
            End If
        End Try

        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Input Error")
            boxFocus.ToString()
        Else
            'If all checked values pass validation the following subs and functions
            'will calculate And return values.
            MilesDriven()
            MileCharge()
            DayCharge()
            Discount()
            YouOwe()
            Total()
            SummaryButton.Enabled = True
        End If

    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        'Displays the number of customers and the daily totals in a messagebox
        MessageBox.Show("Daily Totals" & vbNewLine & "Customers = " & totalcustomers & vbNewLine _
                         & "Miles = " & totalmiles & vbNewLine _
                         & "Sales = " & totalsales.ToString("C"))
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exits the program
        If MessageBox.Show("Do you want to Exit?" & vbNewLine & "All Data Will be lost.", "Exit Program?",
        MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If

    End Sub

    Private Function MilesDriven() As Double
        'Validates the miles driven and converts if data is in Kilometers.
        Try
            beginOdometer = Double.Parse(BeginOdometerTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Odometer Values must be a number", "Input Error")
            BeginOdometerTextBox.Clear()
            BeginOdometerTextBox.Focus()
        End Try
        Try
            endOdometer = Double.Parse(EndOdometerTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Odometer Values must be a number", "Input Error")
            EndOdometerTextBox.Clear()
            EndOdometerTextBox.Focus()
        End Try
        If kilometersRadioButton.Checked = True Then
            MilesDriven = ((endOdometer - beginOdometer) * 0.62)
        ElseIf milesRadioButton.Checked = True Then
            MilesDriven = endOdometer - beginOdometer
        End If
        milesDrivenLabel.Text = MilesDriven.ToString
        'Console.WriteLine(milesDriven)
    End Function

    Private Function MileCharge() As Double
        'Calculates the rate based on miles traveled
        If MilesDriven() <= 200 Then
            MileCharge = 0
        ElseIf MilesDriven() > 200 And MilesDriven() <= 500 Then
            MileCharge = (MilesDriven() - 200) * 0.12
        ElseIf MilesDriven() > 500 Then
            MileCharge = ((MilesDriven() - 500) * 0.1) + (300 * 0.12)
        End If
        mileChargeLabel.Text = MileCharge.ToString("C")
        'Console.WriteLine(mileCharge)

    End Function

    Private Function DayCharge() As Double
        'Validates the number of days and charges based on a $15 daily charge 
        If Integer.Parse(DaysTextBox.Text) = 0 Or Integer.Parse(DaysTextBox.Text) > 45 Then
            MessageBox.Show("Days must be greater than 0 and less than 45", "Input Error")
            DaysTextBox.Clear()
            DaysTextBox.Focus()
        Else
            DayCharge = Integer.Parse(DaysTextBox.Text) * 15.0
        End If
        dayChargeLabel.Text = DayCharge.ToString("C")
        Console.WriteLine(DayCharge)
    End Function

    Private Function Discount() As Double
        'Applies the any applicable discounts to the total
        Discount = 0
        If aaaCheckBox.Checked = True Then
            Discount = (0.05 * (MileCharge() + DayCharge()))
        End If
        If seniorCheckBox.Checked = True Then
            Discount += (0.03 * (MileCharge() + DayCharge()))
        End If
        discountLabel.Text = Discount.ToString("C")
        Console.WriteLine(Discount)
    End Function

    Private Function YouOwe() As Double
        'Returns the total charge minus any discounts
        YouOwe = MileCharge() + DayCharge() - Discount()
        youOweLabel.Text = YouOwe.ToString("C")
        Console.WriteLine(YouOwe)
    End Function

    Private Sub Total()
        totalcustomers += 1
        totalmiles += MilesDriven()
        totalsales += YouOwe()
    End Sub

End Class
