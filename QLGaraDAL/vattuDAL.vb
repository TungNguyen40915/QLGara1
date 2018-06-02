﻿Imports System.Configuration
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


    Public Function selectvattu_baocao(list As List(Of baocao2DTO)) As Result
        Dim query As String = String.Empty
        query &= " select [phatsinh].[mavattu], [phatsinh].[tenvattu],[phatsinh].[tongsoluong],[phatsinh].[soluong],[tondau].[toncuoi] "
        query &= " from "
        query &= " ( "
        query &= " select [suachua].[mavattu],[suachua].[tenvattu],[suachua].[tongsoluong],[nhapvao].[soluong] "
        query &= " from  "
        query &= " 	( "
        query &= " 	select [tblVatTu].[mavattu],[tblVatTu].[tenvattu], [info].[tongsoluong] "
        query &= " from  "
        query &= " 	[tblVatTu] "
        query &= " left join  "
        query &= " 	( "
        query &= " 	select [mavattu],sum([soluong]) as [tongsoluong] "
        query &= " from  "
        query &= " 	[tblCTPSC] "
        query &= " 	,[tblPhieuSuaChua] "
        query &= " where "
        query &= " 	[tblCTPSC].[maphieu]=[tblPhieuSuaChua].[maphieu] "
        query &= " 	 and month([ngaysuachua])= @thang "
        query &= " 	and year([ngaysuachua])=@nam "
        query &= "  group by "
        query &= " [mavattu] "
        query &= "   ) as [info] "
        query &= "  on [tblVatTu].[mavattu] = [info].[mavattu]"
        query &= " ) as [suachua] "
        query &= " left join  "
        query &= " 	( "
        query &= " 	select [tblVatTu].[mavattu],[tblVatTu].[tenvattu] ,[a].[soluong]  "
        query &= " from  "
        query &= " 	[tblVatTu] "
        query &= " left join  "
        query &= " 	( "
        query &= " 	select [mavattu],sum([soluong]) as [soluong]  "
        query &= " from  "
        query &= " 	[tblNhapVatTu] "
        query &= " 	,[tblChiTietNhapVatTu] "
        query &= " where "
        query &= " 	[tblNhapVatTu].[maphieunhap]=[tblChiTietNhapVatTu].[maphieunhap] "
        query &= " 	and month(tblNhapVatTu.ngaynhap)=@thang "
        query &= " 	and year(tblNhapVatTu.ngaynhap)=@nam "
        query &= "  group by "
        query &= " [mavattu] "
        query &= " ) as [a] "
        query &= " on [tblVatTu].[mavattu]=[a].[mavattu]  "
        query &= "  ) as [nhapvao] "











        query &= " 	and  [tblChiTietBaoCaoVatTu].[mavattu] = [tblVatTu].[mavattu]   "
        query &= " ) as [info] "
        query &= " left join  "
        query &= " ( "
        query &= " 	select * "
        query &= " 	from [tbldiem] "
        query &= " 	where  "
        query &= " 	[tbldiem].[mahocsinh] =  N'16000001' "
        query &= " ) as [filterdiem] "
        query &= " on [info].[mahinhthucdanhgia]=  [filterdiem].[mahinhthucdanhgia] "


        query &= ""


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@malop", maLop)
                    .Parameters.AddWithValue("@mamonhoc", maMonHoc)
                    .Parameters.AddWithValue("@mahocsinh", maHocSinh)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDiemView.Clear()
                        While reader.Read()
                            Dim diemview = New DiemViewDTO()
                            diemview.MSHS = reader("mahocsinh")
                            diemview.MaMonHoc = reader("mamonhoc")
                            diemview.MonHoc = reader("tenmonhoc")
                            diemview.MaHTDG = reader("mahinhthucdanhgia")
                            diemview.TenLoaiDiem = reader("tenloaidiem")
                            diemview.MaLoaiDiem = reader("maloaidiem")
                            diemview.HeSoDiem = reader("hesodiem")
                            If (reader("diemso") Is DBNull.Value) Then
                                diemview.Diem = -1
                            Else
                                diemview.Diem = reader("diemso")
                            End If
                            listDiemView.Add(diemview)
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy danh sách điểm của môn học của học sinh đang theo học không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
