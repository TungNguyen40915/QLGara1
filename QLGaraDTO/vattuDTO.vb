Public Class vattuDTO
    Private imavattu As Integer
    Private strtenvattu As String
    Private idongia As Integer
    Private isoluong As Integer

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

    Public Property dongia As Integer
        Get
            Return idongia
        End Get
        Set(value As Integer)
            idongia = value
        End Set
    End Property

    Public Property soluong As Integer
        Get
            Return isoluong
        End Get
        Set(value As Integer)
            isoluong = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, ten As String, dongia As Integer, sl As Integer)
        Me.imavattu = id
        Me.strtenvattu = ten
        Me.isoluong = sl
        Me.idongia = dongia
    End Sub
End Class
