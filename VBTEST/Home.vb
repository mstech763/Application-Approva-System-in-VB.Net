Public Class Home
    Private Sub ButtonLA_Click(sender As Object, e As EventArgs) Handles ButtonLA.Click
        Dim box = New Form1()
        box.Show()
    End Sub

    Private Sub ButtonLAP_Click(sender As Object, e As EventArgs) Handles ButtonLAP.Click
        Dim box = New ApprovalControl()
        box.Show()

    End Sub

    Private Sub ButtonOPMA_Click(sender As Object, e As EventArgs) Handles ButtonOPMA.Click
        Dim box = New OPM_Approval
        box.Show()
    End Sub

    Private Sub ButtonSCTRY_Click(sender As Object, e As EventArgs) Handles ButtonSCTRY.Click
        Dim box = New secretaryApproval
        box.Show()
    End Sub

    Private Sub ButtonCEOAppr_Click(sender As Object, e As EventArgs) Handles ButtonCEOAppr.Click
        Dim box = New CEOApproval
        box.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim box = New AccountsApproval
        box.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim opmp = Me.LoanApprovalTableAdapter1.OpmPending()
        Dim sctp = Me.LoanApprovalTableAdapter1.SctPending()
        Dim ceop = Me.LoanApprovalTableAdapter1.CeoPending()
        Dim accp = Me.LoanApprovalTableAdapter1.AccPending()
        LabelOPMP.Text = "" + opmp.ToString() + " Pending Approvals."
        LabelSCTP.Text = "" + sctp.ToString() + " Pending Approvals."
        LabelCEOP.Text = "" + ceop.ToString() + " Pending Approvals."
        LabelACCP.Text = "" + accp.ToString() + " Pending Approvals."
    End Sub
End Class