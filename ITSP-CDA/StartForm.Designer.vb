<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.RecentItemsControl1 = New ITSP_CDA.RecentItemsControl()
        Me.btnNewProject = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOpenProject = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SuspendLayout()
        '
        'RecentItemsControl1
        '
        Me.RecentItemsControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RecentItemsControl1.Location = New System.Drawing.Point(0, 103)
        Me.RecentItemsControl1.Name = "RecentItemsControl1"
        Me.RecentItemsControl1.Size = New System.Drawing.Size(718, 348)
        Me.RecentItemsControl1.TabIndex = 0
        '
        'btnNewProject
        '
        Me.btnNewProject.ImageOptions.Image = CType(resources.GetObject("btnNewProject.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNewProject.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnNewProject.Location = New System.Drawing.Point(545, 12)
        Me.btnNewProject.Name = "btnNewProject"
        Me.btnNewProject.Size = New System.Drawing.Size(75, 72)
        Me.btnNewProject.TabIndex = 1
        Me.btnNewProject.Text = "New Project"
        '
        'btnOpenProject
        '
        Me.btnOpenProject.ImageOptions.Image = CType(resources.GetObject("btnOpenProject.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOpenProject.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnOpenProject.Location = New System.Drawing.Point(626, 12)
        Me.btnOpenProject.Name = "btnOpenProject"
        Me.btnOpenProject.Size = New System.Drawing.Size(75, 72)
        Me.btnOpenProject.TabIndex = 2
        Me.btnOpenProject.Text = "Open"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(254, 25)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Create or open a project"
        '
        'StartForm
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(718, 451)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnOpenProject)
        Me.Controls.Add(Me.btnNewProject)
        Me.Controls.Add(Me.RecentItemsControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StartForm"
        Me.Text = "Digital Learning Solutions Content Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RecentItemsControl1 As ITSP_CDA.RecentItemsControl
	Friend WithEvents btnNewProject As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents btnOpenProject As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
