' **************************************************************************************
' <Name>
' VB Auto Program
' <date>
' This program will calculate the total cost of an auto based on accessories and 
' finish chosen and if there is a trade-in.
' **************************************************************************************

Public Class frmPurchase

    Function ValidInput(ByRef BasePrice As Double, ByRef TradeIn As Double) As Boolean

        ' validate base price and trade in
        If ValidateBasePrice(BasePrice) = True Then
            If ValidateTradeIn(TradeIn) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Function ValidateBasePrice(ByRef BasePrice As Double) As Boolean


        ' Validate input and put it into variables
        If IsNumeric(txtBase.Text) Then
            BasePrice = txtBase.Text
            Return True
        Else
            txtBase.BackColor = Color.Yellow
            txtBase.Focus()
            MessageBox.Show("Please enter numbers only for Base Price.")
            Return False
        End If


    End Function

    Function ValidateTradeIn(ByRef TradeIn As Double) As Boolean

        ' Validate input and put it into variables
        If IsNumeric(txtTrade.Text) Then
            TradeIn = txtTrade.Text
            Return True
        Else
            txtTrade.BackColor = Color.Yellow
            txtTrade.Focus()
            MessageBox.Show("Please enter numbers only for Trade In Value.")
            Return False
        End If

    End Function

    Private Sub Display(ByVal AccFinish As Double, ByVal SubTotal As Double, ByVal Tax As Double, ByVal AmountDue As Double)

        ' display outputs
        lblAF.Text = FormatCurrency(AccFinish)
        lblSubtotal.Text = FormatCurrency(SubTotal)
        lblTax.Text = FormatCurrency(Tax)
        lblAmtDue.Text = FormatCurrency(AmountDue)

        ' set up the text boxes as currency
        txtBase.Text = FormatCurrency(txtBase.Text)
        txtTrade.Text = FormatCurrency(txtTrade.Text)

    End Sub

    Function CalcAmountDue(ByVal SubTotal As Double, ByVal TradeIn As Double) As Double

        ' create variable to hold amount due
        Dim dblAmountDue As Double

        ' do calculation
        dblAmountDue = SubTotal - TradeIn

        ' return result
        Return dblAmountDue

    End Function

    Function CalcAccFinish() As Double

        ' constants for options and tax rate
        Const dblStereoPrice As Double = 500
        Const dblLeatherPrice As Double = 1000
        Const dblNavigationPrice As Double = 1500
        Const dblPearlPrice As Double = 500
        Const dblCustomPrice As Double = 750


        Dim dblAccFinish As Double

        ' calculate the options
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

        Return dblAccFinish

    End Function

    Private Function CalcTax(ByVal SubTotal As Double) As Double

        Const dblTaxRate As Double = 0.08
        Dim dblTax As Double

        ' do calculation
        dblTax = SubTotal * dblTaxRate

        ' return tax
        Return dblTax

    End Function
    ' calculate subtotal by adding tax to previous subtotal.
    Private Function CalcTotal(ByVal SubTotal As Double, ByVal Tax As Double) As Double

        ' create our Subtotal variable
        Dim dblTotal As Double

        ' do calculation
        dblTotal = SubTotal + Tax

        'return result
        Return dblTotal

    End Function


    Function CalcSubTotal(ByVal AccFinish As Double, ByVal BasePrice As Double) As Double

        ' create our Subtotal variable
        Dim dblSubTotal As Double

        ' do calculation
        dblSubTotal = AccFinish + BasePrice

        'return result
        Return dblSubTotal

    End Function

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub




    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblSubTotal As Double
        Dim dblTax As Double
        Dim dblAmountDue As Double
        Dim dblBasePrice As Double
        Dim dblTrade As Double
        Dim dblAccFinish As Double

        ' set text box back color to white in case there were errors making it yellow
        txtBase.BackColor = Color.White
        txtTrade.BackColor = Color.White


        If ValidInput(dblBasePrice, dblTrade) = True Then

            dblAccFinish = CalcAccFinish()

            ' add base price and acc/finish price 
            dblSubTotal = CalcSubTotal(dblAccFinish, dblBasePrice)

            ' calculate the tax
            dblTax = CalcTax(dblSubTotal)

            ' add tax to sub total
            dblSubTotal = CalcTotal(dblSubTotal, dblTax)

            ' subtract the tradie in amount
            dblAmountDue = CalcAmountDue(dblSubTotal, dblTrade)

            ' call display procedure passing in all values
            Display(dblAccFinish, dblSubTotal, dblTax, dblAmountDue)

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the program
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear all the labels and textboxes
        txtBase.Clear()
        txtTrade.Clear()
        lblAF.ResetText()
        lblAmtDue.ResetText()
        lblSubtotal.Text = ""
        lblTax.Text = String.Empty

        ' clear all check boxes
        chkLeather.Checked = False
        chkNav.Checked = False
        chkStereo.Checked = False

        ' set the default back to radStandard
        radStandard.Checked = True
    End Sub
End Class
