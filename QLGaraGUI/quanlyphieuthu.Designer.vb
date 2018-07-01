<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanlyphieuthu
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
        Me.bttim = New System.Windows.Forms.Button()
        Me.tbtimkiem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bttim)
        Me.Panel1.Controls.Add(Me.tbtimkiem)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(200, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 118)
        Me.Panel1.TabIndex = 9
        '
        'bttim
        '
        Me.bttim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.bttim.Location = New System.Drawing.Point(440, 17)
        Me.bttim.Name = "bttim"
        Me.bttim.Size = New System.Drawing.Size(111, 35)
        Me.bttim.TabIndex = 1
        Me.bttim.Text = "Tìm"
        Me.bttim.UseVisualStyleBackColor = True
        '
        'tbtimkiem
        '
        Me.tbtimkiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbtimkiem.Location = New System.Drawing.Point(8, 17)
        Me.tbtimkiem.Name = "tbtimkiem"
        Me.tbtimkiem.Size = New System.Drawing.Size(422, 35)
        Me.tbtimkiem.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(44, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập thông tin phiếu thu cần tìm"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(16, 152)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 28
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(922, 340)
        Me.dgv.TabIndex = 8
        '
        'quanlyphieuthu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "quanlyphieuthu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Phiếu Thu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bttim As Button
    Friend WithEvents tbtimkiem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
End Class
