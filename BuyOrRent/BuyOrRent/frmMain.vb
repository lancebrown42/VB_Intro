Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        frmBuy.ShowDialog()
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        frmRent.ShowDialog()
    End Sub
End Class
