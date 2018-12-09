
Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.OpenFileDialog
Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.DateTime

Public Class Form1
    Dim OpenFileDialog1 As New OpenFileDialog
    Dim xlcon As OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        Dim excel As String

        If result = DialogResult.OK Then
            Dim fi As New IO.FileInfo(OpenFileDialog1.FileName)
            Dim filename As String = OpenFileDialog1.FileName

            OpenFileDialog1.Filter = "Excel Files(.xls)|*.xls| 
    Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm"
            excel = fi.FullName
            ' Get the file name.
            TextBox1.Text = excel
            '    "Driver={Driver do Microsoft Excel(*.xls)};dbq=E:\payroll.xlsx;defaultdir=E:\;driverid=790;fil=excel 8.0;filedsn=E:\payroll.xlsx.dsn;maxbuffersize=2048;maxscanrows=8;pagetimeout=5;readonly=0;safetransactions=0;threads=3;uid=admin;usercommitsync=Yes"

            xlcon = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties='Excel 8.0;HDR=Yes;';")
            xlcon.Open()


            Dim datatable As DataTable = xlcon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim listsheet As New List(Of String)
            Dim drsheet As DataRow
            For Each drsheet In datatable.Rows
                listsheet.Add(drsheet("TABLE_NAME"))

            Next
            For Each sheet As String In listsheet
                ListBox1.Items.Add(sheet)
            Next
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        xldataadapter = New OleDbDataAdapter("select * from [" & ListBox1.Text & "] ", xlcon)
        xldataadapter.TableMappings.Add("Table", "Test")
        xldataset = New System.Data.DataSet
        xldataadapter.Fill(xldataset)
        DataGridView1.DataSource = xldataset.Tables(0)
        xlcon.Close()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim type As String = "R"
        For i As Integer = 1 To DataGridView1.RowCount - 2
            Try
                Dim edate = DataGridView1.Rows(i).Cells(2).Value.ToString
                MsgBox(edate)
                Dim expenddt As Date = Date.Parse(edate)
                Dim rowSumodd As Integer = 0
                Dim rowSumsu As Integer = 0

                ' Dim ht As SortedList = New SortedList()
                Dim ht As New List(Of DateTime)
                For j As Integer = 3 To DataGridView1.ColumnCount - 1
                    If Not DataGridView1.Rows(i).Cells(j).Value Is DBNull.Value Then
                        Dim invall As DateTime = DateTime.Parse(DataGridView1.Rows(i).Cells(j).Value)
                        ht.Add(invall)
                        '  ht.Add(j, DataGridView1.Rows(i).Cells(j).Value)
                    Else
                        rowSumodd = rowSumodd + 1
                    End If
                Next

                If (ht.Count Mod 2) = 0 Then
                    ' Dim key As ICollection = ht.Keys
                    Dim k As Integer
                    For k = 0 To ht.Count - 1 Step 2
                        Dim diff As TimeSpan = (ht(k + 1).TimeOfDay) - (ht(k).TimeOfDay)

                        Dim inset1 As String = "insert into [EMPSC]  ([id],[name],[date],[in],[out],[type],[Namday],[diff]) VALUES(@idd,@namee,@Datee,@Inn,@outt,@typee,@namedaay,@dif)"
                        Dim CMD As New SqlCommand(inset1, conn)
                        CMD.Parameters.AddWithValue("@idd", DataGridView1.Rows(i).Cells(0).Value)
                        CMD.Parameters.AddWithValue("@namee", DataGridView1.Rows(i).Cells(1).Value)
                        CMD.Parameters.AddWithValue("@Datee", expenddt.ToString("dd'/'MM'/'yyyy"))
                        CMD.Parameters.AddWithValue("@Inn", ht(k).TimeOfDay)
                        CMD.Parameters.AddWithValue("@outt", ht(k + 1).TimeOfDay)
                        CMD.Parameters.AddWithValue("@typee", type)
                        CMD.Parameters.AddWithValue("@namedaay", expenddt.DayOfWeek.ToString)
                        CMD.Parameters.AddWithValue("@dif", diff)
                        conn.Open()
                        CMD.ExecuteNonQuery()
                        MsgBox("insert sucsess the employe", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, " message  information ")
                        conn.Close()


                        ''''''''''''''''''''''''''''''''for insert diff between in and out 
                        '       Dim select1 As String = "Select [in] from [EMPSC] where [id] Like'" & DataGridView1.Rows(i).Cells(0).Value & "'"
                        '    Dim select2 As String = "select [out] from [EMPSC] where [id] like'" & DataGridView1.Rows(i).Cells(0).Value & "'"

                        '   Dim convselect1 As Double = Double.Parse(select1)

                        'Dim convselect2 As Double = Double.Parse(select2)

                        '  Dim result As Double = convselect2 - convselect1
                    Next

                End If


                If (ht.Count Mod 2) <> 0 Then
                    If (ht.Count = 1) Or (ht.Count = 0) Then
                        MessageBox.Show("Error ", "no employe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    '    If (ht.Count = 3) Or (ht.Count = 5) Then
                    MessageBox.Show("Error ", "no employe", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Dim k3 As Integer
                    For k3 = 0 To ht.Count - 2 Step 2
                        Dim diff3 As TimeSpan = (ht(k3 + 1).TimeOfDay) - (ht(k3).TimeOfDay)
                        Dim inset3 As String = "insert into [EMPSC]  ([id],[name],[date],[in],[out],[type],[Namday],[diff]) VALUES(@idd2,@namee2,@Datee2,@Inn2,@outt2,@typee2,@namedaay2,@di)"
                        Dim CMD3 As New SqlCommand(inset3, conn)

                        CMD3.Parameters.AddWithValue("@idd2", DataGridView1.Rows(i).Cells(0).Value)
                        CMD3.Parameters.AddWithValue("@namee2", DataGridView1.Rows(i).Cells(1).Value)
                        CMD3.Parameters.AddWithValue("@Datee2", expenddt.ToString("dd'/'MM'/'yyyy"))
                        CMD3.Parameters.AddWithValue("@Inn2", ht(k3).TimeOfDay)
                        CMD3.Parameters.AddWithValue("@outt2", ht(k3 + 1).TimeOfDay)
                        CMD3.Parameters.AddWithValue("@typee2", type)
                        CMD3.Parameters.AddWithValue("@namedaay2", expenddt.DayOfWeek.ToString)
                        CMD3.Parameters.AddWithValue("@di", diff3)
                        conn.Open()
                        CMD3.ExecuteNonQuery()
                        MsgBox("insert sucsess the employe", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, " message  information ")
                        conn.Close()
                    Next
                    MessageBox.Show("ther is in without out  ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)


                    '    End If

                End If

            Catch
                Dim typeq As String = "S"
                MsgBox("this employee is absent" + DataGridView1.Rows(i).Cells(2).Value, MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, " message  information ")

                Dim inset4 As String = "insert into [EMPSC]  ([id],[name],[type]) VALUES(@idd4,@namee4,@typee4)"
                Dim CMD4 As New SqlCommand(inset4, conn)
                Dim datinfo = DataGridView1.Rows(i).Cells(2).Value.ToString()
                datinfo.Substring(datinfo.Length - 7)
                MsgBox(datinfo.Substring(datinfo.Length - 7))
                '   Dim expenddt As Date = Date.Parse(edate)
                CMD4.Parameters.AddWithValue("@idd4", DataGridView1.Rows(i).Cells(0).Value)
                CMD4.Parameters.AddWithValue("@namee4", DataGridView1.Rows(i).Cells(1).Value)
                CMD4.Parameters.AddWithValue("@typee4", typeq)

                conn.Open()
                CMD4.ExecuteNonQuery()
                MsgBox("null information about in _out for this employee ", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, " message  information ")
                conn.Close()


                '    Dim inset4 As String = "insert into [EMPSC]([id],[name],[type]) VALUES( ' " & DataGridView1.Rows(i).Cells(0).Value & "','
                '" & DataGridView1.Rows(i).Cells(1).Value & " ','" & typeq & " ')"
                '   Dim CMD4 As New SqlCommand(inset4, conn)
                ' conn.Open()
                ' CMD4.ExecuteNonQuery()
                '  MsgBox("null information about in _out for this employee ", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, " message  information ")
                ' conn.Close()

            End Try

        Next
        MsgBox(" the data ended in this sheet")
        DataGridView1.Columns.Clear()

    End Sub
End Class