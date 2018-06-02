Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class lapphieusuachua

    Private pscBus As phieusuachuaBus
    Private ctpscBus As chitietphieusuachuaBus
    Private cxBus As chuxeBus
    Private hxBus As hieuxeBus
    Private ndBus As noidungBus
    Private vtBus As vattuBus
    Private xBus As xeBus
    Private listhienthi As List(Of suachuaDTO)
    Private listnoidung As List(Of noidungDTO)
    Private listvattu As List(Of vattuDTO)
    Private tongtrigia As Integer
    Private Sub lapphieusuachua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pscBus = New phieusuachuaBus()
        xBus = New xeBus()
        cxBus = New chuxeBus()
        hxBus = New hieuxeBus()
        ndBus = New noidungBus()
        vtBus = New vattuBus()
        ctpscBus = New chitietphieusuachuaBus()
        listhienthi = New List(Of suachuaDTO)
        listnoidung = New List(Of noidungDTO)
        listvattu = New List(Of vattuDTO)
        tongtrigia = 0



        loadID()
        tbtongtien.Text = "0"
        buildgv(listhienthi)


        Dim result As Result
        result = ndBus.selectall(listnoidung)
        If (result.FlagResult = True) Then
            cbbnoidung.DataSource = New BindingSource(listnoidung, String.Empty)
            cbbnoidung.DisplayMember = "tennoidung"
            cbbnoidung.ValueMember = "mand"
        End If

        result = vtBus.selectall(listvattu)
        If (result.FlagResult = True) Then
            cbbvattu.DataSource = New BindingSource(listvattu, String.Empty)
            cbbvattu.DisplayMember = "tenvattu"
            cbbvattu.ValueMember = "mavattu"
        End If

    End Sub

    Private Function loadID() As Boolean
        Dim result As Result
        Dim nextID As String
        nextID = Nothing
        result = pscBus.buildMP(dtpngaytiepnhan.Value, nextID)
        If (result.FlagResult = True) Then
            tbmaphieu.Text = nextID.ToString()
            Return True
        Else
            MessageBox.Show("Lấy ID của phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Return False
    End Function

    Private Function loadthongtinxe() As Boolean
        Dim a = New xeDTO()
        Dim result As Result
        result = xBus.select_Bybienso(tbbienso.Text, a)
        If (result.FlagResult = True) Then
            Dim b = New hieuxeDTO()
            result = hxBus.select_ByMahieuxe(a.Mahieuxe, b)
            tbhieuxe.Text = b.Tenhieuxe
            Dim c = New chuxeDTO()
            result = cxBus.select_ByMachuxe(a.Machuxe, c)
            tbchuxe.Text = c.Tenchuxe
            Return True
        End If
        Return False
    End Function

    Private Sub tbbienso_TextChanged(sender As Object, e As EventArgs) Handles tbbienso.TextChanged
        loadthongtinxe()
    End Sub

    Private Sub dtpngaytiepnhan_ValueChanged(sender As Object, e As EventArgs) Handles dtpngaytiepnhan.ValueChanged
        loadID()
    End Sub

    Private Sub btthemvattu_Click(sender As Object, e As EventArgs) Handles btthemvattu.Click
        Dim newf = New themvattu()
        newf.ShowDialog(Me)
    End Sub

    Private Sub btthemnoidung_Click(sender As Object, e As EventArgs) Handles btthemnoidung.Click
        Dim newf = New themnoidung()
        newf.ShowDialog(Me)
    End Sub

    Private Function buildgv(listchitiet As List(Of suachuaDTO)) As Boolean

        ' dgv.DataSource = Nothing
        '  dgv.Columns.Clear()

        dgv.AutoGenerateColumns = False
        dgv.AllowUserToAddRows = False
        dgv.Enabled = True
        dgv.AllowUserToDeleteRows = True
        dgv.DataSource = listchitiet

        Dim clnoidung = New DataGridViewTextBoxColumn()
        clnoidung.Name = "noidung"
        clnoidung.HeaderText = "Nội Dung"
        clnoidung.DataPropertyName = "tennoidung"
        dgv.Columns.Add(clnoidung)
        clnoidung.ReadOnly = True

        Dim clvattu = New DataGridViewTextBoxColumn()
        clvattu.Name = "vattu"
        clvattu.HeaderText = "Vật Tư"
        clvattu.DataPropertyName = "tenvattu"
        dgv.Columns.Add(clvattu)
        clvattu.ReadOnly = True

        Dim clsoluong = New DataGridViewTextBoxColumn()
        clsoluong.Name = "soluong"
        clsoluong.HeaderText = "Số Lượng"
        clsoluong.DataPropertyName = "soluong"
        dgv.Columns.Add(clsoluong)
        'clsoluong.ReadOnly = True

        Dim cldongia = New DataGridViewTextBoxColumn()
        cldongia.Name = "dongia"
        cldongia.HeaderText = "Đơn Giá"
        cldongia.DataPropertyName = "dongia"
        dgv.Columns.Add(cldongia)
        '  cldongia.ReadOnly = True


        Dim cltiencong = New DataGridViewTextBoxColumn()
        cltiencong.Name = "tiencong"
        cltiencong.HeaderText = "Tiền Công"
        cltiencong.DataPropertyName = "tiencong"
        dgv.Columns.Add(cltiencong)
        '  cltiencong.ReadOnly = True

        Dim cltongtien = New DataGridViewTextBoxColumn()
        cltongtien.Name = "tongtien"
        cltongtien.HeaderText = "Tổng tiền"
        cltongtien.DataPropertyName = "tongtien"
        dgv.Columns.Add(cltongtien)
        cltongtien.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgv.DataSource)
        myCurrencyManager.Refresh()


        Return True
    End Function


    Private Function loadnoidung(ByRef a As noidungDTO) As Boolean
        Dim result As Result
        result = ndBus.select_Bymand(tbmanoidung.Text, a)
        Return result.FlagResult
    End Function

    Private Function loadvattu(ByRef a As vattuDTO) As Boolean
        Dim result As Result
        result = vtBus.select_Bymavattu(tbmavattu.Text, a)
        Return result.FlagResult
    End Function
    Private Sub tbmanoidung_TextChanged(sender As Object, e As EventArgs) Handles tbmanoidung.TextChanged
        Dim a = New noidungDTO()
        If (loadnoidung(a) = True) Then
            cbbnoidung.Text = a.tennoidung
        Else
            cbbnoidung.Text = String.Empty
        End If

    End Sub

    Private Sub tbmavattu_TextChanged(sender As Object, e As EventArgs) Handles tbmavattu.TextChanged
        Dim a = New vattuDTO()
        If (loadvattu(a) = True) Then
            cbbvattu.Text = a.tenvattu
        Else
            cbbvattu.Text = String.Empty
        End If

    End Sub

    Private Sub cbbnoidung_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbnoidung.SelectedIndexChanged
        Dim a As noidungDTO
        a = cbbnoidung.SelectedItem
        tbmanoidung.Text = a.mand
    End Sub

    Private Sub cbbvattu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbvattu.SelectedIndexChanged
        Dim a As vattuDTO
        a = cbbvattu.SelectedItem
        tbmavattu.Text = a.mavattu
    End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim nd = New noidungDTO()
        Dim vt = New vattuDTO()
        If (tbmanoidung.Text = Nothing Or loadnoidung(nd) = False) Then
            MessageBox.Show("Vui lòng kiểm tra lại nội dung sửa chữa ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (tbmavattu.Text = Nothing) Then
                Dim vtgia = New vattuDTO(0, "", 0, 0)
                Dim tt = nd.tiencong
                listhienthi.Add(New suachuaDTO(nd.mand, nd.tennoidung, vtgia.mavattu, vtgia.tenvattu, 0, vt.dongia, nd.tiencong, tt.ToString()))
                buildgv(listhienthi)
                tongtrigia += tt
                tbtongtien.Text = tongtrigia
            ElseIf (loadvattu(vt) = True) Then
                Dim tt = vt.dongia + nd.tiencong
                listhienthi.Add(New suachuaDTO(nd.mand, nd.tennoidung, vt.mavattu, vt.tenvattu, 1, vt.dongia, nd.tiencong, tt.ToString()))
                buildgv(listhienthi)
                tongtrigia += tt
                tbtongtien.Text = tongtrigia
            Else
                MessageBox.Show("Vui lòng kiểm tra lại vật tư ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


    End Sub



    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim currentRowIndex As Integer = dgv.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgv.RowCount) Then
            Try

                Dim suachua = CType(dgv.Rows(currentRowIndex).DataBoundItem, suachuaDTO)
                listhienthi.Remove(suachua)
                buildgv(listhienthi)


                Dim myCurrencyManager11 As CurrencyManager = Me.BindingContext(dgv.DataSource)
                myCurrencyManager11.Refresh()

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btluu_Click(sender As Object, e As EventArgs) Handles btluu.Click
        If (tbbienso.Text = Nothing Or dgv.RowCount = 0 Or loadthongtinxe() = False) Then
            MessageBox.Show("Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (luuphieu() = False Or luuchitiet() = False) Then
                MessageBox.Show("Lỗi")
            Else
                MessageBox.Show("Thành công")
                loadID()
                dgv.DataSource = Nothing
                tbbienso.Text = String.Empty

            End If
        End If
    End Sub

    Private Function luuphieu() As Boolean
        Dim psc = New phieusuachuaDTO()
        Dim result As Result

        psc.maphieu = tbmaphieu.Text
        psc.bienso = tbbienso.Text
        psc.ngay = dtpngaytiepnhan.Value
        psc.tongtien = Convert.ToInt32(tbtongtien.Text)

        result = pscBus.insert(psc)
        Return result.FlagResult

    End Function

    Private Function luuchitiet()
        For i = 0 To dgv.RowCount - 1
            Dim suachua = CType(dgv.Rows(i).DataBoundItem, suachuaDTO)

            Dim ct As chitietphieusuachuaDTO
            ct = New chitietphieusuachuaDTO(tbmaphieu.Text, suachua.mavattu, suachua.manoidung, suachua.soluong, suachua.dongia, suachua.tiencong, suachua.tongtien)

            Dim result As Result
            result = ctpscBus.insert(ct)

            If (result.FlagResult = False) Then
                Return False
            End If

        Next
        Return True
    End Function

    Private Sub dgv_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellValueChanged
        Dim currentRowIndex As Integer = dgv.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgv.RowCount) Then
            Try

                Dim ct = CType(dgv.Rows(currentRowIndex).DataBoundItem, suachuaDTO)

                listhienthi.Remove(ct)
                ' buildgv(listhienthi)
                tbtongtien.Text = (Convert.ToInt32(tbtongtien.Text) - ct.tongtien).ToString()
                ct.tongtien = ct.soluong * ct.dongia + ct.tiencong
                listhienthi.Add(ct)

                buildgv(listhienthi)

                tbtongtien.Text = (Convert.ToInt32(tbtongtien.Text) + ct.tongtien).ToString()

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
End Class