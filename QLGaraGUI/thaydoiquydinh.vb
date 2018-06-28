Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class thaydoiquydinh
    Private qdBus As thamsoBus

    Private Sub thaydoiquydinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdBus = New thamsoBus()

        Dim ts = New thamsoDTO()
        Dim result As Result
        result = qdBus.selectall(ts)
        If (result.FlagResult = True) Then
            nudsongay.Value = ts.Soxetoida
        Else
            MessageBox.Show("Đã xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim qdmoi = New thamsoDTO
        qdmoi.Soxetoida = nudsongay.Value
        Dim result As Result
        result = qdBus.update(qdmoi)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cập nhật thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            result = qdBus.selectall(qdmoi)
            nudsongay.Value = qdmoi.Soxetoida
        Else
            MessageBox.Show("Cập nhật không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub
End Class