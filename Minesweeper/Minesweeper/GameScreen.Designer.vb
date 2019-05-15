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
        Me.panelMines = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblMinesLeft, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.panelMines, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(795, 627)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblMinesLeft
        '
        Me.lblMinesLeft.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMinesLeft.AutoSize = True
        Me.lblMinesLeft.Location = New System.Drawing.Point(366, 3)
        Me.lblMinesLeft.Name = "lblMinesLeft"
        Me.lblMinesLeft.Size = New System.Drawing.Size(62, 13)
        Me.lblMinesLeft.TabIndex = 0
        Me.lblMinesLeft.Text = "Mines Left: "
        '
        'panelMines
        '
        Me.panelMines.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelMines.AutoScroll = True
        Me.panelMines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMines.Location = New System.Drawing.Point(270, 218)
        Me.panelMines.Name = "panelMines"
        Me.panelMines.Size = New System.Drawing.Size(254, 211)
        Me.panelMines.TabIndex = 1
        '
        'GameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(819, 651)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "GameScreen"
        Me.Text = "GameScreen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblMinesLeft As Label
    Friend WithEvents panelMines As Panel
End Class
