Imports DevExpress.XtraBars.Ribbon
Imports System.IO

Partial Public Class RecentItemsControl
	Inherits RibbonApplicationUserControl
	Public Sub New()
		InitializeComponent()
        mruFileList_Renamed = New MRUArrayList(splitContainer1.Panel1, imageCollection3.Images(1), imageCollection3.Images(0), imageCollection1.Images(0), False, True)
        AddHandler mruFileList_Renamed.LabelClicked, AddressOf mruFileList_LabelClicked
        mruFolderList_Renamed = New MRUArrayList(panel2, imageCollection3.Images(1), imageCollection3.Images(0), imageCollection1.Images(1), False, True)
        AddHandler mruFolderList_Renamed.LabelClicked, AddressOf mruFolderList_LabelClicked
	End Sub

    Private Sub mruFolderList_LabelClicked(ByVal sender As Object, ByVal e As EventArgs)
        CDAMain.OpenFile(CStr(sender))
        'System.Diagnostics.Process.Start("explorer.exe", CStr(sender))
        BackstageView.Ribbon.HideApplicationButtonContentControl()
    End Sub

    Private Sub mruFileList_LabelClicked(ByVal sender As Object, ByVal e As EventArgs)
		If Me.ParentForm.Name = "StartForm" Then
            CDAMain.OpenThisFile(CStr(sender))
            Me.ParentForm.Close()
		Else
			Dim frm As CDAMain = CType(BackstageView.Ribbon.FindForm(), CDAMain)
            frm.OpenThisFile(CStr(sender))
            BackstageView.Ribbon.HideApplicationButtonContentControl()
		End If

	End Sub
	Private mruFileList_Renamed As MRUArrayList
	Private mruFolderList_Renamed As MRUArrayList
	Public ReadOnly Property MRUFileList() As MRUArrayList
		Get
			Return mruFileList_Renamed
		End Get
	End Property
	Public ReadOnly Property MRUFolderList() As MRUArrayList
		Get
			Return mruFolderList_Renamed
		End Get
	End Property

    Private Sub ClearRecentItems()
        If BackstageView Is Nothing Then
            Return
        End If
        Dim i As Integer = 0
        Do While i < BackstageView.Items.Count
            Dim item As BackstageViewButtonItem = TryCast(BackstageView.Items(i), BackstageViewButtonItem)
            If (item IsNot Nothing AndAlso item.Tag IsNot Nothing) OrElse TypeOf BackstageView.Items(i) Is BackstageViewItemSeparator Then
                If item IsNot Nothing Then
                    RemoveHandler item.ItemClick, AddressOf OnRecentItemClick
                End If
                BackstageView.Items.RemoveAt(i)
            Else
                i += 1
            End If
        Loop
    End Sub
    Private Sub UpdateRecentItems()
        If IsNothing(BackstageView) Then
            Return
        End If
        BackstageView.BeginUpdate()
        Try
            ClearRecentItems()
        Finally
            BackstageView.EndUpdate()
        End Try
    End Sub

    Private Sub OnRecentItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
        If Me.ParentForm.Name = "StartForm" Then
            CDAMain.OpenThisFile(CStr(e.Item.Tag))
            Me.ParentForm.Close()
        Else
            Dim frm As CDAMain = CType(BackstageView.Ribbon.FindForm(), CDAMain)
            frm.OpenThisFile(CStr(e.Item.Tag))
            BackstageView.Ribbon.HideApplicationButtonContentControl()
        End If
    End Sub

End Class
