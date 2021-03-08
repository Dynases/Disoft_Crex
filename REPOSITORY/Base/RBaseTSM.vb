Imports DATA
Imports UTILITIES

Public Class RBaseTSM
    Inherits RBasePrincipal(Of BDDistBHFEntities)

    Protected Overrides Function GetSchema() As BDDistBHFEntities
        Return New BDDistBHFEntities(ConnectionString.ConnetionString)
    End Function

    Private Shared _instance As RBaseTSM

    Public Shared ReadOnly Property Instance As RBaseTSM
        Get
            If _instance Is Nothing Then
                _instance = New RBaseTSM()
            End If

            Return _instance
        End Get
    End Property

End Class
