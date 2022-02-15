<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_user
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_select = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_role = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lv_user = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 71)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Clarendon Blk BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(875, 71)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATA USER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.btn_select)
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Controls.Add(Me.btn_delete)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.btn_edit)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.txt_select)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_password)
        Me.Panel2.Controls.Add(Me.txt_username)
        Me.Panel2.Controls.Add(Me.txt_id)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txt_role)
        Me.Panel2.Controls.Add(Me.txt_name)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 458)
        Me.Panel2.TabIndex = 2
        '
        'btn_select
        '
        Me.btn_select.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select.Location = New System.Drawing.Point(286, 418)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(64, 33)
        Me.btn_select.TabIndex = 12
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(287, 279)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(64, 32)
        Me.btn_cancel.TabIndex = 10
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(217, 279)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(64, 32)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(147, 279)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(64, 32)
        Me.btn_save.TabIndex = 8
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(77, 279)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(64, 32)
        Me.btn_edit.TabIndex = 7
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(7, 279)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(64, 32)
        Me.btn_add.TabIndex = 6
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_select
        '
        Me.txt_select.Enabled = False
        Me.txt_select.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_select.Location = New System.Drawing.Point(217, 420)
        Me.txt_select.Name = "txt_select"
        Me.txt_select.Size = New System.Drawing.Size(61, 29)
        Me.txt_select.TabIndex = 13
        Me.txt_select.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(97, 425)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Select ID User"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(127, 134)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(212, 26)
        Me.txt_password.TabIndex = 3
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(127, 85)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(212, 26)
        Me.txt_username.TabIndex = 2
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(127, 38)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(212, 26)
        Me.txt_id.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(4, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Role"
        '
        'txt_role
        '
        Me.txt_role.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_role.Location = New System.Drawing.Point(127, 231)
        Me.txt_role.Name = "txt_role"
        Me.txt_role.Size = New System.Drawing.Size(212, 26)
        Me.txt_role.TabIndex = 5
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(127, 185)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(212, 26)
        Me.txt_name.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Name Lengkap"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "User ID"
        '
        'lv_user
        '
        Me.lv_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lv_user.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lv_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_user.FullRowSelect = True
        Me.lv_user.GridLines = True
        Me.lv_user.Location = New System.Drawing.Point(371, 109)
        Me.lv_user.Name = "lv_user"
        Me.lv_user.Size = New System.Drawing.Size(492, 410)
        Me.lv_user.TabIndex = 11
        Me.lv_user.UseCompatibleStateImageBehavior = False
        Me.lv_user.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "User ID"
        Me.ColumnHeader5.Width = 79
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Username"
        Me.ColumnHeader6.Width = 127
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Name Lengkap"
        Me.ColumnHeader7.Width = 165
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Role"
        Me.ColumnHeader8.Width = 117
        '
        'txt_cari
        '
        Me.txt_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari.Location = New System.Drawing.Point(495, 77)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(212, 26)
        Me.txt_cari.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(372, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Cari User"
        '
        'Form_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 529)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lv_user)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_user"
        Me.Text = "Form_user"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lv_user As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_role As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents txt_select As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_select As System.Windows.Forms.Button
    Friend WithEvents txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
