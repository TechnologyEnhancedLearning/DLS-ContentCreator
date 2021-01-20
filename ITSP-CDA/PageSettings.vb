Imports System.IO
Imports DevExpress.XtraEditors

Public Class PageSettings
    Public ReadOnly Property selectedPage As mstns.Page
        Get
            If Not CDAMain.itspunit Is Nothing Then
                selectedPage = CDAMain.itspunit.PageCol(CDAMain.selectedPageIndex)
            Else
                selectedPage = Nothing
            End If
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub UpdateImageGallery()
        'PopupGalleryEdit1.Properties.Gallery

    End Sub

    Private Sub reditInstructionText_EmptyDocumentCreated(sender As Object, e As EventArgs) Handles reditInstructionText.EmptyDocumentCreated, reditExampleText.EmptyDocumentCreated
        Dim redit As DevExpress.XtraRichEdit.RichEditControl = TryCast(sender, DevExpress.XtraRichEdit.RichEditControl)
        SetEmptyDocumentDefaults(redit)
    End Sub
    Protected Sub SetEmptyDocumentDefaults(ctrl As DevExpress.XtraRichEdit.RichEditControl)
        CDAMain.allowPreview = False
        ctrl.Document.DefaultCharacterProperties.FontName = CDAMain.itspunit.FontFamily
        reditInstructionText.Document.DefaultCharacterProperties.FontSize = CInt(CDAMain.itspunit.FontSize)
        reditInstructionText.Document.DefaultParagraphProperties.SpacingAfter = 9
        reditInstructionText.Document.DefaultParagraphProperties.SpacingBefore = 3
        reditInstructionText.Document.DefaultParagraphProperties.LineSpacingMultiplier = 1.1
        CDAMain.allowPreview = True
    End Sub

    Private Sub reditInstructionText_Enter(sender As Object, e As EventArgs) Handles reditInstructionText.Enter
        RichEditBarController1.RichEditControl = reditInstructionText
        CDAMain.allowKeys = False
    End Sub

    Private Sub reditExampleText_Enter(sender As Object, e As EventArgs) Handles reditExampleText.Enter
        RichEditBarController1.RichEditControl = reditExampleText
        CDAMain.allowKeys = False
    End Sub


    Private Sub tbPageName_GotFocus(sender As Object, e As EventArgs) Handles tbPageName.GotFocus, reditExampleText.GotFocus, reditInstructionText.GotFocus, spinWidth.GotFocus, spinX.GotFocus, spinY.GotFocus
        CDAMain.allowKeys = False
    End Sub
    Private Sub tbPageName_LostFocus(sender As Object, e As EventArgs) Handles tbPageName.LostFocus
        UpdateName(tbPageName.Text)
        CDAMain.allowKeys = True
    End Sub
    Public Sub UpdateName(ByVal pageName As String)
        'If CDAMain.allowPreview Then
        If selectedPage.PageName <> pageName Then
            selectedPage.PageName = pageName
            CDAMain.UpdatePageLists()
            FinaliseChange()
        End If
        'End If
    End Sub
    Shared Sub FinaliseChange()
        If CDAMain.allowPreview Then
            CDAMain.ReloadControls(False, True, True, True, True, False, True, True)
            CDAMain.Modified = True
        End If
    End Sub
    Private Sub reditInstructionText_HtmlTextChanged(sender As Object, e As EventArgs) Handles reditInstructionText.HtmlTextChanged, reditExampleText.HtmlTextChanged
        If CDAMain.allowPreview Then
            ApplyChanges()
        End If
    End Sub
    Public Sub ApplyChanges()
        If Not CDAMain.itspunit Is Nothing Then
            'Can't check for change here because it always returns true when testing...
            selectedPage.InstructionText = utility.FixHTMLProjectFontsize(reditInstructionText.HtmlText)
            selectedPage.InteractionText = utility.FixHTMLProjectFontsize(reditExampleText.HtmlText)
            CDAMain.Modified = True
            Dim t1 As String = Replace(Trim(utility.StripHTML(reditInstructionText.HtmlText)), " ", "")
            Dim t2 As String = Replace(Trim(utility.StripHTML(reditExampleText.HtmlText)), " ", "")
            If t1 Is Nothing Then
                t1 = ""
            End If
            If t2 Is Nothing Then
                t2 = ""
            End If
            Dim left As Integer = selectedPage.InstructionHPos
            Dim htmtext As String = ""
            If t1.Length > 2 And t2.Length > 2 Then
                htmtext = reditInstructionText.HtmlText & reditExampleText.HtmlText
            ElseIf t1.Length > 2 Then
                htmtext = reditInstructionText.HtmlText
            ElseIf t2.Length > 2 Then
                htmtext = reditExampleText.HtmlText
            Else
                left = -1000
            End If
            If Not CDAMain.wbPagePreview.Document Is Nothing Then
                CDAMain.wbPagePreview.Document.InvokeScript("updateInstructionText", {utility.FixHTMLProjectFontsize(htmtext), left})
            End If
        End If
    End Sub

    Private Sub cbxPageType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPageType.SelectedIndexChanged
        'If CDAMain.allowPreview Then
        If cbxPageType.SelectedItem.ToString <> "" Then
            If selectedPage.PageType <> cbxPageType.SelectedItem.ToString Then
                selectedPage.PageType = cbxPageType.SelectedItem.ToString
            End If
        End If
        FinaliseChange()
        'End If

    End Sub

    Private Sub btnBkgBrowse_Click(sender As Object, e As EventArgs) Handles btnBkgBrowse.Click
        BrowseForBackground()
    End Sub
    Public Sub BrowseForBackground()
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        dlg.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.jpe;*.gif;*.tif;*.tiff;*.png;"
        dlg.Title = "Import Image"
        If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Dim imgImp As Image
            imgImp = Image.FromFile(dlg.FileName)
            SaveImageAsCurrentBackground(imgImp)
        End If
    End Sub

    Private Sub btnPasteBKG_Click(sender As Object, e As EventArgs) Handles btnPasteBKG.Click
        PasteImageAsBackground()
    End Sub
    Public Sub PasteImageAsBackground()
        If Not System.Windows.Forms.Clipboard.GetDataObject() Is Nothing Then
            Dim oDataObj As IDataObject = System.Windows.Forms.Clipboard.GetDataObject()
            If oDataObj.GetDataPresent(System.Windows.Forms.DataFormats.Bitmap) Then
                Dim oImgObj As System.Drawing.Image = DirectCast(oDataObj.GetData(DataFormats.Bitmap, True), Image)
                SaveImageAsCurrentBackground(oImgObj)
            Else
                MsgBox("The clipboard doesn't contain a bitmap image.", MsgBoxStyle.OkOnly, "Clipboard not a bitmap")
            End If
        Else
            MsgBox("The clipboard is empty.", MsgBoxStyle.OkOnly, "Clipboard empty")
        End If
    End Sub

    Private Sub SaveImageAsCurrentBackground(ByVal img As Image)
        Dim oiW As Integer = img.Width
        Dim oiH As Integer = img.Height
        Dim itW As Integer = CDAMain.itspunit.Width
        Dim itH As Integer = CDAMain.itspunit.Height
        If oiW <> itW Or oiH <> itH Then
            If MsgBox("The image proportions (" + CStr(oiW) + "x" + CStr(oiH) + ") don't match your content's specified proportions (" + CStr(itW) + "x" + CStr(itH) + "). Are you sure you wish to use it?", MsgBoxStyle.YesNo, "Background image size incorrect") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        Dim fname As String = CDAMain.bkgFolder + "\" + tbPageName.Text + "_BKG.png"
        Dim iIt As Integer = 0
        While File.Exists(fname)
            fname = fname.Replace("_" & iIt.ToString, "")
            iIt = iIt + 1
            fname = fname.Replace(".png", "_" & iIt.ToString() & ".png")
        End While

        img.Save(fname, System.Drawing.Imaging.ImageFormat.Png)
        Dim fileName As String = Path.GetFileName(fname)
        PopupGalleryEdit1.EditValue = fileName
        CDAMain.UpdateBKGImage()
    End Sub

    Private Sub PopupGalleryEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles PopupGalleryEdit1.EditValueChanged
        If CDAMain.allowPreview Then
            CDAMain.UpdateBKGImage()
        End If
    End Sub

    Private Sub spinX_LostFocus(sender As Object, e As EventArgs) Handles spinX.LostFocus
        'If CDAMain.allowPreview Then
        If selectedPage.InstructionHPos.ToString() <> spinX.Text Then
            selectedPage.InstructionHPos = CInt(spinX.Text)
        End If
        FinaliseChange()
        'End If
        CDAMain.allowKeys = True
    End Sub
    Private Sub spinY_LostFocus(sender As Object, e As EventArgs) Handles spinY.LostFocus
        'If CDAMain.allowPreview Then
        If selectedPage.InstructionVPos.ToString() <> spinY.Text Then
            selectedPage.InstructionVPos = CInt(spinY.Text)
        End If
        FinaliseChange()
        'End If
        CDAMain.allowKeys = True
    End Sub

    Private Sub btnBkgEdit_Click(sender As Object, e As EventArgs) Handles btnBkgEdit.Click

        CDAMain.EditBkgImage()

    End Sub

    Private Sub reditExampleText_LostFocus(sender As Object, e As EventArgs) Handles reditExampleText.LostFocus, reditInstructionText.LostFocus
        CDAMain.allowKeys = True
    End Sub
    Private Sub DisableToolbar()
        BarManager1.Bars.Item(0).Visible = False
        BarManager1.Bars.Item(1).Visible = False
    End Sub
    Private Sub EnableToolbars()
        BarManager1.Bars.Item(0).Visible = True
        BarManager1.Bars.Item(1).Visible = True
    End Sub

    Private Sub GeneralTab_Shown(sender As Object, e As EventArgs) Handles GeneralTab.Shown
        DisableToolbar()
    End Sub

    Private Sub InstructionTab_Shown(sender As Object, e As EventArgs) Handles InstructionTab.Shown
        EnableToolbars()
    End Sub

    Private Sub AssessmentTab_Shown(sender As Object, e As EventArgs) Handles AssessmentTab.Shown
        DisableToolbar()
        If ddAssessTutorial.Properties.Columns.Count > 0 Then
            ddAssessTutorial.Properties.Columns(0).Visible = False
        End If
    End Sub

    Private Sub spinWidth_EditValueChanged(sender As Object, e As EventArgs) Handles spinWidth.EditValueChanged
        If Not selectedPage Is Nothing Then
            If selectedPage.InstructionWidth.ToString() <> spinWidth.Text Then
                selectedPage.InstructionWidth = CInt(spinWidth.Text)
            End If
            FinaliseChange()
            CDAMain.allowKeys = True
        End If
    End Sub


    Private Sub ddAssessTutorial_EditValueChanged(sender As Object, e As EventArgs) Handles ddAssessTutorial.EditValueChanged
        If Not selectedPage Is Nothing Then
            If selectedPage.ScoreTutorialID <> CInt(ddAssessTutorial.EditValue) Then
                selectedPage.ScoreTutorialID = CInt(ddAssessTutorial.EditValue)
            End If
            CDAMain.Modified = True
            'FinaliseChange()
            CDAMain.allowKeys = True
        End If

    End Sub

    Private Sub cbxPassToPage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPassToPage.SelectedIndexChanged
        If Not selectedPage Is Nothing Then
            If selectedPage.PassNextPage <> cbxPassToPage.EditValue.ToString Then
                selectedPage.PassNextPage = cbxPassToPage.EditValue.ToString
            End If
            CDAMain.Modified = True
            'FinaliseChange()
            CDAMain.allowKeys = True
        End If
    End Sub
    Private Sub cbxGotoPageCorrect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGotoPageCorrect.SelectedIndexChanged
        If Not selectedPage Is Nothing Then
            If selectedPage.JudgeCorrectNextPage <> cbxGotoPageCorrect.EditValue.ToString Then
                selectedPage.JudgeCorrectNextPage = cbxGotoPageCorrect.EditValue.ToString
            End If
            CDAMain.Modified = True
            'FinaliseChange()
            CDAMain.allowKeys = True
        End If
    End Sub
    'Private Sub cbxGotoPageIncorrect_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If Not selectedPage Is Nothing Then
    '        If selectedPage.JudgeInCorrectNextPage <> cbxGotoPageIncorrect.EditValue.ToString Then
    '            selectedPage.JudgeInCorrectNextPage = cbxGotoPageIncorrect.EditValue.ToString
    '        End If
    '        FinaliseChange()
    '        CDAMain.allowKeys = True
    '    End If
    'End Sub
    Private Sub btnPurge_Click(sender As Object, e As EventArgs)
        CDAMain.PurgeBackgroundImages()
        CDAMain.PurgeObjectImages()
    End Sub

    Private Sub btnBrowseBkg_Click(sender As Object, e As EventArgs) Handles btnBrowseBkg.Click
        Try
            If Not CDAMain.bkgFolder = "" Then
                Process.Start(CDAMain.bkgFolder)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        CDAMain.ReloadControls(False, False, True, False, False, True, False, False)
    End Sub

    Private Sub btnCopyPrevInst_Click(sender As Object, e As EventArgs) Handles btnCopyPrevInst.Click
        Try
            Dim previousPage As mstns.Page
            previousPage = CDAMain.itspunit.PageCol(CDAMain.selectedPageIndex - 1)
            selectedPage.InstructionHPos = previousPage.InstructionHPos
            selectedPage.InstructionText = previousPage.InstructionText
            selectedPage.InstructionVPos = previousPage.InstructionVPos
            selectedPage.InstructionWidth = previousPage.InstructionWidth
            selectedPage.InteractionText = previousPage.InteractionText
            spinX.EditValue = previousPage.InstructionHPos
            reditInstructionText.HtmlText = previousPage.InstructionText
            spinY.EditValue = previousPage.InstructionVPos
            spinWidth.EditValue = previousPage.InstructionWidth
            reditExampleText.HtmlText = previousPage.InteractionText
            previousPage = Nothing
            FinaliseChange()
            CDAMain.Modified = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbScored_CheckedChanged(sender As Object, e As EventArgs) Handles cbScored.CheckedChanged
        If Not selectedPage Is Nothing Then
            If selectedPage.ScoredInteraction <> cbScored.Checked Then
                selectedPage.ScoredInteraction = cbScored.Checked
            End If
            CDAMain.Modified = True
            'FinaliseChange()
            CDAMain.allowKeys = True
        End If
    End Sub

    Private Sub cbDenyPoint_CheckedChanged(sender As Object, e As EventArgs) Handles cbDenyPoint.CheckedChanged
        If Not selectedPage Is Nothing Then
            If selectedPage.ScoredInteractionIncorrect <> cbDenyPoint.Checked Then
                selectedPage.ScoredInteractionIncorrect = cbDenyPoint.Checked
            End If
            CDAMain.Modified = True
            'FinaliseChange()
            CDAMain.allowKeys = True
        End If
    End Sub

    Private Sub cbNextButton_CheckedChanged(sender As Object, e As EventArgs) Handles cbNextButton.CheckedChanged
        If Not selectedPage Is Nothing Then
            If selectedPage.IncludeNext <> cbNextButton.Checked Then
                selectedPage.IncludeNext = cbNextButton.Checked
            End If
            CDAMain.Modified = True
            FinaliseChange()
            CDAMain.allowKeys = True
        End If
    End Sub

    Private Sub PageSettings_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "ThePagePropertiesPane" & ".html")
    End Sub

End Class
