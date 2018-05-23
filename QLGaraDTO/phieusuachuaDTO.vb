Public Class phieusuachuaDTO
    Private strmaphieu As String
    Private strbienso As String
    Private dtngay As DateTime
    Private itongtien As Integer

    Public Property maphieu As String
        Get
            Return strmaphieu
        End Get
        Set(value As String)
            strmaphieu = value
        End Set
    End Property

    Public Property bienso As String
        Get
            Return strbienso
        End Get
        Set(value As String)
            strbienso = value
        End Set
    End Property

    Public Property ngay As Date
        Get
            Return dtngay
        End Get
        Set(value As Date)
            dtngay = value
        End Set
    End Property

    Public Property tongtien As Integer
        Get
            Return itongtien
        End Get
        Set(value As Integer)
            itongtien = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(mp As String, bs As String, ngay As DateTime, tt As Integer)
        Me.strmaphieu = mp
        Me.strbienso = bs
        Me.dtngay = ngay
        Me.itongtien = tt
    End Sub


End Class
