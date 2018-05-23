﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility


Public Class chitietphieusuachuaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(ct As chitietphieusuachuaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblCTPSC] ([maphieu], [mavattu],[manoidung],[soluong],[dongia],[tiencong],[thanhtien])"
        query &= "VALUES (@maphieu,@mavattu,@manoidung,@soluong,@dongia,@tiencong,@thanhtien)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieu", ct.maphieu)
                    .Parameters.AddWithValue("@mavattu", ct.mavattu)
                    .Parameters.AddWithValue("@manoidung", ct.manoidung)
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
