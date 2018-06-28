Imports QLGaraDTO
Imports QLGaraBus
Imports Utility

Public Class thongtintaikhoan

    Public tk As taikhoanDTO
    Public Sub New(ByVal tk As taikhoanDTO)

        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tbtaikhoan.Text = tk.taikhoan
        If (tk.loaitaikhoan = 0) Then
            tbloaitaikhoan.Text = "Ban Quản Lý"
        ElseIf (tk.loaitaikhoan = 1) Then
            tbloaitaikhoan.Text = "Nhân Viên Văn Phòng"
        ElseIf (tk.loaitaikhoan = 2) Then
            tbloaitaikhoan.Text = "Nhân Viên Kỹ Thuật"
        End If
        tbnhanvien.Text = tk.manhanvien
        Me.tk = tk
    End Sub
    Private Sub thongtintaikhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbloaitaikhoan.ReadOnly = True
        tbnhanvien.ReadOnly = True
        tbtaikhoan.ReadOnly = True
    End Sub

    Private Sub btdoimk_Click(sender As Object, e As EventArgs) Handles btdoimk.Click
        Dim newf = New doimatkhau(tk)
        newf.ShowDialog(Me)
    End Sub
End Class