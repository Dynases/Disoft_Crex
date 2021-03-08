Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class R01_ReporteMovimientos
#Region "Variables Globales"

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

#End Region

#Region "Eventos"

    Private Sub My_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        P_prCargarReporte()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Me.Close()
        _modulo.Select()
        _tab.Close()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_prInicio()
        'Abrir conexion dsds
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        Me.Text = "REPORTE MOVIMIENTOS PRODUCTOS ".ToUpper
        Me.WindowState = FormWindowState.Maximized
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date

        P_prArmarCombos()

    End Sub
    Private Sub P_prArmarCombos()
        P_prArmarComboProveedor()
        P_prArmarComboCategoria()
        P_prCargarComboLibreria(cbMarca, 102)
        P_prCargarComboLibreria(cbAtributo, 103)
        P_prArmarComboDescripcion(cbDescripcion)


    End Sub
    Private Sub P_prArmarComboProveedor()
        Dim DtP As DataTable
        DtP = L_fnObtenerProveedor()
        DtP.Rows.Add(0, "TODOS")

        g_prArmarCombo(cbProveedor, DtP, 60, 200, "COD", "PROVEEDOR")
        cbProveedor.SelectedIndex = Convert.ToInt32(DtP.Rows.Count - 1)

    End Sub
    Private Sub P_prArmarComboCategoria()
        Dim Dt As DataTable
        Dt = L_fnObtenerCategoria()
        Dt.Rows.Add(0, "TODOS")
        g_prArmarCombo(cbCategoria, Dt, 60, 200, "Código", "Categoría")
        cbCategoria.SelectedIndex = Convert.ToInt32(Dt.Rows.Count - 1)

    End Sub

    Private Sub P_prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, cod1 As String)
        Dim dt As New DataTable
        dt = L_prLibreriaProductoGeneral(cod1)
        dt.Rows.Add(0, "TODOS")
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("cenum").Width = 70
            .DropDownList.Columns("cenum").Caption = "COD"
            .DropDownList.Columns.Add("cedesc").Width = 200
            .DropDownList.Columns("cedesc").Caption = "DESCRIPCION"
            .ValueMember = "cenum"
            .DisplayMember = "cedesc"
            .DataSource = dt
            .Refresh()
        End With
        mCombo.SelectedIndex = Convert.ToInt32(dt.Rows.Count - 1)
    End Sub
    Private Sub P_prArmarComboDescripcion(cbDescripcion As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim Dt As DataTable
        Dt = L_fnObtenerDescripcion()
        Dt.Rows.Add("TODOS")
        With cbDescripcion
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("cadesc2").Width = 200
            .DropDownList.Columns("cadesc2").Caption = "DESCRIPCION"
            .ValueMember = "cadesc2"
            .DisplayMember = "cadesc2"
            .DataSource = Dt
            .Refresh()
        End With
        cbDescripcion.SelectedIndex = Convert.ToInt32(Dt.Rows.Count - 1)
    End Sub

    Public Sub CalcularRanking(ByRef _dt As DataTable)
        Dim total As Double = 0
        For i As Integer = 0 To _dt.Rows.Count - 1 Step 1

            total = total + _dt.Rows(i).Item("Importe")

        Next
        For i As Integer = 0 To _dt.Rows.Count - 1 Step 1
            Dim porcentaje As Double
            porcentaje = ((_dt.Rows(i).Item("Importe") * 100) / total)
            _dt.Rows(i).Item("Ranking") = porcentaje

        Next



    End Sub

    Private Sub P_prCargarReporte()
        Dim _dt As New DataTable
        _prObtenerKardexGeneral(_dt)

        If (_dt.Rows.Count > 0) Then
            Dim objrep As New R_KardexGeneral()
            objrep.SetDataSource(_dt)
            objrep.SetParameterValue("Proveedor", cbProveedor.Text)
            objrep.SetParameterValue("Categoria", cbCategoria.Text)
            objrep.SetParameterValue("Marca", cbMarca.Text)
            objrep.SetParameterValue("Atributo", cbAtributo.Text)
            objrep.SetParameterValue("Descripcion", cbDescripcion.Text)
            objrep.SetParameterValue("FechaDesde", tbFechaI.Value.ToString("dd/MM/yyyy"))
            objrep.SetParameterValue("FechaHasta", tbFechaF.Value.ToString("dd/MM/yyyy"))

            MCrReporte.ReportSource = objrep
        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.TopCenter)
            MCrReporte.ReportSource = Nothing
        End If
    End Sub



