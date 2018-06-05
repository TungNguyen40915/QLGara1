Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class vattuBus
    Private vtDAL As vattuDAL
    Public Sub New()
        vtDAL = New vattuDAL()
    End Sub
    Public Sub New(connectionString As String)
        vtDAL = New vattuDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return vtDAL.getNextID(nextID)
    End Function

    Public Function insert(vt As vattuDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return vtDAL.insert(vt)
    End Function


    Public Function select_Bymavattu(id As String, ByRef vt As vattuDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return vtDAL.select_Bymavt(id, vt)
    End Function

    Public Function selectall(ByRef listvattu As List(Of vattuDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return vtDAL.selectall(listvattu)
    End Function

    Public Function update(vt As vattuDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return vtDAL.update(vt)
    End Function

    Public Function selectvattu_baocao(dt As DateTime, ByRef list As List(Of baocao2DTO)) As Result
        Return vtDAL.selectvattu_baocao(dt, list)
    End Function

End Class
