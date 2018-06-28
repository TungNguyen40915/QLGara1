<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tracuuxe
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
        Me.tbtimkiem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttim = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cbbtenchuxe1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbmachuxe1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbbtenhieuxe1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbmahieuxe1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.tbbienso1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbtimkiem)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.bttim)
        Me.Panel1.Location = New System.Drawing.Point(24, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 65)
        Me.Panel1.TabIndex = 9
        '
        'tbtimkiem
        '
        Me.tbtimkiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbtimkiem.Location = New System.Drawing.Point(39, 14)
        Me.tbtimkiem.Margin = New System.Windows.Forms.Padding(2)
        Me.tbtimkiem.Name = "tbtimkiem"
        Me.tbtimkiem.Size = New System.Drawing.Size(375, 26)
        Me.tbtimkiem.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nhập thông tin cần tìm ( mã xe, mã chủ xe, mã hiệu xe, tên chủ xe, tên hiệu xe)"
        '
        'bttim
        '
        Me.bttim.Location = New System.Drawing.Point(473, 22)
        Me.bttim.Margin = New System.Windows.Forms.Padding(2)
        Me.bttim.Name = "bttim"
        Me.bttim.Size = New System.Drawing.Size(94, 25)
        Me.bttim.TabIndex = 4
        Me.bttim.Text = "Tìm"
        Me.bttim.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Location = New System.Drawing.Point(20, 233)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(603, 178)
        Me.Panel5.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(335, 131)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 36)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Xóa Xe"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 131)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 36)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cập Nhật"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.cbbtenchuxe1)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.tbmachuxe1)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Location = New System.Drawing.Point(2, 45)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(601, 39)
        Me.Panel8.TabIndex = 5
        '
        'cbbtenchuxe1
        '
        Me.cbbtenchuxe1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbtenchuxe1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbtenchuxe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbtenchuxe1.FormattingEnabled = True
        Me.cbbtenchuxe1.Location = New System.Drawing.Point(395, 9)
        Me.cbbtenchuxe1.Margin = New System.Windows.Forms.Padding(2)
        Me.cbbtenchuxe1.Name = "cbbtenchuxe1"
        Me.cbbtenchuxe1.Size = New System.Drawing.Size(206, 24)
        Me.cbbtenchuxe1.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(296, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Tên Chủ Xe"
        '
        'tbmachuxe1
        '
        Me.tbmachuxe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbmachuxe1.Location = New System.Drawing.Point(112, 5)
        Me.tbmachuxe1.Margin = New System.Windows.Forms.Padding(2)
        Me.tbmachuxe1.Name = "tbmachuxe1"
        Me.tbmachuxe1.ReadOnly = True
        Me.tbmachuxe1.Size = New System.Drawing.Size(161, 29)
        Me.tbmachuxe1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Mã Chủ Xe"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cbbtenhieuxe1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.tbmahieuxe1)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(2, 88)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(601, 39)
        Me.Panel6.TabIndex = 4
        '
        'cbbtenhieuxe1
        '
        Me.cbbtenhieuxe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbtenhieuxe1.FormattingEnabled = True
        Me.cbbtenhieuxe1.Location = New System.Drawing.Point(395, 9)
        Me.cbbtenhieuxe1.Margin = New System.Windows.Forms.Padding(2)
        Me.cbbtenhieuxe1.Name = "cbbtenhieuxe1"
        Me.cbbtenhieuxe1.Size = New System.Drawing.Size(206, 24)
        Me.cbbtenhieuxe1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(291, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tên Hiệu Xe"
        '
        'tbmahieuxe1
        '
        Me.tbmahieuxe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbmahieuxe1.Location = New System.Drawing.Point(112, 5)
        Me.tbmahieuxe1.Margin = New System.Windows.Forms.Padding(2)
        Me.tbmahieuxe1.Name = "tbmahieuxe1"
        Me.tbmahieuxe1.ReadOnly = True
        Me.tbmahieuxe1.Size = New System.Drawing.Size(161, 29)
        Me.tbmahieuxe1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Mã Hiệu Xe"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.tbbienso1)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Location = New System.Drawing.Point(188, 7)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(285, 39)
        Me.Panel7.TabIndex = 0
        '
        'tbbienso1
        '
        Me.tbbienso1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbbienso1.Location = New System.Drawing.Point(110, 3)
        Me.tbbienso1.Margin = New System.Windows.Forms.Padding(2)
        Me.tbbienso1.Name = "tbbienso1"
        Me.tbbienso1.Size = New System.Drawing.Size(163, 29)
        Me.tbbienso1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Biển Số Xe"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(22, 84)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 28
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(601, 145)
        Me.dgv.TabIndex = 7
        '
        'tracuuxe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(652, 422)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tracuuxe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tra cứu Xe"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbtimkiem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bttim As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cbbtenchuxe1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbmachuxe1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbbtenhieuxe1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbmahieuxe1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents tbbienso1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv As DataGridView
End Class
