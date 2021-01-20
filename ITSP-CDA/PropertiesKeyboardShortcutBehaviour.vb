Public Class PropertiesKeyboardShortcutBehaviour
    Public ReadOnly Property bhks As mstns.KeyboardShortcutBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bhks = CDAMain.currentBehaviour.KeyboardShortcut
                If Not bhks Is Nothing Then
                    Return bhks
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property
    Private Sub tbKeyToPress_EditValueChanged(sender As Object, e As EventArgs) Handles tbKeyToPress.EditValueChanged
        If Not bhks Is Nothing Then
            bhks.KeyToPress = tbKeyToPress.Text()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbCtrlDown_CheckedChanged(sender As Object, e As EventArgs) Handles cbCtrlDown.CheckedChanged
        If Not bhks Is Nothing Then
            bhks.CtrlDown = cbCtrlDown.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbAltDown_CheckedChanged(sender As Object, e As EventArgs) Handles cbAltDown.CheckedChanged
        If Not bhks Is Nothing Then
            bhks.AltDown = cbAltDown.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbShiftDown_CheckedChanged(sender As Object, e As EventArgs) Handles cbShiftDown.CheckedChanged
        If Not bhks Is Nothing Then
            bhks.ShiftDown = cbShiftDown.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxSpecialKey_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSpecialKey.SelectedIndexChanged
        If Not bhks Is Nothing Then
            bhks.SpecialKey = cbxSpecialKey.SelectedItem.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxGotoPage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGotoPage.SelectedIndexChanged
        If Not bhks Is Nothing Then
            bhks.GoToPage = cbxGotoPage.SelectedItem.ToString()
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbAssessCorrect_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssessCorrect.CheckedChanged
        If Not bhks Is Nothing Then
            bhks.AssessCorrect = cbAssessCorrect.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub tbKeyToPress_GotFocus(sender As Object, e As EventArgs) Handles tbKeyToPress.GotFocus
        CDAMain.allowKeys = False
    End Sub

    Private Sub tbKeyToPress_LostFocus(sender As Object, e As EventArgs) Handles tbKeyToPress.LostFocus
        CDAMain.allowKeys = True
    End Sub
    Private Sub cbxCheckShowObjects_EditValueChanged(sender As Object, e As EventArgs) Handles cbxCheckShowObjects.EditValueChanged
        If Not bhks Is Nothing Then
            If Not bhks.ShowObjects = cbxCheckShowObjects.EditValue.ToString() Then
                bhks.ShowObjects = cbxCheckShowObjects.EditValue.ToString()
                CDAMain.Modified = True
            End If
        End If
    End Sub

    Private Sub cbxCheckHideObjects_EditValueChanged(sender As Object, e As EventArgs) Handles cbxCheckHideObjects.EditValueChanged
        If Not bhks Is Nothing Then
            If Not bhks.HideObjects = cbxCheckHideObjects.EditValue.ToString() Then
                bhks.HideObjects = cbxCheckHideObjects.EditValue.ToString()
                CDAMain.Modified = True
            End If
        End If
    End Sub

    Private Sub cbxCheckAnimate_EditValueChanged(sender As Object, e As EventArgs) Handles cbxCheckAnimateObjects.EditValueChanged
        If Not bhks Is Nothing Then
            If Not bhks.AnimateObjects = cbxCheckAnimateObjects.EditValue.ToString() Then
                bhks.AnimateObjects = cbxCheckAnimateObjects.EditValue.ToString()
                CDAMain.Modified = True
            End If
        End If
    End Sub

    Private Sub cbToggle_CheckedChanged(sender As Object, e As EventArgs) Handles cbToggleVis.CheckedChanged
        If Not bhks Is Nothing Then
            If Not bhks.Toggle = cbToggleVis.Checked Then
                bhks.Toggle = cbToggleVis.Checked
                CDAMain.Modified = True
            End If
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If CDAMain.itspunit.Type <> "Learning" Then

            LayoutControlItem8.HideToCustomization()
        Else
            LayoutControlItem9.HideToCustomization()
            LayoutControlItem10.HideToCustomization()
        End If
    End Sub

    Private Sub PropertiesKeyboardShortcutBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "KeyboardShortcut1" & ".html")
    End Sub
End Class
