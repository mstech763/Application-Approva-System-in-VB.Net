Public Class OPM_Approval
    Dim idToUp = 0
    Dim op = 0

    Private Sub OPM_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeDataSet.loanApproval' table. You can move, or remove it, as needed.
        'Me.LoanApprovalTableAdapter.Fill(Me.EmployeDataSet.loanApproval)
        'TODO: This line of code loads data into the 'employeDataSet.loanApproval' table. You can move, or remove it, as needed.
        'Me.LoanApprovalTableAdapter1.Fill(Me.employeDataSet.loanApproval)
        'TODO: This line of code loads data into the 'employeDataSet.loanApproval' table. You can move, or remove it, as needed.
        'Me.LoanApprovalTableAdapter.Fill(Me.EmployeDataSet1.loanApproval)
        'TODO: This line of code loads data into the 'employeDataSet.loanApproval' table. You can move, or remove it, as needed.
        'Me.LoanApprovalTableAdapter.Fill(Me.EmployeDataSet1.loanApproval)
        'TODO: This line of code loads data into the 'EmployeDataSet1.loanApproval' table. You can move, or remove it, as needed.
        Me.LoanApprovalTableAdapter1.FillForOPM(Me.employeDataSet1.loanApproval)
        'Me.LoanApprovalTableAdapter.FillForOPM(Me.EmployeDataSet1.loanApproval)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        idToUp = 0
        If TabControl1.SelectedTab.Name = "TabPagePending" Then
            Me.LoanApprovalTableAdapter1.FillForOPM(Me.employeDataSet1.loanApproval)
            op = 1
        End If
        If TabControl1.SelectedTab.Name = "TabPageApproved" Then
            Me.LoanApprovalTableAdapter1.FillForOpmApr(Me.employeDataSet1.loanApproval)
            op = 2
        End If
    End Sub

    Private Sub ButtonComment_Click(sender As Object, e As EventArgs) Handles ButtonComment.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If idToUp > 0 Then
            Me.Invalidate()
            Me.LoanApprovalBindingSource.EndEdit()
            Me.LoanApprovalTableAdapter.Update(Me.EmployeDataSet.loanApproval)
            GroupBox1.Visible = False
            'La_commentTextBox.Text = ""
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub LoanApprovalDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LoanApprovalDataGridView.CellClick
        Dim id = Integer.Parse(LoanApprovalDataGridView.Item(e.ColumnIndex, e.RowIndex).Value.ToString())
        idToUp = id
        ' MessageBox.Show("id = " + id.ToString())
        Me.LoanApprovalTableAdapter.FillById(Me.EmployeDataSet.loanApproval, CType(id, Integer))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim id = Integer.Parse(LoanApprovalDataGridView.Item(e.ColumnIndex, e.RowIndex).Value.ToString())
        idToUp = id
        ' MessageBox.Show("id = " + id.ToString())
        Me.LoanApprovalTableAdapter.FillById(Me.EmployeDataSet.loanApproval, CType(id, Integer))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ButtonApprove_Click(sender As Object, e As EventArgs) Handles ButtonApprove.Click
        If idToUp > 0 Then
            If TabControl1.SelectedTab.Name = "TabPagePending" Then
                Dim opmad = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                Me.LoanApprovalTableAdapter1.UpdateApprovalForOPM("True", opmad, idToUp)
                Me.Refresh()
                Me.LoanApprovalTableAdapter1.FillForOPM(Me.employeDataSet1.loanApproval)
                MessageBox.Show("Approved")
                Me.ReportViewer1.LocalReport.Refresh()
            Else
                MessageBox.Show("Selected Loan Application is Already Approved")
            End If
        End If
    End Sub
End Class