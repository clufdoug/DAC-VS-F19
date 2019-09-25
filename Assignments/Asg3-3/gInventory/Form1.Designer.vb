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
        Me.Beg_Inv_TextBox = New System.Windows.Forms.TextBox()
        Me.Beg_Inv_Label = New System.Windows.Forms.Label()
        Me.End_Inv_Label = New System.Windows.Forms.Label()
        Me.End_Inv_TextBox = New System.Windows.Forms.TextBox()
        Me.Good_Sold_Label = New System.Windows.Forms.Label()
        Me.Good_Sold_TextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Avg_Inv_TextBox = New System.Windows.Forms.TextBox()
        Me.Avg_Inv_Label = New System.Windows.Forms.Label()
        Me.Turnover_Label = New System.Windows.Forms.Label()
        Me.Turnover_TextBox = New System.Windows.Forms.TextBox()
        Me.Calculate_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Beg_Inv_TextBox
        '
        Me.Beg_Inv_TextBox.Location = New System.Drawing.Point(188, 27)
        Me.Beg_Inv_TextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.Beg_Inv_TextBox.Name = "Beg_Inv_TextBox"
        Me.Beg_Inv_TextBox.Size = New System.Drawing.Size(164, 26)
        Me.Beg_Inv_TextBox.TabIndex = 0
        '
        'Beg_Inv_Label
        '
        Me.Beg_Inv_Label.Location = New System.Drawing.Point(12, 30)
        Me.Beg_Inv_Label.Name = "Beg_Inv_Label"
        Me.Beg_Inv_Label.Size = New System.Drawing.Size(168, 23)
        Me.Beg_Inv_Label.TabIndex = 1
        Me.Beg_Inv_Label.Text = "Beginning Inventory"
        Me.Beg_Inv_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'End_Inv_Label
        '
        Me.End_Inv_Label.Location = New System.Drawing.Point(12, 66)
        Me.End_Inv_Label.Name = "End_Inv_Label"
        Me.End_Inv_Label.Size = New System.Drawing.Size(168, 23)
        Me.End_Inv_Label.TabIndex = 3
        Me.End_Inv_Label.Text = "Ending Inventory"
        Me.End_Inv_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'End_Inv_TextBox
        '
        Me.End_Inv_TextBox.Location = New System.Drawing.Point(188, 63)
        Me.End_Inv_TextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.End_Inv_TextBox.Name = "End_Inv_TextBox"
        Me.End_Inv_TextBox.Size = New System.Drawing.Size(164, 26)
        Me.End_Inv_TextBox.TabIndex = 1
        '
        'Good_Sold_Label
        '
        Me.Good_Sold_Label.Location = New System.Drawing.Point(12, 102)
        Me.Good_Sold_Label.Name = "Good_Sold_Label"
        Me.Good_Sold_Label.Size = New System.Drawing.Size(168, 23)
        Me.Good_Sold_Label.TabIndex = 5
        Me.Good_Sold_Label.Text = "Cost of Goods Sold"
        Me.Good_Sold_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Good_Sold_TextBox
        '
        Me.Good_Sold_TextBox.Location = New System.Drawing.Point(188, 99)
        Me.Good_Sold_TextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.Good_Sold_TextBox.Name = "Good_Sold_TextBox"
        Me.Good_Sold_TextBox.Size = New System.Drawing.Size(164, 26)
        Me.Good_Sold_TextBox.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Beg_Inv_TextBox)
        Me.GroupBox1.Controls.Add(Me.Good_Sold_Label)
        Me.GroupBox1.Controls.Add(Me.Beg_Inv_Label)
        Me.GroupBox1.Controls.Add(Me.Good_Sold_TextBox)
        Me.GroupBox1.Controls.Add(Me.End_Inv_TextBox)
        Me.GroupBox1.Controls.Add(Me.End_Inv_Label)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 157)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory Input"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Avg_Inv_TextBox)
        Me.GroupBox2.Controls.Add(Me.Avg_Inv_Label)
        Me.GroupBox2.Controls.Add(Me.Turnover_Label)
        Me.GroupBox2.Controls.Add(Me.Turnover_TextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 157)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inventory Result"
        '
        'Avg_Inv_TextBox
        '
        Me.Avg_Inv_TextBox.Location = New System.Drawing.Point(188, 27)
        Me.Avg_Inv_TextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.Avg_Inv_TextBox.Name = "Avg_Inv_TextBox"
        Me.Avg_Inv_TextBox.Size = New System.Drawing.Size(164, 26)
        Me.Avg_Inv_TextBox.TabIndex = 3
        '
        'Avg_Inv_Label
        '
        Me.Avg_Inv_Label.Location = New System.Drawing.Point(12, 30)
        Me.Avg_Inv_Label.Name = "Avg_Inv_Label"
        Me.Avg_Inv_Label.Size = New System.Drawing.Size(168, 23)
        Me.Avg_Inv_Label.TabIndex = 1
        Me.Avg_Inv_Label.Text = "Average Inventory"
        Me.Avg_Inv_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Turnover_Label
        '
        Me.Turnover_Label.Location = New System.Drawing.Point(12, 66)
        Me.Turnover_Label.Name = "Turnover_Label"
        Me.Turnover_Label.Size = New System.Drawing.Size(168, 23)
        Me.Turnover_Label.TabIndex = 3
        Me.Turnover_Label.Text = "Turnover"
        Me.Turnover_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Turnover_TextBox
        '
        Me.Turnover_TextBox.Location = New System.Drawing.Point(188, 63)
        Me.Turnover_TextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.Turnover_TextBox.Name = "Turnover_TextBox"
        Me.Turnover_TextBox.Size = New System.Drawing.Size(164, 26)
        Me.Turnover_TextBox.TabIndex = 4
        '
        'Calculate_Button
        '
        Me.Calculate_Button.Location = New System.Drawing.Point(12, 399)
        Me.Calculate_Button.Name = "Calculate_Button"
        Me.Calculate_Button.Size = New System.Drawing.Size(110, 50)
        Me.Calculate_Button.TabIndex = 5
        Me.Calculate_Button.Text = "&Calculate"
        Me.Calculate_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(262, 399)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(110, 50)
        Me.Exit_Button.TabIndex = 7
        Me.Exit_Button.Text = "E&xit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(128, 399)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(110, 50)
        Me.Clear_Button.TabIndex = 6
        Me.Clear_Button.Text = "Clear"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.Clear_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Calculate_Button)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Inventory Control"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Beg_Inv_TextBox As TextBox
    Friend WithEvents Beg_Inv_Label As Label
    Friend WithEvents End_Inv_Label As Label
    Friend WithEvents End_Inv_TextBox As TextBox
    Friend WithEvents Good_Sold_Label As Label
    Friend WithEvents Good_Sold_TextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Avg_Inv_TextBox As TextBox
    Friend WithEvents Avg_Inv_Label As Label
    Friend WithEvents Turnover_TextBox As TextBox
    Friend WithEvents Turnover_Label As Label
    Friend WithEvents Calculate_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Clear_Button As Button
End Class
