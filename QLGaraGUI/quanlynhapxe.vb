Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class quanlynhapxe
    Private cxBus As chuxeBus
    Private xBus As xeBus
    Private tnBus As tiepnhanxeBus
    Private hxBus As hieuxeBus
    Private tsBus As thamsoBus
    Private listphieuload As List(Of tiepnhanxeDTO)
    Private listphieu As List(Of tiepnhanxeDTO)

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        If (MessageBox.Show(" Đây là thao tác không thể phục hồi. Tiếp tục?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK) Then
            Dim result As Result
            result = tnBus.delete(tbmatn.Text)
            If (result.FlagResult = True) Then
                Dim currentRowIndex As Integer = dgv.CurrentCellAddress.Y
                Dim ptn = CType(dgv.Rows(currentRowIndex).DataBoundItem, tiepnhanxeDTO)
                listphieu.Remove(ptn)
                listphieuload.Remove(ptn)
                buildgv(listphieu)
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub quanlynhapxe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cxBus = New chuxeBus()
        xBus = New xeBus()
        tnBus = New tiepnhanxeBus()
        hxBus = New hieuxeBus()
        tsBus = New thamsoBus()
        listphieuload = New List(Of tiepnhanxeDTO)
        listphieu = New List(Of tiepnhanxeDTO)

        loadlistphieutiepnhan()

        buildgv(listphieuload)
        pnthongtin.Visible = False
    End Sub

    Private Function loadlistphieutiepnhan() As Boolean
        Dim result As Result
        result = tnBus.selectAll(listphieuload)
        If (result.FlagResult = False) Then
            MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        Return True
    End Function

    Private Function buildgv(listchitiet As List(Of tiepnhanxeDTO)) As Boolean

        dgv.DataSource = Nothing
        dgv.Columns.Clear()

        dgv.AutoGenerateColumns = False
        dgv.AllowUserToAddRows = False
        dgv.Enabled = True
        dgv.AllowUserToDeleteRows = True
        dgv.DataSource = listchitiet

        Dim clmatiepnhan = New DataGridViewTextBoxColumn()
        clmatiepnhan.Name = "matiepnhan"
        clmatiepnhan.HeaderText = "Mã Tiếp Nhận"
        clmatiepnhan.DataPropertyName = "matiepnhan"
        dgv.Columns.Add(clmatiepnhan)
        clmatiepnhan.ReadOnly = True

        Dim clbiensoxe = New DataGridViewTextBoxColumn()
        clbiensoxe.Name = "biensoxe"
        clbiensoxe.HeaderText = "Biển Số"
        clbiensoxe.DataPropertyName = "bienso"
        dgv.Columns.Add(clbiensoxe)
        clbiensoxe.ReadOnly = True

        Dim clngaytiepnhan = New DataGridViewTextBoxColumn()
        clngaytiepnhan.Name = "ngaytiepnhan"
        clngaytiepnhan.HeaderText = "Ngày tiếp nhận"
        clngaytiepnhan.DataPropertyName = "ngaytiepnhan"
        dgv.Columns.Add(clngaytiepnhan)
        clngaytiepnhan.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgv.DataSource)
        myCurrencyManager.Refresh()
        Return True
    End Function

    Private Function loadchuxe(id As String) As String
        Dim result As Result
        Dim cx = New chuxeDTO
        result = cxBus.select_ByMachuxe(id, cx)
        Return cx.Tenchuxe
    End Function

    Private Function loadhieuxe(id As String) As String
        Dim result As Result
        Dim hx = New hieuxeDTO
        result = hxBus.select_ByMahieuxe(id, hx)
        Return hx.Tenhieuxe
    End Function

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        Dim currentRowIndex As Integer = dgv.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgv.RowCount) Then
            Try
                Dim ptn = CType(dgv.Rows(currentRowIndex).DataBoundItem, tiepnhanxeDTO)
                tbbienso.Text = ptn.Bienso
                tbmatn.Text = ptn.Matiepnhan
                tbngaytiepnhan.Text = ptn.Ngaytiepnhan.ToString()
                Dim x = New xeDTO()
                Dim result As Result
                result = xBus.select_Bybienso(ptn.Bienso, x)
                tbchuxe.Text = loadchuxe(x.Machuxe)
                tbhieuxe.Text = loadhieuxe(x.Mahieuxe)
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btloc_Click(sender As Object, e As EventArgs) Handles btloc.Click
        tracuu()

    End Sub

    Private Function tracuu() As Boolean
        Dim timkiem = tbtimkiem.Text
        listphieu.Clear()
        Dim i = 0
        Dim n As Integer
        n = listphieuload.Count
        While (i < n)
            If (InStr(listphieuload(i).Bienso, timkiem, CompareMethod.Text) <> 0) Then
                listphieu.Add(listphieuload(i))
                GoTo Thoat
            End If

            If (InStr(listphieuload(i).Matiepnhan.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listphieu.Add(listphieuload(i))
                GoTo Thoat
            End If

            If (InStr(listphieuload(i).Ngaytiepnhan.ToString.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listphieu.Add(listphieuload(i))
                GoTo Thoat
            End If
            GoTo Thoat
Thoat:      i += 1
        End While

        buildgv(listphieu)
        Return True
    End Function

    Private Sub dgv_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv.DataSourceChanged
        If (listphieu.Count = 0) Then
            pnthongtin.Visible = False
        Else
            pnthongtin.Visible = True
        End If
    End Sub
End Class