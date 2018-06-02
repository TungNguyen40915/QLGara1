<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.bttiepnhanxe = New System.Windows.Forms.Button()
        Me.bttracuuxe = New System.Windows.Forms.Button()
        Me.btlapphieuthu = New System.Windows.Forms.Button()
        Me.btlapbaocaotheothang = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttiepnhanxe
        '
        Me.bttiepnhanxe.Location = New System.Drawing.Point(87, 87)
        Me.bttiepnhanxe.Name = "bttiepnhanxe"
        Me.bttiepnhanxe.Size = New System.Drawing.Size(135, 57)
        Me.bttiepnhanxe.TabIndex = 0
        Me.bttiepnhanxe.Text = "Tiếp Nhận Xe"
        Me.bttiepnhanxe.UseVisualStyleBackColor = True
        '
        'bttracuuxe
        '
        Me.bttracuuxe.Location = New System.Drawing.Point(87, 253)
        Me.bttracuuxe.Name = "bttracuuxe"
        Me.bttracuuxe.Size = New System.Drawing.Size(135, 57)
        Me.bttracuuxe.TabIndex = 1
        Me.bttracuuxe.Text = "Tra cứu xe"
        Me.bttracuuxe.UseVisualStyleBackColor = True
        '
        'btlapphieuthu
        '
        Me.btlapphieuthu.Location = New System.Drawing.Point(87, 380)
        Me.btlapphieuthu.Name = "btlapphieuthu"
        Me.btlapphieuthu.Size = New System.Drawing.Size(135, 57)
        Me.btlapphieuthu.TabIndex = 2
        Me.btlapphieuthu.Text = "Lập Phiếu Thu"
        Me.btlapphieuthu.UseVisualStyleBackColor = True
        '
        'btlapbaocaotheothang
        '
        Me.btlapbaocaotheothang.Location = New System.Drawing.Point(87, 459)
        Me.btlapbaocaotheothang.Name = "btlapbaocaotheothang"
        Me.btlapbaocaotheothang.Size = New System.Drawing.Size(345, 57)
        Me.btlapbaocaotheothang.TabIndex = 3
        Me.btlapbaocaotheothang.Text = "Lập Báo Cáo Doanh Thu Theo Tháng"
        Me.btlapbaocaotheothang.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(345, 57)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Lập Phiếu Sửa Chữa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(87, 536)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(345, 57)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Lập Báo Cáo Vật Tư"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 605)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btlapbaocaotheothang)
        Me.Controls.Add(Me.btlapphieuthu)
        Me.Controls.Add(Me.bttracuuxe)
        Me.Controls.Add(Me.bttiepnhanxe)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bttiepnhanxe As Button
    Friend WithEvents bttracuuxe As Button
    Friend WithEvents btlapphieuthu As Button
    Friend WithEvents btlapbaocaotheothang As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
