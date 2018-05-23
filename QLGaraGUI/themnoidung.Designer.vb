<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class themnoidung
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbtennoidung = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbmanoidung = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btluu = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tbtiencong = New System.Windows.Forms.TextBox()
        Me.lbtiencong = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 250)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tbtennoidung)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(9, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(623, 64)
        Me.Panel3.TabIndex = 2
        '
        'tbtennoidung
        '
        Me.tbtennoidung.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtennoidung.Location = New System.Drawing.Point(294, 16)
        Me.tbtennoidung.Name = "tbtennoidung"
        Me.tbtennoidung.Size = New System.Drawing.Size(306, 39)
        Me.tbtennoidung.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên Nội Dung"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbmanoidung)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(9, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(623, 64)
        Me.Panel2.TabIndex = 0
        '
        'tbmanoidung
        '
        Me.tbmanoidung.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbmanoidung.Location = New System.Drawing.Point(294, 16)
        Me.tbmanoidung.Name = "tbmanoidung"
        Me.tbmanoidung.ReadOnly = True
        Me.tbmanoidung.Size = New System.Drawing.Size(306, 39)
        Me.tbmanoidung.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Nội Dung"
        '
        'btluu
        '
        Me.btluu.Location = New System.Drawing.Point(231, 287)
        Me.btluu.Name = "btluu"
        Me.btluu.Size = New System.Drawing.Size(170, 48)
        Me.btluu.TabIndex = 2
        Me.btluu.Text = "Lưu"
        Me.btluu.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tbtiencong)
        Me.Panel4.Controls.Add(Me.lbtiencong)
        Me.Panel4.Location = New System.Drawing.Point(9, 154)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(623, 64)
        Me.Panel4.TabIndex = 3
        '
        'tbtiencong
        '
        Me.tbtiencong.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtiencong.Location = New System.Drawing.Point(294, 16)
        Me.tbtiencong.Name = "tbtiencong"
        Me.tbtiencong.Size = New System.Drawing.Size(306, 39)
        Me.tbtiencong.TabIndex = 1
        '
        'lbtiencong
        '
        Me.lbtiencong.AutoSize = True
        Me.lbtiencong.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtiencong.Location = New System.Drawing.Point(26, 16)
        Me.lbtiencong.Name = "lbtiencong"
        Me.lbtiencong.Size = New System.Drawing.Size(146, 32)
        Me.lbtiencong.TabIndex = 0
        Me.lbtiencong.Text = "Tiền Công"
        '
        'themnoidung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 347)
        Me.Controls.Add(Me.btluu)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "themnoidung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Nội Dung"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tbtennoidung As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbmanoidung As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btluu As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tbtiencong As TextBox
    Friend WithEvents lbtiencong As Label
End Class
