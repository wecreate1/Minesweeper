<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rtfInfo = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtfInfo
        '
        Me.rtfInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtfInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtfInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfInfo.Enabled = False
        Me.rtfInfo.Location = New System.Drawing.Point(12, 12)
        Me.rtfInfo.Name = "rtfInfo"
        Me.rtfInfo.ReadOnly = True
        Me.rtfInfo.Size = New System.Drawing.Size(564, 615)
        Me.rtfInfo.TabIndex = 0
        Me.rtfInfo.Text = ""
        '
        'InfoScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 581)
        Me.Controls.Add(Me.rtfInfo)
        Me.Name = "InfoScreen"
        Me.Text = "InfoScreen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtfInfo As RichTextBox
End Class
