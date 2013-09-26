<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbout
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbout))
		Me.LabelAbout = New System.Windows.Forms.Label
		Me.LabelCopyright = New System.Windows.Forms.Label
		Me.ButtonOK = New System.Windows.Forms.Button
		Me.TextBoxLicense = New System.Windows.Forms.TextBox
		Me.LabelReport = New System.Windows.Forms.Label
		Me.LinkLabelReport = New System.Windows.Forms.LinkLabel
		Me.SuspendLayout()
		'
		'LabelAbout
		'
		Me.LabelAbout.AutoSize = True
		Me.LabelAbout.Location = New System.Drawing.Point(12, 9)
		Me.LabelAbout.Name = "LabelAbout"
		Me.LabelAbout.Size = New System.Drawing.Size(61, 13)
		Me.LabelAbout.TabIndex = 0
		Me.LabelAbout.Text = "LabelAbout"
		'
		'LabelCopyright
		'
		Me.LabelCopyright.AutoSize = True
		Me.LabelCopyright.Location = New System.Drawing.Point(12, 31)
		Me.LabelCopyright.Name = "LabelCopyright"
		Me.LabelCopyright.Size = New System.Drawing.Size(260, 13)
		Me.LabelCopyright.TabIndex = 1
		Me.LabelCopyright.Text = "Copyright 2012 by Georg Wölflein. All rights reserved. "
		'
		'ButtonOK
		'
		Me.ButtonOK.Location = New System.Drawing.Point(15, 256)
		Me.ButtonOK.Name = "ButtonOK"
		Me.ButtonOK.Size = New System.Drawing.Size(257, 23)
		Me.ButtonOK.TabIndex = 2
		Me.ButtonOK.Text = "OK"
		Me.ButtonOK.UseVisualStyleBackColor = True
		'
		'TextBoxLicense
		'
		Me.TextBoxLicense.Location = New System.Drawing.Point(15, 97)
		Me.TextBoxLicense.Multiline = True
		Me.TextBoxLicense.Name = "TextBoxLicense"
		Me.TextBoxLicense.ReadOnly = True
		Me.TextBoxLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBoxLicense.Size = New System.Drawing.Size(257, 153)
		Me.TextBoxLicense.TabIndex = 3
		Me.TextBoxLicense.Text = resources.GetString("TextBoxLicense.Text")
		'
		'LabelReport
		'
		Me.LabelReport.AutoSize = True
		Me.LabelReport.Location = New System.Drawing.Point(12, 54)
		Me.LabelReport.Name = "LabelReport"
		Me.LabelReport.Size = New System.Drawing.Size(208, 13)
		Me.LabelReport.TabIndex = 4
		Me.LabelReport.Text = "Please report bugs, errors and feedback to"
		'
		'LinkLabelReport
		'
		Me.LinkLabelReport.AutoSize = True
		Me.LinkLabelReport.LinkColor = System.Drawing.Color.Blue
		Me.LinkLabelReport.Location = New System.Drawing.Point(12, 67)
		Me.LinkLabelReport.Name = "LinkLabelReport"
		Me.LinkLabelReport.Size = New System.Drawing.Size(127, 13)
		Me.LinkLabelReport.TabIndex = 5
		Me.LinkLabelReport.TabStop = True
		Me.LinkLabelReport.Text = "georg.woelflein@igefa.de"
		Me.LinkLabelReport.VisitedLinkColor = System.Drawing.Color.Blue
		'
		'FormAbout
		'
		Me.AcceptButton = Me.ButtonOK
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(280, 291)
		Me.ControlBox = False
		Me.Controls.Add(Me.LinkLabelReport)
		Me.Controls.Add(Me.LabelReport)
		Me.Controls.Add(Me.TextBoxLicense)
		Me.Controls.Add(Me.ButtonOK)
		Me.Controls.Add(Me.LabelCopyright)
		Me.Controls.Add(Me.LabelAbout)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "FormAbout"
		Me.ShowInTaskbar = False
		Me.Text = "FormAbout"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LabelAbout As System.Windows.Forms.Label
	Friend WithEvents LabelCopyright As System.Windows.Forms.Label
	Friend WithEvents ButtonOK As System.Windows.Forms.Button
	Friend WithEvents TextBoxLicense As System.Windows.Forms.TextBox
	Friend WithEvents LabelReport As System.Windows.Forms.Label
	Friend WithEvents LinkLabelReport As System.Windows.Forms.LinkLabel
End Class
