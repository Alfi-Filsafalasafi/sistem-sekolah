Public Class form_Teaching_schedule
    Sub tampildata()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("Select * from v_schedule where Name_teacher = '" & form_teacher.lbl_nama.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read()
            lv_teaching.Items.Add(reader!SubjectID)
            lv_teaching.Items(i).SubItems.Add(reader!Name_subject)
            lv_teaching.Items(i).SubItems.Add(reader!Name_class)
            lv_teaching.Items(i).SubItems.Add("")

            lv_teaching.Items(i).SubItems.Add("")


            i = i + +1
        Loop

    End Sub

    Public Sub reset()
        lv_student.Items.Clear()
    End Sub

    Sub buttonawal()
        btn_view.Enabled = False
        lbl_subject.Text = ""
    End Sub
    Private Sub form_Teaching_schedule_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        form_teacher.Visible = True
    End Sub

    Private Sub form_Teaching_schedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view.Click
        Me.Visible = False
        form_info_subject.txt_user.Text = "2"
        form_info_subject.Show()
    End Sub

    Private Sub form_Teaching_schedule_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampildata()
        buttonawal()
    End Sub

    Private Sub lv_teaching_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_teaching.MouseClick
        reset()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_schedule where SubjectID='" & lv_teaching.SelectedItems(0).SubItems(0).Text & "' and Name_class = '" & lv_teaching.SelectedItems(0).SubItems(2).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_student.Items.Add(reader!StudentID)
            lv_student.Items(i).SubItems.Add(reader!Name_student)
            lv_student.Items(i).SubItems.Add(reader!Gender)
            lbl_subject.Text = reader!Name_Subject

            i = i + +1
        Loop
        btn_view.Enabled = True
    End Sub

    Private Sub lv_teaching_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_teaching.SelectedIndexChanged

    End Sub
End Class