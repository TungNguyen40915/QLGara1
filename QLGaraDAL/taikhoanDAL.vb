Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class taikhoanDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(tk As taikhoanDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTaiKhoan] ([mataikhoan],[taikhoan], [matkhau],[loaitaikhoan],[manhanvien])"
        query &= "VALUES (@mataikhoan,@taikhoan,@matkhau,@loaitaikhoan,@manhanvien)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@taikhoan", tk.taikhoan)
                    .Parameters.AddWithValue("@matkhau", tk.matkhau)
                    .Parameters.AddWithValue("@loaitaikhoan", tk.loaitaikhoan)
                    .Parameters.AddWithValue("@manhanvien", tk.manhanvien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm tài khoản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function select_Bytaikhoan(id As String, ByRef tk As taikhoanDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [taikhoan], [matkhau], [loaitaikhoan], [manhanvien]"
        query &= " FROM [tblTaiKhoan] "
        query &= " WHERE "
        query &= "     [taikhoan] = @taikhoan"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@taikhoan", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        reader.Read()
                        tk = New taikhoanDTO(reader("taikhoan"), reader("matkhau"), reader("loaitaikhoan"), reader("manhanvien"))
                        Return New Result(True)
                    Else
                        Return New Result(False)
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy chủ xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(tk As taikhoanDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblTaiKhoan] SET"
        query &= " [matkhau] = @matkhau "
        query &= " WHERE "
        query &= " [taikhoan] = @taikhoan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@taikhoan", tk.taikhoan)
                    .Parameters.AddWithValue("@matkhau", tk.matkhau)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Chủ Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
