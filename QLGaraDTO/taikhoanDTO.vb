Public Class taikhoanDTO

    Private strtaikhoan As String
    Private strmatkhau As String
    Private iloaitaikhoan As Int32
    Private strmanhanvien As String

    Public Property taikhoan As String
        Get
            Return strtaikhoan
        End Get
        Set(value As String)
            strtaikhoan = value
        End Set
    End Property

    Public Property matkhau As String
        Get
            Return strmatkhau
        End Get
        Set(value As String)
            strmatkhau = value
        End Set
    End Property

    Public Property loaitaikhoan As Integer
        Get
            Return iloaitaikhoan
        End Get
        Set(value As Integer)
            iloaitaikhoan = value
        End Set
    End Property

    Public Property manhanvien As String
        Get
            Return strmanhanvien
        End Get
        Set(value As String)
            strmanhanvien = value
        End Set
    End Property



    Public Sub New()

    End Sub

    Public Sub New(tk As String, mk As String, ltk As Integer, manv As String)
        Me.iloaitaikhoan = ltk
        Me.strmanhanvien = manv
        Me.strmatkhau = mk
        Me.strtaikhoan = tk
    End Sub
End Class
