Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Class Parametros
    Dim lparametros As DataTable
    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

    End Sub

    Private Sub Parametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lparametros = L_Parametros()
        'Dim prueba = lparametros.Columns.Item(0).ColumnName
        CargarCiudad()
        CargarDatos()

    End Sub
    Private Sub CargarCiudad()
        Cb_Ciudad.Items.Add("SANTA CRUZ")
        Cb_Ciudad.Items.Add("LA PAZ")
        Cb_Ciudad.Items.Add("COCHABAMBA")
        Cb_Ciudad.Items.Add("ORURO")
        Cb_Ciudad.Items.Add("SUCRE")
        Cb_Ciudad.Items.Add("TARIJA")
        Cb_Ciudad.Items.Add("POTOSI")
        Cb_Ciudad.Items.Add("BENI")
        Cb_Ciudad.Items.Add("PANDO")
    End Sub
    Private Sub CargarDatos()
        Compra.Value = lparametros(0).Item("sycompra")
        Credito.Value = lparametros(0).Item("sycompracred")
        Factura.Value = lparametros(0).Item("sycompraFact")
        Retension.Value = lparametros(0).Item("sycompraReten")
        Consignacion.Value = lparametros(0).Item("sycompraconsig")
        Asiento.Value = lparametros(0).Item("sycompraasiento")
        DescPr1.Value = lparametros(0).Item("sycompradescpr1")
        DescPr2.Value = lparametros(0).Item("sycompradescpr2")
        Familia.Value = lparametros(0).Item("syproductofamilia")
        Pack.Value = lparametros(0).Item("syproductopack")
        Equipo.Value = lparametros(0).Item("syclienteequipo")
        Cb_Ciudad.SelectedIndex = lparametros(0).Item("syciudad")
        Ruta.Value = lparametros(0).Item("syruta")
        TbLineas.Text = lparametros(0).Item("syaplinea")
        swcredito.Value = lparametros(0).Item("sycredito")
        SwMapa.Value = lparametros(0).Item("syvmapa")
        Swmodped.Value = lparametros(0).Item("symodped")
        SwModCli.Value = lparametros(0).Item("symodcli")
        swstocknega.Value = lparametros(0).Item("systocknega")
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        gs_Parametros(0).Item("syaplinea") = TbLineas.Text
        L_Modificar_Parametros(lparametros)
        ToastNotification.Show(Me, "Parametros Grabados con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomRight)
        gs_Parametros = L_Parametros()
    End Sub

    Private Sub Equipo_ValueChanged(sender As Object, e As EventArgs) Handles Equipo.ValueChanged
        lparametros(0).Item("syclienteequipo") = Equipo.Value
    End Sub

    Private Sub Compra_ValueChanged(sender As Object, e As EventArgs) Handles Compra.ValueChanged
        lparametros(0).Item("sycompra") = Compra.Value
    End Sub

    Private Sub Credito_ValueChanged(sender As Object, e As EventArgs) Handles Credito.ValueChanged
        lparametros(0).Item("sycompracred") = Credito.Value
    End Sub

    Private Sub Factura_ValueChanged(sender As Object, e As EventArgs) Handles Factura.ValueChanged
        lparametros(0).Item("sycomprafact") = Factura.Value
    End Sub

    Private Sub Retension_ValueChanged(sender As Object, e As EventArgs) Handles Retension.ValueChanged
        lparametros(0).Item("sycompraReten") = Retension.Value
    End Sub

    Private Sub Consignacion_ValueChanged(sender As Object, e As EventArgs) Handles Consignacion.ValueChanged
        lparametros(0).Item("sycompraconsig") = Consignacion.Value
    End Sub

    Private Sub Asiento_ValueChanged(sender As Object, e As EventArgs) Handles Asiento.ValueChanged
        lparametros(0).Item("sycompraasiento") = Asiento.Value
    End Sub

    Private Sub DescPr1_ValueChanged(sender As Object, e As EventArgs) Handles DescPr1.ValueChanged
        lparametros(0).Item("sycompradescpr1") = DescPr1.Value
    End Sub

    Private Sub DescPr2_ValueChanged(sender As Object, e As EventArgs) Handles DescPr2.ValueChanged
        lparametros(0).Item("sycompradescpr2") = DescPr2.Value
    End Sub

    Private Sub Familia_ValueChanged(sender As Object, e As EventArgs) Handles Familia.ValueChanged
        lparametros(0).Item("syproductofamilia") = Familia.Value
    End Sub

    Private Sub Pack_ValueChanged(sender As Object, e As EventArgs) Handles Pack.ValueChanged
        lparametros(0).Item("syproductopack") = Pack.Value
    End Sub
    Private Sub Cb_Ciudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Ciudad.SelectedIndexChanged
        lparametros(0).Item("syciudad") = Cb_Ciudad.SelectedIndex
    End Sub

    Private Sub Ruta_ValueChanged(sender As Object, e As EventArgs) Handles Ruta.ValueChanged
        lparametros(0).Item("syruta") = Ruta.Value
    End Sub

    Private Sub LabelX16_Click(sender As Object, e As EventArgs) Handles LabelX16.Click

    End Sub

    Private Sub swcredito_ValueChanged(sender As Object, e As EventArgs) Handles swcredito.ValueChanged
        lparametros(0).Item("sycredito") = swcredito.Value
    End Sub
    Private Sub SwMapa_ValueChanged(sender As Object, e As EventArgs) Handles SwMapa.ValueChanged
        lparametros(0).Item("syvmapa") = SwMapa.Value
    End Sub
    Private Sub Swmodped_ValueChanged(sender As Object, e As EventArgs) Handles Swmodped.ValueChanged
        lparametros(0).Item("symodped") = Swmodped.Value
    End Sub
    Private Sub SwModCli_ValueChanged(sender As Object, e As EventArgs) Handles SwModCli.ValueChanged
        lparametros(0).Item("symodcli") = SwModCli.Value
    End Sub
    Private Sub SwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles swstocknega.ValueChanged
        lparametros(0).Item("systocknega") = swstocknega.Value
    End Sub
End Class