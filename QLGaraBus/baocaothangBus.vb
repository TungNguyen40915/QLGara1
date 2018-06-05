Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class baocaothangBus
    Private bcDAL As baocaothangDAL
    Public Sub New()
        bcDAL = New baocaothangDAL()
    End Sub
    Public Sub New(connectionString As String)
        bcDAL = New baocaothangDAL(connectionString)
    End Sub

    Public Function buildMBC(thang As Integer, nam As Integer, ByRef nextmabaocao As String) As Result

        Return bcDAL.buildMBC(thang, nam, nextmabaocao)
    End Function

    Public Function insert(bc As baocaothangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bcDAL.insert(bc)
    End Function

    Public Function select_bymabaocao(id As String, ByRef a As Integer)
        Return bcDAL.select_Bymabaocao(id, a)
    End Function
End Class
