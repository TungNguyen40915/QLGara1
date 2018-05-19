Imports QLGaraBus
Imports QLGaraDTO
Imports Utility


Public Class phieuthu
    Private ptbus As phieuthuBus
    Private cxbus As chuxeBus
    Private listxe As List(Of xeDTO)
    Private xbus As xeBus

    Private Sub phieuthu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ptbus = New phieuthuBus()
        listxe = New List(Of xeDTO)
        xbus = New xeBus()
        cxbus = New chuxeBus()

        Dim result As Result
        result = xbus.selectall(listxe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy toàn bộ xe không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            cbbbienso.DataSource = listxe
            cbbbienso.DisplayMember = "Bienso"
            '     cbbbienso.ValueMember = "Bienso"
        End If


        ' Get Next ID
        Dim nextID As String
        nextID = Nothing
        Dim result1 As Result
        result1 = ptbus.buildMP(dtngaythu.Value, nextID)
        If (result1.FlagResult = True) Then
            tbmaphieu.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của phiếu thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub cbbbienso_Leave(sender As Object, e As EventArgs) Handles cbbbienso.Leave

        Dim xe = New xeDTO()
        Dim result As Result
        result = xbus.select_Bybienso(cbbbienso.Text, xe)
        If (result.FlagResult = True) Then
            Dim chuxe = New chuxeDTO()
            Dim result1 As Result
            result1 = cxbus.select_ByMachuxe(xe.Machuxe, chuxe)
            If (result1.FlagResult = True) Then
                tbhotenchuxe.Text = chuxe.Tenchuxe
            End If
        End If

    End Sub

    Private Sub btluu_Click(sender As Object, e As EventArgs) Handles btluu.Click
        If (cbbbienso.Text = Nothing Or tbtongtien.Text = Nothing) Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim xe = New xeDTO()
            Dim result As Result
            result = xbus.select_Bybienso(cbbbienso.Text, xe)
            If (result.FlagResult = True) Then
                Dim chuxe = New chuxeDTO()
                Dim result1 As Result
                result1 = cxbus.select_ByMachuxe(xe.Machuxe, chuxe)
                If (result1.FlagResult = True) Then
                    Dim a = Convert.ToInt32(tbtongtien.Text)
                    Dim b = chuxe.Tienno
                    If (a > b) Then
                        MessageBox.Show("Tiền thu vượt quá tiền nợ của khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim phieuthu = New phieuthuDTO()
                        phieuthu.bienso = cbbbienso.Text
                        phieuthu.maphieu = tbmaphieu.Text
                        phieuthu.tongtien = Convert.ToInt32(tbtongtien.Text)
                        phieuthu.ngaythu = dtngaythu.Value

                        Dim r As Result
                        r = ptbus.insert(phieuthu)
                        If (r.FlagResult = False) Then
                            MessageBox.Show("Thêm phiếu thu không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        Else
                            MessageBox.Show("Đã thêm thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Dim cx = New chuxeDTO(chuxe.Machuxe, chuxe.Tenchuxe, chuxe.Diachi, chuxe.Dienthoai, Convert.ToInt32(chuxe.Tienno) - Convert.ToInt32(tbtongtien.Text))
                            Dim ab = cxbus.update(cx)
                            cbbbienso.Text = String.Empty
                            tbtongtien.Text = String.Empty
                            Dim nextID As String
                            nextID = Nothing
                            Dim res As Result
                            res = ptbus.buildMP(dtngaythu.Value, nextID)
                            If (res.FlagResult = True) Then
                                tbmaphieu.Text = nextID.ToString()
                            Else
                                MessageBox.Show("Lấy ID kế tiếp của phiếu thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                System.Console.WriteLine(result.SystemMessage)
                            End If



                        End If
                    End If
                Else
                    Dim thongbao = "Không tìm thấy xe có biển số là " + cbbbienso.Text.ToString()
                    MessageBox.Show(thongbao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If

    End Sub
End Class