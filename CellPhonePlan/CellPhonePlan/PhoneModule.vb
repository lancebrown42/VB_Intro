Module PhoneModule
    Public Sub Calculate(ByVal strModel As String, ByVal strPlan As String, ByVal blnEmail As Boolean, ByVal blnMessaging As Boolean, ByRef dblPhoneSub As Double, ByRef dblTax As Double, ByRef dblPhoneTotal As Double, ByRef dblOptions As Double, ByRef dblPackage As Double, ByRef dblTotal As Double, ByVal intPhoneQuant As Integer)
        Dim dblPhoneCost As Double
        Dim dblPlanCost As Double
        Select Case strModel
            Case "Model 100"
                dblPhoneCost = Consts.dblModel100
            Case "Model 110"
                dblPhoneCost = Consts.dblModel110
            Case "Model 200"
                dblPhoneCost = Consts.dblModel200

        End Select
        Select Case strPlan
            Case "800 Minutes"
                dblPlanCost = Consts.dblEightHundred
            Case "1500 Minutes"
                dblPlanCost = Consts.dblFifteenHundred
            Case "Unlimited Minutes"
                dblPlanCost = Consts.dblUnlimitedTalk

        End Select
        dblPhoneSub = dblPhoneCost * intPhoneQuant
        dblPackage = dblPlanCost
        dblTax = dblPhoneSub * Consts.dblTaxRate
        dblPhoneTotal = dblPhoneSub + dblTax
        If blnEmail Then
            dblOptions += Consts.dblEmail
        End If
        If blnMessaging Then
            dblOptions += Consts.dblTexting
        End If
        dblTotal = dblPhoneTotal + dblPackage + dblOptions
    End Sub

End Module
