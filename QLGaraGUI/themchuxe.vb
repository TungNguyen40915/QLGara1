Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class themchuxe

    Private cxBus As chuxeBus
    Private Sub themchuxe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cxBus = New chuxeBus()

        ' Get Next ID
        Dim nextID As String
        nextID = Nothing
        Dim result As Result
        result = cxBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbmachuxe.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        btluu.Enabled = False
        tbtienno.Text = "0"

    End Sub

    Private Function kiemtra() As Boolean
        If (tbdiachi.Text = Nothing Or tbdienthoai.Text = Nothing Or tbtenchuxe.Text = Nothing Or tbtienno.Text = Nothing) Then
            Return False
        End If
        Return True
    End Function
    Private Sub btluu_Click(sender As Object, e As EventArgs) Handles btluu.Click
        If (kiemtra() = True) Then
            Dim chx As chuxeDTO

            chx = New chuxeDTO()

            '1. Mapping data from GUI control
            chx.Machuxe = tbmachuxe.Text
            chx.Tenchuxe = tbtenchuxe.Text
            chx.Diachi = tbdiachi.Text
            chx.Dienthoai = Convert.ToInt32(tbdienthoai.Text)
            chx.Tienno = Convert.ToInt32(tbtienno.Text)

            '2. Insert to DB
            Dim result As Result
            result = cxBus.insert(chx)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm chủ xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbtenchuxe.Text = String.Empty
                tbdiachi.Text = String.Empty
                tbdienthoai.Text = String.Empty
                tbtienno.Text = "0"
                ' Get Next ID
                Dim nextID As String
                nextID = Nothing
                result = cxBus.getNextID(nextID)
                If (result.FlagResult = True) Then
                    tbmachuxe.Text = nextID.ToString()
                Else
                    MessageBox.Show("Lấy ID kế tiếp của chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If

            Else
                MessageBox.Show("Thêm chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Vui lòng không để trống ô nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tbtenchuxe_TextChanged(sender As Object, e As EventArgs) Handles tbtenchuxe.TextChanged
        If (kiemtra() = False) Then
            btluu.Enabled = False
        Else
            btluu.Enabled = True
        End If
    End Sub

    Private Sub tbdiachi_TextChanged(sender As Object, e As EventArgs) Handles tbdiachi.TextChanged
        If (kiemtra() = False) Then
            btluu.Enabled = False
        Else
            btluu.Enabled = True
        End If
    End Sub

    Private Sub tbdienthoai_TextChanged(sender As Object, e As EventArgs) Handles tbdienthoai.TextChanged
        If (kiemtra() = False) Then
            btluu.Enabled = False
        Else
            btluu.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbtienno.TextChanged
        If (kiemtra() = False) Then
            btluu.Enabled = False
        Else
            btluu.Enabled = True
        End If
    End Sub

    Private Sub btnhaplai_Click(sender As Object, e As EventArgs) Handles btnhaplai.Click
        tbtenchuxe.Text = String.Empty
        tbdiachi.Text = String.Empty
        tbdienthoai.Text = String.Empty
        tbtienno.Text = "0"
    End Sub

    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        If (MessageBox.Show("Thông tin chưa được lưu. Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub
End Class