Public Class Form_manage_class
    Sub reset_tampil_participation()
        lv_participan_student.Items.Clear()
    End Sub
    Sub reset_studentnonclass()
        lv_student_list.Items.Clear()
    End Sub
    Sub tampilstudent_nonclass()
        reset_studentnonclass()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Student where id_class = 0", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_student_list.Items.Add(reader!StudentID)
            lv_student_list.Items(i).SubItems.Add(reader!Name_student)
            lv_student_list.Items(i).SubItems.Add(reader!Gender)
            lv_student_list.Items(i).SubItems.Add(reader!NoHp)

            i = i + +1
        Loop
    End Sub
    Sub tampil_participation()
        reset_tampil_participation()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_student where Name_class = '" & txt_class_name.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Dim i As Integer
        If txt_class_name.Text = "" Then
            txt_id_class.Text = ""
        End If
        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_class.Text = reader!id_class
            End If
            lv_participan_student.Items.Add(reader!StudentID)
            lv_participan_student.Items(i).SubItems.Add(reader!Name_student)
            lv_participan_student.Items(i).SubItems.Add(reader!Gender)
            lv_participan_student.Items(i).SubItems.Add(reader!NoHp)

            i = i + +1
        End While
    End Sub

    Sub tampil_class()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Class", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_class_name.Items.Add(reader("Name_class"))
        Loop


    End Sub

    Private Sub Form_manage_class_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_admin.Visible = True
    End Sub

    Private Sub Form_manage_class_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_manage_class_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampil_class()
        tampilstudent_nonclass()
    End Sub

    Private Sub txt_class_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_class_name.SelectedIndexChanged

    End Sub

    Private Sub txt_class_name_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_class_name.TextChanged
        tampil_participation()




    End Sub

    Private Sub txt_search_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search_name.TextChanged
        reset_studentnonclass()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Student where id_class = 0 and Name_student LIKE'%" & txt_search_name.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader 
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_student_list.Items.Add(reader!StudentID)
            lv_student_list.Items(i).SubItems.Add(reader!Name_student)
            lv_student_list.Items(i).SubItems.Add(reader!Gender)
            lv_student_list.Items(i).SubItems.Add(reader!NoHp)

            i = i + +1
        Loop
    End Sub

    Private Sub lv_student_list_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_student_list.MouseClick
        btn_masuk.Enabled = True
        btn_keluar.Enabled = False
    End Sub

    Private Sub lv_student_list_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_student_list.SelectedIndexChanged
        
    End Sub

    Private Sub lv_participan_student_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_participan_student.MouseClick
        btn_keluar.Enabled = True
        btn_masuk.Enabled = False
    End Sub

    Private Sub btn_masuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_masuk.Click
        konek_db()
        Dim pindah As New SqlClient.SqlCommand("update Student set id_class ='" & txt_id_class.Text & "' where StudentID='" & lv_student_list.SelectedItems(0).SubItems(0).Text & "'", koneksi)

        Try
            pindah.ExecuteNonQuery()
            MsgBox("Data berhasil di pindah", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Data gagal di simpan" + ex.Message, MsgBoxStyle.Critical)
        End Try

        tampil_class()
        tampil_participation()
        tampilstudent_nonclass()
    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        konek_db()
        Dim pindah As New SqlClient.SqlCommand("update Student set id_class =0 where StudentID='" & lv_participan_student.SelectedItems(0).SubItems(0).Text & "'", koneksi)

        Try
            pindah.ExecuteNonQuery()
            MsgBox("Data berhasil di pindah", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Data gagal di simpan" + ex.Message, MsgBoxStyle.Critical)
        End Try

        tampil_class()
        tampil_participation()
        tampilstudent_nonclass()
    End Sub

    Private Sub lv_participan_student_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_participan_student.SelectedIndexChanged

    End Sub
End Class