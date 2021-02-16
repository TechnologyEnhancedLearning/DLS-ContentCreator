Imports System.Drawing.Drawing2D
Imports Microsoft.Win32
Imports System.IO
Imports System.Text.RegularExpressions

Public Class utility

    Public Shared Property r As New Random
    Shared Function ColorToHexString(ByVal color As Color) As String
        Return String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)
    End Function
    Shared Function HTMLEncodeWithTags(ByVal sString As String) As String
        sString = System.Web.HttpUtility.HtmlEncode(sString)
        sString = sString.Replace("&lt;", "<")
        sString = sString.Replace("&gt;", ">")
        Return sString
    End Function
    Shared Function hexAndOpacityToRgba(ByVal Hex As String, ByVal Opacity As Decimal) As String
        If Hex.StartsWith("#") Then
            Hex = Replace(Hex, "#", "")
            Dim red As String = Convert.ToInt32(Hex.Substring(0, 2), 16).ToString
            Dim green As String = Convert.ToInt32(Hex.Substring(2, 2), 16).ToString
            Dim blue As String = Convert.ToInt32(Hex.Substring(4, 2), 16).ToString
            Return "rgba(" & red & ", " & green & ", " & blue & ", " & Opacity.ToString & ")"
        Else
            Return Hex
        End If
    End Function
    Shared Function StripHTML(source As String) As String
        Try
            Dim result As String

            ' Remove HTML Development formatting
            ' Replace line breaks with space
            ' because browsers inserts space
            result = source.Replace(vbCr, " ")
            ' Replace line breaks with space
            ' because browsers inserts space
            result = result.Replace(vbLf, " ")
            ' Remove step-formatting
            result = result.Replace(vbTab, String.Empty)
            ' Remove repeating spaces because browsers ignore them
            result = System.Text.RegularExpressions.Regex.Replace(result, "( )+", " ")

            ' Remove the header (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*head([^>])*>", "<head>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "(<( )*(/)( )*head( )*>)", "</head>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "(<head>).*(</head>)", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)

            ' remove all scripts (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*script([^>])*>", "<script>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "(<( )*(/)( )*script( )*>)", "</script>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result,
            '         @"(<script>)([^(<script>\.</script>)])*(</script>)",
            '         string.Empty,
            '         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result, "(<script>).*(</script>)", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)

            ' remove all styles (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*style([^>])*>", "<style>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "(<( )*(/)( )*style( )*>)", "</style>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "(<style>).*(</style>)", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)

            ' insert tabs in spaces of <td> tags
            result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*td([^>])*>", vbTab, System.Text.RegularExpressions.RegexOptions.IgnoreCase)

            ' insert line breaks in places of <BR> and <LI> tags
            result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*br( )*>", vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*li( )*>", vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)

            ' insert line paragraphs (double line breaks) in place
            ' if <P>, <DIV> and <TR> tags
            result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*div([^>])*>", vbCr & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*tr([^>])*>", vbCr & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*p([^>])*>", vbCr & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)

            ' Remove remaining tags like <a>, links, images,
            ' comments etc - anything that's enclosed inside < >
            result = System.Text.RegularExpressions.Regex.Replace(result, "<[^>]*>", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)

            ' replace special characters:
            result = System.Text.RegularExpressions.Regex.Replace(result, " ", " ", System.Text.RegularExpressions.RegexOptions.IgnoreCase)

            result = System.Text.RegularExpressions.Regex.Replace(result, "&bull;", " * ", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "&lsaquo;", "<", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "&rsaquo;", ">", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "&trade;", "(tm)", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "&frasl;", "/", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "&lt;", "<", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "&gt;", ">", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "&copy;", "(c)", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "&reg;", "(r)", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            ' Remove all others. More can be added, see
            ' http://hotwired.lycos.com/webmonkey/reference/special_characters/
            result = System.Text.RegularExpressions.Regex.Replace(result, "&(.{2,6});", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)

            ' for testing
            'System.Text.RegularExpressions.Regex.Replace(result,
            '       this.txtRegex.Text,string.Empty,
            '       System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            ' make line breaking consistent
            result = result.Replace(vbLf, vbCr)

            ' Remove extra line breaks and tabs:
            ' replace over 2 breaks with 2 and over 4 tabs with 4.
            ' Prepare first to remove any whitespaces in between
            ' the escaped characters and remove redundant tabs in between line breaks
            result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbCr & ")( )+(" & vbCr & ")", vbCr & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbTab & ")( )+(" & vbTab & ")", vbTab & vbTab, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbTab & ")( )+(" & vbCr & ")", vbTab & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbCr & ")( )+(" & vbTab & ")", vbCr & vbTab, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            ' Remove redundant tabs
            result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbCr & ")(" & vbTab & ")+(" & vbCr & ")", vbCr & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            ' Remove multiple tabs following a line break with just one tab
            result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbCr & ")(" & vbTab & ")+", vbCr & vbTab, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            ' Initial replacement target string for line breaks
            Dim breaks As String = vbCr & vbCr & vbCr
            ' Initial replacement target string for tabs
            Dim tabs As String = vbTab & vbTab & vbTab & vbTab & vbTab
            For index As Integer = 0 To result.Length - 1
                result = result.Replace(breaks, vbCr & vbCr)
                result = result.Replace(tabs, vbTab & vbTab & vbTab & vbTab)
                breaks = breaks & Convert.ToString(vbCr)
                tabs = tabs & Convert.ToString(vbTab)
            Next

            ' That's it.
            Return result
        Catch
            MessageBox.Show("Error")
            Return source
        End Try
    End Function
    Public Shared Function RemovePageTags(ByVal source As String) As String
        Try
            If source Is Nothing Then
                Return ""
            End If
            Dim result As String
            ' Remove the html tags (prepare first by clearing attributes)
            result = Text.RegularExpressions.Regex.Replace(source, "<( )*html([^>])*>", "<meta>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = Text.RegularExpressions.Regex.Replace(result, "(<html>)", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = Text.RegularExpressions.Regex.Replace(result, "<!DOCTYPE(.*?)>", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = result.Replace("<head>", String.Empty)
            ' Remove the meta tags (prepare first by clearing attributes)
            result = Text.RegularExpressions.Regex.Replace(result, "<( )*meta([^>])*>", "<meta>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = Text.RegularExpressions.Regex.Replace(result, "(<meta>)", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            result = result.Replace("<title>", String.Empty)
            result = result.Replace("</title>", String.Empty)
            result = result.Replace("</head>", String.Empty)
            result = result.Replace("<body>", String.Empty)
            result = result.Replace("</body>", String.Empty)
            result = result.Replace("</html>", String.Empty)
            Return result
        Catch ex As Exception
            MessageBox.Show("Error")
            Return source
        End Try
    End Function
    Public Shared Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                    percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function
    Public Shared Function IsApplictionInstalled(p_name As String) As String
        Dim displayName As String
        Dim key As RegistryKey

        ' search in: CurrentUser
        key = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall")
        For Each keyName As [String] In key.GetSubKeyNames()
            Dim subkey As RegistryKey = key.OpenSubKey(keyName)
            displayName = TryCast(subkey.GetValue("DisplayName"), String)
            If p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) = True Then
                Return TryCast(subkey.GetValue("DisplayIcon"), String)
            End If
        Next

        ' search in: LocalMachine_32
        key = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall")
        For Each keyName As [String] In key.GetSubKeyNames()
            Dim subkey As RegistryKey = key.OpenSubKey(keyName)
            displayName = TryCast(subkey.GetValue("DisplayName"), String)
            If p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) = True Then
                Return TryCast(subkey.GetValue("DisplayIcon"), String)
            End If
        Next

        ' search in: LocalMachine_64
        key = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall")
        For Each keyName As [String] In key.GetSubKeyNames()
            Dim subkey As RegistryKey = key.OpenSubKey(keyName)
            displayName = TryCast(subkey.GetValue("DisplayName"), String)
            If p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) = True Then
                Return TryCast(subkey.GetValue("DisplayIcon"), String)
            End If
        Next

        ' NOT FOUND
        Return ""
    End Function
    Public Shared Function TidyFileName(sFileName As String) As String
        For Each invalidChar In IO.Path.GetInvalidFileNameChars
            sFileName = sFileName.Replace(invalidChar, "")
        Next
        sFileName = sFileName.Trim()
        sFileName = sFileName.Replace(" ", "_")
        Return sFileName
    End Function
    Public Shared Function RandomString(Optional digits As Integer = 6) As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghjklmnopqrstuvwxyz"
        Dim sb As New System.Text.StringBuilder
        For i As Integer = 1 To digits
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Public Shared Function FileInUse(ByVal sFile As String) As Boolean
        Dim thisFileInUse As Boolean = False
        If System.IO.File.Exists(sFile) Then
            Try
                Using f As New IO.FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                    ' thisFileInUse = False
                End Using
            Catch
                thisFileInUse = True
            End Try
        End If
        Return thisFileInUse
    End Function
    Public Shared Function CaptureScreen() As Image
        Return CaptureWindow(User32.GetDesktopWindow())
    End Function

    Public Shared Function CaptureWindow(handle As IntPtr, Optional nHeight As Integer = 0, Optional nWidth As Integer = 0) As Image

        Dim hdcSrc As IntPtr = User32.GetWindowDC(handle)

        Dim windowRect As New User32.RECT()
        User32.GetWindowRect(handle, windowRect)
        Dim nOffsetH As Integer = 0
        Dim nOffsetV As Integer = 0

        Dim width As Integer = windowRect.right - windowRect.left
        Dim height As Integer = windowRect.bottom - windowRect.top
        If nHeight + nWidth > 0 Then
            Dim ratioH As Double = (width * 1.0) / (nWidth * 1.0)
            Dim ratioV As Double = (height * 1.0) / (nHeight * 1.0)
            If ratioH > ratioV Then
                nOffsetH = CInt((width - (nWidth * ratioV)) / 2)
            Else
                nOffsetV = CInt((height - (nHeight * ratioH)) / 2)
            End If
        End If
        Dim hdcDest As IntPtr = Gdi32.CreateCompatibleDC(hdcSrc)
        Dim hBitmap As IntPtr = Gdi32.CreateCompatibleBitmap(hdcSrc, width - (2 * nOffsetH), height - (2 * nOffsetV))

        Dim hOld As IntPtr = Gdi32.SelectObject(hdcDest, hBitmap)
        Gdi32.BitBlt(hdcDest, 0, 0, width - nOffsetH, height - nOffsetV, hdcSrc,
            nOffsetH, nOffsetV, User32.SRCCOPY)
        Gdi32.SelectObject(hdcDest, hOld)
        Gdi32.DeleteDC(hdcDest)
        User32.ReleaseDC(handle, hdcSrc)

        Dim image__1 As Image = Image.FromHbitmap(hBitmap)
        Gdi32.DeleteObject(hBitmap)

        Return image__1
    End Function
    Public Shared Function ReplacePtsWithPx(sInput As String) As String
        Dim regex As Regex = New Regex("font-size:\d+.?\d?(pt|px)")
        Dim sReplacement As String = "font-size:16px"
        Return regex.Replace(sInput, sReplacement)
    End Function
    Public Shared Function FixHTMLProjectFontsize(ByVal sInput As String) As String

        Dim regex As Regex = New Regex("font-size:\d+.?\d?px")
        Dim sReplacement As String = "font-size:" + CInt(CDAMain.itspunit.FontSize).ToString + "px"
        Return regex.Replace(sInput, sReplacement)
    End Function
End Class
