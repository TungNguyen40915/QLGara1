Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class chitietbaocaovattuBus
    Private bcDAL As chitietbaocaovattuDAL

    Public Sub New()
        bcDAL = New chitietbaocaovattuDAL()
    End Sub
    Public Sub New(connectionString As String)
        bcDAL = New chitietbaocaovattuDAL(connectionString)
    End Sub


    Public Function insert(ct As chitietbaocaovattuDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bcDAL.insert(ct)
    End Function
End Class
