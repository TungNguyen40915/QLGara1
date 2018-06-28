Imports QLGaraBus
Imports QLGaraDTO
Imports Utility


Public Class tracuuxe

    Private xBus As xeBus
    Private cxBus As chuxeBus
    Private hxBus As hieuxeBus
    Private listxe As List(Of xeDTO)
    Private chuxegia As chuxeDTO
    Private hieuxegia As hieuxeDTO
    Private listxetracuu As List(Of tracuuxeDTO)
    Private listxehienthi As List(Of tracuuxeDTO)
    Private tcBus As tracuuxeBus

    Private Sub tracuuxe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xBus = New xeBus()
        cxBus = New chuxeBus()
        hxBus = New hieuxeBus()
        listxe = New List(Of xeDTO)
        listxetracuu = New List(Of tracuuxeDTO)
        listxehienthi = New List(Of tracuuxeDTO)
        tcBus = New tracuuxeBus()

        Dim result As Result

        result = tcBus.selectall(listxetracuu)
        If (result.FlagResult = True) Then
            buildgv(listxetracuu)
        End If


        Dim listchuxe = New List(Of chuxeDTO)
        chuxegia = New chuxeDTO()



        result = cxBus.selectAll(listchuxe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbbtenchuxe1.DataSource = New BindingSource(listchuxe, String.Empty)
        cbbtenchuxe1.DisplayMember = "Tenchuxe"
        cbbtenchuxe1.ValueMember = "Machuxe"


        hieuxegia = New hieuxeDTO
        Dim listhieuxe = New List(Of hieuxeDTO)
        result = hxBus.selectAll(listhieuxe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        cbbtenhieuxe1.DataSource = New BindingSource(listhieuxe, String.Empty)
        cbbtenhieuxe1.DisplayMember = "Tenhieuxe"
        cbbtenhieuxe1.ValueMember = "Mahieuxe"

        Button1.Enabled = False
        Panel5.Visible = False

    End Sub

    Private Function buildgv(listxe As List(Of tracuuxeDTO)) As Boolean

        dgv.DataSource = Nothing
        dgv.Columns.Clear()

        dgv.AutoGenerateColumns = False
        dgv.AllowUserToAddRows = False
        dgv.Enabled = True
        dgv.DataSource = listxe

        Dim clbienso = New DataGridViewTextBoxColumn()
        clbienso.Name = "bienso"
        clbienso.HeaderText = "Biển Số"
        clbienso.DataPropertyName = "biensoxe"
        dgv.Columns.Add(clbienso)
        clbienso.ReadOnly = True

        Dim clmachuxe = New DataGridViewTextBoxColumn()
        clmachuxe.Name = "machuxe"
        clmachuxe.HeaderText = "Chủ Xe"
        clmachuxe.DataPropertyName = "tenchuxe"
        dgv.Columns.Add(clmachuxe)
        clmachuxe.ReadOnly = True

        Dim clmahieuxe = New DataGridViewTextBoxColumn()
        clmahieuxe.Name = "tenhieuxe"
        clmahieuxe.HeaderText = "Hiệu Xe"
        clmahieuxe.DataPropertyName = "tenhieuxe"
        dgv.Columns.Add(clmahieuxe)
        clmahieuxe.ReadOnly = True

        Dim cltienno = New DataGridViewTextBoxColumn()
        cltienno.Name = "tienno"
        cltienno.HeaderText = "Tiền nợ"
        cltienno.DataPropertyName = "tienno"
        dgv.Columns.Add(cltienno)
        cltienno.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgv.DataSource)
        myCurrencyManager.Refresh()


        Return True
    End Function

    Private Function tracuu() As Boolean
        Dim timkiem = tbtimkiem.Text
        listxehienthi.Clear()
        Dim i = 0
        Dim n As Integer
        n = listxetracuu.Count
        While (i < n)
            If (InStr(listxetracuu(i).biensoxe, timkiem, CompareMethod.Text) <> 0) Then
                listxehienthi.Add(listxetracuu(i))
                GoTo Thoat
            End If

            If (InStr(listxetracuu(i).machuxe.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listxehienthi.Add(listxetracuu(i))
                GoTo Thoat
            End If

            If (InStr(listxetracuu(i).mahieuxe.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listxehienthi.Add(listxetracuu(i))
                GoTo Thoat
            End If


            If (InStr(listxetracuu(i).tenchuxe, timkiem, CompareMethod.Text) <> 0) Then
                listxehienthi.Add(listxetracuu(i))
                GoTo Thoat
            End If

            If (InStr(listxetracuu(i).tenhieuxe, timkiem, CompareMethod.Text) <> 0) Then
                listxehienthi.Add(listxetracuu(i))
                GoTo Thoat
            End If
            GoTo Thoat
Thoat:      i += 1
        End While

        buildgv(listxehienthi)
        Return True
    End Function

    Private Sub bttim_Click(sender As Object, e As EventArgs) Handles bttim.Click
        tracuu()
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        Button1.Enabled = True
        Panel5.Visible = True
        Dim currentRowIndex As Integer = dgv.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgv.RowCount) Then
            Try
                Dim tracuu = CType(dgv.Rows(currentRowIndex).DataBoundItem, tracuuxeDTO)
                tbmahieuxe1.Text = tracuu.mahieuxe
                tbmachuxe1.Text = tracuu.machuxe
                tbbienso1.Text = tracuu.biensoxe
                Dim result1 As Result
                Dim r = New chuxeDTO()
                result1 = cxBus.select_ByMachuxe(tbmachuxe1.Text, r)
                If (result1.FlagResult = True) Then
                    cbbtenchuxe1.SelectedItem = r
                    cbbtenchuxe1.Text = r.Tenchuxe
                End If
                Dim rr = New hieuxeDTO()
                result1 = hxBus.select_ByMahieuxe(Convert.ToInt32(tbmahieuxe1.Text), rr)
                If (result1.FlagResult = True) Then
                    cbbtenhieuxe1.SelectedItem = rr
                    cbbtenhieuxe1.Text = rr.Tenhieuxe
                End If

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub dgv_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv.DataSourceChanged
        If (listxehienthi.Count = 0) Then
            Panel5.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xemoi As xeDTO
        xemoi = New xeDTO()
        xemoi.Bienso = tbbienso1.Text
        xemoi.Machuxe = tbmachuxe1.Text
        xemoi.Mahieuxe = Convert.ToInt32(tbmahieuxe1.Text)

        Dim result As Result
        result = xBus.update(xemoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Cập nhật xe không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show("Cập nhật xe thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tcBus.selectall(listxetracuu)
            tracuu()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (MessageBox.Show("Đây là thao tác không thể phục hồi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK) Then
            Dim result As Result
            result = xBus.delete(tbbienso1.Text)
            If (result.FlagResult = False) Then
                MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                MessageBox.Show("Đã xóa", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tcBus.selectall(listxetracuu)
                tracuu()

            End If
        End If

    End Sub



    Private Sub cbbtenchuxe1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbtenchuxe1.SelectedIndexChanged
        Dim chuxe = New chuxeDTO()
        chuxe = cbbtenchuxe1.SelectedItem
        tbmachuxe1.Text = chuxe.Machuxe
    End Sub

    Private Sub cbbtenhieuxe1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbtenhieuxe1.SelectedIndexChanged
        Dim hieuxe = New hieuxeDTO()
        hieuxe = cbbtenhieuxe1.SelectedItem
        tbmahieuxe1.Text = hieuxe.Mahieuxe
    End Sub
End Class