#End Region
#Region "Metodos Kardex"
    Public Sub _prObtenerKardexGeneral(ByRef _dt As DataTable)
        Dim dtaux As DataTable = L_fnObtenerKardexGeneralProductos(cbProveedor.Value, cbCategoria.Value, cbMarca.Value, cbAtributo.Value, cbDescripcion.Value, tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), 1) ''Aqui obtengo todos los productos con movimientos


        '' as SaldoAnterior,
        '' as Entradas,'' as Salidas,'' as SaldoFinal
        For i As Integer = 0 To dtaux.Rows.Count - 1 Step 1
            Dim numipro As Integer = dtaux.Rows(i).Item("canumi")
            Dim descprod As String = dtaux.Rows(i).Item("cadesc")
            Dim UnidProd As String = dtaux.Rows(i).Item("Categoria")
            Dim saldoAnt As String = ""
            Dim Entrada As String = ""
            Dim Salida As String = ""
            Dim SaldoFinal As String = ""
            Dim dtkardex As DataTable = P_ArmarGrillaDatosGeneral(numipro, tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), 1, descprod, UnidProd,
                                                                  saldoAnt, Entrada, Salida, SaldoFinal)
            dtaux.Rows(i).Item("SaldoAnterior") = saldoAnt
            dtaux.Rows(i).Item("Entradas") = Entrada
            dtaux.Rows(i).Item("Salidas") = Salida
            dtaux.Rows(i).Item("SaldoFinal") = SaldoFinal
        Next
        _dt = dtaux
    End Sub

    Private Function P_ArmarGrillaDatosGeneral(codprod As Integer, fechaI As String, fechaF As String, almacen As Integer, DescProd As String, UnidPro As String, ByRef SaldoAnt As String,
                                          ByRef Entradas As String, ByRef Salidas As String,
                                          ByRef SaldoFinal As String) As DataTable
        Dim Dt1Kardex = New DataTable
        Dim Dt2KardexTotal = New DataTable

        'Dt2KardexTotal = L_fnObtenerHistorialProductoGeneral(codprod, fechaI, almacen)
        'Dt1Kardex = L_fnObtenerKardexPorProducto(codprod, fechaI, fechaF, almacen)
        Dt2KardexTotal = L_VistaKardexInventarioTodo(Str(codprod), fechaI).Tables(0)
        Dt1Kardex = L_VistaKardexInventario(Str(codprod), fechaI, fechaF).Tables(0)

        If (Dt1Kardex.Rows.Count > 0) Then
            P_ArmarKardexGeneral(Dt1Kardex, Dt2KardexTotal, codprod, DescProd, UnidPro,
                          SaldoAnt, Entradas, Salidas, SaldoFinal)

        End If
        Return Dt1Kardex
    End Function
    Private Sub P_ArmarKardexGeneral(ByRef Dt1Kardex As DataTable, ByRef Dt2KardexTotal As DataTable,
                                 codprod As Integer, Descprod As String, Unidad As String, ByRef SaldoAnt As String,
                                ByRef Entradas As String, ByRef Salidas As String, ByRef SaldoFinal As String)

        Dim saldo As Double = 0
        Dim ingT As Double = 0
        Dim salT As Double = 0

        If (Not IsDBNull(Dt2KardexTotal.Compute("Sum(cant)", "cprod = " + Str(codprod) + " and concep = 1"))) Then
            ingT = Dt2KardexTotal.Compute("Sum(cant)", "cprod = " + Str(codprod) + " and concep = 1")
        End If
        If (Not IsDBNull(Dt2KardexTotal.Compute("Sum(cant)", "cprod = " + Str(codprod) + " and concep = 2"))) Then
            salT = Dt2KardexTotal.Compute("Sum(cant)", "cprod = " + Str(codprod) + " and concep = 2")
        End If
        saldo = ingT + salT
        Dim ing As Double = 0
        Dim sal As Double = 0
        Dim saldoInicial As Double = 0
        'Sumar ingreso de inventario
        ing = IIf(IsDBNull(Dt1Kardex.Compute("Sum(cant)", "cprod = " + Str(codprod) + " and concep = 1")), 0, Dt1Kardex.Compute("Sum(cant)", "cprod = " + Str(codprod) + " and concep = 1"))
        'Sumar salida de inventario
        sal = IIf(IsDBNull(Dt1Kardex.Compute("Sum(cant)", "cprod = " + Str(codprod) + " and concep = 2")), 0, Dt1Kardex.Compute("Sum(cant)", "cprod = " + Str(codprod) + " and concep = 2"))
        SaldoAnt = Str(saldo).Trim
        Entradas = Str(ing).Trim
        Salidas = Str(Math.Abs(sal)).Trim
        SaldoFinal = Str(Math.Abs((ing + saldo) + sal)).Trim

    End Sub

#End Region
End Class