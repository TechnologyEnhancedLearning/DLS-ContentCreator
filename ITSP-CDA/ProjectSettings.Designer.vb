<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectSettings
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectSettings))
        Me.npProjectSettings = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.npBasicSettings = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.spinFontSize = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cbEnableKeyboard = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.fedFontFamily = New DevExpress.XtraEditors.FontEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.spinWidth = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.spinHeight = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbxUnitType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.tedUnitName = New DevExpress.XtraEditors.TextEdit()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cbDisableZoom = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cbAutoresize = New DevExpress.XtraEditors.CheckEdit()
        Me.lblPageBKGColour = New DevExpress.XtraEditors.LabelControl()
        Me.cedPageBKGColour = New DevExpress.XtraEditors.ColorEdit()
        Me.cedBrowserBKGColour = New DevExpress.XtraEditors.ColorEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.NavigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.spinAssessClicksWrong = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.npProjectSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.npProjectSettings.SuspendLayout()
        Me.npBasicSettings.SuspendLayout()
        CType(Me.spinFontSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEnableKeyboard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fedFontFamily.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinWidth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxUnitType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tedUnitName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.cbDisableZoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAutoresize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cedPageBKGColour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cedBrowserBKGColour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage3.SuspendLayout()
        CType(Me.spinAssessClicksWrong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'npProjectSettings
        '
        Me.npProjectSettings.Controls.Add(Me.npBasicSettings)
        Me.npProjectSettings.Controls.Add(Me.NavigationPage2)
        Me.npProjectSettings.Controls.Add(Me.NavigationPage3)
        Me.npProjectSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npProjectSettings.Location = New System.Drawing.Point(0, 0)
        Me.npProjectSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.npProjectSettings.Name = "npProjectSettings"
        Me.npProjectSettings.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.npBasicSettings, Me.NavigationPage2, Me.NavigationPage3})
        Me.npProjectSettings.RegularSize = New System.Drawing.Size(704, 472)
        Me.npProjectSettings.SelectedPage = Me.npBasicSettings
        Me.npProjectSettings.Size = New System.Drawing.Size(704, 472)
        Me.npProjectSettings.TabIndex = 0
        Me.npProjectSettings.Text = "Project Settings"
        '
        'npBasicSettings
        '
        Me.npBasicSettings.Caption = "Basic Settings"
        Me.npBasicSettings.Controls.Add(Me.LabelControl14)
        Me.npBasicSettings.Controls.Add(Me.LabelControl13)
        Me.npBasicSettings.Controls.Add(Me.spinFontSize)
        Me.npBasicSettings.Controls.Add(Me.LabelControl8)
        Me.npBasicSettings.Controls.Add(Me.cbEnableKeyboard)
        Me.npBasicSettings.Controls.Add(Me.LabelControl7)
        Me.npBasicSettings.Controls.Add(Me.fedFontFamily)
        Me.npBasicSettings.Controls.Add(Me.LabelControl6)
        Me.npBasicSettings.Controls.Add(Me.LabelControl5)
        Me.npBasicSettings.Controls.Add(Me.LabelControl4)
        Me.npBasicSettings.Controls.Add(Me.spinWidth)
        Me.npBasicSettings.Controls.Add(Me.LabelControl3)
        Me.npBasicSettings.Controls.Add(Me.spinHeight)
        Me.npBasicSettings.Controls.Add(Me.LabelControl2)
        Me.npBasicSettings.Controls.Add(Me.cbxUnitType)
        Me.npBasicSettings.Controls.Add(Me.LabelControl1)
        Me.npBasicSettings.Controls.Add(Me.tedUnitName)
        Me.npBasicSettings.ImageOptions.Image = CType(resources.GetObject("npBasicSettings.ImageOptions.Image"), System.Drawing.Image)
        Me.npBasicSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.npBasicSettings.Name = "npBasicSettings"
        Me.npBasicSettings.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.npBasicSettings.PageText = "Basic Settings"
        Me.npBasicSettings.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.npBasicSettings.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.npBasicSettings.Size = New System.Drawing.Size(509, 363)
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(436, 210)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(17, 19)
        Me.LabelControl14.TabIndex = 16
        Me.LabelControl14.Text = "px"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(36, 210)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl13.TabIndex = 15
        Me.LabelControl13.Text = "Font size:"
        '
        'spinFontSize
        '
        Me.spinFontSize.EditValue = New Decimal(New Integer() {16, 0, 0, 0})
        Me.spinFontSize.Location = New System.Drawing.Point(276, 206)
        Me.spinFontSize.Margin = New System.Windows.Forms.Padding(4)
        Me.spinFontSize.Name = "spinFontSize"
        Me.spinFontSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinFontSize.Properties.IsFloatValue = False
        Me.spinFontSize.Properties.Mask.EditMask = "N00"
        Me.spinFontSize.Properties.MaxValue = New Decimal(New Integer() {36, 0, 0, 0})
        Me.spinFontSize.Properties.MinValue = New Decimal(New Integer() {6, 0, 0, 0})
        Me.spinFontSize.Size = New System.Drawing.Size(150, 28)
        Me.spinFontSize.TabIndex = 14
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(36, 250)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(201, 19)
        Me.LabelControl8.TabIndex = 13
        Me.LabelControl8.Text = "Enable keyboard navigation:"
        '
        'cbEnableKeyboard
        '
        Me.cbEnableKeyboard.Location = New System.Drawing.Point(276, 246)
        Me.cbEnableKeyboard.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEnableKeyboard.Name = "cbEnableKeyboard"
        Me.cbEnableKeyboard.Properties.Caption = ""
        Me.cbEnableKeyboard.Size = New System.Drawing.Size(112, 27)
        Me.cbEnableKeyboard.TabIndex = 12
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(36, 170)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(37, 19)
        Me.LabelControl7.TabIndex = 11
        Me.LabelControl7.Text = "Font:"
        '
        'fedFontFamily
        '
        Me.fedFontFamily.Location = New System.Drawing.Point(276, 165)
        Me.fedFontFamily.Margin = New System.Windows.Forms.Padding(4)
        Me.fedFontFamily.Name = "fedFontFamily"
        Me.fedFontFamily.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fedFontFamily.Size = New System.Drawing.Size(201, 26)
        Me.fedFontFamily.TabIndex = 10
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(436, 129)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(40, 19)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "pixels"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(436, 90)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(40, 19)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "pixels"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(36, 90)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Width:"
        '
        'spinWidth
        '
        Me.spinWidth.EditValue = New Decimal(New Integer() {80, 0, 0, 0})
        Me.spinWidth.Location = New System.Drawing.Point(276, 86)
        Me.spinWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.spinWidth.Name = "spinWidth"
        Me.spinWidth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinWidth.Properties.IsFloatValue = False
        Me.spinWidth.Properties.Mask.EditMask = "N00"
        Me.spinWidth.Properties.MaxValue = New Decimal(New Integer() {2400, 0, 0, 0})
        Me.spinWidth.Properties.MinValue = New Decimal(New Integer() {80, 0, 0, 0})
        Me.spinWidth.Size = New System.Drawing.Size(150, 28)
        Me.spinWidth.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(36, 129)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 19)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Height:"
        '
        'spinHeight
        '
        Me.spinHeight.EditValue = New Decimal(New Integer() {80, 0, 0, 0})
        Me.spinHeight.Location = New System.Drawing.Point(276, 124)
        Me.spinHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.spinHeight.Name = "spinHeight"
        Me.spinHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinHeight.Properties.IsFloatValue = False
        Me.spinHeight.Properties.Mask.EditMask = "N00"
        Me.spinHeight.Properties.MaxValue = New Decimal(New Integer() {4096, 0, 0, 0})
        Me.spinHeight.Properties.MinValue = New Decimal(New Integer() {80, 0, 0, 0})
        Me.spinHeight.Size = New System.Drawing.Size(150, 28)
        Me.spinHeight.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(36, 51)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 19)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Type:"
        '
        'cbxUnitType
        '
        Me.cbxUnitType.Location = New System.Drawing.Point(276, 46)
        Me.cbxUnitType.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxUnitType.Name = "cbxUnitType"
        Me.cbxUnitType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxUnitType.Properties.Items.AddRange(New Object() {"Diagnostic", "Learning", "Post Learning"})
        Me.cbxUnitType.Properties.Sorted = True
        Me.cbxUnitType.Size = New System.Drawing.Size(201, 26)
        Me.cbxUnitType.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(36, 10)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Unit name:"
        '
        'tedUnitName
        '
        Me.tedUnitName.EditValue = ""
        Me.tedUnitName.Location = New System.Drawing.Point(276, 6)
        Me.tedUnitName.Margin = New System.Windows.Forms.Padding(4)
        Me.tedUnitName.Name = "tedUnitName"
        Me.tedUnitName.Size = New System.Drawing.Size(201, 26)
        Me.tedUnitName.TabIndex = 0
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "HTML Output"
        Me.NavigationPage2.Controls.Add(Me.LabelControl11)
        Me.NavigationPage2.Controls.Add(Me.cbDisableZoom)
        Me.NavigationPage2.Controls.Add(Me.LabelControl10)
        Me.NavigationPage2.Controls.Add(Me.cbAutoresize)
        Me.NavigationPage2.Controls.Add(Me.lblPageBKGColour)
        Me.NavigationPage2.Controls.Add(Me.cedPageBKGColour)
        Me.NavigationPage2.Controls.Add(Me.cedBrowserBKGColour)
        Me.NavigationPage2.Controls.Add(Me.LabelControl9)
        Me.NavigationPage2.ImageOptions.Image = CType(resources.GetObject("NavigationPage2.ImageOptions.Image"), System.Drawing.Image)
        Me.NavigationPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.NavigationPage2.Size = New System.Drawing.Size(525, 387)
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(6, 130)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(154, 19)
        Me.LabelControl11.TabIndex = 9
        Me.LabelControl11.Text = "Disable mobile zoom:"
        '
        'cbDisableZoom
        '
        Me.cbDisableZoom.Location = New System.Drawing.Point(246, 126)
        Me.cbDisableZoom.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDisableZoom.Name = "cbDisableZoom"
        Me.cbDisableZoom.Properties.Caption = ""
        Me.cbDisableZoom.Size = New System.Drawing.Size(112, 27)
        Me.cbDisableZoom.TabIndex = 8
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(6, 93)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl10.TabIndex = 7
        Me.LabelControl10.Text = "Autoresize:"
        '
        'cbAutoresize
        '
        Me.cbAutoresize.Location = New System.Drawing.Point(246, 87)
        Me.cbAutoresize.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAutoresize.Name = "cbAutoresize"
        Me.cbAutoresize.Properties.Caption = ""
        Me.cbAutoresize.Size = New System.Drawing.Size(112, 27)
        Me.cbAutoresize.TabIndex = 6
        '
        'lblPageBKGColour
        '
        Me.lblPageBKGColour.Location = New System.Drawing.Point(6, 51)
        Me.lblPageBKGColour.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPageBKGColour.Name = "lblPageBKGColour"
        Me.lblPageBKGColour.Size = New System.Drawing.Size(177, 19)
        Me.lblPageBKGColour.TabIndex = 5
        Me.lblPageBKGColour.Text = "Page background colour:"
        '
        'cedPageBKGColour
        '
        Me.cedPageBKGColour.EditValue = System.Drawing.Color.Empty
        Me.cedPageBKGColour.Location = New System.Drawing.Point(246, 46)
        Me.cedPageBKGColour.Margin = New System.Windows.Forms.Padding(4)
        Me.cedPageBKGColour.Name = "cedPageBKGColour"
        Me.cedPageBKGColour.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cedPageBKGColour.Properties.ShowSystemColors = False
        Me.cedPageBKGColour.Properties.ShowWebColors = False
        Me.cedPageBKGColour.Size = New System.Drawing.Size(238, 26)
        Me.cedPageBKGColour.TabIndex = 4
        '
        'cedBrowserBKGColour
        '
        Me.cedBrowserBKGColour.EditValue = System.Drawing.Color.Empty
        Me.cedBrowserBKGColour.Location = New System.Drawing.Point(246, 6)
        Me.cedBrowserBKGColour.Margin = New System.Windows.Forms.Padding(4)
        Me.cedBrowserBKGColour.Name = "cedBrowserBKGColour"
        Me.cedBrowserBKGColour.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cedBrowserBKGColour.Properties.ColorDialogType = DevExpress.XtraEditors.Popup.ColorDialogType.Advanced
        Me.cedBrowserBKGColour.Properties.CustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(121, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(82, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(202, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty}
        Me.cedBrowserBKGColour.Properties.ShowSystemColors = False
        Me.cedBrowserBKGColour.Properties.ShowWebColors = False
        Me.cedBrowserBKGColour.Size = New System.Drawing.Size(238, 26)
        Me.cedBrowserBKGColour.TabIndex = 3
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(6, 10)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(200, 19)
        Me.LabelControl9.TabIndex = 2
        Me.LabelControl9.Text = "Browser background colour:"
        '
        'NavigationPage3
        '
        Me.NavigationPage3.Caption = "Assessment"
        Me.NavigationPage3.Controls.Add(Me.spinAssessClicksWrong)
        Me.NavigationPage3.Controls.Add(Me.LabelControl12)
        Me.NavigationPage3.ImageOptions.Image = CType(resources.GetObject("NavigationPage3.ImageOptions.Image"), System.Drawing.Image)
        Me.NavigationPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.NavigationPage3.Name = "NavigationPage3"
        Me.NavigationPage3.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.NavigationPage3.Size = New System.Drawing.Size(525, 387)
        '
        'spinAssessClicksWrong
        '
        Me.spinAssessClicksWrong.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinAssessClicksWrong.Location = New System.Drawing.Point(372, 6)
        Me.spinAssessClicksWrong.Margin = New System.Windows.Forms.Padding(4)
        Me.spinAssessClicksWrong.Name = "spinAssessClicksWrong"
        Me.spinAssessClicksWrong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinAssessClicksWrong.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.spinAssessClicksWrong.Size = New System.Drawing.Size(112, 28)
        Me.spinAssessClicksWrong.TabIndex = 1
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(6, 10)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(314, 19)
        Me.LabelControl12.TabIndex = 0
        Me.LabelControl12.Text = "Mark wrong after how many incorrect clicks:"
        '
        'ProjectSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.npProjectSettings)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ProjectSettings"
        Me.Size = New System.Drawing.Size(704, 472)
        CType(Me.npProjectSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.npProjectSettings.ResumeLayout(False)
        Me.npBasicSettings.ResumeLayout(False)
        Me.npBasicSettings.PerformLayout()
        CType(Me.spinFontSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEnableKeyboard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fedFontFamily.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinWidth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxUnitType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tedUnitName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage2.ResumeLayout(False)
        Me.NavigationPage2.PerformLayout()
        CType(Me.cbDisableZoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAutoresize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cedPageBKGColour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cedBrowserBKGColour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage3.ResumeLayout(False)
        Me.NavigationPage3.PerformLayout()
        CType(Me.spinAssessClicksWrong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents npProjectSettings As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents npBasicSettings As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents tedUnitName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fedFontFamily As DevExpress.XtraEditors.FontEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spinWidth As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spinHeight As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxUnitType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbEnableKeyboard As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cedBrowserBKGColour As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbDisableZoom As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbAutoresize As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblPageBKGColour As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cedPageBKGColour As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spinAssessClicksWrong As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spinFontSize As DevExpress.XtraEditors.SpinEdit

End Class
