<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customers))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Textname1 = New System.Windows.Forms.TextBox()
        Me.Textadd = New System.Windows.Forms.TextBox()
        Me.Textcsh = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textname2 = New System.Windows.Forms.TextBox()
        Me.Labelph = New System.Windows.Forms.Label()
        Me.Textphone = New System.Windows.Forms.TextBox()
        Me.textid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Butadd = New System.Windows.Forms.Button()
        Me.Buttupdate = New System.Windows.Forms.Button()
        Me.Buttdel = New System.Windows.Forms.Button()
        Me.Butsave = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "first_name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address"
        '
        'Textname1
        '
        Me.Textname1.Location = New System.Drawing.Point(201, 28)
        Me.Textname1.Name = "Textname1"
        Me.Textname1.Size = New System.Drawing.Size(270, 20)
        Me.Textname1.TabIndex = 5
        '
        'Textadd
        '
        Me.Textadd.Location = New System.Drawing.Point(201, 183)
        Me.Textadd.Name = "Textadd"
        Me.Textadd.Size = New System.Drawing.Size(270, 20)
        Me.Textadd.TabIndex = 7
        '
        'Textcsh
        '
        Me.Textcsh.Location = New System.Drawing.Point(322, 264)
        Me.Textcsh.Name = "Textcsh"
        Me.Textcsh.Size = New System.Drawing.Size(366, 20)
        Me.Textcsh.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(322, 290)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(366, 143)
        Me.DataGridView1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(317, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "search for customer"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.White
        Me.ImageList1.Images.SetKeyName(0, "images (10).jpg")
        Me.ImageList1.Images.SetKeyName(1, "images (8).jpg")
        Me.ImageList1.Images.SetKeyName(2, "images (8).jpg")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 27)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "last_name"
        '
        'Textname2
        '
        Me.Textname2.Location = New System.Drawing.Point(201, 72)
        Me.Textname2.Name = "Textname2"
        Me.Textname2.Size = New System.Drawing.Size(270, 20)
        Me.Textname2.TabIndex = 20
        '
        'Labelph
        '
        Me.Labelph.AutoSize = True
        Me.Labelph.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelph.Location = New System.Drawing.Point(35, 138)
        Me.Labelph.Name = "Labelph"
        Me.Labelph.Size = New System.Drawing.Size(75, 27)
        Me.Labelph.TabIndex = 21
        Me.Labelph.Text = "phone"
        '
        'Textphone
        '
        Me.Textphone.Location = New System.Drawing.Point(201, 145)
        Me.Textphone.Name = "Textphone"
        Me.Textphone.Size = New System.Drawing.Size(270, 20)
        Me.Textphone.TabIndex = 22
        '
        'textid
        '
        Me.textid.Enabled = False
        Me.textid.Location = New System.Drawing.Point(201, 109)
        Me.textid.Name = "textid"
        Me.textid.Size = New System.Drawing.Size(270, 20)
        Me.textid.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 27)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "number_client"
        '
        'Butadd
        '
        Me.Butadd.BackColor = System.Drawing.Color.SteelBlue
        Me.Butadd.BackgroundImage = Global.WindowsApplicationlast.My.Resources.Resources.add
        Me.Butadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Butadd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Butadd.FlatAppearance.BorderSize = 8
        Me.Butadd.Location = New System.Drawing.Point(558, 468)
        Me.Butadd.Name = "Butadd"
        Me.Butadd.Size = New System.Drawing.Size(107, 65)
        Me.Butadd.TabIndex = 18
        Me.Butadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Butadd.UseVisualStyleBackColor = False
        Me.Butadd.UseWaitCursor = True
        '
        'Buttupdate
        '
        Me.Buttupdate.BackColor = System.Drawing.Color.SteelBlue
        Me.Buttupdate.BackgroundImage = Global.WindowsApplicationlast.My.Resources.Resources.update_button_png_md
        Me.Buttupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttupdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Buttupdate.FlatAppearance.BorderSize = 8
        Me.Buttupdate.Location = New System.Drawing.Point(311, 468)
        Me.Buttupdate.Name = "Buttupdate"
        Me.Buttupdate.Size = New System.Drawing.Size(107, 65)
        Me.Buttupdate.TabIndex = 17
        Me.Buttupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Buttupdate.UseVisualStyleBackColor = False
        Me.Buttupdate.UseWaitCursor = True
        '
        'Buttdel
        '
        Me.Buttdel.BackColor = System.Drawing.Color.SteelBlue
        Me.Buttdel.BackgroundImage = Global.WindowsApplicationlast.My.Resources.Resources.de
        Me.Buttdel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttdel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Buttdel.FlatAppearance.BorderSize = 8
        Me.Buttdel.Location = New System.Drawing.Point(435, 468)
        Me.Buttdel.Name = "Buttdel"
        Me.Buttdel.Size = New System.Drawing.Size(107, 65)
        Me.Buttdel.TabIndex = 16
        Me.Buttdel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Buttdel.UseVisualStyleBackColor = False
        Me.Buttdel.UseWaitCursor = True
        '
        'Butsave
        '
        Me.Butsave.BackColor = System.Drawing.Color.SteelBlue
        Me.Butsave.BackgroundImage = Global.WindowsApplicationlast.My.Resources.Resources.sa
        Me.Butsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Butsave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Butsave.FlatAppearance.BorderSize = 8
        Me.Butsave.Location = New System.Drawing.Point(186, 469)
        Me.Butsave.Name = "Butsave"
        Me.Butsave.Size = New System.Drawing.Size(107, 65)
        Me.Butsave.TabIndex = 15
        Me.Butsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Butsave.UseVisualStyleBackColor = False
        Me.Butsave.UseWaitCursor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplicationlast.My.Resources.Resources.images__9_
        Me.PictureBox2.Location = New System.Drawing.Point(531, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(245, 182)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplicationlast.My.Resources.Resources.images__3_
        Me.PictureBox1.Location = New System.Drawing.Point(12, 227)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 224)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(16, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 103)
        Me.Button1.TabIndex = 25
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 8
        Me.Button2.Location = New System.Drawing.Point(682, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 65)
        Me.Button2.TabIndex = 26
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.UseWaitCursor = True
        '
        'customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(935, 700)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textid)
        Me.Controls.Add(Me.Textphone)
        Me.Controls.Add(Me.Labelph)
        Me.Controls.Add(Me.Textname2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Butadd)
        Me.Controls.Add(Me.Buttupdate)
        Me.Controls.Add(Me.Buttdel)
        Me.Controls.Add(Me.Butsave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Textcsh)
        Me.Controls.Add(Me.Textadd)
        Me.Controls.Add(Me.Textname1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "customers"
        Me.Text = "Amel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Textname1 As TextBox
    Friend WithEvents Textadd As TextBox
    Friend WithEvents Textcsh As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Butsave As Button
    Friend WithEvents Buttdel As Button
    Friend WithEvents Buttupdate As Button
    Friend WithEvents Butadd As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label2 As Label
    Friend WithEvents Textname2 As TextBox
    Friend WithEvents Labelph As Label
    Friend WithEvents Textphone As TextBox
    Friend WithEvents textid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
