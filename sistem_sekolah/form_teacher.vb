Public Class form_teacher

    Private Sub btn_edit_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_profile.Click
        Me.Visible = False
        Form_edit_profil.lbl_edit_id.Text = "Teacher ID"
        Form_edit_profil.lbl_edit_name.Text = "Teacher Name"
        Form_edit_profil.lbl_view_id.Text = "Teacher ID"
        Form_edit_profil.lbl_view_name.Text = "Teacher Name"
        Form_edit_profil.Show()
    End Sub

    Private Sub btn_teaching_schedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_teaching_schedule.Click
        Me.Visible = False
        form_Teaching_schedule.Show()
    End Sub

    Private Sub btn_log_out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_log_out.Click
        End
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub form_teacher_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
End Class