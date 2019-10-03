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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radSubscribe = New System.Windows.Forms.RadioButton()
        Me.radPurchase = New System.Windows.Forms.RadioButton()
        Me.chkSupport = New System.Windows.Forms.CheckBox()
        Me.chkTraining = New System.Windows.Forms.CheckBox()
        Me.chkBackup = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblSoftwareCost = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAnnual = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radPurchase)
        Me.GroupBox1.Controls.Add(Me.radSubscribe)
        Me.GroupBox1.Location = New System.Drawing.Point(94, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 195)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Options"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBackup)
        Me.GroupBox2.Controls.Add(Me.chkTraining)
        Me.GroupBox2.Controls.Add(Me.chkSupport)
        Me.GroupBox2.Location = New System.Drawing.Point(401, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 189)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add On Features"
        '
        'radSubscribe
        '
        Me.radSubscribe.AutoSize = True
        Me.radSubscribe.Checked = True
        Me.radSubscribe.Location = New System.Drawing.Point(23, 51)
        Me.radSubscribe.Name = "radSubscribe"
        Me.radSubscribe.Size = New System.Drawing.Size(83, 17)
        Me.radSubscribe.TabIndex = 0
        Me.radSubscribe.TabStop = True
        Me.radSubscribe.Text = "Subscription"
        Me.radSubscribe.UseVisualStyleBackColor = True
        '
        'radPurchase
        '
        Me.radPurchase.AutoSize = True
        Me.radPurchase.Location = New System.Drawing.Point(23, 118)
        Me.radPurchase.Name = "radPurchase"
        Me.radPurchase.Size = New System.Drawing.Size(70, 17)
        Me.radPurchase.TabIndex = 1
        Me.radPurchase.Text = "Purchase"
        Me.radPurchase.UseVisualStyleBackColor = True
        '
        'chkSupport
        '
        Me.chkSupport.AutoSize = True
        Me.chkSupport.Location = New System.Drawing.Point(36, 46)
        Me.chkSupport.Name = "chkSupport"
        Me.chkSupport.Size = New System.Drawing.Size(89, 17)
        Me.chkSupport.TabIndex = 0
        Me.chkSupport.Text = "24/7 Support"
        Me.chkSupport.UseVisualStyleBackColor = True
        '
        'chkTraining
        '
        Me.chkTraining.AutoSize = True
        Me.chkTraining.Location = New System.Drawing.Point(36, 87)
        Me.chkTraining.Name = "chkTraining"
        Me.chkTraining.Size = New System.Drawing.Size(64, 17)
        Me.chkTraining.TabIndex = 1
        Me.chkTraining.Text = "Training"
        Me.chkTraining.UseVisualStyleBackColor = True
        '
        'chkBackup
        '
        Me.chkBackup.AutoSize = True
        Me.chkBackup.Location = New System.Drawing.Point(36, 129)
        Me.chkBackup.Name = "chkBackup"
        Me.chkBackup.Size = New System.Drawing.Size(94, 17)
        Me.chkBackup.TabIndex = 2
        Me.chkBackup.Text = "BackupServer"
        Me.chkBackup.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(114, 330)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(301, 330)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(470, 330)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblSoftwareCost
        '
        Me.lblSoftwareCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSoftwareCost.Location = New System.Drawing.Point(301, 296)
        Me.lblSoftwareCost.Name = "lblSoftwareCost"
        Me.lblSoftwareCost.Size = New System.Drawing.Size(100, 23)
        Me.lblSoftwareCost.TabIndex = 5
        Me.lblSoftwareCost.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cost:"
        '
        'lblAnnual
        '
        Me.lblAnnual.AutoSize = True
        Me.lblAnnual.Location = New System.Drawing.Point(407, 306)
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Size = New System.Drawing.Size(0, 13)
        Me.lblAnnual.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAnnual)
        Me.Controls.Add(Me.lblSoftwareCost)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Please Don't Read the TOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radPurchase As RadioButton
    Friend WithEvents radSubscribe As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkBackup As CheckBox
    Friend WithEvents chkTraining As CheckBox
    Friend WithEvents chkSupport As CheckBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblSoftwareCost As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAnnual As Label
End Class
