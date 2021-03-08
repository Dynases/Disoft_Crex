
Imports Logica.AccesoLogica
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports DevComponents.DotNetBar
Imports System.IO
Imports Janus.Data
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Controls

Public Class F0_AsignacionZonaAlternativo
#Region "Atributos generales"

    Dim StTitulo As String = "Z O N A S"

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

    Public _DtRepartidores As DataTable
    Public _DtZonas As DataTable
    Public _DtDetalleZonas As DataTable

    Public Modulo As Integer = -1

#End Region
#Region "Propiedades generales"

    Public Property Titulo As String
        Get
            Return StTitulo
        End Get
        Set(value As String)
            StTitulo = value
        End Set
    End Property

#End Region
#Region "Variables globales locales"


    Dim DtBusqueda As DataTable
    Dim InDuracion As Byte = 5



    Dim _poligono As Integer
    Dim _listPuntos As List(Of PointLatLng)
    Dim _overlay As GMapOverlay
    Private Sub P_prInicio()
        'Abrir conexión
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If


        _DtDetalleZonas = L_prListarZonas()




        P_PrArmarGrillas()


        P_prLlenarDatos(0)
        Me.Text = "Asignacion Zonas"
    End Sub
    Function ObtenerDetalleZonas(numiZona As Integer) As DataTable
        Dim dt As DataTable = _DtDetalleZonas.Copy
        dt.Rows.Clear()
        For i As Integer = 0 To _DtDetalleZonas.Rows.Count - 1 Step 1
            If (_DtDetalleZonas.Rows(i).Item("lcnumi") = numiZona) Then
                dt.ImportRow(_DtDetalleZonas.Rows(i))
            End If

        Next
        Return dt

    End Function

    Private Sub P_prLlenarDatos(ByVal index As Integer)

        If (index <= DgjBusqueda.GetRows.Count - 1 And index >= 0) Then
            TbCodigo.Text = DgjBusqueda.GetValue("numi").ToString
            gPanelRepartidor.Text = "Repartidores Zona " + DgjBusqueda.GetValue("nzona").ToString
            gPanelVendedor.Text = "Vendedores Zona " + DgjBusqueda.GetValue("nzona").ToString

            'cargar lista repartidores
            P_prArmarGrillaRepartidor()
            '' Dim tRep As DataTable = L_ZonaDetalleRepartidor_General(-1, TbCodigo.Text).Tables(0)
            Dim dtZonaRep As DataTable = ObtenerDetalleZonas(TbCodigo.Text)
            Dim dtRepartidor As DataTable = CType(dgjRepartidor.DataSource, DataTable).Copy


            For i As Integer = 0 To dtRepartidor.Rows.Count - 1 Step 1
                Dim idRepartidor As Integer = dtRepartidor.Rows(i).Item("cbnumi")
                For j As Integer = 0 To dtZonaRep.Rows.Count - 1 Step 1
                    If (dtZonaRep.Rows(j).Item("lccbnumi") = idRepartidor And dtZonaRep.Rows(j).Item("estado") >= 0) Then
                        CType(dgjRepartidor.DataSource, DataTable).Rows(i).Item("value") = True
                    End If

                Next


            Next




            'cargar lista prevendedor
            P_prArmarGrillaPrevendedor()
            ''  Dim tPre As DataTable = L_ZonaDetalleRepartidor_General(-1, TbCodigo.Text).Tables(0)
            Dim dtZonaVendedore As DataTable = ObtenerDetalleZonas(TbCodigo.Text)
            Dim dtVendedor As DataTable = CType(dgjPrevendedor.DataSource, DataTable).Copy

            For i As Integer = 0 To dtVendedor.Rows.Count - 1 Step 1
                Dim idRepartidor As Integer = dtVendedor.Rows(i).Item("cbnumi")
                For j As Integer = 0 To dtZonaVendedore.Rows.Count - 1 Step 1
                    If (dtZonaVendedore.Rows(j).Item("lccbnumi") = idRepartidor And dtZonaVendedore.Rows(j).Item("estado") >= 0) Then
                        CType(dgjPrevendedor.DataSource, DataTable).Rows(i).Item("value") = True
                    End If

                Next


            Next


        End If
    End Sub
    Private Sub dgjRepartidor_EditingCell(sender As Object, e As EditingCellEventArgs) Handles dgjRepartidor.EditingCell

        If (e.Column.Index = dgjRepartidor.RootTable.Columns("value").Index) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub dgjPrevendedor_EditingCell(sender As Object, e As EditingCellEventArgs) Handles dgjPrevendedor.EditingCell

        If (e.Column.Index = dgjPrevendedor.RootTable.Columns("value").Index) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub
    Private Sub P_PrArmarGrillas()
        P_prArmarGrillaBusqueda()
        P_prArmarGrillaRepartidor()
        P_prArmarGrillaPrevendedor()
    End Sub

    Private Sub P_prArmarGrillaBusqueda()
        DtBusqueda = New DataTable
        If (IsDBNull(_DtZonas) Or IsNothing(_DtZonas)) Then
            _DtZonas = L_prListarZonasAlternativo()
            DtBusqueda = _DtZonas.Copy
        Else
            DtBusqueda = _DtZonas.Copy
        End If
        DgjBusqueda.BoundMode = Janus.Data.BoundMode.Bound
        DgjBusqueda.DataSource = DtBusqueda
        DgjBusqueda.RetrieveStructure()

        'a.lanumi AS numi, c1.cedesc AS nzona,Clientes
        With DgjBusqueda.RootTable.Columns("numi")
            .Caption = "Código"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With

        With DgjBusqueda.RootTable.Columns("nzona")
            .Caption = "Zona"
            .Width = 300
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .WordWrap = True
        End With

        With DgjBusqueda.RootTable.Columns("Clientes")
            .Caption = "Clientes"
            .Width = 60
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With


        'Habilitar Filtradores
        With DgjBusqueda
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
            .ColumnAutoSizeMode = ColumnAutoSizeMode.AllCellsAndHeader
        End With
    End Sub

    Private Sub P_prArmarGrillaRepartidor()
        Dim dt As New DataTable

        If (IsDBNull(_DtRepartidores) Or IsNothing(_DtRepartidores)) Then
            _DtRepartidores = L_prListarZonasRepartidor()
            dt = _DtRepartidores.Copy

        Else
            dt = _DtRepartidores.Copy
        End If

        dgjRepartidor.BoundMode = Janus.Data.BoundMode.Bound
        dgjRepartidor.DataSource = dt
        dgjRepartidor.RetrieveStructure()

        'dar formato a las columnas cbnumi ,cbdesc ,cast(0 as bit) as value
        With dgjRepartidor.RootTable.Columns("value")
            .Caption = "Asignado"
            .Width = 50

            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With
        With dgjRepartidor.RootTable.Columns("cbnumi")
            .Visible = False
        End With
        With dgjRepartidor.RootTable.Columns("cbdesc")
            .Caption = "Nombre Repartidor"
            .Width = 350

            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .WordWrap = True
        End With

        'Habilitar Filtradores
        With dgjRepartidor
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.MultipleSelection
            .AlternatingColors = True

        End With
    End Sub

    Private Sub P_prArmarGrillaPrevendedor()
        Dim dt As New DataTable
        dt = L_prListarZonasVendedor()

        dgjPrevendedor.BoundMode = Janus.Data.BoundMode.Bound
        dgjPrevendedor.DataSource = dt
        dgjPrevendedor.RetrieveStructure()

        'dar formato a las columnas
        'dar formato a las columnas cbnumi ,cbdesc ,cast(0 as bit) as value
        With dgjPrevendedor.RootTable.Columns("value")
            .Caption = "Asignado"
            .Width = 50
            '.ColumnType = ColumnType.CheckBox
            '.CellStyle.BackColor = Color.DarkBlue

            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With
        With dgjPrevendedor.RootTable.Columns("cbnumi")
            .Visible = False
        End With
        With dgjPrevendedor.RootTable.Columns("cbdesc")
            .Caption = "Nombre Vendedor"
            .Width = 350
            .WordWrap = True
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With

        'Habilitar Filtradores
        With dgjPrevendedor
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.MultipleSelection
            .AlternatingColors = True
        End With
    End Sub

    Private Sub F02ZonaAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
        btnActual.PerformClick()

    End Sub

    Private Sub DgjBusqueda_SelectionChanged(sender As Object, e As EventArgs) Handles DgjBusqueda.SelectionChanged
        If (DgjBusqueda.Row > -1) Then
            P_prLlenarDatos(DgjBusqueda.Row)
        End If
    End Sub
    Public Function _ExisteRepartidor(zona As Integer, repartidor As Integer)

        For i As Integer = 0 To _DtDetalleZonas.Rows.Count - 1 Step 1

            If ((_DtDetalleZonas.Rows(i).Item("lcnumi") = zona) And (_DtDetalleZonas.Rows(i).Item("lccbnumi") = repartidor) And (_DtDetalleZonas.Rows(i).Item("estado") >= 0)) Then

                Return i
            End If
        Next
        Return -1
    End Function
    Private Sub dgjRepartidor_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles dgjRepartidor.CellValueChanged
        If (e.Column.Index = dgjRepartidor.RootTable.Columns("value").Index) Then
            If (dgjRepartidor.GetValue("value") = True) Then
                Dim numi As Integer = dgjRepartidor.GetValue("cbnumi")
                Dim posicion As Integer = _ExisteRepartidor(TbCodigo.Text, numi)
                If (posicion >= 0) Then
                    Dim estado = _DtDetalleZonas.Rows(posicion).Item("estado")

                    If (estado = -1) Then
                        _DtDetalleZonas.Rows(posicion).Item("estado") = 1

                    End If
                    If (estado = -2) Then
                        _DtDetalleZonas.Rows(posicion).Item("estado") = 0
                    End If

                Else
                    _DtDetalleZonas.Rows.Add(TbCodigo.Text, numi, 0)

                End If
            Else
                Dim numi As Integer = dgjRepartidor.GetValue("cbnumi")
                Dim posicion As Integer = _ExisteRepartidor(TbCodigo.Text, numi)
                If (posicion >= 0) Then
                    Dim estado = _DtDetalleZonas.Rows(posicion).Item("estado")
                    If (estado = 1) Then
                        _DtDetalleZonas.Rows(posicion).Item("estado") = -1
                    Else
                        If (estado >= 0) Then
                            _DtDetalleZonas.Rows(posicion).Item("estado") = -2
                        End If
                    End If

                End If

            End If
        End If
    End Sub

    Private Sub dgjPrevendedor_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles dgjPrevendedor.CellValueChanged
        If (e.Column.Index = dgjPrevendedor.RootTable.Columns("value").Index) Then
            If (dgjPrevendedor.GetValue("value") = True) Then
                Dim numi As Integer = dgjPrevendedor.GetValue("cbnumi")
                Dim posicion As Integer = _ExisteRepartidor(TbCodigo.Text, numi)
                If (posicion >= 0) Then
                    Dim estado = _DtDetalleZonas.Rows(posicion).Item("estado")
                    If (estado = -1) Then
                        _DtDetalleZonas.Rows(posicion).Item("estado") = 1
                    End If
                    If (estado = -2) Then
                        _DtDetalleZonas.Rows(posicion).Item("estado") = 0
                    End If

                Else
                    _DtDetalleZonas.Rows.Add(TbCodigo.Text, numi, 0)

                End If
            Else
                Dim numi As Integer = dgjPrevendedor.GetValue("cbnumi")
                Dim posicion As Integer = _ExisteRepartidor(TbCodigo.Text, numi)
                If (posicion >= 0) Then
                    Dim estado = _DtDetalleZonas.Rows(posicion).Item("estado")
                    If (estado = 1) Then
                        _DtDetalleZonas.Rows(posicion).Item("estado") = -1
                    Else
                        If (estado >= 0) Then
                            _DtDetalleZonas.Rows(posicion).Item("estado") = -2
                        End If
                    End If

                End If

            End If
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim res As Boolean
        If (Modulo = -1) Then
            res = GrabarDetalleZona(_DtDetalleZonas)

        Else
            res = GrabarDetalleZonaModulo(_DtDetalleZonas, Modulo)
        End If





        If (res) Then
            If (Modulo = -1) Then
                _DtDetalleZonas = L_prListarZonas()
            Else

                _DtDetalleZonas = L_prListarZonasDetalle(Modulo)
            End If

            P_prArmarGrillaBusqueda()
            DgjBusqueda.Row = 0

            DgjBusqueda.Enabled = True
            ToastNotification.Show(Me, "Codigo de zona ".ToUpper + TbCodigo.Text + " Modificado con Exito.".ToUpper,
                           My.Resources.GRABACION_EXITOSA,
                           InDuracion * 1000,
                           eToastGlowColor.Green,
                           eToastPosition.TopCenter)
        Else
            ToastNotification.Show(Me, "No se pudo modificar Zonas ".ToUpper + TbCodigo.Text + ", intente nuevamente.".ToUpper,
                               My.Resources.WARNING,
                               InDuracion * 1000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
        '_modulo.Select()
        '_tab.Close()
    End Sub
    Public Sub SetearColorTable(Btn As ButtonX, bandera As Boolean)
        If (bandera = True) Then
            Btn.ColorTable = eButtonColor.BlueOrb
        Else
            Btn.ColorTable = eButtonColor.Office2007WithBackground
        End If
    End Sub
    Public Sub SetearTodos()
        SetearColorTable(btnActual, False)
        SetearColorTable(btn01, False)
        SetearColorTable(btn02, False)
        SetearColorTable(btn03, False)
        SetearColorTable(btn04, False)
        SetearColorTable(btn05, False)
        SetearColorTable(btn06, False)
        SetearColorTable(btn07, False)
        SetearColorTable(btn08, False)
        SetearColorTable(btn09, False)
        SetearColorTable(btn010, False)
    End Sub
    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles btnActual.Click, btn01.Click, btn02.Click, btn03.Click, btn04.Click, btn05.Click, btn06.Click, btn07.Click, btn08.Click, btn09.Click, btn010.Click


        Dim btn As ButtonX = sender
        Modulo = btn.Tag
        SetearTodos()
        SetearColorTable(btn, True)
        If (Modulo = -1) Then
            _DtDetalleZonas = L_prListarZonas()
            btnSetup.Visible = False
        Else
            btnSetup.Visible = True
            _DtDetalleZonas = L_prListarZonasDetalle(Modulo)
        End If







            P_PrArmarGrillas()


        P_prLlenarDatos(0)
    End Sub

    Private Sub ButtonX3_Click_1(sender As Object, e As EventArgs) Handles btnSetup.Click
        Dim res As Boolean

        res = GrabarDetalleZona(_DtDetalleZonas)


            GrabarDetalleZonaModulo(_DtDetalleZonas, Modulo)

            If (res) Then
            If (Modulo = -1) Then
                _DtDetalleZonas = L_prListarZonas()
            Else

                _DtDetalleZonas = L_prListarZonasDetalle(Modulo)
            End If

            P_prArmarGrillaBusqueda()
            DgjBusqueda.Row = 0

            DgjBusqueda.Enabled = True
            ToastNotification.Show(Me, "La Configuracion Fue Asignada a la Asignación Principal del Sistema".ToUpper,
                           My.Resources.GRABACION_EXITOSA,
                           InDuracion * 1000,
                           eToastGlowColor.Green,
                           eToastPosition.TopCenter)
        Else
            ToastNotification.Show(Me, "No se pudo Asignar A la configuración Principal".ToUpper,
                               My.Resources.WARNING,
                               InDuracion * 1000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)
        End If
    End Sub



#End Region

End Class