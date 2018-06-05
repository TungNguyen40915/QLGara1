Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility


Public Class baocaovattuDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMBC(thang As Integer, nam As Integer, ByRef nextmabaocao As String) As Result

        nextmabaocao = "BC"
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [mabaocao] "
        query &= "FROM [tblBaoCaoVatTu] "
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

    Public Function insert(pt As baocaovattuDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblBaoCaoVatTu] ([mabaocao], [thang],[nam])"
        query &= "VALUES (@mabaocao,@thang,@nam)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mabaocao", pt.mabaocao)
                    .Parameters.AddWithValue("@thang", pt.thang)
                    .Parameters.AddWithValue("@nam", pt.nam)

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
End Class
