' *************************************************
' 
' <Name>
' <Date>
' This program will accept a students name and 3 test
' scores. The name and scores are required. The scores
' must be numeric and between 0 & 100. 
'
' *************************************************

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' closes the program
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' clear out all controls
        txtName.Clear()
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()

        txtScore1.BackColor = Color.White
        txtScore2.BackColor = Color.White
        txtScore3.BackColor = Color.White
        txtName.BackColor = Color.White

        lblSum.ResetText()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' create local variables
        Dim strName As String
        Dim intScore1 As Integer
        Dim intScore2 As Integer
        Dim intScore3 As Integer
        Dim dblAverage As Double

        txtScore1.BackColor = Color.White
        txtScore2.BackColor = Color.White
        txtScore3.BackColor = Color.White
        txtName.BackColor = Color.White

        If txtName.Text = String.Empty Then
            MessageBox.Show("You know your name, right?")
            txtName.BackColor = Color.Yellow
            txtName.Focus()
            Exit Sub
        Else
            strName = txtName.Text
        End If
        'VVV Score 1 VVV
        If IsNumeric(txtScore1.Text) Then
            intScore1 = txtScore1.Text
        Else
            MessageBox.Show("That's not a number")
            txtScore1.BackColor = Color.Yellow
            txtScore1.Focus()
            Exit Sub
        End If
        If intScore1 < 0 Or intScore1 > 100 Then
            MessageBox.Show("Enter a value between 0 and 100")
            txtScore1.BackColor = Color.Yellow
            txtScore1.Focus()
            Exit Sub
        End If
        'VVV score 2 VVV
        If IsNumeric(txtScore2.Text) Then
            intScore2 = txtScore2.Text
        Else
            MessageBox.Show("That's not a number")
            txtScore2.BackColor = Color.Yellow
            txtScore2.Focus()
            Exit Sub
        End If
        If intScore2 < 0 Or intScore2 > 100 Then
            MessageBox.Show("Enter a value between 0 and 100")
            txtScore2.BackColor = Color.Yellow
            txtScore2.Focus()
            Exit Sub
        End If
        'VVV Score 3 VVV
        If IsNumeric(txtScore3.Text) Then
            intScore3 = txtScore3.Text
        Else
            MessageBox.Show("That's not a number")
            txtScore3.BackColor = Color.Yellow
            txtScore3.Focus()
            Exit Sub
        End If
        If intScore3 < 0 Or intScore3 > 100 Then
            MessageBox.Show("Enter a value between 0 and 100")
            txtScore3.BackColor = Color.Yellow
            txtScore3.Focus()
            Exit Sub
        End If

        ' do calculation
        dblAverage = (intScore1 + intScore2 + intScore3) / 3

        ' display output
        lblSum.Text = "Student: " & strName & vbNewLine & "Average: " & FormatNumber(dblAverage, 2)

    End Sub
End Class
