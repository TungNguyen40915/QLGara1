Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility



Public Class phieuthuBus
    Private ptDAL As phieuthuDAL
    Public Sub New()
        ptDAL = New phieuthuDAL()
    End Sub
    Public Sub New(connectionString As String)
        ptDAL = New phieuthuDAL(connectionString)
    End Sub

    Public Function buildMP(dt As DateTime, ByRef nextMapt As String) As Result

        Return ptDAL.buildMP(dt, nextMapt)
    End Function

    Public Function insert(cx As phieuthuDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDAL.insert(cx)
    End Function

    Public Function selectall(ByRef list As List(Of phieuthuDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDAL.selectALL(list)
    End Function
End Class
