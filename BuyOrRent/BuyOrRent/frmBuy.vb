Public Class frmBuy
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim input As TextBox
        For Each input In grpInput.Controls
            input.ResetText()
            input.BackColor = Color.Empty
        Next

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub
End Class