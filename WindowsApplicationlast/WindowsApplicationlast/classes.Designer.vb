Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient



<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class classes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Texts = New System.Windows.Forms.TextBox()
        Me.Textbarcode = New System.Windows.Forms.TextBox()
        Me.Textcost = New System.Windows.Forms.TextBox()
        Me.Textsails = New System.Windows.Forms.TextBox()
        Me.Textnoteanddate = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.Butinsert = New System.Windows.Forms.Button()
        Me.ComboARTICAL = New System.Windows.Forms.ComboBox()
        Me.Butupdate = New System.Windows.Forms.Button()
        Me.Butdelete = New System.Windows.Forms.Button()
        Me.Butsave = New System.Windows.Forms.Button()
        Me.Butback = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Textname
        '
        Me.Textname.Location = New System.Drawing.Point(114, 86)
        Me.Textname.Name = "Textname"
        Me.Textname.Size = New System.Drawing.Size(302, 20)
        Me.Textname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "artical"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "sailsingle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "sail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "cost"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Date "
        '
        'Texts
        '
        Me.Texts.Location = New System.Drawing.Point(114, 228)
        Me.Texts.Name = "Texts"
        Me.Texts.Size = New System.Drawing.Size(302, 20)
        Me.Texts.TabIndex = 9
        '
        'Textbarcode
        '
        Me.Textbarcode.Location = New System.Drawing.Point(114, 321)
        Me.Textbarcode.Name = "Textbarcode"
        Me.Textbarcode.Size = New System.Drawing.Size(302, 20)
        Me.Textbarcode.TabIndex = 10
        '
        'Textcost
        '
        Me.Textcost.Location = New System.Drawing.Point(114, 275)
        Me.Textcost.Name = "Textcost"
        Me.Textcost.Size = New System.Drawing.Size(302, 20)
        Me.Textcost.TabIndex = 11
        '
        'Textsails
        '
        Me.Textsails.Location = New System.Drawing.Point(114, 182)
        Me.Textsails.Name = "Textsails"
        Me.Textsails.Size = New System.Drawing.Size(302, 20)
        Me.Textsails.TabIndex = 12
        '
        'Textnoteanddate
        '
        Me.Textnoteanddate.Enabled = False
        Me.Textnoteanddate.Location = New System.Drawing.Point(114, 370)
        Me.Textnoteanddate.Name = "Textnoteanddate"
        Me.Textnoteanddate.Size = New System.Drawing.Size(302, 20)
        Me.Textnoteanddate.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(453, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 245)
        Me.DataGridView1.TabIndex = 15
        '
        'textsearch
        '
        Me.textsearch.BackColor = System.Drawing.SystemColors.HotTrack
        Me.textsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textsearch.Location = New System.Drawing.Point(453, 89)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(240, 13)
        Me.textsearch.TabIndex = 16
        '
        'Butinsert
        '
        Me.Butinsert.BackColor = System.Drawing.Color.Blue
        Me.Butinsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Butinsert.FlatAppearance.BorderSize = 3
        Me.Butinsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butinsert.ForeColor = System.Drawing.SystemColors.Window
        Me.Butinsert.Location = New System.Drawing.Point(12, 417)
        Me.Butinsert.Name = "Butinsert"
        Me.Butinsert.Size = New System.Drawing.Size(100, 51)
        Me.Butinsert.TabIndex = 17
        Me.Butinsert.Text = "insert"
        Me.Butinsert.UseVisualStyleBackColor = False
        '
        'ComboARTICAL
        '
        Me.ComboARTICAL.AllowDrop = True
        Me.ComboARTICAL.FormattingEnabled = True
        Me.ComboARTICAL.Items.AddRange(New Object() {"علبه", "كرتونه", "طرد ", "تزينه"})
        Me.ComboARTICAL.Location = New System.Drawing.Point(114, 136)
        Me.ComboARTICAL.Name = "ComboARTICAL"
        Me.ComboARTICAL.Size = New System.Drawing.Size(302, 21)
        Me.ComboARTICAL.TabIndex = 18
        '
        'Butupdate
        '
        Me.Butupdate.BackColor = System.Drawing.Color.Blue
        Me.Butupdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Butupdate.FlatAppearance.BorderSize = 3
        Me.Butupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butupdate.ForeColor = System.Drawing.SystemColors.Window
        Me.Butupdate.Location = New System.Drawing.Point(352, 417)
        Me.Butupdate.Name = "Butupdate"
        Me.Butupdate.Size = New System.Drawing.Size(100, 51)
        Me.Butupdate.TabIndex = 19
        Me.Butupdate.Text = "update"
        Me.Butupdate.UseVisualStyleBackColor = False
        '
        'Butdelete
        '
        Me.Butdelete.BackColor = System.Drawing.Color.Blue
        Me.Butdelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Butdelete.FlatAppearance.BorderSize = 3
        Me.Butdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butdelete.ForeColor = System.Drawing.SystemColors.Window
        Me.Butdelete.Location = New System.Drawing.Point(231, 417)
        Me.Butdelete.Name = "Butdelete"
        Me.Butdelete.Size = New System.Drawing.Size(100, 51)
        Me.Butdelete.TabIndex = 20
        Me.Butdelete.Text = "delete"
        Me.Butdelete.UseVisualStyleBackColor = False
        '
        'Butsave
        '
        Me.Butsave.BackColor = System.Drawing.Color.Blue
        Me.Butsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Butsave.FlatAppearance.BorderSize = 3
        Me.Butsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butsave.ForeColor = System.Drawing.SystemColors.Window
        Me.Butsave.Location = New System.Drawing.Point(118, 417)
        Me.Butsave.Name = "Butsave"
        Me.Butsave.Size = New System.Drawing.Size(100, 51)
        Me.Butsave.TabIndex = 21
        Me.Butsave.Text = "save"
        Me.Butsave.UseVisualStyleBackColor = False
        '
        'Butback
        '
        Me.Butback.BackColor = System.Drawing.Color.Blue
        Me.Butback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Butback.FlatAppearance.BorderSize = 3
        Me.Butback.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butback.ForeColor = System.Drawing.SystemColors.Window
        Me.Butback.Location = New System.Drawing.Point(593, 417)
        Me.Butback.Name = "Butback"
        Me.Butback.Size = New System.Drawing.Size(100, 51)
        Me.Butback.TabIndex = 22
        Me.Butback.Text = "back"
        Me.Butback.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 27)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "barcode"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(476, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 51)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(805, 533)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Butback)
        Me.Controls.Add(Me.Butsave)
        Me.Controls.Add(Me.Butdelete)
        Me.Controls.Add(Me.Butupdate)
        Me.Controls.Add(Me.ComboARTICAL)
        Me.Controls.Add(Me.Butinsert)
        Me.Controls.Add(Me.textsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Textnoteanddate)
        Me.Controls.Add(Me.Textsails)
        Me.Controls.Add(Me.Textcost)
        Me.Controls.Add(Me.Textbarcode)
        Me.Controls.Add(Me.Texts)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Textname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "classes"
        Me.Text = "classes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Textname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Texts As TextBox
    Friend WithEvents Textbarcode As TextBox
    Friend WithEvents Textcost As TextBox
    Friend WithEvents Textsails As TextBox
    Friend WithEvents Textnoteanddate As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents textsearch As TextBox
    Friend WithEvents Butinsert As Button
    Friend WithEvents ComboARTICAL As ComboBox
    Friend WithEvents Butupdate As Button
    Friend WithEvents Butdelete As Button
    Friend WithEvents Butsave As Button
    Friend WithEvents Butback As Button
    Public sqlselect As String = "Select * from itemes "
    Dim dt As Date = Date.Now()

    Private Sub classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen() ' تعني  أجعل النموزج في منتصف الشاشة

        ' conn.Open()
        Dim DataAdapter1 As New SqlDataAdapter(sqlselect, conn)
        DataAdapter1.Fill(DataSet1, "itemes")
        conn.Close()
        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = "itemes"
        DataGridView1.Refresh()
        ''''''''''''''''''''''''''''''''''''''''''''
        DataGridView1.Columns(0).Visible = True
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True
        DataGridView1.Columns(4).Visible = True
        DataGridView1.Columns(5).Visible = True
        DataGridView1.Columns(6).Visible = False

        DataGridView1.Columns(0).HeaderText = "Id_Item "
        DataGridView1.Columns(1).HeaderText = "Name_Item "
        DataGridView1.Columns(2).HeaderText = "Item_artical "
        DataGridView1.Columns(3).HeaderText = " SailSingle"
        DataGridView1.Columns(4).HeaderText = "sail "
        DataGridView1.Columns(5).HeaderText = " Note 
         "
        DataGridView1.Columns(6).HeaderText = "Cost_Item "

        DataGridView1.Columns(0).Width = 40
        DataGridView1.Columns(1).Width = 380
        DataGridView1.Columns(2).Width = 90
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 220
        DataGridView1.Columns(6).Width = 90

        Textname.DataBindings.Add("Text", DataSet1, "itemes.item_name")
        ComboARTICAL.DataBindings.Add("Text", DataSet1, "itemes.item_artical")
        Textsails.DataBindings.Add("Text", DataSet1, "itemes.sailSingle")
        Texts.DataBindings.Add("Text", DataSet1, "itemes.sail")


        Textcost.DataBindings.Add("Text", DataSet1, "itemes.cost")

        Textbarcode.DataBindings.Add("Text", DataSet1, "itemes.id")
        Textnoteanddate.DataBindings.Add("Text", DataSet1, "itemes.note")



    End Sub

    Private Sub Butsave_Click(sender As Object, e As EventArgs) Handles Butsave.Click

        Try
            If Trim(Textname.Text) <> "" And (Trim(ComboARTICAL.Text) <> "" Or Trim(Textsails.Text) <> "") Then
                Dim sqcomand As New SqlCommand
                sqcomand.Connection = conn
                sqcomand.CommandText = "INSERT INTO itemes(id,item_name,item_artical,sailSingle,sail,note,cost) values('" & Textbarcode.Text & "','" & Textname.Text & " ', ' " & ComboARTICAL.Text & "
                ', ' " & Textsails.Text & "', ' " & Texts.Text & " ', ' " & dt & " ', ' " & Textcost.Text & "')"

                sqcomand.CommandType = CommandType.Text
                conn.Open()
                sqcomand.ExecuteNonQuery()
                DataGridView1.Refresh()
                MessageBox.Show("Done Add New item", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.Refresh()

                conn.Close()

            Else
                MsgBox("please insert data ", MsgBoxStyle.Critical, " error in data")
                Exit Sub
            End If
            Butsave.Enabled = False
            Butdelete.Enabled = True
            Butupdate.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Butinsert_Click(sender As Object, e As EventArgs) Handles Butinsert.Click

        If MsgBox(" Do You Want insert new data ", vbYesNo + vbQuestion, " add new ") = MsgBoxResult.Yes Then
            Textname.Clear()
            ComboARTICAL.Text = ""
            Textsails.Clear()
            Textcost.Clear()
            Texts.Clear()
            Textnoteanddate.Text = dt

            Textbarcode.Clear()

            Butdelete.Enabled = False
            Butsave.Enabled = True
            Textname.Focus()
        End If
        Butupdate.Enabled = False

    End Sub

    Private Sub Butupdate_Click(sender As Object, e As EventArgs) Handles Butupdate.Click


        Dim UPInto As New SqlCommand
        UPInto.Connection = conn
        UPInto.CommandType = CommandType.Text
        UPInto.CommandText = "update itemes set [item_name]='" & Textname.Text & "'
       ,[item_artical]='" & ComboARTICAL.Text & "'
       ,[sailSingle]='" & Textsails.Text & "'
       ,[sail]='" & Texts.Text & "'
       ,[cost]='" & Textcost.Text & "'
       ,[note]= '" & Textnoteanddate.Text & "'
       where id = " & Val(Textbarcode.Text) & ""
        conn.Open()
        UPInto.ExecuteNonQuery()
        DataGridView1.Refresh()
        UPInto.Dispose()
        conn.Close()
        MsgBox(" update don", 64 + 524288, "scecsse")
    End Sub

    Private Sub Butdelete_Click(sender As Object, e As EventArgs) Handles Butdelete.Click

        If MsgBox(" do you sure delete this item ", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, " delete recorde") = MsgBoxResult.Cancel Then Exit Sub

        Dim SavInto As New SqlCommand
        Dim DataAdapter1 As New SqlDataAdapter(sqlselect, conn)
        SavInto.Connection = conn
        SavInto.CommandType = CommandType.Text
        SavInto.CommandText = "DELETE  FROM itemes WHERE id=" &
        Textbarcode.Text & ""
        conn.Open()
        SavInto.ExecuteNonQuery()
        DataSet1.Clear()
        conn.Close()


    End Sub

    Private Sub Butback_Click(sender As Object, e As EventArgs) Handles Butback.Click
        Me.Close()
    End Sub

    Private Sub Textnoteanddate_TextChanged(sender As Object, e As EventArgs) Handles Textnoteanddate.TextChanged
        Textnoteanddate.Text = dt
    End Sub

    Private Sub textsearch_TextChanged(sender As Object, e As EventArgs) Handles textsearch.TextChanged

        If Trim(textsearch.Text) <> "" Then
            DataAdapter1 = New SqlDataAdapter("Select * From itemes Where item_name Like '%" & Trim$(textsearch.Text) & "%'", conn)
            DataSet1.Clear()
            DataAdapter1.Fill(DataSet1, "itemes")
            DataGridView1.DataSource = DataSet1
            DataGridView1.DataMember = "itemes"
            DataGridView1.Refresh()
        Else
        End If
    End Sub

    Private Sub textsearch__DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles textsearch.DoubleClick
        'لا ستعادة جميع بيانات قاعدة البيانات
        Dim DataAdapter1 As New SqlDataAdapter("Select * From itemes", conn)
        '  DataSet1.Clear()
        DataAdapter1.Fill(DataSet1, "itemes")

        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = ""
        DataGridView1.Refresh()
        textsearch.Text = ""
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
