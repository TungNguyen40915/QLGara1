Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class chitietbaocaothangBus
    Private bcDAL As chitietbaocaothangDAL

    Public Sub New()
        bcDAL = New chitietbaocaothangDAL()
    End Sub
    Public Sub New(connectionString As String)
        bcDAL = New chitietbaocaothangDAL(connectionString)
    End Sub


    Public Function insert(ct As chitietbaocaothangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bcDAL.insert(ct)
    End Function
End Class
