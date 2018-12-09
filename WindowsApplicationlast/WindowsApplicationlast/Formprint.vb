Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data
Imports System
Imports System.ComponentModel


Public Class Formprint


    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Formprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rptdo As New rptcustomer
        rptdo.Load("rptcustomer.rpt")
        rptdo.SetDatabaseLogon("sa", "123", "local", "newdb")
        Me.CrystalReportViewer1.ReportSource = rptdo

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class