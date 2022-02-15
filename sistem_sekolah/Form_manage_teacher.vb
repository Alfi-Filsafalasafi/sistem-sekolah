Imports System.IO
Public Class Form_manage_teacher
    Dim aksi As String
    Sub bersihteks()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_address.Text = ""
        txt_number.Text = ""
        txt_date.Text = Now
        txt_id_user.Text = ""
        txt_id_subject.Text = ""
        txt_gender.Text = ""
        cb_subject.Text = ""
        txt_photo.Text = ""
        picture.Image = Nothing
    End Sub
    Sub aksesteks(ByVal akses As Boolean)
        txt_id.Enabled = akses
        txt_name.Enabled = akses
        txt_address.Enabled = akses
        txt_date.Enabled = akses
        btn_id_user.Enabled = akses
        txt_number.Enabled = akses
        cb_subject.Enabled = akses
        rd_female.Enabled = akses
        rd_male.Enabled = akses
        btn_cari.Enabled = akses
    End Sub
    Sub buttonawal()
        btn_add.Enabled = True
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False
        lv_teacher.Enabled = True
    End Sub
    Sub reset()
        lv_teacher.Items.Clear()
    End Sub

    Sub tampildata()
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("Select * from v_teacher", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_teacher.Items.Add(reader!TeacherID)
            lv_teacher.Items(i).SubItems.Add(reader!Name_teacher)
            lv_teacher.Items(i).SubItems.Add(reader!Address)
            lv_teacher.Items(i).SubItems.Add(reader!Gender)
            lv_teacher.Items(i).SubItems.Add(reader!date_of_birth)
            lv_teacher.Items(i).SubItems.Add(reader!phone_number)

            i = i + +1
        Loop
    End Sub

    Sub tampilsubject()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Subject", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            cb_subject.Items.Add(reader("Name_subject"))
        Loop
    End Sub

    Private Sub Form_manage_teacher_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_admin.Visible = True
    End Sub

    Private Sub Form_manage_teacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        aksi = "T"
        aksesteks(True)
        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        btn_delete.Enabled = False
        btn_cancel.Enabled = True
        lv_teacher.Enabled = False

    End Sub

    Private Sub Form_manage_teacher_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        bersihteks()
        aksesteks(False)
        buttonawal()
        tampildata()
        tampilsubject()
    End Sub

    Private Sub rd_male_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_male.CheckedChanged
        txt_gender.Text = "Male"
    End Sub

    Private Sub rd_female_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_female.CheckedChanged
        txt_gender.Text = "Female"
    End Sub

    Private Sub lv_teacher_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_teacher.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_teacher where TeacherID = '" & lv_teacher.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id.Text = reader!TeacherID
            txt_name.Text = reader!Name_teacher
            txt_address.Text = reader!Address
            txt_date.Text = reader!date_of_birth
            txt_number.Text = reader!phone_number
            If reader!Gender = "Male" Then
                rd_male.Select()
            Else
                rd_female.Select()
            End If
            txt_id_user.Text = reader!user_id
            cb_subject.Text = reader!Name_Subject

            txt_photo.Text = reader!image.ToString
            Dim img() As Byte
            img = reader!image
            Dim ms As New MemoryStream(img)
            picture.Image = Image.FromStream(ms)
            lbl_photo.Visible = False
        Loop

        btn_add.Enabled = False
        btn_edit.Enabled = True
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_cancel.Enabled = True
    End Sub

    Private Sub lv_teacher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_teacher.SelectedIndexChanged

    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        aksi = "U"
        aksesteks(True)
        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        btn_delete.Enabled = False
        btn_cancel.Enabled = True
        lv_teacher.Enabled = False
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_id.Text <> "" And txt_name.Text <> "" And txt_address.Text <> "" And txt_gender.Text <> "" And txt_id_user.Text <> "" And txt_number.Text <> "" Then
            
            If aksi = "T" Then
                Dim ms As New MemoryStream
                picture.Image.Save(ms, picture.Image.RawFormat)
                konek_db()
                Dim save As New SqlClient.SqlCommand("insert into Teacher values ('" & txt_id.Text & "', '" & txt_name.Text &
                                                     "', '" & txt_gender.Text & "', '" & txt_id_user.Text & "', '" & txt_address.Text &
                                                     "', '" & txt_number.Text & "', '" & Format(txt_date.Value, "yyyy-MM-dd") &
                                                     "', '" & txt_id_subject.Text & "', @image)", koneksi)

                save.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray

                Try
                    save.ExecuteNonQuery()
                    MsgBox("Data Berhasil di simpan", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Data Gagal di simpaan karena" + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            If aksi = "U" Then
                konek_db()
                Dim ms As New MemoryStream
                picture.Image.Save(ms, picture.Image.RawFormat)
                Dim update As New SqlClient.SqlCommand("Update Teacher set Name_teacher = '" & txt_name.Text & "', Gender ='" & txt_gender.Text &
                                                       "', Address='" & txt_address.Text & "', image=@image where TeacherID = '" & txt_id.Text & "'", koneksi)

                update.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    update.ExecuteNonQuery()
                    MsgBox("Data berhasil di simpan", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Data gagal disimpan karena " + ex.Message, MsgBoxStyle.Critical)
                End Try

            End If
            buttonawal()
            bersihteks()
            aksesteks(False)
            tampildata()
        Else
            MsgBox("Data di lengkapi dulu", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub cb_subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_subject.SelectedIndexChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Subject where Name_subject = '" & cb_subject.Text & "'", koneksi)
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

    Private Sub btn_id_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_id_user.Click
        Form_user.Show()
    End Sub

    Private Sub txt_id_subject_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_id_subject.TextChanged

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        konek_db()
        Dim delete As New SqlClient.SqlCommand("Delete from Teacher where TeacherID = '" & txt_id.Text & "'", koneksi)

        Try
            delete.ExecuteNonQuery()
            MsgBox("Data Berhasil di hapus", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Data Gagal di hapus karena " + ex.Message, MsgBoxStyle.Critical)
        End Try

        buttonawal()
        bersihteks()
        aksesteks(False)
        tampildata()
    End Sub

    Private Sub txt_search_teacher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search_teacher.TextChanged
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Teacher where Name_teacher LIKE'%" & txt_search_teacher.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read()
            lv_teacher.Items.Add(reader!TeacherID)
            lv_teacher.Items(i).SubItems.Add(reader!Name_teacher)
            lv_teacher.Items(i).SubItems.Add(reader!Address)
            lv_teacher.Items(i).SubItems.Add(reader!Gender)
            lv_teacher.Items(i).SubItems.Add(reader!date_of_birth)
            lv_teacher.Items(i).SubItems.Add(reader!phone_number)

            i = i + +1
        Loop
    End Sub

    Private Sub btn_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari.Click


        open_photo.Filter = "Jpeg|*.JPG|Bitmap| *.BMP|Gif| *.GIF"
        open_photo.RestoreDirectory = True
        open_photo.ShowDialog()
        If open_photo.FileName = "" Then Exit Sub

        picture.ImageLocation = open_photo.FileName
        txt_photo.Text = open_photo.FileName
        lbl_photo.Text = ""

    End Sub

    Private Sub txt_photo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_photo.TextChanged
        If txt_photo.Text = "" Then
            lbl_photo.Text = "Picture 3 X 4 "
            picture.ImageLocation = txt_photo.Text
        End If
    End Sub
End Class