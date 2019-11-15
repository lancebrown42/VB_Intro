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
        Me.btnLease = New System.Windows.Forms.Button()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLease
        '
        Me.btnLease.Location = New System.Drawing.Point(33, 26)
        Me.btnLease.Name = "btnLease"
        Me.btnLease.Size = New System.Drawing.Size(75, 65)
        Me.btnLease.TabIndex = 0
        Me.btnLease.Text = "Lease an Auto"
        Me.btnLease.UseVisualStyleBackColor = True
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(159, 26)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 65)
        Me.btnPurchase.TabIndex = 1
        Me.btnPurchase.Text = "Purchase an Auto"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(90, 119)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 166)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.btnLease)
        Me.Name = "frmMain"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLease As Button
    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnExit As Button
End Class
