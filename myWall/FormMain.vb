Imports System.Drawing.Drawing2D

Public Class FormMain

	Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
	Private CurrentImage As Integer = 0
	Private Maximized = False ' More/Less Button

#Region "Events"

#Region "FormMain"

	Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		ConfigureWindow(Me)
		ComputerInfo.SetBootTime(Now)
		NotifyIconMain.Icon = My.Resources.Icon
		ChangeStartStopState(True)
		ChangeMaximized(False)
		LoadSettings()
		If My.Settings.StartWallpaperChangeOnStartup Then Start(False)
	End Sub

	Private Sub FormMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		SaveSettings()
		My.Settings.Save()
		NotifyIconMain.Visible = False
		NotifyIconMain.Dispose()
	End Sub
#End Region

#Region "Buttons"

	Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
		Start()
	End Sub

	Private Sub ButtonStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStop.Click
		ChangeStartStopState(True)
	End Sub

	Private Sub ButtonFileAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFileAdd.Click
		Dim FileAddDialog As New OpenFileDialog
		ConfigureWindow(FileAddDialog, "Choose file(s) to add")
		With FileAddDialog
			.Filter = "BMP Files (*.bmp)|*.bmp|PNG Files (*.png)|*.png|JPEG Files (*.jpg)|*.jpg|Other Files|*.*"
			.FilterIndex = My.Settings.LastWallpaperDirectoryFilterIndex
			.InitialDirectory = My.Settings.LastWallpaperDirectory
			.Multiselect = True
			.ShowDialog()
		End With
		My.Settings.LastWallpaperDirectoryFilterIndex = FileAddDialog.FilterIndex
		For Each CurrentFile As String In FileAddDialog.FileNames
			ListBoxFiles.Items.Add(CurrentFile)
			My.Settings.LastWallpaperDirectory = Microsoft.VisualBasic.Left(CurrentFile, CurrentFile.LastIndexOf("\"))
		Next
	End Sub

	Private Sub ButtonFileDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFileDelete.Click
		Try
			ListBoxFiles.Items.RemoveAt(ListBoxFiles.SelectedIndex)
		Catch ex As Exception
		End Try
	End Sub

	Private Sub ButtonComputerInformationUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonComputerInformationUpdate.Click
		UpdateComputerInfo()
	End Sub

	Private Sub ButtonMore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMore.Click
		ChangeMaximized(Not Maximized)
	End Sub

	Private Sub ButtonFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFileSave.Click
		SaveWallpaperDefault()
	End Sub

	Private Sub ButtonFileLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFileLoad.Click
		LoadWallpaperDefault()
	End Sub

	Private Sub ButtonSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSettings.Click
		FormSettings.ShowDialog()
		LoadSettings()
	End Sub

	Private Sub ButtonAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbout.Click
		FormAbout.ShowDialog()
	End Sub
#End Region

#Region "Other"

	Private Sub TimerWallpaperChange_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerWallpaperChange.Tick
		SetWallpaper(ListBoxFiles.Items(CurrentImage))
		ListBoxFiles.SelectedIndex = CurrentImage
		CurrentImage += 1
		If CurrentImage > ListBoxFiles.Items.Count - 1 Then
			CurrentImage = 0
		End If
	End Sub

	Private Sub ListBoxFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxFiles.SelectedIndexChanged
		Try
			PictureBoxPreview.Image = Image.FromFile(ListBoxFiles.SelectedItem)
		Catch ex As Exception
		End Try
	End Sub
#End Region
#End Region

#Region "Methods"

#Region "Wallpaper"
	Private Sub Start(Optional ByVal DisplayWarning As Boolean = True)
		Try
			If ListBoxFiles.Items.Count = 0 Then
				If DisplayWarning Then MsgBox("You must specify at least one image!", MsgBoxStyle.Information)
				Exit Sub
			End If
			TimerWallpaperChange.Interval = NumericUpDownChangeImage.Value * 1000
			ChangeStartStopState(False)
		Catch ex As Exception

		End Try
	End Sub

	Private Sub SetWallpaper(ByVal WallpaperLocation As String)
		Try
			Dim Background As Bitmap = GenerateWallpaperImage(WallpaperLocation, ComputerInfo.GetComputerInfo())
			Dim Location As String = "CurrentWallpaper.bmp"	'Environment.SystemDirectory & "\CurrentWallpaper.Bmp"
			Background.Save(Location, System.Drawing.Imaging.ImageFormat.Bmp)
			SystemParametersInfo(&H14, 0, Location, &H1 Or &H2)
		Catch ex As Exception
			NotifyIconMain.ShowBalloonTip(5000, "Error", "An exception occured while trying to set the desktop background!" & vbCrLf & vbCrLf & "Exception: " & ex.Message & vbCrLf & "Source: " & ex.Source, ToolTipIcon.Error)
		End Try
	End Sub

	Private Function GenerateWallpaperImage(ByVal Location As String, ByVal Text As String) As Bitmap
		Dim CurrentImage As Image = Image.FromFile(Location)
		Dim BitmapImage As New Bitmap(CurrentImage.Width, CurrentImage.Height)
		Dim GraphicImage As Graphics = Graphics.FromImage(BitmapImage)
		With GraphicImage
			' Set the graphics to smooth
			.SmoothingMode = SmoothingMode.AntiAlias
			' Write the text
			.DrawImage(CurrentImage, New PointF(0, 0))
			If My.Settings.ComputerInfoShow Then .DrawImage(GenerateImageText(Text), New PointF(My.Settings.ComputerInfoX, My.Settings.ComputerInfoY))
		End With
		' Clean up
		GraphicImage.Dispose()
		' Return
		Return BitmapImage
	End Function

	Private Function GenerateImageText(ByVal Text As String) As Bitmap
		Dim ScreenWidth As Integer = My.Settings.ScreenWidth
		Dim ScreenHeight As Integer = My.Settings.ScreenHeight
		Dim BitmapImage As New Bitmap(ScreenWidth, ScreenHeight)
		Dim GraphicImage As Graphics = Graphics.FromImage(BitmapImage)
		With GraphicImage
			.SmoothingMode = SmoothingMode.AntiAlias
			.DrawString(Text, My.Settings.ComputerInfoFont, Brushes.Black, New Point(0, 0))
		End With
		GraphicImage.Dispose()
		Return BitmapImage
	End Function
#End Region

#Region "Change/Update"

	Private Sub ChangeStartStopState(ByVal Start As Boolean)
		TimerWallpaperChange.Enabled = Not Start
		ButtonStart.Enabled = Start
		ListBoxFiles.Enabled = Start
		LabelChangeImage.Enabled = Start
		LabelChangeImageSeconds.Enabled = Start
		NumericUpDownChangeImage.Enabled = Start
		ButtonFileAdd.Enabled = Start
		ButtonFileDelete.Enabled = Start
		ButtonFileLoad.Enabled = Start
		ButtonFileSave.Enabled = Start
		ButtonStop.Enabled = Not Start
	End Sub

	Private Sub ChangeMaximized(ByVal NewValue As Boolean)
		Maximized = NewValue
		If Maximized Then
			ButtonMore.Text = "Less"
			Me.Height = My.Settings.HeightMax
		Else
			ButtonMore.Text = "More"
			Me.Height = My.Settings.HeightMin
		End If
		UpdateComputerInfo()
	End Sub

	Private Sub UpdateComputerInfo()
		TextBoxComputerInformation.Text = ComputerInfo.GetComputerInfo()
	End Sub
#End Region

#Region "Settings"

	Private Sub SaveWallpaperDefault()
		If ListBoxFiles.Items.Count = 0 Then Exit Sub
		Dim Files As String = ""
		For i As Integer = 0 To ListBoxFiles.Items.Count - 1
			Files &= ListBoxFiles.Items(i).ToString & Settings.WALLPAPER_SAVE_FILES_SEPARATOR
		Next i
		If Microsoft.VisualBasic.Right(Files, 1) = Settings.WALLPAPER_SAVE_FILES_SEPARATOR Then
			Files = Microsoft.VisualBasic.Left(Files, Files.Length - 1)
		End If
		My.Settings.WallpaperFiles = Files
		LoadWallpaperDefault()
	End Sub

	Private Sub LoadWallpaperDefault()
		ListBoxFiles.Items.Clear()
		If My.Settings.WallpaperFiles = "" Then Exit Sub
		For Each File As String In My.Settings.WallpaperFiles.Split(Settings.WALLPAPER_SAVE_FILES_SEPARATOR)
			ListBoxFiles.Items.Add(File)
		Next
	End Sub

	Private Sub LoadSettings()
		LoadWallpaperDefault()
		NumericUpDownChangeImage.Value = My.Settings.ChangeImage
	End Sub

	Private Sub SaveSettings()
		LoadWallpaperDefault()
		My.Settings.ChangeImage = NumericUpDownChangeImage.Value
	End Sub
#End Region
#End Region

End Class
