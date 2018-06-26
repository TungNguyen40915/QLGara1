Public Class hieuxeDTO

    Private imahieuxe As Integer
    Private strtenhieuxe As String

    Public Property Mahieuxe As Integer
        Get
            Return imahieuxe
        End Get
        Set(value As Integer)
            imahieuxe = value
        End Set
    End Property

    Public Property Tenhieuxe As String
        Get
            Return strtenhieuxe
        End Get
        Set(value As String)
            strtenhieuxe = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, ten As String)
        Me.imahieuxe = id
        Me.strtenhieuxe = ten
    End Sub
End Class
