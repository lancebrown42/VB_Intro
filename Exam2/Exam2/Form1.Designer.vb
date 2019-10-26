<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYearsEmploy = New System.Windows.Forms.TextBox()
        Me.txtYtdPurchases = New System.Windows.Forms.TextBox()
        Me.grpRadios = New System.Windows.Forms.GroupBox()
        Me.radManagement = New System.Windows.Forms.RadioButton()
        Me.radHourly = New System.Windows.Forms.RadioButton()
        Me.txtPurchase = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDiscountPercent = New System.Windows.Forms.Label()
        Me.lblAnnualDiscount = New System.Windows.Forms.Label()
        Me.lblPurchase = New System.Windows.Forms.Label()
        Me.lblDiscountDollars = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpSaleInfo = New System.Windows.Forms.GroupBox()
        Me.lblDailyGrandTotal = New System.Windows.Forms.Label()
        Me.lblDailyDiscountedTotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grpDaily = New System.Windows.Forms.GroupBox()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.grpRadios.SuspendLayout()
        Me.grpSaleInfo.SuspendLayout()
        Me.grpDaily.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(5, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Tag = "Input"
        '
        'txtYearsEmploy
        '
        Me.txtYearsEmploy.Location = New System.Drawing.Point(5, 32)
        Me.txtYearsEmploy.Name = "txtYearsEmploy"
        Me.txtYearsEmploy.Size = New System.Drawing.Size(100, 20)
        Me.txtYearsEmploy.TabIndex = 1
        Me.txtYearsEmploy.Tag = "Input"
        '
        'txtYtdPurchases
        '
        Me.txtYtdPurchases.Location = New System.Drawing.Point(5, 58)
        Me.txtYtdPurchases.Name = "txtYtdPurchases"
        Me.txtYtdPurchases.Size = New System.Drawing.Size(100, 20)
        Me.txtYtdPurchases.TabIndex = 2
        Me.txtYtdPurchases.Tag = "Input"
        '
        'grpRadios
        '
        Me.grpRadios.Controls.Add(Me.radManagement)
        Me.grpRadios.Controls.Add(Me.radHourly)
        Me.grpRadios.Location = New System.Drawing.Point(5, 84)
        Me.grpRadios.Name = "grpRadios"
        Me.grpRadios.Size = New System.Drawing.Size(119, 86)
        Me.grpRadios.TabIndex = 3
        Me.grpRadios.TabStop = False
        Me.grpRadios.Tag = "Input"
        '
        'radManagement
        '
        Me.radManagement.AutoSize = True
        Me.radManagement.Location = New System.Drawing.Point(14, 48)
        Me.radManagement.Name = "radManagement"
        Me.radManagement.Size = New System.Drawing.Size(87, 17)
        Me.radManagement.TabIndex = 3
        Me.radManagement.TabStop = True
        Me.radManagement.Tag = ""
        Me.radManagement.Text = "Management"
        Me.radManagement.UseVisualStyleBackColor = True
        '
        'radHourly
        '
        Me.radHourly.AutoSize = True
        Me.radHourly.Location = New System.Drawing.Point(14, 25)
        Me.radHourly.Name = "radHourly"
        Me.radHourly.Size = New System.Drawing.Size(55, 17)
        Me.radHourly.TabIndex = 3
        Me.radHourly.TabStop = True
        Me.radHourly.Tag = ""
        Me.radHourly.Text = "Hourly"
        Me.radHourly.UseVisualStyleBackColor = True
        '
        'txtPurchase
        '
        Me.txtPurchase.Location = New System.Drawing.Point(5, 176)
        Me.txtPurchase.Name = "txtPurchase"
        Me.txtPurchase.Size = New System.Drawing.Size(100, 20)
        Me.txtPurchase.TabIndex = 4
        Me.txtPurchase.Tag = "Input"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(55, 299)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 39)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(136, 299)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 39)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next Employee"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(217, 299)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(75, 39)
        Me.btnSummary.TabIndex = 7
        Me.btnSummary.Text = "Discount Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(298, 299)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 26)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Years of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Employment:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "YTD Purchases:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Status:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Today's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Purchase:"
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(131, 31)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(76, 13)
        Me.lblName.TabIndex = 14
        Me.lblName.Tag = "Output"
        '
        'lblDiscountPercent
        '
        Me.lblDiscountPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountPercent.Location = New System.Drawing.Point(131, 54)
        Me.lblDiscountPercent.Name = "lblDiscountPercent"
        Me.lblDiscountPercent.Size = New System.Drawing.Size(76, 13)
        Me.lblDiscountPercent.TabIndex = 15
        Me.lblDiscountPercent.Tag = "Output"
        '
        'lblAnnualDiscount
        '
        Me.lblAnnualDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnnualDiscount.Location = New System.Drawing.Point(131, 80)
        Me.lblAnnualDiscount.Name = "lblAnnualDiscount"
        Me.lblAnnualDiscount.Size = New System.Drawing.Size(76, 13)
        Me.lblAnnualDiscount.TabIndex = 16
        Me.lblAnnualDiscount.Tag = "Output"
        '
        'lblPurchase
        '
        Me.lblPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPurchase.Location = New System.Drawing.Point(131, 106)
        Me.lblPurchase.Name = "lblPurchase"
        Me.lblPurchase.Size = New System.Drawing.Size(76, 13)
        Me.lblPurchase.TabIndex = 17
        Me.lblPurchase.Tag = "Output"
        '
        'lblDiscountDollars
        '
        Me.lblDiscountDollars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountDollars.Location = New System.Drawing.Point(131, 131)
        Me.lblDiscountDollars.Name = "lblDiscountDollars"
        Me.lblDiscountDollars.Size = New System.Drawing.Size(76, 13)
        Me.lblDiscountDollars.TabIndex = 18
        Me.lblDiscountDollars.Tag = "Output"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(131, 154)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(76, 13)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Tag = "Output"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Total With Discount:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Discount:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Total Before Discount:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "YTD Discount:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Discount %:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(86, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Name:"
        '
        'grpSaleInfo
        '
        Me.grpSaleInfo.Controls.Add(Me.Label6)
        Me.grpSaleInfo.Controls.Add(Me.Label7)
        Me.grpSaleInfo.Controls.Add(Me.Label8)
        Me.grpSaleInfo.Controls.Add(Me.Label9)
        Me.grpSaleInfo.Controls.Add(Me.Label10)
        Me.grpSaleInfo.Controls.Add(Me.Label11)
        Me.grpSaleInfo.Controls.Add(Me.lblTotal)
        Me.grpSaleInfo.Controls.Add(Me.lblDiscountDollars)
        Me.grpSaleInfo.Controls.Add(Me.lblPurchase)
        Me.grpSaleInfo.Controls.Add(Me.lblAnnualDiscount)
        Me.grpSaleInfo.Controls.Add(Me.lblDiscountPercent)
        Me.grpSaleInfo.Controls.Add(Me.lblName)
        Me.grpSaleInfo.Location = New System.Drawing.Point(241, 25)
        Me.grpSaleInfo.Name = "grpSaleInfo"
        Me.grpSaleInfo.Size = New System.Drawing.Size(213, 191)
        Me.grpSaleInfo.TabIndex = 26
        Me.grpSaleInfo.TabStop = False
        Me.grpSaleInfo.Text = "Employee Sale Info"
        Me.grpSaleInfo.Visible = False
        '
        'lblDailyGrandTotal
        '
        Me.lblDailyGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyGrandTotal.Location = New System.Drawing.Point(150, 16)
        Me.lblDailyGrandTotal.Name = "lblDailyGrandTotal"
        Me.lblDailyGrandTotal.Size = New System.Drawing.Size(82, 13)
        Me.lblDailyGrandTotal.TabIndex = 27
        Me.lblDailyGrandTotal.Tag = "Output"
        '
        'lblDailyDiscountedTotal
        '
        Me.lblDailyDiscountedTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyDiscountedTotal.Location = New System.Drawing.Point(150, 42)
        Me.lblDailyDiscountedTotal.Name = "lblDailyDiscountedTotal"
        Me.lblDailyDiscountedTotal.Size = New System.Drawing.Size(82, 13)
        Me.lblDailyDiscountedTotal.TabIndex = 28
        Me.lblDailyDiscountedTotal.Tag = "Output"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Daily Discounted Total:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Daily Total before Discount:"
        '
        'grpDaily
        '
        Me.grpDaily.Controls.Add(Me.Label14)
        Me.grpDaily.Controls.Add(Me.Label15)
        Me.grpDaily.Controls.Add(Me.lblDailyDiscountedTotal)
        Me.grpDaily.Controls.Add(Me.lblDailyGrandTotal)
        Me.grpDaily.Location = New System.Drawing.Point(222, 222)
        Me.grpDaily.Name = "grpDaily"
        Me.grpDaily.Size = New System.Drawing.Size(232, 71)
        Me.grpDaily.TabIndex = 31
        Me.grpDaily.TabStop = False
        Me.grpDaily.Text = "Daily Totals"
        Me.grpDaily.Visible = False
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.txtPurchase)
        Me.grpInput.Controls.Add(Me.grpRadios)
        Me.grpInput.Controls.Add(Me.txtYtdPurchases)
        Me.grpInput.Controls.Add(Me.txtYearsEmploy)
        Me.grpInput.Controls.Add(Me.txtName)
        Me.grpInput.Location = New System.Drawing.Point(84, 47)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(126, 203)
        Me.grpInput.TabIndex = 32
        Me.grpInput.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 390)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.grpDaily)
        Me.Controls.Add(Me.grpSaleInfo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "We value our employees by up to 40%"
        Me.grpRadios.ResumeLayout(False)
        Me.grpRadios.PerformLayout()
        Me.grpSaleInfo.ResumeLayout(False)
        Me.grpSaleInfo.PerformLayout()
        Me.grpDaily.ResumeLayout(False)
        Me.grpDaily.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYearsEmploy As TextBox
    Friend WithEvents txtYtdPurchases As TextBox
    Friend WithEvents grpRadios As GroupBox
    Friend WithEvents radManagement As RadioButton
    Friend WithEvents radHourly As RadioButton
    Friend WithEvents txtPurchase As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSummary As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblDiscountPercent As Label
    Friend WithEvents lblAnnualDiscount As Label
    Friend WithEvents lblPurchase As Label
    Friend WithEvents lblDiscountDollars As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents grpSaleInfo As GroupBox
    Friend WithEvents lblDailyGrandTotal As Label
    Friend WithEvents lblDailyDiscountedTotal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents grpDaily As GroupBox
    Friend WithEvents grpInput As GroupBox
End Class
