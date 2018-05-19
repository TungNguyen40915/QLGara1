Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class chuxeDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function getNextID(ByRef nextID As String) As Result

        nextID = "CX"
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [machuxe] "
        query &= "FROM [tblChuXe] "
        query &= "ORDER BY [machuxe] DESC "

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
                    Dim idOnDB As String
                    idOnDB = "CX000000"
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("machuxe")
                        End While
                    End If

                    Dim v = idOnDB.Substring(2)
                    Dim convertDecimal = Convert.ToDecimal(v)
                    convertDecimal = convertDecimal + 1
                    Dim tmp = convertDecimal.ToString()
                    tmp = tmp.PadLeft(idOnDB.Length - 2, "0")



                    nextID = nextID + tmp
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = "0"
                    Return New Result(False, "Lấy ID kế tiếp của chủ xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(hx As chuxeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChuXe] ([machuxe], [tenchuxe],[diachi],[dienthoai],[tienno])"
        query &= "VALUES (@machuxe,@tenchuxe,@diachi,@dienthoai,@tienno)"

        Dim nextID = "CX"
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        hx.Machuxe = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machuxe", hx.Machuxe)
                    .Parameters.AddWithValue("@tenchuxe", hx.Tenchuxe)
                    .Parameters.AddWithValue("@diachi", hx.Diachi)
                    .Parameters.AddWithValue("@dienthoai", hx.Dienthoai)
                    .Parameters.AddWithValue("@tienno", hx.Tienno)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm chủ xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function selectALL(ByRef listchuxe As List(Of chuxeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [machuxe], [tenchuxe],[diachi],[dienthoai],[tienno]"
        query &= " FROM [tblChuXe]"


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
                        listchuxe.Clear()
                        While reader.Read()
                            listchuxe.Add(New chuxeDTO(reader("machuxe"), reader("tenchuxe"), reader("diachi"), reader("dienthoai"), reader("tienno")))
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

    Public Function select_ByMachuxe(id As String, ByRef cx As chuxeDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [machuxe], [tenchuxe], [diachi], [dienthoai], [tienno] "
        query &= " FROM [tblChuXe] "
        query &= " WHERE "
        query &= "     [machuxe] = @machuxe"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machuxe", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        reader.Read()
                        cx = New chuxeDTO(reader("machuxe"), reader("tenchuxe"), reader("diachi"), reader("dienthoai"), reader("tienno"))
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

    Public Function update(cx As chuxeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tbChuXe] SET"
        query &= " [machuxe] = @machuxe "
        query &= " ,[tenchuxe] = @tenchuxe "
        query &= " ,[diachi] = @diachi "
        query &= " ,[dienthoai] = @dienthoai "
        query &= " ,[tienno] = @tienno "
        query &= " WHERE "
        query &= " [machuxe] = @machuxe "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machuxe", cx.Machuxe)
                    .Parameters.AddWithValue("@tenchuxe", cx.Tenchuxe)
                    .Parameters.AddWithValue("@diachi", cx.Diachi)
                    .Parameters.AddWithValue("@dienthoai", cx.Dienthoai)
                    .Parameters.AddWithValue("@tienno", cx.Tienno)
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
