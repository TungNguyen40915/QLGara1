Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class quanlyvattu
    Private vtBus As vattuBus
    Private list As List(Of vattuDTO)
    Private listtimkiem As List(Of vattuDTO)

    Private Sub quanlyvattu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vtBus = New vattuBus()
        list = New List(Of vattuDTO)
        listtimkiem = New List(Of vattuDTO)

        loadlist()
        buildgv(list)
        PanelCapnhat.Visible = False
    End Sub

    Private Function buildgv(list As List(Of vattuDTO)) As Boolean

        dgv.DataSource = Nothing
        dgv.Columns.Clear()

        dgv.AutoGenerateColumns = False
        dgv.AllowUserToAddRows = False
        dgv.Enabled = True
        dgv.DataSource = list

        Dim clmavattu = New DataGridViewTextBoxColumn()
        clmavattu.Name = "mavattu"
        clmavattu.HeaderText = "Mã Vật Tư"
        clmavattu.DataPropertyName = "mavattu"
        dgv.Columns.Add(clmavattu)
        clmavattu.ReadOnly = True

        Dim cltenvattu = New DataGridViewTextBoxColumn()
        cltenvattu.Name = "tenvattu"
        cltenvattu.HeaderText = "Tên Vật Tư"
        cltenvattu.DataPropertyName = "tenvattu"
        dgv.Columns.Add(cltenvattu)
        cltenvattu.ReadOnly = True

        Dim cldongia = New DataGridViewTextBoxColumn()
        cldongia.Name = "dongia"
        cldongia.HeaderText = "Đơn Giá"
        cldongia.DataPropertyName = "dongia"
        dgv.Columns.Add(cldongia)
        cldongia.ReadOnly = True

        Dim clluongton = New DataGridViewTextBoxColumn()
        clluongton.Name = "luongton"
        clluongton.HeaderText = "Lượng Tồn"
        clluongton.DataPropertyName = "soluong"
        dgv.Columns.Add(clluongton)
        clluongton.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgv.DataSource)
        myCurrencyManager.Refresh()
        Return True
    End Function

    Private Function loadlist() As Boolean
        Dim result As Result
        result = vtBus.selectall(list)
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
        n = list.Count
        While (i < n)
            If (InStr(list(i).mavattu.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(list(i))
                GoTo Thoat
            End If

            If (InStr(list(i).tenvattu, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(list(i))
                GoTo Thoat
            End If

            If (InStr(list(i).dongia.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(list(i))
                GoTo Thoat
            End If

            If (InStr(list(i).soluong.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(list(i))
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
        Dim vattumoi = New vattuDTO()
        vattumoi.mavattu = tbmavattu.Text
        vattumoi.tenvattu = tbtenvattu.Text
        vattumoi.dongia = Convert.ToInt32(tbdongia.Text)
        vattumoi.soluong = Convert.ToInt32(tbluongton.Text)
        Dim result As Result
        result = vtBus.update(vattumoi)
        If (result.FlagResult = True) Then
            MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadlist()
            tracuu()
        Else
            MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        PanelCapnhat.Visible = True
        Dim currentRowIndex As Integer = dgv.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgv.RowCount) Then
            Try
                Dim vattu = CType(dgv.Rows(currentRowIndex).DataBoundItem, vattuDTO)
                tbmavattu.Text = vattu.mavattu
                tbtenvattu.Text = vattu.tenvattu
                tbdongia.Text = vattu.dongia.ToString
                tbluongton.Text = vattu.soluong.ToString
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class