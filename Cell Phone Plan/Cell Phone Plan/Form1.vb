''' <summary>
''' Lance Brown
''' 10/3/2019
''' Program that allows user to input desired phone plan, phone model and any optional upgrades and displays
''' the subtotal, tax, and monthly total
''' </summary>
Public Class Form1

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'define prices
        Const dblEightHundredPrice As Double = 19.99
        Const dblFifteenHundredPrice As Double = 29.99
        Const dblUnlimitedPrice As Double = 39.99
        Const dblSimsongPrice As Double = 29.99
        Const dblIPoundPrice As Double = 39.99
        Const dblSMSPrice As Double = 10
        Const dblVideoPrice As Double = 15
        Const dblTaxRate As Double = 0.075
        Dim dblSubtotal As Double
        Dim dblTax As Double
        Dim dblTotal As Double

        'See what's checked
        If radEightHundred.Checked Then
            dblSubtotal += dblEightHundredPrice
        ElseIf radFifteenHundred.Checked Then
            dblSubtotal += dblFifteenHundredPrice
        ElseIf radUnlimited.Checked Then
            dblSubtotal += dblUnlimitedPrice
        End If
        If radSimsong.Checked Then
            dblSubtotal += dblSimsongPrice
        ElseIf radIPound.Checked Then
            dblSubtotal += dblIPoundPrice
        End If
        If chkSMS.Checked Then
            dblSubtotal += dblSMSPrice
        End If
        If chkVideo.Checked Then
            dblSubtotal += dblVideoPrice
        End If
        'Calculate
        dblTax = dblSubtotal * dblTaxRate
        dblTotal = dblSubtotal + dblTax

        'display
        lblSubtotal.Text = dblSubtotal.ToString("C")
        lblTax.Text = dblTax.ToString("C")
        lblTotal.Text = dblTotal.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears all labels, initializes radios, clears checkboxes
        radEightHundred.Checked = True
        radCustomerPhone.Checked = True
        chkSMS.Checked = False
        chkVideo.Checked = False
        lblSubtotal.ResetText()
        lblTax.ResetText()
        lblTotal.ResetText()

    End Sub
End Class
