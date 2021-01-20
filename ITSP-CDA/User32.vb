Imports System.Runtime.InteropServices

Public NotInheritable Class User32
    Private Sub New()
    End Sub
    <DllImport("user32.dll")> _
    Public Shared Function GetDesktopWindow() As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function GetWindowDC(hWnd As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function GetWindowRect(hWnd As IntPtr, ByRef rect As RECT) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function ReleaseDC(hWnd As IntPtr, hDC As IntPtr) As IntPtr
    End Function
    Public Const SRCCOPY As Integer = 13369376
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure
End Class
