<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRent
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbxOutput = New System.Windows.Forms.ListBox()
        Me.txtMonthsToRent = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.chkUtilities = New System.Windows.Forms.CheckBox()
        Me.chkParking = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Months to Rent"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "First Name"
        '
        'lbxOutput
        '
        Me.lbxOutput.FormattingEnabled = True
        Me.lbxOutput.Location = New System.Drawing.Point(279, 29)
        Me.lbxOutput.Name = "lbxOutput"
        Me.lbxOutput.Size = New System.Drawing.Size(120, 95)
        Me.lbxOutput.TabIndex = 16
        '
        'txtMonthsToRent
        '
        Me.txtMonthsToRent.Location = New System.Drawing.Point(98, 81)
        Me.txtMonthsToRent.Name = "txtMonthsToRent"
        Me.txtMonthsToRent.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthsToRent.TabIndex = 13
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(98, 55)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 12
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(98, 29)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 11
        '
        'chkUtilities
        '
        Me.chkUtilities.AutoSize = True
        Me.chkUtilities.Location = New System.Drawing.Point(15, 107)
        Me.chkUtilities.Name = "chkUtilities"
        Me.chkUtilities.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkUtilities.Size = New System.Drawing.Size(97, 17)
        Me.chkUtilities.TabIndex = 20
        Me.chkUtilities.Text = "Include Utilities"
        Me.chkUtilities.UseVisualStyleBackColor = True
        '
        'chkParking
        '
        Me.chkParking.AutoSize = True
        Me.chkParking.Location = New System.Drawing.Point(7, 130)
        Me.chkParking.Name = "chkParking"
        Me.chkParking.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkParking.Size = New System.Drawing.Size(105, 17)
        Me.chkParking.TabIndex = 21
        Me.chkParking.Text = "Covered Parking"
        Me.chkParking.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(253, 200)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(172, 200)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(91, 200)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 235)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.chkParking)
        Me.Controls.Add(Me.chkUtilities)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbxOutput)
        Me.Controls.Add(Me.txtMonthsToRent)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "frmRent"
        Me.Text = "What do you have against the American Dream?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbxOutput As ListBox
    Friend WithEvents txtMonthsToRent As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents chkUtilities As CheckBox
    Friend WithEvents chkParking As CheckBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
End Class
