Public Class mine
    'Public isMine As Boolean? = Nothing
    Public Property isMine As Boolean?
        Get
            Return _isMine
        End Get
        Set(value As Boolean?)
            _isMine = value
            updateMineState()
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

    Public _isMine As Boolean?
    Public flagState As Integer = 0
    'flagstate 0 default
    '-1 opened
    '1 flag 1
    '2 flag 2
    Private _minesAround As Integer = 0
    Public Event mineClicked As Action(Of Integer, Integer)
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
        If isMine.Value Then
            Me.BackColor = Color.Red
            lblMinesAround.Visible = False
        End If
    End Sub

    Private Sub mine_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent mineClicked(x, y)
    End Sub
End Class
