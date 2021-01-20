Public Class ObjectProperties

	Private Sub tbObjName_GotFocus(sender As Object, e As EventArgs) Handles tbObjName.GotFocus, spinHeight.GotFocus, spinWidth.GotFocus, spinXPos.GotFocus, spinYPos.GotFocus
		CDAMain.allowKeys = False
	End Sub


	Private Sub tbObjName_LostFocus(sender As Object, e As EventArgs) Handles tbObjName.LostFocus
		CDAMain.allowKeys = True
		CDAMain.UpdateSelectedObjectName(tbObjName.Text)
	End Sub

	Private Sub spinHeight_EditValueChanged(sender As Object, e As EventArgs) Handles spinHeight.EditValueChanged
		CDAMain.UpdateSelectedObjectProperty("Height", spinHeight.Value.ToString())
	End Sub

	Private Sub spinWidth_EditValueChanged(sender As Object, e As EventArgs) Handles spinWidth.EditValueChanged
		CDAMain.UpdateSelectedObjectProperty("Width", spinWidth.Value.ToString())
	End Sub

	Private Sub spinXPos_EditValueChanged(sender As Object, e As EventArgs) Handles spinXPos.EditValueChanged
		CDAMain.UpdateSelectedObjectProperty("HPos", spinXPos.Value.ToString())
	End Sub

	Private Sub spinYPos_EditValueChanged(sender As Object, e As EventArgs) Handles spinYPos.EditValueChanged
		CDAMain.UpdateSelectedObjectProperty("VPos", spinYPos.Value.ToString())
	End Sub

    Private Sub cbStartVisible_CheckedChanged(sender As Object, e As EventArgs) Handles cbStartVisible.CheckedChanged
        CDAMain.UpdateSelectedObjectProperty("StartVisible", cbStartVisible.Checked.ToString())
    End Sub
    Private Sub cbStartOpaque_CheckedChanged(sender As Object, e As EventArgs) Handles cbStartOpaque.CheckedChanged
        CDAMain.UpdateSelectedObjectProperty("StartOpaque", cbStartOpaque.Checked.ToString())
    End Sub
End Class
