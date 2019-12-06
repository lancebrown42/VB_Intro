Public Class frmMain
    Private Sub btnHourly_Click(sender As Object, e As EventArgs) Handles btnHourly.Click
        frmHourly.ShowDialog()

    End Sub

    Private Sub btnSalary_Click(sender As Object, e As EventArgs) Handles btnSalary.Click
        frmSalary.ShowDialog()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub
End Class
