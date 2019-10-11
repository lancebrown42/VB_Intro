' ***************************************************
' <Name>
' Addition Program
' <Date>
' **************************************************


Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' closes the program
        Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' create local variables
        Dim dblNumber1 As Double
        Dim dblNumber2 As Double
        Dim dblSum As Double

        ' assingn values from text boxes to variables
        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text

        ' do calculation
        dblSum = dblNumber1 + dblNumber2

        ' display output
        lblSum.Text = dblSum

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' clear out the controls
        txtNumber1.Clear()
        txtNumber2.Clear()

        lblSum.ResetText()

        'set focus into first text box
        txtNumber1.Focus()

    End Sub
End Class
