Imports System.ComponentModel
Imports System.Environment
Imports System.Text
Imports DevExpress.XtraBars.Ribbon
Imports System.IO
Imports DevExpress.XtraEditors
Imports System.Collections
Imports ClosedXML.Excel
Imports Ionic.Zip
Imports System.Threading
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars

Partial Public Class CDAMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    <STAThread>
    Private Shared Sub Main()
        Application.EnableVisualStyles()
    End Sub
#Region "Properties"
    Public Property DoRefreshOnActivate As Boolean = False
    Public Property LastPageHtml As String = ""
    Public ReadOnly Property selectedObjectName() As String
        Get
            Dim sON As String = ""
            Select Case selectedObjectType
                Case "Object"
                    sON = selectedObjectID
                Case "Behaviour"
                    If Not currentBehaviour Is Nothing Then
                        If Not currentBehaviour.Animate Is Nothing Then
                            sON = "Animation"
                        End If

                        If Not currentBehaviour.CustomCSS Is Nothing Then
                            sON = "Custom CSS"
                        End If

                        If Not currentBehaviour.CustomJavaScript Is Nothing Then
                            sON = "Custom Javascript"
                        End If

                        If Not currentBehaviour.Drag Is Nothing Then
                            sON = "Drag"
                        End If
                        If Not currentBehaviour.FollowMouse Is Nothing Then
                            sON = "Follow Mouse"

                        End If

                        If Not currentBehaviour.MouseEvent Is Nothing Then
                            sON = "Mouse interaction"
                        End If

                        If Not currentBehaviour.MousePointer Is Nothing Then
                            sON = "Mouse Pointer"
                        End If

                        If Not currentBehaviour.Resize Is Nothing Then
                            sON = "Resize"
                        End If

                        If Not currentBehaviour.Text_ Is Nothing Then
                            sON = "Text interaction"
                        End If

                        If Not currentBehaviour.KeyboardShortcut Is Nothing Then
                            sON = "Keyboard Shortcut"
                        End If

                        If Not currentBehaviour.Password Is Nothing Then
                            sON = "Password"
                        End If
                    End If
                Case "Page"
                    sON = itspunit.PageCol(selectedPageIndex).PageName
            End Select
            Return sON
        End Get
    End Property
    Shared Property itspunit As mstns.ITSPUnit
    'page index is simply used to store the number to be appended to the page name when creating a new page:
    Public Property selectedObjectType() As String
        Get
            Return siSelectedType.Caption
        End Get
        Set(value As String)
            siSelectedType.Caption = value
            siName.Caption = selectedObjectName()
        End Set
    End Property
    Public ReadOnly Property pageIndex() As Integer
        Get
            Dim highnum As Integer = 0
            Dim pgname As String
            Dim nCStart As Integer
            Dim nCEnd As Integer
            If itspunit Is Nothing Then
                Return 0
            Else
                For Each pg As mstns.Page In itspunit.PageCol
                    pgname = pg.PageName
                    If pgname.Contains(" ") Then
                        If pgname.Substring(0, pgname.IndexOf(" ")) = "Page" Then
                            nCStart = pgname.IndexOf(" ")
                            nCEnd = pgname.Length
                            If IsNumeric(pgname.Substring(nCStart, nCEnd - nCStart)) Then
                                If highnum < CInt(pgname.Substring(nCStart, nCEnd - nCStart)) Then
                                    highnum = CInt(pgname.Substring(nCStart, nCEnd - nCStart))
                                End If
                            End If
                        End If
                    End If
                Next
                If itspunit.PageCol.Count > highnum Then highnum = itspunit.PageCol.Count
                Return highnum
            End If
        End Get
    End Property
    Public Property bOpenTextEdit As Boolean = False
    Public allowKeys As Boolean = True
    Public bIsObjectListReordering As Boolean = False
    Public Property undoIndex As Integer = 0
    Public Shared imageFolder As String = ""
    Public Shared videoFolder As String = ""
    Public selectedImageName As String = ""
    Public currentBehaviour As mstns.Behaviours
    Public Shared bkgFolder As String = ""
    Public outputFolder As String = ""
    'the following property will be used to prevent unnecessary calls to update the page preview when changing cbx selections from code etc:
    Public allowPreview As Boolean = True
    'selectedPageIndex stores the currently selected page:
    Public selectedPageIndex As Integer = 0
    Public selectedObjectID As String = ""
    Public isUndoRedo As Boolean = False
    Private modified_Renamed As Boolean = False
    Public Property allowRedo As Boolean = False
    Private newDocument_Renamed As Boolean = True
    Private docName_Renamed As String = ""
    'Type of object to insert:
    Public insertObjectType As String = ""
    Property clipboardObjectType As String = ""
    Public Property ScrollYPos() As Integer = 0
    Private ReadOnly Property CurrentModified() As Boolean
        Get
            If itspunit Is Nothing Then
                Return False
            End If
            Return Me.Modified
        End Get
    End Property
    Public UndoRedoChanges As New mstns.ChangeHistory
    Public Property Modified As Boolean
        Get
            Return modified_Renamed
        End Get
        Set(value As Boolean)
            Try
                If Not isUndoRedo Then
                    allowRedo = False
                End If
                If value Then

                    If Not isUndoRedo Then
                        If UndoRedoChanges.ITSPUnitCol.Count - 1 > undoIndex Then
                            While UndoRedoChanges.ITSPUnitCol.Count - 1 > undoIndex
                                UndoRedoChanges.ITSPUnitCol.RemoveAt(UndoRedoChanges.ITSPUnitCol.Count - 1)
                            End While
                        End If

                        Dim sUnit As String = itspunit.ToXml
                        Dim xUnit As New mstns.ITSPUnitB
                        xUnit.FromXml(sUnit)
                        If UndoRedoChanges.ITSPUnitCol(UndoRedoChanges.ITSPUnitCol.Count - 1).ToXml <> xUnit.ToXml Then
                            UndoRedoChanges.ITSPUnitCol.Add(xUnit)
                            If UndoRedoChanges.ITSPUnitCol.Count > 15 Then
                                UndoRedoChanges.ITSPUnitCol.RemoveAt(0)
                            End If
                            undoIndex = UndoRedoChanges.ITSPUnitCol.Count - 1
                            If undoIndex < 1 Then
                                btnUndo.Enabled = False
                                btnQATUndo.Enabled = False
                            Else
                                btnUndo.Enabled = True
                                btnQATUndo.Enabled = True
                            End If

                        End If
                    Else
                        isUndoRedo = False
                    End If
                    Me.Text = DocName + ("*")
                Else
                    Me.Text = DocName + ("")
                End If
                If value <> modified_Renamed Then
                    modified_Renamed = value
                    UpdateText()
                End If
            Catch ex As Exception
                Dim strMsg As String = ex.Message.ToString()
                'MsgBox(strMsg)
            End Try
        End Set
    End Property
    Private ReadOnly Property CurrentDocName() As String
        Get
            If itspunit Is Nothing Then
                Return ""
            End If
            Return Me.DocName
        End Get
    End Property
    Private ReadOnly Property PageName() As String
        Get
            Return String.Format("Page {0}", (pageIndex + 1).ToString("00"))
        End Get
    End Property
    Public Property DocName() As String
        Get
            Return docName_Renamed
        End Get
        Set(value As String)
            Me.docName_Renamed = value
            Me.Text = DocName
        End Set
    End Property
    Public ReadOnly Property NewDocument() As Boolean
        Get
            Return Me.newDocument_Renamed
        End Get
    End Property
    Public ReadOnly Property PreviewPath() As String
        Get
            If DocName <> "" Then
                Dim directoryName As String = Path.GetDirectoryName(DocName)
                Return directoryName & "\preview"
            Else
                Return ""
            End If
        End Get
    End Property
    Public ReadOnly Property PublishPath() As String
        Get
            If DocName <> "" Then
                Dim directoryName As String = Path.GetDirectoryName(DocName)
                Return directoryName & "\publish"
            Else
                Return ""
            End If
        End Get
    End Property
    Public Shared objectAnimateFunctionList As ArrayList = New ArrayList
