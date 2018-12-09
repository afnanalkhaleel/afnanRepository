Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient



Public Class fwin


    Dim DataSet1 As New DataSet
    Dim DataAdapter1 As SqlDataAdapter
    Dim SQLstr As String

    Private Sub frmRsales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.CenterToScreen()
        Dim Con As New SqlConnection
        SQLstr = "select * from bill_des" ' التعامل مع جدول الفواتير
        conn.Open()
        Dim DataAdapter1 As New SqlDataAdapter(SQLstr, conn)
        DataAdapter1.Fill(DataSet1, "bill_des")
        conn.Close()
    End Sub
    Private Sub dgv1()
        ' On Error Resume Next
        ''''
        If datagridview1 IsNot Nothing Then

            Dim count As Integer = 0 'كود الترقيم التلقائي للداتا جريد فيو

            While (count <= (datagridview1.Rows.Count - 2))

                datagridview1.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")

                count += 1

            End While

        End If

        ''''''''''''''''''''''
        datagridview1.Columns(0).Visible = False
        datagridview1.Columns(1).Visible = True
        datagridview1.Columns(2).Visible = True
        datagridview1.Columns(3).Visible = False
        datagridview1.Columns(4).Visible = False
        datagridview1.Columns(5).Visible = False
        datagridview1.Columns(6).Visible = False
        datagridview1.Columns(7).Visible = False
        datagridview1.Columns(8).Visible = False
        datagridview1.Columns(9).Visible = False
        datagridview1.Columns(10).Visible = True

        '''''''''''''''''''''

        datagridview1.Columns(1).Width = 100
        datagridview1.Columns(2).Width = 300
        datagridview1.Columns(10).Width = 120
        ' datagridview1.Columns(9).Width = 120

        ''''''''''''''''''''''''''''''''''''''''''''''''

        datagridview1.Columns(1).HeaderText = "bill_number"
        datagridview1.Columns(2).HeaderText = "name_item"
        datagridview1.Columns(10).HeaderText = "win "
        '  datagridview1.Columns(9).HeaderText = " الاجمالي"
        '''''''''''''''''
        datagridview1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagridview1.MultiSelect = False
        With Me.datagridview1
            .RowsDefaultCellStyle.BackColor = Color.Aqua
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub
    Private Sub tot()
        Dim Total1 As Double ' حساب أجمالي الفاتورة
        Dim Row As DataGridViewRow
        For Each Row In datagridview1.Rows
            Dim celV1 As DataGridViewTextBoxCell = Row.Cells(10)
            If IsNumeric(celV1.Value) = True Then
                Total1 += celV1.Value
            End If
        Next
        txttotalbill.Text = Total1
    End Sub
    Private Sub Buttonsh_Click(sender As Object, e As EventArgs) Handles Buttonsh.Click

        '  Dim x As Date = DateTimePicker1.Value
        ' Dim y As Date = DateTimePicker2.Value
        SQLstr = "select * from bill_des where date between '" & DateTimePicker1.Text & "'and'" & DateTimePicker2.Text & "'"
        conn.Open()
        '  DataSet1.Clear()
        Dim DataAdapter1 As New SqlDataAdapter(SQLstr, conn)
        DataAdapter1.Fill(DataSet1, "bill_des")
        conn.Close()
        Me.datagridview1.DataSource = DataSet1
        Me.datagridview1.DataMember = "bill_des"
        datagridview1.Refresh()
        datagridview1.RefreshEdit()
        Call dgv1()
        Call tot()

    End Sub


    Private Sub Buttonview_Click(sender As Object, e As EventArgs) Handles Buttonview.Click
        DataAdapter1 = New SqlDataAdapter("Select * From bill_des Where bill_num like'" & Trim$(txtbillnumber.Text) & "'", conn)
        DataSet1.Clear()
        DataAdapter1.Fill(DataSet1, "bill_des")
        datagridview1.DataSource = DataSet1
        datagridview1.DataMember = "bill_des"
        datagridview1.Refresh()
        datagridview1.RefreshEdit()
        Call dgv1()
        Call tot()
    End Sub

End Class