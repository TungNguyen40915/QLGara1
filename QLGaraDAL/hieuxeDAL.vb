Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class hieuxeDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [mahieuxe] "
        query &= "FROM [tblHieuXe] "
        query &= "ORDER BY [mahieuxe] DESC "

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
                            idOnDB = reader("mahieuxe")
                        End While
                    End If

                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(hx As hieuxeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblHieuXe] ([mahieuxe], [tenhieuxe])"
        query &= "VALUES (@mahieuxe,@tenhieuxe)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        hx.Mahieuxe = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mahieuxe", hx.Mahieuxe)
                    .Parameters.AddWithValue("@tenhieuxe", hx.Tenhieuxe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function selectALL(ByRef listhieuxe As List(Of hieuxeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [mahieuxe], [tenhieuxe]"
        query &= " FROM [tblHieuXe]"


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
                        listhieuxe.Clear()
                        While reader.Read()
                            listhieuxe.Add(New hieuxeDTO(reader("mahieuxe"), reader("tenhieuxe")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function select_ByMahieuxe(id As String, ByRef cx As hieuxeDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [mahieuxe], [tenhieuxe] "
        query &= " FROM [tblHieuXe] "
        query &= " WHERE "
        query &= "     [mahieuxe] = @mahieuxe"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mahieuxe", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        reader.Read()
                        cx = New hieuxeDTO(reader("mahieuxe"), reader("tenhieuxe"))
                        Return New Result(True)
                    Else
                        Return New Result(False)
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
