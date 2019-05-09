<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblMines = New System.Windows.Forms.Label()
        Me.numMines = New System.Windows.Forms.NumericUpDown()
        Me.numWidth = New System.Windows.Forms.NumericUpDown()
        Me.numHeight = New System.Windows.Forms.NumericUpDown()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.numMines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.46332!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.53668!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblHeight, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWidth, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMines, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.numMines, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.numWidth, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.numHeight, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPlay, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(259, 236)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblHeight
        '
        Me.lblHeight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(3, 26)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 3
        Me.lblHeight.Text = "Height"
        '
        'lblWidth
        '
        Me.lblWidth.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(3, 91)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblWidth.TabIndex = 4
        Me.lblWidth.Text = "Width"
        '
        'lblMines
        '
        Me.lblMines.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMines.AutoSize = True
        Me.lblMines.Location = New System.Drawing.Point(3, 156)
        Me.lblMines.Name = "lblMines"
        Me.lblMines.Size = New System.Drawing.Size(35, 13)
        Me.lblMines.TabIndex = 5
        Me.lblMines.Text = "Mines"
        '
        'numMines
        '
        Me.numMines.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numMines.Location = New System.Drawing.Point(55, 152)
        Me.numMines.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numMines.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMines.Name = "numMines"
        Me.numMines.Size = New System.Drawing.Size(201, 20)
        Me.numMines.TabIndex = 6
        Me.numMines.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'numWidth
        '
        Me.numWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numWidth.Location = New System.Drawing.Point(55, 87)
        Me.numWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numWidth.Name = "numWidth"
        Me.numWidth.Size = New System.Drawing.Size(201, 20)
        Me.numWidth.TabIndex = 7
        Me.numWidth.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'numHeight
        '
        Me.numHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numHeight.Location = New System.Drawing.Point(55, 22)
        Me.numHeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numHeight.Name = "numHeight"
        Me.numHeight.Size = New System.Drawing.Size(201, 20)
        Me.numHeight.TabIndex = 8
        Me.numHeight.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnPlay, 2)
        Me.btnPlay.Location = New System.Drawing.Point(92, 204)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 9
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Options"
        Me.Text = "Options"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.numMines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblMines As Label
    Friend WithEvents numMines As NumericUpDown
    Friend WithEvents numWidth As NumericUpDown
    Friend WithEvents numHeight As NumericUpDown
    Friend WithEvents btnPlay As Button
End Class
