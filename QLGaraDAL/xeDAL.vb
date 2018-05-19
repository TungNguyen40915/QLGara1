Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class xeDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(hx As xeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblXe] ([bienso], [machuxe],[mahieuxe])"
        query &= "VALUES (@bienso,@machuxe,@mahieuxe)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@bienso", hx.Bienso)
                    .Parameters.AddWithValue("@machuxe", hx.Machuxe)
                    .Parameters.AddWithValue("@mahieuxe", hx.Mahieuxe)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function select_Bybiensoxe(id As String, ByRef x As xeDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [bienso], [machuxe],[mahieuxe] "
        query &= " FROM [tblXe] "
        query &= " WHERE "
        query &= "     [bienso] = @bienso"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@bienso", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        reader.Read()
                        x = New xeDTO(reader("bienso"), reader("machuxe"), reader("mahieuxe"))
                    Else
                        Return New Result(False)
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function select_Bymachuxe(id As String, ByRef listxe As List(Of xeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [bienso], [machuxe], [mahieuxe]"
        query &= " FROM [tblXe] "
        query &= "   WHERE "
        query &= "    [machuxe]=@machuxe"


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
                        listxe.Clear()
                        While reader.Read()
                            listxe.Add(New xeDTO(reader("bienso"), reader("machuxe"), reader("mahieuxe")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function select_Bymahieuxe(id As Integer, ByRef listxe As List(Of xeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [bienso], [machuxe], [mahieuxe]"
        query &= " FROM [tblXe] "
        query &= "   WHERE "
        query &= "    [mahieuxe]=@mahieuxe"


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
                        listxe.Clear()
                        While reader.Read()
                            listxe.Add(New xeDTO(reader("bienso"), reader("machuxe"), reader("mahieuxe")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(hs As xeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblXe] SET  "
        query &= "   [machuxe] = @machuxe   "
        query &= " ,  [mahieuxe] = @mahieuxe   "
        query &= "    WHERE  "
        query &= "   [bienso] = @bienso   "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machuxe", hs.Machuxe)
                    .Parameters.AddWithValue("@mahieuxe", hs.Mahieuxe)
                    .Parameters.AddWithValue("@bienso", hs.Bienso)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function delete(bienso As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblXe] "
        query &= " WHERE "
        query &= " [bienso] = @bienso "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@bienso", bienso)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function

    Public Function selectALL(ByRef listxe As List(Of xeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [bienso], [machuxe], [mahieuxe]"
        query &= " FROM [tblXe] "


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
                        listxe.Clear()
                        While reader.Read()
                            listxe.Add(New xeDTO(reader("bienso"), reader("machuxe"), reader("mahieuxe")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
