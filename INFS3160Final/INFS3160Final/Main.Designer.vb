<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.cmd_Tokenizer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_UserName = New System.Windows.Forms.TextBox()
        Me.cmd_Interface1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd_Tokenizer
        '
        Me.cmd_Tokenizer.Location = New System.Drawing.Point(262, 235)
        Me.cmd_Tokenizer.Name = "cmd_Tokenizer"
        Me.cmd_Tokenizer.Size = New System.Drawing.Size(111, 44)
        Me.cmd_Tokenizer.TabIndex = 0
        Me.cmd_Tokenizer.Text = "Tokenizer Demo"
        Me.cmd_Tokenizer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Interface Testing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tester's Name"
        '
        'txt_UserName
        '
        Me.txt_UserName.Location = New System.Drawing.Point(96, 52)
        Me.txt_UserName.MaxLength = 100
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.Size = New System.Drawing.Size(247, 20)
        Me.txt_UserName.TabIndex = 3
        '
        'cmd_Interface1
        '
        Me.cmd_Interface1.Location = New System.Drawing.Point(42, 121)
        Me.cmd_Interface1.Name = "cmd_Interface1"
        Me.cmd_Interface1.Size = New System.Drawing.Size(81, 80)
        Me.cmd_Interface1.TabIndex = 4
        Me.cmd_Interface1.Text = "OPEN INTERFACE 1"
        Me.cmd_Interface1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 80)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "OPEN INTERFACE 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(262, 121)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 80)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "OPEN INTERFACE 3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 235)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 44)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "New Test"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(156, 235)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 44)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 291)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmd_Interface1)
        Me.Controls.Add(Me.txt_UserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_Tokenizer)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_Tokenizer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_UserName As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Interface1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
