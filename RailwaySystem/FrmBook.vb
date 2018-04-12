Public Class lblCustName
    Private Sub lblCustName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttp1.SetToolTip(Me.txtSearch, "Enter the customer's name or IC to search")
    End Sub
End Class
