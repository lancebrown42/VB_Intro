''' <summary>
''' Lance Brown
''' Exam 2
''' 10/24/19
''' 
''' Program accepts Name, years of employment, employment type, purchase amount and previous purchases. On calculate press, displays information
''' about the sale. On Summary press, displays information about the daily running totals.
''' </summary>
Public Class Form1
    Dim dblDailyTotal As Double 'class scope vars for running totals
    Dim dblDailyDiscount As Double
    Dim defaultColor As Color = Color.Empty
    Dim errorColor As Color = Color.Yellow
    'The following line didn't work and I don't understand why. 
    ' ReadOnly arrServiceBrackets()() As Integer = {{0, 0}, {1, 3}, {4, 6}, {7, 10}, {11, 15}, {15, 9999}} 'years of service award brackets in an array, easier to hotswap later. I don't know why I'm making this complicated
    ReadOnly arrHourlyDiscounts() As Double = {0, 0.1, 0.14, 0.2, 0.25, 0.3} ' hourly discount awards in an array
    ReadOnly arrManagerDiscounts() As Double = {0, 0.2, 0.24, 0.3, 0.35, 0.4} 'manager discount awards in an array

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Dim i As Control 'iterator for clearing outputs

        For Each i In grpInput.Controls
            If i.Tag = "Input" Then
                i.ResetText()
                i.BackColor = defaultColor
            End If
        Next
        radHourly.Checked = False
        radManagement.Checked = False
        For Each i In grpSaleInfo.Controls
            If i.Tag = "Output" Then 'only clear the output fields, not the actual labels
                i.ResetText()
            End If
        Next
        grpSaleInfo.Visible = False 'hide the box when not in use
        For Each i In grpDaily.Controls
            If i.Tag = "Output" Then
                i.ResetText()
            End If
        Next
        grpDaily.Visible = False 'hide the box when not in use

        txtName.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'clear any error handling
        Dim i As Control 'iterator
        For Each i In grpInput.Controls
            i.BackColor = defaultColor 'change color back to normal
        Next

        Dim strName As String
        Dim intYears As Integer
        Dim dblYtdPurchase As Double
        Dim dblPurchase As Double
        Dim blnHourly As Boolean
        Dim dblDiscount As Double
        Dim dblYtdDiscount As Double
        Dim dblDiscountDollars As Double
        Dim dblDiscountedTotal As Double

        'Validate and assign
        If txtName.Text.Length > 0 Then
            strName = txtName.Text
        Else
            MessageBox.Show("Please enter your name")
            txtName.BackColor = errorColor
            txtName.Focus()
            Exit Sub

        End If
        If IsNumeric(txtYearsEmploy.Text) Then
            intYears = txtYearsEmploy.Text
            If intYears < 0 Then
                MessageBox.Show("Please enter a positive value")
                txtYearsEmploy.BackColor = errorColor
                txtYearsEmploy.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter your years of service")
            txtYearsEmploy.BackColor = errorColor
            txtYearsEmploy.Focus()
            Exit Sub
        End If
        If IsNumeric(txtYtdPurchases.Text) Then
            dblYtdPurchase = txtYtdPurchases.Text
            If dblYtdPurchase < 0 Then
                MessageBox.Show("Please enter a positive value")
                txtYtdPurchases.BackColor = errorColor
                txtYtdPurchases.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter your total purchases for the year")
            txtYtdPurchases.BackColor = errorColor
            txtYtdPurchases.Focus()
            Exit Sub
        End If
        If radHourly.Checked Then
            blnHourly = True
        ElseIf radManagement.Checked Then
            blnHourly = False
        Else
            MessageBox.Show("Please select your employment type")
            Flash(grpRadios)
            Exit Sub
        End If
        If IsNumeric(txtPurchase.Text) Then
            dblPurchase = txtPurchase.Text
            If dblPurchase < 0 Then
                MessageBox.Show("Please enter a positive value")
                txtPurchase.BackColor = errorColor
                txtPurchase.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter your purchase amount")
            txtPurchase.BackColor = errorColor
            txtPurchase.Focus()
            Exit Sub
        End If

        dblDailyTotal += dblPurchase 'increment running total

        'calculate discount
        If blnHourly Then
            '    Dim j As Integer = 0 'iterator
            '    Dim k As String 'placeholder for ForEach
            '    For Each k In arrServiceBrackets
            '        Select Case intYears
            '            Case k
            '                dblDiscount = arrHourlyDiscounts(j)
            '                j += 1
            '        End Select


            '    Next
            'Else
            '    Dim j As Integer = 0 'iterator
            '    Dim k As String 'placeholder for ForEach
            '    For Each k In arrServiceBrackets
            '        Select Case intYears
            '            Case k
            '                dblDiscount = arrManagerDiscounts(j)
            '                j += 1
            '        End Select
            '    Next
            Select Case intYears
                Case 0
                    dblDiscount = arrHourlyDiscounts(0)
                Case 1 To 3
                    dblDiscount = arrHourlyDiscounts(1)
                Case 4 To 6
                    dblDiscount = arrHourlyDiscounts(2)
                Case 7 To 10
                    dblDiscount = arrHourlyDiscounts(3)
                Case 11 To 15
                    dblDiscount = arrHourlyDiscounts(4)
                Case Is > 15
                    dblDiscount = arrHourlyDiscounts(5)

            End Select
        Else
            Select Case intYears
                Case 0
                    dblDiscount = arrManagerDiscounts(0)
                Case 1 To 3
                    dblDiscount = arrManagerDiscounts(1)
                Case 4 To 6
                    dblDiscount = arrManagerDiscounts(2)
                Case 7 To 10
                    dblDiscount = arrManagerDiscounts(3)
                Case 11 To 15
                    dblDiscount = arrManagerDiscounts(4)
                Case Is > 15
                    dblDiscount = arrManagerDiscounts(5)

            End Select
        End If

        'Calculate discount
        dblYtdDiscount = (dblYtdPurchase * dblDiscount) + (dblPurchase * dblDiscount)
        'check if max discount is reached

        dblDiscountDollars = dblPurchase * dblDiscount
        dblDiscountedTotal = dblPurchase - dblDiscountDollars


        'Display
        lblDiscountDollars.Text = dblDiscountDollars.ToString("c")
        lblDiscountPercent.Text = dblDiscount.ToString("p")
        lblName.Text = strName
        lblPurchase.Text = dblPurchase.ToString("C")
        lblTotal.Text = dblDiscountedTotal.ToString("c")
        lblAnnualDiscount.Text = dblYtdDiscount.ToString("C")

        grpSaleInfo.Visible = True





    End Sub
    Private Async Sub Flash(label As Control)
        Dim i As Integer = 0
        While i < 10
            Await Task.Delay(500)
            If i Mod 2 = 0 Then
                label.BackColor = defaultColor
            Else
                label.BackColor = errorColor
            End If
            i += 1

        End While
    End Sub
End Class
