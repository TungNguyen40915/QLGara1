Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class taikhoanBus
    Private tkDAL As taikhoanDAL
    Public Sub New()
        tkDAL = New taikhoanDAL()
    End Sub
    Public Sub New(connectionString As String)
        tkDAL = New taikhoanDAL(connectionString)
    End Sub

    Public Function insert(tk As taikhoanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tkDAL.insert(tk)
    End Function

    Public Function select_Bytaikhoan(id As String, ByRef tk As taikhoanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tkDAL.select_Bytaikhoan(id, tk)
    End Function

    Public Function update(tk As taikhoanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tkDAL.update(tk)
    End Function
End Class
