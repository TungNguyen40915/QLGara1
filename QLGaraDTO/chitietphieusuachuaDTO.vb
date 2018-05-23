Public Class chitietphieusuachuaDTO
    Private strmaphieu As String
    Private imanoidung As Integer
    Private imavattu As Integer
    Private isoluong As Integer
    Private idongia As Integer
    Private itiencong As Integer
    Private itong As Integer

    Public Property maphieu As String
        Get
            Return strmaphieu
        End Get
        Set(value As String)
            strmaphieu = value
        End Set
    End Property

    Public Property manoidung As Integer
        Get
            Return imanoidung
        End Get
        Set(value As Integer)
            imanoidung = value
        End Set
    End Property

    Public Property mavattu As Integer
        Get
            Return imavattu
        End Get
        Set(value As Integer)
            imavattu = value
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

    Public Property dongia As Integer
        Get
            Return idongia
        End Get
        Set(value As Integer)
            idongia = value
        End Set
    End Property

    Public Property tiencong As Integer
        Get
            Return itiencong
        End Get
        Set(value As Integer)
            itiencong = value
        End Set
    End Property

    Public Property tong As Integer
        Get
            Return itong
        End Get
        Set(value As Integer)
            itong = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(mp As String, mavt As Integer, mand As Integer, sl As Integer, dg As Integer, tc As Integer, tt As Integer)
        Me.maphieu = mp
        Me.mavattu = mavt
        Me.manoidung = mand
        Me.soluong = sl
        Me.dongia = dg
        Me.tiencong = tc
        Me.tong = tt
    End Sub
End Class
