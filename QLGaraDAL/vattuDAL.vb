Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class vattuDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(vt As vattuDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblVatTu] ([mavattu], [tenvattu],[dongia],[tonkho])"
        query &= "VALUES (@mavattu,@tenvattu,@dongia,@tonkho)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mavattu", vt.mavattu)
                    .Parameters.AddWithValue("@tenvattu", vt.tenvattu)
                    .Parameters.AddWithValue("@dongia", vt.dongia)
                    .Parameters.AddWithValue("@tonkho", vt.soluong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Vật tư không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function select_Bymavt(id As String, ByRef x As vattuDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [mavattu], [tenvattu],[dongia],[tonkho] "
        query &= " FROM [tblVatTu] "
        query &= " WHERE "
        query &= "     [mavattu] = @mavattu"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mavattu", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        reader.Read()
                        x = New vattuDTO(reader("mavattu"), reader("tenvattu"), reader("dongia"), reader("tonkho"))
                    Else
                        Return New Result(False)
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Vật Tư  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectall(ByRef listvattu As List(Of vattuDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [mavattu], [tenvattu],[dongia],[tonkho] "
        query &= " FROM [tblVatTu] "




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
                        listvattu.Clear()
                        While reader.Read()
                            listvattu.Add(New vattuDTO(reader("mavattu"), reader("tenvattu"), reader("dongia"), reader("tonkho")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Vật Tư  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(vt As vattuDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblVatTu] SET  "
        query &= "   [mavattu] = @mavattu   "
        query &= " ,  [tenvattu] = @tenvattu   "
        query &= " ,  [dongia] = @dongia   "
        query &= " ,  [luongton] = @luongton   "
        query &= "    WHERE  "
        query &= "   [mavattu] = @mavattu   "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mavattu", vt.mavattu)
                    .Parameters.AddWithValue("@tenvattu", vt.tenvattu)
                    .Parameters.AddWithValue("@dongia", vt.dongia)
                    .Parameters.AddWithValue("@luongton", vt.soluong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Vật Tư không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [mavattu] "
        query &= "FROM [tblVatTu] "
        query &= "ORDER BY [mavattu] DESC "

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
                    Dim idOnDB As Integer
                    idOnDB = 0
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("mavattu")
                        End While
                    End If

                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Vật Tư không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function selectvattu_baocao(dt As DateTime, list As List(Of baocao2DTO)) As Result



        Dim query As String = String.Empty
        query &= " select [phatsinh].[mavattu], [phatsinh].[tenvattu],  [phatsinh].[tongsoluong],  [phatsinh].[soluong],   [tondau].[toncuoi] "
        query &= " from "
        query &= " ( "
        query &= " select [suachua].[mavattu],  [suachua].[tenvattu],   [suachua].[tongsoluong],   [nhapvao].[soluong] "
        query &= " from  "
        query &= " 	( "
        query &= " 	select [tblVatTu].[mavattu],   [tblVatTu].[tenvattu],   [info].[tongsoluong] "
        query &= " from  "
        query &= " 	[tblVatTu] "
        query &= " left join  "
        query &= " 	( "
        query &= " 	select [mavattu],   sum([soluong]) as [tongsoluong] "
        query &= " from  "
        query &= " 	[tblCTPSC] "
        query &= " 	,[tblPhieuSuaChua] "
        query &= " where "
        query &= " 	[tblCTPSC].[maphieu] = [tblPhieuSuaChua].[maphieu] "
        query &= " 	 and month ([ngaysuachua]) = @thang "
        query &= " 	and year ([ngaysuachua]) = @nam "
        query &= "  group by "
        query &= " [mavattu] "
        query &= "   ) as [info] "
        query &= "  on [tblVatTu].[mavattu] = [info].[mavattu]"
        query &= " ) as [suachua] "
        query &= " left join  "
        query &= " 	( "
        query &= " 	select [tblVatTu].[mavattu], [tblVatTu].[tenvattu] ,  [a].[soluong]  "
        query &= " from  "
        query &= " 	[tblVatTu] "
        query &= " left join  "
        query &= " 	( "
        query &= " 	select [mavattu],   sum([soluong]) as [soluong]  "
        query &= " from  "
        query &= " 	[tblNhapVatTu] "
        query &= " 	,  [tblChiTietNhapVatTu] "
        query &= " where "
        query &= " 	[tblNhapVatTu].[maphieunhap] = [tblChiTietNhapVatTu].[maphieunhap] "
        query &= " 	and month ([tblNhapVatTu].[ngaynhap]) = @thang "
        query &= " 	and year ([tblNhapVatTu].[ngaynhap]) = @nam "
        query &= "  group by "
        query &= " [mavattu] "
        query &= " ) as [a] "
        query &= " on [tblVatTu].[mavattu] = [a].[mavattu]  "
        query &= "  ) as [nhapvao] "
        query &= " on [suachua].[mavattu] = [nhapvao].[mavattu]  "
        query &= "  ) as [phatsinh] "
        query &= " left join  "
        query &= " 	( "
        query &= " 	select [tblVatTu].[mavattu], [tblVatTu].[tenvattu], [toncuoi]  "
        query &= " from  "
        query &= " 	[tblVatTu] "
        query &= " left join  "
        query &= " 	( "
        query &= " 	select [mavattu], [toncuoi] "
        query &= " from  "
        query &= " 	[tblChiTietBaoCaoVatTu] "
        query &= " where "
        query &= "  [tblChiTietBaoCaoVatTu].[mabaocao] =  "
        query &= " 	( "
        query &= " 	select TOP 1 [mabaocao]  "
        query &= " from  "
        query &= " 	[tblBaoCaoVatTu] "
        query &= " where "
        query &= " 	[thang] =  @thang1  "
        query &= " 	and [nam] = @nam "
        query &= " order by [mabaocao] DESC   "
        query &= " 	) "
        query &= "  ) as [d]"
        query &= "on  [tblVatTu].[mavattu] = [d].[mavattu]"
        query &= ") as [tondau]  "
        query &= "  on [phatsinh].[mavattu] = [tondau].[mavattu] "



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@thang", dt.Month)
                    If (dt.Month <> 1) Then
                        .Parameters.AddWithValue("@thang1", dt.Month - 1)
                        .Parameters.AddWithValue("@nam", dt.Year)
                    Else
                        .Parameters.AddWithValue("@thang1", 12)
                        .Parameters.AddWithValue("@nam", dt.Year - 1)
                    End If


                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            Dim baocao2 = New baocao2DTO()
                            baocao2.mavattu = reader("mavattu")
                            baocao2.tenvattu = reader("tenvattu")




                            If (reader("toncuoi") Is DBNull.Value) Then
                                baocao2.tondau = 0
                            Else
                                baocao2.tondau = reader("toncuoi")
                            End If
                            Dim suachua = 0
                            Dim nhapmoi = 0

                            If (reader("soluong") Is DBNull.Value) Then
                                nhapmoi = 0
                            Else
                                nhapmoi = reader("soluong")
                            End If

                            If (reader("tongsoluong") Is DBNull.Value) Then
                                suachua = 0
                            Else
                                suachua = reader("tongsoluong")
                            End If

                            baocao2.phatsinh = nhapmoi - suachua
                            baocao2.toncuoi = baocao2.tondau + baocao2.phatsinh
                            list.Add(baocao2)
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
