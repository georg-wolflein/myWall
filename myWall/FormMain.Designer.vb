<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
		Me.components = New System.ComponentModel.Container
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
		Me.GroupBoxFiles = New System.Windows.Forms.GroupBox
		Me.ButtonFileLoad = New System.Windows.Forms.Button
		Me.ButtonFileSave = New System.Windows.Forms.Button
		Me.ButtonFileDelete = New System.Windows.Forms.Button
		Me.ButtonFileAdd = New System.Windows.Forms.Button
		Me.ListBoxFiles = New System.Windows.Forms.ListBox
		Me.GroupBoxPreview = New System.Windows.Forms.GroupBox
		Me.PictureBoxPreview = New System.Windows.Forms.PictureBox
		Me.GroupBoxSettings = New System.Windows.Forms.GroupBox
		Me.LabelChangeImageSeconds = New System.Windows.Forms.Label
		Me.LabelChangeImage = New System.Windows.Forms.Label
		Me.NumericUpDownChangeImage = New System.Windows.Forms.NumericUpDown
		Me.ButtonStart = New System.Windows.Forms.Button
		Me.TimerWallpaperChange = New System.Windows.Forms.Timer(Me.components)
		Me.ButtonStop = New System.Windows.Forms.Button
		Me.GroupBoxComputerInformation = New System.Windows.Forms.GroupBox
		Me.ButtonComputerInformationUpdate = New System.Windows.Forms.Button
		Me.TextBoxComputerInformation = New System.Windows.Forms.TextBox
		Me.ButtonMore = New System.Windows.Forms.Button
		Me.ButtonSettings = New System.Windows.Forms.Button
		Me.NotifyIconMain = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.ButtonAbout = New System.Windows.Forms.Button
		Me.GroupBoxFiles.SuspendLayout()
		Me.GroupBoxPreview.SuspendLayout()
		CType(Me.PictureBoxPreview, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxSettings.SuspendLayout()
		CType(Me.NumericUpDownChangeImage, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxComputerInformation.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBoxFiles
		'
		Me.GroupBoxFiles.Controls.Add(Me.ButtonFileLoad)
		Me.GroupBoxFiles.Controls.Add(Me.ButtonFileSave)
		Me.GroupBoxFiles.Controls.Add(Me.ButtonFileDelete)
		Me.GroupBoxFiles.Controls.Add(Me.ButtonFileAdd)
		Me.GroupBoxFiles.Controls.Add(Me.ListBoxFiles)
		Me.GroupBoxFiles.Location = New System.Drawing.Point(12, 12)
		Me.GroupBoxFiles.Name = "GroupBoxFiles"
		Me.GroupBoxFiles.Size = New System.Drawing.Size(470, 319)
		Me.GroupBoxFiles.TabIndex = 0
		Me.GroupBoxFiles.TabStop = False
		Me.GroupBoxFiles.Text = "Files"
		'
		'ButtonFileLoad
		'
		Me.ButtonFileLoad.Image = Global.myWall.My.Resources.Resources.ActionLoad
		Me.ButtonFileLoad.Location = New System.Drawing.Point(308, 289)
		Me.ButtonFileLoad.Name = "ButtonFileLoad"
		Me.ButtonFileLoad.Size = New System.Drawing.Size(75, 23)
		Me.ButtonFileLoad.TabIndex = 4
		Me.ButtonFileLoad.Text = "Load"
		Me.ButtonFileLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ButtonFileLoad.UseVisualStyleBackColor = True
		'
		'ButtonFileSave
		'
		Me.ButtonFileSave.Image = Global.myWall.My.Resources.Resources.ActionSave
		Me.ButtonFileSave.Location = New System.Drawing.Point(389, 289)
		Me.ButtonFileSave.Name = "ButtonFileSave"
		Me.ButtonFileSave.Size = New System.Drawing.Size(75, 23)
		Me.ButtonFileSave.TabIndex = 3
		Me.ButtonFileSave.Text = "Save"
		Me.ButtonFileSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ButtonFileSave.UseVisualStyleBackColor = True
		'
		'ButtonFileDelete
		'
		Me.ButtonFileDelete.Image = CType(resources.GetObject("ButtonFileDelete.Image"), System.Drawing.Image)
		Me.ButtonFileDelete.Location = New System.Drawing.Point(87, 289)
		Me.ButtonFileDelete.Name = "ButtonFileDelete"
		Me.ButtonFileDelete.Size = New System.Drawing.Size(75, 23)
		Me.ButtonFileDelete.TabIndex = 2
		Me.ButtonFileDelete.Text = "Delete"
		Me.ButtonFileDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ButtonFileDelete.UseVisualStyleBackColor = True
		'
		'ButtonFileAdd
		'
		Me.ButtonFileAdd.Image = Global.myWall.My.Resources.Resources.ActionAdd
		Me.ButtonFileAdd.Location = New System.Drawing.Point(6, 289)
		Me.ButtonFileAdd.Name = "ButtonFileAdd"
		Me.ButtonFileAdd.Size = New System.Drawing.Size(75, 23)
		Me.ButtonFileAdd.TabIndex = 1
		Me.ButtonFileAdd.Text = "Add"
		Me.ButtonFileAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ButtonFileAdd.UseVisualStyleBackColor = True
		'
		'ListBoxFiles
		'
		Me.ListBoxFiles.FormattingEnabled = True
		Me.ListBoxFiles.Location = New System.Drawing.Point(6, 19)
		Me.ListBoxFiles.Name = "ListBoxFiles"
		Me.ListBoxFiles.Size = New System.Drawing.Size(458, 264)
		Me.ListBoxFiles.TabIndex = 0
		'
		'GroupBoxPreview
		'
		Me.GroupBoxPreview.Controls.Add(Me.PictureBoxPreview)
		Me.GroupBoxPreview.Location = New System.Drawing.Point(488, 125)
		Me.GroupBoxPreview.Name = "GroupBoxPreview"
		Me.GroupBoxPreview.Size = New System.Drawing.Size(289, 170)
		Me.GroupBoxPreview.TabIndex = 1
		Me.GroupBoxPreview.TabStop = False
		Me.GroupBoxPreview.Text = "Preview"
		'
		'PictureBoxPreview
		'
		Me.PictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PictureBoxPreview.ErrorImage = Nothing
		Me.PictureBoxPreview.InitialImage = Nothing
		Me.PictureBoxPreview.Location = New System.Drawing.Point(3, 16)
		Me.PictureBoxPreview.Name = "PictureBoxPreview"
		Me.PictureBoxPreview.Size = New System.Drawing.Size(283, 151)
		Me.PictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBoxPreview.TabIndex = 0
		Me.PictureBoxPreview.TabStop = False
		'
		'GroupBoxSettings
		'
		Me.GroupBoxSettings.Controls.Add(Me.LabelChangeImageSeconds)
		Me.GroupBoxSettings.Controls.Add(Me.LabelChangeImage)
		Me.GroupBoxSettings.Controls.Add(Me.NumericUpDownChangeImage)
		Me.GroupBoxSettings.Location = New System.Drawing.Point(488, 12)
		Me.GroupBoxSettings.Name = "GroupBoxSettings"
		Me.GroupBoxSettings.Size = New System.Drawing.Size(289, 49)
		Me.GroupBoxSettings.TabIndex = 2
		Me.GroupBoxSettings.TabStop = False
		Me.GroupBoxSettings.Text = "Settings"
		'
		'LabelChangeImageSeconds
		'
		Me.LabelChangeImageSeconds.AutoSize = True
		Me.LabelChangeImageSeconds.Location = New System.Drawing.Point(234, 21)
		Me.LabelChangeImageSeconds.Name = "LabelChangeImageSeconds"
		Me.LabelChangeImageSeconds.Size = New System.Drawing.Size(47, 13)
		Me.LabelChangeImageSeconds.TabIndex = 2
		Me.LabelChangeImageSeconds.Text = "seconds"
		'
		'LabelChangeImage
		'
		Me.LabelChangeImage.AutoSize = True
		Me.LabelChangeImage.Location = New System.Drawing.Point(6, 21)
		Me.LabelChangeImage.Name = "LabelChangeImage"
		Me.LabelChangeImage.Size = New System.Drawing.Size(107, 13)
		Me.LabelChangeImage.TabIndex = 1
		Me.LabelChangeImage.Text = "Change image every "
		'
		'NumericUpDownChangeImage
		'
		Me.NumericUpDownChangeImage.Location = New System.Drawing.Point(119, 19)
		Me.NumericUpDownChangeImage.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
		Me.NumericUpDownChangeImage.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.NumericUpDownChangeImage.Name = "NumericUpDownChangeImage"
		Me.NumericUpDownChangeImage.Size = New System.Drawing.Size(109, 20)
		Me.NumericUpDownChangeImage.TabIndex = 0
		Me.NumericUpDownChangeImage.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'ButtonStart
		'
		Me.ButtonStart.Location = New System.Drawing.Point(488, 67)
		Me.ButtonStart.Name = "ButtonStart"
		Me.ButtonStart.Size = New System.Drawing.Size(191, 52)
		Me.ButtonStart.TabIndex = 3
		Me.ButtonStart.Text = "Start"
		Me.ButtonStart.UseVisualStyleBackColor = True
		'
		'TimerWallpaperChange
		'
		'
		'ButtonStop
		'
		Me.ButtonStop.Location = New System.Drawing.Point(685, 67)
		Me.ButtonStop.Name = "ButtonStop"
		Me.ButtonStop.Size = New System.Drawing.Size(92, 52)
		Me.ButtonStop.TabIndex = 4
		Me.ButtonStop.Text = "Stop"
		Me.ButtonStop.UseVisualStyleBackColor = True
		'
		'GroupBoxComputerInformation
		'
		Me.GroupBoxComputerInformation.Controls.Add(Me.ButtonComputerInformationUpdate)
		Me.GroupBoxComputerInformation.Controls.Add(Me.TextBoxComputerInformation)
		Me.GroupBoxComputerInformation.Location = New System.Drawing.Point(12, 337)
		Me.GroupBoxComputerInformation.Name = "GroupBoxComputerInformation"
		Me.GroupBoxComputerInformation.Size = New System.Drawing.Size(765, 254)
		Me.GroupBoxComputerInformation.TabIndex = 5
		Me.GroupBoxComputerInformation.TabStop = False
		Me.GroupBoxComputerInformation.Text = "Computer Information"
		'
		'ButtonComputerInformationUpdate
		'
		Me.ButtonComputerInformationUpdate.Location = New System.Drawing.Point(6, 225)
		Me.ButtonComputerInformationUpdate.Name = "ButtonComputerInformationUpdate"
		Me.ButtonComputerInformationUpdate.Size = New System.Drawing.Size(75, 23)
		Me.ButtonComputerInformationUpdate.TabIndex = 1
		Me.ButtonComputerInformationUpdate.Text = "Update"
		Me.ButtonComputerInformationUpdate.UseVisualStyleBackColor = True
		'
		'TextBoxComputerInformation
		'
		Me.TextBoxComputerInformation.Dock = System.Windows.Forms.DockStyle.Top
		Me.TextBoxComputerInformation.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxComputerInformation.Location = New System.Drawing.Point(3, 16)
		Me.TextBoxComputerInformation.Multiline = True
		Me.TextBoxComputerInformation.Name = "TextBoxComputerInformation"
		Me.TextBoxComputerInformation.ReadOnly = True
		Me.TextBoxComputerInformation.Size = New System.Drawing.Size(759, 203)
		Me.TextBoxComputerInformation.TabIndex = 0
		'
		'ButtonMore
		'
		Me.ButtonMore.Location = New System.Drawing.Point(702, 301)
		Me.ButtonMore.Name = "ButtonMore"
		Me.ButtonMore.Size = New System.Drawing.Size(75, 23)
		Me.ButtonMore.TabIndex = 6
		Me.ButtonMore.Text = "More"
		Me.ButtonMore.UseVisualStyleBackColor = True
		'
		'ButtonSettings
		'
		Me.ButtonSettings.Location = New System.Drawing.Point(491, 301)
		Me.ButtonSettings.Name = "ButtonSettings"
		Me.ButtonSettings.Size = New System.Drawing.Size(75, 23)
		Me.ButtonSettings.TabIndex = 7
		Me.ButtonSettings.Text = "Settings"
		Me.ButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ButtonSettings.UseVisualStyleBackColor = True
		'
		'NotifyIconMain
		'
		Me.NotifyIconMain.Text = "myWall"
		Me.NotifyIconMain.Visible = True
		'
		'ButtonAbout
		'
		Me.ButtonAbout.Location = New System.Drawing.Point(572, 301)
		Me.ButtonAbout.Name = "ButtonAbout"
		Me.ButtonAbout.Size = New System.Drawing.Size(75, 23)
		Me.ButtonAbout.TabIndex = 8
		Me.ButtonAbout.Text = "About"
		Me.ButtonAbout.UseVisualStyleBackColor = True
		'
		'FormMain
		'
		Me.AcceptButton = Me.ButtonStart
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(790, 603)
		Me.Controls.Add(Me.ButtonAbout)
		Me.Controls.Add(Me.ButtonSettings)
		Me.Controls.Add(Me.ButtonMore)
		Me.Controls.Add(Me.GroupBoxComputerInformation)
		Me.Controls.Add(Me.ButtonStop)
		Me.Controls.Add(Me.ButtonStart)
		Me.Controls.Add(Me.GroupBoxSettings)
		Me.Controls.Add(Me.GroupBoxPreview)
		Me.Controls.Add(Me.GroupBoxFiles)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "FormMain"
		Me.Text = "FormMain"
		Me.GroupBoxFiles.ResumeLayout(False)
		Me.GroupBoxPreview.ResumeLayout(False)
		CType(Me.PictureBoxPreview, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxSettings.ResumeLayout(False)
		Me.GroupBoxSettings.PerformLayout()
		CType(Me.NumericUpDownChangeImage, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxComputerInformation.ResumeLayout(False)
		Me.GroupBoxComputerInformation.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBoxFiles As System.Windows.Forms.GroupBox
	Friend WithEvents ListBoxFiles As System.Windows.Forms.ListBox
	Friend WithEvents ButtonFileAdd As System.Windows.Forms.Button
	Friend WithEvents ButtonFileDelete As System.Windows.Forms.Button
	Friend WithEvents GroupBoxPreview As System.Windows.Forms.GroupBox
	Friend WithEvents PictureBoxPreview As System.Windows.Forms.PictureBox
	Friend WithEvents GroupBoxSettings As System.Windows.Forms.GroupBox
	Friend WithEvents NumericUpDownChangeImage As System.Windows.Forms.NumericUpDown
	Friend WithEvents LabelChangeImageSeconds As System.Windows.Forms.Label
	Friend WithEvents LabelChangeImage As System.Windows.Forms.Label
	Friend WithEvents ButtonStart As System.Windows.Forms.Button
	Friend WithEvents TimerWallpaperChange As System.Windows.Forms.Timer
	Friend WithEvents ButtonStop As System.Windows.Forms.Button
	Friend WithEvents GroupBoxComputerInformation As System.Windows.Forms.GroupBox
	Friend WithEvents ButtonComputerInformationUpdate As System.Windows.Forms.Button
	Friend WithEvents TextBoxComputerInformation As System.Windows.Forms.TextBox
	Friend WithEvents ButtonMore As System.Windows.Forms.Button
	Friend WithEvents ButtonFileSave As System.Windows.Forms.Button
	Friend WithEvents ButtonFileLoad As System.Windows.Forms.Button
	Friend WithEvents ButtonSettings As System.Windows.Forms.Button
	Friend WithEvents NotifyIconMain As System.Windows.Forms.NotifyIcon
	Friend WithEvents ButtonAbout As System.Windows.Forms.Button

End Class
