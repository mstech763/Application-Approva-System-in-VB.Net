<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OPM_Approval
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
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPagePending = New System.Windows.Forms.TabPage()
        Me.LoanApprovalDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPageApproved = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ButtonApprove = New System.Windows.Forms.Button()
        Me.ButtonComment = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.EmployeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeDataSet = New VBTEST.employeDataSet()
        Me.LoanApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoanApprovalBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employeDataSet1 = New VBTEST.employeDataSet1()
        Me.LoanApprovalTableAdapter = New VBTEST.employeDataSetTableAdapters.loanApprovalTableAdapter()
        Me.TableAdapterManager = New VBTEST.employeDataSetTableAdapters.TableAdapterManager()
        Me.employee_perosnal_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employee_perosnal_infoTableAdapter = New VBTEST.employeDataSet1TableAdapters.employee_perosnal_infoTableAdapter()
        Me.LoanApprovalTableAdapter1 = New VBTEST.employeDataSet1TableAdapters.loanApprovalTableAdapter()
        Me.LaidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.La_commentTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPagePending.SuspendLayout()
        CType(Me.LoanApprovalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageApproved.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmployeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanApprovalBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-4, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(980, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Loan Application Approval Opt. Mngr."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPagePending)
        Me.TabControl1.Controls.Add(Me.TabPageApproved)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-4, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(160, 868)
        Me.TabControl1.TabIndex = 1
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
        Me.LoanApprovalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.LoanApprovalDataGridView.DataSource = Me.LoanApprovalBindingSource1
        Me.LoanApprovalDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.LoanApprovalDataGridView.Name = "LoanApprovalDataGridView"
        Me.LoanApprovalDataGridView.RowHeadersVisible = False
        Me.LoanApprovalDataGridView.Size = New System.Drawing.Size(152, 839)
        Me.LoanApprovalDataGridView.TabIndex = 0
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
        'ReportViewer1
        '
        ReportDataSource4.Name = "DataSet2"
        ReportDataSource4.Value = Me.LoanApprovalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VBTEST.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(158, 95)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(812, 819)
        Me.ReportViewer1.TabIndex = 2
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
        Me.ButtonApprove.Location = New System.Drawing.Point(158, 46)
        Me.ButtonApprove.Name = "ButtonApprove"
        Me.ButtonApprove.Size = New System.Drawing.Size(656, 50)
        Me.ButtonApprove.TabIndex = 3
        Me.ButtonApprove.Text = "APPROVE"
        Me.ButtonApprove.UseVisualStyleBackColor = False
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
        Me.ButtonComment.Location = New System.Drawing.Point(810, 46)
        Me.ButtonComment.Name = "ButtonComment"
        Me.ButtonComment.Size = New System.Drawing.Size(160, 50)
        Me.ButtonComment.TabIndex = 4
        Me.ButtonComment.Text = "COMMENT"
        Me.ButtonComment.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.La_commentTextBox)
        Me.GroupBox1.Controls.Add(Me.ButtonCancel)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(638, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 199)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comment"
        Me.GroupBox1.Visible = False
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
        'EmployeDataSetBindingSource
        '
        Me.EmployeDataSetBindingSource.DataSource = Me.EmployeDataSet
        Me.EmployeDataSetBindingSource.Position = 0
        '
        'EmployeDataSet
        '
        Me.EmployeDataSet.DataSetName = "employeDataSet"
        Me.EmployeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoanApprovalBindingSource
        '
        Me.LoanApprovalBindingSource.DataMember = "loanApproval"
        Me.LoanApprovalBindingSource.DataSource = Me.EmployeDataSet
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
        'LaidDataGridViewTextBoxColumn1
        '
        Me.LaidDataGridViewTextBoxColumn1.DataPropertyName = "la_id"
        Me.LaidDataGridViewTextBoxColumn1.HeaderText = "Apr. PO(s)"
        Me.LaidDataGridViewTextBoxColumn1.Name = "LaidDataGridViewTextBoxColumn1"
        Me.LaidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.LaidDataGridViewTextBoxColumn1.Width = 150
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "la_id"
        Me.Column1.HeaderText = "Pnd. PO(s)"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
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
        'OPM_Approval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(973, 914)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonComment)
        Me.Controls.Add(Me.ButtonApprove)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "OPM_Approval"
        Me.Text = "Loan Application Approval - Operations Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPagePending.ResumeLayout(False)
        CType(Me.LoanApprovalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageApproved.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmployeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanApprovalBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employee_perosnal_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPagePending As TabPage
    Friend WithEvents TabPageApproved As TabPage
    Friend WithEvents LoanApprovalDataGridView As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ButtonApprove As Button
    Friend WithEvents ButtonComment As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents EmployeDataSetBindingSource As BindingSource
    Friend WithEvents EmployeDataSet As employeDataSet
    Friend WithEvents LoanApprovalBindingSource As BindingSource
    Friend WithEvents LoanApprovalBindingSource1 As BindingSource
    Friend WithEvents EmployeDataSet1BindingSource As BindingSource
    Friend WithEvents employeDataSet1 As employeDataSet1
    Friend WithEvents LoanApprovalTableAdapter As employeDataSetTableAdapters.loanApprovalTableAdapter
    Friend WithEvents TableAdapterManager As employeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents employee_perosnal_infoBindingSource As BindingSource
    Friend WithEvents employee_perosnal_infoTableAdapter As employeDataSet1TableAdapters.employee_perosnal_infoTableAdapter
    Friend WithEvents LoanApprovalTableAdapter1 As employeDataSet1TableAdapters.loanApprovalTableAdapter
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents LaidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents La_commentTextBox As TextBox
End Class
