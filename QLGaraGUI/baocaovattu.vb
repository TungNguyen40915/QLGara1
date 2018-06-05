Imports QLGaraBus
Imports QLGaraDTO
Imports Utility


Public Class baocaovattu

    Private bcBus As baocaovattuBus
    Private ctBus As chitietbaocaovattuBus
    Private vtBus As vattuBus

    Private list As List(Of baocao2DTO)

    Private Sub baocaovattu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bcBus = New baocaovattuBus()
        ctBus = New chitietbaocaovattuBus()
        list = New List(Of baocao2DTO)
        vtBus = New vattuBus()


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

    Private Function builddgv(list As List(Of baocao2DTO))
        dgvchitiet.DataSource = Nothing
        dgvchitiet.Columns.Clear()

        dgvchitiet.AutoGenerateColumns = False
        dgvchitiet.AllowUserToAddRows = False
        dgvchitiet.Enabled = True
        dgvchitiet.DataSource = list

        Dim cltenvattu = New DataGridViewTextBoxColumn()
        cltenvattu.Name = "tenvattu"
        cltenvattu.HeaderText = " Vật Tư"
        cltenvattu.DataPropertyName = "tenvattu"
        dgvchitiet.Columns.Add(cltenvattu)
        cltenvattu.ReadOnly = True

        Dim cltondau = New DataGridViewTextBoxColumn()
        cltondau.Name = "tondau"
        cltondau.HeaderText = "Tồn Đầu"
        cltondau.DataPropertyName = "tondau"
        dgvchitiet.Columns.Add(cltondau)
        cltondau.ReadOnly = True

        Dim clphatsinh = New DataGridViewTextBoxColumn()
        clphatsinh.Name = "phatsinh"
        clphatsinh.HeaderText = "Phát Sinh"
        clphatsinh.DataPropertyName = "phatsinh"
        dgvchitiet.Columns.Add(clphatsinh)
        clphatsinh.ReadOnly = True

        Dim cltoncuoi = New DataGridViewTextBoxColumn()
        cltoncuoi.Name = "toncuoi"
        cltoncuoi.HeaderText = "Tồn Cuối"
        cltoncuoi.DataPropertyName = "toncuoi"
        dgvchitiet.Columns.Add(cltoncuoi)
        cltoncuoi.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvchitiet.DataSource)
        myCurrencyManager.Refresh()


        Return True
    End Function

    Private Sub btload_Click(sender As Object, e As EventArgs) Handles btload.Click
        Dim result As Result
        result = vtBus.selectvattu_baocao(dtpngay.Value, list)
        If (result.FlagResult = True) Then
            builddgv(list)
        Else
            MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btluu_Click(sender As Object, e As EventArgs) Handles btluu.Click
        Dim bc = New baocaovattuDTO()
        Dim ct = New chitietbaocaovattuDTO()


        bc.mabaocao = tbmabaocao.Text
        bc.thang = dtpngay.Value.Month
        bc.nam = dtpngay.Value.Year

        Dim result As Result
        result = bcBus.insert(bc)
        If (result.FlagResult = False) Then
            MessageBox.Show("Đã Xảy ra Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
            Me.Close()
        Else
            For Each item In list
                ct.mabaocao = tbmabaocao.Text
                ct.mavattu = item.mavattu
                ct.tondau = item.tondau
                ct.phatsinh = item.phatsinh
                ct.toncuoi = item.toncuoi
                result = ctBus.insert(ct)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Đã xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Next
            MessageBox.Show("Đã Lưu Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




    End Sub
End Class