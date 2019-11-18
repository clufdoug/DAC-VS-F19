<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockAdvisorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CalculateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MondayGroupBox = New System.Windows.Forms.GroupBox()
        Me.MondayStockPriceLabel = New System.Windows.Forms.Label()
        Me.MondayStockNameLabel = New System.Windows.Forms.Label()
        Me.MondayStockPriceTextBox = New System.Windows.Forms.TextBox()
        Me.MondayStockNameTextBox = New System.Windows.Forms.TextBox()
        Me.TuesdayGroupBox = New System.Windows.Forms.GroupBox()
        Me.TuesdayStockPriceLabel = New System.Windows.Forms.Label()
        Me.TuesdayStockNameLabel = New System.Windows.Forms.Label()
        Me.TuesdayStockPriceTextBox = New System.Windows.Forms.TextBox()
        Me.TuesdayStockNameTextBox = New System.Windows.Forms.TextBox()
        Me.WednesdayGroupBox = New System.Windows.Forms.GroupBox()
        Me.WednesdayStockPriceLabel = New System.Windows.Forms.Label()
        Me.WednesdayStockNameLabel = New System.Windows.Forms.Label()
        Me.WednesdayStockPriceTextBox = New System.Windows.Forms.TextBox()
        Me.WednesdayStockNameTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MondayGroupBox.SuspendLayout()
        Me.TuesdayGroupBox.SuspendLayout()
        Me.WednesdayGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem1, Me.ClearToolStripMenuItem1, Me.SummaryToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 70)
        '
        'CalculateToolStripMenuItem1
        '
        Me.CalculateToolStripMenuItem1.Name = "CalculateToolStripMenuItem1"
        Me.CalculateToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.CalculateToolStripMenuItem1.Text = "&Calculate"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.ClearToolStripMenuItem1.Text = "C&lear"
        '
        'SummaryToolStripMenuItem1
        '
        Me.SummaryToolStripMenuItem1.Name = "SummaryToolStripMenuItem1"
        Me.SummaryToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.SummaryToolStripMenuItem1.Text = "&Summary"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1080, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 19)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem, Me.SummaryToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 19)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CalculateToolStripMenuItem.Text = "&Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 19)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'MondayGroupBox
        '
        Me.MondayGroupBox.Controls.Add(Me.MondayStockPriceLabel)
        Me.MondayGroupBox.Controls.Add(Me.MondayStockNameLabel)
        Me.MondayGroupBox.Controls.Add(Me.MondayStockPriceTextBox)
        Me.MondayGroupBox.Controls.Add(Me.MondayStockNameTextBox)
        Me.MondayGroupBox.Location = New System.Drawing.Point(14, 80)
        Me.MondayGroupBox.Margin = New System.Windows.Forms.Padding(5)
        Me.MondayGroupBox.Name = "MondayGroupBox"
        Me.MondayGroupBox.Padding = New System.Windows.Forms.Padding(5)
        Me.MondayGroupBox.Size = New System.Drawing.Size(610, 98)
        Me.MondayGroupBox.TabIndex = 2
        Me.MondayGroupBox.TabStop = False
        Me.MondayGroupBox.Text = "Monday"
        '
        'MondayStockPriceLabel
        '
        Me.MondayStockPriceLabel.AutoSize = True
        Me.MondayStockPriceLabel.Location = New System.Drawing.Point(366, 29)
        Me.MondayStockPriceLabel.Name = "MondayStockPriceLabel"
        Me.MondayStockPriceLabel.Size = New System.Drawing.Size(97, 23)
        Me.MondayStockPriceLabel.TabIndex = 3
        Me.MondayStockPriceLabel.Text = "Stock Price"
        '
        'MondayStockNameLabel
        '
        Me.MondayStockNameLabel.AutoSize = True
        Me.MondayStockNameLabel.Location = New System.Drawing.Point(8, 29)
        Me.MondayStockNameLabel.Name = "MondayStockNameLabel"
        Me.MondayStockNameLabel.Size = New System.Drawing.Size(104, 23)
        Me.MondayStockNameLabel.TabIndex = 2
        Me.MondayStockNameLabel.Text = "Stock Name"
        '
        'MondayStockPriceTextBox
        '
        Me.MondayStockPriceTextBox.Location = New System.Drawing.Point(370, 55)
        Me.MondayStockPriceTextBox.Name = "MondayStockPriceTextBox"
        Me.MondayStockPriceTextBox.Size = New System.Drawing.Size(232, 31)
        Me.MondayStockPriceTextBox.TabIndex = 1
        Me.MondayStockPriceTextBox.Text = "1"
        '
        'MondayStockNameTextBox
        '
        Me.MondayStockNameTextBox.Location = New System.Drawing.Point(8, 55)
        Me.MondayStockNameTextBox.Name = "MondayStockNameTextBox"
        Me.MondayStockNameTextBox.Size = New System.Drawing.Size(354, 31)
        Me.MondayStockNameTextBox.TabIndex = 0
        Me.MondayStockNameTextBox.Text = "toby"
        '
        'TuesdayGroupBox
        '
        Me.TuesdayGroupBox.Controls.Add(Me.TuesdayStockPriceLabel)
        Me.TuesdayGroupBox.Controls.Add(Me.TuesdayStockNameLabel)
        Me.TuesdayGroupBox.Controls.Add(Me.TuesdayStockPriceTextBox)
        Me.TuesdayGroupBox.Controls.Add(Me.TuesdayStockNameTextBox)
        Me.TuesdayGroupBox.Location = New System.Drawing.Point(14, 188)
        Me.TuesdayGroupBox.Margin = New System.Windows.Forms.Padding(5)
        Me.TuesdayGroupBox.Name = "TuesdayGroupBox"
        Me.TuesdayGroupBox.Padding = New System.Windows.Forms.Padding(5)
        Me.TuesdayGroupBox.Size = New System.Drawing.Size(610, 98)
        Me.TuesdayGroupBox.TabIndex = 3
        Me.TuesdayGroupBox.TabStop = False
        Me.TuesdayGroupBox.Text = "Tuesday"
        '
        'TuesdayStockPriceLabel
        '
        Me.TuesdayStockPriceLabel.AutoSize = True
        Me.TuesdayStockPriceLabel.Location = New System.Drawing.Point(366, 29)
        Me.TuesdayStockPriceLabel.Name = "TuesdayStockPriceLabel"
        Me.TuesdayStockPriceLabel.Size = New System.Drawing.Size(97, 23)
        Me.TuesdayStockPriceLabel.TabIndex = 3
        Me.TuesdayStockPriceLabel.Text = "Stock Price"
        '
        'TuesdayStockNameLabel
        '
        Me.TuesdayStockNameLabel.AutoSize = True
        Me.TuesdayStockNameLabel.Location = New System.Drawing.Point(8, 29)
        Me.TuesdayStockNameLabel.Name = "TuesdayStockNameLabel"
        Me.TuesdayStockNameLabel.Size = New System.Drawing.Size(104, 23)
        Me.TuesdayStockNameLabel.TabIndex = 2
        Me.TuesdayStockNameLabel.Text = "Stock Name"
        '
        'TuesdayStockPriceTextBox
        '
        Me.TuesdayStockPriceTextBox.Location = New System.Drawing.Point(370, 55)
        Me.TuesdayStockPriceTextBox.Name = "TuesdayStockPriceTextBox"
        Me.TuesdayStockPriceTextBox.Size = New System.Drawing.Size(232, 31)
        Me.TuesdayStockPriceTextBox.TabIndex = 1
        Me.TuesdayStockPriceTextBox.Text = "1"
        '
        'TuesdayStockNameTextBox
        '
        Me.TuesdayStockNameTextBox.Location = New System.Drawing.Point(8, 55)
        Me.TuesdayStockNameTextBox.Name = "TuesdayStockNameTextBox"
        Me.TuesdayStockNameTextBox.Size = New System.Drawing.Size(354, 31)
        Me.TuesdayStockNameTextBox.TabIndex = 0
        Me.TuesdayStockNameTextBox.Text = "1"
        '
        'WednesdayGroupBox
        '
        Me.WednesdayGroupBox.Controls.Add(Me.WednesdayStockPriceLabel)
        Me.WednesdayGroupBox.Controls.Add(Me.WednesdayStockNameLabel)
        Me.WednesdayGroupBox.Controls.Add(Me.WednesdayStockPriceTextBox)
        Me.WednesdayGroupBox.Controls.Add(Me.WednesdayStockNameTextBox)
        Me.WednesdayGroupBox.Location = New System.Drawing.Point(14, 296)
        Me.WednesdayGroupBox.Margin = New System.Windows.Forms.Padding(5)
        Me.WednesdayGroupBox.Name = "WednesdayGroupBox"
        Me.WednesdayGroupBox.Padding = New System.Windows.Forms.Padding(5)
        Me.WednesdayGroupBox.Size = New System.Drawing.Size(610, 98)
        Me.WednesdayGroupBox.TabIndex = 4
        Me.WednesdayGroupBox.TabStop = False
        Me.WednesdayGroupBox.Text = "Wednesday"
        '
        'WednesdayStockPriceLabel
        '
        Me.WednesdayStockPriceLabel.AutoSize = True
        Me.WednesdayStockPriceLabel.Location = New System.Drawing.Point(366, 29)
        Me.WednesdayStockPriceLabel.Name = "WednesdayStockPriceLabel"
        Me.WednesdayStockPriceLabel.Size = New System.Drawing.Size(97, 23)
        Me.WednesdayStockPriceLabel.TabIndex = 3
        Me.WednesdayStockPriceLabel.Text = "Stock Price"
        '
        'WednesdayStockNameLabel
        '
        Me.WednesdayStockNameLabel.AutoSize = True
        Me.WednesdayStockNameLabel.Location = New System.Drawing.Point(8, 29)
        Me.WednesdayStockNameLabel.Name = "WednesdayStockNameLabel"
        Me.WednesdayStockNameLabel.Size = New System.Drawing.Size(104, 23)
        Me.WednesdayStockNameLabel.TabIndex = 2
        Me.WednesdayStockNameLabel.Text = "Stock Name"
        '
        'WednesdayStockPriceTextBox
        '
        Me.WednesdayStockPriceTextBox.Location = New System.Drawing.Point(370, 55)
        Me.WednesdayStockPriceTextBox.Name = "WednesdayStockPriceTextBox"
        Me.WednesdayStockPriceTextBox.Size = New System.Drawing.Size(232, 31)
        Me.WednesdayStockPriceTextBox.TabIndex = 1
        Me.WednesdayStockPriceTextBox.Text = "1"
        '
        'WednesdayStockNameTextBox
        '
        Me.WednesdayStockNameTextBox.Location = New System.Drawing.Point(8, 55)
        Me.WednesdayStockNameTextBox.Name = "WednesdayStockNameTextBox"
        Me.WednesdayStockNameTextBox.Size = New System.Drawing.Size(354, 31)
        Me.WednesdayStockNameTextBox.TabIndex = 0
        Me.WednesdayStockNameTextBox.Text = "1"
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(14, 402)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(300, 60)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutButton.Location = New System.Drawing.Point(324, 468)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(300, 60)
        Me.AboutButton.TabIndex = 8
        Me.AboutButton.Text = "&About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(14, 468)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(300, 60)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(324, 534)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(300, 60)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummaryButton.Location = New System.Drawing.Point(14, 534)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(300, 60)
        Me.SummaryButton.TabIndex = 9
        Me.SummaryButton.Text = "&Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'StockAdvisorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 607)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.WednesdayGroupBox)
        Me.Controls.Add(Me.TuesdayGroupBox)
        Me.Controls.Add(Me.MondayGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "StockAdvisorForm"
        Me.Text = """Just"" Rich Stock Advisor"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MondayGroupBox.ResumeLayout(False)
        Me.MondayGroupBox.PerformLayout()
        Me.TuesdayGroupBox.ResumeLayout(False)
        Me.TuesdayGroupBox.PerformLayout()
        Me.WednesdayGroupBox.ResumeLayout(False)
        Me.WednesdayGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MondayGroupBox As GroupBox
    Friend WithEvents MondayStockPriceLabel As Label
    Friend WithEvents MondayStockNameLabel As Label
    Friend WithEvents MondayStockPriceTextBox As TextBox
    Friend WithEvents MondayStockNameTextBox As TextBox
    Friend WithEvents TuesdayGroupBox As GroupBox
    Friend WithEvents TuesdayStockPriceLabel As Label
    Friend WithEvents TuesdayStockNameLabel As Label
    Friend WithEvents TuesdayStockPriceTextBox As TextBox
    Friend WithEvents TuesdayStockNameTextBox As TextBox
    Friend WithEvents WednesdayGroupBox As GroupBox
    Friend WithEvents WednesdayStockPriceLabel As Label
    Friend WithEvents WednesdayStockNameLabel As Label
    Friend WithEvents WednesdayStockPriceTextBox As TextBox
    Friend WithEvents WednesdayStockNameTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
End Class
