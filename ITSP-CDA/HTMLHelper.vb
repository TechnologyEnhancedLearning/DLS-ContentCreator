Imports System.Runtime.InteropServices

<ComVisible(True)> _
Public Class HTMLHelper
	Public Sub SetInstructionLocation(ByVal sHPos As String, ByVal sVPos As String)
		Dim nHpos As Integer = CInt(sHPos)
		Dim nVPos As Integer = CInt(sVPos)
		CDAMain.SetInstructionLocation(nHpos, nVPos)
	End Sub
	Public Sub SetInsertObjectPosition(ByVal sHPos As String, ByVal sVPos As String, Optional ByVal sWidth As String = "", Optional ByVal sHeight As String = "")
		Dim nHpos As Integer = CInt(sHPos)
		Dim nVPos As Integer = CInt(sVPos)

		CDAMain.InsertObjectAtPosition(nHpos, nVPos, sWidth, sHeight)
	End Sub
	Public Sub SetObjectLocation(ByVal sId As String, ByVal sHPos As String, ByVal sVPos As String)
		Dim nHpos As Integer = CInt(sHPos)
		Dim nVPos As Integer = CInt(sVPos)
		CDAMain.SetObjectLocation(sId, nHpos, nVPos)
	End Sub
    Public Sub SelectObject(ByVal sId As String)
        CDAMain.selectedObjectID = sId
        CDAMain.selectedObjectType = "Object"
        CDAMain.ReloadControls(False, False, False, False, True, False, False, True)
    End Sub
    Public Sub SetObjectSize(ByVal sId As String, ByVal sW As String, ByVal sH As String)
		CDAMain.SetObjectSize(sId, CInt(sW), CInt(sH))
	End Sub
	Public Sub InstructionBoxClick()
		CDAMain.pnlPage.Show()
		CDAMain.PageSettings1.TabbedControlGroup1.SelectedTabPageIndex = 1
    End Sub
    Public Sub EditStartHtml()
        Dim bht As mstns.TextBehaviour = CDAMain.currentBehaviour.Text_
        If Not bht Is Nothing Then
            Dim sForm As New EditText
            sForm.TextType = "StartText"
            sForm.Text = "Edit Start Text"
            sForm.reditText.HtmlText = bht.StartHtml.ToString()
            sForm.bModified = False
            sForm.Parent = CDAMain.Parent
            sForm.StartPosition = FormStartPosition.CenterParent
            sForm.ShowDialog(CDAMain)
            sForm.bModified = False
            sForm.Dispose()
        End If
    End Sub
    Public Sub SaveThumb()
        CDAMain.SaveThumb()
    End Sub
End Class
