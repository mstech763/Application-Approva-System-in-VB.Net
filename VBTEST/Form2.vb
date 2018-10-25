Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'employeDataSet1.employee_perosnal_info' table. You can move, or remove it, as needed.
        Me.employee_perosnal_infoTableAdapter.Fill(Me.employeDataSet1.employee_perosnal_info)
        'TODO: This line of code loads data into the 'employeDataSet1.loanApproval' table. You can move, or remove it, as needed.
        Me.loanApprovalTableAdapter.Fill(Me.employeDataSet1.loanApproval)
        ''TODO: This line of code loads data into the 'employeDataSet.employee_perosnal_info' table. You can move, or remove it, as needed.
        'Me.employee_perosnal_infoTableAdapter.Fill(Me.employeDataSet.employee_perosnal_info)
        ''TODO: This line of code loads data into the 'employeDataSet.loanApproval' table. You can move, or remove it, as needed.
        'Me.loanApprovalTableAdapter.Fill(Me.employeDataSet.loanApproval)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Insertdata3ToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ButtonFrw_Click(sender As Object, e As EventArgs) Handles ButtonFrw.Click
        'Try
        '    Me.InsertData3TableAdapter1.insertdata3(Me.employeDataSet1.insertData3, AmountToolStripTextBox.Text, ReasonToolStripTextBox.Text, PrepbyToolStripTextBox.Text, CType(TextBoxEN.Text, Integer))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub SearchByEmpnoToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub
End Class