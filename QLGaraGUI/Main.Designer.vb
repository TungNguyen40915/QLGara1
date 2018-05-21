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
        Me.bttracuuxe.Location = New System.Drawing.Point(87, 194)
        Me.bttracuuxe.Name = "bttracuuxe"
        Me.bttracuuxe.Size = New System.Drawing.Size(135, 57)
        Me.bttracuuxe.TabIndex = 1
        Me.bttracuuxe.Text = "Tra cứu xe"
        Me.bttracuuxe.UseVisualStyleBackColor = True
        '
        'btlapphieuthu
        '
        Me.btlapphieuthu.Location = New System.Drawing.Point(87, 288)
        Me.btlapphieuthu.Name = "btlapphieuthu"
        Me.btlapphieuthu.Size = New System.Drawing.Size(135, 57)
        Me.btlapphieuthu.TabIndex = 2
        Me.btlapphieuthu.Text = "Lập Phiếu Thu"
        Me.btlapphieuthu.UseVisualStyleBackColor = True
        '
        'btlapbaocaotheothang
        '
        Me.btlapbaocaotheothang.Location = New System.Drawing.Point(87, 379)
        Me.btlapbaocaotheothang.Name = "btlapbaocaotheothang"
        Me.btlapbaocaotheothang.Size = New System.Drawing.Size(345, 57)
        Me.btlapbaocaotheothang.TabIndex = 3
        Me.btlapbaocaotheothang.Text = "Lập Báo Cáo Doanh Thu Theo Tháng"
        Me.btlapbaocaotheothang.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 538)
        Me.Controls.Add(Me.btlapbaocaotheothang)
        Me.Controls.Add(Me.btlapphieuthu)
        Me.Controls.Add(Me.bttracuuxe)
        Me.Controls.Add(Me.bttiepnhanxe)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bttiepnhanxe As Button
    Friend WithEvents bttracuuxe As Button
    Friend WithEvents btlapphieuthu As Button
    Friend WithEvents btlapbaocaotheothang As Button
End Class
