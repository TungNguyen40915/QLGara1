Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility


Public Class xeBus
    Private xDAL As xeDAL
    Public Sub New()
        xDAL = New xeDAL()
    End Sub
    Public Sub New(connectionString As String)
        xDAL = New xeDAL(connectionString)
    End Sub

    Public Function insert(cx As xeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return xDAL.insert(cx)
    End Function


    Public Function select_Bybienso(id As String, ByRef cx As xeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return xDAL.select_Bybiensoxe(id, cx)
    End Function

    Public Function select_Bymachuxe(id As String, ByRef listxe As List(Of xeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return xDAL.select_Bymachuxe(id, listxe)
    End Function

    Public Function select_Bymahieuxe(id As Integer, ByRef listxe As List(Of xeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return xDAL.select_Bymahieuxe(id, listxe)
    End Function

    Public Function selectall(ByRef listxe As List(Of xeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return xDAL.selectALL(listxe)
    End Function

    Public Function update(hs As xeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return xDAL.update(hs)
    End Function
    Public Function delete(bienso As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return xDAL.delete(bienso)
    End Function
End Class
