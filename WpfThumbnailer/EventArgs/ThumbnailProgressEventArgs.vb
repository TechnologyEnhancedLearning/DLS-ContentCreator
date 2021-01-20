
''' <summary>
''' Event Arguments class for reporting progress when using the ThumbnailGenerator class
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class ThumbnailProgressEventArgs
    Inherits System.EventArgs

    Private _TotalThumbs As Integer = 0
    Private _ThumbCreatedNumber As Integer = 0
    Private _TimeSinceStarted As TimeSpan
    Private _ThumbTimeLocation As TimeSpan
    Private _Message As String

    Public Sub New(ByVal TotalThumbs As Integer, ByVal CreatedThumbs As Integer, ByVal ThumbTimeLocation As TimeSpan, ByVal TimeSinceStarted As TimeSpan, ByVal Message As String)
        _TotalThumbs = TotalThumbs
        _ThumbCreatedNumber = CreatedThumbs
        _TimeSinceStarted = TimeSinceStarted
        _ThumbTimeLocation = ThumbTimeLocation
        _Message = Message
    End Sub

    Public ReadOnly Property TotalThumbs() As Integer
        Get
            Return _TotalThumbs
        End Get
    End Property
    Public ReadOnly Property ThumbCreatedNumber() As Integer
        Get
            Return _ThumbCreatedNumber
        End Get
    End Property
    Public ReadOnly Property TimeSinceStarted() As TimeSpan
        Get
            Return _TimeSinceStarted
        End Get
    End Property
    Public ReadOnly Property ThumbTimeLocation() As TimeSpan
        Get
            Return _ThumbTimeLocation
        End Get
    End Property
    Public ReadOnly Property Message() As String
        Get
            Return _Message
        End Get
    End Property
End Class
