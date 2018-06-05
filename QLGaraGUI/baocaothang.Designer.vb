<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baocaothang
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
        Me.btload = New System.Windows.Forms.Button()
        Me.dgvchitiet = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tbdoanhthu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpngay = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbmabaocao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btluu = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvchitiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btload)
        Me.Panel1.Controls.Add(Me.dgvchitiet)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(730, 592)
        Me.Panel1.TabIndex = 0
        '
        'btload
        '
        Me.btload.Location = New System.Drawing.Point(261, 246)
        Me.btload.Name = "btload"
        Me.btload.Size = New System.Drawing.Size(196, 59)
        Me.btload.TabIndex = 2
        Me.btload.Text = "Load"
        Me.btload.UseVisualStyleBackColor = True
        '
        'dgvchitiet
        '
        Me.dgvchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvchitiet.Location = New System.Drawing.Point(27, 323)
        Me.dgvchitiet.Name = "dgvchitiet"
        Me.dgvchitiet.RowTemplate.Height = 28
        Me.dgvchitiet.Size = New System.Drawing.Size(685, 246)
        Me.dgvchitiet.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.tbdoanhthu)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(125, 159)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(543, 63)
        Me.Panel5.TabIndex = 2
        '
        'tbdoanhthu
        '
        Me.tbdoanhthu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbdoanhthu.Location = New System.Drawing.Point(264, 25)
        Me.tbdoanhthu.Name = "tbdoanhthu"
        Me.tbdoanhthu.ReadOnly = True
        Me.tbdoanhthu.Size = New System.Drawing.Size(260, 35)
        Me.tbdoanhthu.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tổng Doanh Thu"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtpngay)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(125, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(499, 63)
        Me.Panel3.TabIndex = 2
        '
        'dtpngay
        '
        Me.dtpngay.CustomFormat = "MM/yyyy"
        Me.dtpngay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpngay.Location = New System.Drawing.Point(239, 14)
        Me.dtpngay.Name = "dtpngay"
        Me.dtpngay.Size = New System.Drawing.Size(257, 44)
        Me.dtpngay.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tháng/Năm"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbmabaocao)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(125, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(502, 63)
        Me.Panel2.TabIndex = 0
        '
        'tbmabaocao
        '
        Me.tbmabaocao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbmabaocao.Location = New System.Drawing.Point(239, 14)
        Me.tbmabaocao.Name = "tbmabaocao"
        Me.tbmabaocao.ReadOnly = True
        Me.tbmabaocao.Size = New System.Drawing.Size(260, 35)
        Me.tbmabaocao.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Báo Cáo"
        '
        'btluu
        '
        Me.btluu.Location = New System.Drawing.Point(242, 611)
        Me.btluu.Name = "btluu"
        Me.btluu.Size = New System.Drawing.Size(196, 59)
        Me.btluu.TabIndex = 1
        Me.btluu.Text = "Lưu"
        Me.btluu.UseVisualStyleBackColor = True
        '
        'baocaothang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 682)
        Me.Controls.Add(Me.btluu)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "baocaothang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Báo Cáo Tháng"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvchitiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvchitiet As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents tbdoanhthu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbmabaocao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btluu As Button
    Friend WithEvents dtpngay As DateTimePicker
    Friend WithEvents btload As Button
End Class
