Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class R01_EstadoCuentasClientesTodos

#Region "VARIABLES GLOBALES"
    Public _nameButton As String
    Public _tab As SuperTabItem
    Dim titulo As String = ""
    Public _modulo As SideNavItem
    Dim Dt1Estado As DataTable
    Dim Dt2EstadoTotal As DataTable
    Dim _dt As New DataTable

#End Region
#Region "METODOS PRIVADOS"
    Public Sub _prIniciarTodo()
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If
        Me.WindowState = FormWindowState.Maximized
        Me.Text = "REPORTE ESTADO DE CUENTAS DE TODOS LOS CLIENTES"
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
    End Sub

    Public Sub _IniciarComponentes()

    End Sub

    Private Sub _prCargarReporte()

        Try
            Dim _dt As New DataTable
            _prInterpretarDatos(_dt)

            If (_dt.Rows.Count > 0) Then

                Dim objrep As New R_EstadoCuentasClientesTodos
                objrep.SetDataSource(_dt)
                objrep.SetParameterValue("usuario", L_Usuario)

                MCrReporte.ReportSource = objrep
                MCrReporte.Show()
                MCrReporte.BringToFront()
            Else
                ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
                MCrReporte.ReportSource = Nothing
            End If

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try

    End Sub
    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               4000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)

    End Sub
    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)
        If (swCliente.Value = True) Then
            _dt = L_prListarEstadoCuentasClienteTodos()
        Else
            If (tbCodigoCliente.Text.Length > 0) Then
                _dt = L_prListarEstadoCuentasUnCliente(tbCodigoCliente.Text)
            End If
        End If
    End Sub


#End Region

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        If swCliente.Value = True Then
            _prCargarReporte()
        Else
            If tbCliente.Text = String.Empty Then
                ToastNotification.Show(Me, "Debe Seleccionar un Cliente..!!!".ToUpper,
                                           My.Resources.INFORMATION, 2000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.TopCenter)
            Else
                _prCargarReporte()
            End If
        End If

    End Sub

    Private Sub R01_VentasAtendidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Close()
        _modulo.Select()
    End Sub

    Private Sub btBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btBuscarCliente.Click
        P_prArmarAyudaCliente()
    End Sub
    Private Sub P_prArmarAyudaCliente()

        Dim dt As DataTable
        dt = L_prListarCliente()

        Dim listEstCeldas As New List(Of Modelo.MCelda)
        listEstCeldas.Add(New Modelo.MCelda("ccnumi", True, "ID", 50))
        listEstCeldas.Add(New Modelo.MCelda("cccod", True, "CODIGO", 70))
        listEstCeldas.Add(New Modelo.MCelda("ccdesc", True, "NOMBRE", 280))
        listEstCeldas.Add(New Modelo.MCelda("cctelf2", True, "TELEFONO", 220))
        listEstCeldas.Add(New Modelo.MCelda("ccobs", True, "DIRECCION".ToUpper, 200))
        Dim ef = New Efecto
        ef.tipo = 3
        ef.dt = dt
        ef.SeleclCol = 1
        ef.listEstCeldas = listEstCeldas
        ef.alto = 50
        ef.ancho = 250
        ef.Context = "Seleccione Cliente".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
            If (IsNothing(Row)) Then
                btBuscarCliente.Focus()
                Return
            End If
            tbCodigoCliente.Text = Row.Cells("ccnumi").Value
            tbCliente.Text = Row.Cells("ccdesc").Value
            'MBtGenerar.Select()
        End If


    End Sub

    Private Sub swCliente_ValueChanged(sender As Object, e As EventArgs) Handles swCliente.ValueChanged
        If (swCliente.Value = True) Then
            lbcliente.Visible = False
            tbCodigoCliente.Visible = False
            tbCliente.Visible = False
            btBuscarCliente.Visible = False
        Else
            lbcliente.Visible = True
            tbCliente.Visible = True
            btBuscarCliente.Visible = True
        End If
    End Sub
End Class