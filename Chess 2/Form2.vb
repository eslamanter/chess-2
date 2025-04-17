Public Class Form2

    Dim color As Boolean = True
    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Visible = True
        Form3.Close()
        Form4.Close()
    End Sub


    Private Sub tmr_1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_1.Tick
        Me.prg_1.Value += 1

        If Me.prg_1.Value = 1 Then
            Me.pct_a1.Image = My.Resources.Rook1
            Me.pct_a8.Image = My.Resources.Rook2
        End If
        If Me.prg_1.Value = 2 Then
            Me.pct_b1.Image = My.Resources.Knight1
            Me.pct_b8.Image = My.Resources.Knight2
        End If
        If Me.prg_1.Value = 3 Then
            Me.pct_c1.Image = My.Resources.Bishop1
            Me.pct_c8.Image = My.Resources.Bishop2
        End If
        If Me.prg_1.Value = 4 Then
            Me.pct_d1.Image = My.Resources.King1
            Me.pct_d8.Image = My.Resources.King2
        End If
        If Me.prg_1.Value = 5 Then
            Me.pct_e1.Image = My.Resources.Queen1
            Me.pct_e8.Image = My.Resources.Queen2
        End If
        If Me.prg_1.Value = 6 Then
            Me.pct_f1.Image = My.Resources.Bishop1
            Me.pct_f8.Image = My.Resources.Bishop2
        End If
        If Me.prg_1.Value = 7 Then
            Me.pct_g1.Image = My.Resources.Knight1
            Me.pct_g8.Image = My.Resources.Knight2
        End If
        If Me.prg_1.Value = 8 Then
            Me.pct_h1.Image = My.Resources.Rook1
            Me.pct_h8.Image = My.Resources.Rook2
        End If
        If Me.prg_1.Value = 9 Then
            Me.pct_a2.Image = My.Resources.Pawn1
            Me.pct_a7.Image = My.Resources.Pawn2
        End If
        If Me.prg_1.Value = 10 Then
            Me.pct_b2.Image = My.Resources.Pawn1
            Me.pct_b7.Image = My.Resources.Pawn2
        End If
        If Me.prg_1.Value = 11 Then
            Me.pct_c2.Image = My.Resources.Pawn1
            Me.pct_c7.Image = My.Resources.Pawn2
        End If
        If Me.prg_1.Value = 12 Then
            Me.pct_d2.Image = My.Resources.Pawn1
            Me.pct_d7.Image = My.Resources.Pawn2
        End If
        If Me.prg_1.Value = 13 Then
            Me.pct_e2.Image = My.Resources.Pawn1
            Me.pct_e7.Image = My.Resources.Pawn2
        End If
        If Me.prg_1.Value = 14 Then
            Me.pct_f2.Image = My.Resources.Pawn1
            Me.pct_f7.Image = My.Resources.Pawn2
        End If
        If Me.prg_1.Value = 15 Then
            Me.pct_g2.Image = My.Resources.Pawn1
            Me.pct_g7.Image = My.Resources.Pawn2
        End If
        If Me.prg_1.Value = 16 Then
            Me.pct_h2.Image = My.Resources.Pawn1
            Me.pct_h7.Image = My.Resources.Pawn2
        End If

        If Me.prg_1.Value = 16 Then
            Me.tmr_1.Enabled = False
            Me.prg_1.Visible = False
            Me.lbl_1.Visible = True
            Me.grb_1.Text = "Press to play"
            Me.grb_1.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub grb_1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grb_1.Click
        If Me.grb_1.Cursor = Cursors.Hand Then
            Me.grb_1.Cursor = Cursors.Default
            Me.grb_1.Text = "Play"
            Me.pct_1.Visible = True
            Me.lbl_2.Visible = True
            Me.lbl_3.Visible = True
            Me.lbl_4.Visible = True
        End If

        If Me.grb_1.Text = "Play" Then
            Me.pct_a1.Enabled = True
            Me.pct_a2.Enabled = True
            Me.pct_a3.Enabled = True
            Me.pct_a4.Enabled = True
            Me.pct_a5.Enabled = True
            Me.pct_a6.Enabled = True
            Me.pct_a7.Enabled = True
            Me.pct_a8.Enabled = True

            Me.pct_b1.Enabled = True
            Me.pct_b2.Enabled = True
            Me.pct_b3.Enabled = True
            Me.pct_b4.Enabled = True
            Me.pct_b5.Enabled = True
            Me.pct_b6.Enabled = True
            Me.pct_b7.Enabled = True
            Me.pct_b8.Enabled = True

            Me.pct_c1.Enabled = True
            Me.pct_c2.Enabled = True
            Me.pct_c3.Enabled = True
            Me.pct_c4.Enabled = True
            Me.pct_c5.Enabled = True
            Me.pct_c6.Enabled = True
            Me.pct_c7.Enabled = True
            Me.pct_c8.Enabled = True

            Me.pct_d1.Enabled = True
            Me.pct_d2.Enabled = True
            Me.pct_d3.Enabled = True
            Me.pct_d4.Enabled = True
            Me.pct_d5.Enabled = True
            Me.pct_d6.Enabled = True
            Me.pct_d7.Enabled = True
            Me.pct_d8.Enabled = True

            Me.pct_e1.Enabled = True
            Me.pct_e2.Enabled = True
            Me.pct_e3.Enabled = True
            Me.pct_e4.Enabled = True
            Me.pct_e5.Enabled = True
            Me.pct_e6.Enabled = True
            Me.pct_e7.Enabled = True
            Me.pct_e8.Enabled = True

            Me.pct_f1.Enabled = True
            Me.pct_f2.Enabled = True
            Me.pct_f3.Enabled = True
            Me.pct_f4.Enabled = True
            Me.pct_f5.Enabled = True
            Me.pct_f6.Enabled = True
            Me.pct_f7.Enabled = True
            Me.pct_f8.Enabled = True

            Me.pct_g1.Enabled = True
            Me.pct_g2.Enabled = True
            Me.pct_g3.Enabled = True
            Me.pct_g4.Enabled = True
            Me.pct_g5.Enabled = True
            Me.pct_g6.Enabled = True
            Me.pct_g7.Enabled = True
            Me.pct_g8.Enabled = True

            Me.pct_h1.Enabled = True
            Me.pct_h2.Enabled = True
            Me.pct_h3.Enabled = True
            Me.pct_h4.Enabled = True
            Me.pct_h5.Enabled = True
            Me.pct_h6.Enabled = True
            Me.pct_h7.Enabled = True
            Me.pct_h8.Enabled = True
        End If
    End Sub

    Private Sub pct_a1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_a1.MouseDown
        If Me.lbl_5.Tag <> Me.pct_a1.Tag Then
            If Me.pct_a1.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_a1.Image
                Me.pct_1.Tag = Me.pct_a1.Tag
                Me.pct_1.AccessibleDescription = Me.pct_a1.AccessibleDescription
                Me.pct_a1.Image = Me.lbl_1.Image
                Me.pct_a1.Tag = "0"
                Me.pct_a1.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_a1.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_a2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_a2.MouseDown
        If Me.lbl_5.Tag <> Me.pct_a2.Tag Then
            If Me.pct_a2.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_a2.Image
                Me.pct_1.Tag = Me.pct_a2.Tag
                Me.pct_1.AccessibleDescription = Me.pct_a2.AccessibleDescription
                Me.pct_a2.Image = Me.lbl_1.Image
                Me.pct_a2.Tag = "0"
                Me.pct_a2.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_a2.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_a3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_a3.MouseDown
        If Me.lbl_5.Tag <> Me.pct_a3.Tag Then
            If Me.pct_a3.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_a3.Image
                Me.pct_1.Tag = Me.pct_a3.Tag
                Me.pct_1.AccessibleDescription = Me.pct_a3.AccessibleDescription
                Me.pct_a3.Image = Me.lbl_1.Image
                Me.pct_a3.Tag = "0"
                Me.pct_a3.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_a3.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_a4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_a4.MouseDown
        If Me.lbl_5.Tag <> Me.pct_a4.Tag Then
            If Me.pct_a4.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_a4.Image
                Me.pct_1.Tag = Me.pct_a4.Tag
                Me.pct_1.AccessibleDescription = Me.pct_a4.AccessibleDescription
                Me.pct_a4.Image = Me.lbl_1.Image
                Me.pct_a4.Tag = "0"
                Me.pct_a4.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_a4.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_a5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_a5.MouseDown
        If Me.lbl_5.Tag <> Me.pct_a5.Tag Then
            If Me.pct_a5.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_a5.Image
                Me.pct_1.Tag = Me.pct_a5.Tag
                Me.pct_1.AccessibleDescription = Me.pct_a5.AccessibleDescription
                Me.pct_a5.Image = Me.lbl_1.Image
                Me.pct_a5.Tag = "0"
                Me.pct_a5.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_a5.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_a6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_a6.MouseDown
        If Me.lbl_5.Tag <> Me.pct_a6.Tag Then
            If Me.pct_a6.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_a6.Image
                Me.pct_1.Tag = Me.pct_a6.Tag
                Me.pct_1.AccessibleDescription = Me.pct_a6.AccessibleDescription
                Me.pct_a6.Image = Me.lbl_1.Image
                Me.pct_a6.Tag = "0"
                Me.pct_a6.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_a6.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_a7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_a7.MouseDown
        If Me.lbl_5.Tag <> Me.pct_a7.Tag Then
            If Me.pct_a7.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_a7.Image
                Me.pct_1.Tag = Me.pct_a7.Tag
                Me.pct_1.AccessibleDescription = Me.pct_a7.AccessibleDescription
                Me.pct_a7.Image = Me.lbl_1.Image
                Me.pct_a7.Tag = "0"
                Me.pct_a7.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_a7.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_a8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_a8.MouseDown
        If Me.lbl_5.Tag <> Me.pct_a8.Tag Then
            If Me.pct_a8.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_a8.Image
                Me.pct_1.Tag = Me.pct_a8.Tag
                Me.pct_1.AccessibleDescription = Me.pct_a8.AccessibleDescription
                Me.pct_a8.Image = Me.lbl_1.Image
                Me.pct_a8.Tag = "0"
                Me.pct_a8.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_a8.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub

    Private Sub pct_b1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_b1.MouseDown
        If Me.lbl_5.Tag <> Me.pct_b1.Tag Then
            If Me.pct_b1.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_b1.Image
                Me.pct_1.Tag = Me.pct_b1.Tag
                Me.pct_1.AccessibleDescription = Me.pct_b1.AccessibleDescription
                Me.pct_b1.Image = Me.lbl_1.Image
                Me.pct_b1.Tag = "0"
                Me.pct_b1.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_b1.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_b2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_b2.MouseDown
        If Me.lbl_5.Tag <> Me.pct_b2.Tag Then
            If Me.pct_b2.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_b2.Image
                Me.pct_1.Tag = Me.pct_b2.Tag
                Me.pct_1.AccessibleDescription = Me.pct_b2.AccessibleDescription
                Me.pct_b2.Image = Me.lbl_1.Image
                Me.pct_b2.Tag = "0"
                Me.pct_b2.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_b2.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_b3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_b3.MouseDown
        If Me.lbl_5.Tag <> Me.pct_b3.Tag Then
            If Me.pct_b3.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_b3.Image
                Me.pct_1.Tag = Me.pct_b3.Tag
                Me.pct_1.AccessibleDescription = Me.pct_b3.AccessibleDescription
                Me.pct_b3.Image = Me.lbl_1.Image
                Me.pct_b3.Tag = "0"
                Me.pct_b3.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_b3.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_b4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_b4.MouseDown
        If Me.lbl_5.Tag <> Me.pct_b4.Tag Then
            If Me.pct_b4.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_b4.Image
                Me.pct_1.Tag = Me.pct_b4.Tag
                Me.pct_1.AccessibleDescription = Me.pct_b4.AccessibleDescription
                Me.pct_b4.Image = Me.lbl_1.Image
                Me.pct_b4.Tag = "0"
                Me.pct_b4.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_b4.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_b5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_b5.MouseDown
        If Me.lbl_5.Tag <> Me.pct_b5.Tag Then
            If Me.pct_b5.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_b5.Image
                Me.pct_1.Tag = Me.pct_b5.Tag
                Me.pct_1.AccessibleDescription = Me.pct_b5.AccessibleDescription
                Me.pct_b5.Image = Me.lbl_1.Image
                Me.pct_b5.Tag = "0"
                Me.pct_b5.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_b5.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_b6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_b6.MouseDown
        If Me.lbl_5.Tag <> Me.pct_b6.Tag Then
            If Me.pct_b6.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_b6.Image
                Me.pct_1.Tag = Me.pct_b6.Tag
                Me.pct_1.AccessibleDescription = Me.pct_b6.AccessibleDescription
                Me.pct_b6.Image = Me.lbl_1.Image
                Me.pct_b6.Tag = "0"
                Me.pct_b6.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_b6.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_b7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_b7.MouseDown
        If Me.lbl_5.Tag <> Me.pct_b7.Tag Then
            If Me.pct_b7.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_b7.Image
                Me.pct_1.Tag = Me.pct_b7.Tag
                Me.pct_1.AccessibleDescription = Me.pct_b7.AccessibleDescription
                Me.pct_b7.Image = Me.lbl_1.Image
                Me.pct_b7.Tag = "0"
                Me.pct_b7.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_b7.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_b8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_b8.MouseDown
        If Me.lbl_5.Tag <> Me.pct_b8.Tag Then
            If Me.pct_b8.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_b8.Image
                Me.pct_1.Tag = Me.pct_b8.Tag
                Me.pct_1.AccessibleDescription = Me.pct_b8.AccessibleDescription
                Me.pct_b8.Image = Me.lbl_1.Image
                Me.pct_b8.Tag = "0"
                Me.pct_b8.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_b8.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub

    Private Sub pct_c1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_c1.MouseDown
        If Me.lbl_5.Tag <> Me.pct_c1.Tag Then
            If Me.pct_c1.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_c1.Image
                Me.pct_1.Tag = Me.pct_c1.Tag
                Me.pct_1.AccessibleDescription = Me.pct_c1.AccessibleDescription
                Me.pct_c1.Image = Me.lbl_1.Image
                Me.pct_c1.Tag = "0"
                Me.pct_c1.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_c1.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_c2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_c2.MouseDown
        If Me.lbl_5.Tag <> Me.pct_c2.Tag Then
            If Me.pct_c2.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_c2.Image
                Me.pct_1.Tag = Me.pct_c2.Tag
                Me.pct_1.AccessibleDescription = Me.pct_c2.AccessibleDescription
                Me.pct_c2.Image = Me.lbl_1.Image
                Me.pct_c2.Tag = "0"
                Me.pct_c2.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_c2.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_c3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_c3.MouseDown
        If Me.lbl_5.Tag <> Me.pct_c3.Tag Then
            If Me.pct_c3.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_c3.Image
                Me.pct_1.Tag = Me.pct_c3.Tag
                Me.pct_1.AccessibleDescription = Me.pct_c3.AccessibleDescription
                Me.pct_c3.Image = Me.lbl_1.Image
                Me.pct_c3.Tag = "0"
                Me.pct_c3.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_c3.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_c4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_c4.MouseDown
        If Me.lbl_5.Tag <> Me.pct_c4.Tag Then
            If Me.pct_c4.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_c4.Image
                Me.pct_1.Tag = Me.pct_c4.Tag
                Me.pct_1.AccessibleDescription = Me.pct_c4.AccessibleDescription
                Me.pct_c4.Image = Me.lbl_1.Image
                Me.pct_c4.Tag = "0"
                Me.pct_c4.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_c4.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_c5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_c5.MouseDown
        If Me.lbl_5.Tag <> Me.pct_c5.Tag Then
            If Me.pct_c5.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_c5.Image
                Me.pct_1.Tag = Me.pct_c5.Tag
                Me.pct_1.AccessibleDescription = Me.pct_c5.AccessibleDescription
                Me.pct_c5.Image = Me.lbl_1.Image
                Me.pct_c5.Tag = "0"
                Me.pct_c5.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_c5.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_c6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_c6.MouseDown
        If Me.lbl_5.Tag <> Me.pct_c6.Tag Then
            If Me.pct_c6.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_c6.Image
                Me.pct_1.Tag = Me.pct_c6.Tag
                Me.pct_1.AccessibleDescription = Me.pct_c6.AccessibleDescription
                Me.pct_c6.Image = Me.lbl_1.Image
                Me.pct_c6.Tag = "0"
                Me.pct_c6.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_c6.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_c7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_c7.MouseDown
        If Me.lbl_5.Tag <> Me.pct_c7.Tag Then
            If Me.pct_c7.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_c7.Image
                Me.pct_1.Tag = Me.pct_c7.Tag
                Me.pct_1.AccessibleDescription = Me.pct_c7.AccessibleDescription
                Me.pct_c7.Image = Me.lbl_1.Image
                Me.pct_c7.Tag = "0"
                Me.pct_c7.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_c7.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_c8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_c8.MouseDown
        If Me.lbl_5.Tag <> Me.pct_c8.Tag Then
            If Me.pct_c8.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_c8.Image
                Me.pct_1.Tag = Me.pct_c8.Tag
                Me.pct_1.AccessibleDescription = Me.pct_c8.AccessibleDescription
                Me.pct_c8.Image = Me.lbl_1.Image
                Me.pct_c8.Tag = "0"
                Me.pct_c8.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_c8.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub

    Private Sub pct_d1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_d1.MouseDown
        If Me.lbl_5.Tag <> Me.pct_d1.Tag Then
            If Me.pct_d1.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_d1.Image
                Me.pct_1.Tag = Me.pct_d1.Tag
                Me.pct_1.AccessibleDescription = Me.pct_d1.AccessibleDescription
                Me.pct_d1.Image = Me.lbl_1.Image
                Me.pct_d1.Tag = "0"
                Me.pct_d1.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_d1.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_d2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_d2.MouseDown
        If Me.lbl_5.Tag <> Me.pct_d2.Tag Then
            If Me.pct_d2.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_d2.Image
                Me.pct_1.Tag = Me.pct_d2.Tag
                Me.pct_1.AccessibleDescription = Me.pct_d2.AccessibleDescription
                Me.pct_d2.Image = Me.lbl_1.Image
                Me.pct_d2.Tag = "0"
                Me.pct_d2.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_d2.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_d3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_d3.MouseDown
        If Me.lbl_5.Tag <> Me.pct_d3.Tag Then
            If Me.pct_d3.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_d3.Image
                Me.pct_1.Tag = Me.pct_d3.Tag
                Me.pct_1.AccessibleDescription = Me.pct_d3.AccessibleDescription
                Me.pct_d3.Image = Me.lbl_1.Image
                Me.pct_d3.Tag = "0"
                Me.pct_d3.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_d3.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_d4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_d4.MouseDown
        If Me.lbl_5.Tag <> Me.pct_d4.Tag Then
            If Me.pct_d4.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_d4.Image
                Me.pct_1.Tag = Me.pct_d4.Tag
                Me.pct_1.AccessibleDescription = Me.pct_d4.AccessibleDescription
                Me.pct_d4.Image = Me.lbl_1.Image
                Me.pct_d4.Tag = "0"
                Me.pct_d4.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_d4.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_d5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_d5.MouseDown
        If Me.lbl_5.Tag <> Me.pct_d5.Tag Then
            If Me.pct_d5.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_d5.Image
                Me.pct_1.Tag = Me.pct_d5.Tag
                Me.pct_1.AccessibleDescription = Me.pct_d5.AccessibleDescription
                Me.pct_d5.Image = Me.lbl_1.Image
                Me.pct_d5.Tag = "0"
                Me.pct_d5.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_d5.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_d6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_d6.MouseDown
        If Me.lbl_5.Tag <> Me.pct_d6.Tag Then
            If Me.pct_d6.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_d6.Image
                Me.pct_1.Tag = Me.pct_d6.Tag
                Me.pct_1.AccessibleDescription = Me.pct_d6.AccessibleDescription
                Me.pct_d6.Image = Me.lbl_1.Image
                Me.pct_d6.Tag = "0"
                Me.pct_d6.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_d6.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_d7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_d7.MouseDown
        If Me.lbl_5.Tag <> Me.pct_d7.Tag Then
            If Me.pct_d7.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_d7.Image
                Me.pct_1.Tag = Me.pct_d7.Tag
                Me.pct_1.AccessibleDescription = Me.pct_d7.AccessibleDescription
                Me.pct_d7.Image = Me.lbl_1.Image
                Me.pct_d7.Tag = "0"
                Me.pct_d7.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_d7.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_d8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_d8.MouseDown
        If Me.lbl_5.Tag <> Me.pct_d8.Tag Then
            If Me.pct_d8.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_d8.Image
                Me.pct_1.Tag = Me.pct_d8.Tag
                Me.pct_1.AccessibleDescription = Me.pct_d8.AccessibleDescription
                Me.pct_d8.Image = Me.lbl_1.Image
                Me.pct_d8.Tag = "0"
                Me.pct_d8.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_d8.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub

    Private Sub pct_e1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_e1.MouseDown
        If Me.lbl_5.Tag <> Me.pct_e1.Tag Then
            If Me.pct_e1.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_e1.Image
                Me.pct_1.Tag = Me.pct_e1.Tag
                Me.pct_1.AccessibleDescription = Me.pct_e1.AccessibleDescription
                Me.pct_e1.Image = Me.lbl_1.Image
                Me.pct_e1.Tag = "0"
                Me.pct_e1.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_e1.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_e2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_e2.MouseDown
        If Me.lbl_5.Tag <> Me.pct_e2.Tag Then
            If Me.pct_e2.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_e2.Image
                Me.pct_1.Tag = Me.pct_e2.Tag
                Me.pct_1.AccessibleDescription = Me.pct_e2.AccessibleDescription
                Me.pct_e2.Image = Me.lbl_1.Image
                Me.pct_e2.Tag = "0"
                Me.pct_e2.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_e2.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_e3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_e3.MouseDown
        If Me.lbl_5.Tag <> Me.pct_e3.Tag Then
            If Me.pct_e3.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_e3.Image
                Me.pct_1.Tag = Me.pct_e3.Tag
                Me.pct_1.AccessibleDescription = Me.pct_e3.AccessibleDescription
                Me.pct_e3.Image = Me.lbl_1.Image
                Me.pct_e3.Tag = "0"
                Me.pct_e3.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_e3.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_e4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_e4.MouseDown
        If Me.lbl_5.Tag <> Me.pct_e4.Tag Then
            If Me.pct_e4.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_e4.Image
                Me.pct_1.Tag = Me.pct_e4.Tag
                Me.pct_1.AccessibleDescription = Me.pct_e4.AccessibleDescription
                Me.pct_e4.Image = Me.lbl_1.Image
                Me.pct_e4.Tag = "0"
                Me.pct_e4.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_e4.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_e5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_e5.MouseDown
        If Me.lbl_5.Tag <> Me.pct_e5.Tag Then
            If Me.pct_e5.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_e5.Image
                Me.pct_1.Tag = Me.pct_e5.Tag
                Me.pct_1.AccessibleDescription = Me.pct_e5.AccessibleDescription
                Me.pct_e5.Image = Me.lbl_1.Image
                Me.pct_e5.Tag = "0"
                Me.pct_e5.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_e5.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_e6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_e6.MouseDown
        If Me.lbl_5.Tag <> Me.pct_e6.Tag Then
            If Me.pct_e6.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_e6.Image
                Me.pct_1.Tag = Me.pct_e6.Tag
                Me.pct_1.AccessibleDescription = Me.pct_e6.AccessibleDescription
                Me.pct_e6.Image = Me.lbl_1.Image
                Me.pct_e6.Tag = "0"
                Me.pct_e6.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_e6.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_e7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_e7.MouseDown
        If Me.lbl_5.Tag <> Me.pct_e7.Tag Then
            If Me.pct_e7.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_e7.Image
                Me.pct_1.Tag = Me.pct_e7.Tag
                Me.pct_1.AccessibleDescription = Me.pct_e7.AccessibleDescription
                Me.pct_e7.Image = Me.lbl_1.Image
                Me.pct_e7.Tag = "0"
                Me.pct_e7.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_e7.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_e8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_e8.MouseDown
        If Me.lbl_5.Tag <> Me.pct_e8.Tag Then
            If Me.pct_e8.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_e8.Image
                Me.pct_1.Tag = Me.pct_e8.Tag
                Me.pct_1.AccessibleDescription = Me.pct_e8.AccessibleDescription
                Me.pct_e8.Image = Me.lbl_1.Image
                Me.pct_e8.Tag = "0"
                Me.pct_e8.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_e8.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub

    Private Sub pct_f1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_f1.MouseDown
        If Me.lbl_5.Tag <> Me.pct_f1.Tag Then
            If Me.pct_f1.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_f1.Image
                Me.pct_1.Tag = Me.pct_f1.Tag
                Me.pct_1.AccessibleDescription = Me.pct_f1.AccessibleDescription
                Me.pct_f1.Image = Me.lbl_1.Image
                Me.pct_f1.Tag = "0"
                Me.pct_f1.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_f1.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_f2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_f2.MouseDown
        If Me.lbl_5.Tag <> Me.pct_f2.Tag Then
            If Me.pct_f2.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_f2.Image
                Me.pct_1.Tag = Me.pct_f2.Tag
                Me.pct_1.AccessibleDescription = Me.pct_f2.AccessibleDescription
                Me.pct_f2.Image = Me.lbl_1.Image
                Me.pct_f2.Tag = "0"
                Me.pct_f2.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_f2.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_f3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_f3.MouseDown
        If Me.lbl_5.Tag <> Me.pct_f3.Tag Then
            If Me.pct_f3.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_f3.Image
                Me.pct_1.Tag = Me.pct_f3.Tag
                Me.pct_1.AccessibleDescription = Me.pct_f3.AccessibleDescription
                Me.pct_f3.Image = Me.lbl_1.Image
                Me.pct_f3.Tag = "0"
                Me.pct_f3.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_f3.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_f4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_f4.MouseDown
        If Me.lbl_5.Tag <> Me.pct_f4.Tag Then
            If Me.pct_f4.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_f4.Image
                Me.pct_1.Tag = Me.pct_f4.Tag
                Me.pct_1.AccessibleDescription = Me.pct_f4.AccessibleDescription
                Me.pct_f4.Image = Me.lbl_1.Image
                Me.pct_f4.Tag = "0"
                Me.pct_f4.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_f4.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_f5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_f5.MouseDown
        If Me.lbl_5.Tag <> Me.pct_f5.Tag Then
            If Me.pct_f5.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_f5.Image
                Me.pct_1.Tag = Me.pct_f5.Tag
                Me.pct_1.AccessibleDescription = Me.pct_f5.AccessibleDescription
                Me.pct_f5.Image = Me.lbl_1.Image
                Me.pct_f5.Tag = "0"
                Me.pct_f5.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_f5.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_f6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_f6.MouseDown
        If Me.lbl_5.Tag <> Me.pct_f6.Tag Then
            If Me.pct_f6.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_f6.Image
                Me.pct_1.Tag = Me.pct_f6.Tag
                Me.pct_1.AccessibleDescription = Me.pct_f6.AccessibleDescription
                Me.pct_f6.Image = Me.lbl_1.Image
                Me.pct_f6.Tag = "0"
                Me.pct_f6.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_f6.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_f7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_f7.MouseDown
        If Me.lbl_5.Tag <> Me.pct_f7.Tag Then
            If Me.pct_f7.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_f7.Image
                Me.pct_1.Tag = Me.pct_f7.Tag
                Me.pct_1.AccessibleDescription = Me.pct_f7.AccessibleDescription
                Me.pct_f7.Image = Me.lbl_1.Image
                Me.pct_f7.Tag = "0"
                Me.pct_f7.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_f7.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_f8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_f8.MouseDown
        If Me.lbl_5.Tag <> Me.pct_f8.Tag Then
            If Me.pct_f8.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_f8.Image
                Me.pct_1.Tag = Me.pct_f8.Tag
                Me.pct_1.AccessibleDescription = Me.pct_f8.AccessibleDescription
                Me.pct_f8.Image = Me.lbl_1.Image
                Me.pct_f8.Tag = "0"
                Me.pct_f8.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_f8.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub

    Private Sub pct_g1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_g1.MouseDown
        If Me.lbl_5.Tag <> Me.pct_g1.Tag Then
            If Me.pct_g1.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_g1.Image
                Me.pct_1.Tag = Me.pct_g1.Tag
                Me.pct_1.AccessibleDescription = Me.pct_g1.AccessibleDescription
                Me.pct_g1.Image = Me.lbl_1.Image
                Me.pct_g1.Tag = "0"
                Me.pct_g1.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_g1.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_g2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_g2.MouseDown
        If Me.lbl_5.Tag <> Me.pct_g2.Tag Then
            If Me.pct_g2.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_g2.Image
                Me.pct_1.Tag = Me.pct_g2.Tag
                Me.pct_1.AccessibleDescription = Me.pct_g2.AccessibleDescription
                Me.pct_g2.Image = Me.lbl_1.Image
                Me.pct_g2.Tag = "0"
                Me.pct_g2.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_g2.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_g3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_g3.MouseDown
        If Me.lbl_5.Tag <> Me.pct_g3.Tag Then
            If Me.pct_g3.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_g3.Image
                Me.pct_1.Tag = Me.pct_g3.Tag
                Me.pct_1.AccessibleDescription = Me.pct_g3.AccessibleDescription
                Me.pct_g3.Image = Me.lbl_1.Image
                Me.pct_g3.Tag = "0"
                Me.pct_g3.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_g3.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_g4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_g4.MouseDown
        If Me.lbl_5.Tag <> Me.pct_g4.Tag Then
            If Me.pct_g4.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_g4.Image
                Me.pct_1.Tag = Me.pct_g4.Tag
                Me.pct_1.AccessibleDescription = Me.pct_g4.AccessibleDescription
                Me.pct_g4.Image = Me.lbl_1.Image
                Me.pct_g4.Tag = "0"
                Me.pct_g4.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_g4.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_g5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_g5.MouseDown
        If Me.lbl_5.Tag <> Me.pct_g5.Tag Then
            If Me.pct_g5.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_g5.Image
                Me.pct_1.Tag = Me.pct_g5.Tag
                Me.pct_1.AccessibleDescription = Me.pct_g5.AccessibleDescription
                Me.pct_g5.Image = Me.lbl_1.Image
                Me.pct_g5.Tag = "0"
                Me.pct_g5.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_g5.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_g6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_g6.MouseDown
        If Me.lbl_5.Tag <> Me.pct_g6.Tag Then
            If Me.pct_g6.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_g6.Image
                Me.pct_1.Tag = Me.pct_g6.Tag
                Me.pct_1.AccessibleDescription = Me.pct_g6.AccessibleDescription
                Me.pct_g6.Image = Me.lbl_1.Image
                Me.pct_g6.Tag = "0"
                Me.pct_g6.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_g6.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_g7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_g7.MouseDown
        If Me.lbl_5.Tag <> Me.pct_g7.Tag Then
            If Me.pct_g7.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_g7.Image
                Me.pct_1.Tag = Me.pct_g7.Tag
                Me.pct_1.AccessibleDescription = Me.pct_g7.AccessibleDescription
                Me.pct_g7.Image = Me.lbl_1.Image
                Me.pct_g7.Tag = "0"
                Me.pct_g7.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_g7.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_g8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_g8.MouseDown
        If Me.lbl_5.Tag <> Me.pct_g8.Tag Then
            If Me.pct_g8.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_g8.Image
                Me.pct_1.Tag = Me.pct_g8.Tag
                Me.pct_1.AccessibleDescription = Me.pct_g8.AccessibleDescription
                Me.pct_g8.Image = Me.lbl_1.Image
                Me.pct_g8.Tag = "0"
                Me.pct_g8.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_g8.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub

    Private Sub pct_h1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_h1.MouseDown
        If Me.lbl_5.Tag <> Me.pct_h1.Tag Then
            If Me.pct_h1.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_h1.Image
                Me.pct_1.Tag = Me.pct_h1.Tag
                Me.pct_1.AccessibleDescription = Me.pct_h1.AccessibleDescription
                Me.pct_h1.Image = Me.lbl_1.Image
                Me.pct_h1.Tag = "0"
                Me.pct_h1.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_h1.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_h2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_h2.MouseDown
        If Me.lbl_5.Tag <> Me.pct_h2.Tag Then
            If Me.pct_h2.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_h2.Image
                Me.pct_1.Tag = Me.pct_h2.Tag
                Me.pct_1.AccessibleDescription = Me.pct_h2.AccessibleDescription
                Me.pct_h2.Image = Me.lbl_1.Image
                Me.pct_h2.Tag = "0"
                Me.pct_h2.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_h2.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_h3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_h3.MouseDown
        If Me.lbl_5.Tag <> Me.pct_h3.Tag Then
            If Me.pct_h3.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_h3.Image
                Me.pct_1.Tag = Me.pct_h3.Tag
                Me.pct_1.AccessibleDescription = Me.pct_h3.AccessibleDescription
                Me.pct_h3.Image = Me.lbl_1.Image
                Me.pct_h3.Tag = "0"
                Me.pct_h3.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_h3.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_h4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_h4.MouseDown
        If Me.lbl_5.Tag <> Me.pct_h4.Tag Then
            If Me.pct_h4.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_h4.Image
                Me.pct_1.Tag = Me.pct_h4.Tag
                Me.pct_1.AccessibleDescription = Me.pct_h4.AccessibleDescription
                Me.pct_h4.Image = Me.lbl_1.Image
                Me.pct_h4.Tag = "0"
                Me.pct_h4.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_h4.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_h5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_h5.MouseDown
        If Me.lbl_5.Tag <> Me.pct_h5.Tag Then
            If Me.pct_h5.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_h5.Image
                Me.pct_1.Tag = Me.pct_h5.Tag
                Me.pct_1.AccessibleDescription = Me.pct_h5.AccessibleDescription
                Me.pct_h5.Image = Me.lbl_1.Image
                Me.pct_h5.Tag = "0"
                Me.pct_h5.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_h5.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_h6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_h6.MouseDown
        If Me.lbl_5.Tag <> Me.pct_h6.Tag Then
            If Me.pct_h6.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_h6.Image
                Me.pct_1.Tag = Me.pct_h6.Tag
                Me.pct_1.AccessibleDescription = Me.pct_h6.AccessibleDescription
                Me.pct_h6.Image = Me.lbl_1.Image
                Me.pct_h6.Tag = "0"
                Me.pct_h6.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_h6.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_h7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_h7.MouseDown
        If Me.lbl_5.Tag <> Me.pct_h7.Tag Then
            If Me.pct_h7.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_h7.Image
                Me.pct_1.Tag = Me.pct_h7.Tag
                Me.pct_1.AccessibleDescription = Me.pct_h7.AccessibleDescription
                Me.pct_h7.Image = Me.lbl_1.Image
                Me.pct_h7.Tag = "0"
                Me.pct_h7.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_h7.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub
    Private Sub pct_h8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_h8.MouseDown
        If Me.lbl_5.Tag <> Me.pct_h8.Tag Then
            If Me.pct_h8.Tag = "0" Then
            Else
                Me.pct_1.Image = Me.pct_h8.Image
                Me.pct_1.Tag = Me.pct_h8.Tag
                Me.pct_1.AccessibleDescription = Me.pct_h8.AccessibleDescription
                Me.pct_h8.Image = Me.lbl_1.Image
                Me.pct_h8.Tag = "0"
                Me.pct_h8.AccessibleDescription = ""
                Me.Cursor = Cursors.NoMove2D
                color = False
                Me.pct_h8.BackColor = Drawing.Color.Yellow
            End If
        End If
    End Sub

    

    

    

    

    


























    Private Sub pct_a1_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_a1.MouseHover
        If Me.pct_a1.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_a1.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_a1.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_a1.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_a1.Tag
            Me.pct_a1.Image = Me.pct_1.Image
            Me.pct_a1.Tag = Me.pct_1.Tag
            Me.pct_a1.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_a2_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_a2.MouseHover
        If Me.pct_a2.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_a2.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_a2.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_a2.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_a2.Tag
            Me.pct_a2.Image = Me.pct_1.Image
            Me.pct_a2.Tag = Me.pct_1.Tag
            Me.pct_a2.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_a3_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_a3.MouseHover
        If Me.pct_a3.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_a3.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_a3.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_a3.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_a3.Tag
            Me.pct_a3.Image = Me.pct_1.Image
            Me.pct_a3.Tag = Me.pct_1.Tag
            Me.pct_a3.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_a4_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_a4.MouseHover
        If Me.pct_a4.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_a4.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_a4.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_a4.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_a4.Tag
            Me.pct_a4.Image = Me.pct_1.Image
            Me.pct_a4.Tag = Me.pct_1.Tag
            Me.pct_a4.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_a5_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_a5.MouseHover
        If Me.pct_a5.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_a5.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_a5.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_a5.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_a5.Tag
            Me.pct_a5.Image = Me.pct_1.Image
            Me.pct_a5.Tag = Me.pct_1.Tag
            Me.pct_a5.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_a6_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_a6.MouseHover
        If Me.pct_a6.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_a6.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_a6.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_a6.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_a6.Tag
            Me.pct_a6.Image = Me.pct_1.Image
            Me.pct_a6.Tag = Me.pct_1.Tag
            Me.pct_a6.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_a7_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_a7.MouseHover
        If Me.pct_a7.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_a7.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_a7.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_a7.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_a7.Tag
            Me.pct_a7.Image = Me.pct_1.Image
            Me.pct_a7.Tag = Me.pct_1.Tag
            Me.pct_a7.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_a8_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_a8.MouseHover
        If Me.pct_a8.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_a8.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_a8.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_a8.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_a8.Tag
            Me.pct_a8.Image = Me.pct_1.Image
            Me.pct_a8.Tag = Me.pct_1.Tag
            Me.pct_a8.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub

    Private Sub pct_b1_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_b1.MouseHover
        If Me.pct_b1.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_b1.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_b1.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_b1.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_b1.Tag
            Me.pct_b1.Image = Me.pct_1.Image
            Me.pct_b1.Tag = Me.pct_1.Tag
            Me.pct_b1.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_b2_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_b2.MouseHover
        If Me.pct_b2.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_b2.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_b2.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_b2.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_b2.Tag
            Me.pct_b2.Image = Me.pct_1.Image
            Me.pct_b2.Tag = Me.pct_1.Tag
            Me.pct_b2.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_b3_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_b3.MouseHover
        If Me.pct_b3.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_b3.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_b3.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_b3.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_b3.Tag
            Me.pct_b3.Image = Me.pct_1.Image
            Me.pct_b3.Tag = Me.pct_1.Tag
            Me.pct_b3.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_b4_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_b4.MouseHover
        If Me.pct_b4.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_b4.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_b4.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_b4.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_b4.Tag
            Me.pct_b4.Image = Me.pct_1.Image
            Me.pct_b4.Tag = Me.pct_1.Tag
            Me.pct_b4.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_b5_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_b5.MouseHover
        If Me.pct_b5.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_b5.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_b5.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_b5.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_b5.Tag
            Me.pct_b5.Image = Me.pct_1.Image
            Me.pct_b5.Tag = Me.pct_1.Tag
            Me.pct_b5.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_b6_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_b6.MouseHover
        If Me.pct_b6.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_b6.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_b6.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_b6.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_b6.Tag
            Me.pct_b6.Image = Me.pct_1.Image
            Me.pct_b6.Tag = Me.pct_1.Tag
            Me.pct_b6.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_b7_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_b7.MouseHover
        If Me.pct_b7.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_b7.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_b7.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_b7.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_b7.Tag
            Me.pct_b7.Image = Me.pct_1.Image
            Me.pct_b7.Tag = Me.pct_1.Tag
            Me.pct_b7.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_b8_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_b8.MouseHover
        If Me.pct_b8.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_b8.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_b8.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_b8.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_b8.Tag
            Me.pct_b8.Image = Me.pct_1.Image
            Me.pct_b8.Tag = Me.pct_1.Tag
            Me.pct_b8.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub

    Private Sub pct_c1_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_c1.MouseHover
        If Me.pct_c1.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_c1.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_c1.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_c1.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_c1.Tag
            Me.pct_c1.Image = Me.pct_1.Image
            Me.pct_c1.Tag = Me.pct_1.Tag
            Me.pct_c1.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_c2_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_c2.MouseHover
        If Me.pct_c2.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_c2.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_c2.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_c2.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_c2.Tag
            Me.pct_c2.Image = Me.pct_1.Image
            Me.pct_c2.Tag = Me.pct_1.Tag
            Me.pct_c2.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_c3_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_c3.MouseHover
        If Me.pct_c3.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_c3.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_c3.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_c3.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_c3.Tag
            Me.pct_c3.Image = Me.pct_1.Image
            Me.pct_c3.Tag = Me.pct_1.Tag
            Me.pct_c3.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_c4_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_c4.MouseHover
        If Me.pct_c4.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_c4.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_c4.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_c4.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_c4.Tag
            Me.pct_c4.Image = Me.pct_1.Image
            Me.pct_c4.Tag = Me.pct_1.Tag
            Me.pct_c4.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_c5_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_c5.MouseHover
        If Me.pct_c5.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_c5.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_c5.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_c5.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_c5.Tag
            Me.pct_c5.Image = Me.pct_1.Image
            Me.pct_c5.Tag = Me.pct_1.Tag
            Me.pct_c5.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_c6_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_c6.MouseHover
        If Me.pct_c6.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_c6.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_c6.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_c6.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_c6.Tag
            Me.pct_c6.Image = Me.pct_1.Image
            Me.pct_c6.Tag = Me.pct_1.Tag
            Me.pct_c6.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_c7_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_c7.MouseHover
        If Me.pct_c7.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_c7.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_c7.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_c7.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_c7.Tag
            Me.pct_c7.Image = Me.pct_1.Image
            Me.pct_c7.Tag = Me.pct_1.Tag
            Me.pct_c7.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_c8_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_c8.MouseHover
        If Me.pct_c8.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_c8.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_c8.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_c8.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_c8.Tag
            Me.pct_c8.Image = Me.pct_1.Image
            Me.pct_c8.Tag = Me.pct_1.Tag
            Me.pct_c8.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub

    Private Sub pct_d1_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_d1.MouseHover
        If Me.pct_d1.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_d1.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_d1.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_d1.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_d1.Tag
            Me.pct_d1.Image = Me.pct_1.Image
            Me.pct_d1.Tag = Me.pct_1.Tag
            Me.pct_d1.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_d2_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_d2.MouseHover
        If Me.pct_d2.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_d2.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_d2.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_d2.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_d2.Tag
            Me.pct_d2.Image = Me.pct_1.Image
            Me.pct_d2.Tag = Me.pct_1.Tag
            Me.pct_d2.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_d3_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_d3.MouseHover
        If Me.pct_d3.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_d3.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_d3.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_d3.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_d3.Tag
            Me.pct_d3.Image = Me.pct_1.Image
            Me.pct_d3.Tag = Me.pct_1.Tag
            Me.pct_d3.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_d4_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_d4.MouseHover
        If Me.pct_d4.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_d4.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_d4.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_d4.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_d4.Tag
            Me.pct_d4.Image = Me.pct_1.Image
            Me.pct_d4.Tag = Me.pct_1.Tag
            Me.pct_d4.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_d5_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_d5.MouseHover
        If Me.pct_d5.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_d5.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_d5.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_d5.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_d5.Tag
            Me.pct_d5.Image = Me.pct_1.Image
            Me.pct_d5.Tag = Me.pct_1.Tag
            Me.pct_d5.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_d6_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_d6.MouseHover
        If Me.pct_d6.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_d6.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_d6.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_d6.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_d6.Tag
            Me.pct_d6.Image = Me.pct_1.Image
            Me.pct_d6.Tag = Me.pct_1.Tag
            Me.pct_d6.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_d7_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_d7.MouseHover
        If Me.pct_d7.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_d7.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_d7.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_d7.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_d7.Tag
            Me.pct_d7.Image = Me.pct_1.Image
            Me.pct_d7.Tag = Me.pct_1.Tag
            Me.pct_d7.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_d8_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_d8.MouseHover
        If Me.pct_d8.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_d8.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_d8.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_d8.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_d8.Tag
            Me.pct_d8.Image = Me.pct_1.Image
            Me.pct_d8.Tag = Me.pct_1.Tag
            Me.pct_d8.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub

    Private Sub pct_e1_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_e1.MouseHover
        If Me.pct_e1.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_e1.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_e1.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_e1.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_e1.Tag
            Me.pct_e1.Image = Me.pct_1.Image
            Me.pct_e1.Tag = Me.pct_1.Tag
            Me.pct_e1.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_e2_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_e2.MouseHover
        If Me.pct_e2.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_e2.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_e2.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_e2.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_e2.Tag
            Me.pct_e2.Image = Me.pct_1.Image
            Me.pct_e2.Tag = Me.pct_1.Tag
            Me.pct_e2.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_e3_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_e3.MouseHover
        If Me.pct_e3.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_e3.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_e3.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_e3.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_e3.Tag
            Me.pct_e3.Image = Me.pct_1.Image
            Me.pct_e3.Tag = Me.pct_1.Tag
            Me.pct_e3.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_e4_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_e4.MouseHover
        If Me.pct_e4.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_e4.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_e4.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_e4.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_e4.Tag
            Me.pct_e4.Image = Me.pct_1.Image
            Me.pct_e4.Tag = Me.pct_1.Tag
            Me.pct_e4.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_e5_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_e5.MouseHover
        If Me.pct_e5.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_e5.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_e5.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_e5.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_e5.Tag
            Me.pct_e5.Image = Me.pct_1.Image
            Me.pct_e5.Tag = Me.pct_1.Tag
            Me.pct_e5.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_e6_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_e6.MouseHover
        If Me.pct_e6.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_e6.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_e6.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_e6.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_e6.Tag
            Me.pct_e6.Image = Me.pct_1.Image
            Me.pct_e6.Tag = Me.pct_1.Tag
            Me.pct_e6.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_e7_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_e7.MouseHover
        If Me.pct_e7.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_e7.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_e7.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_e7.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_e7.Tag
            Me.pct_e7.Image = Me.pct_1.Image
            Me.pct_e7.Tag = Me.pct_1.Tag
            Me.pct_e7.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_e8_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_e8.MouseHover
        If Me.pct_e8.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_e8.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_e8.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_e8.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_e8.Tag
            Me.pct_e8.Image = Me.pct_1.Image
            Me.pct_e8.Tag = Me.pct_1.Tag
            Me.pct_e8.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub

    Private Sub pct_f1_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_f1.MouseHover
        If Me.pct_f1.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_f1.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_f1.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_f1.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_f1.Tag
            Me.pct_f1.Image = Me.pct_1.Image
            Me.pct_f1.Tag = Me.pct_1.Tag
            Me.pct_f1.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_f2_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_f2.MouseHover
        If Me.pct_f2.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_f2.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_f2.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_f2.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_f2.Tag
            Me.pct_f2.Image = Me.pct_1.Image
            Me.pct_f2.Tag = Me.pct_1.Tag
            Me.pct_f2.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_f3_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_f3.MouseHover
        If Me.pct_f3.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_f3.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_f3.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_f3.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_f3.Tag
            Me.pct_f3.Image = Me.pct_1.Image
            Me.pct_f3.Tag = Me.pct_1.Tag
            Me.pct_f3.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_f4_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_f4.MouseHover
        If Me.pct_f4.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_f4.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_f4.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_f4.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_f4.Tag
            Me.pct_f4.Image = Me.pct_1.Image
            Me.pct_f4.Tag = Me.pct_1.Tag
            Me.pct_f4.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_f5_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_f5.MouseHover
        If Me.pct_f5.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_f5.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_f5.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_f5.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_f5.Tag
            Me.pct_f5.Image = Me.pct_1.Image
            Me.pct_f5.Tag = Me.pct_1.Tag
            Me.pct_f5.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_f6_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_f6.MouseHover
        If Me.pct_f6.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_f6.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_f6.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_f6.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_f6.Tag
            Me.pct_f6.Image = Me.pct_1.Image
            Me.pct_f6.Tag = Me.pct_1.Tag
            Me.pct_f6.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_f7_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_f7.MouseHover
        If Me.pct_f7.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_f7.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_f7.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_f7.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_f7.Tag
            Me.pct_f7.Image = Me.pct_1.Image
            Me.pct_f7.Tag = Me.pct_1.Tag
            Me.pct_f7.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_f8_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_f8.MouseHover
        If Me.pct_f8.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_f8.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_f8.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_f8.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_f8.Tag
            Me.pct_f8.Image = Me.pct_1.Image
            Me.pct_f8.Tag = Me.pct_1.Tag
            Me.pct_f8.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub

    Private Sub pct_g1_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_g1.MouseHover
        If Me.pct_g1.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_g1.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_g1.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_g1.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_g1.Tag
            Me.pct_g1.Image = Me.pct_1.Image
            Me.pct_g1.Tag = Me.pct_1.Tag
            Me.pct_g1.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_g2_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_g2.MouseHover
        If Me.pct_g2.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_g2.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_g2.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_g2.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_g2.Tag
            Me.pct_g2.Image = Me.pct_1.Image
            Me.pct_g2.Tag = Me.pct_1.Tag
            Me.pct_g2.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_g3_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_g3.MouseHover
        If Me.pct_g3.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_g3.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_g3.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_g3.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_g3.Tag
            Me.pct_g3.Image = Me.pct_1.Image
            Me.pct_g3.Tag = Me.pct_1.Tag
            Me.pct_g3.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_g4_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_g4.MouseHover
        If Me.pct_g4.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_g4.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_g4.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_g4.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_g4.Tag
            Me.pct_g4.Image = Me.pct_1.Image
            Me.pct_g4.Tag = Me.pct_1.Tag
            Me.pct_g4.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_g5_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_g5.MouseHover
        If Me.pct_g5.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_g5.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_g5.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_g5.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_g5.Tag
            Me.pct_g5.Image = Me.pct_1.Image
            Me.pct_g5.Tag = Me.pct_1.Tag
            Me.pct_g5.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_g6_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_g6.MouseHover
        If Me.pct_g6.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_g6.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_g6.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_g6.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_g6.Tag
            Me.pct_g6.Image = Me.pct_1.Image
            Me.pct_g6.Tag = Me.pct_1.Tag
            Me.pct_g6.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_g7_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_g7.MouseHover
        If Me.pct_g7.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_g7.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_g7.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_g7.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_g7.Tag
            Me.pct_g7.Image = Me.pct_1.Image
            Me.pct_g7.Tag = Me.pct_1.Tag
            Me.pct_g7.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_g8_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_g8.MouseHover
        If Me.pct_g8.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_g8.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_g8.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_g8.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_g8.Tag
            Me.pct_g8.Image = Me.pct_1.Image
            Me.pct_g8.Tag = Me.pct_1.Tag
            Me.pct_g8.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub

    Private Sub pct_h1_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_h1.MouseHover
        If Me.pct_h1.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_h1.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_h1.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_h1.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_h1.Tag
            Me.pct_h1.Image = Me.pct_1.Image
            Me.pct_h1.Tag = Me.pct_1.Tag
            Me.pct_h1.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_h2_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_h2.MouseHover
        If Me.pct_h2.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_h2.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_h2.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_h2.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_h2.Tag
            Me.pct_h2.Image = Me.pct_1.Image
            Me.pct_h2.Tag = Me.pct_1.Tag
            Me.pct_h2.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_h3_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_h3.MouseHover
        If Me.pct_h3.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_h3.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_h3.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_h3.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_h3.Tag
            Me.pct_h3.Image = Me.pct_1.Image
            Me.pct_h3.Tag = Me.pct_1.Tag
            Me.pct_h3.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_h4_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_h4.MouseHover
        If Me.pct_h4.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_h4.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_h4.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_h4.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_h4.Tag
            Me.pct_h4.Image = Me.pct_1.Image
            Me.pct_h4.Tag = Me.pct_1.Tag
            Me.pct_h4.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_h5_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_h5.MouseHover
        If Me.pct_h5.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_h5.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_h5.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_h5.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_h5.Tag
            Me.pct_h5.Image = Me.pct_1.Image
            Me.pct_h5.Tag = Me.pct_1.Tag
            Me.pct_h5.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_h6_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_h6.MouseHover
        If Me.pct_h6.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_h6.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_h6.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_h6.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_h6.Tag
            Me.pct_h6.Image = Me.pct_1.Image
            Me.pct_h6.Tag = Me.pct_1.Tag
            Me.pct_h6.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_h7_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_h7.MouseHover
        If Me.pct_h7.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_h7.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_h7.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_h7.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_h7.Tag
            Me.pct_h7.Image = Me.pct_1.Image
            Me.pct_h7.Tag = Me.pct_1.Tag
            Me.pct_h7.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub
    Private Sub pct_h8_Mousehover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_h8.MouseHover
        If Me.pct_h8.Tag = Me.pct_1.Tag Or Me.pct_1.Tag = "0" Then
        Else
            If Me.pct_h8.Tag = "1" Then
                Me.txt_black.Text += 1
            End If
            If Me.pct_h8.Tag = "2" Then
                Me.txt_white.Text += 1
            End If
            Me.lbl_1.AccessibleDescription = Me.pct_h8.AccessibleDescription
            Me.lbl_1.Tag = Me.pct_h8.Tag
            Me.pct_h8.Image = Me.pct_1.Image
            Me.pct_h8.Tag = Me.pct_1.Tag
            Me.pct_h8.AccessibleDescription = Me.pct_1.AccessibleDescription
            Me.pct_1.Image = Me.lbl_1.Image
            Me.pct_1.Tag = "0"
            Me.pct_1.AccessibleDescription = ""
            Me.Cursor = Cursors.Default
            Me.txt_mov.Text += 1
            color = True
        End If
    End Sub

    















    Private Sub tmr_2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_2.Tick
        Me.lbl_2.Text = TimeOfDay
        Me.lbl_3.Text = Me.pct_1.AccessibleDescription

        Dim x As DialogResult
        If Me.lbl_1.AccessibleDescription = "King" Then
            If Me.lbl_1.Tag = "1" Then
                Me.Size = Me.MaximumSize
                Me.tmr_2.Enabled = False
                x = MessageBox.Show("The White Team Is The Winner", "Congratiolations !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If x = Windows.Forms.DialogResult.OK Then
                    Me.Close()
                End If
            End If
            If Me.lbl_1.Tag = "2" Then
                Me.Size = Me.MaximumSize
                Me.tmr_2.Enabled = False
                x = MessageBox.Show("The Black Team Is The Winner", "Congratiolations !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If x = Windows.Forms.DialogResult.OK Then
                    Me.Close()
                End If
            End If
        End If

        If Me.pct_1.Tag > 0 Then
            Me.lbl_5.Tag = Me.pct_1.Tag
        End If

        If Me.lbl_5.Tag = "1" Then
            Me.lbl_5.Text = "White Turn"
        End If
        If Me.lbl_5.Tag = "2" Then
            Me.lbl_5.Text = "Black Turn"
        End If

        If color = True Then
            Me.pct_a1.BackColor = Drawing.Color.OrangeRed
            Me.pct_a2.BackColor = Drawing.Color.DarkOrange
            Me.pct_a3.BackColor = Drawing.Color.OrangeRed
            Me.pct_a4.BackColor = Drawing.Color.DarkOrange
            Me.pct_a5.BackColor = Drawing.Color.OrangeRed
            Me.pct_a6.BackColor = Drawing.Color.DarkOrange
            Me.pct_a7.BackColor = Drawing.Color.OrangeRed
            Me.pct_a8.BackColor = Drawing.Color.DarkOrange

            Me.pct_b1.BackColor = Drawing.Color.DarkOrange
            Me.pct_b2.BackColor = Drawing.Color.OrangeRed
            Me.pct_b3.BackColor = Drawing.Color.DarkOrange
            Me.pct_b4.BackColor = Drawing.Color.OrangeRed
            Me.pct_b5.BackColor = Drawing.Color.DarkOrange
            Me.pct_b6.BackColor = Drawing.Color.OrangeRed
            Me.pct_b7.BackColor = Drawing.Color.DarkOrange
            Me.pct_b8.BackColor = Drawing.Color.OrangeRed

            Me.pct_c1.BackColor = Drawing.Color.OrangeRed
            Me.pct_c2.BackColor = Drawing.Color.DarkOrange
            Me.pct_c3.BackColor = Drawing.Color.OrangeRed
            Me.pct_c4.BackColor = Drawing.Color.DarkOrange
            Me.pct_c5.BackColor = Drawing.Color.OrangeRed
            Me.pct_c6.BackColor = Drawing.Color.DarkOrange
            Me.pct_c7.BackColor = Drawing.Color.OrangeRed
            Me.pct_c8.BackColor = Drawing.Color.DarkOrange

            Me.pct_d1.BackColor = Drawing.Color.DarkOrange
            Me.pct_d2.BackColor = Drawing.Color.OrangeRed
            Me.pct_d3.BackColor = Drawing.Color.DarkOrange
            Me.pct_d4.BackColor = Drawing.Color.OrangeRed
            Me.pct_d5.BackColor = Drawing.Color.DarkOrange
            Me.pct_d6.BackColor = Drawing.Color.OrangeRed
            Me.pct_d7.BackColor = Drawing.Color.DarkOrange
            Me.pct_d8.BackColor = Drawing.Color.OrangeRed

            Me.pct_e1.BackColor = Drawing.Color.OrangeRed
            Me.pct_e2.BackColor = Drawing.Color.DarkOrange
            Me.pct_e3.BackColor = Drawing.Color.OrangeRed
            Me.pct_e4.BackColor = Drawing.Color.DarkOrange
            Me.pct_e5.BackColor = Drawing.Color.OrangeRed
            Me.pct_e6.BackColor = Drawing.Color.DarkOrange
            Me.pct_e7.BackColor = Drawing.Color.OrangeRed
            Me.pct_e8.BackColor = Drawing.Color.DarkOrange

            Me.pct_f1.BackColor = Drawing.Color.DarkOrange
            Me.pct_f2.BackColor = Drawing.Color.OrangeRed
            Me.pct_f3.BackColor = Drawing.Color.DarkOrange
            Me.pct_f4.BackColor = Drawing.Color.OrangeRed
            Me.pct_f5.BackColor = Drawing.Color.DarkOrange
            Me.pct_f6.BackColor = Drawing.Color.OrangeRed
            Me.pct_f7.BackColor = Drawing.Color.DarkOrange
            Me.pct_f8.BackColor = Drawing.Color.OrangeRed

            Me.pct_g1.BackColor = Drawing.Color.OrangeRed
            Me.pct_g2.BackColor = Drawing.Color.DarkOrange
            Me.pct_g3.BackColor = Drawing.Color.OrangeRed
            Me.pct_g4.BackColor = Drawing.Color.DarkOrange
            Me.pct_g5.BackColor = Drawing.Color.OrangeRed
            Me.pct_g6.BackColor = Drawing.Color.DarkOrange
            Me.pct_g7.BackColor = Drawing.Color.OrangeRed
            Me.pct_g8.BackColor = Drawing.Color.DarkOrange

            Me.pct_h1.BackColor = Drawing.Color.DarkOrange
            Me.pct_h2.BackColor = Drawing.Color.OrangeRed
            Me.pct_h3.BackColor = Drawing.Color.DarkOrange
            Me.pct_h4.BackColor = Drawing.Color.OrangeRed
            Me.pct_h5.BackColor = Drawing.Color.DarkOrange
            Me.pct_h6.BackColor = Drawing.Color.OrangeRed
            Me.pct_h7.BackColor = Drawing.Color.DarkOrange
            Me.pct_h8.BackColor = Drawing.Color.OrangeRed

        End If
    End Sub


    Private Sub lbl_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_4.Click
        Form3.Show()
        Form3.pct_a1.Enabled = True
        Form3.pct_b1.Enabled = True
        Form3.pct_c1.Enabled = True
        Form3.pct_d1.Enabled = True
        Form3.pct_e1.Enabled = True
        Form3.pct_f1.Enabled = True
        Form3.pct_a2.Enabled = True
        Form3.pct_b2.Enabled = True
        Form3.pct_c2.Enabled = True
        Form3.pct_d2.Enabled = True
        Form3.pct_e2.Enabled = True
        Form3.pct_f2.Enabled = True
        Form3.lbl_9.Visible = True
    End Sub

    Private Sub lbl_down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_down.Click
        Me.Size = Me.MaximumSize
    End Sub
    Private Sub lbl_up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_up.Click
        Me.Size = Me.MinimumSize
    End Sub
End Class