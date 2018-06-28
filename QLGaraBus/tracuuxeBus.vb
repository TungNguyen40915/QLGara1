Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class tracuuxeBus
    Private tcDAL As tracuuxeDAL
    Public Sub New()
        tcDAL = New tracuuxeDAL()
    End Sub
    Public Sub New(connectionString As String)
        tcDAL = New tracuuxeDAL(connectionString)
    End Sub

    Public Function selectall(ByRef listxe As List(Of tracuuxeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tcDAL.selectALL(listxe)
    End Function
End Class
