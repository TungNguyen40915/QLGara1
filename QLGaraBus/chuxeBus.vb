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
        '1. verify data here!!

        '2. insert to DB
        Return cxDAL.insert(cx)
    End Function


    Public Function getNextID(ByRef nextID As String) As Result
        Return cxDAL.getNextID(nextID)
    End Function


    Public Function selectAll(ByRef listchuxe As List(Of chuxeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return cxDAL.selectALL(listchuxe)
    End Function

    Public Function select_ByMachuxe(id As String, ByRef cx As chuxeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return cxDAL.select_ByMachuxe(id, cx)
    End Function

    Public Function update(cx As chuxeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return cxDAL.update(cx)
    End Function
End Class
