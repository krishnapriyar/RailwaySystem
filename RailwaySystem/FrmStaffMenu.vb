Public Class FrmStaffMenu
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim frmBook1 As New FrmBook
        frmBook1.Show()
        Me.Close()
    End Sub

    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        Dim frmSearchBook As New FrmSearchBooking
        frmSearchBook.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formReport As New FrmBookReport
        formReport.Show()
    End Sub
End Class