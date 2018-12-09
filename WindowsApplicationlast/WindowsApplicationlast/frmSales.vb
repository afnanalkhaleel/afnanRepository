Imports System.Data

Imports System.Data.SqlClient


Public Class frmSales

    Dim dt As Date = Date.Now()
    Dim SQLstr As String
    Dim sqlstr2 As String
    Dim sqlstr3 As String
    Dim sqlstr4 As String

    Dim DataSet1 As New DataSet
    Dim dataset2 As New DataSet
    Dim dataset3 As New DataSet
    Dim dataset4 As New DataSet

    Dim DataAdapter2 As New SqlDataAdapter
    Dim DataAdapter3 As New SqlDataAdapter

    'كود البحث برقم الفاتورة
    Private Sub search()

        DataAdapter2 = New SqlDataAdapter("Select * From bill_des Where bill_num like'" & Trim$(txtBillNumber.Text) & "'", conn)
        dataset2.Clear()
        DataAdapter2.Fill(dataset2, "bill_des")
        DataGridView1.DataSource = dataset2
        DataGridView1.DataMember = "bill_des"
        DataGridView1.Refresh()
        DataGridView1.RefreshEdit()
    End Sub
    ' كود الترقيم لوضع رقم اخر فاتورة في شاشة البيعات
    Private Sub add_number()
        Dim cmd2 As New SqlCommand
        cmd2.CommandType = CommandType.Text
        cmd2.Connection = conn
        cmd2.CommandText = "select max (bill_number) from [bills] " ' كود الترقيم التلقائي يعود لا علي قيم في الجدول
        conn.Open()
        Dim a As Integer = cmd2.ExecuteScalar
        conn.Close()
        txtBillNumber.Text = a
    End Sub
    'call desinge datagridview 1
    Private Sub dgv1()
        ' On Error Resume Next

        If DataGridView1 IsNot Nothing Then

            Dim count As Integer = 0 'كود الترقيم التلقائي للداتا جريد فيو

            While (count <= (DataGridView1.Rows.Count - 2))

                DataGridView1.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")

                count += 1

            End While

        End If

        ''''''''''''''''''''''
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = True
        DataGridView1.Columns(8).Visible = True
        DataGridView1.Columns(9).Visible = True
        DataGridView1.Columns(10).Visible = False

        '''''''''''''''''''''

        DataGridView1.Columns(2).Width = 300
        DataGridView1.Columns(7).Width = 120
        DataGridView1.Columns(8).Width = 120
        DataGridView1.Columns(9).Width = 120

        ''''''''''''''''''''''''''''''''''''''''''''''''

        DataGridView1.Columns(2).HeaderText = "item_name"
        DataGridView1.Columns(7).HeaderText = "sail_qut"
        DataGridView1.Columns(8).HeaderText = "sail "
        DataGridView1.Columns(9).HeaderText = " total_sail_qut"
        '''''''''''''''''
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.MultiSelect = False
        With Me.DataGridView1
            .RowsDefaultCellStyle.BackColor = Color.Aqua
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub
    'calculate total in bill
    Private Sub tot()
        Dim Total1 As Double ' حساب أجمالي الفاتورة
        Dim Row As DataGridViewRow
        For Each Row In DataGridView1.Rows
            Dim celV1 As DataGridViewTextBoxCell = Row.Cells(9)
            If IsNumeric(celV1.Value) = True Then
                Total1 += celV1.Value
            End If
        Next
        txtbilltotal.Text = Total1
    End Sub
    ' تنسيق الداتا حريد فيو الخاصة بالبحث عن الاصناف
    Private Sub dgv2()
        '''''''''''''''''
        DataGridView2.Columns(0).Visible = True
        DataGridView2.Columns(2).Visible = False
        DataGridView2.Columns(3).Visible = True
        DataGridView2.Columns(4).Visible = False
        DataGridView2.Columns(5).Visible = False
        DataGridView2.Columns(6).Visible = False

        DataGridView2.Columns(1).Visible = True

        DataGridView2.Columns(1).Width = 300
        ''''''''''''''''''''''''''''''''''''''''''''''''
        DataGridView2.Columns(1).HeaderText = "item_name"
        DataGridView2.Columns(0).HeaderText = "id"
        DataGridView2.Columns(3).HeaderText = "sailsingle"

        ''''
        DataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.MultiSelect = False
        With Me.DataGridView2
            .RowsDefaultCellStyle.BackColor = Color.Beige
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
        End With
        ''''''''''''''''''''


    End Sub
    'لحفظ بيانات الفاتورة
    Private Sub SaveBill()
        Dim CMD As New SqlCommand
        ' CMD.Connection = conn
        ' CMD.CommandType = CommandType.Text
        '' CMD.CommandText
        DataSet1.Clear()
        CMD.CommandText = "Insert Into bills([bill_number],[kind_bill],[kind_CS],[DATE]) values ('" & txtBillNumber.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & DateTimePicker1.Text & "')"

        CMD.CommandType = CommandType.Text
        CMD.Connection = conn
        conn.Open()
        CMD.ExecuteNonQuery()
        conn.Close()
        MsgBox("تم حفظ بيانات الفاتورة بنجاح يمكنك الان بدء التسجيل للاصناف")
        butEnter.Enabled = True
        txtItem2.Focus()
        Call dgv2()
        txtItem2.BackColor = Color.Yellow

    End Sub
    ';,] كود البحث لعرض اسم العميل مقترن بالفاتورة الخاصة بة
    Private Sub SearchBill()
        On Error Resume Next
        DataAdapter3 = New SqlDataAdapter("Select * From bills Where bill_number like'" & Trim$(txtBillNumber.Text) & "'", conn)
        dataset3.Clear()
        DataAdapter3.Fill(dataset3, "bills")

        ComboBox2.DataBindings.Add("Text", dataset3, "bills.kind_CS")

    End Sub
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        Me.CenterToScreen()
        butEnter.Enabled = False
        DateTimePicker1.Value = dt 'متغير التاريخ
        SQLstr = "SELECT * FROM itemes"
        conn.Open()
        Dim DataAdapter1 As New SqlDataAdapter(SQLstr, conn)
        DataAdapter1.Fill(DataSet1, "itemes") 'التعامل مع جدول الاصناف
        conn.Close()
        DataGridView2.DataSource = DataSet1
        DataGridView2.DataMember = "itemes"
        DataGridView2.Refresh()
        ''''''''''''''
        sqlstr2 = "select * from bill_des" ' التعامل مع جدول الفواتير
        conn.Open()
        Dim DataAdapter2 As New SqlDataAdapter(sqlstr2, conn)
        DataAdapter2.Fill(dataset2, "bill_des")
        conn.Close()
        DataGridView1.DataSource = dataset2
        DataGridView1.DataMember = "bill_des"
        DataGridView1.Refresh()

        txtid.DataBindings.Add("Text", DataSet1, "itemes.id")
        '''''' 
        sqlstr3 = "select * from bills "
        conn.Open()
        Dim DataAdapter3 As New SqlDataAdapter(sqlstr3, conn)
        DataAdapter3.Fill(dataset3, "bills")
        conn.Close()
        Call add_number() 'لوضع رقم اخر فاتورة غي شاشة المبيعات   
        '''''''' عرض بيانات العملاء في كمبو بوكس
        sqlstr4 = "select * from client"
        conn.Open()
        Dim dataadaper As New SqlDataAdapter(sqlstr4, conn)
        dataadaper.Fill(dataset4, "client")
        conn.Close()
        For i As Integer = 0 To Me.BindingContext(dataset4, "client").Count - 1
            Dim AddStr As String = dataset4.Tables("client").Rows(i).Item(0).ToString
            If AddStr <> "" Then ComboBox2.Items.Add(AddStr)
        Next
        '''''''
        Call dgv2() ' تنسيق الداتا جريد الخاصة بالاصناف
        '''''

        ''''''''
        Call search() ';كود عرض الفاتورة بالرقم

        Call dgv1() ' تصم الداتا جريد فيو الخاصة بالفاتورة البيع
        Call tot() '  البيع حساب اجمالي الفاتورة


        Call SearchBill() 'عرض اسم العميل الخاص بالفاتورة

        '''''''''''''''''''''''''
        txtItem.DataBindings.Add("Text", DataSet1, "itemes.item_name")
        '   txtprice.DataBindings.Add("text", DataSet1, "itemes.sail")
        txtCost.DataBindings.Add("text", DataSet1, "itemes.cost") 'لعرض تكلفة مبيعات الصنف
        ' كود لجعل فاتورة المشتريات التكلفة تساوي سعر الشراء
        If CheckBoxpu.Checked = True Then 'للتحويل من فاتورة مبيعات الي فاتورة مشتريات

            txtprice.DataBindings.Add("text", DataSet1, "itemes.cost") 'لعرض تكلفة مبيعات الصنف
        Else
            txtprice.DataBindings.Add("text", DataSet1, "itemes.sailSingle")
        End If
        ''''''''''''''''''''''''



    End Sub

    Private Sub CheckBoxsail_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBoxpu_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtWin_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Buttonnext_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Buttonpr_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub butDelet_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub butAdd_Click(sender As Object, e As EventArgs) Handles butAdd.Click
        If MsgBox("do you want to do bill in the same customer in up  ", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "add new bill") = MsgBoxResult.Cancel Then Exit Sub


        Dim cmd2 As New SqlCommand ' كود الترقيم التلقائي
        cmd2.CommandType = CommandType.Text
        cmd2.Connection = conn
        cmd2.CommandText = " select top(1) bill_number from [bills] order by bill_number desc" ' كود الترقيم التلقائي يعود لا علي قيم في الجدول
        conn.Open()
        Dim a As Integer = cmd2.ExecuteScalar

        txtBillNumber.Text = a + 1
        txtpaided.Text = "0"

        conn.Close()


        Call search() 'كود البحث عن رقم الفاتورة
        Call dgv2() 'أستدعاء تنسيق الداتا جريد
        Call tot() 'مجموع الفاتورة
        Call SaveBill() 'حغظ بيانات الفاتورة



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub

    Private Sub butEnter_Click(sender As Object, e As EventArgs) Handles butEnter.Click
        If Trim(txtBillNumber.Text) <> "" And Trim(txtItem.Text) <>
