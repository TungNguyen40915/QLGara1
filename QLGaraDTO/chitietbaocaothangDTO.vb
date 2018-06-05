

Public Class chitietbaocaothangDTO
    Private strmabaocao As String
    Private imahieuxe As Integer
    Private isoluot As Integer
    Private ithanhtien As Integer
    Private style As Single

    Public Property mabaocao As String
        Get
            Return strmabaocao
        End Get
        Set(value As String)
            strmabaocao = value
        End Set
    End Property

    Public Property mahieuxe As Integer
        Get
            Return imahieuxe
        End Get
        Set(value As Integer)
            imahieuxe = value
        End Set
    End Property

    Public Property soluot As Integer
        Get
            Return isoluot
        End Get
        Set(value As Integer)
            isoluot = value
        End Set
    End Property

    Public Property thanhtien As Integer
        Get
            Return ithanhtien
        End Get
        Set(value As Integer)
            ithanhtien = value
        End Set
    End Property

    Public Property tyle As Single
        Get
            Return style
        End Get
        Set(value As Single)
            style = value
        End Set
    End Property
End Class
