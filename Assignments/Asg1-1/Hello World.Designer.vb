

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Me.Language_French = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Language_German = New System.Windows.Forms.Button()
        Me.Language_Norwegian = New System.Windows.Forms.Button()
        Me.Language_English = New System.Windows.Forms.Button()
        Me.Language_Spanish = New System.Windows.Forms.Button()
        Me.Language_Italian = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text_Reply = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Language_French
        '
        Me.Language_French.Location = New System.Drawing.Point(12, 295)
        Me.Language_French.Name = "Language_French"
        Me.Language_French.Size = New System.Drawing.Size(150, 50)
        Me.Language_French.TabIndex = 0
        Me.Language_French.Text = "&French"
        Me.ToolTip1.SetToolTip(Me.Language_French, "Display ""Hello World"" in French")
        Me.Language_French.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(618, 295)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(150, 50)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Click to Exit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Language_German
        '
        Me.Language_German.Location = New System.Drawing.Point(168, 295)
        Me.Language_German.Name = "Language_German"
        Me.Language_German.Size = New System.Drawing.Size(150, 50)
        Me.Language_German.TabIndex = 4
        Me.Language_German.Text = "&German"
        Me.ToolTip1.SetToolTip(Me.Language_German, "Display ""Hello World"" in German")
        Me.Language_German.UseVisualStyleBackColor = True
        '
        'Language_Norwegian
        '
        Me.Language_Norwegian.Location = New System.Drawing.Point(324, 295)
        Me.Language_Norwegian.Name = "Language_Norwegian"
        Me.Language_Norwegian.Size = New System.Drawing.Size(150, 50)
        Me.Language_Norwegian.TabIndex = 5
        Me.Language_Norwegian.Text = "&Norwegian"
        Me.ToolTip1.SetToolTip(Me.Language_Norwegian, "Display ""Hello World"" in Norwegian")
        Me.Language_Norwegian.UseVisualStyleBackColor = True
        '
        'Language_English
        '
        Me.Language_English.Location = New System.Drawing.Point(12, 239)
        Me.Language_English.Name = "Language_English"
        Me.Language_English.Size = New System.Drawing.Size(150, 50)
        Me.Language_English.TabIndex = 6
        Me.Language_English.Text = "&English"
        Me.ToolTip1.SetToolTip(Me.Language_English, "Display ""Hello World"" in English")
        Me.Language_English.UseVisualStyleBackColor = True
        '
        'Language_Spanish
        '
        Me.Language_Spanish.Location = New System.Drawing.Point(168, 239)
        Me.Language_Spanish.Name = "Language_Spanish"
        Me.Language_Spanish.Size = New System.Drawing.Size(150, 50)
        Me.Language_Spanish.TabIndex = 7
        Me.Language_Spanish.Text = "&Spanish"
        Me.ToolTip1.SetToolTip(Me.Language_Spanish, "Display ""Hello World"" in Spanish")
        Me.Language_Spanish.UseVisualStyleBackColor = True
        '
        'Language_Italian
        '
        Me.Language_Italian.Location = New System.Drawing.Point(324, 239)
        Me.Language_Italian.Name = "Language_Italian"
        Me.Language_Italian.Size = New System.Drawing.Size(150, 50)
        Me.Language_Italian.TabIndex = 8
        Me.Language_Italian.Text = "&Italian"
        Me.ToolTip1.SetToolTip(Me.Language_Italian, "Display ""Hello World"" in Italian")
        Me.Language_Italian.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(110, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(570, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "People from around the world say ""Hello World"" in many different ways"
        Me.ToolTip1.SetToolTip(Me.Label1, "Click below to display Hello World in different Languages.")
        '
        'Text_Reply
        '
        Me.Text_Reply.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Text_Reply.AutoSize = True
        Me.Text_Reply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Text_Reply.Location = New System.Drawing.Point(110, 100)
        Me.Text_Reply.Name = "Text_Reply"
        Me.Text_Reply.Size = New System.Drawing.Size(0, 20)
        Me.Text_Reply.TabIndex = 10
        Me.Text_Reply.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 357)
        Me.Controls.Add(Me.Text_Reply)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Language_Italian)
        Me.Controls.Add(Me.Language_Spanish)
        Me.Controls.Add(Me.Language_English)
        Me.Controls.Add(Me.Language_Norwegian)
        Me.Controls.Add(Me.Language_German)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Language_French)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Language_French As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Language_German As Button
    Friend WithEvents Language_Norwegian As Button
    Friend WithEvents Language_English As Button
    Friend WithEvents Language_Spanish As Button
    Friend WithEvents Language_Italian As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Text_Reply As Label


End Class
