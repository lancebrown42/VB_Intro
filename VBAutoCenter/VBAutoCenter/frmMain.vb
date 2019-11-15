Public Class frmMain
    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim Purchase As New frmPurchase
        Purchase.ShowDialog()

    End Sub

    Private Sub btnLease_Click(sender As Object, e As EventArgs) Handles btnLease.Click
        Dim Lease As New frmLease
        Lease.ShowDialog()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class