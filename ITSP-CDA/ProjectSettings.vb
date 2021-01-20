Public Class ProjectSettings

	Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
		frmProjectSettings.Close()
	End Sub
	Public Sub LoadValues()
		tedUnitName.Text = CDAMain.itspunit.UnitName
		cbxUnitType.Text = CDAMain.itspunit.Type
		spinWidth.Text = CStr(CDAMain.itspunit.Width)
		spinHeight.Text = CStr(CDAMain.itspunit.Height)
		fedFontFamily.Text = CDAMain.itspunit.FontFamily
		cbEnableKeyboard.Checked = CDAMain.itspunit.UseKeyboardNavigation
		cedBrowserBKGColour.EditValue = CDAMain.itspunit.BrowserBackgroundColour
		cedPageBKGColour.EditValue = CDAMain.itspunit.PageBackgroundColour
		cbAutoresize.Checked = CDAMain.itspunit.AutoResize
		cbDisableZoom.Checked = CDAMain.itspunit.DisableMobileZoom
		spinAssessClicksWrong.Text = CStr(CDAMain.itspunit.AssessXClicksWrong)
		spinFontSize.Text = CStr(CDAMain.itspunit.FontSize)
	End Sub
	Public Sub SaveValues()
		CDAMain.itspunit.UnitName = tedUnitName.Text
		CDAMain.itspunit.Type = cbxUnitType.Text
		CDAMain.itspunit.Width = CInt(spinWidth.Text)
		CDAMain.itspunit.Height = CInt(spinHeight.Text)
		CDAMain.itspunit.FontFamily = fedFontFamily.Text
		CDAMain.itspunit.UseKeyboardNavigation = cbEnableKeyboard.Checked
		CDAMain.Modified = True
		CDAMain.itspunit.BrowserBackgroundColour = utility.ColorToHexString(cedBrowserBKGColour.Color)
		CDAMain.itspunit.PageBackgroundColour = utility.ColorToHexString(cedPageBKGColour.Color)
		CDAMain.XtraScrollableControl1.BackColor = cedBrowserBKGColour.Color
		CDAMain.itspunit.AutoResize = cbAutoresize.Checked
		CDAMain.itspunit.DisableMobileZoom = cbDisableZoom.Checked
		CDAMain.itspunit.AssessXClicksWrong = CInt(spinAssessClicksWrong.Text)
		If CDAMain.itspunit.FontSize <> CInt(spinFontSize.Text) Then
			CDAMain.itspunit.FontSize = CInt(spinFontSize.Text)
			For Each p As mstns.Page In CDAMain.itspunit.PageCol
				p.InstructionText = utility.FixHTMLProjectFontsize(p.InstructionText)
				p.InteractionText = utility.FixHTMLProjectFontsize(p.InteractionText)
			Next
			CDAMain.PageSettings1.ApplyChanges()
		End If
		CDAMain.UpdateProjectTypeControls()
	End Sub

    Private Sub ProjectSettings_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "ProjectSettings" & ".html")
    End Sub
End Class
