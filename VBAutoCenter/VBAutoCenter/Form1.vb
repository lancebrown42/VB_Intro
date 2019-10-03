' **************************************************************************************
' <Name>
' VB Auto Program
' <date>
' This program takes the base price of an auto adds in optons and finish and calculates
' the amount due after subtracting a trade in.
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

        'Get input into variables
        dblBasePrice = txtBase.Text
        dblTrade = txtTrade.Text

        ' check out accessories 
        If chkStereo.Checked = True Then
            dblAccFinish += dblStereoPrice
        End If
        If chkLeather.Checked Then
            dblAccFinish += dblLeatherPrice
        End If
        If chkNav.Checked Then
            dblAccFinish += dblNavigationPrice
        End If
        If radPearl.Checked Then
            dblAccFinish += dblPearlPrice
        ElseIf radCustom.Checked Then
            dblAccFinish += dblCustomPrice
        End If
        ' do our calculations
        dblSubTotal = dblBasePrice + dblAccFinish
        dblTax = dblSubTotal * dblTaxRate
        dblAmountDue = dblSubTotal + dblTax
        dblAmountDue -= dblTrade


        ' display our outputs in currency

        lblSubtotal.Text = dblSubTotal.ToString("C")
        lblTax.Text = dblTax.ToString("C")
        lblAmtDue.Text = dblAmountDue.ToString("C")
        lblAF.Text = dblAccFinish.ToString("C")






    End Sub
End Class
