Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class dangnhap
    Private tkBus As taikhoanBus
    Public tk As taikhoanDTO

    Private Sub dangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tkBus = New taikhoanBus()
        tk = New taikhoanDTO()

        btdangnhap.Enabled = False
        lbloi.Visible = False

        tbtaikhoan.Text = "16521125"
        tbmatkhau.Text = "20182018"
    End Sub

    Private Sub btdangnhap_Click(sender As Object, e As EventArgs) Handles btdangnhap.Click
        If (tbtaikhoan.Text = Nothing Or tbmatkhau.Text = Nothing) Then
            MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim result As Result
            Dim tkdn = New taikhoanDTO()
            tkdn.taikhoan = tbtaikhoan.Text
            result = tkBus.select_Bytaikhoan(tkdn.taikhoan, tkdn)
            If (result.FlagResult = False) Then
                MessageBox.Show("Đã xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If (tkdn.matkhau = tbmatkhau.Text) Then
                    tk = tkdn
                    tbmatkhau.Text = String.Empty
                    tbtaikhoan.Text = String.Empty
                    lbloi.Visible = False
                    Dim newf = New Main(tk)
                    newf.ShowDialog(Me)

                Else
                    lbloi.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub tbmatkhau_TextChanged(sender As Object, e As EventArgs) Handles tbmatkhau.TextChanged
        If (tbmatkhau.Text.Length < 8) Then
            btdangnhap.Enabled = False
        Else
            btdangnhap.Enabled = True
        End If
    End Sub
End Class