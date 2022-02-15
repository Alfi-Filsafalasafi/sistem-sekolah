Public Class Form_admin

    Private Sub btn_management_student_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_management_student.Click
        Me.Visible = False
        form_manage_student.Show()

    End Sub

    Private Sub Form_admin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Form_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btn_management_teacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_management_teacher.Click
        Me.Visible = False
        Form_manage_teacher.Show()

    End Sub

    Private Sub btn_edit_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_profile.Click
        Me.Visible = False
        Form_edit_profil.Show()
        Form_edit_profil.lbl_edit_id.Text = "Admin ID"
        Form_edit_profil.lbl_edit_name.Text = "Admin Name"
        Form_edit_profil.lbl_view_id.Text = "Admin ID"
        Form_edit_profil.lbl_view_name.Text = "Admin Name"

    End Sub

    Private Sub btn_manage_class_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_manage_class.Click
        Me.Visible = False
        Form_manage_class.Show()

    End Sub

    Private Sub btn_manage_schedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_manage_schedule.Click
        Me.Visible = False
        Form_manage_schedule.Show()

    End Sub

    Private Sub btn_log_out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_log_out.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        Form_manage_subject.Show()
    End Sub
End Class