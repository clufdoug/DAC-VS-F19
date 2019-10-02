<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReuseableCode
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.ThirdTextBox = New System.Windows.Forms.TextBox()
        Me.SecondTextBox = New System.Windows.Forms.TextBox()
        Me.FirstTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(523, 327)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(221, 67)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(296, 327)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(221, 67)
        Me.ClearButton.TabIndex = 0
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(69, 327)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(221, 67)
        Me.GoButton.TabIndex = 0
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.ThirdTextBox)
        Me.GroupBox.Controls.Add(Me.SecondTextBox)
        Me.GroupBox.Controls.Add(Me.FirstTextBox)
        Me.GroupBox.Location = New System.Drawing.Point(69, 33)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(675, 288)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        '
        'ThirdTextBox
        '
        Me.ThirdTextBox.Location = New System.Drawing.Point(88, 87)
        Me.ThirdTextBox.Name = "ThirdTextBox"
        Me.ThirdTextBox.Size = New System.Drawing.Size(143, 20)
        Me.ThirdTextBox.TabIndex = 0
        '
        'SecondTextBox
        '
        Me.SecondTextBox.Location = New System.Drawing.Point(88, 61)
        Me.SecondTextBox.Name = "SecondTextBox"
        Me.SecondTextBox.Size = New System.Drawing.Size(143, 20)
        Me.SecondTextBox.TabIndex = 0
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(88, 35)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(143, 20)
        Me.FirstTextBox.TabIndex = 0
        '
        'ReuseableCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "ReuseableCode"
        Me.Text = "User Data"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents GoButton As Button
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents ThirdTextBox As TextBox
    Friend WithEvents SecondTextBox As TextBox
    Friend WithEvents FirstTextBox As TextBox
End Class
