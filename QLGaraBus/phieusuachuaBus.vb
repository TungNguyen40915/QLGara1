Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class phieusuachuaBus
    Private pscDAL As phieusuachuaDAL
    Public Sub New()
        pscDAL = New phieusuachuaDAL()
    End Sub
    Public Sub New(connectionString As String)
        pscDAL = New phieusuachuaDAL(connectionString)
    End Sub

    Public Function buildMP(dt As DateTime, ByRef nextID As String) As Result

        Return pscDAL.buildMP(dt, nextID)
    End Function

    Public Function insert(p As phieusuachuaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pscDAL.insert(p)
    End Function

    Public Function selectPhieuSC_BC1(dt As DateTime, tongluot As Integer, ByRef list As List(Of baocao1DTO)) As Result
        Return pscDAL.selectPhieuSC_BC1(dt, tongluot, list)
    End Function

    Public Function selectPhieuSC_bydate(dt As DateTime, ByRef tongluot As Integer) As Result
        Return pscDAL.selectPhieuSC_bydate(dt, tongluot)
    End Function


End Class
