Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class tiepnhanxeBus
    Private tnxDAL As tiepnhanxeDAL
    Public Sub New()
        tnxDAL = New tiepnhanxeDAL()
    End Sub
    Public Sub New(connectionString As String)
        tnxDAL = New tiepnhanxeDAL(connectionString)
    End Sub

    Public Function buildMTN(dt As DateTime, ByRef nextMshs As String) As Result

        Return tnxDAL.buildMTN(dt, nextMshs)
    End Function

    Public Function insert(cx As tiepnhanxeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tnxDAL.insert(cx)
    End Function

    Public Function dem(dt As DateTime, ByRef solan As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tnxDAL.dem(dt, solan)
    End Function

    Public Function selectAll(ByRef listphieu As List(Of tiepnhanxeDTO)) As Result

        Return tnxDAL.selectALL(listphieu)
    End Function

    Public Function delete(matn As String) As Result

        Return tnxDAL.delete(matn)
    End Function
End Class
