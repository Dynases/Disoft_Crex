<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillingDispatch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillingDispatch))
        Dim cbChoferes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.PanelBase = New System.Windows.Forms.Panel()
        Me.PanelPedido = New System.Windows.Forms.Panel()
        Me.panelFondo = New System.Windows.Forms.Panel()
        Me.dgjPedido = New Janus.Windows.GridEX.GridEX()
        Me.LblSubtitulo = New System.Windows.Forms.Label()
        Me.PanelProducto = New System.Windows.Forms.Panel()
        Me.QrFactura = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.dgjProducto = New Janus.Windows.GridEX.GridEX()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.btnFactura = New DevComponents.DotNetBar.ButtonX()
        Me.lblCantidadPedido = New DevComponents.DotNetBar.LabelX()
        Me.lblPedido = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_FechaHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btReporteDespachoPedido = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_Fecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnNotaVenta = New DevComponents.DotNetBar.ButtonX()
        Me.btReporteDespachoCliente = New DevComponents.DotNetBar.ButtonX()
        Me.btReporteDespachoLinea = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.btVolverDist = New DevComponents.DotNetBar.ButtonX()
        Me.cbChoferes = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBase.SuspendLayout()
        Me.PanelPedido.SuspendLayout()
        Me.panelFondo.SuspendLayout()
        CType(Me.dgjPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProducto.SuspendLayout()
        CType(Me.QrFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgjProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.Tb_FechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbChoferes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBase
        '
        Me.PanelBase.Controls.Add(Me.PanelPedido)
        Me.PanelBase.Controls.Add(Me.PanelProducto)
        Me.PanelBase.Controls.Add(Me.PanelSuperior)
        Me.PanelBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBase.Location = New System.Drawing.Point(0, 0)
        Me.PanelBase.Name = "PanelBase"
        Me.PanelBase.Size = New System.Drawing.Size(1284, 599)
        Me.PanelBase.TabIndex = 0
        '
        'PanelPedido
        '
        Me.PanelPedido.Controls.Add(Me.panelFondo)
        Me.PanelPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPedido.Location = New System.Drawing.Point(0, 60)
        Me.PanelPedido.Name = "PanelPedido"
        Me.PanelPedido.Size = New System.Drawing.Size(1284, 424)
        Me.PanelPedido.TabIndex = 1
        '
        'panelFondo
        '
        Me.panelFondo.Controls.Add(Me.dgjPedido)
        Me.panelFondo.Controls.Add(Me.LblSubtitulo)
        Me.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFondo.Location = New System.Drawing.Point(0, 0)
        Me.panelFondo.Name = "panelFondo"
        Me.panelFondo.Size = New System.Drawing.Size(1284, 424)
        Me.panelFondo.TabIndex = 70
        '
        'dgjPedido
        '
        Me.dgjPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjPedido.Location = New System.Drawing.Point(0, 37)
        Me.dgjPedido.Name = "dgjPedido"
        Me.dgjPedido.Size = New System.Drawing.Size(1284, 387)
        Me.dgjPedido.TabIndex = 2
        '
        'LblSubtitulo
        '
        Me.LblSubtitulo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblSubtitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSubtitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblSubtitulo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtitulo.ForeColor = System.Drawing.Color.Black
        Me.LblSubtitulo.Location = New System.Drawing.Point(0, 0)
        Me.LblSubtitulo.Name = "LblSubtitulo"
        Me.LblSubtitulo.Size = New System.Drawing.Size(1284, 37)
        Me.LblSubtitulo.TabIndex = 69
        Me.LblSubtitulo.Text = "Para generar la consulta, especifique valores para el filtro de búsqueda:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Para g" &
    "enerar notas de venta y volver a distribución debe seleccionar algún registro:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    " "
        Me.LblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelProducto
        '
        Me.PanelProducto.Controls.Add(Me.QrFactura)
        Me.PanelProducto.Controls.Add(Me.dgjProducto)
        Me.PanelProducto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProducto.Location = New System.Drawing.Point(0, 484)
        Me.PanelProducto.Name = "PanelProducto"
        Me.PanelProducto.Size = New System.Drawing.Size(1284, 115)
        Me.PanelProducto.TabIndex = 1
        '
        'QrFactura
        '
        Me.QrFactura.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrFactura.Image = CType(resources.GetObject("QrFactura.Image"), System.Drawing.Image)
        Me.QrFactura.Location = New System.Drawing.Point(694, 5)
        Me.QrFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.QrFactura.Name = "QrFactura"
        Me.QrFactura.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrFactura.Size = New System.Drawing.Size(95, 90)
        Me.QrFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QrFactura.TabIndex = 23
        Me.QrFactura.TabStop = False
        Me.QrFactura.Text = "QrCodeImgControl1"
        Me.QrFactura.Visible = False
        '
        'dgjProducto
        '
        Me.dgjProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjProducto.Location = New System.Drawing.Point(0, 0)
        Me.dgjProducto.Name = "dgjProducto"
        Me.dgjProducto.Size = New System.Drawing.Size(1284, 115)
        Me.dgjProducto.TabIndex = 3
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.cbEstado)
        Me.PanelSuperior.Controls.Add(Me.LabelX4)
        Me.PanelSuperior.Controls.Add(Me.btnFactura)
        Me.PanelSuperior.Controls.Add(Me.lblCantidadPedido)
        Me.PanelSuperior.Controls.Add(Me.lblPedido)
        Me.PanelSuperior.Controls.Add(Me.LabelX3)
        Me.PanelSuperior.Controls.Add(Me.Tb_FechaHasta)
        Me.PanelSuperior.Controls.Add(Me.btReporteDespachoPedido)
        Me.PanelSuperior.Controls.Add(Me.LabelX1)
        Me.PanelSuperior.Controls.Add(Me.Tb_Fecha)
        Me.PanelSuperior.Controls.Add(Me.btnNotaVenta)
        Me.PanelSuperior.Controls.Add(Me.btReporteDespachoCliente)
        Me.PanelSuperior.Controls.Add(Me.btReporteDespachoLinea)
        Me.PanelSuperior.Controls.Add(Me.LabelX2)
        Me.PanelSuperior.Controls.Add(Me.btVolverDist)
        Me.PanelSuperior.Controls.Add(Me.cbChoferes)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1284, 60)
        Me.PanelSuperior.TabIndex = 0
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"DICTADO", "ENTREGADO"})
        Me.cbEstado.Location = New System.Drawing.Point(369, 38)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cbEstado.TabIndex = 243
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(290, 35)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(55, 23)
        Me.LabelX4.TabIndex = 242
        Me.LabelX4.Text = "Estado:"
        '
        'btnFactura
        '
        Me.btnFactura.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFactura.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFactura.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFactura.Image = CType(resources.GetObject("btnFactura.Image"), System.Drawing.Image)
        Me.btnFactura.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnFactura.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnFactura.Location = New System.Drawing.Point(834, 0)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(75, 60)
        Me.btnFactura.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFactura.TabIndex = 240
        Me.btnFactura.Text = "Factura"
        '
        'lblCantidadPedido
        '
        '
        '
        '
        Me.lblCantidadPedido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCantidadPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadPedido.Location = New System.Drawing.Point(83, 34)
        Me.lblCantidadPedido.Name = "lblCantidadPedido"
        Me.lblCantidadPedido.Size = New System.Drawing.Size(77, 23)
        Me.lblCantidadPedido.TabIndex = 239
        '
        'lblPedido
        '
        '
        '
        '
        Me.lblPedido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedido.Location = New System.Drawing.Point(12, 34)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(77, 23)
        Me.lblPedido.TabIndex = 238
        Me.lblPedido.Text = "Total pedido:"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(495, 13)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(74, 23)
        Me.LabelX3.TabIndex = 237
        Me.LabelX3.Text = "Fecha hasta:"
        '
        'Tb_FechaHasta
        '
        '
        '
        '
        Me.Tb_FechaHasta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Tb_FechaHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_FechaHasta.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Tb_FechaHasta.ButtonDropDown.Visible = True
        Me.Tb_FechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_FechaHasta.IsPopupCalendarOpen = False
        Me.Tb_FechaHasta.Location = New System.Drawing.Point(575, 13)
        '
        '
        '
        '
        '
        '
        Me.Tb_FechaHasta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_FechaHasta.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Tb_FechaHasta.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Tb_FechaHasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Tb_FechaHasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Tb_FechaHasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Tb_FechaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Tb_FechaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Tb_FechaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Tb_FechaHasta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_FechaHasta.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.Tb_FechaHasta.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Tb_FechaHasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Tb_FechaHasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Tb_FechaHasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Tb_FechaHasta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_FechaHasta.MonthCalendar.TodayButtonVisible = True
        Me.Tb_FechaHasta.Name = "Tb_FechaHasta"
        Me.Tb_FechaHasta.Size = New System.Drawing.Size(120, 22)
        Me.Tb_FechaHasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Tb_FechaHasta.TabIndex = 236
        '
        'btReporteDespachoPedido
        '
        Me.btReporteDespachoPedido.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btReporteDespachoPedido.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btReporteDespachoPedido.Dock = System.Windows.Forms.DockStyle.Right
        Me.btReporteDespachoPedido.Image = CType(resources.GetObject("btReporteDespachoPedido.Image"), System.Drawing.Image)
        Me.btReporteDespachoPedido.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btReporteDespachoPedido.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btReporteDespachoPedido.Location = New System.Drawing.Point(909, 0)
        Me.btReporteDespachoPedido.Name = "btReporteDespachoPedido"
        Me.btReporteDespachoPedido.Size = New System.Drawing.Size(75, 60)
        Me.btReporteDespachoPedido.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btReporteDespachoPedido.TabIndex = 235
        Me.btReporteDespachoPedido.Text = "Lista de Pedidos"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(290, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(73, 23)
        Me.LabelX1.TabIndex = 233
        Me.LabelX1.Text = "Fecha desde:"
        '
        'Tb_Fecha
        '
        '
        '
        '
        Me.Tb_Fecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Tb_Fecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Tb_Fecha.ButtonDropDown.Visible = True
        Me.Tb_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Fecha.IsPopupCalendarOpen = False
        Me.Tb_Fecha.Location = New System.Drawing.Point(369, 12)
        '
        '
        '
        '
        '
        '
        Me.Tb_Fecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Tb_Fecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.Tb_Fecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.MonthCalendar.TodayButtonVisible = True
        Me.Tb_Fecha.Name = "Tb_Fecha"
        Me.Tb_Fecha.Size = New System.Drawing.Size(120, 22)
        Me.Tb_Fecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Tb_Fecha.TabIndex = 232
        '
        'btnNotaVenta
        '
        Me.btnNotaVenta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNotaVenta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNotaVenta.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNotaVenta.Image = Global.Presentacion.My.Resources.Resources.REPORTE2
        Me.btnNotaVenta.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnNotaVenta.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNotaVenta.Location = New System.Drawing.Point(984, 0)
        Me.btnNotaVenta.Name = "btnNotaVenta"
        Me.btnNotaVenta.Size = New System.Drawing.Size(75, 60)
        Me.btnNotaVenta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNotaVenta.TabIndex = 4
        Me.btnNotaVenta.Text = "Nota de Venta"
        '
        'btReporteDespachoCliente
        '
        Me.btReporteDespachoCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btReporteDespachoCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btReporteDespachoCliente.Dock = System.Windows.Forms.DockStyle.Right
        Me.btReporteDespachoCliente.Image = Global.Presentacion.My.Resources.Resources.PEDI_ULTIMOS_PEDIDOS
        Me.btReporteDespachoCliente.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btReporteDespachoCliente.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btReporteDespachoCliente.Location = New System.Drawing.Point(1059, 0)
        Me.btReporteDespachoCliente.Name = "btReporteDespachoCliente"
        Me.btReporteDespachoCliente.Size = New System.Drawing.Size(75, 60)
        Me.btReporteDespachoCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btReporteDespachoCliente.TabIndex = 6
        Me.btReporteDespachoCliente.Text = "Despacho por cliente"
        '
        'btReporteDespachoLinea
        '
        Me.btReporteDespachoLinea.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btReporteDespachoLinea.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btReporteDespachoLinea.Dock = System.Windows.Forms.DockStyle.Right
        Me.btReporteDespachoLinea.Image = Global.Presentacion.My.Resources.Resources.PEDI_ENTRAGA_PEDIDOS
        Me.btReporteDespachoLinea.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btReporteDespachoLinea.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btReporteDespachoLinea.Location = New System.Drawing.Point(1134, 0)
        Me.btReporteDespachoLinea.Name = "btReporteDespachoLinea"
        Me.btReporteDespachoLinea.Size = New System.Drawing.Size(75, 60)
        Me.btReporteDespachoLinea.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btReporteDespachoLinea.TabIndex = 5
        Me.btReporteDespachoLinea.Text = "Despacho por producto"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 12)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(55, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Choferes:"
        '
        'btVolverDist
        '
        Me.btVolverDist.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVolverDist.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVolverDist.Dock = System.Windows.Forms.DockStyle.Right
        Me.btVolverDist.Image = Global.Presentacion.My.Resources.Resources.volver
        Me.btVolverDist.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btVolverDist.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btVolverDist.Location = New System.Drawing.Point(1209, 0)
        Me.btVolverDist.Name = "btVolverDist"
        Me.btVolverDist.Size = New System.Drawing.Size(75, 60)
        Me.btVolverDist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btVolverDist.TabIndex = 234
        Me.btVolverDist.Text = "Volver a Distribución"
        '
        'cbChoferes
        '
        cbChoferes_DesignTimeLayout.LayoutString = resources.GetString("cbChoferes_DesignTimeLayout.LayoutString")
        Me.cbChoferes.DesignTimeLayout = cbChoferes_DesignTimeLayout
        Me.cbChoferes.Location = New System.Drawing.Point(73, 14)
        Me.cbChoferes.Name = "cbChoferes"
        Me.cbChoferes.SelectedIndex = -1
        Me.cbChoferes.SelectedItem = Nothing
        Me.cbChoferes.Size = New System.Drawing.Size(200, 20)
        Me.cbChoferes.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmBillingDispatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 599)
        Me.Controls.Add(Me.PanelBase)
        Me.Name = "frmBillingDispatch"
        Me.Opacity = 0.05R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DESPACHO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.PanelBase.ResumeLayout(False)
        Me.PanelPedido.ResumeLayout(False)
        Me.panelFondo.ResumeLayout(False)
        CType(Me.dgjPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProducto.ResumeLayout(False)
        CType(Me.QrFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgjProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.Tb_FechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbChoferes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBase As Panel
    Friend WithEvents PanelPedido As Panel
    Friend WithEvents PanelProducto As Panel
    Friend WithEvents dgjPedido As Janus.Windows.GridEX.GridEX
    Friend WithEvents dgjProducto As Janus.Windows.GridEX.GridEX
    Friend WithEvents QrFactura As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents Timer1 As Timer
    Public WithEvents LblSubtitulo As Label
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents lblCantidadPedido As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPedido As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_FechaHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btReporteDespachoPedido As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_Fecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnNotaVenta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btReporteDespachoCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btReporteDespachoLinea As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btVolverDist As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbChoferes As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents panelFondo As Panel
    Friend WithEvents btnFactura As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
End Class
