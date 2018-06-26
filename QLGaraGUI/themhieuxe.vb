Imports QLGaraBUS
Imports QLGaraDTO
Imports Utility


Public Class themhieuxe

    Private hieuxeBus As hieuxeBus


    Private Sub themhieuxe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hieuxeBus = New hieuxeBus()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = hieuxeBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbmahieuxe.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Hiệu Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            System.Console.WriteLine(result.SystemMessage)
        End If

        btluu.Enabled = False
    End Sub

    Private Sub btluu_Click(sender As Object, e As EventArgs) Handles btluu.Click
        If (tbtenhieuxe.Text <> Nothing) Then
            Dim hx As hieuxeDTO

            hx = New hieuxeDTO()

            '1. Mapping data from GUI control
            hx.Mahieuxe = Convert.ToInt32(tbmahieuxe.Text)
            hx.Tenhieuxe = tbtenhieuxe.Text



            '2. Insert to DB
            Dim result As Result
            result = hieuxeBus.insert(hx)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm hiệu xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbtenhieuxe.Text = String.Empty

                ' Get Next ID
                Dim nextID As Integer
                result = hieuxeBus.getNextID(nextID)
                If (result.FlagResult = True) Then
                    tbmahieuxe.Text = nextID.ToString()
                Else
                    MessageBox.Show("Lấy ID kế tiếp của hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    System.Console.WriteLine(result.SystemMessage)
                End If

            Else
                MessageBox.Show("Thêm hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                System.Console.WriteLine(result.SystemMessage)
            End If
        End If
    End Sub

    Private Sub tbtenhieuxe_TextChanged(sender As Object, e As EventArgs) Handles tbtenhieuxe.TextChanged
        If (tbtenhieuxe.Text = Nothing) Then
            btluu.Enabled = False
        Else btluu.Enabled = True
        End If
    End Sub

    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        If (MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub
End Class