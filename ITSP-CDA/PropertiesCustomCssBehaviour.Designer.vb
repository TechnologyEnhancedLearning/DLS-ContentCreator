<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertiesCustomCssBehaviour
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
        Me.components = New System.ComponentModel.Container()
        Me.meditStyleString = New DevExpress.XtraEditors.MemoEdit()
        Me.PropertiesCustomCssBehaviourConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.meditCSSClasses = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        CType(Me.meditStyleString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesCustomCssBehaviourConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PropertiesCustomCssBehaviourConvertedLayout.SuspendLayout()
        CType(Me.meditCSSClasses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'meditStyleString
        '
        Me.meditStyleString.Location = New System.Drawing.Point(12, 28)
        Me.meditStyleString.Name = "meditStyleString"
        Me.meditStyleString.Size = New System.Drawing.Size(193, 153)
        Me.meditStyleString.StyleController = Me.PropertiesCustomCssBehaviourConvertedLayout
        Me.meditStyleString.TabIndex = 1
        '
        'PropertiesCustomCssBehaviourConvertedLayout
        '
        Me.PropertiesCustomCssBehaviourConvertedLayout.Controls.Add(Me.meditCSSClasses)
        Me.PropertiesCustomCssBehaviourConvertedLayout.Controls.Add(Me.meditStyleString)
        Me.PropertiesCustomCssBehaviourConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesCustomCssBehaviourConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesCustomCssBehaviourConvertedLayout.Name = "PropertiesCustomCssBehaviourConvertedLayout"
        Me.PropertiesCustomCssBehaviourConvertedLayout.Root = Me.LayoutControlGroup1
        Me.PropertiesCustomCssBehaviourConvertedLayout.Size = New System.Drawing.Size(217, 291)
        Me.PropertiesCustomCssBehaviourConvertedLayout.TabIndex = 2
        '
        'meditCSSClasses
        '
        Me.meditCSSClasses.Location = New System.Drawing.Point(12, 201)
        Me.meditCSSClasses.Name = "meditCSSClasses"
        Me.meditCSSClasses.Size = New System.Drawing.Size(193, 78)
        Me.meditCSSClasses.StyleController = Me.PropertiesCustomCssBehaviourConvertedLayout
        Me.meditCSSClasses.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(217, 291)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.meditStyleString
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "meditStyleStringitem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(197, 173)
        Me.LayoutControlItem1.Text = "Style Text:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.meditCSSClasses
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 173)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(197, 98)
        Me.LayoutControlItem2.Text = "CSS Classes:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(62, 13)
        '
        'PropertiesCustomCssBehaviour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.PropertiesCustomCssBehaviourConvertedLayout)
        Me.Name = "PropertiesCustomCssBehaviour"
        Me.Size = New System.Drawing.Size(217, 291)
        CType(Me.meditStyleString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesCustomCssBehaviourConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PropertiesCustomCssBehaviourConvertedLayout.ResumeLayout(False)
        CType(Me.meditCSSClasses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents meditStyleString As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PropertiesCustomCssBehaviourConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents meditCSSClasses As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

End Class
