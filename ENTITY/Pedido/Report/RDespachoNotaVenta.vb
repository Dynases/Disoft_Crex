Public Class RDespachoNotaVenta
    Private _oanumi As Integer
    Public Property oanumi() As Integer
        Get
            Return _oanumi
        End Get
        Set(ByVal value As Integer)
            _oanumi = value
        End Set
    End Property

    Private _oafdoc As Date
    Public Property oafdoc() As Date
        Get
            Return _oafdoc
        End Get
        Set(ByVal value As Date)
            _oafdoc = value
        End Set
    End Property

    Private _ccdesc As String
    Public Property ccdesc() As String
        Get
            Return _ccdesc
        End Get
        Set(ByVal value As String)
            _ccdesc = value
        End Set
    End Property
    Private _ccnomfac As String
    Public Property ccnomfac() As String
        Get
            Return _ccnomfac
        End Get
        Set(ByVal value As String)
            _ccnomfac = value
        End Set
    End Property
    Private _ccdirec As String
    Public Property ccdirec() As String
        Get
            Return _ccdirec
        End Get
        Set(ByVal value As String)
            _ccdirec = value
        End Set
    End Property

    Private _cbnumi As Integer
    Public Property cbnumi() As Integer
        Get
            Return _cbnumi
        End Get
        Set(ByVal value As Integer)
            _cbnumi = value
        End Set
    End Property

    Private _cbdesc As String
    Public Property cbdesc() As String
        Get
            Return _cbdesc
        End Get
        Set(ByVal value As String)
            _cbdesc = value
        End Set
    End Property

    Private _canumi As Integer
    Public Property canumi() As Integer
        Get
            Return _canumi
        End Get
        Set(ByVal value As Integer)
            _canumi = value
        End Set
    End Property

    Private _cadesc As String
    Public Property cadesc() As String
        Get
            Return _cadesc
        End Get
        Set(ByVal value As String)
            _cadesc = value
        End Set
    End Property


    Private _obpcant As Decimal
    Public Property obpcant() As Decimal
        Get
            Return _obpcant
        End Get
        Set(ByVal value As Decimal)
            _obpcant = value
        End Set
    End Property


    Private _obpbase As Decimal
    Public Property obpbase() As Decimal
        Get
            Return _obpbase
        End Get
        Set(ByVal value As Decimal)
            _obpbase = value
        End Set
    End Property

    Private _obptot As Decimal
    Public Property obptot() As Decimal
        Get
            Return _obptot
        End Get
        Set(ByVal value As Decimal)
            _obptot = value
        End Set
    End Property

    Private _obdesc As Decimal
    Public Property obdesc() As Decimal
        Get
            Return _obdesc
        End Get
        Set(ByVal value As Decimal)
            _obdesc = value
        End Set
    End Property

    Private _obtotal As Decimal
    Public Property obtotal() As Decimal
        Get
            Return _obtotal
        End Get
        Set(ByVal value As Decimal)
            _obtotal = value
        End Set
    End Property
    Private _Total As Decimal
    Public Property Total() As Decimal
        Get
            Return _Total
        End Get
        Set(ByVal value As Decimal)
            _Total = value
        End Set
    End Property


    Private _TotalLiteral As String
    Public Property TotalLiteral() As String
        Get
            Return _TotalLiteral
        End Get
        Set(ByVal value As String)
            _TotalLiteral = value
        End Set
    End Property

    Private _oaobs As String
    Public Property oaobs() As String
        Get
            Return _oaobs
        End Get
        Set(ByVal value As String)
            _oaobs = value
        End Set
    End Property

    Private _ccnit As String
    Public Property ccnit() As String
        Get
            Return _ccnit
        End Get
        Set(ByVal value As String)
            _ccnit = value
        End Set
    End Property

    Private _cctelf1 As String
    Public Property cctelf1() As String
        Get
            Return _cctelf1
        End Get
        Set(ByVal value As String)
            _cctelf1 = value
        End Set
    End Property

    Private _cedesc As String
    Public Property cedesc() As String
        Get
            Return _cedesc
        End Get
        Set(ByVal value As String)
            _cedesc = value
        End Set
    End Property
End Class
