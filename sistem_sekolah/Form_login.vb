Public Class Form_login

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from login where  username='" & txt_username.Text & "' and password = '" & txt_password.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader

        reader = tampil.ExecuteReader()
        reader.Read()
        Try
            Dim level As String
            level = reader!role

            If level = "Admin" Then
                konek_db()
                Dim tampil_admin As New SqlClient.SqlCommand("select * from v_admin where username='" & txt_username.Text & "' and password = '" & txt_password.Text & "'", koneksi)
                Dim reader_admin As SqlClient.SqlDataReader
                reader_admin = tampil_admin.ExecuteReader
                reader_admin.Read()
                Form_admin.lbl_nama.Text = reader_admin!Name_admin
                Form_admin.Show()
            End If

            If level = "Teacher" Then
                konek_db()
                Dim tampil_admin As New SqlClient.SqlCommand("select * from v_teacher where username='" & txt_username.Text & "' and password = '" & txt_password.Text & "'", koneksi)
                Dim reader_admin As SqlClient.SqlDataReader
                reader_admin = tampil_admin.ExecuteReader
                reader_admin.Read()
                form_teacher.lbl_nama.Text = reader_admin!Name_teacher
                form_teacher.lbl_class.Text = reader_admin!Name_subject
                form_teacher.Show()
            End If
            If level = "Student" Then
                konek_db()
                Dim tampil_admin As New SqlClient.SqlCommand("select * from v_student where username='" & txt_username.Text & "' and password = '" & txt_password.Text & "'", koneksi)
                Dim reader_admin As SqlClient.SqlDataReader
                reader_admin = tampil_admin.ExecuteReader
                reader_admin.Read()
                Form_student.lbl_nama.Text = reader_admin!Name_student
                Form_student.lbl_class.Text = reader_admin!Name_class
                Form_student.Show()
            End If
            Me.Visible = False
        Catch ex As Exception
            MsgBox("Username dan password tidak valid, silahkan di ulang kembali", MsgBoxStyle.Critical)
            End Try

      

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Form_login_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

    End Sub

    Private Sub txt_username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_username_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_username.TextChanged

    End Sub
End Class
