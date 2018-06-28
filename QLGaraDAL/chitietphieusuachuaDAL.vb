Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility


Public Class chitietphieusuachuaDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(ct As chitietphieusuachuaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblCTPSC] ([machitiet],[maphieu], [mavattu],[noidung],[soluong],[dongia],[tiencong],[thanhtien])"
        query &= "VALUES (@machitiet,@maphieu,@mavattu,@noidung,@soluong,@dongia,@tiencong,@thanhtien)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitiet", ct.machitiet)
                    .Parameters.AddWithValue("@maphieu", ct.Maphieu)
                    .Parameters.AddWithValue("@mavattu", ct.mavattu)
                    .Parameters.AddWithValue("@noidung", ct.noidung)
                    .Parameters.AddWithValue("@soluong", ct.soluong)
                    .Parameters.AddWithValue("@dongia", ct.dongia)
                    .Parameters.AddWithValue("@tiencong", ct.tiencong)
                    .Parameters.AddWithValue("@thanhtien", ct.tong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm chi tiết không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
