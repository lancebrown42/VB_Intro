'''**********************************************************************
'''Lance Brown
'''Program that adds inputs together in different ways and sums the sums, now modularized
'''11/7/19
'''***********************************************************************

Public Class Form1
    Dim dblSum As Double
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear text boxes and labels
        Reset(txtFirst)
        Reset(txtSecond)
        Reset(txtThird)
        Reset(lblFirstSecond)
        Reset(lblFirstThird)
        Reset(lblSecondThird)
        Reset(lblTotalSum)


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close window
        Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'reset error colors
        ResetColor(txtFirst)
        ResetColor(txtSecond)
        ResetColor(txtThird)
        'declare local variables
        Dim dblFirst As Double
        Dim dblSecond As Double
        Dim dblThird As Double
        Dim dblFirstSecond As Double
        Dim dblFirstThird As Double
        Dim dblSecondThird As Double
        'validate
        If ValidateObtainInput(dblFirst, dblSecond, dblThird) = "err" Then
            Exit Sub
        End If
        ' do the math
        Calculate(dblFirst, dblSecond, dblThird, dblFirstSecond, dblFirstThird, dblSecondThird)
        ' display results
        Display(dblFirstSecond, dblFirstThird, dblSecondThird)
    End Sub
    Private Sub Reset(ctrl As Control)
        ctrl.ResetText()
        ResetColor(ctrl)

    End Sub
    Private Sub ResetColor(ctrl As Control)
        ctrl.BackColor = Color.Empty
    End Sub
    Private Function ValidateObtainInput(ByRef dblFirst As Double, ByRef dblSecond As Double, ByRef dblThird As Double)
        If ValidateInput(txtFirst, dblFirst) = "err" Then
            Return "err"
        End If
        If ValidateInput(txtSecond, dblSecond) = "err" Then
            Return "err"
        End If
        If ValidateInput(txtThird, dblThird) = "err" Then
            Return "err"
        End If

        'If IsNumeric(txtFirst.Text) Then
        '    dblFirst = txtFirst.Text
        'Else
        '    MessageBox.Show("Please enter a number")
        '    txtFirst.BackColor = Color.Yellow
        '    txtFirst.Focus()
        '    Exit Sub
        'End If
        'If dblFirst < 0 Then
        '    MessageBox.Show("Please enter a positive number")
        '    txtFirst.BackColor = Color.Yellow
        '    txtFirst.Focus()
        '    Exit Sub
        'End If
        ''Box 2
        ''If IsNumeric(txtSecond.Text) Then
        ''    dblSecond = txtSecond.Text
        ''Else
        ''    MessageBox.Show("Please enter a number")
        ''    txtSecond.BackColor = Color.Yellow
        ''    txtSecond.Focus()
        ''    Exit Sub
        ''End If
        'If dblSecond < 0 Then
        '    MessageBox.Show("Please enter a positive number")
        '    txtSecond.BackColor = Color.Yellow
        '    txtSecond.Focus()
        '    Exit Sub
        'End If
        ''Box 3
        ''If IsNumeric(txtThird.Text) Then
        ''    dblThird = txtThird.Text
        ''Else
        ''    MessageBox.Show("Please enter a number")
        ''    txtThird.BackColor = Color.Yellow
        ''    txtThird.Focus()
        ''    Exit Sub
        ''End If
        'If dblThird < 0 Then
        '    MessageBox.Show("Please enter a positive number")
        '    txtThird.BackColor = Color.Yellow
        '    txtThird.Focus()
        '    Exit Sub
        'End If
    End Function
    Private Sub Calculate(ByRef dblFirst As Double, ByRef dblSecond As Double, ByRef dblThird As Double, ByRef dblFirstSecond As Double, ByRef dblFirstThird As Double, ByRef dblSecondThird As Double)
        dblFirstSecond = dblFirst + dblSecond
        dblFirstThird = dblFirst + dblThird
        dblSecondThird = dblSecond + dblThird
        'Running total
        dblSum += dblFirstSecond + dblFirstThird + dblSecondThird
    End Sub
    Private Sub Display(dblFirstSecond As Double, dblFirstThird As Double, dblSecondThird As Double)
        lblFirstSecond.Text = dblFirstSecond.ToString
        lblFirstThird.Text = dblFirstThird.ToString
        lblSecondThird.Text = dblSecondThird.ToString
        lblTotalSum.Text = dblSum
    End Sub
    Private Function ValidateInput(ctrl As Control, ByRef dblVariable As Double)
        If CheckNumeric(ctrl, dblVariable) = "err" Then
            Return "err"
        End If
        CheckPositive(ctrl, dblVariable)
    End Function
    Private Function CheckNumeric(ByVal ctrl As Control, ByRef assignmentVariable As Double)
        If IsNumeric(ctrl.Text) Then
            assignmentVariable = ctrl.Text
        Else
            MessageBox.Show("Please enter a number")
            ctrl.BackColor = Color.Yellow
            ctrl.Focus()
            Return "err"
        End If
    End Function
    Private Sub CheckPositive(ctrl As Control, validationVariable As Double)
        If validationVariable < 0 Then
            MessageBox.Show("Please enter a positive number")
            ctrl.BackColor = Color.Yellow
            ctrl.Focus()
            Exit Sub
        End If
    End Sub
End Class
