Public Class baocao1DTO
    Private imahieuxe As Integer
    Private strtenhieuxe As String
    Private isoluotsua As Integer
    Private ithanhtien As Integer
    Private itile As Single

    Public Property mahieuxe As Integer
        Get
            Return imahieuxe
        End Get
        Set(value As Integer)
            imahieuxe = value
        End Set
    End Property

    Public Property tenhieuxe As String
        Get
            Return strtenhieuxe
        End Get
        Set(value As String)
            strtenhieuxe = value
        End Set
    End Property

    Public Property soluotsua As Integer
        Get
            Return isoluotsua
        End Get
        Set(value As Integer)
            isoluotsua = value
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

    Public Property tile As Single
        Get
            Return itile
        End Get
        Set(value As Single)
            itile = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(mahx As Integer, tenhieuxe As Integer, sls As Integer, tt As Integer, tl As Integer)
        Me.imahieuxe = mahx
        Me.strtenhieuxe = tenhieuxe
        Me.isoluotsua = sls
        Me.ithanhtien = tt
        Me.itile = tl
    End Sub
End Class
