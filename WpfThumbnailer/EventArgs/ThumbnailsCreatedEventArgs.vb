''' <summary>
''' Event Arguments class for reporting process completion when using the ThumbnailGenerator class
''' </summary>
''' <typeparam name="T"></typeparam>
''' <remarks></remarks>
Public NotInheritable Class ThumbnailsCreatedEventArgs(Of T)
    Inherits EventArgs

    Private _Items() As T
    Private _TimeTaken As TimeSpan

    Public ReadOnly Property TimeTaken() As TimeSpan
        Get
            Return _TimeTaken
        End Get
    End Property

    Public ReadOnly Property Items() As T()
        Get
            Return _Items
        End Get
    End Property

    Public Sub New(ByVal Items As T(), ByVal TimeTaken As TimeSpan)
        _Items = Items
        _TimeTaken = TimeTaken
    End Sub

End Class