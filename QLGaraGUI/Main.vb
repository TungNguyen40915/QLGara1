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
End Class
