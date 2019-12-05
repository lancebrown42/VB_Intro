''' <summary>
''' Lance Brown
''' 11/22/19
''' Program to take in home value and several other values to calculate mortgage payment or rental cost
''' 
''' </summary>
Module BuyRentModule
    Private Sub ResetColor(ctrl As TextBox)
        ctrl.BackColor = Color.Empty
    End Sub
    Public Function ValidateNumeric(strCheckMe As String) As Boolean 'Returns True if string passed is positive number
        If IsNumeric(strCheckMe) Then
            If strCheckMe >= 0 Then
                Return True
            End If
        End If
        Return False
    End Function
    Public Sub InputError(input As Control)
        input.BackColor = Color.Yellow
        input.Select()
    End Sub
End Module
