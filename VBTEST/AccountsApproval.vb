Public Class AccountsApproval
    Dim idToUp = 0
    Dim op = 0
    Private Sub AccountsApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoanApprovalTableAdapter1.FillForAcc(Me.employeDataSet1.loanApproval)
        'Me.LoanApprovalTableAdapter.FillForOPM(Me.EmployeDataSet1.loanApproval)
        Me.ReportViewer1.RefreshReport()
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

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        idToUp = 0
        If TabControl1.SelectedTab.Name = "TabPagePending" Then
            Me.LoanApprovalTableAdapter1.FillForAcc(Me.employeDataSet1.loanApproval)
            op = 1
        End If
        If TabControl1.SelectedTab.Name = "TabPageApproved" Then
            Me.LoanApprovalTableAdapter1.FillForAccAppr(Me.employeDataSet1.loanApproval)
            op = 2
        End If
    End Sub

    Private Sub ButtonComment_Click(sender As Object, e As EventArgs) Handles ButtonComment.Click
        If idToUp > 0 Then
            Me.Invalidate()
            Me.LoanApprovalBindingSource.EndEdit()
            Me.LoanApprovalTableAdapter.Update(Me.EmployeDataSet.loanApproval)
            Me.LoanApprovalTableAdapter1.FillForAcc(Me.employeDataSet1.loanApproval)
            'La_commentTextBox.Text = ""
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
End Class