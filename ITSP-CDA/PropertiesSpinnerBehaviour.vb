Public Class PropertiesSpinnerBehaviour
    Public ReadOnly Property bhs As mstns.SpinnerBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhs = CDAMain.currentBehaviour.Spinner
                If Not bhs Is Nothing Then
                    Return bhs
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property
    Private Sub cbxDirection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDirection.SelectedIndexChanged
        If Not bhs Is Nothing Then
            bhs.Direction = cbxDirection.SelectedItem.ToString
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxTextObject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTextObject.SelectedIndexChanged
        If Not bhs Is Nothing Then
            bhs.TextAreaObject = cbxTextObject.SelectedItem.ToString
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinStepSize_EditValueChanged(sender As Object, e As EventArgs) Handles spinStepSize.EditValueChanged
        If Not bhs Is Nothing Then
            bhs.StepSize = CDec(spinStepSize.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinDecimalPoints_EditValueChanged(sender As Object, e As EventArgs) Handles spinDecimalPoints.EditValueChanged
        If Not bhs Is Nothing Then
            bhs.DecimalPoints = CInt(spinDecimalPoints.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinMinVal_EditValueChanged(sender As Object, e As EventArgs) Handles spinMinVal.EditValueChanged
        If Not bhs Is Nothing Then
            bhs.MinVal = CDec(spinMinVal.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinMaxVal_EditValueChanged(sender As Object, e As EventArgs) Handles spinMaxVal.EditValueChanged
        If Not bhs Is Nothing Then
            bhs.MaxVal = CDec(spinMaxVal.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub txtUnits_EditValueChanged(sender As Object, e As EventArgs) Handles txtUnits.EditValueChanged
        If Not bhs Is Nothing Then
            bhs.Units = txtUnits.EditValue.ToString
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbJudgeOnClick_CheckedChanged(sender As Object, e As EventArgs) Handles cbJudgeOnClick.CheckedChanged
        If Not bhs Is Nothing Then
            bhs.JudgeOnClick = cbJudgeOnClick.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinDecimalPoints_GotFocus(sender As Object, e As EventArgs) Handles spinDecimalPoints.GotFocus, spinMaxVal.GotFocus, spinMinVal.GotFocus, spinStepSize.GotFocus
        CDAMain.allowKeys = False
    End Sub
    Private Sub spinDecimalPoints_LostFocus(sender As Object, e As EventArgs) Handles spinDecimalPoints.LostFocus, spinMaxVal.LostFocus, spinMinVal.LostFocus, spinStepSize.LostFocus
        CDAMain.allowKeys = True
    End Sub

    Private Sub PropertiesSpinnerBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "Spinner" & ".html")
    End Sub
End Class
