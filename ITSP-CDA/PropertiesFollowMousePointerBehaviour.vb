Public Class PropertiesFollowMousePointerBehaviour
    Public ReadOnly Property bhfm As mstns.FollowMouseBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhfm = CDAMain.currentBehaviour.FollowMouse
                If Not bhfm Is Nothing Then
                    Return bhfm
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Sub spinOffsetHPixels_EditValueChanged(sender As Object, e As EventArgs) Handles spinOffsetHPixels.EditValueChanged
        If Not bhfm Is Nothing Then
            bhfm.OffsetHPixels = CInt(spinOffsetHPixels.EditValue.ToString())
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinOffsetVPixels_EditValueChanged(sender As Object, e As EventArgs) Handles spinOffsetVPixels.EditValueChanged
        If Not bhfm Is Nothing Then
            bhfm.OffsetVPixels = CInt(spinOffsetVPixels.EditValue.ToString())
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinOffsetHPixels_GotFocus(sender As Object, e As EventArgs) Handles spinOffsetHPixels.GotFocus, spinOffsetVPixels.GotFocus
        CDAMain.allowKeys = False
    End Sub

    Private Sub spinOffsetHPixels_LostFocus(sender As Object, e As EventArgs) Handles spinOffsetHPixels.LostFocus, spinOffsetVPixels.LostFocus
        CDAMain.allowKeys = True
    End Sub

    Private Sub PropertiesFollowMousePointerBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "FollowMouse" & ".html")
    End Sub
End Class
