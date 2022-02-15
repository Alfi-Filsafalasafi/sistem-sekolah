<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_edit_profil
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
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.txt_photo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_address = New System.Windows.Forms.RichTextBox()
        Me.txt_phone_number = New System.Windows.Forms.TextBox()
        Me.txt_student_name = New System.Windows.Forms.TextBox()
        Me.txt_student_id = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_edit_name = New System.Windows.Forms.Label()
        Me.lbl_edit_id = New System.Windows.Forms.Label()
        Me.lbl_picture = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picture = New System.Windows.Forms.PictureBox()
        Me.picture_view = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_view_name = New System.Windows.Forms.Label()
        Me.lbl_view_id = New System.Windows.Forms.Label()
        Me.lbl_student_id = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_student_name = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_phone_number = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.open_photo = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 83)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1362, 83)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MY PROFILE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.btn_cari)
        Me.Panel2.Controls.Add(Me.txt_photo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_date)
        Me.Panel2.Controls.Add(Me.txt_address)
        Me.Panel2.Controls.Add(Me.txt_phone_number)
        Me.Panel2.Controls.Add(Me.txt_student_name)
        Me.Panel2.Controls.Add(Me.txt_student_id)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Controls.Add(Me.btn_edit)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lbl_edit_name)
        Me.Panel2.Controls.Add(Me.lbl_edit_id)
        Me.Panel2.Controls.Add(Me.lbl_picture)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.picture)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 658)
        Me.Panel2.TabIndex = 1
        '
        'btn_cari
        '
        Me.btn_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari.Location = New System.Drawing.Point(220, 81)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(85, 32)
        Me.btn_cari.TabIndex = 10
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'txt_photo
        '
        Me.txt_photo.Enabled = False
        Me.txt_photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_photo.Location = New System.Drawing.Point(171, 49)
        Me.txt_photo.Name = "txt_photo"
        Me.txt_photo.Size = New System.Drawing.Size(134, 26)
        Me.txt_photo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Student ID"
        '
        'txt_date
        '
        Me.txt_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date.Location = New System.Drawing.Point(167, 487)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(125, 26)
        Me.txt_date.TabIndex = 3
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(167, 349)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(295, 117)
        Me.txt_address.TabIndex = 2
        Me.txt_address.Text = ""
        '
        'txt_phone_number
        '
        Me.txt_phone_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone_number.Location = New System.Drawing.Point(167, 534)
        Me.txt_phone_number.Name = "txt_phone_number"
        Me.txt_phone_number.Size = New System.Drawing.Size(294, 26)
        Me.txt_phone_number.TabIndex = 4
        '
        'txt_student_name
        '
        Me.txt_student_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_student_name.Location = New System.Drawing.Point(168, 305)
        Me.txt_student_name.Name = "txt_student_name"
        Me.txt_student_name.Size = New System.Drawing.Size(294, 26)
        Me.txt_student_name.TabIndex = 1
        '
        'txt_student_id
        '
        Me.txt_student_id.Enabled = False
        Me.txt_student_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_student_id.Location = New System.Drawing.Point(168, 264)
        Me.txt_student_id.Name = "txt_student_id"
        Me.txt_student_id.Size = New System.Drawing.Size(294, 26)
        Me.txt_student_id.TabIndex = 0
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(275, 581)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(85, 32)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(377, 581)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 32)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(171, 581)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(85, 32)
        Me.btn_edit.TabIndex = 5
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Red
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(36, 537)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Phone Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(36, 483)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(36, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address"
        '
        'lbl_edit_name
        '
        Me.lbl_edit_name.AutoSize = True
        Me.lbl_edit_name.BackColor = System.Drawing.Color.Red
        Me.lbl_edit_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edit_name.ForeColor = System.Drawing.Color.White
        Me.lbl_edit_name.Location = New System.Drawing.Point(36, 308)
        Me.lbl_edit_name.Name = "lbl_edit_name"
        Me.lbl_edit_name.Size = New System.Drawing.Size(112, 20)
        Me.lbl_edit_name.TabIndex = 4
        Me.lbl_edit_name.Text = "Student Name"
        '
        'lbl_edit_id
        '
        Me.lbl_edit_id.AutoSize = True
        Me.lbl_edit_id.BackColor = System.Drawing.Color.Red
        Me.lbl_edit_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edit_id.ForeColor = System.Drawing.Color.White
        Me.lbl_edit_id.Location = New System.Drawing.Point(36, 267)
        Me.lbl_edit_id.Name = "lbl_edit_id"
        Me.lbl_edit_id.Size = New System.Drawing.Size(87, 20)
        Me.lbl_edit_id.TabIndex = 3
        Me.lbl_edit_id.Text = "Student ID"
        '
        'lbl_picture
        '
        Me.lbl_picture.AutoSize = True
        Me.lbl_picture.BackColor = System.Drawing.Color.Silver
        Me.lbl_picture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_picture.Location = New System.Drawing.Point(345, 126)
        Me.lbl_picture.Name = "lbl_picture"
        Me.lbl_picture.Size = New System.Drawing.Size(95, 20)
        Me.lbl_picture.TabIndex = 2
        Me.lbl_picture.Text = "Picture 3 x 4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(204, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Edit Profil"
        '
        'picture
        '
        Me.picture.BackColor = System.Drawing.Color.DarkGray
        Me.picture.Location = New System.Drawing.Point(324, 49)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(137, 183)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture.TabIndex = 47
        Me.picture.TabStop = False
        '
        'picture_view
        '
        Me.picture_view.BackColor = System.Drawing.Color.DarkGray
        Me.picture_view.Location = New System.Drawing.Point(571, 216)
        Me.picture_view.Name = "picture_view"
        Me.picture_view.Size = New System.Drawing.Size(300, 400)
        Me.picture_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture_view.TabIndex = 3
        Me.picture_view.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(901, 529)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Phone Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightGray
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(901, 475)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Date of Birth"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightGray
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(901, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 25)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Address"
        '
        'lbl_view_name
        '
        Me.lbl_view_name.AutoSize = True
        Me.lbl_view_name.BackColor = System.Drawing.Color.LightGray
        Me.lbl_view_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_view_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_view_name.Location = New System.Drawing.Point(901, 262)
        Me.lbl_view_name.Name = "lbl_view_name"
        Me.lbl_view_name.Size = New System.Drawing.Size(148, 25)
        Me.lbl_view_name.TabIndex = 17
        Me.lbl_view_name.Text = "Student Name"
        '
        'lbl_view_id
        '
        Me.lbl_view_id.AutoSize = True
        Me.lbl_view_id.BackColor = System.Drawing.Color.LightGray
        Me.lbl_view_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_view_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_view_id.Location = New System.Drawing.Point(901, 216)
        Me.lbl_view_id.Name = "lbl_view_id"
        Me.lbl_view_id.Size = New System.Drawing.Size(112, 25)
        Me.lbl_view_id.TabIndex = 16
        Me.lbl_view_id.Text = "Student ID"
        '
        'lbl_student_id
        '
        Me.lbl_student_id.AutoSize = True
        Me.lbl_student_id.BackColor = System.Drawing.Color.LightGray
        Me.lbl_student_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_student_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_student_id.Location = New System.Drawing.Point(1105, 216)
        Me.lbl_student_id.Name = "lbl_student_id"
        Me.lbl_student_id.Size = New System.Drawing.Size(19, 25)
        Me.lbl_student_id.TabIndex = 21
        Me.lbl_student_id.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.LightGray
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(1076, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 25)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "="
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.LightGray
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(1076, 475)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 25)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "="
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.LightGray
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(1076, 262)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 25)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "="
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.LightGray
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(1076, 315)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 25)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "="
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.LightGray
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(1076, 529)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 25)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "="
        '
        'lbl_student_name
        '
        Me.lbl_student_name.AutoSize = True
        Me.lbl_student_name.BackColor = System.Drawing.Color.LightGray
        Me.lbl_student_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_student_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_student_name.Location = New System.Drawing.Point(1106, 262)
        Me.lbl_student_name.Name = "lbl_student_name"
        Me.lbl_student_name.Size = New System.Drawing.Size(19, 25)
        Me.lbl_student_name.TabIndex = 28
        Me.lbl_student_name.Text = "-"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.LightGray
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Black
        Me.lbl_date.Location = New System.Drawing.Point(1106, 475)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(19, 25)
        Me.lbl_date.TabIndex = 29
        Me.lbl_date.Text = "-"
        '
        'lbl_phone_number
        '
        Me.lbl_phone_number.AutoSize = True
        Me.lbl_phone_number.BackColor = System.Drawing.Color.LightGray
        Me.lbl_phone_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone_number.ForeColor = System.Drawing.Color.Black
        Me.lbl_phone_number.Location = New System.Drawing.Point(1105, 529)
        Me.lbl_phone_number.Name = "lbl_phone_number"
        Me.lbl_phone_number.Size = New System.Drawing.Size(19, 25)
        Me.lbl_phone_number.TabIndex = 30
        Me.lbl_phone_number.Text = "-"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.DarkGray
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(652, 399)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(132, 25)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "Picture 3 x 4"
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(1232, 572)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(85, 32)
        Me.btn_close.TabIndex = 8
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'lbl_address
        '
        Me.lbl_address.BackColor = System.Drawing.Color.LightGray
        Me.lbl_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.Black
        Me.lbl_address.Location = New System.Drawing.Point(1105, 315)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(253, 135)
        Me.lbl_address.TabIndex = 31
        Me.lbl_address.Text = "-"
        '
        'Form_edit_profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lbl_phone_number)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_student_name)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lbl_student_id)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.picture_view)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_view_name)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_view_id)
        Me.Name = "Form_edit_profil"
        Me.Text = "Form_edit_student"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picture_view As System.Windows.Forms.PictureBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_edit_name As System.Windows.Forms.Label
    Friend WithEvents lbl_edit_id As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_phone_number As System.Windows.Forms.TextBox
    Friend WithEvents txt_student_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_student_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_view_name As System.Windows.Forms.Label
    Friend WithEvents lbl_view_id As System.Windows.Forms.Label
    Friend WithEvents lbl_student_id As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbl_student_name As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_phone_number As System.Windows.Forms.Label
    Friend WithEvents lbl_picture As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents btn_cari As System.Windows.Forms.Button
    Friend WithEvents txt_photo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents open_photo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents picture As System.Windows.Forms.PictureBox
End Class
