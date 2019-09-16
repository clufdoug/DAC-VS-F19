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
        Me.English = New System.Windows.Forms.Button()
        Me.Spanish = New System.Windows.Forms.Button()
        Me.French = New System.Windows.Forms.Button()
        Me.Italian = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'English
        '
        Me.English.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.English.Location = New System.Drawing.Point(563, 43)
        Me.English.Name = "English"
        Me.English.Size = New System.Drawing.Size(183, 79)
        Me.English.TabIndex = 1
        Me.English.Text = "English"
        Me.English.UseVisualStyleBackColor = True
        '
        'Spanish
        '
        Me.Spanish.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spanish.Location = New System.Drawing.Point(563, 140)
        Me.Spanish.Name = "Spanish"
        Me.Spanish.Size = New System.Drawing.Size(183, 79)
        Me.Spanish.TabIndex = 2
        Me.Spanish.Text = "Spanish"
        Me.Spanish.UseVisualStyleBackColor = True
        '
        'French
        '
        Me.French.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.French.Location = New System.Drawing.Point(563, 237)
        Me.French.Name = "French"
        Me.French.Size = New System.Drawing.Size(183, 79)
        Me.French.TabIndex = 3
        Me.French.Text = "French"
        Me.French.UseVisualStyleBackColor = True
        '
        'Italian
        '
        Me.Italian.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Italian.Location = New System.Drawing.Point(563, 338)
        Me.Italian.Name = "Italian"
        Me.Italian.Size = New System.Drawing.Size(183, 79)
        Me.Italian.TabIndex = 4
        Me.Italian.Text = "Italian"
        Me.Italian.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 39)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hello World!"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 75)
        Me.Label1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Italian)
        Me.Controls.Add(Me.French)
        Me.Controls.Add(Me.Spanish)
        Me.Controls.Add(Me.English)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents English As Button
    Friend WithEvents Spanish As Button
    Friend WithEvents French As Button
    Friend WithEvents Italian As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
