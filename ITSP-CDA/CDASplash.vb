Public Class CDASplash
    Sub New
		InitializeComponent()
        Me.labelControl1.Text = "Content Creator v" & My.Settings.CurrentVersion & ", Copyright © " & DateTime.Now.Year.ToString() & " NHS Digital"
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub labelControl1_Click(sender As Object, e As EventArgs) Handles labelControl1.Click

    End Sub
End Class
