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
        Me.lbloi.Location = New System.Drawing.Point(164, 149)
        Me.lbloi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbloi.Name = "lbloi"
        Me.lbloi.Size = New System.Drawing.Size(187, 13)
        Me.lbloi.TabIndex = 7
        Me.lbloi.Text = "Sai tên mật khẩu hoặc tên đăng nhập"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbmatkhau)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(11, 80)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(415, 65)
        Me.Panel2.TabIndex = 6
        '
        'tbmatkhau
        '
        Me.tbmatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbmatkhau.Location = New System.Drawing.Point(147, 23)
        Me.tbmatkhau.Margin = New System.Windows.Forms.Padding(2)
        Me.tbmatkhau.Name = "tbmatkhau"
        Me.tbmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbmatkhau.Size = New System.Drawing.Size(249, 26)
        Me.tbmatkhau.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(36, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mật Khẩu"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbtaikhoan)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(11, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 65)
        Me.Panel1.TabIndex = 5
        '
        'tbtaikhoan
        '
        Me.tbtaikhoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbtaikhoan.Location = New System.Drawing.Point(147, 23)
        Me.tbtaikhoan.Margin = New System.Windows.Forms.Padding(2)
        Me.tbtaikhoan.Name = "tbtaikhoan"
        Me.tbtaikhoan.Size = New System.Drawing.Size(249, 26)
        Me.tbtaikhoan.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(36, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tài Khoản"
        '
        'btdangnhap
        '
        Me.btdangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btdangnhap.Location = New System.Drawing.Point(158, 181)
        Me.btdangnhap.Margin = New System.Windows.Forms.Padding(2)
        Me.btdangnhap.Name = "btdangnhap"
        Me.btdangnhap.Size = New System.Drawing.Size(174, 62)
        Me.btdangnhap.TabIndex = 4
        Me.btdangnhap.Text = "Đăng Nhập"
        Me.btdangnhap.UseVisualStyleBackColor = True
        '
        'dangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 247)
        Me.Controls.Add(Me.lbloi)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btdangnhap)
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
