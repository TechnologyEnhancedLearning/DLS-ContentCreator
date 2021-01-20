Public Class ObjectManager

    Private Sub ObjectImageList_Click(sender As Object, e As EventArgs) Handles ObjectImageList.Click
        If CDAMain.allowPreview And ObjectImageList.SelectedIndex >= 0 Then
            Dim objName As String = ObjectImageList.SelectedValue.ToString()
            CDAMain.selectedObjectID = objName
            CDAMain.SelectObject()
        End If
    End Sub

    Private Sub ObjectImageList_KeyDown(sender As Object, e As KeyEventArgs) Handles ObjectImageList.KeyDown
        If e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down OrElse e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right Then
            e.Handled = True
        End If
    End Sub

    Private Sub ObjectImageList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ObjectImageList.SelectedIndexChanged
        If CDAMain.allowPreview And ObjectImageList.SelectedIndex >= 0 And Not CDAMain.bIsObjectListReordering Then
            Dim objName As String = ObjectImageList.SelectedValue.ToString()
            CDAMain.selectedObjectID = objName
            CDAMain.SelectObject()
        End If
    End Sub

    Private Sub btnDeleteObject_Click(sender As Object, e As EventArgs) Handles btnDeleteObject.Click
        CDAMain.DeleteSelectedObject(False)
    End Sub

    Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click
        CDAMain.ReorderObject("Up")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        CDAMain.ReorderObject("Down")
    End Sub

    Private Sub btnBringToFront_Click(sender As Object, e As EventArgs) Handles btnBringToFront.Click
        CDAMain.ReorderObject("Top")
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        CDAMain.ReorderObject("Bottom")
    End Sub

    Private Sub cbtnHide_CheckedChanged(sender As Object, e As EventArgs) Handles cbtnHide.CheckedChanged
        If cbtnHide.Checked Then
            cbtnHide.ToolTip = "Show object in preview"
        Else
            cbtnHide.ToolTip = "Hide object in preview"
        End If
        CDAMain.ToggleObjectPreviewVisibility(cbtnHide.Checked)
    End Sub

    Private Sub ObjectManager_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "ObjectList" & ".html")
    End Sub
End Class
