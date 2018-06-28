Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class quanlyhieuxexe


    Private hxBus As hieuxeBus
    Private listhieuxe As List(Of hieuxeDTO)
    Private listtimkiem As List(Of hieuxeDTO)

    Private Sub quanlyhieuxexe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hxBus = New hieuxeBus()
        listhieuxe = New List(Of hieuxeDTO)
        listtimkiem = New List(Of hieuxeDTO)

        loadlisthieuxe()
        buildgv(listhieuxe)
        PanelCapnhat.Visible = False
    End Sub

    Private Function buildgv(list As List(Of hieuxeDTO)) As Boolean

        dgv.DataSource = Nothing
        dgv.Columns.Clear()

        dgv.AutoGenerateColumns = False
        dgv.AllowUserToAddRows = False
        dgv.Enabled = True
        dgv.DataSource = list

        Dim clmahieuxe = New DataGridViewTextBoxColumn()
        clmahieuxe.Name = "mahieuxe"
        clmahieuxe.HeaderText = "Mã Hiệu Xe"
        clmahieuxe.DataPropertyName = "mahieuxe"
        dgv.Columns.Add(clmahieuxe)
        clmahieuxe.ReadOnly = True

        Dim cltenhiexe = New DataGridViewTextBoxColumn()
        cltenhiexe.Name = "tenhieuxe"
        cltenhiexe.HeaderText = "Tên Hiệu Xe"
        cltenhiexe.DataPropertyName = "tenhieuxe"
        dgv.Columns.Add(cltenhiexe)
        cltenhiexe.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgv.DataSource)
        myCurrencyManager.Refresh()
        Return True
    End Function

    Private Function loadlisthieuxe() As Boolean
        Dim result As Result
        result = hxBus.selectAll(listhieuxe)
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
        n = listhieuxe.Count
        While (i < n)
            If (InStr(listhieuxe(i).Mahieuxe.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(listhieuxe(i))
                GoTo Thoat
            End If

            If (InStr(listhieuxe(i).Tenhieuxe, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(listhieuxe(i))
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
        Dim hieuxemoi = New hieuxeDTO()
        hieuxemoi.Mahieuxe = tbmahieuxe.Text
        hieuxemoi.Tenhieuxe = tbtenhieuxe.Text
        Dim result As Result
        result = hxBus.update(hieuxemoi)
        If (result.FlagResult = True) Then
            MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadlisthieuxe()
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
                Dim hieuxe = CType(dgv.Rows(currentRowIndex).DataBoundItem, hieuxeDTO)
                tbmahieuxe.Text = hieuxe.Mahieuxe
                tbtenhieuxe.Text = hieuxe.Tenhieuxe
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class