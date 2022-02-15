Imports System.IO
Public Class form_manage_student
    Dim aksi As String
    Sub reset()
        lv_student.Items.Clear()
    End Sub

    Sub buttonawal()
        btn_add.Enabled = True
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_save.Enabled = False
        btn_cancel.Enabled = False
        lv_student.Enabled = True
    End Sub
    Sub aksesteks(ByVal akses As Boolean)
        txt_address.Enabled = akses
        txt_id.Enabled = akses
        txt_name.Enabled = akses
        txt_number.Enabled = akses
        txt_date.Enabled = akses
        rd_female.Enabled = akses
        rd_male.Enabled = akses
        btn_id_user.Enabled = akses
        cb_class.Enabled = akses
        btn_photo.Enabled = akses
    End Sub
    Sub bersihteks()
        txt_id.Text = ""
        txt_address.Text = ""
        txt_date.Text = Now
        txt_name.Text = ""
        txt_number.Text = ""
        cb_class.Text = ""
        txt_id_user.Text = ""
        cb_class.Text = ""
        Picture.Image = Nothing
        txt_photo.Text = ""
    End Sub

    Sub tampildata()
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_student", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_student.Items.Add(reader!StudentID)
            lv_student.Items(i).SubItems.Add(reader!Name_student)
            lv_student.Items(i).SubItems.Add(reader!Address)
            lv_student.Items(i).SubItems.Add(reader!Gender)
            lv_student.Items(i).SubItems.Add(reader!DateofBirth)
            lv_student.Items(i).SubItems.Add(reader!NoHp)
            lv_student.Items(i).SubItems.Add(reader!Name_class)

            i = i + +1
        Loop
    End Sub

    Sub tampilclass()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("Select * from Class", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            cb_class.Items.Add(reader("Name_class"))
            cb_class_view.Items.Add(reader("Name_class"))
        Loop

    End Sub

    Private Sub form_manage_student_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_admin.Visible = True
    End Sub

    Private Sub form_manage_student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub form_manage_student_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampildata()
        buttonawal()
        aksesteks(False)
        bersihteks()
        tampilclass()
    End Sub

    Private Sub lv_student_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_student.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_student where StudentID = '" & lv_student.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id.Text = reader!StudentID
            txt_name.Text = reader!Name_student
            txt_address.Text = reader!Address
            txt_date.Text = reader!DateofBirth
            txt_number.Text = reader!NoHp
            cb_class.Text = reader!Name_Class
            txt_id_user.Text = reader!user_id
            txt_photo.Text = reader!image.ToString
            If reader!Gender = "Male" Then
                rd_male.Select()
            Else
                rd_female.Select()
            End If
            cb_class.Text = reader!Name_class

            Dim img() As Byte
            img = reader!image
            Dim ms As New MemoryStream(img)
            Picture.Image = Image.FromStream(ms)
            lbl_picture.Visible = False
          
        Loop

        btn_add.Enabled = False
        btn_edit.Enabled = True
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_cancel.Enabled = True

    End Sub

    Private Sub lv_student_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_student.SelectedIndexChanged

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        aksi = "T"
        aksesteks(True)
        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        btn_cancel.Enabled = True
        btn_delete.Enabled = False
        lv_student.Enabled = False

    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        aksi = "U"
        aksesteks(True)
        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_cancel.Enabled = True
        btn_delete.Enabled = False
        btn_save.Enabled = True
        lv_student.Enabled = False
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        konek_db()
        If txt_address.Text <> "" And txt_gender.Text <> "" And txt_name.Text <> "" And txt_number.Text <> "" And txt_photo.Text <> "" Then
            Dim ms As New MemoryStream
            Picture.Image.Save(ms, Picture.Image.RawFormat)
            If aksi = "T" Then
                konek_db()

                Dim save As New SqlClient.SqlCommand("insert into Student values( '" & txt_id.Text & "', '" & txt_name.Text &
                                                     "', '" & txt_address.Text & "', '" & txt_gender.Text &
                                                     "', '" & Format(txt_date.Value, "yyyy-MM-dd") & "', '" & txt_number.Text & "','" & txt_id_user.Text &
                                                     "', '" & txt_id_class.Text & "', @image)", koneksi)
                save.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray()



                Try

                    MsgBox("Data Berhasil disimpan", MsgBoxStyle.Information)
                    save.ExecuteNonQuery()
                    bersihteks()
                    tampildata()
                    aksesteks(False)
                    buttonawal()
                Catch ex As Exception
                    MsgBox("Data Gagal disimpan Karena " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            If aksi = "U" Then
                konek_db()
                Dim update As New SqlClient.SqlCommand("Update Student set Name_student = '" & txt_name.Text & "', Address = '" & txt_address.Text &
                                                       "', Gender ='" & txt_gender.Text & "', DateofBirth = '" & Format(txt_date.Value, "yyyy-MM-dd") &
                                                       "', id_user = '" & txt_id_user.Text & "', id_class ='" & txt_id_class.Text &
                                                       "', NoHp = '" & txt_number.Text &
                                                       "', image = @image where StudentID = '" & txt_id.Text & "'", koneksi)
                update.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    update.ExecuteNonQuery()
                    MsgBox("Data Berhasil di simpan", MsgBoxStyle.Information)

                    bersihteks()
                    tampildata()
                    aksesteks(False)
                    buttonawal()

                Catch ex As Exception
                    MsgBox("Data Gagal di simpan karena " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If


        Else
            MsgBox("Data harus di isi semua", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_id_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_id_user.Click
        Form_user.Show()
    End Sub

    Private Sub rd_male_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_male.CheckedChanged
        txt_gender.Text = "Male"
    End Sub

    Private Sub rd_female_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_female.CheckedChanged
        txt_gender.Text = "Female"
    End Sub

    Private Sub cb_class_view_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_class_view.SelectedIndexChanged

    End Sub

    Private Sub cb_class_view_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_class_view.TextChanged
        If cb_class_view.Text = "" Then
            tampildata()
        Else
            reset()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from v_student where Name_class = '" & cb_class_view.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer = 0
            Do While reader.Read
                lv_student.Items.Add(reader!StudentID)
                lv_student.Items(i).SubItems.Add(reader!Name_student)
                lv_student.Items(i).SubItems.Add(reader!Address)
                lv_student.Items(i).SubItems.Add(reader!Gender)
                lv_student.Items(i).SubItems.Add(reader!DateofBirth)
                lv_student.Items(i).SubItems.Add(reader!NoHp)
                lv_student.Items(i).SubItems.Add(reader!Name_class)

                i = i + +1

            Loop
        End If


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

    Private Sub txt_id_class_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_id_class.TextChanged

    End Sub

    Private Sub txt_photo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_photo.TextChanged

        If txt_photo.Text = "" Then
            lbl_picture.Text = "Picture 3 X 4"
            Picture.ImageLocation = txt_photo.Text
        End If
    End Sub

    Private Sub btn_photo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_photo.Click
        open_photo.Filter = "Jpeg|*.JPG|Bitmap| *.BMP|Gif| *.GIF"
        open_photo.RestoreDirectory = True
        open_photo.ShowDialog()
        If open_photo.FileName = "" Then Exit Sub
        Picture.ImageLocation = open_photo.FileName
        txt_photo.Text = open_photo.FileName
        lbl_picture.Text = ""
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        konek_db()
        Dim delete As New SqlClient.SqlCommand("delete from Student where StudentID = '" & txt_id.Text & "'", koneksi)
        Try
            delete.ExecuteNonQuery()
            MsgBox("data berhasil di hapus", MsgBoxStyle.Information)

            bersihteks()
            buttonawal()
            aksesteks(False)
            tampildata()
        Catch ex As Exception
            MsgBox("data gagal di hapus karena    ", +ex.Message)
        End Try
    End Sub
End Class