<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZip
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
        Me.btnHarrison = New System.Windows.Forms.Button()
        Me.btnNorwood = New System.Windows.Forms.Button()
        Me.btnErlanger = New System.Windows.Forms.Button()
        Me.btnFlorence = New System.Windows.Forms.Button()
        Me.btnLawrenceburg = New System.Windows.Forms.Button()
        Me.btnRisingSun = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHarrison
        '
        Me.btnHarrison.Location = New System.Drawing.Point(118, 67)
        Me.btnHarrison.Name = "btnHarrison"
        Me.btnHarrison.Size = New System.Drawing.Size(104, 23)
        Me.btnHarrison.TabIndex = 0
        Me.btnHarrison.Text = "Harrison, OH"
        Me.btnHarrison.UseVisualStyleBackColor = True
        '
        'btnNorwood
        '
        Me.btnNorwood.Location = New System.Drawing.Point(118, 96)
        Me.btnNorwood.Name = "btnNorwood"
        Me.btnNorwood.Size = New System.Drawing.Size(104, 23)
        Me.btnNorwood.TabIndex = 1
        Me.btnNorwood.Text = "Norwood, OH"
        Me.btnNorwood.UseVisualStyleBackColor = True
        '
        'btnErlanger
        '
        Me.btnErlanger.Location = New System.Drawing.Point(118, 125)
        Me.btnErlanger.Name = "btnErlanger"
        Me.btnErlanger.Size = New System.Drawing.Size(104, 23)
        Me.btnErlanger.TabIndex = 2
        Me.btnErlanger.Text = "Erlanger, KY"
        Me.btnErlanger.UseVisualStyleBackColor = True
        '
        'btnFlorence
        '
        Me.btnFlorence.Location = New System.Drawing.Point(118, 154)
        Me.btnFlorence.Name = "btnFlorence"
        Me.btnFlorence.Size = New System.Drawing.Size(104, 23)
        Me.btnFlorence.TabIndex = 3
        Me.btnFlorence.Text = "Florence, KY"
        Me.btnFlorence.UseVisualStyleBackColor = True
        '
        'btnLawrenceburg
        '
        Me.btnLawrenceburg.Location = New System.Drawing.Point(118, 183)
        Me.btnLawrenceburg.Name = "btnLawrenceburg"
        Me.btnLawrenceburg.Size = New System.Drawing.Size(104, 23)
        Me.btnLawrenceburg.TabIndex = 4
        Me.btnLawrenceburg.Text = "Lawrenceburg, IN"
        Me.btnLawrenceburg.UseVisualStyleBackColor = True
        '
        'btnRisingSun
        '
        Me.btnRisingSun.Location = New System.Drawing.Point(118, 212)
        Me.btnRisingSun.Name = "btnRisingSun"
        Me.btnRisingSun.Size = New System.Drawing.Size(104, 23)
        Me.btnRisingSun.TabIndex = 5
        Me.btnRisingSun.Text = "Rising Sun, IN"
        Me.btnRisingSun.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(346, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblZip
        '
        Me.lblZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZip.Location = New System.Drawing.Point(348, 151)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(100, 23)
        Me.lblZip.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Zip Code:"
        '
        'frmZip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRisingSun)
        Me.Controls.Add(Me.btnLawrenceburg)
        Me.Controls.Add(Me.btnFlorence)
        Me.Controls.Add(Me.btnErlanger)
        Me.Controls.Add(Me.btnNorwood)
        Me.Controls.Add(Me.btnHarrison)
        Me.Name = "frmZip"
        Me.Text = "Find A Zip Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHarrison As Button
    Friend WithEvents btnNorwood As Button
    Friend WithEvents btnErlanger As Button
    Friend WithEvents btnFlorence As Button
    Friend WithEvents btnLawrenceburg As Button
    Friend WithEvents btnRisingSun As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblZip As Label
    Friend WithEvents Label1 As Label
End Class
