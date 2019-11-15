' ************************************
' <Name>
' <Date>
' VB Auto new lease auto form
'
' ************************************

Public Class frmLease
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' closes the form
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' clear out controls and set form back to default
        txtTotalPrice.Clear()

        lblTax.ResetText()
        lblAmtDue.ResetText()

        rad24Months.Checked = True

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' declare local variables to pass
        Dim dblTotalPrice As Double
        Dim dblMultiplier As Double
        Dim dblTax As Double
        Dim dblMonthlyPayment As Double
        Dim dblSubTotal As Double
        Dim intTerm As Integer

        ' call validate total price
        ' only proceed if it comes back true
        If ValidateTotalPrice(dblTotalPrice) = True Then

            ' calulate amount based on term (24, 36 or 48 months)
            dblMultiplier = CalcTermMultiplier(intTerm)

            ' calculate subtotal based on price and term multiplier
            dblSubTotal = CalcSubTotal(dblTotalPrice, dblMultiplier)

            ' calculate tax
            dblTax = CalcTax(dblSubTotal)

            ' calculate total (subtotal + tax)
            dblTotalPrice = CalcTotal(dblSubTotal, dblTax)

            ' calculate monthly payment 
            dblMonthlyPayment = CalcPayment(dblTotalPrice, intTerm)

            ' display outputs
            Display(dblMonthlyPayment, dblTax)
        End If



    End Sub

    Private Sub Display(ByVal TotalPayment As Double, ByVal Tax As Double)

        ' display outputs in currency
        lblAmtDue.Text = TotalPayment.ToString("c")
        lblTax.Text = Tax.ToString("c")

    End Sub

    Function ValidateTotalPrice(ByRef TotalPrice As Double) As Boolean


        ' Validate input and put it into variables
        If IsNumeric(txtTotalPrice.Text) Then
            TotalPrice = txtTotalPrice.Text
            Return True
        Else
            txtTotalPrice.BackColor = Color.Yellow
            txtTotalPrice.Focus()
            MessageBox.Show("Please enter numbers only for Total Price.")
            Return False
        End If


    End Function

    ' function to set amount based on term
    Function CalcTermMultiplier(ByRef Months As Integer) As Double

        ' constants for options and tax rate
        Const dbl24Month As Double = 0.3
        Const dbl36Month As Double = 0.4
        Const dbl48Month As Double = 0.5

        ' variable to hold amount
        Dim dblTermMultiplier As Double


        ' caculate the term
        If rad24Months.Checked = True Then
            dblTermMultiplier = dbl24Month
            Months = 24
        ElseIf rad36Months.Checked = True Then
            dblTermMultiplier = dbl36Month
            Months = 36
        ElseIf rad48Months.Checked = True Then
            dblTermMultiplier = dbl48Month
            Months = 48
        End If

        ' return the multiplier
        Return dblTermMultiplier

    End Function

    ' calculate the subtotal
    Function CalcSubTotal(ByVal TotalPrice As Double, ByVal Multiplier As Double) As Double

        ' create our Subtotal variable
        Dim dblSubTotal As Double

        ' do calculation
        dblSubTotal = TotalPrice * Multiplier

        'return result
        Return dblSubTotal

    End Function



    ' calculate monthly payment
    Function CalcPayment(ByVal Total As Double, ByVal Term As Integer) As Double


        Dim dblPayment As Double

        ' do calculation
        dblPayment = Total / Term

        ' return tax
        Return dblPayment

    End Function

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click

        ' call the calculate button subroutine
        btnCalc_Click(sender, e)

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        ' call the clear button subroutine
        btnClear_Click(sender, e)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        ' call the exit button subroutine
        btnExit_Click(sender, e)

    End Sub
End Class