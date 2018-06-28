Public Class chitietphieusuachuaDTO
    Private strmachitiet As String
    Private strmaphieu As String
    Private strnoidung As String
    Private imavattu As Integer
    Private isoluong As Integer
    Private idongia As Integer
    Private itiencong As Integer
    Private itong As Integer





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

    Public Property Maphieu As String
        Get
            Return strmaphieu
        End Get
        Set(value As String)
            strmaphieu = value
        End Set
    End Property

    Public Property noidung As String
        Get
            Return strnoidung
        End Get
        Set(value As String)
            strnoidung = value
        End Set
    End Property

    Public Property machitiet As String
        Get
            Return strmachitiet
        End Get
        Set(value As String)
            strmachitiet = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(mct As String, mp As String, mavt As Integer, mand As String, sl As Integer, dg As Integer, tc As Integer, tt As Integer)
        Me.strmachitiet = mct
        Me.Maphieu = mp
        Me.mavattu = mavt
        Me.strnoidung = mand
        Me.soluong = sl
        Me.dongia = dg
        Me.tiencong = tc
        Me.tong = tt
    End Sub
End Class
