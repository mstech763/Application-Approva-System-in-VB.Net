Imports Microsoft.Reporting.WinForms

Public Class ApprovalControl
    Dim idToUp
    Private Sub ApprovalControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.LoanApprovalTableAdapter1.Fill(Me.employeDataSet1.loanApproval)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub LoanApprovalDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LoanApprovalDataGridView.CellClick
        Dim id = Integer.Parse(LoanApprovalDataGridView.Item(e.ColumnIndex, e.RowIndex).Value.ToString())
        idToUp = id
        Me.LoanApprovalTableAdapter.FillById(Me.EmployeDataSet.loanApproval, CType(id, Integer))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub FillByIdToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        GroupBox1.Visible = True
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If idToUp > 0 Then
            Me.Invalidate()
            Me.LoanApprovalBindingSource.EndEdit()
            Me.LoanApprovalTableAdapter.Update(Me.EmployeDataSet.loanApproval)
            GroupBox1.Visible = False
            La_commentTextBox.Text = ""
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub ButtonApprove_Click(sender As Object, e As EventArgs) Handles ButtonApprove.Click
        If idToUp > 0 Then
            If approve.Checked Then
                Dim opmad = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                If CheckBoxOPM.Checked = True Then
                    Me.LoanApprovalTableAdapter1.UpdateApprovalForOPM("True", opmad, idToUp)
                    Me.Refresh()
                    CheckBoxOPM.Checked = True
                    'loadreport()
                    Me.LoanApprovalTableAdapter1.FillForOPM(Me.employeDataSet1.loanApproval)

                End If
                If CheckBoxSCT.Checked = True Then
                    Me.LoanApprovalTableAdapter1.UpdateAprrovalForSCT("True", opmad, idToUp)
                    Me.Refresh()
                    CheckBoxSCT.Checked = True
                    'loadreport()
                    Me.LoanApprovalTableAdapter1.FillForSCT(Me.employeDataSet1.loanApproval)
                End If
                If CheckBoxCEO.Checked = True Then
                    Me.LoanApprovalTableAdapter1.UpdateApprovalForCEO("True", opmad, idToUp)
                    Me.Refresh()
                    CheckBoxCEO.Checked = True
                    'loadreport()
                    Me.LoanApprovalTableAdapter1.FillForCEO(Me.employeDataSet1.loanApproval)
                End If
                MessageBox.Show("Approved")

                Me.ReportViewer1.LocalReport.Refresh()
                approve.Checked = False
            End If
        End If
    End Sub
    Private Sub loadreport()
        Me.ReportViewer1.Reset()
        Dim rptDataSource As ReportDataSource
        Dim ds As New employeDataSet
        Dim da As New employeDataSetTableAdapters.loanApprovalTableAdapter
        da.Fill(ds.loanApproval)
        rptDataSource = New ReportDataSource("DataSet2", ds.Tables("loanApproval"))
        Me.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
    End Sub
    Private Sub CheckBoxOPM_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOPM.CheckedChanged

    End Sub

    Private Sub CheckBoxSCT_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSCT.CheckedChanged

    End Sub

    Private Sub CheckBoxCEO_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCEO.CheckedChanged

    End Sub

    Private Sub CheckBoxOPM_Click(sender As Object, e As EventArgs) Handles CheckBoxOPM.Click
        TextBoxCashP.Visible = False
        ButtonSaveCash.Visible = False
        CheckBoxAccounts.Checked = False
        idToUp = 0
        CheckBoxSCT.Checked = False
        CheckBoxCEO.Checked = False
        Me.LoanApprovalTableAdapter1.FillForOPM(Me.employeDataSet1.loanApproval)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CheckBoxSCT_Click(sender As Object, e As EventArgs) Handles CheckBoxSCT.Click
        TextBoxCashP.Visible = False
        ButtonSaveCash.Visible = False
        CheckBoxAccounts.Checked = False
        idToUp = 0
        CheckBoxCEO.Checked = False
        CheckBoxOPM.Checked = False
        Me.LoanApprovalTableAdapter1.FillForSCT(Me.employeDataSet1.loanApproval)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CheckBoxCEO_Click(sender As Object, e As EventArgs) Handles CheckBoxCEO.Click
        TextBoxCashP.Visible = False
        ButtonSaveCash.Visible = False
        CheckBoxAccounts.Checked = False
        idToUp = 0
        CheckBoxOPM.Checked = False
        CheckBoxSCT.Checked = False
        Me.LoanApprovalTableAdapter1.FillForCEO(Me.employeDataSet1.loanApproval)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CheckBoxAccounts_Click(sender As Object, e As EventArgs) Handles CheckBoxAccounts.Click
        CheckBoxCEO.Checked = False
        CheckBoxOPM.Checked = False
        CheckBoxSCT.Checked = False
        Me.LoanApprovalTableAdapter1.FillForAcc(Me.employeDataSet1.loanApproval)
        Me.ReportViewer1.RefreshReport()
        TextBoxCashP.Visible = True
        ButtonSaveCash.Visible = True
    End Sub

    Private Sub ButtonSaveCash_Click(sender As Object, e As EventArgs) Handles ButtonSaveCash.Click
        If idToUp > 0 Then
            If TextBoxCashP.Text = "" Then
            Else
                Dim amount = Double.Parse(TextBoxCashP.Text)
                Me.LoanApprovalTableAdapter1.UpdateCashPaid(amount, idToUp)
                MessageBox.Show("Data Updated")
                TextBoxCashP.Text = ""
            End If
        End If
    End Sub
End Class