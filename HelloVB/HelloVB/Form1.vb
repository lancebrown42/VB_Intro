Public Class frmHello
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        lblName.Text = "Hello " + txtName.Text.ToString()
        lblName.AutoSize = True
        Me.BackColor = Color.LawnGreen
    End Sub
End Class
