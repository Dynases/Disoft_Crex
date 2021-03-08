Imports UTILITIES

Public Class Form2
    Dim Archivo() As String = IO.File.ReadAllLines(Application.StartupPath + "\CONFIGSERVER.TXT")
    Private Sub MetroTileItem1_Click(sender As Object, e As EventArgs) Handles Mt1.Click
        gs_Ser = 0
        _prLeerArchivoConfig2()
    End Sub
    Private Sub MetroTileItem2_Click(sender As Object, e As EventArgs) Handles Mt2.Click
        gs_Ser = 1
        _prLeerArchivoConfig2()
    End Sub

    Private Sub MetroTileItem3_Click(sender As Object, e As EventArgs) Handles Mt3.Click
        gs_Ser = 2
        _prLeerArchivoConfig2()
    End Sub

    Private Sub MetroTileItem4_Click(sender As Object, e As EventArgs) Handles Mt4.Click
        gs_Ser = 3
        _prLeerArchivoConfig2()
    End Sub
    Private Sub _prLeerArchivoConfig2()
        'Dim Archivo() As String = IO.File.ReadAllLines(Application.StartupPath + "\CONFIGSERVER.TXT")
        'gs_Ip = Archivo(gs_Ser).Split(";")(1).Trim
        gs_Ip = Archivo(gs_Ser).Split(";")(2).Trim
        gs_UsuarioSql = Archivo(gs_Ser).Split(";")(3).Trim
        gs_ClaveSql = Archivo(gs_Ser).Split(";")(4).Trim
        gs_NombreBD = Archivo(gs_Ser).Split(";")(5).Trim
        gs_puerto = Archivo(gs_Ser).Split(";")(6).Trim
        gs_CarpetaRaiz = Archivo(gs_Ser).Split(";")(7).Trim

        ConnectionString.SetParameters(gs_Ip, gs_puerto, gs_NombreBD, gs_UsuarioSql, gs_ClaveSql)

        TextBoxX1.Text = gs_Ip.Trim + ":" + gs_puerto.Trim
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mt1.Text = Archivo(0).Split(";")(1).Trim
        Mt2.Text = Archivo(1).Split(";")(1).Trim
        Mt3.Text = Archivo(2).Split(";")(1).Trim
        Mt4.Text = Archivo(3).Split(";")(1).Trim
        Mt21.Text = Archivo(4).Split(";")(1).Trim
        Mt31.Text = Archivo(5).Split(";")(1).Trim
        Mt32.Text = Archivo(6).Split(";")(1).Trim
        Mt33.Text = Archivo(7).Split(";")(1).Trim
        Mt34.Text = Archivo(8).Split(";")(1).Trim
    End Sub

    Private Sub Mt21_Click(sender As Object, e As EventArgs) Handles Mt21.Click
        gs_Ser = 4
        _prLeerArchivoConfig2()
    End Sub

    Private Sub mT22_Click(sender As Object, e As EventArgs) Handles mT22.Click

    End Sub

    Private Sub Mt23_Click(sender As Object, e As EventArgs) Handles Mt23.Click

    End Sub

    Private Sub MT24_Click(sender As Object, e As EventArgs) Handles MT24.Click

    End Sub

    Private Sub Mt31_Click(sender As Object, e As EventArgs) Handles Mt31.Click
        gs_Ser = 5
        _prLeerArchivoConfig2()
    End Sub
    Private Sub Mt32_Click(sender As Object, e As EventArgs) Handles Mt32.Click
        gs_Ser = 6
        _prLeerArchivoConfig2()
    End Sub

    Private Sub Mt33_Click(sender As Object, e As EventArgs) Handles Mt33.Click
        gs_Ser = 7
        _prLeerArchivoConfig2()
    End Sub

    Private Sub Mt34_Click(sender As Object, e As EventArgs) Handles Mt34.Click
        gs_Ser = 8
        _prLeerArchivoConfig2()
    End Sub
End Class