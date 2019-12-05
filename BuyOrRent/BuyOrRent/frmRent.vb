''' <summary>
''' Lance Brown
''' 11/22/19
''' Program to take in home value and several other values to calculate mortgage payment or rental cost
''' 
''' </summary>
Public Class frmRent
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim input As Control
        For Each input In grpInput.Controls
            If TypeOf input Is CheckBox Then
                Dim chk As CheckBox = input
                chk.Checked = False
            ElseIf TypeOf input Is RadioButton Then
                rdoSix.Checked = True
            ElseIf TypeOf input Is TextBox Then
                input.ResetText()
                input.BackColor = Color.Empty

            End If
            lbxOutput.Items.Clear()


        Next
        rdoSix.Checked = True
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        For Each ctrl In grpInput.Controls
            ctrl.backColor = Color.Empty
        Next
        lbxOutput.Items.Clear()
        Dim strName As String
        Dim intTerm As Integer
        Dim blnUtilities As Boolean
        Dim blnParking As Boolean
        Dim dblRent As Double
        Dim dblTotal As Double
        Dim strUtility As String
        Dim strParking As String
        If GetValidateInput(strName, intTerm, blnUtilities, blnParking) Then
            Calculate(blnUtilities, blnParking, dblRent, dblTotal, strUtility, strParking)
            Display(strName, dblRent, dblTotal, strUtility, strParking)
        End If
    End Sub
    Private Function GetValidateInput(ByRef strName As String, ByRef intTerm As Integer, ByRef blnUtilities As Boolean, ByRef blnParking As Boolean) As Boolean

        If Not txtFirstName.Text = "" Then
            If Not txtLastName.Text = "" Then
                strName = txtFirstName.Text + " " + txtLastName.Text
            Else
                InputError(txtLastName)
                MessageBox.Show("Please enter your last name")
                Return False
            End If
        Else
            InputError(txtFirstName)
            MessageBox.Show("Please enter your first name")
            Return False
        End If
        Dim rdo As RadioButton
        For Each rdo In grpRad.Controls
            If rdo.Checked Then
                intTerm = rdo.Text
            End If
        Next
        blnUtilities = chkUtilities.Checked
        blnParking = chkParking.Checked
        Return True
    End Function
    Private Sub Calculate(ByVal blnUtilities As Boolean, ByVal blnParking As Boolean, ByRef dblRent As Double, ByRef dblTotal As Double, ByRef strUtility As String, ByRef strParking As String)
        dblRent = frmMain.dblValue * Consts.RentPercent / Consts.AnnualPayments
        dblTotal = dblRent
        If blnUtilities Then
            dblTotal *= Consts.UtilitySurcharge
        Else
            strUtility = "No "
        End If
        If blnParking Then
            dblTotal += Consts.ParkingSurcharge
        Else
            strParking = "No "
        End If
    End Sub
    Private Sub Display(ByVal strName As String, ByVal dblRent As Double, ByVal dblTotal As Double, ByRef strUtility As String, ByRef strParking As String)
        lbxOutput.Items.Add(strName)
        lbxOutput.Items.Add("Monthly Rent " + dblRent.ToString("c"))
        lbxOutput.Items.Add(strUtility + "Utilities")
        lbxOutput.Items.Add(strParking + "Parking")
        lbxOutput.Items.Add("Total Monthly Due " + dblTotal.ToString("c"))
    End Sub


End Class