﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamily
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPhones = New System.Windows.Forms.TextBox()
        Me.chkMessaging = New System.Windows.Forms.CheckBox()
        Me.lblMonthlyTotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPhoneTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.cboPackage = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboModel = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Number of Phones"
        '
        'txtPhones
        '
        Me.txtPhones.Location = New System.Drawing.Point(130, 13)
        Me.txtPhones.Name = "txtPhones"
        Me.txtPhones.Size = New System.Drawing.Size(100, 20)
        Me.txtPhones.TabIndex = 17
        '
        'chkMessaging
        '
        Me.chkMessaging.AutoSize = True
        Me.chkMessaging.Location = New System.Drawing.Point(7, 59)
        Me.chkMessaging.Name = "chkMessaging"
        Me.chkMessaging.Size = New System.Drawing.Size(77, 17)
        Me.chkMessaging.TabIndex = 1
        Me.chkMessaging.Text = "Messaging"
        Me.chkMessaging.UseVisualStyleBackColor = True
        '
        'lblMonthlyTotal
        '
        Me.lblMonthlyTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlyTotal.Location = New System.Drawing.Point(89, 136)
        Me.lblMonthlyTotal.Name = "lblMonthlyTotal"
        Me.lblMonthlyTotal.Size = New System.Drawing.Size(105, 23)
        Me.lblMonthlyTotal.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Total Monthly"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPackage
        '
        Me.lblPackage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackage.Location = New System.Drawing.Point(89, 113)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(105, 23)
        Me.lblPackage.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(-1, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Package Charge"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOptions
        '
        Me.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptions.Location = New System.Drawing.Point(89, 90)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(105, 23)
        Me.lblOptions.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Options"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPhoneTotal
        '
        Me.lblPhoneTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneTotal.Location = New System.Drawing.Point(89, 67)
        Me.lblPhoneTotal.Name = "lblPhoneTotal"
        Me.lblPhoneTotal.Size = New System.Drawing.Size(105, 23)
        Me.lblPhoneTotal.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Phone Total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(7, 26)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(51, 17)
        Me.chkEmail.TabIndex = 0
        Me.chkEmail.Text = "Email"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(89, 44)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(105, 23)
        Me.lblTax.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tax"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Phone Subtotal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMonthlyTotal)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblPackage)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblOptions)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblPhoneTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblTax)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblSubtotal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(175, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 193)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Plan Totals"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(89, 21)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(105, 23)
        Me.lblSubtotal.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(196, 255)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 53)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(26, 255)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(121, 53)
        Me.btnCalc.TabIndex = 23
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkMessaging)
        Me.grpOptions.Controls.Add(Me.chkEmail)
        Me.grpOptions.Location = New System.Drawing.Point(26, 147)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(121, 101)
        Me.grpOptions.TabIndex = 22
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Select Options"
        '
        'cboPackage
        '
        Me.cboPackage.FormattingEnabled = True
        Me.cboPackage.Items.AddRange(New Object() {"800 Minutes", "1500 Minutes", "Unlimited Minutes"})
        Me.cboPackage.Location = New System.Drawing.Point(23, 119)
        Me.cboPackage.Name = "cboPackage"
        Me.cboPackage.Size = New System.Drawing.Size(121, 21)
        Me.cboPackage.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Select Package"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Select Phone"
        '
        'cboModel
        '
        Me.cboModel.FormattingEnabled = True
        Me.cboModel.Items.AddRange(New Object() {"Model 100", "Model 110", "Model 200"})
        Me.cboModel.Location = New System.Drawing.Point(23, 74)
        Me.cboModel.Name = "cboModel"
        Me.cboModel.Size = New System.Drawing.Size(121, 21)
        Me.cboModel.TabIndex = 26
        '
        'frmFamily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 362)
        Me.Controls.Add(Me.cboPackage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboModel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.txtPhones)
        Me.Controls.Add(Me.Label15)
        Me.Name = "frmFamily"
        Me.Text = "frmFamily"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPhones As TextBox
    Friend WithEvents chkMessaging As CheckBox
    Friend WithEvents lblMonthlyTotal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblPackage As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblOptions As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPhoneTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chkEmail As CheckBox
    Friend WithEvents lblTax As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents cboPackage As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboModel As ComboBox
End Class
