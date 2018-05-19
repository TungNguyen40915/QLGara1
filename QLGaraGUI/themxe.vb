﻿Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class themxe

    Private xBus As xeBus
    Private cxBus As chuxeBus
    Private hxBus As hieuxeBus
    Private Sub themxe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xBus = New xeBus()
        cxBus = New chuxeBus()
        hxBus = New hieuxeBus()


        Dim listchuxe = New List(Of chuxeDTO)
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


        Dim listhieuxe = New List(Of hieuxeDTO)
        result = hxBus.selectAll(listhieuxe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbbtenhieuxe.DataSource = New BindingSource(listhieuxe, String.Empty)
        cbbtenhieuxe.DisplayMember = "Tenhieuxe"
        cbbtenhieuxe.ValueMember = "Mahieuxe"


    End Sub

    Private Sub cbbtenchuxe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbtenchuxe.SelectedIndexChanged
        Dim a As chuxeDTO
        a = cbbtenchuxe.SelectedItem

        tbmachuxe.Text = a.Machuxe

    End Sub

    Private Sub cbbtenhieuxe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbtenhieuxe.SelectedIndexChanged
        Dim a As hieuxeDTO
        a = cbbtenhieuxe.SelectedItem
        tbmahieuxe.Text = a.Mahieuxe
    End Sub

    Private Sub btluu_Click(sender As Object, e As EventArgs) Handles btluu.Click
        If (kiemtra() = True) Then
            Dim x As xeDTO

            x = New xeDTO()

            '1. Mapping data from GUI control
            x.Bienso = tbbienso.Text
            x.Machuxe = tbmachuxe.Text
            x.Mahieuxe = Convert.ToInt32(tbmahieuxe.Text)

            '2. Insert to DB
            Dim result As Result
            result = xBus.insert(x)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm Xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbbienso.Text = String.Empty

            Else
                MessageBox.Show("Thêm hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function loadchuxe(ByRef a As chuxeDTO) As Boolean
        Dim result As Result
        result = cxBus.select_ByMachuxe(tbmachuxe.Text, a)
        If (result.FlagResult = False) Then
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub tbmachuxe_KeyDown(sender As Object, e As KeyEventArgs) Handles tbmachuxe.KeyDown
        Dim temp = cbbtenchuxe.SelectedItem
        If (e.KeyCode = Keys.Enter) Then
            Dim a = New chuxeDTO
            If (loadchuxe(a) = False) Then
                Dim b = "Không tìm thấy chủ xe có mã là " + tbmachuxe.Text
                MessageBox.Show(b, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbbtenchuxe.SelectedItem = temp
                tbmachuxe.Text = temp.machuxe
            Else
                cbbtenchuxe.Text = a.Tenchuxe
            End If
        End If


    End Sub


    Private Function loadhieuxe(ByRef a As hieuxeDTO)
        Dim result As Result
        result = hxBus.select_ByMahieuxe(Convert.ToInt32(tbmahieuxe.Text), a)
        If (result.FlagResult = False) Then
            Return False
        Else
            Return True
        End If
    End Function



    Private Function kiemtra()
        If (tbbienso.Text = Nothing Or tbmachuxe.Text = Nothing Or tbmahieuxe.Text = Nothing) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Label6_MouseMove(sender As Object, e As MouseEventArgs) Handles Label6.MouseMove
        Label6.ForeColor = Color.Blue
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.Black
    End Sub

    Private Sub Label7_MouseMove(sender As Object, e As MouseEventArgs) Handles Label7.MouseMove
        Label7.ForeColor = Color.Blue
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = Color.Black
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim fthemchuxe = New themchuxe()
        fthemchuxe.ShowDialog(Me)

        Dim listchuxe = New List(Of chuxeDTO)
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
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim fthemhieuxe = New themhieuxe()
        fthemhieuxe.ShowDialog(Me)


        Dim listhieuxe = New List(Of hieuxeDTO)
        Dim result As Result
        result = hxBus.selectAll(listhieuxe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbbtenhieuxe.DataSource = New BindingSource(listhieuxe, String.Empty)
        cbbtenhieuxe.DisplayMember = "Tenhieuxe"
        cbbtenhieuxe.ValueMember = "Mahieuxe"
    End Sub

    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        If (MessageBox.Show("Thông tin chưa được lưu. Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub


End Class