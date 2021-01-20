Imports System.Environment
Public Class StartForm

    Private Sub btnNewProject_Click(sender As Object, e As EventArgs) Handles btnNewProject.Click
        CDAMain.NewProject()
        CDAMain.DoRefreshOnActivate = False
        Me.Close()
    End Sub

    Private Sub btnOpenProject_Click(sender As Object, e As EventArgs) Handles btnOpenProject.Click
        CDAMain.OpenFile()
        CDAMain.DoRefreshOnActivate = False
        Me.Close()
    End Sub
    Private Sub InitMostRecentFiles(ByVal arList As MRUArrayList)
        Dim fileName As String = MRUArrayList.MRUFileName
        arList.Init(fileName, "")
    End Sub
    Private Sub InitMostRecentFolders(ByVal arList As MRUArrayList)
        Dim folderName As String = MRUArrayList.MRUFolderName
        arList.Init(folderName, GetFolderPath(SpecialFolder.MyDocuments))
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        InitMostRecentFiles(RecentItemsControl1.MRUFileList)
        InitMostRecentFolders(RecentItemsControl1.MRUFolderList)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub StartForm_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "CreatingYourFirstProject" & ".html")
    End Sub
End Class