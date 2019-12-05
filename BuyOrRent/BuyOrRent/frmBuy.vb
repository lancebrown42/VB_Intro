''' <summary>
''' Lance Brown
''' 11/22/19
''' Program to take in home value and several other values to calculate mortgage payment or rental cost
''' 
''' </summary>
Public Class frmBuy
    ReadOnly Value As Double = frmMain.dblValue
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
        Dim strName As String
        Dim dblDownPayment As Double
        Dim dblInterest As Double
        Dim intTerm As Integer
        Dim dblSalePrice As Double
        Dim intNumberPayments As Integer
        Dim dblMonthlyPayment As Double
        If GetValidateInput(strName, dblDownPayment, dblInterest, intTerm) Then
            Calculate(dblDownPayment, dblInterest, intTerm, Value, dblSalePrice, intNumberPayments, dblMonthlyPayment)
            Display(strName, dblSalePrice, dblInterest, dblMonthlyPayment)
        Else
            Exit Sub
        End If



    End Sub
    Private Function GetValidateInput(ByRef strName As String, ByRef dblDownPayments As Double, ByRef dblInterest As Double, ByRef intTerm As Integer) As Boolean

        If Not txtFirstName.Text = "" Then

            If Not txtLastName.Text = "" Then
                strName = txtFirstName.Text + " " + txtLastName.Text
            Else
                InputError(txtLastName)
                MessageBox.Show("Please enter your last name")
                Return False
            End If
        Else
            InputError(txtFirstName)
            MessageBox.Show("Please enter your first name")
            Return False
        End If
        If ValidateNumeric(txtDownPayment.Text) Then
            If txtDownPayment.Text <= Value Then
                dblDownPayments = txtDownPayment.Text
            Else
                InputError(txtDownPayment)
                MessageBox.Show("You're not great with money, are you? You can't pay more than the house is worth.")
                Return False
            End If

        Else
            InputError(txtDownPayment)
            MessageBox.Show("Please enter your down payment")
            Return False
        End If
        If ValidateNumeric(txtInterest.Text) Then
            dblInterest = txtInterest.Text
            If dblInterest >= 4 And dblInterest <= 8 Then
                dblInterest *= 0.01
            Else
                InputError(txtInterest)
                MessageBox.Show("Enter a value between 4 and 8")
                Return False
            End If
        Else
            InputError(txtInterest)
            MessageBox.Show("Enter a value between 4 and 8")
            Return False

        End If
        If ValidateNumeric(txtTerm.Text) Then
            If Not Integer.TryParse(txtTerm.Text, intTerm) Then
                InputError(txtTerm)
                MessageBox.Show("Enter an integer")
                Return False
            End If
        Else
            InputError(txtTerm)
            MessageBox.Show("Please enter mortgage term length")
            Return False

        End If
        Return True
    End Function
    Private Sub Calculate(ByVal dblDownPayment As Double, ByVal dblInterest As Double, ByVal intTerm As Integer, ByVal Value As Double, ByRef dblSalePrice As Double, ByRef intNumberPayments As Integer, ByRef dblMonthlyPayment As Double)
        dblSalePrice = Value - dblDownPayment
        intNumberPayments = intTerm / frmMain.AnnualPayments
        dblMonthlyPayment = MortgageCalc(dblSalePrice, dblInterest, intNumberPayments)
    End Sub
    Private Sub Display(ByVal strName As String, ByVal dblSalePrice As Double, ByVal dblInterest As Double, ByVal dblMonthlyPayment As Double)
        lbxOutput.Items.Add(strName)
        lbxOutput.Items.Add(dblSalePrice.ToString("c"))
        lbxOutput.Items.Add(dblInterest.ToString("p"))
        lbxOutput.Items.Add(dblMonthlyPayment.ToString("c"))
    End Sub


    ' SalePrice is the total amount to be mortgaged, IE $105,000 with $5,000 down = #100,000, interest rate is the monthly interest rate, 
    ' Number payments Is the total monthly payments, Interest rate must me in decimal then divided by 12 for monthly rate IE 6%  
    ' Is 6/100 = .06, .06 / 12 = .005 which is the InterestRate needed, Number Payments is mortgage years 8 12 months/year. 
    ' 30 year mortgage = 30 * 12 or 360 Example $100,000 mortgage for 30 years at 6% payments will be $599.55
    Function MortgageCalc(ByVal SalePrice As Double, ByVal InterestRate As Double, ByVal NumberPayments As Integer) As Double

        Dim dblPayment As Double
        Dim dblDiscountFactor As Double

        dblDiscountFactor = (((1 + InterestRate) ^ NumberPayments) - 1) / (InterestRate * (1 + InterestRate) ^ NumberPayments)

        dblPayment = SalePrice / dblDiscountFactor

        Return dblPayment


    End Function

End Class