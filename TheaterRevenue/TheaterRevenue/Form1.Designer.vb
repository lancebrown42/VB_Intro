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
        Me.txtAdultSold = New System.Windows.Forms.TextBox()
        Me.txtAdultPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtChildSold = New System.Windows.Forms.TextBox()
        Me.txtChildPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblGrossTotal = New System.Windows.Forms.Label()
        Me.lblGrossChildSold = New System.Windows.Forms.Label()
        Me.lblGrossAdultSold = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblNetTotal = New System.Windows.Forms.Label()
        Me.lblNetChildSold = New System.Windows.Forms.Label()
        Me.lblNetAdultSold = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAdultSold)
        Me.GroupBox1.Controls.Add(Me.txtAdultPrice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Ticket Sales"
        '
        'txtAdultSold
        '
        Me.txtAdultSold.Location = New System.Drawing.Point(143, 64)
        Me.txtAdultSold.Name = "txtAdultSold"
        Me.txtAdultSold.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultSold.TabIndex = 2
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.Location = New System.Drawing.Point(143, 20)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultPrice.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tickets Sold"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price per Ticket"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtChildSold)
        Me.GroupBox2.Controls.Add(Me.txtChildPrice)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Child Ticket Sales"
        '
        'txtChildSold
        '
        Me.txtChildSold.Location = New System.Drawing.Point(176, 57)
        Me.txtChildSold.Name = "txtChildSold"
        Me.txtChildSold.Size = New System.Drawing.Size(100, 20)
        Me.txtChildSold.TabIndex = 4
        '
        'txtChildPrice
        '
        Me.txtChildPrice.Location = New System.Drawing.Point(176, 13)
        Me.txtChildPrice.Name = "txtChildPrice"
        Me.txtChildPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtChildPrice.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tickets Sold"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Price per Ticket"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblGrossTotal)
        Me.GroupBox3.Controls.Add(Me.lblGrossChildSold)
        Me.GroupBox3.Controls.Add(Me.lblGrossAdultSold)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 209)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket Revenue"
        '
        'lblGrossTotal
        '
        Me.lblGrossTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossTotal.Location = New System.Drawing.Point(169, 152)
        Me.lblGrossTotal.Name = "lblGrossTotal"
        Me.lblGrossTotal.Size = New System.Drawing.Size(84, 39)
        Me.lblGrossTotal.TabIndex = 5
        '
        'lblGrossChildSold
        '
        Me.lblGrossChildSold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossChildSold.Location = New System.Drawing.Point(172, 86)
        Me.lblGrossChildSold.Name = "lblGrossChildSold"
        Me.lblGrossChildSold.Size = New System.Drawing.Size(81, 34)
        Me.lblGrossChildSold.TabIndex = 4
        '
        'lblGrossAdultSold
        '
        Me.lblGrossAdultSold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossAdultSold.Location = New System.Drawing.Point(172, 25)
        Me.lblGrossAdultSold.Name = "lblGrossAdultSold"
        Me.lblGrossAdultSold.Size = New System.Drawing.Size(81, 31)
        Me.lblGrossAdultSold.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(19, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 28)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Net Revenue for Ticket Sales"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Child Ticket Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adult Ticket Sales"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblNetTotal)
        Me.GroupBox4.Controls.Add(Me.lblNetChildSold)
        Me.GroupBox4.Controls.Add(Me.lblNetAdultSold)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(404, 208)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(304, 209)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Ticket Revenue"
        '
        'lblNetTotal
        '
        Me.lblNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetTotal.Location = New System.Drawing.Point(180, 144)
        Me.lblNetTotal.Name = "lblNetTotal"
        Me.lblNetTotal.Size = New System.Drawing.Size(76, 47)
        Me.lblNetTotal.TabIndex = 5
        '
        'lblNetChildSold
        '
        Me.lblNetChildSold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetChildSold.Location = New System.Drawing.Point(180, 78)
        Me.lblNetChildSold.Name = "lblNetChildSold"
        Me.lblNetChildSold.Size = New System.Drawing.Size(76, 34)
        Me.lblNetChildSold.TabIndex = 4
        '
        'lblNetAdultSold
        '
        Me.lblNetAdultSold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetAdultSold.Location = New System.Drawing.Point(180, 25)
        Me.lblNetAdultSold.Name = "lblNetAdultSold"
        Me.lblNetAdultSold.Size = New System.Drawing.Size(76, 36)
        Me.lblNetAdultSold.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(24, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 28)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Total Net Revenue for Ticket Sales"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Child Ticket Sales"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Adult Ticket Sales"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(23, 434)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(232, 39)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate Ticket Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(292, 434)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 39)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(500, 434)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 39)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 513)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Theater Revenue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAdultSold As TextBox
    Friend WithEvents txtAdultPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtChildSold As TextBox
    Friend WithEvents txtChildPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblGrossTotal As Label
    Friend WithEvents lblGrossChildSold As Label
    Friend WithEvents lblGrossAdultSold As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblNetTotal As Label
    Friend WithEvents lblNetChildSold As Label
    Friend WithEvents lblNetAdultSold As Label
End Class
