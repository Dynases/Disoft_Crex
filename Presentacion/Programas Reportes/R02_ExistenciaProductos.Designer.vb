<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R02_ExistenciaProductos
    Inherits Modelo.ModeloR01

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim cbDescripcion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R02_ExistenciaProductos))
        Dim cbCategoria_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbMarca_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbAtributo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cbDescripcion = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbCategoria = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.lbgrupo1 = New DevComponents.DotNetBar.LabelX()
        Me.lbgrupo2 = New DevComponents.DotNetBar.LabelX()
        Me.lbgrupo3 = New DevComponents.DotNetBar.LabelX()
        Me.cbProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbMarca = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbAtributo = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.MPnSuperior.SuspendLayout()
        Me.MPnInferior.SuspendLayout()
        Me.MPanelToolBarUsuario.SuspendLayout()
        Me.MPanelToolBarAccion.SuspendLayout()
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPnUsuario.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MGpFiltro.SuspendLayout()
        CType(Me.cbDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAtributo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MPnSuperior
        '
        Me.MPnSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnSuperior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnSuperior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnSuperior.Style.GradientAngle = 90
        '
        'MPnInferior
        '
        Me.MPnInferior.Location = New System.Drawing.Point(0, 656)
        Me.MPnInferior.Size = New System.Drawing.Size(1013, 44)
        Me.MPnInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnInferior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnInferior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnInferior.Style.GradientAngle = 90
        '
        'MPanelToolBarUsuario
        '
        Me.MPanelToolBarUsuario.Location = New System.Drawing.Point(746, 0)
        '
        'MTbUsuario
        '
        Me.MTbUsuario.ReadOnly = True
        Me.MTbUsuario.Text = "DEFAULT"
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
        Me.MGpFiltro.Controls.Add(Me.LabelX2)
        Me.MGpFiltro.Controls.Add(Me.cbDescripcion)
        Me.MGpFiltro.Controls.Add(Me.cbCategoria)
        Me.MGpFiltro.Controls.Add(Me.LabelX3)
        Me.MGpFiltro.Controls.Add(Me.lbgrupo1)
        Me.MGpFiltro.Controls.Add(Me.lbgrupo2)
        Me.MGpFiltro.Controls.Add(Me.lbgrupo3)
        Me.MGpFiltro.Controls.Add(Me.cbProveedor)
        Me.MGpFiltro.Controls.Add(Me.cbMarca)
        Me.MGpFiltro.Controls.Add(Me.cbAtributo)
        Me.MGpFiltro.Size = New System.Drawing.Size(400, 570)
        '
        '
        '
        Me.MGpFiltro.Style.BackColor = System.Drawing.SystemColors.Control
        Me.MGpFiltro.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
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
        Me.MGpFiltro.Controls.SetChildIndex(Me.cbAtributo, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.cbMarca, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.cbProveedor, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.lbgrupo3, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.lbgrupo2, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.lbgrupo1, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.LabelX3, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.cbCategoria, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.cbDescripcion, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.LabelX2, 0)
        '
        'MCrReporte
        '
        Me.MCrReporte.Size = New System.Drawing.Size(613, 656)
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(8, 175)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(117, 28)
        Me.LabelX2.TabIndex = 266
        Me.LabelX2.Text = "Descripción:"
        '
        'cbDescripcion
        '
        cbDescripcion_DesignTimeLayout.LayoutString = resources.GetString("cbDescripcion_DesignTimeLayout.LayoutString")
        Me.cbDescripcion.DesignTimeLayout = cbDescripcion_DesignTimeLayout
        Me.cbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDescripcion.Location = New System.Drawing.Point(136, 175)
        Me.cbDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDescripcion.MaxLength = 40
        Me.cbDescripcion.Name = "cbDescripcion"
        Me.cbDescripcion.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbDescripcion.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbDescripcion.SelectedIndex = -1
        Me.cbDescripcion.SelectedItem = Nothing
        Me.cbDescripcion.Size = New System.Drawing.Size(239, 26)
        Me.cbDescripcion.TabIndex = 265
        Me.cbDescripcion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cbCategoria
        '
        cbCategoria_DesignTimeLayout.LayoutString = resources.GetString("cbCategoria_DesignTimeLayout.LayoutString")
        Me.cbCategoria.DesignTimeLayout = cbCategoria_DesignTimeLayout
        Me.cbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.Location = New System.Drawing.Point(136, 62)
        Me.cbCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCategoria.MaxLength = 40
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbCategoria.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbCategoria.SelectedIndex = -1
        Me.cbCategoria.SelectedItem = Nothing
        Me.cbCategoria.Size = New System.Drawing.Size(239, 26)
        Me.cbCategoria.TabIndex = 264
        Me.cbCategoria.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(8, 62)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX3.Size = New System.Drawing.Size(101, 28)
        Me.LabelX3.TabIndex = 263
        Me.LabelX3.Text = "Categoria:"
        '
        'lbgrupo1
        '
        Me.lbgrupo1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbgrupo1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbgrupo1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgrupo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbgrupo1.Location = New System.Drawing.Point(8, 26)
        Me.lbgrupo1.Margin = New System.Windows.Forms.Padding(4)
        Me.lbgrupo1.Name = "lbgrupo1"
        Me.lbgrupo1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbgrupo1.Size = New System.Drawing.Size(101, 28)
        Me.lbgrupo1.TabIndex = 260
        Me.lbgrupo1.Text = "Proveedor:"
        '
        'lbgrupo2
        '
        Me.lbgrupo2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbgrupo2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbgrupo2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgrupo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbgrupo2.Location = New System.Drawing.Point(8, 101)
        Me.lbgrupo2.Margin = New System.Windows.Forms.Padding(4)
        Me.lbgrupo2.Name = "lbgrupo2"
        Me.lbgrupo2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbgrupo2.Size = New System.Drawing.Size(101, 28)
        Me.lbgrupo2.TabIndex = 261
        Me.lbgrupo2.Text = "Marca:"
        '
        'lbgrupo3
        '
        Me.lbgrupo3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbgrupo3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbgrupo3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgrupo3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbgrupo3.Location = New System.Drawing.Point(8, 139)
        Me.lbgrupo3.Margin = New System.Windows.Forms.Padding(4)
        Me.lbgrupo3.Name = "lbgrupo3"
        Me.lbgrupo3.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbgrupo3.Size = New System.Drawing.Size(101, 28)
        Me.lbgrupo3.TabIndex = 262
        Me.lbgrupo3.Text = "Atributo:"
        '
        'cbProveedor
        '
        Me.cbProveedor.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.cbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cbProveedor_DesignTimeLayout.LayoutString = resources.GetString("cbProveedor_DesignTimeLayout.LayoutString")
        Me.cbProveedor.DesignTimeLayout = cbProveedor_DesignTimeLayout
        Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Location = New System.Drawing.Point(136, 26)
        Me.cbProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.cbProveedor.MaxLength = 40
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbProveedor.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbProveedor.SelectedIndex = -1
        Me.cbProveedor.SelectedItem = Nothing
        Me.cbProveedor.Size = New System.Drawing.Size(239, 26)
        Me.cbProveedor.TabIndex = 257
        Me.cbProveedor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cbMarca
        '
        cbMarca_DesignTimeLayout.LayoutString = resources.GetString("cbMarca_DesignTimeLayout.LayoutString")
        Me.cbMarca.DesignTimeLayout = cbMarca_DesignTimeLayout
        Me.cbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMarca.Location = New System.Drawing.Point(136, 102)
        Me.cbMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMarca.MaxLength = 40
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbMarca.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbMarca.SelectedIndex = -1
        Me.cbMarca.SelectedItem = Nothing
        Me.cbMarca.Size = New System.Drawing.Size(239, 26)
        Me.cbMarca.TabIndex = 258
        Me.cbMarca.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cbAtributo
        '
        cbAtributo_DesignTimeLayout.LayoutString = resources.GetString("cbAtributo_DesignTimeLayout.LayoutString")
        Me.cbAtributo.DesignTimeLayout = cbAtributo_DesignTimeLayout
        Me.cbAtributo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAtributo.Location = New System.Drawing.Point(136, 137)
        Me.cbAtributo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAtributo.MaxLength = 40
        Me.cbAtributo.Name = "cbAtributo"
        Me.cbAtributo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbAtributo.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbAtributo.SelectedIndex = -1
        Me.cbAtributo.SelectedItem = Nothing
        Me.cbAtributo.Size = New System.Drawing.Size(239, 26)
        Me.cbAtributo.TabIndex = 259
        Me.cbAtributo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'R02_ExistenciaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 700)
        Me.Name = "R02_ExistenciaProductos"
        Me.Text = "R02_ExistenciaProductos"
        Me.Controls.SetChildIndex(Me.MPnInferior, 0)
        Me.Controls.SetChildIndex(Me.MPnUsuario, 0)
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
        Me.MGpFiltro.PerformLayout()
        CType(Me.cbDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAtributo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbDescripcion As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbCategoria As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbgrupo1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbgrupo2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbgrupo3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbMarca As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbAtributo As Janus.Windows.GridEX.EditControls.MultiColumnCombo
End Class
