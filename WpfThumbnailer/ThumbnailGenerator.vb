'THUMBNAILER CLASS LIBRARY
'2014 MATTHEW KLEINWAKS

Imports System.Windows.Threading

Public NotInheritable Class ThumbnailGenerator

    '***********************************
    '      PUBLIC CODE SECTION
    '***********************************

#Region "PUBLIC EVENTS"
    ''' <summary>
    ''' Occurs when a video has finished processing, and thumbnails have been created to memory
    ''' </summary>
    ''' <param name="sender">The ThumbnailGenerator instance that raised this event</param>
    ''' <param name="e">The ThumbnailsCreatedEventArgs EventArgs that contain the thumbnails that were created</param>
    ''' <remarks></remarks>
    Public Event ThumbnailsCreatedToMemory(ByVal sender As Object, ByVal e As ThumbnailsCreatedEventArgs(Of System.Drawing.Image))
    ''' <summary>
    ''' Occurs when a video has finished processing, and thumbnails have been created to disk
    ''' </summary>
    ''' <param name="sender">The ThumbnailGenerator instance that raised this event</param>
    ''' <param name="e">The ThumbnailsCreatedEventArgs EventArgs that contain the thumbnails that were created</param>
    ''' <remarks></remarks>
    Public Event ThumbnailsCreatedToDisk(ByVal sender As Object, ByVal e As ThumbnailsCreatedEventArgs(Of String))
    ''' <summary>
    ''' Occurs when an exception occurs during processing
    ''' </summary>
    ''' <param name="sender">The ThumbnailGenerator instance that raised this event</param>
    ''' <param name="e">The ThumbnailErrorEventArgs EventArgs that contain the exception information</param>
    ''' <remarks></remarks>
    Public Event ThumbnailCreationFailed(ByVal sender As Object, ByVal e As ThumbnailErrorEventArgs)
    ''' <summary>
    ''' Occurs when progress changes during video thumbnail processing
    ''' </summary>
    ''' <param name="sender">The ThumbnailGenerator instance that raised this event</param>
    ''' <param name="e">The ThumbnailProgressEventArgs EventArgs that contain progress information</param>
    ''' <remarks></remarks>
    Public Event ThumbnailProgressChanged(ByVal sender As Object, ByVal e As ThumbnailProgressEventArgs)
#End Region

#Region "PUBLIC PROPERTIES"

    ''' <summary>
    ''' Indicates if the ThumbnailProgressChanged should be raised during processing
    ''' </summary>
    ''' <value>True to report progress, False to bypass reporting progress</value>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Property ReportsProgress() As Boolean
        Get
            Return _ReportsProgress
        End Get
        Set(ByVal value As Boolean)
            _ReportsProgress = value
        End Set
    End Property

    ''' <summary>
    ''' Gets the time that has passed since processing started, and now
    ''' </summary>
    ''' <value>This property is readonly</value>
    ''' <returns>Timespan object</returns>
    ''' <remarks></remarks>
    Private ReadOnly Property TimeSinceStarted() As TimeSpan
        Get
            Return (Now - _StartTime)
        End Get
    End Property
#End Region

