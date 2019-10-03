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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radEightHundred = New System.Windows.Forms.RadioButton()
        Me.radFifteenHundred = New System.Windows.Forms.RadioButton()
        Me.radUnlimited = New System.Windows.Forms.RadioButton()
        Me.radSimsong = New System.Windows.Forms.RadioButton()
        Me.radIPound = New System.Windows.Forms.RadioButton()
        Me.radCustomerPhone = New System.Windows.Forms.RadioButton()
        Me.chkSMS = New System.Windows.Forms.CheckBox()
        Me.chkVideo = New System.Windows.Forms.CheckBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(76, 348)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(292, 348)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(522, 348)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radUnlimited)
        Me.GroupBox1.Controls.Add(Me.radFifteenHundred)
        Me.GroupBox1.Controls.Add(Me.radEightHundred)
        Me.GroupBox1.Location = New System.Drawing.Point(76, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 154)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Voice Plan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radCustomerPhone)
        Me.GroupBox2.Controls.Add(Me.radIPound)
        Me.GroupBox2.Controls.Add(Me.radSimsong)
        Me.GroupBox2.Location = New System.Drawing.Point(292, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 154)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Phone"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkVideo)
        Me.GroupBox3.Controls.Add(Me.chkSMS)
        Me.GroupBox3.Location = New System.Drawing.Point(522, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(188, 153)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'radEightHundred
        '
        Me.radEightHundred.AutoSize = True
        Me.radEightHundred.Checked = True
        Me.radEightHundred.Location = New System.Drawing.Point(7, 30)
        Me.radEightHundred.Name = "radEightHundred"
        Me.radEightHundred.Size = New System.Drawing.Size(83, 17)
        Me.radEightHundred.TabIndex = 0
        Me.radEightHundred.TabStop = True
        Me.radEightHundred.Text = "800 Minutes"
        Me.radEightHundred.UseVisualStyleBackColor = True
        '
        'radFifteenHundred
        '
        Me.radFifteenHundred.AutoSize = True
        Me.radFifteenHundred.Location = New System.Drawing.Point(7, 67)
        Me.radFifteenHundred.Name = "radFifteenHundred"
        Me.radFifteenHundred.Size = New System.Drawing.Size(89, 17)
        Me.radFifteenHundred.TabIndex = 1
        Me.radFifteenHundred.Text = "1500 Minutes"
        Me.radFifteenHundred.UseVisualStyleBackColor = True
        '
        'radUnlimited
        '
        Me.radUnlimited.AutoSize = True
        Me.radUnlimited.Location = New System.Drawing.Point(7, 103)
        Me.radUnlimited.Name = "radUnlimited"
        Me.radUnlimited.Size = New System.Drawing.Size(68, 17)
        Me.radUnlimited.TabIndex = 2
        Me.radUnlimited.Text = "Unlimited"
        Me.radUnlimited.UseVisualStyleBackColor = True
        '
        'radSimsong
        '
        Me.radSimsong.AutoSize = True
        Me.radSimsong.Location = New System.Drawing.Point(7, 30)
        Me.radSimsong.Name = "radSimsong"
        Me.radSimsong.Size = New System.Drawing.Size(83, 17)
        Me.radSimsong.TabIndex = 0
        Me.radSimsong.TabStop = True
        Me.radSimsong.Text = "Simsong AG"
        Me.radSimsong.UseVisualStyleBackColor = True
        '
        'radIPound
        '
        Me.radIPound.AutoSize = True
        Me.radIPound.Location = New System.Drawing.Point(7, 67)
        Me.radIPound.Name = "radIPound"
        Me.radIPound.Size = New System.Drawing.Size(75, 17)
        Me.radIPound.TabIndex = 1
        Me.radIPound.TabStop = True
        Me.radIPound.Text = "iPound XV"
        Me.radIPound.UseVisualStyleBackColor = True
        '
        'radCustomerPhone
        '
        Me.radCustomerPhone.AutoSize = True
        Me.radCustomerPhone.Checked = True
        Me.radCustomerPhone.Location = New System.Drawing.Point(7, 103)
        Me.radCustomerPhone.Name = "radCustomerPhone"
        Me.radCustomerPhone.Size = New System.Drawing.Size(128, 17)
        Me.radCustomerPhone.TabIndex = 2
        Me.radCustomerPhone.TabStop = True
        Me.radCustomerPhone.Text = "Use Your Own Phone"
        Me.radCustomerPhone.UseVisualStyleBackColor = True
        '
        'chkSMS
        '
        Me.chkSMS.AutoSize = True
        Me.chkSMS.Location = New System.Drawing.Point(6, 31)
        Me.chkSMS.Name = "chkSMS"
        Me.chkSMS.Size = New System.Drawing.Size(93, 17)
        Me.chkSMS.TabIndex = 0
        Me.chkSMS.Text = "Unlimited Text"
        Me.chkSMS.UseVisualStyleBackColor = True
        '
        'chkVideo
        '
        Me.chkVideo.AutoSize = True
        Me.chkVideo.Location = New System.Drawing.Point(7, 67)
        Me.chkVideo.Name = "chkVideo"
        Me.chkVideo.Size = New System.Drawing.Size(78, 17)
        Me.chkVideo.TabIndex = 1
        Me.chkVideo.Text = "Video Chat"
        Me.chkVideo.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(76, 270)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 17
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(292, 270)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 20
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(522, 270)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tax"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(451, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Monthly Fee"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.Text = "Sell Your Soul for a Phone"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radUnlimited As RadioButton
    Friend WithEvents radFifteenHundred As RadioButton
    Friend WithEvents radEightHundred As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radCustomerPhone As RadioButton
    Friend WithEvents radIPound As RadioButton
    Friend WithEvents radSimsong As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkVideo As CheckBox
    Friend WithEvents chkSMS As CheckBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
