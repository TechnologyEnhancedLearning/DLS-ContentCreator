Public Class PropertiesCustomCssBehaviour
	Public ReadOnly Property bhcss As mstns.CustomCssBehaviour
		Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhcss = CDAMain.currentBehaviour.CustomCSS
                If Not bhcss Is Nothing Then
                    Return bhcss
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
		End Get
	End Property
    Private Sub meditStyleString_EditValueChanged(sender As Object, e As EventArgs) Handles meditStyleString.EditValueChanged
        If Not bhcss Is Nothing Then
            bhcss.StyleString = meditStyleString.EditValue.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub meditStyleString_GotFocus(sender As Object, e As EventArgs) Handles meditStyleString.GotFocus, meditCSSClasses.GotFocus
        CDAMain.allowKeys = False
    End Sub

    Private Sub meditStyleString_LostFocus(sender As Object, e As EventArgs) Handles meditStyleString.LostFocus
        CDAMain.allowKeys = True
    End Sub

    Private Sub meditCSSClasses_LostFocus(sender As Object, e As EventArgs) Handles meditCSSClasses.LostFocus
        CDAMain.allowKeys = True
        If Not bhcss Is Nothing Then
            bhcss.CSSClasses = meditCSSClasses.EditValue.ToString()
            CDAMain.Modified = True
            CDAMain.ReloadControls(False, False, False, False, False, False, True, False)
        End If
    End Sub

    Private Sub PropertiesCustomCssBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "CustomCSS" & ".html")
    End Sub
End Class
