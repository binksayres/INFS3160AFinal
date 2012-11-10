<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TokenizerDemo
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
        Me.txt_Message = New System.Windows.Forms.TextBox()
        Me.lst_Tokens = New System.Windows.Forms.ListBox()
        Me.cmd_Run = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_Message
        '
        Me.txt_Message.Location = New System.Drawing.Point(26, 41)
        Me.txt_Message.Name = "txt_Message"
        Me.txt_Message.Size = New System.Drawing.Size(362, 20)
        Me.txt_Message.TabIndex = 0
        '
        'lst_Tokens
        '
        Me.lst_Tokens.FormattingEnabled = True
        Me.lst_Tokens.Location = New System.Drawing.Point(139, 133)
        Me.lst_Tokens.Name = "lst_Tokens"
        Me.lst_Tokens.Size = New System.Drawing.Size(226, 368)
        Me.lst_Tokens.TabIndex = 1
        '
        'cmd_Run
        '
        Me.cmd_Run.Location = New System.Drawing.Point(410, 42)
        Me.cmd_Run.Name = "cmd_Run"
        Me.cmd_Run.Size = New System.Drawing.Size(83, 35)
        Me.cmd_Run.TabIndex = 2
        Me.cmd_Run.Text = "Button1"
        Me.cmd_Run.UseVisualStyleBackColor = True
        '
        'TokenizerDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 558)
        Me.Controls.Add(Me.cmd_Run)
        Me.Controls.Add(Me.lst_Tokens)
        Me.Controls.Add(Me.txt_Message)
        Me.Name = "TokenizerDemo"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Message As System.Windows.Forms.TextBox
    Friend WithEvents lst_Tokens As System.Windows.Forms.ListBox
    Friend WithEvents cmd_Run As System.Windows.Forms.Button

End Class
