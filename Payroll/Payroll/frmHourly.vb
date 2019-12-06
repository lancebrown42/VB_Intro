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
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strName As String
        Dim dblPrevGross As Double
        Dim strState As String
        Dim dblGross As Double
        Dim dblNet As Double
        Dim dblFica As Double
        Dim dblStateTax As Double
        Dim dblFedTax As Double

        Dim dblHours As Double
        Dim dblRate As Double

        If GetValidateInput(dblPrevGross, strState, dblHours, dblRate) Then
            Calculate(dblNet, dblFica, dblStateTax, dblFedTax, dblPrevGross, dblGross, dblHours, dblRate, strState)

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
        dblStateTax = dblGross * StateTax(strState)
        FederalTaxCalc(dblGross, dblFedTax)
        FicaCalc(dblPreviousGross, dblGross, dblFica)
        dblNet = dblGross - dblFica - dblStateTax - dblFedTax
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