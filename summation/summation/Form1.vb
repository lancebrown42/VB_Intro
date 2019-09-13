Public Class Summation

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        lblAnswer.Text = Convert.ToDouble(txtNumber1.Text) + Convert.ToDouble(txtNumber2.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber1.Text = ""
        txtNumber2.Text = ""
        lblAnswer.Text = ""
    End Sub
End Class
