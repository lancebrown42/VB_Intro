Public Class frmSalary
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim dblPrevGross As Double
        Dim strState As String
        Dim dblGross As Double
        Dim dblNet As Double
        Dim dblFica As Double
        Dim dblStateTax As Double
        Dim dblFedTax As Double
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each input As Control In grpInput.Controls
            input.ResetText()
            input.BackColor = Color.Empty
        Next
        lbxOutput.Items.Clear()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub SubmitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SubmitToolStripMenuItem1.Click
        btnSubmit_Click(sender, e)

    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        btnClear_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
End Class