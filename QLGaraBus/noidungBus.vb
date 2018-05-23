Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class noidungBus
    Private ndDAL As noidungDAL
    Public Sub New()
        ndDAL = New noidungDAL()
    End Sub
    Public Sub New(connectionString As String)
        ndDAL = New noidungDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ndDAL.getNextID(nextID)
    End Function
    Public Function insert(nd As noidungDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ndDAL.insert(nd)
    End Function


    Public Function select_Bymand(id As String, ByRef nd As noidungDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ndDAL.select_Bymand(id, nd)
    End Function

    Public Function selectall(ByRef listnoidung As List(Of noidungDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ndDAL.selectall(listnoidung)
    End Function

    Public Function update(nd As noidungDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ndDAL.update(nd)
    End Function


End Class
