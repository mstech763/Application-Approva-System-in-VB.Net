<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.ButtonLA = New System.Windows.Forms.Button()
        Me.ButtonLAP = New System.Windows.Forms.Button()
        Me.ButtonOPMA = New System.Windows.Forms.Button()
        Me.ButtonSCTRY = New System.Windows.Forms.Button()
        Me.ButtonCEOAppr = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelACCP = New System.Windows.Forms.Label()
        Me.LabelCEOP = New System.Windows.Forms.Label()
        Me.LabelSCTP = New System.Windows.Forms.Label()
        Me.LabelOPMP = New System.Windows.Forms.Label()
        Me.LoanApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeDataSet = New VBTEST.employeDataSet()
        Me.TableAdapterManager = New VBTEST.employeDataSetTableAdapters.TableAdapterManager()
        Me.LoanApprovalTableAdapter = New VBTEST.employeDataSetTableAdapters.loanApprovalTableAdapter()
        Me.LoanApprovalBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employeDataSet1 = New VBTEST.employeDataSet1()
        Me.EmployeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoanApprovalTableAdapter1 = New VBTEST.employeDataSet1TableAdapters.loanApprovalTableAdapter()
        Me.employee_perosnal_infoTableAdapter = New VBTEST.employeDataSet1TableAdapters.employee_perosnal_infoTableAdapter()
        Me.employee_perosnal_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.LoanApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanApprovalBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonLA
        '
        Me.ButtonLA.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonLA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLA.ForeColor = System.Drawing.Color.White
        Me.ButtonLA.Location = New System.Drawing.Point(12, 12)
        Me.ButtonLA.Name = "ButtonLA"
        Me.ButtonLA.Size = New System.Drawing.Size(431, 43)
        Me.ButtonLA.TabIndex = 9
        Me.ButtonLA.Text = "Loan Application"
        Me.ButtonLA.UseVisualStyleBackColor = False
        '
        'ButtonLAP
        '
        Me.ButtonLAP.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonLAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLAP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLAP.ForeColor = System.Drawing.Color.White
        Me.ButtonLAP.Location = New System.Drawing.Point(12, 61)
        Me.ButtonLAP.Name = "ButtonLAP"
        Me.ButtonLAP.Size = New System.Drawing.Size(431, 43)
        Me.ButtonLAP.TabIndex = 10
        Me.ButtonLAP.Text = "Loan Application Approval"
        Me.ButtonLAP.UseVisualStyleBackColor = False
        '
        'ButtonOPMA
        '
        Me.ButtonOPMA.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonOPMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOPMA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOPMA.ForeColor = System.Drawing.Color.White
        Me.ButtonOPMA.Location = New System.Drawing.Point(12, 110)
        Me.ButtonOPMA.Name = "ButtonOPMA"
        Me.ButtonOPMA.Size = New System.Drawing.Size(431, 43)
        Me.ButtonOPMA.TabIndex = 11
        Me.ButtonOPMA.Text = "Opr. Mngr. Approval"
        Me.ButtonOPMA.UseVisualStyleBackColor = False
        '
        'ButtonSCTRY
        '
        Me.ButtonSCTRY.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonSCTRY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSCTRY.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSCTRY.ForeColor = System.Drawing.Color.White
        Me.ButtonSCTRY.Location = New System.Drawing.Point(12, 159)
        Me.ButtonSCTRY.Name = "ButtonSCTRY"
        Me.ButtonSCTRY.Size = New System.Drawing.Size(431, 43)
        Me.ButtonSCTRY.TabIndex = 12
        Me.ButtonSCTRY.Text = "Secretary Approval"
        Me.ButtonSCTRY.UseVisualStyleBackColor = False
        '
        'ButtonCEOAppr
        '
        Me.ButtonCEOAppr.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonCEOAppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCEOAppr.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCEOAppr.ForeColor = System.Drawing.Color.White
        Me.ButtonCEOAppr.Location = New System.Drawing.Point(12, 208)
        Me.ButtonCEOAppr.Name = "ButtonCEOAppr"
        Me.ButtonCEOAppr.Size = New System.Drawing.Size(431, 43)
        Me.ButtonCEOAppr.TabIndex = 13
        Me.ButtonCEOAppr.Text = "CEO Approval"
        Me.ButtonCEOAppr.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(431, 43)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Accounts Clearance"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.LabelACCP)
        Me.GroupBox1.Controls.Add(Me.LabelCEOP)
        Me.GroupBox1.Controls.Add(Me.LabelSCTP)
        Me.GroupBox1.Controls.Add(Me.LabelOPMP)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(450, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 221)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pending Approvals"
        '
        'LabelACCP
        '
        Me.LabelACCP.AutoSize = True
        Me.LabelACCP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelACCP.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelACCP.Location = New System.Drawing.Point(6, 187)
        Me.LabelACCP.Name = "LabelACCP"
        Me.LabelACCP.Size = New System.Drawing.Size(60, 19)
        Me.LabelACCP.TabIndex = 3
        Me.LabelACCP.Text = "Label1"
        '
        'LabelCEOP
        '
        Me.LabelCEOP.AutoSize = True
        Me.LabelCEOP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCEOP.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelCEOP.Location = New System.Drawing.Point(6, 138)
        Me.LabelCEOP.Name = "LabelCEOP"
        Me.LabelCEOP.Size = New System.Drawing.Size(60, 19)
        Me.LabelCEOP.TabIndex = 2
        Me.LabelCEOP.Text = "Label1"
        '
        'LabelSCTP
        '
        Me.LabelSCTP.AutoSize = True
        Me.LabelSCTP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSCTP.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelSCTP.Location = New System.Drawing.Point(6, 89)
        Me.LabelSCTP.Name = "LabelSCTP"
        Me.LabelSCTP.Size = New System.Drawing.Size(60, 19)
        Me.LabelSCTP.TabIndex = 1
        Me.LabelSCTP.Text = "Label1"
        '
        'LabelOPMP
        '
        Me.LabelOPMP.AutoSize = True
        Me.LabelOPMP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOPMP.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelOPMP.Location = New System.Drawing.Point(6, 42)
        Me.LabelOPMP.Name = "LabelOPMP"
        Me.LabelOPMP.Size = New System.Drawing.Size(60, 19)
        Me.LabelOPMP.TabIndex = 0
        Me.LabelOPMP.Text = "Label1"
        '
        'LoanApprovalBindingSource
        '
        Me.LoanApprovalBindingSource.DataMember = "loanApproval"
        Me.LoanApprovalBindingSource.DataSource = Me.EmployeDataSet
        '
        'EmployeDataSet
        '
        Me.EmployeDataSet.DataSetName = "employeDataSet"
        Me.EmployeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.employee_perosnal_infoTableAdapter = Nothing
        Me.TableAdapterManager.loanApprovalTableAdapter = Me.LoanApprovalTableAdapter
        Me.TableAdapterManager.UpdateOrder = VBTEST.employeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LoanApprovalTableAdapter
        '
        Me.LoanApprovalTableAdapter.ClearBeforeFill = True
        '
        'LoanApprovalBindingSource1
        '
        Me.LoanApprovalBindingSource1.DataMember = "loanApproval"
        Me.LoanApprovalBindingSource1.DataSource = Me.EmployeDataSet1BindingSource
        '
        'EmployeDataSet1BindingSource
        '
        Me.EmployeDataSet1BindingSource.DataSource = Me.employeDataSet1
        Me.EmployeDataSet1BindingSource.Position = 0
        '
        'employeDataSet1
        '
        Me.employeDataSet1.DataSetName = "employeDataSet1"
        Me.employeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeDataSetBindingSource
        '
        Me.EmployeDataSetBindingSource.DataSource = Me.EmployeDataSet
        Me.EmployeDataSetBindingSource.Position = 0
        '
        'LoanApprovalTableAdapter1
        '
        Me.LoanApprovalTableAdapter1.ClearBeforeFill = True
        '
        'employee_perosnal_infoTableAdapter
        '
        Me.employee_perosnal_infoTableAdapter.ClearBeforeFill = True
        '
        'employee_perosnal_infoBindingSource
        '
        Me.employee_perosnal_infoBindingSource.DataMember = "employee_perosnal_info"
        Me.employee_perosnal_infoBindingSource.DataSource = Me.employeDataSet1
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(801, 313)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonCEOAppr)
        Me.Controls.Add(Me.ButtonSCTRY)
        Me.Controls.Add(Me.ButtonOPMA)
        Me.Controls.Add(Me.ButtonLAP)
        Me.Controls.Add(Me.ButtonLA)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LoanApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanApprovalBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonLA As Button
    Friend WithEvents ButtonLAP As Button
    Friend WithEvents ButtonOPMA As Button
    Friend WithEvents ButtonSCTRY As Button
    Friend WithEvents ButtonCEOAppr As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelOPMP As Label
    Friend WithEvents LoanApprovalBindingSource As BindingSource
    Friend WithEvents EmployeDataSet As employeDataSet
    Friend WithEvents TableAdapterManager As employeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoanApprovalTableAdapter As employeDataSetTableAdapters.loanApprovalTableAdapter
    Friend WithEvents LoanApprovalBindingSource1 As BindingSource
    Friend WithEvents EmployeDataSet1BindingSource As BindingSource
    Friend WithEvents employeDataSet1 As employeDataSet1
    Friend WithEvents EmployeDataSetBindingSource As BindingSource
    Friend WithEvents LoanApprovalTableAdapter1 As employeDataSet1TableAdapters.loanApprovalTableAdapter
    Friend WithEvents employee_perosnal_infoTableAdapter As employeDataSet1TableAdapters.employee_perosnal_infoTableAdapter
    Friend WithEvents employee_perosnal_infoBindingSource As BindingSource
    Friend WithEvents LabelACCP As Label
    Friend WithEvents LabelCEOP As Label
    Friend WithEvents LabelSCTP As Label
End Class
