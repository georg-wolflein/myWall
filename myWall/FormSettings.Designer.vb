<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.GroupBoxWallpaper = New System.Windows.Forms.GroupBox
		Me.TextBoxWallpaperLocation = New System.Windows.Forms.TextBox
		Me.LabelWallpaperSave = New System.Windows.Forms.Label
		Me.GroupBoxComputerInfo = New System.Windows.Forms.GroupBox
		Me.GroupBoxComputerInfoLocation = New System.Windows.Forms.GroupBox
		Me.LabelComputerInfoY = New System.Windows.Forms.Label
		Me.LabelComputerInfoX = New System.Windows.Forms.Label
		Me.NumericUpDownComputerInfoY = New System.Windows.Forms.NumericUpDown
		Me.NumericUpDownComputerInfoX = New System.Windows.Forms.NumericUpDown
		Me.TextBoxComputerInfoFont = New System.Windows.Forms.TextBox
		Me.LabelComputerInfoFont = New System.Windows.Forms.Label
		Me.ButtonComputerInfoFont = New System.Windows.Forms.Button
		Me.CheckBoxComputerInfoShow = New System.Windows.Forms.CheckBox
		Me.FontDialogComputerInfoFont = New System.Windows.Forms.FontDialog
		Me.ButtonSave = New System.Windows.Forms.Button
		Me.GroupBoxStartup = New System.Windows.Forms.GroupBox
		Me.LinkLabelStartupNoteAutostartPath = New System.Windows.Forms.LinkLabel
		Me.LabelStartupNote = New System.Windows.Forms.Label
		Me.LabelStartupNoteText = New System.Windows.Forms.Label
		Me.CheckBoxStartupStartWallpaper = New System.Windows.Forms.CheckBox
		Me.GroupBoxWallpaper.SuspendLayout()
		Me.GroupBoxComputerInfo.SuspendLayout()
		Me.GroupBoxComputerInfoLocation.SuspendLayout()
		CType(Me.NumericUpDownComputerInfoY, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NumericUpDownComputerInfoX, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxStartup.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBoxWallpaper
		'
		Me.GroupBoxWallpaper.Controls.Add(Me.TextBoxWallpaperLocation)
		Me.GroupBoxWallpaper.Controls.Add(Me.LabelWallpaperSave)
		Me.GroupBoxWallpaper.Location = New System.Drawing.Point(12, 89)
		Me.GroupBoxWallpaper.Name = "GroupBoxWallpaper"
		Me.GroupBoxWallpaper.Size = New System.Drawing.Size(448, 48)
		Me.GroupBoxWallpaper.TabIndex = 0
		Me.GroupBoxWallpaper.TabStop = False
		Me.GroupBoxWallpaper.Text = "Wallpaper"
		'
		'TextBoxWallpaperLocation
		'
		Me.TextBoxWallpaperLocation.Location = New System.Drawing.Point(66, 19)
		Me.TextBoxWallpaperLocation.Name = "TextBoxWallpaperLocation"
		Me.TextBoxWallpaperLocation.Size = New System.Drawing.Size(375, 20)
		Me.TextBoxWallpaperLocation.TabIndex = 1
		'
		'LabelWallpaperSave
		'
		Me.LabelWallpaperSave.AutoSize = True
		Me.LabelWallpaperSave.Location = New System.Drawing.Point(6, 22)
		Me.LabelWallpaperSave.Name = "LabelWallpaperSave"
		Me.LabelWallpaperSave.Size = New System.Drawing.Size(54, 13)
		Me.LabelWallpaperSave.TabIndex = 0
		Me.LabelWallpaperSave.Text = "Location: "
		'
		'GroupBoxComputerInfo
		'
		Me.GroupBoxComputerInfo.Controls.Add(Me.GroupBoxComputerInfoLocation)
		Me.GroupBoxComputerInfo.Controls.Add(Me.TextBoxComputerInfoFont)
		Me.GroupBoxComputerInfo.Controls.Add(Me.LabelComputerInfoFont)
		Me.GroupBoxComputerInfo.Controls.Add(Me.ButtonComputerInfoFont)
		Me.GroupBoxComputerInfo.Controls.Add(Me.CheckBoxComputerInfoShow)
		Me.GroupBoxComputerInfo.Location = New System.Drawing.Point(12, 143)
		Me.GroupBoxComputerInfo.Name = "GroupBoxComputerInfo"
		Me.GroupBoxComputerInfo.Size = New System.Drawing.Size(448, 102)
		Me.GroupBoxComputerInfo.TabIndex = 1
		Me.GroupBoxComputerInfo.TabStop = False
		Me.GroupBoxComputerInfo.Text = "Computer Info"
		'
		'GroupBoxComputerInfoLocation
		'
		Me.GroupBoxComputerInfoLocation.Controls.Add(Me.LabelComputerInfoY)
		Me.GroupBoxComputerInfoLocation.Controls.Add(Me.LabelComputerInfoX)
		Me.GroupBoxComputerInfoLocation.Controls.Add(Me.NumericUpDownComputerInfoY)
		Me.GroupBoxComputerInfoLocation.Controls.Add(Me.NumericUpDownComputerInfoX)
		Me.GroupBoxComputerInfoLocation.Location = New System.Drawing.Point(333, 19)
		Me.GroupBoxComputerInfoLocation.Name = "GroupBoxComputerInfoLocation"
		Me.GroupBoxComputerInfoLocation.Size = New System.Drawing.Size(108, 72)
		Me.GroupBoxComputerInfoLocation.TabIndex = 4
		Me.GroupBoxComputerInfoLocation.TabStop = False
		Me.GroupBoxComputerInfoLocation.Text = "Location (Pixels)"
		'
		'LabelComputerInfoY
		'
		Me.LabelComputerInfoY.AutoSize = True
		Me.LabelComputerInfoY.Location = New System.Drawing.Point(6, 47)
		Me.LabelComputerInfoY.Name = "LabelComputerInfoY"
		Me.LabelComputerInfoY.Size = New System.Drawing.Size(20, 13)
		Me.LabelComputerInfoY.TabIndex = 6
		Me.LabelComputerInfoY.Text = "Y: "
		'
		'LabelComputerInfoX
		'
		Me.LabelComputerInfoX.AutoSize = True
		Me.LabelComputerInfoX.Location = New System.Drawing.Point(6, 21)
		Me.LabelComputerInfoX.Name = "LabelComputerInfoX"
		Me.LabelComputerInfoX.Size = New System.Drawing.Size(20, 13)
		Me.LabelComputerInfoX.TabIndex = 1
		Me.LabelComputerInfoX.Text = "X: "
		'
		'NumericUpDownComputerInfoY
		'
		Me.NumericUpDownComputerInfoY.Location = New System.Drawing.Point(32, 45)
		Me.NumericUpDownComputerInfoY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
		Me.NumericUpDownComputerInfoY.Name = "NumericUpDownComputerInfoY"
		Me.NumericUpDownComputerInfoY.Size = New System.Drawing.Size(65, 20)
		Me.NumericUpDownComputerInfoY.TabIndex = 5
		'
		'NumericUpDownComputerInfoX
		'
		Me.NumericUpDownComputerInfoX.Location = New System.Drawing.Point(32, 19)
		Me.NumericUpDownComputerInfoX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
		Me.NumericUpDownComputerInfoX.Name = "NumericUpDownComputerInfoX"
		Me.NumericUpDownComputerInfoX.Size = New System.Drawing.Size(65, 20)
		Me.NumericUpDownComputerInfoX.TabIndex = 0
		'
		'TextBoxComputerInfoFont
		'
		Me.TextBoxComputerInfoFont.Location = New System.Drawing.Point(66, 42)
		Me.TextBoxComputerInfoFont.Name = "TextBoxComputerInfoFont"
		Me.TextBoxComputerInfoFont.ReadOnly = True
		Me.TextBoxComputerInfoFont.Size = New System.Drawing.Size(160, 20)
		Me.TextBoxComputerInfoFont.TabIndex = 3
		'
		'LabelComputerInfoFont
		'
		Me.LabelComputerInfoFont.AutoSize = True
		Me.LabelComputerInfoFont.Location = New System.Drawing.Point(6, 45)
		Me.LabelComputerInfoFont.Name = "LabelComputerInfoFont"
		Me.LabelComputerInfoFont.Size = New System.Drawing.Size(34, 13)
		Me.LabelComputerInfoFont.TabIndex = 2
		Me.LabelComputerInfoFont.Text = "Font: "
		'
		'ButtonComputerInfoFont
		'
		Me.ButtonComputerInfoFont.Location = New System.Drawing.Point(232, 40)
		Me.ButtonComputerInfoFont.Name = "ButtonComputerInfoFont"
		Me.ButtonComputerInfoFont.Size = New System.Drawing.Size(95, 23)
		Me.ButtonComputerInfoFont.TabIndex = 1
		Me.ButtonComputerInfoFont.Text = "Change Font"
		Me.ButtonComputerInfoFont.UseVisualStyleBackColor = True
		'
		'CheckBoxComputerInfoShow
		'
		Me.CheckBoxComputerInfoShow.AutoSize = True
		Me.CheckBoxComputerInfoShow.Location = New System.Drawing.Point(9, 19)
		Me.CheckBoxComputerInfoShow.Name = "CheckBoxComputerInfoShow"
		Me.CheckBoxComputerInfoShow.Size = New System.Drawing.Size(217, 17)
		Me.CheckBoxComputerInfoShow.TabIndex = 0
		Me.CheckBoxComputerInfoShow.Text = "Show computer information on wallpaper"
		Me.CheckBoxComputerInfoShow.UseVisualStyleBackColor = True
		'
		'ButtonSave
		'
		Me.ButtonSave.Location = New System.Drawing.Point(12, 251)
		Me.ButtonSave.Name = "ButtonSave"
		Me.ButtonSave.Size = New System.Drawing.Size(448, 51)
		Me.ButtonSave.TabIndex = 2
		Me.ButtonSave.Text = "Save and Exit"
		Me.ButtonSave.UseVisualStyleBackColor = True
		'
		'GroupBoxStartup
		'
		Me.GroupBoxStartup.Controls.Add(Me.LinkLabelStartupNoteAutostartPath)
		Me.GroupBoxStartup.Controls.Add(Me.LabelStartupNote)
		Me.GroupBoxStartup.Controls.Add(Me.LabelStartupNoteText)
		Me.GroupBoxStartup.Controls.Add(Me.CheckBoxStartupStartWallpaper)
		Me.GroupBoxStartup.Location = New System.Drawing.Point(12, 12)
		Me.GroupBoxStartup.Name = "GroupBoxStartup"
		Me.GroupBoxStartup.Size = New System.Drawing.Size(448, 71)
		Me.GroupBoxStartup.TabIndex = 3
		Me.GroupBoxStartup.TabStop = False
		Me.GroupBoxStartup.Text = "Application Startup"
		'
		'LinkLabelStartupNoteAutostartPath
		'
		Me.LinkLabelStartupNoteAutostartPath.AutoSize = True
		Me.LinkLabelStartupNoteAutostartPath.LinkColor = System.Drawing.Color.Blue
		Me.LinkLabelStartupNoteAutostartPath.Location = New System.Drawing.Point(45, 52)
		Me.LinkLabelStartupNoteAutostartPath.Name = "LinkLabelStartupNoteAutostartPath"
		Me.LinkLabelStartupNoteAutostartPath.Size = New System.Drawing.Size(174, 13)
		Me.LinkLabelStartupNoteAutostartPath.TabIndex = 4
		Me.LinkLabelStartupNoteAutostartPath.TabStop = True
		Me.LinkLabelStartupNoteAutostartPath.Text = "LinkLabelStartupNoteAutostartPath"
		Me.LinkLabelStartupNoteAutostartPath.VisitedLinkColor = System.Drawing.Color.Blue
		'
		'LabelStartupNote
		'
		Me.LabelStartupNote.AutoSize = True
		Me.LabelStartupNote.Location = New System.Drawing.Point(6, 39)
		Me.LabelStartupNote.Name = "LabelStartupNote"
		Me.LabelStartupNote.Size = New System.Drawing.Size(33, 13)
		Me.LabelStartupNote.TabIndex = 3
		Me.LabelStartupNote.Text = "Note:"
		'
		'LabelStartupNoteText
		'
		Me.LabelStartupNoteText.AutoSize = True
		Me.LabelStartupNoteText.Location = New System.Drawing.Point(45, 39)
		Me.LabelStartupNoteText.Name = "LabelStartupNoteText"
		Me.LabelStartupNoteText.Size = New System.Drawing.Size(340, 13)
		Me.LabelStartupNoteText.TabIndex = 1
		Me.LabelStartupNoteText.Text = "Put this application into the autostart folder for accurate boot time data!"
		'
		'CheckBoxStartupStartWallpaper
		'
		Me.CheckBoxStartupStartWallpaper.AutoSize = True
		Me.CheckBoxStartupStartWallpaper.Location = New System.Drawing.Point(9, 19)
		Me.CheckBoxStartupStartWallpaper.Name = "CheckBoxStartupStartWallpaper"
		Me.CheckBoxStartupStartWallpaper.Size = New System.Drawing.Size(249, 17)
		Me.CheckBoxStartupStartWallpaper.TabIndex = 0
		Me.CheckBoxStartupStartWallpaper.Text = "Start wallpaper slideshow on application startup"
		Me.CheckBoxStartupStartWallpaper.UseVisualStyleBackColor = True
		'
		'FormSettings
		'
		Me.AcceptButton = Me.ButtonSave
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(466, 312)
		Me.Controls.Add(Me.GroupBoxStartup)
		Me.Controls.Add(Me.ButtonSave)
		Me.Controls.Add(Me.GroupBoxComputerInfo)
		Me.Controls.Add(Me.GroupBoxWallpaper)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "FormSettings"
		Me.Text = "FormSettings"
		Me.GroupBoxWallpaper.ResumeLayout(False)
		Me.GroupBoxWallpaper.PerformLayout()
		Me.GroupBoxComputerInfo.ResumeLayout(False)
		Me.GroupBoxComputerInfo.PerformLayout()
		Me.GroupBoxComputerInfoLocation.ResumeLayout(False)
		Me.GroupBoxComputerInfoLocation.PerformLayout()
		CType(Me.NumericUpDownComputerInfoY, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NumericUpDownComputerInfoX, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxStartup.ResumeLayout(False)
		Me.GroupBoxStartup.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBoxWallpaper As System.Windows.Forms.GroupBox
	Friend WithEvents TextBoxWallpaperLocation As System.Windows.Forms.TextBox
	Friend WithEvents LabelWallpaperSave As System.Windows.Forms.Label
	Friend WithEvents GroupBoxComputerInfo As System.Windows.Forms.GroupBox
	Friend WithEvents CheckBoxComputerInfoShow As System.Windows.Forms.CheckBox
	Friend WithEvents ButtonComputerInfoFont As System.Windows.Forms.Button
	Friend WithEvents LabelComputerInfoFont As System.Windows.Forms.Label
	Friend WithEvents TextBoxComputerInfoFont As System.Windows.Forms.TextBox
	Friend WithEvents GroupBoxComputerInfoLocation As System.Windows.Forms.GroupBox
	Friend WithEvents LabelComputerInfoX As System.Windows.Forms.Label
	Friend WithEvents NumericUpDownComputerInfoX As System.Windows.Forms.NumericUpDown
	Friend WithEvents LabelComputerInfoY As System.Windows.Forms.Label
	Friend WithEvents NumericUpDownComputerInfoY As System.Windows.Forms.NumericUpDown
	Friend WithEvents FontDialogComputerInfoFont As System.Windows.Forms.FontDialog
	Friend WithEvents ButtonSave As System.Windows.Forms.Button
	Friend WithEvents GroupBoxStartup As System.Windows.Forms.GroupBox
	Friend WithEvents CheckBoxStartupStartWallpaper As System.Windows.Forms.CheckBox
	Friend WithEvents LabelStartupNoteText As System.Windows.Forms.Label
	Friend WithEvents LabelStartupNote As System.Windows.Forms.Label
	Friend WithEvents LinkLabelStartupNoteAutostartPath As System.Windows.Forms.LinkLabel
End Class
