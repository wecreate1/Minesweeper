Public Class mine
    'Public isMine As Boolean? = Nothing
    Public Property isMine As Boolean?
        Get
            Return _isMine
        End Get
        Set(value As Boolean?)
            _isMine = value
        End Set
    End Property

    Public Property minesAround As Integer
        Get
            Return _minesAround
        End Get
        Set(value As Integer)
            _minesAround = value
            lblMinesAround.Text = value
        End Set
    End Property

    Public Property flagState As Integer
        Get
            Return _flagState
        End Get
        Set(value As Integer)
            If value > 2 Then
                value = 0
            End If
            _flagState = value
            updateMineState()
        End Set
    End Property

    Public _isMine As Boolean?
    Private _flagState As Integer = 0
    'flagstate 0 default
    '-1 opened
    '1 flag 1
    '2 flag 2
    Private _minesAround As Integer = 0
    Public hasBeenOpened As Boolean
    Public Event mineClicked As Action(Of MouseEventArgs, Integer, Integer)
    Public Event gameLose As Action(Of Integer, Integer)
    Public Event openNear As Action(Of Integer, Integer)
    Public x As Integer
    Public y As Integer
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

    Public Sub updateMineState()
        Select Case flagState
            Case -1
                If isMine.Value = True Then
                    BackColor = Color.Red
                    RaiseEvent gameLose(x, y)
                Else
                    If minesAround = 0 Then
                        BackColor = SystemColors.Control
                        RaiseEvent openNear(x, y)
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
