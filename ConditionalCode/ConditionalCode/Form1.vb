' **************************************************
' <name>
' Conditional Code Program
' <date>
' This program shows ElseIf and Select Case examples
' **************************************************



Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear the controls
        txtNumber.Clear()
        lblResult.ResetText()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' closes the program
        Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' create local variable
        Dim intNumber As Integer
        Dim strResult As String
        'validate
        If IsNumeric(txtNumber.Text) Then
            intNumber = txtNumber.Text
        Else
            MessageBox.Show("Number please")
            txtNumber.BackColor = Color.Yellow
            txtNumber.Focus()
            Exit Sub
        End If
        If intNumber < 1 Or intNumber > 5 Then
            MessageBox.Show("Number can only be between 1 and 5")
            txtNumber.BackColor = Color.Yellow
            txtNumber.Focus()
            Exit Sub
        End If

        Select Case intNumber
            Case 1
                strResult = "One"
            Case 2
                strResult = "Two"
            Case 3
                strResult = "Three"
            Case 4
                strResult = "Four"
            Case 5
                strResult = "Five"
        End Select

        ' display variable
        lblResult.Text = strResult

    End Sub
End Class
