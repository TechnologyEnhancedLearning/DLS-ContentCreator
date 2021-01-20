Imports System.ComponentModel

Public Class EditQuizQuestion
    Public Shared ReadOnly Property quizQuestion As mstns.QuizQuestion
        Get
            quizQuestion = CDAMain.itspunit.PageCol(CDAMain.selectedPageIndex).QuizQuestion()
            Return quizQuestion
        End Get
    End Property

    Private Sub EditQuizQuestion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CDAMain.PopulatePagesDropDown(cbxGotoPageCorrect)
        CDAMain.PopulatePagesDropDown(cbxGotoPageIncorrect)
        cbxGotoPageCorrect.SelectedItem = quizQuestion.GotoPageCorrect
        cbxGotoPageIncorrect.SelectedItem = quizQuestion.GotoPageIncorrect
        cbxLayout.SelectedItem = quizQuestion.Layout
        meditQuestionPrompt.EditValue = quizQuestion.Question
        meditCorrectFeedback.EditValue = quizQuestion.CorrectFeedback
        meditIncorrectFeedback.EditValue = quizQuestion.IncorrectFeedback
        cbShuffle.Checked = quizQuestion.Shuffle
        meditHint.EditValue = quizQuestion.Hint
        Dim col As DataColumn
        Dim dt As New DataTable
        col = New DataColumn
        With col
            .ColumnName = "Correct"
            .DataType = System.Type.GetType("System.Boolean")
            .DefaultValue = False
        End With
        dt.Columns.Add(col)
        col = New DataColumn
        With col
            .ColumnName = "ChoiceText"
            .DataType = System.Type.GetType("System.String")
            .DefaultValue = ""
        End With
        dt.Columns.Add(col)
        For Each qc As mstns.QuizChoice In quizQuestion.QuizChoicesCol
            dt.Rows.Add(qc.Correct, qc.ChoiceText)
        Next
        ChoicesGridControl.DataSource = dt
        GridView1.PopulateColumns()
        ChoicesGridControl.ForceInitialize()
        GridView1.Columns(0).MaxWidth = 60
    End Sub

    Private Sub btnEditQuizOK_Click(sender As Object, e As EventArgs) Handles btnEditQuizOK.Click
        quizQuestion.Question = meditQuestionPrompt.EditValue.ToString()
        quizQuestion.CorrectFeedback = meditCorrectFeedback.EditValue.ToString()
        quizQuestion.IncorrectFeedback = meditIncorrectFeedback.EditValue.ToString()
        quizQuestion.Shuffle = cbShuffle.Checked
        quizQuestion.Layout = cbxLayout.SelectedItem.ToString()
        quizQuestion.Hint = meditHint.EditValue.ToString()
        quizQuestion.GotoPageCorrect = cbxGotoPageCorrect.SelectedItem.ToString()
        quizQuestion.GotoPageIncorrect = cbxGotoPageIncorrect.SelectedItem.ToString()
        quizQuestion.QuizChoicesCol.Clear()
        For i As Integer = 0 To GridView1.DataRowCount - 1
            Dim ch As New mstns.QuizChoice
            ch.Correct = CBool(GridView1.GetRowCellValue(i, "Correct"))
            ch.ChoiceText = GridView1.GetRowCellValue(i, "ChoiceText").ToString()
            quizQuestion.QuizChoicesCol.Add(ch)
        Next
        CDAMain.Modified = True
        CDAMain.ReloadControls(False, False, False, False, False, False, True, False)
        Me.Close()
    End Sub

    Private Sub btnEditQuizCancel_Click(sender As Object, e As EventArgs) Handles btnEditQuizCancel.Click
        Me.Close()
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim i As Integer = e.RowHandle
        If GridView1.GetRowCellValue(i, "ChoiceText").ToString() = "" Then
            GridView1.DeleteRow(i)
        End If
    End Sub

    Private Sub EditQuizQuestion_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "QuizQuestion" & ".html")
    End Sub

    Private Sub EditQuizQuestion_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "QuizQuestion" & ".html")
    End Sub
End Class