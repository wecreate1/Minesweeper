Public Class mine
    'Public isMine As Boolean? = Nothing
    Public Property isMine As Boolean?
        Get
            Return _isMine
        End Get
        Set(value As Boolean?)
            _isMine = value
            updateMine()
        End Set
    End Property
    Public _isMine As Boolean?
    Public flagState As Integer = 0
    Public minesAround As Integer = 0
    Public Event generateMinesAt As Action(Of Integer, Integer)
    Public x As Integer
    Public y As Integer

    Public Sub New(x As Integer, y As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.x = x
        Me.y = y
    End Sub

    Public Sub updateMine()
        If isMine.Value Then
            Me.BackColor = Color.Red

        ElseIf Not isMine.Value Then
            Me.BackColor = Color.Green
        End If
    End Sub

    Private Sub mine_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If IsNothing(isMine) Then
            RaiseEvent generateMinesAt(x, y)
        End If
        BackColor = Color.Lime
    End Sub
End Class
