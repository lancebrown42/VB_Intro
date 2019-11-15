Module VBAutoModule

    Public Function CalcTax(ByVal SubTotal As Double) As Double

        Const dblTaxRate As Double = 0.08
        Dim dblTax As Double

        ' do calculation
        dblTax = SubTotal * dblTaxRate

        ' return tax
        Return dblTax

    End Function
    ' calculate subtotal by adding tax to previous subtotal.
    Public Function CalcTotal(ByVal SubTotal As Double, ByVal Tax As Double) As Double

        ' create our Subtotal variable
        Dim dblTotal As Double

        ' do calculation
        dblTotal = SubTotal + Tax

        'return result
        Return dblTotal

    End Function

End Module
