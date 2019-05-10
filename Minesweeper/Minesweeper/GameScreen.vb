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
                AddHandler mine.mineClicked, Sub(atX As Integer, atY As Integer) mineClicked(atX, atY)
                AddHandler mine.gameLose, Sub(atX As Integer, atY As Integer) gameLose(atX, atY)
                AddHandler mine.openNear, Sub(atX As Integer, atY As Integer) openNearMine(atX, atY)
                cell(x, y) = mine
                panelMines.Controls.Add(mine)

            Next
        Next

        'gridMines.Width = 37 * width
        'gridMines.Height = 37 * height

        'gridMines.ColumnStyles.Item(0).Width = 36
        'gridMines.RowStyles.Item(0).Height = 36
        'For i = 0 To width - 2
        '    gridMines.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 36))
        'Next
        'For i = 0 To height - 2
        '    gridMines.RowStyles.Add(New RowStyle(SizeType.Absolute, 36))
        'Next
    End Sub

    Public Sub mineClicked(x As Integer, y As Integer)
        Dim selectedMine As mine = cell(x, y)
        If Not minesGenerated Then

            generateMines(x, y)

        ElseIf selectedMine.flagState = 0 Then

            selectedMine.flagState = -1

        End If
    End Sub

    Private Sub gameLose(x As Integer, y As Integer)
        Throw New NotImplementedException()
    End Sub

    Private Sub generateMines(x As Integer, y As Integer)
        Dim selectedMine As mine
        Dim selectedX As Integer
        Dim selectedY As Integer
        minesGenerated = True
        cell(x, y).isMine = False
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
            For offY = mine.y - 1 To mine.y + 1
                If offY >= 0 And offY < Me.y Then
                    For offX = mine.x - 1 To mine.x + 1
                        If offX >= 0 And offX < Me.x Then
                            cell(offX, offY).minesAround += 1
                        End If
                    Next
                End If
            Next
        Next
        For Each mine In cell
            If Not mine.isMine.HasValue Then
                mine.isMine = False
            End If
        Next
        cell(x, y).flagState = -1
    End Sub

    Public Sub openNearMine(x As Integer, y As Integer)
        Dim selectedMine As mine
        For Each mine In mines
            For offY = mine.y - 1 To mine.y + 1
                If offY >= 0 And offY < Me.y Then
                    For offX = mine.x - 1 To mine.x + 1
                        If offX >= 0 And offX < Me.x Then
                            selectedMine = cell(offX, offY)
                            If selectedMine.isMine.Value Then
                                Debug.WriteLine("HIT")
                            Else
                                If selectedMine.flagState = 0 Then
                                    selectedMine.flagState = -1 'HELPME
                                End If
                            End If
                            'If selectedMine.flagState = 0 Then
                            '    selectedMine.flagState = -1
                            'End If
                        End If
                    Next
                End If
            Next
        Next
    End Sub
End Class