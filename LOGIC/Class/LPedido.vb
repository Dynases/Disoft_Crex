Imports ENTITY
Imports REPOSITORY
Imports UTILITIES

Public Class LPedido
    Friend iPedido As IPedido

    Public Sub New()
        Me.iPedido = New RPedido()
    End Sub

    Public Function ListarPedidoDistribucion(listIdZona As List(Of Integer)) As List(Of VPedido_Dispatch)
        Try
            Return iPedido.ListarPedidoDistribucion(listIdZona)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarPedidoAsignadoAChofer(idChofer As Integer, estado As Integer) As List(Of VPedido_BillingDispatch)
        Try
            Return iPedido.ListarPedidoAsignadoAChofer(idChofer, estado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function GuardarPedidoDeChofer(listIdPedido As List(Of Integer), idChofer As Integer, usuario As String) As Boolean
        Try
            Return iPedido.GuardarPedidoDeChofer(listIdPedido, idChofer, usuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXClienteDeChofer(idChofer As Integer, estado As Integer) As List(Of RDespachoxCliente)
        Try
            Return iPedido.ListarDespachoXClienteDeChofer(idChofer, estado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXProductoDeChofer(idChofer As Integer, estado As Integer, fechaDesde As DateTime, fechaHasta As DateTime) As List(Of RDespachoXProducto)
        Try
            Return iPedido.ListarDespachoXProductoDeChofer(idChofer, estado, fechaDesde, fechaHasta)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXProductoDeChoferSalida(idChofer As Integer) As List(Of RDespachoXProducto)
        Try
            Return iPedido.ListarDespachoXProductoDeChoferSalida(idChofer)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function VolverPedidoDistribucion(listIdPedido As List(Of Integer), idChofer As Integer) As Boolean
        Try
            Return iPedido.VolverPedidoDistribucion(listIdPedido, idChofer)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXNotaVentaDeChofer(idChofer As Integer, idPedido As Integer) As List(Of RDespachoNotaVenta)
        Try
            Return iPedido.ListarDespachXNotaVentaDeChofer(idChofer, idPedido)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXNotaVenta(idPedido As Integer) As List(Of RDespachoNotaVenta)
        Try
            Return iPedido.ListarDespachXNotaVenta(idPedido)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarPedidoAsignadoAChofer(idChofer As Integer) As List(Of VPedido_BillingDispatch)
        Try
            Return iPedido.ListarPedidoAsignadoAChofer(idChofer)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXClienteDeChofer(idChofer As Integer) As List(Of RDespachoxCliente)
        Try
            Return iPedido.ListarDespachoXClienteDeChofer(idChofer)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarDespachoXProductoDeChofer(idChofer As Integer) As List(Of RDespachoXProducto)
        Try
            Return iPedido.ListarDespachoXProductoDeChofer(idChofer)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ListarDespachoDetalleXChofer(idChofer As Integer, estado As Integer) As List(Of RDespachoDetalleXChofer)
        Try
            Return iPedido.ListarDespachoDetalleXChofer(idChofer, estado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
