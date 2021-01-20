Imports System.Runtime.InteropServices

Public Class Gdi32
    <DllImport("gdi32.dll")> _
    Public Shared Function BitBlt(hObject As IntPtr, nXDest As Integer, nYDest As Integer, nWidth As Integer, nHeight As Integer, hObjectSource As IntPtr, _
        nXSrc As Integer, nYSrc As Integer, dwRop As Integer) As Boolean
    End Function
    <DllImport("gdi32.dll")> _
    Public Shared Function CreateCompatibleBitmap(hDC As IntPtr, nWidth As Integer, nHeight As Integer) As IntPtr
    End Function
    <DllImport("gdi32.dll")> _
    Public Shared Function CreateCompatibleDC(hDC As IntPtr) As IntPtr
    End Function
    <DllImport("gdi32.dll")> _
    Public Shared Function DeleteDC(hDC As IntPtr) As Boolean
    End Function
    <DllImport("gdi32.dll")> _
    Public Shared Function DeleteObject(hObject As IntPtr) As Boolean
    End Function
    <DllImport("gdi32.dll")> _
    Public Shared Function SelectObject(hDC As IntPtr, hObject As IntPtr) As IntPtr
    End Function
End Class
