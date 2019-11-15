<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLease
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rad48Months = New System.Windows.Forms.RadioButton()
        Me.rad36Months = New System.Windows.Forms.RadioButton()
        Me.rad24Months = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAmtDue = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rad48Months)
        Me.GroupBox2.Controls.Add(Me.rad36Months)
        Me.GroupBox2.Controls.Add(Me.rad24Months)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(121, 122)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lease Term/Months"
        '
        'rad48Months
        '
        Me.rad48Months.AutoSize = True
        Me.rad48Months.Location = New System.Drawing.Point(24, 89)
        Me.rad48Months.Name = "rad48Months"
        Me.rad48Months.Size = New System.Drawing.Size(75, 17)
        Me.rad48Months.TabIndex = 2
        Me.rad48Months.Text = "48 Months"
        Me.rad48Months.UseVisualStyleBackColor = True
        '
        'rad36Months
        '
        Me.rad36Months.AutoSize = True
        Me.rad36Months.Location = New System.Drawing.Point(24, 56)
        Me.rad36Months.Name = "rad36Months"
        Me.rad36Months.Size = New System.Drawing.Size(75, 17)
        Me.rad36Months.TabIndex = 1
        Me.rad36Months.Text = "36 Months"
        Me.rad36Months.UseVisualStyleBackColor = True
        '
        'rad24Months
        '
        Me.rad24Months.AutoSize = True
        Me.rad24Months.Checked = True
        Me.rad24Months.Location = New System.Drawing.Point(24, 19)
        Me.rad24Months.Name = "rad24Months"
        Me.rad24Months.Size = New System.Drawing.Size(75, 17)
        Me.rad24Months.TabIndex = 0
        Me.rad24Months.TabStop = True
        Me.rad24Months.Text = "24 Months"
        Me.rad24Months.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(207, 195)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(110, 195)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(13, 195)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 19
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(170, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Monthly Payment:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(169, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Total Price:"
        '
        'lblAmtDue
        '
        Me.lblAmtDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmtDue.Location = New System.Drawing.Point(173, 146)
        Me.lblAmtDue.Name = "lblAmtDue"
        Me.lblAmtDue.Size = New System.Drawing.Size(94, 23)
        Me.lblAmtDue.TabIndex = 23
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(173, 35)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(94, 20)
        Me.txtTotalPrice.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(170, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Sales Tax:"
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(172, 89)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 26
        '
        'frmLease
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 237)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAmtDue)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmLease"
        Me.Text = "VB Auto Lease"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rad48Months As RadioButton
    Friend WithEvents rad36Months As RadioButton
    Friend WithEvents rad24Months As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAmtDue As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTax As Label
End Class
