Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Imports Janus.Windows.GridEX
Imports System.IO
Public Class F01_ReporteVentaAdmin
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim RutaTemporal As String = "C:\Temporal"
    Private Sub P_prInicio()
        'Abrir conexion dsds
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        Me.WindowState = FormWindowState.Maximized
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
        P_prArmarComboClientes()
        P_prArmarComboVendedores()
        P_prArmarComboRepartidor()
        P_prArmarComboProducto()

    End Sub
    Private Sub P_prArmarComboProducto()
        Dim DtP As DataTable
        DtP = L_fnObtenerProductos()
        DtP.Rows.Add(0, "TODOS")

        g_prArmarCombo(cbProducto, DtP, 60, 200, "COD", "PRODUCTOS")
        cbProducto.SelectedIndex = Convert.ToInt32(DtP.Rows.Count - 1)

    End Sub
    Private Sub P_prArmarComboProveedor()
        Dim DtP As DataTable
        DtP = L_fnObtenerProveedor()
        DtP.Rows.Add(0, "TODOS")

        g_prArmarCombo(cbProveedor, DtP, 60, 200, "COD", "PROVEEDOR")
        cbProveedor.SelectedIndex = Convert.ToInt32(DtP.Rows.Count - 1)

    End Sub

    Private Sub P_prArmarComboClientes()
        Dim DtP As DataTable
        DtP = L_fnObtenerClientes()
        DtP.Rows.Add(0, "TODOS")

        g_prArmarCombo(cbClientes, DtP, 60, 200, "COD", "CLIENTES")
        cbClientes.SelectedIndex = Convert.ToInt32(DtP.Rows.Count - 1)

    End Sub
    Private Sub P_prArmarComboRepartidor()
        Dim DtP As DataTable
        DtP = L_fnObtenerPersonal(3)
        DtP.Rows.Add(0, "TODOS")

        g_prArmarCombo(cbRepartidor, DtP, 60, 200, "COD", "REPARTIDORES")
        cbRepartidor.SelectedIndex = Convert.ToInt32(DtP.Rows.Count - 1)

    End Sub
    Private Sub P_prArmarComboVendedores()
        Dim DtP As DataTable
        DtP = L_fnObtenerPersonal(1)
        DtP.Rows.Add(0, "TODOS")

        g_prArmarCombo(cbVendedor, DtP, 60, 200, "COD", "VENDEDORES")
        cbVendedor.SelectedIndex = Convert.ToInt32(DtP.Rows.Count - 1)

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
    Private Sub F01_ReporteVentaFact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ventas Facturadas"
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
        P_prInicio()

    End Sub
    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               5000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)

    End Sub
    Public Sub ConstruirTabla(ByRef _dt As DataTable)
        Try
            Dim table As DataTable = _dt.Copy
            table.Rows.Clear()
            Dim ventaGeneral, ventaProveedor, ventaCategoria, ventaMarca, ventaAtributo, ventaProducto As DataTable

            Dim idProveedor, idCategoria, idMarca, idAtributo, idProducto, idCliente, idRepartidor,idVendedor As Integer

            idProveedor = IIf(cbProveedor.Value = 0, 0, cbProveedor.Value)
            idCategoria = IIf(cbCategoria.Value = 0, 0, cbCategoria.Value)
            idMarca = IIf(cbMarca.Value = 0, 0, cbMarca.Value)
            idAtributo = IIf(cbAtributo.Value = 0, 0, cbAtributo.Value)
            idProducto = IIf(cbProducto.Value = 0, 0, cbProducto.Value)
            idCliente = IIf(cbClientes.Value = 0, 0, cbClientes.Value)
            idRepartidor = IIf(cbRepartidor.Value = 0, 0, cbRepartidor.Value)
            idVendedor = IIf(cbVendedor.Value = 0, 0, cbVendedor.Value)
            Dim fechaDesde As DateTime = tbFechaI.Value.ToString("yyyy/MM/dd")
            Dim fechaHasta As DateTime = tbFechaF.Value.ToString("yyyy/MM/dd")
            Dim tipoFila As Integer = 0


            ventaGeneral = L_fnReporteVentaGeneral(cbProveedor.Value, idCategoria, idMarca, idAtributo,
                                                   cbDescripcion.Value, fechaDesde, fechaHasta, idCliente, idRepartidor, idProducto, idVendedor)

            'SELECCION DE GRUPOS
            'GENERAL
            If ventaGeneral.Rows.Count > 0 Then
                insertarFila(table, tipoFila, "", "TOTAL GENERAL", ventaGeneral.Rows(0))

                'PROVEEDORES
                ventaProveedor = L_fnReporteVentaProveedor(idProveedor, cbCategoria.Value, cbMarca.Value, cbAtributo.Value,
                                                           cbDescripcion.Value, fechaDesde, fechaHasta, idCliente, idRepartidor, idProducto, idVendedor)
                For Each provee As DataRow In ventaProveedor.Rows

                    tipoFila = 1
                    insertarFila(table, tipoFila, "", provee("proveedor"), provee)
                    'CATEGORIA
                    ventaCategoria = L_fnReporteVentaCategoria(IIf(idProveedor = 0, provee("idProveedor"), idProveedor),
                                                                idCategoria,
                                                                idMarca,
                                                                idAtributo,
                                                                cbDescripcion.Value,
                                                                fechaDesde, fechaHasta,
                                                                idCliente, idRepartidor, idProducto, idVendedor)

                    For Each categ As DataRow In ventaCategoria.Rows
                        tipoFila = 2
                        insertarFila(table, tipoFila, "", categ("categoria"), categ)
                        'MARCA
                        ventaMarca = L_fnReporteVentaMarca(IIf(idProveedor = 0, categ("idProveedor"), idProveedor),
                                                           IIf(idCategoria = 0, categ("idCategoria"), idCategoria),
                                                           idMarca,
                                                           idAtributo,
                                                           cbDescripcion.Value, fechaDesde, fechaHasta,
                                                           idCliente, idRepartidor, idProducto, idVendedor)

                        For Each marca As DataRow In ventaMarca.Rows

                            tipoFila = 3
                            insertarFila(table, tipoFila, "", marca("marca"), marca)
                            'ATRIBUTO
                            ventaAtributo = L_fnReporteVentaAtributo(IIf(idProveedor = 0, marca("idProveedor"), idProveedor),
                                                                     IIf(idCategoria = 0, marca("idCategoria"), idCategoria),
                                                                     IIf(idMarca = 0, marca("idMarca"), idMarca),
                                                                     idAtributo,
                                                                     cbDescripcion.Value,
                                                                     fechaDesde, fechaHasta,
                                                                      idCliente, idRepartidor, idProducto, idVendedor)
                            For Each atributo As DataRow In ventaAtributo.Rows
                                tipoFila = 4
                                insertarFila(table, tipoFila, "", atributo("atributo"), atributo)
                                'ATRIBUTO
                                ventaProducto = L_fnReporteVentaProducto(IIf(idProveedor = 0, atributo("idProveedor"), idProveedor),
                                                                         IIf(idCategoria = 0, atributo("idCategoria"), idCategoria),
                                                                         IIf(idMarca = 0, atributo("idMarca"), idMarca),
                                                                         IIf(idAtributo = 0, atributo("idAtributo"), idAtributo),
                                                                         cbDescripcion.Value,
                                                                         fechaDesde, fechaHasta,
                                                                         idCliente, idRepartidor, idProducto, idVendedor)
                                For Each producto As DataRow In ventaProducto.Rows
                                    'PRODUCTO
                                    tipoFila = 5
                                    insertarFila(table, tipoFila, producto("IdProducto"), producto("producto"), producto)
                                Next
                            Next
                        Next
                    Next
                Next
            End If

            _dt = table.Copy
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try

    End Sub
    Public Sub insertarFila(ByRef _dt As DataTable, tipoFila As Integer, codigo As String, descripcion As String, tabla As DataRow)
        Select Case tipoFila
            Case 0
                descripcion = descripcion
            Case 1
                descripcion = "  " + descripcion
            Case 2
                descripcion = "     " + descripcion
            Case 3
                descripcion = "        " + descripcion
            Case 4
                descripcion = "            " + descripcion
            Case 5
                descripcion = "               " + descripcion
        End Select
        _dt.Rows.Add(codigo, descripcion.ToUpper, tabla("caja"), tabla("Importe"), tabla("cantidadCliente"), tabla("Porcentaje"), tipoFila)
    End Sub
    Public Sub Filtrar(ByRef _dt As DataTable)
        Dim table As DataTable = _dt.Copy

        If (cbClientes.Value <> 0) Then
            table = _dt.Copy
            table.Rows.Clear()
            For i As Integer = 0 To _dt.Rows.Count - 1 Step 1
                If (_dt.Rows(i).Item("ClienteId") = cbClientes.Value) Then
                    table.ImportRow(_dt.Rows(i))

                End If

            Next
            _dt = table.Copy
        End If
        If (cbVendedor.Value <> 0) Then
            table = _dt.Copy
            table.Rows.Clear()
            For i As Integer = 0 To _dt.Rows.Count - 1 Step 1
                If (_dt.Rows(i).Item("CodigoVendedor") = cbVendedor.Value) Then
                    table.ImportRow(_dt.Rows(i))

                End If

            Next
            _dt = table.Copy
        End If
        If (cbRepartidor.Value <> 0) Then
            table = _dt.Copy
            table.Rows.Clear()
            For i As Integer = 0 To _dt.Rows.Count - 1 Step 1
                If (_dt.Rows(i).Item("RepartidorId") = cbRepartidor.Value) Then
                    table.ImportRow(_dt.Rows(i))

                End If

            Next
            _dt = table.Copy
        End If
        If (cbProducto.Value <> 0) Then
            table = _dt.Copy
            table.Rows.Clear()
            For i As Integer = 0 To _dt.Rows.Count - 1 Step 1
                If (_dt.Rows(i).Item("CodProducto") = cbProducto.Value) Then
                    table.ImportRow(_dt.Rows(i))

                End If

            Next
            _dt = table.Copy
        End If
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim dt As DataTable = L_fnReporteVentaAdminEstructura()
        ConstruirTabla(dt)
        '  Filtrar(dt)
        If (dt.Rows.Count > 0) Then
            grDatos.DataSource = dt
            grDatos.RetrieveStructure()
            grDatos.AlternatingColors = True

            With grDatos.RootTable.Columns("Codigo")
                .Caption = "Codigo"
                .Width = 120
                .HeaderAlignment = TextAlignment.Center
                .TextAlignment = TextAlignment.Center
                .FormatString = ""
                .Visible = True
            End With
            With grDatos.RootTable.Columns("Descripcion")
                .Caption = "Empresa/Categoria/Marca/Atributo/Producto"
                .HeaderAlignment = TextAlignment.Center
                .TextAlignment = TextAlignment.Near
                .FormatString = ""
                .Width = 500
                .Visible = True
            End With
            With grDatos.RootTable.Columns("Cajas")
                .HeaderAlignment = TextAlignment.Center
                .TextAlignment = TextAlignment.Far
                .Caption = "Cajas"
                .FormatString = "0.00"
                .Width = 160
                .Visible = True
            End With

            With grDatos.RootTable.Columns("Importe")
                .HeaderAlignment = TextAlignment.Center
                .TextAlignment = TextAlignment.Far
                .Caption = "Importe"
                .FormatString = "0.00"
                .Width = 160
                .Visible = True
            End With
            With grDatos.RootTable.Columns("NroClientes")
                .HeaderAlignment = TextAlignment.Center
                .TextAlignment = TextAlignment.Far
                .Caption = "NroClientes"
                .FormatString = "0.00"
                .Width = 160
                .Visible = True
            End With
            With grDatos.RootTable.Columns("Porcentaje")
                .HeaderAlignment = TextAlignment.Center
                .TextAlignment = TextAlignment.Far
                .Caption = "Porcentaje"
                .FormatString = "0.00"
                .Width = 160
                .Visible = True
            End With
            With grDatos.RootTable.Columns("tipo")
                .Visible = False
            End With
            With grDatos
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                .FilterMode = FilterMode.Automatic
                .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                .GroupByBoxVisible = False
                'diseño de la grilla
                .VisualStyle = VisualStyle.Office2007
            End With
            aplicarCondicionJanues()
        Else
            If (Not IsNothing(grDatos) And Not IsNothing(grDatos.DataSource)) Then

                CType(grDatos.DataSource, DataTable).Rows.Clear()

            End If

            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                    My.Resources.INFORMATION, 2000,
                                    eToastGlowColor.Blue,
                                    eToastPosition.TopCenter)
        End If

    End Sub
    Public Sub aplicarCondicionJanues()
        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition(grDatos.RootTable.Columns("tipo"), ConditionOperator.Equal, 1)
        fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.BackColor = Color.DarkGray
        grDatos.RootTable.FormatConditions.Add(fc)

        fc = New GridEXFormatCondition(grDatos.RootTable.Columns("tipo"), ConditionOperator.Equal, 2)
        fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.BackColor = Color.Silver
        grDatos.RootTable.FormatConditions.Add(fc)

        fc = New GridEXFormatCondition(grDatos.RootTable.Columns("tipo"), ConditionOperator.Equal, 3)
        fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.BackColor = Color.LightGray
        grDatos.RootTable.FormatConditions.Add(fc)

        fc = New GridEXFormatCondition(grDatos.RootTable.Columns("tipo"), ConditionOperator.Equal, 4)
        fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.BackColor = Color.Gainsboro
        grDatos.RootTable.FormatConditions.Add(fc)

        fc = New GridEXFormatCondition(grDatos.RootTable.Columns("tipo"), ConditionOperator.Equal, 5)
        'fc.FormatStyle.BackColor = Color.LightSlateGray

        grDatos.RootTable.FormatConditions.Add(fc)
    End Sub
    Private Sub _prCrearCarpetaReportes()
        Dim rutaDestino As String = RutaGlobal + "\Reporte\Reporte Ventas\"

        If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Ventas\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Reporte") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte")
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Ventas") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Ventas")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Ventas") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Ventas")

                End If
            End If
        End If
    End Sub
    Private Sub btExcel_Click(sender As Object, e As EventArgs) Handles btExcel.Click
        If (Not IsNothing(grDatos) And Not IsNothing(grDatos.DataSource)) Then

            _prCrearCarpetaReportes()
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            If (P_ExportarExcel(RutaGlobal + "\Reporte\Reporte Ventas")) Then
                ToastNotification.Show(Me, "EXPORTACIÓN DE LISTA DE PRODUCTOS EXITOSA..!!!",
                                           img, 2000,
                                           eToastGlowColor.Green,
                                           eToastPosition.BottomCenter)
            Else
                ToastNotification.Show(Me, "FALLO AL EXPORTACIÓN DE LISTA DE PRODUCTOS..!!!",
                                           My.Resources.WARNING, 2000,
                                           eToastGlowColor.Red,
                                           eToastPosition.BottomLeft)
            End If
        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA EXPORTAR..!!!",
                                   My.Resources.INFORMATION, 2000,
                                   eToastGlowColor.Blue,
                                   eToastPosition.TopCenter)

        End If
    End Sub
    Public Function P_ExportarExcel(_ruta As String) As Boolean
        Dim _ubicacion As String
        'Dim _directorio As New FolderBrowserDialog

        If (1 = 1) Then 'If(_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            '_ubicacion = _directorio.SelectedPath
            _ubicacion = _ruta
            Try
                Dim _stream As Stream
                Dim _escritor As StreamWriter
                Dim _fila As Integer = grDatos.GetRows.Length
                Dim _columna As Integer = grDatos.RootTable.Columns.Count
                Dim _archivo As String = _ubicacion & "\ListaDeVentaAdministrativa_" & Now.Date.Day &
                    "." & Now.Date.Month & "." & Now.Date.Year & "_" & Now.Hour & "." & Now.Minute & "." & Now.Second & ".csv"
                Dim _linea As String = ""
                Dim _filadata = 0, columndata As Int32 = 0
                File.Delete(_archivo)
                _stream = File.OpenWrite(_archivo)
                _escritor = New StreamWriter(_stream, System.Text.Encoding.UTF8)

                For Each _col As GridEXColumn In grDatos.RootTable.Columns
                    If (_col.Visible) Then
                        _linea = _linea & _col.Caption & ";"
                    End If
                Next
                _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                _escritor.WriteLine(_linea)
                _linea = Nothing

                'Pbx_Precios.Visible = True
                'Pbx_Precios.Minimum = 1
                'Pbx_Precios.Maximum = Dgv_Precios.RowCount
                'Pbx_Precios.Value = 1

                For Each _fil As GridEXRow In grDatos.GetRows
                    For Each _col As GridEXColumn In grDatos.RootTable.Columns
                        If (_col.Visible) Then
                            Dim data As String = CStr(_fil.Cells(_col.Key).Value)
                            data = data.Replace(";", ",")
                            _linea = _linea & data & ";"
                        End If
                    Next
                    _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                    _escritor.WriteLine(_linea)
                    _linea = Nothing
                    'Pbx_Precios.Value += 1
                Next
                _escritor.Close()
                'Pbx_Precios.Visible = False
                Try
                    Dim ef = New Efecto
                    ef._archivo = _archivo

                    ef.tipo = 1
                    ef.Context = "Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?"
                    ef.Header = "PREGUNTA"
                    ef.ShowDialog()
                    Dim bandera As Boolean = False
                    bandera = ef.band
                    If (bandera = True) Then
                        Process.Start(_archivo)
                    End If

                    'If (MessageBox.Show("Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    '    Process.Start(_archivo)
                    'End If
                    Return True
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return False
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End If
        Return False
    End Function

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Me.Close()
    End Sub
End Class