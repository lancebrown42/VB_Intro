Public Class frmMain
    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        Dim Individual As New frmIndividual
        Individual.ShowDialog()

    End Sub

    Private Sub btnFamily_Click(sender As Object, e As EventArgs) Handles btnFamily.Click
        Dim Family As New frmFamily
        Family.ShowDialog()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
