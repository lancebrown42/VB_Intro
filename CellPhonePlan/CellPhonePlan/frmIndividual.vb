
Public Class frmIndividual
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

        Dim dblTotal As Double



        'Get input
        GetInput(strModel, strPlan, blnEmail, blnMessaging, sender)
        'Calculate
        PhoneModule.Calculate(strModel, strPlan, blnEmail, blnMessaging, dblPhoneSub, dblTax, dblPhoneTotal, dblOptions, dblPackage, dblTotal, 1)
        'Display
        Display(dblPhoneSub, dblTax, dblPhoneTotal, dblOptions, dblPackage, dblTotal)
    End Sub
    Private Sub GetInput(ByRef strModel As String, ByRef strPlan As String, ByRef blnEmail As Boolean, ByRef blnMessaging As Boolean, ByRef sender As Object)

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
End Class