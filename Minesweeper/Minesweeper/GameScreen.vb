Public Class GameScreen
    Private cell(,) As mine
    Private minesOnBoard As Integer
    Private x As Integer
    Private y As Integer
    Private mines As New List(Of mine)
    Private minesGenerated As Boolean
    Public Sub New(Optional width As Integer = 10, Optional height As Integer = 10, Optional mines As Integer = 30)

        ' This call is required by the designer.
        InitializeComponent()

        Dim x As Integer
        Dim y As Integer

        Randomize()

        Me.minesOnBoard = mines

        panelMines.Width = 32 * width
        panelMines.Height = 32 * height

        Me.x = width
        Me.y = height

        ReDim cell(width - 1, height - 1)

        For x = 0 To width - 1
            For y = 0 To height - 1
                Dim mine As New mine(x, y) With {.Top = 32 * y, .Left = 32 * x}
                AddHandler mine.mineClicked, Sub(e As MouseEventArgs, atX As Integer, atY As Integer) mineClicked(e, atX, atY)
                AddHandler mine.gameLose, Sub(atX As Integer, atY As Integer) gameLose(atX, atY)
                AddHandler mine.openNear, Sub(atX As Integer, atY As Integer) openNearMine(atX, atY)
                cell(x, y) = mine
                panelMines.Controls.Add(mine)

            Next
        Next
    End Sub

    Public Sub mineClicked(e As MouseEventArgs, x As Integer, y As Integer)
        Dim selectedMine As mine = cell(x, y)

        If Not minesGenerated Then
            generateMines(x, y)

        ElseIf e.Clicks > 1 Or e.Button = MouseButtons.Middle Then
            openNearMine(x, y)

        ElseIf e.Button = MouseButtons.Left AndAlso selectedMine.flagState = 0 Then
            selectedMine.flagState = -1

        ElseIf e.Button = MouseButtons.Right Then
            selectedMine.flagState += 1
        End If
    End Sub

    Private Sub gameLose(x As Integer, y As Integer)
        cell(x, y).BackColor = Color.Red
    End Sub

    Private Sub generateMines(x As Integer, y As Integer)
        Dim selectedMine As mine
        Dim selectedX As Integer
        Dim selectedY As Integer
        minesGenerated = True
        doNearMine(x, y, Sub(mine As mine) mine.isMine = False)
        For i = 1 To minesOnBoard
            While True
                selectedX = Math.Floor(Rnd() * Me.x)
                selectedY = Math.Floor(Rnd() * Me.y)
                selectedMine = cell.GetValue(selectedX, selectedY)
                If Not selectedMine.isMine.HasValue Then
                    selectedMine.isMine = True
                    mines.Add(selectedMine)
                    Exit While
                End If
            End While
        Next
        For Each mine In mines
            doNearMine(mine.x, mine.y, Sub(atMine As mine) atMine.minesAround += 1)
        Next
        For Each mine In cell
            If Not mine.isMine.HasValue Then
                mine.isMine = False
            End If
        Next
        cell(x, y).flagState = -1
    End Sub

    Public Sub openNearMine(x As Integer, y As Integer)
        doNearMine(x, y, Sub(mine As mine) If mine.flagState = 0 Then mine.flagState = -1)
    End Sub

    Private Sub doNearMine(x As Integer, y As Integer, action As Action(Of mine))
        For offY = y - 1 To y + 1
            If offY >= 0 And offY < Me.y Then
                For offX = x - 1 To x + 1
                    If offX >= 0 And offX < Me.x Then
                        action(cell(offX, offY))
                    End If
                Next
            End If
        Next
    End Sub
End Class