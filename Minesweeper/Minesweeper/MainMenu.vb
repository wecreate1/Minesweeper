Public Class MainMenu
    Public Sub FormShow()
        Show()
    End Sub
    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Hide()
        Options.Show()
    End Sub

    Private Sub btnQuickPlay_Click(sender As Object, e As EventArgs) Handles btnQuickPlay.Click
        Dim gameScreen As New GameScreen(Me, width:=16, height:=16, mines:=40)
        gameScreen.Show()
    End Sub
End Class
