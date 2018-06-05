Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class baocaovattuBus
    Private bcDAL As baocaovattuDAL

    Public Sub New()
        bcDAL = New baocaovattuDAL()
    End Sub
    Public Sub New(connectionString As String)
        bcDAL = New baocaovattuDAL(connectionString)
    End Sub

    Public Function buildMBC(thang As Integer, nam As Integer, ByRef nextmabaocao As String) As Result

        Return bcDAL.buildMBC(thang, nam, nextmabaocao)
    End Function

    Public Function insert(ct As baocaovattuDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bcDAL.insert(ct)
    End Function
End Class
