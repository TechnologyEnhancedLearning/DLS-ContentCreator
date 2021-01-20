Public Class PropertiesResizeBehaviour
    Public ReadOnly Property bhr As mstns.ResizeBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhr = CDAMain.currentBehaviour.Resize
                If Not bhr Is Nothing Then
                    Return bhr
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property
    Private Sub cbxResizeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxResizeType.SelectedIndexChanged
        If Not bhr Is Nothing Then
            bhr.ResizeType = cbxResizeType.SelectedItem.ToString
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinMaxWidth_EditValueChanged(sender As Object, e As EventArgs) Handles spinMaxWidth.EditValueChanged
        If Not bhr Is Nothing Then
            bhr.MaxWidth = CInt(spinMaxWidth.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinMaxHeight_EditValueChanged(sender As Object, e As EventArgs) Handles spinMaxHeight.EditValueChanged
        If Not bhr Is Nothing Then
            bhr.MaxHeight = CInt(spinMaxHeight.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinMinReqWidth_EditValueChanged(sender As Object, e As EventArgs) Handles spinMinReqWidth.EditValueChanged
        If Not bhr Is Nothing Then
            bhr.MinRequiredWidth = CInt(spinMinReqWidth.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinMinReqHeight_EditValueChanged(sender As Object, e As EventArgs) Handles spinMinReqHeight.EditValueChanged
        If Not bhr Is Nothing Then
            bhr.MinRequiredHeight = CInt(spinMinReqHeight.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinMaxReqWidth_EditValueChanged(sender As Object, e As EventArgs) Handles spinMaxReqWidth.EditValueChanged
        If Not bhr Is Nothing Then
            bhr.MaxRequiredWidth = CInt(spinMaxReqWidth.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinMaxReqHeight_EditValueChanged(sender As Object, e As EventArgs) Handles spinMaxReqHeight.EditValueChanged
        If Not bhr Is Nothing Then
            bhr.MaxRequiredHeight = CInt(spinMaxReqHeight.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxGotoPageCorrect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGotoPageCorrect.SelectedIndexChanged
        If Not bhr Is Nothing Then
            bhr.GoToPageCorrect = cbxGotoPageCorrect.SelectedItem.ToString
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxGotoPageIncorrect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGotoPageIncorrect.SelectedIndexChanged
        If Not bhr Is Nothing Then
            bhr.GoToPageIncorrect = cbxGotoPageIncorrect.SelectedItem.ToString
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbAssessCorrect_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssessCorrect.CheckedChanged
        If Not bhr Is Nothing Then
            bhr.AssessmentCorrect = cbAssessCorrect.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbAssessIncorrect_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssessIncorrect.CheckedChanged
        If Not bhr Is Nothing Then
            bhr.AssessmentIncorrect = cbAssessIncorrect.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinMaxHeight_GotFocus(sender As Object, e As EventArgs) Handles spinMaxHeight.GotFocus, spinMaxReqHeight.GotFocus, spinMaxReqWidth.GotFocus, spinMaxWidth.GotFocus, spinMinReqHeight.GotFocus, spinMinReqWidth.GotFocus, spinSnapHeight.GotFocus, spinSnapWidth.GotFocus
        CDAMain.allowKeys = False
    End Sub

    Private Sub spinMaxHeight_LostFocus(sender As Object, e As EventArgs) Handles spinMaxHeight.LostFocus, spinMaxReqHeight.LostFocus, spinMaxReqWidth.LostFocus, spinMaxWidth.LostFocus, spinMinReqHeight.LostFocus, spinMinReqWidth.LostFocus, spinSnapHeight.LostFocus, spinSnapWidth.LostFocus
        CDAMain.allowKeys = True
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LayoutControlItem10.HideToCustomization()
        LayoutControlItem11.HideToCustomization()
        LayoutControlItem12.HideToCustomization()
        LayoutControlItem13.HideToCustomization()
        If CDAMain.itspunit.Type <> "Learning" Then
            LayoutControlItem8.HideToCustomization()
            LayoutControlItem9.HideToCustomization()
        Else

        End If
    End Sub

    Private Sub spinSnapWidth_EditValueChanged(sender As Object, e As EventArgs) Handles spinSnapWidth.EditValueChanged
        If Not bhr Is Nothing Then
            bhr.SnapGridWidth = CInt(spinSnapWidth.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinSnapHeight_EditValueChanged(sender As Object, e As EventArgs) Handles spinSnapHeight.EditValueChanged
        If Not bhr Is Nothing Then
            bhr.SnapGridHeight = CInt(spinSnapHeight.EditValue)
            CDAMain.Modified = True
        End If
    End Sub
    Private Sub cbxCustomCursor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCustomCursor.SelectedIndexChanged
        If Not bhr Is Nothing Then
            bhr.CustomCursor = cbxCustomCursor.SelectedItem.ToString
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub PropertiesResizeBehaviour_HelpRequested(sender As Object, e As EventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "Resize" & ".html")
    End Sub
End Class
