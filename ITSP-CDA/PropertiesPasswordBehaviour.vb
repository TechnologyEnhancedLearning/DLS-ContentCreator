Public Class PropertiesPasswordBehaviour
    Public ReadOnly Property bhpw As mstns.PasswordBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhpw = CDAMain.currentBehaviour.Password
                If Not bhpw Is Nothing Then
                    Return bhpw
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property
    Private Sub tbPasswordReq_EditValueChanged(sender As Object, e As EventArgs) Handles tbPasswordReq.EditValueChanged
        If Not bhpw Is Nothing Then
            bhpw.RequiredPassword = tbPasswordReq.EditValue.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxGoToPageCorrect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGoToPageCorrect.SelectedIndexChanged
        If Not bhpw Is Nothing Then
            bhpw.GoToPageCorrect = cbxGoToPageCorrect.SelectedItem.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxGoToPageIncorrect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGoToPageIncorrect.SelectedIndexChanged
        If Not bhpw Is Nothing Then
            bhpw.GoToPageIncorrect = cbxGoToPageIncorrect.SelectedItem.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbJudgeOnEnter_CheckedChanged(sender As Object, e As EventArgs) Handles cbJudgeOnEnter.CheckedChanged
        If Not bhpw Is Nothing Then
            bhpw.JudgeOnEnter = cbJudgeOnEnter.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbJudgeOnKeyup_CheckedChanged(sender As Object, e As EventArgs) Handles cbJudgeOnKeyup.CheckedChanged
        If Not bhpw Is Nothing Then
            bhpw.JudgeOnKeyup = cbJudgeOnKeyup.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbAssessCorrect_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssessCorrect.CheckedChanged
        If Not bhpw Is Nothing Then
            bhpw.AssessCorrect = cbAssessCorrect.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbAssessIncorrect_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssessIncorrect.CheckedChanged
        If Not bhpw Is Nothing Then
            bhpw.AssessIncorrect = cbAssessIncorrect.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbHasFocus_CheckedChanged(sender As Object, e As EventArgs) Handles cbHasFocus.CheckedChanged
        If Not bhpw Is Nothing Then
            bhpw.HasFocus = cbHasFocus.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub tbPasswordReq_GotFocus(sender As Object, e As EventArgs) Handles tbPasswordReq.GotFocus
        CDAMain.allowKeys = False
    End Sub

    Private Sub tbPasswordReq_LostFocus(sender As Object, e As EventArgs) Handles tbPasswordReq.LostFocus
        CDAMain.allowKeys = True
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LayoutControlItem8.HideToCustomization()
        LayoutControlItem9.HideToCustomization()
        LayoutControlItem10.HideToCustomization()
        LayoutControlItem11.HideToCustomization()
        If CDAMain.itspunit.Type <> "Learning" Then
            LayoutControlItem6.HideToCustomization()
            LayoutControlItem7.HideToCustomization()
        End If
    End Sub

    Private Sub cbJudgeOnTab_CheckedChanged(sender As Object, e As EventArgs) Handles cbJudgeOnTab.CheckedChanged
        If Not bhpw Is Nothing Then
            bhpw.JudgeOnTab = cbJudgeOnTab.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub PropertiesPasswordBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "Password" & ".html")
    End Sub
End Class
