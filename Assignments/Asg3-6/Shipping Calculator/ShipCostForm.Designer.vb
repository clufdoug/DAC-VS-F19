<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShipCalc
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
        Me.ShipDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.OzLabel = New System.Windows.Forms.Label()
        Me.LbsLabel = New System.Windows.Forms.Label()
        Me.WeightLabel = New System.Windows.Forms.Label()
        Me.IdLabel = New System.Windows.Forms.Label()
        Me.OzTextBox = New System.Windows.Forms.TextBox()
        Me.LbsTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ShipResultGroupBox = New System.Windows.Forms.GroupBox()
        Me.ShipCostLabel = New System.Windows.Forms.Label()
        Me.ShipCostTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ShipDetailsGroupBox.SuspendLayout()
        Me.ShipResultGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShipDetailsGroupBox
        '
        Me.ShipDetailsGroupBox.Controls.Add(Me.OzLabel)
        Me.ShipDetailsGroupBox.Controls.Add(Me.LbsLabel)
        Me.ShipDetailsGroupBox.Controls.Add(Me.WeightLabel)
        Me.ShipDetailsGroupBox.Controls.Add(Me.IdLabel)
        Me.ShipDetailsGroupBox.Controls.Add(Me.OzTextBox)
        Me.ShipDetailsGroupBox.Controls.Add(Me.LbsTextBox)
        Me.ShipDetailsGroupBox.Controls.Add(Me.IdTextBox)
        Me.ShipDetailsGroupBox.Location = New System.Drawing.Point(15, 69)
        Me.ShipDetailsGroupBox.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.ShipDetailsGroupBox.Name = "ShipDetailsGroupBox"
        Me.ShipDetailsGroupBox.Padding = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.ShipDetailsGroupBox.Size = New System.Drawing.Size(275, 200)
        Me.ShipDetailsGroupBox.TabIndex = 0
        Me.ShipDetailsGroupBox.TabStop = False
        '
        'OzLabel
        '
        Me.OzLabel.AutoSize = True
        Me.OzLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OzLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.OzLabel.Location = New System.Drawing.Point(227, 100)
        Me.OzLabel.Name = "OzLabel"
        Me.OzLabel.Size = New System.Drawing.Size(32, 18)
        Me.OzLabel.TabIndex = 6
        Me.OzLabel.Text = ".oz"
        Me.ToolTip1.SetToolTip(Me.OzLabel, "Enter weight in .oz")
        '
        'LbsLabel
        '
        Me.LbsLabel.AutoSize = True
        Me.LbsLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbsLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LbsLabel.Location = New System.Drawing.Point(116, 100)
        Me.LbsLabel.Name = "LbsLabel"
        Me.LbsLabel.Size = New System.Drawing.Size(36, 18)
        Me.LbsLabel.TabIndex = 5
        Me.LbsLabel.Text = ".lbs"
        Me.ToolTip1.SetToolTip(Me.LbsLabel, "Enter weight in .lbs")
        '
        'WeightLabel
        '
        Me.WeightLabel.AutoSize = True
        Me.WeightLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.WeightLabel.Location = New System.Drawing.Point(6, 67)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(207, 18)
        Me.WeightLabel.TabIndex = 4
        Me.WeightLabel.Text = "Package Shipping Weight"
        Me.ToolTip1.SetToolTip(Me.WeightLabel, "Enter weight in .lbs and .oz")
        '
        'IdLabel
        '
        Me.IdLabel.AutoSize = True
        Me.IdLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.IdLabel.Location = New System.Drawing.Point(5, 39)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(107, 18)
        Me.IdLabel.TabIndex = 3
        Me.IdLabel.Text = "Customer ID"
        Me.ToolTip1.SetToolTip(Me.IdLabel, "ID Code must be 6 digits")
        '
        'OzTextBox
        '
        Me.OzTextBox.Location = New System.Drawing.Point(166, 91)
        Me.OzTextBox.Name = "OzTextBox"
        Me.OzTextBox.Size = New System.Drawing.Size(60, 30)
        Me.OzTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.OzTextBox, "Enter Weight in .oz")
        '
        'LbsTextBox
        '
        Me.LbsTextBox.Location = New System.Drawing.Point(57, 91)
        Me.LbsTextBox.Name = "LbsTextBox"
        Me.LbsTextBox.Size = New System.Drawing.Size(60, 30)
        Me.LbsTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.LbsTextBox, "Enter weight in .lbs")
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(144, 30)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(121, 30)
        Me.IdTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.IdTextBox, "ID Code must be 6 digits")
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(15, 277)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(180, 60)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Returns the Cost Estimate")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ShipResultGroupBox
        '
        Me.ShipResultGroupBox.Controls.Add(Me.ShipCostLabel)
        Me.ShipResultGroupBox.Controls.Add(Me.ShipCostTextBox)
        Me.ShipResultGroupBox.Location = New System.Drawing.Point(289, 69)
        Me.ShipResultGroupBox.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.ShipResultGroupBox.Name = "ShipResultGroupBox"
        Me.ShipResultGroupBox.Padding = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.ShipResultGroupBox.Size = New System.Drawing.Size(275, 200)
        Me.ShipResultGroupBox.TabIndex = 2
        Me.ShipResultGroupBox.TabStop = False
        '
        'ShipCostLabel
        '
        Me.ShipCostLabel.AutoSize = True
        Me.ShipCostLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShipCostLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ShipCostLabel.Location = New System.Drawing.Point(37, 91)
        Me.ShipCostLabel.Name = "ShipCostLabel"
        Me.ShipCostLabel.Size = New System.Drawing.Size(188, 18)
        Me.ShipCostLabel.TabIndex = 8
        Me.ShipCostLabel.Text = "Package Shipping Cost"
        Me.ToolTip1.SetToolTip(Me.ShipCostLabel, "Press Calculate to get shipping cost")
        '
        'ShipCostTextBox
        '
        Me.ShipCostTextBox.Location = New System.Drawing.Point(9, 122)
        Me.ShipCostTextBox.Name = "ShipCostTextBox"
        Me.ShipCostTextBox.Size = New System.Drawing.Size(257, 30)
        Me.ShipCostTextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.ShipCostTextBox, "Press Calculate to get shipping cost")
        '
        'CompanyLabel
        '
        Me.CompanyLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CompanyLabel.Font = New System.Drawing.Font("Lucida Handwriting", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CompanyLabel.Location = New System.Drawing.Point(12, 9)
        Me.CompanyLabel.Name = "CompanyLabel"
        Me.CompanyLabel.Size = New System.Drawing.Size(552, 56)
        Me.CompanyLabel.TabIndex = 3
        Me.CompanyLabel.Text = "QuickShip Shipping LLC."
        Me.CompanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.CompanyLabel, "Welcome to QuickShip Shipping")
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(384, 277)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(180, 60)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit the Form")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(199, 277)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(180, 60)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear the Form")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ShipCalc
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CompanyLabel)
        Me.Controls.Add(Me.ShipResultGroupBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ShipDetailsGroupBox)
        Me.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "ShipCalc"
        Me.Text = "QuickShip Cost Calculator"
        Me.ToolTip1.SetToolTip(Me, "Welcome to QuickShip Shipping LLC.")
        Me.ShipDetailsGroupBox.ResumeLayout(False)
        Me.ShipDetailsGroupBox.PerformLayout()
        Me.ShipResultGroupBox.ResumeLayout(False)
        Me.ShipResultGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShipDetailsGroupBox As GroupBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ShipResultGroupBox As GroupBox
    Friend WithEvents CompanyLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OzLabel As Label
    Friend WithEvents LbsLabel As Label
    Friend WithEvents WeightLabel As Label
    Friend WithEvents IdLabel As Label
    Friend WithEvents OzTextBox As TextBox
    Friend WithEvents LbsTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ShipCostLabel As Label
    Friend WithEvents ShipCostTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
End Class
