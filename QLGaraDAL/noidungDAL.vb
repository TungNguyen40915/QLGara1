Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility


Public Class noidungDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(nd As noidungDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblNoiDung] ([manoidung], [tennoidung],[tiencong])"
        query &= "VALUES (@mand,@tennd,@tiencong)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mand", nd.mand)
                    .Parameters.AddWithValue("@tennd", nd.tennoidung)
                    .Parameters.AddWithValue("@tiencong", nd.tiencong)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Nội Dung Sửa Chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function select_Bymand(id As String, ByRef x As noidungDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [manoidung], [tennoidung],[tiencong] "
        query &= " FROM [tblNoiDung] "
        query &= " WHERE "
        query &= "     [manoidung] = @manoidung"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manoidung", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        reader.Read()
                        x = New noidungDTO(reader("manoidung"), reader("tennoidung"), reader("tiencong"))
                    Else
                        Return New Result(False)
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Nội dung  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectall(ByRef listnoidung As List(Of noidungDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [manoidung], [tennoidung],[tiencong] "
        query &= " FROM [tblNoiDung] "




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
                        listnoidung.Clear()
                        While reader.Read()
                            listnoidung.Add(New noidungDTO(reader("manoidung"), reader("tennoidung"), reader("tiencong")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Nội dung  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(nd As noidungDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblNoiDung] SET  "
        query &= "   [manoidung] = @mand   "
        query &= " ,  [tennoidung] = @tennoidung   "
        query &= " ,  [tiencong] = @tiencong   "
        query &= "    WHERE  "
        query &= "   [manoidung] = @manoidung   "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mand", nd.mand)
                    .Parameters.AddWithValue("@tennoidung", nd.tennoidung)
                    .Parameters.AddWithValue("@tiencong", nd.tiencong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Nội Dung không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result


        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [manoidung] "
        query &= "FROM [tblNoiDung] "
        query &= "ORDER BY [manoidung] DESC "

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
                    idOnDB = "0"
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("manoidung")
                        End While
                    End If


                    Dim convertDecimal = Convert.ToDecimal(idOnDB)
                    convertDecimal = convertDecimal + 1




                    nextID = convertDecimal
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = "0"
                    Return New Result(False, "Lấy ID kế tiếp của nội dung không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
