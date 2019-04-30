Public Class MainMenu
    Public Sub FormShow()
        Show()
    End Sub
    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Hide()
        Options.Show()
    End Sub
End Class
