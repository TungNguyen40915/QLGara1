Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility


Public Class chitietbaocaovattuDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function insert(ct As chitietbaocaovattuDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChiTietBaoCaoVatTu] ([mabaocao], [mavattu],[tondau],[phatsinh],[toncuoi])"
        query &= "VALUES (@mabaocao,@mavattu,@tondau,@phatsinh,@toncuoi)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mabaocao", ct.mabaocao)
                    .Parameters.AddWithValue("@mavattu", ct.mavattu)
                    .Parameters.AddWithValue("@tondau", ct.tondau)
                    .Parameters.AddWithValue("@phatsinh", ct.phatsinh)
                    .Parameters.AddWithValue("@toncuoi", ct.toncuoi)
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
