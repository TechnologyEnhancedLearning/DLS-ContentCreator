
''' <summary>
''' Event Arguments class for reporting errors when using the ThumbnailGenerator class
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class ThumbnailErrorEventArgs
    Inherits EventArgs

    Private _Exception As Exception = Nothing

    Public ReadOnly Property Exception() As Exception
        Get
            Return _Exception
        End Get
    End Property

    Public Sub New(ByVal ex As Exception)
        _Exception = ex
    End Sub
End Class
