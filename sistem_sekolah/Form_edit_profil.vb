Imports System.IO

Public Class Form_edit_profil
    Sub reset()
        lbl_student_id.Text = ""
        lbl_student_name.Text = ""
        lbl_address.Text = ""
        lbl_date.Text = ""
        lbl_phone_number.Text = ""
    End Sub

    Sub akses_teks(ByVal akses As Boolean)

        txt_student_name.Enabled = akses
        txt_address.Enabled = akses
        txt_date.Enabled = akses
        txt_phone_number.Enabled = akses

    End Sub
    Sub button_awal()
        btn_edit.Enabled = True
        btn_save.Enabled = False
        btn_cancel.Enabled = False
        btn_close.Enabled = True
    End Sub
    Sub tampildata()
        If lbl_view_id.Text = "Admin ID" Then
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from Admin where Name_admin = '" & Form_admin.lbl_nama.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader

            Dim i As Integer = 0
            Do While reader.Read
                lbl_student_id.Text = reader!admin_id
                lbl_student_name.Text = reader!Name_admin
                lbl_address.Text = reader!address
                lbl_date.Text = reader!date_of_birth
                lbl_phone_number.Text = reader!phone_number

                txt_student_id.Text = reader!admin_id
                txt_student_name.Text = reader!Name_admin
                txt_address.Text = reader!address
                txt_date.Text = reader!date_of_birth
                txt_phone_number.Text = reader!phone_number
                txt_photo.Text = reader!image.ToString
                Dim img() As Byte
                img = reader!image
                Dim ms As New MemoryStream(img)
                picture.Image = Image.FromStream(ms)
                lbl_picture.Visible = False
                Label23.Visible = False
                picture_view.Image = Image.FromStream(ms)

            Loop
        End If
        If lbl_edit_id.Text = "Student ID" Then
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from Student where Name_student = '" & Form_student.lbl_nama.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader

            Dim i As Integer = 0
            Do While reader.Read
                lbl_student_id.Text = reader!StudentID
                lbl_student_name.Text = reader!Name_student
                lbl_address.Text = reader!address
                lbl_date.Text = reader!DateofBirth
                lbl_phone_number.Text = reader!NoHp

                txt_photo.Text = reader!image.ToString
                Dim img() As Byte
                img = reader!image
                Dim ms As New MemoryStream(img)
                picture.Image = Image.FromStream(ms)
                picture_view.Image = Image.FromStream(ms)
                lbl_picture.Visible = False
                Label23.Visible = False
                txt_student_id.Text = reader!StudentID
                txt_student_name.Text = reader!Name_student
                txt_address.Text = reader!address
                txt_date.Text = reader!DateofBirth
                txt_phone_number.Text = reader!NoHp
            Loop
        End If
        If lbl_edit_id.Text = "Teacher ID" Then
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from Teacher where Name_teacher = '" & form_teacher.lbl_nama.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader

            Dim i As Integer = 0
            Do While reader.Read
                lbl_student_id.Text = reader!TeacherID
                lbl_student_name.Text = reader!Name_teacher
                lbl_address.Text = reader!address
                lbl_date.Text = reader!date_of_birth
                lbl_phone_number.Text = reader!phone_number

                txt_photo.Text = reader!image.ToString
                Dim img() As Byte
                img = reader!image
                Dim ms As New MemoryStream(img)
                picture.Image = Image.FromStream(ms)
                picture_view.Image = Image.FromStream(ms)
                lbl_picture.Visible = False
                Label23.Visible = False

                txt_student_id.Text = reader!TeacherID
                txt_student_name.Text = reader!Name_teacher
                txt_address.Text = reader!address
                txt_date.Text = reader!date_of_birth
                txt_phone_number.Text = reader!phone_number
            Loop
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub lbl_address_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form_edit_profil_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If lbl_view_id.Text = "Admin ID" Then
            Form_admin.Visible = True
        End If
        If lbl_edit_id.Text = "Teacher ID" Then
            form_teacher.Visible = True
        End If
        If lbl_edit_id.Text = "Student ID" Then
            Form_student.Visible = True
        End If
    End Sub

    Private Sub Form_edit_profil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Form_edit_profil_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampildata()
        button_awal()
        akses_teks(False)
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        akses_teks(True)
        btn_edit.Enabled = False
        btn_save.Enabled = True
        btn_cancel.Enabled = True
        btn_close.Enabled = False
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        tampildata()
        button_awal()
        akses_teks(False)
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        konek_db()
        If txt_student_id.Text <> "" Or txt_student_name.Text <> "" Or txt_phone_number.Text <> "" Or txt_address.Text <> "" Then
            If lbl_view_id.Text = "Admin ID" Then


                Dim ms As New MemoryStream
                picture.Image.Save(ms, picture.Image.RawFormat)

                Dim save As New SqlClient.SqlCommand("Update Admin set Name_admin = '" & txt_student_name.Text & "', address = '" & txt_address.Text &
                                                      "' , date_of_birth='" & Format(txt_date.Value, "yyyy-MM-dd") & "' , phone_number ='" & txt_phone_number.Text &
                                                      "', image = @image where admin_id = '" & txt_student_id.Text & "'")
                save.Connection = koneksi
                save.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray()
                Try
                    save.ExecuteNonQuery()
                    MsgBox("Data Berhasil di rubah", MsgBoxStyle.Information)
                    button_awal()
                    akses_teks(False)
                    Form_admin.lbl_nama.Text = txt_student_name.Text
                    tampildata()
                Catch ex As Exception
                    MsgBox("Data gagal di rubah karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            If lbl_view_id.Text = "Student ID" Then
                Dim ms As New MemoryStream
                picture.Image.Save(ms, picture.Image.RawFormat)
                Dim save As New SqlClient.SqlCommand("Update Student set Name_student = '" & txt_student_name.Text & "', address = '" & txt_address.Text &
                                                      "' , DateofBirth='" & Format(txt_date.Value, "yyyy-MM-dd") & "' , NoHp ='" & txt_phone_number.Text &
                                                      "', image=@image where StudentID = '" & txt_student_id.Text & "'")
                save.Connection = koneksi
                save.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray

                Try
                    save.ExecuteNonQuery()
                    MsgBox("Data Berhasil di rubah", MsgBoxStyle.Information)
                    button_awal()
                    akses_teks(False)
                    Form_student.lbl_nama.Text = txt_student_name.Text
                    tampildata()
                Catch ex As Exception
                    MsgBox("Data gagal di rubah karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            If lbl_view_id.Text = "Teacher ID" Then
                Dim ms As New MemoryStream
                picture.Image.Save(ms, picture.Image.RawFormat)
                Dim save As New SqlClient.SqlCommand("Update Teacher set Name_teacher = '" & txt_student_name.Text & "', address = '" & txt_address.Text &
                                                      "' , date_of_birth='" & Format(txt_date.Value, "yyyy-MM-dd") & "' , phone_number ='" & txt_phone_number.Text &
                                                      "',image = @image where TeacherID = '" & txt_student_id.Text & "'")
                save.Connection = koneksi
                save.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    save.ExecuteNonQuery()
                    MsgBox("Data Berhasil di rubah", MsgBoxStyle.Information)
                    button_awal()
                    akses_teks(False)
                    form_teacher.lbl_nama.Text = txt_student_name.Text
                    tampildata()
                Catch ex As Exception
                    MsgBox("Data gagal di rubah karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari.Click
        open_photo.Filter = "Jpeg|*.JPG|Bitmap| *.Bim|Gif| *.GIF"
        open_photo.RestoreDirectory = True
        open_photo.ShowDialog()

        If open_photo.FileName = "" Then Exit Sub
        picture.ImageLocation = open_photo.FileName
        txt_photo.Text = open_photo.FileName
        lbl_picture.Text = ""
    End Sub

    Private Sub txt_photo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_photo.TextChanged
        If txt_photo.Text = "" Then
            picture.ImageLocation = ""
        End If
    End Sub

    Private Sub picture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picture.Click

    End Sub
End Class