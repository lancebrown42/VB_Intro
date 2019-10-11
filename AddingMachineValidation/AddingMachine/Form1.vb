'''**********************************************************************
'''Lance Brown
'''Program that adds inputs together in different ways and sums the sums, now with validation
'''10/10/19
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
        txtFirst.BackColor = Color.White
        txtSecond.BackColor = Color.White
        txtThird.BackColor = Color.White

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close window
        Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'reset error colors
        txtFirst.BackColor = Color.White
        txtSecond.BackColor = Color.White
        txtThird.BackColor = Color.White
        'declare local variables
        Dim dblFirst As Double
        Dim dblSecond As Double
        Dim dblThird As Double
        Dim dblFirstSecond As Double
        Dim dblFirstThird As Double
        Dim dblSecondThird As Double
        'validate
        ' Box 1
        If IsNumeric(txtFirst.Text) Then
            dblFirst = txtFirst.Text
        Else
            MessageBox.Show("Please enter a number")
            txtFirst.BackColor = Color.Yellow
            txtFirst.Focus()
            Exit Sub
        End If
        If dblFirst < 0 Then
            MessageBox.Show("Please enter a positive number")
            txtFirst.BackColor = Color.Yellow
            txtFirst.Focus()
            Exit Sub
        End If
        'Box 2
        If IsNumeric(txtSecond.Text) Then
            dblSecond = txtSecond.Text
        Else
            MessageBox.Show("Please enter a number")
            txtSecond.BackColor = Color.Yellow
            txtSecond.Focus()
            Exit Sub
        End If
        If dblSecond < 0 Then
            MessageBox.Show("Please enter a positive number")
            txtSecond.BackColor = Color.Yellow
            txtSecond.Focus()
            Exit Sub
        End If
        'Box 3
        If IsNumeric(txtThird.Text) Then
            dblThird = txtThird.Text
        Else
            MessageBox.Show("Please enter a number")
            txtThird.BackColor = Color.Yellow
            txtThird.Focus()
            Exit Sub
        End If
        If dblThird < 0 Then
            MessageBox.Show("Please enter a positive number")
            txtThird.BackColor = Color.Yellow
            txtThird.Focus()
            Exit Sub
        End If



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
