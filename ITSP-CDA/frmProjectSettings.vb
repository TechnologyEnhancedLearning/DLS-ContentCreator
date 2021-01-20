Public Class frmProjectSettings

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub
    Public Sub LoadValues()
        If Not CDAMain.itspunit Is Nothing Then
            ProjectSettings1.LoadValues()
        End If
    End Sub
	Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
		ProjectSettings1.SaveValues()
		CDAMain.Modified = True
		Me.Close()
	End Sub

    Private Sub frmProjectSettings_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "ProjectSettings" & ".html")
    End Sub
End Class