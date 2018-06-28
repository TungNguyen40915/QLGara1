<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanlyvattu
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
        Me.tbluongton = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbdongia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbtenvattu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.tbmavattu = New System.Windows.Forms.TextBox()
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
        Me.PanelCapnhat.Controls.Add(Me.tbluongton)
        Me.PanelCapnhat.Controls.Add(Me.Label5)
        Me.PanelCapnhat.Controls.Add(Me.tbdongia)
        Me.PanelCapnhat.Controls.Add(Me.Label4)
        Me.PanelCapnhat.Controls.Add(Me.tbtenvattu)
        Me.PanelCapnhat.Controls.Add(Me.Label3)
        Me.PanelCapnhat.Controls.Add(Me.btcapnhat)
        Me.PanelCapnhat.Controls.Add(Me.tbmavattu)
        Me.PanelCapnhat.Controls.Add(Me.Label2)
        Me.PanelCapnhat.Location = New System.Drawing.Point(16, 261)
        Me.PanelCapnhat.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelCapnhat.Name = "PanelCapnhat"
        Me.PanelCapnhat.Size = New System.Drawing.Size(370, 193)
        Me.PanelCapnhat.TabIndex = 11
        '
        'tbluongton
        '
        Me.tbluongton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbluongton.Location = New System.Drawing.Point(116, 104)
        Me.tbluongton.Margin = New System.Windows.Forms.Padding(2)
        Me.tbluongton.Name = "tbluongton"
        Me.tbluongton.Size = New System.Drawing.Size(220, 26)
        Me.tbluongton.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 108)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Lượng Tồn"
        '
        'tbdongia
        '
        Me.tbdongia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbdongia.Location = New System.Drawing.Point(116, 71)
        Me.tbdongia.Margin = New System.Windows.Forms.Padding(2)
        Me.tbdongia.Name = "tbdongia"
        Me.tbdongia.Size = New System.Drawing.Size(220, 26)
        Me.tbdongia.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Đơn giá"
        '
        'tbtenvattu
        '
        Me.tbtenvattu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbtenvattu.Location = New System.Drawing.Point(116, 42)
        Me.tbtenvattu.Margin = New System.Windows.Forms.Padding(2)
        Me.tbtenvattu.Name = "tbtenvattu"
        Me.tbtenvattu.Size = New System.Drawing.Size(220, 26)
        Me.tbtenvattu.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên vật tư"
        '
        'btcapnhat
        '
        Me.btcapnhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btcapnhat.Location = New System.Drawing.Point(165, 137)
        Me.btcapnhat.Margin = New System.Windows.Forms.Padding(2)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(117, 37)
        Me.btcapnhat.TabIndex = 2
        Me.btcapnhat.Text = "Cập Nhật"
        Me.btcapnhat.UseVisualStyleBackColor = True
        '
        'tbmavattu
        '
        Me.tbmavattu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbmavattu.Location = New System.Drawing.Point(116, 11)
        Me.tbmavattu.Margin = New System.Windows.Forms.Padding(2)
        Me.tbmavattu.Name = "tbmavattu"
        Me.tbmavattu.ReadOnly = True
        Me.tbmavattu.Size = New System.Drawing.Size(220, 26)
        Me.tbmavattu.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã vật tư"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(11, 92)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 28
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(375, 166)
        Me.dgv.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bttim)
        Me.Panel1.Controls.Add(Me.tbtimkiem)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(11, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 77)
        Me.Panel1.TabIndex = 9
        '
        'bttim
        '
        Me.bttim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.bttim.Location = New System.Drawing.Point(293, 11)
        Me.bttim.Margin = New System.Windows.Forms.Padding(2)
        Me.bttim.Name = "bttim"
        Me.bttim.Size = New System.Drawing.Size(74, 23)
        Me.bttim.TabIndex = 2
        Me.bttim.Text = "Tìm"
        Me.bttim.UseVisualStyleBackColor = True
        '
        'tbtimkiem
        '
        Me.tbtimkiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbtimkiem.Location = New System.Drawing.Point(5, 11)
        Me.tbtimkiem.Margin = New System.Windows.Forms.Padding(2)
        Me.tbtimkiem.Name = "tbtimkiem"
        Me.tbtimkiem.Size = New System.Drawing.Size(283, 26)
        Me.tbtimkiem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(29, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập thông tin vật tư cần tìm"
        '
        'quanlyvattu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 468)
        Me.Controls.Add(Me.PanelCapnhat)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "quanlyvattu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Vật Tư"
        Me.PanelCapnhat.ResumeLayout(False)
        Me.PanelCapnhat.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCapnhat As Panel
    Friend WithEvents tbluongton As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbdongia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbtenvattu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btcapnhat As Button
    Friend WithEvents tbmavattu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bttim As Button
    Friend WithEvents tbtimkiem As TextBox
    Friend WithEvents Label1 As Label
End Class
