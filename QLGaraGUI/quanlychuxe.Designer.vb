<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanlychuxe
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
        Me.PanelCapnhat = New System.Windows.Forms.Panel()
        Me.tbdienthoai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbdiachi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbtenchuxe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.tbmachuxe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bttim = New System.Windows.Forms.Button()
        Me.tbtimkiem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelCapnhat.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCapnhat
        '
        Me.PanelCapnhat.Controls.Add(Me.tbdienthoai)
        Me.PanelCapnhat.Controls.Add(Me.Label5)
        Me.PanelCapnhat.Controls.Add(Me.tbdiachi)
        Me.PanelCapnhat.Controls.Add(Me.Label4)
        Me.PanelCapnhat.Controls.Add(Me.tbtenchuxe)
        Me.PanelCapnhat.Controls.Add(Me.Label3)
        Me.PanelCapnhat.Controls.Add(Me.btcapnhat)
        Me.PanelCapnhat.Controls.Add(Me.tbmachuxe)
        Me.PanelCapnhat.Controls.Add(Me.Label2)
        Me.PanelCapnhat.Location = New System.Drawing.Point(30, 569)
        Me.PanelCapnhat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelCapnhat.Name = "PanelCapnhat"
        Me.PanelCapnhat.Size = New System.Drawing.Size(832, 325)
        Me.PanelCapnhat.TabIndex = 8
        '
        'tbdienthoai
        '
        Me.tbdienthoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbdienthoai.Location = New System.Drawing.Point(261, 174)
        Me.tbdienthoai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbdienthoai.Name = "tbdienthoai"
        Me.tbdienthoai.Size = New System.Drawing.Size(490, 35)
        Me.tbdienthoai.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(27, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 29)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Điện Thoại"
        '
        'tbdiachi
        '
        Me.tbdiachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbdiachi.Location = New System.Drawing.Point(261, 125)
        Me.tbdiachi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbdiachi.Name = "tbdiachi"
        Me.tbdiachi.Size = New System.Drawing.Size(490, 35)
        Me.tbdiachi.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(27, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Địa Chỉ"
        '
        'tbtenchuxe
        '
        Me.tbtenchuxe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbtenchuxe.Location = New System.Drawing.Point(261, 75)
        Me.tbtenchuxe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbtenchuxe.Name = "tbtenchuxe"
        Me.tbtenchuxe.Size = New System.Drawing.Size(490, 35)
        Me.tbtenchuxe.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(27, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên chủ xe"
        '
        'btcapnhat
        '
        Me.btcapnhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btcapnhat.Location = New System.Drawing.Point(388, 228)
        Me.btcapnhat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(264, 88)
        Me.btcapnhat.TabIndex = 4
        Me.btcapnhat.Text = "Cập Nhật"
        Me.btcapnhat.UseVisualStyleBackColor = True
        '
        'tbmachuxe
        '
        Me.tbmachuxe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbmachuxe.Location = New System.Drawing.Point(261, 26)
        Me.tbmachuxe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbmachuxe.Name = "tbmachuxe"
        Me.tbmachuxe.ReadOnly = True
        Me.tbmachuxe.Size = New System.Drawing.Size(490, 35)
        Me.tbmachuxe.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(27, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã chủ xe"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(18, 182)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 28
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(844, 378)
        Me.dgv.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bttim)
        Me.Panel1.Controls.Add(Me.tbtimkiem)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(18, 22)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 151)
        Me.Panel1.TabIndex = 6
        '
        'bttim
        '
        Me.bttim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.bttim.Location = New System.Drawing.Point(658, 26)
        Me.bttim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bttim.Name = "bttim"
        Me.bttim.Size = New System.Drawing.Size(166, 54)
        Me.bttim.TabIndex = 2
        Me.bttim.Text = "Tìm"
        Me.bttim.UseVisualStyleBackColor = True
        '
        'tbtimkiem
        '
        Me.tbtimkiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbtimkiem.Location = New System.Drawing.Point(12, 26)
        Me.tbtimkiem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbtimkiem.Name = "tbtimkiem"
        Me.tbtimkiem.Size = New System.Drawing.Size(632, 35)
        Me.tbtimkiem.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(64, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập thông tin chủ xe cần tìm"
        '
        'quanlychuxe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(894, 915)
        Me.Controls.Add(Me.PanelCapnhat)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "quanlychuxe"
        Me.Text = "Quản Lý Chủ Xe"
        Me.PanelCapnhat.ResumeLayout(False)
        Me.PanelCapnhat.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCapnhat As Panel
    Friend WithEvents tbdienthoai As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbdiachi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbtenchuxe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btcapnhat As Button
    Friend WithEvents tbmachuxe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bttim As Button
    Friend WithEvents tbtimkiem As TextBox
    Friend WithEvents Label1 As Label
End Class
