
Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Class F01_RepZonaVendedores
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

        Me.Text = "REPORTE ZONAS VENDEDORES ".ToUpper
        Me.WindowState = FormWindowState.Maximized
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        P_prArmarCombos()

    End Sub
    Private Sub P_prArmarCombos()



    End Sub







    Private Sub P_prCargarReporte()
        Dim _dt As New DataTable
        Dim title01 As String = ""
        Dim title02 As String = ""
        If (swestado.Value = True) Then
            _dt = L_fnReporteZonasVendedores()
            title01 = "Zonas"
            title02 = "Vendedores"
        Else
            _dt = L_fnReporteVendedoresZonas()
            title01 = "Vendedores"
            title02 = "Zonas"
        End If


        If (_dt.Rows.Count > 0) Then
            Dim objrep As New MAM_ZonasRepartidor()
            objrep.SetDataSource(_dt)

            objrep.SetParameterValue("Usuario", L_Usuario)
            objrep.SetParameterValue("titulo01", title01)
            objrep.SetParameterValue("Titulo02", title02)

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