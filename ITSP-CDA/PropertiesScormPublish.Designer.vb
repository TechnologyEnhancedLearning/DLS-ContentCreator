<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertiesScormPublish
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.meditDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.spinMasteryScore = New DevExpress.XtraEditors.SpinEdit()
        Me.txtKeyWords = New DevExpress.XtraEditors.TextEdit()
        Me.txtProjectName = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.meditDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinMasteryScore.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKeyWords.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.meditDescription)
        Me.LayoutControl1.Controls.Add(Me.spinMasteryScore)
        Me.LayoutControl1.Controls.Add(Me.txtKeyWords)
        Me.LayoutControl1.Controls.Add(Me.txtProjectName)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(202, 256)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 218)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(177, 12)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "SCORM publishing is in early access"
        '
        'meditDescription
        '
        Me.meditDescription.Location = New System.Drawing.Point(88, 36)
        Me.meditDescription.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.meditDescription.Name = "meditDescription"
        Me.meditDescription.Size = New System.Drawing.Size(102, 130)
        Me.meditDescription.StyleController = Me.LayoutControl1
        Me.meditDescription.TabIndex = 8
        '
        'spinMasteryScore
        '
        Me.spinMasteryScore.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinMasteryScore.Location = New System.Drawing.Point(88, 194)
        Me.spinMasteryScore.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.spinMasteryScore.Name = "spinMasteryScore"
        Me.spinMasteryScore.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinMasteryScore.Properties.IsFloatValue = False
        Me.spinMasteryScore.Properties.Mask.EditMask = "N00"
        Me.spinMasteryScore.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.spinMasteryScore.Size = New System.Drawing.Size(102, 20)
        Me.spinMasteryScore.StyleController = Me.LayoutControl1
        Me.spinMasteryScore.TabIndex = 7
        '
        'txtKeyWords
        '
        Me.txtKeyWords.Location = New System.Drawing.Point(88, 170)
        Me.txtKeyWords.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtKeyWords.Name = "txtKeyWords"
        Me.txtKeyWords.Size = New System.Drawing.Size(102, 20)
        Me.txtKeyWords.StyleController = Me.LayoutControl1
        ToolTipTitleItem1.Text = "Key words"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Include one or more keywords to include in the SCORM object manifest file. These " &
    "will be used to help learners search for your content in your LMS. Separate word" &
    "s with a space."
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txtKeyWords.SuperTip = SuperToolTip1
        Me.txtKeyWords.TabIndex = 6
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(88, 12)
        Me.txtProjectName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(102, 20)
        Me.txtProjectName.StyleController = Me.LayoutControl1
        Me.txtProjectName.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 4
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(202, 256)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtProjectName
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(182, 24)
        Me.LayoutControlItem1.Text = "Project name:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(72, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 222)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(182, 14)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtKeyWords
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 158)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(182, 24)
        Me.LayoutControlItem3.Text = "Key words:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(72, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.spinMasteryScore
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 182)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(182, 24)
        Me.LayoutControlItem4.Text = "Mastery score:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(72, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.meditDescription
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(182, 134)
        Me.LayoutControlItem2.Text = "Description:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(72, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LabelControl1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 206)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(182, 16)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'PropertiesScormPublish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PropertiesScormPublish"
        Me.Size = New System.Drawing.Size(202, 256)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.meditDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinMasteryScore.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKeyWords.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents spinMasteryScore As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtKeyWords As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProjectName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents meditDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
