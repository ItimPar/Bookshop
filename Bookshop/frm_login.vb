Imports System.Data.SqlClient
Public Class frm_login
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_22\SQLEXPRESS;Initial Catalog=Bookshop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from customer where cus_username = '" & user_tb.Text & "' and cus_pwd = '" & pwd_tb.Text & "'", conn)
        Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        adap.Fill(dt)
        If dt.Rows.Count = 1 Then
            frm_main.Show()
            Me.Hide()
        Else
            MsgBox("ชื่อหรือรหัสไม่ถูก")
        End If
    End Sub
End Class
