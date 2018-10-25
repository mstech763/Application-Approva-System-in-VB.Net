<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ButtonFrw = New System.Windows.Forms.Button()
        Me.ButtonGen = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEN = New System.Windows.Forms.TextBox()
        Me.employee_perosnal_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employeDataSet1 = New VBTEST.employeDataSet1()
        Me.loanApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employee_perosnal_infoTableAdapter = New VBTEST.employeDataSet1TableAdapters.employee_perosnal_infoTableAdapter()
        Me.loanApprovalTableAdapter = New VBTEST.employeDataSet1TableAdapters.loanApprovalTableAdapter()
        Me.InsertData3TableAdapter1 = New VBTEST.employeDataSet1TableAdapters.insertData3TableAdapter()
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loanApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.employee_perosnal_infoBindingSource
        ReportDataSource4.Name = "DataSet2"
        ReportDataSource4.Value = Me.loanApprovalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VBTEST.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 74)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(958, 738)
        Me.ReportViewer1.TabIndex = 0
        '
        'ButtonFrw
        '
        Me.ButtonFrw.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonFrw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFrw.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFrw.ForeColor = System.Drawing.Color.White
        Me.ButtonFrw.Location = New System.Drawing.Point(628, 26)
        Me.ButtonFrw.Name = "ButtonFrw"
        Me.ButtonFrw.Size = New System.Drawing.Size(136, 28)
        Me.ButtonFrw.TabIndex = 16
        Me.ButtonFrw.Text = "Forward"
        Me.ButtonFrw.UseVisualStyleBackColor = False
        '
        'ButtonGen
        '
        Me.ButtonGen.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGen.ForeColor = System.Drawing.Color.White
        Me.ButtonGen.Location = New System.Drawing.Point(461, 26)
        Me.ButtonGen.Name = "ButtonGen"
        Me.ButtonGen.Size = New System.Drawing.Size(149, 28)
        Me.ButtonGen.TabIndex = 15
        Me.ButtonGen.Text = "Generate"
        Me.ButtonGen.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(238, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Purpose"
        '
        'TextBoxPP
        '
        Me.TextBoxPP.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TextBoxPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPP.Location = New System.Drawing.Point(238, 28)
        Me.TextBoxPP.Name = "TextBoxPP"
        Me.TextBoxPP.Size = New System.Drawing.Size(217, 26)
        Me.TextBoxPP.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(111, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Amount Required"
        '
        'TextBoxAR
        '
        Me.TextBoxAR.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TextBoxAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAR.Location = New System.Drawing.Point(111, 28)
        Me.TextBoxAR.Name = "TextBoxAR"
        Me.TextBoxAR.Size = New System.Drawing.Size(121, 26)
        Me.TextBoxAR.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "EmpNo"
        '
        'TextBoxEN
        '
        Me.TextBoxEN.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TextBoxEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxEN.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEN.Location = New System.Drawing.Point(5, 28)
        Me.TextBoxEN.Name = "TextBoxEN"
        Me.TextBoxEN.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxEN.TabIndex = 9
        '
        'employee_perosnal_infoBindingSource
        '
        Me.employee_perosnal_infoBindingSource.DataMember = "employee_perosnal_info"
        Me.employee_perosnal_infoBindingSource.DataSource = Me.employeDataSet1
        '
        'employeDataSet1
        '
        Me.employeDataSet1.DataSetName = "employeDataSet1"
        Me.employeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'loanApprovalBindingSource
        '
        Me.loanApprovalBindingSource.DataMember = "loanApproval"
        Me.loanApprovalBindingSource.DataSource = Me.employeDataSet1
        '
        'employee_perosnal_infoTableAdapter
        '
        Me.employee_perosnal_infoTableAdapter.ClearBeforeFill = True
        '
        'loanApprovalTableAdapter
        '
        Me.loanApprovalTableAdapter.ClearBeforeFill = True
        '
        'InsertData3TableAdapter1
        '
        Me.InsertData3TableAdapter1.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(958, 812)
        Me.Controls.Add(Me.ButtonFrw)
        Me.Controls.Add(Me.ButtonGen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxPP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxEN)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loanApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ButtonFrw As Button
    Friend WithEvents ButtonGen As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxAR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxEN As TextBox
    Friend WithEvents employee_perosnal_infoBindingSource As BindingSource
    Friend WithEvents employeDataSet1 As employeDataSet1
    Friend WithEvents loanApprovalBindingSource As BindingSource
    Friend WithEvents employee_perosnal_infoTableAdapter As employeDataSet1TableAdapters.employee_perosnal_infoTableAdapter
    Friend WithEvents loanApprovalTableAdapter As employeDataSet1TableAdapters.loanApprovalTableAdapter
    Friend WithEvents InsertData3TableAdapter1 As employeDataSet1TableAdapters.insertData3TableAdapter
End Class
