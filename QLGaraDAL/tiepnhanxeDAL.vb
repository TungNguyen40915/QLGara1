Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class tiepnhanxeDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function buildMTN(dt As DateTime, ByRef nextMTN As String) As Result



        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [matiepnhan] "
        query &= "FROM [tblTiepNhan] "
        query &= " WHERE "
        query &= "     day([ngaytiepnhan]) = @ngay"
        query &= " AND "
        query &= "     month([ngaytiepnhan]) = @thang"
        query &= " AND "
        query &= "     year([ngaytiepnhan]) = @nam"
        query &= "  ORDER BY [matiepnhan] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ngay", dt.Day)
                    .Parameters.AddWithValue("@thang", dt.Month)
                    .Parameters.AddWithValue("@nam", dt.Year)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("matiepnhan")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then
                        Dim dtonDB = msOnDB.Substring(0, 6)
                        nextMTN = dtonDB
                        Dim sttonDB = msOnDB.Substring(6, 2)
                        Dim cv = Convert.ToDecimal(sttonDB)
                        cv = cv + 1
                        If (cv.ToString().Length = 1) Then
                            nextMTN = nextMTN + "0" + cv.ToString()
                        Else
                            nextMTN = nextMTN + cv.ToString()
                        End If
                    Else
                        Dim y = dt.Year.ToString().Substring(2, 2)
                        Dim m = dt.Month.ToString()
                        Dim d = dt.Day().ToString()

                        If (m.Length = 1) Then
                            nextMTN = y + "0" + m
                        Else
                            nextMTN = y + m
                        End If


                        If (d.Length = 1) Then
                            nextMTN = nextMTN + "0" + d
                        Else
                            nextMTN = nextMTN + d
                        End If

                        nextMTN = nextMTN + "01"


                    End If



                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã tiếp nhận kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong




    End Function


    Public Function insert(tn As tiepnhanxeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTiepNhan] ([matiepnhan], [bienso],[ngaytiepnhan])"
        query &= "VALUES (@matn,@bs,@ntn)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matn", tn.Matiepnhan)
                    .Parameters.AddWithValue("@bs", tn.Bienso)
                    .Parameters.AddWithValue("@ntn", tn.Ngaytiepnhan)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Tiếp Nhận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function dem(ngay As DateTime, ByRef solan As Integer) As Result
        Dim query As String = String.Empty


        solan = 0
        query &= "SELECT COUNT ([matiepnhan])  AS [dem] "
        query &= "  FROM [tblTiepNhan] "
        query &= "  WHERE DAY([ngaytiepnhan])=@day "
        query &= "  AND MONTH([ngaytiepnhan])=@month "
        query &= "  AND YEAR([ngaytiepnhan])=@year "




        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@day", ngay.Day)
                    .Parameters.AddWithValue("@month", ngay.Month)
                    .Parameters.AddWithValue("@year", ngay.Year)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim a = 0
                    If reader.HasRows = True Then
                        While reader.Read()
                            a = reader("dem")
                        End While
                    End If

                    solan = a

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
