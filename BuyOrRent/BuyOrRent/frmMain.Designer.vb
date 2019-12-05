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
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(55, 86)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(89, 55)
        Me.btnBuy.TabIndex = 0
        Me.btnBuy.Text = "Buy"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'btnRent
        '
        Me.btnRent.Location = New System.Drawing.Point(210, 86)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(89, 55)
        Me.btnRent.TabIndex = 1
        Me.btnRent.Text = "Rent"
        Me.btnRent.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(139, 193)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(168, 35)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 20)
        Me.txtValue.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Home Value"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 256)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRent)
        Me.Controls.Add(Me.btnBuy)
        Me.Name = "frmMain"
        Me.Text = "Home Payment Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuy As Button
    Friend WithEvents btnRent As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtValue As TextBox
    Friend WithEvents Label1 As Label
End Class
