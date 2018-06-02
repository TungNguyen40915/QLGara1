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



    Private Sub tracuuxe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xBus = New xeBus()
        cxBus = New chuxeBus()
        hxBus = New hieuxeBus()
        listxe = New List(Of xeDTO)
        listxetracuu = New List(Of tracuuxeDTO)

        buildgv(listxetracuu)


        Dim listchuxe = New List(Of chuxeDTO)
        chuxegia = New chuxeDTO()
        Dim result As Result
        result = cxBus.selectAll(listchuxe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbbtenchuxe.DataSource = New BindingSource(listchuxe, String.Empty)
        cbbtenchuxe.DisplayMember = "Tenchuxe"
        cbbtenchuxe.ValueMember = "Machuxe"


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
        listhieuxe.Add(hieuxegia)
        cbbtenhieuxe.DataSource = New BindingSource(listhieuxe, String.Empty)
        cbbtenhieuxe.DisplayMember = "Tenhieuxe"
        cbbtenhieuxe.ValueMember = "Mahieuxe"
        cbbtenhieuxe1.DataSource = New BindingSource(listhieuxe, String.Empty)
        cbbtenhieuxe1.DisplayMember = "Tenhieuxe"
        cbbtenhieuxe1.ValueMember = "Mahieuxe"

        Button1.Enabled = False
        Panel5.Visible = False
    End Sub

    Private Function buildgv(listxe As List(Of tracuuxeDTO)) As Boolean

        ' dgv.DataSource = Nothing
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

    Private Sub cbbtenchuxe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbtenchuxe.SelectedIndexChanged
        Dim chuxe = New chuxeDTO()
        chuxe = cbbtenchuxe.SelectedItem
        tbmachuxe.Text = chuxe.Machuxe
    End Sub

    Private Sub cbbtenhieuxe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbtenhieuxe.SelectedIndexChanged
        Dim hieuxe = New hieuxeDTO()
        hieuxe = cbbtenhieuxe.SelectedItem
        tbmahieuxe.Text = hieuxe.Mahieuxe
    End Sub



    Private Sub tbmachuxe_TextChanged(sender As Object, e As EventArgs) Handles tbmachuxe.TextChanged
        If (tbmachuxe.Text <> Nothing) Then
            Dim result1 As Result
            Dim r = New chuxeDTO()
            result1 = cxBus.select_ByMachuxe(tbmachuxe.Text, r)
            If (result1.FlagResult = True) Then
                cbbtenchuxe.SelectedItem = r
                cbbtenchuxe.Text = r.Tenchuxe
            Else
                cbbtenchuxe.Text = ""
            End If
        End If
    End Sub

    Private Sub tbmahieuxe_TextChanged(sender As Object, e As EventArgs) Handles tbmahieuxe.TextChanged
        If (tbmahieuxe.Text <> Nothing) Then
            Dim r = New hieuxeDTO()
            Dim result1 As Result
            result1 = hxBus.select_ByMahieuxe((tbmahieuxe.Text), r)
            If (result1.FlagResult = True) Then
                cbbtenhieuxe.SelectedItem = r
                cbbtenhieuxe.Text = r.Tenhieuxe
            Else

                cbbtenhieuxe.Text = ""
            End If

        End If
    End Sub


    Private Function timkiemchuxe_hieuxe() As Boolean

        If (tbmahieuxe.Text <> Nothing) Then
            'listxetracuu.Clear()
            buildgv(listxetracuu)
            Dim a = New List(Of xeDTO)
            Dim result As Result
            result = xBus.select_Bymahieuxe(tbmahieuxe.Text, a)
            If (result.FlagResult = True) Then
                For Each t In a
                    Dim b = New hieuxeDTO()
                    result = hxBus.select_ByMahieuxe(Convert.ToInt32(tbmahieuxe.Text), b)
                    Dim c = New chuxeDTO()
                    result = cxBus.select_ByMachuxe(t.Machuxe, c)
                    listxetracuu.Add(New tracuuxeDTO(t.Bienso, c.Tenchuxe, b.Tenhieuxe, c.Tienno, b.Mahieuxe, c.Machuxe))
                    buildgv(listxetracuu)
                Next
            End If
        End If


        If (tbmachuxe.Text <> Nothing) Then
            'listxetracuu.Clear()
            buildgv(listxetracuu)
            Dim a = New List(Of xeDTO)
            Dim result As Result
            result = xBus.select_Bymachuxe(tbmachuxe.Text, a)
            If (result.FlagResult = True) Then
                For Each t In a
                    Dim b = New hieuxeDTO()
                    result = hxBus.select_ByMahieuxe(Convert.ToInt32(t.Mahieuxe), b)
                    Dim c = New chuxeDTO()
                    result = cxBus.select_ByMachuxe(t.Machuxe, c)
                    listxetracuu.Add(New tracuuxeDTO(t.Bienso, c.Tenchuxe, b.Tenhieuxe, c.Tienno, b.Mahieuxe, c.Machuxe))
                    buildgv(listxetracuu)
                Next
            End If
        End If
        Return True
    End Function

    Private Function timkiembienso() As Boolean
        If (tbbienso.Text.Length >= 9) Then
            Dim a = New xeDTO()
            Dim result As Result
            result = xBus.select_Bybienso(tbbienso.Text, a)
            If (result.FlagResult = True) Then
                Dim b = New hieuxeDTO()
                result = hxBus.select_ByMahieuxe(a.Mahieuxe, b)
                Dim c = New chuxeDTO()
                result = cxBus.select_ByMachuxe(a.Machuxe, c)
                listxetracuu.Add(New tracuuxeDTO(a.Bienso, c.Tenchuxe, b.Tenhieuxe, c.Tienno, b.Mahieuxe, c.Machuxe))
                buildgv(listxetracuu)

            End If


        End If



        If (tbbienso.Text.Length >= 2) Then
            ' listxetracuu.Clear()
            buildgv(listxetracuu)
            Dim a = New List(Of xeDTO)
            Dim result As Result
            result = xBus.select_Bymavung(tbbienso.Text, a)
            If (result.FlagResult = True) Then
                For Each t In a
                    Dim b = New hieuxeDTO()
                    result = hxBus.select_ByMahieuxe(Convert.ToInt32(t.Mahieuxe), b)
                    Dim c = New chuxeDTO()
                    result = cxBus.select_ByMachuxe(t.Machuxe, c)
                    listxetracuu.Add(New tracuuxeDTO(t.Bienso, c.Tenchuxe, b.Tenhieuxe, c.Tienno, b.Mahieuxe, c.Machuxe))
                    buildgv(listxetracuu)
                Next
            End If
        End If

        Return True

    End Function
    Private Sub bttim_Click(sender As Object, e As EventArgs) Handles bttim.Click
        listxetracuu.Clear()
        timkiemchuxe_hieuxe()
        timkiembienso()
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
        If (listxetracuu.Count = 0) Then
            Panel5.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (tbmachuxe1.Text <> Nothing And tbmahieuxe1.Text <> 0 And kiemtra() = True) Then
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
                tbbienso.Text = ""
                timkiemchuxe_hieuxe()
                timkiembienso()
            End If
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                tbbienso.Text = ""
                timkiembienso()
                timkiemchuxe_hieuxe()

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


    Private Function kiemtra() As Boolean
        Dim result1 As Result
        Dim r = New chuxeDTO()
        result1 = cxBus.select_ByMachuxe(tbmachuxe1.Text, r)
        If (result1.FlagResult = False) Then
            Return False
        End If

        Dim r1 = New hieuxeDTO()
        ' Dim result1 As Result
        result1 = hxBus.select_ByMahieuxe((tbmahieuxe1.Text), r1)
        If (result1.FlagResult = False) Then
            Return False
        End If

        Return True
    End Function

    Private Sub tbmachuxe1_TextChanged(sender As Object, e As EventArgs) Handles tbmachuxe1.TextChanged
        If (tbmachuxe1.Text <> Nothing) Then
            Dim result1 As Result
            Dim r = New chuxeDTO()
            result1 = cxBus.select_ByMachuxe(tbmachuxe1.Text, r)
            If (result1.FlagResult = True) Then
                cbbtenchuxe1.SelectedItem = r
                cbbtenchuxe1.Text = r.Tenchuxe
            Else
                cbbtenchuxe1.Text = ""
            End If
        End If
    End Sub

    Private Sub tbmahieuxe1_TextChanged(sender As Object, e As EventArgs) Handles tbmahieuxe1.TextChanged
        If (tbmahieuxe1.Text <> Nothing) Then
            Dim r = New hieuxeDTO()
            Dim result1 As Result
            result1 = hxBus.select_ByMahieuxe((tbmahieuxe1.Text), r)
            If (result1.FlagResult = True) Then
                cbbtenhieuxe1.SelectedItem = r
                cbbtenhieuxe1.Text = r.Tenhieuxe
            Else
                cbbtenhieuxe1.Text = ""
            End If
        End If
    End Sub


End Class