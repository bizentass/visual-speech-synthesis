<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainfrm
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
        Me.Cancelbtn = New System.Windows.Forms.Button
        Me.Okbtn = New System.Windows.Forms.Button
        Me.femalebtn = New System.Windows.Forms.RadioButton
        Me.realbtn = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Location = New System.Drawing.Point(203, 291)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(84, 37)
        Me.Cancelbtn.TabIndex = 9
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = True
        '
        'Okbtn
        '
        Me.Okbtn.Location = New System.Drawing.Point(50, 291)
        Me.Okbtn.Name = "Okbtn"
        Me.Okbtn.Size = New System.Drawing.Size(75, 37)
        Me.Okbtn.TabIndex = 8
        Me.Okbtn.Text = "Ok"
        Me.Okbtn.UseVisualStyleBackColor = True
        '
        'femalebtn
        '
        Me.femalebtn.AutoSize = True
        Me.femalebtn.Location = New System.Drawing.Point(131, 199)
        Me.femalebtn.Name = "femalebtn"
        Me.femalebtn.Size = New System.Drawing.Size(91, 17)
        Me.femalebtn.TabIndex = 6
        Me.femalebtn.TabStop = True
        Me.femalebtn.Text = "Female Model"
        Me.femalebtn.UseVisualStyleBackColor = True
        '
        'realbtn
        '
        Me.realbtn.AutoSize = True
        Me.realbtn.Location = New System.Drawing.Point(131, 228)
        Me.realbtn.Name = "realbtn"
        Me.realbtn.Size = New System.Drawing.Size(136, 17)
        Me.realbtn.TabIndex = 10
        Me.realbtn.TabStop = True
        Me.realbtn.Text = "Real Time Photo Model"
        Me.realbtn.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(131, 168)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male Model"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(113, 95)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(131, 16)
        Me.Label.TabIndex = 12
        Me.Label.Text = "WELCOME TO REALTALK!"
        '
        'Mainfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 371)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.femalebtn)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.realbtn)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Okbtn)
        Me.Name = "Mainfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mainfrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancelbtn As System.Windows.Forms.Button
    Friend WithEvents Okbtn As System.Windows.Forms.Button
    Friend WithEvents femalebtn As System.Windows.Forms.RadioButton
    Friend WithEvents realbtn As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label As System.Windows.Forms.Label
End Class
