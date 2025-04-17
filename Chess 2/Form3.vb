Public Class Form3

    
    Private Sub pct_a1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_a1.MouseDown
        Form2.pct_1.Image = Me.pct_a1.Image
        Form2.pct_1.Tag = Me.pct_a1.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_a1.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub pct_b1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_b1.MouseDown
        Form2.pct_1.Image = Me.pct_b1.Image
        Form2.pct_1.Tag = Me.pct_b1.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_b1.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub pct_c1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_c1.MouseDown
        Form2.pct_1.Image = Me.pct_c1.Image
        Form2.pct_1.Tag = Me.pct_c1.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_c1.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub pct_d1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_d1.MouseDown
        Form2.pct_1.Image = Me.pct_d1.Image
        Form2.pct_1.Tag = Me.pct_d1.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_d1.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub pct_e1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_e1.MouseDown
        Form2.pct_1.Image = Me.pct_e1.Image
        Form2.pct_1.Tag = Me.pct_e1.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_e1.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub pct_f1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_f1.MouseDown
        Form2.pct_1.Image = Me.pct_f1.Image
        Form2.pct_1.Tag = Me.pct_f1.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_f1.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub

    Private Sub pct_a2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_a2.MouseDown
        Form2.pct_1.Image = Me.pct_a2.Image
        Form2.pct_1.Tag = Me.pct_a2.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_a2.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub pct_b2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_b2.MouseDown
        Form2.pct_1.Image = Me.pct_b2.Image
        Form2.pct_1.Tag = Me.pct_b2.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_b2.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub pct_c2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_c2.MouseDown
        Form2.pct_1.Image = Me.pct_c2.Image
        Form2.pct_1.Tag = Me.pct_c2.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_c2.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub pct_d2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_d2.MouseDown
        Form2.pct_1.Image = Me.pct_d2.Image
        Form2.pct_1.Tag = Me.pct_d2.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_d2.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub pct_e2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_e2.MouseDown
        Form2.pct_1.Image = Me.pct_e2.Image
        Form2.pct_1.Tag = Me.pct_e2.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_e2.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub pct_f2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pct_f2.MouseDown
        Form2.pct_1.Image = Me.pct_f2.Image
        Form2.pct_1.Tag = Me.pct_f2.Tag
        Form2.pct_1.AccessibleDescription = Me.pct_f2.AccessibleDescription
        Me.Cursor = Cursors.NoMove2D
    End Sub
   






    Private Sub lbl_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_8.Click
        Form4.Show()
    End Sub

    Private Sub Form3_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form4.Close()
    End Sub
End Class