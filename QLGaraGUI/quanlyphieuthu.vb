Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class quanlyphieuthu

    Private ptbus As phieuthuBus
    Private list As List(Of phieuthuDTO)
    Private listtimkiem As List(Of phieuthuDTO)
    Private Sub quanlyphieuthu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ptbus = New phieuthuBus()
        list = New List(Of phieuthuDTO)
        listtimkiem = New List(Of phieuthuDTO)

        loadlist()
        buildgv(list)
    End Sub

    Private Function buildgv(list As List(Of phieuthuDTO)) As Boolean

        dgv.DataSource = Nothing
        dgv.Columns.Clear()

        dgv.AutoGenerateColumns = False
        dgv.AllowUserToAddRows = False
        dgv.Enabled = True
        dgv.DataSource = list

        Dim clmaphieuthu = New DataGridViewTextBoxColumn()
        clmaphieuthu.Name = "maphieu"
        clmaphieuthu.HeaderText = "Mã Phiếu"
        clmaphieuthu.DataPropertyName = "maphieu"
        dgv.Columns.Add(clmaphieuthu)
        clmaphieuthu.ReadOnly = True

        Dim clbienso = New DataGridViewTextBoxColumn()
        clbienso.Name = "bienso"
        clbienso.HeaderText = "Biển Số"
        clbienso.DataPropertyName = "bienso"
        dgv.Columns.Add(clbienso)
        clbienso.ReadOnly = True

        Dim clngaythu = New DataGridViewTextBoxColumn()
        clngaythu.Name = "ngaythu"
        clngaythu.HeaderText = "Ngày Thu"
        clngaythu.DataPropertyName = "ngaythu"
        dgv.Columns.Add(clngaythu)
        clngaythu.ReadOnly = True

        Dim cltongtien = New DataGridViewTextBoxColumn()
        cltongtien.Name = "tongtien"
        cltongtien.HeaderText = "Tổng Tiền"
        cltongtien.DataPropertyName = "tongtien"
        dgv.Columns.Add(cltongtien)
        cltongtien.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgv.DataSource)
        myCurrencyManager.Refresh()
        Return True
    End Function

    Private Function loadlist() As Boolean
        Dim result As Result
        result = ptbus.selectall(list)
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
            If (InStr(list(i).maphieu, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(list(i))
                GoTo Thoat
            End If

            If (InStr(list(i).bienso, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(list(i))
                GoTo Thoat
            End If

            If (InStr(list(i).ngaythu.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(list(i))
                GoTo Thoat
            End If

            If (InStr(list(i).tongtien.ToString, timkiem, CompareMethod.Text) <> 0) Then
                listtimkiem.Add(list(i))
                GoTo Thoat
            End If

            GoTo Thoat
Thoat:      i += 1
        End While

        buildgv(listtimkiem)
        Return True
    End Function
End Class