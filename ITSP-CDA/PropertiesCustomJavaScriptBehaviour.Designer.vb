<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertiesCustomJavaScriptBehaviour
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
        Me.meditJSString = New DevExpress.XtraEditors.MemoEdit()
        Me.PropertiesCustomJavaScriptBehaviourConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        CType(Me.meditJSString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesCustomJavaScriptBehaviourConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PropertiesCustomJavaScriptBehaviourConvertedLayout.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'meditJSString
        '
        Me.meditJSString.Location = New System.Drawing.Point(12, 28)
        Me.meditJSString.Name = "meditJSString"
        Me.meditJSString.Size = New System.Drawing.Size(198, 199)
        Me.meditJSString.StyleController = Me.PropertiesCustomJavaScriptBehaviourConvertedLayout
        Me.meditJSString.TabIndex = 2
        '
        'PropertiesCustomJavaScriptBehaviourConvertedLayout
        '
        Me.PropertiesCustomJavaScriptBehaviourConvertedLayout.Controls.Add(Me.meditJSString)
        Me.PropertiesCustomJavaScriptBehaviourConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesCustomJavaScriptBehaviourConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesCustomJavaScriptBehaviourConvertedLayout.Name = "PropertiesCustomJavaScriptBehaviourConvertedLayout"
        Me.PropertiesCustomJavaScriptBehaviourConvertedLayout.Root = Me.LayoutControlGroup1
        Me.PropertiesCustomJavaScriptBehaviourConvertedLayout.Size = New System.Drawing.Size(222, 239)
        Me.PropertiesCustomJavaScriptBehaviourConvertedLayout.TabIndex = 3
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(222, 239)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.meditJSString
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "meditJSStringitem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(202, 219)
        Me.LayoutControlItem1.Text = "JavaScript String:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(85, 13)
        '
        'PropertiesCustomJavaScriptBehaviour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.PropertiesCustomJavaScriptBehaviourConvertedLayout)
        Me.Name = "PropertiesCustomJavaScriptBehaviour"
        Me.Size = New System.Drawing.Size(222, 239)
        CType(Me.meditJSString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesCustomJavaScriptBehaviourConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PropertiesCustomJavaScriptBehaviourConvertedLayout.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents meditJSString As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PropertiesCustomJavaScriptBehaviourConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter

End Class
