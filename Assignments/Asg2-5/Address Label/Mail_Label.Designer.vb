<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mail_Label
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
        Me.FirstName_Textbox = New System.Windows.Forms.TextBox()
        Me.firstName_Label = New System.Windows.Forms.Label()
        Me.LastName_Label = New System.Windows.Forms.Label()
        Me.LastName_TextBox = New System.Windows.Forms.TextBox()
        Me.Street_Label = New System.Windows.Forms.Label()
        Me.Street_TextBox = New System.Windows.Forms.TextBox()
        Me.City_Label = New System.Windows.Forms.Label()
        Me.City_TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Zip_TextBox = New System.Windows.Forms.TextBox()
        Me.State_ListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Output_Label = New System.Windows.Forms.Label()
        Me.Display_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstName_Textbox
        '
        Me.FirstName_Textbox.Location = New System.Drawing.Point(123, 40)
        Me.FirstName_Textbox.Name = "FirstName_Textbox"
        Me.FirstName_Textbox.Size = New System.Drawing.Size(161, 26)
        Me.FirstName_Textbox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.FirstName_Textbox, "Enter recipients First Name")
        '
        'firstName_Label
        '
        Me.firstName_Label.AutoSize = True
        Me.firstName_Label.Location = New System.Drawing.Point(21, 43)
        Me.firstName_Label.Name = "firstName_Label"
        Me.firstName_Label.Size = New System.Drawing.Size(94, 18)
        Me.firstName_Label.TabIndex = 1
        Me.firstName_Label.Text = "First Name"
        Me.ToolTip1.SetToolTip(Me.firstName_Label, "Enter recipients First Name")
        '
        'LastName_Label
        '
        Me.LastName_Label.AutoSize = True
        Me.LastName_Label.Location = New System.Drawing.Point(21, 75)
        Me.LastName_Label.Name = "LastName_Label"
        Me.LastName_Label.Size = New System.Drawing.Size(93, 18)
        Me.LastName_Label.TabIndex = 3
        Me.LastName_Label.Text = "Last Name"
        Me.ToolTip1.SetToolTip(Me.LastName_Label, "Enter recipients Last Name")
        '
        'LastName_TextBox
        '
        Me.LastName_TextBox.Location = New System.Drawing.Point(123, 72)
        Me.LastName_TextBox.Name = "LastName_TextBox"
        Me.LastName_TextBox.Size = New System.Drawing.Size(161, 26)
        Me.LastName_TextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.LastName_TextBox, "Enter recipients Last Name")
        '
        'Street_Label
        '
        Me.Street_Label.AutoSize = True
        Me.Street_Label.Location = New System.Drawing.Point(21, 107)
        Me.Street_Label.Name = "Street_Label"
        Me.Street_Label.Size = New System.Drawing.Size(58, 18)
        Me.Street_Label.TabIndex = 5
        Me.Street_Label.Text = "Street"
        Me.ToolTip1.SetToolTip(Me.Street_Label, "Enter recipients Street address")
        '
        'Street_TextBox
        '
        Me.Street_TextBox.Location = New System.Drawing.Point(123, 104)
        Me.Street_TextBox.Name = "Street_TextBox"
        Me.Street_TextBox.Size = New System.Drawing.Size(161, 26)
        Me.Street_TextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Street_TextBox, "Enter recipients Street address")
        '
        'City_Label
        '
        Me.City_Label.AutoSize = True
        Me.City_Label.Location = New System.Drawing.Point(21, 139)
        Me.City_Label.Name = "City_Label"
        Me.City_Label.Size = New System.Drawing.Size(39, 18)
        Me.City_Label.TabIndex = 7
        Me.City_Label.Text = "City"
        Me.ToolTip1.SetToolTip(Me.City_Label, "Enter recipients City")
        '
        'City_TextBox
        '
        Me.City_TextBox.Location = New System.Drawing.Point(123, 136)
        Me.City_TextBox.Name = "City_TextBox"
        Me.City_TextBox.Size = New System.Drawing.Size(161, 26)
        Me.City_TextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.City_TextBox, "Enter recipients City")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "State"
        Me.ToolTip1.SetToolTip(Me.Label4, "Select recipients State")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Zip Code"
        Me.ToolTip1.SetToolTip(Me.Label5, "Enter recipients Zip Code")
        '
        'Zip_TextBox
        '
        Me.Zip_TextBox.Location = New System.Drawing.Point(123, 200)
        Me.Zip_TextBox.Name = "Zip_TextBox"
        Me.Zip_TextBox.Size = New System.Drawing.Size(161, 26)
        Me.Zip_TextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Zip_TextBox, "Enter recipients Zip Code")
        '
        'State_ListBox
        '
        Me.State_ListBox.FormattingEnabled = True
        Me.State_ListBox.ItemHeight = 18
        Me.State_ListBox.Items.AddRange(New Object() {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"})
        Me.State_ListBox.Location = New System.Drawing.Point(123, 170)
        Me.State_ListBox.Name = "State_ListBox"
        Me.State_ListBox.Size = New System.Drawing.Size(161, 22)
        Me.State_ListBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.State_ListBox, "Select recipients State")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.State_ListBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Zip_TextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.City_Label)
        Me.GroupBox1.Controls.Add(Me.City_TextBox)
        Me.GroupBox1.Controls.Add(Me.Street_Label)
        Me.GroupBox1.Controls.Add(Me.Street_TextBox)
        Me.GroupBox1.Controls.Add(Me.LastName_Label)
        Me.GroupBox1.Controls.Add(Me.LastName_TextBox)
        Me.GroupBox1.Controls.Add(Me.firstName_Label)
        Me.GroupBox1.Controls.Add(Me.FirstName_Textbox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 275)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Label Input"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Output_Label)
        Me.GroupBox2.Location = New System.Drawing.Point(418, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 275)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Label Output"
        '
        'Output_Label
        '
        Me.Output_Label.Location = New System.Drawing.Point(7, 26)
        Me.Output_Label.Name = "Output_Label"
        Me.Output_Label.Size = New System.Drawing.Size(337, 246)
        Me.Output_Label.TabIndex = 9
        '
        'Display_Button
        '
        Me.Display_Button.Location = New System.Drawing.Point(16, 293)
        Me.Display_Button.Name = "Display_Button"
        Me.Display_Button.Size = New System.Drawing.Size(166, 52)
        Me.Display_Button.TabIndex = 6
        Me.Display_Button.Text = "&Display"
        Me.ToolTip1.SetToolTip(Me.Display_Button, "Display Information in output")
        Me.Display_Button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(196, 293)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(166, 52)
        Me.Clear_Button.TabIndex = 7
        Me.Clear_Button.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.Clear_Button, "Clear form Data")
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_Button.Location = New System.Drawing.Point(602, 293)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(166, 52)
        Me.Exit_Button.TabIndex = 8
        Me.Exit_Button.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.Exit_Button, "Exit Label Form")
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Mail_Label
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 357)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Clear_Button)
        Me.Controls.Add(Me.Display_Button)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Mail_Label"
        Me.Text = "Mailing Label"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FirstName_Textbox As TextBox
    Friend WithEvents firstName_Label As Label
    Friend WithEvents LastName_Label As Label
    Friend WithEvents LastName_TextBox As TextBox
    Friend WithEvents Street_Label As Label
    Friend WithEvents Street_TextBox As TextBox
    Friend WithEvents City_Label As Label
    Friend WithEvents City_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Zip_TextBox As TextBox
    Friend WithEvents State_ListBox As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Output_Label As Label
    Friend WithEvents Display_Button As Button
    Friend WithEvents Clear_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
