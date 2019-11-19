<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContestForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondLabel = New System.Windows.Forms.Label()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstLabel = New System.Windows.Forms.Label()
        Me.DivideButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyButton = New System.Windows.Forms.RadioButton()
        Me.SubtractButton = New System.Windows.Forms.RadioButton()
        Me.AnswerGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ValidateTextBox = New System.Windows.Forms.TextBox()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.AnswerGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.GradeTextBox)
        Me.GroupBox1.Controls.Add(Me.GradeLabel)
        Me.GroupBox1.Controls.Add(Me.AgeTextBox)
        Me.GroupBox1.Controls.Add(Me.AgeLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.NameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(400, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Student information")
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(301, 47)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(49, 26)
        Me.GradeTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.GradeTextBox, "Enter Student Grade")
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(298, 24)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(54, 20)
        Me.GradeLabel.TabIndex = 4
        Me.GradeLabel.Text = "Grade"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(230, 47)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(49, 26)
        Me.AgeTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.AgeTextBox, "Enter Student Age")
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(236, 24)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 2
        Me.AgeLabel.Text = "Age"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(7, 47)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(197, 26)
        Me.NameTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Enter Student Name")
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(7, 24)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(51, 20)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'AddButton
        '
        Me.AddButton.AutoSize = True
        Me.AddButton.Location = New System.Drawing.Point(145, 29)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(85, 24)
        Me.AddButton.TabIndex = 3
        Me.AddButton.TabStop = True
        Me.AddButton.Text = "Addition"
        Me.ToolTip1.SetToolTip(Me.AddButton, "Select for addition")
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.SecondNumberTextBox)
        Me.GroupBox2.Controls.Add(Me.SecondLabel)
        Me.GroupBox2.Controls.Add(Me.FirstNumberTextBox)
        Me.GroupBox2.Controls.Add(Me.FirstLabel)
        Me.GroupBox2.Controls.Add(Me.DivideButton)
        Me.GroupBox2.Controls.Add(Me.MultiplyButton)
        Me.GroupBox2.Controls.Add(Me.SubtractButton)
        Me.GroupBox2.Controls.Add(Me.AddButton)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 128)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(400, 175)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Math Problem"
        Me.ToolTip1.SetToolTip(Me.GroupBox2, "Equation Generator")
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SecondNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(279, 71)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.ReadOnly = True
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(77, 49)
        Me.SecondNumberTextBox.TabIndex = 8
        Me.SecondNumberTextBox.TabStop = False
        Me.SecondNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.SecondNumberTextBox, "2nd value in equation")
        '
        'SecondLabel
        '
        Me.SecondLabel.AutoSize = True
        Me.SecondLabel.Location = New System.Drawing.Point(272, 41)
        Me.SecondLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SecondLabel.Name = "SecondLabel"
        Me.SecondLabel.Size = New System.Drawing.Size(96, 20)
        Me.SecondLabel.TabIndex = 7
        Me.SecondLabel.Text = "2nd Number"
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.FirstNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(34, 71)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.ReadOnly = True
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(77, 49)
        Me.FirstNumberTextBox.TabIndex = 6
        Me.FirstNumberTextBox.TabStop = False
        Me.FirstNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.FirstNumberTextBox, "1st Value in equation")
        '
        'FirstLabel
        '
        Me.FirstLabel.AutoSize = True
        Me.FirstLabel.Location = New System.Drawing.Point(27, 41)
        Me.FirstLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FirstLabel.Name = "FirstLabel"
        Me.FirstLabel.Size = New System.Drawing.Size(91, 20)
        Me.FirstLabel.TabIndex = 5
        Me.FirstLabel.Text = "1st Number"
        '
        'DivideButton
        '
        Me.DivideButton.AutoSize = True
        Me.DivideButton.Location = New System.Drawing.Point(145, 131)
        Me.DivideButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DivideButton.Name = "DivideButton"
        Me.DivideButton.Size = New System.Drawing.Size(70, 24)
        Me.DivideButton.TabIndex = 6
        Me.DivideButton.TabStop = True
        Me.DivideButton.Text = "Divide"
        Me.ToolTip1.SetToolTip(Me.DivideButton, "Select for division")
        Me.DivideButton.UseVisualStyleBackColor = True
        '
        'MultiplyButton
        '
        Me.MultiplyButton.AutoSize = True
        Me.MultiplyButton.Location = New System.Drawing.Point(145, 97)
        Me.MultiplyButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MultiplyButton.Name = "MultiplyButton"
        Me.MultiplyButton.Size = New System.Drawing.Size(79, 24)
        Me.MultiplyButton.TabIndex = 5
        Me.MultiplyButton.TabStop = True
        Me.MultiplyButton.Text = "Multiply"
        Me.ToolTip1.SetToolTip(Me.MultiplyButton, "Select for multiplication")
        Me.MultiplyButton.UseVisualStyleBackColor = True
        '
        'SubtractButton
        '
        Me.SubtractButton.AutoSize = True
        Me.SubtractButton.Location = New System.Drawing.Point(145, 63)
        Me.SubtractButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(109, 24)
        Me.SubtractButton.TabIndex = 4
        Me.SubtractButton.TabStop = True
        Me.SubtractButton.Text = "Subtraction"
        Me.ToolTip1.SetToolTip(Me.SubtractButton, "Select for Subtraction")
        Me.SubtractButton.UseVisualStyleBackColor = True
        '
        'AnswerGroupBox
        '
        Me.AnswerGroupBox.BackColor = System.Drawing.SystemColors.Control
        Me.AnswerGroupBox.Controls.Add(Me.Label1)
        Me.AnswerGroupBox.Controls.Add(Me.AnswerTextBox)
        Me.AnswerGroupBox.Location = New System.Drawing.Point(18, 313)
        Me.AnswerGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AnswerGroupBox.Name = "AnswerGroupBox"
        Me.AnswerGroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AnswerGroupBox.Size = New System.Drawing.Size(400, 125)
        Me.AnswerGroupBox.TabIndex = 3
        Me.AnswerGroupBox.TabStop = False
        Me.AnswerGroupBox.Text = "Student Answer"
        Me.ToolTip1.SetToolTip(Me.AnswerGroupBox, "Please solve equation")
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Location = New System.Drawing.Point(205, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "="
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Location = New System.Drawing.Point(230, 59)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(100, 26)
        Me.AnswerTextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.AnswerTextBox, "Enter your answer")
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(428, 18)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(169, 44)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear the form")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ValidateTextBox
        '
        Me.ValidateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ValidateTextBox.Location = New System.Drawing.Point(426, 70)
        Me.ValidateTextBox.Multiline = True
        Me.ValidateTextBox.Name = "ValidateTextBox"
        Me.ValidateTextBox.ReadOnly = True
        Me.ValidateTextBox.Size = New System.Drawing.Size(346, 318)
        Me.ValidateTextBox.TabIndex = 5
        Me.ValidateTextBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ValidateTextBox, "Test Record")
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(603, 18)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(169, 44)
        Me.SummaryButton.TabIndex = 10
        Me.SummaryButton.Text = "Summary"
        Me.ToolTip1.SetToolTip(Me.SummaryButton, "Print summary of problems")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(603, 394)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(169, 44)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit Form")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(428, 394)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(169, 44)
        Me.SubmitButton.TabIndex = 8
        Me.SubmitButton.Text = "&Submit"
        Me.ToolTip1.SetToolTip(Me.SubmitButton, "Submit answer")
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ContestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ValidateTextBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.AnswerGroupBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ContestForm"
        Me.Text = "Math Contest"
        Me.ToolTip1.SetToolTip(Me, "Enter Student Information to begin")
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.AnswerGroupBox.ResumeLayout(False)
        Me.AnswerGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents SecondLabel As Label
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents FirstLabel As Label
    Friend WithEvents DivideButton As RadioButton
    Friend WithEvents MultiplyButton As RadioButton
    Friend WithEvents SubtractButton As RadioButton
    Friend WithEvents AnswerGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents ValidateTextBox As TextBox
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
