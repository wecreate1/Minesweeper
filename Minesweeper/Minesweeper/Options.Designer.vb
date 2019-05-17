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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblMines = New System.Windows.Forms.Label()
        Me.numMines = New System.Windows.Forms.NumericUpDown()
        Me.numWidth = New System.Windows.Forms.NumericUpDown()
        Me.numHeight = New System.Windows.Forms.NumericUpDown()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.radEasy = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radHard = New System.Windows.Forms.RadioButton()
        Me.radCustom = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.numMines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.lblHeight, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWidth, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMines, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.numMines, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.numWidth, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.numHeight, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPlay, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(286, 257)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblHeight
        '
        Me.lblHeight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(3, 54)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 3
        Me.lblHeight.Text = "Height"
        '
        'lblWidth
        '
        Me.lblWidth.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(3, 116)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblWidth.TabIndex = 4
        Me.lblWidth.Text = "Width"
        '
        'lblMines
        '
        Me.lblMines.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMines.AutoSize = True
        Me.lblMines.Location = New System.Drawing.Point(3, 178)
        Me.lblMines.Name = "lblMines"
        Me.lblMines.Size = New System.Drawing.Size(35, 13)
        Me.lblMines.TabIndex = 5
        Me.lblMines.Text = "Mines"
        '
        'numMines
        '
        Me.numMines.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numMines.Location = New System.Drawing.Point(61, 175)
        Me.numMines.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numMines.Name = "numMines"
        Me.numMines.Size = New System.Drawing.Size(222, 20)
        Me.numMines.TabIndex = 6
        Me.numMines.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'numWidth
        '
        Me.numWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numWidth.Location = New System.Drawing.Point(61, 113)
        Me.numWidth.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numWidth.Name = "numWidth"
        Me.numWidth.Size = New System.Drawing.Size(222, 20)
        Me.numWidth.TabIndex = 7
        Me.numWidth.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'numHeight
        '
        Me.numHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numHeight.Location = New System.Drawing.Point(61, 51)
        Me.numHeight.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numHeight.Name = "numHeight"
        Me.numHeight.Size = New System.Drawing.Size(222, 20)
        Me.numHeight.TabIndex = 8
        Me.numHeight.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnPlay, 2)
        Me.btnPlay.Location = New System.Drawing.Point(105, 225)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 9
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.radEasy, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.radMedium, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.radHard, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.radCustom, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(280, 24)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'radEasy
        '
        Me.radEasy.AutoSize = True
        Me.radEasy.Location = New System.Drawing.Point(3, 3)
        Me.radEasy.Name = "radEasy"
        Me.radEasy.Size = New System.Drawing.Size(48, 17)
        Me.radEasy.TabIndex = 0
        Me.radEasy.Text = "Easy"
        Me.radEasy.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Checked = True
        Me.radMedium.Location = New System.Drawing.Point(73, 3)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(62, 17)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radHard
        '
        Me.radHard.AutoSize = True
        Me.radHard.Location = New System.Drawing.Point(143, 3)
        Me.radHard.Name = "radHard"
        Me.radHard.Size = New System.Drawing.Size(48, 17)
        Me.radHard.TabIndex = 2
        Me.radHard.Text = "Hard"
        Me.radHard.UseVisualStyleBackColor = True
        '
        'radCustom
        '
        Me.radCustom.AutoSize = True
        Me.radCustom.Location = New System.Drawing.Point(213, 3)
        Me.radCustom.Name = "radCustom"
        Me.radCustom.Size = New System.Drawing.Size(60, 17)
        Me.radCustom.TabIndex = 3
        Me.radCustom.Text = "Custom"
        Me.radCustom.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 282)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Options"
        Me.Text = "Options"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.numMines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
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
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents radEasy As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radHard As RadioButton
    Friend WithEvents radCustom As RadioButton
End Class
