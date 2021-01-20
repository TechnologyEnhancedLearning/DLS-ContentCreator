<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectsList
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ObjectsList))
		Me.ObjectImageList = New DevExpress.XtraEditors.ImageListBoxControl()
		Me.btnDeleteObject = New DevExpress.XtraEditors.SimpleButton()
		Me.btnObjectMoveUp = New DevExpress.XtraEditors.SimpleButton()
		Me.btnObjectMoveDown = New DevExpress.XtraEditors.SimpleButton()
		Me.btnBringToFront = New DevExpress.XtraEditors.SimpleButton()
		Me.btnSendToBack = New DevExpress.XtraEditors.SimpleButton()
		CType(Me.ObjectImageList, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ObjectImageList
		'
		Me.ObjectImageList.Dock = System.Windows.Forms.DockStyle.Top
		Me.ObjectImageList.Location = New System.Drawing.Point(0, 0)
		Me.ObjectImageList.Name = "ObjectImageList"
		Me.ObjectImageList.Size = New System.Drawing.Size(204, 302)
		Me.ObjectImageList.TabIndex = 0
		'
		'btnDeleteObject
		'
		Me.btnDeleteObject.Image = CType(resources.GetObject("btnDeleteObject.Image"), System.Drawing.Image)
		Me.btnDeleteObject.Location = New System.Drawing.Point(4, 309)
		Me.btnDeleteObject.Name = "btnDeleteObject"
		Me.btnDeleteObject.Size = New System.Drawing.Size(27, 23)
		Me.btnDeleteObject.TabIndex = 1
		Me.btnDeleteObject.ToolTip = "Delete selected object(s)"
		'
		'btnObjectMoveUp
		'
		Me.btnObjectMoveUp.Image = CType(resources.GetObject("btnObjectMoveUp.Image"), System.Drawing.Image)
		Me.btnObjectMoveUp.Location = New System.Drawing.Point(38, 309)
		Me.btnObjectMoveUp.Name = "btnObjectMoveUp"
		Me.btnObjectMoveUp.Size = New System.Drawing.Size(27, 23)
		Me.btnObjectMoveUp.TabIndex = 2
		Me.btnObjectMoveUp.ToolTip = "Move up"
		'
		'btnObjectMoveDown
		'
		Me.btnObjectMoveDown.Image = CType(resources.GetObject("btnObjectMoveDown.Image"), System.Drawing.Image)
		Me.btnObjectMoveDown.Location = New System.Drawing.Point(72, 309)
		Me.btnObjectMoveDown.Name = "btnObjectMoveDown"
		Me.btnObjectMoveDown.Size = New System.Drawing.Size(27, 23)
		Me.btnObjectMoveDown.TabIndex = 3
		'
		'btnBringToFront
		'
		Me.btnBringToFront.Image = CType(resources.GetObject("btnBringToFront.Image"), System.Drawing.Image)
		Me.btnBringToFront.Location = New System.Drawing.Point(106, 309)
		Me.btnBringToFront.Name = "btnBringToFront"
		Me.btnBringToFront.Size = New System.Drawing.Size(27, 23)
		Me.btnBringToFront.TabIndex = 4
		Me.btnBringToFront.ToolTip = "Bring to front"
		'
		'btnSendToBack
		'
		Me.btnSendToBack.Image = CType(resources.GetObject("btnSendToBack.Image"), System.Drawing.Image)
		Me.btnSendToBack.Location = New System.Drawing.Point(140, 309)
		Me.btnSendToBack.Name = "btnSendToBack"
		Me.btnSendToBack.Size = New System.Drawing.Size(27, 23)
		Me.btnSendToBack.TabIndex = 5
		Me.btnSendToBack.ToolTip = "Send to back"
		'
		'ObjectsList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.btnSendToBack)
		Me.Controls.Add(Me.btnBringToFront)
		Me.Controls.Add(Me.btnObjectMoveDown)
		Me.Controls.Add(Me.btnObjectMoveUp)
		Me.Controls.Add(Me.btnDeleteObject)
		Me.Controls.Add(Me.ObjectImageList)
		Me.Name = "ObjectsList"
		Me.Size = New System.Drawing.Size(204, 340)
		CType(Me.ObjectImageList, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents ObjectImageList As DevExpress.XtraEditors.ImageListBoxControl
	Friend WithEvents btnDeleteObject As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents btnObjectMoveUp As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents btnObjectMoveDown As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents btnBringToFront As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents btnSendToBack As DevExpress.XtraEditors.SimpleButton

End Class
