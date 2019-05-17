Public Class mine

    ''' <summary>
    ''' The amount of mines adjacent to the cell
    ''' </summary>
    ''' <returns>The amount of mines adjacent to the cell</returns>
    Public Property minesAround As Integer
        Get
            Return _minesAround
        End Get
        Set(value As Integer)
            _minesAround = value
            lblMinesAround.Text = value
        End Set
    End Property
    Private _minesAround As Integer = 0

    ''' <summary>
    ''' The state of the cell:
    ''' 0: closed
    ''' 1: Flag 1
    ''' 2: Flag 2
    ''' -1: Opened
    ''' Setting this to any value more than 2 will set the value to 0
    ''' </summary>
    ''' <returns>The state of the cell</returns>
    Public Property flagState As Integer
        Get
            Return _flagState
        End Get
        Set(value As Integer)
            If value <> _flagState Then

                'Reset the value to 0 if it is being set to more than 2
                If value > 2 Then
                    value = 0
                End If

                If value = 0 Then
                    RaiseEvent changeGuessedMinesLeft(1) 'Update the guessedMinesLeft when flag is removed
                ElseIf value > 0 Then

                    If _flagState = 0 Then
                        RaiseEvent changeGuessedMinesLeft(-1)   'Update the guessedMinesLeft when a flag is placed
                    End If

                ElseIf value = -1 AndAlso Not isMine.Value Then
                    RaiseEvent changeCellsToOpen(-1)    'Update cellsToOpen when cell is opened ond the cell is not a mine
                End If
                _flagState = value
                updateMineState()
            End If
        End Set
    End Property
    Private _flagState As Integer = 0

    ''' <summary>
    ''' If the cell has a mine
    ''' </summary>
    Public isMine As Boolean?

    ''' <summary>
    ''' If the mine in the cell has been detonated
    ''' </summary>
    Public mineDetonated As Boolean

    Public Event mineClicked As Action(Of MouseEventArgs, Integer, Integer)

    ''' <summary>
    ''' Plays the mine hit animation and shows the game over dialog based on the event args
    ''' </summary>
    Public Event gameLose As Action(Of Integer, Integer)

    ''' <summary>
    ''' Open all mines adjacent to the cell
    ''' </summary>
    Public Event openNear As Action(Of Integer, Integer)

    ''' <summary>
    ''' Updates the guessedMinesLeft value by an amount
    ''' </summary>
    Public Event changeGuessedMinesLeft As Action(Of Integer)

    ''' <summary>
    ''' Updates the cellsToOpen value by an amount
    ''' </summary>
    Public Event changeCellsToOpen As Action(Of Integer)

    ''' <summary>
    ''' The x value of the cell in the field (by cells)
    ''' </summary>
    Public x As Integer

    ''' <summary>
    ''' The y value of the cell in the field (by cells)
    ''' </summary>
    Public y As Integer

    ''' <summary>
    ''' The color the lblMinesAround text should be by it's value
    ''' </summary>
    Private fontColors As New Dictionary(Of Integer, Color) From {
        {1, Color.Blue},
        {2, Color.Lime},
        {3, Color.Red},
        {4, Color.Magenta},
        {5, Color.Maroon},
        {6, Color.Turquoise},
        {7, Color.Black},
        {8, Color.Gray}}

    Public Sub New(x As Integer, y As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.x = x
        Me.y = y
    End Sub


    ''' <summary>
    ''' Makes the cell appear as expected by the cells values
    ''' </summary>
    Public Sub updateMineState()
        Select Case flagState

            Case -1
                If isMine.Value = True Then 'If the cell contains a mine
                    If Not mineDetonated Then   'If the mine has not already been hit
                        mineDetonated = True
                        RaiseEvent changeGuessedMinesLeft(-1)   'Update the guessedMinesLeft value as if the cell was flaged
                        RaiseEvent gameLose(x, y)   'Play the mine hit animation and show the game lost dialog
                    End If
                    BackColor = Color.Red   'Make the cell look like a mine
                Else
                    If minesAround = 0 Then
                        BackColor = SystemColors.Control
                        RaiseEvent openNear(x, y)   'Open all cells adjacent as they are guaranteed safe
                    Else
                        BackColor = SystemColors.ControlDark
                        fontColors.TryGetValue(minesAround, lblMinesAround.ForeColor)
                        lblMinesAround.Visible = True
                    End If
                End If

            Case 0
                BackColor = SystemColors.ControlDark

            Case 1
                BackColor = Color.Yellow

            Case 2
                BackColor = Color.GreenYellow
        End Select

    End Sub

    Private Sub mine_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, MyBase.MouseDoubleClick,
            lblMinesAround.MouseClick, lblMinesAround.MouseDoubleClick
        RaiseEvent mineClicked(e, x, y)
    End Sub
End Class
