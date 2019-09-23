<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wisdom
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
        Me.Wisdom_Response = New System.Windows.Forms.Label()
        Me.Wisdom_1 = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Wisdom_2 = New System.Windows.Forms.Button()
        Me.Wisdom_3 = New System.Windows.Forms.Button()
        Me.Wisdom_4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Wisdom_Response
        '
        Me.Wisdom_Response.Location = New System.Drawing.Point(319, 56)
        Me.Wisdom_Response.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Wisdom_Response.Name = "Wisdom_Response"
        Me.Wisdom_Response.Size = New System.Drawing.Size(375, 193)
        Me.Wisdom_Response.TabIndex = 0
        '
        'Wisdom_1
        '
        Me.Wisdom_1.Location = New System.Drawing.Point(14, 14)
        Me.Wisdom_1.Margin = New System.Windows.Forms.Padding(5)
        Me.Wisdom_1.Name = "Wisdom_1"
        Me.Wisdom_1.Size = New System.Drawing.Size(241, 50)
        Me.Wisdom_1.TabIndex = 1
        Me.Wisdom_1.Text = "Wisdom #1"
        Me.ToolTip1.SetToolTip(Me.Wisdom_1, "Receive the 1st piece of wisdom...")
        Me.Wisdom_1.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_Button.Location = New System.Drawing.Point(516, 281)
        Me.Exit_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(250, 62)
        Me.Exit_Button.TabIndex = 2
        Me.Exit_Button.Text = "E&xit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 265)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 83)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Doug Cluff RCET0265 Asg1-3 Wisdom.vb"
        '
        'Wisdom_2
        '
        Me.Wisdom_2.Location = New System.Drawing.Point(14, 74)
        Me.Wisdom_2.Margin = New System.Windows.Forms.Padding(5)
        Me.Wisdom_2.Name = "Wisdom_2"
        Me.Wisdom_2.Size = New System.Drawing.Size(241, 50)
        Me.Wisdom_2.TabIndex = 4
        Me.Wisdom_2.Text = "Wisdom #2"
        Me.ToolTip1.SetToolTip(Me.Wisdom_2, "Receive the 2nd piece of wisdom...")
        Me.Wisdom_2.UseVisualStyleBackColor = True
        '
        'Wisdom_3
        '
        Me.Wisdom_3.Location = New System.Drawing.Point(14, 134)
        Me.Wisdom_3.Margin = New System.Windows.Forms.Padding(5)
        Me.Wisdom_3.Name = "Wisdom_3"
        Me.Wisdom_3.Size = New System.Drawing.Size(241, 50)
        Me.Wisdom_3.TabIndex = 5
        Me.Wisdom_3.Text = "Wisdom #3"
        Me.ToolTip1.SetToolTip(Me.Wisdom_3, "Receive the 3rd piece of wisdom...")
        Me.Wisdom_3.UseVisualStyleBackColor = True
        '
        'Wisdom_4
        '
        Me.Wisdom_4.Location = New System.Drawing.Point(14, 194)
        Me.Wisdom_4.Margin = New System.Windows.Forms.Padding(5)
        Me.Wisdom_4.Name = "Wisdom_4"
        Me.Wisdom_4.Size = New System.Drawing.Size(241, 50)
        Me.Wisdom_4.TabIndex = 6
        Me.Wisdom_4.Text = "Wisdom #4"
        Me.ToolTip1.SetToolTip(Me.Wisdom_4, "Receive the 4th piece of wisdom...")
        Me.Wisdom_4.UseVisualStyleBackColor = True
        '
        'Wisdom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 357)
        Me.Controls.Add(Me.Wisdom_4)
        Me.Controls.Add(Me.Wisdom_3)
        Me.Controls.Add(Me.Wisdom_2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Wisdom_1)
        Me.Controls.Add(Me.Wisdom_Response)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Wisdom"
        Me.Text = "Wisdom Generator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Wisdom_Response As Label
    Friend WithEvents Wisdom_1 As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Wisdom_2 As Button
    Friend WithEvents Wisdom_3 As Button
    Friend WithEvents Wisdom_4 As Button
End Class
