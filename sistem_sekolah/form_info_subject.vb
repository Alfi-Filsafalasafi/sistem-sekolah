Public Class form_info_subject
    Sub tampildata_student()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Subject where Name_subject ='" & Form_view_schedule.lbl_subject.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read
            lbl_subject.Text = Form_view_schedule.lbl_subject.Text
            lbl_deskripsi_subject.Text = reader!Description
            lbl_assigment.Text = reader!Assignment
            lbl_mid_exam.Text = reader!Mid_Exam
            lbl_final_exam.Text = reader!Final_Exam
        Loop
    End Sub
    Sub tampildata_teacher()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Subject where Name_subject ='" & form_Teaching_schedule.lbl_subject.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read
            lbl_subject.Text = form_Teaching_schedule.lbl_subject.Text
            lbl_deskripsi_subject.Text = reader!Description
            lbl_assigment.Text = reader!Assignment
            lbl_mid_exam.Text = reader!Mid_Exam
            lbl_final_exam.Text = reader!Final_Exam
        Loop
    End Sub
    Private Sub form_info_subject_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If txt_user.Text = "2" Then
            form_Teaching_schedule.Visible = True
            form_Teaching_schedule.btn_view.Enabled = False
            form_Teaching_schedule.lbl_subject.Text = ""
            form_Teaching_schedule.reset()
        End If
        If txt_user.Text = "3" Then
            Form_view_schedule.Visible = True
            Form_view_schedule.btn_view.Enabled = False
            Form_view_schedule.lbl_subject.Text = ""
        End If
    End Sub

    Private Sub form_info_subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub form_info_subject_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If txt_user.Text = "3" Then
            tampildata_student()
        End If
        If txt_user.Text = "2" Then
            tampildata_teacher()
        End If
    End Sub

    
    Private Sub lbl_deskripsi_subject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_deskripsi_subject.Click

    End Sub
End Class