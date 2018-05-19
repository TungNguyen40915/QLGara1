Public Class tracuuxeDTO
    Private strbiensoxe As String
    Private strtenchuxe As String
    Private strtenhieuxe As String
    Private itienno As Integer
    Private imahieuxe As Integer
    Private strmachuxe As String

    Public Sub New()

    End Sub

    Public Sub New(bs As String, chuxe As String, hieuxe As String, tn As Integer, mahx As Integer, macx As String)
        Me.strbiensoxe = bs
        Me.strtenchuxe = chuxe
        Me.strtenhieuxe = hieuxe
        Me.itienno = tn
        Me.strmachuxe = macx
        Me.imahieuxe = mahx
    End Sub

    Public Property biensoxe As String
        Get
            Return strbiensoxe
        End Get
        Set(value As String)
            strbiensoxe = value
        End Set
    End Property

    Public Property tenchuxe As String
        Get
            Return strtenchuxe
        End Get
        Set(value As String)
            strtenchuxe = value
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

    Public Property tienno As Integer
        Get
            Return itienno
        End Get
        Set(value As Integer)
            itienno = value
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

    Public Property machuxe As String
        Get
            Return strmachuxe
        End Get
        Set(value As String)
            strmachuxe = value
        End Set
    End Property
End Class
