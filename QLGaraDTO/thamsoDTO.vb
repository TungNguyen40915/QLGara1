Public Class thamsoDTO
    Private isoxetoida As Integer

    Public Property Soxetoida As Integer
        Get
            Return isoxetoida
        End Get
        Set(value As Integer)
            isoxetoida = value
        End Set
    End Property


    Public Sub New(soxetoida As Integer)
        Me.isoxetoida = soxetoida
    End Sub

    Public Sub New()

    End Sub
End Class
