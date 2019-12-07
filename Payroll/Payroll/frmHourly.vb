Public Class frmHourly
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each input As Control In grpInput.Controls
            input.ResetText()
            input.BackColor = Color.Empty
        Next
        lbxOutput.Items.Clear()
        InitOutputTemplate()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        For Each input As Control In grpInput.Controls
            input.BackColor = Color.Empty
        Next
        InitOutputTemplate()
        lbxOutput.Items.Clear()
        Dim dblHours As Double
        Dim dblRate As Double

        If GetValidateInput(dblPrevGross, strState, dblHours, dblRate) Then
            Calculate(dblNet, dblFica, dblStateTax, dblFedTax, dblPrevGross, dblGross, dblHours, dblRate, strState)
            Display(lbxOutput)

        End If
    End Sub
    Private Function GetValidateInput(ByRef dblPrevGross As Double, ByRef strState As String, ByRef dblHours As Double, ByRef dblRate As Double) As Boolean

        If Not ValidateCommon(txtFirstName, txtLastName, txtPreviousGross, cboState, dblPrevGross, strState) Then
            Return False
        End If
        If ValidateNumeric(txtHours.Text) Then
            dblHours = txtHours.Text
        Else
            InputError(txtHours)
            MessageBox.Show("Please enter hours worked")
            Return False
        End If
        If ValidateNumeric(txtRate.Text) Then
            dblRate = txtRate.Text
        Else
            InputError(txtRate)
            MessageBox.Show("Please enter pay rate")
            Return False
        End If
        Return True
    End Function
    Private Sub Calculate(ByRef dblNet As Double, ByRef dblFica As Double, ByRef dblStateTax As Double, ByRef dblFedTax As Double, ByVal dblPreviousGross As Double, ByRef dblGross As Double, ByVal dblHours As Double, ByVal dblRate As Double, ByVal strState As String)
        dblGross = dblRate * Math.Min(dblHours, 40) + (OvertimeRate * dblRate * (Math.Max(dblHours, 40) - 40)) 'whew
        Output(0) = Output(0) & dblGross.ToString("c")
        CalcCommon(dblStateTax, dblGross, strState, dblFedTax, dblPreviousGross, dblFica, dblNet)

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
    Private Sub txtHours_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHours.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then e.KeyChar = ""
    End Sub
    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then e.KeyChar = ""
    End Sub
End Class