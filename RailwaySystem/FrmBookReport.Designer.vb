<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBookReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.railDataSet = New RailwaySystem.railDataSet()
        Me.BookingRepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingRepTableAdapter = New RailwaySystem.railDataSetTableAdapters.BookingRepTableAdapter()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.brnGen = New System.Windows.Forms.Button()
        CType(Me.railDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingRepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "BookingDS1"
        ReportDataSource2.Value = Me.BookingRepBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RailwaySystem.BookingReport1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 120)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(729, 462)
        Me.ReportViewer1.TabIndex = 0
        '
        'railDataSet
        '
        Me.railDataSet.DataSetName = "railDataSet"
        Me.railDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingRepBindingSource
        '
        Me.BookingRepBindingSource.DataMember = "BookingRep"
        Me.BookingRepBindingSource.DataSource = Me.railDataSet
        '
        'BookingRepTableAdapter
        '
        Me.BookingRepTableAdapter.ClearBeforeFill = True
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(32, 48)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(82, 13)
        Me.lblMonth.TabIndex = 1
        Me.lblMonth.Text = "Choose Period :"
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(134, 45)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(144, 21)
        Me.cboMonth.TabIndex = 2
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2018"})
        Me.cboYear.Location = New System.Drawing.Point(295, 45)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(125, 21)
        Me.cboYear.TabIndex = 3
        '
        'brnGen
        '
        Me.brnGen.Location = New System.Drawing.Point(444, 42)
        Me.brnGen.Name = "brnGen"
        Me.brnGen.Size = New System.Drawing.Size(75, 23)
        Me.brnGen.TabIndex = 4
        Me.brnGen.Text = "Generate Report"
        Me.brnGen.UseVisualStyleBackColor = True
        '
        'FrmBookReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 630)
        Me.Controls.Add(Me.brnGen)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmBookReport"
        Me.Text = "FrmBookReport"
        CType(Me.railDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingRepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BookingRepBindingSource As BindingSource
    Friend WithEvents railDataSet As railDataSet
    Friend WithEvents BookingRepTableAdapter As railDataSetTableAdapters.BookingRepTableAdapter
    Friend WithEvents lblMonth As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents brnGen As Button
End Class
