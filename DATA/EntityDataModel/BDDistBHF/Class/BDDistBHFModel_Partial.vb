Imports System.Data.Entity

Partial Public Class BDDistBHFEntities
    Inherits DbContext
    Public Sub New(connectionString As String)
        MyBase.New(connectionString)
    End Sub
End Class
