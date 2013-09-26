Public Class FormSettings

	Private Sub FormSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		ConfigureWindow(Me, "Settings")
		LoadSettings()
	End Sub

	Private Sub LoadSettings()
		LinkLabelStartupNoteAutostartPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Startup)

		CheckBoxStartupStartWallpaper.Checked = My.Settings.StartWallpaperChangeOnStartup
		CheckBoxComputerInfoShow.Checked = My.Settings.ComputerInfoShow
		TextBoxWallpaperLocation.Text = My.Settings.WallpaperLocation
		TextBoxComputerInfoFont.Text = My.Settings.ComputerInfoFont.Name & ", " & My.Settings.ComputerInfoFont.SizeInPoints & "pt"
		FontDialogComputerInfoFont.Font = My.Settings.ComputerInfoFont
		NumericUpDownComputerInfoX.Value = My.Settings.ComputerInfoX
		NumericUpDownComputerInfoY.Value = My.Settings.ComputerInfoY
	End Sub

	Private Sub SaveSettings()
		My.Settings.StartWallpaperChangeOnStartup = CheckBoxStartupStartWallpaper.Checked
		My.Settings.ComputerInfoShow = CheckBoxComputerInfoShow.Checked
		My.Settings.WallpaperLocation = TextBoxWallpaperLocation.Text
		My.Settings.ComputerInfoFont = FontDialogComputerInfoFont.Font
		My.Settings.ComputerInfoX = NumericUpDownComputerInfoX.Value
		My.Settings.ComputerInfoY = NumericUpDownComputerInfoY.Value
	End Sub

	Private Sub ButtonComputerInfoFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonComputerInfoFont.Click
		FontDialogComputerInfoFont.ShowDialog()
		TextBoxComputerInfoFont.Text = FontDialogComputerInfoFont.Font.Name & ", " & FontDialogComputerInfoFont.Font.SizeInPoints & "pt"
	End Sub

	Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
		SaveSettings()
		Me.DialogResult = Windows.Forms.DialogResult.OK Or Windows.Forms.DialogResult.Yes
		Me.Close()
	End Sub

	Private Sub CheckBoxComputerInfoShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxComputerInfoShow.CheckedChanged
		Dim State As Boolean = CheckBoxComputerInfoShow.Checked
		LabelComputerInfoFont.Enabled = State
		LabelComputerInfoX.Enabled = State
		LabelComputerInfoY.Enabled = State
		GroupBoxComputerInfoLocation.Enabled = State
		TextBoxComputerInfoFont.Enabled = State
		ButtonComputerInfoFont.Enabled = State
		NumericUpDownComputerInfoX.Enabled = State
		NumericUpDownComputerInfoY.Enabled = State
	End Sub

	Private Sub LinkLabelStartupNoteAutostartPath_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelStartupNoteAutostartPath.LinkClicked
		Shell("explorer " & Environment.GetFolderPath(Environment.SpecialFolder.Startup), AppWinStyle.NormalFocus)
	End Sub
End Class