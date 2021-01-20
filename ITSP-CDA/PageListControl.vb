Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery

Public Class PageListControl

	Private Sub GalleryControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles GalleryControl1.MouseUp
		If e.Button = Windows.Forms.MouseButtons.Right Then
			'pmPage.ShowPopup(Control.MousePosition)
		End If

	End Sub

    Private Sub PageListControl_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "TheNavigationPane" & ".html")
    End Sub

    'Private Sub GalleryControl1_Gallery_ItemClick(sender As Object, e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles Gallery.ItemClick
    '	CDAMain.selectedPageIndex = CInt(e.Item.Value)
    'End Sub
    'Private Sub pmbNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles pmbNew.ItemClick
    '	CDAMain.CreateNewPage()
    'End Sub
    Public Class MyGalleryControlGalleryViewInfo
        Inherits GalleryControlGalleryViewInfo
        Public Sub New(gallery As GalleryControlGallery)
            MyBase.New(gallery)
        End Sub
        Public Function CalcGalleryHitInfo(pt As Point) As RibbonHitInfo
            Return CalcHitInfo(pt)
        End Function
        Public Function GetGalleryItemInfo(item As GalleryItem) As GalleryItemViewInfo
            Return GetItemInfo(item)
        End Function
    End Class
    Public Class MyGalleryControlGallery
		Inherits GalleryControlGallery
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(galleryControl As GalleryControl)
			MyBase.New(galleryControl)
		End Sub
		Public ReadOnly Property GalleryInfo() As GalleryControlGalleryViewInfo
			Get
				Return DirectCast(ViewInfo, GalleryControlGalleryViewInfo)
			End Get
		End Property
		Protected Overrides Function CreateViewInfo() As BaseGalleryViewInfo
			Return New MyGalleryControlGalleryViewInfo(Me)
		End Function
	End Class

	Public Class MyGalleryControl
		Inherits GalleryControl
		Shared InvalidPoint As New Point(-10000, -10000)
		Private downPoint As Point
		Public Sub New()
			Me.downPoint = InvalidPoint
			AllowDrop = True
		End Sub
		Protected Overrides Function CreateGallery() As GalleryControlGallery
            Return New MyGalleryControlGallery(Me)
            Me.Gallery.CheckSelectedItemViaKeyboard = True
		End Function
		Public Shadows ReadOnly Property Gallery() As MyGalleryControlGallery
			Get
				Return DirectCast(MyBase.Gallery, MyGalleryControlGallery)
			End Get
		End Property
		Public ReadOnly Property GalleryInfo() As MyGalleryControlGalleryViewInfo
			Get
				Return DirectCast(Gallery.GalleryInfo, MyGalleryControlGalleryViewInfo)
			End Get
		End Property
		Private selectedItem As GalleryItem = Nothing
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			If e.Button = MouseButtons.Left Then
				Me.downPoint = e.Location
				Dim hi As RibbonHitInfo = GalleryInfo.CalcGalleryHitInfo(e.Location)
				selectedItem = hi.GalleryItem
				
			End If
		End Sub
        Protected Overrides Sub OnKeyUp(e As KeyEventArgs)
            MyBase.OnKeyUp(e)
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
                selectedItem = Me.Gallery.GetCheckedItem
                If Not selectedItem Is Nothing Then
                    CDAMain.SelectPage(CInt(selectedItem.Value), True)
                    CDAMain.ReloadControls(False, False, False, True, True, True, True, True)
                End If
            End If
        End Sub
        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            If e.Button = MouseButtons.Left Then

                If Not selectedItem Is Nothing Then
                    CDAMain.SelectPage(CInt(selectedItem.Value), True)
                    CDAMain.ReloadControls(False, False, False, True, True, True, True, True)
                    CDAMain.SelectPagePost(CInt(selectedItem.Value))
                End If
            End If
            CDAMain.ScrollYPos = Me.Gallery.ScrollYPosition
            Me.downPoint = InvalidPoint
        End Sub
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			If Me.downPoint = InvalidPoint OrElse selectedItem Is Nothing Then
				Return
			End If
			If Math.Abs(e.Location.X - Me.downPoint.X) > SystemInformation.DragSize.Width OrElse Math.Abs(e.Location.Y - Me.downPoint.Y) > SystemInformation.DragSize.Height Then
				DoDragDrop(selectedItem, DragDropEffects.Move)
			End If
		End Sub
		Protected Function GetDragItem(e As DragEventArgs) As GalleryItem
			Dim formats As String() = e.Data.GetFormats()
			For i As Integer = 0 To formats.Length - 1
				If TypeOf e.Data.GetData(formats(i)) Is GalleryItem Then
					Return DirectCast(e.Data.GetData(formats(i)), GalleryItem)
				End If
			Next
			Return Nothing
		End Function
		Protected Overrides Sub OnDragOver(e As DragEventArgs)
			MyBase.OnDragOver(e)
			Dim dragItem As GalleryItem = GetDragItem(e)
			If dragItem Is Nothing Then
				e.Effect = DragDropEffects.None
			End If
			Dim hi As RibbonHitInfo = GalleryInfo.CalcGalleryHitInfo(PointToClient(New Point(e.X, e.Y)))
			If hi.GalleryItem Is Nothing Then
				e.Effect = DragDropEffects.None
			Else
				e.Effect = DragDropEffects.Move
			End If
		End Sub
		Protected Overrides Sub OnDragDrop(e As DragEventArgs)
			MyBase.OnDragDrop(e)
			Dim dragItem As GalleryItem = GetDragItem(e)
			If dragItem Is Nothing Then
				Return
			End If
			Dim pt As Point = PointToClient(New Point(e.X, e.Y))
			Dim hi As RibbonHitInfo = GalleryInfo.CalcGalleryHitInfo(pt)
			If hi.GalleryItem Is Nothing OrElse hi.GalleryItem.Caption = dragItem.Caption Then
				Return
			End If
			Dim itemInfo As GalleryItemViewInfo = GalleryInfo.GetGalleryItemInfo(hi.GalleryItem)
			Dim galGroup As GalleryItemGroup = dragItem.GalleryGroup
			If Not galGroup Is Nothing Then
				galGroup.Items.Remove(dragItem)
				Dim dropItemIndex As Integer = hi.GalleryItem.GalleryGroup.Items.IndexOf(hi.GalleryItem)
				If itemInfo.Bounds.X + itemInfo.Bounds.Width < pt.X Then
					dropItemIndex += 1
				End If
				Dim movingPage As New mstns.Page
				movingPage = CDAMain.itspunit.PageCol(CInt(dragItem.Value))
				CDAMain.itspunit.PageCol.RemoveAt(CInt(dragItem.Value))
				CDAMain.itspunit.PageCol.Insert(dropItemIndex, movingPage)
				'hi.GalleryItem.GalleryGroup.Items.Insert(dropItemIndex, dragItem)
				OnMouseUp(New MouseEventArgs(MouseButtons.Left, 1, pt.X, pt.Y, 0))
                CDAMain.ReloadControls(True, False, False, True, True, False, True, True)
				galGroup.Items(dropItemIndex).Checked = True
				CDAMain.Modified = True
			End If
		End Sub
	End Class
End Class

