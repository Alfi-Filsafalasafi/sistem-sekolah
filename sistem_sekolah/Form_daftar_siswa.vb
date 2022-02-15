Imports System.IO
Public Class Form_daftar_siswa

    Private Sub Form_daftar_siswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek_db()
        Dim data_tbl As DataTable

        Dim tampil As New SqlClient.SqlCommand("select * from teacher", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            'Dim newitem As New ListViewItem()

            Dim imageListLarge As New ImageList()
            'newitem.Text = reader!Name_Teacher
            'newitem.SubItems.Add(reader.GetValue(1))
            Dim img() As Byte
            img = reader!image
            Dim ms As New MemoryStream(img)
            imageListLarge.Images.Add(Bitmap.FromStream(ms))

            ListView1.Items.Add(reader!Name_Teacher)
            ListView1.Items(i).SubItems.Add(reader!Gender)


            i = i + +1

        Loop
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class