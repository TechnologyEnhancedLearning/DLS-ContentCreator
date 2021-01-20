Public Class PropertiesCustomJavaScriptBehaviour
	Public ReadOnly Property bhjs As mstns.CustomJavaScriptBehaviour
		Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhjs = CDAMain.currentBehaviour.CustomJavaScript
                If Not bhjs Is Nothing Then
                    Return bhjs
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
		End Get
    End Property

    Private Sub meditJSString_GotFocus(sender As Object, e As EventArgs) Handles meditJSString.GotFocus
        CDAMain.allowKeys = False
    End Sub

    Private Sub meditJSString_LostFocus(sender As Object, e As EventArgs) Handles meditJSString.LostFocus
        CDAMain.allowKeys = True
    End Sub

    Private Sub meditJSString_EditValueChanged(sender As Object, e As EventArgs) Handles meditJSString.TextChanged
        If Not bhjs Is Nothing Then
            bhjs.JavaScriptString = meditJSString.EditValue.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub PropertiesCustomJavaScriptBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "CustomJavaScript" & ".html")
    End Sub
End Class
