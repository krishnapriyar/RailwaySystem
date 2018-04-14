Public Class FrmCustSearchList
    Dim customer As New Customer()
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick, dgv.CellDoubleClick
        Dim rows = dgv.Rows(e.RowIndex)

        Dim c = rows.DataBoundItem
        customer.custID = c.custID
        customer.custName = c.custName
        customer.custIC = c.custIC
        customer.custEmail = c.custEmail
        customer.custAddress = c.custAddress
        customer.custPhone = c.custPhone
        customer.custType = c.custType

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        FrmBook.fillCustomer(customer)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class