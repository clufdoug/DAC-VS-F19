<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StateFlags
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
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.UsaLabel = New System.Windows.Forms.Label()
        Me.FlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.AlButton = New System.Windows.Forms.Button()
        Me.AzButton = New System.Windows.Forms.Button()
        Me.CaButton = New System.Windows.Forms.Button()
        Me.CoButton = New System.Windows.Forms.Button()
        Me.IdButton = New System.Windows.Forms.Button()
        Me.NvButton = New System.Windows.Forms.Button()
        Me.OrButton = New System.Windows.Forms.Button()
        Me.UtButton = New System.Windows.Forms.Button()
        Me.WaButton = New System.Windows.Forms.Button()
        Me.WyButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.DisplayGroupBox.SuspendLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.UsaLabel)
        Me.DisplayGroupBox.Controls.Add(Me.FlagPictureBox)
        Me.DisplayGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayGroupBox.Location = New System.Drawing.Point(282, 12)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Size = New System.Drawing.Size(381, 333)
        Me.DisplayGroupBox.TabIndex = 1
        Me.DisplayGroupBox.TabStop = False
        Me.DisplayGroupBox.Text = "State Details"
        '
        'UsaLabel
        '
        Me.UsaLabel.AutoSize = True
        Me.UsaLabel.Location = New System.Drawing.Point(18, 25)
        Me.UsaLabel.Name = "UsaLabel"
        Me.UsaLabel.Size = New System.Drawing.Size(147, 20)
        Me.UsaLabel.TabIndex = 1
        Me.UsaLabel.Text = "Flags of the USA"
        '
        'FlagPictureBox
        '
        Me.FlagPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FlagPictureBox.Image = Global.State_Flags.My.Resources.Resource._50_us_state_flags__31031_1411402035
        Me.FlagPictureBox.InitialImage = Global.State_Flags.My.Resources.Resource._50_us_state_flags__31031_1411402035
        Me.FlagPictureBox.Location = New System.Drawing.Point(6, 57)
        Me.FlagPictureBox.Name = "FlagPictureBox"
        Me.FlagPictureBox.Size = New System.Drawing.Size(370, 270)
        Me.FlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FlagPictureBox.TabIndex = 0
        Me.FlagPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "State Selection"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(18, 289)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(125, 50)
        Me.Exit_Button.TabIndex = 3
        Me.Exit_Button.Text = "E&xit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'AlButton
        '
        Me.AlButton.Location = New System.Drawing.Point(18, 59)
        Me.AlButton.Name = "AlButton"
        Me.AlButton.Size = New System.Drawing.Size(125, 40)
        Me.AlButton.TabIndex = 4
        Me.AlButton.Text = "Alabama"
        Me.AlButton.UseVisualStyleBackColor = True
        '
        'AzButton
        '
        Me.AzButton.Location = New System.Drawing.Point(18, 105)
        Me.AzButton.Name = "AzButton"
        Me.AzButton.Size = New System.Drawing.Size(125, 40)
        Me.AzButton.TabIndex = 5
        Me.AzButton.Text = "Arizona"
        Me.AzButton.UseVisualStyleBackColor = True
        '
        'CaButton
        '
        Me.CaButton.Location = New System.Drawing.Point(18, 151)
        Me.CaButton.Name = "CaButton"
        Me.CaButton.Size = New System.Drawing.Size(125, 40)
        Me.CaButton.TabIndex = 6
        Me.CaButton.Text = "California"
        Me.CaButton.UseVisualStyleBackColor = True
        '
        'CoButton
        '
        Me.CoButton.Location = New System.Drawing.Point(18, 197)
        Me.CoButton.Name = "CoButton"
        Me.CoButton.Size = New System.Drawing.Size(125, 40)
        Me.CoButton.TabIndex = 7
        Me.CoButton.Text = "Colorado"
        Me.CoButton.UseVisualStyleBackColor = True
        '
        'IdButton
        '
        Me.IdButton.Location = New System.Drawing.Point(18, 243)
        Me.IdButton.Name = "IdButton"
        Me.IdButton.Size = New System.Drawing.Size(125, 40)
        Me.IdButton.TabIndex = 8
        Me.IdButton.Text = "Idaho"
        Me.IdButton.UseVisualStyleBackColor = True
        '
        'NvButton
        '
        Me.NvButton.Location = New System.Drawing.Point(151, 59)
        Me.NvButton.Name = "NvButton"
        Me.NvButton.Size = New System.Drawing.Size(125, 40)
        Me.NvButton.TabIndex = 4
        Me.NvButton.Text = "Nevada"
        Me.NvButton.UseVisualStyleBackColor = True
        '
        'OrButton
        '
        Me.OrButton.Location = New System.Drawing.Point(151, 105)
        Me.OrButton.Name = "OrButton"
        Me.OrButton.Size = New System.Drawing.Size(125, 40)
        Me.OrButton.TabIndex = 5
        Me.OrButton.Text = "Oregon"
        Me.OrButton.UseVisualStyleBackColor = True
        '
        'UtButton
        '
        Me.UtButton.Location = New System.Drawing.Point(151, 151)
        Me.UtButton.Name = "UtButton"
        Me.UtButton.Size = New System.Drawing.Size(125, 40)
        Me.UtButton.TabIndex = 6
        Me.UtButton.Text = "Utah"
        Me.UtButton.UseVisualStyleBackColor = True
        '
        'WaButton
        '
        Me.WaButton.Location = New System.Drawing.Point(151, 197)
        Me.WaButton.Name = "WaButton"
        Me.WaButton.Size = New System.Drawing.Size(125, 40)
        Me.WaButton.TabIndex = 7
        Me.WaButton.Text = "Washington"
        Me.WaButton.UseVisualStyleBackColor = True
        '
        'WyButton
        '
        Me.WyButton.Location = New System.Drawing.Point(151, 243)
        Me.WyButton.Name = "WyButton"
        Me.WyButton.Size = New System.Drawing.Size(125, 40)
        Me.WyButton.TabIndex = 8
        Me.WyButton.Text = "Wyoming"
        Me.WyButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(149, 289)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(125, 50)
        Me.ResetButton.TabIndex = 3
        Me.ResetButton.Text = "&Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'StateFlags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 357)
        Me.Controls.Add(Me.WyButton)
        Me.Controls.Add(Me.IdButton)
        Me.Controls.Add(Me.WaButton)
        Me.Controls.Add(Me.CoButton)
        Me.Controls.Add(Me.UtButton)
        Me.Controls.Add(Me.CaButton)
        Me.Controls.Add(Me.OrButton)
        Me.Controls.Add(Me.AzButton)
        Me.Controls.Add(Me.NvButton)
        Me.Controls.Add(Me.AlButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "StateFlags"
        Me.Text = "State Flags"
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.DisplayGroupBox.PerformLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DisplayGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Exit_Button As Button
    Friend WithEvents AlButton As Button
    Friend WithEvents AzButton As Button
    Friend WithEvents CaButton As Button
    Friend WithEvents CoButton As Button
    Friend WithEvents IdButton As Button
    Friend WithEvents NvButton As Button
    Friend WithEvents OrButton As Button
    Friend WithEvents UtButton As Button
    Friend WithEvents WaButton As Button
    Friend WithEvents WyButton As Button
    Friend WithEvents FlagPictureBox As PictureBox
    Friend WithEvents UsaLabel As Label
    Friend WithEvents ResetButton As Button
End Class
