Imports System.Data.SqlClient
Imports System.IO

Module Module1
    Public koneksi As SqlConnection = Nothing
    Public Sub konek_db()
        Dim server As String
        server = "server=DESKTOP-H62RT00\SERVERKU;database=sekolahku;integrated security = true"
        koneksi = New SqlConnection(server)
        koneksi.Open()
    End Sub
End Module