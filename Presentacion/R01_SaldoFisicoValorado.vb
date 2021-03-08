Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class R01_SaldoFisicoValorado

#Region "Variables Globales"

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

#End Region

#Region "Eventos"
    Dim _Inter As Integer = 0
    Private Sub My_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        P_prCargarReporte()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Me.Close()
        _modulo.Select()
        '_tab.Close()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_prInicio()
        'Abrir conexion dsds
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If
        P_prArmarComboCatCliente()
        Me.Text = "S A L D O   F Í S I C O   V A L O R A D O".ToUpper
        'Me.WindowState = FormWindowState.Maximized
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _prCargarComboLibreriaDeposito(cbAlmacen)
    End Sub
    Private Sub P_prArmarComboCatCliente()

        Dim Dt As New DataTable
        Dt = L_CategoriaPrecioGeneral()
        With cbCategoria.DropDownList
            .Columns.Add(Dt.Columns(0).ToString).Width = 50
            .Columns(0).Caption = "Código"

            .Columns.Add(Dt.Columns(1).ToString).Width = 70
            .Columns(1).Caption = "Abreviatura"

            .Columns.Add(Dt.Columns(2).ToString).Width = 120
            .Columns(2).Caption = "Descripción"
        End With

        cbCategoria.ValueMember = Dt.Columns(0).ToString
        cbCategoria.DisplayMember = Dt.Columns(2).ToString
        cbCategoria.DataSource = Dt
        cbCategoria.Refresh()
        cbCategoria.SelectedIndex = 0
    End Sub
    Private Sub P_prCargarReporte()
        Dim _dt As New DataTable
        If swTipo.Value Then
            Dim objrep As New R_SaldosFisicoValorado()

            If (cbAlmacen.Value >= 0) Then

                _dt = L_VistaSaldoFisicoValorado("cenum=0 AND chcatcl=" + cbCategoria.Value.ToString() + " and iaalm=" + Str(cbAlmacen.Value))
                objrep.SetDataSource(_dt)
                objrep.SetParameterValue("TipoPrecio", cbCategoria.Text)
                MCrReporte.ReportSource = objrep
            Else
                _dt = L_VistaSaldoFisicoValorado("cenum=0 AND chcatcl=" + cbCategoria.Value.ToString())
                objrep.SetDataSource(_dt)
                objrep.SetParameterValue("TipoPrecio", cbCategoria.Text)
                MCrReporte.ReportSource = objrep
            End If



        Else
            Dim objrep As New R_SaldosFisicoValoradoSinAgrupacion()
            If (cbAlmacen.Value >= 0) Then

                _dt = L_VistaSaldoFisicoValorado("cenum=0 AND chcatcl=" + cbCategoria.Value.ToString() + " and iaalm=" + Str(cbAlmacen.Value))
                objrep.SetDataSource(_dt)
                objrep.SetParameterValue("TipoPrecio", cbCategoria.Text)
                MCrReporte.ReportSource = objrep
            Else
                _dt = L_VistaSaldoFisicoValorado("cenum=0 AND chcatcl=" + cbCategoria.Value.ToString())
                objrep.SetDataSource(_dt)
                objrep.SetParameterValue("TipoPrecio", cbCategoria.Text)
                MCrReporte.ReportSource = objrep
            End If



        End If
    End Sub

#End Region
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Inter = _Inter + 1
        If _Inter = 1 Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
        'Me.Opacity = 100
        'Timer1.Enabled = False
    End Sub
    Private Sub _prCargarComboLibreriaDeposito(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnMovimientoListarSucursales()
        dt.Rows.Add(-1, "Todos")
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

        mCombo.Value = -1
    End Sub
End Class