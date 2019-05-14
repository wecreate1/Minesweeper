Public Class GameScreen
    Private cells(,) As mine
    Private minesOnBoard As Integer
    Private x As Integer
    Private y As Integer
    Private mines As New List(Of mine)
    Private minesGenerated As Boolean
    Private parent As Form
    Public Sub New(parent As Form, Optional width As Integer = 10, Optional height As Integer = 10, Optional mines As Integer = 30)

        ' This call is required by the designer.
        InitializeComponent()

        Me.parent = parent

        Dim x As Integer
        Dim y As Integer

        Randomize()

        Me.minesOnBoard = mines

        panelMines.Width = 32 * width
        panelMines.Height = 32 * height

        Me.x = width
        Me.y = height

        ReDim cells(width - 1, height - 1)

        For x = 0 To width - 1
            For y = 0 To height - 1
                Dim mine As New mine(x, y) With {.Top = 32 * y, .Left = 32 * x}
                AddHandler mine.mineClicked, Sub(e As MouseEventArgs, atX As Integer, atY As Integer) mineClicked(e, atX, atY)
                AddHandler mine.gameLose, Sub(atX As Integer, atY As Integer) gameLose(atX, atY)
                AddHandler mine.openNear, Sub(atX As Integer, atY As Integer) openNearMine(atX, atY)
                cells(x, y) = mine
                panelMines.Controls.Add(mine)

            Next
        Next
    End Sub

    Public Sub mineClicked(e As MouseEventArgs, x As Integer, y As Integer)
        Dim selectedMine As mine = cells(x, y)
        selectedMine.isMine = False
        selectedMine.minesAround = x + 1
        selectedMine.flagState = -1
        'If Not minesGenerated Then
        '    generateMines(x, y)
        'ElseIf e.Button = MouseButtons.Right AndAlso selectedMine.flagState <> -1 Then
        '    selectedMine.flagState += 1
        'ElseIf e.Clicks > 1 Or e.Button = MouseButtons.Middle Then
        '    openNearMine(x, y)
        'ElseIf e.Button = MouseButtons.Left AndAlso selectedMine.flagState = 0 Then
        '    selectedMine.flagState = -1
        'End If
    End Sub

    Private Sub gameLose(x As Integer, y As Integer)
        Dim possibleExplosionRadii As Integer()
        Dim maxExplosionRadius As Integer
        Dim atX As Integer
        Dim atY As Integer
        Dim corner As Integer
        Dim direction As Integer
        Dim selectedCell As mine
        'Dim side As Integer
        selectedCell = cells(x, y)
        If selectedCell.hasBeenOpened Then
            Return
        End If
        selectedCell.hasBeenOpened = True
        possibleExplosionRadii = {x, y, Me.x - x, Me.y - y}
        maxExplosionRadius = possibleExplosionRadii.Max()
        For r = 1 To maxExplosionRadius
            For side = -1 To 1 Step 2
                For axis = -1 To 1 Step 2
                    corner = r * side * axis
                    direction = -side * axis
                    For off = corner + direction To -corner Step direction
                        atX = x
                        atY = y
                        If axis = -1 Then
                            atX += off
                            atY += (r * side)
                        Else
                            atX += (r * side)
                            atY += off
                        End If
                        If atY >= 0 AndAlso atY < Me.y AndAlso
                            atX >= 0 AndAlso atX < Me.x Then
                            selectedCell = cells(atX, atY)
                            selectedCell.BackColor = Color.Purple
                            selectedCell.Update()
                            Threading.Thread.Sleep(10)
                        End If
                    Next
                Next
                'side = r * direction
                'For offX = -side + direction To side Step direction
                '    atX = x + offX
                '    atY = y + (r * direction)
                'If atY >= 0 AndAlso atY < Me.y AndAlso
                '    atX >= 0 AndAlso atX < Me.x Then
                '    cell(atX, atY).BackColor = Color.Purple
                '    cell(atX, atY).Update()
                '    Threading.Thread.Sleep(10)
                'End If
                'Next
                'For offY = side - direction To -side Step -direction
                '    atX = x + (r * direction)
                '    atY = y + offY
                '    If atY >= 0 AndAlso atY < Me.y AndAlso
                '        atX >= 0 AndAlso atX < Me.x Then
                '        cell(atX, atY).BackColor = Color.Purple
                '        cell(atX, atY).Update()
                '        Threading.Thread.Sleep(10)
                '    End If
                'Next
            Next
        Next
        Update()
        Threading.Thread.Sleep(1000)
        Dim result As Integer
        result = GameOverLoss.ShowDialog()
        If result = 1 Then
            Close()
        Else
            For Each cell In cells
                cell.updateMineState()
            Next
        End If
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
                selectedMine = cells.GetValue(selectedX, selectedY)
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
        For Each mine In cells
            If Not mine.isMine.HasValue Then
                mine.isMine = False
            End If
        Next
        cells(x, y).flagState = -1
    End Sub

    Public Sub openNearMine(x As Integer, y As Integer)
        If Not cells(x, y).hasBeenOpened Then
            doNearMine(x, y, Sub(mine As mine) If mine.flagState = 0 Then mine.flagState = -1)
        End If
    End Sub

    Private Sub doNearMine(x As Integer, y As Integer, action As Action(Of mine))
        For offY = y - 1 To y + 1
            If offY >= 0 And offY < Me.y Then
                For offX = x - 1 To x + 1
                    If offX >= 0 And offX < Me.x Then
                        action(cells(offX, offY))
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub GameScreen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        parent.BringToFront()
    End Sub
End Class