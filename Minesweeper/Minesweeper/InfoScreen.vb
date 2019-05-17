Public Class InfoScreen
    Private Sub InfoScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the rtf file into the RichTextBox
        rtfInfo.Rtf = My.Resources.Resource.info
    End Sub

    Private Sub RtfInfo_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles rtfInfo.LinkClicked
        'Open a link when clicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub
End Class