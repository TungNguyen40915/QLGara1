Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class tracuuxeDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(ByRef listxe As List(Of tracuuxeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [tblXe].[bienso],[tblXe].[machuxe],[tblXe].[mahieuxe],[tblHieuXe].[tenhieuxe],[tblChuXe].[tenchuxe],[tblChuXe].[tienno]"
        query &= " FROM  [tblxe], [tblchuxe], [tblhieuxe] "
        query &= " WHERE [tblHieuXe].[mahieuxe]=[tblXe].[mahieuxe] and [tblxe].[machuxe]=[tblChuXe].[machuxe]  "



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
                            listxe.Add(New tracuuxeDTO(reader("bienso"), reader("tenchuxe"), reader("tenhieuxe"), reader("tienno"), reader("mahieuxe"), reader("machuxe")))
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
