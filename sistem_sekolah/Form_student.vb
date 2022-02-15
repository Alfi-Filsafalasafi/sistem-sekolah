Public Class Form_student

    Private Sub btn_edit_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_profile.Click
        Me.Visible = False
        Form_edit_profil.Show()
        Form_edit_profil.lbl_edit_id.Text = "Student ID"
        Form_edit_profil.lbl_edit_name.Text = "Student Name"
        Form_edit_profil.lbl_view_id.Text = "Student ID"
        Form_edit_profil.lbl_view_name.Text = "Student Name"
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Form_student_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub btn_class_schedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_class_schedule.Click
        Me.Visible = False
        Form_view_schedule.Show()

    End Sub

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        End
    End Sub

    Private Sub Form_student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class