<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dangnhap
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
        Me.lbloi = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbmatkhau = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbtaikhoan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btdangnhap = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbloi
        '
        Me.lbloi.AutoSize = True
        Me.lbloi.ForeColor = System.Drawing.Color.Red
        Me.lbloi.Location = New System.Drawing.Point(246, 229)
        Me.lbloi.Name = "lbloi"
        Me.lbloi.Size = New System.Drawing.Size(275, 20)
        Me.lbloi.TabIndex = 7
        Me.lbloi.Text = "Sai tên mật khẩu hoặc tên đăng nhập"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbmatkhau)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(16, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(622, 100)
        Me.Panel2.TabIndex = 6
        '
        'tbmatkhau
        '
        Me.tbmatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbmatkhau.Location = New System.Drawing.Point(220, 35)
        Me.tbmatkhau.Name = "tbmatkhau"
        Me.tbmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbmatkhau.Size = New System.Drawing.Size(372, 35)
        Me.tbmatkhau.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(54, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mật Khẩu"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbtaikhoan)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(16, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 100)
        Me.Panel1.TabIndex = 5
        '
        'tbtaikhoan
        '
        Me.tbtaikhoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbtaikhoan.Location = New System.Drawing.Point(220, 35)
        Me.tbtaikhoan.Name = "tbtaikhoan"
        Me.tbtaikhoan.Size = New System.Drawing.Size(372, 35)
        Me.tbtaikhoan.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(54, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tài Khoản"
        '
        'btdangnhap
        '
        Me.btdangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btdangnhap.Location = New System.Drawing.Point(237, 278)
        Me.btdangnhap.Name = "btdangnhap"
        Me.btdangnhap.Size = New System.Drawing.Size(261, 95)
        Me.btdangnhap.TabIndex = 0
        Me.btdangnhap.Text = "Đăng Nhập"
        Me.btdangnhap.UseVisualStyleBackColor = True
        '
        'dangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 380)
        Me.Controls.Add(Me.lbloi)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btdangnhap)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "dangnhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbloi As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbmatkhau As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbtaikhoan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btdangnhap As Button
End Class
