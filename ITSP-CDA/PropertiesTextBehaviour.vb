Public Class PropertiesTextBehaviour
    Public ReadOnly Property bht As mstns.TextBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bht = CDAMain.currentBehaviour.Text_
                If Not bht Is Nothing Then
                    Return bht
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Sub btnStartText_Click(sender As Object, e As EventArgs) Handles btnStartText.Click
        If Not bht Is Nothing Then
            EditStartText()
        End If
    End Sub
    Public Sub EditStartText()
        Try
            Dim sForm As New EditText
            sForm.TextType = "StartText"
            sForm.Text = "Edit Start Text"
            sForm.reditText.CreateNewDocument()
            sForm.reditText.HtmlText = bht.StartHtml.ToString()
            sForm.bModified = False
            sForm.Parent = ParentForm.Parent
            sForm.StartPosition = FormStartPosition.CenterParent
            sForm.ShowDialog(ParentForm)
            sForm.bModified = False
            sForm.Dispose()
        Catch ex As Exception
            Dim sException As String = ex.Message.ToString()
        End Try
    End Sub
    Private Sub btnEditRequiredHtml_Click(sender As Object, e As EventArgs) Handles btnEditRequiredHtml.Click
        If Not bht Is Nothing Then
            Try
                Dim sForm As New EditText
                sForm.TextType = "RequiredText"
                sForm.Text = "Edit Required Text"
                sForm.reditText.CreateNewDocument()
                sForm.reditText.HtmlText = bht.RequiredHtml.ToString()
                sForm.Parent = ParentForm.Parent
                sForm.StartPosition = FormStartPosition.CenterParent
                sForm.ShowDialog(ParentForm)
                sForm.bModified = False
                sForm.Dispose()
            Catch ex As Exception
                Dim sException As String = ex.Message.ToString()
            End Try
        End If
    End Sub
    Private Sub cbIsEditable_CheckedChanged(sender As Object, e As EventArgs) Handles cbIsEditable.CheckedChanged
        If Not bht Is Nothing Then
            bht.IsEditable = cbIsEditable.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbHasFocus_CheckedChanged(sender As Object, e As EventArgs) Handles cbHasFocus.CheckedChanged
        If Not bht Is Nothing Then
            bht.HasFocus = cbHasFocus.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinSelectionStart_EditValueChanged(sender As Object, e As EventArgs) Handles spinSelectionStart.EditValueChanged
        If Not bht Is Nothing Then
            bht.SelectionStart = CInt(spinSelectionStart.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinSelectionEnd_EditValueChanged(sender As Object, e As EventArgs) Handles spinSelectionEnd.EditValueChanged
        If Not bht Is Nothing Then
            bht.SelectionEnd = CInt(spinSelectionEnd.EditValue)
            CDAMain.Modified = True
        End If
    End Sub



    Private Sub spinRequiredSelectionStart_EditValueChanged(sender As Object, e As EventArgs) Handles spinRequiredSelectionStart.EditValueChanged
        If Not bht Is Nothing Then
            bht.RequiredSelectStart = CInt(spinRequiredSelectionStart.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinRequiredSelectionEnd_EditValueChanged(sender As Object, e As EventArgs) Handles spinRequiredSelectionEnd.EditValueChanged
        If Not bht Is Nothing Then
            bht.RequiredSelectEnd = CInt(spinRequiredSelectionEnd.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinRequiredCharCount_EditValueChanged(sender As Object, e As EventArgs) Handles spinRequiredCharCount.EditValueChanged
        If Not bht Is Nothing Then
            bht.RequiredCharacterCount = CInt(spinRequiredCharCount.EditValue)
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbJudgeOnKeyup_CheckedChanged(sender As Object, e As EventArgs) Handles cbJudgeOnKeyup.CheckedChanged
        If Not bht Is Nothing Then
            bht.JudgeOnKeyup = cbJudgeOnKeyup.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbJudgeOnReturn_CheckedChanged(sender As Object, e As EventArgs) Handles cbJudgeOnReturn.CheckedChanged
        If Not bht Is Nothing Then
            bht.JudgeOnReturn = cbJudgeOnReturn.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbJudgeOnSelectionChanged_CheckedChanged(sender As Object, e As EventArgs) Handles cbJudgeOnSelectionChanged.CheckedChanged
        If Not bht Is Nothing Then
            bht.JudgeOnSelectChange = cbJudgeOnSelectionChanged.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxGoToPage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGoToPage.SelectedIndexChanged
        If Not bht Is Nothing Then
            bht.GoToPageCorrect = cbxGoToPage.SelectedItem.ToString
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxGotoPageWrong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGotoPageWrong.SelectedIndexChanged
        If Not bht Is Nothing Then
            bht.GoToPageIncorrect = cbxGotoPageWrong.SelectedItem.ToString
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbAssessCorrect_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssessCorrect.CheckedChanged
        If Not bht Is Nothing Then
            bht.AssessmentCorrect = cbAssessCorrect.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbAssessIncorrect_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssessIncorrect.CheckedChanged
        If Not bht Is Nothing Then
            bht.AssessmentIncorrect = cbAssessIncorrect.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbRetainPrev_CheckedChanged(sender As Object, e As EventArgs) Handles cbRetainPrev.CheckedChanged
        If Not bht Is Nothing Then
            If cbRetainPrev.Checked Then
                btnStartText.Enabled = False
            Else
                btnStartText.Enabled = True
            End If
            bht.RetainPreviousText = cbRetainPrev.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub spinRequiredCharCount_GotFocus(sender As Object, e As EventArgs) Handles spinRequiredCharCount.GotFocus, spinRequiredSelectionEnd.GotFocus, spinRequiredSelectionStart.GotFocus, spinSelectionEnd.GotFocus, spinSelectionStart.GotFocus
        CDAMain.allowKeys = False
    End Sub

    Private Sub spinRequiredCharCount_LostFocus(sender As Object, e As EventArgs) Handles spinRequiredCharCount.LostFocus, spinRequiredSelectionEnd.LostFocus, spinRequiredSelectionStart.LostFocus, spinSelectionEnd.LostFocus, spinSelectionStart.LostFocus
        CDAMain.allowKeys = True
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LayoutControlItem23.HideToCustomization()
        LayoutControlItem24.HideToCustomization()
        LayoutControlItem25.HideToCustomization()
        LayoutControlItem26.HideToCustomization()
        If CDAMain.itspunit.Type <> "Learning" Then
            LayoutControlItem22.HideToCustomization()
            LayoutControlItem27.HideToCustomization()
        End If
    End Sub

    Private Sub cbJudgeOnTab_CheckedChanged(sender As Object, e As EventArgs) Handles cbJudgeOnTab.CheckedChanged
        If Not bht Is Nothing Then
            bht.JudgeOnTab = cbJudgeOnTab.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbIgnoreCase_CheckedChanged(sender As Object, e As EventArgs) Handles cbIgnoreCase.CheckedChanged
        If Not bht Is Nothing Then
            bht.IgnoreCase = cbIgnoreCase.Checked
            CDAMain.Modified = True
        End If
    End Sub

    Private Sub cbxSendTextToObject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSendTextToObject.SelectedIndexChanged
        If Not bht Is Nothing Then
            If bht.SendTextTargetObject <> cbxSendTextToObject.EditValue.ToString Then
                bht.SendTextTargetObject = cbxSendTextToObject.EditValue.ToString
                CDAMain.Modified = True
            End If
        End If
    End Sub

    Private Sub PropertiesTextBehaviour_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "TextInteraction" & ".html")
    End Sub
End Class
