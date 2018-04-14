Public Class FrmNextBook
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmBook.AfterBook()
        Me.Close()
    End Sub

End Class