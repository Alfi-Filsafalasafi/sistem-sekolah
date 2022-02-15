<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpt_schedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.v_schedule1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sekolahkuDataSet = New sistem_sekolah.sekolahkuDataSet()
        Me.v_schedule1TableAdapter = New sistem_sekolah.sekolahkuDataSetTableAdapters.v_schedule1TableAdapter()
        CType(Me.v_schedule1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sekolahkuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.v_schedule1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sistem_sekolah.Report_schedule.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(20, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1325, 437)
        Me.ReportViewer1.TabIndex = 0
        '
        'v_schedule1BindingSource
        '
        Me.v_schedule1BindingSource.DataMember = "v_schedule1"
        Me.v_schedule1BindingSource.DataSource = Me.sekolahkuDataSet
        '
        'sekolahkuDataSet
        '
        Me.sekolahkuDataSet.DataSetName = "sekolahkuDataSet"
        Me.sekolahkuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'v_schedule1TableAdapter
        '
        Me.v_schedule1TableAdapter.ClearBeforeFill = True
        '
        'rpt_schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 669)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rpt_schedule"
        Me.Text = "rpt_student"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.v_schedule1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sekolahkuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents v_schedule1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sekolahkuDataSet As sistem_sekolah.sekolahkuDataSet
    Friend WithEvents v_schedule1TableAdapter As sistem_sekolah.sekolahkuDataSetTableAdapters.v_schedule1TableAdapter
End Class
