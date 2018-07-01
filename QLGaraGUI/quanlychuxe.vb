Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class quanlychuxe
    Private cxBus As chuxeBus
    Private listchuxe As List(Of chuxeDTO)
    Private listtimkiem As List(Of chuxeDTO)

    Private Sub quanlychuxe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cxBus = New chuxeBus()
        listchuxe = New List(Of chuxeDTO)
        listtimkiem = New List(Of chuxeDTO)

        loadlistchuxe()
        If (loadlistchuxe() = False) Then
            MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If
        buildgv(listchuxe)
        PanelCapnhat.Visible = False
    End Sub

    Private Function buildgv(list As List(Of chuxeDTO)) As Boolean

        dgv.DataSource = Nothing
        dgv.Columns.Clear()

        dgv.AutoGenerateColumns = False
        dgv.AllowUserToAddRows = False
        dgv.Enabled = True
        dgv.DataSource = list

        Dim clmachuxe = New DataGridViewTextBoxColumn()
        clmachuxe.Name = "machuxe"
        clmachuxe.HeaderText = "Mã Chủ Xe"
        clmachuxe.DataPropertyName = "machuxe"
        dgv.Columns.Add(clmachuxe)
        clmachuxe.ReadOnly = True

        Dim cltenchuxe = New DataGridViewTextBoxColumn()
        cltenchuxe.Name = "tenchuxe"
        cltenchuxe.HeaderText = "Tên Chủ Xe"
        cltenchuxe.DataPropertyName = "tenchuxe"
        dgv.Columns.Add(cltenchuxe)
        cltenchuxe.ReadOnly = True

        Dim cldienthoai = New DataGridViewTextBoxColumn()
        cldienthoai.Name = "dienthoai"
        cldienthoai.HeaderText = "Điện Thoại"
        cldienthoai.DataPropertyName = "dienthoai"
        dgv.Columns.Add(cldienthoai)
        cldienthoai.ReadOnly = True


        Dim cldiachi = New DataGridViewTextBoxColumn()
        cldiachi.Name = "diachi"
        cldiachi.HeaderText = "Địa Chỉ"
        cldiachi.DataPropertyName = "diachi"
        dgv.Columns.Add(cldiachi)
        cldiachi.ReadOnly = True



        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgv.DataSource)
        myCurrencyManager.Refresh()
        Return True
    End Function

    Private Function loadlistchuxe() As Boolean
        Dim result As Result
        result = cxBus.selectAll(listchuxe)
        Return result.FlagResult
    End Function

    Private Sub bttim_Click(sender As Object, e As EventArgs) Handles bttim.Click
        tracuu()
    End Sub

    Private Function tracuu() As Boolean
        Dim timkiem = tbtimkiem.Text
        listtimkiem.Clear()
        Dim i = 0
        Dim n As Integer
        n = listchuxe.Count
        While (i < n)
            If (InStr(listchuxe(i).Machuxe.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(listchuxe(i))
                GoTo Thoat
            End If

            If (InStr(listchuxe(i).Tenchuxe, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(listchuxe(i))
                GoTo Thoat
            End If

            If (InStr(listchuxe(i).Dienthoai.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(listchuxe(i))
                GoTo Thoat
            End If

            If (InStr(listchuxe(i).Diachi, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(listchuxe(i))
                GoTo Thoat
            End If
            GoTo Thoat
Thoat:      i += 1
        End While

        buildgv(listtimkiem)
        Return True
    End Function

    Private Sub dgv_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv.DataSourceChanged
        If (listtimkiem.Count = 0) Then
            PanelCapnhat.Visible = False
        End If
    End Sub

    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click

        Dim chuxemoi = New chuxeDTO()
            chuxemoi.Machuxe = tbmachuxe.Text
            chuxemoi.Tenchuxe = tbtenchuxe.Text
            chuxemoi.Diachi = tbdiachi.Text
            chuxemoi.Dienthoai = Convert.ToInt32(tbdienthoai.Text)

        If (cxBus.CheckAndStandardizationName(chuxemoi) And tbdiachi.Text <> Nothing And tbdienthoai.Text <> Nothing And tbtenchuxe.Text = Nothing) Then
            Dim result As Result
            result = cxBus.update(chuxemoi)
            If (result.FlagResult = True) Then
                MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadlistchuxe()
                tracuu()
            Else
                MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Vui lòng kiểm tra lại thông tin chủ xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        PanelCapnhat.Visible = True
        Dim currentRowIndex As Integer = dgv.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgv.RowCount) Then
            Try
                Dim chuxe = CType(dgv.Rows(currentRowIndex).DataBoundItem, chuxeDTO)
                tbmachuxe.Text = chuxe.Machuxe
                tbtenchuxe.Text = chuxe.Tenchuxe
                tbdienthoai.Text = chuxe.Dienthoai
                tbdiachi.Text = chuxe.Diachi
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub tbdienthoai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbdienthoai.KeyPress
        Dim mK As Integer = Asc(e.KeyChar)
        e.Handled = Not ((mK >= 48 And mK <= 57) Or mK = 8)
    End Sub
End Class