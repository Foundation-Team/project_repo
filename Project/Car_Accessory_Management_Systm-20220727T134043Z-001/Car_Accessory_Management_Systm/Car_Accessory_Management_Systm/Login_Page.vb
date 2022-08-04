Public Class Login_Page
    Private Sub Login_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As New DAO

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As New DAO
        Dim obj As SqlClient.SqlDataReader

        obj = d.getdata("select * from loginpage where u_name='" & TextBox1.Text & "'")
    End Sub
End Class