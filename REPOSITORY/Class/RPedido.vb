Imports DATA
Imports ENTITY
Imports REPOSITORY
Imports UTILITIES


Public Class RPedido
    Inherits RBaseTSM
    Implements IPedido

    Public Function ListarPedidoDistribucion(listIdZona As List(Of Integer)) As List(Of VPedido_Dispatch) Implements IPedido.ListarPedidoDistribucion
        Try
            Using db = GetSchema()
                Dim listResult = (From a In db.TO001
                                  Join a1 In db.TO001A On a.oanumi Equals a1.oaato1numi
                                  Join b In db.TC004 On a.oaccli Equals b.ccnumi
                                  Join c In db.TC002 On a1.oaanumiprev Equals c.cbnumi
                                  Where a.oaest = ENEstadoPedido.DICTADO And a.oaap = 1 And
                                      listIdZona.Contains(a.oazona) And
                                      Not db.TO001C.Select(Function(aa) aa.oacoanumi).ToList().Contains(a.oanumi)
                                  Select New VPedido_Dispatch With {
                                      .Id = a.oanumi,
                                      .Fecha = a.oafdoc,
                                      .NombreCliente = b.ccdesc,
                                      .NombreVendedor = c.cbdesc,
                                      .idZona = a.oazona
                                      }).ToList()
                Return listResult
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarPedidoAsignadoAChofer(idChofer As Integer, estado As Integer) As List(Of VPedido_BillingDispatch) Implements IPedido.ListarPedidoAsignadoAChofer
        Try
            Using db = GetSchema()
                Dim listResult = (From a In db.TO001
                                  Join a1 In db.TO001A On a.oanumi Equals a1.oaato1numi
                                  Join b In db.TC004 On a.oaccli Equals b.ccnumi
                                  Join c In db.TC002 On a1.oaanumiprev Equals c.cbnumi
                                  Join d In db.TO001C On a.oanumi Equals d.oacoanumi
                                  Where a.oaest = estado And d.oaccbnumi = idChofer And a.oaap = 1
                                  Select New VPedido_BillingDispatch With {
                                      .Id = a.oanumi,
                                      .Fecha = a.oafdoc,
                                      .NombreCliente = b.ccdesc,
                                      .NombreVendedor = c.cbdesc,
                                      .NroFactura = d.oacnrofac,
                                      .idZona = a.oazona,
                                      .observacion = a.oaobs
                                      }).ToList()
                Return listResult
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function GuardarPedidoDeChofer(listIdPedido As List(Of Integer), idChofer As Integer, usuario As String) As Boolean Implements IPedido.GuardarPedidoDeChofer
        Try
            Using db = GetSchema()
                For Each id As String In listIdPedido
                    Dim data = New TO001C With
                    {
                        .oacoanumi = id,
                        .oaccbnumi = idChofer,
                        .oacnconc = 0,
                        .oacfdoc = DateTime.Now
                    }
                    db.TO001C.Add(data)

                    Dim data2 = New TO001D With
                    {
                        .oadoanumi = id,
                        .oadestado = 4,
                        .oaddescrip = "Distribución",
                        .oadcampo1 = 0,
                        .oadcampo2 = 0,
                        .oadcampo3 = " ",
                        .oadfecha = Date.Now,
                        .oadhora = DateTime.Now.ToString("hh:mm"),
                        .oadusuario = usuario
                    }
                    db.TO001D.Add(data2)
                Next

                db.SaveChanges()
                Return True
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXClienteDeChofer(idChofer As Integer, estado As Integer) As List(Of RDespachoxCliente) Implements IPedido.ListarDespachoXClienteDeChofer
        Try
            Using db = GetSchema()
                Dim listResult = (From a In db.VR_GO_DespachoXCliente
                                  Where a.oaccbnumi = idChofer And a.oaest = estado And a.oaap = 1
                                  Select New RDespachoxCliente With {
                                      .oaccbnumi = a.oaccbnumi,
                                      .ccnumi = a.ccnumi,
                                      .cccod = a.cccod,
                                      .ccdesc = a.ccdesc,
                                      .oacnrofact = a.oacnrofact,
                                      .obtotal = a.obtotal,
                                      .IdZona = a.IdZona,
                                      .oafdoc = a.oafdoc,
                                      .oanumi = a.oanumi,
                                      .oaobs = a.oaobs,
                                      .tipo = a.tipo,
                                      .contado = a.contado,
                                      .credito = a.credito
                                      }).ToList()
                Return listResult

            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXProductoDeChofer(idChofer As Integer, estado As Integer, fechaDesde As DateTime, fechaHasta As DateTime) As List(Of RDespachoXProducto) Implements IPedido.ListarDespachoXProductoDeChofer
        Try
            Using db = GetSchema()
                Dim listResult = (From a In db.VR_GO_DespachoXProducto
                                  Where a.oaccbnumi = idChofer And a.oaest = estado And a.oaap = 1 And a.oafdoc >= fechaDesde And a.oafdoc <= fechaHasta
                                  Select New RDespachoXProducto With {
                                   .canumi = a.canumi,
                                   .cacod = a.cacod,
                                   .cadesc = a.cadesc,
                                   .categoria = a.categoria,
                                   .obpcant = a.obpcant,
                                   .Caja = a.caja,
                                   .Unidad = a.Unidad,
                                   .Total = a.Total
                                   }).ToList()
                ' Group a By a.canumi, a.cadesc, a.categoria Into grupo = Group
                'Select New RDespachoXProducto With {
                '  .canumi = grupo.FirstOrDefault().canumi,
                '  .cadesc = grupo.FirstOrDefault().cadesc,
                '  .categoria = grupo.FirstOrDefault().categoria,
                '  .obpcant = grupo.Sum(Function(item) item.obpcant).Value,
                '  .Caja = grupo.Sum(Function(item) item.caja).Value,
                '  .Unidad = grupo.Sum(Function(item) item.Unidad).Value,
                '  .Total = grupo.Sum(Function(item) item.Total).Value
                '}).ToList()

                'Dim listResult = (From a In db.VR_GO_DespachoXProducto
                '                  Where a.oaccbnumi = idChofer And a.oaest = estado And a.oaap = 1 And a.oafdoc >= fechaDesde And a.oafdoc <= fechaHasta
                '                  Select New RDespachoXProducto With {
                '    .oaccbnumi = a.oaccbnumi,
                '    .canumi = a.canumi,
                '    .cacod = a.cacod,
                '    .cadesc = a.cadesc,
                '    .cadesc2 = a.cadesc2,
                '    .categoria = a.categoria,
                '    .obpcant = a.obpcant,
                '    .oafdoc = a.oafdoc,
                '    .Caja = a.caja,
                '    .Unidad = a.Unidad,
                '    .Total = a.Total
                '    }).ToList()
                Return listResult
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXProductoDeChoferSalida(idChofer As Integer) As List(Of RDespachoXProducto) Implements IPedido.ListarDespachoXProductoDeChoferSalida
        Try
            Using db = GetSchema()
                Dim listResult = (From a In db.VR_GO_DespachoXProducto
                                  Where a.oaccbnumi = idChofer And a.oacnconc = 0 And a.oaap = 1 And a.oaest = ENEstadoPedido.DICTADO
                                  Select New RDespachoXProducto With {
                                      .oaccbnumi = a.oaccbnumi,
                                      .canumi = a.canumi,
                                      .cacod = a.cacod,
                                      .cadesc = a.cadesc,
                                      .cadesc2 = a.cadesc2,
                                      .categoria = a.categoria,
                                      .obpcant = a.obpcant,
                                      .oafdoc = a.oafdoc
                                      }).ToList()
                Return listResult
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function VolverPedidoDistribucion(listIdPedido As List(Of Integer), idChofer As Integer) As Boolean Implements IPedido.VolverPedidoDistribucion
        Try
            Using db = GetSchema()
                For Each id As String In listIdPedido
                    Dim data = (From a In db.TO001C
                                Where a.oaccbnumi = idChofer And a.oacoanumi = id
                                Select a)
                    db.TO001C.RemoveRange(data)
                Next

                For Each id2 As String In listIdPedido
                    Dim data2 = (From a In db.TO001D
                                 Where a.oadoanumi = id2 And a.oadestado = 4
                                 Select a)
                    db.TO001D.RemoveRange(data2)
                Next

                db.SaveChanges()

                Return True
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachXNotaVentaDeChofer(idChofer As Integer, idPedido As Integer) As List(Of RDespachoNotaVenta) Implements IPedido.ListarDespachXNotaVentaDeChofer
        Try
            Using db = GetSchema()
                Dim listResult = (From a In db.VR_GO_DespachoNotaVenta
                                  Where (a.oaest = ENEstadoPedido.DICTADO Or a.oaest = ENEstadoPedido.ENTREGADO) And a.oaccbnumi = idChofer And a.oanumi = idPedido
                                  Select New RDespachoNotaVenta With {
                                      .oanumi = a.oanumi,
                                      .oafdoc = a.oafdoc,
                                      .ccdesc = a.ccdesc,
                                      .cbdesc = a.cbdesc,
                                      .ccnomfac = a.ccnomfac,
                                      .ccdirec = a.ccdirec,
                                      .canumi = a.canumi,
                                      .cadesc = a.cadesc,
                                      .obpcant = a.obpcant,
                                      .obpbase = a.obpbase,
                                      .obptot = a.obptot,
                                      .obdesc = a.obdesc,
                                      .obtotal = a.obtotal,
                                      .Total = a.Total,
                                      .oaobs = a.oaobs,
                                      .ccnit = a.ccnit,
                                      .cctelf1 = a.cctelf1,
                                      .cedesc = a.cedesc
                                      }).ToList()
                Return listResult
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachXNotaVenta(idPedido As Integer) As List(Of RDespachoNotaVenta) Implements IPedido.ListarDespachXNotaVenta
        Try
            Using db = GetSchema()
                Dim listResult = (From a In db.VR_GO_DespachoNotaVenta
                                  Where a.oanumi = idPedido And (a.oaest = ENEstadoPedido.DICTADO Or a.oaest = ENEstadoPedido.ENTREGADO)
                                  Select New RDespachoNotaVenta With {
                                      .oanumi = a.oanumi,
                                      .oafdoc = a.oafdoc,
                                      .ccdesc = a.ccdesc,
                                      .cbdesc = a.cbdesc,
                                      .canumi = a.canumi,
                                      .cadesc = a.cadesc,
                                      .obpcant = a.obpcant,
                                      .obpbase = a.obpbase,
                                      .obtotal = a.obtotal,
                                      .Total = a.Total,
                                      .oaobs = a.oaobs,
                                      .ccnit = a.ccnit,
                                      .cctelf1 = a.cctelf1
                                      }).ToList()
                Return listResult
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarPedidoAsignadoAChofer(idChofer As Integer) As List(Of VPedido_BillingDispatch) Implements IPedido.ListarPedidoAsignadoAChofer
        Try
            Using db = GetSchema()
                Dim listResult = (From a In db.TO001
                                  Join a1 In db.TO001A On a.oanumi Equals a1.oaato1numi
                                  Join b In db.TC004 On a.oaccli Equals b.ccnumi
                                  Join c In db.TC002 On a1.oaanumiprev Equals c.cbnumi
                                  Join d In db.TO001C On a.oanumi Equals d.oacoanumi
                                  Where a.oaest <> ENEstadoPedido.PENDIENTE And d.oaccbnumi = idChofer
                                  Select New VPedido_BillingDispatch With {
                                      .Id = a.oanumi,
                                      .Fecha = a.oafdoc,
                                      .NombreCliente = b.ccdesc,
                                      .NombreVendedor = c.cbdesc,
                                      .NroFactura = d.oacnrofac,
                                      .idZona = a.oazona
                                      }).ToList()
                Return listResult
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXClienteDeChofer(idChofer As Integer) As List(Of RDespachoxCliente) Implements IPedido.ListarDespachoXClienteDeChofer
        Try
            Using db = GetSchema()
                Dim listResult = (From a In db.VR_GO_DespachoXCliente
                                  Where a.oaccbnumi = idChofer And a.oaest <> ENEstadoPedido.PENDIENTE
                                  Select New RDespachoxCliente With {
                                      .oaccbnumi = a.oaccbnumi,
                                      .ccnumi = a.ccnumi,
                                      .cccod = a.cccod,
                                      .ccdesc = a.ccdesc,
                                      .oacnrofact = a.oacnrofact,
                                      .obtotal = a.obtotal,
                                      .IdZona = a.IdZona,
                                      .oafdoc = a.oafdoc,
                                      .oanumi = a.oanumi
                                      }).ToList()
                Return listResult

            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXProductoDeChofer(idChofer As Integer) As List(Of RDespachoXProducto) Implements IPedido.ListarDespachoXProductoDeChofer
        Try
            Using db = GetSchema()
                Dim listResult = (From a In db.VR_GO_DespachoXProducto
                                  Where a.oaccbnumi = idChofer And a.oaest <> ENEstadoPedido.PENDIENTE
                                  Select New RDespachoXProducto With {
                                      .oaccbnumi = a.oaccbnumi,
                                      .canumi = a.canumi,
                                      .cacod = a.cacod,
                                      .cadesc = a.cadesc,
                                      .cadesc2 = a.cadesc2,
                                      .categoria = a.categoria,
                                      .obpcant = a.obpcant,
                                      .oafdoc = a.oafdoc
                                      }).ToList()
                Return listResult
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoDetalleXChofer(idChofer As Integer, estado As Integer) As List(Of RDespachoDetalleXChofer) Implements IPedido.ListarDespachoDetalleXChofer
        Try
            Using db = GetSchema()
                Dim listResult = (From a In db.v_VentasDetalleDespacho
                                  Where a.oaccbnumi = idChofer And a.oaest = estado And a.oaap = 1
                                  Select New RDespachoDetalleXChofer With {
                                      .oanumi = a.oanumi,
                                      .oafdoc = a.oafdoc,
                                      .oaccli = a.oaccli,
                                      .ccdesc = a.ccdesc,
                                      .oarepa = a.oarepa,
                                      .oaest = a.oaest,
                                      .oaap = a.oaap,
                                      .obcprod = a.obcprod,
                                      .cacod = a.cacod,
                                      .cadesc = a.cadesc,
                                      .cauventa = a.cauventa,
                                      .obpbase = a.obpbase,
                                      .obpcant = a.obpcant,
                                      .obptot = a.obptot,
                                      .obdesc = a.obdesc,
                                      .obtotal = a.obtotal,
                                      .oaccbnumi = a.oaccbnumi,
                                      .cbdesc = a.cbdesc
                                      }).ToList()
                Return listResult

            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
