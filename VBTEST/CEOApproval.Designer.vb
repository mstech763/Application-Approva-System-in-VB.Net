<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CEOApproval
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
        Dim ReportDataSource13 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.LaempNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaempDepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaempDesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaempDateOfAppointmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaempPicDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.LamonthlyEarnigDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaammountReuiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LapurposeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LagratuityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LainstallmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaempSoDoWoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaoperationManagerApprovalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaomaDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LacompanySecretaryApprovalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LacsaDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaceoApprovalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaceoaDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LacashPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPageApproved = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LaidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoanApprovalBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employeDataSet1 = New VBTEST.employeDataSet1()
        Me.LapreparedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LaempNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoanApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeDataSet = New VBTEST.employeDataSet()
        Me.LoanApprovalTableAdapter1 = New VBTEST.employeDataSet1TableAdapters.loanApprovalTableAdapter()
        Me.employee_perosnal_infoTableAdapter = New VBTEST.employeDataSet1TableAdapters.employee_perosnal_infoTableAdapter()
        Me.employee_perosnal_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New VBTEST.employeDataSetTableAdapters.TableAdapterManager()
        Me.LoanApprovalTableAdapter = New VBTEST.employeDataSetTableAdapters.loanApprovalTableAdapter()
        Me.EmployeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.La_commentTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonComment = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPagePending = New System.Windows.Forms.TabPage()
        Me.LoanApprovalDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonApprove = New System.Windows.Forms.Button()
        Me.TabPageApproved.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanApprovalBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPagePending.SuspendLayout()
        CType(Me.LoanApprovalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LaempNameDataGridViewTextBoxColumn
        '
        Me.LaempNameDataGridViewTextBoxColumn.DataPropertyName = "la_empName"
        Me.LaempNameDataGridViewTextBoxColumn.HeaderText = "la_empName"
        Me.LaempNameDataGridViewTextBoxColumn.Name = "LaempNameDataGridViewTextBoxColumn"
        '
        'LaempDepartmentDataGridViewTextBoxColumn
        '
        Me.LaempDepartmentDataGridViewTextBoxColumn.DataPropertyName = "la_empDepartment"
        Me.LaempDepartmentDataGridViewTextBoxColumn.HeaderText = "la_empDepartment"
        Me.LaempDepartmentDataGridViewTextBoxColumn.Name = "LaempDepartmentDataGridViewTextBoxColumn"
        '
        'LaempDesignationDataGridViewTextBoxColumn
        '
        Me.LaempDesignationDataGridViewTextBoxColumn.DataPropertyName = "la_empDesignation"
        Me.LaempDesignationDataGridViewTextBoxColumn.HeaderText = "la_empDesignation"
        Me.LaempDesignationDataGridViewTextBoxColumn.Name = "LaempDesignationDataGridViewTextBoxColumn"
        '
        'LaempDateOfAppointmentDataGridViewTextBoxColumn
        '
        Me.LaempDateOfAppointmentDataGridViewTextBoxColumn.DataPropertyName = "la_empDateOfAppointment"
        Me.LaempDateOfAppointmentDataGridViewTextBoxColumn.HeaderText = "la_empDateOfAppointment"
        Me.LaempDateOfAppointmentDataGridViewTextBoxColumn.Name = "LaempDateOfAppointmentDataGridViewTextBoxColumn"
        '
        'LaempPicDataGridViewImageColumn
        '
        Me.LaempPicDataGridViewImageColumn.DataPropertyName = "la_empPic"
        Me.LaempPicDataGridViewImageColumn.HeaderText = "la_empPic"
        Me.LaempPicDataGridViewImageColumn.Name = "LaempPicDataGridViewImageColumn"
        '
        'LamonthlyEarnigDataGridViewTextBoxColumn
        '
        Me.LamonthlyEarnigDataGridViewTextBoxColumn.DataPropertyName = "la_monthlyEarnig"
        Me.LamonthlyEarnigDataGridViewTextBoxColumn.HeaderText = "la_monthlyEarnig"
        Me.LamonthlyEarnigDataGridViewTextBoxColumn.Name = "LamonthlyEarnigDataGridViewTextBoxColumn"
        '
        'LaammountReuiredDataGridViewTextBoxColumn
        '
        Me.LaammountReuiredDataGridViewTextBoxColumn.DataPropertyName = "la_ammountReuired"
        Me.LaammountReuiredDataGridViewTextBoxColumn.HeaderText = "la_ammountReuired"
        Me.LaammountReuiredDataGridViewTextBoxColumn.Name = "LaammountReuiredDataGridViewTextBoxColumn"
        '
        'LapurposeDataGridViewTextBoxColumn
        '
        Me.LapurposeDataGridViewTextBoxColumn.DataPropertyName = "la_purpose"
        Me.LapurposeDataGridViewTextBoxColumn.HeaderText = "la_purpose"
        Me.LapurposeDataGridViewTextBoxColumn.Name = "LapurposeDataGridViewTextBoxColumn"
        '
        'LagratuityDataGridViewTextBoxColumn
        '
        Me.LagratuityDataGridViewTextBoxColumn.DataPropertyName = "la_gratuity"
        Me.LagratuityDataGridViewTextBoxColumn.HeaderText = "la_gratuity"
        Me.LagratuityDataGridViewTextBoxColumn.Name = "LagratuityDataGridViewTextBoxColumn"
        '
        'LainstallmentDataGridViewTextBoxColumn
        '
        Me.LainstallmentDataGridViewTextBoxColumn.DataPropertyName = "la_installment"
        Me.LainstallmentDataGridViewTextBoxColumn.HeaderText = "la_installment"
        Me.LainstallmentDataGridViewTextBoxColumn.Name = "LainstallmentDataGridViewTextBoxColumn"
        '
        'LaempSoDoWoDataGridViewTextBoxColumn
        '
        Me.LaempSoDoWoDataGridViewTextBoxColumn.DataPropertyName = "la_empSoDoWo"
        Me.LaempSoDoWoDataGridViewTextBoxColumn.HeaderText = "la_empSoDoWo"
        Me.LaempSoDoWoDataGridViewTextBoxColumn.Name = "LaempSoDoWoDataGridViewTextBoxColumn"
        '
        'LabalanceDataGridViewTextBoxColumn
        '
        Me.LabalanceDataGridViewTextBoxColumn.DataPropertyName = "la_balance"
        Me.LabalanceDataGridViewTextBoxColumn.HeaderText = "la_balance"
        Me.LabalanceDataGridViewTextBoxColumn.Name = "LabalanceDataGridViewTextBoxColumn"
        '
        'LaoperationManagerApprovalDataGridViewTextBoxColumn
        '
        Me.LaoperationManagerApprovalDataGridViewTextBoxColumn.DataPropertyName = "la_operationManagerApproval"
        Me.LaoperationManagerApprovalDataGridViewTextBoxColumn.HeaderText = "la_operationManagerApproval"
        Me.LaoperationManagerApprovalDataGridViewTextBoxColumn.Name = "LaoperationManagerApprovalDataGridViewTextBoxColumn"
        '
        'LaomaDateDataGridViewTextBoxColumn
        '
        Me.LaomaDateDataGridViewTextBoxColumn.DataPropertyName = "la_omaDate"
        Me.LaomaDateDataGridViewTextBoxColumn.HeaderText = "la_omaDate"
        Me.LaomaDateDataGridViewTextBoxColumn.Name = "LaomaDateDataGridViewTextBoxColumn"
        '
        'LacompanySecretaryApprovalDataGridViewTextBoxColumn
        '
        Me.LacompanySecretaryApprovalDataGridViewTextBoxColumn.DataPropertyName = "la_companySecretaryApproval"
        Me.LacompanySecretaryApprovalDataGridViewTextBoxColumn.HeaderText = "la_companySecretaryApproval"
        Me.LacompanySecretaryApprovalDataGridViewTextBoxColumn.Name = "LacompanySecretaryApprovalDataGridViewTextBoxColumn"
        '
        'LacsaDateDataGridViewTextBoxColumn
        '
        Me.LacsaDateDataGridViewTextBoxColumn.DataPropertyName = "la_csaDate"
        Me.LacsaDateDataGridViewTextBoxColumn.HeaderText = "la_csaDate"
        Me.LacsaDateDataGridViewTextBoxColumn.Name = "LacsaDateDataGridViewTextBoxColumn"
        '
        'LaceoApprovalDataGridViewTextBoxColumn
        '
        Me.LaceoApprovalDataGridViewTextBoxColumn.DataPropertyName = "la_ceoApproval"
        Me.LaceoApprovalDataGridViewTextBoxColumn.HeaderText = "la_ceoApproval"
        Me.LaceoApprovalDataGridViewTextBoxColumn.Name = "LaceoApprovalDataGridViewTextBoxColumn"
        '
        'LaceoaDateDataGridViewTextBoxColumn
        '
        Me.LaceoaDateDataGridViewTextBoxColumn.DataPropertyName = "la_ceoaDate"
        Me.LaceoaDateDataGridViewTextBoxColumn.HeaderText = "la_ceoaDate"
        Me.LaceoaDateDataGridViewTextBoxColumn.Name = "LaceoaDateDataGridViewTextBoxColumn"
        '
        'LacashPaidDataGridViewTextBoxColumn
        '
        Me.LacashPaidDataGridViewTextBoxColumn.DataPropertyName = "la_cashPaid"
        Me.LacashPaidDataGridViewTextBoxColumn.HeaderText = "la_cashPaid"
        Me.LacashPaidDataGridViewTextBoxColumn.Name = "LacashPaidDataGridViewTextBoxColumn"
        '
        'TabPageApproved
        '
        Me.TabPageApproved.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPageApproved.Controls.Add(Me.DataGridView1)
        Me.TabPageApproved.Location = New System.Drawing.Point(4, 25)
        Me.TabPageApproved.Name = "TabPageApproved"
        Me.TabPageApproved.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageApproved.Size = New System.Drawing.Size(152, 839)
        Me.TabPageApproved.TabIndex = 1
        Me.TabPageApproved.Text = "APPROVED"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LaidDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.LoanApprovalBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(152, 839)
        Me.DataGridView1.TabIndex = 1
        '
        'LaidDataGridViewTextBoxColumn1
        '
        Me.LaidDataGridViewTextBoxColumn1.DataPropertyName = "la_id"
        Me.LaidDataGridViewTextBoxColumn1.HeaderText = "Apr. PO(s)"
        Me.LaidDataGridViewTextBoxColumn1.Name = "LaidDataGridViewTextBoxColumn1"
        Me.LaidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.LaidDataGridViewTextBoxColumn1.Width = 150
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
        'LapreparedByDataGridViewTextBoxColumn
        '
        Me.LapreparedByDataGridViewTextBoxColumn.DataPropertyName = "la_preparedBy"
        Me.LapreparedByDataGridViewTextBoxColumn.HeaderText = "la_preparedBy"
        Me.LapreparedByDataGridViewTextBoxColumn.Name = "LapreparedByDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-4, -7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(980, 57)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Loan Application Approval - Company Secretary"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LaempNoDataGridViewTextBoxColumn
        '
        Me.LaempNoDataGridViewTextBoxColumn.DataPropertyName = "la_empNo"
        Me.LaempNoDataGridViewTextBoxColumn.HeaderText = "la_empNo"
        Me.LaempNoDataGridViewTextBoxColumn.Name = "LaempNoDataGridViewTextBoxColumn"
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
        'EmployeDataSetBindingSource
        '
        Me.EmployeDataSetBindingSource.DataSource = Me.EmployeDataSet
        Me.EmployeDataSetBindingSource.Position = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.La_commentTextBox)
        Me.GroupBox1.Controls.Add(Me.ButtonCancel)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(638, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 199)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comment"
        Me.GroupBox1.Visible = False
        '
        'La_commentTextBox
        '
        Me.La_commentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanApprovalBindingSource, "la_comment", True))
        Me.La_commentTextBox.Location = New System.Drawing.Point(21, 30)
        Me.La_commentTextBox.Multiline = True
        Me.La_commentTextBox.Name = "La_commentTextBox"
        Me.La_commentTextBox.Size = New System.Drawing.Size(290, 112)
        Me.La_commentTextBox.TabIndex = 3
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Location = New System.Drawing.Point(169, 148)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(142, 31)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(21, 148)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(142, 31)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "SAVE"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonComment
        '
        Me.ButtonComment.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonComment.FlatAppearance.BorderSize = 3
        Me.ButtonComment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonComment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonComment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonComment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonComment.ForeColor = System.Drawing.Color.White
        Me.ButtonComment.Location = New System.Drawing.Point(810, 45)
        Me.ButtonComment.Name = "ButtonComment"
        Me.ButtonComment.Size = New System.Drawing.Size(160, 50)
        Me.ButtonComment.TabIndex = 16
        Me.ButtonComment.Text = "COMMENT"
        Me.ButtonComment.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        ReportDataSource13.Name = "DataSet2"
        ReportDataSource13.Value = Me.LoanApprovalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource13)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VBTEST.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(158, 94)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(812, 819)
        Me.ReportViewer1.TabIndex = 14
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPagePending)
        Me.TabControl1.Controls.Add(Me.TabPageApproved)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-4, 45)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(160, 868)
        Me.TabControl1.TabIndex = 13
        '
        'TabPagePending
        '
        Me.TabPagePending.AutoScroll = True
        Me.TabPagePending.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPagePending.Controls.Add(Me.LoanApprovalDataGridView)
        Me.TabPagePending.Location = New System.Drawing.Point(4, 25)
        Me.TabPagePending.Name = "TabPagePending"
        Me.TabPagePending.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePending.Size = New System.Drawing.Size(152, 839)
        Me.TabPagePending.TabIndex = 0
        Me.TabPagePending.Text = "PENDING"
        '
        'LoanApprovalDataGridView
        '
        Me.LoanApprovalDataGridView.AllowUserToResizeColumns = False
        Me.LoanApprovalDataGridView.AllowUserToResizeRows = False
        Me.LoanApprovalDataGridView.AutoGenerateColumns = False
        Me.LoanApprovalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LoanApprovalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.LaidDataGridViewTextBoxColumn, Me.LaempNoDataGridViewTextBoxColumn, Me.LaempNameDataGridViewTextBoxColumn, Me.LaempSoDoWoDataGridViewTextBoxColumn, Me.LaempDepartmentDataGridViewTextBoxColumn, Me.LaempDesignationDataGridViewTextBoxColumn, Me.LaempDateOfAppointmentDataGridViewTextBoxColumn, Me.LaempPicDataGridViewImageColumn, Me.LamonthlyEarnigDataGridViewTextBoxColumn, Me.LaammountReuiredDataGridViewTextBoxColumn, Me.LapurposeDataGridViewTextBoxColumn, Me.LagratuityDataGridViewTextBoxColumn, Me.LainstallmentDataGridViewTextBoxColumn, Me.LabalanceDataGridViewTextBoxColumn, Me.LapreparedByDataGridViewTextBoxColumn, Me.LaoperationManagerApprovalDataGridViewTextBoxColumn, Me.LaomaDateDataGridViewTextBoxColumn, Me.LacompanySecretaryApprovalDataGridViewTextBoxColumn, Me.LacsaDateDataGridViewTextBoxColumn, Me.LaceoApprovalDataGridViewTextBoxColumn, Me.LaceoaDateDataGridViewTextBoxColumn, Me.LacashPaidDataGridViewTextBoxColumn})
        Me.LoanApprovalDataGridView.DataSource = Me.LoanApprovalBindingSource1
        Me.LoanApprovalDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.LoanApprovalDataGridView.Name = "LoanApprovalDataGridView"
        Me.LoanApprovalDataGridView.RowHeadersVisible = False
        Me.LoanApprovalDataGridView.Size = New System.Drawing.Size(152, 839)
        Me.LoanApprovalDataGridView.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "la_id"
        Me.Column1.HeaderText = "Pnd. PO(s)"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'LaidDataGridViewTextBoxColumn
        '
        Me.LaidDataGridViewTextBoxColumn.DataPropertyName = "la_id"
        Me.LaidDataGridViewTextBoxColumn.HeaderText = "la_id"
        Me.LaidDataGridViewTextBoxColumn.Name = "LaidDataGridViewTextBoxColumn"
        Me.LaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ButtonApprove
        '
        Me.ButtonApprove.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonApprove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonApprove.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.ButtonApprove.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonApprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonApprove.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonApprove.ForeColor = System.Drawing.Color.White
        Me.ButtonApprove.Location = New System.Drawing.Point(158, 45)
        Me.ButtonApprove.Name = "ButtonApprove"
        Me.ButtonApprove.Size = New System.Drawing.Size(660, 50)
        Me.ButtonApprove.TabIndex = 15
        Me.ButtonApprove.Text = "APPROVE"
        Me.ButtonApprove.UseVisualStyleBackColor = False
        '
        'CEOApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(970, 911)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonApprove)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonComment)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CEOApproval"
        Me.Text = "CEOApproval"
        Me.TabPageApproved.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanApprovalBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPagePending.ResumeLayout(False)
        CType(Me.LoanApprovalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LaempNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaempDepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaempDesignationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaempDateOfAppointmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaempPicDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents LamonthlyEarnigDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaammountReuiredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LapurposeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LagratuityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LainstallmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaempSoDoWoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaoperationManagerApprovalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaomaDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LacompanySecretaryApprovalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LacsaDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaceoApprovalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaceoaDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LacashPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TabPageApproved As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LaidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LoanApprovalBindingSource1 As BindingSource
    Friend WithEvents EmployeDataSet1BindingSource As BindingSource
    Friend WithEvents employeDataSet1 As employeDataSet1
    Friend WithEvents LapreparedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents LaempNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoanApprovalBindingSource As BindingSource
    Friend WithEvents EmployeDataSet As employeDataSet
    Friend WithEvents LoanApprovalTableAdapter1 As employeDataSet1TableAdapters.loanApprovalTableAdapter
    Friend WithEvents employee_perosnal_infoTableAdapter As employeDataSet1TableAdapters.employee_perosnal_infoTableAdapter
    Friend WithEvents employee_perosnal_infoBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As employeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoanApprovalTableAdapter As employeDataSetTableAdapters.loanApprovalTableAdapter
    Friend WithEvents EmployeDataSetBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents La_commentTextBox As TextBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonComment As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPagePending As TabPage
    Friend WithEvents LoanApprovalDataGridView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents LaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonApprove As Button
End Class
