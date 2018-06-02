Public Class baocao2DTO
    Private imavattu As Integer
    Private strtenvattu As String
    Private itondau As Integer
    Private iphatsinh As Integer
    Private itoncuoi As Integer

    Public Property mavattu As Integer
        Get
            Return imavattu
        End Get
        Set(value As Integer)
            imavattu = value
        End Set
    End Property

    Public Property tenvattu As String
        Get
            Return strtenvattu
        End Get
        Set(value As String)
            strtenvattu = value
        End Set
    End Property

    Public Property tondau As Integer
        Get
            Return itondau
        End Get
        Set(value As Integer)
            itondau = value
        End Set
    End Property

    Public Property phatsinh As Integer
        Get
            Return iphatsinh
        End Get
        Set(value As Integer)
            iphatsinh = value
        End Set
    End Property

    Public Property toncuoi As Integer
        Get
            Return itoncuoi
        End Get
        Set(value As Integer)
            itoncuoi = value
        End Set
    End Property
End Class
