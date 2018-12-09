Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System.Data

Public Class Printbill

    Public id_bill As String

    Private Sub Printbill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rptIT As New sailbill

        TopMost = True
        MaximizeBox = False
        rptIT.SetDatabaseLogon("sa", "123", "local", "newdb")
        GETPEPORT()


    End Sub

    Private Sub GETPEPORT()

        Dim rptIT As New sailbill
        rptIT.Load("sailbill.rpt")


        Dim ParameterField As New CrystalDecisions.Shared.ParameterField
        Dim paramaterdiscretevalue As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim paramatefields As New CrystalDecisions.Shared.ParameterFields

        ParameterField.ParameterFieldName = "id_bill"
        paramaterdiscretevalue.Value = id_bill
        ParameterField.CurrentValues.Add(paramaterdiscretevalue)
        paramatefields.Add(ParameterField)

        Me.CrystalReportViewer1.ReportSource = rptIT
        Me.CrystalReportViewer1.ParameterFieldInfo = paramatefields

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class