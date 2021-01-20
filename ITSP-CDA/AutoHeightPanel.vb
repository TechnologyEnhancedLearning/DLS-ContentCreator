Public Class AutoHeightPanel
	Inherits Panel
	Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
		MyBase.OnControlAdded(e)
		AddHandler e.Control.SizeChanged, AddressOf ControlSizeChanged
	End Sub
	Public Sub ControlSizeChanged(sender As Object, e As EventArgs)
		Height = CalcHeight()
	End Sub
	Protected Overrides Sub OnControlRemoved(e As ControlEventArgs)
		MyBase.OnControlRemoved(e)
		RemoveHandler e.Control.SizeChanged, AddressOf ControlSizeChanged
	End Sub

	Private Function CalcHeight() As Integer
		Dim res As Integer = 0
		Dim minY As Integer = Int32.MaxValue
		For Each c As Control In Controls
			res = Math.Max(res, c.Height)
			minY = Math.Min(res, c.Location.Y)
		Next
		Return res + minY * 2
	End Function

End Class
