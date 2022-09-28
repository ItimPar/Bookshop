Imports System.Data.SqlClient

Public Class frm_sale
    Private Sub frm_sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookshopDataSet.book' table. You can move, or remove it, as needed.


    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_22\SQLEXPRESS;Initial Catalog=Bookshop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from book where book_id =" & id_tb.Text, conn)
        Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        adap.Fill(dt)
        Dim rowID As Integer = DataGridSale.Rows.Add()
        Dim row As DataGridViewRow = DataGridSale.Rows(rowID)
        row.Cells("b_ID").Value = dt.Rows(0).Item("book_id")
        row.Cells("b_name").Value = dt.Rows(0).Item("book_name")
        row.Cells("b_price").Value = dt.Rows(0).Item("book_price")
        row.Cells("b_amount").Value = amount_tb.Text
        row.Cells("b_sum").Value = row.Cells("b_price").Value * row.Cells("b_amount").Value

        Dim total As Integer = 0

        For Each dataRow As DataGridViewRow In DataGridSale.Rows
            total += dataRow.Cells("b_sum").Value

        Next
        total_tb.Text = total

    End Sub

    Private Sub payment_tb_KeyUp(sender As Object, e As KeyEventArgs) Handles payment_tb.KeyUp
        change_lb.Text = payment_tb.Text - total_tb.Text
    End Sub

    Private Sub buy_btn_Click(sender As Object, e As EventArgs) Handles buy_btn.Click
        For Each dataRow As DataGridViewRow In DataGridSale.Rows
            Dim conn As SqlConnection = New SqlConnection("Data Source=344_22\SQLEXPRESS;Initial Catalog=Bookshop;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("select * from book where book_id = '" & dataRow.Cells("b_ID").Value & "'", conn)
            Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            adap.Fill(dt)
            If dt.Rows.Count > 0 Then
                conn.Open()
                Dim cmd2 As SqlCommand = New SqlCommand("UPDATE book SET book_amount = '" &
                                                        dt.Rows(0).Item("book_amount") - dataRow.Cells("b_amount").Value &
                                                        "' WHERE book_id =" & dt.Rows(0).Item("book_id"), conn)
                If cmd2.ExecuteNonQuery() Then
                    MsgBox("Updated Book Amount")
                End If
                conn.Close()
            End If
            DataGridSale.Rows.Clear()
        Next
    End Sub
End Class