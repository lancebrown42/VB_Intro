Imports System.Text.RegularExpressions
Public Class Form1

    ReadOnly errorColor As Color = Color.Yellow
    ReadOnly defaultColor As Color = Color.Empty
    ReadOnly arrSeason() As String = {"Off Season", "Peak Season", "Standard Season"}
    ReadOnly arrSeasonRates() As Double = {50, 150, 100}
    ReadOnly arrDiscounts() As Double = {0.05, 0.1}
    Const dblTaxRate As Double = 0.1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strPhone As String
        Dim strEmail As String
        Dim blnFlorida As Boolean
        Dim strSeason As String
        Dim intLength As Integer

        Dim dblSubtotal As Double
        Dim dblTax As Double
        Dim dblTotal As Double

        GetValidateInput(strFirstName, strLastName, strPhone, strEmail, blnFlorida, strSeason, intLength)

        Calculate(blnFlorida, strSeason, intLength, dblSubtotal, dblTax, dblTotal)

        Display(strFirstName, strLastName, strPhone, strEmail, dblSubtotal, dblTax, dblTotal)
    End Sub

    'Sub to populate the combobox.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strState As String
        Dim arrState() As String = {"ME", "NH", "VT", "MA", "CT", "RI", "NY", "VA", "NC", "SC", "GA", "FL", "DE", "NJ", "OH", "MI", "IL", "IN", "IA", "KS", "NE", "OK", "TX", "AL", "TN", "MO", "ND", "SD", "WY", "MT", "ID", "NV", "WA", "OR", "CO", "NM", "AZ", "WV", "PA", "CA", "AR", "HI", "MN", "WI", "MD", "MS", "AK", "LA", "UT", "KY"}
        For Each strState In arrState
            cboState.Items.Add(strState)
        Next
        Dim strSeason As String

        For Each strSeason In arrSeason
            cboSeason.Items.Add(strSeason)
        Next
        cboState.SelectedIndex = 0
        cboSeason.SelectedIndex = 0
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmail.ResetText()
        
    End Sub
    Private Sub GetValidateInput(ByRef strFirstName As String, ByRef strLastName As String, ByRef strPhone As String, ByRef strEmail As String, ByRef blnFlorida As Boolean, ByRef strSeason As String, ByRef intLength As Integer)
        If ValidateName(txtFirstName) Then
            strFirstName = txtFirstName.Text
        Else
            Exit Sub
        End If
        If ValidateName(txtLastName) Then
            strLastName = txtLastName.Text
        Else
            Exit Sub
        End If
        If ValidatePhone(txtPhone) Then
            strPhone = txtPhone.Text
        Else
            Exit Sub
        End If
        If ValidateEmail(txtEmail) Then
            strEmail = txtEmail.Text
        Else
            Exit Sub
        End If
        blnFlorida = CheckFlorida(cboState)

        strSeason = cboSeason.Text

        If ValidateInteger(txtLength) Then
            intLength = txtLength.Text
        Else
            Exit Sub

        End If

    End Sub
    Private Function ValidateName(ByVal txt As TextBox)
        If txt.Text.Length > 0 Then
            Return True
        Else
            MessageBox.Show("Please enter your name")
            TextBoxError(txt)
            Return False
        End If
    End Function
    Private Function ValidatePhone(ByVal txt As TextBox)
        Dim strFormat As String = Regex.Replace(txt.Text, "[^A-Za-z0-9]", "")
        If IsNumeric(strFormat) Then
            If strFormat.Length <> 10 Then
                MessageBox.Show("Please enter a 10 digit phone number")
                TextBoxError(txt)
                Return False
            End If
            Return True
        Else
            MessageBox.Show("Please enter your phone number. We probably won't sell it.")
            TextBoxError(txt)
            Return False
        End If
    End Function
    Private Function ValidateEmail(ByVal txt As TextBox)
        If txt.Text.Length > 0 Then
            Dim emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
            If emailExpression.IsMatch(txt.Text) Then
                Return True
            Else
                MessageBox.Show("Please enter a valid email address")
                TextBoxError(txt)
                Return False
            End If

        Else
            MessageBox.Show("Please enter your email.")
            TextBoxError(txt)
            Return False
        End If

    End Function
    Private Function CheckFlorida(cbo As ComboBox)
        If cbo.Text = "FL" Then
            Return True
        Else

            Return False

        End If
    End Function

    Private Function ValidateInteger(txt As TextBox)
        Dim intParse As Integer
        If Integer.TryParse(txt.Text, intParse) Then
            If txt.Text > 0 And txt.Text <= 60 Then
                Return True
            Else
                MessageBox.Show("Please enter a length of stay between 1 and 60 days")
            End If
        Else
            MessageBox.Show("Please enter the length of your stay")
            TextBoxError(txt)
            Return False
        End If
    End Function
    Private Sub Calculate(ByVal blnFlorida As Boolean, ByVal strSeason As String, ByVal intLength As Integer, ByRef dblSubtotal As Double, ByRef dblTax As Double, ByRef dblTotal As Double)
        Dim dblRate As Double
        Select Case strSeason
            Case arrSeason(0)
                dblRate = arrSeasonRates(0)
            Case arrSeason(1)
                dblRate = arrSeasonRates(1)
            Case arrSeason(2)
                dblRate = arrSeasonRates(2)
            Case Else
                MessageBox.Show("something went horribly wrong with the rate calculation")
                Exit Sub
        End Select
        Dim dblDiscount As Double = 0
        If intLength > 14 Then
            dblDiscount = arrDiscounts(0)
            If intLength > 30 Then
                dblDiscount = arrDiscounts(1)
            End If
        End If
        dblSubtotal = intLength * dblRate * (1 - dblDiscount)
        dblTax = dblSubtotal * dblTaxRate
        If blnFlorida Then
            dblTax = 0
        End If
        dblTotal = dblSubtotal + dblTax
    End Sub
    Private Sub Display(ByVal strFirstName As String, ByVal strLastName As String, ByVal strPhone As String, ByVal strEmail As String, ByVal dblSubtotal As Double, ByVal dblTax As Double, ByVal dblTotal As Double)
        lblOutput.Text = strFirstName & " " & strLastName & vbCrLf & strPhone & vbCrLf & strEmail & vbCrLf & "Subtotal: " & dblSubtotal.ToString("c") & vbCrLf & "Tax: " & dblTax.ToString("c") & vbCrLf & "Total: " & dblTotal.ToString("c")
    End Sub
    Private Sub TextBoxError(txt As TextBox)
        txt.Focus()
        ErrColor(txt)
    End Sub
    Private Sub ErrColor(ByRef ctrl As Control)
        ctrl.BackColor = errorColor
    End Sub

End Class
