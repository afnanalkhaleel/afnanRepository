Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data
Imports System
Imports System.ComponentModel


Public Class rptpurchase

    Private Sub Formprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rptdo As New purchases
        rptdo.Load("purchases.rpt")
        rptdo.SetDatabaseLogon("sa", "123", "local", "newdb")
        Me.CrystalReportViewer1.ReportSource = rptdo

    End Sub


End Class