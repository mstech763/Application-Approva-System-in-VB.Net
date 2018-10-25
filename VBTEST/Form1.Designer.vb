<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.employee_perosnal_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employeDataSet = New VBTEST.employeDataSet()
        Me.loanApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TextBoxEN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPP = New System.Windows.Forms.TextBox()
        Me.ButtonGen = New System.Windows.Forms.Button()
        Me.ButtonFrw = New System.Windows.Forms.Button()
        Me.employee_perosnal_infoTableAdapter = New VBTEST.employeDataSetTableAdapters.employee_perosnal_infoTableAdapter()
        Me.loanApprovalTableAdapter = New VBTEST.employeDataSetTableAdapters.loanApprovalTableAdapter()
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loanApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'employee_perosnal_infoBindingSource
        '
        Me.employee_perosnal_infoBindingSource.DataMember = "employee_perosnal_info"
        Me.employee_perosnal_infoBindingSource.DataSource = Me.employeDataSet
        '
        'employeDataSet
        '
        Me.employeDataSet.DataSetName = "employeDataSet"
        Me.employeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'loanApprovalBindingSource
        '
        Me.loanApprovalBindingSource.DataMember = "loanApproval"
        Me.loanApprovalBindingSource.DataSource = Me.employeDataSet
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.employee_perosnal_infoBindingSource
        ReportDataSource4.Name = "DataSet2"
        ReportDataSource4.Value = Me.loanApprovalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VBTEST.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 57)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(831, 832)
        Me.ReportViewer1.TabIndex = 0
        '
        'TextBoxEN
        '
        Me.TextBoxEN.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TextBoxEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxEN.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEN.Location = New System.Drawing.Point(9, 25)
        Me.TextBoxEN.Name = "TextBoxEN"
        Me.TextBoxEN.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxEN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "EmpNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(115, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Amount Required"
        '
        'TextBoxAR
        '
        Me.TextBoxAR.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TextBoxAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAR.Location = New System.Drawing.Point(115, 25)
        Me.TextBoxAR.Name = "TextBoxAR"
        Me.TextBoxAR.Size = New System.Drawing.Size(121, 26)
        Me.TextBoxAR.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(242, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Purpose"
        '
        'TextBoxPP
        '
        Me.TextBoxPP.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TextBoxPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPP.Location = New System.Drawing.Point(242, 25)
        Me.TextBoxPP.Name = "TextBoxPP"
        Me.TextBoxPP.Size = New System.Drawing.Size(217, 26)
        Me.TextBoxPP.TabIndex = 5
        '
        'ButtonGen
        '
        Me.ButtonGen.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGen.ForeColor = System.Drawing.Color.White
        Me.ButtonGen.Location = New System.Drawing.Point(465, 23)
        Me.ButtonGen.Name = "ButtonGen"
        Me.ButtonGen.Size = New System.Drawing.Size(149, 28)
        Me.ButtonGen.TabIndex = 7
        Me.ButtonGen.Text = "Generate"
        Me.ButtonGen.UseVisualStyleBackColor = False
        '
        'ButtonFrw
        '
        Me.ButtonFrw.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonFrw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFrw.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFrw.ForeColor = System.Drawing.Color.White
        Me.ButtonFrw.Location = New System.Drawing.Point(632, 23)
        Me.ButtonFrw.Name = "ButtonFrw"
        Me.ButtonFrw.Size = New System.Drawing.Size(136, 28)
        Me.ButtonFrw.TabIndex = 8
        Me.ButtonFrw.Text = "Forward"
        Me.ButtonFrw.UseVisualStyleBackColor = False
        '
        'employee_perosnal_infoTableAdapter
        '
        Me.employee_perosnal_infoTableAdapter.ClearBeforeFill = True
        '
        'loanApprovalTableAdapter
        '
        Me.loanApprovalTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(854, 901)
        Me.Controls.Add(Me.ButtonFrw)
        Me.Controls.Add(Me.ButtonGen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxPP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxEN)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loanApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents employee_perosnal_infoBindingSource As BindingSource
    Friend WithEvents employeDataSet As employeDataSet
    Friend WithEvents loanApprovalBindingSource As BindingSource
    Friend WithEvents employee_perosnal_infoTableAdapter As employeDataSetTableAdapters.employee_perosnal_infoTableAdapter
    Friend WithEvents loanApprovalTableAdapter As employeDataSetTableAdapters.loanApprovalTableAdapter
    Friend WithEvents TextBoxEN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxAR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPP As TextBox
    Friend WithEvents ButtonGen As Button
    Friend WithEvents ButtonFrw As Button
End Class
