Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class phieuthuDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(pt As phieuthuDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuThu] ([maphieu], [biensoxe],[ngaythu],[sotien])"
        query &= "VALUES (@maphieuthu,@biensoxe,@ngaythu,@sotien)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@biensoxe", pt.bienso)
                    .Parameters.AddWithValue("@maphieuthu", pt.maphieu)
                    .Parameters.AddWithValue("@ngaythu", pt.ngaythu)
                    .Parameters.AddWithValue("@sotien", pt.tongtien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Phiếu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function buildMP(dt As DateTime, ByRef nextMP As String) As Result

        nextMP = "PT"
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maphieu] "
        query &= "FROM [tblPhieuThu] "
        query &= " WHERE "
        query &= "     day([ngaythu]) = @ngay"
        query &= " AND "
        query &= "     month([ngaythu]) = @thang"
        query &= " AND "
        query &= "     year([ngaythu]) = @nam"
        query &= "  ORDER BY [maphieu] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ngay", dt.Day)
                    .Parameters.AddWithValue("@thang", dt.Month)
                    .Parameters.AddWithValue("@nam", dt.Year)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("maphieu")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then
                        Dim dtonDB = msOnDB.Substring(0, 8)
                        nextMP = dtonDB
                        Dim sttonDB = msOnDB.Substring(8, 2)
                        Dim cv = Convert.ToDecimal(sttonDB)
                        cv = cv + 1
                        If (cv.ToString().Length = 1) Then
                            nextMP = nextMP + "0" + cv.ToString()
                        Else
                            nextMP = nextMP + cv.ToString()
                        End If
                    Else
                        Dim y = dt.Year.ToString().Substring(2, 2)
                        Dim m = dt.Month.ToString()
                        Dim d = dt.Day().ToString()

                        If (m.Length = 1) Then
                            nextMP = nextMP + y + "0" + m
                        Else
                            nextMP = nextMP + y + m
                        End If


                        If (d.Length = 1) Then
                            nextMP = nextMP + "0" + d + "01"
                        Else
                            nextMP = nextMP + d + "01"
                        End If




                    End If



                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã tiếp nhận kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function selectALL(ByRef list As List(Of phieuthuDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maphieu], [ngaythu],[biensoxe],[sotien]"
        query &= " FROM [tblPhieuThu]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New phieuthuDTO(reader("maphieu"), reader("biensoxe"), reader("ngaythu"), reader("sotien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả chủ xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


End Class
