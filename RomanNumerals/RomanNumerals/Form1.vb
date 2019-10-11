' **************************************************
' Lance Brown
' Roman Numeral Program
' 10/10/19
' This program stakes in arabic numbers and displays roman numerals
' **************************************************



Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear the controls
        txtNumber.Clear()
        lblResult.ResetText()
        txtNumber.BackColor = Color.White

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' closes the program
        Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        txtNumber.BackColor = Color.White

        ' create local variable
        Dim intNumber As Integer
        Dim strResult As String
        'validate
        If IsNumeric(txtNumber.Text) Then
            intNumber = txtNumber.Text
        Else
            MessageBox.Show("Please enter a number")
            txtNumber.BackColor = Color.Yellow
            txtNumber.Focus()
            Exit Sub
        End If
        If intNumber < 1 Or intNumber > 10 Then
            MessageBox.Show("Number can only be between 1 and 10")
            txtNumber.BackColor = Color.Yellow
            txtNumber.Focus()
            Exit Sub
        End If

        Select Case intNumber
            Case 1
                strResult = "I"
            Case 2
                strResult = "II"
            Case 3
                strResult = "III"
            Case 4
                strResult = "IV"
            Case 5
                strResult = "V"
            Case 6
                strResult = "VI"
            Case 7
                strResult = "VII"
            Case 8
                strResult = "VIII"
            Case 9
                strResult = "IX"
            Case 10
                strResult = "X"
        End Select

        ' display variable
        lblResult.Text = strResult

    End Sub
End Class
