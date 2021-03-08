Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Class R02_ExistenciaProductos

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

        Me.Text = "Reporte Existencia de Productos".ToUpper
        Me.WindowState = FormWindowState.Maximized
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
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



    Private Sub P_prCargarReporte()
        Dim _dt As New DataTable
        _dt = L_fnReporteExistencia(cbProveedor.Value, cbCategoria.Value, cbMarca.Value, cbAtributo.Value, cbDescripcion.Value, Now.Date.ToString("yyyy/MM/dd"))

        If (_dt.Rows.Count > 0) Then
            Dim objrep As New MAM_RepExistenciaProducto()
            objrep.SetDataSource(_dt)
            objrep.SetParameterValue("Proveedor", cbProveedor.Text)
            objrep.SetParameterValue("Categoria", cbCategoria.Text)
            objrep.SetParameterValue("Marca", cbMarca.Text)
            objrep.SetParameterValue("Atributo", cbAtributo.Text)
            objrep.SetParameterValue("Descripcion", cbDescripcion.Text)
            objrep.SetParameterValue("Fecha", Now.Date.ToString("dd/MM/yyyy"))
            objrep.SetParameterValue("Usuario", L_Usuario)
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
End Class