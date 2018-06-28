<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanlyhieuxexe
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
        Me.tbtenhieuxe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.tbmahieuxe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bttim = New System.Windows.Forms.Button()
        Me.tbtimkiem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.PanelCapnhat.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCapnhat
        '
        Me.PanelCapnhat.Controls.Add(Me.tbtenhieuxe)
        Me.PanelCapnhat.Controls.Add(Me.Label3)
        Me.PanelCapnhat.Controls.Add(Me.btcapnhat)
        Me.PanelCapnhat.Controls.Add(Me.tbmahieuxe)
        Me.PanelCapnhat.Controls.Add(Me.Label2)
        Me.PanelCapnhat.Location = New System.Drawing.Point(11, 284)
        Me.PanelCapnhat.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelCapnhat.Name = "PanelCapnhat"
        Me.PanelCapnhat.Size = New System.Drawing.Size(345, 164)
        Me.PanelCapnhat.TabIndex = 6
        '
        'tbtenhieuxe
        '
        Me.tbtenhieuxe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbtenhieuxe.Location = New System.Drawing.Point(116, 65)
        Me.tbtenhieuxe.Margin = New System.Windows.Forms.Padding(2)
        Me.tbtenhieuxe.Name = "tbtenhieuxe"
        Me.tbtenhieuxe.Size = New System.Drawing.Size(220, 26)
        Me.tbtenhieuxe.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên hiệu xe"
        '
        'btcapnhat
        '
        Me.btcapnhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btcapnhat.Location = New System.Drawing.Point(165, 105)
        Me.btcapnhat.Margin = New System.Windows.Forms.Padding(2)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(117, 37)
        Me.btcapnhat.TabIndex = 2
        Me.btcapnhat.Text = "Cập Nhật"
        Me.btcapnhat.UseVisualStyleBackColor = True
        '
        'tbmahieuxe
        '
        Me.tbmahieuxe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbmahieuxe.Location = New System.Drawing.Point(116, 11)
        Me.tbmahieuxe.Margin = New System.Windows.Forms.Padding(2)
        Me.tbmahieuxe.Name = "tbmahieuxe"
        Me.tbmahieuxe.ReadOnly = True
        Me.tbmahieuxe.Size = New System.Drawing.Size(220, 26)
        Me.tbmahieuxe.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã hiệu xe"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bttim)
        Me.Panel1.Controls.Add(Me.tbtimkiem)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(11, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 77)
        Me.Panel1.TabIndex = 5
        '
        'bttim
        '
        Me.bttim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.bttim.Location = New System.Drawing.Point(259, 11)
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
        Me.tbtimkiem.Size = New System.Drawing.Size(248, 26)
        Me.tbtimkiem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(2, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập mã hoặc tên hiệu xe cần tìm"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(11, 101)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 28
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(345, 166)
        Me.dgv.TabIndex = 4
        '
        'quanlyhieuxexe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 479)
        Me.Controls.Add(Me.PanelCapnhat)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "quanlyhieuxexe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Hiệu Xe"
        Me.PanelCapnhat.ResumeLayout(False)
        Me.PanelCapnhat.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCapnhat As Panel
    Friend WithEvents tbtenhieuxe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btcapnhat As Button
    Friend WithEvents tbmahieuxe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bttim As Button
    Friend WithEvents tbtimkiem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
End Class
