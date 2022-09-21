<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_tb = New System.Windows.Forms.TextBox()
        Me.DataGridSale = New System.Windows.Forms.DataGridView()
        Me.b_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_sum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookshopDataSet = New Bookshop.BookshopDataSet()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookTableAdapter = New Bookshop.BookshopDataSetTableAdapters.bookTableAdapter()
        Me.amount_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.total_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.payment_tb = New System.Windows.Forms.TextBox()
        Me.tasdasd = New System.Windows.Forms.Label()
        Me.change_lb = New System.Windows.Forms.Label()
        Me.buy_btn = New System.Windows.Forms.Button()
        CType(Me.DataGridSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookshopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'add_btn
        '
        Me.add_btn.Location = New System.Drawing.Point(317, 155)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(82, 31)
        Me.add_btn.TabIndex = 0
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "book id"
        '
        'id_tb
        '
        Me.id_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_tb.Location = New System.Drawing.Point(180, 155)
        Me.id_tb.Name = "id_tb"
        Me.id_tb.Size = New System.Drawing.Size(131, 31)
        Me.id_tb.TabIndex = 2
        '
        'DataGridSale
        '
        Me.DataGridSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.b_ID, Me.b_name, Me.b_price, Me.b_amount, Me.b_sum})
        Me.DataGridSale.Location = New System.Drawing.Point(479, 41)
        Me.DataGridSale.Name = "DataGridSale"
        Me.DataGridSale.Size = New System.Drawing.Size(543, 278)
        Me.DataGridSale.TabIndex = 3
        '
        'b_ID
        '
        Me.b_ID.HeaderText = "รหัสหนังสือ"
        Me.b_ID.Name = "b_ID"
        '
        'b_name
        '
        Me.b_name.HeaderText = "ชื่อหนังสือ"
        Me.b_name.Name = "b_name"
        Me.b_name.Width = 150
        '
        'b_price
        '
        Me.b_price.HeaderText = "ราคา"
        Me.b_price.Name = "b_price"
        '
        'b_amount
        '
        Me.b_amount.HeaderText = "จำนวน"
        Me.b_amount.Name = "b_amount"
        Me.b_amount.Width = 50
        '
        'b_sum
        '
        Me.b_sum.HeaderText = "รวม"
        Me.b_sum.Name = "b_sum"
        '
        'BookshopDataSet
        '
        Me.BookshopDataSet.DataSetName = "BookshopDataSet"
        Me.BookshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "book"
        Me.BookBindingSource.DataSource = Me.BookshopDataSet
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'amount_tb
        '
        Me.amount_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount_tb.Location = New System.Drawing.Point(180, 201)
        Me.amount_tb.Name = "amount_tb"
        Me.amount_tb.Size = New System.Drawing.Size(131, 31)
        Me.amount_tb.TabIndex = 5
        Me.amount_tb.Text = "1"
        Me.amount_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "amount"
        '
        'total_tb
        '
        Me.total_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_tb.Location = New System.Drawing.Point(891, 335)
        Me.total_tb.Name = "total_tb"
        Me.total_tb.Size = New System.Drawing.Size(131, 31)
        Me.total_tb.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(802, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(802, 375)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "pay"
        '
        'payment_tb
        '
        Me.payment_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payment_tb.Location = New System.Drawing.Point(891, 372)
        Me.payment_tb.Name = "payment_tb"
        Me.payment_tb.Size = New System.Drawing.Size(131, 31)
        Me.payment_tb.TabIndex = 8
        Me.payment_tb.Text = "0"
        '
        'tasdasd
        '
        Me.tasdasd.AutoSize = True
        Me.tasdasd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tasdasd.Location = New System.Drawing.Point(802, 412)
        Me.tasdasd.Name = "tasdasd"
        Me.tasdasd.Size = New System.Drawing.Size(83, 25)
        Me.tasdasd.TabIndex = 11
        Me.tasdasd.Text = "change"
        '
        'change_lb
        '
        Me.change_lb.AutoSize = True
        Me.change_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_lb.Location = New System.Drawing.Point(909, 412)
        Me.change_lb.Name = "change_lb"
        Me.change_lb.Size = New System.Drawing.Size(0, 25)
        Me.change_lb.TabIndex = 12
        '
        'buy_btn
        '
        Me.buy_btn.Location = New System.Drawing.Point(940, 474)
        Me.buy_btn.Name = "buy_btn"
        Me.buy_btn.Size = New System.Drawing.Size(82, 50)
        Me.buy_btn.TabIndex = 13
        Me.buy_btn.Text = "Buy"
        Me.buy_btn.UseVisualStyleBackColor = True
        '
        'frm_sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 551)
        Me.Controls.Add(Me.buy_btn)
        Me.Controls.Add(Me.change_lb)
        Me.Controls.Add(Me.tasdasd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.payment_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.total_tb)
        Me.Controls.Add(Me.amount_tb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridSale)
        Me.Controls.Add(Me.id_tb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.add_btn)
        Me.Name = "frm_sale"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "frm_sale"
        CType(Me.DataGridSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookshopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents add_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents id_tb As TextBox
    Friend WithEvents DataGridSale As DataGridView
    Friend WithEvents BookshopDataSet As BookshopDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As BookshopDataSetTableAdapters.bookTableAdapter
    Friend WithEvents b_ID As DataGridViewTextBoxColumn
    Friend WithEvents b_name As DataGridViewTextBoxColumn
    Friend WithEvents b_price As DataGridViewTextBoxColumn
    Friend WithEvents b_amount As DataGridViewTextBoxColumn
    Friend WithEvents b_sum As DataGridViewTextBoxColumn
    Friend WithEvents amount_tb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents total_tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents payment_tb As TextBox
    Friend WithEvents tasdasd As Label
    Friend WithEvents change_lb As Label
    Friend WithEvents buy_btn As Button
End Class
