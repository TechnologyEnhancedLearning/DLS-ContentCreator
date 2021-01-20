Public Class PropertiesMouseInteractionBehaviour
    Public ReadOnly Property bhme As mstns.MouseInteractionBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhme = CDAMain.currentBehaviour.MouseEvent
                If Not bhme Is Nothing Then
                    Return bhme
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Sub cbxMouseEvent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMouseEvent.SelectedIndexChanged
        If Not bhme Is Nothing Then
            If Not bhme.MouseEvent = cbxMouseEvent.SelectedItem.ToString() Then
                bhme.MouseEvent = cbxMouseEvent.SelectedItem.ToString()
                CDAMain.Modified = True
            End If
        End If
    End Sub
    Private Sub cbPreventFocus_CheckedChanged(sender As Object, e As EventArgs) Handles cbPreventFocus.CheckedChanged
        If Not bhme Is Nothing Then
            If Not bhme.PreventMouseDownFocus = cbPreventFocus.Checked Then
                bhme.PreventMouseDownFocus = cbPreventFocus.Checked
                CDAMain.Modified = True
            End If
        End If
    End Sub
    Private Sub cbxGotoPage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGotoPage.SelectedIndexChanged
        If Not bhme Is Nothing Then
            If Not bhme.GoToPage = cbxGotoPage.SelectedItem.ToString() Then
                bhme.GoToPage = cbxGotoPage.SelectedItem.ToString()
                CDAMain.Modified = True
            End If
        End If
    End Sub

    Private Sub cbJudgeTask_CheckedChanged(sender As Object, e As EventArgs) Handles cbJudgeTask.CheckedChanged
        If Not bhme Is Nothing Then
            If Not bhme.JudgeTask = cbJudgeTask.Checked Then
                bhme.JudgeTask = cbJudgeTask.Checked
                CDAMain.Modified = True
            End If
        End If
    End Sub

    Private Sub cbxCheckShowObjects_EditValueChanged(sender As Object, e As EventArgs) Handles cbxCheckShowObjects.EditValueChanged
        If Not bhme Is Nothing Then
            If Not bhme.ShowObjects = cbxCheckShowObjects.EditValue.ToString() Then
                bhme.ShowObjects = cbxCheckShowObjects.EditValue.ToString()
                CDAMain.Modified = True
            End If
        End If
    End Sub

    Private Sub cbxCheckHideObjects_EditValueChanged(sender As Object, e As EventArgs) Handles cbxCheckHideObjects.EditValueChanged
        If Not bhme Is Nothing Then
            If Not bhme.HideObjects = cbxCheckHideObjects.EditValue.ToString() Then
                bhme.HideObjects = cbxCheckHideObjects.EditValue.ToString()
                CDAMain.Modified = True
            End If
        End If
    End Sub

    Private Sub cbxCheckAnimate_EditValueChanged(sender As Object, e As EventArgs) Handles cbxCheckAnimate.EditValueChanged
        If Not bhme Is Nothing Then
            If Not bhme.AnimateObjects = cbxCheckAnimate.EditValue.ToString() Then
                bhme.AnimateObjects = cbxCheckAnimate.EditValue.ToString()
                CDAMain.Modified = True
            End If
        End If
    End Sub

    Private Sub cbToggle_CheckedChanged(sender As Object, e As EventArgs) Handles cbToggle.CheckedChanged
        If Not bhme Is Nothing Then
            If Not bhme.Toggle = cbToggle.Checked Then
                bhme.Toggle = cbToggle.Checked
                CDAMain.Modified = True
            End If
        End If
    End Sub

    Private Sub cbAssessCorrect_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssessCorrect.CheckedChanged
        If Not bhme Is Nothing Then
            bhme.AssessmentCorrect = cbAssessCorrect.Checked
            CDAMain.Modified = True
           
        End If
    End Sub

    Private Sub cbAssessWrong_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssessWrong.CheckedChanged
        If Not bhme Is Nothing Then
            bhme.AssessmentIncorrect = cbAssessWrong.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If CDAMain.itspunit.Type = "Learning" Then
            LayoutControlItem10.HideToCustomization()
            LayoutControlItem11.HideToCustomization()
            LayoutControlItem12.HideToCustomization()
            LayoutControlItem13.HideToCustomization()
            ' LayoutControlItem3.HideToCustomization()
            ' LayoutControlItem4.HideToCustomization()
        End If


    End Sub

    Private Sub PropertiesMouseInteractionBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "MouseInteraction" & ".html")
    End Sub
End Class
