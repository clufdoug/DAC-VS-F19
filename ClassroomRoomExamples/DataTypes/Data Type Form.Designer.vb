<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.firstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.secondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.resultTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(583, 359)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(155, 63)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'firstNumberTextBox
        '
        Me.firstNumberTextBox.Location = New System.Drawing.Point(163, 56)
        Me.firstNumberTextBox.Name = "firstNumberTextBox"
        Me.firstNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.firstNumberTextBox.TabIndex = 2
        '
        'secondNumberTextBox
        '
        Me.secondNumberTextBox.Location = New System.Drawing.Point(163, 82)
        Me.secondNumberTextBox.Name = "secondNumberTextBox"
        Me.secondNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.secondNumberTextBox.TabIndex = 3
        '
        'resultTextBox
        '
        Me.resultTextBox.Location = New System.Drawing.Point(163, 108)
        Me.resultTextBox.Name = "resultTextBox"
        Me.resultTextBox.Size = New System.Drawing.Size(100, 20)
        Me.resultTextBox.TabIndex = 4
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(184, 169)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 5
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.resultTextBox)
        Me.Controls.Add(Me.secondNumberTextBox)
        Me.Controls.Add(Me.firstNumberTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents firstNumberTextBox As TextBox
    Friend WithEvents secondNumberTextBox As TextBox
    Friend WithEvents resultTextBox As TextBox
    Friend WithEvents calculateButton As Button
End Class
