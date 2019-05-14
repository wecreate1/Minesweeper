Public Class Options
    Private Sub Options_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim gameScreen As New GameScreen(Me, width:=numWidth.Value, height:=numHeight.Value, mines:=numMines.Value)
        gameScreen.Show()
    End Sub

    Private Sub numHeight_ValueChanged(sender As Object, e As EventArgs) Handles numWidth.Validated, numHeight.Validated
        numMines.Maximum = (numHeight.Value * numWidth.Value) - 8
    End Sub

    Private Sub radDifficulty_CheckedChanged(sender As RadioButton, e As EventArgs) Handles radEasy.CheckedChanged, radMedium.CheckedChanged, radHard.CheckedChanged, radCustom.CheckedChanged
        Dim setValues As New Dictionary(Of NumericUpDown, Integer()) From
            {{numHeight, {9, 16, 16}},
            {numWidth, {9, 16, 30}},
            {numMines, {10, 40, 99}}}
        Dim radToDifficultyValues As New Dictionary(Of RadioButton, Integer) From
            {{radEasy, 0},
            {radMedium, 1},
            {radHard, 2}}
        Dim difficulty As Integer
        If sender.Checked Then
            If sender.Equals(radCustom) Then
                For Each upDownBox In setValues.Keys
                    upDownBox.Enabled = True
                Next
            Else
                For Each upDownBox In setValues.Keys
                    upDownBox.Enabled = False
                    difficulty = radToDifficultyValues(sender)
                    upDownBox.Value = setValues(upDownBox)(difficulty)
                Next
            End If
        End If
    End Sub
End Class