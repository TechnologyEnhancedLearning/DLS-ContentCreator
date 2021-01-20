Public Class ScormPublish
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub LoadValues()
        If Not CDAMain.itspunit Is Nothing Then
            PropertiesScormPublish1.LoadValues()
        End If
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        PropertiesScormPublish1.StoreValues()
        CDAMain.Modified = True
        CDAMain.PublishProjectSCORM()
        Me.Close()
    End Sub
End Class