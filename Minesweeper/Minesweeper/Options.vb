Public Class Options

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Options_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim gameScreen As New GameScreen(numWidth.Value, numHeight.Value, numMines.Value)
        gameScreen.Show()
    End Sub
End Class