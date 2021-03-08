Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports Janus.Windows.GridEX
Imports Logica.AccesoLogica

Public Class F02_Movimiento
    Dim _inter As Integer = 0
#Region "Atributos generales"

    Private stTitulo As String = "M O V I M I E N T O   D E   P R O D U C T O S"
    Private inTipo As Byte = 1 '1=Equipos, 2=Productos

    Private stEst As String = "1"
    Private stAlm As String = "1"
    Private stIddc As String = "0"

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

    Private boShow As Boolean = False
    Private boAdd As Boolean = False
    Private boModif As Boolean = False
    Private boDel As Boolean = False

#End Region

#Region "Propiedades generales"

    Public Property titulo
        Get
            Return stTitulo
        End Get
        Set(value)
            stTitulo = value
        End Set
    End Property

    Public Property tipo
        Get
            Return inTipo
        End Get
        Set(value)
            inTipo = value
        End Set
    End Property

#End Region

#Region "Variables globales locales"
    Dim FtTitulo As Font = New Font("Arial", gi_fuenteTamano + 1)
    Dim FtNormal As Font = New Font("Arial", gi_fuenteTamano)

    Dim DtBusqueda As DataTable
    Dim DtDetalle As DataTable
    Dim InDuracion As Byte = 5

    Dim BoNuevo As Boolean = False
    Dim BoModificar As Boolean = False
    Dim BoEliminar As Boolean = False
    Dim BoNavegar As Boolean = False

#End Region

