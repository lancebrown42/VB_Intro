'Lance Brown
'10/10/19
'Find percentage off a given value, now with validation

Public Class frmSale
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAnswer.ResetText()
        txtOriginal.Clear()
        txtPercentOff.Clear()
        txtOriginal.BackColor = Color.White
        txtPercentOff.BackColor = Color.White

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'reset error colors
        txtOriginal.BackColor = Color.White
        txtPercentOff.BackColor = Color.White
        'declare
        Dim dblOriginalPrice As Double
        Dim dblPercentOff As Double
        Dim dblFinalPrice As Double
        'validate
        If IsNumeric(txtOriginal.Text) Then
            dblOriginalPrice = txtOriginal.Text
        Else
            MessageBox.Show("Please enter a number")
            txtOriginal.BackColor = Color.Yellow
            txtOriginal.Focus()
            Exit Sub
        End If
        If dblOriginalPrice < 0 Then
            MessageBox.Show("Please enter a positive number")
            txtOriginal.BackColor = Color.Yellow
            txtOriginal.Focus()
            Exit Sub
        End If

        If IsNumeric(txtPercentOff.Text) Then
            dblPercentOff = txtPercentOff.Text
        Else
            MessageBox.Show("Please enter a number")
            txtPercentOff.BackColor = Color.Yellow
            txtPercentOff.Focus()
            Exit Sub
        End If
        Select Case dblPercentOff 'try out Select case because why not
            Case Is < 0
                MessageBox.Show("Please enter a positive number")
                txtPercentOff.BackColor = Color.Yellow
                txtPercentOff.Focus()
                Exit Sub
            Case Is > 100
                MessageBox.Show("You wish. That's not how retail works, buddy. Enter 100 or less.")
                txtPercentOff.BackColor = Color.Yellow
                txtPercentOff.Focus()
                Exit Sub
        End Select
        'display
        dblPercentOff = txtPercentOff.Text
        dblFinalPrice = dblOriginalPrice * ((100 - dblPercentOff) / 100)
        lblAnswer.Text = dblFinalPrice.ToString("C") 'converts double value to string formatted to Currency
    End Sub

End Class
