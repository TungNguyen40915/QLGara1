Public Class chuxeDTO
    Private strmachuxe As String
    Private strtenchuxe As String
    Private strdiachi As String
    Private idienthoai As Integer
    Private itienno As Integer

    Public Property Machuxe As String
        Get
            Return strmachuxe
        End Get
        Set(value As String)
            strmachuxe = value
        End Set
    End Property

    Public Property Tenchuxe As String
        Get
            Return strtenchuxe
        End Get
        Set(value As String)
            strtenchuxe = value
        End Set
    End Property

    Public Property Diachi As String
        Get
            Return strdiachi
        End Get
        Set(value As String)
            strdiachi = value
        End Set
    End Property

    Public Property Dienthoai As Integer
        Get
            Return idienthoai
        End Get
        Set(value As Integer)
            idienthoai = value
        End Set
    End Property

    Public Property Tienno As Integer
        Get
            Return itienno
        End Get
        Set(value As Integer)
            itienno = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id As String, ten As String, diachi As String, dienthoai As Integer, no As Integer)
        Me.strmachuxe = id
        Me.strtenchuxe = ten
        Me.idienthoai = dienthoai
        Me.strdiachi = diachi
        Me.itienno = no
    End Sub
End Class
