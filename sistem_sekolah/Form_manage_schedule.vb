Public Class Form_manage_schedule
    Dim aksi As String
    Sub reset_schedule()
        lv_schedule.Items.Clear()
    End Sub
    Sub bersihteks()
        cb_class.Text = ""
        cb_subject.Text = ""
        cb_teacher.Text = ""
        cb_day.Text = ""
        txt_time.Text = ""
    End Sub
    Sub buttonawal()
        btn_add.Enabled = True
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False
        lv_schedule.Enabled = True
    End Sub
    Sub aksesteks(ByVal akses As Boolean)
        cb_class.Enabled = akses
        cb_subject.Enabled = akses
        cb_teacher.Enabled = akses
        cb_day.Enabled = akses
        txt_time.Enabled = akses
    End Sub
    Sub tampil_schedule()
        reset_schedule()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_schedule1", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read()
            lv_schedule.Items.Add(reader!SubjectID)
            lv_schedule.Items(i).SubItems.Add(reader!Name_subject)
            lv_schedule.Items(i).SubItems.Add(reader!TeacherID)
            lv_schedule.Items(i).SubItems.Add(reader!Name_teacher)
            lv_schedule.Items(i).SubItems.Add(reader!Name_class)
            lv_schedule.Items(i).SubItems.Add(reader!Day)
            lv_schedule.Items(i).SubItems.Add(reader!Time)
            lv_schedule.Items(i).SubItems.Add(reader!ScheduleID)


            i = i + +1
        Loop
    End Sub

    Sub tampil_subject()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Subject", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            cb_subject.Items.Add(reader("Name_subject"))
        Loop
        konek_db()

    End Sub

    Sub tampil_class()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Class", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            cb_class.Items.Add(reader("Name_class"))
        Loop
    End Sub

    Sub tampil_teacher()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("Select * from Teacher", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            cb_teacher.Items.Add(reader("Name_teacher"))
        Loop
    End Sub

    Private Sub Form_manage_schedule_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_admin.Visible = True
    End Sub

    Private Sub Form_manage_schedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Form_manage_schedule_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        bersihteks()
        buttonawal()
        aksesteks(False)
        tampil_schedule()
        tampil_subject()
        tampil_class()
        tampil_teacher()
    End Sub

    Private Sub cb_subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_subject.SelectedIndexChanged

    End Sub

    Private Sub cb_subject_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_subject.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("Select * from Subject where Name_subject = '" & cb_subject.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        If cb_subject.Text = "" Then
            txt_id_subject.Text = ""
        End If
        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_subject.Text = reader!SubjectID
            End If
        End While

    End Sub

    Private Sub cb_teacher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_teacher.SelectedIndexChanged

    End Sub

    Private Sub cb_teacher_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_teacher.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("Select * from Teacher where Name_teacher = '" & cb_teacher.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        If cb_teacher.Text = "" Then
            txt_id_teacher.Text = ""
        End If
        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_teacher.Text = reader!TeacherID
            End If
        End While
    End Sub

    Private Sub cb_class_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_class.SelectedIndexChanged

    End Sub

    Private Sub cb_class_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_class.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Class where Name_class = '" & cb_class.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        If cb_class.Text = "" Then
            txt_id_class.Text = ""
        End If
        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_class.Text = reader!ClassID
            End If
        End While
    End Sub

    Private Sub lv_schedule_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_schedule.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("Select * from v_schedule1 where ScheduleID = '" & lv_schedule.SelectedItems(0).SubItems(7).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            cb_class.Text = reader!Name_class
            cb_subject.Text = reader!Name_subject
            cb_teacher.Text = reader!Name_teacher
            cb_day.Text = reader!Day
            txt_time.Text = reader!Time
        Loop

        btn_add.Enabled = False
        btn_edit.Enabled = True
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_cancel.Enabled = True
    End Sub

    Private Sub lv_schedule_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_schedule.SelectedIndexChanged

    End Sub


    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        aksi = "T"
        aksesteks(True)
        bersihteks()
        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        btn_delete.Enabled = False
        btn_cancel.Enabled = True
        lv_schedule.Enabled = False
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        aksi = "U"
        aksesteks(True)
        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        btn_delete.Enabled = False
        btn_cancel.Enabled = True
        lv_schedule.Enabled = False
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        bersihteks()
        buttonawal()
        aksesteks(False)
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        konek_db()
        Dim hapus_detail As New SqlClient.SqlCommand("Delete from DetailSchedule where ScheduleID = '" & lv_schedule.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim hapus As New SqlClient.SqlCommand("Delete From HeaderSchedule where ScheduleID = '" & lv_schedule.SelectedItems(0).SubItems(0).Text & "'", koneksi)

        Try
            hapus_detail.ExecuteNonQuery()
            hapus.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Data gagal di hapus karena " + ex.Message, MsgBoxStyle.Critical)
        End Try
        tampil_schedule()
        aksesteks(False)
        buttonawal()
        bersihteks()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If cb_class.Text <> "" And cb_subject.Text <> "" And cb_teacher.Text <> "" And cb_day.Text <> "" And txt_time.Text <> "" Then
            If aksi = "T" Then
                konek_db()
                Dim simpan1 As New SqlClient.SqlCommand("SET IDENTITY_INSERT HeaderSchedule off", koneksi)
                Dim simpan As New SqlClient.SqlCommand("Insert into HeaderSchedule values ('" & txt_id_subject.Text &
                                                       "' , '" & txt_id_teacher.Text & "', '" & txt_id_class.Text &
                                                       "' , '" & cb_day.Text & "', '" & txt_time.Text & "')", koneksi)
                Try
                    simpan1.ExecuteNonQuery()
                    simpan.ExecuteNonQuery()
                    MsgBox("Data berhasil di simpan", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Data Gagal di simpan karena  " + ex.Message)
                End Try
            End If
            If aksi = "U" Then
                konek_db()
                Dim update As New SqlClient.SqlCommand("Update HeaderSchedule set SubjectID = '" & txt_id_subject.Text &
                                                       "', TeacherID = '" & txt_id_teacher.Text & "',ClassID = '" & txt_id_class.Text &
                                                       "', Day = '" & cb_day.Text & "', Time = '" & txt_time.Text &
                                                       "' where ScheduleID = '" & lv_schedule.SelectedItems(0).SubItems(7).Text & "'", koneksi)
                Try
                    update.ExecuteNonQuery()
                    MsgBox("Data Berhasil di update", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Data gagal di update", MsgBoxStyle.Critical)
                End Try
            End If
        Else
            MsgBox("Mohon di lengkapi dulu", MsgBoxStyle.Critical)
        End If
        tampil_schedule()
        buttonawal()
        bersihteks()
        aksesteks(False)

    End Sub
End Class