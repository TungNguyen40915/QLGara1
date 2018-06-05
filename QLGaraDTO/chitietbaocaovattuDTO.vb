Public Class chitietbaocaovattuDTO
    Private strmabaocao As String
    Private imavattu As Integer
    Private itondau As Integer
    Private itoncuoi As Integer
    Private iphatsinh As Integer



    Public Property mavattu As Integer
        Get
            Return mavattu
        End Get
        Set(value As Integer)
            imavattu = value
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

    Public Property toncuoi As Integer
        Get
            Return itoncuoi
        End Get
        Set(value As Integer)
            itoncuoi = value
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

    Public Property mabaocao As String
        Get
            Return strmabaocao
        End Get
        Set(value As String)
            strmabaocao = value
        End Set
    End Property
End Class
