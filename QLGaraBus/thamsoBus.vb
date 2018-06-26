Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class thamsoBus
    Private tsDAL As thamsoDAL
    Public Sub New()
        tsDAL = New thamsoDAL()
    End Sub
    Public Sub New(connectionString As String)
        tsDAL = New thamsoDAL(connectionString)
    End Sub

    Public Function update(ts As thamsoDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tsDAL.update(ts)
    End Function

    Public Function selectall(ByRef thamso As thamsoDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tsDAL.selectall(thamso)
    End Function
End Class
