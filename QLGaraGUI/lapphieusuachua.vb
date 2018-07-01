Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class lapphieusuachua

    Private pscBus As phieusuachuaBus
    Private ctpscBus As chitietphieusuachuaBus


    Private cxBus As chuxeBus
    Private hxBus As hieuxeBus
    Private vtBus As vattuBus
    Private xBus As xeBus


    Private listhienthi As List(Of suachuaDTO)
    Private listvattu As List(Of vattuDTO)

    Private tongtrigia As Integer
    Private Sub lapphieusuachua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pscBus = New phieusuachuaBus()
        xBus = New xeBus()
        cxBus = New chuxeBus()
        hxBus = New hieuxeBus()
        vtBus = New vattuBus()
        ctpscBus = New chitietphieusuachuaBus()
        listhienthi = New List(Of suachuaDTO)
        listvattu = New List(Of vattuDTO)
        tongtrigia = 0

        loadID()
        tbtongtien.Text = "0"
        buildgv(listhienthi)


        Dim result As Result
        result = vtBus.selectall(listvattu)
        If (result.FlagResult = True) Then
            listvattu.Add(New vattuDTO(0, "<Không có>", 0, 0))
            cbbvattu.DataSource = New BindingSource(listvattu, String.Empty)
            cbbvattu.DisplayMember = "tenvattu"
            cbbvattu.ValueMember = "mavattu"
        Else
            MessageBox.Show("Không thể lấy danh sách vật tư", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        tbtiencong.Text = "0"
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
            Me.Close()
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

    Private Sub dtpngaytiepnhan_ValueChanged(sender As Object, e As EventArgs) Handles dtpngaytiepnhan.ValueChanged
        loadID()
    End Sub

    Private Sub btthemvattu_Click(sender As Object, e As EventArgs) Handles btthemvattu.Click
        Dim newf = New themvattu()
        newf.ShowDialog(Me)
    End Sub

    Private Function buildgv(listchitiet As List(Of suachuaDTO)) As Boolean

        dgv.DataSource = Nothing
        dgv.Columns.Clear()

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
        clsoluong.ReadOnly = True

        Dim cldongia = New DataGridViewTextBoxColumn()
        cldongia.Name = "dongia"
        cldongia.HeaderText = "Đơn Giá"
        cldongia.DataPropertyName = "dongia"
        dgv.Columns.Add(cldongia)
        cldongia.ReadOnly = True


        Dim cltiencong = New DataGridViewTextBoxColumn()
        cltiencong.Name = "tiencong"
        cltiencong.HeaderText = "Tiền Công"
        cltiencong.DataPropertyName = "tiencong"
        dgv.Columns.Add(cltiencong)
        cltiencong.ReadOnly = True

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


    Private Function loadvattu(ByRef a As vattuDTO) As Boolean
        Dim result As Result
        result = vtBus.select_Bymavattu(tbmavattu.Text, a)
        Return result.FlagResult
    End Function


    Private Sub cbbvattu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbvattu.SelectedIndexChanged
        Dim a As vattuDTO
        a = cbbvattu.SelectedItem
        tbmavattu.Text = a.mavattu
    End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click

        If (tbnoidung.Text = Nothing) Then
            MessageBox.Show("Vui lòng nhập lại nội dung sửa chữa ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (tbtiencong.Text <> Nothing) Then
            Dim vt As vattuDTO
            vt = cbbvattu.SelectedItem
            Dim tt = vt.dongia * nudsoluong.Value + Convert.ToInt32(tbtiencong.Text)
            listhienthi.Add(New suachuaDTO(tbnoidung.Text, vt.mavattu, vt.tenvattu, nudsoluong.Value, vt.dongia, Convert.ToInt32(tbtiencong.Text), vt.dongia * nudsoluong.Value + Convert.ToInt32(tbtiencong.Text)))
            buildgv(listhienthi)
            tongtrigia += tt
            tbtongtien.Text = tongtrigia
        Else
            MessageBox.Show("Vui lòng nhập tiền công sửa chữa ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub



    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim currentRowIndex As Integer = dgv.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgv.RowCount) Then
            Try

                Dim suachua = CType(dgv.Rows(currentRowIndex).DataBoundItem, suachuaDTO)
                Dim tt = Convert.ToInt32(tbtongtien.Text)
                tt -= suachua.tongtien
                tbtongtien.Text = tt.ToString()
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
                MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadID()
                dgv.Columns.Clear()

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
        Dim NumOfRow As Integer
        NumOfRow = dgv.RowCount

        Dim i = 0

        While (i < NumOfRow)


            Dim suachua = CType(dgv.Rows(i).DataBoundItem, suachuaDTO)

            Dim ct As chitietphieusuachuaDTO
            Dim machitiet = String.Empty
            If (i <= 9) Then
                machitiet = tbmaphieu.Text + "0" + (i + 1).ToString()
            Else
                machitiet = tbmaphieu.Text + (i + 1).ToString()
            End If
            ct = New chitietphieusuachuaDTO(machitiet, tbmaphieu.Text, suachua.mavattu, suachua.tennoidung, suachua.soluong, suachua.dongia, suachua.tiencong, suachua.tongtien)

            Dim result As Result
            result = ctpscBus.insert(ct)



            If (result.FlagResult = True) Then
                Dim vt = New vattuDTO()
                vtBus.select_Bymavattu(suachua.mavattu.ToString, vt)
                vt.soluong = vt.soluong - suachua.soluong
                vtBus.update(vt)

                Return True
            End If
            i += 1
        End While
        Return True
    End Function
    Private Sub tbbienso_Leave(sender As Object, e As EventArgs) Handles tbbienso.Leave
        loadthongtinxe()
    End Sub

    Private Sub tbtiencong_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbtiencong.KeyPress
        Dim mK As Integer = Asc(e.KeyChar)
        e.Handled = Not ((mK >= 48 And mK <= 57) Or mK = 8)
    End Sub


End Class