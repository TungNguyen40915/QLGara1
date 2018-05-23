Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class themnoidung
    Private ndBus As noidungBus
    Private Sub themnoidung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ndBus = New noidungBus()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = ndBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbmanoidung.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Nội Dung không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        btluu.Enabled = False
    End Sub

    Private Function kiemtra() As Boolean
        If (tbtennoidung.Text = Nothing Or tbtiencong.Text = Nothing) Then
            Return False
        End If
        Return True
    End Function



    Private Sub btluu_Click(sender As Object, e As EventArgs) Handles btluu.Click
        If (kiemtra()) Then
            Dim nd As noidungDTO

            nd = New noidungDTO()

            '1. Mapping data from GUI control
            nd.mand = Convert.ToInt32(tbmanoidung.Text)
            nd.tennoidung = tbtennoidung.Text
            nd.tiencong = Convert.ToInt32(tbtiencong.Text)


            '2. Insert to DB
            Dim result As Result
            result = ndBus.insert(nd)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm Nội Dung thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbtennoidung.Text = String.Empty
                tbtiencong.Text = String.Empty

                ' Get Next ID
                Dim nextID As Integer
                result = ndBus.getNextID(nextID)
                If (result.FlagResult = True) Then
                    tbmanoidung.Text = nextID.ToString()
                Else
                    MessageBox.Show("Lấy ID kế tiếp của nội dung không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If

            Else
                MessageBox.Show("Thêm nội dung không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tbtennoidung_TextChanged(sender As Object, e As EventArgs) Handles tbtennoidung.TextChanged
        If (kiemtra() = True) Then
            btluu.Enabled = True
        Else
            btluu.Enabled = False
        End If
    End Sub

    Private Sub tbtiencong_TextChanged(sender As Object, e As EventArgs) Handles tbtiencong.TextChanged
        If (kiemtra() = True) Then
            btluu.Enabled = True
        Else
            btluu.Enabled = False
        End If
    End Sub
End Class