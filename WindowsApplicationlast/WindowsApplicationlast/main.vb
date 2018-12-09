Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient

Public Class main

    Private Sub dgv1()
        If DataGridViewmain IsNot Nothing Then
            Dim count As Integer = 0

            While (count <= (DataGridViewmain.Rows.Count - 2))
                DataGridViewmain.Rows(count).HeaderCell.Value =
String.Format((count + 1).ToString(), "0")
                count += 1
            End While
        End If
    End Sub
    ''' '''''''''''''''''''''''''''''''''''''''
    Public sqlselect As String = "Select * from itemes "
    Dim dt As Date = Date.Now()


    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        conn.Open()
        Dim DataAdapter1 As New SqlDataAdapter(sqlselect, conn)
        DataAdapter1.Fill(DataSet1, "itemes")
        conn.Close()
        DataGridViewmain.DataSource = DataSet1
        DataGridViewmain.DataMember = "itemes"
        DataGridViewmain.Refresh()
        ''''''''''''''
        Call dgv1()
        '''''''''''''''
        DataGridViewmain.Columns(0).Visible = True
        DataGridViewmain.Columns(1).Visible = True
        DataGridViewmain.Columns(2).Visible = True
        DataGridViewmain.Columns(3).Visible = True
        DataGridViewmain.Columns(4).Visible = True
        DataGridViewmain.Columns(5).Visible = True
        DataGridViewmain.Columns(6).Visible = False

        DataGridViewmain.Columns(0).HeaderText = "Id_Item "
        DataGridViewmain.Columns(1).HeaderText = "Name_Item "
        DataGridViewmain.Columns(2).HeaderText = "Item_artical "
        DataGridViewmain.Columns(3).HeaderText = " SailSingle"
        DataGridViewmain.Columns(4).HeaderText = "sail "
        DataGridViewmain.Columns(5).HeaderText = " Note 
         "
        DataGridViewmain.Columns(6).HeaderText = "Cost_Item "

        DataGridViewmain.Columns(0).Width = 40
        DataGridViewmain.Columns(1).Width = 380
        DataGridViewmain.Columns(2).Width = 90
        DataGridViewmain.Columns(3).Width = 100
        DataGridViewmain.Columns(4).Width = 100
        DataGridViewmain.Columns(5).Width = 220
        DataGridViewmain.Columns(6).Width = 90
        DataGridViewmain.ColumnHeadersDefaultCellStyle.Alignment =
DataGridViewContentAlignment.MiddleCenter
        DataGridViewmain.MultiSelect = False
        With Me.DataGridViewmain
            .RowsDefaultCellStyle.BackColor = Color.Bisque
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        End With
        TextBoo.Focus()


    End Sub

    Private Sub Butclasses_Click(sender As Object, e As EventArgs) Handles Butclasses.Click
        classes.Show()

    End Sub

    Private Sub TextBoo_TextChanged(sender As Object, e As EventArgs) Handles TextBoo.TextChanged
        If Trim(TextBoo.Text) <> "" Then
            DataAdapter1 = New SqlDataAdapter("Select * From itemes
            Where item_name Like'%" & Trim$(TextBoo.Text) & "%'", conn)
            DataSet2.Clear()
            DataAdapter1.Fill(DataSet2, "itemes")
            DataGridViewmain.DataSource = DataSet2
            DataGridViewmain.DataMember = "itemes"
            DataGridViewmain.Refresh()
            Call dgv1()
        Else
        End If
    End Sub
    Private Sub TextBoo__DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoo.DoubleClick
        'لا ستعادة جميع بيانات قاعدة البيانات
        Dim DataAdapter1 As New SqlDataAdapter("Select * From itemes", conn)
        DataSet2.Clear()
        DataAdapter1.Fill(DataSet2, "itemes")

        DataGridViewmain.DataSource = DataSet2
        DataGridViewmain.DataMember = ""
        DataGridViewmain.Refresh()
        TextBoo.Text = ""
    End Sub
    Private Sub SuppliersAndCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersAndCustomersToolStripMenuItem.Click


    End Sub

    Private Sub Butsales_Click(sender As Object, e As EventArgs) Handles Butsales.Click
        customers.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub DataGridViewmain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewmain.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmSales.CheckBoxsail.ForeColor = Color.Red
        frmSales.CheckBoxsail.Checked = True
        frmSales.butEnter.Enabled = True

        frmSales.Show()
    End Sub

    Private Sub butpur_Click(sender As Object, e As EventArgs) Handles butpur.Click
        frmSales.ComboBox1.Text = "purchases "
        frmSales.butEnter.Text = " enter item "
        frmSales.Label3.Text = " suplier"
        frmSales.ComboBox2.Text = "general suplier "
        frmSales.BackColor = Color.AliceBlue
        frmSales.CheckBoxpu.ForeColor = Color.Red
        frmSales.CheckBoxpu.Checked = True
        '  frmSales.Buttonprint.Enabled = False
        frmSales.Buttonprint.Text = "print All bill purchase"

        frmSales.Show()
    End Sub
End Class
