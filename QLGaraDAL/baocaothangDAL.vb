Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class baocaothangDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(pt As baocaothangDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblBaoCaoThang] ([mabaocao], [thang],[nam],[tongdoanhthu])"
        query &= "VALUES (@mabaocao,@thang,@nam,@tongdoanhthu)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mabaocao", pt.mabaocao)
                    .Parameters.AddWithValue("@thang", pt.thang)
                    .Parameters.AddWithValue("@nam", pt.nam)
                    .Parameters.AddWithValue("@tongdoanhthu", pt.tongdoanhthu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Báo Cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function buildMBC(thang As Integer, nam As Integer, ByRef nextmabaocao As String) As Result
        nextmabaocao = "BC"
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [mabaocao] "
        query &= "FROM [tblBaoCaoThang] "
        query &= " WHERE "
        query &= "     thang = @thang"
        query &= " AND "
        query &= "    nam = @nam"
        query &= "  ORDER BY [mabaocao] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@thang", thang)
                    .Parameters.AddWithValue("@nam", nam)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("mabaocao")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then
                        Dim dtonDB = msOnDB.Substring(0, 6)
                        nextmabaocao = dtonDB
                        Dim sttonDB = msOnDB.Substring(6, 2)
                        Dim cv = Convert.ToDecimal(sttonDB)
                        cv = cv + 1
                        If (cv.ToString().Length = 1) Then
                            nextmabaocao = nextmabaocao + "0" + cv.ToString()
                        Else
                            nextmabaocao = nextmabaocao + cv.ToString()
                        End If
                    Else
                        Dim y = nam.ToString().Substring(2, 2)
                        Dim m = thang.ToString()
                        If (m.Length = 1) Then
                            nextmabaocao = nextmabaocao + y + "0" + m + "01"
                        Else
                            nextmabaocao = nextmabaocao + y + m + "01"
                        End If
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động mã báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function select_Bymabaocao(id As String, ByRef a As Integer) As Result

        Dim query As String = String.Empty
        query &= " SELECT [mabaocao], [thang],[nam],[tongdoanhthu] "
        query &= " FROM [tblBaoCaoThang] "
        query &= " WHERE "
        query &= "     [mabaocao] = @mabaocao"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mabaocao", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        a = 1 'tim thay

                    Else
                        a = 0 '0 tim thay
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

End Class
