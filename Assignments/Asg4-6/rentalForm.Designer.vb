<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentalForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.BeginningOdometerLabel = New System.Windows.Forms.Label()
        Me.EndingOdometerLabel = New System.Windows.Forms.Label()
        Me.DayCountLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.BeginOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.EndOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.DaysTextBox = New System.Windows.Forms.TextBox()
        Me.OdometerGroupBox = New System.Windows.Forms.GroupBox()
        Me.kilometersRadioButton = New System.Windows.Forms.RadioButton()
        Me.milesRadioButton = New System.Windows.Forms.RadioButton()
        Me.DiscountGroupBox = New System.Windows.Forms.GroupBox()
        Me.seniorCheckBox = New System.Windows.Forms.CheckBox()
        Me.aaaCheckBox = New System.Windows.Forms.CheckBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.milesDrivenLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mileChargeLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dayChargeLabel = New System.Windows.Forms.Label()
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.youOweLabel = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OdometerGroupBox.SuspendLayout()
        Me.DiscountGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Location = New System.Drawing.Point(8, 20)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(82, 13)
        Me.CustomerNameLabel.TabIndex = 0
        Me.CustomerNameLabel.Text = "Customer &Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(8, 48)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(45, 13)
        Me.AddressLabel.TabIndex = 2
        Me.AddressLabel.Text = "&Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(8, 76)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(24, 13)
        Me.CityLabel.TabIndex = 4
        Me.CityLabel.Text = "C&ity"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(8, 104)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(32, 13)
        Me.StateLabel.TabIndex = 6
        Me.StateLabel.Text = "&State"
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(8, 132)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(50, 13)
        Me.ZipCodeLabel.TabIndex = 8
        Me.ZipCodeLabel.Text = "&Zip Code"
        '
        'BeginningOdometerLabel
        '
        Me.BeginningOdometerLabel.AutoSize = True
        Me.BeginningOdometerLabel.Location = New System.Drawing.Point(8, 160)
        Me.BeginningOdometerLabel.Name = "BeginningOdometerLabel"
        Me.BeginningOdometerLabel.Size = New System.Drawing.Size(146, 13)
        Me.BeginningOdometerLabel.TabIndex = 10
        Me.BeginningOdometerLabel.Text = "&Beginning Odometer Reading"
        '
        'EndingOdometerLabel
        '
        Me.EndingOdometerLabel.AutoSize = True
        Me.EndingOdometerLabel.Location = New System.Drawing.Point(8, 188)
        Me.EndingOdometerLabel.Name = "EndingOdometerLabel"
        Me.EndingOdometerLabel.Size = New System.Drawing.Size(132, 13)
        Me.EndingOdometerLabel.TabIndex = 12
        Me.EndingOdometerLabel.Text = "&Ending Odometer Reading"
        '
        'DayCountLabel
        '
        Me.DayCountLabel.AutoSize = True
        Me.DayCountLabel.Location = New System.Drawing.Point(8, 216)
        Me.DayCountLabel.Name = "DayCountLabel"
        Me.DayCountLabel.Size = New System.Drawing.Size(83, 13)
        Me.DayCountLabel.TabIndex = 14
        Me.DayCountLabel.Text = "N&umber of Days"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(160, 16)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Enter the name of the customer.")
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(160, 44)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.AddressTextBox, "Enter the address of the customer.")
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(160, 72)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.CityTextBox, "Enter the customers City.")
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(160, 100)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StateTextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.StateTextBox, "Enter the customers State.")
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(160, 128)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipCodeTextBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.ZipCodeTextBox, "Enter the customers Zip Code.")
        '
        'BeginOdometerTextBox
        '
        Me.BeginOdometerTextBox.Location = New System.Drawing.Point(160, 156)
        Me.BeginOdometerTextBox.Name = "BeginOdometerTextBox"
        Me.BeginOdometerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BeginOdometerTextBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.BeginOdometerTextBox, "Enter the initial odometer reading.")
        '
        'EndOdometerTextBox
        '
        Me.EndOdometerTextBox.Location = New System.Drawing.Point(160, 184)
        Me.EndOdometerTextBox.Name = "EndOdometerTextBox"
        Me.EndOdometerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EndOdometerTextBox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.EndOdometerTextBox, "Enter the final odometer reading.")
        '
        'DaysTextBox
        '
        Me.DaysTextBox.Location = New System.Drawing.Point(160, 212)
        Me.DaysTextBox.Name = "DaysTextBox"
        Me.DaysTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DaysTextBox.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.DaysTextBox, "Enter the number of rental days.")
        '
        'OdometerGroupBox
        '
        Me.OdometerGroupBox.Controls.Add(Me.kilometersRadioButton)
        Me.OdometerGroupBox.Controls.Add(Me.milesRadioButton)
        Me.OdometerGroupBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OdometerGroupBox.Location = New System.Drawing.Point(8, 244)
        Me.OdometerGroupBox.Name = "OdometerGroupBox"
        Me.OdometerGroupBox.Size = New System.Drawing.Size(312, 84)
        Me.OdometerGroupBox.TabIndex = 16
        Me.OdometerGroupBox.TabStop = False
        Me.OdometerGroupBox.Text = "Is Odometer in Miles or Kilometers?"
        Me.ToolTip1.SetToolTip(Me.OdometerGroupBox, "Is odometer reading in miles or kilometers?")
        '
        'kilometersRadioButton
        '
        Me.kilometersRadioButton.AutoSize = True
        Me.kilometersRadioButton.Location = New System.Drawing.Point(20, 52)
        Me.kilometersRadioButton.Name = "kilometersRadioButton"
        Me.kilometersRadioButton.Size = New System.Drawing.Size(106, 20)
        Me.kilometersRadioButton.TabIndex = 1
        Me.kilometersRadioButton.Text = "&Kilometers"
        Me.kilometersRadioButton.UseVisualStyleBackColor = True
        '
        'milesRadioButton
        '
        Me.milesRadioButton.AutoSize = True
        Me.milesRadioButton.Checked = True
        Me.milesRadioButton.Location = New System.Drawing.Point(20, 24)
        Me.milesRadioButton.Name = "milesRadioButton"
        Me.milesRadioButton.Size = New System.Drawing.Size(66, 20)
        Me.milesRadioButton.TabIndex = 0
        Me.milesRadioButton.TabStop = True
        Me.milesRadioButton.Text = "&Miles"
        Me.milesRadioButton.UseVisualStyleBackColor = True
        '
        'DiscountGroupBox
        '
        Me.DiscountGroupBox.Controls.Add(Me.seniorCheckBox)
        Me.DiscountGroupBox.Controls.Add(Me.aaaCheckBox)
        Me.DiscountGroupBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountGroupBox.Location = New System.Drawing.Point(352, 244)
        Me.DiscountGroupBox.Name = "DiscountGroupBox"
        Me.DiscountGroupBox.Size = New System.Drawing.Size(240, 84)
        Me.DiscountGroupBox.TabIndex = 17
        Me.DiscountGroupBox.TabStop = False
        Me.DiscountGroupBox.Text = "Enter Any Discounts"
        '
        'seniorCheckBox
        '
        Me.seniorCheckBox.AutoSize = True
        Me.seniorCheckBox.Location = New System.Drawing.Point(20, 56)
        Me.seniorCheckBox.Name = "seniorCheckBox"
        Me.seniorCheckBox.Size = New System.Drawing.Size(211, 20)
        Me.seniorCheckBox.TabIndex = 1
        Me.seniorCheckBox.Text = "Seni&or Citizen Discount"
        Me.ToolTip1.SetToolTip(Me.seniorCheckBox, "3% Senior Discount")
        Me.seniorCheckBox.UseVisualStyleBackColor = True
        '
        'aaaCheckBox
        '
        Me.aaaCheckBox.AutoSize = True
        Me.aaaCheckBox.Location = New System.Drawing.Point(20, 28)
        Me.aaaCheckBox.Name = "aaaCheckBox"
        Me.aaaCheckBox.Size = New System.Drawing.Size(179, 20)
        Me.aaaCheckBox.TabIndex = 0
        Me.aaaCheckBox.Text = "AAA Member &Discount"
        Me.ToolTip1.SetToolTip(Me.aaaCheckBox, "5% AAA discount")
        Me.aaaCheckBox.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(128, 380)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 18
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Enter Calculations")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(220, 380)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 19
        Me.ClearButton.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear the Form")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(408, 380)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 20
        Me.ExitButton.TabStop = False
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit the form.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(292, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Distance Driven In Miles"
        '
        'milesDrivenLabel
        '
        Me.milesDrivenLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.milesDrivenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.milesDrivenLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.milesDrivenLabel.Location = New System.Drawing.Point(504, 16)
        Me.milesDrivenLabel.Name = "milesDrivenLabel"
        Me.milesDrivenLabel.Size = New System.Drawing.Size(128, 24)
        Me.milesDrivenLabel.TabIndex = 23
        Me.milesDrivenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.milesDrivenLabel, "Miles based on odometer readings.")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(292, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Mileage Charge"
        '
        'mileChargeLabel
        '
        Me.mileChargeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mileChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mileChargeLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.mileChargeLabel.Location = New System.Drawing.Point(504, 48)
        Me.mileChargeLabel.Name = "mileChargeLabel"
        Me.mileChargeLabel.Size = New System.Drawing.Size(128, 24)
        Me.mileChargeLabel.TabIndex = 25
        Me.mileChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.mileChargeLabel, "Cost based on distances.")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(292, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Day Charge"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(292, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Minus Discount"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(292, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "You Owe"
        '
        'dayChargeLabel
        '
        Me.dayChargeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dayChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dayChargeLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.dayChargeLabel.Location = New System.Drawing.Point(504, 80)
        Me.dayChargeLabel.Name = "dayChargeLabel"
        Me.dayChargeLabel.Size = New System.Drawing.Size(128, 24)
        Me.dayChargeLabel.TabIndex = 27
        Me.dayChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.dayChargeLabel, "Charge for number of days.")
        '
        'discountLabel
        '
        Me.discountLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discountLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.discountLabel.Location = New System.Drawing.Point(504, 112)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(128, 24)
        Me.discountLabel.TabIndex = 29
        Me.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.discountLabel, "Discounts applied (select below)")
        '
        'youOweLabel
        '
        Me.youOweLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.youOweLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.youOweLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.youOweLabel.Location = New System.Drawing.Point(504, 144)
        Me.youOweLabel.Name = "youOweLabel"
        Me.youOweLabel.Size = New System.Drawing.Size(128, 24)
        Me.youOweLabel.TabIndex = 31
        Me.youOweLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.youOweLabel, "Balance due for rental.")
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(272, 184)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(372, 3)
        Me.Label18.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(272, 4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(3, 180)
        Me.Label19.TabIndex = 21
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(316, 380)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(75, 23)
        Me.SummaryButton.TabIndex = 33
        Me.SummaryButton.Text = "Summar&y"
        Me.ToolTip1.SetToolTip(Me.SummaryButton, "Print Summary")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'rentalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 437)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.youOweLabel)
        Me.Controls.Add(Me.discountLabel)
        Me.Controls.Add(Me.dayChargeLabel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.mileChargeLabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.milesDrivenLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.DiscountGroupBox)
        Me.Controls.Add(Me.OdometerGroupBox)
        Me.Controls.Add(Me.DaysTextBox)
        Me.Controls.Add(Me.EndOdometerTextBox)
        Me.Controls.Add(Me.BeginOdometerTextBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.DayCountLabel)
        Me.Controls.Add(Me.EndingOdometerLabel)
        Me.Controls.Add(Me.BeginningOdometerLabel)
        Me.Controls.Add(Me.ZipCodeLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.CustomerNameLabel)
        Me.Name = "rentalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acme Car Rental Service"
        Me.OdometerGroupBox.ResumeLayout(False)
        Me.OdometerGroupBox.PerformLayout()
        Me.DiscountGroupBox.ResumeLayout(False)
        Me.DiscountGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerNameLabel As System.Windows.Forms.Label
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents CityLabel As System.Windows.Forms.Label
    Friend WithEvents StateLabel As System.Windows.Forms.Label
    Friend WithEvents ZipCodeLabel As System.Windows.Forms.Label
    Friend WithEvents BeginningOdometerLabel As System.Windows.Forms.Label
    Friend WithEvents EndingOdometerLabel As System.Windows.Forms.Label
    Friend WithEvents DayCountLabel As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BeginOdometerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndOdometerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OdometerGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents kilometersRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents milesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DiscountGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents seniorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents aaaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents milesDrivenLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents mileChargeLabel As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dayChargeLabel As System.Windows.Forms.Label
    Friend WithEvents discountLabel As System.Windows.Forms.Label
    Friend WithEvents youOweLabel As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SummaryButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
