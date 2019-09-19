'''**********************************************************************
'''Lance Brown
'''Program that adds inputs together in different ways and sums the sums
'''9/19/19
'''***********************************************************************

Public Class Form1
    Dim dblSum As Double
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear text boxes and labels
        txtFirst.Clear()
        txtSecond.Clear()
        txtThird.Clear()
        lblFirstSecond.ResetText()
        lblFirstThird.ResetText()
        lblSecondThird.ResetText()
        lblTotalSum.ResetText()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close window
        Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'declare local variables
        Dim dblFirst As Double
        Dim dblSecond As Double
        Dim dblThird As Double
        Dim dblFirstSecond As Double
        Dim dblFirstThird As Double
        Dim dblSecondThird As Double

        'assign txts to vars
        dblFirst = txtFirst.Text
        dblSecond = txtSecond.Text
        dblThird = txtThird.Text

        ' do the math
        dblFirstSecond = dblFirst + dblSecond
        dblFirstThird = dblFirst + dblThird
        dblSecondThird = dblSecond + dblThird
        'Running total
        dblSum += dblFirstSecond + dblFirstThird + dblSecondThird
        ' display results
        lblFirstSecond.Text = dblFirstSecond.ToString
        lblFirstThird.Text = dblFirstThird.ToString
        lblSecondThird.Text = dblSecondThird.ToString
        lblTotalSum.Text = dblSum





    End Sub

End Class
