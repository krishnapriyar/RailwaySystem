<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNextBook
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRebook = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking has been succesfully added. "
        '
        'btnRebook
        '
        Me.btnRebook.Location = New System.Drawing.Point(25, 99)
        Me.btnRebook.Name = "btnRebook"
        Me.btnRebook.Size = New System.Drawing.Size(106, 51)
        Me.btnRebook.TabIndex = 1
        Me.btnRebook.Text = "Rebook Another Ticket"
        Me.btnRebook.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(188, 99)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(103, 51)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Book Return Journey"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(104, 200)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(106, 45)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back To Booking"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmNextBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 270)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnRebook)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmNextBook"
        Me.Text = "Booking Added"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRebook As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnBack As Button
End Class
