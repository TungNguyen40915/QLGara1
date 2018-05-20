Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class hieuxeBus
    Private hxDAL As hieuxeDAL
    Public Sub New()
        hxDAL = New hieuxeDAL()
    End Sub
    Public Sub New(connectionString As String)
        hxDAL = New hieuxeDAL(connectionString)
    End Sub

    Public Function insert(lhs As hieuxeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hxDAL.insert(lhs)
    End Function


    Public Function getNextID(ByRef nextID As Integer) As Result
        Return hxDAL.getNextID(nextID)
    End Function


    Public Function selectAll(ByRef listLoaiHS As List(Of hieuxeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hxDAL.selectALL(listLoaiHS)
    End Function

    Public Function select_ByMahieuxe(id As String, ByRef cx As hieuxeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hxDAL.select_ByMahieuxe(id, cx)
    End Function
End Class
