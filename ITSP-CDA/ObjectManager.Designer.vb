<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ObjectManager))
        Me.ObjectImageList = New DevExpress.XtraEditors.ImageListBoxControl()
        Me.ObjectManagerConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.cbtnHide = New DevExpress.XtraEditors.CheckButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBringToFront = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMoveUp = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDeleteObject = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        CType(Me.ObjectImageList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectManagerConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ObjectManagerConvertedLayout.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ObjectImageList
        '
        Me.ObjectImageList.Cursor = System.Windows.Forms.Cursors.Default
        Me.ObjectImageList.Location = New System.Drawing.Point(12, 12)
        Me.ObjectImageList.Name = "ObjectImageList"
        Me.ObjectImageList.Size = New System.Drawing.Size(166, 122)
        Me.ObjectImageList.StyleController = Me.ObjectManagerConvertedLayout
        Me.ObjectImageList.TabIndex = 0
        '
        'ObjectManagerConvertedLayout
        '
        Me.ObjectManagerConvertedLayout.Controls.Add(Me.cbtnHide)
        Me.ObjectManagerConvertedLayout.Controls.Add(Me.SimpleButton2)
        Me.ObjectManagerConvertedLayout.Controls.Add(Me.btnBringToFront)
        Me.ObjectManagerConvertedLayout.Controls.Add(Me.SimpleButton1)
        Me.ObjectManagerConvertedLayout.Controls.Add(Me.btnMoveUp)
        Me.ObjectManagerConvertedLayout.Controls.Add(Me.btnDeleteObject)
        Me.ObjectManagerConvertedLayout.Controls.Add(Me.ObjectImageList)
        Me.ObjectManagerConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObjectManagerConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.ObjectManagerConvertedLayout.Name = "ObjectManagerConvertedLayout"
        Me.ObjectManagerConvertedLayout.Root = Me.LayoutControlGroup1
        Me.ObjectManagerConvertedLayout.Size = New System.Drawing.Size(190, 172)
        Me.ObjectManagerConvertedLayout.TabIndex = 7
        '
        'cbtnHide
        '
        Me.cbtnHide.ImageOptions.Image = CType(resources.GetObject("cbtnHide.ImageOptions.Image"), System.Drawing.Image)
        Me.cbtnHide.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cbtnHide.Location = New System.Drawing.Point(12, 138)
        Me.cbtnHide.Name = "cbtnHide"
        Me.cbtnHide.Size = New System.Drawing.Size(24, 22)
        Me.cbtnHide.StyleController = Me.ObjectManagerConvertedLayout
        Me.cbtnHide.TabIndex = 6
        Me.cbtnHide.ToolTip = "Hide object in preview"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(124, 138)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(24, 22)
        Me.SimpleButton2.StyleController = Me.ObjectManagerConvertedLayout
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.ToolTip = "Send to back"
        '
        'btnBringToFront
        '
        Me.btnBringToFront.ImageOptions.Image = CType(resources.GetObject("btnBringToFront.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBringToFront.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBringToFront.Location = New System.Drawing.Point(96, 138)
        Me.btnBringToFront.Name = "btnBringToFront"
        Me.btnBringToFront.Size = New System.Drawing.Size(24, 22)
        Me.btnBringToFront.StyleController = Me.ObjectManagerConvertedLayout
        Me.btnBringToFront.TabIndex = 4
        Me.btnBringToFront.ToolTip = "Bring to front"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(68, 138)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 22)
        Me.SimpleButton1.StyleController = Me.ObjectManagerConvertedLayout
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.ToolTip = "Move down"
        '
        'btnMoveUp
        '
        Me.btnMoveUp.ImageOptions.Image = CType(resources.GetObject("btnMoveUp.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMoveUp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnMoveUp.Location = New System.Drawing.Point(40, 138)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(24, 22)
        Me.btnMoveUp.StyleController = Me.ObjectManagerConvertedLayout
        Me.btnMoveUp.TabIndex = 2
        Me.btnMoveUp.ToolTip = "Move up"
        '
        'btnDeleteObject
        '
        Me.btnDeleteObject.ImageOptions.Image = CType(resources.GetObject("btnDeleteObject.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteObject.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDeleteObject.Location = New System.Drawing.Point(152, 138)
        Me.btnDeleteObject.Name = "btnDeleteObject"
        Me.btnDeleteObject.Size = New System.Drawing.Size(26, 22)
        Me.btnDeleteObject.StyleController = Me.ObjectManagerConvertedLayout
        Me.btnDeleteObject.TabIndex = 1
        Me.btnDeleteObject.ToolTip = "Delete selected object"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(190, 172)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbtnHide
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem1.Name = "cbtnHideitem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(112, 126)
        Me.LayoutControlItem2.Name = "SimpleButton2item"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnBringToFront
        Me.LayoutControlItem3.Location = New System.Drawing.Point(84, 126)
        Me.LayoutControlItem3.Name = "btnBringToFrontitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(56, 126)
        Me.LayoutControlItem4.Name = "SimpleButton1item"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnMoveUp
        Me.LayoutControlItem5.Location = New System.Drawing.Point(28, 126)
        Me.LayoutControlItem5.Name = "btnMoveUpitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnDeleteObject
        Me.LayoutControlItem6.Location = New System.Drawing.Point(140, 126)
        Me.LayoutControlItem6.Name = "btnDeleteObjectitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(30, 26)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.ObjectImageList
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "ObjectImageListitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(170, 126)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'ObjectManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ObjectManagerConvertedLayout)
        Me.Name = "ObjectManager"
        Me.Size = New System.Drawing.Size(190, 172)
        CType(Me.ObjectImageList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectManagerConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ObjectManagerConvertedLayout.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ObjectImageList As DevExpress.XtraEditors.ImageListBoxControl
    Friend WithEvents btnDeleteObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMoveUp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBringToFront As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbtnHide As DevExpress.XtraEditors.CheckButton
    Friend WithEvents ObjectManagerConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter

End Class
