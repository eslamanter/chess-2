Public Class Form1

    Private Sub btn_1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        Me.Visible = False
        Form2.Show()
        Form3.Close()
        Form4.Close()
    End Sub

    Private Sub btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_3.Click
        Form4.Show()
    End Sub

    Private Sub btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2.Click
        Form3.Show()
    End Sub

    Private Sub tmr_1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_1.Tick
        Me.prg_1.Value += 1
        
        If Me.prg_1.Value = 1 Then
            Me.pct_x1.Visible = True
        End If
        If Me.prg_1.Value = 2 Then
            Me.pct_x2.Visible = True
        End If
        If Me.prg_1.Value = 3 Then
            Me.pct_x3.Visible = True
        End If
        If Me.prg_1.Value = 4 Then
            Me.pct_x4.Visible = True
        End If
        If Me.prg_1.Value = 5 Then
            Me.pct_x5.Visible = True
        End If
        If Me.prg_1.Value = 6 Then
            Me.pct_x6.Visible = True
        End If

        If Me.prg_1.Value = 6 Then
            Me.tmr_1.Enabled = False
            Me.lbl_5.Text = "2013"
        End If
    End Sub

    Private Sub pct_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_2.Click
        Form4.Show()
    End Sub

    Private Sub pct_x1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_x1.Click
        Me.lbl_5.Text = Me.pct_x1.AccessibleDescription
        Me.prg_1.Value = 0
        Me.tmr_1.Enabled = True
    End Sub
    Private Sub pct_x2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_x2.Click
        Me.lbl_5.Text = Me.pct_x2.AccessibleDescription
        Me.prg_1.Value = 0
        Me.tmr_1.Enabled = True
    End Sub
    Private Sub pct_x3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_x3.Click
        Me.lbl_5.Text = Me.pct_x3.AccessibleDescription
        Me.prg_1.Value = 0
        Me.tmr_1.Enabled = True
    End Sub
    Private Sub pct_x4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_x4.Click
        Me.lbl_5.Text = Me.pct_x4.AccessibleDescription
        Me.prg_1.Value = 0
        Me.tmr_1.Enabled = True
    End Sub
    Private Sub pct_x5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_x5.Click
        Me.lbl_5.Text = Me.pct_x5.AccessibleDescription
        Me.prg_1.Value = 0
        Me.tmr_1.Enabled = True
    End Sub
    Private Sub pct_x6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_x6.Click
        Me.lbl_5.Text = Me.pct_x6.AccessibleDescription
        Me.prg_1.Value = 0
        Me.tmr_1.Enabled = True
    End Sub
End Class
