<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertiesChangeMousePointerBehaviour
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
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbxCustomPointerImage = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbxMouseDownCursor = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbxMouseInCursor = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbxCustomPointerImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxMouseDownCursor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxMouseInCursor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbxCustomPointerImage)
        Me.LayoutControl1.Controls.Add(Me.cbxMouseDownCursor)
        Me.LayoutControl1.Controls.Add(Me.cbxMouseInCursor)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(214, 105)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbxCustomPointerImage
        '
        Me.cbxCustomPointerImage.Location = New System.Drawing.Point(116, 60)
        Me.cbxCustomPointerImage.Name = "cbxCustomPointerImage"
        Me.cbxCustomPointerImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCustomPointerImage.Size = New System.Drawing.Size(86, 20)
        Me.cbxCustomPointerImage.StyleController = Me.LayoutControl1
        Me.cbxCustomPointerImage.TabIndex = 6
        '
        'cbxMouseDownCursor
        '
        Me.cbxMouseDownCursor.Location = New System.Drawing.Point(116, 36)
        Me.cbxMouseDownCursor.Name = "cbxMouseDownCursor"
        Me.cbxMouseDownCursor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxMouseDownCursor.Properties.Items.AddRange(New Object() {"all-scroll", "auto", "col-resize", "crosshair", "hand", "help", "move", "no-drop", "none", "not-allowed", "pointer", "progress", "row-resize", "text", "vertical-text", "wait", "n-resize", "ne-resize", "e-resize", "sw-resize", "w-resize", "nw-resize"})
        Me.cbxMouseDownCursor.Size = New System.Drawing.Size(86, 20)
        Me.cbxMouseDownCursor.StyleController = Me.LayoutControl1
        ToolTipTitleItem1.Text = "Mouse down pointer"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "The mouse pointer to display when the mouse is down on the object."
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.cbxMouseDownCursor.SuperTip = SuperToolTip1
        Me.cbxMouseDownCursor.TabIndex = 5
        '
        'cbxMouseInCursor
        '
        Me.cbxMouseInCursor.Location = New System.Drawing.Point(116, 12)
        Me.cbxMouseInCursor.Name = "cbxMouseInCursor"
        Me.cbxMouseInCursor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxMouseInCursor.Properties.Items.AddRange(New Object() {"all-scroll", "auto", "col-resize", "crosshair", "hand", "help", "move", "no-drop", "none", "not-allowed", "pointer", "progress", "row-resize", "text", "vertical-text", "wait", "n-resize", "ne-resize", "e-resize", "sw-resize", "w-resize", "nw-resize"})
        Me.cbxMouseInCursor.Size = New System.Drawing.Size(86, 20)
        Me.cbxMouseInCursor.StyleController = Me.LayoutControl1
        ToolTipTitleItem2.Text = "Mouse in pointer"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "The mouse pointer to display when the mouse is inside the object."
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.cbxMouseInCursor.SuperTip = SuperToolTip2
        Me.cbxMouseInCursor.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(214, 105)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbxMouseInCursor
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(194, 24)
        Me.LayoutControlItem1.Text = "Mouse over pointer:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbxMouseDownCursor
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(194, 24)
        Me.LayoutControlItem2.Text = "Mouse down pointer:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbxCustomPointerImage
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(194, 37)
        Me.LayoutControlItem3.Text = "Use image:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(101, 13)
        '
        'PropertiesChangeMousePointerBehaviour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "PropertiesChangeMousePointerBehaviour"
        Me.Size = New System.Drawing.Size(214, 105)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbxCustomPointerImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxMouseDownCursor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxMouseInCursor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents cbxMouseDownCursor As DevExpress.XtraEditors.ComboBoxEdit
	Friend WithEvents cbxMouseInCursor As DevExpress.XtraEditors.ComboBoxEdit
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbxCustomPointerImage As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

End Class
