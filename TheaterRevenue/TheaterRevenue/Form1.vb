'*****************************************'
' Lance Brown
' Debugging Assignment
' 10/17/19
'*****************************************'



Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes program
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Resets Inputs and Outputs 

        txtAdultPrice.Clear()
        txtAdultSold.Clear()
        txtChildPrice.Clear()
        txtChildSold.Clear()

        lblGrossAdultSold.ResetText()
        lblGrossChildSold.ResetText()
        lblGrossTotal.ResetText()

        lblNetAdultSold.ResetText()
        lblNetChildSold.ResetText()
        lblNetTotal.ResetText()

        txtAdultPrice.Focus()
        txtAdultPrice.BackColor = Color.White
        txtAdultSold.BackColor = Color.White
        txtChildPrice.BackColor = Color.White
        txtChildSold.BackColor = Color.White


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ''''''Creating the Constant Given'''''
        Const dblPercentForTheater As Double = 0.2

        ''''''Creating the needed Variables''''''
        Dim dblAdultPrice As Double
        Dim IntAdultSold As Integer
        Dim dblChildPrice As Double
        Dim IntChildSold As Integer
        Dim dblGrossAdults As Double
        Dim dblGrossChildren As Double
        Dim dblGrossTotal As Double
        Dim dblNetAdults As Double
        Dim dblNetChildren As Double
        Dim dblNetTotal As Double

        'In order to avoid yellow fields when one makes mistkes. 
        'This will help the user.
        txtAdultPrice.BackColor = Color.White
        txtAdultSold.BackColor = Color.White
        txtChildPrice.BackColor = Color.White
        txtChildSold.BackColor = Color.White


        '''''''Valadating Inputs (and saving in Variable)''''''' 

        'Valadating txtAdultPrice

        If IsNumeric(txtAdultPrice.Text) Then
            dblAdultPrice = txtAdultPrice.Text
        Else
            txtAdultPrice.BackColor = Color.Yellow
            txtAdultPrice.Focus()
            MessageBox.Show("Please Enter Positive Numbers only for Adult Price!")
            Exit Sub
        End If




        'Valadating txtAdultSold''

        If IsNumeric(txtAdultSold.Text) Then
            IntAdultSold = txtAdultSold.Text
        Else
            txtAdultSold.BackColor = Color.Yellow
            txtAdultSold.Focus()
            MessageBox.Show("Please Enter a Positive Integer only for Adult # sold!")
            Exit Sub


        End If





        'Valadating txtChildPrice

        If IsNumeric(txtChildPrice.Text) Then
            dblChildPrice = txtChildPrice.Text
        Else
            txtChildPrice.BackColor = Color.Yellow
            txtChildPrice.Focus()
            MessageBox.Show("Please Enter a Positive Number only for child price!")
            Exit Sub
        End If





        ' Valadating txtChildSold

        If IsNumeric(txtChildSold.Text) Then
            IntChildSold = txtChildSold.Text
        Else
            txtChildSold.BackColor = Color.Yellow
            txtChildSold.Focus()
            MessageBox.Show("Please Enter a Positive Integer only for child # sold!")
            Exit Sub
        End If





        '''''''Calculaing the data to output the results''''''''''
        '                  'Gross
        dblGrossAdults = dblAdultPrice * IntAdultSold
        dblGrossChildren = dblChildPrice * IntChildSold
        dblGrossTotal = dblGrossAdults + dblGrossChildren
        '                   'Net
        dblNetAdults = dblGrossAdults * (1 - dblPercentForTheater)
        dblNetChildren = dblGrossChildren * (1 - dblPercentForTheater)
        dblNetTotal = dblNetAdults + dblNetChildren


        ''''''Diplaying the results in the labels'''''
        lblGrossAdultSold.Text = FormatCurrency(dblGrossAdults)
        lblGrossChildSold.Text = FormatCurrency(dblGrossChildren)
        lblGrossTotal.Text = FormatCurrency(dblGrossTotal)
        lblNetAdultSold.Text = FormatCurrency(dblNetAdults)
        lblNetChildSold.Text = FormatCurrency(dblNetChildren)
        lblNetTotal.Text = FormatCurrency(dblNetTotal)



    End Sub
End Class
'''''''''
'''Test cases:
''''''Case 1
'''Adult tickets sold - 10 ----- Adult Price 10
'''Child tickets sold - 10 ------ Child price 10
'''Expected result: 
'''Adult gross ticket sales: 100 --- Adult net ticket sales: 80
'''Child gross ticket sales: 100 --- Child net ticket sales: 80
'''Total gross ticket sales: 200 --- Total net ticket sales: 160
'''
''' Actual results:
'''Adult gross ticket sales: 100 --- Adult net ticket sales: 80
'''Child gross ticket sales: 100 --- Child net ticket sales: 80
'''Total gross ticket sales: 200 --- Total net ticket sales: 160
''''''Case 2
'''Adult tickets sold - 10 ----- Adult Price 10
'''Child tickets sold - 0 ------ Child price 0
'''Expected result: 
'''Adult gross ticket sales: 100 --- Adult net ticket sales: 80
'''Child gross ticket sales: 0 --- Child net ticket sales: 0
'''Total gross ticket sales: 100 --- Total net ticket sales: 80
'''
''' Actual results:
'''Adult gross ticket sales: 100 --- Adult net ticket sales: 80
'''Child gross ticket sales: 0 --- Child net ticket sales: 0
'''Total gross ticket sales: 100 --- Total net ticket sales: 80
''''''Case 3
'''Adult tickets sold - 0 ----- Adult Price 0
'''Child tickets sold - 10 ------ Child price 10
'''Expected result: 
'''Adult gross ticket sales: 0 --- Adult net ticket sales: 0
'''Child gross ticket sales: 100 --- Child net ticket sales: 80
'''Total gross ticket sales: 100 --- Total net ticket sales: 80
'''
''' Actual results:
'''Adult gross ticket sales: 0 --- Adult net ticket sales: 0
'''Child gross ticket sales: 100 --- Child net ticket sales: 80
'''Total gross ticket sales: 100 --- Total net ticket sales: 80
''''''Case 4
'''Adult tickets sold - n ----- Adult Price o
'''Child tickets sold - p ------ Child price e
'''Expected result: 
'''errors
'''
''' Actual results:
'''errors