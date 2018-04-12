<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblCustName
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSeatType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDepart = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cboDestination = New System.Windows.Forms.Label()
        Me.cboSource = New System.Windows.Forms.Label()
        Me.lblBookId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblCustType = New System.Windows.Forms.Label()
        Me.lblCustAdd = New System.Windows.Forms.Label()
        Me.lblCustEmail = New System.Windows.Forms.Label()
        Me.lblCustPhone = New System.Windows.Forms.Label()
        Me.lblCustIC = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnBook)
        Me.GroupBox1.Controls.Add(Me.cboSeatType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboDepart)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.cboDestination)
        Me.GroupBox1.Controls.Add(Me.cboSource)
        Me.GroupBox1.Controls.Add(Me.lblBookId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(436, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 422)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ticket Information"
        '
        'cboSeatType
        '
        Me.cboSeatType.FormattingEnabled = True
        Me.cboSeatType.Location = New System.Drawing.Point(108, 202)
        Me.cboSeatType.Name = "cboSeatType"
        Me.cboSeatType.Size = New System.Drawing.Size(202, 21)
        Me.cboSeatType.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Seat Type : "
        '
        'cboDepart
        '
        Me.cboDepart.FormattingEnabled = True
        Me.cboDepart.Location = New System.Drawing.Point(108, 160)
        Me.cboDepart.Name = "cboDepart"
        Me.cboDepart.Size = New System.Drawing.Size(202, 21)
        Me.cboDepart.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Departure Time :"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(108, 115)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(202, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(108, 76)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'cboDestination
        '
        Me.cboDestination.AutoSize = True
        Me.cboDestination.Location = New System.Drawing.Point(16, 114)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(66, 13)
        Me.cboDestination.TabIndex = 3
        Me.cboDestination.Text = "Destination :"
        '
        'cboSource
        '
        Me.cboSource.AutoSize = True
        Me.cboSource.Location = New System.Drawing.Point(16, 76)
        Me.cboSource.Name = "cboSource"
        Me.cboSource.Size = New System.Drawing.Size(50, 13)
        Me.cboSource.TabIndex = 2
        Me.cboSource.Text = "Source : "
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCreate)
        Me.GroupBox2.Controls.Add(Me.lblCustType)
        Me.GroupBox2.Controls.Add(Me.lblCustAdd)
        Me.GroupBox2.Controls.Add(Me.lblCustEmail)
        Me.GroupBox2.Controls.Add(Me.lblCustPhone)
        Me.GroupBox2.Controls.Add(Me.lblCustIC)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.lblCustId)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 422)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(119, 348)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(161, 44)
        Me.btnCreate.TabIndex = 22
        Me.btnCreate.Text = "Create New Customer"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblCustType
        '
        Me.lblCustType.AutoSize = True
        Me.lblCustType.Location = New System.Drawing.Point(131, 296)
        Me.lblCustType.Name = "lblCustType"
        Me.lblCustType.Size = New System.Drawing.Size(45, 13)
        Me.lblCustType.TabIndex = 21
        Me.lblCustType.Text = "Label13"
        '
        'lblCustAdd
        '
        Me.lblCustAdd.AutoSize = True
        Me.lblCustAdd.Location = New System.Drawing.Point(131, 259)
        Me.lblCustAdd.Name = "lblCustAdd"
        Me.lblCustAdd.Size = New System.Drawing.Size(45, 13)
        Me.lblCustAdd.TabIndex = 20
        Me.lblCustAdd.Text = "Label15"
        '
        'lblCustEmail
        '
        Me.lblCustEmail.AutoSize = True
        Me.lblCustEmail.Location = New System.Drawing.Point(131, 227)
        Me.lblCustEmail.Name = "lblCustEmail"
        Me.lblCustEmail.Size = New System.Drawing.Size(45, 13)
        Me.lblCustEmail.TabIndex = 19
        Me.lblCustEmail.Text = "Label16"
        '
        'lblCustPhone
        '
        Me.lblCustPhone.AutoSize = True
        Me.lblCustPhone.Location = New System.Drawing.Point(131, 192)
        Me.lblCustPhone.Name = "lblCustPhone"
        Me.lblCustPhone.Size = New System.Drawing.Size(39, 13)
        Me.lblCustPhone.TabIndex = 18
        Me.lblCustPhone.Text = "Label3"
        '
        'lblCustIC
        '
        Me.lblCustIC.AutoSize = True
        Me.lblCustIC.Location = New System.Drawing.Point(131, 161)
        Me.lblCustIC.Name = "lblCustIC"
        Me.lblCustIC.Size = New System.Drawing.Size(39, 13)
        Me.lblCustIC.TabIndex = 17
        Me.lblCustIC.Text = "Label4"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(131, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Label12"
        '
        'btnSearch
        '
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
        Me.lblCustId.Size = New System.Drawing.Size(45, 13)
        Me.lblCustId.TabIndex = 7
        Me.lblCustId.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 296)
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
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(39, 348)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(105, 38)
        Me.btnBook.TabIndex = 2
        Me.btnBook.Text = "Book Ticket"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(188, 348)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 38)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCustName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 443)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "lblCustName"
        Me.Text = "Book Tickets"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboSource As Label
    Friend WithEvents lblBookId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSeatType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboDepart As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cboDestination As Label
    Friend WithEvents lblCustType As Label
    Friend WithEvents lblCustAdd As Label
    Friend WithEvents lblCustEmail As Label
    Friend WithEvents lblCustPhone As Label
    Friend WithEvents lblCustIC As Label
    Friend WithEvents Label12 As Label
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
End Class