#Region "Eventos generales"

    Private Sub My_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub

    Private Sub MBtNuevo_Click(sender As Object, e As EventArgs) Handles MBtNuevo.Click
        P_prNuevoRegistro()
    End Sub

    Private Sub MBtModificar_Click(sender As Object, e As EventArgs) Handles MBtModificar.Click
        P_prModificarRegistro()
    End Sub

    Private Sub MBtEliminar_Click(sender As Object, e As EventArgs) Handles MBtEliminar.Click
        P_prEliminarRegistro()
    End Sub

    Private Sub MBtGrabar_Click(sender As Object, e As EventArgs) Handles MBtGrabar.Click
        P_prGrabarRegistro()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        P_prCancelarRegistro()
    End Sub

    Private Sub MBtPrimero_Click(sender As Object, e As EventArgs) Handles MBtPrimero.Click
        If (dgjBusqueda.RowCount > 0) Then
            dgjBusqueda.MoveFirst()
        End If
    End Sub

    Private Sub MBtAnterior_Click(sender As Object, e As EventArgs) Handles MBtAnterior.Click
        If (dgjBusqueda.RowCount > 0) Then
            dgjBusqueda.MovePrevious()
        End If
    End Sub

    Private Sub MBtSiguiente_Click(sender As Object, e As EventArgs) Handles MBtSiguiente.Click
        If (dgjBusqueda.RowCount > 0) Then
            dgjBusqueda.MoveNext()
        End If
    End Sub

    Private Sub MBtUltimo_Click(sender As Object, e As EventArgs) Handles MBtUltimo.Click
        If (dgjBusqueda.RowCount > 0) Then
            dgjBusqueda.MoveLast()
        End If
    End Sub

    Private Sub DgjBusqueda_SelectionChanged(sender As Object, e As EventArgs) Handles dgjBusqueda.SelectionChanged
        If (dgjBusqueda.Row > -1 And (Not BoNuevo And Not BoModificar)) Then
            P_prLlenarDatos(dgjBusqueda.Row)
        End If
    End Sub

    Private Sub dgjBusqueda_DoubleClick(sender As Object, e As EventArgs) Handles dgjBusqueda.DoubleClick
        If (dgjBusqueda.Row > -1) Then
            MSuperTabControlPrincipal.SelectedTabIndex = 0
        End If
    End Sub

    Private Sub dgjBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles dgjBusqueda.KeyDown
        If (e.KeyData = Keys.Enter) Then
            MSuperTabControlPrincipal.SelectedTabIndex = 0
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub dgjDetalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles dgjDetalle.EditingCell
        If (e.Column.Key.Equals("iccant")) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Public Function ExisteProducto(idproducto As Integer) As Boolean

        Dim dt As DataTable = CType(dgjDetalle.DataSource, DataTable)
        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            If (dt.Rows(i).Item("estado") >= 0 And dt.Rows(i).Item("iccprod") = idproducto) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub dgjDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles dgjDetalle.KeyDown
        

        If (BoNuevo Or BoModificar) Then
            If (e.KeyData = Keys.Control + Keys.Enter) Then
                Dim dt As DataTable
                dt = L_fnObtenerTabla("a.canumi as numi, a.cadesc as [desc],b.iacant as stock",
                                      "TC001 a,TI001 as b",
                                      "a.caserie=" + IIf(tipo = 1, "1", "0") + " and caest=1 and a.canumi=b.iacprod 
                                      and b.iaalm = " + Str(cbAlmacenOrigen.Value) + "order by a.canumi asc")

                Dim listEstCeldas As New List(Of Modelo.MCelda)
                listEstCeldas.Add(New Modelo.MCelda("numi,", True, "Código", 80))
                listEstCeldas.Add(New Modelo.MCelda("desc", True, "Descripción", 270))
                listEstCeldas.Add(New Modelo.MCelda("stock", True, "Stock", 120))

                Dim ef = New Efecto
                ef.tipo = 3
                ef.dt = dt
                ef.SeleclCol = 2
                ef.listEstCeldas = listEstCeldas
                ef.alto = 50
                ef.ancho = 350
                ef.Context = "Seleccione Producto".ToUpper
                ef.ShowDialog()
                ef.StartPosition = FormStartPosition.CenterScreen
                Dim bandera As Boolean = False
                bandera = ef.band
                If (bandera = True) Then
                    Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                    If (Not ExisteProducto(Row.Cells("numi").Value)) Then



                        'dgjDetalle.SetValue("cprod", Row.Cells("numi").Value)
                        'dgjDetalle.SetValue("ncprod", Row.Cells("desc").Value)
                        dgjDetalle.Col = dgjDetalle.RootTable.Columns("iccant").Index
                        DtDetalle.Rows(dgjDetalle.Row).Item("iccprod") = Row.Cells("numi").Value
                        DtDetalle.Rows(dgjDetalle.Row).Item("ncprod") = Row.Cells("desc").Value
                        DtDetalle.Rows(dgjDetalle.Row).Item("stock") = Row.Cells("stock").Value
                    Else
                        Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
                        ToastNotification.Show(Me, "El producto ya existe en el Detalle",
                          img,
                          5000,
                          eToastGlowColor.Blue,
                          eToastPosition.BottomLeft)
                    End If

                End If
                ElseIf (e.KeyData = Keys.Enter And dgjDetalle.Col = dgjDetalle.RootTable.Columns("iccant").Index) Then
                Dim filIndex As Integer = dgjDetalle.Row
                If (filIndex = dgjDetalle.RowCount - 1) Then
                    P_prAddFilaDetalle()

                    Dim dt As DataTable
                    dt = L_fnObtenerTabla("a.canumi as numi, a.cadesc as [desc],b.iacant as stock",
                                      "TC001 a,TI001 as b",
                                      "a.caserie=" + IIf(tipo = 1, "1", "0") + " and caest=1 and a.canumi=b.iacprod 
                                      and b.iaalm = " + Str(cbAlmacenOrigen.Value) + "order by a.canumi asc")

                    Dim listEstCeldas As New List(Of Modelo.MCelda)
                    listEstCeldas.Add(New Modelo.MCelda("numi,", True, "Código", 80))
                    listEstCeldas.Add(New Modelo.MCelda("desc", True, "Descripción", 270))
                    listEstCeldas.Add(New Modelo.MCelda("stock", True, "Stock", 120))

                    Dim ef = New Efecto
                    ef.tipo = 3
                    ef.dt = dt
                    ef.SeleclCol = 2
                    ef.listEstCeldas = listEstCeldas
                    ef.alto = 50
                    ef.ancho = 350
                    ef.Context = "Seleccione Producto".ToUpper
                    ef.ShowDialog()
                    ef.StartPosition = FormStartPosition.CenterScreen
                    Dim bandera As Boolean = False
                    bandera = ef.band
                    If (bandera = True) Then
                        Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                        If (Not ExisteProducto(Row.Cells("numi").Value)) Then
                            dgjDetalle.Row = filIndex + 1
                            dgjDetalle.Col = dgjDetalle.RootTable.Columns("iccant").Index

                            'dgjDetalle.SetValue("cprod", Row.Cells("numi").Value)
                            'dgjDetalle.SetValue("ncprod", Row.Cells("desc").Value)
                            DtDetalle.Rows(dgjDetalle.Row).Item("iccprod") = Row.Cells("numi").Value
                            DtDetalle.Rows(dgjDetalle.Row).Item("ncprod") = Row.Cells("desc").Value
                            DtDetalle.Rows(dgjDetalle.Row).Item("stock") = Row.Cells("stock").Value

                        Else
                            Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
                            ToastNotification.Show(Me, "El producto ya existe en el Detalle",
                              img,
                              5000,
                              eToastGlowColor.Blue,
                              eToastPosition.BottomLeft)
                        End If

                    End If

                End If
            End If
        End If
    End Sub

    Private Sub dgjDetalle_Enter(sender As Object, e As EventArgs) Handles dgjDetalle.Enter
        dgjDetalle.Row = 0
        dgjDetalle.Col = dgjDetalle.RootTable.Columns("iccprod").Index
    End Sub

    Private Sub dgjDetalle_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles dgjDetalle.CellEdited
        If (BoModificar And e.Column.Key.Equals("iccant")) Then
            If (dgjDetalle.GetValue("icid") <> 0) Then
                dgjDetalle.SetValue("estado", 2)
            End If
        End If
    End Sub

    Private Sub QuitarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitarProductoToolStripMenuItem.Click
        Try
            dgjDetalle.CurrentRow.EndEdit()
            dgjDetalle.CurrentRow.Delete()
            dgjDetalle.Refetch()
            dgjDetalle.Refresh()
        Catch ex As Exception
            'sms
            'MsgBox(ex)
        End Try
    End Sub

#End Region

#Region "Metodos y funciones indispensables"

    Private Sub P_prInicio()
        'Abrir conexión
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        'Validar requisitos del programa
        If (Not P_fnValidarRequisitos() = String.Empty) Then
            Return
        End If

        'Inicializar componentes
        P_prInicializarComponentes()

        'Habilitar/Deshabilitar compotentes del formulario
        P_prHDComponentes(False)

        'Armar todo los combobox 
        P_prArmarCombos()

        'Armar todo las grillas
        BoNavegar = False
        P_prArmarGrillas()
        BoNavegar = True

        P_prActualizarPaginacion(0)
        P_prLlenarDatos(0)
    End Sub

    Private Function P_fnValidarRequisitos() As String
        Dim sms As String = ""

        If (Not sms = String.Empty) Then
            ToastNotification.Show(Me,
                                   "".ToUpper,
                                   My.Resources.WARNING,
                                   InDuracion * 1000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
        End If

        Return sms
    End Function

    Private Sub P_prInicializarComponentes()
        'Form
        Me.Text = titulo
        'Me.WindowState = FormWindowState.Maximized

        'Tab
        MSuperTabControlPrincipal.SelectedTabIndex = 0

        'Visible
        MBtImprimir.Visible = False
        btAddConcepto.Visible = False
        QuitarProductoToolStripMenuItem.Visible = False

        'Enabled
        MBtGrabar.Enabled = False

        'ReadOnly
        tbCodigo.ReadOnly = True

        'Grid Busqueda
        dgjBusqueda.AllowEdit = Janus.Data.InheritableBoolean.False
        dgjDetalle.ContextMenuStrip = CmDetalle

        'Botones

        'Funciones
        P_prCambiarFuenteComponentes()
        P_prAsignarPermisos()

        'Usuario del sistema
        MTbUsuario.Text = gs_user
    End Sub

    Private Sub P_prCambiarFuenteComponentes()
        Dim xCtrl As Control
        For Each xCtrl In TableLayoutPanelPrincipal.Controls
            Try
                xCtrl.Font = FtNormal
            Catch ex As Exception
            End Try
        Next
        'For Each xCtrl In TableLayoutPanelPrincipal.Controls
        '    Try
        '        xCtrl.Font = FtNormal
        '    Catch ex As Exception
        '    End Try
        'Next
    End Sub

    Private Sub P_prAsignarPermisos()
        Dim dtRolUsu() As DataRow = L_prRolDetalleGeneral(gi_userRol).Select("yaprog='" + _nameButton + "'")

        If (dtRolUsu.Count = 1) Then
            boShow = dtRolUsu(0).Item("ycshow")
            boAdd = dtRolUsu(0).Item("ycadd")
            boModif = dtRolUsu(0).Item("ycmod")
            boDel = dtRolUsu(0).Item("ycdel")
        End If

        If boAdd = False Then
            MBtNuevo.Visible = False
        End If
        If boModif = False Then
            MBtModificar.Visible = False
        End If
        If boDel = False Then
            MBtEliminar.Visible = False
        End If

    End Sub

    Private Sub P_prHDComponentes(ByVal flat As Boolean)
        'TextBox
        tbObs.ReadOnly = Not flat

        'ComboBox
        cbConcepto.ReadOnly = Not flat
        cbAlmacenOrigen.ReadOnly = Not flat
        cbDepositoDestino.ReadOnly = Not flat
        'DateTimer
        dtiFechaDoc.IsInputReadOnly = Not flat
        dtiFechaDoc.ButtonDropDown.Enabled = flat

        'Button
        btAddConcepto.Enabled = flat

        'Switch Button

        'Radio Button

        'Grillas
        dgjDetalle.AllowEdit = IIf(flat, 1, 2)
    End Sub

    Private Sub P_prLimpiar()
        'TextBox
        tbCodigo.Clear()
        tbObs.Clear()

        'ComboBox
        If (CType(cbConcepto.DataSource, DataTable).Rows.Count > 0) Then
            cbConcepto.SelectedIndex = 0
        Else
            cbConcepto.Clear()
        End If

        If (CType(cbAlmacenOrigen.DataSource, DataTable).Rows.Count > 0) Then
            cbAlmacenOrigen.SelectedIndex = 0
        Else
            cbAlmacenOrigen.Clear()
        End If

        'DateTimer
        dtiFechaDoc.Value = Now.Date

        'Switch Button

        'Radio Button

        'Grillas
        P_prArmarGrillaDetalle("-1")

        MBtGrabar.Tooltip = "GRABAR"
    End Sub

    Private Sub P_prArmarCombos()
        P_prArmarComboConcepto()
        _prCargarComboLibreriaDeposito(cbAlmacenOrigen)
        _prCargarComboLibreriaDeposito(cbDepositoDestino)
    End Sub

    Private Sub _prCargarComboLibreriaDeposito(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnMovimientoListarSucursales()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("aanumi").Width = 60
            .DropDownList.Columns("aanumi").Caption = "COD"
            .DropDownList.Columns.Add("aabdes").Width = 500
            .DropDownList.Columns("aabdes").Caption = "SUCURSAL"
            .ValueMember = "aanumi"
            .DisplayMember = "aabdes"
            .DataSource = dt
            .Refresh()
        End With
    End Sub

    Private Sub P_prArmarGrillas()
        P_prArmarGrillaBusqueda()
        P_prArmarGrillaDetalle("-1")
    End Sub

    Private Sub P_prActualizarPaginacion(ByVal index As Integer)
        MLbPaginacion.Text = "Reg. " & index + 1 & " de " & dgjBusqueda.GetRows.Count
    End Sub

    Private Sub P_prMoverIndexActual()
        Dim index As Integer = CInt(MLbPaginacion.Text.Trim.Split(" ")(1).Trim)
        If (index < 0) Then
            index = 0
        End If
        If (index > dgjBusqueda.RowCount) Then
            index = dgjBusqueda.RowCount
        End If
        Try
            dgjBusqueda.MoveTo(index - 1)
            P_prLlenarDatos(dgjBusqueda.Row)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub P_prLlenarDatos(ByVal index As Integer)
        If (index <= dgjBusqueda.GetRows.Count - 1 And index >= 0) Then
            If (BoNavegar) Then
                With dgjBusqueda
                    Me.tbCodigo.Text = .GetValue("id").ToString
                    Me.dtiFechaDoc.Value = .GetValue("fdoc")
                    Me.tbObs.Text = .GetValue("obs").ToString
                    Me.cbConcepto.Clear()
                    Me.cbConcepto.SelectedText = .GetValue("nconcep").ToString

                    stEst = .GetValue("est").ToString
                    stAlm = .GetValue("alm").ToString
                    stIddc = .GetValue("iddc").ToString
                    cbAlmacenOrigen.Value = .GetValue("alm")
                    'Aqui se coloca los datos de la grilla de los Equipos
                    P_prArmarGrillaDetalle(tbCodigo.Text)

                    MLbFecha.Text = CType(.GetValue("fact").ToString, Date).ToString("dd/MM/yyyy")
                    MLbHora.Text = .GetValue("hact").ToString
                    MLbUsuario.Text = .GetValue("uact").ToString
                End With

                P_prActualizarPaginacion(dgjBusqueda.Row)

                If (Not boModif And boAdd) Then
                    If (Now.Date = Me.dtiFechaDoc.Value) Then
                        MBtModificar.Visible = True
                    Else
                        MBtModificar.Visible = False
                    End If
                End If
            End If
        Else
            If (dgjBusqueda.GetRows.Count > 0) Then
                P_prMoverIndexActual()
            End If
        End If
    End Sub

    Private Sub P_prNuevoRegistro()
        P_prLimpiar()
        P_prEstadoNueModEli(1)
        P_prHDComponentes(BoNuevo)
        dtiFechaDoc.Select()
        P_prAddFilaDetalle()
    End Sub

    Private Sub P_prModificarRegistro()
        P_prEstadoNueModEli(2)
        P_prHDComponentes(BoModificar)
        dtiFechaDoc.Select()
        P_prAddFilaDetalle()
    End Sub

    Private Sub P_prEliminarRegistro()
        Dim numi As String = tbCodigo.Text 'Valor del código único
        Dim info As New TaskDialogInfo("¿esta seguro de eliminar el registro?".ToUpper,
                                       eTaskDialogIcon.Delete, "advertencia".ToUpper,
                                       "Esta a punto de eliminar el movimiento con".ToUpper _
                                       + vbCrLf + "código -> ".ToUpper _
                                       + numi + " " + vbCrLf + "Desea continuar?".ToUpper,
                                       eTaskDialogButton.Yes Or eTaskDialogButton.Cancel,
                                       eTaskDialogBackgroundColor.Blue)
        Dim result As eTaskDialogResult = TaskDialog.Show(info)
        If result = eTaskDialogResult.Yes Then
            Dim mensajeError As String = ""
            Dim resEliminar As Boolean = L_fnbValidarEliminacion(numi, "TI002", "ibid", mensajeError)
            If (resEliminar) Then
                Dim res As Boolean = L_fnMovimientoBorrar(numi) 'Medoto de lógica para eliminar
                If (res) Then
                    ToastNotification.Show(Me, "Codigo de movimiento: ".ToUpper + numi + " eliminado con Exito.".ToUpper,
                                           My.Resources.GRABACION_EXITOSA, InDuracion * 1000,
                                           eToastGlowColor.Green,
                                           eToastPosition.TopCenter)
                    BoNavegar = False
                    P_prArmarGrillaBusqueda()
                    BoNavegar = True
                    P_prMoverIndexActual()
                Else
                    ToastNotification.Show(Me, "No se pudo eliminar el movimiento con código: ".ToUpper + numi + ", intente nuevamente.".ToUpper,
                                           My.Resources.WARNING, InDuracion * 1000,
                                           eToastGlowColor.Red,
                                           eToastPosition.TopCenter)
                End If
            Else
                ToastNotification.Show(Me, mensajeError.ToUpper,
                                           My.Resources.I64x64_error, InDuracion * 1000,
                                           eToastGlowColor.Red,
                                           eToastPosition.TopCenter)
            End If
        End If
    End Sub
    Sub _prGuardarTraspaso()
        Dim numi As String = ""
        Dim dt As DataTable
        Dim est As String
        est = IIf(tipo = 1, "1", "11")
        dt = CType(dgjDetalle.DataSource, DataTable).DefaultView.ToTable(False, "icid", "icibid", "iccprod", "ncprod", "iccant", "stock", "estado")
        'Dim res As Boolean = L_fnMovimientoGrabar(id, fdoc, concep, obs, est, alm, iddc, dt)
        Dim res As Boolean = L_fnMovimientoGrabar(numi, dtiFechaDoc.Value.ToString("yyyy/MM/dd"), cbConcepto.Value, tbObs.Text.Trim, est, cbAlmacenOrigen.Value, cbDepositoDestino.Value, 0, dt)
        If res Then

            Dim numDestino As String = ""


            Dim resDestino As Boolean = L_fnMovimientoGrabar(numDestino, dtiFechaDoc.Value.ToString("yyyy/MM/dd"), 50, tbObs.Text.Trim, est, cbDepositoDestino.Value, cbAlmacenOrigen.Value, numi, dt)
            If resDestino Then
                P_prLimpiar()
                BoNavegar = False
                P_prArmarGrillaBusqueda()
                BoNavegar = True

                ToastNotification.Show(Me, "Codigo de movimiento ".ToUpper + tbCodigo.Text + " Grabado con Exito.".ToUpper,
                                       My.Resources.GRABACION_EXITOSA,
                                       InDuracion * 1000,
                                       eToastGlowColor.Green,
                                       eToastPosition.TopCenter)

                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                ToastNotification.Show(Me, "Código de Movimiento ".ToUpper + tbCodigo.Text + " Grabado con Exito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )
            End If

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El Movimiento no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        End If
    End Sub
    Private Sub P_prGrabarRegistro()
        Dim id As String
        Dim fdoc As String
        Dim concep As String
        Dim obs As String
        Dim est As String
        Dim alm As String
        Dim iddc As String

        dgjDetalle.Refetch()

        If (BoNuevo) Then
            If (P_fnValidarGrabacion()) Then

                If (cbConcepto.Value = 60) Then
                    _prGuardarTraspaso()
                    Return

                End If

                id = ""
                fdoc = dtiFechaDoc.Value.ToString("yyyy/MM/dd")
                concep = cbConcepto.Value.ToString
                obs = tbObs.Text.Trim
                est = IIf(tipo = 1, "1", "11")
                alm = cbAlmacenOrigen.Value
                iddc = stIddc

                dtiFechaDoc.Select()

                Dim dt As New DataTable
                dt = CType(dgjDetalle.DataSource, DataTable).DefaultView.ToTable(False, "icid", "icibid", "iccprod", "ncprod", "iccant", "stock", "estado")

                'Grabar

                'L_fnMovimientoGrabar(numi, dtiFechaDoc.Value.ToString("yyyy/MM/dd"), cbConcepto.Value, tbObs.Text.Trim, est, cbAlmacenOrigen.Value, cbDepositoDestino.Value, 0, dt)

                Dim res As Boolean = L_fnMovimientoGrabar(id, fdoc, concep, obs, est, alm, 0, 0, dt)

                If (res) Then
                    P_prLimpiar()
                    BoNavegar = False
                    P_prArmarGrillaBusqueda()
                    BoNavegar = True

                    ToastNotification.Show(Me, "Codigo de movimiento ".ToUpper + tbCodigo.Text + " Grabado con Exito.".ToUpper,
                                       My.Resources.GRABACION_EXITOSA,
                                       InDuracion * 1000,
                                       eToastGlowColor.Green,
                                       eToastPosition.TopCenter)
                Else
                    ToastNotification.Show(Me, "No se pudo grabar el codigo de movimiento ".ToUpper + tbCodigo.Text + ", intente nuevamente.".ToUpper,
                                       My.Resources.WARNING,
                                       InDuracion * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.TopCenter)
                End If
            End If
        ElseIf (BoModificar) Then
            If (P_fnValidarGrabacion()) Then

                id = tbCodigo.Text.Trim
                fdoc = dtiFechaDoc.Value.ToString("yyyy/MM/dd")
                concep = cbConcepto.Value.ToString
                obs = tbObs.Text.Trim
                est = stEst
                alm = cbAlmacenOrigen.Value
                iddc = stIddc

                dtiFechaDoc.Select()

                Dim dt As New DataTable
                dt = CType(dgjDetalle.DataSource, DataTable).DefaultView.ToTable(False, "icid", "icibid", "iccprod", "ncprod", "iccant", "stock", "estado")

                'Grabar
                Dim res As Boolean = L_fnMovimientoModificar(id, fdoc, concep, obs, est, alm, iddc, dt)

                If (res) Then

                    BoNavegar = False
                    P_prArmarGrillaBusqueda()
                    BoNavegar = True

                    P_prMoverIndexActual()

                    dtiFechaDoc.Select()
                    MBtSalir.PerformClick()

                    ToastNotification.Show(Me, "Codigo de cliente ".ToUpper + tbCodigo.Text + " Modificado con Exito.".ToUpper,
                                       My.Resources.GRABACION_EXITOSA,
                                       InDuracion * 1000,
                                       eToastGlowColor.Green,
                                       eToastPosition.TopCenter)
                Else
                    ToastNotification.Show(Me, "No se pudo modificar el codigo de cliente ".ToUpper + tbCodigo.Text + ", intente nuevamente.".ToUpper,
                                       My.Resources.WARNING,
                                       InDuracion * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.TopCenter)
                End If
            End If
        End If
    End Sub

    Private Sub P_prCancelarRegistro()
        If (Not MBtGrabar.Enabled) Then
            Me.Close()
            _modulo.Select()
            '_tab.Close()
        Else
            P_prLimpiar()
            P_prHDComponentes(False)
            P_prLlenarDatos(dgjBusqueda.Row)
        End If
        P_prEstadoNueModEli(4)
    End Sub

    Private Sub P_prEstadoNueModEli(value As Integer)
        BoNuevo = (value = 1)
        BoModificar = (value = 2)
        BoEliminar = (value = 3)

        MBtNuevo.Enabled = (value = 4)
        MBtModificar.Enabled = (value = 4)
        MBtEliminar.Enabled = (value = 4)
        MBtGrabar.Enabled = Not (value = 4)

        If (value = 4) Then
            MBtSalir.Tooltip = "SALIR"
            MBtSalir.Text = "SALIR"
        Else
            MBtSalir.Tooltip = "CANCELAR"
            MBtSalir.Text = "CANCELAR"
        End If

        MBtPrimero.Enabled = (value = 4)
        MBtAnterior.Enabled = (value = 4)
        MBtSiguiente.Enabled = (value = 4)
        MBtUltimo.Enabled = (value = 4)
        MSuperTabItemBusqueda.Visible = (value = 4)
        QuitarProductoToolStripMenuItem.Visible = Not (value = 4)

        MBtGrabar.Tooltip = IIf(value = 1, "GRABAR NUEVO REGISTRO", IIf(value = 2, "GRABAR MODIFICACIÓN DE REGISTRO", "GRABAR"))
        MRlAccion.Text = IIf(value = 1, "NUEVO", IIf(value = 2, "MODIFICAR", ""))

        'Compentes

        If (MSuperTabControlPrincipal.SelectedTabIndex = 1) Then
            MSuperTabControlPrincipal.SelectedTabIndex = 0
        End If

    End Sub

    Private Function P_fnObtenerID() As String
        Dim res As String = ""
        res = res + Now.Hour.ToString("00") + Now.Minute.ToString("00") + Now.Second.ToString("00") + "_" _
            + Now.Day.ToString("00") + Now.Month.ToString("00") + Now.Year.ToString("0000")
        Return res
    End Function

#End Region
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _inter = _inter + 1
        If _inter = 1 Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
        'Me.Opacity = 100
        'Timer1.Enabled = False
    End Sub
#Region "Metodos y funciones generales"

    Private Sub P_prArmarComboConcepto()
        Dim Dt As New DataTable
        'select a.cpnumi as numi, ROW_NUMBER() OVER(ORDER BY a.cpnumi ASC) AS [row], a.cpdesc as [desc]
        'from TCI001 a
        'where a.cptipo=2
        Dt = L_fnObtenerTabla("a.cpnumi as numi, ROW_NUMBER() OVER(ORDER BY a.cpnumi ASC) AS [row], a.cpdesc as [desc]",
                              "TCI001 a", "a.cptipo=" + IIf(tipo = 1, "2", "3"))

        With cbConcepto.DropDownList
            .Columns.Add(Dt.Columns("numi").ToString)
            .Columns(0).Visible = False

            .Columns.Add(Dt.Columns("row").ToString).Width = 80
            .Columns(1).Caption = "Nro."

            .Columns.Add(Dt.Columns("desc").ToString).Width = 150
            .Columns(2).Caption = "Descripción"
        End With

        cbConcepto.ValueMember = Dt.Columns("numi").ToString
        cbConcepto.DisplayMember = Dt.Columns("desc").ToString
        cbConcepto.DataSource = Dt
        cbConcepto.Refresh()
    End Sub

    Private Sub P_prArmarGrillaBusqueda()
        DtBusqueda = New DataTable
        DtBusqueda = L_fnMovimientoGeneral(IIf(tipo = 1, "1", "11"))

        dgjBusqueda.BoundMode = Janus.Data.BoundMode.Bound
        dgjBusqueda.DataSource = DtBusqueda
        dgjBusqueda.RetrieveStructure()

        'dar formato a las columnas
        With dgjBusqueda.RootTable.Columns("id")
            .Caption = "Código"
            .Width = 80
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns("fdoc")
            .Caption = "Fecha"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns("concep")
            .Visible = False
        End With

        With dgjBusqueda.RootTable.Columns("nconcep")
            .Caption = "Concepto"
            .Width = 150
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns("obs")
            .Caption = "Observación"
            .Width = 200
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Position = 2
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns("est")
            .Visible = False
        End With

        With dgjBusqueda.RootTable.Columns("alm")
            .Visible = False
        End With

        With dgjBusqueda.RootTable.Columns("iddc")
            .Visible = False
        End With

        With dgjBusqueda.RootTable.Columns("fact")
            .Visible = False
        End With

        With dgjBusqueda.RootTable.Columns("hact")
            .Visible = False
        End With

        With dgjBusqueda.RootTable.Columns("uact")
            .Visible = False
        End With
        'Habilitar Filtradores
        With dgjBusqueda
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.MultipleSelection
            .AlternatingColors = True
            .RecordNavigator = True
        End With
    End Sub

    Private Sub P_prArmarGrillaDetalle(numi As String)
        DtDetalle = New DataTable
        DtDetalle = L_fnMovimientoDetalle(numi, cbAlmacenOrigen.Value)

        dgjDetalle.BoundMode = Janus.Data.BoundMode.Bound
        dgjDetalle.DataSource = DtDetalle
        dgjDetalle.RetrieveStructure()

        'dar formato a las columnas
        With dgjDetalle.RootTable.Columns("icid")
            .Visible = False
        End With

        With dgjDetalle.RootTable.Columns("icibid")
            .Visible = False
        End With

        With dgjDetalle.RootTable.Columns("iccprod")
            .Caption = "Código"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjDetalle.RootTable.Columns("ncprod")
            .Caption = "Descripción"
            .Width = 200
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjDetalle.RootTable.Columns("iccant")
            .Caption = "Cantidad"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With dgjDetalle.RootTable.Columns("estado")
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjDetalle.RootTable.Columns("stock")
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        'Habilitar Filtradores
        With dgjDetalle
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.MultipleSelection
            .AlternatingColors = True
            .RecordNavigator = True
        End With
    End Sub

    Private Function P_fnValidarGrabacion() As Boolean
        Dim res As Boolean = True
        MEP.Clear()

        If (Not IsNumeric(cbConcepto.Value)) Then
            cbConcepto.BackColor = Color.Red
            MEP.SetError(cbConcepto, "elija un concepto valido.".ToUpper)
            res = False
        Else
            cbConcepto.BackColor = Color.White
            MEP.SetError(cbConcepto, "")
        End If

        Return res
    End Function

    Private Sub P_prAddFilaDetalle()
        Dim fil As DataRow
        fil = DtDetalle.NewRow
        fil.Item("icid") = 0
        fil.Item("icibid") = 0
        fil.Item("iccprod") = 0
        fil.Item("ncprod") = "Nuevo"
        fil.Item("iccant") = 0
        fil.Item("estado") = 0
        fil.Item("stock") = 0
        DtDetalle.Rows.Add(fil)
    End Sub
    Public Function _fnAccesible()
        Return tbObs.ReadOnly = False
    End Function

    Private Sub cbConcepto_ValueChanged(sender As Object, e As EventArgs) Handles cbConcepto.ValueChanged
        If (cbConcepto.SelectedIndex >= 0) Then
            If (cbConcepto.Value = 60) Then ''''Movimiento 6=Traspaso Salida
                If (CType(cbAlmacenOrigen.DataSource, DataTable).Rows.Count > 1) Then
                    lbDepositoDestino.Visible = True
                    cbDepositoDestino.Visible = True
                    lbDepositoOrigen.Text = "Deposito Origen"
                    lbDepositoDestino.Text = "Deposito Destino"
                    cbDepositoDestino.SelectedIndex = 1
                    If (Not _fnAccesible()) Then
                        MBtModificar.Enabled = False
                    End If
                Else
                    lbDepositoDestino.Visible = False
                    cbDepositoDestino.Visible = False
                    lbDepositoOrigen.Text = "Deposito:"
                    If (Not _fnAccesible()) Then
                        MBtModificar.Enabled = True
                    End If
                End If
            Else
                MBtModificar.Enabled = True
                lbDepositoDestino.Visible = False
                cbDepositoDestino.Visible = False
                lbDepositoOrigen.Text = "Deposito:"

            End If
            If (_fnAccesible() And tbCodigo.Text = String.Empty) Then
                CType(dgjDetalle.DataSource, DataTable).Rows.Clear()
                P_prAddFilaDetalle()
            End If
        End If
    End Sub

    Private Sub cbAlmacenOrigen_ValueChanged(sender As Object, e As EventArgs) Handles cbAlmacenOrigen.ValueChanged
        If (_fnAccesible() And tbCodigo.Text = String.Empty) Then
            CType(dgjDetalle.DataSource, DataTable).Rows.Clear()
            P_prAddFilaDetalle()

        End If
    End Sub
    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(dgjDetalle.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("icid")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub

    Private Sub dgjDetalle_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles dgjDetalle.CellValueChanged
        If (e.Column.Index = dgjDetalle.RootTable.Columns("iccant").Index) Then


            If (Not IsNumeric(dgjDetalle.GetValue("iccant")) Or dgjDetalle.GetValue("iccant").ToString = String.Empty) Then

                'dgjDetalle.GetRow(rowIndex).Cells("cant").Value = 1
                '  dgjDetalle.CurrentRow.Cells.Item("cant").Value = 1
                Dim lin As Integer = dgjDetalle.GetValue("icid")
                Dim pos As Integer = -1
                _fnObtenerFilaDetalle(pos, lin)
                CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("iccant") = 1

                Dim estado As Integer = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("estado")

                If (estado = 1) Then
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("estado") = 2
                End If

            Else
                If (dgjDetalle.GetValue("iccant") > 0) Then

                    Dim stock As Double = dgjDetalle.GetValue("stock")
                    If (dgjDetalle.GetValue("iccant") > stock And cbConcepto.Value = 60) Then
                        Dim lin As Integer = dgjDetalle.GetValue("icid")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("iccant") = stock
                        dgjDetalle.SetValue("iccant", stock)
                        Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
                        ToastNotification.Show(Me, "La cantidad que se quiere sacar es mayor a la que existe en el stock solo puede Sacar : ".ToUpper + Str(stock).Trim,
                          img,
                          5000,
                          eToastGlowColor.Blue,
                          eToastPosition.BottomLeft)
                        Return


                    Else
                        Dim lin As Integer = dgjDetalle.GetValue("icid")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        Dim estado As Integer = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("estado")

                        If (estado = 1) Then
                            CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("estado") = 2
                        End If
                    End If
                Else
                    Dim lin As Integer = dgjDetalle.GetValue("icid")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("iccant") = 1
                    Dim estado As Integer = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("estado")

                    If (estado = 1) Then
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("estado") = 2
                    End If

                End If
            End If
        End If
    End Sub

#End Region

End Class