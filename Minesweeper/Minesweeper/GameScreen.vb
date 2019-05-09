Public Class GameScreen
    Private cell(,) As mine
    Private minesOnBoard As Integer
    Private x As Integer
    Private y As Integer
    Private mines As New List(Of mine)
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
                AddHandler mine.generateMinesAt, Sub(atX As Integer, atY As Integer) generateMines(atX, atY)
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

    Public Sub generateMines(x As Integer, y As Integer)
        Dim selectedMine As mine
        Dim selectedX As Integer
        Dim selectedY As Integer
        cell(x, y).isMine = True
        For i = 1 To minesOnBoard
            While True
                selectedX = Math.Floor(Rnd() * Me.x)
                selectedY = Math.Floor(Rnd() * Me.y)
                selectedMine = cell.GetValue(selectedX, selectedY) 'FIX ME
                If Not selectedMine.isMine.HasValue Then
                    selectedMine.isMine = True
                    mines.Add(selectedMine)
                    Exit While
                End If
            End While
        Next
        For Each mine In mines
            For offY = x - 1 To x + 1
                For offX = y - 1 To +1
                    cell(offX, offY).minesAround += 1
                Next
            Next
        Next
    End Sub

    Private Sub panelMines_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub panelMines_MouseClick(sender As Object, e As MouseEventArgs) Handles panelMines.MouseClick

    End Sub
End Class