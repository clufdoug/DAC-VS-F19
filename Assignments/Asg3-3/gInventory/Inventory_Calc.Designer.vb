<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryCalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BegInvTextBox = New System.Windows.Forms.TextBox()
        Me.BegInvLabel = New System.Windows.Forms.Label()
        Me.EndInvLabel = New System.Windows.Forms.Label()
        Me.EndInvTextBox = New System.Windows.Forms.TextBox()
        Me.GoodSoldLabel = New System.Windows.Forms.Label()
        Me.GoodSoldTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ResultGroupBox = New System.Windows.Forms.GroupBox()
        Me.AvgInvTextBox = New System.Windows.Forms.TextBox()
        Me.AvgInvLabel = New System.Windows.Forms.Label()
        Me.TurnoverLabel = New System.Windows.Forms.Label()
        Me.TurnoverTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.ResultGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'BegInvTextBox
        '
        Me.BegInvTextBox.Location = New System.Drawing.Point(188, 27)
        Me.BegInvTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.BegInvTextBox.Name = "BegInvTextBox"
        Me.BegInvTextBox.Size = New System.Drawing.Size(164, 26)
        Me.BegInvTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BegInvTextBox, "Enter the Beginning Inventory")
        '
        'BegInvLabel
        '
        Me.BegInvLabel.Location = New System.Drawing.Point(12, 30)
        Me.BegInvLabel.Name = "BegInvLabel"
        Me.BegInvLabel.Size = New System.Drawing.Size(168, 23)
        Me.BegInvLabel.TabIndex = 1
        Me.BegInvLabel.Text = "Beginning Inventory"
        Me.BegInvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.BegInvLabel, "Enter the Beginning Inventory")
        '
        'EndInvLabel
        '
        Me.EndInvLabel.Location = New System.Drawing.Point(12, 66)
        Me.EndInvLabel.Name = "EndInvLabel"
        Me.EndInvLabel.Size = New System.Drawing.Size(168, 23)
        Me.EndInvLabel.TabIndex = 3
        Me.EndInvLabel.Text = "Ending Inventory"
        Me.EndInvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.EndInvLabel, "Enter the Ending Inventory")
        '
        'EndInvTextBox
        '
        Me.EndInvTextBox.Location = New System.Drawing.Point(188, 63)
        Me.EndInvTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.EndInvTextBox.Name = "EndInvTextBox"
        Me.EndInvTextBox.Size = New System.Drawing.Size(164, 26)
        Me.EndInvTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EndInvTextBox, "Enter the Ending Inventory")
        '
        'GoodSoldLabel
        '
        Me.GoodSoldLabel.Location = New System.Drawing.Point(12, 102)
        Me.GoodSoldLabel.Name = "GoodSoldLabel"
        Me.GoodSoldLabel.Size = New System.Drawing.Size(168, 23)
        Me.GoodSoldLabel.TabIndex = 5
        Me.GoodSoldLabel.Text = "Cost of Goods Sold"
        Me.GoodSoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.GoodSoldLabel, "Enter the Cost of the Goods")
        '
        'GoodSoldTextBox
        '
        Me.GoodSoldTextBox.Location = New System.Drawing.Point(188, 99)
        Me.GoodSoldTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.GoodSoldTextBox.Name = "GoodSoldTextBox"
        Me.GoodSoldTextBox.Size = New System.Drawing.Size(164, 26)
        Me.GoodSoldTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.GoodSoldTextBox, "Enter the Cost of the Goods")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BegInvTextBox)
        Me.GroupBox1.Controls.Add(Me.GoodSoldLabel)
        Me.GroupBox1.Controls.Add(Me.BegInvLabel)
        Me.GroupBox1.Controls.Add(Me.GoodSoldTextBox)
        Me.GroupBox1.Controls.Add(Me.EndInvTextBox)
        Me.GroupBox1.Controls.Add(Me.EndInvLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 157)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory Input"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Enter Values and press the Calculate button")
        '
        'ResultGroupBox
        '
        Me.ResultGroupBox.Controls.Add(Me.AvgInvTextBox)
        Me.ResultGroupBox.Controls.Add(Me.AvgInvLabel)
        Me.ResultGroupBox.Controls.Add(Me.TurnoverLabel)
        Me.ResultGroupBox.Controls.Add(Me.TurnoverTextBox)
        Me.ResultGroupBox.Location = New System.Drawing.Point(12, 228)
        Me.ResultGroupBox.Name = "ResultGroupBox"
        Me.ResultGroupBox.Size = New System.Drawing.Size(360, 157)
        Me.ResultGroupBox.TabIndex = 7
        Me.ResultGroupBox.TabStop = False
        Me.ResultGroupBox.Text = "Inventory Result"
        Me.ToolTip1.SetToolTip(Me.ResultGroupBox, "Enter Values and press the Calculate button")
        '
        'AvgInvTextBox
        '
        Me.AvgInvTextBox.Location = New System.Drawing.Point(188, 27)
        Me.AvgInvTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.AvgInvTextBox.Name = "AvgInvTextBox"
        Me.AvgInvTextBox.Size = New System.Drawing.Size(164, 26)
        Me.AvgInvTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.AvgInvTextBox, "The average value of inventory")
        '
        'AvgInvLabel
        '
        Me.AvgInvLabel.Location = New System.Drawing.Point(12, 30)
        Me.AvgInvLabel.Name = "AvgInvLabel"
        Me.AvgInvLabel.Size = New System.Drawing.Size(168, 23)
        Me.AvgInvLabel.TabIndex = 1
        Me.AvgInvLabel.Text = "Average Inventory"
        Me.AvgInvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.AvgInvLabel, "The average value of inventory")
        '
        'TurnoverLabel
        '
        Me.TurnoverLabel.Location = New System.Drawing.Point(12, 66)
        Me.TurnoverLabel.Name = "TurnoverLabel"
        Me.TurnoverLabel.Size = New System.Drawing.Size(168, 23)
        Me.TurnoverLabel.TabIndex = 3
        Me.TurnoverLabel.Text = "Turnover"
        Me.TurnoverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.TurnoverLabel, "Cost of Goods vs. Average inventory")
        '
        'TurnoverTextBox
        '
        Me.TurnoverTextBox.Location = New System.Drawing.Point(188, 63)
        Me.TurnoverTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.TurnoverTextBox.Name = "TurnoverTextBox"
        Me.TurnoverTextBox.Size = New System.Drawing.Size(164, 26)
        Me.TurnoverTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.TurnoverTextBox, "Cost of Goods vs. Average inventory")
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(12, 399)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(110, 50)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculates and populates the result boxes")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(262, 399)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(110, 50)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exits the Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(128, 399)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(110, 50)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clears the Inventory Values")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'InventoryCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ResultGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "InventoryCalc"
        Me.Text = "Inventory Control"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResultGroupBox.ResumeLayout(False)
        Me.ResultGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BegInvTextBox As TextBox
    Friend WithEvents BegInvLabel As Label
    Friend WithEvents EndInvLabel As Label
    Friend WithEvents EndInvTextBox As TextBox
    Friend WithEvents GoodSoldLabel As Label
    Friend WithEvents GoodSoldTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ResultGroupBox As GroupBox
    Friend WithEvents AvgInvTextBox As TextBox
    Friend WithEvents AvgInvLabel As Label
    Friend WithEvents TurnoverTextBox As TextBox
    Friend WithEvents TurnoverLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
