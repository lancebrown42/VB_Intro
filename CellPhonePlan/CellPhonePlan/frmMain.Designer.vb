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
        Me.grpPlans = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFamily = New System.Windows.Forms.Button()
        Me.btnIndividual = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpPlans.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPlans
        '
        Me.grpPlans.Controls.Add(Me.Label2)
        Me.grpPlans.Controls.Add(Me.Label1)
        Me.grpPlans.Controls.Add(Me.btnFamily)
        Me.grpPlans.Controls.Add(Me.btnIndividual)
        Me.grpPlans.Location = New System.Drawing.Point(40, 46)
        Me.grpPlans.Name = "grpPlans"
        Me.grpPlans.Size = New System.Drawing.Size(459, 292)
        Me.grpPlans.TabIndex = 0
        Me.grpPlans.TabStop = False
        Me.grpPlans.Text = "Select a Plan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 78)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "The Family Plan allows" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you to purchase" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "multiple cell phones of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the same model," &
    " with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "each phone sharing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "one monthly package"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 52)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "The Individual Plan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "provides one cell phone " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and a variety of monthly " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "packag" &
    "es."
        '
        'btnFamily
        '
        Me.btnFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamily.Location = New System.Drawing.Point(247, 165)
        Me.btnFamily.Name = "btnFamily"
        Me.btnFamily.Size = New System.Drawing.Size(165, 65)
        Me.btnFamily.TabIndex = 1
        Me.btnFamily.Text = "Family Plan"
        Me.btnFamily.UseVisualStyleBackColor = True
        '
        'btnIndividual
        '
        Me.btnIndividual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIndividual.Location = New System.Drawing.Point(247, 43)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(165, 65)
        Me.btnIndividual.TabIndex = 0
        Me.btnIndividual.Text = "Individual Plan"
        Me.btnIndividual.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(287, 358)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(165, 65)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpPlans)
        Me.Name = "frmMain"
        Me.Text = "Cell Phone Packages"
        Me.grpPlans.ResumeLayout(False)
        Me.grpPlans.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpPlans As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFamily As Button
    Friend WithEvents btnIndividual As Button
    Friend WithEvents btnExit As Button
End Class
