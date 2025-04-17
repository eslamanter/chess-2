<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grb_1 = New System.Windows.Forms.GroupBox
        Me.prg_1 = New System.Windows.Forms.ProgressBar
        Me.pct_x6 = New System.Windows.Forms.PictureBox
        Me.pct_x5 = New System.Windows.Forms.PictureBox
        Me.pct_x4 = New System.Windows.Forms.PictureBox
        Me.pct_x3 = New System.Windows.Forms.PictureBox
        Me.pct_x2 = New System.Windows.Forms.PictureBox
        Me.pct_x1 = New System.Windows.Forms.PictureBox
        Me.lbl_6 = New System.Windows.Forms.Label
        Me.btn_3 = New System.Windows.Forms.Button
        Me.lbl_4 = New System.Windows.Forms.Label
        Me.btn_2 = New System.Windows.Forms.Button
        Me.lbl_1 = New System.Windows.Forms.Label
        Me.btn_1 = New System.Windows.Forms.Button
        Me.lbl_2 = New System.Windows.Forms.Label
        Me.lbl_5 = New System.Windows.Forms.Label
        Me.pct_2 = New System.Windows.Forms.PictureBox
        Me.pct_1 = New System.Windows.Forms.PictureBox
        Me.lbl_3 = New System.Windows.Forms.Label
        Me.tmr_1 = New System.Windows.Forms.Timer(Me.components)
        Me.grb_1.SuspendLayout()
        CType(Me.pct_x6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_x5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_x4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_x3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_x2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_x1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grb_1
        '
        Me.grb_1.Controls.Add(Me.prg_1)
        Me.grb_1.Controls.Add(Me.pct_x6)
        Me.grb_1.Controls.Add(Me.pct_x5)
        Me.grb_1.Controls.Add(Me.pct_x4)
        Me.grb_1.Controls.Add(Me.pct_x3)
        Me.grb_1.Controls.Add(Me.pct_x2)
        Me.grb_1.Controls.Add(Me.pct_x1)
        Me.grb_1.Controls.Add(Me.lbl_6)
        Me.grb_1.Controls.Add(Me.btn_3)
        Me.grb_1.Controls.Add(Me.lbl_4)
        Me.grb_1.Controls.Add(Me.btn_2)
        Me.grb_1.Controls.Add(Me.lbl_1)
        Me.grb_1.Controls.Add(Me.btn_1)
        Me.grb_1.Controls.Add(Me.lbl_2)
        Me.grb_1.Controls.Add(Me.lbl_5)
        Me.grb_1.Controls.Add(Me.pct_2)
        Me.grb_1.Controls.Add(Me.pct_1)
        Me.grb_1.Controls.Add(Me.lbl_3)
        Me.grb_1.ForeColor = System.Drawing.Color.White
        Me.grb_1.Location = New System.Drawing.Point(12, 12)
        Me.grb_1.Name = "grb_1"
        Me.grb_1.Size = New System.Drawing.Size(568, 242)
        Me.grb_1.TabIndex = 0
        Me.grb_1.TabStop = False
        '
        'prg_1
        '
        Me.prg_1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.prg_1.ForeColor = System.Drawing.Color.White
        Me.prg_1.Location = New System.Drawing.Point(205, 0)
        Me.prg_1.Maximum = 6
        Me.prg_1.Name = "prg_1"
        Me.prg_1.Size = New System.Drawing.Size(200, 25)
        Me.prg_1.Step = 1
        Me.prg_1.TabIndex = 3
        Me.prg_1.Visible = False
        '
        'pct_x6
        '
        Me.pct_x6.AccessibleDescription = "Pawn"
        Me.pct_x6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_x6.Image = Global.Chess_2.My.Resources.Resources.Pawn2
        Me.pct_x6.Location = New System.Drawing.Point(166, 0)
        Me.pct_x6.Name = "pct_x6"
        Me.pct_x6.Size = New System.Drawing.Size(25, 25)
        Me.pct_x6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_x6.TabIndex = 13
        Me.pct_x6.TabStop = False
        Me.pct_x6.Visible = False
        '
        'pct_x5
        '
        Me.pct_x5.AccessibleDescription = "Queen"
        Me.pct_x5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_x5.Image = Global.Chess_2.My.Resources.Resources.Queen2
        Me.pct_x5.Location = New System.Drawing.Point(135, 0)
        Me.pct_x5.Name = "pct_x5"
        Me.pct_x5.Size = New System.Drawing.Size(25, 25)
        Me.pct_x5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_x5.TabIndex = 16
        Me.pct_x5.TabStop = False
        Me.pct_x5.Visible = False
        '
        'pct_x4
        '
        Me.pct_x4.AccessibleDescription = "King"
        Me.pct_x4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_x4.Image = Global.Chess_2.My.Resources.Resources.King2
        Me.pct_x4.Location = New System.Drawing.Point(104, 0)
        Me.pct_x4.Name = "pct_x4"
        Me.pct_x4.Size = New System.Drawing.Size(25, 25)
        Me.pct_x4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_x4.TabIndex = 15
        Me.pct_x4.TabStop = False
        Me.pct_x4.Visible = False
        '
        'pct_x3
        '
        Me.pct_x3.AccessibleDescription = "Bishop"
        Me.pct_x3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_x3.Image = Global.Chess_2.My.Resources.Resources.Bishop2
        Me.pct_x3.Location = New System.Drawing.Point(73, 0)
        Me.pct_x3.Name = "pct_x3"
        Me.pct_x3.Size = New System.Drawing.Size(25, 25)
        Me.pct_x3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_x3.TabIndex = 14
        Me.pct_x3.TabStop = False
        Me.pct_x3.Visible = False
        '
        'pct_x2
        '
        Me.pct_x2.AccessibleDescription = "Knight"
        Me.pct_x2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_x2.Image = Global.Chess_2.My.Resources.Resources.Knight2
        Me.pct_x2.Location = New System.Drawing.Point(42, 0)
        Me.pct_x2.Name = "pct_x2"
        Me.pct_x2.Size = New System.Drawing.Size(25, 25)
        Me.pct_x2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_x2.TabIndex = 13
        Me.pct_x2.TabStop = False
        Me.pct_x2.Visible = False
        '
        'pct_x1
        '
        Me.pct_x1.AccessibleDescription = "Rook"
        Me.pct_x1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_x1.Image = Global.Chess_2.My.Resources.Resources.Rook2
        Me.pct_x1.Location = New System.Drawing.Point(11, 0)
        Me.pct_x1.Name = "pct_x1"
        Me.pct_x1.Size = New System.Drawing.Size(25, 25)
        Me.pct_x1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_x1.TabIndex = 12
        Me.pct_x1.TabStop = False
        Me.pct_x1.Visible = False
        '
        'lbl_6
        '
        Me.lbl_6.AutoSize = True
        Me.lbl_6.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_6.Location = New System.Drawing.Point(176, 31)
        Me.lbl_6.Name = "lbl_6"
        Me.lbl_6.Size = New System.Drawing.Size(35, 32)
        Me.lbl_6.TabIndex = 11
        Me.lbl_6.Text = "®"
        Me.lbl_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.Color.Black
        Me.btn_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.ForeColor = System.Drawing.Color.DarkOrange
        Me.btn_3.Location = New System.Drawing.Point(382, 184)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(169, 39)
        Me.btn_3.TabIndex = 2
        Me.btn_3.Text = "About"
        Me.btn_3.UseVisualStyleBackColor = False
        '
        'lbl_4
        '
        Me.lbl_4.AutoSize = True
        Me.lbl_4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_4.Location = New System.Drawing.Point(516, 77)
        Me.lbl_4.Name = "lbl_4"
        Me.lbl_4.Size = New System.Drawing.Size(35, 32)
        Me.lbl_4.TabIndex = 4
        Me.lbl_4.Text = "®"
        Me.lbl_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.Color.Black
        Me.btn_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_2.Location = New System.Drawing.Point(382, 142)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(169, 39)
        Me.btn_2.TabIndex = 1
        Me.btn_2.Text = "Pieces"
        Me.btn_2.UseVisualStyleBackColor = False
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("David", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_1.Location = New System.Drawing.Point(11, 196)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(200, 27)
        Me.lbl_1.TabIndex = 2
        Me.lbl_1.Text = "Eslam Abdullah"
        Me.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.Color.Black
        Me.btn_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.Location = New System.Drawing.Point(236, 142)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(140, 81)
        Me.btn_1.TabIndex = 0
        Me.btn_1.Text = "Play"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.ForeColor = System.Drawing.Color.Lime
        Me.lbl_2.Location = New System.Drawing.Point(369, 45)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(162, 32)
        Me.lbl_2.TabIndex = 6
        Me.lbl_2.Text = "Version 2.2"
        Me.lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_5
        '
        Me.lbl_5.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_5.ForeColor = System.Drawing.Color.Lime
        Me.lbl_5.Location = New System.Drawing.Point(411, 0)
        Me.lbl_5.Name = "lbl_5"
        Me.lbl_5.Size = New System.Drawing.Size(140, 36)
        Me.lbl_5.TabIndex = 10
        Me.lbl_5.Text = "2013"
        Me.lbl_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pct_2
        '
        Me.pct_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_2.Image = Global.Chess_2.My.Resources.Resources.King2
        Me.pct_2.Location = New System.Drawing.Point(326, 33)
        Me.pct_2.Name = "pct_2"
        Me.pct_2.Size = New System.Drawing.Size(50, 50)
        Me.pct_2.TabIndex = 3
        Me.pct_2.TabStop = False
        '
        'pct_1
        '
        Me.pct_1.Image = CType(resources.GetObject("pct_1.Image"), System.Drawing.Image)
        Me.pct_1.Location = New System.Drawing.Point(11, 31)
        Me.pct_1.Name = "pct_1"
        Me.pct_1.Size = New System.Drawing.Size(200, 150)
        Me.pct_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_1.TabIndex = 1
        Me.pct_1.TabStop = False
        '
        'lbl_3
        '
        Me.lbl_3.AutoSize = True
        Me.lbl_3.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_3.Location = New System.Drawing.Point(217, 45)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(334, 111)
        Me.lbl_3.TabIndex = 5
        Me.lbl_3.Text = "Chess"
        Me.lbl_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmr_1
        '
        Me.tmr_1.Enabled = True
        Me.tmr_1.Interval = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(592, 266)
        Me.Controls.Add(Me.grb_1)
        Me.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 300)
        Me.MinimumSize = New System.Drawing.Size(600, 300)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E.A Chess 2"
        Me.grb_1.ResumeLayout(False)
        Me.grb_1.PerformLayout()
        CType(Me.pct_x6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_x5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_x4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_x3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_x2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_x1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_1 As System.Windows.Forms.GroupBox
    Friend WithEvents pct_1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_3 As System.Windows.Forms.Label
    Friend WithEvents lbl_2 As System.Windows.Forms.Label
    Friend WithEvents pct_2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_4 As System.Windows.Forms.Label
    Friend WithEvents btn_3 As System.Windows.Forms.Button
    Friend WithEvents btn_2 As System.Windows.Forms.Button
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents lbl_5 As System.Windows.Forms.Label
    Friend WithEvents lbl_6 As System.Windows.Forms.Label
    Friend WithEvents pct_x6 As System.Windows.Forms.PictureBox
    Friend WithEvents pct_x5 As System.Windows.Forms.PictureBox
    Friend WithEvents pct_x4 As System.Windows.Forms.PictureBox
    Friend WithEvents pct_x3 As System.Windows.Forms.PictureBox
    Friend WithEvents pct_x2 As System.Windows.Forms.PictureBox
    Friend WithEvents pct_x1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmr_1 As System.Windows.Forms.Timer
    Friend WithEvents prg_1 As System.Windows.Forms.ProgressBar

End Class
