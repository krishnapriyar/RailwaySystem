Imports System.ComponentModel

Public Class FrmCustSearchList
    Dim customer As New Customer()
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick, dgv.CellDoubleClick
        Try
            Dim rows = dgv.Rows(e.RowIndex)

            Dim c = rows.DataBoundItem
            customer.custID = c.custID
            customer.custName = c.custName
            customer.custIC = c.custIC
            customer.custEmail = c.custEmail
            customer.custAddress = c.custAddress
            customer.custPhone = c.custPhone
            customer.custType = c.custType

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        If customer.custID = 0 Then
            MessageBox.Show("Please click on a record to select.", "No Record Selected",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim myParentForm As FrmBook = Me.Owner
            myParentForm.fillCustomer(customer)
            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class