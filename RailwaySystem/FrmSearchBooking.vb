Public Class FrmSearchBooking

    Dim booking As New Booking

    Dim db As New railDataContext()

    Private Sub FrmSearchBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rs = From book In db.Bookings

        dgvBooking.DataSource = rs

    End Sub

    Private Sub cboCriteria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCriteria.SelectedIndexChanged

        If radCust.Checked Then

            Try
                Dim key As String = DirectCast(cboCriteria.SelectedItem, KeyValuePair(Of String, String)).Key
                Dim custID = Integer.Parse(key)

                Dim rs = From book In db.Bookings
                         Where book.custID = custID

                dgvBooking.DataSource = rs

            Catch ex As Exception

            End Try

        ElseIf radSchedule.Checked Then

            Try
                Dim key As String = DirectCast(cboCriteria.SelectedItem, KeyValuePair(Of String, String)).Key
                Dim scheduleID = Integer.Parse(key)

                Dim rs = From book In db.Bookings
                         Where book.scheduleID = scheduleID

                dgvBooking.DataSource = rs

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub radCust_CheckedChanged(sender As Object, e As EventArgs) Handles radCust.CheckedChanged
        If radCust.Checked Then
            cboCriteria.Enabled = True

            Dim cList = From c In db.Customers

            Dim comboSource As New Dictionary(Of String, String)()

            For Each cust In cList
                comboSource.Add(cust.custID, cust.custID & " " & cust.custName)
            Next

            cboCriteria.DataSource = New BindingSource(comboSource, Nothing)
            cboCriteria.DisplayMember = "Value"
            cboCriteria.ValueMember = "Key"

        End If
    End Sub

    Private Sub radSchedule_CheckedChanged(sender As Object, e As EventArgs) Handles radSchedule.CheckedChanged
        If radSchedule.Checked Then
            cboCriteria.Enabled = True

            Dim stList = From c In db.Stations
            Dim dictStation As New Dictionary(Of String, String)()

            For Each s In stList
                dictStation.Add(s.stationID, s.stationName)
            Next


            Dim sList = From c In db.Schedules
            Dim comboSource As New Dictionary(Of String, String)()

            For Each s In sList
                comboSource.Add(s.scheduleID, "Schedule ID:" & s.scheduleID & "  First:" & dictStation.Item(s.firstStationID).ToString & "  Last:" & dictStation.Item(s.lastStationID).ToString)
            Next

            cboCriteria.DataSource = New BindingSource(comboSource, Nothing)
            cboCriteria.DisplayMember = "Value"
            cboCriteria.ValueMember = "Key"

        End If
    End Sub

    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        If booking.bookingID = 0 Then
            MessageBox.Show("Please click on a record to select.", "No Record Selected",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim formEdit As New FrmBook
            formEdit.setEdit(booking)
            formEdit.Show()
            Me.Close()
        End If
    End Sub

    Private Sub dgvBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooking.CellClick, dgvBooking.CellDoubleClick
        Try
            Dim rows = dgvBooking.Rows(e.RowIndex)

            Dim c = rows.DataBoundItem
            booking.bookingID = c.bookingID
            booking.quantity = c.quantity
            booking.custID = c.custID
            booking.source = c.source
            booking.destination = c.destination
            booking.seatType = c.seatType
            booking.departureDate = c.departureDate
            booking.departureTime = c.departureTime
            booking.scheduleID = c.scheduleID

            Console.Write(booking.bookingID)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim formMenu As New FrmStaffMenu
        formMenu.Show()
        Me.Close()

    End Sub

    Private Sub radAll_CheckedChanged(sender As Object, e As EventArgs) Handles radAll.CheckedChanged
        If radAll.Checked Then
            Dim rs = From book In db.Bookings

            dgvBooking.DataSource = rs
            cboCriteria.Enabled = False
        End If
    End Sub
End Class