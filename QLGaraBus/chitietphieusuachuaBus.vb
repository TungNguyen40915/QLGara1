Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility
Public Class chitietphieusuachuaBus
    Private ctDAL As chitietphieusuachuaDAL
    Public Sub New()
        ctDAL = New chitietphieusuachuaDAL()
    End Sub
    Public Sub New(connectionString As String)
        ctDAL = New chitietphieusuachuaDAL(connectionString)
    End Sub

    Public Function insert(ct As chitietphieusuachuaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctDAL.insert(ct)
    End Function
End Class