#End Region
#Region "Startup"
    Public Sub UpdateText()
        rbnMain.ApplicationCaption = "Digital Learning Solutions Content Creator v" & My.Settings.CurrentVersion.ToString
        txtImageEditor.Text = My.Settings.ImageEditor.ToString()
        If CurrentModified Then
            Try
                rbnMain.ApplicationDocumentCaption = Path.GetFileNameWithoutExtension(CurrentDocName) + ("*")
            Catch ex As Exception
                Dim strMsg As String = ex.Message.ToString()
                'MsgBox(strMsg)
            End Try
        Else
            Try
                rbnMain.ApplicationDocumentCaption = Path.GetFileNameWithoutExtension(CurrentDocName) + ("")
            Catch ex As Exception
                Dim strMsg As String = ex.Message.ToString()
                'MsgBox(strMsg)
            End Try
        End If
        siDocName.Caption = String.Format("  {0}", CurrentDocName)
    End Sub
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub CDAMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Not itspunit Is Nothing And DoRefreshOnActivate Then
            ' ReloadControls(True, True, False, False, True, True, False)
        Else
            DoRefreshOnActivate = True
        End If
    End Sub
    Private Sub LoadTheme()
        Dim sTheme As String = ""
        sTheme = My.Settings.DXSkinName
        If sTheme <> "" Then
            UserLookAndFeel.[Default].SkinName = sTheme
        End If
    End Sub

    Private Sub SaveTheme()
        Dim sTheme As String = UserLookAndFeel.[Default].SkinName
        My.Settings.DXSkinName = sTheme
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CreateNewPage(False, "Explain")
        Main()
        DevExpress.XtraBars.Helpers.SkinHelper.InitSkinPopupMenu(bsubThemeSelector)
        LoadTheme()
        Me.WindowState = FormWindowState.Maximized
        Me.KeyPreview = True
        'check if 30 day trial and quit if 30 days exceeded:
        Try
            Dim myReg As Microsoft.Win32.RegistryKey = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32)
            Dim myReg_Key As Microsoft.Win32.RegistryKey
            myReg_Key = myReg.OpenSubKey("SOFTWARE")

            myReg_Key = myReg_Key.OpenSubKey("Digital Learning Solutions")
            myReg_Key = myReg_Key.OpenSubKey("Digital Learning Solutions Content Creator")
            If myReg_Key IsNot Nothing Then
                Dim sSerial As String = myReg_Key.GetValue("Serial").ToString.Trim
                If sSerial = "" Or sSerial = "Trial" Or sSerial.Length <> 18 Then
                    Dim sDate As String = myReg_Key.GetValue("Installed").ToString
                    Dim dDate As Date = Date.ParseExact(sDate, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                    Dim nDays As Integer = CInt(DateDiff(DateInterval.Day, dDate, Now))
                    If nDays > 30 Then
                        MsgBox("Your trial period has expired. Please contact it.skills@nhs.net to discuss purchasing a licence for this software if you wish to continue using it.", vbOKOnly, "Trial Period Expired")
                        Me.Close()
                    Else
                        Dim nRemaining As Integer = 30 - nDays
                        MsgBox("You have " & nRemaining.ToString & " days of your trial period remaining. Please contact it.skills@nhs.net to discuss purchasing a licence for this software if you wish to continue using it after your trial period ends.", vbOKOnly, nRemaining.ToString & " Days Remaining")

                    End If

                End If
            End If
        Catch ex As Exception

        End Try
        Try
            InitMostRecentFiles()
            ' arMRUList = New MRUArrayList(pcAppMenuFileLabels, imageCollection3.Images(0), imageCollection3.Images(1))
            If Not arMRUList Is Nothing Then
                AddHandler arMRUList.LabelClicked, AddressOf OnMRUFileLabelClicked
            End If
            '  InitMostRecentFiles(arMRUList)
            rbnMain.ForceInitialize()
        Finally
            ReloadControls(False, False, False, False, False, False, False, False)
            If System.Environment.GetCommandLineArgs.Count > 1 Then
                Dim s As String = System.Environment.GetCommandLineArgs(1)
                If s.Contains(".itsc") Then
                    OpenThisFile(s)
                Else
                    OpenStartForm()
                End If
            Else
                OpenStartForm()
            End If
            'Dim sPresso As String = utility.IsApplictionInstalled("Screenpresso")
            'If sPresso <> "" Then
            '    System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(sPresso))
            'End If
            'Dim sSizer As String = "C:\Program Files (x86)\Sizer\sizer.exe"
            'If System.IO.File.Exists(sSizer) Then
            '    System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(sSizer))
            'Else
            '    sSizer = "C:\Program Files\Sizer\sizer.exe"
            '    If System.IO.File.Exists(sSizer) Then
            '        System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(sSizer))
            '    End If
            'End If

        End Try
        'SelectPage(selectedPageIndex, True)
        'UpdatePageList()

    End Sub
    Private Sub OnMRUFileLabelClicked(ByVal sender As Object, ByVal e As EventArgs)
        rbnMain.DeactivateKeyboardNavigation()
        'pmAppMain.HidePopup()

        rbnMain.HideApplicationButtonContentControl()
        Me.Refresh()
        OpenThisFile(sender.ToString())
    End Sub
    Public Sub OpenStartForm()

        Try
            Dim sForm As New StartForm
            sForm.Parent = Parent
            sForm.StartPosition = FormStartPosition.CenterParent
            sForm.ShowDialog(Me)
            sForm.Dispose()
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub CDAMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not SaveQuestion()
    End Sub

#End Region
#Region "EditRibbonCommands"
    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick, btnQATUndo.ItemClick
        Undo()
    End Sub

    Private Sub btnRedo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRedo.ItemClick
        Redo()
    End Sub
#End Region
#Region "HomeRibbonCommands"
    Private Sub btnCopy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCopy.ItemClick
        CopyCurrentSelected()
    End Sub
    Private Sub btnPaste_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPaste.ItemClick
        PasteClipboard()
    End Sub
    Private Sub btnCut_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCut.ItemClick
        CopyCurrentSelected()
        DeleteSelected(False)
        ReloadControls(True, False, True, True, True, True, True, True)
    End Sub
    Private Sub btnNewProject_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewProject.ItemClick
        NewProject()
    End Sub
    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick, qatBtnSave.ItemClick
        Save()
    End Sub

    Private Sub btnOpen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpen.ItemClick
        OpenFile()
    End Sub

    Private Sub btnPublish_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPublish.ItemClick, btnRbnPublish.ItemClick, btnPublishITSP.ItemClick
        PublishProjectStandard()
    End Sub

    Private Sub btnPublishSCORM_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPublishSCORM.ItemClick
        If itspunit.Type.Contains("Diagnostic") Then
            MsgBox("SCORM publishing is not available for Diagnostic Assessments. Please convert your project to a Post Learning Assessment before publishing to SCORM.", MsgBoxStyle.OkOnly, "Diagnostic Assessments Cannot be Published to SCORM")
            Exit Sub
        End If
        ScormPublish.StartPosition = FormStartPosition.CenterParent
        ScormPublish.LoadValues()
        ScormPublish.Show()
    End Sub
    Private Sub btnNewPage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewPage.ItemClick
        If itspunit.Type = "Learning" Then
            CreateNewPage(True, "Explain")
        Else
            CreateNewPage(True, "Test")
        End If
    End Sub
    Private Sub btnDeletePage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeletePage.ItemClick
        DeleteSelectedPage(True)
    End Sub

    Private Sub btnZoomIn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnZoomIn.ItemClick
        'Zoom IN
        wbPagePreview.Focus()
        SendKeys.Send("^{+}")
        DoZoomCheck()
        ' [CTRL]+[+]
    End Sub

    Private Sub btnZoomOut_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnZoomOut.ItemClick
        'Zoom OUT
        wbPagePreview.Focus()
        SendKeys.Send("^-")
        DoZoomCheck()
        ' [CTRL]+[-]
    End Sub

    Private Sub btnZoom100_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        'Zoom 100%
        wbPagePreview.Focus()
        SendKeys.Send("^0")
        DoZoomCheck()
        ' [CTRL]+[0]
    End Sub

    Private Sub btnProjectSettings_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProjectSettingsRbn.ItemClick
        frmProjectSettings.LoadValues()
        frmProjectSettings.Show()
    End Sub
    Private Sub rbnProjectGroup_CaptionButtonClick(sender As Object, e As RibbonPageGroupEventArgs)
        frmProjectSettings.LoadValues()
        frmProjectSettings.Show()
    End Sub

    Private Sub btnPreview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreview.ItemClick, btnPreviewFromPage.ItemClick, btnQATPreview.ItemClick, btnPreviewView.ItemClick
        PreviewFromPage()
    End Sub
    Private Sub btnPreviewAll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewAll.ItemClick
        PreviewAll()
    End Sub

    Private Sub btnPreviewThisPage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreviewThisPage.ItemClick
        PreviewPage()
    End Sub
    Private Sub btnInsertRolloverImage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInsertRolloverImage.ItemClick
        Try
            radInsertImageType.EditValue = 2
            Dim sImageFile As String = PasteImageAsImage()
            If Not sImageFile = "" Then
                selectedImageName = sImageFile
                ResetRibbonButtons()
                insertObjectType = "Image"
                AddImageCrosshair(sImageFile)
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub btnInsertStandardImage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInsertStandardImage.ItemClick
        Try
            radInsertImageType.EditValue = 1
            Dim sImageFile As String = PasteImageAsImage()
            If Not sImageFile = "" Then
                selectedImageName = sImageFile
                ResetRibbonButtons()
                insertObjectType = "Image"
                AddImageCrosshair(sImageFile)
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub btnAssessTemplate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportAssessTemplateRbn.ItemClick
        ImportAssessTemplate()
    End Sub
#End Region
#Region "InsertRibbonCommands"
    Private Sub btnArrowObject_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnArrowLeft.ItemClick, btnHmArrow.ItemClick
        ResetRibbonButtons()
        btnHmArrow.Down = True
        AddArrowImageOnce()
        insertObjectType = "Arrow-Left"
        AddCrosshair()
    End Sub
    Private Sub btnArrowDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnArrowDown.ItemClick
        ResetRibbonButtons()
        btnHmArrow.Down = True
        AddArrowImageOnce()
        insertObjectType = "Arrow-Down"
        AddCrosshair()
    End Sub


    Private Sub btnArrowRight_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnArrowRight.ItemClick
        ResetRibbonButtons()
        btnHmArrow.Down = True
        AddArrowImageOnce()
        insertObjectType = "Arrow-Right"
        AddCrosshair()
    End Sub

    Private Sub btnArrowUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnArrowUp.ItemClick
        ResetRibbonButtons()
        btnHmArrow.Down = True
        AddArrowImageOnce()
        insertObjectType = "Arrow-Up"
        AddCrosshair()
    End Sub
    Private Sub btnHighlightBox_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHighlightBox.ItemClick, btnHmHighlight.ItemClick
        ResetRibbonButtons()
        btnHighlightBox.Down = True
        insertObjectType = "Highlight-Box"
        AddMarquee()
    End Sub
    Private Sub btnInteractionArea_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInteractionArea.ItemClick, btnHmInteractionArea.ItemClick
        ResetRibbonButtons()
        btnInteractionArea.Down = True
        insertObjectType = "Interaction-Area"
        AddMarquee()
    End Sub
    Private Sub btnTextArea_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTextArea.ItemClick, btnHmTextArea.ItemClick
        ResetRibbonButtons()
        btnTextArea.Down = True
        insertObjectType = "Text-Area"
        AddMarquee()
    End Sub
    Public Sub ResetRibbonButtons()
        btnHighlightBox.Down = False
        btnHmArrow.Down = False
        btnInteractionArea.Down = False
        btnTextArea.Down = False
    End Sub
    Private Sub btnPasteImageInsert_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPasteImageInsert.ItemClick
        Try
            Dim sImageFile As String = PasteImageAsImage()
            If Not sImageFile = "" Then
                selectedImageName = sImageFile
                ResetRibbonButtons()
                insertObjectType = "Image"
                AddImageCrosshair(sImageFile)
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub RibbonImageGallery_GalleryItemClick(sender As Object, e As GalleryItemClickEventArgs) Handles RibbonImageGallery.GalleryItemClick
        selectedImageName = e.Item.Value.ToString()
        ResetRibbonButtons()
        insertObjectType = "Image"
        AddImageCrosshair(selectedImageName)
    End Sub
    Private Sub btnInsertQuizQuestion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInsertQuizQuestion.ItemClick, btnHmQuiz.ItemClick
        Try

            Dim pg As mstns.Page = itspunit.PageCol(selectedPageIndex)
            If pg.QuizQuestion Is Nothing Then
                Dim qq As New mstns.QuizQuestion
                pg.QuizQuestion = qq
            End If
            Dim sForm As New EditQuizQuestion
            sForm.GridView1.PopulateColumns()
            sForm.Parent = Me.Parent
            sForm.StartPosition = FormStartPosition.CenterParent
            sForm.ShowDialog(ParentForm)
            sForm.Dispose()
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub btnBrowseInsert_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBrowseInsert.ItemClick
        BrowseForImage()
    End Sub
    Private Sub rbnImagesGroup_CaptionButtonClick(sender As Object, e As RibbonPageGroupEventArgs) Handles rbnHomeImages.CaptionButtonClick
        Try
            If Not imageFolder = "" Then
                Process.Start(imageFolder)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnImagesPurge_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImagesPurge.ItemClick
        If MsgBox("Are you sure you wish to delete all unused image files from the images and backgrounds folders for this project?", vbYesNo, "Purge image files") = MsgBoxResult.Yes Then
            PurgeBackgroundImages()
            PurgeObjectImages()
        End If
    End Sub
    Private Sub btnInsertVideo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInsertVideoHome.ItemClick
        BrowseForVideo()
    End Sub
#End Region
#Region "PageRibbonCommands"
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPasteImage.ItemClick, btnHmRbnPasteBkg.ItemClick
        PageSettings1.PasteImageAsBackground()
    End Sub
    Private Sub btnImportScript_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        ImportScript()
    End Sub
    Private Sub btnBrowseBkg_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBrowseBkg.ItemClick
        PageSettings1.BrowseForBackground()
    End Sub

    Private Sub btnEditBkg_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditBkg.ItemClick
        EditBkgImage()
    End Sub


    Private Sub BarEditItem1_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItem1.EditValueChanged
        PageSettings1.UpdateName(BarEditItem1.EditValue.ToString())
    End Sub

    Private Sub RibbonBackgroundGallery_GalleryInitDropDownGallery(sender As Object, e As InplaceGalleryEventArgs) Handles RibbonBackgroundGallery.GalleryInitDropDownGallery
        e.PopupGallery.SynchWithInRibbonGallery = True
        e.PopupGallery.ItemCheckMode = Gallery.ItemCheckMode.SingleCheck
    End Sub

    Private Sub RibbonBackgroundGallery_GalleryItemCheckedChanged(sender As Object, e As GalleryItemEventArgs) Handles RibbonBackgroundGallery.GalleryItemCheckedChanged
        If Not RibbonBackgroundGallery.Gallery.GetCheckedItem Is Nothing And allowPreview And Not bIsObjectListReordering Then
            PageSettings1.PopupGalleryEdit1.EditValue = RibbonBackgroundGallery.Gallery.GetCheckedItem.Value
            ReloadControls(False, False, False, False, False, False, True, False)
        End If
    End Sub
    Private Sub rbnPageBackgroundGroup_CaptionButtonClick(sender As Object, e As RibbonPageGroupEventArgs)
        Try
            If Not bkgFolder = "" Then
                Process.Start(bkgFolder)
            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Sub rbnPageInstructionGroup_CaptionButtonClick(sender As Object, e As RibbonPageGroupEventArgs)
        pnlPage.Show()
        PageSettings1.TabbedControlGroup1.SelectedTabPageIndex = 1
    End Sub
    Private Sub rbnPageAsssessmentGroup_CaptionButtonClick(sender As Object, e As RibbonPageGroupEventArgs)
        pnlPage.Show()
        PageSettings1.TabbedControlGroup1.SelectedTabPageIndex = 2
    End Sub
#End Region
#Region "ViewRibbonCommands"
    Property bSuppressChange As Boolean = False
    Private Sub cbNavigationPane_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cbNavigationPane.CheckedChanged
        If Not bSuppressChange Then
            If cbNavigationPane.Checked Then
                pnlNavigation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                pnlNavigation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If
        Else
            bSuppressChange = False
        End If
    End Sub

    Private Sub cbObjectList_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cbObjectList.CheckedChanged
        If Not bSuppressChange Then
            If cbObjectList.Checked Then
                pnlObjectList.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                pnlObjectList.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If
        Else
            bSuppressChange = False
        End If
    End Sub

    Private Sub cbObjectProperties_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cbObjectProperties.CheckedChanged
        If Not bSuppressChange Then
            If cbObjectProperties.Checked Then
                pnlObjectProps.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                pnlObjectProps.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If
        Else
            bSuppressChange = False
        End If
    End Sub

    Private Sub cbBehaviours_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cbBehaviours.CheckedChanged
        If Not bSuppressChange Then
            If cbBehaviours.Checked Then
                pnlBehaviours.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                pnlBehaviours.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If
        Else
            bSuppressChange = False
        End If
    End Sub

    Private Sub cbBehaviourProperties_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cbBehaviourProperties.CheckedChanged
        If Not bSuppressChange Then
            If cbBehaviourProperties.Checked Then
                pnlBehaviourProps.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                pnlBehaviourProps.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If
        Else
            bSuppressChange = False
        End If
    End Sub

    Private Sub cbPageProps_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cbPageProps.CheckedChanged
        If Not bSuppressChange Then
            If cbPageProps.Checked Then
                pnlPage.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                pnlPage.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If
        Else
            bSuppressChange = False
        End If
    End Sub

    Private Sub pnlPage_VisibilityChanged(sender As Object, e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles pnlPage.VisibilityChanged
        'bSuppressChange = True
        If pnlPage.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            cbPageProps.Checked = False
        Else
            cbPageProps.Checked = True
        End If
    End Sub
    Private Sub pnlBehaviourProps_VisibilityChanged(sender As Object, e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles pnlBehaviourProps.VisibilityChanged
        'bSuppressChange = True
        If pnlBehaviourProps.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            cbBehaviourProperties.Checked = False
        Else
            cbBehaviourProperties.Checked = True
        End If
    End Sub

    Private Sub pnlBehaviours_VisibilityChanged(sender As Object, e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles pnlBehaviours.VisibilityChanged
        'bSuppressChange = True
        If pnlBehaviours.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            cbBehaviours.Checked = False
        Else
            cbBehaviours.Checked = True
        End If
    End Sub

    Private Sub pnlNavigation_VisibilityChanged(sender As Object, e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles pnlNavigation.VisibilityChanged
        'bSuppressChange = True
        If pnlNavigation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            cbNavigationPane.Checked = False
        Else
            cbNavigationPane.Checked = True
        End If
    End Sub

    Private Sub pnlObjectList_VisibilityChanged(sender As Object, e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles pnlObjectList.VisibilityChanged
        'bSuppressChange = True
        If pnlObjectList.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            cbObjectList.Checked = False
        Else
            cbObjectList.Checked = True
        End If
    End Sub

    Private Sub pnlObjectProps_VisibilityChanged(sender As Object, e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles pnlObjectProps.VisibilityChanged
        'bSuppressChange = True
        If pnlObjectProps.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            cbObjectProperties.Checked = False
        Else
            cbObjectProperties.Checked = True
        End If
    End Sub
#End Region
#Region "Pages"

    Public Sub CreateNewPage(ByVal modified As Boolean, ByVal pgType As String)
        Try
            Dim contentPage As New mstns.Page
            contentPage.PageName = PageName
            contentPage.PageType = pgType
            contentPage.InstructionText = "<p>&nbsp;</p>"
            contentPage.InteractionText = "<p>&nbsp;</p>"
            If selectedPageIndex < itspunit.PageCol.Count - 1 Then
                itspunit.PageCol.Insert(selectedPageIndex + 1, contentPage)
            Else
                itspunit.PageCol.Add(contentPage)
            End If
            'ScrollYPos = 136 * (itspunit.PageCol.Count)

            If modified Then
                Me.Modified = True
            End If
            selectedPageIndex = selectedPageIndex + 1

            SelectPage(selectedPageIndex, True)
            If Not bkgFolder = "" Then
                ReloadControls(True, False, False, True, True, True, True, True)
            Else
                ReloadControls(False, False, False, True, True, True, True, True)
            End If
            pageList1.GalleryControl1.Gallery.Groups.First.Items(selectedPageIndex).Checked = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub UpdatePageList()
        'Update the page list gallery control (navigation pane):
        Try
            If bkgFolder <> "" And Not itspunit Is Nothing Then
                Dim fld As String = imageFolder.Replace("images", "thumbs")
                If itspunit.PageCol.Count > 0 Then
                    If selectedPageIndex > itspunit.PageCol.Count - 1 Then
                        selectedPageIndex = itspunit.PageCol.Count - 1
                    End If
                    'wbPagePreview.Visible = True
                    'pageList1.Visible = True
                    'PageSettings1.Enabled = True
                    Dim gc As GalleryControl = pageList1.GalleryControl1
                    gc.Gallery.FixedImageSize = True
                    gc.Gallery.UseMaxImageSize = False
                    Dim nH As Integer = itspunit.Height
                    Dim nW As Integer = itspunit.Width
                    Dim nHnew As Integer = nH
                    Dim nWnew As Integer = nW
                    If nHnew < 128 Then
                        nWnew = CInt((CSng(96) / CSng(nH)) * CSng(nW))
                        nHnew = 128
                    End If
                    If nWnew > 170 Then
                        nHnew = CInt((CSng(170) / CSng(nWnew)) * CSng(nHnew))
                        nWnew = 170
                    End If
                    gc.Gallery.ImageSize = New System.Drawing.Size(nWnew, nHnew)
                    gc.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch
                    Dim pageGalleryGroup As GalleryItemGroup = gc.Gallery.Groups.First
                    pageGalleryGroup.Items.Clear()
                    Dim nPIndex As Integer = 0
                    For Each p As mstns.Page In itspunit.PageCol
                        Dim filen As String = fld + "\" + p.PageName + "_thmb.jpg"
                        Dim img As Image
                        If Not System.IO.File.Exists(filen) Then
                            If Not (p.BackgroundImage = "" Or p.BackgroundImage = ",") Then
                                filen = bkgFolder + "\" + p.BackgroundImage
                            End If
                        End If
                        If Not System.IO.File.Exists(filen) Then
                            img = New Bitmap(ITSP_CDA.My.Resources.blank_thmb)

                        Else
                            Dim fs As System.IO.FileStream
                            fs = New System.IO.FileStream(filen, IO.FileMode.Open, IO.FileAccess.Read)
                            Try
                                img = System.Drawing.Image.FromStream(fs)
                            Catch ex As Exception

                            Finally
                                If Not fs Is Nothing Then
                                    fs.Dispose()
                                End If
                            End Try


                        End If
                        Dim sInst As String = utility.StripHTML(p.InstructionText)
                        If sInst.Length > 40 Then
                            sInst = sInst.Substring(0, 37) & "..."
                        End If
                        Dim newItem As GalleryItem = New GalleryItem(img, p.PageName, sInst)
                        newItem.Value = nPIndex

                        nPIndex = nPIndex + 1
                        pageGalleryGroup.Items.Add(newItem)
                        If p.PageName.StartsWith("Page ") Then
                            If IsNumeric(p.PageName.Substring(p.PageName.LastIndexOf(" ") + 1)) Then
                                Dim iPageNum As Integer = CInt(p.PageName.Substring(p.PageName.LastIndexOf(" ") + 1))
                            End If
                        End If
                    Next
                    gc.Gallery.SetItemCheck(pageGalleryGroup.Items(selectedPageIndex), True)
                    gc.Gallery.ScrollYPosition = ScrollYPos
                    PopulatePagesDropDown(PageSettings1.cbxPassToPage)
                    PopulatePagesDropDown(PageSettings1.cbxGotoPageCorrect)
                    'PopulatePagesDropDown(PageSettings1.cbxGotoPageIncorrect)
                    gc.Gallery.CheckSelectedItemViaKeyboard = True
                    'pageGalleryGroup.Items(selectedPageIndex).Checked = True

                    'UpdateObjectsList()
                    'UpdateImageList()
                Else
                    wbPagePreview.Visible = False
                    pageList1.Visible = False
                    PageSettings1.Enabled = False
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub UpdateCurrentPageThumb()
        Try
            Dim fld As String = imageFolder.Replace("images", "thumbs")
            Dim gc As GalleryControl = pageList1.GalleryControl1
            Dim pageGalleryGroup As GalleryItemGroup = gc.Gallery.Groups.First
            Dim p As mstns.Page = itspunit.PageCol(selectedPageIndex)
            Dim filen As String = fld + "\" + p.PageName + "_thmb.jpg"
            Dim img As Image
            If Not System.IO.File.Exists(filen) Then
                If Not (p.BackgroundImage = "" Or p.BackgroundImage = ",") Then
                    filen = bkgFolder + "\" + p.BackgroundImage
                End If
            End If
            If Not System.IO.File.Exists(filen) Then
                img = New Bitmap(ITSP_CDA.My.Resources.blank_thmb)

            Else
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(filen, IO.FileMode.Open, IO.FileAccess.Read)
                Try
                    img = System.Drawing.Image.FromStream(fs)
                Catch ex As Exception

                Finally
                    If Not fs Is Nothing Then
                        fs.Dispose()
                    End If
                End Try


            End If
            Dim sInst As String = utility.StripHTML(p.InstructionText)
            If sInst.Length > 40 Then
                sInst = sInst.Substring(0, 37) & "..."
            End If
            If Not img Is Nothing Then
                pageGalleryGroup.Items(selectedPageIndex).Image = img
                pageGalleryGroup.Items(selectedPageIndex).Caption = p.PageName
                pageGalleryGroup.Items(selectedPageIndex).Description = sInst
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SelectPage(ByVal pgIndex As Integer, Optional boolForce As Boolean = False)
        Try
            If Not itspunit Is Nothing Then
                If (pgIndex <> selectedPageIndex Or boolForce) Then
                    ShowHideVideoProperties(False)
                    ShowHideObjectProperties(False)
                    If pgIndex <> selectedPageIndex Then
                        selectedObjectID = ""
                    End If
                    selectedPageIndex = pgIndex
                    If selectedPageIndex = 0 Then
                        PageSettings1.btnCopyPrevInst.Enabled = False
                    Else
                        PageSettings1.btnCopyPrevInst.Enabled = True
                    End If
                    Dim selectedPage As mstns.Page = itspunit.PageCol(pgIndex)
                    allowPreview = False
                    PageSettings1.tbPageName.Text = selectedPage.PageName
                    BarEditItem1.EditValue = PageSettings1.tbPageName.Text
                    If selectedPage.BackgroundImage <> "" Then
                        For Each nGalItem As DevExpress.XtraBars.Ribbon.GalleryItem In PageSettings1.PopupGalleryEdit1.Properties.Gallery.Groups(0).Items
                            If nGalItem.Value.ToString() = selectedPage.BackgroundImage Then
                                RibbonBackgroundGallery.Gallery.SetItemCheck(nGalItem, True)
                                Exit For
                            End If
                        Next
                        PageSettings1.PopupGalleryEdit1.EditValue = selectedPage.BackgroundImage
                    Else
                        PageSettings1.PopupGalleryEdit1.EditValue = ""
                    End If
                    PageSettings1.reditInstructionText.CreateNewDocument()
                    PageSettings1.reditExampleText.CreateNewDocument()
                    PageSettings1.reditInstructionText.HtmlText = selectedPage.InstructionText
                    PageSettings1.reditExampleText.HtmlText = selectedPage.InteractionText
                    PageSettings1.cbxPageType.SelectedItem = selectedPage.PageType
                    PageSettings1.spinWidth.Text = CStr(selectedPage.InstructionWidth)
                    PageSettings1.spinX.Text = CStr(selectedPage.InstructionHPos)
                    PageSettings1.spinY.Text = CStr(selectedPage.InstructionVPos)
                    PageSettings1.cbNextButton.Checked = CBool(selectedPage.IncludeNext)
                    If imageFolder = "" Then
                        PageSettings1.Enabled = False
                    Else
                        PageSettings1.Enabled = True
                    End If
                    If Not selectedPage.IsNilScoreTutorialID Then
                        PageSettings1.ddAssessTutorial.EditValue = selectedPage.ScoreTutorialID
                        If PageSettings1.ddAssessTutorial.Properties.Columns.Count > 0 Then
                            PageSettings1.ddAssessTutorial.Properties.Columns(0).Visible = False
                        End If
                    End If
                    For Each item As String In PageSettings1.cbxPassToPage.Properties.Items
                        If selectedPage.PassNextPage = item.ToString Then
                            PageSettings1.cbxPassToPage.EditValue = selectedPage.PassNextPage
                        End If
                    Next
                    For Each item As String In PageSettings1.cbxGotoPageCorrect.Properties.Items
                        If selectedPage.JudgeCorrectNextPage = item Then
                            PageSettings1.cbxGotoPageCorrect.EditValue = selectedPage.JudgeCorrectNextPage
                        End If
                    Next
                    PageSettings1.cbScored.Checked = selectedPage.ScoredInteraction
                    PageSettings1.cbDenyPoint.Checked = selectedPage.ScoredInteractionIncorrect
                    'PageSettings1.cbxGotoPageIncorrect.EditValue = selectedPage.JudgeInCorrectNextPage
                    allowPreview = True
                    'If bkgFolder <> "" Then
                    '	RenderSelectedPage()
                    'End If
                    selectedObjectType = "Page"
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub SelectPagePost(ByVal pgIndex As Integer)
        Try
            If Not itspunit Is Nothing Then

                Dim selectedPage As mstns.Page = itspunit.PageCol(pgIndex)
                selectedObjectType = "Page"
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub RefreshPage()
        If Not itspunit Is Nothing Then
            If allowPreview Then
                RenderSelectedPage()
            End If
        End If
    End Sub
    Private Sub btnAddExpPage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddExpPage.ItemClick
        CreateNewPage(True, "Explain")
    End Sub
    Private Sub btnAddDemoPage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddDemoPage.ItemClick
        CreateNewPage(True, "Demo")
    End Sub
    Private Sub btnAddGuidePage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddGuidePage.ItemClick
        CreateNewPage(True, "Guide")
    End Sub
    Private Sub btnAddPracticePage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddPracticePage.ItemClick
        CreateNewPage(True, "Practice")
    End Sub
    Private Sub btnAddTestPage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddTestPage.ItemClick
        CreateNewPage(True, "Test")
    End Sub
    Public Sub DeleteSelectedPage(ByVal bWarn As Boolean)
        If bWarn Then
            If MsgBox("Are you sure that you wish to delete the currently selected page?", MsgBoxStyle.OkCancel, "Delete Page?") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
        End If
        Try
            If itspunit.PageCol.Count > 1 Then
                itspunit.PageCol.RemoveAt(selectedPageIndex)
                If selectedPageIndex >= itspunit.PageCol.Count - 1 And selectedPageIndex > 0 Then
                    selectedPageIndex = selectedPageIndex - 1
                End If
                ReloadControls(True, False, False, False, False, False, False, False)
                Modified = True
                SelectPage(selectedPageIndex, True)
                ReloadControls(False, False, False, True, True, True, True, True)
            Else
                MsgBox("Your project must contain at least one page.", MsgBoxStyle.Exclamation, "Error")
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Function GetPageTypeFromLetter(ByVal letter As String) As String
        Dim typeString As String = "Explain"
        Select Case letter.ToUpper()
            Case "E"
                typeString = "Explain"
            Case "G"
                typeString = "Guide"
            Case "T"
                typeString = "Test"
            Case "D"
                typeString = "Demo"
            Case "P"
                typeString = "Practice"
        End Select
        Return typeString
    End Function
    Public Function TidyUp(ByVal TidyString As String) As String
        TidyString = TidyString.Replace("’", "'")
        Return TidyString
    End Function
    Public Shared Function GetNextPage(ByVal pgname As String) As String

        Dim sPageName As String = ""
        Try
            Dim i As Integer = 0
            For Each pg As mstns.Page In itspunit.PageCol
                If pg.PageName = pgname Then
                    If itspunit.Type <> "Learning" And pg.PassNextPage <> "Next" And pg.PassNextPage <> "Last" Then
                        sPageName = pg.PassNextPage
                    ElseIf i < itspunit.PageCol.Count - 1 Then
                        sPageName = itspunit.PageCol.Item(i + 1).PageName
                    End If
                    Exit For
                End If
                i = i + 1
            Next
            If sPageName = "" Then
                If itspunit.Type = "Diagnostic" Then
                    sPageName = "diagnostic-outcome"
                ElseIf itspunit.Type = "Post Learning" Then
                    sPageName = "assessment-outcome"
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
        Return sPageName
    End Function
    Public Shared Function GetPreviousPage(ByVal pgname As String) As String
        Dim sPageName As String = ""
        Try
            Dim i As Integer = 0
            For Each pg As mstns.Page In itspunit.PageCol
                If pg.PageName = pgname Then
                    If i > 0 Then
                        sPageName = itspunit.PageCol.Item(i - 1).PageName
                    End If
                    Exit For
                End If
                i = i + 1
            Next
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
        Return sPageName
    End Function
    Public Shared Function GetLastPage() As String
        Dim sPageName As String = ""
        Try
            If itspunit.Type = "Diagnostic" Then
                sPageName = "Diagnostic-outcome"
            ElseIf itspunit.Type = "Post Learning" Then
                sPageName = "Assessment-outcome"
            Else
                sPageName = itspunit.PageCol.Item(itspunit.PageCol.Count - 1).PageName
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
        Return sPageName
    End Function
    Public Sub ReorderPage(ByVal Direction As String)
        Dim pg As mstns.Page = itspunit.PageCol(selectedPageIndex)
        Try
            Dim changed As Boolean = False
            Select Case Direction
                Case "Down"
                    If selectedPageIndex > 0 Then
                        itspunit.PageCol.RemoveAt(selectedPageIndex)
                        itspunit.PageCol.Insert(selectedPageIndex - 1, pg)
                        selectedPageIndex = selectedPageIndex - 1
                        changed = True
                    End If
                Case "Up"
                    If selectedPageIndex < pg.ObjectCol.Count - 1 Then
                        itspunit.PageCol.RemoveAt(selectedPageIndex)
                        itspunit.PageCol.Insert(selectedPageIndex + 1, pg)
                        selectedPageIndex = selectedPageIndex + 1
                        changed = True
                    End If

            End Select
            If changed Then
                Modified = True
                ReloadControls(True, False, False, True, True, False, True, True)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "BackstageCommands"
    Private Sub bsvExit_ItemClick(sender As Object, e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles bsvExit.ItemClick
        Me.Close()
    End Sub
    Private Sub bsvOpen_ItemClick(ByVal sender As Object, ByVal e As RecentItemEventArgs)
        OpenFile()
    End Sub
    Private Sub bsvSave_ItemClick(sender As Object, e As BackstageViewItemEventArgs) Handles bsvSave.ItemClick
        Save()
    End Sub

    Private Sub bsvSettingsTab_SelectedChanged(sender As Object, e As BackstageViewItemEventArgs) Handles bsvSettingsTab.SelectedChanged
        If Not itspunit Is Nothing Then
            ProjectSettings1.LoadValues()
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ProjectSettings1.SaveValues()
        rbnMain.HideApplicationButtonContentControl()
    End Sub
    Private Sub bsvNewProject_ItemClick(sender As Object, e As BackstageViewItemEventArgs) Handles bsvNewProject.ItemClick
        NewProject()
    End Sub
    Private Sub btnImportScriptBSV_Click(sender As Object, e As EventArgs) Handles btnImportScriptBSV.Click
        ImportScript()
    End Sub

    Private Sub btnImportAssessTemplateBSV_Click(sender As Object, e As EventArgs) Handles btnImportAssessTemplateBSV.Click
        ImportAssessTemplate()
    End Sub

    Private Sub BackstageViewButtonItem1_ItemClick(sender As Object, e As BackstageViewItemEventArgs) Handles bsvPublish.ItemClick
        PublishProjectStandard()
    End Sub

    Private Sub btnPublishRbn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPublishRbn.ItemClick
        PublishProjectStandard()
    End Sub

    Private Sub btnRefreshRbn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefreshRbn.ItemClick
        ReloadControls(False, False, True, False, False, True, False, False)
    End Sub

    Private Sub btnImportScriptRbn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportScriptRbn.ItemClick
        ImportScript()
    End Sub
    Private Sub bsvCloseDocument_ItemClick(sender As Object, e As BackstageViewItemEventArgs) Handles bsvCloseDocument.ItemClick
        CloseProject()
    End Sub
#End Region
#Region "File"
    Public Sub CloseProject()
        SaveQuestion()
        itspunit = Nothing
        Me.DocName = ""
        bkgFolder = ""
        imageFolder = ""
        videoFolder = ""
        selectedPageIndex = 0
        Dim gc1 As PopupGalleryEditGallery = StandardImageGalleryEdit.Properties.Gallery
        Dim gc2 As PopupGalleryEditGallery = HoverImageGalleryEdit.Properties.Gallery
        Dim gc3 As PopupGalleryEditGallery = MouseDownImageGalleryEdit.Properties.Gallery
        Dim gc4 As PopupGalleryEditGallery = MouseUpImageGalleryEdit.Properties.Gallery
        PrepareGallery(gc1)
        PrepareGallery(gc2)
        PrepareGallery(gc3)
        PrepareGallery(gc4)
        Dim rgc As DevExpress.XtraBars.RibbonGalleryBarItem = RibbonImageGallery
        If rgc.Gallery.Groups.Count = 0 Then
            rgc.Gallery.Groups.Add(New DevExpress.XtraBars.Ribbon.GalleryItemGroup)
            rgc.Gallery.Groups(0).Caption = "Images"
        Else
            rgc.Gallery.Groups(0).Items.Clear()
        End If
        listBehaviours.Items.Clear()
        scrollableBehaviourProps.Controls.Clear()
        UpdateText()
        ReloadControls(False, False, False, False, False, False, False, False)
    End Sub
    Public Sub OpenFile(Optional ByVal directory As String = "")
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        dlg.Filter = "Digital Learning Solutions Content (*.itsc)|*.itsc"
        If Not directory = "" Then
            dlg.InitialDirectory = directory
        End If
        dlg.Title = "Open"
        Try
            DoRefreshOnActivate = False
            If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                OpenThisFile(dlg.FileName)
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub OpenThisFile(ByVal name As String)
        If Not itspunit Is Nothing Then
            CloseProject()
        End If
        AddToMostRecentFiles(name, arMRUList)
        '  AddToMostRecentFiles(name, recentItemsControl1.MRUFileList)
        '  AddToMostRecentFolders(name, recentItemsControl1.MRUFolderList)
        LoadDocument(name)
    End Sub
    'Private Sub AddToMostRecentFiles(ByVal name As String, ByVal arMRUList As MRUArrayList)
    'arMRUList.InsertElement(name)
    'End Sub
    Private Sub Save()
        If itspunit Is Nothing Then
            Return
        End If
        If Me.NewDocument Then
            SaveAs()
        Else
            itspunit.ToXmlFile(CurrentDocName)
            Me.Modified = False
        End If
        SetModifiedCaption()
    End Sub
    Public Sub NewProject()

        Try
            CloseProject()
            itspunit = New mstns.ITSPUnit
            itspunit.SchemaVersion = My.Settings.CurrentVersion
            Dim sUnit As String = itspunit.ToXml
            Dim xUnit As New mstns.ITSPUnitB
            xUnit.FromXml(sUnit)
            UndoRedoChanges.ITSPUnitCol.Add(xUnit)
            selectedPageIndex = -1
            CreateNewPage(False, "Explain")
            Me.newDocument_Renamed = True
            DocName = ""
            Dim frmNewProj As New frmProjectSettingsNew
            frmNewProj.LoadValues()
            frmNewProj.ShowDialog()
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub NewProjectSave()
        If SaveAs() <> "" Then
            'Me.wbPagePreview.Height = itspunit.Height
            'Me.wbPagePreview.Width = itspunit.Width
            ReloadControls(True, False, True, False, False, False, False, False)
            SelectPage(selectedPageIndex, True)
            ReloadControls(False, False, False, True, True, True, True, True)
        End If
    End Sub
    Public Function SaveAs(Optional ByVal folder As String = "") As String
        Dim dlg As SaveFileDialog = New SaveFileDialog()
        Dim oldFileName As String = CurrentDocName.ToString()
        dlg.Filter = "Digital Learning Solutions Content (*.itsc)|*.itsc"
        dlg.Title = "Save As"
        If Not folder = "" Then
            dlg.InitialDirectory = folder
        End If
        Dim sReturn As String = ""
        Try
            DoRefreshOnActivate = False
            If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim fn As String = dlg.FileName

                If MsgBox("It is essential that each of your projects is stored in a folder of its own. Would you like Content Creator to create a folder for this project?", MsgBoxStyle.YesNo, "Create folder?") = MsgBoxResult.Yes Then
                    Dim sPath As String = IO.Path.GetDirectoryName(fn)
                    Dim sFile As String = IO.Path.GetFileNameWithoutExtension(fn)
                    If (Not System.IO.Directory.Exists(sPath & "\" & sFile)) Then
                        IO.Directory.CreateDirectory(sPath & "\" & sFile)
                    End If
                    fn = sPath & "\" & sFile & "\" & sFile & ".itsc"
                End If
                itspunit.ToXmlFile(fn)
                Me.DocName = fn
                Me.newDocument_Renamed = False
                Me.Modified = False
                AddToMostRecentFiles(Me.DocName, arMRUList)
                '    AddToMostRecentFiles(Me.DocName, recentItemsControl1.MRUFileList)
                '    AddToMostRecentFolders(Me.DocName, recentItemsControl1.MRUFolderList)
                If oldFileName = "" Then
                    SetupImageFolders(DocName)
                ElseIf DocName <> oldFileName Then
                    SetupImageFolders(DocName)
                    CopyFilesToNewLoc(oldFileName)
                End If
                sReturn = Me.DocName
            ElseIf Me.newDocument_Renamed Then
                itspunit = Nothing
                wbPagePreview.Visible = False
                pageList1.Visible = False
                ObjectManager1.Enabled = False
                'ObjectPropertiesTabControl.Enabled = False
                PageSettings1.Enabled = False
                rbnPageGroup.Enabled = False

                OpenStartForm()
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
        Return sReturn
    End Function
    Public Sub SetupImageFolders(ByVal fileloc As String)
        Try
            Dim directoryName As String = Path.GetDirectoryName(fileloc)
            If (Not System.IO.Directory.Exists(directoryName & "\images")) Then
                System.IO.Directory.CreateDirectory(directoryName & "\images")
                System.IO.Directory.CreateDirectory(directoryName & "\backgrounds")
                System.IO.Directory.CreateDirectory(directoryName & "\videos")
            End If
            If (Not System.IO.Directory.Exists(directoryName & "\output")) Then
                System.IO.Directory.CreateDirectory(directoryName & "\output")
                System.IO.Directory.CreateDirectory(directoryName & "\output\navimages")
                System.IO.Directory.CreateDirectory(directoryName & "\output\css")
                System.IO.Directory.CreateDirectory(directoryName & "\output\js")
                System.IO.Directory.CreateDirectory(directoryName & "\output\fonts")
                System.IO.File.WriteAllText(directoryName & "\output\css\animation.css", My.Resources.animation)
                System.IO.File.WriteAllText(directoryName & "\output\css\itsplearning.css", My.Resources.itsplearning)
                System.IO.File.WriteAllText(directoryName & "\output\css\jquery_ui.css", My.Resources.jquery_ui_css)
                System.IO.File.WriteAllText(directoryName & "\output\css\bootstrap.min.css", My.Resources.bootstrap_min_css)
                System.IO.File.WriteAllText(directoryName & "\output\js\jquery.js", My.Resources.jquery)
                System.IO.File.WriteAllText(directoryName & "\output\js\jquery_ui.js", My.Resources.jquery_ui_js)
                System.IO.File.WriteAllText(directoryName & "\output\js\crosshair-min.js", My.Resources.crosshair_min)
                System.IO.File.WriteAllText(directoryName & "\output\js\itsp_content.js", My.Resources.itsp_content)
                System.IO.File.WriteAllText(directoryName & "\output\js\player-scaling.js", My.Resources.player_scaling)
                System.IO.File.WriteAllText(directoryName & "\output\js\bootstrap.min.js", My.Resources.bootstrap_min_js)
                My.Resources.Back_F1.Save(directoryName & "\output\navimages\Back_F1.png")
                My.Resources.Back_F2.Save(directoryName & "\output\navimages\Back_F2.png")
                My.Resources.Next_F1.Save(directoryName & "\output\navimages\Next_F1.png")
                My.Resources.Next_F2.Save(directoryName & "\output\navimages\Next_F2.png")
                My.Resources.exit_f1.Save(directoryName & "\output\navimages\exit_F1.png")
                My.Resources.exit_f2.Save(directoryName & "\output\navimages\exit_F2.png")
                My.Resources.pass.Save(directoryName & "\output\navimages\pass_F1.png")
                My.Resources.pass_f2.Save(directoryName & "\output\navimages\pass_F2.png")
                My.Resources.blank.Save(directoryName & "\output\navimages\blank.png")
                My.Resources.empty.Save(directoryName & "\output\navimages\empty.png")
                My.Resources.tick.Save(directoryName & "\output\navimages\outcome-tick.png")
                My.Resources.cross.Save(directoryName & "\output\navimages\outcome-cross.png")
            End If
            imageFolder = directoryName & "\images"
            videoFolder = directoryName & "\videos"
            bkgFolder = directoryName & "\backgrounds"
            outputFolder = directoryName & "\output"
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub CopyFilesToNewLoc(ByVal OldImgLoc As String)
        Try
            Dim oldPath As String = Path.GetDirectoryName(OldImgLoc)
            Dim sPath As String = oldPath & "\videos"
            For Each File As String In IO.Directory.GetFiles(sPath)
                System.IO.File.Copy(File, videoFolder & "\" & Path.GetFileName(File), True)
            Next
            For Each f As String In IO.Directory.GetFiles(oldPath & "\images")
                If File.Exists(f) Then
                    System.IO.File.Copy(f, Path.Combine(imageFolder, Path.GetFileName(f)), True)
                End If

            Next

            For Each File As String In IO.Directory.GetFiles(oldPath & "\backgrounds")
                System.IO.File.Copy(File, bkgFolder & "\" & Path.GetFileName(File), True)
            Next

        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub SetModifiedCaption()
        If itspunit Is Nothing Then
            siModified.Caption = ""
            Return
        End If
        If CurrentModified Then
            siModified.Caption = "   Modified   "
        Else
            siModified.Caption = ""
        End If
    End Sub

    Public Sub LoadDocument(ByVal fileName As String)
        Me.newDocument_Renamed = False
        Try
            itspunit = New mstns.ITSPUnit
            Dim itspxml As String = File.ReadAllText(fileName)
            itspxml = upgradefile.UpgradeFile(itspxml, fileName)
            itspunit.FromXml(itspxml)
            Dim sUnit As String = itspunit.ToXml
            Dim xUnit As New mstns.ITSPUnitB
            xUnit.FromXml(sUnit)
            UndoRedoChanges.ITSPUnitCol.Add(xUnit)
        Catch
        Finally
            Try
                'XtraScrollableControl1.BackColor = ColorTranslator.FromHtml(itspunit.BrowserBackgroundColour)
                SetupImageFolders(fileName)
                Me.DocName = fileName
                UpdateText()
                ReloadControls(True, False, True, True, True, True, True, True)
                selectedPageIndex = 0
                SelectPage(selectedPageIndex, True)
                UpdateProjectTypeControls()
            Catch ex As Exception
                Dim strMsg As String = ex.Message.ToString()
                'MsgBox(strMsg)
            End Try
        End Try

        PopulateAssessmentCombo()
        UpdateBKGImage()
    End Sub
    Public Sub ImportTemplate(ByVal fileName As String)
        Try
            Dim TextFileReader As New FileIO.TextFieldParser(fileName)
            TextFileReader.TextFieldType = FileIO.FieldType.Delimited
            TextFileReader.SetDelimiters(",")
            Dim CurrentRow As String()
            CurrentRow = TextFileReader.ReadFields()

            itspunit.TutorialList.Clear()

            While Not TextFileReader.EndOfData
                Try
                    CurrentRow = TextFileReader.ReadFields()
                    If Not CurrentRow Is Nothing Then
                        Dim nColumnNo As Integer = 1
                        Dim currentField As String
                        Dim t As New mstns.Tutorials
                        For Each currentField In CurrentRow
                            If nColumnNo = 1 Then
                                t.TutorialID = CInt(currentField)
                                nColumnNo = 2
                            ElseIf nColumnNo = 2 Then
                                t.TutorialName = currentField
                                nColumnNo = 0
                            End If
                        Next
                        itspunit.TutorialList.Add(t)
                    End If
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & " is not valid and will be skipped.")
                End Try
            End While
            PopulateAssessmentCombo()
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Function SaveQuestion() As Boolean
        Try
            If Modified Then
                Select Case DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to save the changes you made to " & DocName & "?", "Content Creator Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                    Case Windows.Forms.DialogResult.Cancel
                        Return False
                    Case Windows.Forms.DialogResult.Yes
                        Save()
                End Select
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
        Return True
    End Function
    Public Sub ImportScript()
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
            dlg.Title = "Open"
            DoRefreshOnActivate = False
            If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                ImportScriptFile(dlg.FileName)
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub ImportAssessTemplate()
        Try
            DoRefreshOnActivate = False
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "Digital Learning Solutions Assessment Template (*.itst)|*.itst"
            dlg.Title = "Load Assessment Template"
            If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                ImportTemplate(dlg.FileName)
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub ImportScriptFile(ByVal fileName As String)
        Try
            Dim s As New FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            Dim wb As New XLWorkbook(s)
            Dim ws As IXLWorksheet = wb.Worksheet(1)
            Dim currentrow As IXLRow = ws.FirstRowUsed
            Dim lastpage As mstns.Page = itspunit.PageCol.Item(itspunit.PageCol.Count - 1)
            If lastpage.BackgroundImage = "" And Trim(utility.StripHTML(lastpage.InstructionText)).Length < 4 Then
                itspunit.PageCol.RemoveAt(itspunit.PageCol.Count - 1)
            End If
            While Not currentrow.Cell(3).IsEmpty()
                Dim pageTitle As String = currentrow.Cell(1).GetString()
                If pageTitle = "" Then
                    pageTitle = PageName
                End If
                Dim InstructionText As String = "<p class='csC583D0C8'>" & currentrow.Cell(3).GetString() & "</p>"
                Dim pageType As String = currentrow.Cell(2).GetString()
                pageType = GetPageTypeFromLetter(pageType)
                currentrow = currentrow.RowBelow
                If currentrow.Cell(2).IsEmpty() Then
                    While currentrow.Cell(2).IsEmpty And Not currentrow.Cell(3).IsEmpty()
                        InstructionText = InstructionText & "<p class='csC583D0C8'>" & currentrow.Cell(3).GetString() & "</p>"
                        currentrow = currentrow.RowBelow
                        If currentrow.Cell(3).IsEmpty And Not currentrow.RowBelow.Cell(3).IsEmpty Then
                            currentrow = currentrow.RowBelow
                        End If
                    End While
                End If
                Dim contentPage As New mstns.Page
                contentPage.PageName = pageTitle
                contentPage.PageType = pageType
                contentPage.InteractionText = "<p>&nbsp;</p>"
                contentPage.InstructionText = GetHtmlStartBlock() & TidyUp(InstructionText) & GetHtmlEndBlock()
                If Trim(utility.StripHTML(contentPage.InstructionText)).Length > 2 Then
                    itspunit.PageCol.Add(contentPage)
                    selectedPageIndex = itspunit.PageCol.Count - 1
                End If
                If currentrow.Cell(3).IsEmpty And Not currentrow.RowBelow.Cell(3).IsEmpty Then
                    currentrow = currentrow.RowBelow
                End If
            End While
            Modified = True
            ReloadControls(True, False, False, True, True, False, True, True)
            s.Dispose()
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

#End Region
#Region "MostRecentFiles"
    Private arMRUList As MRUArrayList = Nothing
    Private Sub AddToMostRecentFiles(ByVal name As String, ByVal arMRUList As MRUArrayList)
        If arMRUList IsNot Nothing Then
            arMRUList.InsertElement(name)
        End If
        Dim pinItem As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = False}
        If CheckForOverlap(pinItem, RecentTabItem1.TabPanel.Items) Then
            Return
        End If
        RecentTabItem1.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(RecentTabItem1.TabPanel), pinItem)
    End Sub

    Private Function CheckForOverlap(ByVal pinItem As RecentPinItem, ByVal recentItemCollection As RecentItemCollection) As Boolean
        For Each item As RecentItemBase In recentItemCollection
            Dim pItem As RecentPinItem = TryCast(item, RecentPinItem)
            If pItem IsNot Nothing AndAlso pinItem.Caption = pItem.Caption AndAlso pinItem.Description = pItem.Description Then
                Return True
            End If
        Next item
        Return False
    End Function
    Public Sub InitFiles(ByVal fileName As String, ByVal isFile As Boolean)
        If Not System.IO.File.Exists(fileName) Then
            StartInitFiles(isFile)
            EndInitFiles(isFile)
            Return
        End If
        Dim sr As System.IO.StreamReader = System.IO.File.OpenText(fileName)
        Dim list As New List(Of String)()
        Dim s As String = sr.ReadLine()
        Do While s IsNot Nothing
            list.Add(s)
            s = sr.ReadLine()
        Loop
        For i As Integer = 0 To list.Count - 1
            InsertElement(list(i), isFile)
        Next i
        sr.Close()
        If Not isFile Then
            CreateButtonBrowse()
        End If
    End Sub

    Private Function FindFirstUnCheckedIntemIndex(ByVal recentPanelBase As RecentPanelBase) As Integer
        For i As Integer = 0 To recentPanelBase.Items.Count - 1
            Dim pinItem As RecentPinItem = TryCast(recentPanelBase.Items(i), RecentPinItem)
            If pinItem Is Nothing Then
                Continue For
            End If
            If Not pinItem.PinButtonChecked Then
                Return i
            End If
        Next i
        Return 0
    End Function
    Private Sub InsertElement(ByVal obj As Object, ByVal isFile As Boolean)
        Dim names() As String = obj.ToString().Split(","c)
        Dim name As String = names(0)
        Dim checkedLabel As Boolean = False
        If names.Length > 1 Then
            checkedLabel = names(1).ToLower().Equals("true")
        End If
        If isFile Then
            Dim pinItem As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = checkedLabel}
            AddHandler pinItem.ItemClick, AddressOf recentControlOpen_ItemClick
            RecentTabItem1.TabPanel.Items.Add(pinItem)
        Else
            Dim pinItem As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = checkedLabel}
            AddHandler pinItem.ItemClick, AddressOf recentControlOpen_ItemClick
            Dim pinItem_ As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = checkedLabel}
            AddHandler pinItem_.ItemClick, AddressOf recentControlSaveAs_ItemClick
            RecentTabItem2.TabPanel.Items.Add(pinItem)
            RecentTabItem3.TabPanel.Items.Add(pinItem_)
        End If
    End Sub
    Private Sub recentControlOpen_ItemClick(ByVal sender As Object, ByVal e As RecentItemEventArgs)
        Dim recentItem As RecentPinItem = TryCast(e.Item, RecentPinItem)
        If recentItem IsNot Nothing Then
            rbnMain.HideApplicationButtonContentControl()
        End If
        If RecentTabItem1.TabPanel.Items.Contains(e.Item) AndAlso recentItem IsNot Nothing Then
            OpenThisFile(recentItem.Description)
        ElseIf RecentTabItem2.TabPanel.Items.Contains(e.Item) Then
            If recentItem IsNot Nothing Then
                OpenFile(recentItem.Description)
                'System.Diagnostics.Process.Start("explorer.exe", recentItem.Description)

            End If
        End If
    End Sub
    Private Sub recentControlSaveAs_ItemClick(ByVal sender As Object, ByVal e As RecentItemEventArgs)
        Dim recentItem As RecentPinItem = TryCast(e.Item, RecentPinItem)
        If recentItem IsNot Nothing Then
            rbnMain.HideApplicationButtonContentControl()
            SaveAs(recentItem.Description)
        End If
    End Sub
    Private Sub CreateButtonBrowse()
        Dim hyperlinkBrowse As New RecentHyperlinkItem() With {.Caption = "Browse..."} ', Link = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        RecentTabItem2.TabPanel.Items.Add(hyperlinkBrowse)
        RecentTabItem1.TabPanel.Items.Add(hyperlinkBrowse)
        AddHandler hyperlinkBrowse.ItemClick, AddressOf bsvOpen_ItemClick
        Dim hyperlinkBrowse1 As New RecentHyperlinkItem() With {.Caption = "Browse..."} ', Link = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        RecentTabItem3.TabPanel.Items.Add(hyperlinkBrowse1)
        AddHandler hyperlinkBrowse1.ItemClick, AddressOf hyperlinkBrowse_ItemClick
    End Sub

    Private Sub hyperlinkBrowse_ItemClick(ByVal sender As Object, ByVal e As RecentItemEventArgs)
        SaveAs()
    End Sub
    Private Sub EndInitFiles(ByVal isFile As Boolean)
        If isFile Then
            '  InitDefaultFiles()
        Else
            InitDefaultFolders()
        End If
        If Not isFile Then
            CreateButtonBrowse()
        End If
    End Sub
    Private Sub StartInitFiles(ByVal isFile As Boolean)
        If Not isFile Then
            InitStartDefaultFolders()
        End If
    End Sub
    Private Sub InitStartDefaultFolders()
        Dim desktop As New RecentPinItem() With {.Caption = "Desktop", .Description = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString(), .PinButtonChecked = True, .ShowDescription = False}
        Dim desktop_ As New RecentPinItem() With {.Caption = "Desktop", .Description = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString(), .PinButtonChecked = True, .ShowDescription = False}
        RecentTabItem2.TabPanel.Items.Add(desktop)
        RecentTabItem3.TabPanel.Items.Add(desktop_)
        Dim separator As New RecentSeparatorItem()
        Dim separator_ As New RecentSeparatorItem()
        RecentTabItem2.TabPanel.Items.Add(separator)
        RecentTabItem3.TabPanel.Items.Add(separator_)
    End Sub
    Private Sub InitDefaultFolders()
        Dim item1 As New RecentPinItem() With {.Caption = "MyDocuments", .Description = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString()}
        Dim item1_ As New RecentPinItem() With {.Caption = "MyDocuments", .Description = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString()}
        RecentTabItem2.TabPanel.Items.Add(item1)
        RecentTabItem3.TabPanel.Items.Add(item1_)


    End Sub
    Private Sub AddToMostRecentFolders(ByVal name As String, ByVal arMRUList As MRUArrayList)
        If arMRUList IsNot Nothing Then
            name = Path.GetFullPath(name)
            arMRUList.InsertElement(Path.GetDirectoryName(name))
        End If
        name = Path.GetDirectoryName(Path.GetFullPath(name))
        Dim pinItem As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = False}
        If CheckForOverlap(pinItem, RecentTabItem2.TabPanel.Items) Then
            Return
        End If
        Dim pinItem_ As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = False}
        RecentTabItem2.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(RecentTabItem2.TabPanel), pinItem)
        recentTabItem3.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(recentTabItem3.TabPanel), pinItem_)
    End Sub
    Private Function GetFileName(ByVal obj As Object) As String
        Dim fi As New FileInfo(obj.ToString())
        Return fi.Name
    End Function
    Private Sub InitMostRecentFiles(ByVal arList As MRUArrayList)
        Try
            Dim fileName As String = MRUArrayList.MRUFileName
            arList.Init(fileName, "")
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub InitMostRecentFiles()
        Dim fileName As String = MRUArrayList.MRUFileName
        Dim folderName As String = MRUArrayList.MRUFolderName
        InitFiles(fileName, True)
        InitFiles(folderName, False)
    End Sub
    Private Sub InitMostRecentFolders(ByVal arList As MRUArrayList)
        Try
            Dim folderName As String = MRUArrayList.MRUFolderName
            arList.Init(folderName, GetFolderPath(SpecialFolder.MyDocuments))
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub SaveMostRecentFiles(ByVal files As RecentItemCollection, ByVal fileName As String)
        Try
            Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(fileName)
            For i As Integer = 0 To files.Count - 1
                Dim pinItem As RecentPinItem = TryCast(files(i), RecentPinItem)
                If pinItem Is Nothing Then
                    Continue For
                End If
                sw.WriteLine(String.Format("{0},{1}", If(pinItem.Description <> String.Empty, pinItem.Description, pinItem.Caption), pinItem.PinButtonChecked.ToString()))
            Next i
            sw.Close()
        Catch
        End Try
    End Sub
#End Region
#Region "Images"
    Public Sub UpdateBkgImageLibraries()
        Try
            'Update the gallery list
            Dim pgc As PopupGalleryEditGallery = PageSettings1.PopupGalleryEdit1.Properties.Gallery
            pgc.Groups(0).Dispose()
            pgc.Groups.Add(New DevExpress.XtraBars.Ribbon.GalleryItemGroup)
            pgc.Groups(0).Items.Clear()
            'pgc.Groups(1).Items.Clear()
            pgc.ShowItemText = True
            pgc.FixedImageSize = True
            pgc.UseMaxImageSize = False
            pgc.ImageSize = New System.Drawing.Size(170, 128)
            pgc.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
            Dim rgc As DevExpress.XtraBars.RibbonGalleryBarItem = RibbonBackgroundGallery
            If rgc.Gallery.Groups.Count = 0 Then
                rgc.Gallery.Groups.Add(New DevExpress.XtraBars.Ribbon.GalleryItemGroup)
                rgc.Gallery.Groups(0).Caption = "Background"
            Else
                rgc.Gallery.Groups(0).Items.Clear()
            End If
            rgc.Gallery.ShowItemText = True
            rgc.Gallery.FixedImageSize = True
            rgc.Gallery.UseMaxImageSize = False
            rgc.Gallery.ImageSize = New System.Drawing.Size(170, 128)
            rgc.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
            If bkgFolder <> "" Then
                For Each File As String In IO.Directory.GetFiles(bkgFolder, "*.jpg")
                    Dim fs As System.IO.FileStream
                    fs = New System.IO.FileStream(File, IO.FileMode.Open, IO.FileAccess.Read)
                    Dim img As Image = System.Drawing.Image.FromStream(fs)
                    fs.Dispose()
                    Dim nWidth As Integer = img.Width
                    Dim nHeight As Integer = img.Height
                    If nHeight > 128 Then
                        nWidth = CInt((CSng(128) / CSng(nHeight)) * CSng(nWidth))
                        nHeight = 128
                    End If
                    If nWidth > 170 Then
                        nHeight = CInt((CSng(170) / CSng(nWidth)) * CSng(nHeight))
                        nWidth = 170
                    End If
                    Dim newItem As GalleryItem = New GalleryItem(utility.ResizeImage(img, New Size(nWidth, nHeight)), Path.GetFileNameWithoutExtension(File), "")
                    newItem.Value = Path.GetFileName(File)
                    newItem.HoverImage = utility.ResizeImage(img, New Size(400, 300))
                    pgc.Groups(0).Items.Add(newItem)
                    rgc.Gallery.Groups(0).Items.Add(newItem)
                Next
                For Each File As String In IO.Directory.GetFiles(bkgFolder, "*.png")
                    Dim fs As System.IO.FileStream
                    fs = New System.IO.FileStream(File, IO.FileMode.Open, IO.FileAccess.Read)
                    Dim img As Image = System.Drawing.Image.FromStream(fs)
                    fs.Dispose()
                    Dim nWidth As Integer = img.Width
                    Dim nHeight As Integer = img.Height
                    If nHeight > 128 Then
                        nWidth = CInt((CSng(128) / CSng(nHeight)) * CSng(nWidth))
                        nHeight = 128
                    End If
                    If nWidth > 170 Then
                        nHeight = CInt((CSng(170) / CSng(nWidth)) * CSng(nHeight))
                        nWidth = 170
                    End If
                    Dim newItem As GalleryItem = New GalleryItem(utility.ResizeImage(img, New Size(nWidth, nHeight)), Path.GetFileNameWithoutExtension(File), "")
                    newItem.Value = Path.GetFileName(File)
                    newItem.HoverImage = utility.ResizeImage(img, New Size(400, 300))
                    pgc.Groups(0).Items.Add(newItem)
                    rgc.Gallery.Groups(0).Items.Add(newItem)
                Next
                Dim blankimg As Image
                blankimg = New Bitmap(ITSP_CDA.My.Resources.blank_thmb)
                Dim blankItem As GalleryItem = New GalleryItem(blankimg, "Blank", "")
                blankItem.Value = ""
                pgc.Groups(0).Items.Add(blankItem)
                rgc.Gallery.Groups(0).Items.Add(blankItem)

            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub UpdateBKGImage()
        Try
            If PageSettings1.PopupGalleryEdit1.EditValue Is Nothing Or PageSettings1.PopupGalleryEdit1.EditValue.ToString = "" Or Trim(PageSettings1.PopupGalleryEdit1.EditValue.ToString) = "," Then
                itspunit.PageCol(selectedPageIndex).BackgroundImage = ""
            Else
                itspunit.PageCol(selectedPageIndex).BackgroundImage = PageSettings1.PopupGalleryEdit1.EditValue.ToString()
            End If

            ReloadControls(False, True, True, True, True, False, True, True)
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Function PasteImageAsImage() As String
        If Not System.Windows.Forms.Clipboard.GetDataObject() Is Nothing Then
            Dim oDataObj As IDataObject = System.Windows.Forms.Clipboard.GetDataObject()
            If oDataObj.GetDataPresent(System.Windows.Forms.DataFormats.Bitmap) Then
                Dim oImgObj As System.Drawing.Image = DirectCast(oDataObj.GetData(DataFormats.Bitmap, True), Image)
                Dim fname As String = GetNextImageName()
                oImgObj.Save(fname, System.Drawing.Imaging.ImageFormat.Png)
                ReloadControls(False, False, False, False, False, True, False, False)
                Dim fileName As String = Path.GetFileName(fname)
                Return (fileName)
            Else
                MsgBox("The clipboard doesn't contain a bitmap image.", MsgBoxStyle.OkOnly, "Clipboard not a bitmap")
                Return ("")
            End If
        Else
            MsgBox("The clipboard is empty.", MsgBoxStyle.OkOnly, "Clipboard empty")
            Return ("")
        End If
    End Function
    Public Function GetNextImageName() As String
        Dim Prefix As String = imageFolder + "\Image_"
        Dim iIt As Integer = 1
        Dim fname As String = Prefix & iIt.ToString & ".png"
        Dim fname2 As String = Prefix & iIt.ToString & ".jpg"
        Try
            While File.Exists(fname) Or File.Exists(fname2)
                fname = Prefix & iIt.ToString & ".png"
                fname2 = Prefix & iIt.ToString & ".jpg"
                iIt = iIt + 1
            End While
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
        Return fname
    End Function

    Public Sub PrepareGallery(ByVal gc As PopupGalleryEditGallery)
        Try
            If gc.Groups.Count > 0 Then
                gc.Groups(0).Dispose()
            End If
            If gc.Groups.Count = 0 Then
                gc.Groups.Add(New DevExpress.XtraBars.Ribbon.GalleryItemGroup)
                gc.Groups(0).Caption = "Images"
            Else
                gc.Groups(0).Items.Clear()
            End If
            gc.ShowItemText = True
            gc.FixedImageSize = True
            gc.UseMaxImageSize = False
            gc.ImageSize = New System.Drawing.Size(70, 50)
            gc.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub UpdateImageList()
        Try
            If Not imageFolder = "" Then
                bIsObjectListReordering = True
                Dim gc1 As PopupGalleryEditGallery = StandardImageGalleryEdit.Properties.Gallery
                Dim gc2 As PopupGalleryEditGallery = HoverImageGalleryEdit.Properties.Gallery
                Dim gc3 As PopupGalleryEditGallery = MouseDownImageGalleryEdit.Properties.Gallery
                Dim gc4 As PopupGalleryEditGallery = MouseUpImageGalleryEdit.Properties.Gallery
                PrepareGallery(gc1)
                PrepareGallery(gc2)
                PrepareGallery(gc3)
                PrepareGallery(gc4)
                Dim rgc As DevExpress.XtraBars.RibbonGalleryBarItem = RibbonImageGallery
                If rgc.Gallery.Groups.Count = 0 Then
                    rgc.Gallery.Groups.Add(New DevExpress.XtraBars.Ribbon.GalleryItemGroup)
                    rgc.Gallery.Groups(0).Caption = "Images"
                Else
                    rgc.Gallery.Groups(0).Items.Clear()
                End If
                rgc.Gallery.ShowItemText = True
                rgc.Gallery.FixedImageSize = False
                rgc.Gallery.UseMaxImageSize = False
                rgc.Gallery.ImageSize = New System.Drawing.Size(70, 50)
                rgc.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside

                For Each File As String In IO.Directory.GetFiles(imageFolder, "*.png")
                    Dim img As Image = Image.FromFile(File)
                    Dim nWidth As Integer = img.Width
                    Dim nHeight As Integer = img.Height
                    If nHeight > 50 Then
                        nWidth = CInt((CSng(50) / CSng(nHeight)) * CSng(nWidth))
                        nHeight = 50
                    End If
                    If nWidth > 70 Then
                        nHeight = CInt((CSng(70) / CSng(nWidth)) * CSng(nHeight))
                        nWidth = 70
                    End If

                    Dim newHItem As GalleryItem = New GalleryItem(img, Path.GetFileNameWithoutExtension(File), "")
                    Dim newItem As GalleryItem = New GalleryItem(utility.ResizeImage(img, New Size(nWidth, nHeight)), Path.GetFileNameWithoutExtension(File), "")
                    newItem.Value = Path.GetFileName(File)
                    newItem.HoverImage = img
                    rgc.Gallery.Groups(0).Items.Add(newItem)
                    gc1.Groups(0).Items.Add(newItem)
                    gc2.Groups(0).Items.Add(newItem)
                    gc3.Groups(0).Items.Add(newItem)
                    gc4.Groups(0).Items.Add(newItem)
                Next

                For Each File As String In IO.Directory.GetFiles(imageFolder, "*.jpg")
                    Dim img As Image = Image.FromFile(File)
                    Dim nWidth As Integer = img.Width
                    Dim nHeight As Integer = img.Height
                    If nHeight > 50 Then
                        nWidth = CInt((CSng(50) / CSng(nHeight)) * CSng(nWidth))
                        nHeight = 50
                    End If
                    If nWidth > 70 Then
                        nHeight = CInt((CSng(70) / CSng(nWidth)) * CSng(nHeight))
                        nWidth = 70
                    End If
                    Dim newHItem As GalleryItem = New GalleryItem(img, Path.GetFileNameWithoutExtension(File), "")

                    Dim newItem As GalleryItem = New GalleryItem(utility.ResizeImage(img, New Size(nWidth, nHeight)), Path.GetFileNameWithoutExtension(File), "")
                    newItem.Value = Path.GetFileName(File)
                    newItem.HoverImage = img
                    rgc.Gallery.Groups(0).Items.Add(newItem)
                    gc1.Groups(0).Items.Add(newItem)
                    gc2.Groups(0).Items.Add(newItem)
                    gc3.Groups(0).Items.Add(newItem)
                    gc4.Groups(0).Items.Add(newItem)
                Next

                Dim imgnone As New Bitmap(70, 50)
                Dim blankItem As GalleryItem = New GalleryItem(imgnone, "None", "")
                blankItem.Value = ""
                gc1.Groups(0).Items.Add(blankItem)
                gc2.Groups(0).Items.Add(blankItem)
                gc3.Groups(0).Items.Add(blankItem)
                gc4.Groups(0).Items.Add(blankItem)
                bIsObjectListReordering = False
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub BrowseForImage()
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.jpe;*.gif;*.tif;*.tiff;*.png;*.cur;"
            dlg.Title = "Import Image"
            DoRefreshOnActivate = False
            If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(dlg.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                Dim fn As String = Path.GetFileName(dlg.FileName)
                Dim ffn As String = imageFolder & "\" & fn
                Dim ds As New FileStream(ffn, FileMode.Create)
                fs.CopyTo(ds)
                ds.Close()
                fs.Close()
                ReloadControls(False, False, False, False, False, True, False, False)
                Dim sExt As String = Path.GetExtension(dlg.FileName)
                If Not sExt = ".cur" Then
                    selectedImageName = fn
                    ResetRibbonButtons()
                    insertObjectType = "Image"
                    AddImageCrosshair(fn)
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
        End Try
    End Sub
#End Region
#Region "Video"
    Dim WithEvents thumb As New Thumbnailer.ThumbnailGenerator
    Dim svfn As String
    Public Sub BrowseForVideo()
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "mp4 video files|*.mp4"
            dlg.Title = "Import Video"
            DoRefreshOnActivate = False
            If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(dlg.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                If (Not System.IO.Directory.Exists(videoFolder)) Then
                    System.IO.Directory.CreateDirectory(videoFolder)
                End If
                svfn = Path.GetFileName(dlg.FileName)
                Dim ffn As String = videoFolder & "\" & svfn
                If Path.GetDirectoryName(dlg.FileName) <> videoFolder Then
                    Dim ds As New FileStream(ffn, FileMode.Create)
                    fs.CopyTo(ds)
                    ds.Close()
                    fs.Close()
                End If
                thumb.CreateThumbnailsToFile(ffn, videoFolder, TimeSpan.Parse("00:00:00.01"), TimeSpan.Parse("00:00:00.01"), 1, 0, 0)
                ReloadControls(False, False, False, False, False, True, False, False)
                selectedImageName = svfn
                ResetRibbonButtons()
                insertObjectType = "Video"
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
        End Try
    End Sub
    Private Sub thumb_ThumbnailsCreatedToDisk(sender As Object, e As Thumbnailer.ThumbnailsCreatedEventArgs(Of String)) Handles thumb.ThumbnailsCreatedToDisk
        AddImageCrosshair(svfn.Replace(".mp4", ".jpg"))
    End Sub
#End Region
#Region "WebPreview"
    Private Sub RenderSelectedPage()
        Try
            If allowPreview Then
                allowPreview = False
                Dim wp As WebBrowser = wbPagePreview
                'wp.Width = XtraScrollableControl1.Width
                'wp.Height = XtraScrollableControl1.Height
                SavePreviewPage(HtmlPreview())

                wp.ObjectForScripting = New HTMLHelper
                wp.Navigate(outputFolder & "/preview.html")
                While (wp.IsBusy())
                    Application.DoEvents()
                End While

            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub ResponsiveSleep(ByRef iMilliSeconds As Integer)
        Dim i As Integer, iTenthSeconds As Integer = iMilliSeconds / 60
        For i = 1 To iTenthSeconds
            Threading.Thread.Sleep(60) : Application.DoEvents()
        Next i
    End Sub
    Protected Sub DoZoomCheck()
        Dim wp As WebBrowser = wbPagePreview
        ResponsiveSleep(60)
        Dim w = CType(wp.Document.Window.DomWindow, mshtml.IHTMLWindow2)
        Dim s = CType(w.screen, mshtml.IHTMLScreen2)
        Dim zoom As Integer = s.deviceXDPI * 100 / 96
        If zoom > 125 Then
            wp.ScrollBarsEnabled = True
        Else
            wp.ScrollBarsEnabled = False
        End If
    End Sub
    Public Shared Function GetHtmlStartBlock() As String
        Dim sHtml As String = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'><html xmlns='http://www.w3.org/1999/xhtml'>"
        sHtml = sHtml & "<head><meta http-equiv='Content-Type' content='text/html; charset=utf-8' /><title></title><style type='text/css'>.csC583D0C8{text-align:left;text-indent:0pt;margin:6pt 0pt 6pt 0pt;color:#000000;background-color:transparent;font-family:" & itspunit.FontFamily
        sHtml = sHtml & ";font-size:16px;font-weight:normal;line-height:1.5;font-style:normal;}</style></head><body>"
        Return sHtml
    End Function
    Public Shared Function GetHtmlEndBlock() As String
        Dim sHtml As String = "</body></html>"
        Return sHtml
    End Function
    Private Function HtmlPreview() As String
        Dim htmlSource As String = ""
        Try
            htmlSource = My.Resources.ViewPage.ToString()
            Dim pg As mstns.Page = itspunit.PageCol(selectedPageIndex)
            'Calculate progress bar position:
            Dim nPageNum As Integer = itspunit.PageCol.IndexOf(pg) + 1
            Dim nPageCount As Integer = itspunit.PageCol.Count
            htmlSource = htmlSource.Replace("00065", nPageNum.ToString)
            htmlSource = htmlSource.Replace("000100", nPageCount.ToString)
            Dim t1 As String = Replace(Trim(utility.StripHTML(pg.InstructionText)), " ", "")
            Dim t2 As String = Replace(Trim(utility.StripHTML(pg.InteractionText)), " ", "")
            If t1 Is Nothing Then
                t1 = ""
            End If
            If t2 Is Nothing Then
                t2 = ""
            End If
            'Handle page background image settings:
            If pg.BackgroundImage <> "" Then
                PageSettings1.btnBkgEdit.Enabled = True
                Dim imgPath As String = "../backgrounds/" & pg.BackgroundImage
                htmlSource = htmlSource.Replace("XXBkgImageSrcXX", imgPath.Replace(" ", "%20"))
            Else
                PageSettings1.btnBkgEdit.Enabled = False
                htmlSource = htmlSource.Replace("XXBkgImageSrcXX", "/navimages/empty.png")
            End If
            htmlSource = htmlSource.Replace("#ABABAB", itspunit.BrowserBackgroundColour.ToString())
            htmlSource = htmlSource.Replace("#CDCDCD", itspunit.PageBackgroundColour.ToString())
            htmlSource = htmlSource.Replace("XXBlankXX", outputFolder & "\navimages\empty.png")
            htmlSource = htmlSource.Replace("XXImageNameXX", pg.BackgroundImage)
            htmlSource = htmlSource.Replace("XXImageWidthXX", itspunit.Width.ToString())
            htmlSource = htmlSource.Replace("XXImageHeightXX", itspunit.Height.ToString())


            'hide next and previous if assessment:
            If itspunit.Type <> "Learning" Then
                htmlSource = htmlSource.Replace("back-button", "back-button hiddenobj")
                htmlSource = htmlSource.Replace("next-button", "pass-button")
            ElseIf Not pg.IncludeNext Then
                htmlSource = htmlSource.Replace("next-button", "next-button hiddenobj")
            End If
            If (t1 & t2).Length < 5 Then
                htmlSource = htmlSource.Replace("XXLeftPosXX", "-1000")
                htmlSource.Replace("XXTBClassXX", "hidden")
            Else
                htmlSource = htmlSource.Replace("XXLeftPosXX", pg.InstructionHPos.ToString())
            End If
            'Handle instruction type and text settings:
            Dim sType As String = "Explanation"
            Select Case pg.PageType
                Case "explain"
                    sType = "Explanation"
                Case "demo"
                    sType = "Demonstration"
                Case "test"
                    sType = "Test"
                Case "practice"
                    sType = "Practise"
                Case "guide"
                    sType = "Guide"
                Case "review"
                    sType = "Review"
            End Select
            htmlSource = htmlSource.Replace("##PageType##", sType)
            If pg.PageType <> "" Then
                htmlSource = htmlSource.Replace("XXTBClassXX", "tb-" & pg.PageType.ToLower())
            Else
                htmlSource = htmlSource.Replace("XXTBClassXX", "tb-explain")
            End If
            htmlSource = htmlSource.Replace("XXRightPosXX", pg.InstructionVPos.ToString())
            If t1.Length > 2 And t2.Length > 2 Then
                htmlSource = htmlSource.Replace("<div id='output-inst-text'></div>", utility.RemovePageTags(pg.InstructionText) & utility.RemovePageTags(pg.InteractionText))
            ElseIf t1.Length > 2 Then
                htmlSource = htmlSource.Replace("<div id='output-inst-text'></div>", utility.RemovePageTags(pg.InstructionText))
            ElseIf t2.Length > 2 Then
                htmlSource = htmlSource.Replace("<div id='output-inst-text'></div>", utility.RemovePageTags(pg.InteractionText))
            End If
            'Handle quiz question stuff:
            Dim htmlScripts As String = ""
            If Not pg.QuizQuestion Is Nothing Then
                If pg.QuizQuestion.Question <> "" Then
                    htmlSource = htmlSource.Replace("<!--quizq-->", My.Resources.quiz_question.ToString)
                    htmlSource = htmlSource.Replace("XXXQuestionTextXXX", utility.HTMLEncodeWithTags(pg.QuizQuestion.Question))
                    htmlSource = htmlSource.Replace("XXHintXX", utility.HTMLEncodeWithTags(pg.QuizQuestion.Hint))
                    Select Case pg.QuizQuestion.Layout.ToLower
                        Case "left"
                            htmlSource = htmlSource.Replace("col-sm-10 col-sm-offset-1", "col-sm-6")
                        Case "right"
                            htmlSource = htmlSource.Replace("col-sm-10 col-sm-offset-1", "col-sm-6 col-sm-offset-6")
                        Case "centred"
                            htmlSource = htmlSource.Replace("col-sm-10 col-sm-offset-1", "col-sm-6 col-sm-offset-3")
                    End Select
                    Dim sChoices As String = ""
                    Dim nCorrect As Integer = 0
                    For Each ch As mstns.QuizChoice In pg.QuizQuestion.QuizChoicesCol
                        sChoices = sChoices & "<li class='q-choice list-group-item' data-type='radio' data-style='alert' data-color='alert-info' data-iscor='" & ch.Correct.ToString() & "'><span style='padding-left:10px;'>" & ch.ChoiceText & "</span>"

                        If ch.Correct Then
                            nCorrect = nCorrect + 1
                            sChoices = sChoices & "<span class='pull-right'>&#x2713;</span>"
                        End If

                        sChoices = sChoices & "</li>"
                    Next
                    If nCorrect <> 1 Then
                        sChoices = sChoices.Replace("data-type='radio'", "data-type='checkbox'")
                    End If
                    htmlSource = htmlSource.Replace("<!--qchoices-->", sChoices)
                    If pg.QuizQuestion.Shuffle Then
                        htmlScripts = htmlScripts + "$('.q-choice').shuffle();"
                    End If
                End If
            End If
            'Setup the css and js file references
            htmlSource = htmlSource.Replace("XXitsplearningcssXX", outputFolder & "\css\itsplearning.css")
            htmlSource = htmlSource.Replace("XXanimationcssXX", outputFolder & "\css\animation.css")
            htmlSource = htmlSource.Replace("XXbootstrapcssXX", outputFolder & "\css\bootstrap.min.css")
            htmlSource = htmlSource.Replace("XXjquery_ui_cssXX", outputFolder & "\css\jquery_ui.css")
            htmlSource = htmlSource.Replace("XXjquery_ui_jsXX", outputFolder & "\js\jquery_ui.js")
            htmlSource = htmlSource.Replace("XXjquery_jsXX", outputFolder & "\js\jquery.js")
            htmlSource = htmlSource.Replace("XXbootstrap_jsXX", outputFolder & "\js\bootstrap.min.js")
            htmlSource = htmlSource.Replace("XXitsplearning_jsXX", outputFolder & "\js\itsp_content.js")
            htmlSource = htmlSource.Replace("XXcrosshair-minXX", outputFolder & "\js\crosshair-min.js")
            htmlSource = htmlSource.Replace("XXplayerscaling_jsXX", outputFolder & "\js\player-scaling.js")
            Dim htmlObjects As String = ""
            Dim htmlStyles As String = ".text-box{ width: " & pg.InstructionWidth.ToString & "px !important;}"
            htmlStyles = htmlStyles & "progress{ width: " & (pg.InstructionWidth - 35).ToString & "px !important;}"
            For Each obj As mstns.Object_ In pg.ObjectCol
                'Start the style string:
                htmlStyles = htmlStyles + "#" & obj.ObjectName & " {position:absolute;"

                'Add the positioning css elements:
                htmlStyles = htmlStyles + "top:" & obj.VPos.ToString() & "px;left:" & obj.HPos.ToString() & "px;height:" & obj.Height.ToString() & "px;width:" & obj.Width.ToString() & "px;"

                'Add background options:


                'If image is rotated, rotate it:
                If obj.Rotation > 0 Then
                    htmlStyles = htmlStyles + "transform: rotate(" & obj.Rotation & "deg);"
                End If
                'If a Standard background exists, set it:
                If obj.StandardImage <> "" Then
                    Dim imgPath As String = "../Images/" & obj.StandardImage
                    htmlStyles = htmlStyles + "background-Image:url(" & imgPath.Replace(" ", "%20") & ");"
                ElseIf obj.UseMouseUpImage Or obj.UseMouseEnterImage Or obj.UseMouseDownImage Then
                    Dim imgPath As String = ""
                    If obj.UseMouseEnterImage Then
                        imgPath = "../Images/" & obj.MouseEnterImage
                    End If
                    If obj.UseMouseUpImage Then
                        imgPath = "../Images/" & obj.MouseUpImage
                    End If
                    If obj.UseMouseDownImage Then
                        imgPath = "../Images/" & obj.MouseDownImage
                    End If
                    htmlStyles = htmlStyles + "background-Image:url(" & imgPath.Replace(" ", "%20") & ");"
                    htmlStyles = htmlStyles + "filter: alpha(opacity=35);opacity: 0.35;"
                    'Else
                    '    htmlStyles = htmlStyles + "background-color:" & utility.hexAndOpacityToRgba(obj.BackGroundColour.ToString(), obj.BackGroundOpacity) & ";"
                End If
                htmlStyles = htmlStyles + "}"
                'Add border options:
                If obj.BorderStyle <> "none" Or obj.Radius <> 0 Then
                    'Setup the border color according to opacity:
                    Dim sBorderColour As String = obj.BorderColour.ToString()
                    If obj.BorderOpacity < 1 Then
                        Dim nOpacityPercent As Integer = CInt(CDec(obj.BorderOpacity) * CDec(100))
                        sBorderColour = utility.hexAndOpacityToRgba(sBorderColour, obj.BorderOpacity)
                    End If
                    htmlStyles = htmlStyles + "#" & obj.ObjectName & ":after {position:absolute;content: ''; display: block; position: absolute; top: 0; bottom: 0; left: 0; right: 0; "
                    If obj.BorderStyle <> "none" Then
                        htmlStyles = htmlStyles + "border: " & obj.BorderWidth.ToString() & "px " & obj.BorderStyle.ToString() & " " & sBorderColour & ";transform: translate(0px,0px);"
                    End If
                    If obj.Radius <> 0 Then
                        htmlStyles = htmlStyles + "border-radius:" & obj.Radius & "px;"
                    End If
                    htmlStyles = htmlStyles + "background-color:" & utility.hexAndOpacityToRgba(obj.BackGroundColour.ToString(), obj.BackGroundOpacity) & ";"
                    htmlStyles = htmlStyles + "}"
                End If
                If obj.MouseEnterImage <> "" Then
                    Dim imgPath As String = "../Images/" & obj.MouseEnterImage
                    htmlStyles = htmlStyles + "#" & obj.ObjectName & ":hover {background-Image:url(" & imgPath.Replace(" ", "%20") & ");cursor:pointer;filter: alpha(opacity=100);opacity:1;}"
                End If
                Dim sInnerHtml As String = ""
                For Each bh As mstns.Behaviours In obj.BehaviourCol
                    If Not bh.Text_ Is Nothing Then
                        If Not bh.Text_.StartHtml = "" Then
                            Dim sHTML As String = bh.Text_.StartHtml
                            sHTML = Replace(sHTML, "<body>", "<body><div id='" & obj.ObjectName & "-content' spellcheck='false' class='text-area-content'>")
                            sHTML = Replace(sHTML, "</body>", "</div></body>")
                            sInnerHtml = "<div class='start-text'>" & sHTML & "</div>"
                            Exit For
                        End If
                    End If
                    If Not bh.Password Is Nothing Then
                        sInnerHtml = "<input type='password' name='pwd' style='width:" & obj.Width.ToString & "px;border:0;' value='" & bh.Password.RequiredPassword & "'>"
                    End If
                Next
                If Not obj.VideoFile = "" Then
                    Dim vidPath As String = "../videos/" & obj.VideoFile
                    sInnerHtml = "<video id='" & obj.ObjectName & "-vid' width='" & obj.Width.ToString & "' height='" & obj.Height.ToString & "'"
                    If obj.VideoAutoplay Then
                        sInnerHtml = sInnerHtml & " autoplay='autoplay' muted='muted'"
                    Else
                        sInnerHtml = sInnerHtml & " controls='controls'"
                    End If
                    sInnerHtml = sInnerHtml & " >"
                    sInnerHtml = sInnerHtml & "<source src='" & vidPath.Replace(" ", "%20") & "' type='video/mp4'>"
                    sInnerHtml = sInnerHtml & "</video>"
                End If
                'If obj.ObjectName = selectedObjectID Then
                '    htmlObjects = htmlObjects & "<div class='object outline-element' id='" & obj.ObjectName & "' >" & sInnerHtml & "</div>"
                'Else
                Dim sClassList As String = "object"
                If obj.ObjectName = selectedObjectID Then
                    sClassList = sClassList & " selected-element"
                End If
                If Not obj.EditorVisible Then
                    sClassList = sClassList & " hiddenobj"
                End If
                For Each bh As mstns.Behaviours In obj.BehaviourCol
                    If Not bh.CustomCSS Is Nothing Then
                        If Not bh.CustomCSS.CSSClasses = "" Then
                            sClassList = sClassList & " " & bh.CustomCSS.CSSClasses
                        End If
                    End If
                Next
                htmlObjects = htmlObjects & "<div class='" & sClassList & "' id='" & obj.ObjectName & "' >" & sInnerHtml & "</div>"
                'End If

            Next

            htmlSource = htmlSource.Replace(".stylestring{}", htmlStyles)
            htmlSource = htmlSource.Replace("<div id='output-objects'></div>", htmlObjects)
            htmlSource = htmlSource.Replace("function customScripts() { };", htmlScripts)
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
        Return htmlSource
    End Function
    Private Sub SavePreviewPage(ByVal shtml As String)
        Try
            If Not outputFolder = "" Then
                Dim writePermission As New Security.Permissions.FileIOPermission(Security.Permissions.FileIOPermissionAccess.Write, outputFolder & "/preview.html")
                'write here
                If Security.SecurityManager.IsGranted(writePermission) Then
                    'some error message
                    If (System.IO.File.Exists(outputFolder & "/preview.html")) Then
                        If Not utility.FileInUse(outputFolder & "/preview.html") Then
                            System.IO.File.Delete(outputFolder & "/preview.html")
                        End If
                    End If
                    System.IO.File.WriteAllText(outputFolder & "/preview.html", shtml)
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub EditBkgImage()
        Try
            Dim editor As String = My.Settings.ImageEditor
            If editor = "" Then
                editor = SetImageEditor()
            End If
            If editor = "" Then
                Exit Sub
            End If
            Dim imgPath As String = bkgFolder + "\" & itspunit.PageCol(selectedPageIndex).BackgroundImage
            System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(editor, """" + imgPath + """"))
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub wbPagePreview_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbPagePreview.DocumentCompleted
        Try
            If e.Url.AbsolutePath <> TryCast(sender, WebBrowser).Url.AbsolutePath Or wbPagePreview.ReadyState <> WebBrowserReadyState.Complete Then
                Return
            End If
            'The page is finished loading 
            If selectedObjectID <> "" And selectedObjectType = "Object" Then
                SelectObject()
            End If

            allowPreview = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub SaveThumb()
        'Dim b As New Bitmap(wbPagePreview.Width, wbPagePreview.Height)
        'wbPagePreview.DrawToBitmap(b, New Rectangle(0, 0, b.Width, b.Height))
        'If XtraScrollableControl1.ClientRectangle.Width >= itspunit.Width And XtraScrollableControl1.ClientRectangle.Height >= itspunit.Height Then
        If imageFolder <> "" Then


                Dim i As Image
            i = utility.CaptureWindow(wbPagePreview.Handle, itspunit.Height, itspunit.Width)
            Dim nH As Integer = i.Height
            Dim nW As Integer = i.Width
            Dim nHnew As Integer = nH
            Dim nWnew As Integer = nW
            If nHnew < 128 Then
                nWnew = CInt((CSng(96) / CSng(nH)) * CSng(nW))
                nHnew = 128
            End If
            If nWnew > 170 Then
                nHnew = CInt((CSng(170) / CSng(nWnew)) * CSng(nHnew))
                nWnew = 170
            End If
            i = utility.ResizeImage(i, New Size(nWnew, nHnew))
            Dim fld As String = imageFolder.Replace("images", "thumbs")
                If (Not System.IO.Directory.Exists(fld)) Then
                    System.IO.Directory.CreateDirectory(fld)
                End If
                Dim fname As String = fld + "\" + itspunit.PageCol(selectedPageIndex).PageName + "_thmb.jpg"
                i.Save(fname, System.Drawing.Imaging.ImageFormat.Jpeg)
                UpdateCurrentPageThumb()
                'ReloadControls(True, False, False, False, False, False, False)

                DoZoomCheck()

            End If
        ' Else
        'wbPagePreview.ScrollBarsEnabled = True
        'End If
    End Sub
#End Region
#Region "CleanUp"
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        'SaveMostRecentFiles(arMRUList, Application.StartupPath & "\" & MRUArrayList.MRUFileName)
        Try
            SaveTheme()
            SaveMostRecentFiles(RecentTabItem1.TabPanel.Items, MRUArrayList.MRUFileName)
            SaveMostRecentFiles(RecentTabItem2.TabPanel.Items, MRUArrayList.MRUFolderName)
            '   SaveMostRecentFiles(recentItemsControl1.MRUFolderList, MRUArrayList.MRUFolderName)
            '   SaveMostRecentFiles(recentItemsControl1.MRUFileList, MRUArrayList.MRUFileName)
            If (System.IO.File.Exists(outputFolder & "/preview.html")) Then
                If Not utility.FileInUse(outputFolder & "/preview.html") Then
                    System.IO.File.Delete(outputFolder & "/preview.html")
                End If
            End If
            If (System.IO.Directory.Exists(PreviewPath)) Then
                My.Computer.FileSystem.DeleteDirectory(PreviewPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub PurgeBackgroundImages()
        Try


            If Not itspunit Is Nothing Then
                Dim bkgImgList As ArrayList = New ArrayList
                For Each pg As mstns.Page In itspunit.PageCol
                    If Not bkgImgList.Contains(pg.BackgroundImage) Then
                        bkgImgList.Add(pg.BackgroundImage)
                    End If
                Next
                Dim files As String()
                Dim File As String
                Dim i As Integer = 0
                files = Directory.GetFiles(bkgFolder, "*.jpg")
                For Each File In files
                    'Do Something With The File                 
                    If Not bkgImgList.Contains(Path.GetFileName(File)) Then
                        If Not utility.FileInUse(File) Then
                            System.IO.File.Delete(File)
                            i = i + 1
                        End If
                    End If
                Next
                files = Directory.GetFiles(bkgFolder, "*.png")
                For Each File In files
                    'Do Something With The File                 
                    If Not bkgImgList.Contains(Path.GetFileName(File)) Then
                        If Not utility.FileInUse(File) Then
                            System.IO.File.Delete(File)
                            i = i + 1
                        End If
                    End If
                Next
                MsgBox(i.ToString() & " files removed from background image folder.")
                UpdateBkgImageLibraries()
            End If

        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub PurgeObjectImages()
        Try
            If Not itspunit Is Nothing Then
                Dim objImgList As ArrayList = New ArrayList
                For Each pg As mstns.Page In itspunit.PageCol
                    For Each obj As mstns.Object_ In pg.ObjectCol
                        If Not objImgList.Contains(obj.StandardImage) Then
                            objImgList.Add(obj.StandardImage)
                        End If
                        If Not objImgList.Contains(obj.MouseEnterImage) Then
                            objImgList.Add(obj.MouseEnterImage)
                        End If
                        If Not objImgList.Contains(obj.MouseDownImage) Then
                            objImgList.Add(obj.MouseDownImage)
                        End If
                        If Not objImgList.Contains(obj.MouseUpImage) Then
                            objImgList.Add(obj.MouseUpImage)
                        End If
                    Next
                Next
                Dim files As String()
                Dim File As String
                Dim i As Integer = 0
                files = Directory.GetFiles(imageFolder, "*.jpg")
                For Each File In files
                    'Do Something With The File                 
                    If Not objImgList.Contains(Path.GetFileName(File)) Then
                        If Not utility.FileInUse(File) Then
                            System.IO.File.Delete(File)
                            i = i + 1
                        End If
                    End If
                Next
                files = Directory.GetFiles(imageFolder, "*.png")
                For Each File In files
                    'Do Something With The File                 
                    If Not objImgList.Contains(Path.GetFileName(File)) Then
                        If Not utility.FileInUse(File) Then
                            System.IO.File.Delete(File)
                            i = i + 1
                        End If
                    End If
                Next
                MsgBox(i.ToString() & " files removed from object image folder.")
                UpdateImageList()
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
        End Try
    End Sub
#End Region
#Region "Settings"
    Public Function SetImageEditor() As String
        DoRefreshOnActivate = False
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        Dim imageEditorExe As String = ""
        dlg.Filter = "Executable files|*.exe;"
        dlg.Title = "Choose Image Editor"
        dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            imageEditorExe = dlg.FileName
            My.Settings.ImageEditor = imageEditorExe
        End If
        Return imageEditorExe
    End Function
#End Region
#Region "Objects"
    Public Function GetNextObjectName(ByVal Prefix As String) As String
        If (Prefix = "Image" Or Prefix = "Video") And selectedImageName <> "" Then
            Dim str As String = Path.GetFileNameWithoutExtension(imageFolder & "\" & selectedImageName)
            Prefix = utility.TidyFileName(str)
        End If
        Dim i As Integer = 1
        Try
            If itspunit.PageCol(selectedPageIndex).ObjectCol.Count > 0 Then
                For Each obj As mstns.Object_ In itspunit.PageCol(selectedPageIndex).ObjectCol
                    If obj.ObjectName.StartsWith(Prefix) Then
                        Dim sMaybeInt As String = obj.ObjectName.Substring(obj.ObjectName.LastIndexOf("-") + 1)
                        Dim myi As Integer
                        If Integer.TryParse(sMaybeInt, myi) Then
                            If CInt(sMaybeInt) >= i Then
                                i = CInt(sMaybeInt) + 1
                            End If
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
        Return Prefix + "-" + i.ToString()
    End Function
    Public Sub AddArrowImageOnce()
        Try
            'Checks if the standard arrow image exists in the imageFolder and adds it if not:
            If imageFolder <> "" Then
                If (Not System.IO.File.Exists(imageFolder & "\Arrow_Right.png")) Then
                    My.Resources.Arrow_Right.Save(imageFolder & "\Arrow_Right.png")
                    My.Resources.Arrow_Down.Save(imageFolder & "\Arrow_Down.png")
                    My.Resources.Arrow_Left.Save(imageFolder & "\Arrow_Left.png")
                    My.Resources.Arrow_Up.Save(imageFolder & "\Arrow_Up.png")
                End If
            End If
            'Enable the crosshair and image mask in the preview window:
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub UpdateObjectsList()
        Try
            Dim imgList As New ImageList
            Dim ilb As DevExpress.XtraEditors.ImageListBoxControl = ObjectManager1.ObjectImageList
            ilb.ImageList = imgList
            Dim imgArList As New ArrayList
            ilb.Items.Clear()
            bIsObjectListReordering = True
            For Each obj As mstns.Object_ In itspunit.PageCol(selectedPageIndex).ObjectCol

                Dim sFilePath As String = ""
                If obj.StandardImage <> "" Then
                    sFilePath = obj.StandardImage
                ElseIf obj.MouseEnterImage <> "" Then
                    sFilePath = obj.MouseEnterImage
                ElseIf obj.MouseDownImage <> "" Then
                    sFilePath = obj.MouseDownImage
                ElseIf obj.MouseUpImage <> "" Then
                    sFilePath = obj.MouseUpImage
                End If
                Dim img As Image
                If sFilePath <> "" And sFilePath <> "," Then
                    Dim fs As System.IO.FileStream
                    fs = New System.IO.FileStream(imageFolder + "\" + sFilePath, IO.FileMode.Open, IO.FileAccess.Read)
                    img = System.Drawing.Image.FromStream(fs)
                    fs.Dispose()
                    Dim nWidth As Integer = img.Width
                    Dim nHeight As Integer = img.Height
                    If nHeight > 16 Then
                        nWidth = CInt((CSng(16) / CSng(nHeight)) * CSng(nWidth))
                        nHeight = 16
                    End If
                    If nWidth > 20 Then
                        nHeight = CInt((CSng(20) / CSng(nWidth)) * CSng(nHeight))
                        nWidth = 20
                    End If
                    imgList.Images.Add(obj.ObjectName, utility.ResizeImage(img, New Size(nWidth, nHeight)))
                ElseIf obj.ObjectName.Contains("Highlight-Box") Then
                    imgList.Images.Add(obj.ObjectName, utility.ResizeImage(My.Resources.HighlightBox, New Size(20, 16)))
                Else
                    img = New Bitmap(20, 16)
                    imgList.Images.Add(obj.ObjectName, img)
                End If
                Dim ilbitem As New DevExpress.XtraEditors.Controls.ImageListBoxItem
                ilbitem.Value = obj.ObjectName
                ilbitem.ImageIndex = imgList.Images.Count - 1
                If ilb.Items.Count > 0 Then
                    If Not ilb.Items(0).Value.ToString = obj.ObjectName Then
                        ilb.Items.Insert(0, ilbitem)
                    End If
                Else
                    ilb.Items.Insert(0, ilbitem)
                End If

            Next
            bIsObjectListReordering = False
            If ilb.Items.Count > 0 Then
                EnableObjectProperties()
                If selectedObjectID <> "" Then
                    ilb.SelectedValue = selectedObjectID


                Else
                    ilb.SelectedIndex = 0
                    selectedObjectID = ilb.SelectedValue.ToString()

                End If
                SelectObject()
                'SelectWebPreviewObject()
            End If
            ilb.ImageList = imgList

        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            If strMsg.Contains("Could not find file") Then
                MsgBox(strMsg & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "This file is referenced by one of the objects on this page. This page will not function correctly until the image is returned to the Image folder.", MsgBoxStyle.OkOnly, "Missing Image File")
            End If

        End Try
    End Sub

    Public Sub EnableObjectProperties()
        ObjectPropertiesTabControl.Enabled = True
        ObjectManager1.Enabled = True
    End Sub
    Public Sub InsertObjectAtPosition(ByVal nHPos As Integer, ByVal nVPos As Integer, ByVal sWidth As String, ByVal sHeight As String)
        Try
            'Check that there is an object type to insert:
            If Not insertObjectType = "" Then
                Dim obj As New mstns.Object_
                'Check the object type and insert:
                Dim arr As Image = My.Resources.Arrow_Right
                Dim arrW As Integer
                Dim arrH As Integer
                If sWidth <> "" And sHeight <> "" Then
                    arrW = CInt(sWidth)
                    arrH = CInt(sHeight)
                Else
                    arrW = arr.Width
                    arrH = arr.Height
                End If
                Dim bHasBehaviour As Boolean = False
                Dim bhs As New mstns.Behaviours
                obj.ObjectName = GetNextObjectName(insertObjectType)
                Select Case insertObjectType
                    Case "Arrow-Right"
                        obj.StandardImage = "Arrow_Right.png"
                        obj.HPos = nHPos - arrW
                        obj.VPos = nVPos - CInt(arrH / 2)
                        obj.Width = arrW
                        obj.Height = arrH
                        Dim bhArrowAnimate As New mstns.AnimateBehaviour
                        'Setup the arrow animation behaviour
                        bhArrowAnimate.StartHPos = -10
                        bhArrowAnimate.EndHPos = 0
                        bhArrowAnimate.StartVPos = 0
                        bhArrowAnimate.EndVPos = 0
                        bhArrowAnimate.LoopCount = -1
                        bhArrowAnimate.AnimationDuration = CDec(0.7)
                        bhs.Animate = bhArrowAnimate
                        bHasBehaviour = True
                    Case "Arrow-Left"
                        obj.StandardImage = "Arrow_Left.png"
                        obj.HPos = nHPos
                        obj.VPos = nVPos - CInt(arrH / 2)
                        'obj.Rotation = 180
                        obj.Width = arrW
                        obj.Height = arrH
                        Dim bhArrowAnimate As New mstns.AnimateBehaviour
                        'Setup the arrow animation behaviour
                        bhArrowAnimate.StartHPos = 10
                        bhArrowAnimate.EndHPos = 0
                        bhArrowAnimate.StartVPos = 0
                        bhArrowAnimate.EndVPos = 0
                        bhArrowAnimate.LoopCount = -1
                        bhArrowAnimate.AnimationDuration = CDec(0.7)
                        bhs.Animate = bhArrowAnimate
                        bHasBehaviour = True
                    Case "Arrow-Up"
                        obj.StandardImage = "Arrow_Up.png"
                        obj.HPos = nHPos - CInt(arrH / 2)
                        obj.VPos = nVPos
                        obj.Width = arrH
                        obj.Height = arrW
                        Dim bhArrowAnimate As New mstns.AnimateBehaviour
                        'Setup the arrow animation behaviour
                        bhArrowAnimate.StartHPos = 0
                        bhArrowAnimate.EndHPos = 0
                        bhArrowAnimate.StartVPos = 10
                        bhArrowAnimate.EndVPos = 0
                        bhArrowAnimate.LoopCount = -1
                        bhArrowAnimate.AnimationDuration = CDec(0.7)
                        bhs.Animate = bhArrowAnimate
                        bHasBehaviour = True
                    Case "Arrow-Down"
                        obj.StandardImage = "Arrow_Down.png"
                        obj.HPos = nHPos - CInt(arrH / 2)
                        obj.VPos = nVPos - arrW
                        obj.Width = arrH
                        obj.Height = arrW
                        Dim bhArrowAnimate As New mstns.AnimateBehaviour
                        'Setup the arrow animation behaviour
                        bhArrowAnimate.StartHPos = 0
                        bhArrowAnimate.EndHPos = 0
                        bhArrowAnimate.StartVPos = -10
                        bhArrowAnimate.EndVPos = 0
                        bhArrowAnimate.LoopCount = -1
                        bhArrowAnimate.AnimationDuration = CDec(0.7)
                        bhs.Animate = bhArrowAnimate
                        bHasBehaviour = True
                    Case "Highlight-Box"
                        obj.HPos = nHPos
                        obj.VPos = nVPos
                        obj.Width = arrW
                        obj.Height = arrH
                        obj.BorderWidth = 2
                        obj.BorderColour = "#D90000"
                        obj.BorderStyle = "solid"
                        obj.Radius = 5
                        obj.BackGroundColour = "#FFFFFF"
                        obj.BackGroundOpacity = 0
                        Dim bhBoxAnimate As New mstns.AnimateBehaviour
                        bhBoxAnimate.StartOpacity = CDec(0.1)
                        bhBoxAnimate.EndOpacity = 1
                        bhBoxAnimate.LoopCount = -1
                        bhBoxAnimate.AnimationDuration = CDec(0.7)
                        bhs.Animate = bhBoxAnimate
                        bHasBehaviour = True
                    Case "Interaction-Area"
                        obj.HPos = nHPos
                        obj.VPos = nVPos
                        obj.Width = arrW
                        obj.Height = arrH
                        obj.BorderWidth = 0
                        obj.BorderStyle = "none"
                        obj.BorderColour = "#000000"
                        obj.BackGroundColour = "#FFFFFF"
                        obj.BackGroundOpacity = 0
                    Case "Text-Area"
                        obj.HPos = nHPos
                        obj.VPos = nVPos
                        obj.Width = arrW
                        obj.Height = arrH
                        obj.BorderWidth = 0
                        obj.BorderStyle = "none"
                        obj.BorderColour = "#000000"
                        obj.BackGroundColour = "#FFFFFF"
                        obj.BackGroundOpacity = 0
                        Dim bhText As New mstns.TextBehaviour
                        bhs.Text_ = bhText
                        bOpenTextEdit = True
                        bHasBehaviour = True
                    Case "Image"
                        obj.HPos = nHPos
                        obj.VPos = nVPos
                        Dim iType As Integer = CInt(radInsertImageType.EditValue)
                        Select Case iType
                            Case 1
                                obj.StandardImage = selectedImageName
                            Case 2
                                obj.MouseEnterImage = selectedImageName
                                obj.UseMouseEnterImage = True
                            Case 3
                                obj.MouseDownImage = selectedImageName
                                obj.UseMouseDownImage = True
                            Case 4
                                obj.MouseUpImage = selectedImageName
                                obj.UseMouseUpImage = True
                        End Select
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(imageFolder + "\" + selectedImageName, IO.FileMode.Open, IO.FileAccess.Read)
                        Dim img As Image
                        img = System.Drawing.Image.FromStream(fs)
                        fs.Dispose()
                        obj.Width = img.Width
                        obj.Height = img.Height
                    Case "Video"
                        obj.HPos = nHPos
                        obj.VPos = nVPos
                        obj.VideoFile = selectedImageName
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(videoFolder + "\" + selectedImageName.Replace(".mp4", ".jpg"), IO.FileMode.Open, IO.FileAccess.Read)
                        Dim img As Image
                        img = System.Drawing.Image.FromStream(fs)
                        fs.Dispose()
                        obj.Width = img.Width
                        obj.Height = img.Height
                    Case Else
                        Exit Sub
                End Select
                'Add the constructed behaviours to the behaviours collection:
                If bHasBehaviour Then
                    obj.BehaviourCol.Add(bhs)
                End If
                itspunit.PageCol(selectedPageIndex).ObjectCol.Add(obj)
                Modified = True
                ResetRibbonButtons()
                selectedObjectID = obj.ObjectName
                ReloadControls(False, False, False, True, True, False, True, True)
                SelectObject()
                'ObjectManager1.ObjectImageList.SelectedIndex = 0
                'ReloadControls(False, False, False, False, False, False, True, True)
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Function GetObjectByName(ByVal sName As String) As mstns.Object_
        If Not itspunit Is Nothing Then
            Dim pg As mstns.Page = itspunit.PageCol(selectedPageIndex)

            For Each obj As mstns.Object_ In pg.ObjectCol
                If obj.ObjectName = sName Then
                    Return obj
                    Exit Function
                End If
            Next
        End If
        Return Nothing
    End Function
    Public Sub ShowHideObjectProperties(ByVal bShow As Boolean)
        ObjectPropertiesTabControl.TabPages.Item(1).PageVisible = bShow
        ObjectPropertiesTabControl.TabPages.Item(2).PageVisible = bShow
        ObjectPropertiesTabControl.TabPages.Item(3).PageVisible = bShow
        ObjectProperties1.Enabled = bShow
        lcgObjectPropertiesBackground.Enabled = bShow
        lcgObjectPropertiesBorder.Enabled = bShow
        lcgObjectpropertiesImages.Enabled = bShow
    End Sub
    Public Sub ShowHideVideoProperties(ByVal bShow As Boolean)
        ObjectPropertiesTabControl.TabPages.Item(4).PageVisible = bShow
        lcgObjectPropertiesVideo.Enabled = bShow
    End Sub
    Public Sub SelectObject(Optional ByVal setSelected As Boolean = True)
        Try
            Dim sId As String = selectedObjectID
            If setSelected Then
                SelectWebPreviewObject()
            End If

            allowPreview = False
            ObjectManager1.ObjectImageList.SelectedValue = sId
            Dim obj As mstns.Object_ = GetObjectByName(sId)
            If Not obj Is Nothing Then
                If obj.VideoFile = "" Then
                    ShowHideVideoProperties(False)
                    ShowHideObjectProperties(True)
                Else
                    ShowHideVideoProperties(True)
                    ShowHideObjectProperties(False)
                End If
                'StandardImageGalleryEdit.CheckedItems.Clear()
                'HoverImageGalleryEdit.CheckedItems.Clear()
                'MouseDownImageGalleryEdit.CheckedItems.Clear()
                'MouseUpImageGalleryEdit.CheckedItems.Clear()
                StandardImageGalleryEdit.EditValue = "None"
                HoverImageGalleryEdit.EditValue = "None"
                MouseDownImageGalleryEdit.EditValue = "None"
                MouseUpImageGalleryEdit.EditValue = "None"
                cbVideoAutoPlay.Checked = obj.VideoAutoplay
                PopulatePagesDropDown(cbxVideoGotoOnFinish)
                cbxVideoGotoOnFinish.SelectedItem = obj.VideoFinishGoToPage
                ObjectProperties1.tbObjName.Text = sId
                ObjectProperties1.spinHeight.Value = obj.Height
                ObjectProperties1.spinWidth.Value = obj.Width
                ObjectProperties1.spinXPos.Value = obj.HPos
                ObjectProperties1.spinYPos.Value = obj.VPos
                ObjectProperties1.cbStartVisible.Checked = obj.StartVisible
                ObjectProperties1.cbStartOpaque.Checked = obj.StartOpaque
                ObjectManager1.cbtnHide.Checked = Not (obj.EditorVisible)
                cbxBorderStyle.EditValue = obj.BorderStyle
                spinBorderOpacity.Value = obj.BorderOpacity
                spinBorderWidth.Value = CInt(obj.BorderWidth)
                spinRadius.Value = obj.Radius
                BorderColourPicker.EditValue = obj.BorderColour
                ObjBackgroundColourPicker.EditValue = obj.BackGroundColour
                spinBackgroundOpacity.Value = obj.BackGroundOpacity

                Dim si As String = obj.StandardImage

                For Each gal As GalleryItem In StandardImageGalleryEdit.Properties.Gallery.Groups(0).Items
                    gal.Checked = False
                    If gal.Value.ToString() = si Then
                        StandardImageGalleryEdit.Properties.Gallery.SetItemCheck(gal, True, True)
                        Exit For
                    End If
                Next
                'If si = "" Then
                '    si = "None"
                'End If
                StandardImageGalleryEdit.EditValue = si

                si = obj.MouseEnterImage
                For Each gal As GalleryItem In HoverImageGalleryEdit.Properties.Gallery.Groups(0).Items
                    'gal.Checked = False
                    If gal.Value.ToString() = si Then
                        HoverImageGalleryEdit.Properties.Gallery.SetItemCheck(gal, True, True)
                        'gal.Checked = True
                        Exit For
                    End If
                Next
                'If si = "" Then
                '    si = "None"
                'End If
                HoverImageGalleryEdit.EditValue = si
                si = obj.MouseDownImage

                For Each gal As GalleryItem In MouseDownImageGalleryEdit.Properties.Gallery.Groups(0).Items
                    'gal.Checked = False
                    If gal.Value.ToString() = si Then
                        gal.Checked = True
                        Exit For
                    End If
                Next
                'If si = "" Then
                '    si = "None"
                'End If
                MouseDownImageGalleryEdit.EditValue = si
                si = obj.MouseUpImage
                For Each gal As GalleryItem In MouseUpImageGalleryEdit.Properties.Gallery.Groups(0).Items
                    'gal.Checked = False
                    If gal.Value.ToString() = si Then
                        gal.Checked = True
                        Exit For
                    End If
                Next
                'If si = "" Then
                '    si = "None"
                'End If
                MouseUpImageGalleryEdit.EditValue = si



                EnableObjectProperties()
                UpdateBehaviourList()
                If setSelected Then
                    selectedObjectType = "Object"
                End If
            End If
            allowPreview = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub SelectWebPreviewObject()
        Try
            If Not wbPagePreview.Document Is Nothing And Not bIsObjectListReordering Then
                wbPagePreview.Document.InvokeScript("SelectObject", {selectedObjectID})
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub UpdateWebPreviewObjectPosition()
        Try
            If Not wbPagePreview.Document Is Nothing And allowPreview Then
                wbPagePreview.Document.InvokeScript("PositionObject", {selectedObjectID, CInt(ObjectProperties1.spinHeight.Value), CInt(ObjectProperties1.spinWidth.Value), CInt(ObjectProperties1.spinXPos.Value), CInt(ObjectProperties1.spinYPos.Value)})
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub DeselectWebPreviewObjects()
        Try
            If Not wbPagePreview.Document Is Nothing And allowPreview Then
                insertObjectType = ""
                wbPagePreview.Document.InvokeScript("DeselectObjects")
                ResetRibbonButtons()
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub UpdateTextContent(ByVal sHtml As String)
        Try
            If Not wbPagePreview.Document Is Nothing And allowPreview Then
                wbPagePreview.Document.InvokeScript("SetInnerHTML", {selectedObjectID, sHtml})
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub UpdateSelectedObjectName(ByVal sName As String)
        Try
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            If obj.ObjectName <> sName Then
                If Not obj Is Nothing Then
                    If GetObjectByName(sName) Is Nothing Then
                        If obj.ObjectName <> sName Then
                            obj.ObjectName = sName
                            Modified = True
                            ReloadControls(False, False, False, True, True, False, True, True)
                        End If
                    Else
                        MsgBox("An object with the name " + sName + " already exists on this page. Please enter a name that is unique for this page.", MsgBoxStyle.Exclamation, "Object Name Already Exists")
                        ObjectProperties1.tbObjName.Text = selectedObjectID
                    End If
                End If
            End If
            SelectWebPreviewObject()
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub UpdateSelectedObjectProperty(ByVal sPropertyName As String, ByVal sNewValue As String)
        Try
            If selectedObjectID = "" And ObjectManager1.ObjectImageList.ItemCount > 0 Then
                selectedObjectID = ObjectManager1.ObjectImageList.SelectedValue.ToString()
            End If
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            Dim bMod As Boolean = False
            If Not obj Is Nothing Then
                Select Case sPropertyName
                    Case "Height"
                        If Not obj.Height = CInt(sNewValue) Then
                            obj.Height = CInt(sNewValue)
                            bMod = True
                        End If

                    Case "Width"
                        If Not obj.Width = CInt(sNewValue) Then
                            obj.Width = CInt(sNewValue)
                            bMod = True
                        End If

                    Case "HPos"
                        If Not obj.HPos = CInt(sNewValue) Then
                            obj.HPos = CInt(sNewValue)
                            bMod = True
                        End If
                    Case "VPos"
                        If Not obj.VPos = CInt(sNewValue) Then
                            obj.VPos = CInt(sNewValue)
                            bMod = True
                        End If
                    Case "StartVisible"
                        If Not obj.StartVisible = CBool(sNewValue) Then
                            obj.StartVisible = CBool(sNewValue)
                            bMod = True
                        End If
                    Case "StartOpaque"
                        If Not obj.StartOpaque = CBool(sNewValue) Then
                            obj.StartOpaque = CBool(sNewValue)
                            bMod = True
                        End If
                End Select
            End If
            If bMod Then
                Modified = True
                UpdateWebPreviewObjectPosition()
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Public Sub DeleteSelectedObject(ByVal bWarn As Boolean)
        If bWarn Then
            If MsgBox("Are you sure that you wish to delete the currently selected object?", MsgBoxStyle.OkCancel, "Delete Object?") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
        End If
        Try
            Dim objIx As Integer = (ObjectManager1.ObjectImageList.Items.Count - 1) - ObjectManager1.ObjectImageList.SelectedIndex
            If objIx >= 0 And objIx < itspunit.PageCol(selectedPageIndex).ObjectCol.Count Then
                Dim pg As mstns.Page = itspunit.PageCol(selectedPageIndex)
                pg.ObjectCol.RemoveAt(objIx)
                Modified = True
                'RefreshPage()
                'UpdateObjectsList()
                If ((ObjectManager1.ObjectImageList.Items.Count - 1) - objIx - 1) > 0 Then
                    selectedObjectID = ObjectManager1.ObjectImageList.Items.Item((ObjectManager1.ObjectImageList.Items.Count - 1) - objIx - 1).Value.ToString()
                End If
                ReloadControls(False, False, False, True, True, False, True, True)
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub ReorderObject(ByVal Direction As String)
        Try
            Dim objName As String = ObjectManager1.ObjectImageList.SelectedValue.ToString()
            Dim objIx As Integer = (ObjectManager1.ObjectImageList.Items.Count - 1) - ObjectManager1.ObjectImageList.SelectedIndex
            Dim pg As mstns.Page = itspunit.PageCol(selectedPageIndex)
            Dim obj As mstns.Object_ = pg.ObjectCol.Item(objIx)
            Dim changed As Boolean = False
            bIsObjectListReordering = True
            Select Case Direction
                Case "Down"
                    If objIx > 0 Then
                        pg.ObjectCol.RemoveAt(objIx)
                        pg.ObjectCol.Insert(objIx - 1, obj)
                        changed = True
                        'objIx = objIx - 1
                    End If
                Case "Up"
                    If objIx < pg.ObjectCol.Count - 1 Then
                        pg.ObjectCol.RemoveAt(objIx)
                        pg.ObjectCol.Insert(objIx + 1, obj)
                        changed = True
                        'objIx = objIx + 1
                    End If
                Case "Bottom"
                    If objIx > 0 Then
                        pg.ObjectCol.RemoveAt(objIx)
                        pg.ObjectCol.Insert(0, obj)
                        changed = True
                        'objIx = pg.ObjectCol.Count
                    End If
                Case "Top"
                    If objIx < pg.ObjectCol.Count - 1 Then
                        pg.ObjectCol.RemoveAt(objIx)
                        pg.ObjectCol.Insert(pg.ObjectCol.Count, obj)
                        changed = True
                        'objIx = 0
                    End If
            End Select

            If changed Then
                Modified = True
                ReloadControls(False, False, False, True, True, False, True, True)

                'ObjectManager1.ObjectImageList.SelectedIndex = objIx
            End If
            bIsObjectListReordering = False
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub ToggleObjectPreviewVisibility(ByVal Checked As Boolean)
        Try
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.EditorVisible = Not (Checked)
            wbPagePreview.Document.InvokeScript("ToggleObject", {selectedObjectID, Checked})
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
        End Try
    End Sub
    Private Sub StandardImageGalleryEdit_EditValueChanged(sender As Object, e As EventArgs) Handles StandardImageGalleryEdit.EditValueChanged
        Try
            If allowPreview And Not StandardImageGalleryEdit.EditValue Is Nothing Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.StandardImage.Contains(StandardImageGalleryEdit.EditValue.ToString) Then
                        If Not obj.StandardImage = StandardImageGalleryEdit.EditValue.ToString Then
                            If StandardImageGalleryEdit.EditValue.ToString = "None" Then
                                obj.StandardImage = ""
                            Else
                                obj.StandardImage = StandardImageGalleryEdit.EditValue.ToString
                            End If
                            ReloadControls(False, False, False, False, False, False, True, False)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub HoverImageGalleryEdit_EditValueChanged(sender As Object, e As EventArgs) Handles HoverImageGalleryEdit.EditValueChanged
        Try
            If allowPreview And Not HoverImageGalleryEdit.EditValue Is Nothing Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.MouseEnterImage.Contains(HoverImageGalleryEdit.EditValue.ToString) Then
                        If HoverImageGalleryEdit.EditValue.ToString = "None" Then
                            obj.MouseEnterImage = ""
                        Else
                            obj.MouseEnterImage = HoverImageGalleryEdit.EditValue.ToString
                        End If
                        ReloadControls(False, False, False, False, False, False, True, False)
                        Modified = True
                    End If
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub MouseDownImageGalleryEdit_EditValueChanged(sender As Object, e As EventArgs) Handles MouseDownImageGalleryEdit.EditValueChanged
        Try
            If allowPreview And Not MouseDownImageGalleryEdit.EditValue Is Nothing Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.MouseDownImage.Contains(MouseDownImageGalleryEdit.EditValue.ToString) Then
                        If MouseDownImageGalleryEdit.EditValue.ToString = "None" Then
                            obj.MouseDownImage = ""
                        Else
                            obj.MouseDownImage = MouseDownImageGalleryEdit.EditValue.ToString
                        End If
                        ReloadControls(False, False, False, False, False, False, True, False)
                        Modified = True
                    End If
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub MouseUpImageGalleryEdit_EditValueChanged(sender As Object, e As EventArgs) Handles MouseUpImageGalleryEdit.EditValueChanged
        Try
            If allowPreview And Not MouseUpImageGalleryEdit.EditValue Is Nothing Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.MouseUpImage.Contains(MouseUpImageGalleryEdit.EditValue.ToString) Then
                        If MouseUpImageGalleryEdit.EditValue.ToString = "None" Then
                            obj.MouseUpImage = ""
                        Else
                            obj.MouseUpImage = MouseUpImageGalleryEdit.EditValue.ToString
                        End If

                        ReloadControls(False, False, False, False, False, False, True, False)
                        Modified = True
                    End If
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub cbxBorderStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBorderStyle.SelectedIndexChanged
        Try
            If allowPreview Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If obj.BorderStyle <> cbxBorderStyle.EditValue.ToString() Then


                        obj.BorderStyle = cbxBorderStyle.EditValue.ToString()
                        'obj.BorderWidth = CInt(spinBorderWidth.Value)
                        'obj.BorderOpacity = CDec(spinBorderOpacity.Value)
                        'obj.BorderColour = utility.ColorToHexString(BorderColourPicker.Color)
                        'obj.Radius = CInt(spinRadius.Value)
                        'obj.BackGroundOpacity = CDec(spinBackgroundOpacity.Value)
                        'obj.BackGroundColour = utility.ColorToHexString(ObjBackgroundColourPicker.Color)
                        ReloadControls(False, False, False, False, False, False, True, False)
                        Modified = True
                    End If
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub spinBorderWidth_EditValueChanged(sender As Object, e As EventArgs) Handles spinBorderWidth.EditValueChanged
        Try
            If allowPreview Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.BorderWidth = CInt(spinBorderWidth.Value) Then
                        obj.BorderWidth = CInt(spinBorderWidth.Value)
                        Modified = True
                        ReloadControls(False, False, False, False, False, False, True, False)
                    End If
                End If

            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub spinBorderOpacity_EditValueChanged(sender As Object, e As EventArgs) Handles spinBorderOpacity.EditValueChanged
        Try
            If allowPreview Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.BorderOpacity = CDec(spinBorderOpacity.Value) Then
                        obj.BorderOpacity = CDec(spinBorderOpacity.Value)
                        Modified = True
                        ReloadControls(False, False, False, False, False, False, True, False)
                    End If
                End If

            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub BorderColourPicker_EditValueChanged(sender As Object, e As EventArgs) Handles BorderColourPicker.EditValueChanged
        Try
            If allowPreview Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.BorderColour = utility.ColorToHexString(BorderColourPicker.Color) Then
                        obj.BorderColour = utility.ColorToHexString(BorderColourPicker.Color)
                        Modified = True
                        ReloadControls(False, False, False, False, False, False, True, False)
                    End If
                End If

            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub spinRadius_EditValueChanged(sender As Object, e As EventArgs) Handles spinRadius.EditValueChanged
        Try
            If allowPreview Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.Radius = CInt(spinRadius.Value) Then
                        obj.Radius = CInt(spinRadius.Value)
                        Modified = True
                        ReloadControls(False, False, False, False, False, False, True, False)
                    End If
                End If

            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub spinBackgroundOpacity_EditValueChanged(sender As Object, e As EventArgs) Handles spinBackgroundOpacity.EditValueChanged
        Try
            If allowPreview Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.BackGroundOpacity = CDec(spinBackgroundOpacity.Value) Then
                        obj.BackGroundOpacity = CDec(spinBackgroundOpacity.Value)
                        Modified = True
                        ReloadControls(False, False, False, False, False, False, True, False)
                    End If
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub ObjBackgroundColourPicker_EditValueChanged(sender As Object, e As EventArgs) Handles ObjBackgroundColourPicker.EditValueChanged
        Try
            If allowPreview Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.BackGroundColour = utility.ColorToHexString(ObjBackgroundColourPicker.Color) Then
                        obj.BackGroundColour = utility.ColorToHexString(ObjBackgroundColourPicker.Color)
                        Modified = True
                        ReloadControls(False, False, False, False, False, False, True, False)
                    End If
                End If

            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub cbxVideoGotoOnFinish_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxVideoGotoOnFinish.SelectedIndexChanged
        Try
            If allowPreview Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.VideoFinishGoToPage = cbxVideoGotoOnFinish.SelectedItem.ToString Then
                        obj.VideoFinishGoToPage = cbxVideoGotoOnFinish.SelectedItem.ToString
                        Modified = True
                    End If
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub cbVideoAutoPlay_CheckedChanged(sender As Object, e As EventArgs) Handles cbVideoAutoPlay.CheckedChanged
        Try
            If allowPreview Then
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then
                    If Not obj.VideoAutoplay = cbVideoAutoPlay.Checked Then
                        obj.VideoAutoplay = cbVideoAutoPlay.Checked
                        Modified = True
                        ReloadControls(False, False, False, False, False, False, True, False)
                    End If
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub spinBackgroundOpacity_GotFocus(sender As Object, e As EventArgs) Handles spinBackgroundOpacity.GotFocus, spinBorderOpacity.GotFocus, spinBorderWidth.GotFocus, spinRadius.GotFocus
        allowKeys = False
    End Sub

    Private Sub spinBackgroundOpacity_LostFocus(sender As Object, e As EventArgs) Handles spinBackgroundOpacity.LostFocus, spinBorderOpacity.LostFocus, spinBorderWidth.LostFocus, spinRadius.LostFocus
        allowKeys = True
    End Sub
#End Region
#Region "Behaviours"
    Public Sub UpdateBehaviourList()
        Try
            If Not itspunit Is Nothing Then
                listBehaviours.Items.Clear()
                Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
                If Not obj Is Nothing Then

                    For Each bh As mstns.Behaviours In obj.BehaviourCol
                        If Not bh.Animate Is Nothing Then
                            listBehaviours.Items.Add("Animation")
                        End If
                        If Not bh.CustomCSS Is Nothing Then
                            listBehaviours.Items.Add("Custom CSS")
                        End If
                        If Not bh.CustomJavaScript Is Nothing Then
                            listBehaviours.Items.Add("Custom JavaScript")
                        End If
                        If Not bh.Drag Is Nothing Then
                            listBehaviours.Items.Add("Drag")
                        End If
                        If Not bh.FollowMouse Is Nothing Then
                            listBehaviours.Items.Add("Follow Mouse")
                        End If
                        If Not bh.MouseEvent Is Nothing Then
                            listBehaviours.Items.Add("Mouse Interaction")
                        End If
                        If Not bh.MousePointer Is Nothing Then
                            listBehaviours.Items.Add("Mouse Pointer")
                        End If
                        If Not bh.Resize Is Nothing Then
                            listBehaviours.Items.Add("Resize")
                        End If
                        If Not bh.Text_ Is Nothing Then
                            listBehaviours.Items.Add("Text Interaction")
                        End If
                        If Not bh.KeyboardShortcut Is Nothing Then
                            listBehaviours.Items.Add("Keyboard Shortcut")
                        End If
                        If Not bh.Password Is Nothing Then
                            listBehaviours.Items.Add("Password")
                        End If
                        If Not bh.Spinner Is Nothing Then
                            listBehaviours.Items.Add("Spinner Control")
                        End If
                        If Not bh.Tooltip Is Nothing Then
                            listBehaviours.Items.Add("Tooltip")
                        End If
                        If Not bh.Selectable Is Nothing Then
                            listBehaviours.Items.Add("Selectable")
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub listBehaviours_Click(sender As Object, e As EventArgs) Handles listBehaviours.Click
        selectedObjectType = "Behaviour"
    End Sub


    Private Sub listBehaviours_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBehaviours.SelectedIndexChanged
        Try
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            If scrollableBehaviourProps.Controls.Count > 0 Then
                scrollableBehaviourProps.Controls(0).Dispose()
            End If
            scrollableBehaviourProps.Controls.Clear()
            If Not obj Is Nothing Then
                Dim bIx As Integer = listBehaviours.SelectedIndex
                If bIx >= 0 Then
                    Dim bh As mstns.Behaviours = obj.BehaviourCol(bIx)
                    If Not bh Is Nothing Then
                        allowPreview = False
                        currentBehaviour = bh

                        Select Case listBehaviours.SelectedValue.ToString()
                            Case "Animation"
                                If Not bh.Animate Is Nothing Then
                                    Dim abp As New PropertiesAnimateBehaviour
                                    'Populate drop down lists in property control:
                                    PopulatePagesDropDown(abp.ddPageOnFinish)
                                    'Load values into controls in property control:
                                    abp.spinAnimationDuration.EditValue = bh.Animate.AnimationDuration
                                    abp.spinEndHPos.EditValue = bh.Animate.EndHPos
                                    abp.spinEndOpacity.EditValue = bh.Animate.EndOpacity
                                    abp.spinEndVPos.EditValue = bh.Animate.EndVPos
                                    abp.spinLoopCount.EditValue = bh.Animate.LoopCount
                                    abp.spinStartDelay.EditValue = bh.Animate.AnimationDelay
                                    abp.spinStartHPos.EditValue = bh.Animate.StartHPos
                                    abp.spinStartOpacity.EditValue = bh.Animate.StartOpacity
                                    abp.spinStartVPos.EditValue = bh.Animate.StartVPos
                                    abp.cbAutoStart.Checked = CBool(bh.Animate.AutoStart)
                                    For Each item As String In abp.ddPageOnFinish.Properties.Items
                                        If bh.Animate.GoToPageOnFinish = item Then
                                            abp.ddPageOnFinish.EditValue = bh.Animate.GoToPageOnFinish
                                        End If
                                    Next
                                    abp.Dock = DockStyle.Fill
                                    'Add property control to behaviour properties panel scrollable area:
                                    scrollableBehaviourProps.Controls.Add(abp)
                                End If
                                'Create property control:

                            Case "Custom CSS"
                                If Not bh.CustomCSS Is Nothing Then
                                    Dim pccss As New PropertiesCustomCssBehaviour
                                    pccss.meditStyleString.EditValue = bh.CustomCSS.StyleString
                                    pccss.meditCSSClasses.EditValue = bh.CustomCSS.CSSClasses
                                    pccss.Dock = DockStyle.Fill
                                    scrollableBehaviourProps.Controls.Add(pccss)
                                End If
                            Case "Custom JavaScript"
                                'Create property control:
                                If Not bh.CustomJavaScript Is Nothing Then
                                    Dim pcjs As New PropertiesCustomJavaScriptBehaviour
                                    'Load values into controls in property control:
                                    pcjs.meditJSString.EditValue = bh.CustomJavaScript.JavaScriptString
                                    pcjs.Dock = DockStyle.Fill
                                    'Add property control to behaviour properties panel scrollable area:
                                    scrollableBehaviourProps.Controls.Add(pcjs)
                                End If
                            Case "Drag"
                                'Create property control:
                                If Not bh.Drag Is Nothing Then
                                    Dim pdb As New PropertiesDragBehaviour
                                    'Populate drop down lists in property control:
                                    PopulateObjectsDropDown(pdb.cbxTargetObject)
                                    PopulatePagesDropDown(pdb.cbxPageCorrect)
                                    PopulatePagesDropDown(pdb.cbxPageWrong)
                                    PopulateObjectsMultiSelect(pdb.cbxCheckShowObjects)
                                    PopulateObjectsDropDown(pdb.cbxLimitToObject)
                                    'Load values into controls in property control:
                                    pdb.cbxDirection.SelectedItem = bh.Drag.Direction
                                    pdb.cbxLimitToObject.SelectedItem = bh.Drag.LimitToObject
                                    pdb.cbNavigateOnMouseDown.Checked = bh.Drag.NavigateMouseDown
                                    pdb.cbxTargetObject.SelectedItem = bh.Drag.TargetObject
                                    pdb.cbxDragCursor.SelectedItem = bh.Drag.DragCursor
                                    pdb.spinSnapWidth.EditValue = bh.Drag.SnapGridWidth
                                    pdb.spinSnapHeight.EditValue = bh.Drag.SnapGridHeight
                                    pdb.cbxDropType.SelectedItem = bh.Drag.DropType
                                    pdb.cbSnapTo.Checked = bh.Drag.SnapToTarget
                                    pdb.cbAnimatedReset.Checked = bh.Drag.AnimatedReset
                                    For Each item As String In pdb.cbxPageCorrect.Properties.Items
                                        If bh.Drag.GoToPageCorrect = item Then
                                            pdb.cbxPageCorrect.EditValue = bh.Drag.GoToPageCorrect
                                        End If
                                    Next
                                    For Each item As String In pdb.cbxPageWrong.Properties.Items
                                        If bh.Drag.GoToPageIncorrect = item Then
                                            pdb.cbxPageWrong.EditValue = bh.Drag.GoToPageIncorrect
                                        End If
                                    Next
                                    pdb.cbReset.Checked = bh.Drag.ResetOnMouseUp
                                    pdb.cbxCheckShowObjects.EditValue = bh.Drag.ShowObjectsWhenDragOver.ToString()
                                    pdb.cbHideOnLeave.Checked = bh.Drag.Toggle
                                    pdb.cbAssessCorrect.Checked = bh.Drag.AssessmentCorrect
                                    pdb.cbAssessMarkWrong.Checked = bh.Drag.AssessmentIncorrect
                                    pdb.Dock = DockStyle.Fill
                                    'Add property control to behaviour properties panel scrollable area:
                                    scrollableBehaviourProps.Controls.Add(pdb)
                                End If
                            Case "Follow Mouse"
                                If Not bh.FollowMouse Is Nothing Then
                                    'Create property control:
                                    Dim pfm As New PropertiesFollowMousePointerBehaviour
                                    'Load values into controls in property control:
                                    pfm.spinOffsetHPixels.EditValue = bh.FollowMouse.OffsetHPixels
                                    pfm.spinOffsetVPixels.EditValue = bh.FollowMouse.OffsetVPixels
                                    pfm.Dock = DockStyle.Fill
                                    'Add property control to behaviour properties panel scrollable area:
                                    scrollableBehaviourProps.Controls.Add(pfm)

                                End If

                            Case "Mouse Interaction"
                                If Not bh.MouseEvent Is Nothing Then
                                    'Create property control:
                                    Dim pmib As New PropertiesMouseInteractionBehaviour
                                    'Populate drop down lists in property control:
                                    PopulatePagesDropDown(pmib.cbxGotoPage)
                                    PopulateObjectsMultiSelect(pmib.cbxCheckShowObjects)
                                    PopulateObjectsMultiSelect(pmib.cbxCheckHideObjects)
                                    PopulateObjectsMultiSelect(pmib.cbxCheckAnimate)
                                    'Load values into controls in property control:
                                    pmib.cbxMouseEvent.SelectedItem = bh.MouseEvent.MouseEvent
                                    For Each item As String In pmib.cbxGotoPage.Properties.Items
                                        If bh.MouseEvent.GoToPage = item Then
                                            pmib.cbxGotoPage.EditValue = bh.MouseEvent.GoToPage
                                        End If
                                    Next
                                    pmib.cbPreventFocus.Checked = bh.MouseEvent.PreventMouseDownFocus
                                    pmib.cbJudgeTask.Checked = bh.MouseEvent.JudgeTask
                                    pmib.cbxCheckShowObjects.EditValue = bh.MouseEvent.ShowObjects.ToString()
                                    pmib.cbxCheckHideObjects.EditValue = bh.MouseEvent.HideObjects.ToString()
                                    pmib.cbxCheckAnimate.EditValue = bh.MouseEvent.AnimateObjects.ToString()
                                    pmib.cbToggle.Checked = bh.MouseEvent.Toggle
                                    pmib.cbAssessCorrect.Checked = bh.MouseEvent.AssessmentCorrect
                                    pmib.cbAssessWrong.Checked = bh.MouseEvent.AssessmentIncorrect
                                    pmib.Dock = DockStyle.Fill
                                    'Add property control to behaviour properties panel scrollable area:
                                    scrollableBehaviourProps.Controls.Add(pmib)
                                End If

                            Case "Mouse Pointer"
                                If Not bh.MousePointer Is Nothing Then
                                    'Create property control:
                                    Dim pmpb As New PropertiesChangeMousePointerBehaviour
                                    'Populate drop down lists in property control:
                                    'PopulateImageCombo(pmpb.cbxCustomPointerImage)
                                    PopulateCursorDropDown(pmpb.cbxCustomPointerImage)
                                    'Load values into controls in property control:
                                    pmpb.cbxMouseInCursor.SelectedItem = bh.MousePointer.MouseInPointer
                                    pmpb.cbxMouseDownCursor.SelectedItem = bh.MousePointer.MouseDownPointer
                                    pmpb.cbxCustomPointerImage.EditValue = bh.MousePointer.CustomPointerImage
                                    'If Not obj.MouseEnterImage = "" Then
                                    '    For Each gal As GalleryItem In pmpb.galCustomCursor.Properties.Gallery.Groups(0).Items
                                    '        If gal.Value.ToString() = bh.MousePointer.CustomPointerImage Then
                                    '            gal.Checked = True
                                    '            pmpb.galCustomCursor.EditValue = Replace(Replace(bh.MousePointer.CustomPointerImage, ".jpg", ""), ".png", "")
                                    '            Exit For
                                    '        End If
                                    '    Next
                                    'End If
                                    pmpb.Dock = DockStyle.Fill
                                    'Add property control to behaviour properties panel scrollable area:
                                    scrollableBehaviourProps.Controls.Add(pmpb)
                                End If

                            Case "Resize"
                                If Not bh.Resize Is Nothing Then
                                    'Create property control:
                                    Dim prb As New PropertiesResizeBehaviour
                                    'Populate drop down lists in property control:
                                    PopulatePagesDropDown(prb.cbxGotoPageCorrect)
                                    PopulatePagesDropDown(prb.cbxGotoPageIncorrect)
                                    'Load values into controls in property control:
                                    prb.cbxResizeType.SelectedItem = bh.Resize.ResizeType
                                    PopulateCursorDropDown(prb.cbxCustomCursor)
                                    prb.cbxCustomCursor.SelectedItem = bh.Resize.CustomCursor
                                    prb.spinMaxWidth.EditValue = bh.Resize.MaxWidth
                                    prb.spinMaxHeight.EditValue = bh.Resize.MaxHeight
                                    prb.spinMinReqWidth.EditValue = bh.Resize.MinRequiredWidth
                                    prb.spinMinReqHeight.EditValue = bh.Resize.MinRequiredHeight
                                    prb.spinMaxReqWidth.EditValue = bh.Resize.MaxRequiredWidth
                                    prb.spinMaxReqHeight.EditValue = bh.Resize.MaxRequiredHeight
                                    prb.spinSnapWidth.EditValue = bh.Resize.SnapGridWidth
                                    prb.spinSnapHeight.EditValue = bh.Resize.SnapGridHeight
                                    For Each item As String In prb.cbxGotoPageCorrect.Properties.Items
                                        If bh.Resize.GoToPageCorrect = item Then
                                            prb.cbxGotoPageCorrect.EditValue = bh.Resize.GoToPageCorrect
                                        End If
                                    Next
                                    For Each item As String In prb.cbxGotoPageIncorrect.Properties.Items
                                        If bh.Resize.GoToPageIncorrect = item Then
                                            prb.cbxGotoPageIncorrect.EditValue = bh.Resize.GoToPageIncorrect
                                        End If
                                    Next
                                    prb.cbAssessCorrect.Checked = bh.Resize.AssessmentCorrect
                                    prb.cbAssessIncorrect.Checked = bh.Resize.AssessmentIncorrect
                                    prb.Dock = DockStyle.Fill
                                    'Add property control to behaviour properties panel scrollable area:
                                    scrollableBehaviourProps.Controls.Add(prb)
                                End If
                            Case "Text Interaction"
                                If Not bh.Text_ Is Nothing Then
                                    'Create property control:
                                    Dim ptib As New PropertiesTextBehaviour
                                    'Populate drop down lists in property control:
                                    PopulatePagesDropDown(ptib.cbxGoToPage)
                                    PopulatePagesDropDown(ptib.cbxGotoPageWrong)
                                    PopulateObjectsDropDown(ptib.cbxSendTextToObject)
                                    'Load values into controls in property control:
                                    ptib.cbRetainPrev.Checked = bh.Text_.RetainPreviousText
                                    ptib.btnStartText.Enabled = Not bh.Text_.RetainPreviousText
                                    ptib.cbIsEditable.Checked = bh.Text_.IsEditable
                                    ptib.cbHasFocus.Checked = bh.Text_.HasFocus
                                    ptib.cbxSendTextToObject.EditValue = bh.Text_.SendTextTargetObject
                                    ptib.spinSelectionStart.EditValue = bh.Text_.SelectionStart
                                    ptib.spinSelectionEnd.EditValue = bh.Text_.SelectionEnd
                                    ptib.spinRequiredSelectionStart.EditValue = bh.Text_.RequiredSelectStart
                                    ptib.spinRequiredSelectionEnd.EditValue = bh.Text_.RequiredSelectEnd
                                    ptib.spinRequiredCharCount.EditValue = bh.Text_.RequiredCharacterCount
                                    ptib.cbJudgeOnKeyup.Checked = bh.Text_.JudgeOnKeyup
                                    ptib.cbJudgeOnReturn.Checked = bh.Text_.JudgeOnReturn
                                    ptib.cbJudgeOnTab.Checked = bh.Text_.JudgeOnTab
                                    ptib.cbIgnoreCase.Checked = bh.Text_.IgnoreCase
                                    ptib.cbJudgeOnSelectionChanged.Checked = bh.Text_.JudgeOnSelectChange
                                    For Each item As String In ptib.cbxGoToPage.Properties.Items
                                        If bh.Text_.GoToPageCorrect = item Then
                                            ptib.cbxGoToPage.EditValue = bh.Text_.GoToPageCorrect
                                        End If
                                    Next
                                    For Each item As String In ptib.cbxGotoPageWrong.Properties.Items
                                        If bh.Text_.GoToPageIncorrect = item Then
                                            ptib.cbxGotoPageWrong.EditValue = bh.Text_.GoToPageIncorrect
                                        End If
                                    Next
                                    ptib.cbAssessCorrect.Checked = bh.Text_.AssessmentCorrect
                                    ptib.cbAssessIncorrect.Checked = bh.Text_.AssessmentIncorrect
                                    ptib.Dock = DockStyle.Fill
                                    'Add property control to behaviour properties panel scrollable area:
                                    scrollableBehaviourProps.Controls.Add(ptib)
                                    allowPreview = True
                                    If bOpenTextEdit Then
                                        bOpenTextEdit = False
                                        ptib.EditStartText()
                                    End If
                                End If
                            Case "Keyboard Shortcut"
                                If Not bh.KeyboardShortcut Is Nothing Then
                                    'Create property control:
                                    Dim pksb As New PropertiesKeyboardShortcutBehaviour
                                    'Populate drop down lists in property control:
                                    PopulatePagesDropDown(pksb.cbxGotoPage)
                                    PopulateObjectsMultiSelect(pksb.cbxCheckShowObjects)
                                    PopulateObjectsMultiSelect(pksb.cbxCheckHideObjects)
                                    PopulateObjectsMultiSelect(pksb.cbxCheckAnimateObjects)
                                    'Load values into controls in property control:
                                    pksb.cbCtrlDown.Checked = bh.KeyboardShortcut.CtrlDown
                                    pksb.cbAltDown.Checked = bh.KeyboardShortcut.AltDown
                                    pksb.cbShiftDown.Checked = bh.KeyboardShortcut.ShiftDown
                                    pksb.tbKeyToPress.Text = bh.KeyboardShortcut.KeyToPress
                                    pksb.cbxSpecialKey.SelectedItem = bh.KeyboardShortcut.SpecialKey
                                    pksb.cbxGotoPage.SelectedItem = bh.KeyboardShortcut.GoToPage
                                    pksb.cbAssessCorrect.Checked = bh.KeyboardShortcut.AssessCorrect
                                    pksb.cbxCheckShowObjects.EditValue = bh.KeyboardShortcut.ShowObjects.ToString()
                                    pksb.cbxCheckHideObjects.EditValue = bh.KeyboardShortcut.HideObjects.ToString()
                                    pksb.cbxCheckAnimateObjects.EditValue = bh.KeyboardShortcut.AnimateObjects.ToString()
                                    pksb.cbToggleVis.Checked = bh.KeyboardShortcut.Toggle
                                    'Add property control to behaviour properties panel scrollable area:
                                    pksb.Dock = DockStyle.Fill
                                    scrollableBehaviourProps.Controls.Add(pksb)
                                End If
                            Case "Password"
                                If Not bh.Password Is Nothing Then
                                    'Create property control:
                                    Dim ppwb As New PropertiesPasswordBehaviour
                                    'Populate drop down lists in property control:
                                    PopulatePagesDropDown(ppwb.cbxGoToPageCorrect)
                                    PopulatePagesDropDown(ppwb.cbxGoToPageIncorrect)
                                    'Load values into controls in property control:
                                    ppwb.tbPasswordReq.EditValue = bh.Password.RequiredPassword
                                    ppwb.cbJudgeOnEnter.Checked = bh.Password.JudgeOnEnter
                                    ppwb.cbJudgeOnKeyup.Checked = bh.Password.JudgeOnKeyup
                                    ppwb.cbJudgeOnTab.Checked = bh.Password.JudgeOnTab
                                    For Each item As String In ppwb.cbxGoToPageCorrect.Properties.Items
                                        If bh.Password.GoToPageCorrect = item Then
                                            ppwb.cbxGoToPageCorrect.EditValue = bh.Password.GoToPageCorrect
                                        End If
                                    Next
                                    For Each item As String In ppwb.cbxGoToPageIncorrect.Properties.Items
                                        If bh.Password.GoToPageIncorrect = item Then
                                            ppwb.cbxGoToPageIncorrect.EditValue = bh.Password.GoToPageIncorrect
                                        End If
                                    Next

                                    ppwb.cbAssessCorrect.Checked = bh.Password.AssessCorrect
                                    ppwb.cbAssessIncorrect.Checked = bh.Password.AssessIncorrect
                                    ppwb.cbHasFocus.Checked = bh.Password.HasFocus
                                    'Add property control to behaviour properties panel scrollable area:
                                    ppwb.Dock = DockStyle.Fill
                                    scrollableBehaviourProps.Controls.Add(ppwb)
                                End If
                            Case "Spinner Control"
                                If Not bh.Spinner Is Nothing Then
                                    'Create property control:
                                    Dim pspb As New PropertiesSpinnerBehaviour
                                    'Populate drop down lists in property control:
                                    PopulateObjectsDropDown(pspb.cbxTextObject)
                                    'Load values into controls in property control:
                                    pspb.cbxDirection.SelectedItem = bh.Spinner.Direction
                                    pspb.cbxTextObject.SelectedItem = bh.Spinner.TextAreaObject
                                    pspb.spinStepSize.EditValue = bh.Spinner.StepSize
                                    pspb.spinDecimalPoints.EditValue = bh.Spinner.DecimalPoints
                                    pspb.spinMinVal.EditValue = bh.Spinner.MinVal
                                    pspb.spinMaxVal.EditValue = bh.Spinner.MaxVal
                                    pspb.txtUnits.EditValue = bh.Spinner.Units
                                    pspb.cbJudgeOnClick.Checked = bh.Spinner.JudgeOnClick
                                    'Add property control to behaviour properties panel scrollable area:
                                    pspb.Dock = DockStyle.Fill
                                    scrollableBehaviourProps.Controls.Add(pspb)
                                End If
                            Case "Tooltip"
                                If Not bh.Tooltip Is Nothing Then
                                    'Create property control:
                                    Dim pttb As New PropertiesTooltipBehaviour
                                    'Populate drop down lists in property control:

                                    'Load values into controls in property control:
                                    pttb.tbTooltipTitle.Text = bh.Tooltip.TooltipTitle
                                    'Add property control to behaviour properties panel scrollable area:
                                    pttb.Dock = DockStyle.Fill
                                    scrollableBehaviourProps.Controls.Add(pttb)
                                End If
                            Case "Selectable"
                                If Not bh.Selectable Is Nothing Then
                                    'Create property control:
                                    Dim psb As New PropertiesSelectableBehaviour
                                    'Populate drop down lists in property control:
                                    'Load values into controls in property control:
                                    psb.cbCorrectWhenSelected.Checked = bh.Selectable.CorrectWhenSelected
                                    psb.cbMultiSelect.Checked = bh.Selectable.MultiSelectEnabled
                                    psb.meSelectedCSS.EditValue = bh.Selectable.SelectedCSS
                                    'Add property control to behaviour properties panel scrollable area:
                                    psb.Dock = DockStyle.Fill
                                    scrollableBehaviourProps.Controls.Add(psb)
                                End If
                        End Select
                        allowPreview = True
                    End If
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub btnAddAnimateBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddAnimateBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhArrowAnimate As New mstns.AnimateBehaviour
            'bhArrowAnimate.StartHPos = -10
            bhs.Animate = bhArrowAnimate
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub btnAddCustomCSSBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddCustomCSSBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhCustomCSS As New mstns.CustomCssBehaviour
            'bhArrowAnimate.StartHPos = -10
            bhs.CustomCSS = bhCustomCSS
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            bhs.CustomCSS.StyleString = "#" & obj.ObjectName & vbCrLf & "{" & vbCrLf & vbCrLf & vbCrLf & "}"
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub btnAddCustomJSBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddCustomJSBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhCustomJS As New mstns.CustomJavaScriptBehaviour
            'bhArrowAnimate.StartHPos = -10
            bhs.CustomJavaScript = bhCustomJS
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            bhs.CustomJavaScript.JavaScriptString = "$('#" & obj.ObjectName & "')"
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub btnAddDragBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddDragBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhDrag As New mstns.DragBehaviour
            'bhArrowAnimate.StartHPos = -10
            bhs.Drag = bhDrag
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub btnAddFollowMouseBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddFollowMouseBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhFollow As New mstns.FollowMouseBehaviour
            'bhArrowAnimate.StartHPos = -10
            bhs.FollowMouse = bhFollow
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub btnAddMouseEventBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddMouseEventBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhMouseEvent As New mstns.MouseInteractionBehaviour
            'bhArrowAnimate.StartHPos = -10
            'override broken default value for goto page:
            If itspunit.Type <> "Learning" Then
                bhMouseEvent.GoToPage = ""
            End If
            bhs.MouseEvent = bhMouseEvent
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub btnAddResizeBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddResizeBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhResize As New mstns.ResizeBehaviour
            'bhArrowAnimate.StartHPos = -10
            bhs.Resize = bhResize
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub btnAddTextBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddTextBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhText As New mstns.TextBehaviour
            'bhArrowAnimate.StartHPos = -10
            bhs.Text_ = bhText
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub btnAddMousePointerBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddMousePointerBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhmp As New mstns.ChangeMousePointerBehaviour
            bhs.MousePointer = bhmp
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub btnAddKeyboardShortcutBH_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddKeyboardShortcutBH.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhks As New mstns.KeyboardShortcutBehaviour
            bhs.KeyboardShortcut = bhks
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub btnPasswordBehaviour_Click(sender As Object, e As EventArgs) Handles btnAddPasswordBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhpw As New mstns.PasswordBehaviour
            bhs.Password = bhpw
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Private Sub btnAddSpinnerBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddSpinnerBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhsp As New mstns.SpinnerBehaviour
            bhs.Spinner = bhsp
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
        End Try
    End Sub
    Private Sub btnAddTooltipBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddTooltipBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhtt As New mstns.TooltipBehaviour
            bhs.Tooltip = bhtt
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
        End Try
    End Sub
    Private Sub btnAddSelectableBehaviour_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddSelectableBehaviour.ItemClick
        Try
            Dim bhs As New mstns.Behaviours
            Dim bhsb As New mstns.SelectableBehaviour
            bhs.Selectable = bhsb
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            obj.BehaviourCol.Add(bhs)
            ReloadControls(False, False, False, False, False, False, False, True)
            listBehaviours.SelectedIndex = listBehaviours.ItemCount - 1
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
        End Try
    End Sub
    Private Sub btnDeleteBehaviour_Click(sender As Object, e As EventArgs) Handles btnDeleteBehaviour.Click
        DeleteSelectedBehaviour(False)
    End Sub
    Public Sub DeleteSelectedBehaviour(ByVal bWarn As Boolean)
        If bWarn Then
            If MsgBox("Are you sure that you wish to delete the currently selected behaviour?", MsgBoxStyle.OkCancel, "Delete Behaviour?") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
        End If
        Try
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            scrollableBehaviourProps.Controls.Clear()
            If Not obj Is Nothing Then
                Dim bIx As Integer = listBehaviours.SelectedIndex
                If bIx >= 0 Then
                    obj.BehaviourCol.RemoveAt(bIx)
                    Modified = True
                    If bIx > 0 Then
                        listBehaviours.SelectedIndex = bIx - 1
                    End If
                    ReloadControls(False, False, False, False, False, False, False, True)
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

#End Region
#Region "HTMLHelpers"
    Public Sub SetInstructionLocation(ByVal nHPos As Integer, ByVal nVPos As Integer)
        Try
            Dim pg As mstns.Page = itspunit.PageCol(selectedPageIndex)
            If Not (pg.InstructionHPos = nHPos) Or Not (pg.InstructionVPos = nVPos) Or Not (PageSettings1.spinX.Value = nHPos) Or Not (PageSettings1.spinY.Value = nVPos) Then
                pg.InstructionHPos = nHPos
                pg.InstructionVPos = nVPos
                PageSettings1.spinX.Value = nHPos
                PageSettings1.spinY.Value = nVPos
                Modified = True
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub SetObjectSize(ByVal sId As String, ByVal nW As Integer, ByVal nH As Integer)
        Try
            Dim obj As mstns.Object_ = GetObjectByName(sId)
            If Not obj Is Nothing Then
                If Not (obj.Width = nW - 4) Or Not (obj.Height = nH - 4) Then
                    selectedObjectID = sId
                    obj.Width = nW - 4
                    obj.Height = nH - 4
                    SelectObject(False)
                    Modified = True
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub SetObjectLocation(ByVal sId As String, ByVal nHPos As Integer, ByVal nVPos As Integer)
        Try
            Dim obj As mstns.Object_ = GetObjectByName(sId)
            If Not obj Is Nothing Then
                If Not (obj.HPos = nHPos + 2) Or Not (obj.VPos = nVPos + 2) Then
                    selectedObjectID = sId
                    obj.HPos = nHPos + 2
                    obj.VPos = nVPos + 2
                    SelectObject(False)
                    Modified = True
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub AddCrosshair()
        Try
            If allowPreview Then
                wbPagePreview.Document.InvokeScript("doCrossHair")
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub AddMarquee()
        Try
            If allowPreview Then
                wbPagePreview.Document.InvokeScript("doMarquee")
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub AddImageCrosshair(ByVal fname As String)
        Try
            If allowPreview Then
                Dim imgpath As String = ""
                If insertObjectType = "Image" Then
                    imgpath = "../images/" & fname
                ElseIf insertObjectType = "Video" Then
                    imgpath = "../videos/" & fname
                End If
                Dim apphtml As String = "<img src=""" & imgpath.Replace(" ", "%20") & """ class=""follow"" id=""followimg"" />"
                wbPagePreview.Document.InvokeScript("doImageCrosshair", {apphtml, Width, Height})
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
#End Region
#Region "KeyboardControl"
    Private Sub CDAMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If allowKeys Then
                If e.Control Then
                    If e.KeyCode = Keys.C Then
                        CopyCurrentSelected()
                    ElseIf e.KeyCode = Keys.X Then
                        CopyCurrentSelected()
                        DeleteSelected()
                    ElseIf e.KeyCode = Keys.V Then
                        PasteClipboard()
                    ElseIf e.KeyCode = Keys.Z Then
                        Undo()
                    ElseIf e.KeyCode = Keys.Y Then
                        Redo()
                    End If
                End If
            End If
            KeyHandler(e.KeyCode)
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub KeyHandler(ByVal e As Keys)
        Try
            If allowKeys Then
                Select Case e
                    Case Keys.Delete
                        DeleteSelected()
                    Case Keys.Up
                        Dim nY As Integer = CInt(ObjectProperties1.spinYPos.Value)
                        If nY > 0 Then
                            ObjectProperties1.spinYPos.Value = CDec(nY - 1)
                            UpdateSelectedObjectProperty("VPos", (nY - 1).ToString)
                        End If
                    Case Keys.Down
                        Dim nY As Integer = CInt(ObjectProperties1.spinYPos.Value)
                        If nY < itspunit.Height Then
                            ObjectProperties1.spinYPos.Value = nY + 1
                            UpdateSelectedObjectProperty("VPos", (nY + 1).ToString)
                        End If
                    Case Keys.Left
                        Dim nX As Integer = CInt(ObjectProperties1.spinXPos.Value)
                        If nX > 0 Then
                            ObjectProperties1.spinXPos.Value = CDec(nX - 1)
                            UpdateSelectedObjectProperty("HPos", (nX - 1).ToString)
                        End If
                    Case Keys.Right
                        Dim nX As Integer = CInt(ObjectProperties1.spinXPos.Value)
                        If nX < itspunit.Height Then
                            ObjectProperties1.spinXPos.Value = nX + 1
                            UpdateSelectedObjectProperty("HPos", (nX + 1).ToString)
                        End If
                    Case Keys.Escape
                        ReloadControls(False, False, False, False, False, False, True, False)
                End Select
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Private Sub wbPagePreview_GotFocus(sender As Object, e As EventArgs) Handles wbPagePreview.GotFocus
        allowKeys = True
    End Sub
    Private Sub wbPagePreview_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles wbPagePreview.PreviewKeyDown
        KeyHandler(e.KeyCode)
    End Sub
    Private Sub btnSizeObjectToImage_Click(sender As Object, e As EventArgs) Handles btnSizeObjectToImage.Click
        Try
            Dim obj As mstns.Object_ = GetObjectByName(selectedObjectID)
            If Not obj Is Nothing Then
                Dim sFilePath As String = ""
                If obj.StandardImage <> "" Then
                    sFilePath = obj.StandardImage
                ElseIf obj.MouseEnterImage <> "" Then
                    sFilePath = obj.MouseEnterImage
                ElseIf obj.MouseDownImage <> "" Then
                    sFilePath = obj.MouseDownImage
                ElseIf obj.MouseUpImage <> "" Then
                    sFilePath = obj.MouseUpImage
                End If
                Dim img As Image
                If sFilePath <> "" Then
                    Dim fs As System.IO.FileStream
                    fs = New System.IO.FileStream(imageFolder + "\" + sFilePath, IO.FileMode.Open, IO.FileAccess.Read)
                    img = System.Drawing.Image.FromStream(fs)
                    fs.Dispose()
                    ObjectProperties1.spinWidth.Value = img.Width
                    ObjectProperties1.spinHeight.Value = img.Height
                    UpdateSelectedObjectProperty("Width", img.Width.ToString())
                    UpdateSelectedObjectProperty("Height", img.Height.ToString())
                End If
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
#End Region
#Region "CutCopyPasteDelete"
    Public Sub DeleteSelected(Optional bWarn As Boolean = True)
        Try
            Select Case selectedObjectType
                Case "Object"
                    DeleteSelectedObject(bWarn)
                Case "Page"
                    DeleteSelectedPage(bWarn)
                Case "Behaviour"
                    DeleteSelectedBehaviour(bWarn)
            End Select
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub CopyCurrentSelected()
        Try
            If Not CDAMain.itspunit Is Nothing Then
                Select Case selectedObjectType
                    Case "Page"
                        Dim selectedPage As mstns.Page = CDAMain.itspunit.PageCol(selectedPageIndex)
                        clipboardObjectType = "Page"
                        Clipboard.SetText(selectedPage.ToXml)
                    Case "Object"
                        Dim selectedObject As mstns.Object_ = GetObjectByName(selectedObjectID)
                        clipboardObjectType = "Object"
                        Clipboard.SetText(selectedObject.ToXml)
                    Case "Behaviour"
                        clipboardObjectType = "Behaviour"
                        Clipboard.SetText(currentBehaviour.ToXml)
                End Select
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub PasteClipboard()
        Try
            Dim txt As String = Clipboard.GetText()
            Select Case clipboardObjectType
                Case "Page"
                    Dim pg As New mstns.Page

                    pg.FromXml(txt)
                    pg.PageName = PageName
                    itspunit.PageCol.Insert(selectedPageIndex + 1, pg)
                    selectedPageIndex = selectedPageIndex + 1
                    ReloadControls(True, False, True, True, True, True, True, True)
                    SelectPage(selectedPageIndex, True)
                Case "Object"
                    Dim obj As New mstns.Object_
                    obj.FromXml(txt)
                    Dim sPref = getPrefix(obj.ObjectName)
                    If sPref = "" Then
                        sPref = obj.ObjectName
                    End If
                    obj.ObjectName = GetNextObjectName(sPref)
                    If selectedPageIndex >= 0 Then
                        itspunit.PageCol(selectedPageIndex).ObjectCol.Add(obj)
                    End If
                    ReloadControls(False, False, False, True, True, True, True, True)
                Case "Behaviour"
                    Dim selectedObject As mstns.Object_ = GetObjectByName(selectedObjectID)
                    Dim bh As New mstns.Behaviours
                    bh.FromXml(txt)
                    If Not selectedObject Is Nothing Then
                        selectedObject.BehaviourCol.Add(bh)
                        ReloadControls(False, False, False, False, False, False, False, True)
                    End If
            End Select
            Modified = True
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Function getPrefix(ByVal sName As String) As String
        Dim sReturn As String = ""
        Try
            If sName.LastIndexOf("-") > 0 Then
                sReturn = sName.Substring(0, sName.LastIndexOf("-"))
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
        End Try
        Return sReturn
    End Function
#End Region
#Region "FormControlState"
    Public Sub ReloadControls(ByVal bPageList As Boolean, ByVal bCurrentPageThumb As Boolean, ByVal bBackGroundImageLists As Boolean, ByVal bObjectList As Boolean, ByVal bObjectProperties As Boolean, ByVal bImageLists As Boolean, ByVal bWebPreview As Boolean, ByVal bBehaviourList As Boolean)
        Try
            If bkgFolder <> "" And Not itspunit Is Nothing Then
                pnlBehaviours.Enabled = True
                rbnPageGroup.Enabled = True
                rbnHomeImages.Enabled = True
                rbnHomeObjectsGroup.Enabled = True
                rbnHmPreviewGroup.Enabled = True
                rbnClipboardGroup.Enabled = True
                wbPagePreview.Visible = True
                pageList1.Visible = True
                ObjectManager1.Enabled = True
                ObjectPropertiesTabControl.Enabled = True
                PageSettings1.Enabled = True
                rbnProjectPage.Visible = True
                rbnViewTab.Visible = True
                bsvSave.Enabled = True
                bsvSaveAsTab.Enabled = True
                bsvPublish.Enabled = True
                bsvCloseDocument.Enabled = True
                bsvSettingsTab.Enabled = True
                btnQATPreview.Enabled = True
                qatBtnSave.Enabled = True
                bsvImport.Enabled = True
            Else
                pnlBehaviours.Enabled = False
                rbnPageGroup.Enabled = False
                rbnHomeImages.Enabled = False
                rbnHomeObjectsGroup.Enabled = False
                rbnHmPreviewGroup.Enabled = False
                rbnClipboardGroup.Enabled = False
                wbPagePreview.Visible = False
                pageList1.Visible = False
                ObjectManager1.Enabled = False
                ObjectPropertiesTabControl.Enabled = False
                PageSettings1.Enabled = False
                rbnProjectPage.Visible = False
                rbnViewTab.Visible = False
                bsvSave.Enabled = False
                bsvSaveAsTab.Enabled = False
                bsvPublish.Enabled = False
                bsvCloseDocument.Enabled = False
                bsvSettingsTab.Enabled = False
                btnQATPreview.Enabled = False
                qatBtnSave.Enabled = False
                bsvImport.Enabled = False
            End If

            If bPageList Then
                UpdatePageList()
            End If
            If bCurrentPageThumb Then
                UpdateCurrentPageThumb()
            End If
            If bBackGroundImageLists Then
                UpdateBkgImageLibraries()
            End If
            If bObjectList Then
                UpdateObjectsList()
            End If
            If bObjectProperties Then
                If selectedObjectType = "Object" Then
                    SelectObject(True)
                Else
                    SelectObject(False)
                End If

            End If
            If bImageLists Then
                UpdateImageList()
            End If
            If bWebPreview And allowPreview Then
                RefreshPage()
            End If
            If bBehaviourList Then
                UpdateBehaviourList()
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub UpdateProjectTypeControls()
        Try
            If itspunit.Type = "Learning" Then
                btnAssessTemplate.Enabled = False
                PageSettings1.AssessmentTab.Enabled = False
            Else
                btnAssessTemplate.Enabled = True
                PageSettings1.AssessmentTab.Enabled = True
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
#End Region
#Region "PopulateLists"
    Public Shared Sub PopulatePagesDropDown(ByVal ddBox As DevExpress.XtraEditors.ComboBoxEdit)
        Try
            ddBox.Properties.Items.Clear()
            ddBox.Properties.Items.Add("")
            ddBox.Properties.Items.Add("Next")
            ddBox.Properties.Items.Add("Previous")
            ddBox.Properties.Items.Add("Last")
            For Each pg As mstns.Page In itspunit.PageCol
                ddBox.Properties.Items.Add(pg.PageName)
            Next


        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub PopulateObjectsDropDown(ByVal ddBox As DevExpress.XtraEditors.ComboBoxEdit, Optional ByVal bExcludeVisible As Boolean = False, Optional ByVal bExcludeInvisible As Boolean = False)
        Try
            ddBox.Properties.Items.Clear()
            ddBox.Properties.Items.Add("")
            For Each obj As mstns.Object_ In itspunit.PageCol(selectedPageIndex).ObjectCol
                If (obj.StartVisible = True And bExcludeVisible = False) Or (obj.StartVisible = False And bExcludeInvisible = False) Then
                    ddBox.Properties.Items.Add(obj.ObjectName)
                End If
            Next
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub PopulateObjectsMultiSelect(ByVal ddBox As DevExpress.XtraEditors.CheckedComboBoxEdit, Optional ByVal bExcludeVisible As Boolean = False, Optional ByVal bExcludeInvisible As Boolean = False)
        Try
            ddBox.Properties.Items.Clear()
            For Each obj As mstns.Object_ In itspunit.PageCol(selectedPageIndex).ObjectCol
                If ((obj.StartVisible = True Or obj.StartOpaque = True) And bExcludeVisible = False) Or ((obj.StartVisible = False Or obj.StartOpaque = False) And bExcludeInvisible = False) Then
                    ddBox.Properties.Items.Add(obj.ObjectName)
                End If
            Next
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub PopulateImageCombo(ByVal ddBox As DevExpress.XtraEditors.ComboBoxEdit)
        Try
            ddBox.Properties.Items.Clear()
            For Each i As DevExpress.XtraBars.Ribbon.GalleryItem In StandardImageGalleryEdit.Properties.Gallery.Groups(0).Items
                ddBox.Properties.Items.Add(i.Value)
            Next
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub PopulateImageDropDown(ByVal galEdit As DevExpress.XtraEditors.PopupGalleryEdit)
        Try
            galEdit.Properties.Gallery.Groups(0).Items.Clear()
            galEdit.Properties.Gallery.ShowItemText = True
            galEdit.Properties.Gallery.FixedImageSize = False
            galEdit.Properties.Gallery.UseMaxImageSize = False
            galEdit.Properties.Gallery.ImageSize = New System.Drawing.Size(70, 50)
            galEdit.Properties.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
            For Each i As DevExpress.XtraBars.Ribbon.GalleryItem In StandardImageGalleryEdit.Properties.Gallery.Groups(0).Items
                galEdit.Properties.Gallery.Groups(0).Items.Add(i)
            Next
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub PopulateCursorDropDown(ByVal ddBox As DevExpress.XtraEditors.ComboBoxEdit)
        ddBox.Properties.Items.Clear()
        ddBox.Properties.Items.Add("")
        For Each File As String In IO.Directory.GetFiles(imageFolder, "*.cur")
            ddBox.Properties.Items.Add(Path.GetFileNameWithoutExtension(File))
        Next
    End Sub
    Public Sub PopulateAssessmentCombo()
        Try
            If itspunit.Type <> "Learning" And itspunit.TutorialList.Count > 0 Then
                Dim dd As DevExpress.XtraEditors.LookUpEdit = PageSettings1.ddAssessTutorial
                Dim ds As DataSet = New DataSet("dsTutorials")
                Dim dt As DataTable = ds.Tables.Add("tTutorials")
                dt.Columns.Add("TutorialID", Type.GetType("System.Int32"))
                dt.Columns.Add("TutorialName", Type.GetType("System.String"))
                For Each t As mstns.Tutorials In itspunit.TutorialList
                    dt.Rows.Add(t.TutorialID, t.TutorialName)
                Next
                dd.Properties.DataSource = dt
                dd.Properties.DisplayMember = "TutorialName"
                dd.Properties.ValueMember = "TutorialID"
                dd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
                dd.Properties.PopulateColumns()
                dd.Refresh()
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub UpdatePageLists()
        Try
            PopulatePagesDropDown(PageSettings1.cbxPassToPage)
            PopulatePagesDropDown(PageSettings1.cbxGotoPageCorrect)
            Dim selectedPage As mstns.Page = itspunit.PageCol(selectedPageIndex)
            'PageSettings1.cbxPassToPage.EditValue = selectedPage.PassNextPage
            'PageSettings1.cbxGotoPageCorrect.EditValue = selectedPage.JudgeCorrectNextPage
            For Each item As String In PageSettings1.cbxPassToPage.Properties.Items
                If selectedPage.PassNextPage = item Then
                    PageSettings1.cbxPassToPage.EditValue = selectedPage.PassNextPage
                End If
            Next
            For Each item As String In PageSettings1.cbxGotoPageCorrect.Properties.Items
                If selectedPage.JudgeCorrectNextPage = item Then
                    PageSettings1.cbxGotoPageCorrect.EditValue = selectedPage.JudgeCorrectNextPage
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "PublishAndPreviewProject"
    Public Sub PreviewFromPage()
        Try
            If Not itspunit Is Nothing And Not PreviewPath = "" Then
                EmptyFolder(PreviewPath)
                For Each pg As mstns.Page In itspunit.PageCol
                    GeneratePage(PreviewPath, pg)
                Next
                Dim htmlSource As String = ""
                'if this is a diagnostic assessment, add the diagnostic outcome:
                If itspunit.Type = "Diagnostic" Then
                    htmlSource = My.Resources.DiagnosticOutcome.ToString()
                    htmlSource = htmlSource.Replace("XXImageWidthXX", itspunit.Width.ToString())
                    htmlSource = htmlSource.Replace("XXImageHeightXX", itspunit.Height.ToString())
                    htmlSource = htmlSource.Replace("#CDCDCD", itspunit.BrowserBackgroundColour.ToString())
                    System.IO.File.WriteAllText(PreviewPath & "/diagnostic-outcome.html", htmlSource)
                End If
                'if this is a PL assessment, add the assess outcome:
                If itspunit.Type = "Post Learning" Then
                    htmlSource = My.Resources.AssessOutcome.ToString()
                    htmlSource = htmlSource.Replace("XXImageWidthXX", itspunit.Width.ToString())
                    htmlSource = htmlSource.Replace("XXImageHeightXX", itspunit.Height.ToString())
                    htmlSource = htmlSource.Replace("#CDCDCD", itspunit.BrowserBackgroundColour.ToString())
                    System.IO.File.WriteAllText(PreviewPath & "/assessment-outcome.html", htmlSource)
                End If
                Dim url As String = PreviewPath & "/" & utility.TidyFileName(itspunit.PageCol.Item(selectedPageIndex).PageName) & ".html"
                Try
                    Cursor = Cursors.AppStarting
                    Process.Start(url)
                Catch generatedExceptionName As Exception
                    Dim sMsg As String = generatedExceptionName.Message.ToString
                Finally
                    Cursor = Nothing
                End Try
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Public Sub PreviewAll()
        Try
            If Not itspunit Is Nothing And Not PreviewPath = "" Then
                EmptyFolder(PreviewPath)
                For Each pg As mstns.Page In itspunit.PageCol
                    GeneratePage(PreviewPath, pg)
                Next
                Dim htmlSource As String = ""
                'if this is a diagnostic assessment, add the diagnostic outcome:
                If itspunit.Type = "Diagnostic" Then
                    htmlSource = My.Resources.DiagnosticOutcome.ToString()
                    htmlSource = htmlSource.Replace("XXImageWidthXX", itspunit.Width.ToString())
                    htmlSource = htmlSource.Replace("XXImageHeightXX", itspunit.Height.ToString())
                    htmlSource = htmlSource.Replace("<!--qchoices-->", "<li>Your diagnostic scores for each objective will appear here when published.</li>")
                    htmlSource = htmlSource.Replace("#CDCDCD", itspunit.BrowserBackgroundColour.ToString())
                    System.IO.File.WriteAllText(PreviewPath & "/diagnostic-outcome.html", htmlSource)
                End If
                'if this is a PL assessment, add the assess outcome:
                If itspunit.Type = "Post Learning" Then
                    htmlSource = My.Resources.AssessOutcome.ToString()
                    htmlSource = htmlSource.Replace("XXImageWidthXX", itspunit.Width.ToString())
                    htmlSource = htmlSource.Replace("XXImageHeightXX", itspunit.Height.ToString())
                    htmlSource = htmlSource.Replace("#CDCDCD", itspunit.BrowserBackgroundColour.ToString())
                    System.IO.File.WriteAllText(PreviewPath & "/assessment-outcome.html", htmlSource)
                End If
                Dim url As String = PreviewPath & "/" & utility.TidyFileName(itspunit.PageCol.Item(0).PageName) & ".html"
                Try
                    Cursor = Cursors.AppStarting
                    Process.Start(url)
                Catch generatedExceptionName As Exception
                Finally
                    Cursor = Nothing
                End Try
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub

    Public Sub PreviewPage()
        Try
            If Not itspunit Is Nothing And Not PreviewPath = "" Then
                EmptyFolder(PreviewPath)
                GeneratePage(PreviewPath, itspunit.PageCol.Item(selectedPageIndex))
                Dim url As String = PreviewPath & "/" & utility.TidyFileName(itspunit.PageCol.Item(selectedPageIndex).PageName) & ".html"
                Try
                    Cursor = Cursors.AppStarting
                    Process.Start(url)
                Catch generatedExceptionName As Exception
                Finally
                    Cursor = Nothing
                End Try
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Property JudgeFunctionList As List(Of String) = New List(Of String)
    Public Sub GeneratePage(ByVal sPath As String, ByVal pg As mstns.Page, Optional ByVal bIsPreview As Boolean = True)
        Try
            JudgeFunctionList.Clear()

            Dim htmlSource As String = My.Resources.PreviewPage.ToString()
            'Calculate progress bar position:
            Dim nPageNum As Integer = itspunit.PageCol.IndexOf(pg) + 1
            Dim nPageCount As Integer = itspunit.PageCol.Count
            htmlSource = htmlSource.Replace("00065", nPageNum.ToString)
            htmlSource = htmlSource.Replace("000100", nPageCount.ToString)
            Dim sPrefetch As String = ""
            'Set a javascript variable to state that we are in preview mode for preview only scripts
            Dim sPageJS As String
            If bIsPreview Then
                sPageJS = "var isPreview = true;"
            Else
                sPageJS = "var isPreview = false;"
            End If
            Dim t1 As String = Replace(Trim(utility.StripHTML(pg.InstructionText)), " ", "")
            Dim t2 As String = Replace(Trim(utility.StripHTML(pg.InteractionText)), " ", "")
            If t1 Is Nothing Then
                t1 = ""
            End If
            If t2 Is Nothing Then
                t2 = ""
            End If
            Dim bkfolder As String
            Dim imgfolder As String
            Dim vidfolder As String
            If bIsPreview Then
                bkfolder = "../backgrounds/"
                imgfolder = "../images/"
                vidfolder = "../videos/"
            Else
                bkfolder = "backgrounds/"
                imgfolder = "images/"
                vidfolder = "videos/"
            End If

            If pg.BackgroundImage <> "" Then
                PageSettings1.btnBkgEdit.Enabled = True
                Dim imgPath As String = bkfolder & pg.BackgroundImage
                htmlSource = htmlSource.Replace("XXBkgImageSrcXX", imgPath.Replace(" ", "%20"))
            Else
                PageSettings1.btnBkgEdit.Enabled = False

                htmlSource = htmlSource.Replace("XXBkgImageSrcXX", "navimages/empty.png")

            End If
            If bIsPreview Then
                htmlSource = htmlSource.Replace("XXBlankXX", sPath & "\navimages\empty.png")
            Else
                htmlSource = htmlSource.Replace("XXBlankXX", "navimages/empty.png")
            End If
            htmlSource = htmlSource.Replace("XXImageNameXX", pg.BackgroundImage)
            htmlSource = htmlSource.Replace("XXImageWidthXX", itspunit.Width.ToString())
            htmlSource = htmlSource.Replace("XXImageHeightXX", itspunit.Height.ToString())
            If (t1 & t2).Length < 5 Then
                htmlSource = htmlSource.Replace("XXLeftPosXX", "-1000")
                htmlSource = htmlSource.Replace("XXTBClassXX", "hidden")
            Else
                htmlSource = htmlSource.Replace("XXLeftPosXX", pg.InstructionHPos.ToString())
            End If
            If pg.PageType <> "" Then
                htmlSource = htmlSource.Replace("XXTBClassXX", "tb-" & pg.PageType.ToLower())
            Else
                htmlSource = htmlSource.Replace("XXTBClassXX", "tb-explain")
            End If
            Dim sType As String = "Explanation"
            Select Case pg.PageType
                Case "explain"
                    sType = "Explanation"
                Case "demo"
                    sType = "Demonstration"
                Case "test"
                    sType = "Test"
                Case "practice"
                    sType = "Practise"
                Case "guide"
                    sType = "Guide"
                Case "review"
                    sType = "Review"
            End Select
            htmlSource = htmlSource.Replace("##PageType##", sType)
            htmlSource = htmlSource.Replace("XXRightPosXX", pg.InstructionVPos.ToString())
            If t1.Length > 2 And t2.Length > 2 Then
                htmlSource = htmlSource.Replace("<div id='output-inst-text'></div>", utility.RemovePageTags(pg.InstructionText) & utility.RemovePageTags(pg.InteractionText))
            ElseIf t1.Length > 2 Then
                htmlSource = htmlSource.Replace("<div id='output-inst-text'></div>", utility.RemovePageTags(pg.InstructionText))
            ElseIf t2.Length > 2 Then
                htmlSource = htmlSource.Replace("<div id='output-inst-text'></div>", utility.RemovePageTags(pg.InteractionText))
            End If
            If Not LastPageHtml = "" Then
                If pg.InstructionText & pg.InteractionText = LastPageHtml Then
                    htmlSource.Replace("text-box fade-in", "text-box")
                End If
            End If
            LastPageHtml = pg.InstructionText & pg.InteractionText
            htmlSource = htmlSource.Replace("#ABABAB", itspunit.BrowserBackgroundColour.ToString())
            htmlSource = htmlSource.Replace("#CDCDCD", itspunit.PageBackgroundColour.ToString())
            'Handle quiz question stuff:
            If Not pg.QuizQuestion Is Nothing Then
                If pg.QuizQuestion.Question <> "" Then
                    htmlSource = htmlSource.Replace("<!--quizq-->", My.Resources.quiz_question.ToString)
                    htmlSource = htmlSource.Replace("XXXQuestionTextXXX", utility.HTMLEncodeWithTags(pg.QuizQuestion.Question))
                    htmlSource = htmlSource.Replace("XXHintXX", utility.HTMLEncodeWithTags(pg.QuizQuestion.Hint))
                    Select Case pg.QuizQuestion.Layout.ToLower
                        Case "left"
                            htmlSource = htmlSource.Replace("col-sm-10 col-sm-offset-1", "col-sm-6")
                        Case "right"
                            htmlSource = htmlSource.Replace("col-sm-10 col-sm-offset-1", "col-sm-6 col-sm-offset-6")
                        Case "centred"
                            htmlSource = htmlSource.Replace("col-sm-10 col-sm-offset-1", "col-sm-6 col-sm-offset-3")
                    End Select
                    Dim sChoices As String = ""
                    Dim nCorrect As Integer = 0
                    Dim nChoices As Integer = 0
                    For Each ch As mstns.QuizChoice In pg.QuizQuestion.QuizChoicesCol
                        nChoices += 1
                        Dim sID = "q" & nChoices.ToString
                        sChoices = sChoices & "<li role='option' class='q-choice list-group-item' data-type='radio' aria-setsize='9999' aria-psinset='" & nChoices.ToString() & "' aria-labelledby='" & sID & "' data-style='alert' data-color='alert-info' data-iscor='" & ch.Correct.ToString() & "'><span id='" & sID & "' style='padding-left:10px;'>" & utility.HTMLEncodeWithTags(ch.ChoiceText) & "</span></li>"
                        If ch.Correct Then nCorrect = nCorrect + 1

                    Next
                    sChoices = sChoices.Replace("9999", nChoices.ToString)
                    If nCorrect <> 1 Then
                        sChoices = sChoices.Replace("data-type='radio'", "data-type='checkbox'")
                        htmlSource = htmlSource.Replace("##checklist##", "checklist")
                    Else
                        htmlSource = htmlSource.Replace("##checklist##", "radiogroup")
                    End If
                    htmlSource = htmlSource.Replace("<!--qchoices-->", sChoices)
                    If pg.QuizQuestion.Shuffle Then
                        sPageJS = sPageJS + "$('.q-choice').shuffle();"
                    End If
                    'Setup function for judging the interaction:
                    sPageJS = sPageJS + "$('#get-checked-data').click(function() {"
                    'Check if the question is correct:
                    sPageJS = sPageJS + "var isCorrect = getQuizResult();"
                    sPageJS = sPageJS + "if(isCorrect==true){"
                    'HANDLE ASSESSMENT SCORE INCREMENT HERE:
                    If itspunit.Type <> "Learning" And pg.ScoredInteraction Then
                        sPageJS = sPageJS + "AssessmentOutcome(true, " & pg.ScoreTutorialID & ");"
                    End If
                    If pg.QuizQuestion.CorrectFeedback <> "" Then
                        sPageJS = sPageJS + "$('#feedbackTitle').html('Correct');"
                        sPageJS = sPageJS + "$('.modal-header').addClass('has-success');"
                        sPageJS = sPageJS + "$('#feedbackText').html('" & utility.HTMLEncodeWithTags(pg.QuizQuestion.CorrectFeedback) & "');"
                        sPageJS = sPageJS + "$('#feedbackModal').modal('show');"
                        If pg.QuizQuestion.GotoPageIncorrect <> "" Then
                            sPageJS = sPageJS + "$('#feedbackModal').on('hidden.bs.modal', function (e) {"
                            If pg.QuizQuestion.GotoPageCorrect <> "" Then
                                Dim sPage As String = utility.TidyFileName(pg.QuizQuestion.GotoPageCorrect)
                                If sPage = "Next" Then
                                    sPage = CDAMain.GetNextPage(pg.PageName)
                                ElseIf sPage = "Previous" Then
                                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                                ElseIf sPage = "Last" Then
                                    sPage = CDAMain.GetLastPage()
                                End If
                                If sPage = "" Then
                                    If itspunit.Type = "Diagnostic" Then
                                        sPage = "diagnostic-outcome"
                                    ElseIf itspunit.Type = "Post Learning" Then
                                        sPage = "assessment-outcome"
                                    End If
                                End If
                                sPageJS = sPageJS + "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
                            End If
                            sPageJS = sPageJS + "})"
                        End If
                    Else
                        'Navigate to next page if not:

                        If pg.QuizQuestion.GotoPageCorrect <> "" Then
                            Dim sPage As String = utility.TidyFileName(pg.QuizQuestion.GotoPageCorrect)
                            If sPage = "Next" Then
                                sPage = CDAMain.GetNextPage(pg.PageName)
                                If sPage = "" Then
                                    If itspunit.Type = "Diagnostic" Then
                                        sPage = "diagnostic-outcome"
                                    ElseIf itspunit.Type = "Post Learning" Then
                                        sPage = "assessment-outcome"
                                    End If
                                End If
                            ElseIf sPage = "Previous" Then
                                sPage = CDAMain.GetPreviousPage(pg.PageName)
                            ElseIf sPage = "Last" Then
                                sPage = CDAMain.GetLastPage()
                            End If
                            sPageJS = sPageJS + "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
                        End If
                    End If
                    sPageJS = sPageJS + "} else {"
                    If itspunit.Type <> "Learning" And pg.ScoredInteractionIncorrect Then
                        sPageJS = sPageJS + "AssessmentOutcome(false, " & pg.ScoreTutorialID & ");"
                    End If
                    If pg.QuizQuestion.IncorrectFeedback <> "" Then
                        sPageJS = sPageJS + "$('#feedbackTitle').html('Incorrect');"
                        sPageJS = sPageJS + "$('.modal-header').addClass('has-error');"
                        sPageJS = sPageJS + "$('#feedbackText').html('" & utility.HTMLEncodeWithTags(pg.QuizQuestion.IncorrectFeedback) & "');"
                        sPageJS = sPageJS + "$('#feedbackModal').modal('show');"
                        If pg.QuizQuestion.GotoPageIncorrect <> "" Then
                            sPageJS = sPageJS + "$('#feedbackModal').on('hidden.bs.modal', function (e) {"
                            If pg.QuizQuestion.GotoPageIncorrect <> "" Then
                                Dim sPage As String = utility.TidyFileName(pg.QuizQuestion.GotoPageIncorrect)
                                If sPage = "Next" Then
                                    sPage = CDAMain.GetNextPage(pg.PageName)
                                    If sPage = "" Then
                                        If itspunit.Type = "Diagnostic" Then
                                            sPage = "diagnostic-outcome"
                                        ElseIf itspunit.Type = "Post Learning" Then
                                            sPage = "assessment-outcome"
                                        End If
                                    End If
                                ElseIf sPage = "Previous" Then
                                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                                ElseIf sPage = "Last" Then
                                    sPage = CDAMain.GetLastPage()
                                End If
                                sPageJS = sPageJS + "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
                            End If
                            sPageJS = sPageJS + "})"
                        End If
                    Else
                        'Navigate to next page if not:

                        If pg.QuizQuestion.GotoPageIncorrect <> "" Then
                            Dim sPage As String = utility.TidyFileName(pg.QuizQuestion.GotoPageIncorrect)
                            If sPage = "Next" Then
                                sPage = CDAMain.GetNextPage(pg.PageName)
                                If sPage = "" Then
                                    If itspunit.Type = "Diagnostic" Then
                                        sPage = "diagnostic-outcome"
                                    ElseIf itspunit.Type = "Post Learning" Then
                                        sPage = "assessment-outcome"
                                    End If
                                End If
                            ElseIf sPage = "Previous" Then
                                sPage = CDAMain.GetPreviousPage(pg.PageName)
                            ElseIf sPage = "Last" Then
                                sPage = CDAMain.GetLastPage()
                            End If
                            sPageJS = sPageJS + "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
                        End If
                    End If
                    sPageJS = sPageJS + "};"
                    'Close the submit button function:
                    sPageJS = sPageJS + "});"
                End If
            End If
            sPageJS = sPageJS + "function InitialiseUI(){"
            'htmlSource = htmlSource.Replace("XXBlankImageSrcXX", sPath & "\navimages\blank.png")
            If bIsPreview Then
                htmlSource = htmlSource.Replace("XXitsplearningcssXX", sPath & "\css\itsplearning.css")
                htmlSource = htmlSource.Replace("XXanimationcssXX", sPath & "\css\animation.css")
                htmlSource = htmlSource.Replace("XXjquery_ui_cssXX", sPath & "\css\jquery_ui.css")
                htmlSource = htmlSource.Replace("XXbootstrapcssXX", sPath & "\css\bootstrap.min.css")
                htmlSource = htmlSource.Replace("XXjquery_ui_jsXX", sPath & "\js\jquery_ui.js")
                htmlSource = htmlSource.Replace("XXjquery_jsXX", sPath & "\js\jquery.js")
                htmlSource = htmlSource.Replace("XXpage_jsXX", sPath & "\js\" & utility.TidyFileName(pg.PageName) & ".js")
                htmlSource = htmlSource.Replace("XXcrosshair-minXX", sPath & "\js\crosshair-min.js")
                htmlSource = htmlSource.Replace("XXitsp-contentXX", sPath & "\js\itsp-content.js")
                htmlSource = htmlSource.Replace("XXplayerscaling_jsXX", sPath & "\js\player-scaling.js")
                htmlSource = htmlSource.Replace("XXbootstrap_jsXX", sPath & "\js\bootstrap.min.js")
            Else
                htmlSource = htmlSource.Replace("XXitsplearningcssXX", "css/itsplearning.css")
                htmlSource = htmlSource.Replace("XXanimationcssXX", "css/animation.css")
                htmlSource = htmlSource.Replace("XXjquery_ui_cssXX", "css/jquery_ui.css")
                htmlSource = htmlSource.Replace("XXbootstrapcssXX", "css/bootstrap.min.css")
                htmlSource = htmlSource.Replace("XXjquery_ui_jsXX", "js/jquery_ui.js")
                htmlSource = htmlSource.Replace("XXjquery_jsXX", "js/jquery.js")
                htmlSource = htmlSource.Replace("XXpage_jsXX", "js/" & utility.TidyFileName(pg.PageName) & ".js")
                htmlSource = htmlSource.Replace("XXcrosshair-minXX", "js/crosshair-min.js")
                htmlSource = htmlSource.Replace("XXitsp-contentXX", "js/itsp-content.js")
                htmlSource = htmlSource.Replace("XXplayerscaling_jsXX", "js/player-scaling.js")
                htmlSource = htmlSource.Replace("XXbootstrap_jsXX", "js/bootstrap.min.js")
            End If
            Dim htmlObjects As String = ""
            Dim htmlStyles As String = ".text-box{ width: " & pg.InstructionWidth.ToString & "px !important;}"
            Dim htmlScripts As String = ""
            'set the correct page background colour:
            htmlStyles = htmlStyles + ".container {background-color: " & itspunit.BrowserBackgroundColour & ";}"
            'hide next and previous if assessment:
            If itspunit.Type <> "Learning" Then
                htmlSource = htmlSource.Replace("back-button", "back-button hiddenobj")
                htmlSource = htmlSource.Replace("next-button", "pass-button")
                Dim sPage As String = utility.TidyFileName(pg.PassNextPage)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                Dim qs As String = ""
                If pg.ScoredInteractionIncorrect Then
                    htmlSource = htmlSource.Replace("id='btnNext'", "id='btnNext' onclick='AssessmentOutcome(false, " & pg.ScoreTutorialID & ");'")
                    If bIsPreview Then
                        qs = "?outcome=2"
                    End If
                End If

                If sPage = "" Then
                    htmlSource = htmlSource.Replace("XXNextTargetXX", "javascript:exit_learning();")
                Else
                    htmlSource = htmlSource.Replace("XXNextTargetXX", utility.TidyFileName(sPage) & ".html" & qs)
                End If
                If itspunit.Type = "Diagnostic" Then
                    htmlSource = htmlSource.Replace("1234567890", pg.ScoreTutorialID.ToString())

                End If
            Else
                If Not pg.IncludeNext Then
                    htmlSource = htmlSource.Replace("next-button", "next-button hiddenobj")
                End If
                'setup next and previous navigation:
                Dim sNext As String = GetNextPage(pg.PageName)
                If Not sNext = "" Then
                    sNext = utility.TidyFileName(sNext) & ".html"
                    If sNext <> ".html" Then
                        htmlSource = htmlSource.Replace("XXNextTargetXX", sNext)
                        sPrefetch = sPrefetch & "<link rel='prefetch' href='" & sNext & "' />"
                        sPrefetch = sPrefetch & "<link rel='prefetch' href='js/" & Replace(sNext, "html", "js") & "' />"
                    End If
                Else

                    If itspunit.Type = "Diagnostic" Then
                        htmlSource = htmlSource.Replace("XXNextTargetXX", "diagnostic-outcome.html")
                    ElseIf itspunit.Type = "Post Learning" Then
                        htmlSource = htmlSource.Replace("XXNextTargetXX", "assessment-outcome.html")
                    Else
                        htmlSource = htmlSource.Replace("XXNextTargetXX", "javascript:exit_learning();")
                        sPageJS = sPageJS & "if (typeof parent.CCPlayer != 'undefined') {parent.CCPlayer.MarkLearningComplete();}"
                    End If

                    'htmlStyles = htmlStyles + "#btnNext {display:none;}"
                End If
                Dim sPrevious As String = GetPreviousPage(pg.PageName)
                If Not sPrevious = "" Then
                    sPrevious = utility.TidyFileName(sPrevious) & ".html"
                    If sPrevious <> ".html" Then
                        sPrefetch = sPrefetch & "<link rel='prefetch' href='" & sPrevious & "' />"
                        sPrefetch = sPrefetch & "<link rel='prefetch' href='js/" & Replace(sNext, "html", "js") & "' />"
                        htmlSource = htmlSource.Replace("XXPreviousTargetXX", sPrevious)
                    End If
                Else
                    htmlSource = htmlSource.Replace("XXPreviousTargetXX", "javascript:exit_learning();")
                    'htmlStyles = htmlStyles + "#btnPrev {display:none;}"
                End If
            End If
            For Each obj As mstns.Object_ In pg.ObjectCol
                objectAnimateFunctionList.Clear()
                'Start the style string:
                htmlStyles = htmlStyles + "#" & TidyObjectName(obj.ObjectName) & " {position:absolute;"
                'Add the positioning css elements:
                htmlStyles = htmlStyles + "top:" & obj.VPos.ToString() & "px;left:" & obj.HPos.ToString() & "px;height:" & obj.Height.ToString() & "px;width:" & obj.Width.ToString() & "px;"


                'Add background options:

                'If image is rotated, rotate it:
                If obj.Rotation > 0 Then
                    htmlStyles = htmlStyles + "transform: rotate(" & obj.Rotation & "deg);"
                End If
                'If a Standard background exists, set it:
                If obj.StandardImage <> "" Then
                    Dim imgPath As String = imgfolder & obj.StandardImage
                    htmlStyles = htmlStyles + "background-Image:url(" & imgPath.Replace(" ", "%20") & ");"
                ElseIf obj.UseMouseUpImage Or obj.UseMouseEnterImage Or obj.UseMouseDownImage Then
                    htmlStyles = htmlStyles + "background-color:" & utility.hexAndOpacityToRgba(obj.BackGroundColour.ToString(), 0) & ";"
                    'Else
                    '    htmlStyles = htmlStyles + "background-color:" & utility.hexAndOpacityToRgba(obj.BackGroundColour.ToString(), obj.BackGroundOpacity) & ";"
                End If
                htmlStyles = htmlStyles + "}"
                'Add border options:
                If obj.BorderStyle <> "none" Or obj.Radius <> 0 Then
                    'Setup the border color according to opacity:
                    Dim sBorderColour As String = obj.BorderColour.ToString()
                    If obj.BorderOpacity < 1 Then
                        Dim nOpacityPercent As Integer = CInt(CDec(obj.BorderOpacity) * CDec(100))
                        sBorderColour = utility.hexAndOpacityToRgba(sBorderColour, obj.BorderOpacity)
                    End If
                    htmlStyles = htmlStyles + "#" & TidyObjectName(obj.ObjectName) & ":after {position:absolute;content: ''; display: block; position: absolute; top: 0; bottom: 0; left: 0; right: 0; "
                    If obj.BorderStyle <> "none" Then
                        htmlStyles = htmlStyles + "border: " & obj.BorderWidth.ToString() & "px " & obj.BorderStyle.ToString() & " " & sBorderColour & ";transform: translate(0px,0px);"
                    End If
                    If obj.Radius <> 0 Then
                        htmlStyles = htmlStyles + "border-radius:" & obj.Radius & "px;"
                    End If
                    htmlStyles = htmlStyles + "background-color:" & utility.hexAndOpacityToRgba(obj.BackGroundColour.ToString(), obj.BackGroundOpacity) & ";"
                    htmlStyles = htmlStyles + "}"
                End If
                If obj.MouseEnterImage <> "" Then
                    Dim imgPath As String = imgfolder & obj.MouseEnterImage
                    htmlStyles = htmlStyles + "#" & TidyObjectName(obj.ObjectName) & ":hover {background-Image:url(" & imgPath.Replace(" ", "%20") & ");filter: alpha(opacity=100);opacity:1;}"
                End If
                If obj.MouseDownImage <> "" Then
                    Dim imgPath As String = imgfolder & obj.MouseDownImage
                    htmlStyles = htmlStyles + "#" & TidyObjectName(obj.ObjectName) & ":active {background-Image:url(" & imgPath.Replace(" ", "%20") & ");filter: alpha(opacity=100);opacity:1;}"
                End If
                Dim sInnerHtml As String = ""
                Dim sOuterHtml As String = ""
                Dim sTitle As String = ""
                For Each bh As mstns.Behaviours In obj.BehaviourCol
                    If Not bh.Text_ Is Nothing Then
                        sInnerHtml = sInnerHtml + SetupTextBehaviour(bh.Text_, TidyObjectName(obj.ObjectName))
                        sPageJS = sPageJS + jsgenerate.GenerateTextBehaviourJS(bh.Text_, obj, pg)
                    ElseIf Not bh.Animate Is Nothing Then
                        sPageJS = sPageJS + jsgenerate.GenerateAnimateBehaviourJS(bh.Animate, obj, pg)
                    ElseIf Not bh.MouseEvent Is Nothing Then
                        sPageJS = sPageJS + jsgenerate.GenerateMouseEventBehaviourJS(bh.MouseEvent, obj, pg)
                    ElseIf Not bh.CustomCSS Is Nothing Then
                        htmlStyles = htmlStyles + jsgenerate.GenerateCustomCSSBehaviourCSS(bh.CustomCSS, obj, pg)
                    ElseIf Not bh.CustomJavaScript Is Nothing Then
                        sPageJS = sPageJS + jsgenerate.GenerateCustomJSBehaviourJS(bh.CustomJavaScript, obj, pg)
                    ElseIf Not bh.Drag Is Nothing Then
                        sPageJS = sPageJS + jsgenerate.GenerateDragBehaviourJS(bh.Drag, obj, pg)
                    ElseIf Not bh.FollowMouse Is Nothing Then
                        sPageJS = sPageJS + jsgenerate.GenerateFollowMouseBehaviourJS(bh.FollowMouse, obj, pg)
                    ElseIf Not bh.KeyboardShortcut Is Nothing Then
                        sPageJS = sPageJS + jsgenerate.GenerateKeyboardShortcutBehaviourJS(bh.KeyboardShortcut, obj, pg)
                    ElseIf Not bh.MousePointer Is Nothing Then
                        htmlStyles = htmlStyles + jsgenerate.GenerateMousePointerBehaviourCSS(bh.MousePointer, obj, pg, imgfolder)
                    ElseIf Not bh.Resize Is Nothing Then
                        sPageJS = sPageJS + jsgenerate.GenerateResizeBehaviourJS(bh.Resize, obj, pg)
                        If Not bh.Resize.CustomCursor = "" Then
                            htmlStyles = htmlStyles + jsgenerate.GenerateResizeBehaviourCSS(bh.Resize, imgfolder)
                        End If
                    ElseIf Not bh.Password Is Nothing Then
                        sInnerHtml = "<input type='password' id='pwd-" & TidyObjectName(obj.ObjectName) & "'  style='width:" & obj.Width.ToString & "px;'>"
                        sPageJS = sPageJS + jsgenerate.GeneratePasswordBehaviourJS(bh.Password, obj, pg)
                    ElseIf Not bh.Spinner Is Nothing Then
                        sPageJS = sPageJS + jsgenerate.GenerateSpinnerBehaviourJS(bh.Spinner, obj, pg)
                    ElseIf Not bh.Tooltip Is Nothing Then
                        sTitle = " title='" & bh.Tooltip.TooltipTitle & "'"
                    ElseIf Not bh.Selectable Is Nothing Then
                        sTitle = " data-iscor='" & bh.Selectable.CorrectWhenSelected.ToString() & "'"
                        htmlStyles = htmlStyles + jsgenerate.GenerateSelectableCSS(bh.Selectable, obj, pg)
                        sPageJS = sPageJS + jsgenerate.GenerateSelectableBehaviourJS(bh.Selectable, obj, pg)
                    End If

                Next
                If Not obj.VideoFile = "" Then
                    Dim vidPath As String = vidfolder & obj.VideoFile
                    sInnerHtml = "<video id='" & TidyObjectName(obj.ObjectName) & "-vid' width='" & obj.Width.ToString & "' height='" & obj.Height.ToString & "'"
                    If obj.VideoAutoplay Then
                        sInnerHtml = sInnerHtml & " autoplay='autoplay' muted='muted'"
                    Else
                        sInnerHtml = sInnerHtml & " controls='controls'"
                    End If
                    sInnerHtml = sInnerHtml & " >"
                    sInnerHtml = sInnerHtml & "<source src='" & vidPath.Replace(" ", "%20") & "' type='video/mp4'>"
                    sInnerHtml = sInnerHtml & "</video>"
                    If obj.VideoFinishGoToPage <> "" Then
                        Dim sPage As String = utility.TidyFileName(obj.VideoFinishGoToPage)
                        If sPage = "Next" Then
                            sPage = CDAMain.GetNextPage(pg.PageName)
                        ElseIf sPage = "Previous" Then
                            sPage = CDAMain.GetPreviousPage(pg.PageName)
                        ElseIf sPage = "Last" Then
                            sPage = CDAMain.GetLastPage()
                        End If
                        sPageJS = sPageJS + "document.getElementById('" & TidyObjectName(obj.ObjectName) & "-vid').addEventListener('ended',myHandler,false);function myHandler(e) {window.location.href = '" & utility.TidyFileName(sPage) & ".html';}"
                    End If
                End If
                If objectAnimateFunctionList.Count > 0 Then
                    'open animate all function call:
                    sPageJS = sPageJS + "function " & Replace("AnimateAll" & TidyObjectName(obj.ObjectName), "-", "") & "(){"
                    'Loop through the object animate functions array and add function calls:
                    For i As Integer = 0 To objectAnimateFunctionList.Count - 1
                        sPageJS = sPageJS + objectAnimateFunctionList(i).ToString() + "();"
                    Next
                    'close the animate all function call:
                    sPageJS = sPageJS + "};"
                End If
                Dim sClassList As String = "object"
                If obj.StartOpaque = False Then
                    sClassList = sClassList & " object-hidden"
                End If
                If obj.StartVisible = False Then
                    sClassList = sClassList & " hiddenobj"
                End If
                For Each bh As mstns.Behaviours In obj.BehaviourCol
                    If Not bh.CustomCSS Is Nothing Then
                        If Not bh.CustomCSS.CSSClasses = "" Then
                            sClassList = sClassList & " " & bh.CustomCSS.CSSClasses
                        End If
                    End If
                Next
                htmlObjects = htmlObjects & "<div class='" & sClassList & "' id='"

                htmlObjects = htmlObjects & TidyObjectName(obj.ObjectName) & "'" & sTitle & " >" & sInnerHtml & "</div>" & sOuterHtml

            Next
            sPageJS = sPageJS + "function JudgeInteraction() {"
            sPageJS = sPageJS + "var allcorrect = true;"
            For Each Str As String In JudgeFunctionList
                sPageJS = sPageJS + "if(" + Str + "() === false){allcorrect = false;};"
            Next
            sPageJS = sPageJS + "if (allcorrect){"
            If pg.ScoredInteraction And itspunit.Type <> "Learning" Then
                sPageJS = sPageJS + "AssessmentOutcome(true, " & pg.ScoreTutorialID & ");"
            End If
            If pg.JudgeCorrectNextPage <> "" Then
                Dim sPage As String = utility.TidyFileName(pg.JudgeCorrectNextPage)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                If sPage <> "" Then
                    sPageJS = sPageJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
                    sPrefetch = sPrefetch & "<link rel='prefetch' href='" & utility.TidyFileName(sPage) & ".html' />"
                    sPrefetch = sPrefetch & "<link rel='prefetch' href='js/" & utility.TidyFileName(sPage) & ".js' />"
                End If
            End If
            sPageJS = sPageJS + "} else {"
            If pg.ScoredInteractionIncorrect And itspunit.Type <> "Learning" Then
                sPageJS = sPageJS + "AssessmentOutcome(false, " & pg.ScoreTutorialID & ");"
            End If
            If pg.PassNextPage <> "" Then
                Dim sPage As String = utility.TidyFileName(pg.PassNextPage)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                If sPage <> "" Then
                    sPageJS = sPageJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
                    sPrefetch = sPrefetch & "<link rel='prefetch' href='" & utility.TidyFileName(sPage) & ".html' />"
                    sPrefetch = sPrefetch & "<link rel='prefetch' href='js/" & utility.TidyFileName(sPage) & ".js' />"
                End If
            End If
            sPageJS = sPageJS + "};}}$(document).ready(function(){InitialiseUI();});"
            htmlSource = htmlSource.Replace(".stylestring{}", htmlStyles)
            htmlSource = htmlSource.Replace("<link rel='prefetch' href='#' />", sPrefetch)
            htmlSource = htmlSource.Replace("<div id='output-objects'></div>", htmlObjects)
            System.IO.File.WriteAllText(sPath & "/js/" & utility.TidyFileName(pg.PageName) & ".js", sPageJS)
            System.IO.File.WriteAllText(sPath & "/" & utility.TidyFileName(pg.PageName) & ".html", htmlSource)
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Shared Function TidyObjectName(ByVal objname As String) As String
        'get rid of spaces:
        objname = objname.Replace(" ", "_")
        'make sure it doesn't start with a number - prepend with "a" if so:
        Dim sValueAsArray = objname.ToCharArray()
        If IsNumeric(sValueAsArray(0)) Then
            objname = "a" & objname
        End If
        Return objname
    End Function


    Public Sub EmptyFolder(ByVal sPath As String)
        Try
            If Not sPath = "" Then
                If (System.IO.Directory.Exists(sPath)) Then
                    My.Computer.FileSystem.DeleteDirectory(sPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                System.IO.Directory.CreateDirectory(sPath)
                System.IO.Directory.CreateDirectory(sPath & "\navimages")
                System.IO.Directory.CreateDirectory(sPath & "\css")
                System.IO.Directory.CreateDirectory(sPath & "\js")
                System.IO.File.WriteAllText(sPath & "\css\animation.css", My.Resources.animation)
                System.IO.File.WriteAllText(sPath & "\css\itsplearning.css", My.Resources.itsplearning)
                System.IO.File.WriteAllText(sPath & "\css\jquery_ui.css", My.Resources.jquery_ui_css)
                System.IO.File.WriteAllText(sPath & "\css\bootstrap.min.css", My.Resources.bootstrap_min_css)
                System.IO.File.WriteAllText(sPath & "\js\jquery.js", My.Resources.jquery)
                System.IO.File.WriteAllText(sPath & "\js\jquery_ui.js", My.Resources.jquery_ui_js)
                System.IO.File.WriteAllText(sPath & "\js\itsp-content.js", My.Resources.itsp_content)
                File.WriteAllText(sPath & "\js\player-scaling.js", My.Resources.player_scaling)
                System.IO.File.WriteAllText(sPath & "\js\crosshair-min.js", My.Resources.crosshair_min)
                System.IO.File.WriteAllText(sPath & "\js\bootstrap.min.js", My.Resources.bootstrap_min_js)
                My.Resources.Back_F1.Save(sPath & "\navimages\Back_F1.png")
                My.Resources.Back_F2.Save(sPath & "\navimages\Back_F2.png")
                My.Resources.Next_F1.Save(sPath & "\navimages\Next_F1.png")
                My.Resources.Next_F2.Save(sPath & "\navimages\Next_F2.png")
                My.Resources.exit_f1.Save(sPath & "\navimages\exit_F1.png")
                My.Resources.exit_f2.Save(sPath & "\navimages\exit_F2.png")
                My.Resources.pass.Save(sPath & "\navimages\pass_F1.png")
                My.Resources.pass_f2.Save(sPath & "\navimages\pass_F2.png")
                My.Resources.blank.Save(sPath & "\navimages\blank.png")
                My.Resources.empty.Save(sPath & "\navimages\empty.png")
                My.Resources.tick.Save(sPath & "\navimages\outcome-tick.png")
                My.Resources.cross.Save(sPath & "\navimages\outcome-cross.png")
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
#End Region
#Region "OutputBehaviours"
    Public Function SetupTextBehaviour(ByVal bhText As mstns.TextBehaviour, ByVal sObjectID As String) As String
        Dim returnHtml As String = ""
        Try
            Dim sHTML As String = bhText.StartHtml
            Dim sHTMLReq As String = bhText.RequiredHtml
            Dim iseditable As String = ""
            If bhText.IsEditable Then
                iseditable = " contenteditable='true'"
            End If
            sHTML = Replace(sHTML, "<body>", "<body><div id='" & sObjectID & "-content' spellcheck='false' class='text-area-content' aria-labelledby='pgInst'" & iseditable & ">")
            sHTML = Replace(sHTML, "</body>", "</div></body>")
            sHTMLReq = Replace(sHTMLReq, "<body>", "<body><div id='" & sObjectID & "-required'>")
            sHTMLReq = Replace(sHTMLReq, "</body>", "</div></body>")

            returnHtml = "<div class='start-text'>" & utility.RemovePageTags(sHTML) & "</div><div class='required-text'>" & utility.RemovePageTags(sHTMLReq) & "</div>"
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
        Return returnHtml
    End Function

#End Region
#Region "UndoRedo"
    Public Sub Undo()
        Try
            If undoIndex > 0 Then
                Dim sUnitXML As String = UndoRedoChanges.ITSPUnitCol(undoIndex - 1).ToXml
                itspunit.FromXml(sUnitXML)
                undoIndex = undoIndex - 1
                If undoIndex < 1 Then
                    btnUndo.Enabled = False
                    btnQATUndo.Enabled = False
                Else
                    btnUndo.Enabled = True
                    btnQATUndo.Enabled = True
                End If
                If undoIndex >= UndoRedoChanges.ITSPUnitCol.Count - 1 Then
                    btnRedo.Enabled = False
                Else
                    btnRedo.Enabled = True
                End If
                allowRedo = True
                isUndoRedo = True
                Modified = True
                ReloadControls(True, False, True, True, True, True, True, True)

            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub Redo()
        Try
            If undoIndex < UndoRedoChanges.ITSPUnitCol.Count - 1 Then
                Dim sUnitXML As String = UndoRedoChanges.ITSPUnitCol(undoIndex + 1).ToXml
                itspunit.FromXml(sUnitXML)
                undoIndex = undoIndex + 1
                If undoIndex >= UndoRedoChanges.ITSPUnitCol.Count - 1 Then
                    btnRedo.Enabled = False
                Else
                    btnRedo.Enabled = True
                End If
                If undoIndex < 1 Then
                    btnUndo.Enabled = False
                    btnQATUndo.Enabled = False
                Else
                    btnUndo.Enabled = True
                    btnQATUndo.Enabled = True
                End If
                allowRedo = True
                isUndoRedo = True
                Modified = True
                ReloadControls(True, False, True, True, True, True, True, True)
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
#End Region
#Region "Publish"
    Public Sub PublishProjectStandard()
        Try
            If Not itspunit Is Nothing And Not PublishPath = "" Then
                EmptyFolder(PublishPath)
                For Each pg As mstns.Page In itspunit.PageCol

                    GeneratePage(PublishPath, pg, False)
                Next
                LastPageHtml = ""
                Dim fName As String
                If itspunit.UnitName Is Nothing Then
                    fName = "ITSPUnitPublish"
                Else
                    fName = itspunit.UnitName
                End If
                Dim objImgList As ArrayList = New ArrayList
                For Each pg As mstns.Page In itspunit.PageCol
                    If pg.BackgroundImage <> "" And Not objImgList.Contains(pg.BackgroundImage) And File.Exists(bkgFolder & "\" & pg.BackgroundImage) Then
                        objImgList.Add("backgrounds/" & pg.BackgroundImage)
                    End If
                    For Each obj As mstns.Object_ In pg.ObjectCol
                        If obj.StandardImage <> "" And Not objImgList.Contains(obj.StandardImage) And File.Exists(imageFolder & "\" & obj.StandardImage) Then
                            objImgList.Add("images/" & obj.StandardImage)
                        End If
                        If obj.MouseEnterImage <> "" And Not objImgList.Contains(obj.MouseEnterImage) And File.Exists(imageFolder & "\" & obj.MouseEnterImage) Then
                            objImgList.Add("images/" & obj.MouseEnterImage)
                        End If
                        If obj.MouseDownImage <> "" And Not objImgList.Contains(obj.MouseDownImage) And File.Exists(imageFolder & "\" & obj.MouseDownImage) Then
                            objImgList.Add("images/" & obj.MouseDownImage)
                        End If
                        If obj.MouseUpImage <> "" And Not objImgList.Contains(obj.MouseUpImage) And File.Exists(imageFolder & "\" & obj.MouseUpImage) Then
                            objImgList.Add("images/" & obj.MouseUpImage)
                        End If
                    Next
                Next
                Dim StrImageList As String = ""
                For Each im As String In objImgList
                    If im <> "" Then
                        StrImageList = StrImageList & "'" & im & "', "
                    End If
                Next
                If Not StrImageList = "" Then
                    StrImageList = StrImageList.Substring(0, StrImageList.Length - 2)
                End If

                System.IO.File.WriteAllText(PublishPath & "\js\itsp-tracking.js", My.Resources.itsp_tracking)
                    Dim htmlSource As String = My.Resources.itspplayer.ToString()
                    htmlSource = htmlSource.Replace("XXjquery_jsXX", "js/jquery.js")
                htmlSource = htmlSource.Replace("XXitsp-trackingXX", "https://www.dls.nhs.uk/Scripts/player/itsp-tracking.min.js")

                htmlSource = htmlSource.Replace("XXplayerscaling_jsXX", "js/player-scaling.js")
                htmlSource = htmlSource.Replace("XXPageNameXX", utility.TidyFileName(itspunit.PageCol(0).PageName) & ".html")
                    htmlSource = htmlSource.Replace("'XXImageListXX'", StrImageList)
                    System.IO.File.WriteAllText(PublishPath & "/itspplayer.html", htmlSource)
                    'if this is a diagnostic assessment, add the diagnostic outcome:
                    If itspunit.Type = "Diagnostic" Then
                        htmlSource = My.Resources.DiagnosticOutcome.ToString()
                        htmlSource = htmlSource.Replace("XXImageWidthXX", itspunit.Width.ToString())
                        htmlSource = htmlSource.Replace("XXImageHeightXX", itspunit.Height.ToString())
                        htmlSource = htmlSource.Replace("#CDCDCD", itspunit.BrowserBackgroundColour.ToString())
                        System.IO.File.WriteAllText(PublishPath & "/diagnostic-outcome.html", htmlSource)
                    End If
                'if this is a PL assessment, add the assess outcome:
                If itspunit.Type = "Post Learning" Then
                    htmlSource = My.Resources.AssessOutcome.ToString()
                    htmlSource = htmlSource.Replace("XXImageWidthXX", itspunit.Width.ToString())
                    htmlSource = htmlSource.Replace("XXImageHeightXX", itspunit.Height.ToString())
                    htmlSource = htmlSource.Replace("#CDCDCD", itspunit.BrowserBackgroundColour.ToString())
                    System.IO.File.WriteAllText(PublishPath & "/assessment-outcome.html", htmlSource)
                End If
                'get thumbnail for use in CC
                If itspunit.PageCol.Count > 0 Then
                    Dim nMidPage As Integer = CInt(itspunit.PageCol.Count / 2)
                    If nMidPage > 0 Then
                        Dim fld As String = imageFolder.Replace("images", "thumbs")
                        Dim filen As String = fld + "\" + itspunit.PageCol(nMidPage - 1).PageName + "_thmb.jpg"
                        If System.IO.File.Exists(filen) Then

                        End If
                    End If
                End If

                Using zip As ZipFile = New ZipFile()
                    'get thumbnail for use in CC
                    If itspunit.PageCol.Count > 0 Then
                        Dim nMidPage As Integer = CInt(itspunit.PageCol.Count / 2)
                        If nMidPage > 0 Then
                            Dim fld As String = imageFolder.Replace("images", "thumbs")
                            Dim filen As String = fld + "\" + itspunit.PageCol(nMidPage - 1).PageName + "_thmb.jpg"
                            If System.IO.File.Exists(filen) Then
                                Dim img As Image
                                Dim fs As System.IO.FileStream
                                fs = New System.IO.FileStream(filen, IO.FileMode.Open, IO.FileAccess.Read)
                                Try
                                    img = System.Drawing.Image.FromStream(fs)
                                    img = utility.ResizeImage(img, New Size(160, 120))
                                    img.Save(fld + "\ccthumb.jpg")



                                Catch ex As Exception

                                Finally
                                    If Not fs Is Nothing Then
                                        fs.Dispose()
                                    End If
                                    If Not img Is Nothing Then
                                        zip.AddFile(fld + "\ccthumb.jpg").FileName = "ccthumb.jpg"
                                    End If
                                End Try

                            End If
                        End If
                    End If

                    zip.AddDirectory(PublishPath)
                    zip.AddDirectory(imageFolder, "images")
                    zip.AddDirectory(bkgFolder, "backgrounds")
                    If (System.IO.Directory.Exists(videoFolder)) Then
                        zip.AddDirectory(videoFolder, "videos")
                    End If
                    DoRefreshOnActivate = False
                    Dim dlg As SaveFileDialog = New SaveFileDialog()
                    dlg.DefaultExt = ".zip"
                    dlg.Filter = "Zip archive (*.zip)|*.zip"
                    dlg.FileName = fName
                    dlg.Title = "Publish to zip"
                    If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                        zip.Save(dlg.FileName)
                        If MsgBox("Project published successfully to: " & dlg.FileName) = MsgBoxResult.Ok Then
                            System.IO.Directory.Delete(PublishPath)
                        End If
                    End If
                End Using
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub
    Public Sub PublishProjectSCORM()
        Try
            If Not itspunit Is Nothing And Not PublishPath = "" Then
                EmptyFolder(PublishPath)
                For Each pg As mstns.Page In itspunit.PageCol

                    GeneratePage(PublishPath, pg, False)
                Next
                LastPageHtml = ""
                Dim fName As String
                If itspunit.UnitName Is Nothing Then
                    fName = "ITSPUnitPublish"
                Else
                    fName = itspunit.UnitName
                End If
                Dim objImgList As ArrayList = New ArrayList
                For Each pg As mstns.Page In itspunit.PageCol
                    If pg.BackgroundImage <> "" And Not objImgList.Contains(pg.BackgroundImage) And File.Exists(bkgFolder & "\" & pg.BackgroundImage) Then
                        objImgList.Add("backgrounds/" & pg.BackgroundImage)
                    End If
                    For Each obj As mstns.Object_ In pg.ObjectCol
                        If obj.StandardImage <> "" And Not objImgList.Contains(obj.StandardImage) And File.Exists(imageFolder & "\" & obj.StandardImage) Then
                            objImgList.Add("images/" & obj.StandardImage)
                        End If
                        If obj.MouseEnterImage <> "" And Not objImgList.Contains(obj.MouseEnterImage) And File.Exists(imageFolder & "\" & obj.MouseEnterImage) Then
                            objImgList.Add("images/" & obj.MouseEnterImage)
                        End If
                        If obj.MouseDownImage <> "" And Not objImgList.Contains(obj.MouseDownImage) And File.Exists(imageFolder & "\" & obj.MouseDownImage) Then
                            objImgList.Add("images/" & obj.MouseDownImage)
                        End If
                        If obj.MouseUpImage <> "" And Not objImgList.Contains(obj.MouseUpImage) And File.Exists(imageFolder & "\" & obj.MouseUpImage) Then
                            objImgList.Add("images/" & obj.MouseUpImage)
                        End If
                    Next
                Next
                Dim StrImageList As String = ""
                For Each im As String In objImgList
                    If im <> "" Then
                        StrImageList = StrImageList & "'" & im & "', "
                    End If
                Next
                If Not StrImageList = "" Then
                    StrImageList = StrImageList.Substring(0, StrImageList.Length - 2)
                End If
                Dim trackjs As String = My.Resources.itsp_tracking_sco
                trackjs = trackjs.Replace("XXContentTypeXX", itspunit.Type)
                trackjs = trackjs.Replace("123456789", itspunit.SCOMasteryScore.ToString())
                System.IO.File.WriteAllText(PublishPath & "\js\itsp-tracking.js", trackjs)
                System.IO.File.WriteAllText(PublishPath & "\js\player-scaling.js", My.Resources.player_scaling)
                System.IO.File.WriteAllText(PublishPath & "\js\APIWrapper.js", My.Resources.APIWrapper)
                System.IO.File.WriteAllText(PublishPath & "\js\SCOFunctions.js", My.Resources.SCOFunctions)
                System.IO.File.WriteAllText(PublishPath & "\imsmd_rootv1p2p1.xsd", My.Resources.imsmd_rootv1p2p1)
                System.IO.File.WriteAllText(PublishPath & "\imscp_rootv1p1p2.xsd", My.Resources.imscp_rootv1p1p2)
                System.IO.File.WriteAllText(PublishPath & "\adlcp_rootv1p2.xsd", My.Resources.adlcp_rootv1p2)
                'generate the manifest xml files and save them to the publish folder:
                Dim xmlimsmanifest As String = My.Resources.imsmanifest.ToString()
                xmlimsmanifest = xmlimsmanifest.Replace("XXXCourseTitleXXX", itspunit.UnitName)
                xmlimsmanifest = xmlimsmanifest.Replace("XXXCourseTitleNoSpacesXXX", utility.TidyFileName(itspunit.UnitName))
                xmlimsmanifest = xmlimsmanifest.Replace("XXXPassThresholdXXX", itspunit.SCOMasteryScore.ToString())
                xmlimsmanifest = xmlimsmanifest.Replace("XXXCourseIdXXX", utility.RandomString(8))
                'generate the meta data:
                Dim metadataxml As String = My.Resources.metadata.ToString()
                metadataxml = metadataxml.Replace("XXXCourseTitleXXX", itspunit.UnitName)
                metadataxml = metadataxml.Replace("XXXCourseTitleNoSpacesXXX", utility.TidyFileName(itspunit.UnitName))
                metadataxml = metadataxml.Replace("XXXDescriptionXXXX", itspunit.SCODescription)
                metadataxml = metadataxml.Replace("XXXWidthXXX", itspunit.Width.ToString())
                metadataxml = metadataxml.Replace("XXXHeightXXX", itspunit.Height.ToString)
                System.IO.File.WriteAllText(PublishPath & "/metadata.xml", metadataxml)
                Dim htmlSource As String = My.Resources.itspplayer_sco.ToString()
                htmlSource = htmlSource.Replace("XXjquery_jsXX", "js/jquery.js")
                htmlSource = htmlSource.Replace("XXitsp-trackingXX", "js/itsp-tracking.js")
                htmlSource = htmlSource.Replace("XXplayerscaling_jsXX", "js/player-scaling.js")
                htmlSource = htmlSource.Replace("XXSCOFunctionsXX", "js/SCOFunctions.js")
                htmlSource = htmlSource.Replace("XXAPIWrapperXX", "js/APIWrapper.js")
                htmlSource = htmlSource.Replace("XXPageNameXX", utility.TidyFileName(itspunit.PageCol(0).PageName) & ".html")
                htmlSource = htmlSource.Replace("'XXImageListXX'", StrImageList)
                System.IO.File.WriteAllText(PublishPath & "/itspplayer.html", htmlSource)
                'if this is a diagnostic assessment, add the diagnostic outcome:
                If itspunit.Type = "Diagnostic" Then
                    htmlSource = My.Resources.DiagnosticOutcome.ToString()
                    htmlSource = htmlSource.Replace("XXImageWidthXX", itspunit.Width.ToString())
                    htmlSource = htmlSource.Replace("XXImageHeightXX", itspunit.Height.ToString())
                    htmlSource = htmlSource.Replace("#CDCDCD", itspunit.BrowserBackgroundColour.ToString())
                    System.IO.File.WriteAllText(PublishPath & "/diagnostic-outcome.html", htmlSource)
                End If
                'if this is a PL assessment, add the assess outcome:
                If itspunit.Type = "Post Learning" Then
                    htmlSource = My.Resources.AssessOutcome.ToString()
                    htmlSource = htmlSource.Replace("XXImageWidthXX", itspunit.Width.ToString())
                    htmlSource = htmlSource.Replace("XXImageHeightXX", itspunit.Height.ToString())
                    htmlSource = htmlSource.Replace("#CDCDCD", itspunit.BrowserBackgroundColour.ToString())
                    System.IO.File.WriteAllText(PublishPath & "/assessment-outcome.html", htmlSource)
                End If
                'get all of the files in the publish folder:
                Dim txtFiles = Directory.GetFiles(PublishPath, "*.*", SearchOption.AllDirectories).[Select](Function(nm) ((Path.GetDirectoryName(nm) & "/" & Path.GetFileName(nm)).Replace(PublishPath, "")).Replace("\", ""))
                Dim sFiles As String = ""

                For Each filenm As String In txtFiles
                    sFiles = sFiles & "<file href=""" & filenm & """ />" & vbCrLf
                Next
                txtFiles = Directory.GetFiles(imageFolder, "*.*", SearchOption.AllDirectories).[Select](Function(nm) Path.GetFileName(nm))
                For Each filenm As String In txtFiles
                    sFiles = sFiles & "<file href=""images/" & filenm & """ />" & vbCrLf
                Next
                txtFiles = Directory.GetFiles(bkgFolder, "*.*", SearchOption.AllDirectories).[Select](Function(nm) Path.GetFileName(nm))
                For Each filenm As String In txtFiles
                    sFiles = sFiles & "<file href=""backgrounds/" & filenm & """ />" & vbCrLf
                Next
                If (System.IO.Directory.Exists(videoFolder)) Then
                    txtFiles = Directory.GetFiles(videoFolder, "*.*", SearchOption.AllDirectories).[Select](Function(nm) Path.GetFileName(nm))
                    For Each filenm As String In txtFiles
                        sFiles = sFiles & "<file href=""videos/" & filenm & """ />" & vbCrLf
                    Next
                End If
                xmlimsmanifest = xmlimsmanifest.Replace("<file />", sFiles)
                System.IO.File.WriteAllText(PublishPath & "/imsmanifest.xml", xmlimsmanifest)
                Using zip As ZipFile = New ZipFile()
                    zip.AddDirectory(PublishPath)
                    zip.AddDirectory(imageFolder, "images")
                    zip.AddDirectory(bkgFolder, "backgrounds")
                    If (System.IO.Directory.Exists(videoFolder)) Then
                        zip.AddDirectory(videoFolder, "videos")
                    End If
                    DoRefreshOnActivate = False
                    Dim dlg As SaveFileDialog = New SaveFileDialog()
                    dlg.DefaultExt = ".zip"
                    dlg.Filter = "Zip archive (*.zip)|*.zip"
                    dlg.FileName = fName
                    dlg.Title = "Publish to zip"
                    If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                        zip.Save(dlg.FileName)
                        If MsgBox("Project published successfully to: " & dlg.FileName) = MsgBoxResult.Ok Then
                            System.IO.Directory.Delete(PublishPath)
                        End If
                    End If
                End Using
            End If
        Catch ex As Exception
            Dim strMsg As String = ex.Message.ToString()
            'MsgBox(strMsg)
        End Try
    End Sub



#End Region
#Region "Help"
    Private Sub CDAMain_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "ContentCreator" & ".html")
    End Sub

    Private Sub ObjectProperties1_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles ObjectProperties1.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "ObjectProperties" & ".html")
    End Sub

    Private Sub ObjectManager1_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles ObjectManager1.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "ObjectList" & ".html")
    End Sub

    Private Sub itspBackstageView_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles itspBackstageView.HelpRequested
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "BackstageView" & ".html")
    End Sub

    Private Sub CDAMain_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        Help.ShowHelp(Me, My.Settings.HTMLHelpRoute & "ContentCreator" & ".html")
    End Sub

    Private Sub btnBrowseImageEditor_Click(sender As Object, e As EventArgs) Handles btnBrowseImageEditor.Click
        SetImageEditor()
        UpdateText()
    End Sub

    Private Sub PageSettings1_Load(sender As Object, e As EventArgs) Handles PageSettings1.Load

    End Sub

#End Region

End Class
