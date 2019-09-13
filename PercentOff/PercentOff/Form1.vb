'Lance Brown
'September 12, 2019
'Find percentage off a given value

Public Class frmSale
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAnswer.ResetText()
        txtOriginal.Clear()
        txtPercentOff.Clear()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dblOriginalPrice As Double
        Dim dblPercentOff As Double
        Dim dblFinalPrice As Double
        dblOriginalPrice = txtOriginal.Text
        dblPercentOff = txtPercentOff.Text
        dblFinalPrice = dblOriginalPrice * ((100 - dblPercentOff) / 100)
        lblAnswer.Text = dblFinalPrice.ToString("C") 'converts double value to string formatted to Currency
    End Sub
End Class
