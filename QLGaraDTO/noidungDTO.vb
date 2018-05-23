Public Class noidungDTO
    Private imand As Integer
    Private strtennoidung As String
    Private itiencong As Integer
    Public Property mand As Integer
        Get
            Return imand
        End Get
        Set(value As Integer)
            imand = value
        End Set
    End Property

    Public Property tennoidung As String
        Get
            Return strtennoidung
        End Get
        Set(value As String)
            strtennoidung = value
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

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, name As String, tc As Integer)
        Me.imand = id
        Me.strtennoidung = name
        Me.itiencong = tc
    End Sub
End Class
