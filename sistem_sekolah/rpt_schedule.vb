Public Class rpt_schedule

    Private Sub rpt_student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.v_schedule1TableAdapter.Fill(Me.sekolahkuDataSet.v_schedule1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class