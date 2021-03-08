Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls


Public Class F02_Comisiones
    Dim _inter As Integer = 0
#Region "Variables Globales"

    Dim _Pos As Integer
    Dim _Nuevo As Boolean
    Dim _Dsencabezado As DataSet

    Dim _BindingSource As BindingSource
    Dim _Modificar As Boolean

    Dim modif As Boolean = True

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

    Dim dtComisiones As New DataTable

#End Region

#Region "Metodos"
    Private Sub _PIniciarTodo()
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If
        P_prArmarComboCategoria()
        _PCargarGridCategoriasComisiones(-1)
        _Filtrar()

        MBtNuevo.Visible = False
        MBtModificar.Visible = False
        MBtEliminar.Visible = False

        Me.Text = "C O M I S I O N E S "
        'Me.WindowState = FormWindowState.Maximized

        btNuevoP.Image = My.Resources.ADICIONAR

        MBtPrimero.PerformClick()

        'activar los permisos del rol
        _PAsignarPermisos()

        'Asignar el menustrip quitar al grid JGr_Descuentos
        JGr_Descuentos.ContextMenuStrip = CmDetalle
    End Sub

    Private Sub _PAsignarPermisos()
        Dim dtRolUsu() As DataRow = L_prRolDetalleGeneral(gi_userRol).Select("yaprog='" + _nameButton + "'")

        Dim show As Boolean = False
        Dim add As Boolean = False
        Dim modif As Boolean = False
        Dim del As Boolean = False

        If (dtRolUsu.Count = 1) Then
            show = dtRolUsu(0).Item("ycshow")
            add = dtRolUsu(0).Item("ycadd")
            modif = dtRolUsu(0).Item("ycmod")
            del = dtRolUsu(0).Item("ycdel")
        End If

        If add = False Then
            'MBtNuevo.Visible = False
        End If
        If modif = False Then
            'MBtModificar.Visible = False
        End If
        If del = False Then
            'MBtEliminar.Visible = False
        End If
    End Sub


    Private Sub _PSalirRegistro()
        Me.Close()
        _modulo.Select()
        '_tab.Close()
    End Sub

    Private Sub P_prArmarComboCategoria()
        Dim Dt As DataTable
        Dt = L_fnObtenerCategoria()
        ''   Dt = L_fnObtenerLibreria("5", IIf(TipoForm = 1, "cenum>0", "cenum<0"))
        g_prArmarCombo(JCb_CatProducto, Dt, 60, 200, "Código", "Categoría")
    End Sub

    Private Sub _PCargarDetalle(idTipoProd As String)
        Dim dtProd, dtCatPrecios As New DataTable
        dtProd = L_Productos_GeneralFiltrado3(-1, "cacat= " + idTipoProd + "AND caest=1 AND caserie=0 AND cecon=103 AND cenum=cagr3")
        'dtCatPrecios = L_General_LibreriaDetalle(-1, 8).Tables(0)
        dtCatPrecios = L_CategoriaPrecioGeneral()

        'Cargar categoria de precios
        Dim i, j As Integer
        j = 2
        For i = 0 To dtCatPrecios.Rows.Count() - 1
            'aumentar columna al datatable de productos
            dtProd.Columns.Add(dtCatPrecios.Rows(i).Item("cicod"), Type.GetType("System.Double"))
        Next
        dtProd.Columns.Add("huboCambio", Type.GetType("System.Boolean"))
        dtProd.Columns.Add("listPrecio", Type.GetType("System.String"))


        'cargar datos de la tabla
        Dim dtPreciosProd As DataTable
        For i = 0 To dtProd.Rows.Count - 1
            Dim where As String = "chcprod='" + dtProd.Rows(i).Item("canumi").ToString + "'"
            dtPreciosProd = L_PrecioProd_GeneralConCatPrecio(-1, where).Tables(0)
            Dim listPrecio = String.Empty
            Dim k As Integer = 0
            For j = 0 To dtPreciosProd.Rows.Count - 1
                Dim catPrecio As String = dtPreciosProd.Rows(j).Item("cicod")
                Dim precio As Double = dtPreciosProd.Rows(j).Item("chprecio")
                dtProd.Rows(i).Item(catPrecio) = precio
                listPrecio += precio.ToString + "|"
            Next
            dtProd.Rows(i).Item("huboCambio") = False
            dtProd.Rows(i).Item("listPrecio") = listPrecio.Trim("|")
        Next

        JGr_Detalle.BoundMode = BoundMode.Bound
        JGr_Detalle.DataSource = dtProd
        JGr_Detalle.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Detalle.RootTable.Columns(0)
            .Caption = "Cod. Producto"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .CellStyle.BackColor = Color.AliceBlue
        End With

        With JGr_Detalle.RootTable.Columns(1)
            .Caption = "Codigo Flex"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .CellStyle.BackColor = Color.AliceBlue
        End With

        ''JGr_Detalle.RootTable.Columns.Add()
        With JGr_Detalle.RootTable.Columns(2)
            .Caption = "Descripción"
            .Width = 450
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
        End With

        For i = 3 To JGr_Detalle.RootTable.Columns.Count - 1
            With JGr_Detalle.RootTable.Columns(i)
                .Width = 65
                .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                .CellStyle.FontSize = gi_fuenteTamano
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .FormatString = "0.00"
                .Visible = False
            End With
        Next

        With JGr_Detalle.RootTable.Columns("huboCambio")
            .Visible = False
        End With

        With JGr_Detalle.RootTable.Columns("listPrecio")
            .Visible = False
        End With
        With JGr_Detalle.RootTable.Columns(3)
            .Caption = "Familia"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .TextAlignment = TextAlignment.Near
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
            .Visible = False
        End With

        'Habilitar Filtradores
        With JGr_Detalle
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With


    End Sub

    Private Sub _PCargarGridCategoriasComisiones(cod As String)

        dtComisiones = L_fnMostrarComisiones(cod)

        JGr_Descuentos.DataSource = dtComisiones
        JGr_Descuentos.RetrieveStructure()

        With JGr_Descuentos.RootTable.Columns("cqnumi")
            .Visible = False
        End With
        With JGr_Descuentos.RootTable.Columns("cqprod")
            .Caption = "Cod Prod."
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .CellStyle.BackColor = Color.AliceBlue
            .Visible = False
        End With

        With JGr_Descuentos.RootTable.Columns("cqcomision")
            .Caption = "Comision"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.0000"
        End With

        With JGr_Descuentos.RootTable.Columns("estado")
            .Visible = False
        End With
        'Habilitar Filtradores
        With JGr_Descuentos
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
            '.AllowEdit = InheritableBoolean.False
        End With

        tbComision.Text = JGr_Descuentos.GetValue("cqcomision")
    End Sub


    Private Sub _Filtrar()
        _Dsencabezado = New DataSet
        _Dsencabezado = L_General_LibreriaDetalle(-1, 5)
        '_First = False
        If _Dsencabezado.Tables(0).Rows.Count <> 0 Then
            _Pos = 0
            _MostrarRegistro(_Pos)
            If _Dsencabezado.Tables(0).Rows.Count > 0 Then
                MBtPrimero.Visible = True
                MBtAnterior.Visible = True
                MBtSiguiente.Visible = True
                MBtUltimo.Visible = True
            End If
        End If

    End Sub
    Private Sub _MostrarRegistro(_N As Integer)
        JCb_CatProducto.SelectedIndex = _N
    End Sub
    Private Sub _PrimerRegistro()
        _Pos = 0
        _MostrarRegistro(_Pos)
        MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub
    Private Sub _AnteriorRegistro()
        If _Pos > 0 Then
            _Pos = _Pos - 1
            _MostrarRegistro(_Pos)
            MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub
    Private Sub _SiguienteRegistro()
        If _Pos < _Dsencabezado.Tables(0).Rows.Count - 1 Then
            _Pos = _Pos + 1
            _MostrarRegistro(_Pos)
            MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub
    Private Sub _UltimoRegistro()
        _Pos = _Dsencabezado.Tables(0).Rows.Count - 1
        _MostrarRegistro(_Pos)
        MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub
