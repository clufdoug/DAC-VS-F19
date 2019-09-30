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
        Me.SelectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.BadButton = New System.Windows.Forms.RadioButton()
        Me.Meh = New System.Windows.Forms.RadioButton()
        Me.GoodDayButton = New System.Windows.Forms.RadioButton()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ResponseButton = New System.Windows.Forms.Button()
        Me.SelectionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SelectionGroupBox
        '
        Me.SelectionGroupBox.Controls.Add(Me.GoodDayButton)
        Me.SelectionGroupBox.Controls.Add(Me.Meh)
        Me.SelectionGroupBox.Controls.Add(Me.BadButton)
        Me.SelectionGroupBox.Location = New System.Drawing.Point(366, 38)
        Me.SelectionGroupBox.Name = "SelectionGroupBox"
        Me.SelectionGroupBox.Size = New System.Drawing.Size(324, 239)
        Me.SelectionGroupBox.TabIndex = 0
        Me.SelectionGroupBox.TabStop = False
        Me.SelectionGroupBox.Text = "Select One"
        '
        'BadButton
        '
        Me.BadButton.AutoSize = True
        Me.BadButton.Location = New System.Drawing.Point(33, 34)
        Me.BadButton.Name = "BadButton"
        Me.BadButton.Size = New System.Drawing.Size(66, 17)
        Me.BadButton.TabIndex = 0
        Me.BadButton.TabStop = True
        Me.BadButton.Text = "Bad Day"
        Me.BadButton.UseVisualStyleBackColor = True
        '
        'Meh
        '
        Me.Meh.AutoSize = True
        Me.Meh.Location = New System.Drawing.Point(33, 58)
        Me.Meh.Name = "Meh"
        Me.Meh.Size = New System.Drawing.Size(46, 17)
        Me.Meh.TabIndex = 1
        Me.Meh.TabStop = True
        Me.Meh.Text = "Meh"
        Me.Meh.UseVisualStyleBackColor = True
        '
        'GoodDayButton
        '
        Me.GoodDayButton.AutoSize = True
        Me.GoodDayButton.Location = New System.Drawing.Point(33, 82)
        Me.GoodDayButton.Name = "GoodDayButton"
        Me.GoodDayButton.Size = New System.Drawing.Size(73, 17)
        Me.GoodDayButton.TabIndex = 2
        Me.GoodDayButton.TabStop = True
        Me.GoodDayButton.Text = "Good Day"
        Me.GoodDayButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(449, 343)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(241, 61)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ResponseButton
        '
        Me.ResponseButton.Location = New System.Drawing.Point(202, 343)
        Me.ResponseButton.Name = "ResponseButton"
        Me.ResponseButton.Size = New System.Drawing.Size(241, 61)
        Me.ResponseButton.TabIndex = 2
        Me.ResponseButton.Text = "Response"
        Me.ResponseButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ResponseButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SelectionGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SelectionGroupBox.ResumeLayout(False)
        Me.SelectionGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SelectionGroupBox As GroupBox
    Friend WithEvents GoodDayButton As RadioButton
    Friend WithEvents Meh As RadioButton
    Friend WithEvents BadButton As RadioButton
    Friend WithEvents ClearButton As Button
    Friend WithEvents ResponseButton As Button
End Class
