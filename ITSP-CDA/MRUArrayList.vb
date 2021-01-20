
Imports System.Environment
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Ribbon
Imports System.Collections
Imports System.Windows.Forms
Imports System.IO

Public Class MRUArrayList
    Inherits ArrayList
    Public appData As String = GetFolderPath(SpecialFolder.ApplicationData).ToString
    Public Shared MRUFileName As String = GetFolderPath(SpecialFolder.ApplicationData) & "\ITSP\RibbonMRUFiles.ini"
    Public Shared MRUFolderName As String = GetFolderPath(SpecialFolder.ApplicationData) & "\ITSP\RibbonMRUFolders.ini"
    Private container As Control
    Private maxRecentFiles As Integer = 9
    Private imgChecked, imgUncheked, glyph As Image
    Public Event LabelClicked As EventHandler
    Private indexedList As Boolean
    Private showDescription As Boolean
    Public Sub New(ByVal cont As Control, ByVal iChecked As Image, ByVal iUnchecked As Image, ByVal glyph As Image, ByVal indexedList As Boolean, ByVal showDescription As Boolean)
        Me.New(cont, iChecked, iUnchecked, glyph)
        Me.indexedList = indexedList
        Me.showDescription = showDescription
    End Sub
    Public Sub New(ByVal cont As Control, ByVal iChecked As Image, ByVal iUnchecked As Image, ByVal glyph As Image)
        Me.New(cont, iChecked, iUnchecked)
        Me.glyph = glyph
    End Sub
    Public Sub New(ByVal cont As Control, ByVal iChecked As Image, ByVal iUnchecked As Image)
        MyBase.New()
        Me.indexedList = True
        Me.imgChecked = iChecked
        Me.imgUncheked = iUnchecked
        Me.container = cont
    End Sub
    Public Sub InsertElement(ByVal value As Object)
        Dim names() As String = value.ToString().Split(","c)
        Dim name As String = names(0)
        Dim checkedLabel As Boolean = False
        If names.Length > 1 Then
            checkedLabel = names(1).ToLower().Equals("true")
        End If
        For Each c As Control In container.Controls
            Dim ml As AppMenuFileLabel = TryCast(c, AppMenuFileLabel)
            If ml Is Nothing Then
                Continue For
            End If
            If ml.Tag.Equals(name) Then
                checkedLabel = ml.Checked
                MyBase.Remove(name)
                RemoveHandler ml.LabelClick, AddressOf OnLabelClick
                ml.Dispose()
                Exit For
            End If
        Next c
        Dim access As Boolean = True
        If MyBase.Count >= maxRecentFiles Then
            access = RemoveLastElement()
        End If
        If access Then
            MyBase.Insert(0, name)
            Dim ml As New AppMenuFileLabel()
            container.Controls.Add(ml)
            ml.BringToFront()
            ml.Tag = name
            If showDescription Then
                ml.Text = GetFileName(name)
                ml.Description = name
            Else
                ml.Text = GetFileName(name)
            End If
            ml.Glyph = glyph
            ml.Checked = checkedLabel
            ml.AutoHeight = True
            ml.Dock = DockStyle.Top
            ml.Image = imgUncheked
            ml.SelectedImage = imgChecked
            AddHandler ml.LabelClick, AddressOf OnLabelClick
            If indexedList Then
                SetElementsRange()
            End If
        End If
    End Sub
    Private Sub OnLabelClick(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent LabelClicked((CType(sender, AppMenuFileLabel)).Tag.ToString(), e)
    End Sub
    Public Function RemoveLastElement() As Boolean
        For i As Integer = 0 To container.Controls.Count - 1
            Dim ml As AppMenuFileLabel = TryCast(container.Controls(i), AppMenuFileLabel)
            If (Not ml.Checked) Then
                MyBase.Remove(ml.Tag)
                RemoveHandler ml.LabelClick, AddressOf OnLabelClick
                ml.Dispose()
                Return True
            End If
        Next i
        Return False
    End Function
    Private Function GetFileName(ByVal obj As Object) As String
        Dim fi As New FileInfo(obj.ToString())
        Return fi.Name
    End Function
    Private Sub SetElementsRange()
        Dim i As Integer = 0
        For Each c As Control In container.Controls
            Dim ml As AppMenuFileLabel = TryCast(c, AppMenuFileLabel)
            If ml Is Nothing Then
                Continue For
            End If
            ml.Caption = String.Format("&{0}", container.Controls.Count - i)
            i += 1
        Next c
    End Sub
    Public Function GetLabelChecked(ByVal name As String) As Boolean
        For Each ml As AppMenuFileLabel In container.Controls
            If ml.Tag.Equals(name) Then
                Return ml.Checked
            End If
        Next ml
        Return False
    End Function
    Public Sub Init(ByVal fileName As String, ByVal defaultItem As String)
        If (Not System.IO.File.Exists(fileName)) Then
            '	InsertElement(defaultItem)
            '	Return#
            Dim myPath As String = GetFolderPath(SpecialFolder.ApplicationData) & "\ITSP\"
            If (Not System.IO.Directory.Exists(myPath)) Then
                System.IO.Directory.CreateDirectory(myPath)
            End If
            File.Create(fileName)
        End If
        Dim sr As System.IO.StreamReader = System.IO.File.OpenText(fileName)
        container.SuspendLayout()
        Dim s As String = sr.ReadLine()
        Do While s IsNot Nothing
            InsertElement(s)
            s = sr.ReadLine()
        Loop
        sr.Close()
        container.ResumeLayout()
    End Sub
End Class
