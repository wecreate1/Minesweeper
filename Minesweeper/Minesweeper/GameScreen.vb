Public Class GameScreen


    ''' <summary>
    ''' All cells on the field
    ''' </summary>
    Private cells(,) As mine


    ''' <summary>
    ''' The amount of mines on the board
    ''' </summary>
    Private minesOnBoard As Integer


    ''' <summary>
    ''' The amount of flags needed to equal the minesOnBoard
    ''' </summary>
    ''' <returns>The amount of flags needed to equal the minesOnBoard</returns>
    Private Property guessedMinesLeft As Integer
        Get
            Return _guessedMinesLeft
        End Get
        Set(value As Integer)
            _guessedMinesLeft = value
            lblMinesLeft.Text = "Mines Left: " & value
        End Set
    End Property
    Private _guessedMinesLeft As Integer

    ''' <summary>
    ''' The amount of cells that haven't been opened and that are not mines
    ''' </summary>
    ''' <returns>The amount of cells that haven't been opened and that are not mines</returns>
    Private Property cellsLeftToOpen As Integer
        Get
            Return _cellsLeftToOpen
        End Get
        Set(value As Integer)
            _cellsLeftToOpen = value
            If _cellsLeftToOpen = 0 Then
                gameWin()
            End If
        End Set
    End Property
    Private _cellsLeftToOpen As Integer

    ''' <summary>
    ''' The width of the field (in cells)
    ''' </summary>
    Private x As Integer

    ''' <summary>
    ''' The height of the field (in cells)
    ''' </summary>
    Private y As Integer

    ''' <summary>
    ''' If the mines have been generated
    ''' </summary>
    Private minesGenerated As Boolean

    ''' <summary>
    ''' The form to reopen when the screen is closed
    ''' </summary>
    Private sender As Form

    ''' <summary>
    ''' The form the game is played on
    ''' </summary>
    ''' <param name="parent">The sender form which will be reopened when the screen is closed</param>
    ''' <param name="width">The width of the field (in cells)</param>
    ''' <param name="height">The height of the field (in cells)</param>
    ''' <param name="mines">The amount of mines on the board</param>
    Public Sub New(parent As Form, Optional width As Integer = 10, Optional height As Integer = 10, Optional mines As Integer = 30)

        ' This call is required by the designer.
        InitializeComponent()

        Me.sender = parent

        Randomize()

        guessedMinesLeft = mines    'Sets the initial value for guessedMinesLeft
        cellsLeftToOpen = (width * height) - mines     'Sets the initial value for cellsLeftToOpen

        Me.minesOnBoard = mines

        panelMines.Width = 32 * width       'Adjusts the width of the panel so all cells can be shown
        panelMines.Height = 32 * height     'Adjusts the height of the panel so all cells can be shown

        Me.x = width
        Me.y = height

        ReDim cells(width - 1, height - 1)  'Adjusts the size of the array to fit all the cells in

        'Creates all the cells for the field and places them on the form and in the cells array
        For x = 0 To width - 1
            For y = 0 To height - 1
                'Creates the mine and adds the event handlers
                Dim mine As New mine(x, y) With {.Top = 32 * y, .Left = 32 * x}
                AddHandler mine.mineClicked, Sub(e As MouseEventArgs, atX As Integer, atY As Integer) mineClicked(e, atX, atY)
                AddHandler mine.gameLose, Sub(atX As Integer, atY As Integer) gameLose(atX, atY)
                AddHandler mine.openNear, Sub(atX As Integer, atY As Integer) openNearMine(atX, atY)
                AddHandler mine.changeGuessedMinesLeft, Sub(changeBy As Integer) guessedMinesLeft += changeBy
                AddHandler mine.changeCellsToOpen, Sub(changeBy As Integer) cellsLeftToOpen += changeBy

                'Adds the cell to the cells array
                cells(x, y) = mine

                'Adds the cell to the panel so the user can interact with the cell
                panelMines.Controls.Add(mine)
            Next
        Next
    End Sub

    ''' <summary>
    ''' Shows the game won dialog
    ''' </summary>
    Private Sub gameWin()
        BackColor = Color.Lime
        MessageBox.Show("You Won!")
    End Sub

    ''' <summary>
    ''' Performs the proper action when a cell is clicked based on the event args
    ''' </summary>
    ''' <param name="e"></param>
    ''' <param name="x">The x position of the cell that was clicked (by cells)</param>
    ''' <param name="y">The y position of the cell that was clicked (by cells)</param>
    Public Sub mineClicked(e As MouseEventArgs, x As Integer, y As Integer)
        Dim selectedMine As mine = cells(x, y)

        'Generates the mines if they have not been yet
        If Not minesGenerated Then
            generateMines(x, y)

            'Flags the cell clicked if the cell was right clicked and the cell hasn't been opened 
            'by incrementing the flagstate
            'If the Then flagstate Is Set To anything above 2 it Get reset To 0 automatically
        ElseIf e.Button = MouseButtons.Right AndAlso selectedMine.flagState <> -1 Then
            selectedMine.flagState += 1

            'Opens all cells adjacent to the mine if the mouse was double clicked or middle clicked
        ElseIf e.Clicks > 1 Or e.Button = MouseButtons.Middle Then
            openNearMine(x, y)

            'Opens the cell if the cell was left clicked and the cell is not flaged or already opened
        ElseIf e.Button = MouseButtons.Left AndAlso selectedMine.flagState = 0 Then
            selectedMine.flagState = -1
        End If
    End Sub

    ''' <summary>
    ''' Plays the mine hit animation and shows the game over dialog
    ''' </summary>
    ''' <param name="x">The x position of the cell that was clicked (by cells)</param>
    ''' <param name="y">The x position of the cell that was clicked (by cells)</param>
    Private Sub gameLose(x As Integer, y As Integer)

        'Various variables neccecary for the mine hit animation
        Dim possibleExplosionRadii As Integer()
        Dim maxExplosionRadius As Integer
        Dim atX As Integer
        Dim atY As Integer
        Dim var1 As Integer
        Dim var2 As Integer
        Dim var3 As Integer
        Dim selectedCell As mine

        possibleExplosionRadii = {x, y, Me.x - x, Me.y - y} 'A list of the distances to each edge from the cell
        maxExplosionRadius = possibleExplosionRadii.Max()   'Gets the farthest egde from the cell so the animaion doesn't play forever

        For r = 1 To maxExplosionRadius     'The distance from the cell the animation is at
            For side = -1 To 1 Step 2       'The side the animation is playing at, by closest to the selected axis or farthest
                var3 = r * side
                For axis = -1 To 1 Step 2   'The axis the animation is playing along, left and right or top and bottom
                    var1 = r * side * axis
                    var2 = -side * axis
                    For off = var1 + var2 To -var1 Step var2
                        atX = x
                        atY = y
                        If axis = -1 Then
                            atX += off
                            atY += var3
                        Else
                            atX += var3
                            atY += off
                        End If

                        'Check if the cell exists
                        If atY >= 0 AndAlso atY < Me.y AndAlso
                            atX >= 0 AndAlso atX < Me.x Then

                            'Colors the cell purple
                            selectedCell = cells(atX, atY)
                            selectedCell.BackColor = Color.Purple
                            selectedCell.Update()

                            'Sleeps for 10 milliseconds
                            Threading.Thread.Sleep(10)
                        End If
                    Next
                Next
            Next
        Next
        Update()
        Threading.Thread.Sleep(1000)

        'Shows the Game lost dialog
        Dim result As Integer
        result = GameOverLoss.ShowDialog()

        'Closes the form if the user selected Return To Main Menu
        If result = 1 Then
            Close()
        Else
            'Returns all cells to their expected apperance (like before the mine hit animation
            For Each cell In cells
                cell.updateMineState()
            Next
        End If
    End Sub

    ''' <summary>
    ''' Generates the mines so that the cell the user clicked is safe
    ''' </summary>
    ''' <param name="x">The x position of the cell that was clicked (by cells)</param>
    ''' <param name="y">The y position of the cell that was clicked (by cells)</param>
    Private Sub generateMines(x As Integer, y As Integer)
        Dim mines As New List(Of mine)
        Dim selectedMine As mine
        Dim selectedX As Integer
        Dim selectedY As Integer
        minesGenerated = True

        'Marks all cells adjacent to the clicked cell as safe
        doNearMine(x, y, Sub(mine As mine) mine.isMine = False)

        'Generates the mine for minesOnBoard
        For i = 1 To minesOnBoard
            'Attempt to place a mine until a spot is found
            While True
                'Randomly select a x and y value to atempt to place the mine there
                selectedX = Math.Floor(Rnd() * Me.x)
                selectedY = Math.Floor(Rnd() * Me.y)

                selectedMine = cells.GetValue(selectedX, selectedY)

                'Check if a mine has already been placed at the selected location or if the location has been marked safe
                If Not selectedMine.isMine.HasValue Then
                    'Mark the location as a mine
                    selectedMine.isMine = True
                    mines.Add(selectedMine)
                    Exit While
                End If
            End While
        Next

        'Set the minesAround value for each cell based on the mines around them
        For Each mine In mines
            doNearMine(mine.x, mine.y, Sub(atMine As mine) atMine.minesAround += 1)
        Next

        'Mark all cells as not mines if they have not already been set as a mine or not
        For Each mine In cells
            If Not mine.isMine.HasValue Then
                mine.isMine = False
            End If
        Next

        'Open the selected mine that raised the event
        cells(x, y).flagState = -1
    End Sub

    ''' <summary>
    ''' Opens all mines adjacent to a cell
    ''' </summary>
    ''' <param name="x">The x position of the cell (by cells)</param>
    ''' <param name="y">The y position of the cell (by cells</param>
    Public Sub openNearMine(x As Integer, y As Integer)
        doNearMine(x, y, Sub(mine As mine) If mine.flagState = 0 Then mine.flagState = -1)
    End Sub

    ''' <summary>
    ''' Perform an action at all adjacent cells to a cell
    ''' </summary>
    ''' <param name="x">The x position of the cell (by cells)</param>
    ''' <param name="y">The x position of the cell (by cells)</param>
    ''' <param name="action">What action to perform</param>
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
        Me.sender.BringToFront()
    End Sub
End Class