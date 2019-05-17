Public Class Options
    Private Sub Options_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim gameScreen As New GameScreen(Me, width:=numWidth.Value, height:=numHeight.Value, mines:=numMines.Value)
        gameScreen.Show()
    End Sub

    Private Sub numSize_ValueChanged(sender As Object, e As EventArgs) Handles numWidth.Validated, numHeight.Validated
        numMines.Maximum = (numHeight.Value * numWidth.Value) - 9
    End Sub

    Private Sub radDifficulty_CheckedChanged(sender As RadioButton, e As EventArgs) Handles radEasy.CheckedChanged, radMedium.CheckedChanged, radHard.CheckedChanged, radCustom.CheckedChanged
        'Updates the numHeight, numWidth, and numMines values based on the difficulty setting
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
                'Enables all UpDown boxes to be customized by the user when the custom radio button is checked
                For Each upDownBox In setValues.Keys
                    upDownBox.Enabled = True
                Next
            Else
                difficulty = radToDifficultyValues(sender)  'Gets the difficulty setting based on which radio button is checked

                For Each upDownBox In setValues.Keys
                    upDownBox.Enabled = False   'Disables each UpDownBox
                    upDownBox.Value = setValues(upDownBox)(difficulty)  'Gets the value the UpDownBox should be based on the difficulty and makes it the box's value
                Next
            End If
        End If
        numSize_ValueChanged(Nothing, Nothing)
    End Sub
End Class