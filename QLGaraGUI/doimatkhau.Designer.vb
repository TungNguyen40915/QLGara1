<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doimatkhau
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbxnmk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbmkm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbmkht = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(303, 237)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Đổi Mật Khẩu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tbxnmk)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(35, 159)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(554, 65)
        Me.Panel3.TabIndex = 5
        '
        'tbxnmk
        '
        Me.tbxnmk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbxnmk.Location = New System.Drawing.Point(227, 20)
        Me.tbxnmk.Margin = New System.Windows.Forms.Padding(2)
        Me.tbxnmk.Name = "tbxnmk"
        Me.tbxnmk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxnmk.Size = New System.Drawing.Size(294, 26)
        Me.tbxnmk.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(25, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mật Khẩu Mới (Nhập Lại)"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbmkm)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(35, 90)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(554, 65)
        Me.Panel2.TabIndex = 6
        '
        'tbmkm
        '
        Me.tbmkm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbmkm.Location = New System.Drawing.Point(227, 24)
        Me.tbmkm.Margin = New System.Windows.Forms.Padding(2)
        Me.tbmkm.Name = "tbmkm"
        Me.tbmkm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbmkm.Size = New System.Drawing.Size(294, 26)
        Me.tbmkm.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(25, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mật Khẩu Mới"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbmkht)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(35, 21)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 65)
        Me.Panel1.TabIndex = 4
        '
        'tbmkht
        '
        Me.tbmkht.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbmkht.Location = New System.Drawing.Point(227, 22)
        Me.tbmkht.Margin = New System.Windows.Forms.Padding(2)
        Me.tbmkht.Name = "tbmkht"
        Me.tbmkht.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbmkht.Size = New System.Drawing.Size(294, 26)
        Me.tbmkht.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mật Khẩu Hiện Tại"
        '
        'doimatkhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 283)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "doimatkhau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đổi mật khẩu"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tbxnmk As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbmkm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbmkht As TextBox
    Friend WithEvents Label1 As Label
End Class
