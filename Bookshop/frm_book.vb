﻿Imports System.Data.SqlClient

Public Class frm_book


    Private Sub frm_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookshopDataSet1.book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter1.Fill(Me.BookshopDataSet1.book)
        'TODO: This line of code loads data into the 'BookshopDataSet.book' table. You can move, or remove it, as needed.


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_22\SQLEXPRESS;Initial Catalog=Bookshop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM book WHERE book_id =" & Book_idTextBox.Text, conn)
        conn.Open()
        If cmd.ExecuteNonQuery() Then
            MsgBox("Deleted")
        End If
        conn.Close()
        Me.BookTableAdapter1.Fill(Me.BookshopDataSet1.book)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_22\SQLEXPRESS;Initial Catalog=Bookshop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("UPDATE book SET book_name = @name,
        book_price = @price, book_amount = @amount WHERE book_id = @id", conn)
        cmd.Parameters.AddWithValue("name", Book_nameTextBox.Text)
        cmd.Parameters.AddWithValue("price", Book_priceTextBox.Text)
        cmd.Parameters.AddWithValue("amount", Book_amountTextBox.Text)
        cmd.Parameters.AddWithValue("id", Book_idTextBox.Text)
        conn.Open()
        If cmd.ExecuteNonQuery() Then
            MsgBox("Edited")
        End If
        conn.Close()
        Me.BookTableAdapter1.Fill(Me.BookshopDataSet1.book)


    End Sub
End Class