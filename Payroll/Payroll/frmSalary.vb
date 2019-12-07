Public Class frmSalary
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        InitOutputTemplate()
        lbxOutput.Items.Clear()
        For Each input As Control In grpInput.Controls
            input.BackColor = Color.Empty
        Next
        Dim dblSalary As Double
        If GetValidateInput(dblPrevGross, strState, dblSalary) Then
            Calculate(dblSalary, dblGross)
            Display(lbxOutput)
        End If
    End Sub
    Private Function GetValidateInput(ByRef dblPrevGross As Double, ByRef strState As String, ByRef dblSalary As Double) As Boolean
        If Not ValidateCommon(txtFirstName, txtLastName, txtPreviousGross, cboState, dblPrevGross, strState) Then
            Return False
        End If
        If ValidateNumeric(txtSalary.Text) Then
            dblSalary = txtSalary.Text
        Else
            InputError(txtSalary)
            MessageBox.Show("Please enter your salary")
            Return False
        End If
        Return True
    End Function
    Private Sub Calculate(ByVal dblSalary As Double, ByRef dblGross As Double)
        dblGross = dblSalary / PayPeriods
        Output(0) = Output(0) & dblGross.ToString("c")
        CalcCommon(dblStateTax, dblGross, strState, dblFedTax, dblPrevGross, dblFica, dblNet)

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each input As Control In grpInput.Controls
            input.ResetText()
            input.BackColor = Color.Empty
        Next
        lbxOutput.Items.Clear()
        InitOutputTemplate()
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
    Private Sub txtPreviousGross_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPreviousGross.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then e.KeyChar = ""
    End Sub
    Private Sub txtSalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalary.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then e.KeyChar = ""
    End Sub
End Class