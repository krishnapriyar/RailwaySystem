Public Class FrmSearchBooking
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooking.CellContentClick

    End Sub

    Private Sub FrmSearchBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New railDataContext()

        Dim rs = From book In db.Bookings

        dgvBooking.DataSource = rs

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim queryStr As String = lblSearch.Text


    End Sub
End Class