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
End Class
