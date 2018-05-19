Public Class tiepnhanxeDTO
    Private strmatiepnhan As String
    Private strbienso As String
    Private dtngaytiepnhan As DateTime

    Public Property Matiepnhan As String
        Get
            Return strmatiepnhan
        End Get
        Set(value As String)
            strmatiepnhan = value
        End Set
    End Property

    Public Property Bienso As String
        Get
            Return strbienso
        End Get
        Set(value As String)
            strbienso = value
        End Set
    End Property



    Public Property Ngaytiepnhan As Date
        Get
            Return dtngaytiepnhan
        End Get
        Set(value As Date)
            dtngaytiepnhan = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ma As String, bs As String, dt As DateTime)
        Me.strmatiepnhan = ma
        Me.strbienso = bs
        Me.dtngaytiepnhan = dt
    End Sub
End Class
