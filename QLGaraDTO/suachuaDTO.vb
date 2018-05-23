Public Class suachuaDTO
    Private imanoidung As Integer
    Private strtennoidung As String
    Private imavattu As Integer
    Private strtenvattu As String
    Private isoluong As Integer
    Private idongia As Integer
    Private itiencong As Integer
    Private itongtien As Integer

    Public Property manoidung As Integer
        Get
            Return imanoidung
        End Get
        Set(value As Integer)
            imanoidung = value
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

    Public Sub New(mand As Integer, tennd As String, mavt As Integer, tenvt As String, sl As Integer, dg As Integer, tc As Integer, tt As Integer)
        Me.imanoidung = mand
        Me.strtennoidung = tennd
        Me.imavattu = mavt
        Me.strtenvattu = tenvt
        Me.isoluong = sl
        Me.idongia = dg
        Me.itiencong = tc
        Me.itongtien = tt
    End Sub
End Class
