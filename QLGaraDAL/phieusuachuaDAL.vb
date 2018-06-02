Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class phieusuachuaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(psc As phieusuachuaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuSuaChua] ([maphieu], [biensoxe],[ngaysuachua],[tongtien])"
        query &= "VALUES (@maphieu,@biensoxe,@ngay,@tong)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieu", psc.maphieu)
                    .Parameters.AddWithValue("@biensoxe", psc.bienso)
                    .Parameters.AddWithValue("@ngay", psc.ngay)
                    .Parameters.AddWithValue("@tong", psc.tongtien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm phiếu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function buildMP(dt As DateTime, ByRef nextID As String) As Result

        nextID = "SC"
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maphieu] "
        query &= "FROM [tblPhieuSuaChua] "
        query &= " WHERE "
        query &= "     day([ngaysuachua])= @ngay "
        query &= " AND "
        query &= "     month([ngaysuachua])= @thang  "
        query &= " AND "
        query &= "     year([ngaysuachua])= @nam  "
        query &= "  ORDER BY [maphieu] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@thang", dt.Month)
                    .Parameters.AddWithValue("@nam", dt.Year)
                    .Parameters.AddWithValue("@ngay", dt.Day)
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
                        nextID = dtonDB
                        Dim sttonDB = msOnDB.Substring(8, 2)
                        Dim cv = Convert.ToDecimal(sttonDB)
                        cv = cv + 1
                        If (cv.ToString().Length = 1) Then
                            nextID = nextID + "0" + cv.ToString()
                        Else
                            nextID = nextID + cv.ToString()
                        End If
                    Else
                        Dim y = dt.Year.ToString().Substring(2, 2)
                        Dim m = dt.Month.ToString()
                        Dim d = dt.Day.ToString()

                        If (m.Length = 1) Then
                            nextID = nextID + y + "0" + m
                        Else
                            nextID = nextID + y + m
                        End If

                        If (d.Length = 1) Then
                            nextID = nextID + "0" + d + "01"
                        Else
                            nextID = nextID + d + "01"
                        End If


                    End If



                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động mã phiếu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong






    End Function


    Public Function selectPhieuSC_BC1(dt As DateTime, tongluot As Integer, ByRef list As List(Of baocao1DTO)) As Result
        Dim query As String = String.Empty


        query &= " select [tblHieuXe].[mahieuxe], [tblHieuXe].[tenhieuxe], count(*) as [tongsoluot],  sum([tblPhieuSuaChua].[tongtien]) as [tonggiatri]"
        query &= " from "
        query &= " 	[tblXe] "
        query &= " 	,[tblHieuXe] "
        query &= " 	,[tblPhieuSuaChua] "
        query &= " where "
        query &= " 	Year([tblPhieuSuaChua].[ngaysuachua]) = @nam "
        query &= " 	And  Month([tblPhieuSuaChua].[ngaysuachua]) = @thang "
        query &= " 	and  [tblHieuXe].[mahieuxe] = [tblXe].[mahieuxe]   "
        query &= " 	and  [tblXe].[bienso]  = [tblPhieuSuaChua].[biensoxe] "
        query &= " 	  Group by [tblHieuXe].[mahieuxe] "
        query &= " ,[tblHieuXe].[tenhieuxe] "



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@thang", dt.Month())
                    .Parameters.AddWithValue("@nam", dt.Year())
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            Dim bc = New baocao1DTO()
                            bc.mahieuxe = reader("mahieuxe")
                            bc.tenhieuxe = reader("tenhieuxe")
                            bc.soluotsua = reader("tongsoluot")
                            bc.thanhtien = reader("tonggiatri")

                            bc.tile = bc.soluotsua / tongluot
                            'list.Add(New baocao1DTO(reader("mahieuxe"), reader("tenhieuxe"), reader("tongsoluot"), reader("tonggiatri"), reader("tongsoluot") / tongluot))
                            list.Add(bc)
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy danh sách phiếu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectPhieuSC_bydate(dt As DateTime, ByRef tongluot As Integer) As Result
        Dim query As String = String.Empty

        query &= " select count(*) as [tongluotsuachua]"
        query &= " from "
        query &= " 	[tblPhieuSuaChua] "
        query &= " where "
        query &= " 	Year([tblPhieuSuaChua].[ngaysuachua]) = @nam "
        query &= " 	And  Month([tblPhieuSuaChua].[ngaysuachua]) = @thang "




        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@thang", dt.Month)
                    .Parameters.AddWithValue("@nam", dt.Year)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            tongluot = reader("tongluotsuachua")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
