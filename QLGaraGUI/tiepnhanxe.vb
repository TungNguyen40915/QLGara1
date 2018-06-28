Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class tiepnhanxe

    Private cxBus As chuxeBus
    Private xBus As xeBus
    Private tnBus As tiepnhanxeBus
    Private hxBus As hieuxeBus
    Private tsBus As thamsoBus

    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        If (MessageBox.Show(" Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub

    Private Sub tiepnhanxe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cxBus = New chuxeBus()
        xBus = New xeBus()
        tnBus = New tiepnhanxeBus()
        hxBus = New hieuxeBus()
        tsBus = New thamsoBus()
        buimatn()
        solantiepnhan()
    End Sub

    Private Function buimatn() As Integer
        Dim t As String
        t = Nothing

        tnBus.buildMTN(dtngaytiepnhan.Value, t)
        tbmatiepnhan.Text = t
        Return 0
    End Function

    Private Function solantiepnhan() As Integer
        Dim solan As Integer
        Dim result As Result
        result = tnBus.dem(dtngaytiepnhan.Value, solan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
            Dim ts = New thamsoDTO()
            result = tsBus.selectall(ts)
            If (result.FlagResult = False) Then
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            ElseIf (solan >= ts.Soxetoida) Then
                MessageBox.Show("Đã tiếp nhận đủ xe cho ngày này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else
                tbsolan.Text = solan
            End If

        End If
        Return 0
    End Function

    Private Sub dtngaytiepnhan_ValueChanged(sender As Object, e As EventArgs) Handles dtngaytiepnhan.ValueChanged
        buimatn()
        solantiepnhan()
    End Sub


    Private Function loadXeByBienso(ByRef a As xeDTO) As Boolean
        a = New xeDTO()
        Dim result As Result
        result = xBus.select_Bybienso(tbbiensoxe.Text, a)
        If (result.FlagResult = False) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function loadChuXeByMachuxe(ms As String, ByRef a As chuxeDTO) As Boolean
        a = New chuxeDTO()
        Dim result As Result
        result = cxBus.select_ByMachuxe(ms, a)
        Return True

    End Function

    Private Function loadHieuXeByMahieuxe(ms As Integer, ByRef a As hieuxeDTO) As Boolean
        a = New hieuxeDTO()
        Dim result As Result
        result = hxBus.select_ByMahieuxe(ms, a)
        Return True
    End Function

    Private Sub btluu_Click(sender As Object, e As EventArgs) Handles Label9.Click, btluu.Click
        Dim a As xeDTO
        a = New xeDTO()
        If (loadXeByBienso(a) = True) Then
            Dim x As tiepnhanxeDTO
            x = New tiepnhanxeDTO()

            '1. Mapping data from GUI control
            x.Matiepnhan = tbmatiepnhan.Text
            x.Bienso = tbbiensoxe.Text
            x.Ngaytiepnhan = dtngaytiepnhan.Value

            Dim b = String.Empty
            For Each item In x.Bienso
                b = b + UCase(item)
            Next

            x.Bienso = b

            '2. Insert to DB
            Dim result As Result
            result = tnBus.insert(x)
            If (result.FlagResult = True) Then
                MessageBox.Show("Tiếp Nhận Xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbbiensoxe.Text = String.Empty
                buimatn()
                solantiepnhan()
                tbdiachi.Text = String.Empty
                tbdienthoai.Text = String.Empty
                tbhieuxe.Text = String.Empty
                tbmachuxe.Text = String.Empty
                tbtenchuxe.Text = String.Empty

            Else
                MessageBox.Show("Tiếp Nhận Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            If (tbbiensoxe.Text = Nothing) Then
                MessageBox.Show("Vui lòng nhập biển số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim b = "Không tìm thấy xe có biển số là " + tbbiensoxe.Text
                MessageBox.Show(b, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Label9_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover
        Label9.ForeColor = Color.BlueViolet

    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        Label9.ForeColor = Color.Black
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)
        Dim newf = New themxe()
        newf.ShowDialog(Me)
    End Sub
    Private Sub tbbiensoxe_Leave(sender As Object, e As EventArgs) Handles tbbiensoxe.Leave
        If (tbbiensoxe.Text.Length = 0) Then
            btluu.Enabled = False
        Else
            Dim a As xeDTO
            a = New xeDTO()
            If (loadXeByBienso(a) = True) Then
                Dim b As hieuxeDTO
                b = New hieuxeDTO()
                Dim c As chuxeDTO
                c = New chuxeDTO()
                loadChuXeByMachuxe(a.Machuxe, c)
                tbdiachi.Text = c.Diachi
                tbdienthoai.Text = c.Dienthoai.ToString()
                tbmachuxe.Text = c.Machuxe
                tbtenchuxe.Text = c.Tenchuxe


                loadHieuXeByMahieuxe(a.Mahieuxe.ToString(), b)
                tbhieuxe.Text = b.Tenhieuxe
            End If
        End If
    End Sub
End Class