Imports System.Data.SqlClient

Public Class frm_customer
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookshopDataSet)

    End Sub

    Private Sub frm_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookshopDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.BookshopDataSet.customer)

    End Sub

    Private Sub DEL_Click(sender As Object, e As EventArgs) Handles DEL.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-ST13543\SQLEXPRESS01;Initial Catalog=Bookshop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM customer WHERE cus_id =" & Cus_idTextBox.Text, conn)
        conn.Open()
        If cmd.ExecuteNonQuery() Then
            MsgBox("Deleted")
        End If
        conn.Close()
        Me.CustomerTableAdapter.Fill(Me.BookshopDataSet.customer)
    End Sub

    Private Sub EDIT_Click(sender As Object, e As EventArgs) Handles EDIT.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-ST13543\SQLEXPRESS01;Initial Catalog=Bookshop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("UPDATE customer SET cus_name = @name,
        cus_lastname = @lastname, cus_username = @username, cus_pwd = @pwd WHERE cus_id = @id", conn)
        cmd.Parameters.AddWithValue("name", Cus_nameTextBox.Text)
        cmd.Parameters.AddWithValue("lastname", Cus_lastnameTextBox.Text)
        cmd.Parameters.AddWithValue("username", Cus_usernameTextBox.Text)
        cmd.Parameters.AddWithValue("pwd", Cus_pwdTextBox.Text)
        cmd.Parameters.AddWithValue("id", Cus_idTextBox.Text)
        conn.Open()
        If cmd.ExecuteNonQuery() Then
            MsgBox("Edited")
        End If
        conn.Close()
        Me.CustomerTableAdapter.Fill(Me.BookshopDataSet.customer)
    End Sub
End Class