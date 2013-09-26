Public Class FormAbout

	Private Sub FormAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		ConfigureWindow(Me, "About")
		LabelAbout.Text = Main.ApplicationName & " (Version " & Main.ApplicationVersion & ")"
	End Sub

	Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
		Me.Close()
	End Sub

	Private Sub LinkLabelReport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelReport.LinkClicked
		Diagnostics.Process.Start("mailto:georg.woelflein@igefa.de?subject=myWall%20App%20Feedback&body=Description", AppWinStyle.NormalFocus)
	End Sub
End Class