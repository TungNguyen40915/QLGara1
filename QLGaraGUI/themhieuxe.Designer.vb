<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class themhieuxe
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbmahieuxe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbtenhieuxe = New System.Windows.Forms.TextBox()
        Me.btluu = New System.Windows.Forms.Button()
        Me.btthoat = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbmahieuxe)
        Me.Panel1.Location = New System.Drawing.Point(12, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 53)
        Me.Panel1.TabIndex = 0
        '
        'tbmahieuxe
        '
        Me.tbmahieuxe.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbmahieuxe.Location = New System.Drawing.Point(241, 3)
        Me.tbmahieuxe.Name = "tbmahieuxe"
        Me.tbmahieuxe.ReadOnly = True
        Me.tbmahieuxe.Size = New System.Drawing.Size(657, 44)
        Me.tbmahieuxe.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã hiệu xe"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tbtenhieuxe)
        Me.Panel2.Location = New System.Drawing.Point(12, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(901, 66)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên hiệu xe"
        '
        'tbtenhieuxe
        '
        Me.tbtenhieuxe.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtenhieuxe.Location = New System.Drawing.Point(241, 3)
        Me.tbtenhieuxe.Name = "tbtenhieuxe"
        Me.tbtenhieuxe.Size = New System.Drawing.Size(657, 44)
        Me.tbtenhieuxe.TabIndex = 0
        '
        'btluu
        '
        Me.btluu.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btluu.Location = New System.Drawing.Point(216, 217)
        Me.btluu.Name = "btluu"
        Me.btluu.Size = New System.Drawing.Size(173, 59)
        Me.btluu.TabIndex = 3
        Me.btluu.Text = "Lưu"
        Me.btluu.UseVisualStyleBackColor = True
        '
        'btthoat
        '
        Me.btthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.Location = New System.Drawing.Point(436, 217)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(173, 59)
        Me.btthoat.TabIndex = 4
        Me.btthoat.Text = "Thoát"
        Me.btthoat.UseVisualStyleBackColor = True
        '
        'themhieuxe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 288)
        Me.Controls.Add(Me.btthoat)
        Me.Controls.Add(Me.btluu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "themhieuxe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm hiệu xe"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tbmahieuxe As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tbtenhieuxe As TextBox
    Friend WithEvents btluu As Button
    Friend WithEvents btthoat As Button
End Class
