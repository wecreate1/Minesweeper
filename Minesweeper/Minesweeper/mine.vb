Public Class mine
    'Public isMine As Boolean? = Nothing
    Public Property isMine As Boolean?
        Get
            Return _isMine
        End Get
        Set(value As Boolean?)
            If value.HasValue AndAlso value.Value Then
                BackColor = Color.Red
            End If
            _isMine = value
            'updateMineState()
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
    Public Event mineClicked As Action(Of Integer, Integer)
    Public Event gameLose As Action(Of Integer, Integer)
    Public Event openNear As Action(Of Integer, Integer)
    Public x As Integer
    Public y As Integer

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
                    RaiseEvent gameLose(x, y)
                Else
                    'lblMinesAround.Visible = True
                    If minesAround = 0 Then
                        BackColor = SystemColors.Control
                        RaiseEvent openNear(x, y)
                    Else
                        BackColor = SystemColors.ControlDark
                        lblMinesAround.Visible = True
                    End If
                End If
        End Select

    End Sub

    Private Sub mine_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent mineClicked(x, y)
    End Sub
End Class
