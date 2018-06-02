Imports QLGaraBus
Imports QLGaraDTO
Imports Utility


Public Class baocaovattu

    Private bcBus As baocaovattuBus
    Private Sub baocaovattu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bcBus = New baocaovattuBus()

        dtpngay.Value = Now
        loadID()

    End Sub

    Private Function loadID() As Boolean
        Dim result As Result
        Dim nextID As String
        nextID = Nothing
        result = bcBus.buildMBC(dtpngay.Value.Month, dtpngay.Value.Year, nextID)
        If (result.FlagResult = True) Then
            tbmabaocao.Text = nextID.ToString()
            Return True
        Else
            MessageBox.Show("Lấy ID của báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Return False
    End Function


End Class