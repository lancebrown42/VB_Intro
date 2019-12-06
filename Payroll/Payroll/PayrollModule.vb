Module PayrollModule
    Public Const PayPeriods As Integer = 52
    Public ReadOnly StateTax As New Dictionary(Of String, Double) From {{"Ohio", 0.065}, {"Kentucky", 0.06}, {"Indiana", 0.55}}
    Public ReadOnly FedTaxThresholds As New List(Of Integer) From {50, 500, 2500, 5000}
    Public Const OvertimeRate As Double = 1.5
    Public Const FicaRate As Double = 0.062
    Public Const FicaMax As Integer = 125000
    Public Sub InputError(input As Control)
        input.BackColor = Color.Yellow
        input.Select()
    End Sub
    Public Function ValidateNumeric(strCheckMe As String) As Boolean 'Returns True if string passed is positive number
        If IsNumeric(strCheckMe) Then
            If strCheckMe >= 0 Then
                Return True
            End If
        End If
        Return False
    End Function
    Public Function ValidateCommon(ByRef txtFirstName As TextBox, ByRef txtLastName As TextBox, ByRef txtPreviousGross As TextBox, ByRef cboState As ComboBox, ByRef dblPrevGross As Double, ByRef strState As String) As Boolean
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            InputError(txtFirstName)
            MessageBox.Show("Please enter your first name")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtLastName.Text) Then
            InputError(txtLastName)
            MessageBox.Show("Please enter your last name")
            Return False
        End If
        If ValidateNumeric(txtPreviousGross.Text) Then
            dblPrevGross = txtPreviousGross.Text
        Else
            InputError(txtPreviousGross)
            MessageBox.Show("Please enter previous gross pay")
            Return False
        End If
        If Not String.IsNullOrWhiteSpace(cboState.SelectedText) Then
            strState = cboState.SelectedText
        Else
            MessageBox.Show("Please select a state")
            Return False
        End If
        Return True
    End Function
    Public Sub FederalTaxCalc(ByVal dblGross As Double, ByRef dblFedTax As Double)

        Dim bracket As Integer = 5000
        For Each threshold As Integer In FedTaxThresholds
            If dblGross < threshold Then
                bracket = FedTaxThresholds.IndexOf(threshold)
                Exit For
            End If
        Next
        Select Case bracket
            Case 0
                dblFedTax = 0
            Case 1
                dblFedTax = (dblGross - 50) * 0.1
            Case 2
                dblFedTax = 45 + (dblGross - 500) * 0.15
            Case 3
                dblFedTax = 345 + (dblGross - 2500) * 0.2
            Case 5000
                dblFedTax = 845 + (dblGross - 5000) * 0.25
            Case Else
                Console.Write("tax is fucked, bracket is " + bracket.ToString)
        End Select

    End Sub
    Public Sub FicaCalc(ByVal dblPreviousGross As Double, ByVal dblGross As Double, ByRef dblFica As Double)
        If dblPreviousGross + dblGross <= FicaMax Then
            dblFica = dblGross * FicaRate
        Else
            dblFica = 0
        End If
    End Sub
    Public Sub Display(ByVal dblNet As Double, ByVal dblGross As Double, ByVal dblFica As Double, ByVal dblFedTax As Double, ByVal dblStateTax As Double)


    End Sub
End Module
