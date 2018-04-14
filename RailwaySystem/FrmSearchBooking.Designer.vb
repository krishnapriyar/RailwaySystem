<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearchBooking
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
        Me.dgvBooking = New System.Windows.Forms.DataGridView()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radCust = New System.Windows.Forms.RadioButton()
        Me.radSchedule = New System.Windows.Forms.RadioButton()
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBooking
        '
        Me.dgvBooking.AllowUserToAddRows = False
        Me.dgvBooking.AllowUserToDeleteRows = False
        Me.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooking.Location = New System.Drawing.Point(12, 79)
        Me.dgvBooking.Name = "dgvBooking"
        Me.dgvBooking.ReadOnly = True
        Me.dgvBooking.Size = New System.Drawing.Size(714, 321)
        Me.dgvBooking.TabIndex = 0
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(146, 444)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(91, 45)
        Me.btnAction.TabIndex = 1
        Me.btnAction.Text = "Edit"
        Me.btnAction.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(521, 444)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 45)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.Location = New System.Drawing.Point(277, 30)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(334, 20)
        Me.lblSearch.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(641, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search By : "
        '
        'radCust
        '
        Me.radCust.AutoSize = True
        Me.radCust.Location = New System.Drawing.Point(84, 30)
        Me.radCust.Name = "radCust"
        Me.radCust.Size = New System.Drawing.Size(69, 17)
        Me.radCust.TabIndex = 8
        Me.radCust.TabStop = True
        Me.radCust.Text = "Customer"
        Me.radCust.UseVisualStyleBackColor = True
        '
        'radSchedule
        '
        Me.radSchedule.AutoSize = True
        Me.radSchedule.Location = New System.Drawing.Point(173, 30)
        Me.radSchedule.Name = "radSchedule"
        Me.radSchedule.Size = New System.Drawing.Size(70, 17)
        Me.radSchedule.TabIndex = 9
        Me.radSchedule.TabStop = True
        Me.radSchedule.Text = "Schedule"
        Me.radSchedule.UseVisualStyleBackColor = True
        '
        'FrmSearchBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 534)
        Me.Controls.Add(Me.radSchedule)
        Me.Controls.Add(Me.radCust)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAction)
        Me.Controls.Add(Me.dgvBooking)
        Me.Name = "FrmSearchBooking"
        Me.Text = "Search Bookings"
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBooking As DataGridView
    Friend WithEvents btnAction As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents radCust As RadioButton
    Friend WithEvents radSchedule As RadioButton
End Class
