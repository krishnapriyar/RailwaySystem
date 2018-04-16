Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class FrmBook

    Dim custBook As New Customer
    Dim sourceID As Integer
    Dim destinationID As Integer
    Dim newBookingID As Integer
    Dim stationSource As New Dictionary(Of String, String)()


    Private Sub lblCustName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttp1.SetToolTip(Me.txtSearch, "Enter the customer's name or IC to search")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        getCustomer(txtSearch.Text)
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If btnCreate.Text = "Next" Then
            genBookingId()
            grpTicket.Enabled = True
        Else
            grpTicket.Enabled = False

            'call Zhi Gie's module
        End If
    End Sub

    Private Sub getCustomer(queryStr As String)

        Dim db As New railDataContext()

        Dim cList = From cust In db.Customers
                    Where cust.custName.Contains(queryStr) Or
                      cust.custPhone.Contains(queryStr) Or
                      cust.custIC.Contains(queryStr)
                    Select cust.custID, cust.custName, cust.custIC, cust.custEmail, cust.custAddress, cust.custPhone, cust.custType
        'customer table contains password. avoid selecting all fields

        Dim customer As New Customer()

        If cList.Count() = 1 Then
            Dim c = cList.First

            customer.custID = c.custID
            customer.custName = c.custName
            customer.custIC = c.custIC
            customer.custEmail = c.custEmail
            customer.custAddress = c.custAddress
            customer.custPhone = c.custPhone
            customer.custType = c.custType

            fillCustomer(customer)

        ElseIf cList.Count() = 0 Then
            MessageBox.Show("No such customer record found. Consider creating a new customer.", "No Record Found",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnCreate.Text = "Create New Customer"
        Else
            Dim formResult As New FrmCustSearchList()
            formResult.dgv.DataSource = cList
            formResult.Owner = Me
            formResult.ShowDialog()
        End If

    End Sub

    Public Sub fillCustomer(cu As Customer)
        lblCustId.Text = cu.custID
        lblCustName.Text = cu.custName
        lblCustIC.Text = cu.custIC
        lblCustPhone.Text = cu.custPhone
        lblCustEmail.Text = cu.custEmail
        lblCustAdd.Text = cu.custAddress
        lblCustType.Text = cu.custType

        btnCreate.Text = "Next"

        custBook = cu
        'grpCust.Refresh()
        'grpCust.Update()
        'Application.DoEvents()

    End Sub

    Private Sub grpTicket_EnabledChanged(sender As Object, e As EventArgs) Handles grpTicket.EnabledChanged
        If grpTicket.Enabled Then
            fillStation(cboSource)
            fillStation(cboDestination)

        End If
    End Sub

    Private Sub fillStation(cbo As ComboBox)
        'cbo.Items.Clear()
        Dim db As New railDataContext()

        Dim source = From s In db.Stations



        For Each s In source
            If Not stationSource.ContainsKey(s.stationID.ToString) Then
                stationSource.Add(s.stationID, s.stationName)
            End If

        Next

        cbo.DataSource = New BindingSource(stationSource, Nothing)
        cbo.DisplayMember = "Value"
        cbo.ValueMember = "Key"
    End Sub

    Private Sub cboStation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSource.SelectedIndexChanged, cboDestination.SelectedIndexChanged
        Dim key As String = DirectCast(cboSource.SelectedItem, KeyValuePair(Of String, String)).Key


        Try
            sourceID = Integer.Parse(key)


        Catch ex As Exception

        End Try

        Try
            Dim key2 As String = DirectCast(cboDestination.SelectedItem, KeyValuePair(Of String, String)).Key
            destinationID = Integer.Parse(key2)
            getSchedule()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub getSchedule()

        Dim db As New railDataContext()

        Dim schedule = From sch In db.Schedules
                       Join sta In db.Stations
                       On sta.stationID Equals sch.firstStationID
                       Where sch.firstStationID <= sourceID And
                       sch.lastStationID >= destinationID
                       Select sch.startTime, sch.scheduleID


        Dim comboSource As New Dictionary(Of String, String)()

        For Each s In schedule
            If comboSource.ContainsValue(s.startTime.ToString()) = False Then
                comboSource.Add(s.scheduleID, s.startTime.ToString())
            End If
        Next

        If comboSource.Count = 0 Then
            err.SetError(cboDepart, "No journeys found for this route.")
        Else
            err.Clear()
        End If
        cboDepart.DataSource = New BindingSource(comboSource, Nothing)
        cboDepart.DisplayMember = "Value"
        cboDepart.ValueMember = "Key"
        cboDepart.Refresh()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        If btnBook.Text = "Book Ticket" Then
            saveBooking()
        ElseIf btnBook.Text = "Confirm Changes" Then
            saveEditedBooking()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Link to Staff menu
    End Sub

    Public Sub AfterBook()
        Dim c As New Customer
        fillCustomer(c)
    End Sub

    Private Function getQuantity() As Integer
        Dim quantity As Integer = Integer.Parse(dudQuantity.Text.Trim())
        Return quantity
    End Function

    Private Sub dudQuantity_Validating(sender As Object, e As CancelEventArgs) Handles dudQuantity.Validating
        If getQuantity() = 0 Then
            err.SetError(dudQuantity, "Quantity cannot be zero.")
        Else
            err.Clear()
        End If
    End Sub

    Private Sub genBookingId()
        Dim db As New railDataContext()
        Dim lastID As Integer = 1000
        Try
            lastID = CInt((From booking In db.Bookings Select booking.bookingID).Max())
        Catch ex As Exception

        End Try

        newBookingID = lastID + 1

        lblBookId.Text = newBookingID
    End Sub

    Private Sub saveBooking()

        Dim booking As New Booking
        Dim isDuplicated As Boolean
        Dim db As New railDataContext()

        Try
            booking.bookingID = newBookingID
            booking.quantity = getQuantity()
            booking.custID = custBook.custID
            booking.source = sourceID
            booking.destination = destinationID
            booking.seatType = cboSeatType.SelectedItem.ToString
            booking.departureDate = dtpDeparture.Value
            booking.departureTime = TimeSpan.Parse(cboDepart.Text)
            Dim key As String = DirectCast(cboDepart.SelectedItem, KeyValuePair(Of String, String)).Key
            Dim scheduleID = Integer.Parse(key)
            booking.scheduleID = scheduleID

            isDuplicated = db.Bookings.Any(Function(o) o.bookingID = booking.bookingID)

            If isDuplicated Then
                MessageBox.Show("There is already a booking with the same id.", "Duplicate Record Found",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Bookings.InsertOnSubmit(booking)
                db.SubmitChanges()

                MessageBox.Show("Booking added succesfully.", "Booking Succesful",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                InitForm()
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub InitForm()
        custBook = New Customer
        sourceID = 0
        destinationID = 0
        newBookingID = 0
        btnBook.Text = "Book Ticket"
        grpTicket.Enabled = False
    End Sub

    Public Sub setEdit(booking As Booking)
        btnBook.Text = "Confirm Changes"

        Try
            newBookingID = booking.bookingID
            lblBookId.Text = newBookingID
            grpTicket.Enabled = True

            dudQuantity.SelectedItem = booking.quantity.ToString
            cboSeatType.SelectedItem = booking.seatType
            cboDestination.SelectedItem = stationSource(booking.destination.ToString)

            dtpDeparture.Value = booking.departureDate

            'cboDestination.SelectedItem = cboDestination.Items(1)
            selectComboItem(booking.bookingID.ToString, cboDestination)

            Dim db As New railDataContext()

            Dim cList = From cust In db.Customers
                        Where cust.custID = booking.custID


            Dim c = cList.First
            fillCustomer(c)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub selectComboItem(item As String, cbo As ComboBox)

        For Each i In cbo.Items
            Dim key As String = DirectCast(cboDestination.Items(i), KeyValuePair(Of String, String)).Key

            If item.Equals(key) Then
                cbo.SelectedItem = cbo.Items(i)
            End If
        Next

    End Sub


    Private Function getStationName(id As Integer) As String
        Dim db As New railDataContext()

        Dim rs = From sta In db.Stations
                 Where sta.stationID = id
                 Select sta.stationName



        Return rs.First().ToString()
    End Function

    Private Sub saveEditedBooking()

        'Dim booking As New Booking
        Dim db As New railDataContext()

        Try
            Dim booking As Booking = db.Bookings.FirstOrDefault(Function(o) o.bookingID = newBookingID)
            booking.quantity = getQuantity()
            booking.custID = custBook.custID
            booking.source = sourceID
            booking.destination = destinationID
            booking.seatType = cboSeatType.SelectedItem.ToString
            booking.departureDate = dtpDeparture.Value
            booking.departureTime = TimeSpan.Parse(cboDepart.Text)
            Dim key As String = DirectCast(cboDepart.SelectedItem, KeyValuePair(Of String, String)).Key
            Dim scheduleID = Integer.Parse(key)
            booking.scheduleID = scheduleID

            db.SubmitChanges()

            MessageBox.Show("Booking updated succesfully.", "Booking Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            InitForm()

        Catch ex As Exception

        End Try





    End Sub



End Class
