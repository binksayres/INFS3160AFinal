<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interface_1
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
        Me.txt_answers = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_question = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_answers
        '
        Me.txt_answers.Location = New System.Drawing.Point(21, 59)
        Me.txt_answers.MaxLength = 150
        Me.txt_answers.Name = "txt_answers"
        Me.txt_answers.Size = New System.Drawing.Size(365, 20)
        Me.txt_answers.TabIndex = 0
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(18, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(85, 13)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Question 1 of 10"
        '
        'lbl_question
        '
        Me.lbl_question.AutoSize = True
        Me.lbl_question.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_question.Location = New System.Drawing.Point(18, 39)
        Me.lbl_question.Name = "lbl_question"
        Me.lbl_question.Size = New System.Drawing.Size(196, 17)
        Me.lbl_question.TabIndex = 2
        Me.lbl_question.Text = "What is the name of the item?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "<-  Previous"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(161, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(295, 85)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 28)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Next  ->"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Interface_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 127)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_question)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.txt_answers)
        Me.Name = "Interface_1"
        Me.Text = "Interface_1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_answers As System.Windows.Forms.TextBox
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents lbl_question As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
