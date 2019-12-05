''' <summary>
''' Lance Brown
''' 11/22/19
''' Program to take in home value and several other values to calculate mortgage payment or rental cost
''' 
''' </summary>
Public Class frmMain

    Public dblValue As Double

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        txtValue.BackColor = Color.Empty
        If BuyRentModule.ValidateNumeric(txtValue.Text) Then
            dblValue = txtValue.Text
            frmBuy.ShowDialog()
        Else
            BuyRentModule.InputError(txtValue)
            MessageBox.Show("Please enter a positive number")
        End If


    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        txtValue.BackColor = Color.Empty
        If BuyRentModule.ValidateNumeric(txtValue.Text) Then
            dblValue = txtValue.Text
            frmRent.ShowDialog()
        Else
            BuyRentModule.InputError(txtValue)
            MessageBox.Show("Please enter a positive number")
        End If

    End Sub
End Class
