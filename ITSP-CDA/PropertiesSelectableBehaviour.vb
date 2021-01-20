Public Class PropertiesSelectableBehaviour
    Public ReadOnly Property bhsb As mstns.SelectableBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhsb = CDAMain.currentBehaviour.Selectable
                If Not bhsb Is Nothing Then
                    Return bhsb
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property
    Private Sub meSelectedCSS_EditValueChanged(sender As Object, e As EventArgs) Handles meSelectedCSS.EditValueChanged
        If Not bhsb Is Nothing Then
            bhsb.SelectedCSS = meSelectedCSS.EditValue.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbMultiSelect_CheckedChanged(sender As Object, e As EventArgs) Handles cbMultiSelect.CheckedChanged
        If Not bhsb Is Nothing Then
            bhsb.MultiSelectEnabled = cbMultiSelect.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbCorrectWhenSelected_CheckedChanged(sender As Object, e As EventArgs) Handles cbCorrectWhenSelected.CheckedChanged
        If Not bhsb Is Nothing Then
            bhsb.CorrectWhenSelected = cbCorrectWhenSelected.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub PropertiesSelectableBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "Selectable" & ".html")
    End Sub
End Class
