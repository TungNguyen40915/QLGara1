Public Class phieuthuDTO
    Private strmaphieu As String
    Private strbienso As String
    Private dtngaythu As DateTime
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

    Public Property ngaythu As Date
        Get
            Return dtngaythu
        End Get
        Set(value As Date)
            dtngaythu = value
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

    Public Sub New(maphieu As String, bienso As String, ngaythu As DateTime, tongtien As Integer)
        Me.strmaphieu = maphieu
        Me.strbienso = bienso
        Me.dtngaythu = ngaythu
        Me.itongtien = tongtien
    End Sub
End Class
