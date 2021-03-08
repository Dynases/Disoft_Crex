<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F01_MonitoreoPedido
    Inherits Modelo.ModeloF01_ca

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CbPersonal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F01_MonitoreoPedido))
        Me.TableLayoutPanelPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelExTrakingRepartidor = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GrRecorrido = New Janus.Windows.GridEX.GridEX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanelVendedores = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Gr_vendedores = New Janus.Windows.GridEX.GridEX()
        Me.Ven = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanelRepartidores = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.grRepartidores = New Janus.Windows.GridEX.GridEX()
        Me.Rep = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.GroupPanelTrak = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelExTraking = New DevComponents.DotNetBar.PanelEx()
        Me.SwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Sw_Vendedor = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Sw_Repartidor = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.J_Cb_Ciudad = New System.Windows.Forms.ComboBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.tbTracking = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.GroupPanelGeoreferencia = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.Btn_ZoomMenos = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_ZoomMas = New DevComponents.DotNetBar.ButtonX()
        Me.GM_Mapa = New GMap.NET.WindowsForms.GMapControl()
        Me.TimerRuta = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CbPersonal = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSuperTabControlPrincipal.SuspendLayout()
        Me.MSuperTabControlPanelRegistro.SuspendLayout()
        Me.MPnSuperior.SuspendLayout()
        Me.MPnInferior.SuspendLayout()
        Me.MPanelToolBarUsuario.SuspendLayout()
        Me.MPanelToolBarNavegacion.SuspendLayout()
        Me.MPanelToolBarAccion.SuspendLayout()
        Me.MPanelToolBarImprimir.SuspendLayout()
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPnUsuario.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelPrincipal.SuspendLayout()
        Me.PanelExTrakingRepartidor.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.GrRecorrido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        Me.GroupPanelVendedores.SuspendLayout()
        CType(Me.Gr_vendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupPanelRepartidores.SuspendLayout()
        CType(Me.grRepartidores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelTrak.SuspendLayout()
        Me.PanelExTraking.SuspendLayout()
        Me.GroupPanelGeoreferencia.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        CType(Me.CbPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSuperTabControlPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.MSuperTabControlPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.MSuperTabControlPrincipal.ControlBox.MenuBox.Name = ""
        Me.MSuperTabControlPrincipal.ControlBox.Name = ""
        Me.MSuperTabControlPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MSuperTabControlPrincipal.ControlBox.MenuBox, Me.MSuperTabControlPrincipal.ControlBox.CloseBox})
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.MSuperTabControlPanelRegistro, 0)
        '
        'MSuperTabControlPanelRegistro
        '
        Me.MSuperTabControlPanelRegistro.Controls.Add(Me.TableLayoutPanelPrincipal)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.MPnUsuario, 0)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.TableLayoutPanelPrincipal, 0)
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
        Me.MPnInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnInferior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.MPnInferior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.MPnInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnInferior.Style.GradientAngle = 90
        '
        'MTbUsuario
        '
        Me.MTbUsuario.Margin = New System.Windows.Forms.Padding(5)
        Me.MTbUsuario.ReadOnly = True
        Me.MTbUsuario.Size = New System.Drawing.Size(179, 38)
        Me.MTbUsuario.Text = "DEFAULT"
        '
        'MBtSalir
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
        'MLbPaginacion
        '
        '
        '
        '
        Me.MLbPaginacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MRlAccion.Margin = New System.Windows.Forms.Padding(5)
        Me.MRlAccion.Size = New System.Drawing.Size(733, 74)
        '
        'TableLayoutPanelPrincipal
        '
        Me.TableLayoutPanelPrincipal.ColumnCount = 2
        Me.TableLayoutPanelPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanelPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanelPrincipal.Controls.Add(Me.PanelExTrakingRepartidor, 0, 0)
        Me.TableLayoutPanelPrincipal.Controls.Add(Me.GroupPanelGeoreferencia, 1, 0)
        Me.TableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanelPrincipal.Name = "TableLayoutPanelPrincipal"
        Me.TableLayoutPanelPrincipal.RowCount = 1
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPrincipal.Size = New System.Drawing.Size(1270, 560)
        Me.TableLayoutPanelPrincipal.TabIndex = 29
        '
        'PanelExTrakingRepartidor
        '
        Me.PanelExTrakingRepartidor.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelExTrakingRepartidor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelExTrakingRepartidor.Controls.Add(Me.GroupPanel1)
        Me.PanelExTrakingRepartidor.Controls.Add(Me.GroupPanelTrak)
        Me.PanelExTrakingRepartidor.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelExTrakingRepartidor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelExTrakingRepartidor.Location = New System.Drawing.Point(4, 4)
        Me.PanelExTrakingRepartidor.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelExTrakingRepartidor.Name = "PanelExTrakingRepartidor"
        Me.PanelExTrakingRepartidor.Size = New System.Drawing.Size(373, 552)
        Me.PanelExTrakingRepartidor.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelExTrakingRepartidor.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelExTrakingRepartidor.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelExTrakingRepartidor.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelExTrakingRepartidor.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelExTrakingRepartidor.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelExTrakingRepartidor.Style.GradientAngle = 90
        Me.PanelExTrakingRepartidor.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TabControl1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 215)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(373, 337)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 19
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.Transparent
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel3)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(367, 331)
        Me.TabControl1.TabIndex = 1
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.Rep)
        Me.TabControl1.Tabs.Add(Me.Ven)
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.GrRecorrido)
        Me.TabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(367, 305)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 9
        Me.TabControlPanel3.TabItem = Me.TabItem1
        '
        'GrRecorrido
        '
        Me.GrRecorrido.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.GrRecorrido.BackColor = System.Drawing.Color.Linen
        Me.GrRecorrido.BorderStyle = Janus.Windows.GridEX.BorderStyle.Sunken
        Me.GrRecorrido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrRecorrido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrRecorrido.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrRecorrido.Location = New System.Drawing.Point(1, 1)
        Me.GrRecorrido.Margin = New System.Windows.Forms.Padding(4)
        Me.GrRecorrido.Name = "GrRecorrido"
        Me.GrRecorrido.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GrRecorrido.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.GrRecorrido.Size = New System.Drawing.Size(365, 303)
        Me.GrRecorrido.TabIndex = 1
        Me.GrRecorrido.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel3
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Recorrido"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.GroupPanelVendedores)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(367, 305)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 5
        Me.TabControlPanel2.TabItem = Me.Ven
        '
        'GroupPanelVendedores
        '
        Me.GroupPanelVendedores.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelVendedores.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelVendedores.Controls.Add(Me.Gr_vendedores)
        Me.GroupPanelVendedores.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelVendedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelVendedores.Location = New System.Drawing.Point(1, 1)
        Me.GroupPanelVendedores.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanelVendedores.Name = "GroupPanelVendedores"
        Me.GroupPanelVendedores.Size = New System.Drawing.Size(365, 303)
        '
        '
        '
        Me.GroupPanelVendedores.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelVendedores.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelVendedores.Style.BackColorGradientAngle = 90
        Me.GroupPanelVendedores.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelVendedores.Style.BorderBottomWidth = 1
        Me.GroupPanelVendedores.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelVendedores.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelVendedores.Style.BorderLeftWidth = 1
        Me.GroupPanelVendedores.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelVendedores.Style.BorderRightWidth = 1
        Me.GroupPanelVendedores.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelVendedores.Style.BorderTopWidth = 1
        Me.GroupPanelVendedores.Style.CornerDiameter = 4
        Me.GroupPanelVendedores.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelVendedores.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelVendedores.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelVendedores.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanelVendedores.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelVendedores.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelVendedores.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelVendedores.TabIndex = 3
        '
        'Gr_vendedores
        '
        Me.Gr_vendedores.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.Gr_vendedores.BackColor = System.Drawing.Color.Linen
        Me.Gr_vendedores.BorderStyle = Janus.Windows.GridEX.BorderStyle.Sunken
        Me.Gr_vendedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gr_vendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gr_vendedores.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gr_vendedores.Location = New System.Drawing.Point(0, 0)
        Me.Gr_vendedores.Margin = New System.Windows.Forms.Padding(4)
        Me.Gr_vendedores.Name = "Gr_vendedores"
        Me.Gr_vendedores.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.Gr_vendedores.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.Gr_vendedores.Size = New System.Drawing.Size(359, 297)
        Me.Gr_vendedores.TabIndex = 0
        Me.Gr_vendedores.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Ven
        '
        Me.Ven.AttachedControl = Me.TabControlPanel2
        Me.Ven.Name = "Ven"
        Me.Ven.Text = "Vendedores"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.GroupPanelRepartidores)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(367, 305)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.Rep
        '
        'GroupPanelRepartidores
        '
        Me.GroupPanelRepartidores.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelRepartidores.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelRepartidores.Controls.Add(Me.grRepartidores)
        Me.GroupPanelRepartidores.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelRepartidores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelRepartidores.Location = New System.Drawing.Point(1, 1)
        Me.GroupPanelRepartidores.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanelRepartidores.Name = "GroupPanelRepartidores"
        Me.GroupPanelRepartidores.Size = New System.Drawing.Size(365, 303)
        '
        '
        '
        Me.GroupPanelRepartidores.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelRepartidores.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelRepartidores.Style.BackColorGradientAngle = 90
        Me.GroupPanelRepartidores.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelRepartidores.Style.BorderBottomWidth = 1
        Me.GroupPanelRepartidores.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelRepartidores.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelRepartidores.Style.BorderLeftWidth = 1
        Me.GroupPanelRepartidores.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelRepartidores.Style.BorderRightWidth = 1
        Me.GroupPanelRepartidores.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelRepartidores.Style.BorderTopWidth = 1
        Me.GroupPanelRepartidores.Style.CornerDiameter = 4
        Me.GroupPanelRepartidores.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelRepartidores.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelRepartidores.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelRepartidores.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanelRepartidores.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelRepartidores.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelRepartidores.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelRepartidores.TabIndex = 2
        '
        'grRepartidores
        '
        Me.grRepartidores.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grRepartidores.BackColor = System.Drawing.Color.Linen
        Me.grRepartidores.BorderStyle = Janus.Windows.GridEX.BorderStyle.Sunken
        Me.grRepartidores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grRepartidores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grRepartidores.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grRepartidores.Location = New System.Drawing.Point(0, 0)
        Me.grRepartidores.Margin = New System.Windows.Forms.Padding(4)
        Me.grRepartidores.Name = "grRepartidores"
        Me.grRepartidores.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grRepartidores.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grRepartidores.Size = New System.Drawing.Size(359, 297)
        Me.grRepartidores.TabIndex = 0
        Me.grRepartidores.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Rep
        '
        Me.Rep.AttachedControl = Me.TabControlPanel1
        Me.Rep.Name = "Rep"
        Me.Rep.Text = "Repartidores"
        '
        'GroupPanelTrak
        '
        Me.GroupPanelTrak.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelTrak.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelTrak.Controls.Add(Me.PanelExTraking)
        Me.GroupPanelTrak.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelTrak.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanelTrak.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelTrak.Name = "GroupPanelTrak"
        Me.GroupPanelTrak.Size = New System.Drawing.Size(373, 215)
        '
        '
        '
        Me.GroupPanelTrak.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelTrak.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelTrak.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelTrak.TabIndex = 10
        '
        'PanelExTraking
        '
        Me.PanelExTraking.AutoScroll = True
        Me.PanelExTraking.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelExTraking.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelExTraking.Controls.Add(Me.CbPersonal)
        Me.PanelExTraking.Controls.Add(Me.SwitchButton1)
        Me.PanelExTraking.Controls.Add(Me.LabelX6)
        Me.PanelExTraking.Controls.Add(Me.DtFecha)
        Me.PanelExTraking.Controls.Add(Me.LabelX5)
        Me.PanelExTraking.Controls.Add(Me.Sw_Vendedor)
        Me.PanelExTraking.Controls.Add(Me.Sw_Repartidor)
        Me.PanelExTraking.Controls.Add(Me.LabelX4)
        Me.PanelExTraking.Controls.Add(Me.LabelX3)
        Me.PanelExTraking.Controls.Add(Me.J_Cb_Ciudad)
        Me.PanelExTraking.Controls.Add(Me.LabelX1)
        Me.PanelExTraking.Controls.Add(Me.LabelX2)
        Me.PanelExTraking.Controls.Add(Me.tbTracking)
        Me.PanelExTraking.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelExTraking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelExTraking.Location = New System.Drawing.Point(0, 0)
        Me.PanelExTraking.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelExTraking.Name = "PanelExTraking"
        Me.PanelExTraking.Size = New System.Drawing.Size(373, 215)
        Me.PanelExTraking.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelExTraking.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelExTraking.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelExTraking.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelExTraking.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelExTraking.Style.GradientAngle = 90
        Me.PanelExTraking.TabIndex = 0
        '
        'SwitchButton1
        '
        '
        '
        '
        Me.SwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton1.Enabled = False
        Me.SwitchButton1.Location = New System.Drawing.Point(112, 176)
        Me.SwitchButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SwitchButton1.Name = "SwitchButton1"
        Me.SwitchButton1.OffText = "NO"
        Me.SwitchButton1.OnText = "SI"
        Me.SwitchButton1.Size = New System.Drawing.Size(104, 27)
        Me.SwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton1.TabIndex = 17
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(4, 176)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(100, 28)
        Me.LabelX6.TabIndex = 16
        Me.LabelX6.Text = "RECORRIDO:"
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(112, 140)
        Me.DtFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DtFecha.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(104, 22)
        Me.DtFecha.TabIndex = 15
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(4, 140)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(100, 28)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "FECHA:"
        '
        'Sw_Vendedor
        '
        '
        '
        '
        Me.Sw_Vendedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Sw_Vendedor.Enabled = False
        Me.Sw_Vendedor.Location = New System.Drawing.Point(112, 104)
        Me.Sw_Vendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.Sw_Vendedor.Name = "Sw_Vendedor"
        Me.Sw_Vendedor.OffText = "UNO"
        Me.Sw_Vendedor.OnText = "TODOS"
        Me.Sw_Vendedor.Size = New System.Drawing.Size(104, 27)
        Me.Sw_Vendedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Sw_Vendedor.TabIndex = 9
        '
        'Sw_Repartidor
        '
        '
        '
        '
        Me.Sw_Repartidor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Sw_Repartidor.Enabled = False
        Me.Sw_Repartidor.Location = New System.Drawing.Point(112, 72)
        Me.Sw_Repartidor.Margin = New System.Windows.Forms.Padding(4)
        Me.Sw_Repartidor.Name = "Sw_Repartidor"
        Me.Sw_Repartidor.OffText = "UNO"
        Me.Sw_Repartidor.OnText = "TODOS"
        Me.Sw_Repartidor.Size = New System.Drawing.Size(104, 27)
        Me.Sw_Repartidor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Sw_Repartidor.TabIndex = 8
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(4, 104)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(100, 28)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "VENDEDOR:"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(4, 74)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(100, 28)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "REPARTIDOR:"
        '
        'J_Cb_Ciudad
        '
        Me.J_Cb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.J_Cb_Ciudad.FormattingEnabled = True
        Me.J_Cb_Ciudad.Location = New System.Drawing.Point(112, 41)
        Me.J_Cb_Ciudad.Margin = New System.Windows.Forms.Padding(4)
        Me.J_Cb_Ciudad.Name = "J_Cb_Ciudad"
        Me.J_Cb_Ciudad.Size = New System.Drawing.Size(239, 24)
        Me.J_Cb_Ciudad.TabIndex = 5
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(4, 5)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(100, 28)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "TRACKING:"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(4, 41)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(100, 28)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "CIUDAD:"
        '
        'tbTracking
        '
        '
        '
        '
        Me.tbTracking.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTracking.Location = New System.Drawing.Point(112, 6)
        Me.tbTracking.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTracking.Name = "tbTracking"
        Me.tbTracking.Size = New System.Drawing.Size(88, 27)
        Me.tbTracking.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbTracking.TabIndex = 1
        '
        'GroupPanelGeoreferencia
        '
        Me.GroupPanelGeoreferencia.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelGeoreferencia.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelGeoreferencia.Controls.Add(Me.PanelEx6)
        Me.GroupPanelGeoreferencia.Controls.Add(Me.GM_Mapa)
        Me.GroupPanelGeoreferencia.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelGeoreferencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelGeoreferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelGeoreferencia.Location = New System.Drawing.Point(385, 4)
        Me.GroupPanelGeoreferencia.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanelGeoreferencia.Name = "GroupPanelGeoreferencia"
        Me.GroupPanelGeoreferencia.Size = New System.Drawing.Size(881, 552)
        '
        '
        '
        Me.GroupPanelGeoreferencia.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelGeoreferencia.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelGeoreferencia.Style.BackColorGradientAngle = 90
        Me.GroupPanelGeoreferencia.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelGeoreferencia.Style.BorderBottomWidth = 1
        Me.GroupPanelGeoreferencia.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelGeoreferencia.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelGeoreferencia.Style.BorderLeftWidth = 1
        Me.GroupPanelGeoreferencia.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelGeoreferencia.Style.BorderRightWidth = 1
        Me.GroupPanelGeoreferencia.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelGeoreferencia.Style.BorderTopWidth = 1
        Me.GroupPanelGeoreferencia.Style.CornerDiameter = 4
        Me.GroupPanelGeoreferencia.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelGeoreferencia.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelGeoreferencia.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelGeoreferencia.Style.TextColor = System.Drawing.Color.AliceBlue
        Me.GroupPanelGeoreferencia.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelGeoreferencia.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelGeoreferencia.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelGeoreferencia.TabIndex = 2
        Me.GroupPanelGeoreferencia.Text = "UBICACIÓN"
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.Btn_ZoomMenos)
        Me.PanelEx6.Controls.Add(Me.Btn_ZoomMas)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Location = New System.Drawing.Point(4, 6)
        Me.PanelEx6.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(61, 107)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 5
        '
        'Btn_ZoomMenos
        '
        Me.Btn_ZoomMenos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_ZoomMenos.BackgroundImage = Global.Presentacion.My.Resources.Resources.ZOOM_MENOS_ORI
        Me.Btn_ZoomMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_ZoomMenos.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.Btn_ZoomMenos.Image = Global.Presentacion.My.Resources.Resources.ZOOM_MENOS_ORI
        Me.Btn_ZoomMenos.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.Btn_ZoomMenos.Location = New System.Drawing.Point(4, 55)
        Me.Btn_ZoomMenos.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_ZoomMenos.Name = "Btn_ZoomMenos"
        Me.Btn_ZoomMenos.Size = New System.Drawing.Size(53, 49)
        Me.Btn_ZoomMenos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_ZoomMenos.TabIndex = 1
        '
        'Btn_ZoomMas
        '
        Me.Btn_ZoomMas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_ZoomMas.BackgroundImage = Global.Presentacion.My.Resources.Resources.ZOOM_MAS_ORI
        Me.Btn_ZoomMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_ZoomMas.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.Btn_ZoomMas.Image = Global.Presentacion.My.Resources.Resources.ZOOM_MAS_ORI
        Me.Btn_ZoomMas.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.Btn_ZoomMas.Location = New System.Drawing.Point(4, 4)
        Me.Btn_ZoomMas.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_ZoomMas.Name = "Btn_ZoomMas"
        Me.Btn_ZoomMas.Size = New System.Drawing.Size(53, 49)
        Me.Btn_ZoomMas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_ZoomMas.TabIndex = 0
        '
        'GM_Mapa
        '
        Me.GM_Mapa.Bearing = 0!
        Me.GM_Mapa.CanDragMap = True
        Me.GM_Mapa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GM_Mapa.EmptyTileColor = System.Drawing.Color.Navy
        Me.GM_Mapa.GrayScaleMode = False
        Me.GM_Mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GM_Mapa.LevelsKeepInMemmory = 5
        Me.GM_Mapa.Location = New System.Drawing.Point(0, 0)
        Me.GM_Mapa.Margin = New System.Windows.Forms.Padding(4)
        Me.GM_Mapa.MarkersEnabled = True
        Me.GM_Mapa.MaxZoom = 2
        Me.GM_Mapa.MinZoom = 2
        Me.GM_Mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.GM_Mapa.Name = "GM_Mapa"
        Me.GM_Mapa.NegativeMode = False
        Me.GM_Mapa.PolygonsEnabled = True
        Me.GM_Mapa.RetryLoadTile = 0
        Me.GM_Mapa.RoutesEnabled = True
        Me.GM_Mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GM_Mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GM_Mapa.ShowTileGridLines = False
        Me.GM_Mapa.Size = New System.Drawing.Size(875, 528)
        Me.GM_Mapa.TabIndex = 1
        Me.GM_Mapa.Zoom = 0R
        '
        'TimerRuta
        '
        Me.TimerRuta.Interval = 10000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'CbPersonal
        '
        Me.CbPersonal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CbPersonal.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.CbPersonal.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.FlatBorderless
        CbPersonal_DesignTimeLayout.LayoutString = resources.GetString("CbPersonal_DesignTimeLayout.LayoutString")
        Me.CbPersonal.DesignTimeLayout = CbPersonal_DesignTimeLayout
        Me.CbPersonal.Enabled = False
        Me.CbPersonal.Location = New System.Drawing.Point(223, 177)
        Me.CbPersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.CbPersonal.Name = "CbPersonal"
        Me.CbPersonal.SelectedIndex = -1
        Me.CbPersonal.SelectedItem = Nothing
        Me.CbPersonal.Size = New System.Drawing.Size(151, 22)
        Me.CbPersonal.TabIndex = 18
        '
        'F01_MonitoreoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 690)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "F01_MonitoreoPedido"
        Me.Opacity = 0.05R
        Me.Text = "F01_MonitoreoPedido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Controls.SetChildIndex(Me.MPnSuperior, 0)
        Me.Controls.SetChildIndex(Me.MPnInferior, 0)
        Me.Controls.SetChildIndex(Me.MSuperTabControlPrincipal, 0)
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSuperTabControlPrincipal.ResumeLayout(False)
        Me.MSuperTabControlPanelRegistro.ResumeLayout(False)
        Me.MPnSuperior.ResumeLayout(False)
        Me.MPnInferior.ResumeLayout(False)
        Me.MPanelToolBarUsuario.ResumeLayout(False)
        Me.MPanelToolBarUsuario.PerformLayout()
        Me.MPanelToolBarNavegacion.ResumeLayout(False)
        Me.MPanelToolBarAccion.ResumeLayout(False)
        Me.MPanelToolBarImprimir.ResumeLayout(False)
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MPnUsuario.ResumeLayout(False)
        Me.MPnUsuario.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelPrincipal.ResumeLayout(False)
        Me.PanelExTrakingRepartidor.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        CType(Me.GrRecorrido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.GroupPanelVendedores.ResumeLayout(False)
        CType(Me.Gr_vendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupPanelRepartidores.ResumeLayout(False)
        CType(Me.grRepartidores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelTrak.ResumeLayout(False)
        Me.PanelExTraking.ResumeLayout(False)
        Me.PanelExTraking.PerformLayout()
        Me.GroupPanelGeoreferencia.ResumeLayout(False)
        Me.PanelEx6.ResumeLayout(False)
        CType(Me.CbPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanelPrincipal As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents J_Cb_Ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbTracking As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanelGeoreferencia As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelExTrakingRepartidor As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelExTraking As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GM_Mapa As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Btn_ZoomMenos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_ZoomMas As DevComponents.DotNetBar.ButtonX
    Public WithEvents TimerRuta As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Rep As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GroupPanelVendedores As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Gr_vendedores As Janus.Windows.GridEX.GridEX
    Friend WithEvents Ven As DevComponents.DotNetBar.TabItem
    Friend WithEvents Sw_Vendedor As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents Sw_Repartidor As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanelRepartidores As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents grRepartidores As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupPanelTrak As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DtFecha As DateTimePicker
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GrRecorrido As Janus.Windows.GridEX.GridEX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents SwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CbPersonal As Janus.Windows.GridEX.EditControls.MultiColumnCombo
End Class
