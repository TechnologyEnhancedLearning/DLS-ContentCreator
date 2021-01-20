Imports DevExpress.XtraBars.Ribbon.Drawing
Imports DevExpress.XtraBars.Ribbon

Partial Public Class RibbonApplicationUserControl
	Inherits UserControl
	Public Sub New()
		InitializeComponent()
	End Sub
	Public Overrides Property BackColor() As Color
		Get
			Return GetBackgroundColor()
		End Get
		Set(ByVal value As Color)
			MyBase.BackColor = value
		End Set
	End Property
	Private Function GetBackgroundColor() As Color
		Dim parent As BackstageViewClientControl = TryCast(Me.Parent, BackstageViewClientControl)
		If parent Is Nothing Then
			Return Color.Transparent
		End If
		Return parent.GetBackgroundColor()
	End Function
	Public ReadOnly Property BackstageView() As BackstageViewControl
		Get
			If Parent Is Nothing Then
				Return Nothing
			End If
			Return TryCast(Parent.Parent, BackstageViewControl)
		End Get
	End Property
	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		MyBase.OnPaint(e)
		If BackstageView IsNot Nothing Then
			BackstageViewPainter.DrawBackstageViewImage(e, Me, BackstageView)
		End If
	End Sub
End Class
