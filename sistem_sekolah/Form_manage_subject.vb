Public Class Form_manage_subject
    Dim aksi As String
    Sub reset()
        lv_subject.Items.Clear()
    End Sub
    Sub bersihteks()
        txt_assignment.Text = ""
        txt_descripsi.Text = ""
        txt_final_exam.Text = ""
        txt_mid_exam.Text = ""
        txt_name.Text = ""
        txt_subject_id.Text = ""
    End Sub

    Sub aksesteks(ByVal akses As Boolean)
        txt_assignment.Enabled = akses
        txt_descripsi.Enabled = akses
        txt_final_exam.Enabled = akses
        txt_mid_exam.Enabled = akses
        txt_name.Enabled = akses
        txt_subject_id.Enabled = akses
    End Sub
    Sub buttonawal()
        btn_add.Enabled = True
        btn_cancel.Enabled = False
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        lv_subject.Enabled = True
    End Sub

    Sub tampildata()
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from subject", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_subject.Items.Add(reader!SubjectID)
            lv_subject.Items(i).SubItems.Add(reader!Name_subject)
            lv_subject.Items(i).SubItems.Add(reader!Assignment)
            lv_subject.Items(i).SubItems.Add(reader!Mid_Exam)
            lv_subject.Items(i).SubItems.Add(reader!Final_Exam)

            i = i + +1
        Loop
    End Sub

    Private Sub Form1_manage_subject_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_admin.Visible = True
    End Sub

    Private Sub Form1_manage_subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_manage_subject_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampildata()
        buttonawal()
        aksesteks(False)
        bersihteks()
    End Sub

    Private Sub lv_subject_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_subject.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("Select * from Subject where SubjectID = '" & lv_subject.SelectedItems(0).SubItems(0).Text & "' ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_assignment.Text = reader!Assignment
            txt_descripsi.Text = reader!Description
            txt_final_exam.Text = reader!Final_Exam
            txt_mid_exam.Text = reader!Mid_Exam
            txt_name.Text = reader!Name_Subject
            txt_subject_id.Text = reader!SubjectID
        Loop

        btn_add.Enabled = False
        btn_cancel.Enabled = True
        btn_delete.Enabled = True
        btn_edit.Enabled = True
        btn_save.Enabled = False
    End Sub

    Private Sub lv_subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_subject.SelectedIndexChanged

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        aksesteks(True)
        bersihteks()
        aksi = "T"
        btn_add.Enabled = False
        btn_cancel.Enabled = True
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        lv_subject.Enabled = False
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        aksesteks(True)
        aksi = "U"
        btn_add.Enabled = False
        btn_cancel.Enabled = True
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        lv_subject.Enabled = False
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        konek_db()
        Dim delete As New SqlClient.SqlCommand("Delete from Subject where SubjectID='" & txt_subject_id.Text & "'", koneksi)
        Try
            delete.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Data gagal di hapus karena " + ex.Message, MsgBoxStyle.Critical)
        End Try

        buttonawal()
        bersihteks()
        aksesteks(False)
        tampildata()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_assignment.Text <> "" And txt_descripsi.Text <> "" And txt_final_exam.Text <> "" And txt_mid_exam.Text <> "" And txt_name.Text <> "" And txt_subject_id.Text <> "" Then
            If aksi = "T" Then
                konek_db()
                Dim save As New SqlClient.SqlCommand("insert into Subject values('" & txt_subject_id.Text & "', '" & txt_name.Text &
                                                     "', '" & txt_descripsi.Text & "', '" & txt_assignment.Text &
                                                     "', '" & txt_mid_exam.Text & "', '" & txt_final_exam.Text & "')", koneksi)

                Try
                    save.ExecuteNonQuery()
                    MsgBox("Data berhasil di simpan", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Data gagal di simpan", MsgBoxStyle.Critical)
                End Try
            End If
            If aksi = "U" Then
                konek_db()
                Dim update As New SqlClient.SqlCommand("Update Subject set Name_subject = '" & txt_name.Text & "', Assignment='" & txt_assignment.Text &
                                                       "', Description = '" & txt_descripsi.Text & "', Mid_Exam = '" & txt_mid_exam.Text &
                                                       "', Final_Exam = '" & txt_final_exam.Text & "' where SubjectID = '" & txt_subject_id.Text & "'", koneksi)
                Try
                    update.ExecuteNonQuery()
                    MsgBox("Data berhasil di ubah", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Data Gagal di ubah" + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            buttonawal()
            aksesteks(False)
            bersihteks()
            tampildata()
        Else
            MsgBox("Lengkapi data dulu", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search_subject.TextChanged
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from subject where Name_subject LIKE'%" & txt_search_subject.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_subject.Items.Add(reader!SubjectID)
            lv_subject.Items(i).SubItems.Add(reader!Name_subject)
            lv_subject.Items(i).SubItems.Add(reader!Assignment)
            lv_subject.Items(i).SubItems.Add(reader!Mid_Exam)
            lv_subject.Items(i).SubItems.Add(reader!Final_Exam)

            i = i + +1
        Loop
    End Sub
End Class