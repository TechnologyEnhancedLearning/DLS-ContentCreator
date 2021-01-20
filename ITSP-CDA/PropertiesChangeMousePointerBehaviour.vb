Public Class PropertiesChangeMousePointerBehaviour
    Public ReadOnly Property bhmp As mstns.ChangeMousePointerBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhmp = CDAMain.currentBehaviour.MousePointer
                If Not bhmp Is Nothing Then
                    Return bhmp
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Sub cbxMouseInCursor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMouseInCursor.SelectedIndexChanged
        If Not bhmp Is Nothing Then
            bhmp.MouseInPointer = cbxMouseInCursor.SelectedItem.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxMouseDownCursor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMouseDownCursor.SelectedIndexChanged
        If Not bhmp Is Nothing Then
            bhmp.MouseDownPointer = cbxMouseDownCursor.SelectedItem.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxCustomPointerImage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCustomPointerImage.SelectedIndexChanged
        If Not bhmp Is Nothing Then
            bhmp.CustomPointerImage = cbxCustomPointerImage.SelectedItem.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub PropertiesChangeMousePointerBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "MousePointer" & ".html")
    End Sub
End Class
