<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_view_schedule
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lv_schedule = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_view = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_class = New System.Windows.Forms.Label()
        Me.lbl_subject = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 91)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Clarendon Blk BT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1370, 91)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VIEW SCHEDULE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lv_schedule
        '
        Me.lv_schedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lv_schedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lv_schedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_schedule.FullRowSelect = True
        Me.lv_schedule.GridLines = True
        Me.lv_schedule.Location = New System.Drawing.Point(45, 152)
        Me.lv_schedule.Name = "lv_schedule"
        Me.lv_schedule.Size = New System.Drawing.Size(1285, 580)
        Me.lv_schedule.TabIndex = 1
        Me.lv_schedule.UseCompatibleStateImageBehavior = False
        Me.lv_schedule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Subject ID"
        Me.ColumnHeader1.Width = 164
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Subject "
        Me.ColumnHeader2.Width = 358
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Class Name"
        Me.ColumnHeader3.Width = 240
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Day"
        Me.ColumnHeader4.Width = 142
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Time"
        Me.ColumnHeader5.Width = 153
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Teacher Name"
        Me.ColumnHeader6.Width = 223
        '
        'btn_view
        '
        Me.btn_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view.Location = New System.Drawing.Point(1179, 106)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(146, 38)
        Me.btn_view.TabIndex = 2
        Me.btn_view.Text = "View Subject Info"
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CLASS :"
        '
        'lbl_class
        '
        Me.lbl_class.AutoSize = True
        Me.lbl_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_class.Location = New System.Drawing.Point(120, 120)
        Me.lbl_class.Name = "lbl_class"
        Me.lbl_class.Size = New System.Drawing.Size(70, 20)
        Me.lbl_class.TabIndex = 4
        Me.lbl_class.Text = "CLASS :"
        '
        'lbl_subject
        '
        Me.lbl_subject.AutoSize = True
        Me.lbl_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subject.Location = New System.Drawing.Point(547, 120)
        Me.lbl_subject.Name = "lbl_subject"
        Me.lbl_subject.Size = New System.Drawing.Size(14, 20)
        Me.lbl_subject.TabIndex = 6
        Me.lbl_subject.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(444, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "SUBJECT :"
        '
        'Form_view_schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.lbl_subject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_class)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.lv_schedule)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_view_schedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_view_schedule"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lv_schedule As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_view As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_class As System.Windows.Forms.Label
    Friend WithEvents lbl_subject As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
