Imports QLGaraDTO
Imports QLGaraBus
Imports Utility

Public Class doimatkhau

    Public taikhoan As taikhoanDTO
    Private tkBus As taikhoanBus
    Public Sub New(ByVal tk As taikhoanDTO)

        MyBase.New()


        InitializeComponent()


        taikhoan = tk
    End Sub
    Private Sub doimatkhau_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tkBus = New taikhoanBus()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (kiemtra() = True) Then
            Dim tkmoi = New taikhoanDTO()
            tkmoi.taikhoan = taikhoan.taikhoan
            tkmoi.loaitaikhoan = taikhoan.loaitaikhoan
            tkmoi.manhanvien = taikhoan.manhanvien
            tkmoi.matkhau = tbmkm.Text
            Dim result = tkBus.update(tkmoi)
            If (result.FlagResult = True) Then
                tbmkht.Text = String.Empty
                tbmkm.Text = String.Empty
                tbxnmk.Text = String.Empty
                MessageBox.Show("Đã đổi mật khẩu", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Đã xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function kiemtra() As Boolean
        If (tbmkht.Text = Nothing Or tbmkm.Text = Nothing Or tbxnmk.Text = Nothing) Then
            Return False
        End If

        If (tbmkht.Text <> taikhoan.matkhau) Then
            MessageBox.Show("Mật Khẩu hiện tại không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (tbmkm.Text.Length < 8) Then
            MessageBox.Show("Mật Khẩu phải nhiều hơn 8 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (tbmkm.Text <> tbxnmk.Text) Then
            MessageBox.Show("Mật Khẩu xác nhận không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True

    End Function
End Class