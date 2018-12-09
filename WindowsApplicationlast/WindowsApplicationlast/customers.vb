Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class customers
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Public sqlselect As String = "Select * from client "
    Dim dt As Date = Date.Now()

    Private Sub Amel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.Open()
        Dim DataAdapter1 As New SqlDataAdapter(sqlselect, conn)
        DataAdapter1.Fill(DataSet1, "client")

        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = "client"
        DataGridView1.Refresh()
        ''
        Textname1.DataBindings.Add("Text", DataSet1, "client.fiest_name")
        Textname2.DataBindings.Add("text", DataSet1, "client.last_name")
        textid.DataBindings.Add("text", DataSet1, "client.id_client")
        Textphone.DataBindings.Add("text", DataSet1, "client.phone_client")
        Textadd.DataBindings.Add("text", DataSet1, "client.address_client")

        ''''''
        DataGridView1.Columns(0).Visible = True
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True
        DataGridView1.Columns(4).Visible = True

        '''''''''''''''
        DataGridView1.Columns(0).HeaderText = "fiest_name"
        DataGridView1.Columns(1).HeaderText = "last_name "
        DataGridView1.Columns(2).HeaderText = "number_client "
        DataGridView1.Columns(3).HeaderText = "phone_client "
        DataGridView1.Columns(4).HeaderText = "address_client "
        ''''''''''''''
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 250
        Butsave.Enabled = False
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Butsave_Click(sender As Object, e As EventArgs) Handles Butsave.Click
        Dim insertq As String = "Insert Into
client(fiest_name,last_name,phone_client,address_client)values('" & Textname1.Text & "','" &
              Textname2.Text & "','" & Textphone.Text & "','" & Textadd.Text & "')"
        If Trim(Textname1.Text) <> "" Then
            Dim sqcomand As New SqlCommand(insertq, conn)
            conn.Open()
            sqcomand.ExecuteNonQuery()
            MsgBox("ADD CUSTOMER DON ", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, " SAVE ")
            DataGridView1.Refresh()
            conn.Close()
        Else
            MsgBox(" PLEASE INSERT DATA ", MsgBoxStyle.Critical, " ERROR IN INSERT Data")
            Exit Sub
        End If
        Butsave.Enabled = False

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Buttdel.Click
        If MsgBox(" do you sure delete this customer ", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, " delete customer") = MsgBoxResult.Cancel Then Exit Sub
        Dim dell As New SqlCommand
        Dim DataAdapter1 As New SqlDataAdapter(sqlselect, conn)
        dell.Connection = conn
        dell.CommandType = CommandType.Text
        dell.CommandText = "DELETE  FROM client WHERE id_client =" & textid.Text & ""
        conn.Open()
        dell.ExecuteNonQuery()
        DataGridView1.Refresh()
        ' DataSet1.Clear()
        MsgBox("this customer has been deleted", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, " message deletion information ")
        conn.Close()
    End Sub

    Private Sub Butadd_Click(sender As Object, e As EventArgs) Handles Butadd.Click
        Textname1.Text = ""
        Textname2.Text = ""
        Textphone.Text = ""
        Textadd.Text = ""
        textid.Text = ""

        Butsave.Enabled = True
    End Sub

    Private Sub Buttupdate_Click(sender As Object, e As EventArgs) Handles Buttupdate.Click
        Dim sqcomand As New SqlCommand
        Dim updatequry As String = "update client set [fiest_name]='" & Textname1.Text & "'
      ,[last_name]='" & Textname2.Text & "'
      ,[phone_client]='" & Val(Textphone.Text) & "'
      ,[address_client]='" & Textadd.Text & "'
       WHERE id_client = " & Val(textid.Text) & ""

        Dim comand As New SqlCommand(updatequry, conn)

        conn.Open()
        comand.ExecuteNonQuery()
        DataGridView1.Refresh()
        comand.Dispose()
        MsgBox("UPDATE Is DON", 64 + 524288, "UPDATE CUSTOMER")
        conn.Close()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Textname2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Textname1.TextChanged

    End Sub

    Private Sub Labelph_Click(sender As Object, e As EventArgs) Handles Labelph.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles textid.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Textcsh_TextChanged(sender As Object, e As EventArgs) Handles Textcsh.TextChanged
        If Trim(Textcsh.Text) <> "" Then
            DataAdapter1 = New SqlDataAdapter("Select * From client Where [fiest_name] Like '%" & Trim$(Textcsh.Text) & "%'", conn)
            DataSet1.Clear()
            DataAdapter1.Fill(DataSet1, "client")
            DataGridView1.DataSource = DataSet1
            DataGridView1.DataMember = "client"
            DataGridView1.Refresh()
        Else
        End If
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        'Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class