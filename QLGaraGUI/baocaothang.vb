Imports QLGaraBus
Imports QLGaraDTO
Imports Utility

Public Class baocaothang

    Private bcBus As baocaothangBus
    Private Sub baocaothang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bcBus = New baocaothangBus()

        dtpngay.Value = Now
        tbdoanhthu.Text = "0"

        loadID()

    End Sub

    Private Function loadID() As Boolean
        Dim result As Result
        Dim nextID As String
        nextID = Nothing
        result = bcBus.buildMBC(dtpngay.Value.Month, dtpngay.Value.Year, nextID)
        If (result.FlagResult = True) Then
            tbmabaocao.Text = nextID.ToString()
            Return True
        Else
            MessageBox.Show("Lấy ID của báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Return False
    End Function



    Private Function builddgvchitiet(list As List(Of baocaothangDTO))
        dgvchitiet.DataSource = Nothing
        dgvchitiet.Columns.Clear()

        dgvchitiet.AutoGenerateColumns = True
        dgvchitiet.AllowUserToAddRows = True
        dgvchitiet.Enabled = True
        dgvchitiet.DataSource = list

        Dim clhieuxe = New DataGridViewTextBoxColumn()
        clhieuxe.Name = "bienso"
        clhieuxe.HeaderText = "Biển Số"
        clhieuxe.DataPropertyName = "biensoxe"
        dgvchitiet.Columns.Add(clhieuxe)
        clhieuxe.ReadOnly = True

        Dim clmachuxe = New DataGridViewTextBoxColumn()
        clmachuxe.Name = "machuxe"
        clmachuxe.HeaderText = "Chủ Xe"
        clmachuxe.DataPropertyName = "tenchuxe"
        dgvchitiet.Columns.Add(clmachuxe)
        clmachuxe.ReadOnly = True

        Dim clmahieuxe = New DataGridViewTextBoxColumn()
        clmahieuxe.Name = "tenhieuxe"
        clmahieuxe.HeaderText = "Hiệu Xe"
        clmahieuxe.DataPropertyName = "tenhieuxe"
        dgvchitiet.Columns.Add(clmahieuxe)
        clmahieuxe.ReadOnly = True

        Dim cltienno = New DataGridViewTextBoxColumn()
        cltienno.Name = "tienno"
        cltienno.HeaderText = "Tiền nợ"
        cltienno.DataPropertyName = "tienno"
        dgvchitiet.Columns.Add(cltienno)
        cltienno.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvchitiet.DataSource)
        myCurrencyManager.Refresh()


        Return True
    End Function

    Private Sub dtpngay_ValueChanged(sender As Object, e As EventArgs) Handles dtpngay.ValueChanged
        loadID()
    End Sub



End Class