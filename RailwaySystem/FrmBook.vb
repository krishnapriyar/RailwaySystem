Imports System.Text.RegularExpressions

Public Class FrmBook

    Dim custBook As New Customer
    Dim sourceID As Integer
    Dim destinationID As Integer


    Private Sub lblCustName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttp1.SetToolTip(Me.txtSearch, "Enter the customer's name or IC to search")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        getCustomer(txtSearch.Text)
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If btnCreate.Text = "Next" Then
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

        Dim comboSource As New Dictionary(Of String, String)()

        For Each s In source
            comboSource.Add(s.stationID, s.stationName)
        Next

        cbo.DataSource = New BindingSource(comboSource, Nothing)
        cbo.DisplayMember = "Value"
        cbo.ValueMember = "Key"
    End Sub

    'Private Sub fillDestination()
    '    cboSource.Items.Clear()
    '    Dim db As New railDataContext()

    '    Dim dest = From sta In db.Stations
    '               Join sch In db.Schedules
    '               On sta.stationID Equals sch.firstStationID
    '               Group By sch.lastStationID Into Group
    '               Select lastStationID

    '    For Each d In dest
    '        cboSource.Items.Add(d)
    '    Next
    'End Sub

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
            comboSource.Add(s.scheduleID, s.startTime.ToString("hh:mm"))
        Next

        cboDepart.DataSource = New BindingSource(comboSource, Nothing)
        cboDepart.DisplayMember = "Value"
        cboDepart.ValueMember = "Key"
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Link to Staff menu
    End Sub

    Public Sub AfterBook()
        Dim c As New Customer
        fillCustomer(c)
    End Sub
End Class
