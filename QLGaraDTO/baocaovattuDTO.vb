Public Class baocaovattuDTO
    Private strmabaocao As String
    Private ithang As Integer
    Private inam As Integer

    Public Property mabaocao As String
        Get
            Return strmabaocao
        End Get
        Set(value As String)
            strmabaocao = value
        End Set
    End Property

    Public Property thang As Integer
        Get
            Return ithang
        End Get
        Set(value As Integer)
            ithang = value
        End Set
    End Property

    Public Property nam As Integer
        Get
            Return inam
        End Get
        Set(value As Integer)
            inam = value
        End Set
    End Property

    Public Sub New()

    End Sub


End Class
