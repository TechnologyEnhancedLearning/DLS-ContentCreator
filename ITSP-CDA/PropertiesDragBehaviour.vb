Public Class PropertiesDragBehaviour
    Public ReadOnly Property bhd As mstns.DragBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhd = CDAMain.currentBehaviour.Drag
                If Not bhd Is Nothing Then
                    Return bhd
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Sub cbxTargetObject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTargetObject.SelectedIndexChanged
        If Not bhd Is Nothing Then
            bhd.TargetObject = cbxTargetObject.SelectedItem.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxDragCursor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDragCursor.SelectedIndexChanged
        If Not bhd Is Nothing Then
            bhd.DragCursor = cbxDragCursor.SelectedItem.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxPageCorrect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPageCorrect.SelectedIndexChanged
        If Not bhd Is Nothing Then
            bhd.GoToPageCorrect = cbxPageCorrect.SelectedItem.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxPageWrong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPageWrong.SelectedIndexChanged
        If Not bhd Is Nothing Then
            bhd.GoToPageIncorrect = cbxPageWrong.SelectedItem.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbAssessCorrect_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssessCorrect.CheckedChanged
        If Not bhd Is Nothing Then
            bhd.AssessmentCorrect = cbAssessCorrect.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbAssessMarkWrong_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssessMarkWrong.CheckedChanged
        If Not bhd Is Nothing Then
            bhd.AssessmentIncorrect = cbAssessMarkWrong.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbReset_CheckedChanged(sender As Object, e As EventArgs) Handles cbReset.CheckedChanged
        If Not bhd Is Nothing Then
            bhd.ResetOnMouseUp = cbReset.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxCheckShowObjects_EditValueChanged(sender As Object, e As EventArgs) Handles cbxCheckShowObjects.EditValueChanged
        If Not bhd Is Nothing Then
            bhd.ShowObjectsWhenDragOver = cbxCheckShowObjects.EditValue.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbHideOnLeave_CheckedChanged(sender As Object, e As EventArgs) Handles cbHideOnLeave.CheckedChanged
        If Not bhd Is Nothing Then
            bhd.Toggle = cbHideOnLeave.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxDirection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDirection.SelectedIndexChanged
        If Not bhd Is Nothing Then
            bhd.Direction = cbxDirection.EditValue.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxLimitToObject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLimitToObject.SelectedIndexChanged
        If Not bhd Is Nothing Then
            bhd.LimitToObject = cbxLimitToObject.EditValue.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbNavigateOnMouseDown_CheckedChanged(sender As Object, e As EventArgs) Handles cbNavigateOnMouseDown.CheckedChanged
        If Not bhd Is Nothing Then
            bhd.NavigateMouseDown = cbNavigateOnMouseDown.Checked()
            CDAMain.Modified = True
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LayoutControlItem2.HideToCustomization()
        LayoutControlItem12.HideToCustomization()
        LayoutControlItem13.HideToCustomization()
        ' Add any initialization after the InitializeComponent() call.
        If CDAMain.itspunit.Type <> "Learning" Then
            LayoutControlItem3.HideToCustomization()
            LayoutControlItem4.HideToCustomization()
        End If
    End Sub

    Private Sub cbSnapTo_CheckedChanged(sender As Object, e As EventArgs) Handles cbSnapTo.CheckedChanged
        If Not bhd Is Nothing Then
            bhd.SnapToTarget = cbSnapTo.Checked()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbAnimatedReset_CheckedChanged(sender As Object, e As EventArgs) Handles cbAnimatedReset.CheckedChanged
        If Not bhd Is Nothing Then
            bhd.AnimatedReset = cbAnimatedReset.Checked()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxDropType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDropType.SelectedIndexChanged
        If Not bhd Is Nothing Then
            bhd.DropType = cbxDropType.EditValue.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinSnapWidth_EditValueChanged(sender As Object, e As EventArgs) Handles spinSnapWidth.EditValueChanged
        If Not bhd Is Nothing Then
            bhd.SnapGridWidth = CInt(spinSnapWidth.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinSnapHeight_EditValueChanged(sender As Object, e As EventArgs) Handles spinSnapHeight.EditValueChanged
        If Not bhd Is Nothing Then
            bhd.SnapGridHeight = CInt(spinSnapHeight.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub PropertiesDragBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "Drag" & ".html")
    End Sub
End Class
