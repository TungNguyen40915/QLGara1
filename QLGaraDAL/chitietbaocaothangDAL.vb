
Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class chitietbaocaothangDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function insert(ct As chitietbaocaothangDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChiTietBaoCaoThang] ([mabaocao], [mahieuxe],[soluotsua],[thanhtien],[tyle])"
        query &= "VALUES (@mabaocao,@mahieuxe,@soluotsua,@thanhtien,@tyle)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mabaocao", ct.mabaocao)
                    .Parameters.AddWithValue("@mahieuxe", ct.mahieuxe)
                    .Parameters.AddWithValue("@soluotsua", ct.soluot)
                    .Parameters.AddWithValue("@thanhtien", ct.thanhtien)
                    .Parameters.AddWithValue("@tyle", ct.tyle)
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
