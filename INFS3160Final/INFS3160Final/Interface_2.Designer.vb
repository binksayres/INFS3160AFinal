<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interface_2
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
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.tab_Required = New System.Windows.Forms.TabPage()
        Me.tab_additional = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.chk_Rechargeable = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tabs.SuspendLayout()
        Me.tab_Required.SuspendLayout()
        Me.tab_additional.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.tab_Required)
        Me.tabs.Controls.Add(Me.tab_additional)
        Me.tabs.Location = New System.Drawing.Point(12, 12)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(349, 187)
        Me.tabs.TabIndex = 0
        '
        'tab_Required
        '
        Me.tab_Required.Controls.Add(Me.TextBox5)
        Me.tab_Required.Controls.Add(Me.TextBox4)
        Me.tab_Required.Controls.Add(Me.TextBox3)
        Me.tab_Required.Controls.Add(Me.TextBox2)
        Me.tab_Required.Controls.Add(Me.TextBox1)
        Me.tab_Required.Controls.Add(Me.Label5)
        Me.tab_Required.Controls.Add(Me.Label4)
        Me.tab_Required.Controls.Add(Me.Label3)
        Me.tab_Required.Controls.Add(Me.Label2)
        Me.tab_Required.Controls.Add(Me.Label1)
        Me.tab_Required.Location = New System.Drawing.Point(4, 22)
        Me.tab_Required.Name = "tab_Required"
        Me.tab_Required.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Required.Size = New System.Drawing.Size(341, 161)
        Me.tab_Required.TabIndex = 0
        Me.tab_Required.Text = "Required Information"
        Me.tab_Required.UseVisualStyleBackColor = True
        '
        'tab_additional
        '
        Me.tab_additional.Controls.Add(Me.chk_Rechargeable)
        Me.tab_additional.Controls.Add(Me.TextBox10)
        Me.tab_additional.Controls.Add(Me.TextBox9)
        Me.tab_additional.Controls.Add(Me.TextBox7)
        Me.tab_additional.Controls.Add(Me.TextBox6)
        Me.tab_additional.Controls.Add(Me.Label10)
        Me.tab_additional.Controls.Add(Me.Label9)
        Me.tab_additional.Controls.Add(Me.Label8)
        Me.tab_additional.Controls.Add(Me.Label7)
        Me.tab_additional.Controls.Add(Me.Label6)
        Me.tab_additional.Location = New System.Drawing.Point(4, 22)
        Me.tab_additional.Name = "tab_additional"
        Me.tab_additional.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_additional.Size = New System.Drawing.Size(411, 222)
        Me.tab_additional.TabIndex = 1
        Me.tab_additional.Text = "Additional Information"
        Me.tab_additional.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Battery Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Battery ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number in Package"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cost of Package"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "How long 1 lasts"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(127, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(127, 68)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(127, 94)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(127, 120)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Common Names"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Rechargable"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Vendor Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(66, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Vendor ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Weight Each"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(127, 16)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(192, 20)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(127, 42)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 6
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(127, 94)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 8
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(127, 120)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 9
        '
        'chk_Rechargeable
        '
        Me.chk_Rechargeable.AutoSize = True
        Me.chk_Rechargeable.Location = New System.Drawing.Point(127, 71)
        Me.chk_Rechargeable.Name = "chk_Rechargeable"
        Me.chk_Rechargeable.Size = New System.Drawing.Size(15, 14)
        Me.chk_Rechargeable.TabIndex = 10
        Me.chk_Rechargeable.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cancel Entry"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(268, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Submit Entry"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Interface_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 241)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tabs)
        Me.Name = "Interface_2"
        Me.Text = "Interface 2"
        Me.tabs.ResumeLayout(False)
        Me.tab_Required.ResumeLayout(False)
        Me.tab_Required.PerformLayout()
        Me.tab_additional.ResumeLayout(False)
        Me.tab_additional.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabs As System.Windows.Forms.TabControl
    Friend WithEvents tab_Required As System.Windows.Forms.TabPage
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tab_additional As System.Windows.Forms.TabPage
    Friend WithEvents chk_Rechargeable As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
