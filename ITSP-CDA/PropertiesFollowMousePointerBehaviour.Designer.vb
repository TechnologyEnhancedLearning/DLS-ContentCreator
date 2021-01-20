<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertiesFollowMousePointerBehaviour
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
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.spinOffsetVPixels = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.spinOffsetHPixels = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.spinOffsetVPixels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinOffsetHPixels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LabelControl2)
        Me.LayoutControl1.Controls.Add(Me.spinOffsetVPixels)
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.spinOffsetHPixels)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(214, 73)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(190, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.StyleController = Me.LayoutControl1
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "px"
        '
        'spinOffsetVPixels
        '
        Me.spinOffsetVPixels.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinOffsetVPixels.Location = New System.Drawing.Point(99, 36)
        Me.spinOffsetVPixels.Name = "spinOffsetVPixels"
        Me.spinOffsetVPixels.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinOffsetVPixels.Properties.IsFloatValue = False
        Me.spinOffsetVPixels.Properties.Mask.EditMask = "n0"
        Me.spinOffsetVPixels.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.spinOffsetVPixels.Properties.MinValue = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.spinOffsetVPixels.Size = New System.Drawing.Size(87, 20)
        Me.spinOffsetVPixels.StyleController = Me.LayoutControl1
        Me.spinOffsetVPixels.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(190, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "px"
        '
        'spinOffsetHPixels
        '
        Me.spinOffsetHPixels.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinOffsetHPixels.Location = New System.Drawing.Point(99, 12)
        Me.spinOffsetHPixels.Name = "spinOffsetHPixels"
        Me.spinOffsetHPixels.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spinOffsetHPixels.Properties.IsFloatValue = False
        Me.spinOffsetHPixels.Properties.Mask.EditMask = "n0"
        Me.spinOffsetHPixels.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.spinOffsetHPixels.Properties.MinValue = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.spinOffsetHPixels.Size = New System.Drawing.Size(87, 20)
        Me.spinOffsetHPixels.StyleController = Me.LayoutControl1
        ToolTipTitleItem1.Text = "Horizontal offset"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "The number of pixels to offset the image by horizontally relative to the mouse po" &
    "sition."
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = "Example:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10 = ten pixels to the right of the mouse pointer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-10 = ten pixels" &
    " to the left of the mouse pointer"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        Me.spinOffsetHPixels.SuperTip = SuperToolTip1
        Me.spinOffsetHPixels.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(214, 73)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.spinOffsetHPixels
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(178, 24)
        Me.LayoutControlItem1.Text = "Horizontal offset:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LabelControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(178, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(16, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.spinOffsetVPixels
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(178, 29)
        Me.LayoutControlItem3.Text = "Vertical offset:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LabelControl2
        Me.LayoutControlItem4.Location = New System.Drawing.Point(178, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(16, 29)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'PropertiesFollowMousePointerBehaviour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "PropertiesFollowMousePointerBehaviour"
        Me.Size = New System.Drawing.Size(214, 73)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.spinOffsetVPixels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinOffsetHPixels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents spinOffsetVPixels As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents spinOffsetHPixels As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

End Class
