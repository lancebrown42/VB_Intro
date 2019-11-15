Public Class frmFamily
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click



        Dim strModel As String
        Dim strPlan As String
        Dim blnEmail As Boolean
        Dim blnMessaging As Boolean
        Dim dblPhoneSub As Double
        Dim dblTax As Double
        Dim dblPhoneTotal As Double
        Dim dblOptions As Double
        Dim dblPackage As Double
        Dim intPhoneQuant As Integer
        Dim dblTotal As Double



        'Get input
        GetInput(strModel, strPlan, blnEmail, blnMessaging, sender, intPhoneQuant)
        'Validate
        If Not Validate(intPhoneQuant) Then
            Exit Sub
        End If
        'Calculate
        PhoneModule.Calculate(strModel, strPlan, blnEmail, blnMessaging, dblPhoneSub, dblTax, dblPhoneTotal, dblOptions, dblPackage, dblTotal, intPhoneQuant)
        'Display
        Display(dblPhoneSub, dblTax, dblPhoneTotal, dblOptions, dblPackage, dblTotal)
    End Sub
    Private Sub GetInput(ByRef strModel As String, ByRef strPlan As String, ByRef blnEmail As Boolean, ByRef blnMessaging As Boolean, ByRef sender As Object, ByRef intPhoneQuant As Integer)
        txtPhones.BackColor = Color.Empty
        strModel = cboModel.Text
        strPlan = cboPackage.Text
        blnEmail = chkEmail.Checked
        blnMessaging = chkMessaging.Checked

    End Sub

    Private Sub Display(ByVal dblPhoneSub As Double, ByVal dblTax As Double, ByVal dblPhoneTotal As Double, ByVal dblOptions As Double, ByVal dblPackage As Double, ByVal dblTotal As Double)
        lblSubtotal.Text = dblPhoneSub.ToString("c")
        lblTax.Text = dblTax.ToString("c")
        lblPhoneTotal.Text = dblPhoneTotal.ToString("c")
        lblOptions.Text = dblOptions.ToString("c")
        lblPackage.Text = dblPackage.ToString("c")
        lblMonthlyTotal.Text = dblTotal.ToString("c")
    End Sub

    Private Sub frmIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboModel.SelectedIndex = 0
        cboPackage.SelectedIndex = 0
    End Sub
    Private Function Validate(ByRef intPhoneQuant As Integer)
        If IsNumeric(txtPhones.Text) Then
            intPhoneQuant = txtPhones.Text

        Else
            txtPhones.Focus()
            txtPhones.BackColor = Color.Yellow
            MessageBox.Show("Please enter a number of phones")
            Return False
        End If
        If intPhoneQuant > 0 Then
            Return True
        Else
            txtPhones.Focus()
            txtPhones.BackColor = Color.Yellow
            MessageBox.Show("Please enter a positive value")
            Return False

        End If

    End Function
End Class