Imports Microsoft.Reporting

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'employeDataSet.employee_perosnal_info' table. You can move, or remove it, as needed.
        'Me.employee_perosnal_infoTableAdapter.Fill(Me.employeDataSet.employee_perosnal_info)
        'TODO: This line of code loads data into the 'employeDataSet.loanApproval' table. You can move, or remove it, as needed.
        'Me.loanApprovalTableAdapter.Fill(Me.employeDataSet.loanApproval)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ButtonGen_Click(sender As Object, e As EventArgs) Handles ButtonGen.Click
        Dim id = Integer.Parse(TextBoxEN.Text)
        Me.employee_perosnal_infoTableAdapter.FillById(Me.employeDataSet.employee_perosnal_info, id)

        Dim am = Double.Parse(TextBoxAR.Text)
        Dim pp = TextBoxPP.Text

        For Each param As WinForms.ReportParameterInfo In ReportViewer1.LocalReport.GetParameters()
            If param.Name = "AR" Then
                ReportViewer1.LocalReport.SetParameters(New WinForms.ReportParameter(param.Name, am))
            End If
            If param.Name = "pp" Then
                ReportViewer1.LocalReport.SetParameters(New WinForms.ReportParameter(param.Name, pp))
            End If
            If param.Name = "pb" Then
                ReportViewer1.LocalReport.SetParameters(New WinForms.ReportParameter(param.Name, Environment.UserName))
            End If
        Next

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ButtonFrw_Click(sender As Object, e As EventArgs) Handles ButtonFrw.Click
        Dim id = Integer.Parse(TextBoxEN.Text)
        Dim am = Double.Parse(TextBoxAR.Text)
        'Me.loanApprovalTableAdapter.InsertLAN()
        Me.loanApprovalTableAdapter.InsertQuery12(am, TextBoxPP.Text, Environment.UserName, id)
        'MessageBox.Show("Loan Application Forwarded")
    End Sub

    'Private Sub FillByIdToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.employee_perosnal_infoTableAdapter.FillById(Me.employeDataSet.employee_perosnal_info, CType(IdToolStripTextBox.Text, Integer))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class
