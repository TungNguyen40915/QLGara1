Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class chuxeBus
    Private cxDAL As chuxeDAL
    Public Sub New()
        cxDAL = New chuxeDAL()
    End Sub
    Public Sub New(connectionString As String)
        cxDAL = New chuxeDAL(connectionString)
    End Sub

    Public Function insert(cx As chuxeDTO) As Result

        Return cxDAL.insert(cx)
    End Function


    Public Function getNextID(ByRef nextID As String) As Result
        Return cxDAL.getNextID(nextID)
    End Function


    Public Function selectAll(ByRef listchuxe As List(Of chuxeDTO)) As Result

        Return cxDAL.selectALL(listchuxe)
    End Function

    Public Function select_ByMachuxe(id As String, ByRef cx As chuxeDTO) As Result

        Return cxDAL.select_ByMachuxe(id, cx)
    End Function

    Public Function update(cx As chuxeDTO) As Result

        Return cxDAL.update(cx)
    End Function

    Public Function CheckAndStandardizationName(ByRef cx As chuxeDTO) As Boolean
        If (cx.Tenchuxe.Length = 0) Then
            Return False
        End If

        For Each item In cx.Tenchuxe

            Dim a As Integer
            Integer.TryParse(item, a)
            If (a <> 0) Then
                Return False
            End If

        Next


        cx.Tenchuxe = cx.Tenchuxe.Trim()

        While (cx.Tenchuxe.IndexOf("  ")) > -1
            cx.Tenchuxe = cx.Tenchuxe.Replace("  ", " ")
        End While

        Dim mang() As String = Split(cx.Tenchuxe.ToString, " ")
        Dim t As String
        For i As Integer = 0 To UBound(mang)
            t = t & UCase(mang(i).Substring(0, 1)) & LCase(mang(i).Substring(1, mang(i).Length - 1)) & " "

        Next

        cx.Tenchuxe = t

        Return True


    End Function

    Public Function isvalidAddress(cx As chuxeDTO) As Boolean
        If (cx.Diachi.Length < 1) Then
            Return False
        End If
        Return True
    End Function


    Public Function isvalidNumberPhone(cx As chuxeDTO) As Boolean
        If (cx.Dienthoai.ToString().Length < 10) Then
            Return False
        End If

        Dim sdt As String
        sdt = cx.Dienthoai.ToString()

        For Each item In sdt

            Dim a As Integer
            Integer.TryParse(item, a)
            If (a = 0) Then
                Return False
            End If

        Next


        Return True
    End Function
End Class
