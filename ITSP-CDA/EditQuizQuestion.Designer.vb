<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditQuizQuestion
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbxLayout = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbxGotoPageIncorrect = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbxGotoPageCorrect = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnEditQuizCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditQuizOK = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.meditHint = New DevExpress.XtraEditors.MemoEdit()
        Me.cbShuffle = New DevExpress.XtraEditors.CheckEdit()
        Me.meditIncorrectFeedback = New DevExpress.XtraEditors.MemoEdit()
        Me.meditCorrectFeedback = New DevExpress.XtraEditors.MemoEdit()
        Me.ChoicesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcCorrectCheckBox = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.gcChoiceText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.meditQuestionPrompt = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ITSPUnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbxLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxGotoPageIncorrect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxGotoPageCorrect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meditHint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbShuffle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meditIncorrectFeedback.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meditCorrectFeedback.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoicesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meditQuestionPrompt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITSPUnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbxLayout)
        Me.LayoutControl1.Controls.Add(Me.cbxGotoPageIncorrect)
        Me.LayoutControl1.Controls.Add(Me.cbxGotoPageCorrect)
        Me.LayoutControl1.Controls.Add(Me.btnEditQuizCancel)
        Me.LayoutControl1.Controls.Add(Me.btnEditQuizOK)
        Me.LayoutControl1.Controls.Add(Me.SeparatorControl1)
        Me.LayoutControl1.Controls.Add(Me.meditHint)
        Me.LayoutControl1.Controls.Add(Me.cbShuffle)
        Me.LayoutControl1.Controls.Add(Me.meditIncorrectFeedback)
        Me.LayoutControl1.Controls.Add(Me.meditCorrectFeedback)
        Me.LayoutControl1.Controls.Add(Me.ChoicesGridControl)
        Me.LayoutControl1.Controls.Add(Me.meditQuestionPrompt)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(734, 566)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbxLayout
        '
        Me.cbxLayout.Location = New System.Drawing.Point(117, 304)
        Me.cbxLayout.Name = "cbxLayout"
        Me.cbxLayout.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxLayout.Properties.Items.AddRange(New Object() {"Centred wide", "Centred", "Left", "Right"})
        Me.cbxLayout.Size = New System.Drawing.Size(605, 20)
        Me.cbxLayout.StyleController = Me.LayoutControl1
        Me.cbxLayout.TabIndex = 15
        '
        'cbxGotoPageIncorrect
        '
        Me.cbxGotoPageIncorrect.Location = New System.Drawing.Point(117, 386)
        Me.cbxGotoPageIncorrect.Name = "cbxGotoPageIncorrect"
        Me.cbxGotoPageIncorrect.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxGotoPageIncorrect.Size = New System.Drawing.Size(605, 20)
        Me.cbxGotoPageIncorrect.StyleController = Me.LayoutControl1
        Me.cbxGotoPageIncorrect.TabIndex = 14
        '
        'cbxGotoPageCorrect
        '
        Me.cbxGotoPageCorrect.Location = New System.Drawing.Point(117, 362)
        Me.cbxGotoPageCorrect.Name = "cbxGotoPageCorrect"
        Me.cbxGotoPageCorrect.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxGotoPageCorrect.Size = New System.Drawing.Size(605, 20)
        Me.cbxGotoPageCorrect.StyleController = Me.LayoutControl1
        Me.cbxGotoPageCorrect.TabIndex = 13
        '
        'btnEditQuizCancel
        '
        Me.btnEditQuizCancel.Location = New System.Drawing.Point(12, 532)
        Me.btnEditQuizCancel.MaximumSize = New System.Drawing.Size(70, 0)
        Me.btnEditQuizCancel.Name = "btnEditQuizCancel"
        Me.btnEditQuizCancel.Size = New System.Drawing.Size(70, 22)
        Me.btnEditQuizCancel.StyleController = Me.LayoutControl1
        Me.btnEditQuizCancel.TabIndex = 12
        Me.btnEditQuizCancel.Text = "Cancel"
        '
        'btnEditQuizOK
        '
        Me.btnEditQuizOK.Location = New System.Drawing.Point(652, 532)
        Me.btnEditQuizOK.MaximumSize = New System.Drawing.Size(70, 0)
        Me.btnEditQuizOK.Name = "btnEditQuizOK"
        Me.btnEditQuizOK.Size = New System.Drawing.Size(70, 22)
        Me.btnEditQuizOK.StyleController = Me.LayoutControl1
        Me.btnEditQuizOK.TabIndex = 11
        Me.btnEditQuizOK.Text = "OK"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(117, 410)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(605, 20)
        Me.SeparatorControl1.TabIndex = 10
        '
        'meditHint
        '
        Me.meditHint.Location = New System.Drawing.Point(117, 328)
        Me.meditHint.MinimumSize = New System.Drawing.Size(0, 30)
        Me.meditHint.Name = "meditHint"
        Me.meditHint.Size = New System.Drawing.Size(605, 30)
        Me.meditHint.StyleController = Me.LayoutControl1
        Me.meditHint.TabIndex = 9
        '
        'cbShuffle
        '
        Me.cbShuffle.Location = New System.Drawing.Point(12, 281)
        Me.cbShuffle.Name = "cbShuffle"
        Me.cbShuffle.Properties.Caption = "Shuffle choices     "
        Me.cbShuffle.Size = New System.Drawing.Size(710, 19)
        Me.cbShuffle.StyleController = Me.LayoutControl1
        Me.cbShuffle.TabIndex = 8
        '
        'meditIncorrectFeedback
        '
        Me.meditIncorrectFeedback.Location = New System.Drawing.Point(117, 483)
        Me.meditIncorrectFeedback.MinimumSize = New System.Drawing.Size(0, 45)
        Me.meditIncorrectFeedback.Name = "meditIncorrectFeedback"
        Me.meditIncorrectFeedback.Size = New System.Drawing.Size(605, 45)
        Me.meditIncorrectFeedback.StyleController = Me.LayoutControl1
        Me.meditIncorrectFeedback.TabIndex = 7
        '
        'meditCorrectFeedback
        '
        Me.meditCorrectFeedback.Location = New System.Drawing.Point(117, 434)
        Me.meditCorrectFeedback.MinimumSize = New System.Drawing.Size(0, 45)
        Me.meditCorrectFeedback.Name = "meditCorrectFeedback"
        Me.meditCorrectFeedback.Size = New System.Drawing.Size(605, 45)
        Me.meditCorrectFeedback.StyleController = Me.LayoutControl1
        Me.meditCorrectFeedback.TabIndex = 6
        '
        'ChoicesGridControl
        '
        Me.ChoicesGridControl.Location = New System.Drawing.Point(12, 113)
        Me.ChoicesGridControl.MainView = Me.GridView1
        Me.ChoicesGridControl.MaximumSize = New System.Drawing.Size(0, 300)
        Me.ChoicesGridControl.Name = "ChoicesGridControl"
        Me.ChoicesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemMemoEdit1})
        Me.ChoicesGridControl.Size = New System.Drawing.Size(710, 164)
        Me.ChoicesGridControl.TabIndex = 5
        Me.ChoicesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcCorrectCheckBox, Me.gcChoiceText})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(870, 545, 210, 172)
        Me.GridView1.GridControl = Me.ChoicesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "Enter a new choice"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'gcCorrectCheckBox
        '
        Me.gcCorrectCheckBox.Caption = "Correct"
        Me.gcCorrectCheckBox.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.gcCorrectCheckBox.FieldName = "Correct"
        Me.gcCorrectCheckBox.Name = "gcCorrectCheckBox"
        Me.gcCorrectCheckBox.Visible = True
        Me.gcCorrectCheckBox.VisibleIndex = 0
        Me.gcCorrectCheckBox.Width = 82
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'gcChoiceText
        '
        Me.gcChoiceText.Caption = "Choice text"
        Me.gcChoiceText.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcChoiceText.FieldName = "ChoiceText"
        Me.gcChoiceText.Name = "gcChoiceText"
        Me.gcChoiceText.Visible = True
        Me.gcChoiceText.VisibleIndex = 1
        Me.gcChoiceText.Width = 614
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'meditQuestionPrompt
        '
        Me.meditQuestionPrompt.Location = New System.Drawing.Point(12, 28)
        Me.meditQuestionPrompt.MaximumSize = New System.Drawing.Size(0, 80)
        Me.meditQuestionPrompt.Name = "meditQuestionPrompt"
        Me.meditQuestionPrompt.Size = New System.Drawing.Size(710, 65)
        Me.meditQuestionPrompt.StyleController = Me.LayoutControl1
        Me.meditQuestionPrompt.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(734, 566)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.meditQuestionPrompt
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(714, 85)
        Me.LayoutControlItem1.Text = "Question / prompt:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ChoicesGridControl
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 85)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(714, 184)
        Me.LayoutControlItem2.Text = "Choices"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.meditCorrectFeedback
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 422)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(714, 49)
        Me.LayoutControlItem3.Text = "Correct:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.meditIncorrectFeedback
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 471)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(714, 49)
        Me.LayoutControlItem4.Text = "Incorrect:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbShuffle
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 269)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(714, 23)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.meditHint
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 316)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(714, 34)
        Me.LayoutControlItem6.Text = "Hint text:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SeparatorControl1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 398)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(714, 24)
        Me.LayoutControlItem7.Text = "Feedback"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnEditQuizOK
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopRight
        Me.LayoutControlItem8.Location = New System.Drawing.Point(74, 520)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(640, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnEditQuizCancel
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 520)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(74, 26)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbxGotoPageCorrect
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 350)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(714, 24)
        Me.LayoutControlItem10.Text = "Go to page correct:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cbxGotoPageIncorrect
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 374)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(714, 24)
        Me.LayoutControlItem11.Text = "Go to page incorrect:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cbxLayout
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 292)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(714, 24)
        Me.LayoutControlItem12.Text = "Question layout:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(102, 13)
        '
        'ITSPUnitBindingSource
        '
        Me.ITSPUnitBindingSource.DataSource = GetType(mstns.ITSPUnit)
        '
        'EditQuizQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(734, 566)
        Me.Controls.Add(Me.LayoutControl1)
        Me.HelpButton = True
        Me.Name = "EditQuizQuestion"
        Me.Text = "Edit Quiz Question"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbxLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxGotoPageIncorrect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxGotoPageCorrect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meditHint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbShuffle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meditIncorrectFeedback.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meditCorrectFeedback.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoicesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meditQuestionPrompt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITSPUnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ChoicesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcCorrectCheckBox As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gcChoiceText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents meditQuestionPrompt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents meditIncorrectFeedback As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents meditCorrectFeedback As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnEditQuizCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditQuizOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents meditHint As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cbShuffle As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ITSPUnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cbxGotoPageIncorrect As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbxGotoPageCorrect As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbxLayout As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
End Class
