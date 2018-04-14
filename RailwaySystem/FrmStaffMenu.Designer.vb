<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStaffMenu
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
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(175, 66)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(155, 49)
        Me.btnBook.TabIndex = 0
        Me.btnBook.Text = "Create New Booking"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Location = New System.Drawing.Point(175, 150)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(155, 49)
        Me.btnSearchBook.TabIndex = 1
        Me.btnSearchBook.Text = "Search Bookings"
        Me.btnSearchBook.UseVisualStyleBackColor = True
        '
        'FrmStaffMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 448)
        Me.Controls.Add(Me.btnSearchBook)
        Me.Controls.Add(Me.btnBook)
        Me.Name = "FrmStaffMenu"
        Me.Text = "FrmStaffMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBook As Button
    Friend WithEvents btnSearchBook As Button
End Class
