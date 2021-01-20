<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageListControl
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
		Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
		Dim GalleryItem1 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PageListControl))
		Me.GalleryControl1 = New MyGalleryControl()
		Me.GalleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
		CType(Me.GalleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GalleryControl1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GalleryControl1
		'
		Me.GalleryControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.GalleryControl1.Controls.Add(Me.GalleryControlClient1)
		Me.GalleryControl1.DesignGalleryGroupIndex = 0
		Me.GalleryControl1.DesignGalleryItemIndex = 0
		Me.GalleryControl1.Dock = System.Windows.Forms.DockStyle.Fill
		'
		'
		'
		Me.GalleryControl1.Gallery.BackColor = System.Drawing.SystemColors.ControlLight
		Me.GalleryControl1.Gallery.ColumnCount = 1
		Me.GalleryControl1.Gallery.FixedImageSize = True
		Me.GalleryControl1.Gallery.ShowGroupCaption = False
		GalleryItemGroup1.Caption = "Pages"
		GalleryItemGroup1.CaptionAlignment = DevExpress.XtraBars.Ribbon.GalleryItemGroupCaptionAlignment.Center
		GalleryItem1.Caption = "Page 1"
		GalleryItem1.Image = CType(resources.GetObject("GalleryItem1.Image"), System.Drawing.Image)
		GalleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {GalleryItem1})
		Me.GalleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
		Me.GalleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
		Me.GalleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch
		Me.GalleryControl1.Gallery.ImageSize = New System.Drawing.Size(170, 128)
		Me.GalleryControl1.Gallery.ShowItemText = True
		Me.GalleryControl1.Location = New System.Drawing.Point(0, 0)
		Me.GalleryControl1.Name = "GalleryControl1"
		Me.GalleryControl1.Size = New System.Drawing.Size(159, 597)
		Me.GalleryControl1.TabIndex = 0
		Me.GalleryControl1.Text = "GalleryControl1"
		'
		'GalleryControlClient1
		'
		Me.GalleryControlClient1.GalleryControl = Me.GalleryControl1
		Me.GalleryControlClient1.Location = New System.Drawing.Point(1, 1)
		Me.GalleryControlClient1.Size = New System.Drawing.Size(140, 595)
		'
		'PageListControl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
		Me.AutoSize = True
		Me.Controls.Add(Me.GalleryControl1)
		Me.Name = "PageListControl"
		Me.Size = New System.Drawing.Size(159, 597)
		CType(Me.GalleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GalleryControl1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GalleryControl1 As MyGalleryControl
	Friend WithEvents GalleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient

End Class
