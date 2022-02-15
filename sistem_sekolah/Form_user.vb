Public Class Form_user
    Dim aksi As String
    Sub reset()
        lv_user.Items.Clear()
    End Sub
    Sub bersihteks()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_password.Text = ""
        txt_role.Text = ""
        txt_username.Text = ""
        txt_select.Text = ""
    End Sub
    Sub buttonawal()
        btn_add.Enabled = True
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False
        btn_select.Enabled = False
        lv_user.Enabled = True
    End Sub
    Sub aksesteks(ByVal akses As Boolean)
        txt_id.Enabled = akses
        txt_name.Enabled = akses
        txt_username.Enabled = akses
        txt_role.Enabled = akses
        txt_password.Enabled = akses
    End Sub

    Sub tampildata()
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from login", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_user.Items.Add(reader!user_id)
            lv_user.Items(i).SubItems.Add(reader!Username)
            lv_user.Items(i).SubItems.Add(reader!Name_lengkap)
            lv_user.Items(i).SubItems.Add(reader!role)

            i = i + +1
        Loop
    End Sub

    Private Sub txt_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_id.TextChanged

    End Sub

    Private Sub Form_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_user_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        aksesteks(False)
        buttonawal()
        bersihteks()
        tampildata()
    End Sub

    Private Sub lv_user_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_user.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from login where user_id = '" & lv_user.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id.Text = reader!user_id
            txt_username.Text = reader!username
            txt_role.Text = reader!role
            txt_password.Text = reader!password
            txt_name.Text = reader!Name_lengkap
            txt_select.Text = reader!user_id
        Loop

        btn_add.Enabled = False
        btn_edit.Enabled = True
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_cancel.Enabled = True
        btn_select.Enabled = True
    End Sub

    Private Sub lv_user_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_user.SelectedIndexChanged

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        aksi = "T"
        aksesteks(True)

        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        btn_delete.Enabled = False
        btn_cancel.Enabled = True
        lv_user.Enabled = False
        btn_select.Enabled = False
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        aksesteks(False)
        buttonawal()
        bersihteks()

    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        aksi = "U"
        aksesteks(True)

        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        btn_delete.Enabled = False
        btn_cancel.Enabled = True
        lv_user.Enabled = False
        btn_select.Enabled = False
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_id.Text <> "" And txt_name.Text <> "" And txt_password.Text <> "" And txt_username.Text <> "" And txt_role.Text <> "" Then
            If aksi = "T" Then
                konek_db()
                Dim save As New SqlClient.SqlCommand("Insert Into login values ( '" & txt_username.Text & "', '" & txt_password.Text &
                                                     "','" & txt_role.Text & "','" & txt_name.Text & "')", koneksi)
                Try
                    save.ExecuteNonQuery()
                    MsgBox("Data berhasil di simpan", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Data Gagal di simpan karena " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            If aksi = "U" Then
                konek_db()
                Dim update As New SqlClient.SqlCommand("update login set username = '" & txt_username.Text &
                                                       "', password = '" & txt_password.Text & "', role ='" & txt_role.Text &
                                                       "', Name_lengkap = '" & txt_name.Text & "' where user_id = '" & txt_id.Text & "' ", koneksi)
                Try
                    update.ExecuteNonQuery()
                    MsgBox("Data berhasil di ubah", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Data gagal di simpan karena " + ex.Message, MsgBoxStyle.Critical)
                End Try

            End If
            tampildata()
            bersihteks()
            buttonawal()
            aksesteks(False)

        Else
            MsgBox("Mohon data dilengkapi dulu", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        konek_db()
        Dim delete As New SqlClient.SqlCommand("delete from login where user_id = '" & txt_id.Text & "'", koneksi)
        Try
            delete.ExecuteNonQuery()
            MsgBox("Data berhasil di simpan", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Data gagal di hapus karena " + ex.Message, MsgBoxStyle.Critical)
        End Try

        tampildata()
        buttonawal()
        bersihteks()
    End Sub

    Private Sub btn_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_select.Click
        If form_manage_student.Visible = True Then
            form_manage_student.txt_id_user.Text = txt_select.Text
        End If
        If Form_manage_teacher.Visible = True Then
            Form_manage_teacher.txt_id_user.Text = txt_select.Text
        End If

        Me.Close()
    End Sub

    Private Sub txt_select_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_select.TextChanged

    End Sub

    Private Sub txt_cari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cari.TextChanged
        reset()
        If txt_cari.Text = "" Then
            tampildata()
        End If
        If txt_cari.Text <> "" Then
            konek_db()
            Dim cari As New SqlClient.SqlCommand("select * from login where Username LIKE'%" & txt_cari.Text & "%'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = cari.ExecuteReader
            Dim i As Integer = 0
            Do While reader.Read
                lv_user.Items.Add(reader!user_id)
                lv_user.Items(i).SubItems.Add(reader!Username)
                lv_user.Items(i).SubItems.Add(reader!Name_lengkap)
                lv_user.Items(i).SubItems.Add(reader!role)

                i = i + +1
            Loop
        End If
    End Sub
End Class