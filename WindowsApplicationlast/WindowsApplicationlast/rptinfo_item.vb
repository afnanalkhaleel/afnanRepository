Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data
Imports System
Imports System.ComponentModel


Public Class rptinfo_item


    Public idd_item As String

    Private Sub rptinfo_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rptIT As New rptitem

        TopMost = True
        MaximizeBox = False
        rptIT.SetDatabaseLogon("sa", "123", "local", "newdb")
        GETPEPORT()


    End Sub

    Private Sub GETPEPORT()

        Dim rptIT As New rptitem
        rptIT.Load("rptitem.rpt")


        Dim ParameterField As New CrystalDecisions.Shared.ParameterField
        Dim paramaterdiscretevalue As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim paramatefields As New CrystalDecisions.Shared.ParameterFields

        ParameterField.ParameterFieldName = "id_item"
        paramaterdiscretevalue.Value = idd_item
        ParameterField.CurrentValues.Add(paramaterdiscretevalue)
        paramatefields.Add(ParameterField)

        Me.CrystalReportViewer1.ReportSource = rptIT
        Me.CrystalReportViewer1.ParameterFieldInfo = paramatefields

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bclose.Click
        Me.Close()
    End Sub
End Class