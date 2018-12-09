Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient


Module Module1

    Public conn As SqlConnection = New SqlConnection("Data Source=(local);Initial Catalog=emp;Integrated Security=True")
    Public CMD As SqlCommand
    Public row As Integer

    Public DataSet1 As New DataSet
    Public DataSet2 As New DataSet
    Public DataAdapter1 As SqlDataAdapter
    Public DataRedear As SqlDataReader
    '' ....
    Public xlcon As OleDbConnection
    Public xlcmd As OleDbCommand
    Public xldataset As DataSet
    Public xldatareader As OleDbDataReader
    Public xldataadapter As OleDbDataAdapter


End Module
