﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpTicket = New System.Windows.Forms.GroupBox()
        Me.dudQuantity = New System.Windows.Forms.DomainUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.cboSeatType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDepart = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboDestination = New System.Windows.Forms.ComboBox()
        Me.cboSource = New System.Windows.Forms.ComboBox()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblBookId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCust = New System.Windows.Forms.GroupBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblCustType = New System.Windows.Forms.Label()
        Me.lblCustAdd = New System.Windows.Forms.Label()
        Me.lblCustEmail = New System.Windows.Forms.Label()
        Me.lblCustPhone = New System.Windows.Forms.Label()
        Me.lblCustIC = New System.Windows.Forms.Label()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblCustId = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ttp1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpTicket.SuspendLayout()
        Me.grpCust.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTicket
        '
        Me.grpTicket.Controls.Add(Me.dudQuantity)
        Me.grpTicket.Controls.Add(Me.Label4)
        Me.grpTicket.Controls.Add(Me.dtpDeparture)
        Me.grpTicket.Controls.Add(Me.Label3)
        Me.grpTicket.Controls.Add(Me.btnBook)
        Me.grpTicket.Controls.Add(Me.cboSeatType)
        Me.grpTicket.Controls.Add(Me.Label6)
        Me.grpTicket.Controls.Add(Me.cboDepart)
        Me.grpTicket.Controls.Add(Me.Label5)
        Me.grpTicket.Controls.Add(Me.cboDestination)
        Me.grpTicket.Controls.Add(Me.cboSource)
        Me.grpTicket.Controls.Add(Me.lblDestination)
        Me.grpTicket.Controls.Add(Me.lblSource)
        Me.grpTicket.Controls.Add(Me.lblBookId)
        Me.grpTicket.Controls.Add(Me.Label1)
        Me.grpTicket.Enabled = False
        Me.grpTicket.Location = New System.Drawing.Point(436, 12)
        Me.grpTicket.Name = "grpTicket"
        Me.grpTicket.Size = New System.Drawing.Size(331, 422)
        Me.grpTicket.TabIndex = 0
        Me.grpTicket.TabStop = False
        Me.grpTicket.Text = "Ticket Information"
        '
        'dudQuantity
        '
        Me.dudQuantity.Items.Add("8")
        Me.dudQuantity.Items.Add("7")
        Me.dudQuantity.Items.Add("6")
        Me.dudQuantity.Items.Add("5")
        Me.dudQuantity.Items.Add("4")
        Me.dudQuantity.Items.Add("3")
        Me.dudQuantity.Items.Add("2")
        Me.dudQuantity.Items.Add("1")
        Me.dudQuantity.Location = New System.Drawing.Point(108, 297)
        Me.dudQuantity.Name = "dudQuantity"
        Me.dudQuantity.Size = New System.Drawing.Size(120, 20)
        Me.dudQuantity.TabIndex = 14
        Me.dudQuantity.Text = "0"
        Me.dudQuantity.Wrap = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Quantity : "
        '
        'dtpDeparture
        '
        Me.dtpDeparture.CustomFormat = ""
        Me.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDeparture.Location = New System.Drawing.Point(112, 161)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(200, 20)
        Me.dtpDeparture.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Departure Date : "
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(271, 362)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 38)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Back"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(123, 362)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(105, 38)
        Me.btnBook.TabIndex = 2
        Me.btnBook.Text = "Book Ticket"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'cboSeatType
        '
        Me.cboSeatType.FormattingEnabled = True
        Me.cboSeatType.Items.AddRange(New Object() {"Premium", "Standard", "Economy"})
        Me.cboSeatType.Location = New System.Drawing.Point(108, 249)
        Me.cboSeatType.Name = "cboSeatType"
        Me.cboSeatType.Size = New System.Drawing.Size(202, 21)
        Me.cboSeatType.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Seat Type : "
        '
        'cboDepart
        '
        Me.cboDepart.FormattingEnabled = True
        Me.cboDepart.Location = New System.Drawing.Point(108, 207)
        Me.cboDepart.Name = "cboDepart"
        Me.cboDepart.Size = New System.Drawing.Size(202, 21)
        Me.cboDepart.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Departure Time :"
        '
        'cboDestination
        '
        Me.cboDestination.FormattingEnabled = True
        Me.cboDestination.Location = New System.Drawing.Point(108, 123)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(202, 21)
        Me.cboDestination.TabIndex = 5
        '
        'cboSource
        '
        Me.cboSource.FormattingEnabled = True
        Me.cboSource.Location = New System.Drawing.Point(108, 84)
        Me.cboSource.Name = "cboSource"
        Me.cboSource.Size = New System.Drawing.Size(202, 21)
        Me.cboSource.TabIndex = 4
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Location = New System.Drawing.Point(16, 122)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(66, 13)
        Me.lblDestination.TabIndex = 3
        Me.lblDestination.Text = "Destination :"
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(16, 84)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(50, 13)
        Me.lblSource.TabIndex = 2
        Me.lblSource.Text = "Source : "
        '
        'lblBookId
        '
        Me.lblBookId.AutoSize = True
        Me.lblBookId.Location = New System.Drawing.Point(105, 44)
        Me.lblBookId.Name = "lblBookId"
        Me.lblBookId.Size = New System.Drawing.Size(39, 13)
        Me.lblBookId.TabIndex = 1
        Me.lblBookId.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking ID : "
        '
        'grpCust
        '
        Me.grpCust.Controls.Add(Me.btnCreate)
        Me.grpCust.Controls.Add(Me.lblCustType)
        Me.grpCust.Controls.Add(Me.lblCustAdd)
        Me.grpCust.Controls.Add(Me.lblCustEmail)
        Me.grpCust.Controls.Add(Me.btnClose)
        Me.grpCust.Controls.Add(Me.lblCustPhone)
        Me.grpCust.Controls.Add(Me.lblCustIC)
        Me.grpCust.Controls.Add(Me.lblCustName)
        Me.grpCust.Controls.Add(Me.btnSearch)
        Me.grpCust.Controls.Add(Me.txtSearch)
        Me.grpCust.Controls.Add(Me.lblCustId)
        Me.grpCust.Controls.Add(Me.Label14)
        Me.grpCust.Controls.Add(Me.Label9)
        Me.grpCust.Controls.Add(Me.Label10)
        Me.grpCust.Controls.Add(Me.Label11)
        Me.grpCust.Controls.Add(Me.Label8)
        Me.grpCust.Controls.Add(Me.Label7)
        Me.grpCust.Controls.Add(Me.Label2)
        Me.grpCust.Location = New System.Drawing.Point(12, 12)
        Me.grpCust.Name = "grpCust"
        Me.grpCust.Size = New System.Drawing.Size(418, 422)
        Me.grpCust.TabIndex = 1
        Me.grpCust.TabStop = False
        Me.grpCust.Text = "Customer Information"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(71, 362)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(119, 38)
        Me.btnCreate.TabIndex = 22
        Me.btnCreate.Text = "Create New Customer"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblCustType
        '
        Me.lblCustType.AutoSize = True
        Me.lblCustType.Location = New System.Drawing.Point(131, 311)
        Me.lblCustType.Name = "lblCustType"
        Me.lblCustType.Size = New System.Drawing.Size(0, 13)
        Me.lblCustType.TabIndex = 21
        '
        'lblCustAdd
        '
        Me.lblCustAdd.AutoSize = True
        Me.lblCustAdd.Location = New System.Drawing.Point(131, 259)
        Me.lblCustAdd.Name = "lblCustAdd"
        Me.lblCustAdd.Size = New System.Drawing.Size(0, 13)
        Me.lblCustAdd.TabIndex = 20
        '
        'lblCustEmail
        '
        Me.lblCustEmail.AutoSize = True
        Me.lblCustEmail.Location = New System.Drawing.Point(131, 227)
        Me.lblCustEmail.Name = "lblCustEmail"
        Me.lblCustEmail.Size = New System.Drawing.Size(0, 13)
        Me.lblCustEmail.TabIndex = 19
        '
        'lblCustPhone
        '
        Me.lblCustPhone.AutoSize = True
        Me.lblCustPhone.Location = New System.Drawing.Point(131, 192)
        Me.lblCustPhone.Name = "lblCustPhone"
        Me.lblCustPhone.Size = New System.Drawing.Size(0, 13)
        Me.lblCustPhone.TabIndex = 18
        '
        'lblCustIC
        '
        Me.lblCustIC.AutoSize = True
        Me.lblCustIC.Location = New System.Drawing.Point(131, 161)
        Me.lblCustIC.Name = "lblCustIC"
        Me.lblCustIC.Size = New System.Drawing.Size(0, 13)
        Me.lblCustIC.TabIndex = 17
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Location = New System.Drawing.Point(131, 131)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(0, 13)
        Me.lblCustName.TabIndex = 16
        '
        'btnSearch
        '
        Me.btnSearch.CausesValidation = False
        Me.btnSearch.Location = New System.Drawing.Point(326, 39)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(24, 41)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(284, 20)
        Me.txtSearch.TabIndex = 14
        '
        'lblCustId
        '
        Me.lblCustId.AutoSize = True
        Me.lblCustId.Location = New System.Drawing.Point(131, 98)
        Me.lblCustId.Name = "lblCustId"
        Me.lblCustId.Size = New System.Drawing.Size(0, 13)
        Me.lblCustId.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 311)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Customer Type : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Address : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Email : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Phone : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "IC : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer ID : "
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'FrmBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 443)
        Me.Controls.Add(Me.grpCust)
        Me.Controls.Add(Me.grpTicket)
        Me.Name = "FrmBook"
        Me.Text = "Book Tickets"
        Me.grpTicket.ResumeLayout(False)
        Me.grpTicket.PerformLayout()
        Me.grpCust.ResumeLayout(False)
        Me.grpCust.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTicket As GroupBox
    Friend WithEvents grpCust As GroupBox
    Friend WithEvents lblSource As Label
    Friend WithEvents lblBookId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSeatType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboDepart As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboDestination As ComboBox
    Friend WithEvents cboSource As ComboBox
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblCustType As Label
    Friend WithEvents lblCustAdd As Label
    Friend WithEvents lblCustEmail As Label
    Friend WithEvents lblCustPhone As Label
    Friend WithEvents lblCustIC As Label
    Friend WithEvents lblCustName As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblCustId As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents ttp1 As ToolTip
    Friend WithEvents btnClose As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dudQuantity As DomainUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents err As ErrorProvider
End Class