#Region "PUBLIC SUB ROUTINES (ENTRY POINTS TO THE CLASS)"

    ''' <summary>
    ''' Creates thumbnails of the specified video, and saves them to disk in JPG format
    ''' </summary>
    ''' <param name="VideoFileName">The full path to the video file to process</param>
    ''' <param name="OutputDirectory">The directory to output the thumbnails to (must exist prior)</param>
    ''' <param name="StartOffset">The offset amount, in seconds, to clip at the start processing</param>
    ''' <param name="EndOffset">The offset amount, in seconds, to clip at the end when processing</param>
    ''' <param name="NumberOfThumbs">The number of thumbnails to create</param>
    ''' <param name="Width">The Width of the thumbnail</param>
    ''' <param name="Height">The Height of the thumbnail</param>
    ''' <remarks></remarks>
    Public Sub CreateThumbnailsToFile(ByVal VideoFileName As String, ByVal OutputDirectory As String, ByVal StartOffset As TimeSpan, ByVal EndOffset As TimeSpan, ByVal NumberOfThumbs As Integer, ByVal Width As Integer, ByVal Height As Integer)

        Try
            'VALIDATE USER INPUT
            If Not IO.File.Exists(VideoFileName) Then
                Throw New IO.FileNotFoundException("Video File Not Found")
            ElseIf Not IO.Directory.Exists(OutputDirectory) Then
                Throw New IO.DirectoryNotFoundException("Output Directory Not Found")
            ElseIf Width < 0 OrElse Height < 0 Then
                Throw New ArgumentOutOfRangeException("Height/Width of thumbnails must be 0 (for natural size) or greater (for custom size)")
            ElseIf Width = 0 Or Height = 0 Then
                'IF EITHER ARE 0, THEN WE USE THE VIDEO SIZE WHEN BOTH 0
                'IF ONLY 1 VALUE IS 0, WE WILL MAP THE OTHER VALUE ONCE THE VIDEO
                'IS OPENED, AND WE CAN GET THE NATURAL HEIGHT/WIDTH
                _MapHeightWidth = (Width <> Height)
            End If

            _VideoFileName = VideoFileName
            _OutputDirectory = OutputDirectory
            _StartOffset = StartOffset
            _EndOffset = EndOffset
            _NumberOfThumbs = NumberOfThumbs
            _ThumbCreationType = eThumbCreationType.ToFile
            _ThumbSize = New System.Drawing.Size(Width, Height)
            If _FileNameCache IsNot Nothing Then
                _FileNameCache.Clear()
            End If
            _FileNameCache = New List(Of String)

            start()
        Catch ex As Exception
            OnThumbnailCreationFailed(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Creates thumbnails of the specified video, and saves them to disk in JPG format
    ''' </summary>
    ''' <param name="VideoFileName">The full path to the video file to process</param>
    ''' <param name="OutputDirectory">The directory to output the thumbnails to (must exist prior)</param>
    ''' <param name="StartOffset">The offset amount, in seconds, to clip at the start processing</param>
    ''' <param name="EndOffset">The offset amount, in seconds, to clip at the end when processing</param>
    ''' <param name="NumberOfThumbs">The number of thumbnails to create</param>
    ''' <remarks>Uses the videos natural size for the thumbnail size</remarks>
    Public Sub CreateThumbnailsToFile(ByVal VideoFileName As String, ByVal OutputDirectory As String, ByVal StartOffset As TimeSpan, ByVal EndOffset As TimeSpan, ByVal NumberOfThumbs As Integer)
        Try
            CreateThumbnailsToFile(VideoFileName, OutputDirectory, StartOffset, EndOffset, NumberOfThumbs, 0, 0)
        Catch ex As Exception
            OnThumbnailCreationFailed(ex)
        End Try
    End Sub


    ''' <summary>
    ''' Creates thumbnails of the specified video, and loads them to a list of System.Drawing.Image
    ''' </summary>
    ''' <param name="VideoFileName">The full path to the video file to process</param>
    ''' <param name="StartOffset">The offset amount, in seconds, to clip at the start processing</param>
    ''' <param name="EndOffset">The offset amount, in seconds, to clip at the end when processing</param>
    ''' <param name="NumberOfThumbs">The number of thumbnails to create</param>
    ''' <remarks>Uses the videos natural size for the thumbnail size</remarks>
    Public Sub CreateThumbnailsToMemory(ByVal VideoFileName As String, ByVal StartOffset As TimeSpan, ByVal EndOffset As TimeSpan, ByVal NumberOfThumbs As Integer)
        Try
            CreateThumbnailsToMemory(VideoFileName, StartOffset, EndOffset, NumberOfThumbs, 0, 0)
        Catch ex As Exception
            OnThumbnailCreationFailed(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Creates thumbnails of the specified video, and loads them to a list of System.Drawing.Image
    ''' </summary>
    ''' <param name="VideoFileName">The full path to the video file to process</param>
    ''' <param name="StartOffset">The offset amount, in seconds, to clip at the start processing</param>
    ''' <param name="EndOffset">The offset amount, in seconds, to clip at the end when processing</param>
    ''' <param name="NumberOfThumbs">The number of thumbnails to create</param>
    ''' <param name="Width">The Width of the thumbnail</param>
    ''' <param name="Height">The Height of the thumbnail</param>
    ''' <remarks></remarks>
    Public Sub CreateThumbnailsToMemory(ByVal VideoFileName As String, ByVal StartOffset As TimeSpan, ByVal EndOffset As TimeSpan, ByVal NumberOfThumbs As Integer, ByVal Width As Integer, ByVal Height As Integer)

        Try
            If Not IO.File.Exists(VideoFileName) Then
                Throw New IO.FileNotFoundException("Video File Not Found")
            ElseIf Width < 0 OrElse Height < 0 Then
                Throw New ArgumentOutOfRangeException("Height/Width of thumbnails must be 0 (for natural size) or greater (for custom size)")
            ElseIf Width = 0 Or Height = 0 Then
                'IF EITHER ARE 0, THEN WE USE THE VIDEO SIZE WHEN BOTH 0
                'IF ONLY 1 VALUE IS 0, WE WILL MAP THE OTHER VALUE ONCE THE VIDEO
                'IS OPENED, AND WE CAN GET THE NATURAL HEIGHT/WIDTH
                _MapHeightWidth = (Width <> Height)
            End If

            _VideoFileName = VideoFileName
            _StartOffset = StartOffset
            _EndOffset = EndOffset
            _NumberOfThumbs = NumberOfThumbs
            _ThumbCreationType = eThumbCreationType.ToMemory

            If _MemoryImageCache IsNot Nothing Then
                For Each I As System.Drawing.Image In _MemoryImageCache
                    I.Dispose()
                Next
                _MemoryImageCache.Clear()
            End If

            _MemoryImageCache = New List(Of System.Drawing.Image)
            _ThumbSize = New System.Drawing.Size(Width, Height)

            start()
        Catch ex As Exception
            OnThumbnailCreationFailed(ex)
        End Try

    End Sub

#End Region


    '***********************************
    '      PRIVATE CODE SECTION
    '***********************************

#Region "PRIVATE CLASS VARIABLES"
    Private WithEvents _mediaPlayer As MediaPlayer = Nothing
    Private WithEvents _dispatchTimer As DispatcherTimer = Nothing

    Private _NextPositionToTake As TimeSpan
    Private _ThumbsTaken As Integer = 0

    Private _VideoFileName As String = String.Empty
    Private _OutputDirectory As String = String.Empty
    Private _StartOffset As TimeSpan
    Private _EndOffset As TimeSpan
    Private _NumberOfThumbs As Integer

    Private _ThumbCreationType As eThumbCreationType

    Private _MemoryImageCache As List(Of System.Drawing.Image)
    Private _FileNameCache As List(Of String)

    Private _ThumbSize As New System.Drawing.Size(0, 0)
    Private _framePixels As UInteger()
    Private _FramePixelsPrevious As UInteger()
    Private _Processing As Boolean = False
    Private _MapHeightWidth As Boolean = False

    Private _StartTime As DateTime

    Private _TimeQueue As Queue(Of TimeSpan)

    Private _ReportsProgress As Boolean = False

#End Region

#Region "ENUMERATIONS"
    Private Enum eThumbCreationType
        ToFile
        ToMemory
    End Enum
#End Region

#Region "PRIVATE SUB ROUTINES"

    Private Sub start()

        Try
            Debug.WriteLine("Start")

            _StartTime = Now
            _Processing = True

            If _mediaPlayer IsNot Nothing Then
                _mediaPlayer.Close()
                _mediaPlayer = Nothing
            End If
            _mediaPlayer = New MediaPlayer
            _mediaPlayer.ScrubbingEnabled = True

            If _dispatchTimer Is Nothing Then
                _dispatchTimer = New DispatcherTimer
            End If
            _dispatchTimer.Stop()
            _dispatchTimer.Interval = TimeSpan.FromSeconds(1)

            If _TimeQueue IsNot Nothing Then
                _TimeQueue.Clear()
            End If
            _TimeQueue = New Queue(Of TimeSpan)

            _NextPositionToTake = TimeSpan.Zero
            _ThumbsTaken = 0

            Debug.WriteLine("About to Open Media")
            _mediaPlayer.Open(New Uri(_VideoFileName, UriKind.Absolute))
        Catch : Throw
        End Try

    End Sub

    Private Function RenderBitmapAndCapturePixels(ByVal Pixels As UInteger()) As ImageSource
        Try
            ' Render the current frame into a bitmap
            Dim drawingVisual = New DrawingVisual()
            Dim renderTargetBitmap = New RenderTargetBitmap(_ThumbSize.Width, _ThumbSize.Height, 96, 96, PixelFormats.[Default])
            Using drawingContext = drawingVisual.RenderOpen()
                drawingContext.DrawVideo(_mediaPlayer, New Rect(0, 0, _ThumbSize.Width, _ThumbSize.Height))
            End Using
            renderTargetBitmap.Render(drawingVisual)

            ' Copy the pixels to the specified location
            Dim myStride As Integer = (renderTargetBitmap.PixelWidth * renderTargetBitmap.Format.BitsPerPixel + 7) \ 8

            renderTargetBitmap.CopyPixels(Pixels, myStride, 0)

            ' Return the bitmap
            Return renderTargetBitmap
        Catch : Throw
        End Try

    End Function

    Private Sub GenerateTimeQueue()

        Try
            Dim TotalVideoLength As TimeSpan = _mediaPlayer.NaturalDuration.TimeSpan
            Dim StartTime As TimeSpan = _StartOffset
            Dim EndTime As TimeSpan = (TotalVideoLength - _EndOffset)
            Dim LengthToCapture As TimeSpan = (TotalVideoLength - (_StartOffset + _EndOffset))
            Dim TotalSeconds As Integer = CInt(LengthToCapture.TotalSeconds)

            If TotalSeconds < _NumberOfThumbs Then
                Throw New InvalidOperationException("Offsets/Thumbnail count specified not valid for length of this video")
            End If

            Dim Increment = CInt(LengthToCapture.TotalSeconds) \ _NumberOfThumbs

            'FORCE 1 SECOND INCREMENTS IF THEY WANTED MORE THUMBS THAN AVAILABLE SECONDS
            If Increment = 0 Then Increment = 1

            For i As Integer = 1 To _NumberOfThumbs
                If i = 1 AndAlso _StartOffset = TimeSpan.Zero Then
                    Debug.WriteLine("First Thumb will be taken at frame 0")
                Else
                    Dim TS = StartTime.Add(TimeSpan.FromSeconds(Increment * i))
                    _TimeQueue.Enqueue(TS)
                    Debug.WriteLine("Time Queued for thumbnail: " & TS.ToString)
                End If
            Next
        Catch : Throw
        End Try

    End Sub

    Private Sub SeekToNextThumbnailPosition()
        Try
            If _ThumbsTaken = _NumberOfThumbs Then



                PerformCleanup()

                If _ReportsProgress Then
                    RaiseEvent ThumbnailProgressChanged(Me, New ThumbnailProgressEventArgs(_NumberOfThumbs, _
                                    _ThumbsTaken, _
                                    _NextPositionToTake, _
                                    TimeSinceStarted, _
                                    "Media Closed"))
                End If

                Dim TimeTaken = (Now - _StartTime)
                If _ThumbCreationType = eThumbCreationType.ToFile Then
                    RaiseEvent ThumbnailsCreatedToDisk(Me, New ThumbnailsCreatedEventArgs(Of String)(_FileNameCache.ToArray, TimeTaken))
                Else
                    RaiseEvent ThumbnailsCreatedToMemory(Me, New ThumbnailsCreatedEventArgs(Of System.Drawing.Image)(_MemoryImageCache.ToArray, TimeTaken))
                End If

            Else
                _NextPositionToTake = _TimeQueue.Dequeue
                _mediaPlayer.Position = _NextPositionToTake
                _dispatchTimer.Start()
            End If
        Catch : Throw
        End Try

    End Sub

    Private Sub CaptureCurrentFrame(ByVal forceCapture As Boolean, ByVal IsFirstFrame As Boolean)

        Try
            ' Capture the current frame as an ImageSource
            Dim imageSource = RenderBitmapAndCapturePixels(_framePixels)

            ' If captured pixels are different than the previous frame...
            If forceCapture OrElse Not _framePixels.SequenceEqual(_FramePixelsPrevious) Then
                ' Stop the  timer
                _dispatchTimer.Stop()

                ' Add an Image for the Thumbnail
                _ThumbsTaken += 1
                SaveCaptureToCollection(imageSource)

                If _ReportsProgress Then
                    RaiseEvent ThumbnailProgressChanged(Me, New ThumbnailProgressEventArgs(_NumberOfThumbs, _
                                    _ThumbsTaken, _
                                    _NextPositionToTake, _
                                    TimeSinceStarted, _
                                    "Media Seek Occured"))
                End If


                ' Swap the pixel buffers (moves current to previous and avoids allocating a new buffer for current)
                Dim tempPixels = _framePixels
                _framePixels = _FramePixelsPrevious
                _FramePixelsPrevious = tempPixels

                ' Seek to the next thumbnail position
                If Not IsFirstFrame Then SeekToNextThumbnailPosition()
            End If
        Catch : Throw
        End Try

    End Sub

    Private Sub SaveCaptureToCollection(ByVal theImage As ImageSource)

        Try
            Dim myBMPSource As BitmapSource = CType(theImage, BitmapSource)

            Dim myEncoder As New JpegBitmapEncoder

            myEncoder.Frames.Add(BitmapFrame.Create(myBMPSource))

            If _ThumbCreationType = eThumbCreationType.ToFile Then
                Dim FileName As String = ""
                If _VideoFileName <> "" Then
                    FileName = _VideoFileName.Replace(".mp4", ".jpg")
                Else
                    FileName = IO.Path.Combine(_OutputDirectory, _ThumbsTaken.ToString("00") & ".jpg")
                End If
                Using myFileStream As New IO.FileStream(FileName, IO.FileMode.Create)
                    myEncoder.Save(myFileStream)
                End Using
                _FileNameCache.Add(FileName)
            Else
                Using myMemoryStream As New IO.MemoryStream()
                    myEncoder.Save(myMemoryStream)
                    _MemoryImageCache.Add(System.Drawing.Image.FromStream(myMemoryStream))
                End Using
            End If
        Catch : Throw
        End Try

    End Sub

    Private Sub OnThumbnailCreationFailed(ByVal ex As Exception)

        PerformCleanup()

        RaiseEvent ThumbnailCreationFailed(Me, New ThumbnailErrorEventArgs(ex))

    End Sub

    Private Sub PerformCleanup()
        Try
            If _dispatchTimer IsNot Nothing Then
                _dispatchTimer.Stop()
                _dispatchTimer = Nothing
            End If

            If _mediaPlayer IsNot Nothing Then
                If _mediaPlayer.Source IsNot Nothing Then
                    _mediaPlayer.Close()
                End If
                _mediaPlayer = Nothing
            End If

            If _TimeQueue IsNot Nothing Then
                _TimeQueue.Clear()
                _TimeQueue = Nothing
            End If

            _NextPositionToTake = TimeSpan.Zero
            _ThumbsTaken = 0

            _VideoFileName = String.Empty
            _OutputDirectory = String.Empty
            _StartOffset = TimeSpan.Zero
            _EndOffset = TimeSpan.Zero
            _NumberOfThumbs = 0

            'NOT CLEARING THESE BECAUSE THEIR CONTENTS ARE PASSED TO THE
            'EVENTS THAT ARE RAISED TO THE CLASS CONSUMER
            '
            '_MemoryImageCache
            '_FileNameCache 

            _ThumbSize = System.Drawing.Size.Empty
            _framePixels = Nothing
            _FramePixelsPrevious = Nothing
            _Processing = False
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "MEDIA PLAYER EVENTS"
    Private Sub _mediaPlayer_MediaOpened(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mediaPlayer.MediaOpened


        Debug.WriteLine("Media Opened")

        If Not _mediaPlayer.HasVideo Then
            OnThumbnailCreationFailed(New ArgumentException("The media file selected does not have video"))
            Return
        End If

        Try
            If _ReportsProgress Then
                RaiseEvent ThumbnailProgressChanged(Me, New ThumbnailProgressEventArgs(_NumberOfThumbs, _
                                                                    _ThumbsTaken, _
                                                                    TimeSpan.Zero, _
                                                                     TimeSinceStarted, _
                                                                    "Media has been opened"))
            End If

            'PIXEL INIT WAS HERE, MOVED IT BELOW AFTER WE HAVE SIZE OF THUMBS TO CREATE

            GenerateTimeQueue()

            If _MapHeightWidth Then
                If _ThumbSize.Height = 0 Then
                    'HEIGHT = 0, MAP TO WIDTH
                    _ThumbSize.Height = CInt(_mediaPlayer.NaturalVideoHeight / _
                                       (_mediaPlayer.NaturalVideoWidth / _ThumbSize.Width))
                Else
                    'WIDTH = 0, MAP TO HEIGHT
                    _ThumbSize.Width = CInt(_mediaPlayer.NaturalVideoWidth / _
                                       (_mediaPlayer.NaturalVideoHeight / _ThumbSize.Height))
                End If
            ElseIf _ThumbSize.IsEmpty OrElse (_ThumbSize.Height < 0 Or _ThumbSize.Width < 0) Then
                _ThumbSize.Height = _mediaPlayer.NaturalVideoHeight
                _ThumbSize.Width = _mediaPlayer.NaturalVideoWidth
            End If

            _framePixels = New UInteger((_ThumbSize.Width * _ThumbSize.Height) - 1) {}
            _FramePixelsPrevious = New UInteger(_framePixels.Length - 1) {}

            RenderBitmapAndCapturePixels(_FramePixelsPrevious)

            'ONLY CAPTURE FIRST FRAME OF THE VIDEO IF THERE IS NO STARTING OFFSET
            If _StartOffset = TimeSpan.Zero Then
                CaptureCurrentFrame(True, True)
            End If

            SeekToNextThumbnailPosition()
        Catch ex As Exception
            OnThumbnailCreationFailed(ex)
        End Try

    End Sub

    Private Sub _mediaPlayer_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mediaPlayer.Changed


        Debug.WriteLine(_mediaPlayer.Source.ToString)

        Try
            Debug.WriteLine("Changed Event: " & _mediaPlayer.Position.ToString)

            If _Processing Then

                CaptureCurrentFrame(False, False)

            End If
        Catch : Throw
        End Try


    End Sub

    Private Sub _mediaPlayer_MediaFailed(ByVal sender As Object, ByVal e As System.Windows.Media.ExceptionEventArgs) Handles _mediaPlayer.MediaFailed
        OnThumbnailCreationFailed(e.ErrorException)
    End Sub
#End Region

#Region "DISPATCH TIMER EVENTS"
    Private Sub _dispatchTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _dispatchTimer.Tick
        _dispatchTimer.Stop()
        CaptureCurrentFrame(True, False)
    End Sub
#End Region

End Class