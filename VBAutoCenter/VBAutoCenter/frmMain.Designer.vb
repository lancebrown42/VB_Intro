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
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.btnLease = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(43, 76)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 61)
        Me.btnPurchase.TabIndex = 0
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'btnLease
        '
        Me.btnLease.Location = New System.Drawing.Point(292, 76)
        Me.btnLease.Name = "btnLease"
        Me.btnLease.Size = New System.Drawing.Size(75, 61)
        Me.btnLease.TabIndex = 1
        Me.btnLease.Text = "Lease"
        Me.btnLease.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(159, 167)
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
        Me.ClientSize = New System.Drawing.Size(439, 277)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLease)
        Me.Controls.Add(Me.btnPurchase)
        Me.Name = "frmMain"
        Me.Text = "Auto Program"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnLease As Button
    Friend WithEvents btnClose As Button
End Class
