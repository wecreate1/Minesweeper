<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameScreen
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMinesLeft = New System.Windows.Forms.Label()
        Me.gridMines = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblMinesLeft, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gridMines, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.39241!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.6076!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(260, 237)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblMinesLeft
        '
        Me.lblMinesLeft.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMinesLeft.AutoSize = True
        Me.lblMinesLeft.Location = New System.Drawing.Point(99, 7)
        Me.lblMinesLeft.Name = "lblMinesLeft"
        Me.lblMinesLeft.Size = New System.Drawing.Size(62, 13)
        Me.lblMinesLeft.TabIndex = 0
        Me.lblMinesLeft.Text = "Mines Left: "
        '
        'gridMines
        '
        Me.gridMines.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gridMines.BackColor = System.Drawing.SystemColors.Control
        Me.gridMines.ColumnCount = 1
        Me.gridMines.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.gridMines.Location = New System.Drawing.Point(0, 27)
        Me.gridMines.Margin = New System.Windows.Forms.Padding(0)
        Me.gridMines.Name = "gridMines"
        Me.gridMines.RowCount = 1
        Me.gridMines.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.gridMines.Size = New System.Drawing.Size(260, 210)
        Me.gridMines.TabIndex = 1
        '
        'GameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "GameScreen"
        Me.Text = "GameScreen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblMinesLeft As Label
    Friend WithEvents gridMines As TableLayoutPanel
End Class
