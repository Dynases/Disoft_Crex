Public Class RDespachoDetalleXChofer
    Private _oanumi As Integer
    Public Property oanumi() As Integer
        Get
            Return _oanumi
        End Get
        Set(ByVal value As Integer)
            _oanumi = value
        End Set
    End Property

    Private _oafdoc As DateTime
    Public Property oafdoc() As DateTime
        Get
            Return _oafdoc
        End Get
        Set(ByVal value As DateTime)
            _oafdoc = value
        End Set
    End Property
    Private _oaccli As Integer
    Public Property oaccli() As Integer
        Get
            Return _oaccli
        End Get
        Set(ByVal value As Integer)
            _oaccli = value
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
    Private _oarepa As Integer
    Public Property oarepa() As Integer
        Get
            Return _oarepa
        End Get
        Set(ByVal value As Integer)
            _oarepa = value
        End Set
    End Property
    Private _oaest As Integer
    Public Property oaest() As Integer
        Get
            Return _oaest
        End Get
        Set(ByVal value As Integer)
            _oaest = value
        End Set
    End Property
    Private _oaap As Integer
    Public Property oaap() As String
        Get
            Return _oaap
        End Get
        Set(ByVal value As String)
            _oaap = value
        End Set
    End Property

    Private _obcprod As Integer
    Public Property obcprod() As Integer
        Get
            Return _obcprod
        End Get
        Set(ByVal value As Integer)
            _obcprod = value
        End Set
    End Property

    Private _cacod As String
    Public Property cacod() As String
        Get
            Return _cacod
        End Get
        Set(ByVal value As String)
            _cacod = value
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
    Private _cauventa As Integer
    Public Property cauventa() As Integer
        Get
            Return _cauventa
        End Get
        Set(ByVal value As Integer)
            _cauventa = value
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
    Private _obpcant As Decimal
    Public Property obpcant() As Decimal
        Get
            Return _obpcant
        End Get
        Set(ByVal value As Decimal)
            _obpcant = value
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


    Private _oaccbnumi As Integer
    Public Property oaccbnumi() As Integer
        Get
            Return _oaccbnumi
        End Get
        Set(ByVal value As Integer)
            _oaccbnumi = value
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
End Class
