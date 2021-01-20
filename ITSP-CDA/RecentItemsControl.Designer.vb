<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecentItemsControl
	''' <summary> 
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecentItemsControl))
        Me.labelControl1 = New ITSP_CDA.BackstageViewLabel()
        Me.labelControl2 = New ITSP_CDA.BackstageViewLabel()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.imageCollection3 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelControl1
        '
        Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.labelControl1.Appearance.Options.UseFont = True
        Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.labelControl1.LineVisible = True
        Me.labelControl1.Location = New System.Drawing.Point(10, 0)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.ShowLineShadow = False
        Me.labelControl1.Size = New System.Drawing.Size(340, 36)
        Me.labelControl1.TabIndex = 0
        Me.labelControl1.Text = "Recent Projects"
        '
        'labelControl2
        '
        Me.labelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.labelControl2.Appearance.Options.UseFont = True
        Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.labelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.labelControl2.LineVisible = True
        Me.labelControl2.Location = New System.Drawing.Point(14, 0)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.ShowLineShadow = False
        Me.labelControl2.Size = New System.Drawing.Size(324, 36)
        Me.labelControl2.TabIndex = 1
        Me.labelControl2.Text = "Recent Places"
        '
        'splitContainer1
        '
        Me.splitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.ForeColor = System.Drawing.Color.Transparent
        Me.splitContainer1.IsSplitterFixed = True
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.labelControl1)
        Me.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.splitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.panel2)
        Me.splitContainer1.Panel2.Controls.Add(Me.labelControl4)
        Me.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Transparent
        Me.splitContainer1.Size = New System.Drawing.Size(720, 515)
        Me.splitContainer1.SplitterDistance = 360
        Me.splitContainer1.TabIndex = 2
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.labelControl2)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(4, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Padding = New System.Windows.Forms.Padding(14, 0, 14, 0)
        Me.panel2.Size = New System.Drawing.Size(352, 515)
        Me.panel2.TabIndex = 2
        '
        'labelControl4
        '
        Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.labelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical
        Me.labelControl4.LineVisible = True
        Me.labelControl4.Location = New System.Drawing.Point(0, 0)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(4, 515)
        Me.labelControl4.TabIndex = 3
        '
        'imageCollection3
        '
        Me.imageCollection3.ImageSize = New System.Drawing.Size(15, 15)
        Me.imageCollection3.ImageStream = CType(resources.GetObject("imageCollection3.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection3.Images.SetKeyName(0, "pin-F1.png")
        Me.imageCollection3.Images.SetKeyName(1, "pin-F2.png")
        Me.imageCollection3.InsertGalleryImage("edit_16x16.png", "images/edit/edit_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/edit_16x16.png"), 2)
        Me.imageCollection3.Images.SetKeyName(2, "edit_16x16.png")
        '
        'imageCollection1
        '
        Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection1.InsertGalleryImage("edit_32x32.png", "images/edit/edit_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/edit_32x32.png"), 0)
        Me.imageCollection1.Images.SetKeyName(0, "edit_32x32.png")
        Me.imageCollection1.InsertGalleryImage("up_32x32.png", "images/navigation/up_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/up_32x32.png"), 1)
        Me.imageCollection1.Images.SetKeyName(1, "up_32x32.png")
        '
        'RecentItemsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "RecentItemsControl"
        Me.Size = New System.Drawing.Size(720, 515)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private labelControl1 As BackstageViewLabel
    Private labelControl2 As BackstageViewLabel
    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private imageCollection3 As DevExpress.Utils.ImageCollection
    Private imageCollection1 As DevExpress.Utils.ImageCollection
    Private panel2 As System.Windows.Forms.Panel
    Private labelControl4 As DevExpress.XtraEditors.LabelControl

End Class