"" Or Trim(txtq.Text) <> "" Then
        Else
            MsgBox(" Please inter data ", MsgBoxStyle.Critical, " error in data")
            Exit Sub
        End If

        If butEnter.Text = "enter" Then
            Dim cmd As New SqlCommand
            Dim too As String
            too = Val(txtq.Text) * Val(txtprice.Text)

            txtTotal.Text = too


            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Insert Into
bill_des([bill_num],[id],[item_name],[sail_qut],[date],[sail],[total_sail_qut],[win]) values
('" & txtBillNumber.Text & "','" & txtid.Text & "','" & txtItem.Text & "','" & txtq.Text & "','" & DateTimePicker1.Text & "','" & txtprice.Text &
                "','" & txtTotal.Text & "','" & txtWin.Text & "')"
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            txtTotal.Text = too
            Call search()
            Call dgv1()
            Call tot()
            txtq.Text = ""
            txtprice.Text = ""
            txtTotal.Text = ""
            txtItem2.Focus()
            Call dgv2()


        Else
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "Insert Into
bill_des([bill_num],[id],[item_name],[qut],[date],[cost],[total_qut],[win]) values
('" & txtBillNumber.Text & "','" & txtid.Text & "','" & txtItem.Text & "','" & txtq.Text & "','" & DateTimePicker1.Text & "','" & txtprice.Text &
                "','" & txtTotal.Text & "','" & txtWin.Text & "')"


            conn.Open()
            CMD.ExecuteNonQuery()
            conn.Close()


            Call search()
            Call dgv1billBuy() 'عرض فواتير الشراء
            Call totBuy() ' لعرض أجمالي فاتورة الشراء
            txtq.Text = ""
            txtprice.Text = ""
            txtItem2.Focus()
        End If
    End Sub

    Private Sub txtItem2_TextChanged(sender As Object, e As EventArgs) Handles txtItem2.TextChanged
        Call dgv2()
        On Error Resume Next
        DataGridView2.Visible = True
        If Trim(txtItem2.Text) <> "" Then
            DataAdapter1 = New SqlDataAdapter("Select * From itemes Where item_name like '%" & Trim$(txtItem2.Text) & "%'", conn)
            DataSet1.Clear()
            DataAdapter1.Fill(DataSet1, "itemes")
            DataGridView2.DataSource = DataSet1
            DataGridView2.DataMember = "itemes"
            DataGridView2.Refresh()

        Else
        End If
        Call dgv2()
    End Sub

    Private Sub Buttonview_Click(sender As Object, e As EventArgs) Handles Buttonview.Click
        On Error Resume Next ' كود عرض البحث عن رقم الفاتورة
        If Trim(txtBillNumber.Text) <> "" Then
            Call SearchBill() 'لعرض اسم العميل الخاص بالفاتورة 

            Call search() 'كود البحث برقم الفاتورة
        End If

        If CheckBoxpu.Checked = True Then
            Call dgv1billBuy() 'فاتورة الشراء
            Call totBuy() 'اجمالي فاتورة الشراء
        Else
            Call dgv1() ' تصم الداتا جريد فيو الخاصة بالفاتورة البيع
            Call tot() '  البيع حساب اجمالي الفاتورة

        End If


        butEnter.Enabled = True
    End Sub

    Private Sub butDelet_Click_1(sender As Object, e As EventArgs) Handles butDelet.Click
        If MsgBox("do you want to dellet item from this bill ", MsgBoxStyle.Question +
MsgBoxStyle.OkCancel, " delete  ") = MsgBoxResult.Cancel Then Exit Sub

        Dim del As New SqlCommand
        Dim DataAdapter2 As New SqlCommand(sqlstr2, conn)
        del.Connection = conn
        del.CommandType = CommandType.Text

        del.CommandText = "DELETE  FROM bill_des WHERE id=" &
        txtid.Text & ""
        conn.Open()
        del.ExecuteNonQuery()
        dataset2.Clear()
        conn.Close()

        If CheckBoxpu.Checked = True Then
            'Call search()
            Call dgv1billBuy() ' الشراء فاتورة
            Call totBuy() ' الشراء فاتورة اجمالي
        Else

            Call search() ' البحث كود أستدعاء
        Call dgv1()
        Call tot() '

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a, b, x, t4, t5, t6, t7 As String
        Dim t1, t2, t3 As String
        a = txtprice.Text
        b = txtq.Text
        x = Val(txtq.Text) * Val(txtprice.Text)
        txtTotal.Text = x
        ''''''''''''
        t1 = txtbilltotal.Text ' الفاتورة أجمالي حساب كود
        t2 = txtpaided.Text
        t3 = Val(txtbilltotal.Text) - Val(txtpaided.Text)
        txtreset.Text = t3
        ''''''''''''''''''''
        t4 = txtCost.Text
        t5 = Val(a) * Val(b)
        t6 = Val(b) * Val(t4)
        t7 = Val(t5) - Val(t6)
        txtWin.Text = t7
        ''''''''''''
        If txtreset.Text < 0 Then
            txtreset.ForeColor = Color.Red
            txtreset.BackColor = Color.Turquoise
            Label6.Text = "Remaining amount
 "
            Label6.BackColor = Color.Ivory
        Else
            txtreset.ForeColor = Color.Black
            txtreset.BackColor = Color.Thistle
            Label6.Text = " The remaining amount to us"
            Label6.BackColor = Color.Red
        End If
        Exit Sub
    End Sub


    Private Sub txtItem2_KeyPress(ByVal sender As Object,
ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItem2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtq.Focus()
        End If
    End Sub

    Private Sub Buttonexit_Click(sender As Object, e As EventArgs) Handles Buttonexit.Click
        Me.Close()
    End Sub

    Private Sub Buttonprint_Click(sender As Object, e As EventArgs) Handles Buttonprint.Click
        If CheckBoxpu.Checked = True Then
            Dim rr As New purchases
            rptpurchase.Show()
        Else
            Dim r As New sailbill
            Printbill.Show()
        End If
    End Sub

    Private Sub Buttonpr_Click_1(sender As Object, e As EventArgs) Handles Buttonpr.Click
        'كود لعرض ارقام الغواتير السابقة
        txtBillNumber.Text = txtBillNumber.Text - 1

        Call search()

        If CheckBoxpu.Checked = True Then
            Call dgv1billBuy() 'فاتورة الشراء
            Call totBuy() 'اجمالي فاتورة الشراء
        Else
            Call dgv1() ' تصم الداتا جريد فيو الخاصة بالفاتورة البيع
            Call tot() '  البيع حساب اجمالي الفاتورة

        End If
        Call SearchBill() 'عرض اسم العميل الخاص بالفاتورة
    End Sub


    Private Sub Buttonnext_Click_1(sender As Object, e As EventArgs) Handles Buttonnext.Click
        'كود لعرض ارقام الغواتير اللاحقة التالية
        txtBillNumber.Text = txtBillNumber.Text + 1
        Call search()
        If CheckBoxpu.Checked = True Then
            Call dgv1billBuy() 'فاتورة الشراء
            Call totBuy() 'اجمالي فاتورة الشراء
        Else
            Call dgv1() ' تصم الداتا جريد فيو الخاصة بالفاتورة البيع
            Call tot() '  البيع حساب اجمالي الفاتورة

        End If
        Call SearchBill()
    End Sub


    Private Sub dgv1billBuy()
        ' On Error Resume Next 'لعرض النتيجة في فاتورة الشراء
        ''''
        If DataGridView1 IsNot Nothing Then

            Dim count As Integer = 0 'كود الترقيم التلقائي للداتا جريد فيو

            While (count <= (DataGridView1.Rows.Count - 2))

                DataGridView1.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")

                count += 1

            End While

        End If

        ''''''''''''''''''''''
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True
        DataGridView1.Columns(4).Visible = True
        DataGridView1.Columns(5).Visible = True
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(10).Visible = False

        '''''''''''''''''''''

        DataGridView1.Columns(2).Width = 300
        DataGridView1.Columns(3).Width = 120
        DataGridView1.Columns(4).Width = 120
        DataGridView1.Columns(5).Width = 120

        ''''''''''''''''''''''''''''''''''''''''''''''''

        DataGridView1.Columns(2).HeaderText = "item_name"
        DataGridView1.Columns(3).HeaderText = "qut"
        DataGridView1.Columns(4).HeaderText = "cost "
        DataGridView1.Columns(5).HeaderText = " total_qut"
        '''''''''''''''''
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.MultiSelect = False
        With Me.DataGridView1
            .RowsDefaultCellStyle.BackColor = Color.Aqua
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub
    Private Sub totBuy() 'لعرض أجمالي فاتورة الشراء
        Dim Total1 As Double ' حساب أجمالي الفاتورة
        Dim Row As DataGridViewRow
        For Each Row In DataGridView1.Rows
            Dim celV1 As DataGridViewTextBoxCell = Row.Cells(5)
            If IsNumeric(celV1.Value) = True Then
                Total1 += celV1.Value
            End If
        Next
        txtbilltotal.Text = Total1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fwin.Show()
    End Sub
End Class