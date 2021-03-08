Public Class RDespachoxCliente
    Private _oaccbnumi As Integer
    Public Property oaccbnumi() As Integer
        Get
            Return _oaccbnumi
        End Get
        Set(ByVal value As Integer)
            _oaccbnumi = value
        End Set
    End Property

    Private _ccnumi As Integer
    Public Property ccnumi() As Integer
        Get
            Return _ccnumi
        End Get
        Set(ByVal value As Integer)
            _ccnumi = value
        End Set
    End Property

    Private _cccod As String
    Public Property cccod() As String
        Get
            Return _cccod
        End Get
        Set(ByVal value As String)
            _cccod = value
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

    Private _oacnrofact As Long
    Public Property oacnrofact() As Long
        Get
            Return _oacnrofact
        End Get
        Set(ByVal value As Long)
            _oacnrofact = value
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
    Private _IdZona As Integer
    Public Property IdZona() As Integer
        Get
            Return _IdZona
        End Get
        Set(ByVal value As Integer)
            _IdZona = value
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
    Private _oanumi As Integer
    Public Property oanumi() As Integer
        Get
            Return _oanumi
        End Get
        Set(ByVal value As Integer)
            _oanumi = value
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

    Private _tipo As String
    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    Private _contado As Decimal
    Public Property contado() As Decimal
        Get
            Return _contado
        End Get
        Set(ByVal value As Decimal)
            _contado = value
        End Set
    End Property
    Private _credito As Decimal
    Public Property credito() As Decimal
        Get
            Return _credito
        End Get
        Set(ByVal value As Decimal)
            _credito = value
        End Set
    End Property
End Class
