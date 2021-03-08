Imports System.Data.Entity.Core.EntityClient
Imports System.Data.SqlClient

Public Class ConnectionString
    Private Shared _connetionString As ConnectionString = Nothing
    Private _string As String = Nothing
    Private Shared _serverName As String
    Private Shared _port As String
    Private Shared _dataBase As String
    Private Shared _userId As String
    Private Shared _password As String

    Public Shared Sub SetParameters(serverName As String, port As String, dataBase As String, userId As String, password As String)
        _serverName = serverName
        _port = port
        _dataBase = dataBase
        _userId = userId
        _password = password
    End Sub

    Public Shared ReadOnly Property ConnetionString As String
        Get
            If (_connetionString Is Nothing) Then
                _connetionString = New ConnectionString()
                _connetionString._string = Connect()
            End If
            Return _connetionString._string
        End Get
    End Property

    Public Shared Function Connect() As String
        Dim sqlString = New SqlConnectionStringBuilder()
        'sqlString.DataSource = _serverName + "," + _port
        sqlString.DataSource = _serverName
        sqlString.InitialCatalog = _dataBase
        sqlString.UserID = _userId
        sqlString.Password = _password

        Dim entityString = New EntityConnectionStringBuilder()
        entityString.Provider = "System.Data.SqlClient"
        entityString.Metadata = "res://*/EntityDataModel.BDDistBHF.BDDistBHFModel.csdl|res://*/EntityDataModel.BDDistBHF.BDDistBHFModel.ssdl|res://*/EntityDataModel.BDDistBHF.BDDistBHFModel.msl"
        entityString.ProviderConnectionString = sqlString.ToString()

        Return entityString.ConnectionString
    End Function
End Class
