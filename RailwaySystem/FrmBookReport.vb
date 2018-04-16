Public Class FrmBookReport
    Private Sub FrmBookReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'railDataSet.BookingRep' table. You can move, or remove it, as needed.
        Me.BookingRepTableAdapter.Fill(Me.railDataSet.BookingRep, New Date, New Date)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub brnGen_Click(sender As Object, e As EventArgs) Handles brnGen.Click

        Try
            Dim month = cboMonth.SelectedIndex + 1
            Dim year = Integer.Parse(cboYear.SelectedItem)

            Dim startDStr = year & "-" & month & "-1"
            Dim endDStr = year & "-" & month + 1 & "-1"

            Dim startDate = Date.Parse(startDStr)
            Dim endDate = Date.Parse(endDStr)
            Me.BookingRepTableAdapter.Fill(Me.railDataSet.BookingRep, startDate, endDate)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try



    End Sub
End Class