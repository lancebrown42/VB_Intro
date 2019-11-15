Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' closes the program
        Close()

    End Sub

    Private Sub btnLease_Click(sender As Object, e As EventArgs) Handles btnLease.Click

        ' create new instance of frmLease
        Dim Lease As New frmLease

        ' show the form modally
        Lease.ShowDialog()


    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click

        ' create a new instance of the purchase form
        Dim Purchase As New frmPurchase

        ' show new instance to user
        Purchase.ShowDialog()

    End Sub
End Class