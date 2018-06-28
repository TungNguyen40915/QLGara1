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
        Return ctDAL.insert(ct)
    End Function

End Class
