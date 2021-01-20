Public Class frmProjectSettingsNew

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub LoadValues()
        If Not CDAMain.itspunit Is Nothing Then
            ProjectSettings1.LoadValues()
        End If
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ProjectSettings1.SaveValues()
        If Not ProjectSettings1.cbxUnitType.SelectedItem.ToString() = "Learning" Then
            CDAMain.itspunit.PageCol(0).PageType = "Test"
        End If
        CDAMain.Modified = True
        CDAMain.NewProjectSave()
        Me.Close()
    End Sub

    Private Sub frmProjectSettingsNew_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "ProjectSettings" & ".html")
    End Sub
End Class