

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HelloWorldLanguagesForm
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
        Me.LanguageFrenchButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.LanguageGermanButton = New System.Windows.Forms.Button()
        Me.LanguageNorwegianButton = New System.Windows.Forms.Button()
        Me.LanguageEnglishButton = New System.Windows.Forms.Button()
        Me.LanguageSpanishButton = New System.Windows.Forms.Button()
        Me.LanguageItalianButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelloWorldHeadingLabel = New System.Windows.Forms.Label()
        Me.Text_Reply = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LanguageFrenchButton
        '
        Me.LanguageFrenchButton.Location = New System.Drawing.Point(12, 295)
        Me.LanguageFrenchButton.Name = "LanguageFrenchButton"
        Me.LanguageFrenchButton.Size = New System.Drawing.Size(150, 50)
        Me.LanguageFrenchButton.TabIndex = 0
        Me.LanguageFrenchButton.Text = "&French"
        Me.ToolTip1.SetToolTip(Me.LanguageFrenchButton, "Display ""Hello World"" in French")
        Me.LanguageFrenchButton.UseVisualStyleBackColor = True
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
        'LanguageGermanButton
        '
        Me.LanguageGermanButton.Location = New System.Drawing.Point(168, 295)
        Me.LanguageGermanButton.Name = "LanguageGermanButton"
        Me.LanguageGermanButton.Size = New System.Drawing.Size(150, 50)
        Me.LanguageGermanButton.TabIndex = 4
        Me.LanguageGermanButton.Text = "&German"
        Me.ToolTip1.SetToolTip(Me.LanguageGermanButton, "Display ""Hello World"" in German")
        Me.LanguageGermanButton.UseVisualStyleBackColor = True
        '
        'LanguageNorwegianButton
        '
        Me.LanguageNorwegianButton.Location = New System.Drawing.Point(324, 295)
        Me.LanguageNorwegianButton.Name = "LanguageNorwegianButton"
        Me.LanguageNorwegianButton.Size = New System.Drawing.Size(150, 50)
        Me.LanguageNorwegianButton.TabIndex = 5
        Me.LanguageNorwegianButton.Text = "&Norwegian"
        Me.ToolTip1.SetToolTip(Me.LanguageNorwegianButton, "Display ""Hello World"" in Norwegian")
        Me.LanguageNorwegianButton.UseVisualStyleBackColor = True
        '
        'LanguageEnglishButton
        '
        Me.LanguageEnglishButton.Location = New System.Drawing.Point(12, 239)
        Me.LanguageEnglishButton.Name = "LanguageEnglishButton"
        Me.LanguageEnglishButton.Size = New System.Drawing.Size(150, 50)
        Me.LanguageEnglishButton.TabIndex = 6
        Me.LanguageEnglishButton.Text = "&English"
        Me.ToolTip1.SetToolTip(Me.LanguageEnglishButton, "Display ""Hello World"" in English")
        Me.LanguageEnglishButton.UseVisualStyleBackColor = True
        '
        'LanguageSpanishButton
        '
        Me.LanguageSpanishButton.Location = New System.Drawing.Point(168, 239)
        Me.LanguageSpanishButton.Name = "LanguageSpanishButton"
        Me.LanguageSpanishButton.Size = New System.Drawing.Size(150, 50)
        Me.LanguageSpanishButton.TabIndex = 7
        Me.LanguageSpanishButton.Text = "&Spanish"
        Me.ToolTip1.SetToolTip(Me.LanguageSpanishButton, "Display ""Hello World"" in Spanish")
        Me.LanguageSpanishButton.UseVisualStyleBackColor = True
        '
        'LanguageItalianButton
        '
        Me.LanguageItalianButton.Location = New System.Drawing.Point(324, 239)
        Me.LanguageItalianButton.Name = "LanguageItalianButton"
        Me.LanguageItalianButton.Size = New System.Drawing.Size(150, 50)
        Me.LanguageItalianButton.TabIndex = 8
        Me.LanguageItalianButton.Text = "&Italian"
        Me.ToolTip1.SetToolTip(Me.LanguageItalianButton, "Display ""Hello World"" in Italian")
        Me.LanguageItalianButton.UseVisualStyleBackColor = True
        '
        'HelloWorldHeadingLabel
        '
        Me.HelloWorldHeadingLabel.AutoSize = True
        Me.HelloWorldHeadingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.HelloWorldHeadingLabel.Location = New System.Drawing.Point(110, 9)
        Me.HelloWorldHeadingLabel.Name = "HelloWorldHeadingLabel"
        Me.HelloWorldHeadingLabel.Size = New System.Drawing.Size(570, 20)
        Me.HelloWorldHeadingLabel.TabIndex = 9
        Me.HelloWorldHeadingLabel.Text = "People from around the world say ""Hello World"" in many different ways"
        Me.ToolTip1.SetToolTip(Me.HelloWorldHeadingLabel, "Click below to display Hello World in different Languages.")
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
        'HelloWorldLanguagesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 357)
        Me.Controls.Add(Me.Text_Reply)
        Me.Controls.Add(Me.HelloWorldHeadingLabel)
        Me.Controls.Add(Me.LanguageItalianButton)
        Me.Controls.Add(Me.LanguageSpanishButton)
        Me.Controls.Add(Me.LanguageEnglishButton)
        Me.Controls.Add(Me.LanguageNorwegianButton)
        Me.Controls.Add(Me.LanguageGermanButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LanguageFrenchButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "HelloWorldLanguagesForm"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LanguageFrenchButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LanguageGermanButton As Button
    Friend WithEvents LanguageNorwegianButton As Button
    Friend WithEvents LanguageEnglishButton As Button
    Friend WithEvents LanguageSpanishButton As Button
    Friend WithEvents LanguageItalianButton As Button
    Friend WithEvents HelloWorldHeadingLabel As Label
    Friend WithEvents Text_Reply As Label


End Class
