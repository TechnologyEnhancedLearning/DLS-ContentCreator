Imports System.ComponentModel

Public Class EditText
    Public Property TextType As String = ""
    Public Property bModified As Boolean = False
    Public ReadOnly Property bht As mstns.TextBehaviour
        Get
            If CDAMain.allowPreview = False Then
                Return Nothing
            ElseIf Not CDAMain.currentBehaviour Is Nothing Then
                bht = CDAMain.currentBehaviour.Text_
                If Not bht Is Nothing Then
                    Return bht
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        SaveChanges()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub reditText_EmptyDocumentCreated(sender As Object, e As EventArgs) Handles reditText.EmptyDocumentCreated
        reditText.Document.DefaultCharacterProperties.FontName = CDAMain.itspunit.FontFamily
        reditText.Document.DefaultCharacterProperties.FontSize = CDAMain.itspunit.FontSize
        reditText.Document.DefaultParagraphProperties.SpacingAfter = 9
        reditText.Document.DefaultParagraphProperties.SpacingBefore = 3
        reditText.Document.DefaultParagraphProperties.LineSpacingMultiplier = 1.1
    End Sub

    Private Sub reditText_Enter(sender As Object, e As EventArgs) Handles reditText.Enter
        CDAMain.allowKeys = False
    End Sub

    Private Sub reditText_KeyDown(sender As Object, e As KeyEventArgs) Handles reditText.KeyDown
        If Not bModified And CDAMain.allowPreview Then
            bModified = True
        End If
    End Sub
    Public Sub SaveChanges()
        If Not bht Is Nothing Then
            If TextType = "StartText" Then
                bht.StartHtml = reditText.HtmlText
                Dim sHTML As String = bht.StartHtml
                sHTML = Replace(sHTML, "<body>", "<body><div id='" & CDAMain.selectedObjectID & "-content' class='text-area-content'>")
                sHTML = Replace(sHTML, "</body>", "</div></body>")
                sHTML = "<div class='start-text'>" & sHTML & "</div>"
                CDAMain.UpdateTextContent(sHTML)
            ElseIf TextType = "RequiredText" Then
                bht.RequiredHtml = reditText.HtmlText
            End If
            CDAMain.Modified = True
        End If
        bModified = False
    End Sub

    Private Sub EditText_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bModified Then
            If MsgBox("Would you like to save your changes?", MsgBoxStyle.YesNo, "Save changes?") = MsgBoxResult.Yes Then
                SaveChanges()
            End If
        End If
        CDAMain.allowKeys = True
    End Sub

    Private Sub btnCopyText_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCopyText.ItemClick
        reditText.HtmlText = bht.StartHtml
    End Sub

    Private Sub EditText_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If TextType = "StartText" Then
            btnCopyText.Enabled = False
        Else
            btnCopyText.Enabled = True
        End If
    End Sub

    Private Sub EditText_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "TextInteraction" & ".html")
    End Sub

    Private Sub EditText_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "TextInteraction" & ".html")
    End Sub
End Class