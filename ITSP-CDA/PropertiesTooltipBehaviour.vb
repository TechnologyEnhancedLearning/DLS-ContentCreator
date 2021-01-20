Public Class PropertiesTooltipBehaviour
    Public ReadOnly Property bhtt As mstns.TooltipBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhtt = CDAMain.currentBehaviour.Tooltip
                If Not bhtt Is Nothing Then
                    Return bhtt
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Sub tbTooltipTitle_TextChanged(sender As Object, e As EventArgs) Handles tbTooltipTitle.TextChanged
        If Not bhtt Is Nothing Then
            bhtt.TooltipTitle = tbTooltipTitle.Text
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub PropertiesTooltipBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "Tooltip" & ".html")
    End Sub

End Class
