Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class baocaothang

    Private bcBus As baocaothangBus
    Private pscBus As phieusuachuaBus
    Private list As List(Of baocao1DTO)

    Private Sub baocaothang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bcBus = New baocaothangBus()
        pscBus = New phieusuachuaBus()
        list = New List(Of baocao1DTO)


        dtpngay.Value = Now
        tbdoanhthu.Text = "0"

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



    Private Function builddgv(list As List(Of baocao1DTO))
        dgvchitiet.DataSource = Nothing
        dgvchitiet.Columns.Clear()

        dgvchitiet.AutoGenerateColumns = False
        dgvchitiet.AllowUserToAddRows = False
        dgvchitiet.Enabled = True
        dgvchitiet.DataSource = list

        Dim cltenhieuxe = New DataGridViewTextBoxColumn()
        cltenhieuxe.Name = "tenhieuxe"
        cltenhieuxe.HeaderText = " Hiệu Xe"
        cltenhieuxe.DataPropertyName = "tenhieuxe"
        dgvchitiet.Columns.Add(cltenhieuxe)
        cltenhieuxe.ReadOnly = True

        Dim clsoluotsua = New DataGridViewTextBoxColumn()
        clsoluotsua.Name = "soluotsua"
        clsoluotsua.HeaderText = "Số Lượt Sửa"
        clsoluotsua.DataPropertyName = "soluotsua"
        dgvchitiet.Columns.Add(clsoluotsua)
        clsoluotsua.ReadOnly = True

        Dim clthanhtien = New DataGridViewTextBoxColumn()
        clthanhtien.Name = "thanhtien"
        clthanhtien.HeaderText = "Tổng tiền"
        clthanhtien.DataPropertyName = "thanhtien"
        dgvchitiet.Columns.Add(clthanhtien)
        clthanhtien.ReadOnly = True

        Dim cltile = New DataGridViewTextBoxColumn()
        cltile.Name = "tile"
        cltile.HeaderText = "Tỉ Lệ"
        cltile.DataPropertyName = "tile"
        dgvchitiet.Columns.Add(cltile)
        cltile.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvchitiet.DataSource)
        myCurrencyManager.Refresh()


        Return True
    End Function

    Private Sub dtpngay_ValueChanged(sender As Object, e As EventArgs) Handles dtpngay.ValueChanged
        loadID()
    End Sub

    Private Sub btload_Click(sender As Object, e As EventArgs) Handles btload.Click
        Dim result As Result
        Dim tongluot As Integer
        tongluot = 0
        result = pscBus.selectPhieuSC_bydate(dtpngay.Value, tongluot)
        If (result.FlagResult = True) Then
            result = pscBus.selectPhieuSC_BC1(dtpngay.Value, tongluot, list)
            If (result.FlagResult = False) Then
                MessageBox.Show("Đã có lỗi xảy ra1", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                builddgv(list)
                Dim tongtrigia As Integer
                tongtrigia = 0
                For Each item In list
                    tongtrigia += item.thanhtien

                Next
                tbdoanhthu.Text = tongtrigia.ToString()
            End If
        Else
            MessageBox.Show("Đã có lỗi xảy ra2", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub




End Class