
Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient

Module Module1

    Public conn As SqlConnection = New SqlConnection("Data Source=(local);Initial Catalog=newdb;Integrated Security=True")
    Public CMD As SqlCommand
    Public row As Integer


    Public DataSet1 As New DataSet
    Public DataSet2 As New DataSet
    Public DataAdapter1 As SqlDataAdapter





    ' Public CMD As New OleDbCommand
End Module
