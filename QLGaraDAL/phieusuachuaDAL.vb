Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class phieusuachuaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(psc As phieusuachuaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuSuaChua] ([maphieu], [biensoxe],[ngaysuachua],[tongtien])"
        query &= "VALUES (@maphieu,@biensoxe,@ngay,@tong)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieu", psc.maphieu)
                    .Parameters.AddWithValue("@biensoxe", psc.bienso)
                    .Parameters.AddWithValue("@ngay", psc.ngay)
                    .Parameters.AddWithValue("@tong", psc.tongtien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm phiếu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function buildMP(dt As DateTime, ByRef nextID As String) As Result

        nextID = "SC"
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maphieu] "
        query &= "FROM [tblPhieuSuaChua] "
        query &= " WHERE "
        query &= "     day([ngaysuachua])= @ngay "
        query &= " AND "
        query &= "     month([ngaysuachua])= @thang  "
        query &= " AND "
        query &= "     year([ngaysuachua])= @nam  "
        query &= "  ORDER BY [maphieu] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@thang", dt.Month)
                    .Parameters.AddWithValue("@nam", dt.Year)
                    .Parameters.AddWithValue("@ngay", dt.Day)
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
                        Dim dtonDB = msOnDB.Substring(0, 8)
                        nextID = dtonDB
                        Dim sttonDB = msOnDB.Substring(8, 2)
                        Dim cv = Convert.ToDecimal(sttonDB)
                        cv = cv + 1
                        If (cv.ToString().Length = 1) Then
                            nextID = nextID + "0" + cv.ToString()
                        Else
                            nextID = nextID + cv.ToString()
                        End If
                    Else
                        Dim y = dt.Year.ToString().Substring(2, 2)
                        Dim m = dt.Month.ToString()
                        Dim d = dt.Day.ToString()

                        If (m.Length = 1) Then
                            nextID = nextID + y + "0" + m
                        Else
                            nextID = nextID + y + m
                        End If

                        If (d.Length = 1) Then
                            nextID = nextID + "0" + d + "01"
                        Else
                            nextID = nextID + d + "01"
                        End If


                    End If



                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động mã phiếu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong






    End Function
End Class
