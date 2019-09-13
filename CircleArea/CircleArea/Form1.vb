''' <summary>
''' Lance Brown
''' September 12 2019
''' Find the area of a circle given the radius
''' </summary>
Public Class frmArea
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRad.Clear()
        lblArea.ResetText()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Const Pi As Double = 3.14
        Dim dblRad As Double
        Dim dblArea As Double
        dblRad = txtRad.Text
        dblArea = Pi * dblRad ^ 2
        lblArea.Text = "Area of a circle with radius of " & dblRad.ToString() & " inches is " & dblArea.ToString("N") & " square inches."
    End Sub
End Class
