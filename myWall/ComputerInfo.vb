Imports System.Management

Public Class ComputerInfo

	Private Shared LastBootTime As Date

	Public Shared Function GetComputerInfo() As String
		Dim Info As String = ""
		Info &= "   COMPUTER INFORMATION"
		Info &= vbCrLf & "==========================="
		Info &= vbCrLf & "Name:                        " & ComputerInfo.Name
		Info &= vbCrLf & "Boot Time:                   " & ComputerInfo.BootTime
		Info &= vbCrLf & "IP Address:                  " & ComputerInfo.IP
		Info &= vbCrLf & "Domain:                      " & ComputerInfo.UserDomain
		Info &= vbCrLf & "Username:                    " & ComputerInfo.Username
		Info &= vbCrLf & "Physical Memory:  Total:     " & ComputerInfo.TotalPhysicalMemory
		Info &= vbCrLf & "                  Avaliable: " & ComputerInfo.AvaliablePhysicalMemory
		Info &= vbCrLf & "Virtual Memory:   Total:     " & ComputerInfo.TotalVirtualMemory
		Info &= vbCrLf & "                  Avaliable: " & ComputerInfo.AvaliableVirtualMemory
		Info &= vbCrLf & "Operating System: Name:      " & ComputerInfo.OperatingSystemFullName
		Info &= vbCrLf & "                  Platform:  " & ComputerInfo.OperatingSystemPlatform
		Info &= vbCrLf & "                  Version:   " & ComputerInfo.OperatingSystemVersion
		Return Info
	End Function

	Public Shared ReadOnly Property Name() As String
		Get
			Return My.Computer.Name
		End Get
	End Property

	Public Shared ReadOnly Property IP() As String
		Get
			Try
				Dim query As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration")
				Dim queryCollection As ManagementObjectCollection = query.Get()
				Dim mo As ManagementObject

				For Each mo In queryCollection
					If CType(mo("IPEnabled"), Boolean) = True Then
						Dim addresses() As String = CType(mo("IPAddress"), String())
						Dim subnets() As String = CType(mo("IPSubnet"), String())
						Dim s As String
						Dim a As Integer = 0
						For Each s In addresses
							Return s
							a += 1
							If a = 1 Then
								Exit For
							End If
						Next
					End If
				Next mo
			Catch ex As Exception
				Return "Not found!"
			End Try
			Return ""
		End Get
	End Property

	Public Shared ReadOnly Property Username() As String
		Get
			Return Environment.UserName
		End Get
	End Property

	Public Shared ReadOnly Property UserDomain() As String
		Get
			Return Environment.UserDomainName
		End Get
	End Property

	Public Shared ReadOnly Property BootTime() As Date
		Get
			If LastBootTime = Nothing Then LastBootTime = Now
			Return LastBootTime
		End Get
	End Property

	Public Shared ReadOnly Property AvaliablePhysicalMemory() As String
		Get
			Return My.Computer.Info.AvailablePhysicalMemory
		End Get
	End Property

	Public Shared ReadOnly Property TotalPhysicalMemory() As String
		Get
			Return My.Computer.Info.TotalPhysicalMemory
		End Get
	End Property

	Public Shared ReadOnly Property AvaliableVirtualMemory() As String
		Get
			Return My.Computer.Info.AvailableVirtualMemory
		End Get
	End Property

	Public Shared ReadOnly Property TotalVirtualMemory() As String
		Get
			Return My.Computer.Info.TotalVirtualMemory
		End Get
	End Property

	Public Shared ReadOnly Property OperatingSystemFullName() As String
		Get
			Return My.Computer.Info.OSFullName
		End Get
	End Property

	Public Shared ReadOnly Property OperatingSystemPlatform() As String
		Get
			Return My.Computer.Info.OSPlatform
		End Get
	End Property

	Public Shared ReadOnly Property OperatingSystemVersion() As String
		Get
			Return My.Computer.Info.OSVersion
		End Get
	End Property

	Public Shared Sub SetBootTime(ByVal NewValue As Date)
		LastBootTime = NewValue
	End Sub
End Class
