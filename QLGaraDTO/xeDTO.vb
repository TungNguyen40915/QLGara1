Public Class xeDTO
    Private strbienso As String
    Private strmachuxe As String
    Private imahieuxe As Integer

    Public Property Bienso As String
        Get
            Return strbienso
        End Get
        Set(value As String)
            strbienso = value
        End Set
    End Property

    Public Property Machuxe As String
        Get
            Return strmachuxe
        End Get
        Set(value As String)
            strmachuxe = value
        End Set
    End Property

    Public Property Mahieuxe As Integer
        Get
            Return imahieuxe
        End Get
        Set(value As Integer)
            imahieuxe = value
        End Set
    End Property

    Public Sub New(bs As String, macx As String, mahx As Integer)
        Me.strbienso = bs
        Me.strmachuxe = macx
        Me.imahieuxe = mahx
    End Sub

    Public Sub New()

    End Sub
End Class
