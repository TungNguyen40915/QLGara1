﻿Imports System.Configuration
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

#Region "hoi thay"
        'Dim a As DateTime
        'a = Convert.ToDateTime(dt)

        'Dim query As String = String.Empty
        'query &= "SELECT TOP 1 [matiepnhan] "
        'query &= "FROM [tblTiepNhan] "
        'query &= " WHERE "
        'query &= "     [ngaytiepnhan] = @ngaytiepnhan"
        'query &= "  ORDER BY [matiepnhan] DESC "

        'Using conn As New SqlConnection(connectionString)
        '    Using comm As New SqlCommand()
        '        With comm
        '            .Connection = conn
        '            .CommandType = CommandType.Text
        '            .CommandText = query
        '            .Parameters.AddWithValue("@ngaytiepnhan", a)
        '        End With
        '        Try
        '            conn.Open()
        '            Dim reader As SqlDataReader
        '            reader = comm.ExecuteReader()
        '            Dim msOnDB As String
        '            msOnDB = Nothing
        '            If reader.HasRows = True Then
        '                While reader.Read()
        '                    msOnDB = reader("matiepnhan")
        '                End While
        '            End If
        '            If (msOnDB <> Nothing) Then
        '                Dim dtonDB = msOnDB.Substring(0, 6)
        '                nextMP = dtonDB
        '                Dim sttonDB = msOnDB.Substring(6, 2)
        '                Dim cv = Convert.ToDecimal(sttonDB)
        '                cv = cv + 1
        '                If (cv.ToString().Length = 1) Then
        '                    nextMP = nextMP + "0" + cv.ToString()
        '                Else
        '                    nextMP = nextMP + cv.ToString()
        '                End If
        '            Else
        '                Dim y = dt.Year.ToString().Substring(2, 2)
        '                Dim m = dt.Month.ToString()
        '                Dim d = dt.Day().ToString()

        '                If (m.Length = 1) Then
        '                    nextMP = y + "0" + m
        '                Else
        '                    nextMP = y + m
        '                End If


        '                If (d.Length = 1) Then
        '                    nextMP = nextMP + "0" + d
        '                Else
        '                    nextMP = nextMP + d
        '                End If

        '                nextMP = nextMP + "01"


        '            End If



        '        Catch ex As Exception
        '            conn.Close() ' that bai!!!
        '            System.Console.WriteLine(ex.StackTrace)
        '            Return New Result(False, "Lấy tự động Mã tiếp nhận kế tiếp không thành công", ex.StackTrace)
        '        End Try
        '    End Using
        'End Using
        'Return New Result(True) ' thanh cong
#End Region


        nextMP = "PT"
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maphieu] "
        query &= "FROM [tblPhieuThu] "
        query &= "ORDER BY [maphieu] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("maphieu")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then
                        Dim v = msOnDB.Substring(2, 6)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextMP = nextMP + tmp
                        System.Console.WriteLine(nextMP)
                    Else
                        nextMP = nextMP + "000001"
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động mã phiếu kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


End Class
