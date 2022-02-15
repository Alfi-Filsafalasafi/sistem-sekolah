Public Class Form_view_schedule

    Sub button_awal()
        btn_view.Enabled = False
        lbl_subject.Text = "-"
    End Sub

    Sub tampildata()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("Select * from v_schedule where Name_student = '" & Form_student.lbl_nama.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read()
            lv_schedule.Items.Add(reader!SubjectID)
            lv_schedule.Items(i).SubItems.Add(reader!Name_subject)
            lv_schedule.Items(i).SubItems.Add("")
            lv_schedule.Items(i).SubItems.Add("")
            lv_schedule.Items(i).SubItems.Add("")
            lv_schedule.Items(i).SubItems.Add(reader!Name_teacher)
            lbl_class.Text = Form_student.lbl_class.Text

            i = i + +1
        Loop

    End Sub
    Private Sub Form_view_schedule_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form_student.Visible = True
    End Sub

    Private Sub Form_view_schedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view.Click
        Me.Visible = False
        form_info_subject.Show()
        form_info_subject.txt_user.Text = "3"
    End Sub

    Private Sub Form_view_schedule_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampildata()
        button_awal()
    End Sub

    Private Sub lv_schedule_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_schedule.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_schedule where SubjectID = '" & lv_schedule.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_subject.Text = reader!Name_subject
        Loop
        btn_view.Enabled = True
    End Sub

    Private Sub lv_schedule_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_schedule.SelectedIndexChanged
        
    End Sub
End Class