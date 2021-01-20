<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertiesSelectableBehaviour
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.meSelectedCSS = New DevExpress.XtraEditors.MemoEdit()
        Me.cbCorrectWhenSelected = New DevExpress.XtraEditors.CheckEdit()
        Me.cbMultiSelect = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.meSelectedCSS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCorrectWhenSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMultiSelect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LabelControl2)
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.meSelectedCSS)
        Me.LayoutControl1.Controls.Add(Me.cbCorrectWhenSelected)
        Me.LayoutControl1.Controls.Add(Me.cbMultiSelect)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(220, 284)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl2.StyleController = Me.LayoutControl1
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Enable multi-select?      "
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Correct when selected?"
        '
        'meSelectedCSS
        '
        Me.meSelectedCSS.Location = New System.Drawing.Point(12, 74)
        Me.meSelectedCSS.Name = "meSelectedCSS"
        Me.meSelectedCSS.Size = New System.Drawing.Size(196, 198)
        Me.meSelectedCSS.StyleController = Me.LayoutControl1
        Me.meSelectedCSS.TabIndex = 6
        '
        'cbCorrectWhenSelected
        '
        Me.cbCorrectWhenSelected.Location = New System.Drawing.Point(129, 12)
        Me.cbCorrectWhenSelected.Name = "cbCorrectWhenSelected"
        Me.cbCorrectWhenSelected.Properties.Caption = ""
        Me.cbCorrectWhenSelected.Size = New System.Drawing.Size(79, 19)
        Me.cbCorrectWhenSelected.StyleController = Me.LayoutControl1
        Me.cbCorrectWhenSelected.TabIndex = 5
        '
        'cbMultiSelect
        '
        Me.cbMultiSelect.Location = New System.Drawing.Point(128, 35)
        Me.cbMultiSelect.Name = "cbMultiSelect"
        Me.cbMultiSelect.Properties.Caption = ""
        Me.cbMultiSelect.Size = New System.Drawing.Size(80, 19)
        Me.cbMultiSelect.StyleController = Me.LayoutControl1
        Me.cbMultiSelect.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(220, 284)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbMultiSelect
        Me.LayoutControlItem1.Location = New System.Drawing.Point(116, 23)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(84, 23)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbCorrectWhenSelected
        Me.LayoutControlItem2.Location = New System.Drawing.Point(117, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(83, 23)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.meSelectedCSS
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 46)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(200, 218)
        Me.LayoutControlItem3.Text = "Selected CSS:"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(67, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LabelControl1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(117, 23)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LabelControl2
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 23)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(116, 23)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'PropertiesSelectableBehaviour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "PropertiesSelectableBehaviour"
        Me.Size = New System.Drawing.Size(220, 284)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.meSelectedCSS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCorrectWhenSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMultiSelect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meSelectedCSS As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cbCorrectWhenSelected As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbMultiSelect As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

End Class
