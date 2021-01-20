Public Class PropertiesScormPublish
    Public Sub StoreValues()
        CDAMain.itspunit.UnitName = txtProjectName.Text
        CDAMain.itspunit.SCODescription = meditDescription.Text
        CDAMain.itspunit.SCOKeyWords = txtKeyWords.Text
        CDAMain.itspunit.SCOMasteryScore = CInt(spinMasteryScore.EditValue)
    End Sub
    Public Sub LoadValues()
        txtProjectName.Text = CDAMain.itspunit.UnitName
        txtKeyWords.Text = CDAMain.itspunit.SCOKeyWords
        meditDescription.Text = CDAMain.itspunit.SCODescription
        spinMasteryScore.Text = CDAMain.itspunit.SCOMasteryScore.ToString()
    End Sub


End Class
