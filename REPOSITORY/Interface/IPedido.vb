Imports ENTITY
Imports UTILITIES

Public Interface IPedido
    Function ListarPedidoDistribucion(listIdZona As List(Of Integer)) As List(Of VPedido_Dispatch)
    Function ListarPedidoAsignadoAChofer(idChofer As Integer, estado As Integer) As List(Of VPedido_BillingDispatch)
    Function GuardarPedidoDeChofer(listIdPedido As List(Of Integer), idChofer As Integer, usuario As String) As Boolean
    Function ListarDespachoXClienteDeChofer(idChofer As Integer, estado As Integer) As List(Of RDespachoxCliente)
    Function ListarDespachoXProductoDeChoferSalida(idChofer As Integer) As List(Of RDespachoXProducto)
    Function ListarDespachoXProductoDeChofer(idChofer As Integer, estado As Integer, fechaDesde As DateTime, fechaHasta As DateTime) As List(Of RDespachoXProducto)
    Function VolverPedidoDistribucion(listIdPedido As List(Of Integer), idChofer As Integer) As Boolean
    Function ListarDespachXNotaVentaDeChofer(idChofer As Integer, idPedido As Integer) As List(Of RDespachoNotaVenta)
    Function ListarDespachXNotaVenta(idPedido As Integer) As List(Of RDespachoNotaVenta)
    Function ListarPedidoAsignadoAChofer(idChofer As Integer) As List(Of VPedido_BillingDispatch)
    Function ListarDespachoXClienteDeChofer(idChofer As Integer) As List(Of RDespachoxCliente)
    Function ListarDespachoXProductoDeChofer(idChofer As Integer) As List(Of RDespachoXProducto)
    Function ListarDespachoDetalleXChofer(idChofer As Integer, estado As Integer) As List(Of RDespachoDetalleXChofer)
End Interface
