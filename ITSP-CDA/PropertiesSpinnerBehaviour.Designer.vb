<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertiesSpinnerBehaviour
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbJudgeOnClick = New DevExpress.XtraEditors.CheckEdit()
        Me.txtUnits = New DevExpress.XtraEditors.TextEdit()
        Me.spinMaxVal = New DevExpress.XtraEditors.SpinEdit()
        Me.spinMinVal = New DevExpress.XtraEditors.SpinEdit()
        Me.spinDecimalPoints = New DevExpress.XtraEditors.SpinEdit()
        Me.spinStepSize = New DevExpress.XtraEditors.SpinEdit()
        Me.cbxDirection = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbxTextObject = New DevExpress.XtraEditors.ComboBoxEdit()
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
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbJudgeOnClick.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinMaxVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinMinVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinDecimalPoints.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinStepSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxDirection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTextObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.cbJudgeOnClick)
        Me.LayoutControl1.Controls.Add(Me.txtUnits)
        Me.LayoutControl1.Controls.Add(Me.spinMaxVal)
        Me.LayoutControl1.Controls.Add(Me.spinMinVal)
        Me.LayoutControl1.Controls.Add(Me.spinDecimalPoints)
        Me.LayoutControl1.Controls.Add(Me.spinStepSize)
        Me.LayoutControl1.Controls.Add(Me.cbxDirection)
        Me.LayoutControl1.Controls.Add(Me.cbxTextObject)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(221, 291)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 180)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Judge on change:"
        '
        'cbJudgeOnClick
        '
        Me.cbJudgeOnClick.Location = New System.Drawing.Point(102, 180)
        Me.cbJudgeOnClick.Name = "cbJudgeOnClick"
        Me.cbJudgeOnClick.Properties.Caption = ""
        Me.cbJudgeOnClick.Size = New System.Drawing.Size(107, 19)
        Me.cbJudgeOnClick.StyleController = Me.LayoutControl1
        Me.cbJudgeOnClick.TabIndex = 11
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(99, 156)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(110, 20)
        Me.txtUnits.StyleController = Me.LayoutControl1
        Me.txtUnits.TabIndex = 10
        '
        'spinMaxVal
        '
        Me.spinMaxVal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinMaxVal.Location = New System.Drawing.Point(99, 132)
        Me.spinMaxVal.Name = "spinMaxVal"
        Me.spinMaxVal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinMaxVal.Size = New System.Drawing.Size(110, 20)
        Me.spinMaxVal.StyleController = Me.LayoutControl1
        Me.spinMaxVal.TabIndex = 9
        '
        'spinMinVal
        '
        Me.spinMinVal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinMinVal.Location = New System.Drawing.Point(99, 108)
        Me.spinMinVal.Name = "spinMinVal"
        Me.spinMinVal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinMinVal.Size = New System.Drawing.Size(110, 20)
        Me.spinMinVal.StyleController = Me.LayoutControl1
        Me.spinMinVal.TabIndex = 8
        '
        'spinDecimalPoints
        '
        Me.spinDecimalPoints.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinDecimalPoints.Location = New System.Drawing.Point(99, 84)
        Me.spinDecimalPoints.Name = "spinDecimalPoints"
        Me.spinDecimalPoints.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinDecimalPoints.Properties.IsFloatValue = False
        Me.spinDecimalPoints.Properties.Mask.EditMask = "N00"
        Me.spinDecimalPoints.Size = New System.Drawing.Size(110, 20)
        Me.spinDecimalPoints.StyleController = Me.LayoutControl1
        Me.spinDecimalPoints.TabIndex = 7
        '
        'spinStepSize
        '
        Me.spinStepSize.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinStepSize.Location = New System.Drawing.Point(99, 60)
        Me.spinStepSize.Name = "spinStepSize"
        Me.spinStepSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinStepSize.Size = New System.Drawing.Size(110, 20)
        Me.spinStepSize.StyleController = Me.LayoutControl1
        Me.spinStepSize.TabIndex = 6
        '
        'cbxDirection
        '
        Me.cbxDirection.Location = New System.Drawing.Point(99, 12)
        Me.cbxDirection.Name = "cbxDirection"
        Me.cbxDirection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxDirection.Properties.Items.AddRange(New Object() {"Up", "Down"})
        Me.cbxDirection.Size = New System.Drawing.Size(110, 20)
        Me.cbxDirection.StyleController = Me.LayoutControl1
        Me.cbxDirection.TabIndex = 5
        '
        'cbxTextObject
        '
        Me.cbxTextObject.Location = New System.Drawing.Point(99, 36)
        Me.cbxTextObject.Name = "cbxTextObject"
        Me.cbxTextObject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxTextObject.Size = New System.Drawing.Size(110, 20)
        Me.cbxTextObject.StyleController = Me.LayoutControl1
        Me.cbxTextObject.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(221, 291)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbxTextObject
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(201, 24)
        Me.LayoutControlItem1.Text = "Text area object:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbxDirection
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(201, 24)
        Me.LayoutControlItem2.Text = "Direction:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.spinStepSize
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(201, 24)
        Me.LayoutControlItem3.Text = "Step size:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.spinDecimalPoints
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(201, 24)
        Me.LayoutControlItem4.Text = "Decimal points:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.spinMinVal
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(201, 24)
        Me.LayoutControlItem5.Text = "Minimum value:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.spinMaxVal
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(201, 24)
        Me.LayoutControlItem6.Text = "Maximum value:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtUnits
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(201, 24)
        Me.LayoutControlItem7.Text = "Units:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cbJudgeOnClick
        Me.LayoutControlItem8.Location = New System.Drawing.Point(90, 168)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(111, 103)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.LabelControl1
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(90, 103)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'PropertiesSpinnerBehaviour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "PropertiesSpinnerBehaviour"
        Me.Size = New System.Drawing.Size(221, 291)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbJudgeOnClick.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinMaxVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinMinVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinDecimalPoints.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinStepSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxDirection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTextObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cbxDirection As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbxTextObject As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbJudgeOnClick As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents spinMaxVal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinMinVal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinDecimalPoints As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinStepSize As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

End Class
