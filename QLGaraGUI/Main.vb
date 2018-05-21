Imports QLGaraDTO
Imports QLGaraBus
Imports Utility



Public Class Main
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

    Private Sub btlapbaocaotheothang_Click(sender As Object, e As EventArgs) Handles btlapbaocaotheothang.Click
        Dim newf = New baocaothang()
        newf.ShowDialog(Me)
    End Sub
End Class
