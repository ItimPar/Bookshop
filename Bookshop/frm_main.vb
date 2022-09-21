Public Class frm_main
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        frm_customer.MdiParent = frm_main.ActiveForm
        frm_customer.Dock = DockStyle.Fill
        frm_customer.Show()
    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        frm_book.MdiParent = frm_main.ActiveForm
        frm_book.Dock = DockStyle.Fill
        frm_book.Show()
    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        frm_sale.MdiParent = frm_main.ActiveForm
        frm_sale.Dock = DockStyle.Fill
        frm_sale.Show()
    End Sub
End Class