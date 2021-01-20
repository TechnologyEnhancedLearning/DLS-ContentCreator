<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectSettingsNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.ProjectSettings1 = New ITSP_CDA.ProjectSettings()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.ProjectSettings1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(462, 374)
        Me.PanelControl2.TabIndex = 2
        '
        'ProjectSettings1
        '
        Me.ProjectSettings1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProjectSettings1.Location = New System.Drawing.Point(2, 2)
        Me.ProjectSettings1.Name = "ProjectSettings1"
        Me.ProjectSettings1.Size = New System.Drawing.Size(458, 370)
        Me.ProjectSettings1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnOK)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 374)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(462, 50)
        Me.PanelControl3.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnOK.Location = New System.Drawing.Point(375, 15)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        '
        'frmProjectSettingsNew
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(462, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.Name = "frmProjectSettingsNew"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Project - Settings"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ProjectSettings1 As ITSP_CDA.ProjectSettings
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
End Class
