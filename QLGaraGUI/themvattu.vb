
Imports QLGaraBus
Imports QLGaraDTO
Imports Utility
Public Class themvattu
    Private vtBus As vattuBus
    Private Sub themvattu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vtBus = New vattuBus()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = vtBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbmavattu.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Vật Tư không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        btluu.Enabled = False
    End Sub

    Private Function kiemtra() As Boolean
        If (tbtenvattu.Text = Nothing Or tbdongia.Text = Nothing) Then
            Return False
        End If
        Return True
    End Function

    Private Sub btluu_Click(sender As Object, e As EventArgs) Handles btluu.Click
        If (kiemtra() = True) Then
            Dim vt As vattuDTO

            vt = New vattuDTO()

            '1. Mapping data from GUI control
            vt.mavattu = Convert.ToInt32(tbmavattu.Text)
            vt.tenvattu = tbtenvattu.Text
            vt.dongia = tbdongia.Text
            vt.soluong = 0


            '2. Insert to DB
            Dim result As Result
            result = vtBus.insert(vt)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm Vật Tư thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbtenvattu.Text = String.Empty
                tbdongia.Text = String.Empty

                ' Get Next ID
                Dim nextID As Integer
                result = vtBus.getNextID(nextID)
                If (result.FlagResult = True) Then
                    tbmavattu.Text = nextID.ToString()
                Else
                    MessageBox.Show("Lấy ID kế tiếp của vật tư không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If

            Else
                MessageBox.Show("Thêm vật tư không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tbtenvattu_TextChanged(sender As Object, e As EventArgs) Handles tbtenvattu.TextChanged
        If (kiemtra() = True) Then
            btluu.Enabled = True
        Else
            btluu.Enabled = False
        End If
    End Sub

    Private Sub tbdongia_TextChanged(sender As Object, e As EventArgs) Handles tbdongia.TextChanged
        If (kiemtra() = True) Then
            btluu.Enabled = True
        Else
            btluu.Enabled = False
        End If
    End Sub

    Private Sub tbdongia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbdongia.KeyPress
        Dim mK As Integer = Asc(e.KeyChar)
        e.Handled = Not ((mK >= 48 And mK <= 57) Or mK = 8)
    End Sub
End Class