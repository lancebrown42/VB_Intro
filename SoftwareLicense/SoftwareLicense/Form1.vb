''' <summary>
''' Lance Brown
''' 10/3/2019
''' Program that allows user to select software license purchase or lease and several
''' optional add on services and calculates the cost to the consumer
''' </summary>
Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radSubscribe.Checked = True
        chkBackup.Checked = False
        chkSupport.Checked = False
        chkTraining.Checked = False
        lblAnnual.ResetText()
        lblSoftwareCost.ResetText()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Const dblSubscriptionCost As Double = 5000
        Const dblPurchaseCost As Double = 25000
        Const dblBackupCost As Double = 500
        Const dblSupportCost As Double = 2200
        Const dblTrainingCost As Double = 2200
        Dim dblSubscriptionTotal As Double = 0

        If chkBackup.Checked Then
            dblSubscriptionTotal += dblBackupCost
        End If
        If chkSupport.Checked Then
            dblSubscriptionTotal += dblSupportCost
        End If
        If chkTraining.Checked Then
            dblSubscriptionTotal += dblTrainingCost
        End If
        If radSubscribe.Checked Then
            dblSubscriptionTotal += dblSubscriptionCost
            lblSoftwareCost.Text = dblSubscriptionTotal.ToString("C")
            lblAnnual.Text = "per year"
        Else
            lblSoftwareCost.Text = dblPurchaseCost.ToString("C")
            If dblSubscriptionTotal Then
                lblAnnual.Text = "up front and " & dblSubscriptionTotal.ToString("C") & " per year"
            Else
                lblAnnual.Text = ""
            End If

        End If

    End Sub
End Class
