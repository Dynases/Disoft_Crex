Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class R01_VisitasClientes
#Region "VARIABLES GLOBALES"
    Public _nameButton As String
    Public _tab As SuperTabItem
    Dim titulo As String = ""
    Public _modulo As SideNavItem

#End Region
#Region "METODOS PRIVADOS"
    Public Sub _prIniciarTodo()
        Me.Text = "REPORTE VISITAS A CLIENTES"
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        tbFecha.Value = Now.Date
        P_prArmarComboZona()
    End Sub

    Private Sub P_prArmarComboZona()
        Dim Dt As New DataTable
        Dt = L_GetZonasCPZ().Tables(0)

        With cbZona.DropDownList
            .Columns.Add(Dt.Columns("lanumi").ToString).Width = 50
            .Columns(0).Caption = "Código"

            .Columns.Add(Dt.Columns("Zona").ToString).Width = 150
            .Columns(1).Caption = "Zona"
        End With

        cbZona.ValueMember = Dt.Columns("lanumi").ToString
        CbZona.DisplayMember = Dt.Columns("zona").ToString
        CbZona.DataSource = Dt
        CbZona.Refresh()
    End Sub

    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _dt = L_fnObtenerVisitaClientes(cbZona.Value.ToString, tbFecha.Value.ToString("yyyy/MM/dd"))

        If (_dt.Rows.Count > 0) Then

            Dim objrep As New R_VisitaClientes
            objrep.SetDataSource(_dt)
            Dim fechaI As String = tbFecha.Value.ToString("dd/MM/yyyy")


            objrep.SetParameterValue("Fecha", tbFecha.Value.ToString("dd/MM/yyyy"))
            objrep.SetParameterValue("Zona", cbZona.Text)
            objrep.SetParameterValue("Usuario", L_Usuario)
            MCrReporte.ReportSource = objrep
            MCrReporte.Show()
            MCrReporte.BringToFront()



        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
            MCrReporte.ReportSource = Nothing
        End If
    End Sub

#End Region
#Region "EVENTOS"
    Private Sub R01_VisitasClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Close()
    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        If cbZona.SelectedIndex = -1 Then
            ToastNotification.Show(Me, "seleccione una zona..!!!".ToUpper,
                                     My.Resources.WARNING, 2000,
                                         eToastGlowColor.Blue,
                                         eToastPosition.BottomLeft)
            MCrReporte.ReportSource = Nothing
            Exit Sub
        End If

        _prCargarReporte()
    End Sub
#End Region

End Class