<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R02_VentaClientePorMes
    Inherits Modelo.ModeloR02

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
        Dim cbMeses_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R02_VentaClientePorMes))
        Me.gpCriterio = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.tbNombreCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbCodigoCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.gpFiltroAM = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cbMeses = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.tbAnho = New DevComponents.Editors.IntegerInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.gpFiltroTipo = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SbFiltroCM = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.dgjPrincipal = New Janus.Windows.GridEX.GridEX()
        Me.geExportar = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
        Me.btExportar = New DevComponents.DotNetBar.ButtonX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MPnSuperior.SuspendLayout()
        Me.MPnInferior.SuspendLayout()
        Me.MPanelToolBarUsuario.SuspendLayout()
        Me.MPanelToolBarAccion.SuspendLayout()
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPnUsuario.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MGpFiltro.SuspendLayout()
        Me.MPnReporte.SuspendLayout()
        Me.gpCriterio.SuspendLayout()
        Me.gpFiltroAM.SuspendLayout()
        CType(Me.cbMeses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAnho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpFiltroTipo.SuspendLayout()
        CType(Me.dgjPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MPnSuperior
        '
        Me.MPnSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnSuperior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.MPnSuperior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.MPnSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnSuperior.Style.GradientAngle = 90
        '
        'MPnInferior
        '
        Me.MPnInferior.Location = New System.Drawing.Point(400, 646)
        Me.MPnInferior.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MPnInferior.Size = New System.Drawing.Size(1182, 44)
        Me.MPnInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnInferior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.MPnInferior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.MPnInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnInferior.Style.GradientAngle = 90
        '
        'MPanelToolBarUsuario
        '
        Me.MPanelToolBarUsuario.Location = New System.Drawing.Point(915, 0)
        Me.MPanelToolBarUsuario.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'MTbUsuario
        '
        Me.MTbUsuario.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MTbUsuario.ReadOnly = True
        Me.MTbUsuario.Size = New System.Drawing.Size(179, 38)
        Me.MTbUsuario.Text = "DEFAULT"
        '
        'MBtSalir
        '
        '
        'MBtGenerar
        '
        '
        'MBubbleBarUsuario
        '
        '
        '
        '
        Me.MBubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.MBubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.MBubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'MGpFiltro
        '
        Me.MGpFiltro.Controls.Add(Me.btExportar)
        Me.MGpFiltro.Controls.Add(Me.gpCriterio)
        Me.MGpFiltro.Controls.Add(Me.gpFiltroAM)
        Me.MGpFiltro.Controls.Add(Me.gpFiltroTipo)
        Me.MGpFiltro.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MGpFiltro.Size = New System.Drawing.Size(400, 604)
        '
        '
        '
        Me.MGpFiltro.Style.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MGpFiltro.Style.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.MGpFiltro.Style.BackColorGradientAngle = 90
        Me.MGpFiltro.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderBottomWidth = 1
        Me.MGpFiltro.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MGpFiltro.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderLeftWidth = 1
        Me.MGpFiltro.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderRightWidth = 1
        Me.MGpFiltro.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderTopWidth = 1
        Me.MGpFiltro.Style.CornerDiameter = 4
        Me.MGpFiltro.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.MGpFiltro.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.MGpFiltro.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MGpFiltro.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.MGpFiltro.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MGpFiltro.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MGpFiltro.Controls.SetChildIndex(Me.gpFiltroTipo, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.gpFiltroAM, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.gpCriterio, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.btExportar, 0)
        '
        'MPnReporte
        '
        Me.MPnReporte.Controls.Add(Me.dgjPrincipal)
        Me.MPnReporte.Padding = New System.Windows.Forms.Padding(2)
        Me.MPnReporte.Size = New System.Drawing.Size(1182, 646)
        Me.MPnReporte.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnReporte.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.MPnReporte.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.MPnReporte.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnReporte.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnReporte.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnReporte.Style.GradientAngle = 90
        '
        'gpCriterio
        '
        Me.gpCriterio.BackColor = System.Drawing.Color.Transparent
        Me.gpCriterio.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpCriterio.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpCriterio.Controls.Add(Me.tbNombreCliente)
        Me.gpCriterio.Controls.Add(Me.tbCodigoCliente)
        Me.gpCriterio.Controls.Add(Me.LabelX3)
        Me.gpCriterio.Controls.Add(Me.LabelX5)
        Me.gpCriterio.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpCriterio.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpCriterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpCriterio.Location = New System.Drawing.Point(0, 174)
        Me.gpCriterio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpCriterio.Name = "gpCriterio"
        Me.gpCriterio.Size = New System.Drawing.Size(394, 103)
        '
        '
        '
        Me.gpCriterio.Style.BackColor = System.Drawing.Color.Transparent
        Me.gpCriterio.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.gpCriterio.Style.BackColorGradientAngle = 90
        Me.gpCriterio.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCriterio.Style.BorderBottomWidth = 1
        Me.gpCriterio.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpCriterio.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCriterio.Style.BorderLeftWidth = 1
        Me.gpCriterio.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCriterio.Style.BorderRightWidth = 1
        Me.gpCriterio.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCriterio.Style.BorderTopWidth = 1
        Me.gpCriterio.Style.CornerDiameter = 4
        Me.gpCriterio.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpCriterio.Style.TextColor = System.Drawing.SystemColors.WindowText
        Me.gpCriterio.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpCriterio.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpCriterio.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpCriterio.TabIndex = 20
        Me.gpCriterio.Text = "CRITERIOS DEL CLIENTE"
        '
        'tbNombreCliente
        '
        '
        '
        '
        Me.tbNombreCliente.Border.Class = "TextBoxBorder"
        Me.tbNombreCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNombreCliente.Location = New System.Drawing.Point(81, 42)
        Me.tbNombreCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNombreCliente.MaxLength = 50
        Me.tbNombreCliente.Name = "tbNombreCliente"
        Me.tbNombreCliente.PreventEnterBeep = True
        Me.tbNombreCliente.Size = New System.Drawing.Size(296, 24)
        Me.tbNombreCliente.TabIndex = 9
        '
        'tbCodigoCliente
        '
        '
        '
        '
        Me.tbCodigoCliente.Border.Class = "TextBoxBorder"
        Me.tbCodigoCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodigoCliente.Location = New System.Drawing.Point(81, 5)
        Me.tbCodigoCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCodigoCliente.MaxLength = 15
        Me.tbCodigoCliente.Name = "tbCodigoCliente"
        Me.tbCodigoCliente.PreventEnterBeep = True
        Me.tbCodigoCliente.Size = New System.Drawing.Size(296, 24)
        Me.tbCodigoCliente.TabIndex = 8
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelX3.Location = New System.Drawing.Point(4, 39)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(69, 28)
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = "Cliente:"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelX5.Location = New System.Drawing.Point(4, 4)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(69, 28)
        Me.LabelX5.TabIndex = 6
        Me.LabelX5.Text = "Código:"
        '
        'gpFiltroAM
        '
        Me.gpFiltroAM.BackColor = System.Drawing.Color.Transparent
        Me.gpFiltroAM.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpFiltroAM.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpFiltroAM.Controls.Add(Me.cbMeses)
        Me.gpFiltroAM.Controls.Add(Me.tbAnho)
        Me.gpFiltroAM.Controls.Add(Me.LabelX2)
        Me.gpFiltroAM.Controls.Add(Me.LabelX1)
        Me.gpFiltroAM.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpFiltroAM.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpFiltroAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpFiltroAM.Location = New System.Drawing.Point(0, 71)
        Me.gpFiltroAM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpFiltroAM.Name = "gpFiltroAM"
        Me.gpFiltroAM.Size = New System.Drawing.Size(394, 103)
        '
        '
        '
        Me.gpFiltroAM.Style.BackColor = System.Drawing.Color.Transparent
        Me.gpFiltroAM.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.gpFiltroAM.Style.BackColorGradientAngle = 90
        Me.gpFiltroAM.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFiltroAM.Style.BorderBottomWidth = 1
        Me.gpFiltroAM.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpFiltroAM.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFiltroAM.Style.BorderLeftWidth = 1
        Me.gpFiltroAM.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFiltroAM.Style.BorderRightWidth = 1
        Me.gpFiltroAM.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFiltroAM.Style.BorderTopWidth = 1
        Me.gpFiltroAM.Style.CornerDiameter = 4
        Me.gpFiltroAM.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpFiltroAM.Style.TextColor = System.Drawing.SystemColors.WindowText
        Me.gpFiltroAM.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpFiltroAM.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpFiltroAM.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpFiltroAM.TabIndex = 19
        Me.gpFiltroAM.Text = "AÑO Y MES"
        '
        'cbMeses
        '
        cbMeses_DesignTimeLayout.LayoutString = resources.GetString("cbMeses_DesignTimeLayout.LayoutString")
        Me.cbMeses.DesignTimeLayout = cbMeses_DesignTimeLayout
        Me.cbMeses.Location = New System.Drawing.Point(81, 42)
        Me.cbMeses.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.SelectedIndex = -1
        Me.cbMeses.SelectedItem = Nothing
        Me.cbMeses.Size = New System.Drawing.Size(296, 24)
        Me.cbMeses.TabIndex = 9
        '
        'tbAnho
        '
        '
        '
        '
        Me.tbAnho.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbAnho.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbAnho.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbAnho.Location = New System.Drawing.Point(81, 6)
        Me.tbAnho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbAnho.MaxValue = 3000
        Me.tbAnho.MinValue = 2000
        Me.tbAnho.Name = "tbAnho"
        Me.tbAnho.Size = New System.Drawing.Size(67, 24)
        Me.tbAnho.TabIndex = 8
        Me.tbAnho.Value = 2000
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelX2.Location = New System.Drawing.Point(4, 39)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(69, 28)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "Mes:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelX1.Location = New System.Drawing.Point(4, 4)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(69, 28)
        Me.LabelX1.TabIndex = 6
        Me.LabelX1.Text = "Año:"
        '
        'gpFiltroTipo
        '
        Me.gpFiltroTipo.BackColor = System.Drawing.Color.Transparent
        Me.gpFiltroTipo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpFiltroTipo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpFiltroTipo.Controls.Add(Me.SbFiltroCM)
        Me.gpFiltroTipo.Controls.Add(Me.LabelX4)
        Me.gpFiltroTipo.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpFiltroTipo.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpFiltroTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpFiltroTipo.Location = New System.Drawing.Point(0, 0)
        Me.gpFiltroTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpFiltroTipo.Name = "gpFiltroTipo"
        Me.gpFiltroTipo.Size = New System.Drawing.Size(394, 71)
        '
        '
        '
        Me.gpFiltroTipo.Style.BackColor = System.Drawing.Color.Transparent
        Me.gpFiltroTipo.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.gpFiltroTipo.Style.BackColorGradientAngle = 90
        Me.gpFiltroTipo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFiltroTipo.Style.BorderBottomWidth = 1
        Me.gpFiltroTipo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpFiltroTipo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFiltroTipo.Style.BorderLeftWidth = 1
        Me.gpFiltroTipo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFiltroTipo.Style.BorderRightWidth = 1
        Me.gpFiltroTipo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFiltroTipo.Style.BorderTopWidth = 1
        Me.gpFiltroTipo.Style.CornerDiameter = 4
        Me.gpFiltroTipo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpFiltroTipo.Style.TextColor = System.Drawing.SystemColors.WindowText
        Me.gpFiltroTipo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpFiltroTipo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpFiltroTipo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpFiltroTipo.TabIndex = 18
        Me.gpFiltroTipo.Text = "TIPO DE REPORTE"
        '
        'SbFiltroCM
        '
        '
        '
        '
        Me.SbFiltroCM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SbFiltroCM.Location = New System.Drawing.Point(100, 5)
        Me.SbFiltroCM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SbFiltroCM.Name = "SbFiltroCM"
        Me.SbFiltroCM.OffText = "CANTIDAD"
        Me.SbFiltroCM.OnText = "MONTO"
        Me.SbFiltroCM.Size = New System.Drawing.Size(133, 27)
        Me.SbFiltroCM.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SbFiltroCM.TabIndex = 13
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelX4.Location = New System.Drawing.Point(8, 4)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(83, 28)
        Me.LabelX4.TabIndex = 12
        Me.LabelX4.Text = "FILTRAR:"
        '
        'dgjPrincipal
        '
        Me.dgjPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjPrincipal.Location = New System.Drawing.Point(2, 2)
        Me.dgjPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgjPrincipal.Name = "dgjPrincipal"
        Me.dgjPrincipal.Size = New System.Drawing.Size(1178, 642)
        Me.dgjPrincipal.TabIndex = 0
        '
        'geExportar
        '
        Me.geExportar.GridEX = Me.dgjPrincipal
        Me.geExportar.SheetName = "Hoja1"
        '
        'btExportar
        '
        Me.btExportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btExportar.Image = Global.Presentacion.My.Resources.Resources.EXCEL
        Me.btExportar.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btExportar.Location = New System.Drawing.Point(0, 286)
        Me.btExportar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btExportar.Name = "btExportar"
        Me.btExportar.Size = New System.Drawing.Size(392, 55)
        Me.btExportar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btExportar.TabIndex = 21
        Me.btExportar.Text = "Exportar a excel"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'R02_VentaClientePorMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 690)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "R02_VentaClientePorMes"
        Me.Opacity = 0.05R
        Me.Text = "R02_VentaClientePorMes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Controls.SetChildIndex(Me.MPnInferior, 0)
        Me.Controls.SetChildIndex(Me.MPnUsuario, 0)
        Me.Controls.SetChildIndex(Me.MPnReporte, 0)
        Me.MPnSuperior.ResumeLayout(False)
        Me.MPnInferior.ResumeLayout(False)
        Me.MPanelToolBarUsuario.ResumeLayout(False)
        Me.MPanelToolBarUsuario.PerformLayout()
        Me.MPanelToolBarAccion.ResumeLayout(False)
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MPnUsuario.ResumeLayout(False)
        Me.MPnUsuario.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MGpFiltro.ResumeLayout(False)
        Me.MPnReporte.ResumeLayout(False)
        Me.gpCriterio.ResumeLayout(False)
        Me.gpFiltroAM.ResumeLayout(False)
        Me.gpFiltroAM.PerformLayout()
        CType(Me.cbMeses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAnho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpFiltroTipo.ResumeLayout(False)
        CType(Me.dgjPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpCriterio As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents tbNombreCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbCodigoCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpFiltroAM As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpFiltroTipo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SbFiltroCM As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbAnho As DevComponents.Editors.IntegerInput
    Friend WithEvents cbMeses As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents dgjPrincipal As Janus.Windows.GridEX.GridEX
    Friend WithEvents geExportar As Janus.Windows.GridEX.Export.GridEXExporter
    Friend WithEvents btExportar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Timer1 As Timer
End Class
