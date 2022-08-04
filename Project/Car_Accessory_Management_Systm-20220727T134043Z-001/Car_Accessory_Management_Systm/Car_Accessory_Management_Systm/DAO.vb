Imports System.Data.SqlClient
Public Class DAO
    Private conn As SqlClient.SqlConnection

    Public Sub New()
        conn = New SqlConnection("Data Source=103.212.121.67;Persist Security Info=True;User ID=data_stu4;Password=Lovecoding@6750")
        Try
            conn.Open()
            conn.Close()
            'MsgBox("DataBase Conected")

        Catch ex As Exception
            MsgBox("Please Check DataBase Conectivity.....!")
        End Try
    End Sub

    Public Function getdata(ByVal str As String) As SqlDataReader
        Dim obj As SqlDataReader
        conn.Open()
        Dim cmd As New SqlCommand

    End Function


End Class