#End Region

    Private Sub P_PrecioProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub JCb_CatProducto_ValueChanged(sender As Object, e As EventArgs) Handles JCb_CatProducto.ValueChanged
        If JCb_CatProducto.SelectedIndex >= 0 Then
            _PCargarDetalle(JCb_CatProducto.Value)
        End If
    End Sub

    Private Sub MBtPrimero_Click(sender As Object, e As EventArgs) Handles MBtPrimero.Click
        _PrimerRegistro()
    End Sub

    Private Sub MBtAnterior_Click(sender As Object, e As EventArgs) Handles MBtAnterior.Click
        _AnteriorRegistro()
    End Sub

    Private Sub MBtSiguiente_Click(sender As Object, e As EventArgs) Handles MBtSiguiente.Click
        _SiguienteRegistro()
    End Sub

    Private Sub MBtUltimo_Click(sender As Object, e As EventArgs) Handles MBtUltimo.Click
        _UltimoRegistro()
    End Sub

    Private Sub JGr_Detalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_Detalle.EditingCell
        If e.Column.Index = 0 Or e.Column.Index = 1 Or e.Column.Index = 2 Or e.Column.Index = 3 Then
            e.Cancel = True
        End If

        If modif = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        _PSalirRegistro()
    End Sub


    Private Sub JGr_Detalle_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles JGr_Detalle.CellEdited
        Try
            If (Not IsNumeric(JGr_Detalle.CurrentRow.Cells(e.Column.Index).Value)) Then
                JGr_Detalle.CurrentRow.Cells(e.Column.Index).Value = 0
            End If

            Dim listPrecio = JGr_Detalle.CurrentRow.Cells("listPrecio").Value.ToString.Split("|")
            Dim valorActual = Convert.ToDecimal(JGr_Detalle.CurrentRow.Cells(e.Column.Index).Value)
            Dim valorInicial As Decimal = 0
            Try
                valorInicial = Convert.ToDecimal(listPrecio(e.Column.Index - 3))
            Catch
            End Try

            If (valorActual <> valorInicial) Then
                JGr_Detalle.CurrentRow.Cells("huboCambio").Value = True
            Else
                JGr_Detalle.CurrentRow.Cells("huboCambio").Value = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub JGr_Detalle_Click(sender As Object, e As EventArgs) Handles JGr_Detalle.Click
        If JGr_Detalle.CurrentRow.Selected <> JGr_Detalle.FilterRow.Selected Then
            If JGr_Detalle.Focused Then
                If JGr_Detalle.GetValue("canumi") > 0 Then
                    btNuevoP.Enabled = True

                    tbCodPro.Text = JGr_Detalle.CurrentRow.Cells("canumi").Value.ToString
                    lbProducto.Text = JGr_Detalle.CurrentRow.Cells("cadesc").Value.ToString + "    " + JGr_Detalle.CurrentRow.Cells("listprecio").Value.ToString

                    _PCargarGridCategoriasComisiones(tbCodPro.Text)
                    _Inhabilitar()

                    'P_prAddFilaDetallePrecio()
                    'CType(JGr_Descuentos.DataSource, DataTable).Rows(0).Item("dacant1") = JGr_Detalle.CurrentRow.Cells("canumi").Value.ToString
                End If
            End If
        End If
    End Sub

    Private Sub _Inhabilitar()
        JGr_Descuentos.Enabled = False
        btGrabarP.Enabled = False
    End Sub
    Private Sub _Habilitar()
        JGr_Descuentos.Enabled = True
        btGrabarP.Enabled = True
    End Sub

    Private Sub btNuevoP_Click(sender As Object, e As EventArgs) Handles btNuevoP.Click
        If JGr_Descuentos.RowCount > 0 Then
            L_fnActualizarEstadoComision(tbCodPro.Text)
            _PCargarGridCategoriasComisiones(tbCodPro.Text)
        End If

        _Habilitar()

        btNuevoP.Enabled = False
    End Sub

    Private Sub btGrabarP_Click(sender As Object, e As EventArgs) Handles btGrabarP.Click
        Dim numi As String = ""
        If (_ValidarCampos()) Then
            'Grabar
            Dim res As Boolean = L_fnGrabarComisiones(numi, tbCodPro.Text, tbComision.Value)

            If (res) Then
                ToastNotification.Show(Me, "Comision del Producto Grabado con éxito.".ToUpper,
                                   My.Resources.GRABACION_EXITOSA,
                                   3000,
                                   eToastGlowColor.Green,
                                   eToastPosition.TopCenter)
                btGrabarP.Enabled = False
            Else
                ToastNotification.Show(Me, "No se pudo grabar la comisión.".ToUpper,
                                   My.Resources.WARNING,
                                   3000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
            End If
        End If
    End Sub
    Public Function _ValidarCampos() As Boolean
        If (tbCodPro.Text <= 0) Then
            Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
            ToastNotification.Show(Me, "Por Favor debe dar click a un producto".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            Return False
        End If

        Return True
    End Function

    Private Sub QuitarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitarProductoToolStripMenuItem.Click
        Try
            JGr_Descuentos.CurrentRow.EndEdit()
            JGr_Descuentos.CurrentRow.Delete()
            JGr_Descuentos.Refetch()
            JGr_Descuentos.Refresh()
            JGr_Descuentos.UpdateData()
        Catch ex As Exception
            'sms
            'MsgBox(ex)
        End Try
    End Sub
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
End Class