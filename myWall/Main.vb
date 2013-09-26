Module Main

#Region "Application Information"

	Private AppVersion As String = "1.0.0.5"
	Private AppVersionType As String = "Beta" ' Alpha/Beta

	Public ReadOnly Property ApplicationName() As String
		Get
			Return Application.ProductName
		End Get
	End Property

	Public ReadOnly Property ApplicationVersion() As String
		Get
			Return AppVersion & " " & AppVersionType
		End Get
	End Property

	Public ReadOnly Property ApplicationVersionShort() As String
		Get
			Return Microsoft.VisualBasic.Left(ApplicationVersion, "_._".Length)
		End Get
	End Property

	Public ReadOnly Property ApplicationInfo() As String
		Get
			If Settings.SHOW_VERSION_IN_TITLE Then
				Return ApplicationName & " " & ApplicationVersionShort
			Else
				Return ApplicationName
			End If
		End Get
	End Property
#End Region

#Region "Methods"

	Public Function GetWindowText(Optional ByVal Description As String = Nothing) As String
		If Description = Nothing Then
			Return ApplicationInfo
		Else
			Return Description & " - " & ApplicationInfo
		End If
	End Function

	Public Sub ConfigureWindow(ByRef Window As Form, Optional ByVal Description As String = Nothing)
		With Window
			.Text = GetWindowText(Description)
			.Icon = My.Resources.Icon
		End With
	End Sub

	Public Sub ConfigureWindow(ByRef Window As OpenFileDialog, Optional ByVal Description As String = Nothing)
		Window.Title = GetWindowText(Description)
	End Sub
#End Region

End Module