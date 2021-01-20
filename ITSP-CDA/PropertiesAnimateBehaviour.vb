Public Class PropertiesAnimateBehaviour
	Public ReadOnly Property bha As mstns.AnimateBehaviour
		Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bha = CDAMain.currentBehaviour.Animate
                If Not bha Is Nothing Then
                    Return bha
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
		End Get
	End Property
	Private Sub spinStartHPos_EditValueChanged(sender As Object, e As EventArgs) Handles spinStartHPos.EditValueChanged

		If Not bha Is Nothing Then
            bha.StartHPos = CInt(spinStartHPos.EditValue)
            CDAMain.Modified = True
		End If
	End Sub

	Private Sub spinStartVPos_EditValueChanged(sender As Object, e As EventArgs) Handles spinStartVPos.EditValueChanged

		If Not bha Is Nothing Then
            bha.StartVPos = CInt(spinStartVPos.EditValue)
            CDAMain.Modified = True
		End If
	End Sub

	Private Sub spinEndHPos_EditValueChanged(sender As Object, e As EventArgs) Handles spinEndHPos.EditValueChanged
		If Not bha Is Nothing Then
            bha.EndHPos = CInt(spinEndHPos.EditValue)
            CDAMain.Modified = True
		End If
	End Sub

	Private Sub spinEndVPos_EditValueChanged(sender As Object, e As EventArgs) Handles spinEndVPos.EditValueChanged

		If Not bha Is Nothing Then
            bha.EndVPos = CInt(spinEndVPos.EditValue)
            CDAMain.Modified = True
		End If
	End Sub

	Private Sub spinStartOpacity_EditValueChanged(sender As Object, e As EventArgs) Handles spinStartOpacity.EditValueChanged

		If Not bha Is Nothing Then
            bha.StartOpacity = CDec(spinStartOpacity.EditValue)
            CDAMain.Modified = True
		End If
	End Sub

	Private Sub spinEndOpacity_EditValueChanged(sender As Object, e As EventArgs) Handles spinEndOpacity.EditValueChanged

		If Not bha Is Nothing Then
            bha.EndOpacity = CDec(spinEndOpacity.EditValue)
            CDAMain.Modified = True
		End If
	End Sub

	Private Sub spinLoopCount_EditValueChanged(sender As Object, e As EventArgs) Handles spinLoopCount.EditValueChanged

		If Not bha Is Nothing Then
            bha.LoopCount = CInt(spinLoopCount.EditValue)
            CDAMain.Modified = True
		End If
	End Sub

	Private Sub spinAnimationDuration_EditValueChanged(sender As Object, e As EventArgs) Handles spinAnimationDuration.EditValueChanged

		If Not bha Is Nothing Then
			bha.AnimationDuration = CDec(spinAnimationDuration.EditValue)
		End If
	End Sub

	Private Sub spinStartDelay_EditValueChanged(sender As Object, e As EventArgs) Handles spinStartDelay.EditValueChanged

		If Not bha Is Nothing Then
            bha.AnimationDelay = CDec(spinStartDelay.EditValue)
            CDAMain.Modified = True
		End If
	End Sub

	Private Sub cbAutoStart_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoStart.CheckedChanged

		If Not bha Is Nothing Then
            bha.AutoStart = CBool(cbAutoStart.Checked)
            CDAMain.Modified = True
		End If
	End Sub

	Private Sub ddPageOnFinish_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddPageOnFinish.SelectedIndexChanged
		If Not bha Is Nothing Then
            bha.GoToPageOnFinish = CStr(ddPageOnFinish.SelectedText)
            CDAMain.Modified = True
		End If
	End Sub

    Private Sub spinEndHPos_GotFocus(sender As Object, e As EventArgs) Handles spinEndHPos.GotFocus, spinAnimationDuration.GotFocus, spinEndOpacity.GotFocus, spinEndVPos.GotFocus, spinLoopCount.GotFocus, spinStartDelay.GotFocus, spinStartHPos.GotFocus, spinStartVPos.GotFocus
        CDAMain.allowKeys = False
    End Sub

    Private Sub spinEndHPos_LostFocus(sender As Object, e As EventArgs) Handles spinEndHPos.LostFocus, spinAnimationDuration.LostFocus, spinEndOpacity.LostFocus, spinEndVPos.LostFocus, spinLoopCount.LostFocus, spinStartDelay.LostFocus, spinStartHPos.LostFocus, spinStartVPos.LostFocus
        CDAMain.allowKeys = True
    End Sub

    Private Sub PropertiesAnimateBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "Animation" & ".html")
    End Sub
End Class
