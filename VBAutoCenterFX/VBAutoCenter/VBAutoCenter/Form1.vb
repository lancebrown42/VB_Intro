' **************************************************************************************
' <Name>
' VB Auto Program
' <date>
' This program will calculate the total cost of an auto based on accessories and 
' finish chosen and if there is a trade-in.
' **************************************************************************************

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'close the program
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear all the labels and textboxes and set trade in back to default value of 0
        txtBase.Clear()
        txtTrade.Clear()
        lblAF.ResetText()
        lblAmtDue.ResetText()
        lblSubtotal.Text = ""
        lblTax.Text = String.Empty

        txtBase.BackColor = Color.White
        txtTrade.BackColor = Color.White

        chkLeather.Checked = False
        chkNav.Checked = False
        chkStereo.Checked = False

        radStandard.Checked = True


    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' constants for options and tax rate
        Const dblStereoPrice As Double = 500
        Const dblLeatherPrice As Double = 1000
        Const dblNavigationPrice As Double = 1500
        Const dblPearlPrice As Double = 500
        Const dblCustomPrice As Double = 750
        Const dblTaxRate As Double = 0.07

        Dim dblAccFinish As Double
        Dim dblSubTotal As Double
        Dim dblTax As Double
        Dim dblAmountDue As Double
        Dim dblBasePrice As Double
        Dim dblTrade As Double


        txtBase.BackColor = Color.White
        txtTrade.BackColor = Color.White

        'Get input into variables

        If IsNumeric(txtBase.Text) Then
            dblBasePrice = txtBase.Text
        Else
            txtBase.BackColor = Color.Yellow
            txtBase.Focus()
            MessageBox.Show("Please enter numbers only for Base Price.")
            Exit Sub
        End If

        If dblBasePrice < 0 Then
            txtBase.BackColor = Color.Yellow
            txtBase.Focus()
            MessageBox.Show("Please enter numbers greater than 0 for Base Price.")
            Exit Sub
        End If

        If IsNumeric(txtTrade.Text) Then
            dblTrade = txtTrade.Text
        Else
            txtTrade.BackColor = Color.Yellow
            txtTrade.Focus()
            MessageBox.Show("Please enter numbers only for Trade In Value.")
            Exit Sub
        End If

        If dblTrade < 0 Then
            txtTrade.BackColor = Color.Yellow
            txtTrade.Focus()
            MessageBox.Show("Please enter numbers greater than 0 for Trade in Value.")
            Exit Sub
        End If

        ' check out accessories 
        If chkStereo.Checked = True Then
            dblAccFinish += dblStereoPrice
        End If

        If chkLeather.Checked = True Then
            dblAccFinish += dblLeatherPrice
        End If

        If chkNav.Checked = True Then
            dblAccFinish += dblNavigationPrice
        End If

        ' caculate the finish
        If radPearl.Checked = True Then
            dblAccFinish += dblPearlPrice
        Else
            If radCustom.Checked = True Then
                dblAccFinish += dblCustomPrice
            End If
        End If

        ' do our calculations

        ' add base price and acc/finish price 
        dblSubTotal = dblAccFinish + dblBasePrice

        ' calculate the tax
        dblTax = dblSubTotal * dblTaxRate

        ' add tax to sub total
        dblSubTotal += dblTax


        ' subtract the trade in amount
        dblAmountDue = dblSubTotal - dblTrade

        ' display our outputs in currency


        ' display outputs
        lblAF.Text = dblAccFinish.ToString("c")
        lblSubtotal.Text = dblSubTotal.ToString("c")
        lblTax.Text = dblTax.ToString("c")
        lblAmtDue.Text = dblAmountDue.ToString("c")

        ' set up the text boxes as currency
        txtBase.Text = FormatCurrency(txtBase.Text)
        txtTrade.Text = FormatCurrency(txtTrade.Text)



    End Sub

End Class
