<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mine
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblMinesAround = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMinesAround
        '
        Me.lblMinesAround.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMinesAround.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMinesAround.Enabled = False
        Me.lblMinesAround.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinesAround.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMinesAround.Location = New System.Drawing.Point(0, 0)
        Me.lblMinesAround.Name = "lblMinesAround"
        Me.lblMinesAround.Size = New System.Drawing.Size(30, 30)
        Me.lblMinesAround.TabIndex = 0
        Me.lblMinesAround.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMinesAround.Visible = False
        '
        'mine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.lblMinesAround)
        Me.Name = "mine"
        Me.Size = New System.Drawing.Size(30, 30)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMinesAround As Label
End Class
