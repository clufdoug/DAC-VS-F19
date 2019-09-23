<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Specials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Specials))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Special_Soup = New System.Windows.Forms.Button()
        Me.Specials_Selection = New System.Windows.Forms.GroupBox()
        Me.Special_Fish = New System.Windows.Forms.Button()
        Me.Special_Chef = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Special_Response = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Specials_Selection.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(249, 202)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(522, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Special_Soup
        '
        Me.Special_Soup.Location = New System.Drawing.Point(8, 29)
        Me.Special_Soup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Special_Soup.Name = "Special_Soup"
        Me.Special_Soup.Size = New System.Drawing.Size(190, 40)
        Me.Special_Soup.TabIndex = 1
        Me.Special_Soup.Text = "Soup of the Day"
        Me.Special_Soup.UseVisualStyleBackColor = True
        '
        'Specials_Selection
        '
        Me.Specials_Selection.Controls.Add(Me.Special_Fish)
        Me.Specials_Selection.Controls.Add(Me.Special_Chef)
        Me.Specials_Selection.Controls.Add(Me.Special_Soup)
        Me.Specials_Selection.Location = New System.Drawing.Point(18, 23)
        Me.Specials_Selection.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Specials_Selection.Name = "Specials_Selection"
        Me.Specials_Selection.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Specials_Selection.Size = New System.Drawing.Size(207, 200)
        Me.Specials_Selection.TabIndex = 4
        Me.Specials_Selection.TabStop = False
        Me.Specials_Selection.Text = "Specials Selection"
        '
        'Special_Fish
        '
        Me.Special_Fish.Location = New System.Drawing.Point(8, 129)
        Me.Special_Fish.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Special_Fish.Name = "Special_Fish"
        Me.Special_Fish.Size = New System.Drawing.Size(190, 40)
        Me.Special_Fish.TabIndex = 1
        Me.Special_Fish.Text = "Daily Fish"
        Me.Special_Fish.UseVisualStyleBackColor = True
        '
        'Special_Chef
        '
        Me.Special_Chef.Location = New System.Drawing.Point(8, 79)
        Me.Special_Chef.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Special_Chef.Name = "Special_Chef"
        Me.Special_Chef.Size = New System.Drawing.Size(190, 40)
        Me.Special_Chef.TabIndex = 1
        Me.Special_Chef.Text = "Tim's Special"
        Me.Special_Chef.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(26, 307)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(190, 40)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "E&xit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Special_Response
        '
        Me.Special_Response.Location = New System.Drawing.Point(245, 52)
        Me.Special_Response.Name = "Special_Response"
        Me.Special_Response.Size = New System.Drawing.Size(526, 140)
        Me.Special_Response.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Make a selection at the left to see our Specials!!"
        '
        'Specials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Special_Response)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Specials_Selection)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Specials"
        Me.Text = "Rosstimo Bistro Specials"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Specials_Selection.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Special_Soup As Button
    Friend WithEvents Specials_Selection As GroupBox
    Friend WithEvents Special_Fish As Button
    Friend WithEvents Special_Chef As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Special_Response As Label
    Friend WithEvents Label1 As Label
End Class
