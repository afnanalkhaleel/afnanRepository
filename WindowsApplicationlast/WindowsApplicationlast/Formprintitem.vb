Public Class Formprintitem



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Formprintitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim b = New rptinfo_item
        '  b.idd_item = TextBox1.Text

        rptinfo_item.Show()

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)




    End Sub
End Class