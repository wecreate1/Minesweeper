Public Class GameScreen
    Private mines(,) As mine
    Public Sub New(Optional width As Integer = 10, Optional height As Integer = 10, Optional mines As Integer = 30)

        ' This call is required by the designer.
        InitializeComponent()

        gridMines.ColumnCount = width
        gridMines.RowCount = height

        ReDim Me.mines(width, height)

        For x = 0 To width - 1
            For y = 0 To height - 1
                Dim mine As New mine
                Me.mines(x, y) = mine
                gridMines.Controls.Add(mine)
                gridMines.SetColumn(mine, x)
                gridMines.SetRow(mine, y)
            Next
        Next

        gridMines.Width = 37 * width
        gridMines.Height = 37 * height

        gridMines.ColumnStyles.Item(0).Width = 36
        gridMines.RowStyles.Item(0).Height = 36
        For i = 0 To width - 2
            gridMines.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 36))
        Next
        For i = 0 To height - 2
            gridMines.RowStyles.Add(New RowStyle(SizeType.Absolute, 36))
        Next
    End Sub
End Class