Imports QLGaraDTO
Imports QLGaraBus
Imports Utility



Public Class Main
    Private taikhoan As taikhoanDTO
    Public Sub New(ByVal tk As taikhoanDTO)
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        taikhoan = tk
    End Sub
    Private Sub bttiepnhanxe_Click(sender As Object, e As EventArgs) Handles bttiepnhanxe.Click

        Dim newf = New tiepnhanxe()
        newf.ShowDialog(Me)
    End Sub

    Private Sub bttracuuxe_Click(sender As Object, e As EventArgs) Handles bttracuuxe.Click
        Dim newf = New tracuuxe()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btlapphieuthu_Click(sender As Object, e As EventArgs) Handles btlapphieuthu.Click
        Dim newf = New phieuthu()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btlapbaocaotheothang_Click(sender As Object, e As EventArgs)
        Dim newf = New baocaothang()
        newf.ShowDialog(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btlapphieusuachua.Click
        Dim newf = New lapphieusuachua()
        newf.ShowDialog(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim newf = New baocaovattu()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btthemxe_Click(sender As Object, e As EventArgs) Handles btthemxe.Click
        Dim newf = New themxe()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btthemchuxe_Click(sender As Object, e As EventArgs) Handles btthemchuxe.Click
        Dim newf = New themchuxe()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btthemhieuxe_Click(sender As Object, e As EventArgs) Handles btthemhieuxe.Click
        Dim newf = New themhieuxe()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btquanlytiepnhan_Click(sender As Object, e As EventArgs) Handles btquanlytiepnhan.Click
        Dim newf = New quanlynhapxe()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btquanlyhieuxe_Click(sender As Object, e As EventArgs) Handles btquanlyhieuxe.Click
        Dim newf = New quanlyhieuxexe()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btquanlychuxe_Click(sender As Object, e As EventArgs) Handles btquanlychuxe.Click
        Dim newf = New quanlychuxe()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btthemvattu_Click(sender As Object, e As EventArgs) Handles btthemvattu.Click
        Dim newf = New themvattu()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btbaocaovattu_Click(sender As Object, e As EventArgs) Handles btbaocaovattu.Click
        Dim newf = New baocaovattu()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btbaocaodoanhthu_Click(sender As Object, e As EventArgs) Handles btbaocaodoanhthu.Click
        Dim newf = New baocaothang()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btquanlyvattu_Click(sender As Object, e As EventArgs) Handles btquanlyvattu.Click
        Dim newf = New quanlyvattu()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btthaydoiquydinh_Click(sender As Object, e As EventArgs) Handles btthaydoiquydinh.Click
        If (taikhoan.loaitaikhoan = 0) Then
            Dim newf = New thaydoiquydinh()
            newf.ShowDialog(Me)
        Else
            MessageBox.Show("Bạn không có quyền truy cập vào mục này", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btquanlyphieuthu_Click(sender As Object, e As EventArgs) Handles btquanlyphieuthu.Click
        Dim newf = New quanlyphieuthu()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btthongtintaikhoan_Click(sender As Object, e As EventArgs) Handles btthongtintaikhoan.Click
        Dim newf = New thongtintaikhoan(taikhoan)
        newf.ShowDialog(Me)
    End Sub

    Private Sub btdangxuat_Click(sender As Object, e As EventArgs) Handles btdangxuat.Click
        Me.Close()
    End Sub


End Class
