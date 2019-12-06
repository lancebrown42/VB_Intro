<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnHourly = New System.Windows.Forms.Button()
        Me.btnSalary = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHourly
        '
        Me.btnHourly.Location = New System.Drawing.Point(12, 38)
        Me.btnHourly.Name = "btnHourly"
        Me.btnHourly.Size = New System.Drawing.Size(186, 136)
        Me.btnHourly.TabIndex = 0
        Me.btnHourly.Text = "Hourly"
        Me.btnHourly.UseVisualStyleBackColor = True
        '
        'btnSalary
        '
        Me.btnSalary.Location = New System.Drawing.Point(216, 38)
        Me.btnSalary.Name = "btnSalary"
        Me.btnSalary.Size = New System.Drawing.Size(186, 136)
        Me.btnSalary.TabIndex = 1
        Me.btnSalary.Text = "Salaried"
        Me.btnSalary.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(169, 212)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 283)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSalary)
        Me.Controls.Add(Me.btnHourly)
        Me.Name = "frmMain"
        Me.Text = "In this world nothing can be said to be certain except..."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHourly As Button
    Friend WithEvents btnSalary As Button
    Friend WithEvents btnClose As Button
End Class
