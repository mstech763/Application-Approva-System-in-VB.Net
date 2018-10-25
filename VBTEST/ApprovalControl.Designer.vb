<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApprovalControl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.LoanApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeDataSet = New VBTEST.employeDataSet()
        Me.LoanApprovalDataGridView = New System.Windows.Forms.DataGridView()
        Me.LoanApprovalBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ButtonApprove = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.La_commentTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.EmployeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoanApprovalTableAdapter = New VBTEST.employeDataSetTableAdapters.loanApprovalTableAdapter()
        Me.TableAdapterManager = New VBTEST.employeDataSetTableAdapters.TableAdapterManager()
        Me.CheckBoxOPM = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSCT = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCEO = New System.Windows.Forms.CheckBox()
        Me.approve = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAccounts = New System.Windows.Forms.CheckBox()
        Me.ButtonSaveCash = New System.Windows.Forms.Button()
        Me.TextBoxCashP = New System.Windows.Forms.TextBox()
        Me.EmployeDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employeDataSet1 = New VBTEST.employeDataSet1()
        Me.employee_perosnal_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employee_perosnal_infoTableAdapter = New VBTEST.employeDataSet1TableAdapters.employee_perosnal_infoTableAdapter()
        Me.LoanApprovalTableAdapter1 = New VBTEST.employeDataSet1TableAdapters.loanApprovalTableAdapter()
        CType(Me.LoanApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanApprovalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanApprovalBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmployeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'LoanApprovalDataGridView
        '
        Me.LoanApprovalDataGridView.AllowUserToAddRows = False
        Me.LoanApprovalDataGridView.AllowUserToDeleteRows = False
        Me.LoanApprovalDataGridView.AllowUserToResizeColumns = False
        Me.LoanApprovalDataGridView.AllowUserToResizeRows = False
        Me.LoanApprovalDataGridView.AutoGenerateColumns = False
        Me.LoanApprovalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LoanApprovalDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.LoanApprovalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LoanApprovalDataGridView.DataSource = Me.EmployeDataSet1BindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LoanApprovalDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.LoanApprovalDataGridView.Location = New System.Drawing.Point(12, 66)
        Me.LoanApprovalDataGridView.Name = "LoanApprovalDataGridView"
        Me.LoanApprovalDataGridView.ReadOnly = True
        Me.LoanApprovalDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanApprovalDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.LoanApprovalDataGridView.ShowEditingIcon = False
        Me.LoanApprovalDataGridView.Size = New System.Drawing.Size(107, 823)
        Me.LoanApprovalDataGridView.TabIndex = 0
        '
        'LoanApprovalBindingSource1
        '
        Me.LoanApprovalBindingSource1.DataMember = "loanApproval"
        Me.LoanApprovalBindingSource1.DataSource = Me.EmployeDataSet1BindingSource
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.LoanApprovalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VBTEST.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(125, 66)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(717, 823)
        Me.ReportViewer1.TabIndex = 1
        '
        'ButtonApprove
        '
        Me.ButtonApprove.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonApprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonApprove.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonApprove.ForeColor = System.Drawing.Color.White
        Me.ButtonApprove.Location = New System.Drawing.Point(452, 4)
        Me.ButtonApprove.Name = "ButtonApprove"
        Me.ButtonApprove.Size = New System.Drawing.Size(95, 51)
        Me.ButtonApprove.TabIndex = 2
        Me.ButtonApprove.Text = "Approve"
        Me.ButtonApprove.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel1.Location = New System.Drawing.Point(377, 39)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 16)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Comment"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.La_commentTextBox)
        Me.GroupBox1.Controls.Add(Me.ButtonCancel)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.ForestGreen
        Me.GroupBox1.Location = New System.Drawing.Point(510, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 199)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comment"
        Me.GroupBox1.Visible = False
        '
        'La_commentTextBox
        '
        Me.La_commentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanApprovalBindingSource, "la_comment", True))
        Me.La_commentTextBox.Location = New System.Drawing.Point(21, 21)
        Me.La_commentTextBox.Multiline = True
        Me.La_commentTextBox.Name = "La_commentTextBox"
        Me.La_commentTextBox.Size = New System.Drawing.Size(290, 121)
        Me.La_commentTextBox.TabIndex = 3
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.ForestGreen
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
        Me.ButtonSave.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(21, 148)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(142, 31)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "SAVE"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'EmployeDataSetBindingSource
        '
        Me.EmployeDataSetBindingSource.DataSource = Me.EmployeDataSet
        Me.EmployeDataSetBindingSource.Position = 0
        '
        'LoanApprovalTableAdapter
        '
        Me.LoanApprovalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.employee_perosnal_infoTableAdapter = Nothing
        Me.TableAdapterManager.loanApprovalTableAdapter = Me.LoanApprovalTableAdapter
        Me.TableAdapterManager.UpdateOrder = VBTEST.employeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CheckBoxOPM
        '
        Me.CheckBoxOPM.AutoSize = True
        Me.CheckBoxOPM.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOPM.ForeColor = System.Drawing.Color.White
        Me.CheckBoxOPM.Location = New System.Drawing.Point(13, 20)
        Me.CheckBoxOPM.Name = "CheckBoxOPM"
        Me.CheckBoxOPM.Size = New System.Drawing.Size(97, 20)
        Me.CheckBoxOPM.TabIndex = 9
        Me.CheckBoxOPM.Text = "OPM Login"
        Me.CheckBoxOPM.UseVisualStyleBackColor = True
        '
        'CheckBoxSCT
        '
        Me.CheckBoxSCT.AutoSize = True
        Me.CheckBoxSCT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSCT.ForeColor = System.Drawing.Color.White
        Me.CheckBoxSCT.Location = New System.Drawing.Point(125, 20)
        Me.CheckBoxSCT.Name = "CheckBoxSCT"
        Me.CheckBoxSCT.Size = New System.Drawing.Size(93, 20)
        Me.CheckBoxSCT.TabIndex = 10
        Me.CheckBoxSCT.Text = "SCT Login"
        Me.CheckBoxSCT.UseVisualStyleBackColor = True
        '
        'CheckBoxCEO
        '
        Me.CheckBoxCEO.AutoSize = True
        Me.CheckBoxCEO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCEO.ForeColor = System.Drawing.Color.White
        Me.CheckBoxCEO.Location = New System.Drawing.Point(242, 20)
        Me.CheckBoxCEO.Name = "CheckBoxCEO"
        Me.CheckBoxCEO.Size = New System.Drawing.Size(94, 20)
        Me.CheckBoxCEO.TabIndex = 11
        Me.CheckBoxCEO.Text = "CEO Login"
        Me.CheckBoxCEO.UseVisualStyleBackColor = True
        '
        'approve
        '
        Me.approve.AutoSize = True
        Me.approve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.approve.ForeColor = System.Drawing.Color.White
        Me.approve.Location = New System.Drawing.Point(359, 20)
        Me.approve.Name = "approve"
        Me.approve.Size = New System.Drawing.Size(86, 20)
        Me.approve.TabIndex = 12
        Me.approve.Text = "Approve"
        Me.approve.UseVisualStyleBackColor = True
        '
        'CheckBoxAccounts
        '
        Me.CheckBoxAccounts.AutoSize = True
        Me.CheckBoxAccounts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAccounts.ForeColor = System.Drawing.Color.White
        Me.CheckBoxAccounts.Location = New System.Drawing.Point(553, 20)
        Me.CheckBoxAccounts.Name = "CheckBoxAccounts"
        Me.CheckBoxAccounts.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxAccounts.TabIndex = 13
        Me.CheckBoxAccounts.Text = "Accounts"
        Me.CheckBoxAccounts.UseVisualStyleBackColor = True
        '
        'ButtonSaveCash
        '
        Me.ButtonSaveCash.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonSaveCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSaveCash.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveCash.ForeColor = System.Drawing.Color.White
        Me.ButtonSaveCash.Location = New System.Drawing.Point(698, 34)
        Me.ButtonSaveCash.Name = "ButtonSaveCash"
        Me.ButtonSaveCash.Size = New System.Drawing.Size(144, 31)
        Me.ButtonSaveCash.TabIndex = 14
        Me.ButtonSaveCash.Text = "Save"
        Me.ButtonSaveCash.UseVisualStyleBackColor = False
        Me.ButtonSaveCash.Visible = False
        '
        'TextBoxCashP
        '
        Me.TextBoxCashP.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCashP.Location = New System.Drawing.Point(698, 7)
        Me.TextBoxCashP.Multiline = True
        Me.TextBoxCashP.Name = "TextBoxCashP"
        Me.TextBoxCashP.Size = New System.Drawing.Size(144, 26)
        Me.TextBoxCashP.TabIndex = 15
        Me.TextBoxCashP.Visible = False
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
        'employee_perosnal_infoBindingSource
        '
        Me.employee_perosnal_infoBindingSource.DataMember = "employee_perosnal_info"
        Me.employee_perosnal_infoBindingSource.DataSource = Me.employeDataSet1
        '
        'employee_perosnal_infoTableAdapter
        '
        Me.employee_perosnal_infoTableAdapter.ClearBeforeFill = True
        '
        'LoanApprovalTableAdapter1
        '
        Me.LoanApprovalTableAdapter1.ClearBeforeFill = True
        '
        'ApprovalControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(864, 909)
        Me.Controls.Add(Me.TextBoxCashP)
        Me.Controls.Add(Me.ButtonSaveCash)
        Me.Controls.Add(Me.CheckBoxAccounts)
        Me.Controls.Add(Me.approve)
        Me.Controls.Add(Me.CheckBoxCEO)
        Me.Controls.Add(Me.CheckBoxSCT)
        Me.Controls.Add(Me.CheckBoxOPM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ButtonApprove)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.LoanApprovalDataGridView)
        Me.Name = "ApprovalControl"
        Me.Text = "ApprovalControl"
        CType(Me.LoanApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanApprovalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanApprovalBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmployeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmployeDataSetBindingSource As BindingSource
    Friend WithEvents EmployeDataSet As employeDataSet
    Friend WithEvents LoanApprovalBindingSource As BindingSource
    Friend WithEvents LoanApprovalTableAdapter As employeDataSetTableAdapters.loanApprovalTableAdapter
    Friend WithEvents TableAdapterManager As employeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoanApprovalDataGridView As DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents employee_perosnal_infoBindingSource As BindingSource
    Friend WithEvents employeDataSet1 As employeDataSet1
    Friend WithEvents employee_perosnal_infoTableAdapter As employeDataSet1TableAdapters.employee_perosnal_infoTableAdapter
    Friend WithEvents EmployeDataSet1BindingSource As BindingSource
    Friend WithEvents LoanApprovalBindingSource1 As BindingSource
    Friend WithEvents LoanApprovalTableAdapter1 As employeDataSet1TableAdapters.loanApprovalTableAdapter
    Friend WithEvents ButtonApprove As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents La_commentTextBox As TextBox
    Friend WithEvents CheckBoxOPM As CheckBox
    Friend WithEvents CheckBoxSCT As CheckBox
    Friend WithEvents CheckBoxCEO As CheckBox
    Friend WithEvents approve As CheckBox
    Friend WithEvents CheckBoxAccounts As CheckBox
    Friend WithEvents ButtonSaveCash As Button
    Friend WithEvents TextBoxCashP As TextBox
End Class
